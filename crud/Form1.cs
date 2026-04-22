using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace crud
{
    public partial class frmCadastrodeClientes : Form
    {
        
        //Conexão com o banco de dados MySQL

        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; database=db_cadastro";

        private int? codigo_cliente = null;
        
        public frmCadastrodeClientes()
        {
            InitializeComponent();

            //Configuração inicial do ListView para exibição dos dados dos clientes
            lstCliente.View = View.Details; //Define a visualização em "Detalhes"
            lstCliente.LabelEdit = true; //Permite editar os títulos das colunas
            lstCliente.AllowColumnReorder = true; //Permite reordenar as colunas
            lstCliente.FullRowSelect = true; //Seleciona a linha inteira ao clicar
            lstCliente.GridLines = true; //Exibe as linhas de graede no ListView

            //Definindo as colunas no ListView
            lstCliente.Columns.Add("codigo", 100, HorizontalAlignment.Left); //Coluna do código
            lstCliente.Columns.Add("Nome completo", 200, HorizontalAlignment.Left); //Coluna de nome Completo
            lstCliente.Columns.Add("Nome Social", 200, HorizontalAlignment.Left); //Coluna nome Social
            lstCliente.Columns.Add("E-mail", 200, HorizontalAlignment.Left); //Coluna de E-mail
            lstCliente.Columns.Add("CPF", 200, HorizontalAlignment.Left); //Coluna de CPF

            //Carrega os dados dos clientes na interface
            carregar_clientes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validando campos obrigatórios
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                   string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                   string.IsNullOrEmpty(txtCPF.Text.Trim()))

                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.",
                                      "Validação",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return; //Impede o prosseguimento se algum campo estiver vazio
                }

                //Validação do CPF
                string cpf = txtCPF.Text.Trim();

                if (!isValidCPFLength(cpf))
                {
                    MessageBox.Show("CPF inválido. Certifique-se de que o CPF tenha 11 dígitos númericos.",
                        "Validação de CPF",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return; //Impede o prosseguimento se o CPF for inválido

                }

                //Cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Comando SQL para inserir um novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };

                if (codigo_cliente == null)
                {
                    //insert

                    cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf) " +
                        "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";

                    //Adiciona os parâmetros com os dados do formulário
                    cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                    cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());

                    //Executa o comando de inserção no banco
                    cmd.ExecuteNonQuery();

                    //Mensagem de sucesso
                    MessageBox.Show(
                        "Contato inserido com Sucesso: ",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    //update
                    cmd.CommandText = $"UPDATE `dadosdocliente` SET " +
                    $"nomecompleto = @nomecompleto, " +
                    $"nomesocial = @nomesocial, " +
                    $"email = @email, " +
                    $"cpf = @cpf " +
                    $"WHERE codigo = @codigo";

                    cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                    cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@codigo", codigo_cliente);

                    // Executa o comando de alteração no banco
                    cmd.ExecuteNonQuery();

                    // Mensagem de sucesso para dados atualizados
                    MessageBox.Show($"Os dados com o código {codigo_cliente} foram alterados com Sucesso!",
                         "Sucesso",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                }

                codigo_cliente = null;

                //Limpa os campos após o sucesso
                limpar_formulario();

                //Recarrega os clientes na ListView
                carregar_clientes();

                //Muda para a aba de consulta
                tabControl1.SelectedIndex = 1;
            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                //Trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            finally
            {
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                if(Conexao != null && Conexao.State == ConnectionState.Open) 
                {
                    Conexao.Close();
                }
            }
        }
        private bool isValidCPFLength(string cpf)
        {
            // Remove todos os caracteres não númericos

            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF tem exatamente 11 dígitos;

            return cpf.Length == 11;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dadosdocliente WHERE nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY codigo DESC";
            carregar_cliente_com_query(query);
        }

        private void carregar_cliente_com_query(string query)
        {
            try
            {
                //Cria a conecão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Executa a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta contém o parâmetro @q, adiciona o valor da caixa de pesquisa
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                //Executa o comando e obtém os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens existentes no ListView antes de adicionar novos
                lstCliente.Items.Clear();

                //Preenche o ListView com os daods dos clientes
                while (reader.Read())
                {
                    //Cria uma linha para cada cliente com os dados retornados da consulta
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)),//Código
                        reader.GetString(1),//Nome Completo
                        reader.GetString(2),//Nome Social
                        reader.GetString(3),//E-mail
                        reader.GetString(4),//CPF
                    };

                    //Adiciona a linha ao ListView
                    lstCliente.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //Trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            finally
            {
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }

        }

        private void carregar_clientes()
        {
            string query = "SELECT * FROM dadosdocliente ORDER BY codigo DESC";
            carregar_cliente_com_query(query);
        }

        private void lstCliente_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Obtém a coleçao de itens selecionados
            ListView.SelectedListViewItemCollection clientedaselecao = lstCliente.SelectedItems;

            //Percorre todos os itens selecionados (mesmo que normalmente só tenha um item selecionado)
            foreach(ListViewItem item in clientedaselecao)
            {
                codigo_cliente = Convert.ToInt32(item.SubItems[0].Text);

                //Exibe uma messageBox com o código do cliente
                MessageBox.Show("Código do cliente: " + codigo_cliente.ToString(),
                                "Código selecionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                //Preenche os campos de texto com os dados do cliente selecionado
                txtNomeCompleto.Text = item.SubItems[1].Text;
                txtNomeSocial.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
                txtCPF.Text = item.SubItems[4].Text;

                btnExcluirCliente.Visible = true;
            }
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            limpar_formulario();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            excluir_cliente();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            excluir_cliente();
        }

        private void excluir_cliente()
        {
            try
            {
                DialogResult opcaoDigitada = MessageBox.Show("Tem certeza que deseja excluir o registro de código" + codigo_cliente,
                                                              "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcaoDigitada == DialogResult.Yes)
                {
                    //Excluir no Banco de Dados
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    cmd.Prepare();

                    cmd.CommandText = "DELETE FROM dadosdocliente WHERE codigo = @codigo";

                    cmd.Parameters.AddWithValue("@codigo", codigo_cliente);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Os dados do cliente foram EXCLUIDOS!",
                                       "Sucesso",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);

                    limpar_formulario();

                    carregar_clientes();

                    //Muda para a aba de consulçta
                    tabControl1.SelectedIndex = 1;

                    btnExcluirCliente.Visible = true;
                }
            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //Trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            finally
            {
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }
        private void limpar_formulario()
        {
            codigo_cliente = null;

            txtNomeCompleto.Text = string.Empty;
            txtNomeSocial.Text = "";
            txtEmail.Text = "";
            txtCPF.Text = "";

            txtNomeCompleto.Focus();

            btnExcluirCliente.Visible = false;
        }
    }
}

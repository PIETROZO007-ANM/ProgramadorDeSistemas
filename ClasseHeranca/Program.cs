using classeHerenca;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeHerenca
{
    //classe base (superclasse)
    internal class Animal
    {
        //Propriedade da classe Animal
        public string Nome {  get; set; }

        //Método que será sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emite um som.");
        }
    }

    //Classe derivada (subclasse)
    internal class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: AU AU! ");
        }
    }
    //Outra classe derivada
    internal class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: Miau!");
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Animal meuCachorro = new Cachorro { Nome = "Rex" };
        Animal meuGato = new Gato { Nome = "Felix" };

        //Chamando o método EmitirSom para cada anomal
        meuCachorro.EmitirSom();
        meuGato.EmitirSom();

        //Ultilizando o Polimorfismo: Array de animais
        Animal[] animais = {meuGato,meuCachorro};

        foreach (var animal in animais)
        {
            animal.EmitirSom();
        }
    }
}

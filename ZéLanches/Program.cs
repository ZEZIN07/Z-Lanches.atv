using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZéLanches
{
    internal class Program
    {
        //struct
        struct Lanche
        {
            public string Nome;
            public string Preco;
            public string ID;

            public Lanche(string lanche, string preco, string id)//construtor da struct
            {
                Nome = lanche;
                Preco = preco;
                ID = id;

            }

            public void ExibirDados()
            {
                Console.WriteLine($"Lanche: {Nome} \nPreco.: {Preco} \nCodigo: {ID}");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("__BEM-VINDO AO ZÉ LANCHES__");

            Console.WriteLine("----------CARDAPIO----------");
            {
              
                List<Lanche> lanche = new List<Lanche>();
                lanche.Add(new Lanche("X-Bacon", "R$19.90", "030"));
                lanche.Add(new Lanche("X-Cheddar", "R$15.90", "040"));
                lanche.Add(new Lanche("X-Salada", "R$17.90", "050"));
                foreach (Lanche comida in lanche)
                {
                    comida.ExibirDados();
                    Console.WriteLine();
                }

                int comida = 10; 
                
                if (comida < 10)
                {
                    Console.WriteLine("Seu X-Bacon Já Está Sendo Preparado");
                }
                if (comida > 10)
                {
                    Console.WriteLine("Seu X-Cheddar Já Está Sendo Preparado");
                }
                if (comida == 10)
                {
                    Console.WriteLine("Seu X-Salada Já Está Sendo Preparado");
                }
          

                Console.ReadKey();

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace ExemploFundamentos.Common.Models { 


	public class Pessoa
	{
        public string? Nome { get; set; }

        public string? Profissao { get; set; }
        public int Idade { get; set; }



        public void Apresentar()
        {
           
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou {Profissao}");
        }
    }



}
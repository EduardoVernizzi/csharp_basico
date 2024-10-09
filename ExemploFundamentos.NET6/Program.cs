using ExemploFundamentos.NET6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFundamentos.NET6
{
   
//Do .NET 6 em diante, o modelo de projeto para novos aplicativos de console do C# gera o seguinte código no arquivo Program.cs:

//C#

//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//    A nova saída usa recursos recentes do C# que simplificam o código que você precisa escrever para um programa. Para o .NET 5 e versões anteriores, o modelo de aplicativo de console gera o seguinte código:

//C#

//using System;

//namespace MyApp // Note: actual namespace depends on the project name.
//    {
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("Hello World!");
//            }
//        }
//    }
//    Essas duas formas representam o mesmo programa.Ambos são válidos com C# 10.0. Ao usar a versão mais recente, você só precisa escrever o corpo do método Main. O compilador gera uma classe Program com um método de ponto de entrada e coloca todas as instruções de nível superior nesse método. O nome do método gerado não é Main, é um detalhe de implementação que seu código não pode referenciar diretamente. Você não precisa incluir os outros elementos do programa, o compilador os gera para você. Você pode saber mais sobre o código gerado pelo compilador ao usar instruções de nível superior no artigo sobre Instruções de nível superior, na seção de conceitos básicos do Guia do C#.

//Você tem duas opções para trabalhar com tutoriais que não foram atualizados para usar modelos do .NET 6+:

//Use o novo estilo de programa, adicionando novas instruções de nível superior à medida que você adiciona recursos.
//Converta o novo estilo de programa no estilo mais antigo, com uma classe Program e um método Main.
}

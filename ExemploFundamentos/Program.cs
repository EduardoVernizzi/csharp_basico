
using System;

//Vantagens da lista

List<string> listaString = new List<string>();

listaString.Add("São Paulo");
listaString.Add("Rio de Janeiro");
listaString.Add("Santa Catarina");
listaString.Add("Minas Gerais");

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Add("Alagoas");

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("Rio de Janeiro");

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");




//Implementação de Listas

//List<string> listaString = new List<string>();

//listaStringAdd("São Paulo");
//listaString.Add("Rio de Janeiro");
//listaString.Add("Santa Catarina");

//for(int i = 0; i < listaString.Count; i++)
//{
//    Console.WriteLine($"Posição nº{i} - {listaString[i]}");
//}

//Console.WriteLine("\nPercorrendo a lista com Foreach \n");

//int j = 0;

//foreach(string item in listaString)
//{
//    Console.WriteLine($"Posição nº{j} - {item}");
//    j++;
//}



//Copiando um Array para outro

//int[] arrayInteiros = new int[3];


//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;

////Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
//Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

//for (int i = 0; i < arrayInteiros.Length; i++)
//{
//    Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");

//}


////Redimensionando um array

//int[] arrayInteiros = new int[3];


//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//for (int i = 0; i < arrayInteiros.Length; i++)
//{
//    Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
//}


//Implementação de Foreach

//int[] arrayInteiros = new int[3];


//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;

//for (int i = 0; i < arrayInteiros.Length; i++)
//{
//    Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
//}

//Console.WriteLine("Percorrendo o Array como FOREACH");

//int j = 0;
//foreach (int valor in arrayInteiros)
//{

//    Console.WriteLine($"Posição nº {j} - {valor}");
//    j++;
//}


//Implementação de  Array

//int [] arrayInteiros = new int[3];


//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;

//for (int i = 0; i < arrayInteiros.Length; i++)
//{
//    Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
//}








//Utilizando classes em comum entre projetos

//using ExemploFundamentos.Common.Models;

//Pessoa pessoa1 = new Pessoa();
//pessoa1.Nome = "Eduardo Vernizzi";
//pessoa1.Idade = 25;
//pessoa1.Profissao = "Engenheiro civil";
//pessoa1.Apresentar();



//Introdução a laços de repetição

//string opcao;
//bool exibirMenu = true;

//while (exibirMenu)
//{

//    Console.WriteLine("Digite a sua opção: ");
//    Console.WriteLine("1 - Cadastrar cliente");
//    Console.WriteLine("2 - Buscar cliente");
//    Console.WriteLine("3 - Apagar cliente");
//    Console.WriteLine("4 - Encerrar");

//    opcao = Console.ReadLine();

//    switch (opcao)
//    {
//        case "1": 
//            Console.WriteLine("\nCadastro de cliente\n");
//            break;

//        case "2": 
//            Console.WriteLine("\nBusca de cliente\n");
//            break;

//        case "3": 
//            Console.WriteLine("\nApagar cliente\n");
//            break;

//        case "4": 
//            Console.WriteLine("\nEncerrar\n");
//            exibirMenu=false;
//            break;

//        default: Console.WriteLine("\nOpção inválida!\n");
//            break;
//    }
//}

//Console.WriteLine("O programa se encerrou!");



//int soma = 0, numero = 0;

//do
//{
//    Console.WriteLine($"Digite um número (0 para parar): ");
//    numero = Convert.ToInt32( Console.ReadLine() );
//    soma += numero;

//} while( numero != 0 );

//Console.WriteLine($"A soma dos números digitados é: {soma}");


//int numero = 5;
//int i = 0;

//while (i <= 10)
//{
//    Console.WriteLine($"{numero} x {i} = {numero * i}");
//    i++;

//    if(i == 6)
//    {
//        break;
//    }
//}


//int numero = 10;

//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine($"{numero} x {i} = {numero*i}");

//}



//Raiz Quadrada

//Calculadora calc = new Calculadora();
//calc.RaizQuadrada(144);


//Incremento e Decremento

//int numero = 10;

//Console.WriteLine(numero);
//Console.WriteLine("Incrementando o 10");
//numero++;
//Console.WriteLine(numero);

//Console.WriteLine($"Decrementando o {numero}");
//numero--;
//Console.WriteLine(numero);



////Funções trigonométricas

//Calculadora calc = new Calculadora();
//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente(30);


//Potencia

//Calculadora calc = new Calculadora();
//calc.Potencia(3, 3);


//Operadores aritméticos

//Calculadora calc = new Calculadora();
//calc.Somar(10, 30);
//calc.Subtrair(10, 50);
//calc.Multiplicar(15, 45);
//calc.Dividir(2, 2);


//Utilização do SWITCH CASE

//Console.WriteLine($"Digite uma letra: ");
//string letra = Console.ReadLine().ToUpper();
//switch (letra)
//{
//    case "A":
//    case "E":
//    case "I":
//    case "O":
//    case "U":
//        Console.WriteLine("Vogal");
//        break;   
//        default: 
//        Console.WriteLine("Não é vogal");
//        break;
//}


//Utilização de operadores lógicos

//Console.WriteLine($"Digite uma letra: ");
//string letra = Console.ReadLine().ToUpper();
//if (letra =="A" ||  letra =="E" || letra=="I" || letra =="O" || letra == "U")
//{
//    Console.WriteLine("Vogal");
//} else
//{
//    Console.WriteLine("Consoante");
//}

//Encadeamento de IF (IF aninhado)

//Console.WriteLine($"Digite uma letra: ");
//string letra = Console.ReadLine().ToUpper();
//if ( letra == "A")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "E")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "I")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "O")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "U")
//{
//    Console.WriteLine("Vogal");
//}
//else 
//{
//    Console.WriteLine("Não é Vogal");
//}

//Utilização do IF e ELSE

//int quantidadeEmEstoque = 10;
//int quantidadeCompra = 1;
//bool possivelVenda = quantidadeCompra>0 && quantidadeEmEstoque >= quantidadeCompra;
//Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
//Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
//Console.WriteLine($"É possível realizar a venda? {possivelVenda}");
//if (quantidadeCompra == 0)
//{
//    Console.WriteLine("Venda inválida!");
//}
//else if (possivelVenda)
//{
//    Console.WriteLine("Venda realizada!");
//}
//else
//{
//    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque!");
//}


//Conversão de tipos de variáveis

//string a = "15";
//int b = 0;
//int.TryParse(a, out b);
//Console.WriteLine(b);
//Console.WriteLine("Conversão feita com sucesso!!");
//double a = 4 / 2 + 2;
//Console.WriteLine(a);
//string a = 5.ToString();
//Console.WriteLine(a);
//int a = Convert.ToInt32("5");
//Console.WriteLine(a);
//int a = int.Parse("5");
//Console.WriteLine(a);


// Utilização do DateTime

//DateTime dataAtual = DateTime.Now;
//Console.WriteLine(dataAtual.AddDays(5));

//Conceitos básicos de criação de variáveis e instanciação de Classe.

//string apresentacao = "Olá, seja bem vindo!";
//int quantidade = 1;
//double altura = 1.85;
//decimal preco = 1.80m;
//bool condicao = true;
//Console.WriteLine(apresentacao);
//Console.WriteLine("O valor da variável quantidade é: " + quantidade);
//Console.WriteLine("O valor da variável altura é: " + altura.ToString("0.00"));
//Console.WriteLine("O valor da variável preço é: " + preco);
//Console.WriteLine("O valor da variável condição é: " + condicao);
//Pessoa pessoa1 = new Pessoa();
//pessoa1.Nome = "Carlos";
//pessoa1.Idade = 24;
//pessoa1.Apresentar();

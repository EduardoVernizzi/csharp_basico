
using ExemploFundamentos.Models;
using System.Data;



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

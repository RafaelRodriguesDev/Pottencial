using ExemploFundamentos.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome= "Rafael";
pessoa1.Idade = 28;
pessoa1.Apresentar();

// Pessoa Pessoa_FisicaRepresentacao = new Pessoa();

string apresentacao = "olá, seja bem vindo";

int quantidade = 1;

double altura = 1.00;

decimal preco = 1.00m;

bool condicao = true;

Console.WriteLine("O valor da variavel quantidade: "+ quantidade);
Console.WriteLine("O valor da variavel altura "+ altura );
Console.WriteLine("O valor da variavel preco "+ preco);
Console.WriteLine("O valor da variavel condicao "+ condicao);


DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

DateTime dataAtual2 = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual2);
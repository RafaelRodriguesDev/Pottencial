using ExemploFundamentos.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome= "Rafael";
pessoa1.Idade = 28;
pessoa1.Apresentar();
Console.WriteLine("#######################################");
// Pessoa Pessoa_FisicaRepresentacao = new Pessoa();
Console.WriteLine("########## Operadores Parte 1 #########");

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

Console.WriteLine("#######################################");
// tipo operadores em C#
Console.WriteLine("########## Operadores Parte 2 #########");

int a = 10;
int b = 20;

int c = a+b ;

c = c + 5 ;

int inteiro = 5;
string d = inteiro.ToString();

Console.WriteLine(c);
Console.WriteLine(d);


Console.WriteLine("#######################################");
// tipo operadores em C#
Console.WriteLine("########## Operadores Parte 3 #########");

int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

    Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}.");
    Console.WriteLine($"Qauntidade compra: {quantidadeCompra}");
    Console.WriteLine($"É possivel realizar a venda ? {possivelVenda}");

if(quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
if(possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}

Console.WriteLine("-----------------------------------------");

// switch case

Console.WriteLine("Digite uma Letra");
string letra = Console.ReadLine();

switch(letra)   
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

        default:
        Console.WriteLine("não é vogal");
        break;
}

Console.WriteLine("-----------------------------------------");

// operadores logicos

bool ehMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = false;
if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada!");
}
else{
    Console.WriteLine("Entrada não liberada");
}

Console.WriteLine("#######################################");
// tipo operadores aritimeticos
Console.WriteLine("########## Operadores Parte 4 #########");

Calculadora calc = new Calculadora();

calc.Somar(10,30);
calc.Subtrair(10,50);
calc.Multiplicar(15,45);
calc.Dividir(2,2);
calc.Potencia(3,3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);
int numero = 10;

Console.WriteLine(numero);

Console.WriteLine("incrementando o 10");
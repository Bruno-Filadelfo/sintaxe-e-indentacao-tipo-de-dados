using System.ComponentModel;
using Dio.models;

DateTime dataAtual = DateTime.Now.AddDays(2);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

Pessoa pessoas = new Pessoa();

pessoas.Nome = "Bruno";
pessoas.Idade = 28;
pessoas.Apresentar();

string apresentacao = "Olá, seja bem vindo!";
int quantidade = 10;
double altura = 1.80;
decimal largura = 1.88M;
bool condicao = true;

Console.WriteLine("Valor da variavel apresentação: " + apresentacao);
Console.WriteLine("Valor da variavel quantidade: " + quantidade);
Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variavel largura: " + largura);
Console.WriteLine("Valor da variavel condição: " + condicao);

//Combinando Operadores
int a = 10;
int b = 20;
int c = 10 + 20;
c = c + 5;
c -= 2;

Console.WriteLine(c);

//Cast - Casting
int d = Convert.ToInt32("5");
Console.WriteLine(d);

int e = int.Parse("5");
Console.WriteLine(e);


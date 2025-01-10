using System.ComponentModel;
using Dio.models;

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
Console.WriteLine("Valor da variavel altura: " + altura);
Console.WriteLine("Valor da variavel largura: " + largura);
Console.WriteLine("Valor da variavel condição: " + condicao);

using System;
using System.Collections.Generic;
using System.Linq;
//Exercício 01
//Console.WriteLine("Digite um número inteiro :");
//int num = Convert.ToInt32(Console.ReadLine());
//int result = 1;
//int aux = num;
//while (num != 1)
//{
//    result += result *( num -1);

//    num = num - 1;
//}

//Console.WriteLine($"O Fatorial de {aux} é igual á {result}");
//Console.WriteLine("Digite um número para calcular o seu fatorial :");
//long numero = Convert.ToInt32(Console.ReadLine());
//long fatorial = 1;

//for (int i=1; i<=numero; i++)
//{
//    fatorial = fatorial * i;
//    Console.WriteLine(fatorial);
//}
//Console.WriteLine($"O fatorial de {numero} é {fatorial}");


//Exercício 02

//List<int> numeros= new List<int>();
//string opcao = "S";
//while(opcao == "S")
//{
//    Console.WriteLine("Digite um número para inserir na lista :");
//    int num = Convert.ToInt32(Console.ReadLine());
//    numeros.Add(num);
//    Console.WriteLine("Deseja continuar ? (Sim / Não)");
//    opcao = Console.ReadLine();
//    opcao = opcao.ToUpper();
//    opcao.FirstOrDefault();
//}

//numeros.Sort();
//int result = 0;
//foreach(int n in numeros)
//{
//    result = n;
//}

//Console.WriteLine($" maior valor é {result}");



Console.WriteLine("Quantos valores você deseja adicionar ao array ?");
int quant = Convert.ToInt32(Console.ReadLine());
int[] values = new int[quant];


for (int i = 0;i < quant; i++)
{
    Console.WriteLine($"Adicione o {i + 1}º valor:");
    values[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(values);

Console.WriteLine("[{0}] {1}",string.Join(", ", values), "lista ordenada !!");
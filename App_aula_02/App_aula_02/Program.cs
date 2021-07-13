using System;

Console.WriteLine("Digite um número inteiro :");
int num = Convert.ToInt32(Console.ReadLine());
int result = 1;
int aux = num;
while (num != 1)
{
    result += result *( num -1);
    
    num = num - 1;
}

Console.WriteLine($"O Fatorial de {aux} é igual á {result}");
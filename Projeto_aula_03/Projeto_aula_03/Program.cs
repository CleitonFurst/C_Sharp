using System;

// double Soma(double n1, double n2){

//    return n1 + n2;

//}

//int n = 5;
//int res = 1;

//for (int i = 1; i <= 5; i++) res *= i; 

//while (n > 1)
//{
//    res *= n;
//    n--;
//}


//int fatorial (int n)
//{
//    return n == 1 ? 1 : n * fatorial(n - 1);
//}

//int fatorial2(int n)=> n == 1 ? 1 :n * fatorial2(n - 1);


int soma(int num1 = 1, int num2 = 1)
{
    return num1 + num2;
}

Console.WriteLine(soma());
Console.WriteLine(soma(num1: 5));
Console.WriteLine(soma(num2: 5));
Console.WriteLine(soma(5));
Console.WriteLine(soma(5, 4));

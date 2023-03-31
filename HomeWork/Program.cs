// HomeWork

/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

if(a > b){
    Console.WriteLine("max = " + a);
}else{
    Console.WriteLine("max = " + b);
}
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
Console.Write("a = ");
int a1 = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("c = ");
int c1 = int.Parse(Console.ReadLine());
if(a1 > b1){
    if(a1>c1){Console.WriteLine("max = " + a1);}
    if(a1<c1){Console.WriteLine("max = " + c1);}
    if(a1==c1){Console.WriteLine("max = " + c1);}
}else if(b1 > a1){
    if(b1>c1){Console.WriteLine("max = " + b1);}
    if(b1<c1){Console.WriteLine("max = " + c1);}
    if(b1==c1){Console.WriteLine("max = " + c1);}
}else if(b1 == a1){
    if(b1>c1){Console.WriteLine("max = " + b1);}
    if(b1<c1){Console.WriteLine("max = " + c1);}
    if(b1==c1){Console.WriteLine("max = " + c1);}
}
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/
Console.Write("a = ");
int a2 = int.Parse(Console.ReadLine());
int b2 = a2 % 2;
if(b2 == 0){
    Console.WriteLine("Число четное!");
}else{
    Console.WriteLine("Число нечетное!");
}
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
for (int i=2; i<N+1; i = i+2){
        Console.Write(i + ", ");
}
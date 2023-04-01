// HomeWork 2

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
int b = a/10;
int c = b%10;
 Console.WriteLine("Вторая цифра числа - " + c);
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
Console.Write("b = ");
int a1 = int.Parse(Console.ReadLine());
int b1 = a1%10;
int c1 = a1/100;
if(c1>0){Console.WriteLine("Третья цифра числа - " + b1);}else{
    Console.WriteLine("Нет третьей цифры");
}

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
Console.Write("День недели = ");
int DW = int.Parse(Console.ReadLine());
if (DW == 6 || DW == 7){
    Console.Write("-> Да");
}else{
 Console.Write("-> Нет");
}
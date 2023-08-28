// Задачи находятся в ветках:
// Задача 1 - ветка "main"
// Задача 2 - ветка "vetka 2"
// Задача 3 - ветка "vetka 3"


//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void Number()
{
int A=int.Parse(Console.ReadLine());
int B=int.Parse(Console.ReadLine());
int degree=1;
for (int i = 1; i <= B; i++)
	{
        degree = degree * A;
   	}
Console.WriteLine(degree);
}
Number();
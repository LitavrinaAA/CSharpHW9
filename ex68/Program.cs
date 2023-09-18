//Задача 68: Напишите программу вычисления 
//функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
int InputNum(string mess){
    System.Console.WriteLine(mess);

     return int.Parse(Console.ReadLine()!); 
}
// функция Аккермана
int Akkerman( int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
int m = InputNum("Input m:");
int n = InputNum("Input n:");
if ((m > 0)&&(n>0))
System.Console.WriteLine(Akkerman(m,n));
else
System.Console.WriteLine("Ошибка. Введите неотрицательные числа.");
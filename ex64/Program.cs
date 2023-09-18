// Задача 64: Задайте значение N. 
//Напишите программу, которая 
//выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputNum(string mess){
    System.Console.WriteLine(mess);

     return int.Parse(Console.ReadLine()!); 
}
string PrintNumbers(int n, string text){
    if (n > 0){  
        text += n + " ";  
        text = PrintNumbers(n-1, text);          
    }    
    return text;
}
int num = InputNum("Input number:");
System.Console.WriteLine(PrintNumbers(num, ""));
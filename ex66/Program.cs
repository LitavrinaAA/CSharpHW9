// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int InputNum(string mess){
    System.Console.WriteLine(mess);

     return int.Parse(Console.ReadLine()!); 
}
int PrintNumbers(int m, int n, int sum){
    if (n >= m){          
        
        sum += n;        
        sum = PrintNumbers(m, n-1, sum);    
              
    }    
    return sum;
}


int m = InputNum("Input M:");
int n = InputNum("Input N:");
System.Console.WriteLine(PrintNumbers(m,n,0));

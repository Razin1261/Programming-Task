// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int i,j;
      Console.Write("Enter the Number : ");
      int n=Convert.ToInt32(Console.ReadLine());
      
      for(i=1;i<=n;i++)
      {
          for(int k = 1; k < n-i+1; k++){
             Console.Write(" ");
          }
          for(j=1;j<=i;j++)
          {
              Console.Write("* ");
          }
          Console.Write("\n");
      }
      
    }
}
using System;
public class Conditions{
    public static void Main (string[] args)
     {
    int num1,num2;
       Console.WriteLine("COMPARISON");
    Console.Write("Enter First Number");
     num1=Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Second Number");
     num2=Convert.ToInt32(Console.ReadLine());
     if(num1>num2)
      {
       Console.WriteLine("Welcome ,Successful");
      }
     else
      {
       Console.WriteLine("PLease Try Next Time");
      }
    }


}

using System;
public class Addition
{
    public static void Main( string[] args )
     {
     int number1,number2,sum; 
  
Console.Write( "Enter first integer: " ); // prompt user

number1 = Convert.ToInt32( Console.ReadLine() );
Console.Write( "Enter second integer: " ); // prompt user

number2 = Convert.ToInt32( Console.ReadLine() );
sum = number1 + number2; 
Console.WriteLine( "Sum is {0}", sum ); 
} 
} 

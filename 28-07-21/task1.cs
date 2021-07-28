using System;

class task1{
    public static void Main(){
        Console.WriteLine("Enter units used");
        int num1=Convert.ToInt32(Console.ReadLine());
        int sum;
	if(num1 <=200){
	sum= num1*2;
	Console.WriteLine(""+sum);
        }
	if(num1 >=201 && num1<=350){
	sum= 200*2+(num1-200)*3;
        Console.WriteLine(""+sum);
	}
	if(num1 >=351 && num1<=500){
	sum= 200*2+150*3+(num1-350)*5;
        Console.WriteLine(""+sum);
	}
	if(num1>500){
	sum= 200*2+150*3+150*5+(num1-500)*7;
        Console.WriteLine(""+sum);
	}
}
}
using System;
class task2{
	public static void Main(){
			
	Console.WriteLine("Enter the number");
	int num1=Convert.ToInt32(Console.ReadLine());
	int mul;
	for(int i=1;i<=20;i++)
	{
		mul=i*num1;
		Console.WriteLine(num1+"*"+i+"="+mul);
	}
}
}
using System;

class task2{
    public static void Main(){
        Console.WriteLine("Enter Your Cgpa");
        double num1=Convert.ToDouble(Console.ReadLine());
	double aps;
	double tech;
	double hr;
	if(num1 >=7)
	{
		Console.WriteLine("You are eligible for aps");

		Console.WriteLine("Enter Your aps mark");
		aps=Convert.ToDouble(Console.ReadLine());
	        if(aps >= 7)
			Console.WriteLine("You are selected for technical Interview");
		else
			Console.WriteLine("Try after 6 Months");
		Console.WriteLine("Enter Your tech mark");
		tech=Convert.ToDouble(Console.ReadLine());
		if(tech >= 7)
			Console.WriteLine("You are selected for Hr Interview");
		else
			Console.WriteLine("Try after 3 months");
		Console.WriteLine("Enter Your H.r mark");
		hr=Convert.ToDouble(Console.ReadLine());
		if(hr >= 7)
			Console.WriteLine("Congradulation You are selected");
		else
			Console.WriteLine("Sorry try next time");
	}
	else
	{
		Console.WriteLine("Not eligible");
	}
}
}
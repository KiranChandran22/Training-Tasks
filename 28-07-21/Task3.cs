using System;

class task3{
    public static void Main(){
        Console.WriteLine("Enter Your age");
        double num1=Convert.ToDouble(Console.ReadLine());
	if(num1<=16){
		Console.WriteLine("You should contact a Paediatric doctor");	
		}
	else{
		Console.WriteLine("You should contact a adult doctor");
	}	
}
}
using System;
class task3{
	public static void Main(){
				
	Console.WriteLine("Enter your choice of package A,B,C");
	String package=Console.ReadLine();
	switch(package){
	case "A":Console.WriteLine("Your package has Youth special,Children's club and movies and the cost is 250rs");
		break;
	case "B":Console.WriteLine("Your package has Movie,sports,news and regional-2 Channels, the cost is 450rs");	
		break;
	case "C":Console.WriteLine("Your package has Discovery,History and national, the cost is 350rs");
		break;
	default:Console.WriteLine("Enter a valid package");
		break;
}
}


}

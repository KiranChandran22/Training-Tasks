using System;
class task4{
	public static void Main(){
	double tot=0;
	double percent;
	int[]arr= new int[5];
        Console.WriteLine("Enter your marks");
	for(int i=0;i<5;i++)
	{
		arr[i]=Convert.ToInt32(Console.ReadLine());
	}		
	foreach(int i in arr)
	{
		tot=tot+i;
	}
		percent= (tot/500)*100;
		Console.WriteLine("percent="+percent+" total="+tot);
}
}

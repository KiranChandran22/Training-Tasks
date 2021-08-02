using System;
class polymph
{
public void login(String str1, String str2)
{
String mail=str1;
String pass=str2;
if(mail==pass)
Console.WriteLine("welcome "+mail);
else
Console.WriteLine("Wrong entry"+mail);
}
public void login(int n1,int n2)
{
int num1=n1;
int num2=n2;
if(num1==num2)
Console.WriteLine("Welcome "+num1 );
else
Console.WriteLine("Wrong entry"+num1);
}


public void login(double n1, int n2)
{
double num1=n1;
int num2=n2;
if(n1==n2)
Console.WriteLine("Welcome "+n1);
else
Console.WriteLine("Wrong entry "+n1);
}

public static void Main()
{
polymph obj = new polymph();
obj.login(12345.6,123456);
}
}
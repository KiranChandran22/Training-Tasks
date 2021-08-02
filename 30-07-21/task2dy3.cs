using System;
class VAT
{
public void vati(double x)
{
double num1=x;
double vatpercent=(12/100)*num1;
Console.WriteLine("Value added tax for the product is "+vatpercent);
}
}
class GST : VAT
{
public void gsti(double x)
{
double num1=x;
double gstpercent=20/100*num1;
Console.WriteLine("The Gst for the product is "+gstpercent);
}
}
class implementClass
{
public static void Main()
{
GST mobj = new GST();
mobj.gsti(1000);
mobj.vati(1000);
}
}
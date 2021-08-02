using System;
class VAT
{
public void vati(int x)
{
int num1=x;
int vatpercent=(12/100)*num1;
Console.WriteLine("Value added tax for the product is "+vatpercent);
}
}
class GST : VAT
{
public void gsti(int x)
{
int num1=x;
int gstpercent=20/100*100;
Console.WriteLine("The Gst for the product is "+gstpercent);
}
}
class implementClass
{
public static void Main()
{
GST mobj = new GST();
mobj.gsti(100);
mobj.vati(100);
}
}
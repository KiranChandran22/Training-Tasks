using System;
abstract class respack
{
public abstract void packages();
public void select()
{
Console.WriteLine("Select your package number");
}
}
class silver: respack
{
public override void packages()
{
Console.WriteLine("3 days accomodation at resort");
}
}
class gold:respack
{
public override void packages()
{
Console.WriteLine("5 days accomodation at resort with 2 dinners on the house");
}
}
class diamond:respack
{
public override void packages()
{
Console.WriteLine("7 days accomodation at resort with 5 dinners on the house");
}
}
class AbsProg
{
public static void Main()
{
Console.WriteLine("Select your package number");
int num=Convert.ToInt32(Console.ReadLine());
if(num==3)
{
silver sobj=new silver();
sobj.packages();
}
if(num==5)
{
gold gobj=new gold();
gobj.packages();
}
if(num==7)
{
diamond dobj=new diamond();
dobj.packages();
}
}
}
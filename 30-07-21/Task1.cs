using System;
class addsub
{
int sum,sub=0;
public void addisubt(int x,int y)
{
int num1=x;
int num2=y;
sum=num1+num2;
sub=num1-num2;
Console.WriteLine("sum is "+sum+" difference is "+sub);
}
}
class muldiv : addsub
{
public void multidivi(int x, int y)
{
int num1=x;
int num2=y;
int mul,div;
mul=num1*num2;
div=num1/num2;
Console.WriteLine("Product is "+mul+" quotient is "+div);
}
}
class implementClass
{
public static void Main()
{
muldiv mobj = new muldiv();
mobj.addisubt(60,20);
mobj.multidivi(60,20);
}
}
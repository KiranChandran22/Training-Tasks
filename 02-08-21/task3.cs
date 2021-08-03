using System;
class employee
{
public int empid;
public String empname;
public String empgender; 
public int empage;
public int empyof;
public int sal;
public employee(int ei, String en, String eg,int eage,int eof,int sa)
{
empid=ei;
empname=en;
empgender=eg;
empage=eage;
empyof=eof;
sal=sa;
}
}
class Salary
{
double salar=0;
String depart;
public employee adobj;
public Salary(String dept, employee Employee)
{
depart=dept;
adobj = Employee;
if(depart=="m"){
	salar=(20.0/100)*adobj.sal;
}
if(depart=="p")
	salar=(10.0/100)*adobj.sal;
}
public void DisplayDetails()
{
Console.WriteLine($"Employees Name : {adobj.empname} and increase : {salar}");
}
public static void Main()
{
employee adj = new employee(1,"Kiran","male", 21 , 0,100);
Salary eobj = new Salary("m", adj);
eobj.DisplayDetails();
}

}
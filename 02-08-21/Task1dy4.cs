using System;

 

class Members
{
    public string Name;
    public int Age;
    public Members(string name, int age)
    {
      Name = name;
      Age = age;
      Console.WriteLine("Member name is " + Name + " & age is " + Age);
    }
}
class MemberDetails
{
    string Mname;
    int Mage;
    public MemberDetails(string MemName, int MemAge)
    {
        Mname = MemName;
        Mage = MemAge;
    }
    public void Display()
    {
        Console.WriteLine($"Member Name : {Mname} and age is : {Mage}");
    }
    public static void Main()
    {
        MemberDetails md = new MemberDetails("Kiran", 21);
        Console.WriteLine($"Member name is {md.Mname}");
        Console.WriteLine($"Member age is {md.Mage}");
    }
}
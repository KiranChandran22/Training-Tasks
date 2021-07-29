using System; 
class Jarray
{
public static void Main()
{
String [][] Prodcat = new String[3][];
Prodcat[0] = new String[4]{"Bourborn","darkfantasy","marie gold","sunfeast"};
Prodcat[1] = new String[5]{"Dairy milk","kitkat","ferro roacher","melody","center"};
Prodcat[2] = new String[6]{"British","Kingfish","1868","maaza","sprite","coco cola"};
for(int i =0;i<Prodcat.Length;i++)
{
	for(int j=0;j<Prodcat[i].Length;j++)
	Console.Write(Prodcat[i][j] +"\t");
Console.WriteLine();
}
}
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    class Colec
    {


        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(" WHITE CHOCOLATE RASPBERRY CHEESECAKE");
            al.Add(" BAKLAVA");
            al.Add("LEMON CAKE DOBERGE");
            al.Add(" MOLTEN CHOCOLATE LAVA CAKE");
            al.Add("CHOCOLATE FONDUE");
            FileStream fs = new FileStream("D:\\Inatech\\03-08-21\\Fyle1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter swr = new StreamWriter(fs);
            foreach (var i in al)
                swr.Write(i);
            swr.Flush();
            swr.Close();
            fs.Close();

            FileStream fr = new FileStream("D:\\Inatech\\03-08-21\\Fyle1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fr);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(
                sr.ReadToEnd());
            sr.Close();
            fr.Close();
            FileInfo f1 = new FileInfo("D:\\Inatech\\03-08-21\\Fyle1.txt");

            Console.WriteLine(f1.Length);
            Console.WriteLine(f1.CreationTime);
            Console.Read();
        }



    }

}

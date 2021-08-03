using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace ConsoleApp1
{
    [Serializable]
    class Seria
    {
        int id;
        String name;
        String gender;
        int age;
        public Seria(int id, String name, String gender, int age)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
            this.age = age;
        }
        
        
        public static void Main()
        {
            Seria sclass = new Seria(24, "Kiran Chandran", "male", 21);

            FileStream fs = new FileStream("D:\\Inatech\\03-08-21\\Serial.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, sclass);
            fs.Close();


            FileStream fr = new FileStream("D:\\Inatech\\03-08-21\\Serial.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter br = new BinaryFormatter();

            Seria sc = (Seria)br.Deserialize(fr);
            Console.WriteLine(sc.name);
            Console.WriteLine(sc.age);
            Console.WriteLine(sc.gender);
            Console.WriteLine(sc.id);
            fs.Close();
            Console.Read();
        }
    }
}

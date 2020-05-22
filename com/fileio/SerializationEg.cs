using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpWay.com.fileio
{
    [Serializable()]
    class Usr
    {
        public int age { get; set; }
        public string name { get; set; }

        public Usr(int a, string n)
        {
            age = a;
            name = n;
        }
        public override string ToString() => $"Object Values : {age} {name}";

    }

    class SerializationEg
    {
        public static string fpath = @"D:\MyCloud\myworkspace\CSharpWay\com.fileio\fileinfo.txt";

        static void SerializeIt()
        {
            Usr obj = new Usr(10, "John");
            Console.WriteLine("Before: " + obj);

            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }

            //serialization
            Stream stream = File.Open(fpath, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, obj);
            stream.Close();
            Console.WriteLine("Serialization Successful ....");
        }



        static void DeserializeIt()
        {
            //de-serialization
            Stream stream = File.Open(fpath, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Usr obj = (Usr)bf.Deserialize(stream);
            stream.Close();

            Console.WriteLine("... Deserialization");
            Console.WriteLine("After: " + obj);
        }
         
        public static void main(string[] args)
        {
            SerializeIt();
            DeserializeIt();
        }
    }
}

using System;

namespace CSharpWay
{
    class ThrowMe
    {

        public static string GetUserAddress(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Name is empty");
            }
            else
            {
                return "Coutry Road";
            }
        }

        static void main(string[] args)
        {
            string address = "";
            try
            {
                //address = GetUserAddress("John");
                address = GetUserAddress("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Address: " + address);
        }
    }
}

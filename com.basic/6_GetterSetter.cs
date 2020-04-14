using System;

//https://codeasy.net/lesson/properties
namespace CSharpWay
{
    class MyUser
    {
        public MyUser()
        {
        }

        public MyUser(string name, string occupation)
        {
            this.name = name;
            this.occupation = occupation;
        }

        public string name { get; set; }

        public string occupation { get; set; }

        public override string ToString() => $"{name} {occupation}";
    }

    class MyUserTestClass
    {
        static void main(String[] args)
        {
            MyUser obj1 = new MyUser("John", "Runner");
            Console
                .WriteLine("Details1 = " + obj1.name + " : " + obj1.occupation);

            MyUser obj2 = new MyUser();

            //setter
            obj2.name = "Dan";
            obj2.occupation = "Swimmer";

            //getter
            Console
                .WriteLine("Details2 = " + obj2.name + " : " + obj2.occupation);
        }
    }
}

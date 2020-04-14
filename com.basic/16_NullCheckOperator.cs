using System;

namespace CSharpWay
{
    class User
    {
        public User()
        {
        } //Default Constructor

        public User(string name, string occupation)
        {
            this.name = name;
            this.occupation = occupation;
        }

        public string name { get; set; }

        public string occupation { get; set; }

        public override string ToString() => $"{name} {occupation}";
    }

    class NullCheck
    {
        public static void NullConditionalCheck1()
        {
            var users =
                new List<User>()
                {
                    new User("John Doe", "gardener"),
                    new User(),
                    new User("Lucia Newton", "teacher")
                };

            users.ForEach(user => Console.WriteLine(user.name?.ToUpper()));
        }

        public static void NullConditionalCheck2()
        {
        }

        static void main(String[] args)
        {
        }
    }
}

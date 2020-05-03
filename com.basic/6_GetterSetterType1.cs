using System;

//https://codeasy.net/lesson/properties

/**
  Properties:
  In C# we have properties feature unlike Java
  

  #property declaration
  public string age { get; set; }
 
  #what compiler read it  
  private int _age;

  public int GetAge()
  {
    return _age;
  }

  public void SetAge(int age)
  {
    _age = age;
  }

  Note: We cant call obj.GetAge() 
  
 */

namespace CSharpWay
{
    class MyUser
    {
        //name, occupation not declared explicitly
        //get,set will declare it implicitly
        public string name { get; set; }
        public string occupation { get; set; }

        public override string ToString() => $"Object Values : {name} {occupation}";
    }

    class MyUserTestClass
    {
        static void main(String[] args)
        {
            MyUser mu = new MyUser();
            mu.name = "John";
            mu.occupation = "Salaried";
            Console.WriteLine(mu);
            //Console.WriteLine(mu.GetName());  these methods are not implicit
            //Console.WriteLine(mu.SetName());
        }
    }
}

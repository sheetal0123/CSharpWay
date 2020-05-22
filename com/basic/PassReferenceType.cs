using System;

namespace CSharpWay
{

    class EmpId
    {
        public int id;
    }

    class PassReferenceType
    {
        static void UpdateEmpId(EmpId emp)
        {
            emp.id = 50;
            Console.WriteLine("Updated: "+ emp.id);
        }

        static void main(string[] args)
        {
            EmpId emp = new EmpId();
            emp.id = 30;
            Console.WriteLine("Initial: "+ emp.id);

            UpdateEmpId(emp);
            Console.WriteLine("After Update: " + emp.id);
        }
    }
}

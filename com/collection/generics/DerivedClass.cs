using System;
using System.Collections.Generic;

namespace CSharpWay
{
    class DerivedClass<T> : GenericClass<T>
    {
        //implementation
        //DC is Generic hence Parent class can be Generic
    }

    //class DerivedClassString : GenericClass<T>
    class DerivedClassString : GenericClass<string>
    {
        //implementation
        //DC is NOT Generic hence Parent cant be Generic
    }

}

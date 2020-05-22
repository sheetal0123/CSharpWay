using System;
using System.Collections.Generic;
using System.Text;

/*
 * Here we suggest T can only be a class/reference 
 * not primitive/value type like int
 * 
 * Same constraint can also be applied on Methods
 */
namespace CSharpWay.com.collection.generics
{
    class GenericClassWithConstraint<T> where T:class
    {
        //code

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public class DerivedClass : BaseClass
    {
      public override String Method1()
      {
          return "Derived class overriden Method 1";
      }
      public new String Method2()
      {
          return "Derived class hidden  Method 2";
      }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
     public class BaseClass
    {
      public virtual String Method1()
      {
        return "Base class overridable Method 1";
      }
      public String Method2()
      {
        return "Base class hideable Method 2";
      }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityExample.Logic
{
  public interface IBusinessLogic
  {
    string[] Foo();
  }

  public class BusinessLogic : IBusinessLogic
  {
    private string value;

    public BusinessLogic(string value)
    {
      this.value = value;
    }

    public string[] Foo()
    {
      return new string[] { value, value, value };
    }
  }
}
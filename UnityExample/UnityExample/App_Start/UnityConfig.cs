using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using UnityExample.Logic;

namespace UnityExample
{
  public static class UnityConfig
  {
    public static void RegisterComponents()
    {
      var container = new UnityContainer();

      container.RegisterType<IBusinessLogic, BusinessLogic>(new InjectionMember[] { 
        new InjectionConstructor("foo")
      });

      GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
    }
  }
}
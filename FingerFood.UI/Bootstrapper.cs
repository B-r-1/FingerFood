
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Unity.Mvc4;
using System.Web.Http;
using System.Web.Mvc;

namespace FingerFood.UI
{
  public static class Bootstrapper
  {
      public static IUnityContainer Initialise()
      {
          var container = BuildUnityContainer();

          DependencyResolver.SetResolver(new UnityDependencyResolver(container));
          GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

          return container;
      }

      private static IUnityContainer BuildUnityContainer()
      {
          var container = new UnityContainer();
          container.LoadConfiguration();

          return container;
      }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}
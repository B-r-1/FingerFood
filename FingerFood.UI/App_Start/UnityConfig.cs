using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Unity.WebApi;
using System.Web.Http;

namespace FingerFood.UI.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {

        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}

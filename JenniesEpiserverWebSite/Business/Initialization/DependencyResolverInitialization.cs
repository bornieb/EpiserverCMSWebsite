using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web.Mvc;

namespace JenniesEpiserverWebSite.Business.Initialization
{
    [InitializableModule]
    public class DependencyResolverInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.Locate.Advanced));
        }

        public void Uninitialize(InitializationEngine context)
        {

        }
    }
}
using BLL;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;

namespace UI
{
    /// <summary>
    /// Acceso al contenedor de IoC.
    /// </summary>
    public static class IoCContainerLocator
    {

        /// <summary>
        /// Instancia lazy del contenedor de IoC.
        /// </summary>
        private static readonly Lazy<IUnityContainer> cInstance = new Lazy<IUnityContainer>(() =>
        {

            IUnityContainer mUnityContainer = new UnityContainer()
                .RegisterType<IRssReader, RawXmlRssReader>(new ContainerControlledLifetimeManager())
                .RegisterType<IBannerService, BannerService>(new ContainerControlledLifetimeManager())
                .RegisterType<ICampaignService, CampaignService>(new ContainerControlledLifetimeManager());

            return mUnityContainer;
        });

        public static IUnityContainer Container
        {
            get { return cInstance.Value; }
        }

    }

}

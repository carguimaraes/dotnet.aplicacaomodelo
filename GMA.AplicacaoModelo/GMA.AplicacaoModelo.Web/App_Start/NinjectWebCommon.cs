[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(GMA.AplicacaoModelo.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(GMA.AplicacaoModelo.Web.App_Start.NinjectWebCommon), "Stop")]

namespace GMA.AplicacaoModelo.Web.App_Start
{
 using System;
 using System.Web;
 using System.Web.Http;
 using GMA.AplicacaoModelo.Dominio.Repositorios;
 using GMA.AplicacaoModelo.Infra;
 using GMA.AplicacaoModelo.Web.Servicos;
 using Microsoft.Web.Infrastructure.DynamicModuleHelper;
 using Ninject;
 using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(kernel);
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
         //TODO melhorar
         GMA.AplicacaoModelo.Infra.Map.SetMap(kernel);
         //TODO retuirar deste modulo e padronizar MAPs
         kernel.Bind<LojaServico>().ToSelf();
        
         //

        }        
    }
}

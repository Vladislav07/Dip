using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using SkadTechDomain;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using Moq;

namespace Skadtech.Web.Infrastructure
{

    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext
            requestContext, Type controllerType)
        {

            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            

           // ninjectKernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}

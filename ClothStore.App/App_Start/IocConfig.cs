using Autofac;
using Autofac.Integration.Mvc;
using ClothStore.App.Controllers;
using ClothStore.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothStore.App.App_Start
{
    public class IocConfig
    {
        public static void ConfigIoc()
        {

            var containerBuild = new ContainerBuilder();
            containerBuild
                .RegisterControllers(typeof(MvcApplication).Assembly)
                .PropertiesAutowired();

            containerBuild.RegisterInstance<EFProductRepo>(new EFProductRepo())
                .PropertiesAutowired();

            containerBuild.RegisterInstance<EFDbContext>(new EFDbContext())
                .PropertiesAutowired();
            var build = containerBuild.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(build));
        }




    }
}
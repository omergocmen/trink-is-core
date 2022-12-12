using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;

namespace Business.DependencyResolvers.Autofac
{
    //Bu yapı IoC için context yapımız içerisindeki objeleri üretiyor ve context yapısına kayıt ediyor
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<ApplicationManager>().As<IApplicationService>().SingleInstance();
            builder.RegisterType<EfApplicationDal>().As<IApplicationDal>().SingleInstance();

            builder.RegisterType<CandidateManager>().As<ICandidateService>().SingleInstance();
            builder.RegisterType<EfCandidateDal>().As<ICandidateDal>().SingleInstance();

            builder.RegisterType<EmployerManager>().As<IEmployerService>().SingleInstance();
            builder.RegisterType<EfEmployerDal>().As<IEmployerDal>().SingleInstance();

            builder.RegisterType<JobAnnouncementManager>().As<IJobAnnouncementService>().SingleInstance();
            builder.RegisterType<EfJobAnnouncementDal>().As<IJobAnnouncementDal>().SingleInstance();

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}

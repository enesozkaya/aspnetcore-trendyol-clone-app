using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Clone.Bussiness.Abstract;
using Trendyol.Clone.Bussiness.Concrete;

namespace Trendyol.Clone.Bussiness.DependencyResolvers.AutoFac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
        }
    }
}

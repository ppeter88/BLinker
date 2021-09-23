using AutoMapper;
using BLinkerTest.BLinkerAPI;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLinkerTest.Ninject
{
    public class DepInjBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IBLRequest>().To<BLRequestWebClient>();
            Bind<IBLinkerMapping>().To<BLinkerMappingProfile>();
        }
    }
}

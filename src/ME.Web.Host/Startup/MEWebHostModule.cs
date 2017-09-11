using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ME.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ME.Web.Host.Startup
{
    [DependsOn(
       typeof(MEWebCoreModule))]
    public class MEWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MEWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MEWebHostModule).GetAssembly());
        }
    }
}

using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ME.Authorization;

namespace ME
{
    [DependsOn(
        typeof(MECoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MEApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MEAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(MEApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
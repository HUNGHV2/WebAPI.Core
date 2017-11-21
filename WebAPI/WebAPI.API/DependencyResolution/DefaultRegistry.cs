using Microsoft.Win32;
using WebAPI.Data.Common;

namespace WebAPI.API.DependencyResolution
{
    public class DefaultRegistry : Registry
    {
        #region Constructors and Destructors

        public DefaultRegistry()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
            For<SkillContext>().Use<SkillContext>();
        }

        #endregion
    }
}
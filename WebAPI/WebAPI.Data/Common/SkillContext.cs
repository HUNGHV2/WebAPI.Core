using System.Data.Entity;

namespace WebAPI.Data.Common
{
    public class SkillContext : DbContext
    {
        public SkillContext() : base("SkillContext")
        {
        }
    }

}

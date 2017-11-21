using WebAPI.Data.Common;
using WebAPI.Data.Entities;
using WebAPI.Data.Reponsitory.Interfaces;

namespace WebAPI.Data.Reponsitory
{
        public class CategoriesReponsitory : EntityBaseRepository<NewsCategories>, ICategoriesReponsitory
        {
            public CategoriesReponsitory(SkillContext context) : base(context) { }
        }
}

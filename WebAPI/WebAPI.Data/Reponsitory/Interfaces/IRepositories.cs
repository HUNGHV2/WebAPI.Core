using WebAPI.Data.Entities;

namespace WebAPI.Data.Reponsitory.Interfaces
{
    public interface ICategoriesReponsitory : IEntityBaseRepository<NewsCategories> { }
    public interface INewsRepository : IEntityBaseRepository<News> { }
}

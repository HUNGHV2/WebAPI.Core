using System.ComponentModel.DataAnnotations;

namespace WebAPI.Data.Entities
{
    public class News : Entity
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string UserName { get; set; }
        public virtual NewsCategories NewsCategorie { get; set; }
    }
}

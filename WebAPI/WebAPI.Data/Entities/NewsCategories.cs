using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Data.Entities
{
    public class NewsCategories:Entity
    {
        public NewsCategories()
        {
            this.NewsCategorie = new List<News>();
        }

        public int Id { get; set; }

        [MaxLength(150)]
        public string LocationName { get; set; }

        public virtual ICollection<News> NewsCategorie { get; set; }
    }
}

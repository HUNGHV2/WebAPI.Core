using System.ComponentModel.DataAnnotations;

namespace WebAPI.Data.Entities
{
    public class CoverImage : Entity
    {
        //public CoverImage()
        //{
        //this.GamificationBadges = new List<GamificationBadge>();
        //this.KnowledgeDocuments = new List<KnowledgeDocument>();
        //this.FeaturedContents = new List<FeaturedContent>();
        //this.Collections = new List<Collection>();
        // }

        public int Id { get; set; }

        [MaxLength(100)]
        public string FileName { get; set; }

        [MaxLength(50)]
        public string Extension { get; set; }

        [MaxLength(50)]
        public string Mime { get; set; }

        public byte[] Attachment { get; set; }

        //public virtual ICollection<GamificationBadge> GamificationBadges { get; set; }
        //public virtual ICollection<KnowledgeDocument> KnowledgeDocuments { get; set; }
        //public virtual ICollection<FeaturedContent> FeaturedContents { get; set; }
        //public virtual ICollection<Collection> Collections { get; set; }
    }
}

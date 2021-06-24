using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoRental.Entities
{
    public class Video
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        [ForeignKey("VideoType")]
        public int VideoTypeId { get; set; }
        public virtual VideoType Type { get; set; }
        public string Genre { get; set; }
        public int MaximumAge { get; set; }
        public int Year { get; set; }
    }
}

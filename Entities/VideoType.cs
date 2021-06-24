using System.ComponentModel.DataAnnotations;

namespace VideoRental.Entities
{
    public class VideoType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public int Rate { get; set; }
    }
}

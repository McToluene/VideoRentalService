using System.ComponentModel.DataAnnotations;

namespace VideoRental.API.ViewModels
{
    public class Detail
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Days { get; set; }
    }
}

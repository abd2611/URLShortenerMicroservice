using System.ComponentModel.DataAnnotations;
namespace URLShortenerMicroservice.Model
{
    public class URLMapping
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public string OriginalUrl { get; set; }

        [Required]



    }
}


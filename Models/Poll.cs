using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class Poll
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreationDate { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreationDate { get; set; }
        public Question Question { get; set; } = null!;
    }
}

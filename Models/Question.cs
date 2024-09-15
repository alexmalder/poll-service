using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<Answer> Answers { get; } = new List<Answer>();
        //public Poll? Poll { get; set; }
    }
}

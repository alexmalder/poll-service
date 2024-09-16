using System.ComponentModel.DataAnnotations;

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

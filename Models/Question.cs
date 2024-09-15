using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<Answer> Answers { get; } = new List<Answer>();
    }
}

using System.ComponentModel.DataAnnotations;

namespace DotNetCrudWebApi.Models
{
    public class Question : EntityBase
    {
        public string? Title { get; set; }
        public ICollection<Answer> Answers { get; } = new List<Answer>();
    }
}

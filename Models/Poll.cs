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
        public ICollection<PollInstance> PollInstances { get; } = new List<PollInstance>();
        public ICollection<Question> Questions { get; } = new List<Question>();
    }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class Poll : EntityBase
    {
        public string? Title { get; set; }
        public ICollection<PollInstance> PollInstances { get; } = new List<PollInstance>();
        public ICollection<Question> Questions { get; } = new List<Question>();
    }
}

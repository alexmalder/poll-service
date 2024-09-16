using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class Poll : EntityBase
    {
        public string? Title { get; set; }
        public ICollection<Instance> Instances { get; } = [];
        public ICollection<Question> Questions { get; } = [];
        public ICollection<InstanceQuestion> InstanceQuestion { get; } = [];
    }
}

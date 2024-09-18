using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class Instance : EntityBase
    {
        public required Poll Poll { get; set; }
        public long? PollId { get; set; }
        public ICollection<InstanceQuestion> InstanceQuestions { get; } = [];
        
    }
}

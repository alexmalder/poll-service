using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class PollInstance : EntityBase
    {
        public required Poll Poll { get; set; }
        [ForeignKey("PollId")]
        public long? PollId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCrudWebApi.Models
{
    public class PollInstanceDTO : DTOBase
    {
        public string? Title { get; set; }
        [ForeignKey("PollId")]
        public long? PollId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCrudWebApi.Models
{
    public class InstanceDTO : DTOBase
    {
        public string? Title { get; set; }
        public long? PollId { get; set; }
    }
}

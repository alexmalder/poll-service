using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCrudWebApi.Models
{
    public class PollDTO : DTOBase
    {
        public string? Title { get; set; }
    }
}

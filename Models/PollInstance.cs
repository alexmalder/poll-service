using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class PollInstance
    {
        [Key]
        public int Id { get; set; }
        public required Poll Poll { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCrudWebApi.Models
{
    public class PollInstanceAnswerDTO : DTOBase
    {
        [ForeignKey("AnswerId")]
        public long? AnswerId { get; set; }
        [ForeignKey("PollInstanceId")]
        public long? PollInstanceId { get; set; }
    }
}

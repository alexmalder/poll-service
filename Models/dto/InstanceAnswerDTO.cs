using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCrudWebApi.Models
{
    public class InstanceAnswerDTO : DTOBase
    {
        public long? InstanceQuestionId { get; set; }
        public string? Text { get; set; }
    }
}

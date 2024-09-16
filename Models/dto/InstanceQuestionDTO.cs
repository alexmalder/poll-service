using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCrudWebApi.Models
{
    public class InstanceQuestionDTO : DTOBase
    {
        public long? QuestionId { get; set; }
        public long? InstanceId { get; set; }
    }
}

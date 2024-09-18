using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudWebApi.Models
{
    //[PrimaryKey(nameof(AnswerId), nameof(InstanceId))]
    public class InstanceAnswer : EntityBase
    {
        public required InstanceQuestion InstanceQuestion;
        public long InstanceQuestionId { get; set; }
        public long AnswerId { get; set; }
        public string? Text { get; set; }
    }
}

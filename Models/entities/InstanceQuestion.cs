using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudWebApi.Models
{
    //[PrimaryKey(nameof(QuestionId), nameof(InstanceId))]
    public class InstanceQuestion : EntityBase
    {
        public Question Question { get; set; } = null!;
        public long QuestionId { get; set; }
        //public Instance Instance { get; set; } = null!;
        public long InstanceId { get; set; }
        public ICollection<InstanceAnswer> InstanceAnswers { get; } = [];
    }
}

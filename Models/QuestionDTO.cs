using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DotNetCrudWebApi.Models
{
    public class QuestionDTO
    {
        public string? Title { get; set; }
        public DateTime CreationDate { get; set; }
    }
}

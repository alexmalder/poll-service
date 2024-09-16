using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DotNetCrudWebApi.Models
{
    public class Question : EntityBase
    {
        public Question() {

        }
        private ILazyLoader LazyLoader { get; set; }
        private ICollection<Answer> _answers;
        public string? Title { get; set; }
        public ICollection<Answer> Answers {
            get => LazyLoader.Load(this, ref _answers);
            set => _answers = value;
        }
    }
}

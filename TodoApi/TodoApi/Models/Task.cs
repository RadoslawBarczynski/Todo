using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    [Table("Todos")]
    public class Todo
    {
        [Key]
        public Guid id { get; set; }
        public DateTime Created_at { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}

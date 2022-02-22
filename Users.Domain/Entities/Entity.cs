using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Users.Domain.Entities
{
    public interface IEntity<T>
    {
        T Id { get;}
        bool Deleted { get; set; }
    }

    public abstract class Entity<T> : IEntity<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        
        public bool Deleted { get; set; }
    }
}
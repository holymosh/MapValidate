using System.Collections.Generic;

namespace Users.Domain.Entities
{
    public class Organisation : Entity<int>
    {
        public string Title { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
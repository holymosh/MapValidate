using System.ComponentModel.DataAnnotations.Schema;

namespace Users.Domain.Entities
{
    public class User : Entity<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [ForeignKey("OrganisationId")]
        public int? OrganisationId { get; set; }
        public Organisation Organisation { get; set; }
    }
}
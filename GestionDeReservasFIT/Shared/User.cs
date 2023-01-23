using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeReservasFIT.Shared
{
    public class User : Audit
    {

        [Required]
        [StringLength(10, ErrorMessage = "* Obligatorio")]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(25, ErrorMessage = "* Obligatorio")]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(25, ErrorMessage = "* Obligatorio")]
        public string Password { get; set; } = null!;

        [ForeignKey("RolID")]
        public int RolId { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public User()
        {
            this.Roles = new HashSet<Role>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeReservasFIT.Shared
{
    public  class User: Audit
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

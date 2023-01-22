using GestionDeReservasFIT.Shared;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionDeReservasFIT.Shared.DTO
{
    public class UserDetailDTO : Audit
    {
        public string UserName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
        public int RolId { get; set; }
        public virtual ICollection<Role> Roles { get; set; }

    }
}
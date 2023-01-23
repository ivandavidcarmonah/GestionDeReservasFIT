namespace GestionDeReservasFIT.Shared.DTO
{
    public class UserListDTO : Audit
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int RolId { get; set; }
#pragma warning disable CS8618 // El elemento propiedad "Roles" que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declarar el elemento propiedad como que admite un valor NULL.
        public virtual ICollection<Role> Roles { get; set; }
#pragma warning restore CS8618 // El elemento propiedad "Roles" que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declarar el elemento propiedad como que admite un valor NULL.
    }
}

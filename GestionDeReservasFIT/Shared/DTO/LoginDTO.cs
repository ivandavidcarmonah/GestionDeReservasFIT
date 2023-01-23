using System.ComponentModel.DataAnnotations;

namespace GestionDeReservasFIT.Shared.DTO
{
    public class LoginDTO
    {
        [Required]
#pragma warning disable CS8618 // El elemento propiedad "UserName" que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declarar el elemento propiedad como que admite un valor NULL.
        public string UserName { get; set; }
#pragma warning restore CS8618 // El elemento propiedad "UserName" que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declarar el elemento propiedad como que admite un valor NULL.
        [Required]
#pragma warning disable CS8618 // El elemento propiedad "Password" que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declarar el elemento propiedad como que admite un valor NULL.
        public string Password { get; set; }
#pragma warning restore CS8618 // El elemento propiedad "Password" que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declarar el elemento propiedad como que admite un valor NULL.
        public bool RememberMe { get; set; }
    }

    public class CurrentUser
    {
        public bool IsAuthenticated { get; set; }
#pragma warning disable CS8618 // El elemento propiedad "UserName" que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declarar el elemento propiedad como que admite un valor NULL.
        public string UserName { get; set; }
#pragma warning restore CS8618 // El elemento propiedad "UserName" que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declarar el elemento propiedad como que admite un valor NULL.
#pragma warning disable CS8618 // El elemento propiedad "Claims" que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declarar el elemento propiedad como que admite un valor NULL.
        public Dictionary<string, string> Claims { get; set; }
#pragma warning restore CS8618 // El elemento propiedad "Claims" que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declarar el elemento propiedad como que admite un valor NULL.
    }
}

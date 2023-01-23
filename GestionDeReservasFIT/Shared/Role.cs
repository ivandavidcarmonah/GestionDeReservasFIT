namespace GestionDeReservasFIT.Shared;

public class Role : Audit
{


    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

}

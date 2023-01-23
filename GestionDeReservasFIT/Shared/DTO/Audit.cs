namespace GestionDeReservasFIT.Shared.DTO
{
    public class Audit
    {

        public int Id { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int UpdateBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public bool Deleted { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }

    }
}

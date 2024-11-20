using Banking.Domain.Enums;

namespace Banking.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public AccountTypes AccountType { get; set; }
        public decimal Balance { get; set; }
        public string? AccountName { get; set; }
        public string? AccountNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public string? Swift { get; set; }
        public string? ElectonicRoutingNumber { get; set; }
        public string? WiresRoutingNumber { get; set; }
    }
}

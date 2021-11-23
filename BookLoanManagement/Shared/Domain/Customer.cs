using System.Collections.Generic;

namespace BookLoanManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Loan> Loans { get; set; }
    }
}
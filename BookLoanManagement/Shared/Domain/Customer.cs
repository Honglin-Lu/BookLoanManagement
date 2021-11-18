using System.Collections.Generic;

namespace BookLoanManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string Name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public List<Loan> Loans { get; set; }
    }
}
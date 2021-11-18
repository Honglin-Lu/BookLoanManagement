using System;

namespace BookLoanManagement.Shared.Domain
{
    public class Loan : BaseDomainModel
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CustomerId { get; set;}
        public Customer Customer { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }


    }
}
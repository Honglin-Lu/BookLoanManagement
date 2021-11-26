using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLoanManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        // ErrorMessage is the customized message
        [Required(ErrorMessage ="Please enter the customer name!")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public List<Loan> Loans { get; set; }
    }
}
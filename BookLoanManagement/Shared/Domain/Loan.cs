using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLoanManagement.Shared.Domain
{
    public class Loan : BaseDomainModel,IValidatableObject
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        [Required]
        public int CustomerId { get; set;}
        public Customer Customer { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }


        // write customized validation
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateIn != null)
            {
                if (DateIn <= DateOut)
                {
                    //use a yield return statement to return each element one at a time.
                    yield return new ValidationResult("Date In must be greater than Date out", new[] { "DateIn" });
                }
            }
        }
    }
}
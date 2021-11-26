using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanManagement.Shared.Domain
{
    public class Book : BaseDomainModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please select the book category!")]
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Please select the book author!")]
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        [Required(ErrorMessage = "Please select the book publisher!")]
        public Publisher Publisher { get; set; }
        public List<Loan> Loans { get; set; }
    }
}

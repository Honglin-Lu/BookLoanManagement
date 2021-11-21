using BookLoanManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLoanManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Author> Authors { get;}
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Book> Books { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Publisher> Publishers { get; }
        IGenericRepository<Loan> Loans { get; }
    }
}

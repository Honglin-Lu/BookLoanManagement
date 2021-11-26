using BookLoanManagement.Server.Data;
using BookLoanManagement.Server.IRepository;
using BookLoanManagement.Server.Models;
using BookLoanManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookLoanManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Author> _authors;
        private IGenericRepository<Category> _categories;
        private IGenericRepository<Book> _books;
        private IGenericRepository<Publisher> _publishers;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Loan> _loans;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IGenericRepository<Author> Authors => _authors ??= new GenericRepository<Author>(_context);
        public IGenericRepository<Category> Categories => _categories ??= new GenericRepository<Category>(_context);
        public IGenericRepository<Publisher> Publishers => _publishers ??= new GenericRepository<Publisher>(_context);
        public IGenericRepository<Book> Books => _books ??= new GenericRepository<Book>(_context);
        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Loan> Loans => _loans ??= new GenericRepository<Loan>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //var user = httpContext.User.Identity.Name;

            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user.UserName;

                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user.UserName;
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}

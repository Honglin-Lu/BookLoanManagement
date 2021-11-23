using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLoanManagement.Client.Static
{
    public static class Endpoints
    {
        public static string Prefix = "api";

        public static string AuthorsEndpoint = $"{Prefix}/authors";
        public static string PublishersEndpoint = $"{Prefix}/publishers";
        public static string CategoriesEndpoint = $"{Prefix}/categories";
        public static string BooksEndpoint = $"{Prefix}/books";
        public static string CustomersEndpoint = $"{Prefix}/customers";
        public static string LoansEndpoint = $"{Prefix}/loans";
    }
}

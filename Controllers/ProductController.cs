using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;
using Microsoft.EntityFrameworkCore;


namespace StoreApp.Controllers
{
    public class ProductController:Controller
    {
        public IEnumerable<Product>Index()
        {
            var context=new RepositoryContext(
                new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer("Server=.\\SQLEXPRESS;Database=ProductDb;Trusted_Connection=True;TrustServerCertificate=True")
                .Options
            );
            return context.Products;


           /* return new List<Product>()
            {
                new Product(){ProductId=1,ProductName="Computer",Predicate=6}
            };veritabanına erişim şuanda olmadığı için bunu yaptık diay çercevesi ne bak*/
        }
    }
}
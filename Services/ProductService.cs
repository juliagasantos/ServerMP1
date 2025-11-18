using ServerMP1.Interfaces;
using ServerMP1.Models;

namespace ServerMP1.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() =>
            new()
            {
                new Product () {Id = 1, Name = "Salada", Description = "Lanche de salada", 
                    UrlImagem = "image/xSalada.jpg", Price = 22.5m, Stock = 15, IsActive = true, CategoryId = 1},
                new Product () {Id = 2, Name = "Bebida", Description = "Refrigerante de Lata",
                    UrlImagem = "image/Refrigerante.jpg", Price = 7.5m, Stock = 50, IsActive = true, CategoryId = 2},
                new Product () {Id = 2, Name = "Sobremesa", Description = "Pudim de Leite",
                    UrlImagem = "image/Pudim.jpg", Price = 12.0m, Stock = 20, IsActive = true, CategoryId = 3},
            };
    }
}

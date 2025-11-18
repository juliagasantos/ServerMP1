namespace ServerMP1.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } =  string.Empty;
        public string UrlImagem { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public bool IsActive { get; set; }
        public List<CategoryDTO> Categories { get; set; } = new ();

    }
}

namespace ServerMP1.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } =  string.Empty;
        public string UrlImg { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public bool IsActive { get; set; }

        //Categoria escolhida no select
        public string CategoryName { get; set; } = string.Empty;
        public List<CategoryDTO> Categories { get; set; } = new ();

    }
}

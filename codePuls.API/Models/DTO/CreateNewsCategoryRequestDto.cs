namespace codePuls.API.Models.DTO

{
    public class CreateNewsCategoryRequestDto
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public string FeaturedImageUrl { get; set; }
        public bool IsVisible { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ShortDescription { get; set; }
        public string Title { get; set; }
        public string UrlHandle { get; set; }
        // For requests we expect category Ids
        public List<Guid> Categories { get; set; } = new List<Guid>();
    }
}

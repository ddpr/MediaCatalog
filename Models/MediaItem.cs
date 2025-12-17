namespace MediaCatalog.Models
{
    public class MediaItem
    {
        //idk if this is neccessary, i remember it from c++?
        public MediaItem(int id, string title, string description, int releaseYear, MediaTypes mediaTypes, string? imageUrl)
        {
            Id = id;
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            MediaType = mediaTypes;
            ImageUrl = imageUrl;
        }
        public enum MediaTypes
        {
            Movie,
            Series,
            Game,
            Book,
            Manga
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public MediaTypes MediaType { get; set; }
        public string? ImageUrl { get; set; }
    }
}

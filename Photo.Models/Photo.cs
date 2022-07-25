namespace Photo.Models
{
    public static class Photo
    {
        public int AlbumId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }

        public Photo(int albumId, int id, string title, string url, string thumbnailUrl)
        {
            AlbumId = albumId;
            Id = id;
            Title = title;
            Url = url;
            ThumbnailUrl = thumbnailUrl;
        }
    }
}

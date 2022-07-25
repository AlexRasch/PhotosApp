using Microsoft.AspNetCore.Mvc;



namespace PhotoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PhotoController : ControllerBase
    {
        [HttpGet(Name = "GetPhoto")]
        public IEnumerable<Photo> Get()
        {
          
           return  Photo.photos.ToArray();
        }

        //[Route("")]
        //[HttpGet(Name = "GetPhotoV3")]
        //public IActionResult Index()
        //{
        //    string szResponse = null;
        //
        //    foreach (var item in Photo.photos)
        //    {
        //        szResponse += item;
        //    }
        //
        //    return Content(szResponse);
        //}
    }



    public class Photo
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


        public static List<Photo> photos = new List<Photo>()
        {


            new Photo(1, 0, "Mona Lisa", @"https://via.placeholder.com/600/92c952", @"https://via.placeholder.com/150/92c952"),
            new Photo(2, 1, "reprehenderit", @"https://via.placeholder.com/600/771796", @"https://via.placeholder.com/150/771796"),
            new Photo(3, 2, "gafasfdas", @"https://via.placeholder.com/600/24f355", @"https://via.placeholder.com/150/24f355"),
            new Photo(4, 3, "avavs", @"https://via.placeholder.com/600/d32776", @"https://via.placeholder.com/150/d32776"),
            new Photo(5, 4, "Mfwga", @"https://via.placeholder.com/600/f66b97", @"https://via.placeholder.com/150/f66b97"),
            new Photo(6, 5, "56a8c2", @"https://via.placeholder.com/600/56a8c2", @"https://via.placeholder.com/150/56a8c2"),
            new Photo(7, 6, "b0f7cc", @"https://via.placeholder.com/600/b0f7cc", @"https://via.placeholder.com/150/b0f7cc"),
            new Photo(8, 7, "54176f", @"https://via.placeholder.com/600/54176f", @"https://via.placeholder.com/150/54176f"),
            new Photo(9, 8, "51aa97", @"https://via.placeholder.com/600/51aa97", @"https://via.placeholder.com/150/51aa97"),
            new Photo(10, 9, "810b14", @"https://via.placeholder.com/600/810b14", @"https://via.placeholder.com/150/810b14")
        };
    }
}

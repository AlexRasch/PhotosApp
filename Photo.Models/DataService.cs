using System.Collections.Generic;

using PhotosApp.Views.Photos;

namespace PhotosApp.Models
{
    public static class DataService
    {
        //private readonly DataService dataService;
        //
        //public DataService(DataService dataService)
        //{
        //    this.dataService = dataService;
        //}

        private readonly IHttpClientFactory _httpClientFactory;

        public DataService(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

        List<Photo> photos = new List<Photo>()
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

        public IndexVM[] GetAll()
        {
            return photos.Select(o => new IndexVM
            {
                Url = o.Url,
                ThumbnailUrl = o.ThumbnailUrl,
                Title = o.Title,
            })
            .OrderBy(o => o.Title)
            .ToArray();

        }


        public async Task<IndexVM[]> GetAllRemote()
        {
            string url = "https://jsonplaceholder.typicode.com/photos";

            var httpClient = _httpClientFactory.CreateClient();

            Photo[] photos = await httpClient.GetFromJsonAsync<Photo[]>(url);

            return photos.Select(o => new IndexVM
            {
                ThumbnailUrl = o.ThumbnailUrl,
                Title = o.Title,
                Url = o.Url,

                
            })
            .ToArray();
        }

        public async Task<IndexVM[]> GetAllRemoteV2()
        {
            string url = "https://localhost:7028/photo";

            var httpClient = _httpClientFactory.CreateClient();

            Photo[] photos = await httpClient.GetFromJsonAsync<Photo[]>(url);

            return photos.Select(o => new IndexVM
            {
                ThumbnailUrl = o.ThumbnailUrl,
                Title = o.Title,
                Url = o.Url,


            })
            .ToArray();
        }

    }
}

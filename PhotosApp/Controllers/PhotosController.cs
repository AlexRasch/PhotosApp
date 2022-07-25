using Microsoft.AspNetCore.Mvc;
using PhotosApp.Models;
using PhotosApp.Views.Photos;

namespace PhotosApp.Controllers
{
    public class PhotosController : Controller
    {
        private readonly DataService dataService;

        public PhotosController(DataService dataService)
        {
            this.dataService = dataService;
        }

        [Route("")]
        public IActionResult Index()
        {
            //var model = dataService.GetAll();
            return View("index");
        }


        /*
         * Local stored hardcoded
         */


        [Route("1")]
        public async Task<IActionResult> First()
        {
            var model = dataService.GetAll();

            return View("index",model);
        }

        [Route("2")]
        public async Task<IActionResult> Second()
        {
            var model = await dataService.GetAllRemote();
            return View("index", model);
        }

        [Route("3")]
        public async Task<IActionResult> Third()
        {
            var model = await dataService.GetAllRemoteV2();
            return View("index", model);
        }

    }
}

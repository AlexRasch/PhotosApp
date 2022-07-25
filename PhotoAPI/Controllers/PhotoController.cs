using Microsoft.AspNetCore.Mvc;
using PhotoAPI.Models;
using System.Linq;

namespace PhotoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotoController : ControllerBase
    {

        // photo?limit=10

        [HttpGet(Name = "GetPhoto")]
        [Route("photo")]
        public IEnumerable<Photo> Get(int? limit)
        {
           


            return limit == null ? Photo.photos.ToArray(): Photo.photos.Take((int)limit);
        }

    }
}


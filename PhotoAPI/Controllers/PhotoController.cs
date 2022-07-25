using Microsoft.AspNetCore.Mvc;
using PhotoAPI.Models;

namespace PhotoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotoController : ControllerBase
    {
        [HttpGet(Name = "GetPhoto")]
        public IEnumerable<Photo> Get()
        {

            return Photo.photos.ToArray();
        }

    }
}


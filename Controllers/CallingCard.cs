using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace calling_card.Controllers
{
    public class CallingCard : Controller
    {
        // Other code
        [HttpGet]
        [Route("{user_fname}/{user_lname}/{user_age}/{color}")]
        public JsonResult DisplayInfo(string user_fname, string user_lname, int user_age, string color)
        {
            var AnonObject = new {
                                FirstName = user_fname,
                                LastName = user_lname,
                                Age = user_age,
                                FavoriteColor = color
                            };
            return Json(AnonObject);
        }

    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Ski_App_Service.Controllers.API
{
    [Route("addSkiField")] 
    [ApiController]

    public class SkiFieldController
    {
        private readonly List<string> _skiFieldReviews = new List<string>();


        [HttpPost]
        public void AddNewSkiFieldReview(string review)
        {
            _skiFieldReviews.Add(review);
        }
        [HttpGet]
        public List<string> GetSkiFieldReviews(string review)
        {
            return _skiFieldReviews;
        }
    }
}
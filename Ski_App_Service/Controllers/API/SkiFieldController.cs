using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ski_App_Application;

namespace Ski_App_Service.Controllers.API
{
    [Route("reviews")] 
    [ApiController]

    public class SkiFieldController
    {
        private readonly ISkiFieldsRepository _skiFieldsRepository;

        public SkiFieldController(ISkiFieldsRepository skiFieldsRepository)
        {
            _skiFieldsRepository = skiFieldsRepository;
        }

        [HttpPost]
        public void AddNewSkiFieldReview([FromBody]string review)
        {
            _skiFieldsRepository.Add(review);
        }
        [HttpGet]
        public Task<List<string>> GetSkiFieldReviews(string review)
        {
            return _skiFieldsRepository.GetAll();
        }
    }
}
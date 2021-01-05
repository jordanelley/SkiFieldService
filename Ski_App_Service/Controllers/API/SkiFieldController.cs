using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ski_App_Application;
using Ski_App_Service.Contracts;

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
        public Task AddNewSkiFieldReview(SkiFieldReviewModel model)
        {
            return _skiFieldsRepository.Add(model.Name+" "+model.Review);
        }
        [HttpGet]
        public Task<List<string>> GetSkiFieldReviews()
        {
            return _skiFieldsRepository.GetAll();
        }
    }
}
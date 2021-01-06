using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Ski_App_Application;
using Ski_App_Service.Models;
using Ski_App_Service.Models.Contracts;

namespace Ski_App_Service.Controllers.API
{
    [Route("reviews")] 
    [ApiController]

    public class SkiFieldController
    {
        private readonly ISkiFieldsRepository _skiFieldsRepository;
        private readonly IMapper _mapper;

        public SkiFieldController(ISkiFieldsRepository skiFieldsRepository, IMapper mapper)
        {
            _skiFieldsRepository = skiFieldsRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public Task AddNewSkiFieldReview(SkiFieldReviewModel model)
        {
            var review = _mapper.Map<SkiFieldReview>(model);
            return _skiFieldsRepository.Add(model.Name+" "+model.Review);
        }
        [HttpGet]
        public Task<List<string>> GetSkiFieldReviews()
        {
            return _skiFieldsRepository.GetAll();
        }
    }
}
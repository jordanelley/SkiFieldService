using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ski_App_Repositories.InMemoryRepositories;
using Ski_App_Service.Models.Contracts;
using Ski_App_Service.Controllers.API;
using Xunit;
using AutoMapper;
using Newtonsoft.Json;
using Ski_App_Repositories.Models;
using Ski_App_Service_Tests.helpers;

namespace Ski_App_Service_Tests
{
    public class SkiFieldControllerTests
    {
        private readonly IMapper _mapper;
        public SkiFieldControllerTests()
        {
            _mapper = new AutomapperHelper().AddMappingProfile();
        }
        [Fact]
        public async Task ShouldAddSkiField()
        {
            var skiFieldController = new SkiFieldController(new SkiFieldsRepository(),_mapper);
            
            var skiFieldReviewModel = new SkiFieldReviewModel
            {
                Name = "Cadrona",
                Review = "good"
            };

            await skiFieldController.AddNewSkiFieldReview(skiFieldReviewModel);
            var reviews = await skiFieldController.GetSkiFieldReviews();
            var expected = new List<SkiFieldReviewModel>() {new SkiFieldReviewModel() {Name = "Cadrona", Review = "good"}};
            
            Assert.Equal(JsonConvert.SerializeObject(expected[0]),JsonConvert.SerializeObject(reviews[0]));
        }
    }
}
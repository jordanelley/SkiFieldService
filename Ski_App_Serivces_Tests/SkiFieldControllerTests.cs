using System;
using System.Threading.Tasks;
using Ski_App_Repositories.InMemoryRepositories;
using Ski_App_Service.Models.Contracts;
using Ski_App_Service.Controllers.API;
using Xunit;

namespace Ski_App_Service_Tests
{
    public class SkiFieldControllerTests
    {
        [Fact]
        public async Task ShouldAddSkiField()
        {
            var skiFieldController = new SkiFieldController(new SkiFieldsRepository());
            
            var skiFieldReviewModel = new SkiFieldReviewModel
            {
                Name = "Cadrona",
                Review = "good"
            };

            await skiFieldController.AddNewSkiFieldReview(skiFieldReviewModel);
            var reviews = await skiFieldController.GetSkiFieldReviews();
            
            Assert.Equal("Cadrona good", reviews[0]);
        }
    }
}
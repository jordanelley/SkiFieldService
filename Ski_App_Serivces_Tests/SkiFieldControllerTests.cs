using System;
using System.Threading.Tasks;
using Ski_App_Repositories.InMemoryRepositories;
using Ski_App_Service.Contracts;
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
            await skiFieldController.AddNewSkiFieldReview(new SkiFieldReviewModel());
            //check that i got back what I added
           //add a ski field
           //check its added
        }
    }
}
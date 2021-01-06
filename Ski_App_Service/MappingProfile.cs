using AutoMapper;
using Ski_App_Service.Models;
using Ski_App_Service.Models.Contracts;

namespace Ski_App_Service
{
    public class MappingProfile : Profile {
        public MappingProfile() {
            CreateMap<SkiFieldReviewModel, SkiFieldReview>();
            CreateMap<SkiFieldReview, SkiFieldReviewModel>();
        }
    }
}
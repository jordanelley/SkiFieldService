using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Rewrite;
using Ski_App_Repositories.Models;
using Ski_App_Service.Models;
using Ski_App_Service.Models.Contracts;

namespace Ski_App_Service
{
    public class MappingProfile : Profile {
        public MappingProfile() {
            CreateMap<SkiFieldReviewModel, SkiFieldReview>();
            CreateMap<SkiFieldReview, SkiFieldReviewModel>()
                .ForMember(review => review.Name, opt =>
                    opt.MapFrom(src => src.Name))
                .ForMember(review => review.Review, opt =>
                    opt.MapFrom(src => src.Review));
        }
    }
}
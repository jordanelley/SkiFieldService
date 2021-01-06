using AutoMapper;
using Ski_App_Service;

namespace Ski_App_Service_Tests.helpers
{
    public class AutomapperHelper
    {
        public IMapper AddMappingProfile()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            return mapperConfig.CreateMapper();
        }
    }
}
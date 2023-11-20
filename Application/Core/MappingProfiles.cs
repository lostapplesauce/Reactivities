using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //We're asking auotmapper to just match the property names
            //That is what this is going to do.
            CreateMap<Activity, Activity>();
        }
    }
}
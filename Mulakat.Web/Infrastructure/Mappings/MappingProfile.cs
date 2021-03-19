using AutoMapper;
using Mulakat.Data.Models;
using Mulakat.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mulakat.Web.Infrastructure.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterViewModel, User>()
                .ForMember(dest => dest.Email, mf => mf.MapFrom(src => src.Email))
                .ForMember(dest => dest.Password, mf => mf.MapFrom(src => src.Password));

            CreateMap<MovieViewModel, Movie>()
              .ForMember(dest => dest.ID, mf => mf.MapFrom(src => src.ID))
              .ForMember(dest => dest.Title, mf => mf.MapFrom(src => src.Title))
              .ForMember(dest => dest.Year, mf => mf.MapFrom(src => src.Year));

            CreateMap<Movie, MovieViewModel>()
              .ForMember(dest => dest.ID, mf => mf.MapFrom(src => src.ID))
              .ForMember(dest => dest.Title, mf => mf.MapFrom(src => src.Title))
              .ForMember(dest => dest.Year, mf => mf.MapFrom(src => src.Year));
        }
    }
}

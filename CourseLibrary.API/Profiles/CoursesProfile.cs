﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Entities.Course, Models.CourseDto>();
            CreateMap<Models.CourseDto, Entities.Course>();
            CreateMap<Models.CourseForCreationDto, Entities.Course>().ReverseMap();
            CreateMap<Models.CourseForUpdateDto, Entities.Course>().ReverseMap();
        }
    }
}

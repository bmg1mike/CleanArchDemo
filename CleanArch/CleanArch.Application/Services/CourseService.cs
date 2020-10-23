using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            var courses = new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };

            return courses;
        }
    }
}

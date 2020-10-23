using CleanArch.Infra.Data.Context;
using Core.Models;
using Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _universityDbContext;
        public CourseRepository(UniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            var courses = _universityDbContext.Courses;
            return courses;
        }
    }
}

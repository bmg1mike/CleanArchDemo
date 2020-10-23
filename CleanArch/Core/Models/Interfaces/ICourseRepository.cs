using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}

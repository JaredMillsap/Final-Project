using System;
using System.Collections.Generic;
using FinalProjectColleges.Models;

namespace FinalProjectColleges
{
    public interface ISchoolsRepository
    {
        public IEnumerable<School> GetAllSchools();
    }
}

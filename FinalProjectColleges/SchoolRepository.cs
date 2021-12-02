using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using FinalProjectColleges.Models;

namespace FinalProjectColleges
{
    public class SchoolRepository : ISchoolsRepository
    {
        private readonly IDbConnection _conn;
        public SchoolRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<School> GetAllSchools()
        {
            return _conn.Query<School>("SELECT * FROM SCHOOLS;");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using vacation.Models;

namespace vacation.Repositories
{
    public class VacationRepository
    {
        private readonly IDbConnection _db;
        public VacationRepository(IDbConnection db)
        {
            _db = db;
        }
        internal IEnumerable<Vacation> GetAll()
        {
            string sql = @"SELECT
            trip.location,
            trip.price,
            trip.id FROM trip
            UNION SELECT
            cruise.location,
            cruise.price,
            cruise.id FROM cruise;
            ";
            return _db.Query<Vacation>(sql);
        }
    }
}
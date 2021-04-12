using System;
using System.Data;
using Dapper;
using vacation.Models;

namespace vacation.Repositories
{
    public class CruisesRepository
    {
        public readonly IDbConnection _db;

        public CruisesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Cruise Create(Cruise newCruise)
        {
            string sql = @"
            INSERT INTO cruise
            (location, price)
            VALUES
            (@Location, @Price);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, newCruise);
            newCruise.Id = id;
            return newCruise;
        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM cruise WHERE id = @id;";
            _db.Execute(sql, new { id });
            return;
        }
    }
}
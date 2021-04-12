using System;
using System.Collections.Generic;
using vacation.Models;
using vacation.Repositories;

namespace vacation.Services
{
    public class VacationService
    {

        private readonly VacationRepository _repo;

        public VacationService(VacationRepository repo)
        {
            _repo = repo;
        }
        internal IEnumerable<Vacation> getAll()
        {
            var data = _repo.GetAll();
            return data;
        }
    }
}
using System;
using vacation.Models;
using vacation.Repositories;

namespace vacation.Services
{
    public class CruisesService
    {
        private readonly CruisesRepository _repo;

        public CruisesService(CruisesRepository repo)
        {
            _repo = repo;
        }

        internal Cruise Create(Cruise newCruise)
        {
            return _repo.Create(newCruise);
        }

        internal Cruise Delete(int id)
        {
            Cruise original = Get(id);
            _repo.Delete(id);
            return original;
        }

        private Cruise Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
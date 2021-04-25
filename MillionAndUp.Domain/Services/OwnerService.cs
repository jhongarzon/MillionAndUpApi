using MillionAndUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly MillionUpDbContext _context;
        public OwnerService()
        {
            _context = new MillionUpDbContext();
        }
        public Owner GetOwnerById(int ownerId)
        {
            return _context.Owners.Find(ownerId);
        }

        public IEnumerable<Owner> GetOwners()
        {
            return _context.Owners;
        }
    }
}

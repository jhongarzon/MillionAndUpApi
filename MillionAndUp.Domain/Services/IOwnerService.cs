using MillionAndUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public interface IOwnerService
    {
        IEnumerable<Owner> GetOwners();
        Owner GetOwnerById(int ownerId);
    }
}

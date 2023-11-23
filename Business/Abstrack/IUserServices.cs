using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstrack
{
    public interface IUserServices
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
       User GetByMail(string email);



    }
}

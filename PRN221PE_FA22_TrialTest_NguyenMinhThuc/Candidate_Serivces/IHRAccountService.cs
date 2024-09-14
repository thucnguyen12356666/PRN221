using Candidate_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Serivces
{
    public interface IHRAccountService
    {
        public Hraccount GetHraccount(string email);
    }
}

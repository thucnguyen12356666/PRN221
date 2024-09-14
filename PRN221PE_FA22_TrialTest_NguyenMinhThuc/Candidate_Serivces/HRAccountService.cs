using Candidate_BusinessObjects.Entities;
using Candidate_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Serivces
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepo iAccountRepo = null;
        public HRAccountService()
        {
            if (iAccountRepo == null)
            {
                iAccountRepo = new HRAccountRepo();
            }
        }
        public Hraccount GetHraccount(string email)
        {
          return iAccountRepo.GetHraccount(email);
        }
    }
}

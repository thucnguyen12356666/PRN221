using Candidate_BusinessObjects;
using Candidate_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candisate_Daos
{
    public class HRAccountDAO
    {
        private CandidateManagementContext _HRcontext;
        private static HRAccountDAO _instance = null;  

        
        public static HRAccountDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HRAccountDAO();
                }
                return _instance;
            }
        }

        
        private HRAccountDAO()
        {
            _HRcontext = new CandidateManagementContext();
        }
        public Hraccount GetHraccount (string email)
        {
            return _HRcontext.Hraccounts.SingleOrDefault (h => h.Email == email);
        }
    }

}

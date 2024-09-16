using Candidate_BusinessObjects.Entities;
using Candisate_Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public class JobPostingRepository : IJobPostingRepository
    {
        public bool AddJobPosting(JobPosting jobPosting) => JobPostingDao.Instance.AddJobPosting(jobPosting);
        

        public JobPosting GetJobPosting(string postingId) => JobPostingDao.Instance.GetJobPosting(postingId);
        

        public bool UpdateJobPosting(JobPosting jobPosting) => JobPostingDao.Instance.UpdateJobPosting(jobPosting);
        
    }
}

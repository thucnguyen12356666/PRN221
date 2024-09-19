using Candidate_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public interface IJobPostingService
    {
        public bool AddJobPosting(JobPosting jobPosting);

        public bool UpdateJobPosting(JobPosting jobPosting);

        public JobPosting GetJobPosting(string postingId);
        public bool DeleteJobPosting(string postingId);
        public List<JobPosting> GetAllJob();
    }
}

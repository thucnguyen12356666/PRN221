using Candidate_BusinessObjects.Entities;
using Candidate_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Serivces
{
    public class JobPostingService : IJobPostingService
    {
        private readonly IJobPostingRepository _jobPostingRepository;

        public JobPostingService(IJobPostingRepository jobPostingRepository)
        {
            _jobPostingRepository = jobPostingRepository;
        }

        public bool CreateJobPosting(JobPosting jobPosting)
        {
            return _jobPostingRepository.Create(jobPosting);
        }

        public List<JobPosting> GetAllJobPostings()
        {
            return _jobPostingRepository.GetAll();
        }

        public JobPosting GetJobPostingById(string id)
        {
            return _jobPostingRepository.GetById(id);
        }
    }
}

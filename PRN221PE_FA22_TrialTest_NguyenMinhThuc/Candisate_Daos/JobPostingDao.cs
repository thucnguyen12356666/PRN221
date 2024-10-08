﻿using Candidate_BusinessObjects;
using Candidate_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candisate_Daos
{
    public class JobPostingDao
    {
        private CandidateManagementContext context;
        
        public static JobPostingDao instance;
            public JobPostingDao()
        {
            context = new CandidateManagementContext();
        }


            public static JobPostingDao Instance 
        {
            get
            {
                if ( instance == null)
                {
                     instance = new JobPostingDao();
                }
                return instance;
            }
        }
        public bool AddJobPosting(JobPosting jobPosting)
        {
            bool isSuccess  = false;
            try
            {
                context.JobPostings.Add(jobPosting);
                context.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isSuccess;
        }
       
        public bool UpdateJobPosting (JobPosting jobPosting)
        {
            bool isSuccess = false;
            try
            {
                JobPosting job  = GetJobPosting(jobPosting.PostingId);
                if (job != null) 
                { 
                    //xử hàm update 
                    context.JobPostings.Update(job);
                    context.SaveChanges();
                    isSuccess = true;
                }
                

            }
            catch (Exception ex)
            { 
            }
            return isSuccess;
        }

        public  JobPosting GetJobPosting(string postingId)
        {
            return context.JobPostings.SingleOrDefault(m => m.PostingId.Equals(postingId));
        }
        public bool DeleteJobPosting(string postingId)
        {
            bool isSuccess = false;
            try
            {
                // Lấy đối tượng JobPosting cần xóa dựa trên postingId
                JobPosting jobPosting = GetJobPosting(postingId);

                if (jobPosting != null)
                {
                    // Xóa đối tượng từ DbSet
                    context.JobPostings.Remove(jobPosting);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();

                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isSuccess;
        }
        public List<JobPosting> GetAllJob()
        {
               return context.JobPostings.ToList();
        }

    }
}

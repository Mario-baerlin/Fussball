using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.Data.EndToEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public class JobStatusService
    {
        private readonly EndtoendContext _context;

        public JobStatusService(EndtoendContext context)
        {
            _context = context;
        }

        public async Task<List<JobModel>>
            GetJobStatusAsync(string strCurrentUser)
        {
            // Get Weather Forecasts  
            return await _context.jobModel
                 // Only get entries for the current logged in user
                 .Where(x => x.UserName == strCurrentUser)
                 // Use AsNoTracking to disable EF change tracking
                 // Use ToListAsync to avoid blocking a thread
                 .AsNoTracking().ToListAsync();
        }

        public Task<JobModel>
            CreateJobModelAsync(JobModel objJobStatus2)
        {
            _context.jobModel.Add(objJobStatus2);
            _context.SaveChanges();
            return Task.FromResult(objJobStatus2);
        }

        public Task<bool>
               UpdateForecastAsync(JobModel objJobStatus2)
        {
            var ExistingJobStatus2 =
                _context.jobModel
                .Where(x => x.Id == objJobStatus2.Id)
                .FirstOrDefault();
            if (ExistingJobStatus2 != null)
            {
                ExistingJobStatus2.LastUpdated =
                    objJobStatus2.LastUpdated;
                ExistingJobStatus2.Description =
                    objJobStatus2.Description;
                ExistingJobStatus2.Status =
                    objJobStatus2.Status;
                
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool>
            DeleteForecastAsync(JobModel objJobStatus2)
        {
            var ExistingJobStatus2 =
                _context.jobModel
                .Where(x => x.Id == objJobStatus2.Id)
                .FirstOrDefault();
            if (ExistingJobStatus2 != null)
            {
                _context.jobModel.Remove(ExistingJobStatus2);
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}


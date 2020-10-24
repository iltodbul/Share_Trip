using System;
using System.Collections.Generic;
using System.Text;
using SULS.Data;
using SULS.Models;
using SULS.ViewModels.Submissions;

namespace SULS.Services
{
    public class SubmissionsService : ISubmissionsService
    {
        private readonly SULSContext dbContext;

        public SubmissionsService(SULSContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(CreateSubmissionInputModel inputModel)
        {
            var submission = new Submission()
            {

            };

            this.dbContext.Submissions.Add(submission);
            this.dbContext.SaveChanges();
        }
    }
}

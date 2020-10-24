using System;
using System.Collections.Generic;
using System.Text;
using SULS.Models;

namespace SULS.ViewModels.Submissions
{
    public class CreateSubmissionInputModel
    {
        public string Code { get; set; }

        public int AchievedResult { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ProblemId { get; set; }

        public string UserId { get; set; }

    }
}

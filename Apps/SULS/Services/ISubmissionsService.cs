using System;
using System.Collections.Generic;
using System.Text;
using SULS.ViewModels.Submissions;

namespace SULS.Services
{
    public interface ISubmissionsService
    {
        void Create(CreateSubmissionInputModel inputModel);
    }
}

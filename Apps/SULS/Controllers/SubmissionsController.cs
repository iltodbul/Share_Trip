using System;
using System.Collections.Generic;
using System.Text;
using SULS.Services;
using SULS.ViewModels.Submissions;
using SUS.HTTP;
using SUS.MvcFramework;

namespace SULS.Controllers
{
    public class SubmissionsController : Controller
    {
        private readonly ISubmissionsService submissionsService;

        public SubmissionsController(ISubmissionsService submissionsService)
        {
            this.submissionsService = submissionsService;
        }

        public HttpResponse Create()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Create(CreateSubmissionInputModel inputModel)
        {


            return this.View();
        }
    }
}

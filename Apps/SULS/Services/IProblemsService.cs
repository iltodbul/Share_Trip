using System;
using System.Collections.Generic;
using System.Text;
using SULS.Models;
using SULS.ViewModels.Problems;

namespace SULS.Services
{
    public interface IProblemsService
    {
        void Create(string name, int totalPoints);

        IEnumerable<HomePageProblemViewModel> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SULS.Data;
using SULS.Models;
using SULS.ViewModels.Problems;

namespace SULS.Services
{
    public class ProblemsService : IProblemsService
    {
        private readonly SULSContext dbContext;

        public ProblemsService(SULSContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(string name, int totalPoints)
        {
            var problem = new Problem()
            {
                Name = name,
                Points = totalPoints
            };

            this.dbContext.Problems.Add(problem);
            this.dbContext.SaveChanges();
        }

        public IEnumerable<HomePageProblemViewModel> GetAll()
        {
            var problems = this.dbContext.Problems
                .Select(x => new HomePageProblemViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Count = x.Submissions.Count
                })
                .ToList();

            return problems;
        }
    }
}

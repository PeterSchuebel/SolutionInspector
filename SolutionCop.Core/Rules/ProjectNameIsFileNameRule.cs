﻿namespace SolutionCop.Core.Rules
{
    using System.Collections.Generic;
    using System.IO;

    using SolutionCop.Contracts;
    using SolutionCop.Contracts.Model;

    internal class ProjectNameIsFileNameRule : IRule
    {
        public IEnumerable<IIssue> Apply(ISolution solution)
        {
            if (solution.Settings.ProjectNameIsFileName ?? false)
            {
                foreach (IProject project in solution.Projects)
                {
                    if (project.Name != Path.GetFileNameWithoutExtension(project.File))
                    {
                        yield return Issue.Create(Issue.ProjectVsFileNameMismatch, project, "Project name {0} is not matching its filename", project.Name);
                    }
                }
            }
        } 
    }
}
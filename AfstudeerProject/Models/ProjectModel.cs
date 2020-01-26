using System;
using System.Collections.Generic;

namespace AfstudeerProject.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public double Cost { get; set; }
        public double Reveneu { get; set; }

        public int Col { get; set; }

        public int Duration { get; set; }
    }

    public class ProjectDependencyModel { 
        public int Id { get; set; }

        public ProjectModel Source { get; set; }

        public ProjectModel Destination { get; set; }

        public DependencyModel DependencyModel { get; set; }
    }

    public class DependencyModel { 
        public DependencyType DependencyType { get; set; }

        public float Weight { get; set; }
    }

    public enum DependencyType
    {
        Hard, SoftPos, SoftNeg
    }

    public class SimModel {

        public SimModel (){
            Entries = new List<SimEntry>();
        }
        public int ProjectId { get; set; }
        public List<SimEntry> Entries { get; set; }
    }

    public class SimEntry { 
        public int Year { get; set; }
        public double Result { get; set; }
    }
}

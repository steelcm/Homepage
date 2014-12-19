using steelcm.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace steelcm.Models.Projects
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Completion { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public Uri ProjectLink { get; set; }
        public IDictionary<TagEnum, String> Tags { get; set; }
    }
}
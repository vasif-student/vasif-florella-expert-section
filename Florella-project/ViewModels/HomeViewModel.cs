using Florella_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_project.ViewModels
{
    public class HomeViewModel
    {
        public ExpSectionHeader ExpSectionHeader { get; set; }
        public List<Expert> Experts { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ELearningPortalMSAzureV1.Models;
using ELearningPortalMSAzureV1.ViewModels;

namespace ELearningPortalMSAzureV1.ViewModels
{
    public class AddTutorialViewModel : CommonViewModel
    {
        public List<Course> CourseList { get; set; }
        public int TeacherId { get; set; }
    }
}

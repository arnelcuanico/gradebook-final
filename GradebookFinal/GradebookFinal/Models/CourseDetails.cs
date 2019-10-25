using System;
using System.Collections.Generic;
using System.Text;

namespace GradebookFinal.Models
{
    class CourseDetails
    {
        public string coursecode { get; set; }
        public string coursedesc { get; set; }
        public string schedule { get; set; }
        public string room { get; set; }

        public int studcount { get; set; }
        public int studdropcount { get; set; }


    }
}

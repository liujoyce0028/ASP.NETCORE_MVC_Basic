using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    //Now we need to create the View Model which will store the required data that is required for a particular view. 
    //In our case its student’s Details view. This View Model is going to represent the Student Model + Student Address Model + Some additional data like page title and page header.
    public class StudentDetailsViewModel
    {
        public Student Student { get; set; }

        public Address Address { get; set; }

        public string Title { get; set; }

        public string Header { get; set; }
    }
}

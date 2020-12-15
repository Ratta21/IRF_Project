using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_project.Entities
{
  public  class Customer
    {
    
            public String name { get; set; }
            public Gender gender { get; set; }
            public String email { get; set; }
            public int weight { get; set; }
            public int heightFeet { get; set; }
            public int heightInches { get; set; }

            public String leadSource { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_project.Entities
{
  public  class Customers
    {
    
            public String Name { get; set; }
            public Gender Gender { get; set; }
            public String Email { get; set; }
            public int Weight { get; set; }
            public int HeightFeet { get; set; }
            public int HeightInches { get; set; }

            public String Lead_Source { get; set; }



    }
}

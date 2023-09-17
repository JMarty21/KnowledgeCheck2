using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class HikerData : HikingTrailAttributes
    {
        public string HikerFullName { get; set; }
        
        public string HikerFirstName { get; set; }
        public string HikerLastName { get; set; }
        
        public DateOnly DateOfHike { get; set; }
        public DateOnly HikerBirthDate { get; set; }

        public override string ToString()
        {
            return "Hiker Name: " + HikerFullName + ".  Date of Hike: " + DateOfHike + ".  Trail Hiked: " + HikingTrailName;
        }

    }
}

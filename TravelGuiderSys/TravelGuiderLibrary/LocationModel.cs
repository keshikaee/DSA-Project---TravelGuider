using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGuiderLibrary
{
    public class LocationModel
    {
        public int LocationId { get; set; }
        public string? LocationName { get; set; }
        public string? District { get; set; }
        public int Budjet { get; set; }
        public string? Description { get; set; } 
    }
    public class LocationNode
    {
        public LocationModel Location { get; set; }
        public LocationNode? Next { get; set; }

        public LocationNode(LocationModel location)
        {
            Location = location;
            Next = null;
        }
    }
}

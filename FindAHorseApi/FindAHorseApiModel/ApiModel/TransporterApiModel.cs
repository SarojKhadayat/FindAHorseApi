using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAHorseApiModel.ApiModel
{
    public class TransporterApiModel
    {
        public bool IsAirConditioned { get; set; }
        public bool HasCameras { get; set; }
        public bool HasAccomodation { get; set; }
        public Nullable<decimal> Tonnage { get; set; }
        public int Age { get; set; }
        public Nullable<int> RampId { get; set; }
        public string AvailableDates { get; set; }
        public Nullable<int> UserId { get; set; }
        public List<string> ImagePaths { get; set; }
    }
}

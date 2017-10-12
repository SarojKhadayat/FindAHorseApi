using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAHorseApiModel.ApiModel
{
    public class HorseApiModel
    {
        public string Breed { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Other { get; set; }
        public Nullable<int> UserId { get; set; }
        public List<string> ImagePaths { get; set; }
    }
}

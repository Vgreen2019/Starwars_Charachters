using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarPractice.Models
{
    public partial class StarWarsPeopleResponse
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }
        public IEnumerable<StarWarsPersonResponse> Results { get; set; }

    }
}

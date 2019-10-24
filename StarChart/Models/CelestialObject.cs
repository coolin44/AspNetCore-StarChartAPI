using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int Id;

        public int? OrbitedObjectId;

        [Required()]
        public string Name;

        [NotMapped]
        public List<CelestialObject> Satellites;

        public TimeSpan OrbitalPeriod;
    }
}

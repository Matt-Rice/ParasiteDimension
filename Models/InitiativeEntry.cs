using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thing.Models
{
    public class InitiativeEntry
    {
        public int Initiative { get; set; }
        public string Name { get; set; } = string.Empty;
        public string DisplayName => $"{Name} ({Initiative})";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainie.Models
{
    public class NbuFullData
    {
        public Transaction[] Transactions { get; set; }
        public Bond[] Bonds { get; set; }
    }
}

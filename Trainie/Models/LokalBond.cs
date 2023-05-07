using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Trainie.Models
{
    public class LokalBond
    {
        public string cpcod { get; set; }
        public int nominal { get; set; }
        public float auk_proc { get; set; }
        public string pgs_date { get; set; }
        public string razm_date { get; set; }
        public string pay_period { get; set; }
        public string val_code { get; set; }
        public string cptype { get; set; }
        public string cpdescr { get; set; }
        public int emit_okpo { get; set; }
        public string emit_nam { get; set; }
        public int? total_bonds { get; set; }
        public Payment[] payments { get; set; }
    }
}

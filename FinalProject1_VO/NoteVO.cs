using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class NoteVO
    {
        public int note_id { get; set; }
        public int note_userid { get; set; }
        public string note_subject { get; set; }
        public string note_contents { get; set; }
        public int note_readCount { get; set; }
        public string note_date { get; set; }
    }
}

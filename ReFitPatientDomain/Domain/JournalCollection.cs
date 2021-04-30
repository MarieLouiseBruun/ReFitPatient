using System;
using System.Collections.Generic;
using System.Text;

namespace ReFitPatientCore.Domain
{
    public class JournalCollection
    {

        public int ID { get; set; }
        public List<Journal> JournalList { get; set; }= new List<Journal>();
    }
}

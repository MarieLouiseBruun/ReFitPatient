using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ReFitPatientDomain
{
    public class JournalCollection
    {

        public int ID { get; set; }
        public List<Journal> JournalID { get; set; }= new List<Journal>();

    }
}

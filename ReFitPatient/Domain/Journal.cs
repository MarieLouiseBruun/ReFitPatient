﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatient.Domain
{
    //JOURNAL SKAL LAVES OM!
    //Den skal tilbage til de forskellige attributter, og dette kræver en del ændringer i nogle af de andre klasser. HUSK DET
    public class Journal
    {
        //public int PainScale { get; set; }
        //public double BendAngle { get; set; }
        //public string Medicine { get; set; }
        //public string GeneralComment { get; set; }
        //public string ExerciseComment { get; set; }
        public List<string> JournalList { get; set; } = new List<string>();

        //public Journal(int painscale, double bendAngle, string medicine, string generalComment, string exerciseComment)
        //{
        //    PainScale = painscale;
        //    BendAngle = bendAngle;
        //    Medicine = medicine;
        //    GeneralComment = generalComment;
        //    ExerciseComment = exerciseComment;
        //}


        public Journal(List<string> journalList)
        {
            JournalList = journalList;
        }
    }
}

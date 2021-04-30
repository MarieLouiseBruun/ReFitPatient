﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientCore.Domain
{
   
    public class ExercisePackage
    {
        [Key]
        [Required]
        public int ExercisePackageID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required] public bool Completed { get; set; } = false;
        
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
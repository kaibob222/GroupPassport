﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace groupPassport.Classes
{
    public class Teacher : Person
    {

       
        public enum Position
        {
            teacher,
            director,
            curator,

        }; //Должность
       
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommanderCreatDto
    {
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
    }
}

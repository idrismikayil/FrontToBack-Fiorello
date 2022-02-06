﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Expert
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Fullname { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}

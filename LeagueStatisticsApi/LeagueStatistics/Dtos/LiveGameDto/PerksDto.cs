﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueStatistics.Dtos.LiveGameDto
{
    public class PerksDto
    {
        public List<long> perkIds { get; set; }
        public long perkStyle { get; set; }
        public long perkSubStyle { get; set; }
    }
}

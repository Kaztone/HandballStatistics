﻿using System;
using System.Collections.Generic;

namespace HandballStatistics.Models
{
    public class Match : DomainObject
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string FileName { get; set; }

        public ICollection<Shot> Shots { get; set; }

    }
}

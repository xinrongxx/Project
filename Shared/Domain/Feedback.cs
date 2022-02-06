﻿using CarRentalManagement.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Feedback : BaseDomainModel
    {
        public string Rating { get; set; }
        public string Comment { get; set; }
    }
}

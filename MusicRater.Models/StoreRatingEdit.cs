﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRater.Models
{
    public class StoreRatingEdit
    {
        public int StoreRatingId { get; set; }
        public int StoreId { get; set; }
        public decimal StoreIndividualRating { get; set; }
    }
}

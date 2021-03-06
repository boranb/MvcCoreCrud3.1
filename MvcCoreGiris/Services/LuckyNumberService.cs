﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreGiris.Services
{
    // bu servis, bize bir adet rastgele seçilmiş sayı sağlar
    public class LuckyNumberService
    {
        private readonly static Random rnd = new Random();
        public int LuckyNumber { get; set; }
        public LuckyNumberService()
        {
            LuckyNumber = rnd.Next(10);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Base.Time {
    public class TimeManager {

        public static DateTime Now {
            get {
                return DateTime.UtcNow;
            }
        }
    }
}

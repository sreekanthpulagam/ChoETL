﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL
{
    public class ChoCSVFileHeaderConfiguration : ChoFileHeaderConfiguration
    {
        public ChoCSVFileHeaderConfiguration(Type recordType = null, CultureInfo culture = null) : base(recordType, culture)
        { }
    }
}

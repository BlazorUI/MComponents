﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MComponents.MGrid
{
    public class MGridSorterState
    {
        public string ColumnIdentifier { get; set; }

        public MSortDirection Direction { get; set; }

        public int Index { get; set; }
    }
}

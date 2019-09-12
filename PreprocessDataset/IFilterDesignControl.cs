﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CCIUtilities;
using DigitalFilter;

namespace PreprocessDataset
{
    public interface IFilterDesignControl : IValidate
    {
        IIRFilter Filter { get; }

        IIRFilter FinishDesign();

        IIRFilter FilterDesign { get; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBulletCE.Plugins
{
    public interface IControl
    {
        dynamic GetValue();
        void SetValue(dynamic value);
    }
}

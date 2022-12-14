﻿using System;
using System.Collections.Generic;

namespace ZH_QYZ7R7.Models;

public partial class Receptek
{
    public int ReceptId { get; set; }

    public int? FogasId { get; set; }

    public int? NyersanyagId { get; set; }

    public double? Mennyiseg4fo { get; set; }

    public virtual Fogasok? Fogas { get; set; }

    public virtual Nyersanyagok? Nyersanyag { get; set; }
}

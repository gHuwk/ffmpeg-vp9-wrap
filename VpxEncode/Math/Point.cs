﻿using System;

namespace VpxEncode.Math
{
  struct Point
  {
    public int Target { get; set; }
    public int Current { get; set; }

    public override string ToString()
    {
      return String.Format("{0} -> {1}", Target, Current);
    }

    public override int GetHashCode()
    {
      return Target ^ Current;
    }
  }
}
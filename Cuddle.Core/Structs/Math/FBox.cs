﻿using System.Numerics;
using System.Runtime.InteropServices;
using Cuddle.Core.Assets;

namespace Cuddle.Core.Structs.Math;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 0x19)]
public readonly record struct FBox(Vector3 Min, Vector3 Max, bool IsValid) : FStructValue {
    public FBox() : this(Vector3.Zero, Vector3.Zero, false) { }
}

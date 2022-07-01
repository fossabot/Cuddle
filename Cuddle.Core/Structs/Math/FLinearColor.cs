﻿namespace Cuddle.Core.Structs.Math;

public readonly record struct FLinearColor(float R, float G, float B, float A) {
    public FLinearColor() : this(0, 0, 0, 0) { }
}

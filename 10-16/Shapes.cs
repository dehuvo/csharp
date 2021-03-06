﻿using System;
using System.Drawing;

namespace Shapes {
  public class Circle {
    double radius;

    public Circle() {
      radius = 0;
    }

    public Circle(double radius) {
      this.radius = radius;
    }

    public double Area() {
      return Math.PI * (radius * radius);
    }

    public void Draw() {
      Pen p = new Pen(Color.Red);
    }
  }
}
// sn -k Shapes.snk
// csc /t:library /keyfile:Shapes.snk Shapes.cs
// gacutil /i Shapes.dll
// --> C:\Windows\Microsoft.NET\assembly\GAC_MSIL\Shapes
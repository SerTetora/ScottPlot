﻿using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;

namespace ScottPlot.WinForms.OpenGL.GLPrograms;

/// <summary>
/// This program is used by OpenGL plot types
/// </summary>
public class GLLinesProgram : GLProgramBase, ILinesDrawProgram
{
    protected override string VertexShaderSource =>
    @"#version 410 core
      layout(location = 0) in dvec2 aPosition;
      uniform dmat4 transform;

      void main()
      {
        dvec4 posd = dvec4(aPosition, 0.0, 1.0);
        dvec4 transformedD = posd * transform;
        gl_Position = vec4(transformedD);
      }";

    protected override string FragmentShaderSource =>
    @"#version 330 core
      out vec4 FragColor;
      uniform vec4 pathColor;

      void main()
      {
        FragColor = pathColor;
      }";

    public void SetTransform(Matrix4d transform)
    {
        var location = GetUniformLocation("transform");
        GL.UniformMatrix4(location, true, ref transform);
    }

    public void SetColor(Color4 color)
    {
        var location = GetUniformLocation("pathColor");
        GL.Uniform4(location, color);
    }

    public void SetLineWidth(float lineWidth)
    {
        throw new NotSupportedException("Line width not supported");
    }

    public void SetViewPortSize(float width, float height)
    {
    }
}

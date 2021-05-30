﻿using System;
using System.IO;

namespace Paint.Framework.Utils
{
    public class PathFunctions
    {
        public static string GetCombinedPath(string fileName)
        {
            var baseDirectory = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            return Directory.GetParent(baseDirectory).Parent.FullName + fileName;
        }
    }
}

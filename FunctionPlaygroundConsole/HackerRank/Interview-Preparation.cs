using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace FunctionPlayground.HackerRank
{
    public class Interview_Preparation
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int seaLevel = 0;
            int valleysCrossed = 0;

            foreach (char c in s)
            {
                if (c == 'D') { seaLevel--; }
                if (c == 'U') { seaLevel++; }
                if (c == 'U' && seaLevel == 0) { valleysCrossed++; }
            }

            return valleysCrossed;
        }
    }
}
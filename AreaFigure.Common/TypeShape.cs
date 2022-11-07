using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AreaFigure.Common
{
    public static class TypeShape
    {
        public static Dictionary<int, string> Roster = new Dictionary<int, string>()
        {
            {0, "point"},
            {1, "circle"},
            {2, "rectangle"},
            {3, "triangle"}

        };

        public static string DefoultType = "polygone";
    }
    
}
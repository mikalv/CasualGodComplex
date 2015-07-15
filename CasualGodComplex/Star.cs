﻿
using System.Numerics;

namespace CasualGodComplex
{
    public class Star
    {
        public Vector3 Position { get; internal set; }

        public float Size { get; private set; }
        public string Name { get; private set; }

        public float Temperature { get; internal set; }

        public Star(float x, float y, float z, string name)
        {
            Name = name;
            Position = new Vector3(x, y, z);
        }

        public Star(Vector3 position, string name, float temp)
        {
            Name = name;
            Position = position;
            Temperature = temp;
        }
    }
}

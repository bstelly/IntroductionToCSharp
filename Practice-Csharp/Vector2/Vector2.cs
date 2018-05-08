using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vector2
{
    class Vector2
    {
        private float mX;
        private float mY;

        public Vector2()
        {
            mX = 0;
            mY = 0;
        }
        public Vector2(float x, float y)
        {
            mX = x;
            mY = y;
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.mX + rhs.mX, lhs.mY + rhs.mY);
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.mX - rhs.mX, lhs.mY - rhs.mY);
        }

        public static Vector2 operator *(Vector2 vector, int scale)
        {
            return new Vector2(vector.mX * scale, vector.mY * scale);
        }

        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.mX == rhs.mX && lhs.mY == rhs.mY);
        }

        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.mX != rhs.mX && lhs.mY != rhs.mY);
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.mX * rhs.mX) + (lhs.mY * rhs.mY);
        }

        public static float Magnitude(Vector2 vector)
        {
            float result = (float) Math.Sqrt((vector.mX * vector.mX) + (vector.mY * vector.mY));
            return result;
        }

        public static Vector2 Normalize(Vector2 vector)
        {
            return new Vector2(vector.mX / Magnitude(vector), vector.mY / Magnitude(vector));
        }

        public static void Print(Vector2 vector)
        {   Console.Write("<");
            Console.Write(vector.mX);
            Console.Write(", ");
            Console.Write(vector.mY);
            Console.WriteLine(">");
        }
    }
}

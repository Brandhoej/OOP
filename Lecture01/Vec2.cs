using System;

namespace Lecture01 {
    public class Vec2 {
        private double[] coords = new double[2];

        public double X { get => coords[0]; set => coords[0] = value; }

        public double Y { get => coords[1]; set => coords[1] = value; }

        public Vec2(double x, double y) {
            coords[0] = x;
            coords[1] = y;
        }

        public static Vec2 operator +(Vec2 a, Vec2 b) {
            return new Vec2(a.X + b.X, a.Y + b.Y);
        }

        public static Vec2 operator -(Vec2 a, Vec2 b) {
            return new Vec2(a.X - b.X, a.Y - b.Y);
        }

        public static Vec2 operator *(Vec2 vec, double scalar) {
            return new Vec2(vec.X * scalar, vec.Y * scalar);
        }

        public void Add(Vec2 other) {
            X += other.X;
            Y += other.Y;
        }

        public void Subtract(Vec2 other) {
            X -= other.X;
            Y -= other.Y;
        }

        public void Scalar(double scalar) {
            X *= scalar;
            Y *= scalar;
        }

        public double Dot(Vec2 other) {
            return X * other.X + Y * other.Y;
        }
    }
}
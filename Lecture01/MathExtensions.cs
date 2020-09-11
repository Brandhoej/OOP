using System;

namespace Lecture01 {
    public static class MathExtensions {
        public static double DegreesToRadians(double degrees) => degrees * (Math.PI / 180.0);
        public static double RadiansToDegrees(double radians) => radians * (180.0 / Math.PI);
    }
}
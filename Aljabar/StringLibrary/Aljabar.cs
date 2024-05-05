namespace AljabarLibrary
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return new double[0];
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { x1, x2 };
            }
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double akarA = a * a;
            double akarB = b * b;

            double middle = 2 * a * b;

            return new double[] { akarA, middle, akarB };
        }
    }
}

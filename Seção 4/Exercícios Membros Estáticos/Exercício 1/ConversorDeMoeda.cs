namespace Exercício_1
{
    class ConversorDeMoeda
    {
        public static double dollar;

        public static double Conversor(double doll)
        {
            return ((doll * dollar) + (((doll * dollar)*6) /100));
        }
    }
}

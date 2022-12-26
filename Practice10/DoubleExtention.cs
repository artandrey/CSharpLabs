namespace Practice10
{
    static class DoubleExtention
        {
            public static double Flip(this double number)
            {
                return double.Parse(Reverser.flip(number));
            }
        }
}

namespace Practice10
{
    static class StringExtention
    {
        public static string Flip(this string str)
        {
            return Reverser.flip(str);
        }
        public static string Flip(this string str, char sign)
        {
            return Reverser.flip(str, sign);
        }
    }
}

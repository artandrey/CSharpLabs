namespace Practice10
{
    internal static class IntExtention
    {
        public static int Flip(this int integer)
        {

            return int.Parse(Reverser.flip(integer));
        }
    }
}
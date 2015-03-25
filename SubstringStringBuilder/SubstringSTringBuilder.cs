namespace SubstringStringBuilder
{
    using System;
    using System.Text;

    public static class SubstringSB
    {
        public static StringBuilder Substring(this StringBuilder sb, int start, int length)
        {
            StringBuilder subResult = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                subResult.Append(sb[i + start]);
            }

            return subResult;
        }
    }
}

namespace Ays.Extensions
{
    public static class StringExt
    {
        public static string Shorten(this string text, int maxLength)
        {
            W.ArgumentNotNull(text, nameof(text));
            W.ArgumentPositive(maxLength, nameof(maxLength));

            if (text.Length <= maxLength)
            {
                return text;
            }

            return text.Substring(0, maxLength);
        }
    }
}

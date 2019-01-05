using System;

namespace Characteristics.erp.Util
{
    public static class GetList
    {
        /// <summary>
        /// Search <code>Inclusive</code> or <code>Exclusive</code> <see cref="Options"/>
        /// </summary>
        public enum Sing
        {
            Inclusive,
            Exclusive
        }

        /// <summary>
        /// Search <see cref="Options"/>.
        /// </summary>
        public enum Options
        {
            Equal,
            NotEqual,
            BeTween,
            NotBetween,
            LessThan,
            LessEqual,
            GreaterThan,
            GreaterEqual,
            ContainsPattern,
            NotContainsPattern
        }

        /// <summary>
        /// Get value of <see cref="Sing"/>.
        /// </summary>
        /// <param name="o"><see cref="Sing"/></param>
        /// <returns>Returns equivalent string</returns>
        /// <exception cref="ArgumentOutOfRangeException"><see cref="Sing"/> not known</exception>
        public static string ToValue(Sing o)
        {
            switch (o)
            {
                case Sing.Inclusive:
                    return "I";
                case Sing.Exclusive:
                    return "E";
                default:
                    throw new ArgumentOutOfRangeException(nameof(o), o, null);
            }
        }

        /// <summary>
        /// Get value of <see cref="Options"/>
        /// </summary>
        /// <param name="o"><see cref="Options"/></param>
        /// <returns>Returns equivalent string</returns>
        /// <exception cref="ArgumentOutOfRangeException"><see cref="Options"/> not known</exception>
        public static string ToValue(Options o)
        {
            switch (o)
            {
                case Options.Equal:
                    return "EQ";
                case Options.NotEqual:
                    return "NE";
                case Options.BeTween:
                    return "BT";
                case Options.NotBetween:
                    return "NB";
                case Options.LessThan:
                    return "LT";
                case Options.LessEqual:
                    return "LE";
                case Options.GreaterThan:
                    return "GT";
                case Options.GreaterEqual:
                    return "GE";
                case Options.ContainsPattern:
                    return "CP";
                case Options.NotContainsPattern:
                    return "NP";
                default:
                    throw new ArgumentOutOfRangeException(nameof(o), o, null);
            }
        }
    }
}
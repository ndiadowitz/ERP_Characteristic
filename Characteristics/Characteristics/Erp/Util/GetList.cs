using System;

namespace Characteristics.erp.Util
{
    public static class GetList
    {
        public enum Sing
        {
            Inclusive,
            Exclusive
        }

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
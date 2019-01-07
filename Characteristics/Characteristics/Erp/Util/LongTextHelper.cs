using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.Erp.Util
{
    public class LongTextHelper
    {
        public List<LongTextPart> LongTextContainer { get;}

        public LongTextHelper()
        {
            LongTextContainer = new List<LongTextPart>();
        }

        public enum Format
        {
            Default,
            NewLine,
            ControlCommand,
            Comment,
            LongLine,
            LongLineWithNewLine,
            RawLine,
            RawLineWithNewLine,
            FixLine
        }

        public static string ToValue(Format format)
        {
            switch (format)
            {
                case Format.Default:
                    return "*";
                case Format.NewLine:
                    return "/";
                case Format.ControlCommand:
                    return "/:";
                case Format.Comment:
                    return "/*";
                case Format.LongLine:
                    return "=";
                case Format.LongLineWithNewLine:
                    return "/=";
                case Format.RawLine:
                    return "(";
                case Format.RawLineWithNewLine:
                    return "/(";
                case Format.FixLine:
                    return ">x";
                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format, null);
            }
        }

    }

    public class LongTextPart
    {
        public string _format { get; }
        public string _line { get; }

        public LongTextPart(string format, string line)
        {
            _format = format;
            _line = line;
        }
    }
}

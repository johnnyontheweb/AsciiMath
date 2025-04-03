using System.Buffers;
using System.Globalization;
using System.Text;

namespace AsciiMath;

internal static class StringBuilderExtensions
{
    //private static readonly SearchValues<char> ValuesToEscape = SearchValues.Create("&<>");
    private static readonly char[] ValuesToEscape = { '&', '<', '>' }; // Change to char array

    public static StringBuilder AppendEscapedText(this StringBuilder sb, ReadOnlyMemory<char> text, bool escapeNonAscii)
    {
        // check for non-ascii and Values to escape
        if (text.Span.IndexOfAny(ValuesToEscape) == -1
            && (!escapeNonAscii || !ContainsNonAscii(text.Span)))
        {
            // all fine, append everything
            sb.Append(text);
            return sb;
        }

        // need to loop through
        foreach (var c in text.Span)
        {
            if (c == '&')
            {
                sb.Append("&amp;");
            }
            else if (c == '<')
            {
                sb.Append("&lt;");
            }
            else if (c == '>')
            {
                sb.Append("&gt;");
            }
            else if (c > 127 && escapeNonAscii)
            {
                sb.AppendFormat(CultureInfo.InvariantCulture, $"&#x{((int)c):X};");
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb;
    }

    private static bool ContainsNonAscii(ReadOnlySpan<char> span)
    {
        foreach (var c in span)
        {
            if (c > 127)
            {
                return true;
            }
        }
        return false;
    }
}

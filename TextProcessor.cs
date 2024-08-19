namespace MyTextProccesingPackage;
public class TextProcessor
{
    public static string ToUpperCase(string text)
    {
        return text.ToUpper();
    }

    public static string ToLowerCase(string text)
    {
        return text.ToLower();
    }

    public static int CountWords(string text)
    {
        return text.Split(new char[]
        {
            ' ',
            '\t',
            '\n',
            '\r'
        }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

}

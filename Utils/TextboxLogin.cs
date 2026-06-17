using Microsoft.Playwright;
using NUnit.Framework;
namespace Fields;
public static class FieldMappings
{
    public static Dictionary<string, string> TextBoxFields =
        new Dictionary<string, string>()
        {
                { "name", "#userName" },
                { "email", "#userEmail" },
                { "currentaddress", "#currentAddress" },
                { "permanentaddress", "#permanentAddress" }
        };
}


using Microsoft.Playwright;
using NUnit.Framework;

namespace Urlsss;
    public class UrlMap
    {
        public static readonly Dictionary<string, string> Url = new Dictionary<string, string>()
       {
        { "TextBox", "https://demoqa.com/text-box" },
        { "CheckBox", "https://demoqa.com/checkbox" },
        { "RadioButton", "https://demoqa.com/radio-button" },
        { "Buttons", "https://demoqa.com/buttons" },
        { "WebTables", "https://demoqa.com/webtables" },
        { "BrowserWindows", "https://demoqa.com/browser-windows" },
        { "Alerts", "https://demoqa.com/alerts" },
        { "Frames", "https://demoqa.com/frames" },
        { "NestedFrames", "https://demoqa.com/nestedframes" },
        { "ModalDialogs", "https://demoqa.com/modal-dialogs" },
        { "UploadDownload", "https://demoqa.com/upload-download" },
        { "Sortable", "https://demoqa.com/sortable" },
        { "Resizable", "https://demoqa.com/resizable" }
      };
    }

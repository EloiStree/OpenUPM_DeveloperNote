using System.IO;
using UnityEngine;

namespace Eloi
{
    [System.Serializable]
        public class Note_MarkDown 
    {
        [TextArea(0,20)]
        public string m_markdown;

        public void OpenMarkDownInBrowser() {

            OpenMarkDownInBrowser(m_markdown);
        }
       

        public static void OpenMarkDownInBrowser(string text)
        {
            string path = Application.temporaryCachePath + "/Markdown.html";

            string markdownAsHTML = m_formatHtmlMarkdown.Replace("[MARKDOWNHERE]", text);
            File.WriteAllText(path, markdownAsHTML);
            Application.OpenURL(path);
        }

        public static string m_formatHtmlMarkdown = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Markdown to HTML Example</title>
    <!-- Include the showdown.js library from the CDN -->
    <script src=""https://cdn.jsdelivr.net/npm/showdown/dist/showdown.min.js""></script>
</head>
<body>
    <div id=""content"">Loading...</div> <!-- This div will hold the converted HTML content -->

    <script>
        // Function to convert Markdown to HTML and display it
        function displayMarkdown() {
            // Define your Markdown text
            const markdown = `[MARKDOWNHERE]`;

            // Create a new showdown converter
            const converter = new showdown.Converter();

            // Convert Markdown to HTML using the showdown.js library
            const htmlContent = converter.makeHtml(markdown);

            // Inject the HTML into the div with id=""content""
            document.getElementById('content').innerHTML = htmlContent;
        }

        // Call the function when the page is fully loaded
        window.onload = displayMarkdown;
    </script>
</body>
</html>

";

        public void OpenMarkDownAsMarkdownFile()
        {
            OpenMarkDownAsFile(m_markdown,"md");
        }

      

        public static void OpenMarkDownAsFile(string text, string fileExtensionNoDot="md")
        {
            string path = Application.temporaryCachePath + "/Markdown."+ fileExtensionNoDot;
            string image =  text ;
            File.WriteAllText(path, image);
            Application.OpenURL(path);
        }
    }
}

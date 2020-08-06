using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();
            WebKitConverterSettings settings = new WebKitConverterSettings();

            //Set WebKit path
            settings.WebKitPath = "QtBinariesLinux";

            //Assign WebKit settings to HTML converter
            htmlConverter.ConverterSettings = settings;

            //Convert URL to PDF
            PdfDocument document = htmlConverter.Convert("https://www.google.com.co/?gws_rd=ssl");
            FileStream fileStream = new FileStream("Sample.pdf", FileMode.CreateNew, FileAccess.ReadWrite);

            MemoryStream stream = new MemoryStream();
            document.Save(stream);
            var aaa = 2;

            //Save and close the PDF document 
            //document.Save(fileStream);
            //document.Close(true);
        }
    }
}

using System;


namespace windows_downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "https://software-download.microsoft.com/pr/Win11_EnglishInternational_x64.iso?t=cad34527-d346-4b02-8773-d0f19dccbd7f&e=1635022915&h=554f168377044bdbf679bfabcad2e688";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
    }
    }


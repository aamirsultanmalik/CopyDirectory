using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyLib
{
    public class CopyController
    {
        public static string currentFileName = string.Empty;
        public static void Copy(string source, string destination)
        {
            var files = Directory.GetFiles(source);
            var directories = Directory.GetDirectories(source);
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var destinationPath = Path.Combine(destination, fileName);
                currentFileName = fileName;
                File.Copy(file, destinationPath, true);
            }
            foreach (var sourceSubDir in directories)
            {
                var dirName = new DirectoryInfo(sourceSubDir).Name;
                var destinationSubDir = Path.Combine(destination, dirName);
                Directory.CreateDirectory(destinationSubDir);
                Copy(sourceSubDir, destinationSubDir);
                
            }
        }

        public static void CopyLite(string source, string destination)
        {
            var fileName = Path.GetFileName(source);
            var destinationPath = Path.Combine(destination, fileName);
            currentFileName = fileName;
            File.Copy(source, destinationPath, true);
        }
    }
}

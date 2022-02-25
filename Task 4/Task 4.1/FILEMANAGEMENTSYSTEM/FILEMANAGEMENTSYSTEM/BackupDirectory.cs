using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILEMANAGEMENTSYSTEM
{
    class BackupDirectory
    {

        public static void FindDirectory(string _logDirectory, string _sourceDirectory)

        {
            Console.WriteLine("Введите один из нежеуказанных доступных дат для бэкапа:");
            var logDirectory = new DirectoryInfo(_logDirectory + Console.ReadLine());
            if (logDirectory.Exists)
            {
                DirectoryCopy(logDirectory.ToString(), _sourceDirectory, true);
            }
            else
                Console.WriteLine("Такого бэкапа не существует");
        }

        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(destDirName);


            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, true);
            }
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        public static void PrintBackup(string _logDirectory)
        {
            var logDirectory = new DirectoryInfo(_logDirectory);
            if(logDirectory.Exists)
            foreach (var dir in logDirectory.GetDirectories())
            {
                Console.WriteLine(dir.Name);
            }
            else
                Console.WriteLine("список бэкапов пуст");
        }
    }
   
    
}

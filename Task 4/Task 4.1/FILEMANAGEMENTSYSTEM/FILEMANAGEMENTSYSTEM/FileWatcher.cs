using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Serilog;

namespace FILEMANAGEMENTSYSTEM
{
    class FileWatcher
    {
        public static string filePath ;
        public static string copyPath;

        public FileWatcher(string path, string path2)
        {
            filePath = path;
            copyPath = path2;
        }
        
        public void CheckDirectory(FileSystemWatcher watcher)
        {
            
            watcher.Filter = "*.txt";

            watcher.NotifyFilter = NotifyFilters.Attributes
                                | NotifyFilters.CreationTime
                                | NotifyFilters.DirectoryName
                                | NotifyFilters.FileName
                                | NotifyFilters.LastAccess
                                | NotifyFilters.LastWrite;

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;
            watcher.Error += OnError;
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
            Console.ReadLine();
           
            
        }
        public static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
                return;
            Log.Debug($"Изменеие {e.ChangeType} в элементе  {e.Name} по пути {e.FullPath}" + Environment.NewLine);
            SendCopy();

        }
        public static string PrintDT(DateTime date)
        {
            var res = date.Day + "." + date.Month + "." + date.Year + "_"
                + date.Hour + "h" + date.Minute + "m" + date.Second + "s";
            //var res = dt.ToString("F", DateTimeFormatInfo.InvariantInfo);
            return res;
        }

        public static void SendCopy()
        {
            DateTime now = DateTime.Now;
            var newDir = copyPath + PrintDT(now);
            BackupDirectory.DirectoryCopy(filePath, newDir, true);
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            Log.Debug($"Создан элмент  {e.Name} по пути {e.FullPath}" + Environment.NewLine);
            SendCopy();
        }
        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Log.Debug($"Удален элемент: {e.Name} + по пути {e.FullPath}" + Environment.NewLine); 
            SendCopy();
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Log.Debug($"Элемент переименован: Старое имя: {e.OldName} Новое имя: {e.Name} " + Environment.NewLine);
            SendCopy();
        }

        private static void OnError(object sender, ErrorEventArgs e) =>
            Log.Error(e.GetException().ToString());
         
    }
}

using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILEMANAGEMENTSYSTEM
{
    class UI
    {
        public void Start()
        {
            const string path = @"..\..\..\working_folders";
            const string copyPath = @"..\..\..\copy\";
            Log.Logger = (ILogger)new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(@"..\..\..\logger.txt", rollingInterval: RollingInterval.Infinite)
                .CreateLogger();

            

            byte choice = 4;
            do
            {
                Console.Write("Введите режим, в котором хотите работать" + Environment.NewLine
                  + "1 - режим логгирования изменений" + Environment.NewLine
                  + "2 - режим восстановления данных" + Environment.NewLine
                  + "0 - выход" + Environment.NewLine);
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        var dirToDel = new DirectoryInfo(copyPath);
                        if(dirToDel.Exists)
                        Directory.Delete(copyPath, true);
                        break;
                    case 1:
                        Console.Write("Отслеживание изменений начато, для окончания, нажмите любую клавишу ->" + Environment.NewLine);
                        Log.Debug($"Запись в Log начата {DateTime.Now}" + Environment.NewLine);                   
                        
                        try
                        {
                            FileWatcher newFileWatcher = new FileWatcher(path, copyPath);
                            FileSystemWatcher watcher = new FileSystemWatcher(path);
                            newFileWatcher.CheckDirectory(watcher);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                                            
                        Log.Debug($"Запись в Log  {DateTime.Now}" + Environment.NewLine);
                        break;
                    case 2:
                        Console.WriteLine("Доступные бэки:");
                        
                        BackupDirectory.PrintBackup(copyPath);
                        BackupDirectory.FindDirectory(copyPath, path);                                             
                        break;

                }
               

            } while (choice != 0);           
        }
    }
}

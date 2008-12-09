using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace A2
{
    class FileSystemHandler
    {
        private FileSystemWatcher Watcher = new FileSystemWatcher();

        public FileSystemHandler(string _path)
        {
            if (_path == "" || Directory.Exists(_path))
                throw new ArgumentException("Pfad ist ungültig");

            this.Watcher.Path = _path;
            this.Watcher.EnableRaisingEvents = true;
        }

        public void Run()
        {
            this.Watcher.Renamed += new RenamedEventHandler(Watcher_Renamed);
            this.Watcher.Created += new FileSystemEventHandler(Watcher_Created);
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine();
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine();
        }

        public NotifyFilters NotifyFilters
        {
            set
            {
                this.Watcher.NotifyFilter = value;
            }
            get
            {
                return this.Watcher.NotifyFilter;
            }
        }

        public string Filter
        {
            set
            {
                this.Watcher.Filter = value;
            }
            get
            {
                return this.Watcher.Filter;
            }
        }

    }
}

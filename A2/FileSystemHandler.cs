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

        public void Run()
        {
            this.Watcher.Renamed += new RenamedEventHandler(Watcher_Renamed);
            this.Watcher.Created += new FileSystemEventHandler(Watcher_Created);
            this.Watcher.EnableRaisingEvents = true;
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Created " + e.Name);
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Renamed {0} to {1}", e.OldName, e.Name);
        }

        public string Path
        {
            set
            {
                if (value == "" || !Directory.Exists(value))
                    throw new ArgumentException("Pfad ist ungültig");

                this.Watcher.Path = value;
            }
            get
            {
                return this.Watcher.Path;
            }
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

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
            this.Watcher.Created += new FileSystemEventHandler(Watcher_Created);
            this.Watcher.Deleted += new FileSystemEventHandler(Watcher_Deleted);
            this.Watcher.Renamed += new RenamedEventHandler(Watcher_Renamed);
            this.Watcher.Changed += new FileSystemEventHandler(Watcher_Changed);

            this.Watcher.EnableRaisingEvents = true;
            this.Watcher.IncludeSubdirectories = true;
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Created \"{0}\"", e.Name);
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Deleted \"{0}\"", e.Name);
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Renamed \"{0}\" to \"{1}\"", e.OldName, e.Name);
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed \"{0}\"", e.Name);
        }

        public string Path
        {
            set
            {
                if (value == "" || !Directory.Exists(value))
                    throw new ArgumentException("Invalid path.");

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
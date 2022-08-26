﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWorker
{
    public class FileData : IFileData
    {
        public async Task Create(string path)
        {
            using (var sw = new StreamWriter(path))
            {
                await Task.Delay(1000);
                await sw.WriteAsync("se crea el archivo en");
            }
        }
    }
}

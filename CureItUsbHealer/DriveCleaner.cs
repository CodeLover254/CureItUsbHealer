using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CureItImproved
{
    class DriveCleaner
    {
        /// <summary>
        /// Unhides hidden files. Changes attributes of files and removes shortcuts
        /// </summary>
        /// <param name="files"></param>
        public static async Task Clean(string[] files)
        {
            await Task.Run(() =>
            {
                foreach (var path in files)
                {
                    Unhide(path);
                    RemoveReadOnly(path);
                    RemoveSystemAttributes(path);
                    if (path.EndsWith(".lnk"))//remove shortcuts
                    {
                        File.Delete(path);
                    }
                }
            });
        }
        
        /// <summary>
        /// Unhides a file by changing its attribute
        /// </summary>
        /// <param name="filePath"></param>
        private static void Unhide(string filePath)
        {
            File.SetAttributes(filePath,File.GetAttributes(filePath) & ~FileAttributes.Hidden);
        }
        
        /// <summary>
        /// Removes the readonly attribute from a file
        /// </summary>
        /// <param name="filePath"></param>
        private static void RemoveReadOnly(string filePath)
        {
            File.SetAttributes(filePath,File.GetAttributes(filePath) & ~FileAttributes.ReadOnly);
        }
        
        /// <summary>
        /// Removed system attribute from file
        /// </summary>
        /// <param name="filePath"></param>
        private static void RemoveSystemAttributes(string filePath)
        {
            File.SetAttributes(filePath,File.GetAttributes(filePath) & ~FileAttributes.System);
        }
    }
}

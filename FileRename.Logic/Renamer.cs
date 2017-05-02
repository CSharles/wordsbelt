using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRename.Logic
{
    public class Renamer
    {
        public List<string> FileNames { get; set; }
        public string baseAdress { get; set; }
        public List<string> NewNames { get; private set; }
        public List<string> listFiles(string folderAddress)
        {
            var fileNames = new List<string>();
            return fileNames;           
        }
        private List<string> renameFiles(List<string>fileNames, string nameTemplate)
        {
            var newNames = new List<string>();
            foreach (var fileName in fileNames)
            {

            }
            return newNames;
        }
        public Renamer (string baseAddress)
        {
            this.baseAdress = baseAdress;
        }
    }
}

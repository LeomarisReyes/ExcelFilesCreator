using System;
using System.Collections.Generic;

namespace ExcelFilesCreator.Models
{
    public class ExcelStructure
    {
        public List<string> Headers { get; set; } = new List<string>();
        public List<List<string>> Values { get; set; } = new List<List<string>>();
    }
}

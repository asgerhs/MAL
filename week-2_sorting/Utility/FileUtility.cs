using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace week_2_sorting.Utility
{
    public class FileUtility
    {
        public static string[] toStringArray(string path, string delimiterPattern = "[^A-Za-z]+") {
        return File.ReadAllLines(path)
        .SelectMany(line => Regex.Split(line, delimiterPattern))
        .Where(word => !String.IsNullOrEmpty(word))
        .Select(word => word.ToLower())
        .ToArray<string>();
    }
}
}

using System.IO;

namespace Paint.Framework.Utils
{
    public class FileFunctions
    {
        public static bool FileIsChanged(string path)
        {
            FileInfo file = new FileInfo(path);
            return file.CreationTime.Equals(file.LastWriteTime);
        }
    }
}

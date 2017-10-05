using System;

namespace CADHERO
{
    public interface IDirectoryTools
    {
          String[] GetAllFiles(string Path, string SearchPattern, bool AllDirectories);
          bool CreateDirectory(string Path);
          DateTime GetLastWriteTime(string Path);
          DateTime GetLastWriteTimeUtc(string Path);
          DateTime GetLastAccessTime(string Path);
          DateTime GetLastAccessTimeUtc(string Path);
          bool Exists(string Path);
          bool Delete(string Path);
       
    }
}
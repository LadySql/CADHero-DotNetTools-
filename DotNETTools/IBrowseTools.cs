using System.Runtime.InteropServices;

namespace CADHERO
{ 
[Guid("B1568DF6-DADF-4144-A812-E728F2A50165")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
  public interface IBrowseTools
    {
        string SaveFileDialog(string StartUpDirectory, string ExtensionFilter,string defaultFileName);
        string BrowseToFolder();
    }
}

/*
 *  public interface IStringTools
    {
        bool Contains(string Source, string Target);
        void Trim(string Source, char Character);
        void TrimStart(string Source, char Character);
        void TrimEnd(string Source, char Character);
        string ToLower(string Source);
        string ToUpper(string Source);
        bool StartsWith(string Source, string Target);
        bool EndsWith(string Source, string Target);
        int GetHashCode(string Source);
        int IndexOf(string Source, char value);       
        Char[] ToCharArray(string Source);
        int LastIndexOf(string Source, char value);
    }
 *  public interface IBrowseTools
    {
        string SaveFileDialog(string StartUpDirectory, string ExtensionFilter,string defaultFileName);
        string BrowseToFolder();
    }
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
     public interface IFileTools
    {
        bool AppendAllLines(string Path, string[] contents);
        bool AppendAllText(string Path, string contents);
        string[] ReadAllText(string Path);
        bool Exists(string Path);
        bool Delete(string Path);
    }
    public interface IPathTools
    {
        string GetFileNameWithExtension(string Path);
        string ChangeExtension(string Path, string Extension);
        string GetExtension(string Path);
        string Combine(string[] Paths);
        string GetFullPath(string Path);
        char[] GetInvalidPathChars(string Path);
        string GetTempPath();
        bool HasExtension(string Path);
        bool IsPathRooted(string Path);
        string GetDirectoryName(string Path);
        string GetRandomFileName();       
    }
    public interface IInternetTools
    {
        bool DownloadFile(string DownloadURL, string Target);
    }
 */

namespace CADHERO
{
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
}
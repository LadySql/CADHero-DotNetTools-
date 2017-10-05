namespace CADHERO
{
    public interface IFileTools
    {
        bool AppendAllLines(string Path, string[] contents);
        bool AppendAllText(string Path, string contents);
        string[] ReadAllText(string Path);
        bool Exists(string Path);
        bool Delete(string Path);
    }
}
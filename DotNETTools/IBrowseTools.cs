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
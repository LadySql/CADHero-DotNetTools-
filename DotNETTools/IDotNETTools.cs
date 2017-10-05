using System;
using System.Runtime.InteropServices;
namespace CADHERO
{
    [Guid("AB3ADCF6-703D-4B89-ABC6-4CAC18525F77")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IDotNETTools
    {

        IStringTools StringTools { get; }
        IBrowseTools BrowseTools { get; }
        IInternetTools InternetTools { get; }
        IPathTools PathTools { get; }
        IFileTools FileTools { get; }
        string Version { get; }
      
    }



     
}
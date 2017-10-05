using System.Runtime.InteropServices;

namespace CADHERO
{
    [Guid("ED5CA661-27D6-4E93-AD60-AF8CFB7B6B60")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IInternetTools
    {
        bool DownloadFile(string DownloadURL, string Target);
    }
}
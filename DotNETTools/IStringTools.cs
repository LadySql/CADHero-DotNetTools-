using System;
using System.Runtime.InteropServices;

namespace CADHERO
{
    [Guid("7F4F9CFE-265F-4315-977B-0C063197CE6A")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IStringTools
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
}
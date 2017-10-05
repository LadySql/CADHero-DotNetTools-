using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CADHERO
{
    public enum AssemblyInfo
    {
        ProductName,
        CompanyName,
        ProductVersion,
    }

    [ComVisible(true)]
    [Guid("DC87D4DF-2134-45C0-BED7-E971064B8C3A")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("CADHERO.DotNETTools")]
    public class DotNETTools : IDotNETTools
    {
        internal static string GetAssemblyName(AssemblyInfo information)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

            switch (information)
            {
                case AssemblyInfo.CompanyName:
                    return fvi.CompanyName;
                case AssemblyInfo.ProductName:
                    return fvi.ProductName;
                case AssemblyInfo.ProductVersion:
                    string[] splitString = fvi.FileVersion.Split('.');
                    return splitString[0] + "." + splitString[1] + "." + splitString[2];
                default:
                    return string.Empty;
            }
        }
        [DispId(1)]
        public IStringTools StringTools
        {
            get
            {
                return new StringTools();
            }
        }
        [DispId(2)]
        public IBrowseTools BrowseTools
        {
            get
            {
                return new BrowseTools();
            }
        }
        [DispId(3)]
        public IInternetTools InternetTools
        {
            get
            {
                return new InternetTools();
            }
        }
        [DispId(4)]
        public string Version
        {
            get
            {
                string Version = string.Empty;
                Version = string.Format("{0} {1} - {2}", "DotNetTools by CADHERO CONSULTING", GetAssemblyName(AssemblyInfo.ProductVersion),"By using this library, you agree to the terms outlined at www.cadhero.com/dotnettoolseula");
                return Version;  
            }
        }
        [DispId(5)]
        public IPathTools PathTools
        {
            get
            {
                return new PathTools();
            }
        }
        public IFileTools FileTools
        {
            get
            {
                return new FileTools();
            }
        }
        public IDirectoryTools DirectoryTools
        {
            get
            {
                return new DirectoryTools();
            }
        }
    }



    [ComVisible(true)]
    [Guid("030ADC3A-8E36-4A9F-80AC-9229209E6E21")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("CADHERO.StringTools")]
    public class StringTools : IStringTools
    {
        public StringTools()
        {

        }
       
        /// <summary>
        ///  Returns a value indicating whether a specified substring occurs within this string.
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="value"> The string to seek.</param>
        /// <returns> true if the value parameter occurs within this string, or if value is the empty
        ///     string (""); otherwise, false.</returns>
        public bool Contains(string Source, string value)
        {
            if (Source.Contains(value))
                return true;
            return false; 
        }
        public bool EndsWith(string Source, string value)
        {
            return Source.EndsWith(value);
        }
        public int GetHashCode(string Source)
        {
            return Source.GetHashCode();
            
        }
        public int IndexOf(string Source, char value)
        {
            return Source.IndexOf(value);
          
        }
        public Char[] ToCharArray(string Source)
        {
            return Source.ToCharArray();

        }
        public int LastIndexOf(string Source, char value)
        {
            return Source.LastIndexOf(value);

        }
        public bool StartsWith(string Source, string value)
        {
            return Source.StartsWith(value);
        }
        public string ToLower(string Source)
        {
            return Source.ToLower();
        }
        public string ToUpper(string Source)
        {
            return Source.ToUpper();
        }
        public void Trim(string Source, char Character)
        {
            Source.Trim(Character);
        }
        public void TrimEnd(string Source, char Character)
        {
            Source.TrimEnd(Character);
        }
        public void TrimStart(string Source, char Character)
        {
            Source.TrimStart(Character);
           
            
        }

        
    }

    [ComVisible(true)]
    [Guid("589F0EEC-777C-45C7-B92C-0F752735C89D")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("CADHERO.BrowseTools")]
    public class BrowseTools : IBrowseTools
    {
        public BrowseTools()
        {

        }
        public string BrowseToFolder()
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            return folderPath;
        }
        public string SaveFileDialog(string StartUpDirectory, string ExtensionFilter, string defaultFileName)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName =  string.IsNullOrEmpty(defaultFileName) ? string.Empty : defaultFileName ;
            // set filters - this can be done in properties as well
            savefile.Filter =  string.IsNullOrEmpty(ExtensionFilter) ? "Text files (*.txt)|*.txt|All files (*.*)|*.*" : ExtensionFilter; 

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                return savefile.FileName;
            }

            return string.Empty; 
        }
    }


    [ComVisible(true)]
    [Guid("5CA6AC03-17A1-4F89-80BF-B2AC4C4CA6DD")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("CADHERO.InternetTools")]
    public class InternetTools : IInternetTools
    {
        public InternetTools()
        {

        }

        public bool DownloadFile(string DownloadURL, string Target)
        {
            try
            {
                string myStringWebResource = null;
                // Create a new WebClient instance.
                WebClient myWebClient = new WebClient();
                // Concatenate the domain with the Web resource filename.
                myStringWebResource = DownloadURL;
              
                // Download the Web resource and save it into the current filesystem folder.
                myWebClient.DownloadFile(myStringWebResource, Target);
                return true; 
            }
            catch (Exception e)
            {

                return false; 
            }
        }
    }

    [ComVisible(true)]
    [Guid("69384ABC-57D7-4CB6-BA6A-EEDEFAA7FAF7")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("CADHERO.PathTools")]
    public class PathTools : IPathTools
    {
        public PathTools()
        {

        }
        [DispId(1)]
        public string GetFileNameWithExtension(string Path)
        {
            return System.IO.Path.GetFileNameWithoutExtension(Path);
         
        }
        [DispId(2)]
        public string GetExtension(string Path)
        {
            return System.IO.Path.GetExtension(Path);

        }
        [DispId(3)]
        public string GetFullPath(string Path)
        {
            return System.IO.Path.GetFullPath(Path);

        }
        [DispId(4)]
        public char[] GetInvalidPathChars(string Path)
        {
            return System.IO.Path.GetInvalidPathChars();

        }
        [DispId(5)]
        public string GetTempPath()
        {
            return System.IO.Path.GetTempPath();

        }
        [DispId(6)]
        public bool HasExtension(string Path)
        {
            return System.IO.Path.HasExtension(Path);

        }

        public bool IsPathRooted(string Path)
        {
            return System.IO.Path.IsPathRooted(Path);

        }
        public string GetDirectoryName(string Path)
        {
            return System.IO.Path.GetDirectoryName(Path);

        }
        public string GetRandomFileName()
        {
            return System.IO.Path.GetRandomFileName();

        }
       

    }

    [ComVisible(true)]
    [Guid("B5A529E6-67F7-49B8-8542-82810C31AE01")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("CADHERO.FileTools")]
    public class FileTools : IFileTools
    {
        public bool AppendAllLines(string Path, string[] contents)
        {
            try
            {
                System.IO.File.AppendAllLines(Path, contents);
                return true;
            }
            catch (Exception)
            {

                return false; 
            } 

        }
        public bool AppendAllText(string Path, string contents)
        {
            try
            {
                System.IO.File.AppendAllText(Path, contents);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public string[] ReadAllText(string Path)
        {
        
                return System.IO.File.ReadAllLines(Path);
                  
           
        }
        public bool Exists(string Path)
        {

            return System.IO.File.Exists(Path);


        }
        public bool Delete(string Path)
        {
            try
            {
                 System.IO.File.Delete(Path);
                return true; 

            }
            catch (Exception)
            {

                return false; 
            }
          


        }
    }


    [ComVisible(true)]
    [Guid("FA00BDB4-D920-4795-A599-77F3781F68A5")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("CADHERO.DirectoryTools")]
    public class DirectoryTools : IDirectoryTools
    {
        public String[] GetAllFiles(string Path, string SearchPattern, bool AllDirectories)
        {
            try
            {
                var SearchOption = AllDirectories ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly;
                return System.IO.Directory.GetFiles(Path, SearchPattern, SearchOption);
               
            }
            catch (Exception)
            {

                return new string[] { };
            }

        }
        public bool CreateDirectory(string Path)
        {
            try
            {
                System.IO.Directory.CreateDirectory(Path);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public DateTime GetLastWriteTime(string Path)
        {

            return System.IO.Directory.GetLastWriteTime(Path);


        }
        public DateTime GetLastWriteTimeUtc(string Path)
        {

            return System.IO.Directory.GetLastWriteTimeUtc(Path);


        }
        public DateTime GetLastAccessTime(string Path)
        {

            return System.IO.Directory.GetLastAccessTime(Path);


        }
        public DateTime GetLastAccessTimeUtc(string Path)
        {

            return System.IO.Directory.GetLastAccessTimeUtc(Path);


        }
        public bool Exists(string Path)
        {

            return System.IO.Directory.Exists(Path);


        }
        public bool Delete(string Path)
        {
            try
            {
                System.IO.Directory.Delete(Path);
                return true;

            }
            catch (Exception)
            {

                return false;
            }



        }
    }

}

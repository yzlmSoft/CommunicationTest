using System.Runtime.InteropServices;

namespace CommunicationTest
{
    internal static class MainHelpers
    {

        [DllImport("shell32.dll")]
        public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
    }
}
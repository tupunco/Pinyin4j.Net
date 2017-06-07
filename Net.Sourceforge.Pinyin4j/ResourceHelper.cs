using System.IO;
using System.Reflection;

namespace Net.Sourceforge.Pinyin4j
{
    /// <summary>
    /// Helper class for file resources
    /// </summary>
    internal static class ResourceHelper
    {
        /// <summary>
        ///  Current Assembly
        /// </summary>
        private static Assembly asm = null;

        /// <summary>
        /// Current Assembly
        /// </summary>
        private static Assembly Asm
        {
            get
            {
                if (asm == null)
                    asm = Assembly.GetExecutingAssembly();
                return asm;
            }
        }

        /// <summary>
        /// resource (mainly file in file system or file in compressed package) as BufferedInputStream
        /// </summary>
        /// <param name="resourceName">resourceName</param>
        /// <returns></returns>
        public static Stream GetResourceInputStream(string resourceName)
        {
            return Asm.GetManifestResourceStream(string.Format("{0}.{1}", Asm.GetName().Name, resourceName));
        }
    }
}
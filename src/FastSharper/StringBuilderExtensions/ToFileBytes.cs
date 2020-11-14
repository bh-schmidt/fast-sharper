using System.IO;
using System.Text;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Writes the <paramref name="src"/> to a stream and get its bytes.
        /// </summary>
        /// <param name="src"></param>
        /// <exception cref="System.ArgumentNullException">src is null.</exception>
        /// <returns></returns>
        public static byte[] ToFileBytes(this StringBuilder src)
        {
            if (src is null)
                throw new System.ArgumentNullException(nameof(src));

            using var memoryStream = new MemoryStream();
            using var streamWriter = new StreamWriter(memoryStream);

            streamWriter.Write(src);
            streamWriter.Flush();

            return memoryStream.ToArray();
        }
    }
}

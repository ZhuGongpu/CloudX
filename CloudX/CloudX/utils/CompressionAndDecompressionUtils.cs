using System.IO;
using System.IO.Compression;
using SnappyPI;

namespace CloudX.utils
{
    internal class CompressionAndDecompressionUtils
    {
        public static byte[] SnappyCompress(byte[] input)
        {
            return SnappyCodec.Compress(input, 0, input.Length);
        }

        public static byte[] GZipCompress(byte[] source)
        {
            var memoryStream = new MemoryStream();
            var stream = new GZipStream(memoryStream, CompressionMode.Compress);
            stream.Write(source, 0, source.Length);
            stream.Flush();
            stream.Close();

            //Console.WriteLine("GZip : {0}", memoryStream.ToArray().Length);

            return memoryStream.ToArray();
        }
    }
}
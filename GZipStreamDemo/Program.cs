using System;
using System.IO;
using System.IO.Compression;

public class GZipTest
{
    private static void usage()
    {
        Console.WriteLine("My test GZip program");
        Console.WriteLine("gziptest [filename to be compressed]");
    }

    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            usage();
            return;
        }
        else
        {
            string inputFile = args[0];
            string outputFile = inputFile + ".gz";

            try
            {
                // Get bytes from input stream
                FileStream inFileStream = new FileStream(Path.Combine(Environment.CurrentDirectory, inputFile), FileMode.Open);
                byte[] buffer = new byte[inFileStream.Length];
                inFileStream.Read(buffer, 0, buffer.Length);
                inFileStream.Close();

                // Create GZip file stream and compress input bytes
                FileStream outFileStream = new FileStream(Path.Combine(Environment.CurrentDirectory, outputFile), FileMode.Create);
                GZipStream compressedStream = new GZipStream(outFileStream, CompressionMode.Compress);
                compressedStream.Write(buffer, 0, buffer.Length);
                compressedStream.Close();
                outFileStream.Close();

                Console.WriteLine("The file has been compressed.  UR Da Bomb!!!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: Specified file cannot be found.");
            }
        }
    }
}
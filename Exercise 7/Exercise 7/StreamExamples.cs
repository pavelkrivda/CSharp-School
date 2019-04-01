using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    public class StreamExamples
    {
        public static void FileExample()
        {
            //const string testPath01 = "text.txt";
            //if (!File.Exists(testPath01))
            //{
            //    FileStream text1 = File.Create(testPath01);
            //}

            //const string testPath02 = "textWithBuffer.txt";
            //if (!File.Exists(testPath02))
            //{
            //    FileStream text2 = File.Create(testPath02, sizeof(int) * 100,
            //          FileOptions.Encrypted | FileOptions.Asynchronous);
            //}

            const string testPath01 = "text.txt";
            const string testPath02 = "textWithBuffer.txt";

            if (!File.Exists(testPath01))
            {
                //FileStream text2 = File.Create(testPath2, sizeof(int) * 100, 
                //    FileOptions.Encrypted | FileOptions.Asynchronous);

                //text2.Flush();


                using (StreamWriter sw = File.CreateText(testPath01))
                {
                    sw.Write("test text");
                }
            }


            FileInfo fileInfoTest = new FileInfo(testPath01);
            if (fileInfoTest.Exists)
            {
                FileStream sw = fileInfoTest.Create();
                sw.Close();

                using (FileStream sw1 = fileInfoTest.Create())
                {

                }
            }

            DriveInfo di = new DriveInfo("C");
            var freeSpace = di.TotalFreeSpace;
            var totalSpace = di.TotalSize;
            Console.WriteLine();
        }
    }
}

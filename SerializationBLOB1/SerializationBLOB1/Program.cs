using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationBLOB1
{
    [Serializable]
    class Program
    {   
        static void Main(string[] args)
        {
            List<string> blobVictims = new List<string>();
            blobVictims.Add("Gary");
            blobVictims.Add("Carl");

            string fileDir = @"D:\Documents";
            string serializedFile = Path.Combine(fileDir, "blob.txt");

            /// <summary>
            /// This will serialize the object and create the txt file
            /// </summary>
            using (Stream stream = File.Open(serializedFile, FileMode.Create))
            {
                var binFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binFormatter.Serialize(stream, blobVictims);
                Console.WriteLine(blobVictims);
            }

            /// <summary>
            /// This will deserialize the object and show the blob object in the console window
            /// </summary>
            using (Stream stream = File.Open(serializedFile, FileMode.Open))
            {
                var binFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                List<string> blobOpen = (List<string>)binFormatter.Deserialize(stream);
                Console.WriteLine(blobOpen);
            }
            Console.Read();

        } 



    }
}

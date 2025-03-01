using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // include the system.io namespace
namespace W_3_school
{ 
     class Files
    {
        static void Main()
        {
                         // path of file to create this location
            string filePath = "C:\\Users\\ASUS\\Desktop\\textfile1.txt";
            string content1F = "Using by the file.Create() This method creates an empty file\n";

            // 1.Create a new file
            File.Create(filePath).Close();//close() releases the file handle
            Console.WriteLine("File created Successfully...!");

            // 2.Writing to a file
            // you can use the File.WriteAllText() and File.AppendAllText()
            File.WriteAllText(filePath,content1F);// Write to a file (overwrites if exists)

            // 3.Appending Data to a File
            // If you want to add data without overwriting,
            // use File.AppendAllText()
            string morecontent = "this is append method.\n";
            File.AppendAllText(filePath,morecontent);

            // 4.Reading from a file
            // you can use File.ReadAllText(),File.ReadAllLines() to read data
            // File.ReadAllText(filePath); --> Reads the entire file and returns it as a 
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);

            // 5.Reading a file line by line
            // File.ReadAllLines(filePath);
            // → Reads all lines into a string array and processes them in a loop.
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            // 6.Using StreamWriter (for large files)
            // if you need to write a file efficiently,use streamwriter
            using (StreamWriter w = new StreamWriter(filePath))
            {
                w.WriteLine("// path of file to create this location\r\nstring filePath = \"C:\\\\Users\\\\ASUS\\\\Desktop\\\\textfile1\";\r\nstring content1F = \"Using by the file.Create() This method creates an empty file\\n\";\r\n" + 
                    "1.Create a new file\r\nFile.Create(filePath).Close();//close() releases the file handle" +
                    "2.Writing to a file\r\n// you can use the File.WriteAllText() and File.AppendAllText()\n " +
                    "3.Appending Data to a File\r\n// If you want to add data without overwriting,\r\n// use File.AppendAllText()\n " +
                    "4.Reading from a file\r\n// you can use File.ReadAllText(),File.ReadAllLines() to read data\r\n// File.ReadAllText(filePath); --> Reads the entire file and returns it as a\n" +
                    "5.Reading a file line by line\r\n// File.ReadAllLines(filePath);\r\n// → Reads all lines into a string array and processes them in a loop.\n" +
                    "6.Using StreamWriter (for large files)\r\n// if you need to write a file efficiently,use streamwriter \n" +
                    "7.Using StreamReader (for large Files)\r\n// for efficient file reading use streamReader \r\n// Reads a file line by line (useful for large files to avoid memory overload).\n" +
                    "8.Checking if a File Exists\r\n// File.Exists(filePath);\r\n// -> Checks if the file exists before performing operations.\n" +
                    "9.Copy a file \r\n// sourceFilePath → The path of the existing file to copy.\r\n// destinationFilePath → The path where the new copied file will be created" +
                    "10.Delete the file\r\n// The File.Delete() method is used to delete an existing file from the system");
            }

            // 7.using StreamReader (for large Files)
            // for efficient file reading use streamReader 
            // Reads a file line by line (useful for large files to avoid memory overload).
            using (StreamReader r = new StreamReader(filePath))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // 8.Checking if a File Exists
            // File.Exists(filePath);
            // → Checks if the file exists before performing operations.
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            // 9.Copy a file 
            // sourceFilePath → The path of the existing file to copy.
            // destinationFilePath → The path where the new copied file will be created.
            string copytextfile = "C:\\Users\\ASUS\\Desktop\\copytextfile.txt";
            try
            {
                //By passing true, the File.Copy() method overwrites the file if it already exists.
                File.Copy(filePath, copytextfile , true);
                Console.WriteLine("File copied and overwritten Successfully..!");
            }
            catch (IOException e)
            {
                /*IOException	       -Destination file already exists and overwrite is false
                FileNotFoundException  -Source file does not exist
            UnauthorizedAccessException-No permission to access the file
                 ArgumentException	   -Invalid file path provided*/
                Console.WriteLine("Error: "+ e.Message);
            }

            // 10.Delete the file
            // The File.Delete() method is used to delete an existing file from the system.
            string newfile = "C:\\Users\\ASUS\\Desktop\\newfile.txt";
            File.Create(newfile).Close();
            string newfilec = "new file content";
            File.WriteAllText(newfile,newfilec);
            string newfilecr = File.ReadAllText(newfile);
            Console.WriteLine(newfilecr);

            try
            {
                // If the file does not exist, it will not throw an error but simply do nothing
                /* if (File.Exists(newfile))
                 {
                     File.Delete(newfile);
                     Console.WriteLine("File deleted successfully..!");
                 }
                 else
                 {
                     Console.WriteLine("file not found..!");
                 }
                 */

                //If the file is open in another program, you'll see an error like
                File.Delete(newfile);
                Console.WriteLine("file deleted..!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
/* 
       Operation                            Method
    Write to File	    -->         File.WriteAllText(), StreamWriter
    Append to File	    -->         File.AppendAllText(), StreamWriter
    Read File (Full)	-->         File.ReadAllText()
    Read File (Line by Line) -->    File.ReadAllLines(), StreamReader
    Check File Exists	-->         File.Exists()
    Copy a file         -->         File.Copy()
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp110_worksheet_7
{
	public static class DirectoryUtils
	{
		// Return the size, in bytes, of the given file
		public static long GetFileSize(string filePath)
		{
			return new FileInfo(filePath).Length;
		}

		// Return true if the given path points to a directory, false if it points to a file
		public static bool IsDirectory(string path)
		{
			return File.GetAttributes(path).HasFlag(FileAttributes.Directory);
		}

		// Return the total size, in bytes, of all the files below the given directory
		public static long GetTotalSize(string directory)
		{



            string[] files = Directory.GetFiles(directory, "*ProfileHandler.cs", SearchOption.AllDirectories); // search pattern? 

            int Total_Size = 0;

            int number_of_files = files.Length;  //start from midpoint? 
            
            foreach (string file in files){

                int File_Size = 0; // 
                Total_Size = Total_Size + File_Size;           
            
            }


			throw new NotImplementedException();
		}

		// Return the number of files (not counting directories) below the given directory
		public static int CountFiles(string directory)
		{


            Directory.GetFiles(directory, "*ProfileHandler.cs", SearchOption.TopDirectoryOnly);   // same as above with just this line changed?

            throw new NotImplementedException();

        }

		// Return the nesting depth of the given directory. A directory containing only files (no subdirectories) has a depth of 0.
		public static int GetDepth(string directory)
		{

            // using GetDirectorys?

            throw new NotImplementedException();
                        
		}

		// Get the path and size (in bytes) of the smallest file below the given directory
		public static Tuple<string, long> GetSmallestFile(string directory)
		{
			throw new NotImplementedException();


		}

		// Get the path and size (in bytes) of the largest file below the given directory
		public static Tuple<string, long> GetLargestFile(string directory)
		{
			throw new NotImplementedException();
		}

		// Get all files whose size is equal to the given value (in bytes) below the given directory
		public static IEnumerable<string> GetFilesOfSize(string directory, long size)
		{

            List<string> Files_That_Match = new List<string>();

            // loop through all files adding the ones that match to a list,



            throw new NotImplementedException();              

		}
	}
}

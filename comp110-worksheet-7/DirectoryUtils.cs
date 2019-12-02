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
            
            string[] files = Directory.GetFileSystemEntries(directory); // search pattern? 

            long Total_Size = 0;            
            
            foreach (string element in files){
                if (IsDirectory(element))
                {
                    Total_Size = Total_Size + GetTotalSize(element);
                }
                else{
                    Total_Size = Total_Size + GetFileSize(element);
                }                             
            }


			return Total_Size;
		}

		// Return the number of files (not counting directories) below the given directory
		public static int CountFiles(string directory)
		{

            string[] files = Directory.GetFileSystemEntries(directory); // search pattern? 

            int file_count = 0;

            foreach (string element in files)
            {
                if (IsDirectory(element))
                {
                    file_count = file_count + CountFiles(element);                   
                }
                else
                {
                    file_count ++; 
                }
            }


            return file_count;                                          
        }

		// Return the nesting depth of the given directory. A directory containing only files (no subdirectories) has a depth of 0.
		public static int GetDepth(string directory)
		{
            int Current_Depth = 0;

            string[] Array_Of_Directories = Directory.GetDirectories(directory);

            foreach (string element in Array_Of_Directories) {
                
                int New_Depth = GetDepth(element);
                if (New_Depth > Current_Depth) {
                    Current_Depth = New_Depth;
                }            
            }

            //Console.WriteLine(Current_Depth++);
            Current_Depth++;
            return Current_Depth;
            
                        
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

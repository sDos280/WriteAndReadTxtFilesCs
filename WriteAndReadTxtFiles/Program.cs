//Write a text file - Version 2
using System;
using System.IO;
using System.Text;
namespace readwriteapp
{
    class getFileData
    {
        public static int[,] getDataFromFile(string path, int rows, int columns)
        {
            int[,] data = new int[rows, columns];
            String? line;
            
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(path, true);
                //Continue to read until you reach end of file
                for (int i = 0; i <= rows; i++)
                {
                    line = sr.ReadLine();
                    if (line != null) 
                    { 
                        Char[] dataChar = line.ToCharArray();
                        for (int j = 0; j < dataChar.Length; j++)
                        {
                            data[i, j] = (int)dataChar[j];
                            //data[i, j] = CharToInt(dataChar[j]);
                        }

                    }

                }
                //close the file
                sr.Close();
                return data;
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return data;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public static int CharToInt(char c) // https://stackoverflow.com/questions/239103/convert-char-to-int-in-c-sharp
        {
            return 0b0000_1111 & (byte)c;
        }
    }
}
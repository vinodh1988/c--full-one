using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.Json;


namespace ObjectOriented.Glencore
{
    internal class FileProcessing
    {
        public static void WriteFile(string FileName, string contentToWrite)
        {
            try
            {
                string path = "e:\\files\\" + FileName;

                // Write content to the text file
                File.WriteAllText(path, contentToWrite);
                Console.WriteLine($"Content written to {path}");
            }
            catch (Exception e)
            when (e is IOException | e is InvalidOperationException)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().Name);
            }

        }

        public static void ReadFile(string FileName)
        {

            string path = "e:\\files\\" + FileName;

            // Read content from the text file
            if (File.Exists(path))
            {
                string contentRead = File.ReadAllText(path);
                Console.WriteLine("Content Read from File: " + contentRead);
            }
            else
            {
                Console.WriteLine($"{path} does not exist.");
            }


        }

        public static void SerializeFile(string FileName, List<Book> books)
        {


            // Serialize the array to JSON
            string jsonString = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });

            // Define the path to the file
            string filePath = "e:\\files\\" + FileName;

            // Write the JSON string to the file
            File.WriteAllText(filePath, jsonString);

            Console.WriteLine($"JSON data has been written to {filePath}");
        }


        public static List<Book> ReadBooksFromFile(string filePath)
        {
            try
            {
                // Read the JSON string from the file
                string jsonString = File.ReadAllText("e:\\files\\" + filePath);

                // Deserialize the JSON string to a list of Product objects
                List<Book> books = JsonSerializer.Deserialize<List<Book>>(jsonString);

                return books;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<Book>();
            }
        }

    }
}



/*
public void SerializeFile(string FileName,List<Book> books) {

         // Serialize object to binary file
         BinaryFormatter formatter = new BinaryFormatter();
         using (FileStream stream = new FileStream("e:files"+FileName, FileMode.Create))
      {
          foreach(Books book:books)
              formatter.Serialize(stream, book);

             Console.WriteLine("Person object serialized to person.bin");
     }
 }*/


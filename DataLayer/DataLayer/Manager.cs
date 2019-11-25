using Newtonsoft.Json;
using System;
using System.IO;

namespace DataLayer
{

    /// <summary> Manager is used to sotere data in JSON files. </summary>
    
    public class Manager
    {
        private const string PATH = "..\\..\\..\\Storage\\";

        ///<summary> Save data in JSON file. </summary>
        ///<return> JSON format in string or NUll if the contain is null or the file is not exist.</return>
        ///<param name="FileName"> Name used to save </param>
        /// <exception cref="IOException">
        /// the file is not found.
        /// </exception>
        public static string loadJson(string FileName)
        {
            string path = PATH + FileName;
            try {
                if (File.Exists(path))
                {
                    string data = System.IO.File.ReadAllText(path);
                    if (data.Trim() == "")
                        return null;
                    else
                        return data;
                }
                File.Create(path);
            }
            catch (IOException e)
            {
                Console.WriteLine("Load Error File");
            }
            catch (Exception e)
            {
                Console.WriteLine("Fatal Error");
            }
            return null;
        }

        ///<summary> Save data in JSON file. </summary>
        ///<return> Return TRUE if the process is correct or FALSE if error occurred</return>
        ///<param name="FileName"> Name used to save </param>
        /// <exception cref="IOException">
        /// the file is not found.
        /// </exception>
        /// <exception cref="JsonSerializationException">
        /// Serialization Json error.
        /// </exception>
        public static bool saveJson(string FileName, object data)
        {
            try {
                string json = JsonConvert.SerializeObject(data);
                System.IO.File.WriteAllText(PATH+FileName, json);
                Console.WriteLine("Save");
                return true;
            }
            catch (JsonSerializationException e)
            {
                Console.WriteLine("serialization Error");
            }
            catch (IOException e)
            {
                Console.WriteLine("Save Error");
            }
            catch (Exception e) {
                Console.WriteLine("Fatal Error!");
                
            }
            return false;
        }

    }
}

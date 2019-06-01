using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;
using AbstractClassLibrary;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ZipInterface;
using System.Reflection;



namespace OOP2
{

    class Serializer

    {
       
      

        
        SaveFileDialog saveDialog = new SaveFileDialog();
        string fileName = null;
        readonly JsonSerializerSettings settings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
        public string Serialize(List<InboxClass> listIn, List<EventClass> listEv, List<ProjCl> listPr, List<SubProj> listSub, Array array)
        {
            array = new Array(listIn, listEv, listPr, listSub);
            saveDialog.DefaultExt = ".json";
            saveDialog.Filter = "Text files (*.txt)|*txt| JSON files (*.json)|*json| XML files (*.xml)|*xml| DAT files (*.dat)|*dat| BIN files (*.bin)|*bin";
            saveDialog.ShowDialog();
            string fileName = saveDialog.FileName;
            string filename1 = fileName;
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate | FileMode.Truncate))
                {
                    var json = JsonConvert.SerializeObject(array, Formatting.None, settings);
                    var writeStream = new StreamWriter(fs);
                    writeStream.Write(json);
                    writeStream.Flush();
                    


                }
                 
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return filename1;

        }

        public Array Deserialize(List<InboxClass> listIn, List<EventClass> listEv, List<ProjCl> listPr, List<SubProj> listSub, Array array, string fileName)
        {
            try
            {
                using (var fStream = File.OpenRead(fileName))
                {
                    
                    try
                    {
                            var json = new StreamReader(fStream).ReadToEnd();
                        if (".txt" == Path.GetExtension(fileName))
                        {
                            var array1 = JsonConvert.DeserializeObject<Array>(File.ReadAllText(fileName));
                            array = array1;
                        }
                        else
                        {
                            var array1 = JsonConvert.DeserializeObject<Array>(json, settings);
                            array = array1;
                        }
                            
                        
                    }
                    
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        array = null;
                    }
                }
            

             }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return array;
        
        }

        
    }
}

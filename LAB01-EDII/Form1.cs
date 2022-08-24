using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace LAB01_EDII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tPInsertar_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string InsertData = "";
            string DeleteData = "";
            string PatchData = "";

            //Open File Dialog
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;

                GetData(file, ref InsertData, ref DeleteData, ref PatchData);
                File.WriteAllText("InsertData.json", InsertData);
                File.WriteAllText("PatchData.json", PatchData);
                File.WriteAllText("DeleteData.json", DeleteData);

                ConvertJSONtoCS();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir el archivo correctamente");
            }
        }

        //Converts a CSV to JSON
        public string CSVtoJSON(string file)
        {
            var csv = new List<string[]>();
            var lines = File.ReadAllLines(file);

            foreach (string line in lines)
                csv.Add(line.Split(','));

            var properties = lines[0].Split(',');

            var listObjResult = new List<Dictionary<string, string>>();

            for (int i = 1; i < lines.Length; i++)
            {
                var objResult = new Dictionary<string, string>();
                for (int j = 0; j < properties.Length; j++)
                    objResult.Add(properties[j], csv[i][j]);

                listObjResult.Add(objResult);
            }

            return JsonConvert.SerializeObject(listObjResult);
        }
        
        public void GetData(string file, ref string InsertData, ref string PatchData, ref string DeleteData)
        {

            foreach (string line in File.ReadLines(file))
            {
                if (line.Contains("INSERT"))
                {
                    string temp = line.Remove(0, 7); //Remove INSERT;"
                    InsertData += (temp + "\n");
                }
                else if (line.Contains("PATCH"))
                {
                    string temp = line.Remove(0, 6); //Remove PATCH;"
                    PatchData += temp;
                }
                else
                {
                    string temp = line.Remove(0, 7); //Remove DELETE;"
                    DeleteData += temp;
                }

            }
        }

        public static void ConvertJSONtoCS()
        {
            string PathInsert = @"C:\Users\danie\OneDrive - Universidad Rafael Landivar\Escritorio\Universidad\Ciclo IV\Estructura de Datos II\Práctica\LAB 01\LAB01-EDII-2022\LAB01-EDII\bin\Debug\InsertData.json";

            if (System.IO.File.Exists(PathInsert))
            {
                foreach (string line in File.ReadLines(PathInsert))
                {
                    Person person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(line);
                    InsertToTree(person);
                    
                }
            }


        }

        public static void InsertToTree(Person person)
        {
            Node<Person> NewNodeDPI = new Node<Person>(person);
            Node<Person> NewNodeName = new Node<Person>(person);

            if (!Data.Instance.DPITree.Contains(Data.Instance.DPITree.Root, NewNodeDPI))
            {
                Data.Instance.DPITree.Root = Data.Instance.DPITree.Insert(Data.Instance.DPITree.Root, NewNodeDPI);
                Data.Instance.NameTree.Root = Data.Instance.NameTree.Insert(Data.Instance.NameTree.Root, NewNodeName);

            }
            else
            {
                MessageBox.Show("Una persona ingresada tiene el mismo DPI que otra persona. Por favor, corrige el error.");
            }
        }
    }
}

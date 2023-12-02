using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policy
{
    class Base
    {
        private Dictionary<LicencePlate, List<Crime>> police_base;
        const string delimiter = "\n------------------------------------\n";
        public Base(Dictionary<LicencePlate, List<Crime>> police_base)
        {
            this.police_base = new Dictionary<LicencePlate, List<Crime>>(police_base);
        }
        public void Print()
        {
            foreach (KeyValuePair<LicencePlate, List<Crime>> i in police_base)
            {
                Console.WriteLine($"{i.Key}:\n");
                foreach (Crime j in i.Value)
                {
                    Console.WriteLine($"\t{j}");
                }
                Console.WriteLine(delimiter);
            }
        }
        public void Save(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (KeyValuePair<LicencePlate, List<Crime>> i in police_base)
            {
                sw.Write(i.Key + ":");
                foreach (Crime j in i.Value)
                {
                    sw.Write(j + ",");
                }
                sw.WriteLine();
            }
            sw.Close();
            System.Diagnostics.Process.Start("notepad", filename);
        }
        public void Load(string filename)
        {
            string line;
            //string crimes;
            StreamReader sr = new StreamReader(filename);
            Dictionary<LicencePlate, List<Crime>> police = new Dictionary<LicencePlate, List<Crime>>();
            line = sr.ReadLine().Trim();
            //string[] crimes = line.Split(',', ' ');
            for (int i = 0; i<line.Length;i++)
            {
                string[] crimes = line.Split("ул", ".",);
            }
            /*foreach (KeyValuePair<LicencePlate, List<Crime>> i in filename)
            {
                foreach (Crime j in i.Value)
                {
                    
                }
                line = sr.ReadLine();
            }*/
            /*foreach ()
            {
            policy.Add(new Crime())
                //line = sr.ReadLine().Trim();
            }*/
        }
    }
}

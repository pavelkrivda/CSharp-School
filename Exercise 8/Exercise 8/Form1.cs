using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Exercise_8
{
    public partial class Form1 : Form
    {
        private List<String> poleKoncovek;
        private List<int> pocetKoncovek;
        private string[] files;
        private string[] direcotries;
        private string[] koncovky;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*",
                     SearchOption.AllDirectories);

                direcotries = Directory.GetDirectories(folderBrowserDialog1.SelectedPath, "*.*",
                    SearchOption.AllDirectories);
            }
            else
            {
                FileInfo temp = new FileInfo(Assembly.GetExecutingAssembly().Location);

                files = Directory.GetFiles(temp.Directory.FullName, "*.*",
                    SearchOption.AllDirectories);

                direcotries = Directory.GetDirectories(temp.Directory.FullName, "*.*",
                    SearchOption.AllDirectories);
            }

            listBox1.Items.AddRange(files);
            listBox2.Items.AddRange(direcotries);

            poleKoncovek = new List<string>();
            foreach (var file in files)
            {
                poleKoncovek.Add(new FileInfo(file).Extension); ;
            }

            var koncovky = from s in poleKoncovek
                group s by s into sg
                select new { sg.Key };

            pocetKoncovek = new List<int>();
            foreach (var koncovka in koncovky)
            {
                pocetKoncovek.Add((from x in poleKoncovek where x.Equals(koncovka.Key) select x).Count());
                listBox4.Items.Add(koncovka.Key + "\t\t" + pocetKoncovek[pocetKoncovek.Count - 1]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            FileInfo file = new FileInfo(listBox1.Items[listBox1.SelectedIndex].ToString());
            listBox3.Items.Add("Name: " + file.Name);
            listBox3.Items.Add("Directory name: " + file.DirectoryName);
            listBox3.Items.Add("File name: " + file.FullName);
            listBox3.Items.Add("Create time: " + file.CreationTime);
            listBox3.Items.Add("Last access time: " + file.LastAccessTime);
            listBox3.Items.Add("Last write time: " + file.LastWriteTime);
            listBox3.Items.Add("Size: " + file.Length);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(listBox2.Items[listBox2.SelectedIndex].ToString());
            listBox3.Items.Add("Name: " + directory.Name);
            listBox3.Items.Add("File name: " + directory.FullName);
            listBox3.Items.Add("Create time: " + directory.CreationTime);
            listBox3.Items.Add("Last access time: " + directory.LastAccessTime);
            listBox3.Items.Add("Last write time: " + directory.LastWriteTime);
            listBox3.Items.Add("Size: " + directory.EnumerateFiles().Sum(file => file.Length));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var koncovky = from s in poleKoncovek
                group s by s into sg
                select new { sg.Key };

            if (!File.Exists(@"D:\fileInfo.txt"))
            {
                File.Create(@"D:\fileInfo.txt");
            }

            using (StreamWriter sw = new StreamWriter(@"D:\fileInfo.txt", false, Encoding.UTF8))
            {
                sw.WriteLine("Koncovky a počet koncovek: ");

                int index = 0;
                foreach (var koncovka in koncovky)
                {
                    sw.WriteLine(koncovka.Key + " " + pocetKoncovek[index++]);
                }
                sw.WriteLine();

                sw.WriteLine("Soubory: ");
                foreach (var file in files)
                {
                    sw.WriteLine(file);
                    FileInfo fileInfo = new FileInfo(file);
                    sw.WriteLine("Name: " + fileInfo.Name);
                    sw.WriteLine("Directory name: " + fileInfo.DirectoryName);
                    sw.WriteLine("File name: " + fileInfo.FullName);
                    sw.WriteLine("Create time: " + fileInfo.CreationTime);
                    sw.WriteLine("Last access time: " + fileInfo.LastAccessTime);
                    sw.WriteLine("Last write time: " + fileInfo.LastWriteTime);
                    sw.WriteLine("Size: " + fileInfo.Length);
                    sw.WriteLine();
                }

                sw.WriteLine("Adresáře: ");
                foreach (var direcotry in direcotries)
                {
                    sw.WriteLine(direcotry);
                    DirectoryInfo directory = new DirectoryInfo(direcotry);
                    sw.WriteLine("Name: " + directory.Name);
                    sw.WriteLine("File name: " + directory.FullName);
                    sw.WriteLine("Create time: " + directory.CreationTime);
                    sw.WriteLine("Last access time: " + directory.LastAccessTime);
                    sw.WriteLine("Last write time: " + directory.LastWriteTime);
                    sw.WriteLine("Size: " + directory.EnumerateFiles().Sum(file => file.Length));
                    sw.WriteLine();
                }
            }

        }
    }
}

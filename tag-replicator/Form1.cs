
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace tag_replicator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private string RunScript(string script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(script);
            pipeline.Commands.Add("Out-String");
            Collection<PSObject> results = pipeline.Invoke();
            runspace.Close();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject pSObject in results)
                stringBuilder.AppendLine(pSObject.ToString());
            return stringBuilder.ToString();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string tags = tagListTextBox.Text.Trim();

            string path = @"C:\Users\christian.gros\Desktop\tag-replicator\input\Points.txt";

                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(tags);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }


            string myCommandParse = "powershell.exe -file ..\\BackfillingPS.ps1 -PISourceServer " + textBox1.Text + " -PITargetServer  "  + textBox2.Text + "  -DateStartTime \" " + textBox3.Text + " -DateEndTime " + textBox4.Text;
            //textBox2.Text = RunScript("get-process");*

            textBox2.Text = RunScript("powershell -help");
        }

        
    }
}
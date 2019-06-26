using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Archivo(string FTP, string rutaarchivo, string computadora321, string test1pweb)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FtpWebRequest c = (FtpWebRequest)FtpWebRequest.Create("ftp://files.000webhost.com/public_html/" + "/" + Path.GetFileName(@"C:\Users\emiliano\source\repos"));
            c.Method = WebRequestMethods.Ftp.UploadFile;
            c.Credentials = new NetworkCredential("test1pweb", "computadora321");
            c.UsePassive = true;
            c.UseBinary = true;
            c.KeepAlive = false;
             FileStream b = File.OpenRead(@"C:\Users\emiliano\source\repos");
            byte[] buffer = new byte[b.Length];

            b.Read(buffer, 0, buffer.Length);
            b.Close();
            Stream streamQuery = c.GetRequestStream();
            streamQuery.Write(buffer, 0, buffer.Length);
            streamQuery.Close();
            MessageBox.Show("Archivo subido");
        }
    }
}
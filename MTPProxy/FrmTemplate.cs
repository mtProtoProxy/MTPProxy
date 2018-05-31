using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using MTProtoProxy;
using Ini;
namespace MTPProxy
{
    public partial class FrmTemplate : MetroForm
    {
        public FrmTemplate()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.port.StyleManager = metroStyleManager1;
            this.ip.StyleManager = metroStyleManager1;
            this.secret.StyleManager = metroStyleManager1;
            this.ToolTip1.StyleManager = metroStyleManager1;
            this.st.StyleManager = metroStyleManager1;
            this.backlog.StyleManager = metroStyleManager1;
            this.textbox.StyleManager = metroStyleManager1;
            this.save.StyleManager = metroStyleManager1;
            this.load.StyleManager = metroStyleManager1;
            this.metroButton1.StyleManager = metroStyleManager1;
            ToolTip1.AutoPopDelay = 3000;
            
            Console.SetOut(new MultiTextWriter(new ControlWriter(textbox), Console.Out));
            ToolTip1.SetToolTip(secret, "To Generate new secret use 0");
            ToolTip1.SetToolTip(port, "For Example : 4000");
            ToolTip1.SetToolTip(ip, "(for localhost) : 127.0.0.1 or 51.254.160.49");
            ToolTip1.SetToolTip(st, "Start && Stop the server");
            ToolTip1.SetToolTip(backlog, "Default: 100");
        }

        public class MultiTextWriter : TextWriter
        {
            private IEnumerable<TextWriter> writers;
            public MultiTextWriter(IEnumerable<TextWriter> writers)
            {
                this.writers = writers.ToList();
            }
            public MultiTextWriter(params TextWriter[] writers)
            {
                this.writers = writers;
            }

            public override void Write(char value)
            {
                foreach (var writer in writers)
                    writer.Write(value);
            }

            public override void Write(string value)
            {
                foreach (var writer in writers)
                    writer.Write(value);
            }

            public override void Flush()
            {
                foreach (var writer in writers)
                    writer.Flush();
            }

            public override void Close()
            {
                foreach (var writer in writers)
                    writer.Close();
            }

            public override Encoding Encoding
            {
                get { return Encoding.ASCII; }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
       

        private void port_change(object sender, EventArgs e)
        {
            int n;
            int.TryParse(port.Text, out n);
            this.port.Text = n.ToString();


            //int n;
            //string s = port.Text;
            //if (int.TryParse(new string(s.Where(a => Char.IsDigit(a)).ToArray()), out n))
            //{
            //    if (n > 0 && n < 100000)
            //    {
            //        this.port.Text = n.ToString();
            //    }
            //    else
            //    {
            //        this.port.Text = "";
            //    }
            //}
        }
        public static string GenerateRandomSecret()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
        public int pport;
        public string iip;
        public string sesret;
        public int back_log;
       

        public void st_Click(object sender, EventArgs e)
        {
            if (st.Text == "Start") 
            {
                if (ip.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "\nPlease enter IP to ip field\nFor Example:\n127.0.0.1\n51.254.164.54", "Error On Start");
                    return;
                }
                if (backlog.Text == "" || backlog.Text == "0")
                {
                    MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "\nPlease enter Backlog to Backlog field\nFor Example:\n100\n255", "Error On Start");
                    return;
                }
                if (port.Text == "" || port.Text == "0")
                {
                    MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "\nPlease enter Port Number to port field\nFor Example:\n4000\n8888","Error On Start");
                    return;
                }
                if (secret.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "\nPlease enter secret to secret field\nFor Example:\ndbd9a4f78fb145b7b513aaae49864b31\nor for generate new secret enter 0", "Error On Start");
                    return;
                }
                st.Text = "Stop";
                pport = int.Parse(port.Text);
                back_log = int.Parse(backlog.Text);
                if (secret.Text == "0")
                {
                    string n = GenerateRandomSecret();
                    this.secret.Text = n;
                    sesret = n;
                }
                else 
                {
                    sesret = secret.Text;
                }
                
                iip = ip.Text;
               var mtp = new MTProtoProxyServer(ref sesret, ref pport, ref iip);
                mtp.Start(ref back_log);
               // var mtprotoProxy = new MTProtoProxyServer("secret", port, "ip");
               // mtprotoProxy.Start(backlog);
                Console.WriteLine("Created By Soheil1234");
                Console.WriteLine("open source => https://github.com/Metal-Ghost/MTProxy");
                st.Enabled = false;

            }
            else if (st.Text == "Stop")
            {
                MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "\nOn MTPROTOPROXY stop code not released Can not stop you must restart the Application", "Error On Stop");
                st.Text = "Start";
                Application.Restart();
                
            }

        }
        public class ControlWriter : TextWriter
        {
            private Control textbox;
            public ControlWriter(Control textbox)
            {
                this.textbox = textbox;
            }

            public override void Write(char value)
            {
                textbox.Text += value;
            }

            public override void Write(string value)
            {
                textbox.Text += value;
            }

            public override Encoding Encoding
            {
                get { return Encoding.ASCII; }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog1 = new SaveFileDialog();

            // openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "ini files (*.ini)|*.ini";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Save an Information File";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                
                IniFile ini = new IniFile(openFileDialog1.FileName);
                ini.IniWriteValue("Settings", "ip", ip.Text);
                ini.IniWriteValue("Settings", "port", port.Text);
                ini.IniWriteValue("Settings", "secret", secret.Text);
                ini.IniWriteValue("Settings", "backlog", backlog.Text);
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
             Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "ini files (*.ini)|*.ini";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Load an Information File";  
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            IniFile ini = new IniFile(openFileDialog1.FileName);
                            ip.Text=ini.IniReadValue("Settings", "ip" );
                            port.Text = ini.IniReadValue("Settings", "port");
                            secret.Text = ini.IniReadValue("Settings", "secret");
                            backlog.Text = ini.IniReadValue("Settings", "backlog");
                        }
                    }
                }
               catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/soheil_12_34");
            System.Diagnostics.Process.Start("https://github.com/Metal-Ghost/MTPProxy");
            System.Diagnostics.Process.Start("https://t.me/VPN_And_Proxies");
        }
    }
}

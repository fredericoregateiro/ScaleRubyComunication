using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsScaleRuby
{
    public partial class Form1 : Form
    {
        [DllImport("xGatDll.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern long totik(long dest, long ndest, long inireg, long fireg, ref string buf, long borrado);

        [DllImport("xGatdll.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern long opensocket(ref string ipremota, long portlocal, long portdesti, long ingredientes);

        [DllImport("xGatdll.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern long closesocket();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDest.Text = "1";
            txtNdest.Text = "0";
            txtInireg.Text = "0";
            txtFireg.Text = "10000";
            txtBorrado.Text = "1";
            txtBuf.Text = Path.Combine(Environment.CurrentDirectory, "scale_log.txt");

            txtIP.Text = "192.168.2.5";
            txtPort.Text = "2003";

            checkOpenConnection.Checked = true;
        }

        long openid, closeid;
        private long Read(long dest, long ndest, long inireg, long fireg, ref string buf, long borrado)
        {
            if (checkOpenConnection.Checked)
            {
                int.TryParse(txtPort.Text, out int port);
                string ip = txtIP.Text;

                openid = opensocket(ref ip, port, port, 12);
                Log(openid.ToString());
            }

            var result = totik(dest, ndest, inireg, fireg, ref buf, borrado);
            Log(result.ToString());

            if (checkCloseConnection.Checked)
            {
                closeid = closesocket();
                Log(closeid.ToString());
            }

            return result;
        }

        private string buf;
        private void BtnTestComunication_Click(object sender, EventArgs e)
        {
            try
            {
                buf = string.Empty;

                int.TryParse(txtDest.Text, out int dest);
                int.TryParse(txtNdest.Text, out int ndest);
                int.TryParse(txtInireg.Text, out int inireg);
                int.TryParse(txtFireg.Text, out int fireg);
                int.TryParse(txtBorrado.Text, out int borrado);
                buf = txtBuf.Text;

                var result = Read(dest, ndest, inireg, fireg, ref buf, borrado);

                Log("Resultado: " + result.ToString()); Log(Environment.NewLine);
                Log("buf: " + buf);

                if (MessageBox.Show("Ler valores?", "Ler", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ReadFile();
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private void Log(string message)
        {
            txtLog.Text += message;
            txtLog.Text += Environment.NewLine;
        }

        private void Log(Exception ex)
        {
            Log(ex.Message);
            Exception inner = ex.InnerException;
            while (inner != null)
            {
                Log(inner.Message);
                inner = inner.InnerException;
            }
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        private void ReadFile()
        {
            txtLog.Text = string.Empty;

            string fileContent;
            if (File.Exists(txtBuf.Text))
                fileContent = File.ReadAllText(txtBuf.Text);
            else
                fileContent = buf;

            if (string.IsNullOrEmpty(fileContent) == false)
            {
                var lines = fileContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    var columns = line.Split(' ');

                    if (columns.Length == 24)
                    {
                        if (columns[4] == "9")
                            continue;

                        Log("Peso: " + columns[5]); Log(Environment.NewLine);
                        Log("€/Kg: " + columns[6]); Log(Environment.NewLine);
                        Log("€: " + columns[7]); Log(Environment.NewLine);
                        Log("PLU: " + columns[9]); Log(Environment.NewLine);

                        Log(Environment.NewLine);
                    }
                    else
                        MessageBox.Show("Linha com valores incorretos", "Ler ficheiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Ficheiro vazio", "Ler ficheiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtBuf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                InitialDirectory = Environment.CurrentDirectory,
                Multiselect = false
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    txtBuf.Text = openFileDialog.FileName;
            }
        }
    }
}

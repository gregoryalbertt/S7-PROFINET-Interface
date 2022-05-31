using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROFINET_STEP_7.Profinet;

namespace PROFINET_STEP_7
{
    public partial class FormMain : Form
    {
        private PLC plc = null;
        private ExceptionCode errCode;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.SetEnabledBotton(true);
                cboxPLCs.SelectedIndex = 2;
                txtIPaddress.Text = "192.168.0.1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIPaddress.Text)) throw new Exception("Input your PLC IP first");
                int selectionIndex = cboxPLCs.SelectedIndex;
                CPU_Type cpuType = CPU_Type.S7200;
                string ipAddress = txtIPaddress.Text;
                switch (selectionIndex)
                {
                    case 0:
                        cpuType = CPU_Type.S7200;
                        break;
                    case 1:
                        cpuType = CPU_Type.S7300;
                        break;
                    case 2:
                        cpuType = CPU_Type.S7400;
                        break;
                    case 3:
                        cpuType = CPU_Type.S71200;
                        break;
                    case 4:
                        cpuType = CPU_Type.S71500;
                        break;
                    default:
                        cboxPLCs.SelectedIndex = 3;
                        cpuType = CPU_Type.S71200;
                        break;
                }
                plc = new PLC(cpuType, ipAddress, (short)numericUpDownRack.Value, (short)numericUpDownSlot.Value);
                if (!plc.IsAvailable) throw new Exception("Not possible to find your PLC, try again");
                errCode = plc.Open();
                if (errCode != ExceptionCode.ExceptionNo) throw new Exception(plc.lastErrorString);
                this.SetEnabledBotton(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnection_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetEnabledBotton(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetEnabledBotton(bool flag)
        {
            btnConnection.Enabled = flag;
            txtIPaddress.Enabled = flag;
            cboxPLCs.Enabled = flag;
            numericUpDownRack.Enabled = flag;
            numericUpDownSlot.Enabled = flag;
            btnDisconnection.Enabled = !btnConnection.Enabled;
        }

        private int db;
        private int startByteAddr;

        private void btnReadReal_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                //double value = Types.Double.FromDWord((uint)plc.Read("DB90.DBD248"));
                string[] tempStrg = txtRealOutput.Text.Split('.');
                int size = tempStrg.Length;
                double value = 0;
                db = 0;
                startByteAddr = 0;
                if (size >= 2)
                {
                    db = int.Parse(tempStrg[0].Substring(2, tempStrg[0].Length - 2));
                    startByteAddr = int.Parse(tempStrg[1].Substring(3, tempStrg[1].Length - 3));
                }
                value = Types.Double.FromDWord((uint)plc.Read(txtRealOutput.Text));
                txtRealInput.Text = value.ToString("0.#");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteReal_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                byte[] values = Types.Double.ToByteArray(double.Parse(txtRealInput.Text));
                if(db != 0 && startByteAddr != 0)
                    plc.WriteBytes(DataType.DataBlock, 90, 248, values);
                else
                    plc.WriteBytes(DataType.Marker, 0, int.Parse(txtRealOutput.Text.Substring(2, txtRealOutput.Text.Length-2)), values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadWord_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                txtWordInput.Text = plc.Read(txtWordOutput.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteWord_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                plc.Write(txtWordOutput.Text, txtWordInput.Text).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                //plc.Write("M500.1", 1);
                //plc.Write("Q0.0", 1);
                plc.Write("O2.7", 1); //Q15.2 doi voi bit(O thay cho Q) con cai khac thi Q binh thuong.
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                //plc.Write("M500.1", 1);
                //plc.Write("Q0.0", 0);
                plc.Write("O2.7", 0); //Q15.2 doi voi bit(O thay cho Q) con cai khac thi Q binh thuong.
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMOn_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                plc.Write("M0.0", 1);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMOff_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                plc.Write("M0.0", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAbout frmAbout = new FormAbout();
            frmAbout.ShowDialog();
        }

        private void cboxPLCs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRealOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWordOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PICkitS;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WindowsApplication1.My;

namespace WindowsApplication1
{
    [DesignerGenerated]
    public class COMsetup : Form
    {
        private IContainer components;

        [AccessedThroughProperty("COMportNumber")]
        private ComboBox _COMportNumber;

        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        [AccessedThroughProperty("Label6")]
        private Label _Label6;

        [AccessedThroughProperty("TimeoutBox")]
        private TextBox _TimeoutBox;

        [AccessedThroughProperty("OKbtn")]
        private Button _OKbtn;

        [AccessedThroughProperty("CancelBtn")]
        private Button _CancelBtn;

        [AccessedThroughProperty("BaudrateValue")]
        private TextBox _BaudrateValue;

        internal virtual TextBox BaudrateValue
        {
            get
            {
                return this._BaudrateValue;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._BaudrateValue = value;
            }
        }

        internal virtual Button CancelBtn
        {
            get
            {
                return this._CancelBtn;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                COMsetup cOMsetup = this;
                EventHandler eventHandler = new EventHandler(cOMsetup.CancelButton_Click);
                if (this._CancelBtn != null)
                {
                    this._CancelBtn.Click -= eventHandler;
                }
                this._CancelBtn = value;
                if (this._CancelBtn != null)
                {
                    this._CancelBtn.Click += eventHandler;
                }
            }
        }

        internal virtual ComboBox COMportNumber
        {
            get
            {
                return this._COMportNumber;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._COMportNumber = value;
            }
        }

        internal virtual Label Label1
        {
            get
            {
                return this._Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label1 = value;
            }
        }

        internal virtual Label Label2
        {
            get
            {
                return this._Label2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label2 = value;
            }
        }

        internal virtual Label Label6
        {
            get
            {
                return this._Label6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label6 = value;
            }
        }

        internal virtual Button OKbtn
        {
            get
            {
                return this._OKbtn;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                COMsetup cOMsetup = this;
                EventHandler eventHandler = new EventHandler(cOMsetup.OKbutton_Click);
                if (this._OKbtn != null)
                {
                    this._OKbtn.Click -= eventHandler;
                }
                this._OKbtn = value;
                if (this._OKbtn != null)
                {
                    this._OKbtn.Click += eventHandler;
                }
            }
        }

        internal virtual TextBox TimeoutBox
        {
            get
            {
                return this._TimeoutBox;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TimeoutBox = value;
            }
        }

        public COMsetup()
        {
            COMsetup cOMsetup = this;
            base.Load += new EventHandler(cOMsetup.COMsetup_Load);
            this.InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void COMsetup_Load(object sender, EventArgs e)
        {
            this.BaudrateValue.Text = MyProject.Forms.Network.ToolStripStatusBaud.Text;
            int num = 0;
            this.COMportNumber.Items.Clear();

            ushort num1 = Basic.How_Many_Of_MyDevices_Are_Attached(MyProject.Forms.Network.PID);
            for (ushort i = 1; i <= num1; i++)
            {
                this.COMportNumber.Items.Add($"APG USB to LIN {num}");
                num++;
            }

            num = 0;
            ushort num2 = Basic.How_Many_Of_MyDevices_Are_Attached(MyProject.Forms.Network.PKSAPID);
            for (ushort i = 1; i <= num2; i++)
            {
                this.COMportNumber.Items.Add($"PKSA {num}");
                num++;
            }

            if (MyProject.Forms.Network.SelectedCOMport == -1)
            {
                this.COMportNumber.Text = "" +
                                          "No USB" +
                                          " device present";
                this.TimeoutBox.Text = "Not Available";
            }
            else
            {
                this.COMportNumber.Text = this.COMportNumber.Items[MyProject.Forms.Network.SelectedCOMport].ToString();
                if (!LIN.OnReceive_Timeout_Is_Baud_Dependent())
                {
                    this.TimeoutBox.Text = LIN.Get_OnReceive_Timeout().ToString();
                }
                else
                {
                    this.TimeoutBox.Text = "140% x baud";
                }
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.COMportNumber = new ComboBox();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label6 = new Label();
            this.TimeoutBox = new TextBox();
            this.OKbtn = new Button();
            this.CancelBtn = new Button();
            this.BaudrateValue = new TextBox();
            this.SuspendLayout();
            this.COMportNumber.FormattingEnabled = true;
            ComboBox.ObjectCollection items = this.COMportNumber.Items;
            object[] objArray = new object[] { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10" };
            items.AddRange(objArray);
            ComboBox cOMportNumber = this.COMportNumber;
            Point point = new Point(94, 34);
            cOMportNumber.Location = point;
            this.COMportNumber.Name = "COMportNumber";
            ComboBox comboBox = this.COMportNumber;
            System.Drawing.Size size = new System.Drawing.Size(153, 21);
            comboBox.Size = size;
            this.COMportNumber.TabIndex = 0;
            this.COMportNumber.Text = "COM1";
            this.Label1.AutoSize = true;
            Label label1 = this.Label1;
            point = new Point(24, 37);
            label1.Location = point;
            this.Label1.Name = "Label1";
            Label label = this.Label1;
            size = new System.Drawing.Size(52, 13);
            label.Size = size;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "COM port";
            this.Label2.AutoSize = true;
            Label label2 = this.Label2;
            point = new Point(26, 73);
            label2.Location = point;
            this.Label2.Name = "Label2";
            Label label21 = this.Label2;
            size = new System.Drawing.Size(50, 13);
            label21.Size = size;
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Baudrate";
            this.Label6.AutoSize = true;
            Label label6 = this.Label6;
            point = new Point(8, 104);
            label6.Location = point;
            this.Label6.Name = "Label6";
            Label label61 = this.Label6;
            size = new System.Drawing.Size(74, 13);
            label61.Size = size;
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Timeout in mS";
            TextBox timeoutBox = this.TimeoutBox;
            point = new Point(96, 104);
            timeoutBox.Location = point;
            this.TimeoutBox.Name = "TimeoutBox";
            TextBox textBox = this.TimeoutBox;
            size = new System.Drawing.Size(59, 20);
            textBox.Size = size;
            this.TimeoutBox.TabIndex = 11;
            Button oKbtn = this.OKbtn;
            point = new Point(160, 136);
            oKbtn.Location = point;
            this.OKbtn.Name = "OKbtn";
            Button button = this.OKbtn;
            size = new System.Drawing.Size(75, 23);
            button.Size = size;
            this.OKbtn.TabIndex = 12;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            Button cancelBtn = this.CancelBtn;
            point = new Point(24, 136);
            cancelBtn.Location = point;
            this.CancelBtn.Name = "CancelBtn";
            Button cancelBtn1 = this.CancelBtn;
            size = new System.Drawing.Size(75, 23);
            cancelBtn1.Size = size;
            this.CancelBtn.TabIndex = 13;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            TextBox baudrateValue = this.BaudrateValue;
            point = new Point(96, 70);
            baudrateValue.Location = point;
            this.BaudrateValue.Name = "BaudrateValue";
            TextBox baudrateValue1 = this.BaudrateValue;
            size = new System.Drawing.Size(59, 20);
            baudrateValue1.Size = size;
            this.BaudrateValue.TabIndex = 14;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            size = new System.Drawing.Size(259, 176);
            this.ClientSize = size;
            this.Controls.Add(this.BaudrateValue);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.TimeoutBox);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.COMportNumber);
            this.Name = "COMsetup";
            this.Text = "Setup COM port";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (this.COMportNumber.SelectedIndex != -1)
            {
                if (this.COMportNumber.SelectedIndex != MyProject.Forms.Network.SelectedCOMport)
                {
                    Basic.Terminate_Comm_Threads();
                    if (Strings.InStr(this.COMportNumber.SelectedItem.ToString(), "APG", CompareMethod.Binary) != 0)
                    {
                        if (!Basic.Initialize_MyDevice(checked((ushort)(checked((int)Math.Round(Conversion.Val(Strings.Mid(this.COMportNumber.SelectedItem.ToString(), 16)))))), MyProject.Forms.Network.PID))
                        {
                            Interaction.MsgBox("USB2LIN Failed to Initialize", MsgBoxStyle.Exclamation, "Error");
                            return;
                        }
                    }
                    else if (Strings.InStr(this.COMportNumber.SelectedItem.ToString(), "PKSA", CompareMethod.Binary) != 0 && !Basic.Initialize_MyDevice(checked((ushort)(checked((int)Math.Round(Conversion.Val(Strings.Mid(this.COMportNumber.SelectedItem.ToString(), 6)))))), MyProject.Forms.Network.PKSAPID))
                    {
                        Interaction.MsgBox("USB PKSA Failed to Initialize", MsgBoxStyle.Exclamation, "Error");
                        return;
                    }
                    MyProject.Forms.Network.SelectedCOMport = this.COMportNumber.SelectedIndex;
                    Basic.Configure_PICkitSerial_For_LIN();
                }
                string text = MyProject.Forms.Network.ToolStripStatusBaud.Text;
                string str = this.BaudrateValue.Text;
                if (Operators.CompareString(str, "", false) == 0)
                {
                    str = text;
                }
                else if (!LIN.Change_LIN_BAUD_Rate(checked((ushort)Math.Round(Conversion.Val(str)))))
                {
                    str = text;
                    Interaction.MsgBox("USB Failed to Change Baudrate", MsgBoxStyle.Critical | MsgBoxStyle.Question | MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, "Error");
                    return;
                }
                MyProject.Forms.Network.ToolStripStatusBaud.Text = str;
                MyProject.Forms.Network.MasterBaudRate = checked((ushort)Math.Round(Conversion.Val(str)));
                LIN.Reset_LIN_Frame_Buffers();
                text = this.TimeoutBox.Text;
                str = this.TimeoutBox.Text;
                if (Operators.CompareString(str, "", false) == 0)
                {
                    str = text;
                }
                else if (Operators.CompareString(str, "0", false) == 0)
                {
                    str = Conversions.ToString(65535);
                    if (LIN.Set_OnReceive_Timeout(checked((int)Math.Round(Conversion.Val(str)))))
                    {
                        this.TimeoutBox.Text = "140% x baud";
                    }
                    else
                    {
                        str = text;
                    }
                }
                else if (Operators.CompareString(str, "140% x baud", false) == 0)
                {
                    str = Conversions.ToString(65535);
                    if (LIN.Set_OnReceive_Timeout(checked((int)Math.Round(Conversion.Val(str)))))
                    {
                        this.TimeoutBox.Text = "140% x baud";
                    }
                    else
                    {
                        str = text;
                    }
                }
                else if (!LIN.Set_OnReceive_Timeout(checked((int)Math.Round(Conversion.Val(str)))))
                {
                    str = text;
                }
            }
            this.Hide();
        }
    }
}
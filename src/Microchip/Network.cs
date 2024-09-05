using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using PICkitS;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsApplication1.My;

namespace WindowsApplication1
{
    [DesignerGenerated]
    [Serializable]
    public class Network : Form
    {
        private IContainer components;

        [AccessedThroughProperty("LogfileToolStripMenuItem")]
        private ToolStripMenuItem _LogfileToolStripMenuItem;

        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;

        [AccessedThroughProperty("StatusStrip1")]
        private StatusStrip _StatusStrip1;

        [AccessedThroughProperty("ToolStripStatusBaud")]
        private System.Windows.Forms.ToolStripStatusLabel _ToolStripStatusBaud;

        [AccessedThroughProperty("Sendbtn")]
        private Button _Sendbtn;

        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        [AccessedThroughProperty("Label5")]
        private Label _Label5;

        [AccessedThroughProperty("Label6")]
        private Label _Label6;

        [AccessedThroughProperty("Label7")]
        private Label _Label7;

        [AccessedThroughProperty("FileToolStripMenuItem")]
        private ToolStripMenuItem _FileToolStripMenuItem;

        [AccessedThroughProperty("OpenToolStripMenuItem")]
        private ToolStripMenuItem _OpenToolStripMenuItem;

        [AccessedThroughProperty("toolStripSeparator")]
        private ToolStripSeparator _toolStripSeparator;

        [AccessedThroughProperty("SaveToolStripMenuItem")]
        private ToolStripMenuItem _SaveToolStripMenuItem;

        [AccessedThroughProperty("SaveAsToolStripMenuItem")]
        private ToolStripMenuItem _SaveAsToolStripMenuItem;

        [AccessedThroughProperty("toolStripSeparator1")]
        private ToolStripSeparator _toolStripSeparator1;

        [AccessedThroughProperty("PrintToolStripMenuItem")]
        private ToolStripMenuItem _PrintToolStripMenuItem;

        [AccessedThroughProperty("PrintPreviewToolStripMenuItem")]
        private ToolStripMenuItem _PrintPreviewToolStripMenuItem;

        [AccessedThroughProperty("toolStripSeparator2")]
        private ToolStripSeparator _toolStripSeparator2;

        [AccessedThroughProperty("ExitToolStripMenuItem")]
        private ToolStripMenuItem _ExitToolStripMenuItem;

        [AccessedThroughProperty("ToolsToolStripMenuItem")]
        private ToolStripMenuItem _ToolsToolStripMenuItem;

        [AccessedThroughProperty("OptionsToolStripMenuItem")]
        private ToolStripMenuItem _OptionsToolStripMenuItem;

        [AccessedThroughProperty("HelpToolStripMenuItem")]
        private ToolStripMenuItem _HelpToolStripMenuItem;

        [AccessedThroughProperty("ContentsToolStripMenuItem")]
        private ToolStripMenuItem _ContentsToolStripMenuItem;

        [AccessedThroughProperty("IndexToolStripMenuItem")]
        private ToolStripMenuItem _IndexToolStripMenuItem;

        [AccessedThroughProperty("SearchToolStripMenuItem")]
        private ToolStripMenuItem _SearchToolStripMenuItem;

        [AccessedThroughProperty("toolStripSeparator5")]
        private ToolStripSeparator _toolStripSeparator5;

        [AccessedThroughProperty("AboutToolStripMenuItem")]
        private ToolStripMenuItem _AboutToolStripMenuItem;

        [AccessedThroughProperty("MessageLstBox")]
        private ListBox _MessageLstBox;

        [AccessedThroughProperty("Label8")]
        private Label _Label8;

        [AccessedThroughProperty("Label9")]
        private Label _Label9;

        [AccessedThroughProperty("DeleteBtn")]
        private Button _DeleteBtn;

        [AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;

        [AccessedThroughProperty("Label10")]
        private Label _Label10;

        [AccessedThroughProperty("ToolTip1")]
        private ToolTip _ToolTip1;

        [AccessedThroughProperty("OpenFileDialog1")]
        private OpenFileDialog _OpenFileDialog1;

        [AccessedThroughProperty("ToolStripStatusLabel")]
        private System.Windows.Forms.ToolStripStatusLabel _ToolStripStatusLabel;

        [AccessedThroughProperty("Label12")]
        private Label _Label12;

        [AccessedThroughProperty("SaveFileDialog1")]
        private SaveFileDialog _SaveFileDialog1;

        [AccessedThroughProperty("LogBtn")]
        private Button _LogBtn;

        [AccessedThroughProperty("LOGfilelbl")]
        private Label _LOGfilelbl;

        [AccessedThroughProperty("PrintDocument1")]
        private PrintDocument _PrintDocument1;

        [AccessedThroughProperty("PrintDialog1")]
        private PrintDialog _PrintDialog1;

        [AccessedThroughProperty("PrintPreviewDialog1")]
        private PrintPreviewDialog _PrintPreviewDialog1;

        [AccessedThroughProperty("PrintSetupToolStripMenuItem")]
        private ToolStripMenuItem _PrintSetupToolStripMenuItem;

        [AccessedThroughProperty("PageSetupDialog1")]
        private PageSetupDialog _PageSetupDialog1;

        [AccessedThroughProperty("ClearMonitorWindowToolStripMenuItem")]
        private ToolStripMenuItem _ClearMonitorWindowToolStripMenuItem;

        [AccessedThroughProperty("PictureBox2")]
        private PictureBox _PictureBox2;

        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;

        [AccessedThroughProperty("ToolStripStatusCOMStatus")]
        private System.Windows.Forms.ToolStripStatusLabel _ToolStripStatusCOMStatus;

        [AccessedThroughProperty("StatusError")]
        private System.Windows.Forms.ToolStripStatusLabel _StatusError;

        [AccessedThroughProperty("TransmitToolStripMenuItem")]
        private ToolStripMenuItem _TransmitToolStripMenuItem;

        [AccessedThroughProperty("ListenToolStripMenuItem")]
        private ToolStripMenuItem _ListenToolStripMenuItem;

        [AccessedThroughProperty("SnoopToolStripMenuItem")]
        private ToolStripMenuItem _SnoopToolStripMenuItem;

        [AccessedThroughProperty("classicRadioButton")]
        private RadioButton _classicRadioButton;

        [AccessedThroughProperty("forcedRadioButton")]
        private RadioButton _forcedRadioButton;

        [AccessedThroughProperty("enhancedRadioButton")]
        private RadioButton _enhancedRadioButton;

        [AccessedThroughProperty("DebugModeToolStripMenuItem")]
        private ToolStripMenuItem _DebugModeToolStripMenuItem;

        [AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator _ToolStripSeparator3;

        [AccessedThroughProperty("GroupBox2")]
        private GroupBox _GroupBox2;

        [AccessedThroughProperty("GroupBox3")]
        private GroupBox _GroupBox3;

        [AccessedThroughProperty("TextBox1")]
        private RichTextBox _TextBox1;

        [AccessedThroughProperty("SupressBusTimeoutErrorToolStripMenuItem")]
        private ToolStripMenuItem _SupressBusTimeoutErrorToolStripMenuItem;

        [AccessedThroughProperty("NumericUpDown1")]
        private NumericUpDown _NumericUpDown1;

        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;

        [AccessedThroughProperty("ContSendbtn")]
        private Button _ContSendbtn;

        [AccessedThroughProperty("FiltersToolStripMenuItem")]
        private ToolStripMenuItem _FiltersToolStripMenuItem;

        [AccessedThroughProperty("SetupToolStripMenuItem")]
        private ToolStripMenuItem _SetupToolStripMenuItem;

        [AccessedThroughProperty("COMPortToolStripMenuItem")]
        private ToolStripMenuItem _COMPortToolStripMenuItem;

        [AccessedThroughProperty("LogFileToolStripMenuItem1")]
        private ToolStripMenuItem _LogFileToolStripMenuItem1;

        [AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator _ToolStripSeparator4;

        [AccessedThroughProperty("SlaveResponseToolStripMenuItem")]
        private ToolStripMenuItem _SlaveResponseToolStripMenuItem;

        [AccessedThroughProperty("AddBtn")]
        private Button _AddBtn;

        [AccessedThroughProperty("EditBtn")]
        private Button _EditBtn;

        [AccessedThroughProperty("ToolStripSeparator6")]
        private ToolStripSeparator _ToolStripSeparator6;

        [AccessedThroughProperty("LoadFirmwareToolStripMenuItem")]
        private ToolStripMenuItem _LoadFirmwareToolStripMenuItem;

        [AccessedThroughProperty("ReconnectToolStripMenuItem")]
        private ToolStripMenuItem _ReconnectToolStripMenuItem;

        [AccessedThroughProperty("DisplayErrors")]
        private ToolStripMenuItem _DisplayErrors;

        [AccessedThroughProperty("ToolStripSeparator7")]
        private ToolStripSeparator _ToolStripSeparator7;

        [AccessedThroughProperty("ScriptFileToolStripMenuItem")]
        private ToolStripMenuItem _ScriptFileToolStripMenuItem;

        [AccessedThroughProperty("OpenFileDialog2")]
        private OpenFileDialog _OpenFileDialog2;

        [AccessedThroughProperty("SCRIPTfilelbl")]
        private Label _SCRIPTfilelbl;

        [AccessedThroughProperty("Label11")]
        private Label _Label11;

        [AccessedThroughProperty("DisplayNextScheduleToolStripMenuItem1")]
        private ToolStripMenuItem _DisplayNextScheduleToolStripMenuItem1;

        private object ListenCnt;

        private int LOGrecord;

        public int chksum;

        private int TestData;

        private string INIpath;

        private string LOGpath;

        private string SCRIPTpath;

        private StreamWriter LOGfile;

        private StreamReader SCRIPTfile;

        public ushort MasterBaudRate;

        public int SelectedCOMport;

        public ushort PID;

        public ushort PKSAPID;

        public bool HitError;

        public int HitErrorCount;

        public int selectedmessagepointer;

        public bool SendOnce;

        public byte FilterID;

        private double act_timestamp;

        private double old_timestamp;

        private double diff_timestamp;

        public string firmwarehex;

        [AccessedThroughProperty("OnAnswerSource")]
        private LIN _OnAnswerSource;

        [AccessedThroughProperty("OnReceiveSource")]
        private LIN _OnReceiveSource;

        private DataObject DisplayResultsLock;

        private RichTextBox temp_textbox;

        private RichTextBox inter_textbox;

        public RichTextBox RTFstrng;

        public const int WM_VSCROLL = 277;

        public const int SB_BOTTOM = 7;

        private bool m_need_to_scroll_to_bottom_next_time;

        internal virtual ToolStripMenuItem AboutToolStripMenuItem
        {
            get
            {
                return this._AboutToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.AboutToolStripMenuItem_Click);
                if (this._AboutToolStripMenuItem != null)
                {
                    this._AboutToolStripMenuItem.Click -= eventHandler;
                }
                this._AboutToolStripMenuItem = value;
                if (this._AboutToolStripMenuItem != null)
                {
                    this._AboutToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual Button AddBtn
        {
            get
            {
                return this._AddBtn;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.AddBtn_Click);
                if (this._AddBtn != null)
                {
                    this._AddBtn.Click -= eventHandler;
                }
                this._AddBtn = value;
                if (this._AddBtn != null)
                {
                    this._AddBtn.Click += eventHandler;
                }
            }
        }

        internal virtual RadioButton classicRadioButton
        {
            get
            {
                return this._classicRadioButton;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.classicRadioButton_CheckedChanged);
                if (this._classicRadioButton != null)
                {
                    this._classicRadioButton.CheckedChanged -= eventHandler;
                }
                this._classicRadioButton = value;
                if (this._classicRadioButton != null)
                {
                    this._classicRadioButton.CheckedChanged += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem ClearMonitorWindowToolStripMenuItem
        {
            get
            {
                return this._ClearMonitorWindowToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.ClearMonitorWindowToolStripMenuItem_Click);
                if (this._ClearMonitorWindowToolStripMenuItem != null)
                {
                    this._ClearMonitorWindowToolStripMenuItem.Click -= eventHandler;
                }
                this._ClearMonitorWindowToolStripMenuItem = value;
                if (this._ClearMonitorWindowToolStripMenuItem != null)
                {
                    this._ClearMonitorWindowToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem COMPortToolStripMenuItem
        {
            get
            {
                return this._COMPortToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.COMPortToolStripMenuItem_Click);
                if (this._COMPortToolStripMenuItem != null)
                {
                    this._COMPortToolStripMenuItem.Click -= eventHandler;
                }
                this._COMPortToolStripMenuItem = value;
                if (this._COMPortToolStripMenuItem != null)
                {
                    this._COMPortToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem ContentsToolStripMenuItem
        {
            get
            {
                return this._ContentsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ContentsToolStripMenuItem = value;
            }
        }

        internal virtual Button ContSendbtn
        {
            get
            {
                return this._ContSendbtn;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.ContSendbtn_Click);
                if (this._ContSendbtn != null)
                {
                    this._ContSendbtn.Click -= eventHandler;
                }
                this._ContSendbtn = value;
                if (this._ContSendbtn != null)
                {
                    this._ContSendbtn.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem DebugModeToolStripMenuItem
        {
            get
            {
                return this._DebugModeToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.DebugModeToolStripMenuItem_Click);
                if (this._DebugModeToolStripMenuItem != null)
                {
                    this._DebugModeToolStripMenuItem.Click -= eventHandler;
                }
                this._DebugModeToolStripMenuItem = value;
                if (this._DebugModeToolStripMenuItem != null)
                {
                    this._DebugModeToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual Button DeleteBtn
        {
            get
            {
                return this._DeleteBtn;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.DeleteBtn_Click);
                if (this._DeleteBtn != null)
                {
                    this._DeleteBtn.Click -= eventHandler;
                }
                this._DeleteBtn = value;
                if (this._DeleteBtn != null)
                {
                    this._DeleteBtn.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem DisplayErrors
        {
            get
            {
                return this._DisplayErrors;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.DisplayErrors_Click);
                if (this._DisplayErrors != null)
                {
                    this._DisplayErrors.Click -= eventHandler;
                }
                this._DisplayErrors = value;
                if (this._DisplayErrors != null)
                {
                    this._DisplayErrors.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem DisplayNextScheduleToolStripMenuItem1
        {
            get
            {
                return this._DisplayNextScheduleToolStripMenuItem1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.DisplayNextScheduleToolStripMenuItem1_Click);
                if (this._DisplayNextScheduleToolStripMenuItem1 != null)
                {
                    this._DisplayNextScheduleToolStripMenuItem1.Click -= eventHandler;
                }
                this._DisplayNextScheduleToolStripMenuItem1 = value;
                if (this._DisplayNextScheduleToolStripMenuItem1 != null)
                {
                    this._DisplayNextScheduleToolStripMenuItem1.Click += eventHandler;
                }
            }
        }

        internal virtual Button EditBtn
        {
            get
            {
                return this._EditBtn;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.EditBtn_Click);
                if (this._EditBtn != null)
                {
                    this._EditBtn.Click -= eventHandler;
                }
                this._EditBtn = value;
                if (this._EditBtn != null)
                {
                    this._EditBtn.Click += eventHandler;
                }
            }
        }

        internal virtual RadioButton enhancedRadioButton
        {
            get
            {
                return this._enhancedRadioButton;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._enhancedRadioButton = value;
            }
        }

        internal virtual ToolStripMenuItem ExitToolStripMenuItem
        {
            get
            {
                return this._ExitToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.ExitToolStripMenuItem_Click);
                if (this._ExitToolStripMenuItem != null)
                {
                    this._ExitToolStripMenuItem.Click -= eventHandler;
                }
                this._ExitToolStripMenuItem = value;
                if (this._ExitToolStripMenuItem != null)
                {
                    this._ExitToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem FileToolStripMenuItem
        {
            get
            {
                return this._FileToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._FileToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem FiltersToolStripMenuItem
        {
            get
            {
                return this._FiltersToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.FiltersToolStripMenuItem_Click);
                if (this._FiltersToolStripMenuItem != null)
                {
                    this._FiltersToolStripMenuItem.Click -= eventHandler;
                }
                this._FiltersToolStripMenuItem = value;
                if (this._FiltersToolStripMenuItem != null)
                {
                    this._FiltersToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual RadioButton forcedRadioButton
        {
            get
            {
                return this._forcedRadioButton;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._forcedRadioButton = value;
            }
        }

        internal virtual GroupBox GroupBox1
        {
            get
            {
                return this._GroupBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox1 = value;
            }
        }

        internal virtual GroupBox GroupBox2
        {
            get
            {
                return this._GroupBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox2 = value;
            }
        }

        internal virtual GroupBox GroupBox3
        {
            get
            {
                return this._GroupBox3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox3 = value;
            }
        }

        internal virtual ToolStripMenuItem HelpToolStripMenuItem
        {
            get
            {
                return this._HelpToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._HelpToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem IndexToolStripMenuItem
        {
            get
            {
                return this._IndexToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._IndexToolStripMenuItem = value;
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
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.Label1_Click);
                if (this._Label1 != null)
                {
                    this._Label1.Click -= eventHandler;
                }
                this._Label1 = value;
                if (this._Label1 != null)
                {
                    this._Label1.Click += eventHandler;
                }
            }
        }

        internal virtual Label Label10
        {
            get
            {
                return this._Label10;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label10 = value;
            }
        }

        internal virtual Label Label11
        {
            get
            {
                return this._Label11;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label11 = value;
            }
        }

        internal virtual Label Label12
        {
            get
            {
                return this._Label12;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label12 = value;
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

        internal virtual Label Label3
        {
            get
            {
                return this._Label3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label3 = value;
            }
        }

        internal virtual Label Label4
        {
            get
            {
                return this._Label4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label4 = value;
            }
        }

        internal virtual Label Label5
        {
            get
            {
                return this._Label5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label5 = value;
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

        internal virtual Label Label7
        {
            get
            {
                return this._Label7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label7 = value;
            }
        }

        internal virtual Label Label8
        {
            get
            {
                return this._Label8;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label8 = value;
            }
        }

        internal virtual Label Label9
        {
            get
            {
                return this._Label9;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label9 = value;
            }
        }

        internal virtual ToolStripMenuItem ListenToolStripMenuItem
        {
            get
            {
                return this._ListenToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.ListenToolStripMenuItem_Click);
                WindowsApplication1.Network network1 = this;
                EventHandler eventHandler1 = new EventHandler(network1.ListenToolStripMenuItem_CheckedChanged);
                if (this._ListenToolStripMenuItem != null)
                {
                    this._ListenToolStripMenuItem.Click -= eventHandler;
                    this._ListenToolStripMenuItem.CheckedChanged -= eventHandler1;
                }
                this._ListenToolStripMenuItem = value;
                if (this._ListenToolStripMenuItem != null)
                {
                    this._ListenToolStripMenuItem.Click += eventHandler;
                    this._ListenToolStripMenuItem.CheckedChanged += eventHandler1;
                }
            }
        }

        internal virtual ToolStripMenuItem LoadFirmwareToolStripMenuItem
        {
            get
            {
                return this._LoadFirmwareToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.LoadFirmwareToolStripMenuItem_Click);
                if (this._LoadFirmwareToolStripMenuItem != null)
                {
                    this._LoadFirmwareToolStripMenuItem.Click -= eventHandler;
                }
                this._LoadFirmwareToolStripMenuItem = value;
                if (this._LoadFirmwareToolStripMenuItem != null)
                {
                    this._LoadFirmwareToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual Button LogBtn
        {
            get
            {
                return this._LogBtn;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.LogBtn_Click);
                if (this._LogBtn != null)
                {
                    this._LogBtn.Click -= eventHandler;
                }
                this._LogBtn = value;
                if (this._LogBtn != null)
                {
                    this._LogBtn.Click += eventHandler;
                }
            }
        }

        internal virtual Label LOGfilelbl
        {
            get
            {
                return this._LOGfilelbl;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._LOGfilelbl = value;
            }
        }

        internal virtual ToolStripMenuItem LogfileToolStripMenuItem
        {
            get
            {
                return this._LogfileToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._LogfileToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem LogFileToolStripMenuItem1
        {
            get
            {
                return this._LogFileToolStripMenuItem1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.LogFileToolStripMenuItem1_Click);
                if (this._LogFileToolStripMenuItem1 != null)
                {
                    this._LogFileToolStripMenuItem1.Click -= eventHandler;
                }
                this._LogFileToolStripMenuItem1 = value;
                if (this._LogFileToolStripMenuItem1 != null)
                {
                    this._LogFileToolStripMenuItem1.Click += eventHandler;
                }
            }
        }

        internal virtual MenuStrip MenuStrip1
        {
            get
            {
                return this._MenuStrip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._MenuStrip1 = value;
            }
        }

        internal virtual ListBox MessageLstBox
        {
            get
            {
                return this._MessageLstBox;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.MessageLstBox_DoubleClick);
                if (this._MessageLstBox != null)
                {
                    this._MessageLstBox.DoubleClick -= eventHandler;
                }
                this._MessageLstBox = value;
                if (this._MessageLstBox != null)
                {
                    this._MessageLstBox.DoubleClick += eventHandler;
                }
            }
        }

        internal virtual NumericUpDown NumericUpDown1
        {
            get
            {
                return this._NumericUpDown1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.NumericUpDown1_ValueChanged);
                if (this._NumericUpDown1 != null)
                {
                    this._NumericUpDown1.ValueChanged -= eventHandler;
                }
                this._NumericUpDown1 = value;
                if (this._NumericUpDown1 != null)
                {
                    this._NumericUpDown1.ValueChanged += eventHandler;
                }
            }
        }

        public virtual LIN OnAnswerSource
        {
            get
            {
                return this._OnAnswerSource;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                LIN.GUINotifierOR gUINotifierOR = new LIN.GUINotifierOR(network.HandleOnReceive);
                WindowsApplication1.Network network1 = this;
                LIN.GUINotifierOA gUINotifierOA = new LIN.GUINotifierOA(network1.HandleOnAnswer);
                if (this._OnAnswerSource != null)
                {
                    LIN.OnReceive -= gUINotifierOR;
                    LIN.OnAnswer -= gUINotifierOA;
                }
                this._OnAnswerSource = value;
                if (this._OnAnswerSource != null)
                {
                    LIN.OnReceive += gUINotifierOR;
                    LIN.OnAnswer += gUINotifierOA;
                }
            }
        }

        public virtual LIN OnReceiveSource
        {
            get
            {
                return this._OnReceiveSource;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._OnReceiveSource = value;
            }
        }

        internal virtual OpenFileDialog OpenFileDialog1
        {
            get
            {
                return this._OpenFileDialog1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._OpenFileDialog1 = value;
            }
        }

        internal virtual OpenFileDialog OpenFileDialog2
        {
            get
            {
                return this._OpenFileDialog2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._OpenFileDialog2 = value;
            }
        }

        internal virtual ToolStripMenuItem OpenToolStripMenuItem
        {
            get
            {
                return this._OpenToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.OpenToolStripMenuItem_Click);
                if (this._OpenToolStripMenuItem != null)
                {
                    this._OpenToolStripMenuItem.Click -= eventHandler;
                }
                this._OpenToolStripMenuItem = value;
                if (this._OpenToolStripMenuItem != null)
                {
                    this._OpenToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem OptionsToolStripMenuItem
        {
            get
            {
                return this._OptionsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._OptionsToolStripMenuItem = value;
            }
        }

        internal virtual PageSetupDialog PageSetupDialog1
        {
            get
            {
                return this._PageSetupDialog1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._PageSetupDialog1 = value;
            }
        }

        internal virtual PictureBox PictureBox1
        {
            get
            {
                return this._PictureBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._PictureBox1 = value;
            }
        }

        internal virtual PictureBox PictureBox2
        {
            get
            {
                return this._PictureBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._PictureBox2 = value;
            }
        }

        internal virtual PrintDialog PrintDialog1
        {
            get
            {
                return this._PrintDialog1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._PrintDialog1 = value;
            }
        }

        internal virtual PrintDocument PrintDocument1
        {
            get
            {
                return this._PrintDocument1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler(network.PrintDocument1_PrintPage);
                if (this._PrintDocument1 != null)
                {
                    this._PrintDocument1.PrintPage -= printPageEventHandler;
                }
                this._PrintDocument1 = value;
                if (this._PrintDocument1 != null)
                {
                    this._PrintDocument1.PrintPage += printPageEventHandler;
                }
            }
        }

        internal virtual PrintPreviewDialog PrintPreviewDialog1
        {
            get
            {
                return this._PrintPreviewDialog1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._PrintPreviewDialog1 = value;
            }
        }

        internal virtual ToolStripMenuItem PrintPreviewToolStripMenuItem
        {
            get
            {
                return this._PrintPreviewToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.PrintPreviewToolStripMenuItem_Click);
                if (this._PrintPreviewToolStripMenuItem != null)
                {
                    this._PrintPreviewToolStripMenuItem.Click -= eventHandler;
                }
                this._PrintPreviewToolStripMenuItem = value;
                if (this._PrintPreviewToolStripMenuItem != null)
                {
                    this._PrintPreviewToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem PrintSetupToolStripMenuItem
        {
            get
            {
                return this._PrintSetupToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.PrintSetupToolStripMenuItem_Click);
                if (this._PrintSetupToolStripMenuItem != null)
                {
                    this._PrintSetupToolStripMenuItem.Click -= eventHandler;
                }
                this._PrintSetupToolStripMenuItem = value;
                if (this._PrintSetupToolStripMenuItem != null)
                {
                    this._PrintSetupToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem PrintToolStripMenuItem
        {
            get
            {
                return this._PrintToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.PrintToolStripMenuItem_Click);
                if (this._PrintToolStripMenuItem != null)
                {
                    this._PrintToolStripMenuItem.Click -= eventHandler;
                }
                this._PrintToolStripMenuItem = value;
                if (this._PrintToolStripMenuItem != null)
                {
                    this._PrintToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem ReconnectToolStripMenuItem
        {
            get
            {
                return this._ReconnectToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.ReconnectToolStripMenuItem_Click);
                if (this._ReconnectToolStripMenuItem != null)
                {
                    this._ReconnectToolStripMenuItem.Click -= eventHandler;
                }
                this._ReconnectToolStripMenuItem = value;
                if (this._ReconnectToolStripMenuItem != null)
                {
                    this._ReconnectToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
        {
            get
            {
                return this._SaveAsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.SaveAsToolStripMenuItem_Click);
                if (this._SaveAsToolStripMenuItem != null)
                {
                    this._SaveAsToolStripMenuItem.Click -= eventHandler;
                }
                this._SaveAsToolStripMenuItem = value;
                if (this._SaveAsToolStripMenuItem != null)
                {
                    this._SaveAsToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual SaveFileDialog SaveFileDialog1
        {
            get
            {
                return this._SaveFileDialog1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._SaveFileDialog1 = value;
            }
        }

        internal virtual ToolStripMenuItem SaveToolStripMenuItem
        {
            get
            {
                return this._SaveToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.SaveToolStripMenuItem_Click);
                if (this._SaveToolStripMenuItem != null)
                {
                    this._SaveToolStripMenuItem.Click -= eventHandler;
                }
                this._SaveToolStripMenuItem = value;
                if (this._SaveToolStripMenuItem != null)
                {
                    this._SaveToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual Label SCRIPTfilelbl
        {
            get
            {
                return this._SCRIPTfilelbl;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._SCRIPTfilelbl = value;
            }
        }

        internal virtual ToolStripMenuItem ScriptFileToolStripMenuItem
        {
            get
            {
                return this._ScriptFileToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.ScriptFileToolStripMenuItem_Click);
                if (this._ScriptFileToolStripMenuItem != null)
                {
                    this._ScriptFileToolStripMenuItem.Click -= eventHandler;
                }
                this._ScriptFileToolStripMenuItem = value;
                if (this._ScriptFileToolStripMenuItem != null)
                {
                    this._ScriptFileToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem SearchToolStripMenuItem
        {
            get
            {
                return this._SearchToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._SearchToolStripMenuItem = value;
            }
        }

        internal virtual Button Sendbtn
        {
            get
            {
                return this._Sendbtn;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.Sendbtn_Click);
                if (this._Sendbtn != null)
                {
                    this._Sendbtn.Click -= eventHandler;
                }
                this._Sendbtn = value;
                if (this._Sendbtn != null)
                {
                    this._Sendbtn.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem SetupToolStripMenuItem
        {
            get
            {
                return this._SetupToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._SetupToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem SlaveResponseToolStripMenuItem
        {
            get
            {
                return this._SlaveResponseToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.SlaveResponseToolStripMenuItem_Click);
                if (this._SlaveResponseToolStripMenuItem != null)
                {
                    this._SlaveResponseToolStripMenuItem.Click -= eventHandler;
                }
                this._SlaveResponseToolStripMenuItem = value;
                if (this._SlaveResponseToolStripMenuItem != null)
                {
                    this._SlaveResponseToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem SnoopToolStripMenuItem
        {
            get
            {
                return this._SnoopToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.SnoopToolStripMenuItem_Click);
                WindowsApplication1.Network network1 = this;
                EventHandler eventHandler1 = new EventHandler(network1.SnoopToolStripMenuItem_CheckedChanged);
                if (this._SnoopToolStripMenuItem != null)
                {
                    this._SnoopToolStripMenuItem.Click -= eventHandler;
                    this._SnoopToolStripMenuItem.CheckedChanged -= eventHandler1;
                }
                this._SnoopToolStripMenuItem = value;
                if (this._SnoopToolStripMenuItem != null)
                {
                    this._SnoopToolStripMenuItem.Click += eventHandler;
                    this._SnoopToolStripMenuItem.CheckedChanged += eventHandler1;
                }
            }
        }

        internal virtual System.Windows.Forms.ToolStripStatusLabel StatusError
        {
            get
            {
                return this._StatusError;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._StatusError = value;
            }
        }

        internal virtual StatusStrip StatusStrip1
        {
            get
            {
                return this._StatusStrip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._StatusStrip1 = value;
            }
        }

        internal virtual ToolStripMenuItem SupressBusTimeoutErrorToolStripMenuItem
        {
            get
            {
                return this._SupressBusTimeoutErrorToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.SupressBusTimeoutErrorToolStripMenuItem_Click);
                if (this._SupressBusTimeoutErrorToolStripMenuItem != null)
                {
                    this._SupressBusTimeoutErrorToolStripMenuItem.Click -= eventHandler;
                }
                this._SupressBusTimeoutErrorToolStripMenuItem = value;
                if (this._SupressBusTimeoutErrorToolStripMenuItem != null)
                {
                    this._SupressBusTimeoutErrorToolStripMenuItem.Click += eventHandler;
                }
            }
        }

        internal virtual RichTextBox TextBox1
        {
            get
            {
                return this._TextBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.TextBox1_Click);
                WindowsApplication1.Network network1 = this;
                EventHandler eventHandler1 = new EventHandler(network1.TextBox1_Leave);
                WindowsApplication1.Network network2 = this;
                KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(network2.TextBox1_KeyPress);
                if (this._TextBox1 != null)
                {
                    this._TextBox1.Click -= eventHandler;
                    this._TextBox1.Leave -= eventHandler1;
                    this._TextBox1.KeyPress -= keyPressEventHandler;
                }
                this._TextBox1 = value;
                if (this._TextBox1 != null)
                {
                    this._TextBox1.Click += eventHandler;
                    this._TextBox1.Leave += eventHandler1;
                    this._TextBox1.KeyPress += keyPressEventHandler;
                }
            }
        }

        internal virtual Timer Timer1
        {
            get
            {
                return this._Timer1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.Timer1_Tick);
                if (this._Timer1 != null)
                {
                    this._Timer1.Tick -= eventHandler;
                }
                this._Timer1 = value;
                if (this._Timer1 != null)
                {
                    this._Timer1.Tick += eventHandler;
                }
            }
        }

        internal virtual ToolStripMenuItem ToolsToolStripMenuItem
        {
            get
            {
                return this._ToolsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolsToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripSeparator toolStripSeparator
        {
            get
            {
                return this._toolStripSeparator;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._toolStripSeparator = value;
            }
        }

        internal virtual ToolStripSeparator toolStripSeparator1
        {
            get
            {
                return this._toolStripSeparator1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._toolStripSeparator1 = value;
            }
        }

        internal virtual ToolStripSeparator toolStripSeparator2
        {
            get
            {
                return this._toolStripSeparator2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._toolStripSeparator2 = value;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator3
        {
            get
            {
                return this._ToolStripSeparator3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator3 = value;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator4
        {
            get
            {
                return this._ToolStripSeparator4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator4 = value;
            }
        }

        internal virtual ToolStripSeparator toolStripSeparator5
        {
            get
            {
                return this._toolStripSeparator5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._toolStripSeparator5 = value;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            get
            {
                return this._ToolStripSeparator6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator6 = value;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            get
            {
                return this._ToolStripSeparator7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator7 = value;
            }
        }

        internal virtual System.Windows.Forms.ToolStripStatusLabel ToolStripStatusBaud
        {
            get
            {
                return this._ToolStripStatusBaud;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.ToolStripStatusBaud_Click);
                if (this._ToolStripStatusBaud != null)
                {
                    this._ToolStripStatusBaud.Click -= eventHandler;
                }
                this._ToolStripStatusBaud = value;
                if (this._ToolStripStatusBaud != null)
                {
                    this._ToolStripStatusBaud.Click += eventHandler;
                }
            }
        }

        internal virtual System.Windows.Forms.ToolStripStatusLabel ToolStripStatusCOMStatus
        {
            get
            {
                return this._ToolStripStatusCOMStatus;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripStatusCOMStatus = value;
            }
        }

        internal virtual System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel
        {
            get
            {
                return this._ToolStripStatusLabel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripStatusLabel = value;
            }
        }

        internal virtual ToolTip ToolTip1
        {
            get
            {
                return this._ToolTip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolTip1 = value;
            }
        }

        internal virtual ToolStripMenuItem TransmitToolStripMenuItem
        {
            get
            {
                return this._TransmitToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                WindowsApplication1.Network network = this;
                EventHandler eventHandler = new EventHandler(network.TransmitToolStripMenuItem_Click);
                WindowsApplication1.Network network1 = this;
                EventHandler eventHandler1 = new EventHandler(network1.TransmitToolStripMenuItem_CheckedChanged);
                if (this._TransmitToolStripMenuItem != null)
                {
                    this._TransmitToolStripMenuItem.Click -= eventHandler;
                    this._TransmitToolStripMenuItem.CheckedChanged -= eventHandler1;
                }
                this._TransmitToolStripMenuItem = value;
                if (this._TransmitToolStripMenuItem != null)
                {
                    this._TransmitToolStripMenuItem.Click += eventHandler;
                    this._TransmitToolStripMenuItem.CheckedChanged += eventHandler1;
                }
            }
        }

        public Network()
        {
            WindowsApplication1.Network network = this;
            base.GotFocus += new EventHandler(network.Network_GotFocus);
            WindowsApplication1.Network network1 = this;
            base.Load += new EventHandler(network1.Network_Load);
            WindowsApplication1.Network network2 = this;
            base.Shown += new EventHandler(network2.Network_Shown);
            WindowsApplication1.Network network3 = this;
            base.Resize += new EventHandler(network3.Network_Resize);
            WindowsApplication1.Network network4 = this;
            base.FormClosed += new FormClosedEventHandler(network4.Network_FormClosed);
            this.ListenCnt = 0;
            this.LOGrecord = 0;
            this.chksum = 0;
            this.TestData = 0;
            this.LOGpath = "";
            this.SCRIPTpath = "";
            this.MasterBaudRate = 9600;
            this.SelectedCOMport = -1;
            this.PID = 2564;
            this.PKSAPID = 54;
            this.HitError = false;
            this.HitErrorCount = 10;
            this.SendOnce = true;
            this.DisplayResultsLock = new DataObject();
            this.temp_textbox = new RichTextBox();
            this.inter_textbox = new RichTextBox();
            this.RTFstrng = new RichTextBox();
            this.m_need_to_scroll_to_bottom_next_time = false;
            this.InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.AboutForm.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string str = Interaction.InputBox("Enter LIN meesage, ID first, byte separated by spaces", "LIN Message", "", -1, -1);
            if (Operators.CompareString(str, "", false) != 0)
            {
                this.MessageLstBox.Items.Insert(this.MessageLstBox.Items.Count, str);
                this.MessageLstBox.SelectedIndex = -1;
                this.MessageLstBox.SelectedValue = null;
            }
        }

        private void ChangeMode(object sender, EventArgs e)
        {
            LIN.SetModeDisplayAll();
            this.TextBox1.Clear();
            this.ListenCnt = 0;
        }

        public bool CheckParityBits(byte masterID)
        {
            // Extract the 6-bit identifier (ID5 ID4 ID3 ID2 ID1 ID0)
            byte identifier = (byte)(masterID & 0x3F);

            // Extract the parity bits (P1 P0)
            byte receivedParity = (byte)(masterID & 0xC0);

            // Calculate P0 and P1
            bool p0 = (((identifier >> 0) & 1) ^ ((identifier >> 1) & 1) ^ ((identifier >> 2) & 1) ^ ((identifier >> 4) & 1)) == 1;
            bool p1 = (((identifier >> 1) & 1) ^ ((identifier >> 3) & 1) ^ ((identifier >> 4) & 1) ^ ((identifier >> 5) & 1)) == 1;

            // Construct the expected parity
            byte expectedParity = 0;
            if (p0)
            {
                expectedParity |= 0x40; // Set bit 6
            }
            if (p1)
            {
                expectedParity |= 0x80; // Set bit 7
            }

            // Compare received parity with expected parity
            return receivedParity == expectedParity;
        }

        public bool CheckParityBits2(byte masterID)
        {
            byte[] numArray = new byte[] { masterID };
            BitArray bitArrays = new BitArray(numArray);
            bool item = bitArrays[0] ^ bitArrays[1] ^ bitArrays[2] ^ bitArrays[4];
            bool flag = !(bitArrays[1] ^ bitArrays[3] ^ bitArrays[4] ^ bitArrays[5]);
            if (!item)
            {
                numArray[0] = 0;
            }
            else
            {
                numArray[0] = 64;
            }
            if (flag)
            {
                numArray[0] = checked((byte)(numArray[0] | 128));
            }
            return (masterID & 192 ^ numArray[0]) != 0;
        }

        private void classicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ClearMonitorWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "";
        }

        private void COMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.COMsetup.ShowDialog();
        }

        private void ContSendbtn_Click(object sender, EventArgs e)
        {
            if (Operators.CompareString(this.ContSendbtn.Text, "Continuous", false) != 0)
            {
                this.ContSendbtn.Text = "Continuous";
                this.MessageLstBox.Enabled = true;
                this.Sendbtn.Enabled = true;
                this.DeleteBtn.Enabled = true;
                this.SendOnce = true;
                this.Timer1.Enabled = false;
                this.Timer1.Stop();
            }
            else if (decimal.Compare(this.NumericUpDown1.Value, new decimal((long)10)) > 0)
            {
                this.Timer1.Interval = Convert.ToInt32(this.NumericUpDown1.Value);
                this.Timer1.Enabled = true;
                this.Timer1.Start();
                this.ContSendbtn.Text = "Stop";
                this.MessageLstBox.Enabled = false;
                this.Sendbtn.Enabled = false;
                this.DeleteBtn.Enabled = false;
                this.selectedmessagepointer = 0;
                this.SendOnce = false;
            }
        }

        private void DebugModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.DebugModeToolStripMenuItem.Checked)
            {
                this.DebugModeToolStripMenuItem.Checked = true;
                this.forcedRadioButton.Enabled = true;
            }
            else
            {
                this.DebugModeToolStripMenuItem.Checked = false;
                this.forcedRadioButton.Enabled = false;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            while (this.MessageLstBox.SelectedIndex != -1)
            {
                this.MessageLstBox.Items.Remove(RuntimeHelpers.GetObjectValue(this.MessageLstBox.SelectedItem));
            }
        }

        private void DisplayErrors_Click(object sender, EventArgs e)
        {
            this.SnoopToolStripMenuItem.Checked = false;
            this.ListenToolStripMenuItem.Checked = false;
            this.TransmitToolStripMenuItem.Checked = false;
            this.DisplayErrors.Checked = true;
            this.DisplayNextScheduleToolStripMenuItem1.Checked = false;
        }

        private void DisplayNextScheduleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.SnoopToolStripMenuItem.Checked = false;
            this.ListenToolStripMenuItem.Checked = false;
            this.TransmitToolStripMenuItem.Checked = false;
            this.DisplayErrors.Checked = true;
            this.DisplayNextScheduleToolStripMenuItem1.Checked = true;
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.MessageLstBox.SelectedIndex;
            string str = Interaction.InputBox("Edit LIN meesage, ID first, byte separated by spaces", "LIN Message", Conversions.ToString(this.MessageLstBox.SelectedItem), -1, -1);
            if (Operators.CompareString(str, "", false) != 0)
            {
                this.MessageLstBox.Items.Remove(RuntimeHelpers.GetObjectValue(this.MessageLstBox.SelectedItem));
                this.MessageLstBox.Items.Insert(selectedIndex, str);
            }
            this.MessageLstBox.SelectedIndex = -1;
            this.MessageLstBox.SelectedValue = null;
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectData.EndApp();
        }

        private void FiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.Filters.Show();
        }

        //public byte GenParityBits(byte masterID)
        //{
        //    byte[] numArray = new byte[] { masterID };
        //    BitArray bitArrays = new BitArray(numArray);
        //    if (!(!this.forcedRadioButton.Checked & masterID < 64))
        //    {
        //        numArray[0] = 0;
        //    }
        //    else
        //    {
        //        bool item = bitArrays[0] ^ bitArrays[1] ^ bitArrays[2] ^ bitArrays[4];
        //        bool flag = !(bitArrays[1] ^ bitArrays[3] ^ bitArrays[4] ^ bitArrays[5]);
        //        if (!item)
        //        {
        //            numArray[0] = 0;
        //        }
        //        else
        //        {
        //            numArray[0] = 64;
        //        }
        //        if (flag)
        //        {
        //            numArray[0] = checked((byte)(numArray[0] | 128));
        //        }
        //    }
        //    //return masterID | numArray[0];
        //    return (byte)(masterID | parity);


        //}


        public byte GenParityBits(byte masterID)
        {
            byte parity = 0;

            // If forcedRadioButton is checked or masterID >= 64, set parity to 0
            if (!forcedRadioButton.Checked && masterID < 64)
            {
                // Calculate P0 and P1 parity bits
                bool p0 = ((masterID & 1) ^ ((masterID >> 1) & 1) ^ ((masterID >> 2) & 1) ^ ((masterID >> 4) & 1)) != 0;
                bool p1 = (((masterID >> 1) & 1) ^ ((masterID >> 3) & 1) ^ ((masterID >> 4) & 1) ^ ((masterID >> 5) & 1)) == 0;

                // Set parity bits based on P0 and P1
                if (p0)
                {
                    parity |= 64; // Set bit 6
                }
                if (p1)
                {
                    parity |= 128; // Set bit 7
                }
            }

            // Return masterID with parity bits
            return (byte)(masterID | parity);
        }

        public byte GenParityBits3(byte masterID)
        {
            byte parity = 0;

            // If forcedRadioButton is not checked and masterID < 64, calculate parity bits
            if (!forcedRadioButton.Checked && masterID < 64)
            {
                // Calculate P0 and P1 parity bits
                bool p0 = (((masterID >> 0) & 1) ^ ((masterID >> 1) & 1) ^ ((masterID >> 2) & 1) ^ ((masterID >> 4) & 1)) == 1;
                bool p1 = (((masterID >> 1) & 1) ^ ((masterID >> 3) & 1) ^ ((masterID >> 4) & 1) ^ ((masterID >> 5) & 1)) == 1;

                // Set parity bits based on P0 and P1
                if (p0)
                {
                    parity |= 0x40; // Set bit 6
                }
                if (p1)
                {
                    parity |= 0x80; // Set bit 7
                }
            }

            // Return masterID with parity bits
            return (byte)(masterID | parity);
        }



        [DllImport("Kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetPrivateProfileStringA", ExactSpelling = true, SetLastError = true)]
        public static extern int GetPrivateProfileString(ref string lpApplicationName, ref string lpKeyName, ref string lpDefault, ref string lpRetunedString, int nSize, ref string lpFileName);

        private void HandleOnAnswer(byte masterID, byte[] data, byte length, byte ErrorCode, ushort baudrate, double timestamp)
        {
            int k;
            if (this.InvokeRequired)
            {
                WindowsApplication1.Network network = this;
                WindowsApplication1.Network.Threaded_OnAnswer threadedOnAnswer = new WindowsApplication1.Network.Threaded_OnAnswer(network.HandleOnAnswer);
                byte[] numArray = new byte[11];
                int num = checked(length - 1);
                for (int i = 0; i <= num; i = checked(i + 1))
                {
                    numArray[i] = data[i];
                }
                object[] objArray = new object[] { masterID, numArray, length, ErrorCode, baudrate, timestamp };
                this.BeginInvoke(threadedOnAnswer, objArray);
                return;
            }
            string str = "";
            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            lock (this.DisplayResultsLock)
            {
                this.RTFstrng.Text = "";
                this.FilterID = masterID;
                int num1 = 0;
                str3 = Strings.Format(timestamp, "00000.000");
                this.UpdateRTFstrng(string.Concat(str3, "   "), Color.Blue);
                str5 = Conversion.Hex(masterID);
                if (str5.Length == 1)
                {
                    str5 = string.Concat("0", str5);
                }
                this.UpdateRTFstrng(str5, Color.Black);
                if (this.CheckParityBits(masterID))
                {
                    ErrorCode = 10;
                }
                int num2 = checked(length - 1);
                for (int j = 0; j <= num2; j = checked(j + 1))
                {
                    num1 = checked(num1 + data[j]);
                    if (num1 >= 256)
                    {
                        num1 = checked(num1 - 255);
                    }
                    if (j < checked(length - 1))
                    {
                        str1 = Conversion.Hex(data[j]);
                        if (str1.Length == 1)
                        {
                            str1 = string.Concat("0", str1);
                        }
                        str2 = string.Concat(str2, "  ", str1);
                    }
                }
                int num3 = checked((int)Math.Round((double)(checked(32 - str2.Length)) / 4));
                for (k = 0; k <= num3; k = checked(k + 1))
                {
                    str2 = string.Concat(str2, "    ");
                }
                this.UpdateRTFstrng(str2, Color.Blue);
                if (length != 0)
                {
                    str4 = Conversion.Hex(data[checked(length - 1)]);
                }
                if (str4.Length == 1)
                {
                    str4 = string.Concat("0", str4);
                }
                this.UpdateRTFstrng(string.Concat("  ", str4), Color.Blue);
                if (num1 == 255)
                {
                    this.UpdateRTFstrng("     classic ", Color.Blue);
                }
                else if (checked(num1 + masterID) != 255)
                {
                    this.UpdateRTFstrng("               ", Color.Black);
                    if (ErrorCode != 6)
                    {
                        ErrorCode = 11;
                    }
                }
                else
                {
                    this.UpdateRTFstrng("     enhanced", Color.Blue);
                }
                this.UpdateRTFstrng("  ", Color.Black);
                int num4 = checked((int)Math.Round(5 - Conversions.ToDouble(Strings.Trim(Conversions.ToString(baudrate.ToString().Length)))));
                for (k = 1; k <= num4; k = checked(k + 1))
                {
                    this.UpdateRTFstrng(" ", Color.Black);
                }
                this.UpdateRTFstrng(baudrate.ToString(), Color.Black);
                this.UpdateRTFstrng("    ", Color.Black);
                switch (ErrorCode)
                {
                    case 1:
                        {
                            if (!this.SupressBusTimeoutErrorToolStripMenuItem.Checked)
                            {
                                this.UpdateRTFstrng("Bus timeout", Color.Black);
                                goto case 9;
                            }
                            else
                            {
                                goto case 9;
                            }
                        }
                    case 2:
                        {
                            this.UpdateRTFstrng("No SyncBreak", Color.Black);
                            goto case 9;
                        }
                    case 3:
                        {
                            this.UpdateRTFstrng("Error Resetting Timestamp", Color.Red);
                            goto case 9;
                        }
                    case 4:
                        {
                            this.UpdateRTFstrng("PKSA Status Error", Color.Red);
                            goto case 9;
                        }
                    case 5:
                        {
                            str = string.Concat(str, "PKSA Event Marker Error");
                            goto case 9;
                        }
                    case 6:
                        {
                            this.UpdateRTFstrng("No Answer", Color.Black);
                            goto case 9;
                        }
                    case 7:
                    case 9:
                        {
                            if (this.DisplayErrors.Checked)
                            {
                                if (!(ErrorCode == 0 | ErrorCode == 1))
                                {
                                    this.HitError = true;
                                    this.HitErrorCount = checked(this.HitErrorCount - 1);
                                    if (this.HitErrorCount == 0)
                                    {
                                        this.HitErrorCount = 10;
                                        this.HitError = false;
                                    }
                                }
                                else if (!this.HitError)
                                {
                                    break;
                                }
                            }
                            this.UpdateRTFstrng(" \r\n", Color.Black);
                            this.UpdateTextBox(this.RTFstrng.Rtf, Color.Black);
                            break;
                        }
                    case 8:
                        {
                            this.UpdateRTFstrng("SwBreak", Color.Black);
                            goto case 9;
                        }
                    case 10:
                        {
                            this.UpdateRTFstrng("Parity Error", Color.Red);
                            goto case 9;
                        }
                    case 11:
                        {
                            this.UpdateRTFstrng("Checksum", Color.Red);
                            goto case 9;
                        }
                    default:
                        {
                            goto case 9;
                        }
                }
            }
        }

        public byte ExtractIdentifier(byte masterID)
        {
            // Mask out the parity bits (upper 2 bits) to get the original 6-bit identifier
            return (byte)(masterID & 0x3F);
        }
        private void HandleOnReceive(byte masterID, byte[] data, byte length, byte ErrorCode, ushort baudrate, double timestamp)
        {
            int k;
            if (this.InvokeRequired)
            {
                WindowsApplication1.Network network = this;
                WindowsApplication1.Network.Threaded_OnReceive threadedOnReceive = new WindowsApplication1.Network.Threaded_OnReceive(network.HandleOnReceive);
                byte[] numArray = new byte[11];
                int num = checked(length - 1);
                for (int i = 0; i <= num; i = checked(i + 1))
                {
                    numArray[i] = data[i];
                }
                object[] objArray = new object[] { masterID, numArray, length, ErrorCode, baudrate, timestamp };
                this.BeginInvoke(threadedOnReceive, objArray);
                return;
            }
            string str = "";
            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            lock (this.DisplayResultsLock)
            {
                this.RTFstrng.Text = "";
                this.FilterID = masterID;
                int num1 = 0;
                str3 = Strings.Format(timestamp, "00000.000");
                this.UpdateRTFstrng(string.Concat(str3, "   "), Color.Black);

                byte originalIdentifier = ExtractIdentifier(masterID);

                str5 = Conversion.Hex(masterID);
                str5 = Conversion.Hex(originalIdentifier);


                if (str5.Length == 1)
                {
                    str5 = string.Concat("0", str5);
                }
                this.UpdateRTFstrng(str5, Color.Black);
                if (this.CheckParityBits(masterID))
                {
                    ErrorCode = 10;
                }
                int num2 = checked(length - 1);
                for (int j = 0; j <= num2; j = checked(j + 1))
                {
                    num1 = checked(num1 + data[j]);
                    if (num1 >= 256)
                    {
                        num1 = checked(num1 - 255);
                    }
                    if (j < checked(length - 1))
                    {
                        str1 = Conversion.Hex(data[j]);
                        if (str1.Length == 1)
                        {
                            str1 = string.Concat("0", str1);
                        }
                        str2 = string.Concat(str2, "  ", str1);
                    }
                }
                int num3 = checked((int)Math.Round((double)(checked(32 - str2.Length)) / 4));
                for (k = 0; k <= num3; k = checked(k + 1))
                {
                    str2 = string.Concat(str2, "    ");
                }
                this.UpdateRTFstrng(str2, Color.Black);
                if (length != 0)
                {
                    str4 = Conversion.Hex(data[checked(length - 1)]);
                }
                if (str4.Length == 1)
                {
                    str4 = string.Concat("0", str4);
                }
                this.UpdateRTFstrng(string.Concat("  ", str4), Color.Black);
                if (num1 == 255)
                {
                    this.UpdateRTFstrng("     classic ", Color.Black);
                }
                else if (checked(num1 + masterID) != 255)
                {
                    this.UpdateRTFstrng("               ", Color.Black);
                    if (ErrorCode != 6)
                    {
                        ErrorCode = 11;
                    }
                }
                else
                {
                    this.UpdateRTFstrng("     enhanced", Color.Black);
                }
                this.UpdateRTFstrng("  ", Color.Black);
                int num4 = checked((int)Math.Round(5 - Conversions.ToDouble(Strings.Trim(Conversions.ToString(baudrate.ToString().Length)))));
                for (k = 1; k <= num4; k = checked(k + 1))
                {
                    this.UpdateRTFstrng(" ", Color.Black);
                }
                this.UpdateRTFstrng(baudrate.ToString(), Color.Black);
                this.UpdateRTFstrng("    ", Color.Black);
                switch (ErrorCode)
                {
                    case 1:
                        {
                            if (!this.SupressBusTimeoutErrorToolStripMenuItem.Checked)
                            {
                                this.UpdateRTFstrng("Bus timeout", Color.Black);
                                goto case 9;
                            }
                            else
                            {
                                goto case 9;
                            }
                        }
                    case 2:
                        {
                            this.UpdateRTFstrng("No SyncBreak", Color.Black);
                            goto case 9;
                        }
                    case 3:
                        {
                            this.UpdateRTFstrng("Error Resetting Timestamp", Color.Red);
                            goto case 9;
                        }
                    case 4:
                        {
                            this.UpdateRTFstrng("PKSA Status Error", Color.Red);
                            goto case 9;
                        }
                    case 5:
                        {
                            str = string.Concat(str, "PKSA Event Marker Error");
                            goto case 9;
                        }
                    case 6:
                        {
                            this.UpdateRTFstrng("No Answer", Color.Black);
                            goto case 9;
                        }
                    case 7:
                    case 9:
                        {
                            if (this.DisplayErrors.Checked)
                            {
                                if (!(ErrorCode == 0 | ErrorCode == 1))
                                {
                                    this.HitError = true;
                                    this.HitErrorCount = checked(this.HitErrorCount - 1);
                                    if (this.HitErrorCount == 0)
                                    {
                                        this.HitErrorCount = 10;
                                        this.HitError = false;
                                    }
                                }
                                else if (!this.HitError)
                                {
                                    break;
                                }
                            }
                            this.UpdateRTFstrng(" \r\n", Color.Black);
                            this.UpdateTextBox(this.RTFstrng.Rtf, Color.Black);
                            break;
                        }
                    case 8:
                        {
                            this.UpdateRTFstrng("SwBreak", Color.Black);
                            goto case 9;
                        }
                    case 10:
                        {
                            this.UpdateRTFstrng("Parity Error", Color.Red);
                            goto case 9;
                        }
                    case 11:
                        {
                            this.UpdateRTFstrng("Checksum", Color.Red);
                            goto case 9;
                        }
                    default:
                        {
                            goto case 9;
                        }
                }
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WindowsApplication1.Network));
            this.MenuStrip1 = new MenuStrip();
            this.FileToolStripMenuItem = new ToolStripMenuItem();
            this.OpenToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripSeparator = new ToolStripSeparator();
            this.SaveToolStripMenuItem = new ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.PrintToolStripMenuItem = new ToolStripMenuItem();
            this.PrintSetupToolStripMenuItem = new ToolStripMenuItem();
            this.PrintPreviewToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.ExitToolStripMenuItem = new ToolStripMenuItem();
            this.SetupToolStripMenuItem = new ToolStripMenuItem();
            this.COMPortToolStripMenuItem = new ToolStripMenuItem();
            this.ReconnectToolStripMenuItem = new ToolStripMenuItem();
            this.LogFileToolStripMenuItem1 = new ToolStripMenuItem();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.SlaveResponseToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ScriptFileToolStripMenuItem = new ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new ToolStripMenuItem();
            this.DebugModeToolStripMenuItem = new ToolStripMenuItem();
            this.SupressBusTimeoutErrorToolStripMenuItem = new ToolStripMenuItem();
            this.ClearMonitorWindowToolStripMenuItem = new ToolStripMenuItem();
            this.FiltersToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.TransmitToolStripMenuItem = new ToolStripMenuItem();
            this.ListenToolStripMenuItem = new ToolStripMenuItem();
            this.SnoopToolStripMenuItem = new ToolStripMenuItem();
            this.DisplayErrors = new ToolStripMenuItem();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.LoadFirmwareToolStripMenuItem = new ToolStripMenuItem();
            this.HelpToolStripMenuItem = new ToolStripMenuItem();
            this.ContentsToolStripMenuItem = new ToolStripMenuItem();
            this.IndexToolStripMenuItem = new ToolStripMenuItem();
            this.SearchToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.AboutToolStripMenuItem = new ToolStripMenuItem();
            this.LogfileToolStripMenuItem = new ToolStripMenuItem();
            this.StatusStrip1 = new StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusBaud = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusCOMStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusError = new System.Windows.Forms.ToolStripStatusLabel();
            this.Sendbtn = new Button();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.Label5 = new Label();
            this.Label6 = new Label();
            this.Label7 = new Label();
            this.MessageLstBox = new ListBox();
            this.Label8 = new Label();
            this.Label9 = new Label();
            this.DeleteBtn = new Button();
            this.PictureBox1 = new PictureBox();
            this.Label10 = new Label();
            this.ToolTip1 = new ToolTip(this.components);
            this.forcedRadioButton = new RadioButton();
            this.ContSendbtn = new Button();
            this.NumericUpDown1 = new NumericUpDown();
            this.AddBtn = new Button();
            this.EditBtn = new Button();
            this.OpenFileDialog1 = new OpenFileDialog();
            this.Label12 = new Label();
            this.SaveFileDialog1 = new SaveFileDialog();
            this.LogBtn = new Button();
            this.LOGfilelbl = new Label();
            this.PrintDocument1 = new PrintDocument();
            this.PrintDialog1 = new PrintDialog();
            this.PrintPreviewDialog1 = new PrintPreviewDialog();
            this.PageSetupDialog1 = new PageSetupDialog();
            this.PictureBox2 = new PictureBox();
            this.GroupBox1 = new GroupBox();
            this.SCRIPTfilelbl = new Label();
            this.GroupBox2 = new GroupBox();
            this.enhancedRadioButton = new RadioButton();
            this.classicRadioButton = new RadioButton();
            this.GroupBox3 = new GroupBox();
            this.Label11 = new Label();
            this.TextBox1 = new RichTextBox();
            this.Timer1 = new Timer(this.components);
            this.OpenFileDialog2 = new OpenFileDialog();
            this.DisplayNextScheduleToolStripMenuItem1 = new ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((ISupportInitialize)this.PictureBox1).BeginInit();
            ((ISupportInitialize)this.NumericUpDown1).BeginInit();
            ((ISupportInitialize)this.PictureBox2).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            ToolStripItemCollection items = this.MenuStrip1.Items;
            ToolStripItem[] fileToolStripMenuItem = new ToolStripItem[] { this.FileToolStripMenuItem, this.SetupToolStripMenuItem, this.ToolsToolStripMenuItem, this.HelpToolStripMenuItem };
            items.AddRange(fileToolStripMenuItem);
            MenuStrip menuStrip1 = this.MenuStrip1;
            Point point = new Point(0, 0);
            menuStrip1.Location = point;
            this.MenuStrip1.Name = "MenuStrip1";
            MenuStrip menuStrip = this.MenuStrip1;
            System.Drawing.Size size = new System.Drawing.Size(767, 24);
            menuStrip.Size = size;
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip2";
            ToolStripItemCollection dropDownItems = this.FileToolStripMenuItem.DropDownItems;
            fileToolStripMenuItem = new ToolStripItem[] { this.OpenToolStripMenuItem, this.toolStripSeparator, this.SaveToolStripMenuItem, this.SaveAsToolStripMenuItem, this.toolStripSeparator1, this.PrintToolStripMenuItem, this.PrintSetupToolStripMenuItem, this.PrintPreviewToolStripMenuItem, this.toolStripSeparator2, this.ExitToolStripMenuItem };
            dropDownItems.AddRange(fileToolStripMenuItem);
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem = this.FileToolStripMenuItem;
            size = new System.Drawing.Size(39, 20);
            toolStripMenuItem.Size = size;
            this.FileToolStripMenuItem.Text = "&File";
            this.OpenToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("OpenToolStripMenuItem.Image");
            this.OpenToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = Keys.LButton | Keys.RButton | Keys.Cancel | Keys.MButton | Keys.XButton1 | Keys.XButton2 | Keys.Back | Keys.Tab | Keys.LineFeed | Keys.Clear | Keys.Return | Keys.Enter | Keys.A | Keys.B | Keys.C | Keys.D | Keys.E | Keys.F | Keys.G | Keys.H | Keys.I | Keys.J | Keys.K | Keys.L | Keys.M | Keys.N | Keys.O | Keys.Control;
            ToolStripMenuItem openToolStripMenuItem = this.OpenToolStripMenuItem;
            size = new System.Drawing.Size(153, 22);
            openToolStripMenuItem.Size = size;
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.ToolTipText = "Open Inialization File";
            this.toolStripSeparator.Name = "toolStripSeparator";
            ToolStripSeparator toolStripSeparator = this.toolStripSeparator;
            size = new System.Drawing.Size(150, 6);
            toolStripSeparator.Size = size;
            this.SaveToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("SaveToolStripMenuItem.Image");
            this.SaveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = Keys.LButton | Keys.RButton | Keys.Cancel | Keys.ShiftKey | Keys.ControlKey | Keys.Menu | Keys.Pause | Keys.A | Keys.B | Keys.C | Keys.P | Keys.Q | Keys.R | Keys.S | Keys.Control;
            ToolStripMenuItem saveToolStripMenuItem = this.SaveToolStripMenuItem;
            size = new System.Drawing.Size(153, 22);
            saveToolStripMenuItem.Size = size;
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.ToolTipText = "Save Initialization File";
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            ToolStripMenuItem saveAsToolStripMenuItem = this.SaveAsToolStripMenuItem;
            size = new System.Drawing.Size(153, 22);
            saveAsToolStripMenuItem.Size = size;
            this.SaveAsToolStripMenuItem.Text = "Save &As";
            this.SaveAsToolStripMenuItem.ToolTipText = "Save Initialization File As";
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            ToolStripSeparator toolStripSeparator1 = this.toolStripSeparator1;
            size = new System.Drawing.Size(150, 6);
            toolStripSeparator1.Size = size;
            this.PrintToolStripMenuItem.DoubleClickEnabled = true;
            this.PrintToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("PrintToolStripMenuItem.Image");
            this.PrintToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = Keys.ShiftKey | Keys.P | Keys.Control;
            ToolStripMenuItem printToolStripMenuItem = this.PrintToolStripMenuItem;
            size = new System.Drawing.Size(153, 22);
            printToolStripMenuItem.Size = size;
            this.PrintToolStripMenuItem.Text = "&Print";
            this.PrintToolStripMenuItem.ToolTipText = "Print Monitor Window";
            this.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem";
            ToolStripMenuItem printSetupToolStripMenuItem = this.PrintSetupToolStripMenuItem;
            size = new System.Drawing.Size(153, 22);
            printSetupToolStripMenuItem.Size = size;
            this.PrintSetupToolStripMenuItem.Text = "Print Setup";
            this.PrintSetupToolStripMenuItem.ToolTipText = "Setup printer";
            this.PrintPreviewToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("PrintPreviewToolStripMenuItem.Image");
            this.PrintPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            this.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem";
            ToolStripMenuItem printPreviewToolStripMenuItem = this.PrintPreviewToolStripMenuItem;
            size = new System.Drawing.Size(153, 22);
            printPreviewToolStripMenuItem.Size = size;
            this.PrintPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            ToolStripSeparator toolStripSeparator2 = this.toolStripSeparator2;
            size = new System.Drawing.Size(150, 6);
            toolStripSeparator2.Size = size;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ToolStripMenuItem exitToolStripMenuItem = this.ExitToolStripMenuItem;
            size = new System.Drawing.Size(153, 22);
            exitToolStripMenuItem.Size = size;
            this.ExitToolStripMenuItem.Text = "E&xit";
            ToolStripItemCollection toolStripItemCollections = this.SetupToolStripMenuItem.DropDownItems;
            fileToolStripMenuItem = new ToolStripItem[] { this.COMPortToolStripMenuItem, this.ReconnectToolStripMenuItem, this.LogFileToolStripMenuItem1, this.ToolStripSeparator4, this.SlaveResponseToolStripMenuItem, this.ToolStripSeparator7, this.ScriptFileToolStripMenuItem };
            toolStripItemCollections.AddRange(fileToolStripMenuItem);
            this.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem";
            ToolStripMenuItem setupToolStripMenuItem = this.SetupToolStripMenuItem;
            size = new System.Drawing.Size(52, 20);
            setupToolStripMenuItem.Size = size;
            this.SetupToolStripMenuItem.Text = "Setup";
            this.COMPortToolStripMenuItem.Name = "COMPortToolStripMenuItem";
            ToolStripMenuItem cOMPortToolStripMenuItem = this.COMPortToolStripMenuItem;
            size = new System.Drawing.Size(170, 22);
            cOMPortToolStripMenuItem.Size = size;
            this.COMPortToolStripMenuItem.Text = "COM port";
            this.COMPortToolStripMenuItem.ToolTipText = "Setup or change port settings";
            this.ReconnectToolStripMenuItem.Name = "ReconnectToolStripMenuItem";
            ToolStripMenuItem reconnectToolStripMenuItem = this.ReconnectToolStripMenuItem;
            size = new System.Drawing.Size(170, 22);
            reconnectToolStripMenuItem.Size = size;
            this.ReconnectToolStripMenuItem.Text = "Reconnect";
            this.ReconnectToolStripMenuItem.ToolTipText = "Reinitialize communication link";
            this.LogFileToolStripMenuItem1.Name = "LogFileToolStripMenuItem1";
            ToolStripMenuItem logFileToolStripMenuItem1 = this.LogFileToolStripMenuItem1;
            size = new System.Drawing.Size(170, 22);
            logFileToolStripMenuItem1.Size = size;
            this.LogFileToolStripMenuItem1.Text = "Log File";
            this.LogFileToolStripMenuItem1.ToolTipText = "Select log file";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            ToolStripSeparator toolStripSeparator4 = this.ToolStripSeparator4;
            size = new System.Drawing.Size(167, 6);
            toolStripSeparator4.Size = size;
            this.SlaveResponseToolStripMenuItem.Name = "SlaveResponseToolStripMenuItem";
            ToolStripMenuItem slaveResponseToolStripMenuItem = this.SlaveResponseToolStripMenuItem;
            size = new System.Drawing.Size(170, 22);
            slaveResponseToolStripMenuItem.Size = size;
            this.SlaveResponseToolStripMenuItem.Text = "Slave Response";
            this.SlaveResponseToolStripMenuItem.ToolTipText = "Setup slave reponse messages";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            ToolStripSeparator toolStripSeparator7 = this.ToolStripSeparator7;
            size = new System.Drawing.Size(167, 6);
            toolStripSeparator7.Size = size;
            this.ScriptFileToolStripMenuItem.Name = "ScriptFileToolStripMenuItem";
            ToolStripMenuItem scriptFileToolStripMenuItem = this.ScriptFileToolStripMenuItem;
            size = new System.Drawing.Size(170, 22);
            scriptFileToolStripMenuItem.Size = size;
            this.ScriptFileToolStripMenuItem.Text = "Script File";
            ToolStripItemCollection dropDownItems1 = this.ToolsToolStripMenuItem.DropDownItems;
            fileToolStripMenuItem = new ToolStripItem[] { this.OptionsToolStripMenuItem, this.ClearMonitorWindowToolStripMenuItem, this.FiltersToolStripMenuItem, this.ToolStripSeparator3, this.TransmitToolStripMenuItem, this.ListenToolStripMenuItem, this.SnoopToolStripMenuItem, this.DisplayErrors, this.DisplayNextScheduleToolStripMenuItem1, this.ToolStripSeparator6, this.LoadFirmwareToolStripMenuItem };
            dropDownItems1.AddRange(fileToolStripMenuItem);
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            ToolStripMenuItem toolsToolStripMenuItem = this.ToolsToolStripMenuItem;
            size = new System.Drawing.Size(50, 20);
            toolsToolStripMenuItem.Size = size;
            this.ToolsToolStripMenuItem.Text = "&Tools";
            ToolStripItemCollection toolStripItemCollections1 = this.OptionsToolStripMenuItem.DropDownItems;
            fileToolStripMenuItem = new ToolStripItem[] { this.DebugModeToolStripMenuItem, this.SupressBusTimeoutErrorToolStripMenuItem };
            toolStripItemCollections1.AddRange(fileToolStripMenuItem);
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            ToolStripMenuItem optionsToolStripMenuItem = this.OptionsToolStripMenuItem;
            size = new System.Drawing.Size(254, 22);
            optionsToolStripMenuItem.Size = size;
            this.OptionsToolStripMenuItem.Text = "&Options";
            this.DebugModeToolStripMenuItem.Name = "DebugModeToolStripMenuItem";
            ToolStripMenuItem debugModeToolStripMenuItem = this.DebugModeToolStripMenuItem;
            size = new System.Drawing.Size(246, 22);
            debugModeToolStripMenuItem.Size = size;
            this.DebugModeToolStripMenuItem.Text = "Debug Mode";
            this.SupressBusTimeoutErrorToolStripMenuItem.Name = "SupressBusTimeoutErrorToolStripMenuItem";
            ToolStripMenuItem supressBusTimeoutErrorToolStripMenuItem = this.SupressBusTimeoutErrorToolStripMenuItem;
            size = new System.Drawing.Size(246, 22);
            supressBusTimeoutErrorToolStripMenuItem.Size = size;
            this.SupressBusTimeoutErrorToolStripMenuItem.Text = "Suppress \"Bus Timeout\" error";
            this.ClearMonitorWindowToolStripMenuItem.Name = "ClearMonitorWindowToolStripMenuItem";
            this.ClearMonitorWindowToolStripMenuItem.ShortcutKeys = Keys.RButton | Keys.MButton | Keys.XButton2 | Keys.Back | Keys.LineFeed | Keys.Clear | Keys.Space | Keys.Next | Keys.PageDown | Keys.Home | Keys.Up | Keys.Down | Keys.Print | Keys.Snapshot | Keys.PrintScreen | Keys.Delete | Keys.Control;
            ToolStripMenuItem clearMonitorWindowToolStripMenuItem = this.ClearMonitorWindowToolStripMenuItem;
            size = new System.Drawing.Size(254, 22);
            clearMonitorWindowToolStripMenuItem.Size = size;
            this.ClearMonitorWindowToolStripMenuItem.Text = "Clear Monitor Window";
            this.FiltersToolStripMenuItem.Name = "FiltersToolStripMenuItem";
            ToolStripMenuItem filtersToolStripMenuItem = this.FiltersToolStripMenuItem;
            size = new System.Drawing.Size(254, 22);
            filtersToolStripMenuItem.Size = size;
            this.FiltersToolStripMenuItem.Text = "&Filters";
            this.FiltersToolStripMenuItem.ToolTipText = "Display messages sorted by Identifier";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator toolStripSeparator3 = this.ToolStripSeparator3;
            size = new System.Drawing.Size(251, 6);
            toolStripSeparator3.Size = size;
            this.TransmitToolStripMenuItem.Name = "TransmitToolStripMenuItem";
            ToolStripMenuItem transmitToolStripMenuItem = this.TransmitToolStripMenuItem;
            size = new System.Drawing.Size(254, 22);
            transmitToolStripMenuItem.Size = size;
            this.TransmitToolStripMenuItem.Text = "Transmit";
            this.TransmitToolStripMenuItem.ToolTipText = "Transmit Only, No Reception";
            this.ListenToolStripMenuItem.Name = "ListenToolStripMenuItem";
            ToolStripMenuItem listenToolStripMenuItem = this.ListenToolStripMenuItem;
            size = new System.Drawing.Size(254, 22);
            listenToolStripMenuItem.Size = size;
            this.ListenToolStripMenuItem.Text = "Listen (Filter)";
            this.ListenToolStripMenuItem.ToolTipText = "Display Transmitted and Received Frames, Suppress Duplicates";
            this.SnoopToolStripMenuItem.Checked = true;
            this.SnoopToolStripMenuItem.CheckState = CheckState.Checked;
            this.SnoopToolStripMenuItem.Name = "SnoopToolStripMenuItem";
            ToolStripMenuItem snoopToolStripMenuItem = this.SnoopToolStripMenuItem;
            size = new System.Drawing.Size(254, 22);
            snoopToolStripMenuItem.Size = size;
            this.SnoopToolStripMenuItem.Text = "Display All (Snoop)";
            this.SnoopToolStripMenuItem.ToolTipText = "Display All Frames on the Bus";
            this.DisplayErrors.Name = "DisplayErrors";
            ToolStripMenuItem displayErrors = this.DisplayErrors;
            size = new System.Drawing.Size(254, 22);
            displayErrors.Size = size;
            this.DisplayErrors.Text = "Display Errors Only";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            ToolStripSeparator toolStripSeparator6 = this.ToolStripSeparator6;
            size = new System.Drawing.Size(251, 6);
            toolStripSeparator6.Size = size;
            this.LoadFirmwareToolStripMenuItem.Name = "LoadFirmwareToolStripMenuItem";
            ToolStripMenuItem loadFirmwareToolStripMenuItem = this.LoadFirmwareToolStripMenuItem;
            size = new System.Drawing.Size(254, 22);
            loadFirmwareToolStripMenuItem.Size = size;
            this.LoadFirmwareToolStripMenuItem.Text = "Update Firmware";
            this.LoadFirmwareToolStripMenuItem.ToolTipText = "Download firmware to Analyzer";
            ToolStripItemCollection dropDownItems2 = this.HelpToolStripMenuItem.DropDownItems;
            fileToolStripMenuItem = new ToolStripItem[] { this.ContentsToolStripMenuItem, this.IndexToolStripMenuItem, this.SearchToolStripMenuItem, this.toolStripSeparator5, this.AboutToolStripMenuItem };
            dropDownItems2.AddRange(fileToolStripMenuItem);
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            ToolStripMenuItem helpToolStripMenuItem = this.HelpToolStripMenuItem;
            size = new System.Drawing.Size(45, 20);
            helpToolStripMenuItem.Size = size;
            this.HelpToolStripMenuItem.Text = "&Help";
            this.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem";
            ToolStripMenuItem contentsToolStripMenuItem = this.ContentsToolStripMenuItem;
            size = new System.Drawing.Size(128, 22);
            contentsToolStripMenuItem.Size = size;
            this.ContentsToolStripMenuItem.Text = "&Contents";
            this.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem";
            ToolStripMenuItem indexToolStripMenuItem = this.IndexToolStripMenuItem;
            size = new System.Drawing.Size(128, 22);
            indexToolStripMenuItem.Size = size;
            this.IndexToolStripMenuItem.Text = "&Index";
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            ToolStripMenuItem searchToolStripMenuItem = this.SearchToolStripMenuItem;
            size = new System.Drawing.Size(128, 22);
            searchToolStripMenuItem.Size = size;
            this.SearchToolStripMenuItem.Text = "&Search";
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            ToolStripSeparator toolStripSeparator5 = this.toolStripSeparator5;
            size = new System.Drawing.Size(125, 6);
            toolStripSeparator5.Size = size;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            ToolStripMenuItem aboutToolStripMenuItem = this.AboutToolStripMenuItem;
            size = new System.Drawing.Size(128, 22);
            aboutToolStripMenuItem.Size = size;
            this.AboutToolStripMenuItem.Text = "&About...";
            this.LogfileToolStripMenuItem.Name = "LogfileToolStripMenuItem";
            ToolStripMenuItem logfileToolStripMenuItem = this.LogfileToolStripMenuItem;
            size = new System.Drawing.Size(152, 22);
            logfileToolStripMenuItem.Size = size;
            this.LogfileToolStripMenuItem.Text = "LOG File";
            ToolStripItemCollection items1 = this.StatusStrip1.Items;
            fileToolStripMenuItem = new ToolStripItem[] { this.ToolStripStatusLabel, this.ToolStripStatusBaud, this.ToolStripStatusCOMStatus, this.StatusError };
            items1.AddRange(fileToolStripMenuItem);
            StatusStrip statusStrip1 = this.StatusStrip1;
            point = new Point(0, 606);
            statusStrip1.Location = point;
            StatusStrip statusStrip = this.StatusStrip1;
            size = new System.Drawing.Size(0, 42);
            statusStrip.MinimumSize = size;
            this.StatusStrip1.Name = "StatusStrip1";
            StatusStrip statusStrip11 = this.StatusStrip1;
            size = new System.Drawing.Size(767, 42);
            statusStrip11.Size = size;
            this.StatusStrip1.TabIndex = 3;
            this.StatusStrip1.Text = "StatusStrip1";
            this.ToolTip1.SetToolTip(this.StatusStrip1, "Click to change COMport of Baudrate");
            this.ToolStripStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel = this.ToolStripStatusLabel;
            size = new System.Drawing.Size(151, 37);
            toolStripStatusLabel.Size = size;
            this.ToolStripStatusLabel.Text = "Current Serial Port Status";
            this.ToolStripStatusBaud.Name = "ToolStripStatusBaud";
            System.Windows.Forms.ToolStripStatusLabel toolStripStatusBaud = this.ToolStripStatusBaud;
            size = new System.Drawing.Size(41, 37);
            toolStripStatusBaud.Size = size;
            this.ToolStripStatusBaud.Text = "BAUD";
            this.ToolStripStatusBaud.ToolTipText = "Change Baudrate";
            this.ToolStripStatusCOMStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ToolStripStatusCOMStatus.Name = "ToolStripStatusCOMStatus";
            System.Windows.Forms.ToolStripStatusLabel toolStripStatusCOMStatus = this.ToolStripStatusCOMStatus;
            size = new System.Drawing.Size(118, 37);
            toolStripStatusCOMStatus.Size = size;
            this.ToolStripStatusCOMStatus.Text = "LIN Network Status";
            this.StatusError.Name = "StatusError";
            System.Windows.Forms.ToolStripStatusLabel statusError = this.StatusError;
            size = new System.Drawing.Size(0, 37);
            statusError.Size = size;
            this.Sendbtn.BackColor = SystemColors.Control;
            Button sendbtn = this.Sendbtn;
            point = new Point(248, 42);
            sendbtn.Location = point;
            this.Sendbtn.Name = "Sendbtn";
            Button button = this.Sendbtn;
            size = new System.Drawing.Size(72, 23);
            button.Size = size;
            this.Sendbtn.TabIndex = 5;
            this.Sendbtn.Text = "Send";
            this.ToolTip1.SetToolTip(this.Sendbtn, "Send selected frame");
            this.Sendbtn.UseVisualStyleBackColor = false;
            this.Label1.AutoSize = true;
            Label label1 = this.Label1;
            point = new Point(10, 64);
            label1.Location = point;
            this.Label1.Name = "Label1";
            Label label = this.Label1;
            size = new System.Drawing.Size(60, 13);
            label.Size = size;
            this.Label1.TabIndex = 7;
            this.Label1.Text = "TimeStamp";
            this.ToolTip1.SetToolTip(this.Label1, "Resolution = .001 seconds");
            this.Label2.AutoSize = true;
            Label label2 = this.Label2;
            point = new Point(109, 64);
            label2.Location = point;
            this.Label2.Name = "Label2";
            Label label21 = this.Label2;
            size = new System.Drawing.Size(18, 13);
            label21.Size = size;
            this.Label2.TabIndex = 8;
            this.Label2.Text = "ID";
            this.ToolTip1.SetToolTip(this.Label2, "Contains Parity Bits");
            this.Label3.AutoSize = true;
            Label label3 = this.Label3;
            point = new Point(152, 64);
            label3.Location = point;
            this.Label3.Name = "Label3";
            Label label31 = this.Label3;
            size = new System.Drawing.Size(30, 13);
            label31.Size = size;
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Data";
            this.Label4.AutoSize = true;
            Label label4 = this.Label4;
            point = new Point(419, 64);
            label4.Location = point;
            this.Label4.Name = "Label4";
            Label label41 = this.Label4;
            size = new System.Drawing.Size(57, 13);
            label41.Size = size;
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Checksum";
            this.Label5.AutoSize = true;
            Label label5 = this.Label5;
            point = new Point(482, 64);
            label5.Location = point;
            this.Label5.Name = "Label5";
            Label label51 = this.Label5;
            size = new System.Drawing.Size(71, 13);
            label51.Size = size;
            this.Label5.TabIndex = 11;
            this.Label5.Text = "ChkSumType";
            this.Label6.AutoSize = true;
            Label label6 = this.Label6;
            point = new Point(573, 64);
            label6.Location = point;
            this.Label6.Name = "Label6";
            Label label61 = this.Label6;
            size = new System.Drawing.Size(32, 13);
            label61.Size = size;
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Baud";
            this.ToolTip1.SetToolTip(this.Label6, "Actual Calculated Value");
            this.Label7.AutoSize = true;
            Label label7 = this.Label7;
            point = new Point(657, 64);
            label7.Location = point;
            this.Label7.Name = "Label7";
            Label label71 = this.Label7;
            size = new System.Drawing.Size(34, 13);
            label71.Size = size;
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Errors";
            this.MessageLstBox.Font = new System.Drawing.Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.MessageLstBox.FormattingEnabled = true;
            this.MessageLstBox.ItemHeight = 14;
            this.MessageLstBox.Items.AddRange(new object[] { "20 00 22 33 44", "3C 00 00 00 00 00 00 00 00", "15 01 80 FF FF FF 7F 0F 06", "12 01 80 FF FF FF 7F 0F 06" });
            ListBox messageLstBox = this.MessageLstBox;
            point = new Point(8, 40);
            messageLstBox.Location = point;
            this.MessageLstBox.Name = "MessageLstBox";
            this.MessageLstBox.ScrollAlwaysVisible = true;
            this.MessageLstBox.SelectionMode = SelectionMode.MultiExtended;
            ListBox listBox = this.MessageLstBox;
            size = new System.Drawing.Size(232, 102);
            listBox.Size = size;
            this.MessageLstBox.TabIndex = 14;
            this.ToolTip1.SetToolTip(this.MessageLstBox, "Click in blank area to add\r\nnew message frame");
            this.Label8.AutoSize = true;
            Label label8 = this.Label8;
            point = new Point(15, 15);
            label8.Location = point;
            this.Label8.Name = "Label8";
            Label label81 = this.Label8;
            size = new System.Drawing.Size(18, 13);
            label81.Size = size;
            this.Label8.TabIndex = 15;
            this.Label8.Text = "ID";
            this.Label9.AutoSize = true;
            Label label9 = this.Label9;
            point = new Point(89, 15);
            label9.Location = point;
            this.Label9.Name = "Label9";
            Label label91 = this.Label9;
            size = new System.Drawing.Size(30, 13);
            label91.Size = size;
            this.Label9.TabIndex = 16;
            this.Label9.Text = "Data";
            this.DeleteBtn.BackColor = SystemColors.Control;
            this.DeleteBtn.ForeColor = SystemColors.ControlText;
            Button deleteBtn = this.DeleteBtn;
            point = new Point(404, 119);
            deleteBtn.Location = point;
            this.DeleteBtn.Name = "DeleteBtn";
            Button deleteBtn1 = this.DeleteBtn;
            size = new System.Drawing.Size(72, 23);
            deleteBtn1.Size = size;
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "Delete";
            this.ToolTip1.SetToolTip(this.DeleteBtn, "Delete selected frame");
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
            PictureBox pictureBox1 = this.PictureBox1;
            point = new Point(139, 15);
            pictureBox1.Location = point;
            this.PictureBox1.Name = "PictureBox1";
            PictureBox pictureBox = this.PictureBox1;
            size = new System.Drawing.Size(96, 72);
            pictureBox.Size = size;
            this.PictureBox1.TabIndex = 18;
            this.PictureBox1.TabStop = false;
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label label10 = this.Label10;
            point = new Point(137, 76);
            label10.Location = point;
            this.Label10.Name = "Label10";
            Label label101 = this.Label10;
            size = new System.Drawing.Size(97, 9);
            label101.Size = size;
            this.Label10.TabIndex = 19;
            this.Label10.Text = "Local Interconnect Network";
            this.forcedRadioButton.AutoSize = true;
            this.forcedRadioButton.Enabled = false;
            RadioButton radioButton = this.forcedRadioButton;
            point = new Point(7, 56);
            radioButton.Location = point;
            this.forcedRadioButton.Name = "forcedRadioButton";
            RadioButton radioButton1 = this.forcedRadioButton;
            size = new System.Drawing.Size(55, 17);
            radioButton1.Size = size;
            this.forcedRadioButton.TabIndex = 23;
            this.forcedRadioButton.TabStop = true;
            this.forcedRadioButton.Text = "forced";
            this.ToolTip1.SetToolTip(this.forcedRadioButton, "Do Not Calculate CheckSum, Send last byte as checksum");
            this.forcedRadioButton.UseVisualStyleBackColor = true;
            this.ContSendbtn.BackColor = SystemColors.Control;
            Button contSendbtn = this.ContSendbtn;
            point = new Point(323, 42);
            contSendbtn.Location = point;
            this.ContSendbtn.Name = "ContSendbtn";
            Button contSendbtn1 = this.ContSendbtn;
            size = new System.Drawing.Size(75, 23);
            contSendbtn1.Size = size;
            this.ContSendbtn.TabIndex = 30;
            this.ContSendbtn.Text = "Continuous";
            this.ToolTip1.SetToolTip(this.ContSendbtn, "Send selected frame at interval shown below");
            this.ContSendbtn.UseVisualStyleBackColor = false;
            NumericUpDown numericUpDown1 = this.NumericUpDown1;
            point = new Point(326, 71);
            numericUpDown1.Location = point;
            NumericUpDown numericUpDown = this.NumericUpDown1;
            int[] numArray = new int[] { 10000, 0, 0, 0 };
            decimal num = new decimal(numArray);
            numericUpDown.Maximum = num;
            NumericUpDown numericUpDown11 = this.NumericUpDown1;
            numArray = new int[] { 10, 0, 0, 0 };
            num = new decimal(numArray);
            numericUpDown11.Minimum = num;
            this.NumericUpDown1.Name = "NumericUpDown1";
            NumericUpDown numericUpDown12 = this.NumericUpDown1;
            size = new System.Drawing.Size(72, 20);
            numericUpDown12.Size = size;
            this.NumericUpDown1.TabIndex = 26;
            this.ToolTip1.SetToolTip(this.NumericUpDown1, "Transmission interval in milliseconds");
            NumericUpDown numericUpDown2 = this.NumericUpDown1;
            numArray = new int[] { 200, 0, 0, 0 };
            num = new decimal(numArray);
            numericUpDown2.Value = num;
            this.AddBtn.BackColor = SystemColors.Control;
            this.AddBtn.ForeColor = SystemColors.ControlText;
            Button addBtn = this.AddBtn;
            point = new Point(248, 119);
            addBtn.Location = point;
            this.AddBtn.Name = "AddBtn";
            Button addBtn1 = this.AddBtn;
            size = new System.Drawing.Size(72, 23);
            addBtn1.Size = size;
            this.AddBtn.TabIndex = 31;
            this.AddBtn.Text = "Add";
            this.ToolTip1.SetToolTip(this.AddBtn, "Add a new frame");
            this.AddBtn.UseVisualStyleBackColor = false;
            this.EditBtn.BackColor = SystemColors.Control;
            this.EditBtn.ForeColor = SystemColors.ControlText;
            Button editBtn = this.EditBtn;
            point = new Point(326, 119);
            editBtn.Location = point;
            this.EditBtn.Name = "EditBtn";
            Button editBtn1 = this.EditBtn;
            size = new System.Drawing.Size(72, 23);
            editBtn1.Size = size;
            this.EditBtn.TabIndex = 32;
            this.EditBtn.Text = "Edit";
            this.ToolTip1.SetToolTip(this.EditBtn, "Edit message frame");
            this.EditBtn.UseVisualStyleBackColor = false;
            this.OpenFileDialog1.FileName = "*.ini";
            this.OpenFileDialog1.Filter = "\"Initialisation Files (*.ini)|*.ini|All Files (*.*)|*,*\"";
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label label12 = this.Label12;
            point = new Point(5, 98);
            label12.Location = point;
            this.Label12.Name = "Label12";
            Label label121 = this.Label12;
            size = new System.Drawing.Size(230, 20);
            label121.Size = size;
            this.Label12.TabIndex = 21;
            this.Label12.Text = "Automotive Products Group";
            Button logBtn = this.LogBtn;
            point = new Point(656, 32);
            logBtn.Location = point;
            this.LogBtn.Name = "LogBtn";
            Button logBtn1 = this.LogBtn;
            size = new System.Drawing.Size(99, 23);
            logBtn1.Size = size;
            this.LogBtn.TabIndex = 22;
            this.LogBtn.Text = "START Logging";
            this.LogBtn.UseVisualStyleBackColor = true;
            this.LOGfilelbl.AutoSize = true;
            Label lOGfilelbl = this.LOGfilelbl;
            point = new Point(56, 32);
            lOGfilelbl.Location = point;
            this.LOGfilelbl.Name = "LOGfilelbl";
            Label lOGfilelbl1 = this.LOGfilelbl;
            size = new System.Drawing.Size(89, 13);
            lOGfilelbl1.Size = size;
            this.LOGfilelbl.TabIndex = 23;
            this.LOGfilelbl.Text = "No LOG file open";
            this.PrintDialog1.UseEXDialog = true;
            PrintPreviewDialog printPreviewDialog1 = this.PrintPreviewDialog1;
            size = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMargin = size;
            PrintPreviewDialog printPreviewDialog = this.PrintPreviewDialog1;
            size = new System.Drawing.Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = size;
            PrintPreviewDialog printPreviewDialog11 = this.PrintPreviewDialog1;
            size = new System.Drawing.Size(400, 300);
            printPreviewDialog11.ClientSize = size;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("PrintPreviewDialog1.Icon");
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            this.PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
            PictureBox pictureBox2 = this.PictureBox2;
            point = new Point(6, 17);
            pictureBox2.Location = point;
            this.PictureBox2.Name = "PictureBox2";
            PictureBox pictureBox21 = this.PictureBox2;
            size = new System.Drawing.Size(120, 64);
            pictureBox21.Size = size;
            this.PictureBox2.TabIndex = 24;
            this.PictureBox2.TabStop = false;
            this.GroupBox1.BackColor = SystemColors.ControlLightLight;
            this.GroupBox1.Controls.Add(this.SCRIPTfilelbl);
            this.GroupBox1.Controls.Add(this.EditBtn);
            this.GroupBox1.Controls.Add(this.AddBtn);
            this.GroupBox1.Controls.Add(this.ContSendbtn);
            this.GroupBox1.Controls.Add(this.NumericUpDown1);
            this.GroupBox1.Controls.Add(this.MessageLstBox);
            this.GroupBox1.Controls.Add(this.DeleteBtn);
            this.GroupBox1.Controls.Add(this.Sendbtn);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            GroupBox groupBox1 = this.GroupBox1;
            point = new Point(8, 446);
            groupBox1.Location = point;
            this.GroupBox1.Name = "GroupBox1";
            GroupBox groupBox = this.GroupBox1;
            size = new System.Drawing.Size(503, 156);
            groupBox.Size = size;
            this.GroupBox1.TabIndex = 26;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Master Frames";
            this.SCRIPTfilelbl.AutoSize = true;
            Label sCRIPTfilelbl = this.SCRIPTfilelbl;
            point = new Point(179, 15);
            sCRIPTfilelbl.Location = point;
            this.SCRIPTfilelbl.Name = "SCRIPTfilelbl";
            Label sCRIPTfilelbl1 = this.SCRIPTfilelbl;
            size = new System.Drawing.Size(92, 13);
            sCRIPTfilelbl1.Size = size;
            this.SCRIPTfilelbl.TabIndex = 33;
            this.SCRIPTfilelbl.Text = "No script file open";
            this.GroupBox2.Controls.Add(this.forcedRadioButton);
            this.GroupBox2.Controls.Add(this.enhancedRadioButton);
            this.GroupBox2.Controls.Add(this.classicRadioButton);
            GroupBox groupBox2 = this.GroupBox2;
            point = new Point(404, 32);
            groupBox2.Location = point;
            this.GroupBox2.Name = "GroupBox2";
            GroupBox groupBox21 = this.GroupBox2;
            size = new System.Drawing.Size(89, 81);
            groupBox21.Size = size;
            this.GroupBox2.TabIndex = 24;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Checksum";
            this.enhancedRadioButton.AutoSize = true;
            RadioButton radioButton2 = this.enhancedRadioButton;
            point = new Point(7, 39);
            radioButton2.Location = point;
            this.enhancedRadioButton.Name = "enhancedRadioButton";
            RadioButton radioButton3 = this.enhancedRadioButton;
            size = new System.Drawing.Size(73, 17);
            radioButton3.Size = size;
            this.enhancedRadioButton.TabIndex = 22;
            this.enhancedRadioButton.TabStop = true;
            this.enhancedRadioButton.Text = "enhanced";
            this.enhancedRadioButton.UseVisualStyleBackColor = true;
            this.classicRadioButton.AutoSize = true;
            this.classicRadioButton.Checked = true;
            RadioButton radioButton4 = this.classicRadioButton;
            point = new Point(7, 21);
            radioButton4.Location = point;
            this.classicRadioButton.Name = "classicRadioButton";
            RadioButton radioButton5 = this.classicRadioButton;
            size = new System.Drawing.Size(57, 17);
            radioButton5.Size = size;
            this.classicRadioButton.TabIndex = 21;
            this.classicRadioButton.TabStop = true;
            this.classicRadioButton.Text = "classic";
            this.classicRadioButton.UseVisualStyleBackColor = true;
            this.GroupBox3.AutoSize = true;
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.PictureBox2);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Controls.Add(this.Label12);
            this.GroupBox3.Controls.Add(this.PictureBox1);
            GroupBox groupBox3 = this.GroupBox3;
            point = new Point(517, 471);
            groupBox3.Location = point;
            this.GroupBox3.Name = "GroupBox3";
            GroupBox groupBox31 = this.GroupBox3;
            size = new System.Drawing.Size(243, 134);
            groupBox31.Size = size;
            this.GroupBox3.TabIndex = 27;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "a product of...";
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            this.Label11.ForeColor = Color.Red;
            Label label11 = this.Label11;
            point = new Point(35, 84);
            label11.Location = point;
            this.Label11.Name = "Label11";
            Label label111 = this.Label11;
            size = new System.Drawing.Size(62, 13);
            label111.Size = size;
            this.Label11.TabIndex = 28;
            this.Label11.Text = "In Control";
            this.TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.TextBox1.BackColor = SystemColors.Window;
            this.TextBox1.CausesValidation = false;
            this.TextBox1.Cursor = Cursors.Default;
            this.TextBox1.DetectUrls = false;
            this.TextBox1.Font = new System.Drawing.Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            RichTextBox textBox1 = this.TextBox1;
            point = new Point(8, 80);
            textBox1.Location = point;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.TextBox1.ShortcutsEnabled = false;
            RichTextBox richTextBox = this.TextBox1;
            size = new System.Drawing.Size(752, 370);
            richTextBox.Size = size;
            this.TextBox1.TabIndex = 4;
            this.TextBox1.TabStop = false;
            this.TextBox1.Text = "";
            this.TextBox1.WordWrap = false;
            this.OpenFileDialog2.FileName = "OpenFileDialog2";
            this.DisplayNextScheduleToolStripMenuItem1.Name = "DisplayNextScheduleToolStripMenuItem1";
            ToolStripMenuItem displayNextScheduleToolStripMenuItem1 = this.DisplayNextScheduleToolStripMenuItem1;
            size = new System.Drawing.Size(254, 22);
            displayNextScheduleToolStripMenuItem1.Size = size;
            this.DisplayNextScheduleToolStripMenuItem1.Text = "Display Next Schedule";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            size = new System.Drawing.Size(767, 648);
            this.ClientSize = size;
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.LOGfilelbl);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox3);
            size = new System.Drawing.Size(775, 675);
            this.MaximumSize = size;
            size = new System.Drawing.Size(775, 27);
            this.MinimumSize = size;
            this.Name = "Network";
            this.Text = "LIN Serial Analyser V2.05";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((ISupportInitialize)this.PictureBox1).EndInit();
            ((ISupportInitialize)this.NumericUpDown1).EndInit();
            ((ISupportInitialize)this.PictureBox2).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            LIN.Reset_Timer();
        }

        private void ListenToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ListenToolStripMenuItem.Checked)
            {
                if (!LIN.SetModeListen())
                {
                    this.StatusError.Text = "Error setting Listen mode.";
                }
                else
                {
                    this.StatusError.Text = "Mode = Listen.";
                }
            }
        }

        private void ListenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ListenToolStripMenuItem.Checked = true;
            this.SnoopToolStripMenuItem.Checked = false;
            this.TransmitToolStripMenuItem.Checked = false;
            this.DisplayErrors.Checked = false;
        }

        private void LoadFirmwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int length = "                                                                                              ".Length;
            OpenFileDialog openFileDialog1 = this.OpenFileDialog1;
            openFileDialog1.FileName = string.Concat(Microsoft.VisualBasic.FileSystem.CurDir(), "\\*.hex");
            openFileDialog1.Filter = "Firmware Files (*.hex)|*.hex|All Files (*.*)|*,*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            if (Strings.Len(openFileDialog1.FileName) == 0)
            {
                return;
            }
            string fileName = openFileDialog1.FileName;
            Strings.Mid(this.OpenFileDialog1.FileName, 1, checked(Strings.InStr(1, this.OpenFileDialog1.FileName, this.OpenFileDialog1.Title, CompareMethod.Text) - 1));
            string title = openFileDialog1.Title;
            openFileDialog1 = null;
            this.firmwarehex = fileName;
            MyProject.Forms.FirmwareLoad.ShowDialog();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            if (this.LOGrecord != 0)
            {
                this.LOGrecord = 0;
                this.LogBtn.Text = "START Logging";
            }
            else if (Operators.CompareString(this.LOGpath, "", false) == 0)
            {
                Interaction.MsgBox("Go to SETUP to select LOG file", MsgBoxStyle.Information, "No LOG file open");
            }
            else
            {
                this.LOGrecord = -1;
                this.LogBtn.Text = "STOP Logging";
            }
        }

        private void LogFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.LogFileToolStripMenuItem1.Checked)
            {
                this.LOGfile.Close();
                this.LogFileToolStripMenuItem1.Checked = false;
                this.LOGfilelbl.Text = "No LOG file open";
            }
            else
            {
                SaveFileDialog saveFileDialog1 = this.SaveFileDialog1;
                saveFileDialog1.FileName = "*.log";
                saveFileDialog1.Filter = "LOG Files (*.log)|*.log|All Files (*.*)|*,*";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
                if (Strings.Len(saveFileDialog1.FileName) == 0)
                {
                    return;
                }
                string fileName = saveFileDialog1.FileName;
                Strings.Mid(this.SaveFileDialog1.FileName, 1, checked(Strings.InStr(1, this.SaveFileDialog1.FileName, this.SaveFileDialog1.Title, CompareMethod.Text) - 1));
                string title = saveFileDialog1.Title;
                saveFileDialog1 = null;
                this.LOGpath = fileName;
                if (Operators.CompareString(this.LOGpath, "*.log", false) == 0)
                {
                    this.LOGpath = "";
                    this.LOGfilelbl.Text = "No LOG file open";
                }
                else
                {
                    this.LOGfile = MyProject.Computer.FileSystem.OpenTextFileWriter(this.LOGpath, true);
                    this.LogFileToolStripMenuItem1.Checked = true;
                    this.LOGfilelbl.Text = this.LOGpath;
                }
            }
        }

        private void MessageLstBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.MessageLstBox.SelectedIndex == -1)
            {
                this.AddBtn_Click(RuntimeHelpers.GetObjectValue(sender), e);
            }
            else
            {
                this.EditBtn_Click(RuntimeHelpers.GetObjectValue(sender), e);
            }
        }

        private void Network_FormClosed(object sender, FormClosedEventArgs e)
        {
            Basic.Cleanup();
            this.UnregisterEvents();
        }

        private void Network_GotFocus(object sender, EventArgs e)
        {
            this.ToolStripStatusBaud.Text = this.MasterBaudRate.ToString();
            if (!LIN.Change_LIN_BAUD_Rate(this.MasterBaudRate))
            {
                this.ToolStripStatusBaud.Text = "FAIL";
            }
        }

        private void Network_Load(object sender, EventArgs e)
        {
            if (Basic.Initialize_MyDevice(0, this.PID))
            {
                if (!LIN.Configure_PICkitSerial_For_LIN())
                {
                    this.StatusError.Text = "Error configuring APG Analyser for LIN";
                    this.SelectedCOMport = -1;
                }
                else
                {
                    Device.Set_Buffer_Flush_Parameters(true, true, 10, 10);
                    this.StatusError.Text = "APG LIN Analyser correctly configured for LIN";
                    this.SelectedCOMport = 0;
                }
            }
            else if (!Basic.Initialize_MyDevice(0, this.PKSAPID))
            {
                this.StatusError.Text = "Error initializing tool";
            }
            else if (!LIN.Configure_PICkitSerial_For_LIN())
            {
                this.StatusError.Text = "Error configuring PICkit Serial for LIN";
                this.SelectedCOMport = -1;
            }
            else
            {
                Device.Set_Buffer_Flush_Parameters(true, true, 10, 10);
                this.StatusError.Text = "PICkit Serial correctly configured for LIN";
                this.SelectedCOMport = 0;
            }
            this.RegisterEvents(new LIN());
            this.INIpath = string.Concat(Microsoft.VisualBasic.FileSystem.CurDir(), "\\USB2LIN.ini");
            this.LOGpath = "";
            LIN.SetModeDisplayAll();
        }

        private void Network_Resize(object sender, EventArgs e)
        {
            this.GroupBox1.Top = checked(this.TextBox1.Top + this.TextBox1.Height);
            this.GroupBox3.Top = checked(checked(this.TextBox1.Top + this.TextBox1.Height) + 15);
        }

        private void Network_Shown(object sender, EventArgs e)
        {
            this.ToolStripStatusBaud.Text = this.MasterBaudRate.ToString();
            if (!LIN.Change_LIN_BAUD_Rate(this.MasterBaudRate))
            {
                this.ToolStripStatusBaud.Text = "FAIL";
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Timer1.Interval = Convert.ToInt32(this.NumericUpDown1.Value);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int integer;
            string str = "                                                                                              ";
            int length = str.Length;
            OpenFileDialog openFileDialog1 = this.OpenFileDialog1;
            openFileDialog1.FileName = this.INIpath;
            openFileDialog1.Filter = "Initialisation Files (*.ini)|*.ini|All Files (*.*)|*,*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            if (Strings.Len(openFileDialog1.FileName) == 0)
            {
                return;
            }
            string fileName = openFileDialog1.FileName;
            Strings.Mid(this.OpenFileDialog1.FileName, 1, checked(Strings.InStr(1, this.OpenFileDialog1.FileName, this.OpenFileDialog1.Title, CompareMethod.Text) - 1));
            string title = openFileDialog1.Title;
            openFileDialog1 = null;
            this.INIpath = fileName;
            string str1 = "                                                                                              ";
            str1 = "";
            string str2 = "LINInterface";
            string str3 = "Speed";
            int privateProfileString = WindowsApplication1.Network.GetPrivateProfileString(ref str2, ref str3, ref str1, ref str, length, ref this.INIpath);
            this.MasterBaudRate = checked((ushort)Conversions.ToInteger(Strings.Left(str, privateProfileString)));
            this.ToolStripStatusBaud.Text = this.MasterBaudRate.ToString();
            if (!LIN.Change_LIN_BAUD_Rate(this.MasterBaudRate))
            {
                this.ToolStripStatusBaud.Text = "FAIL";
            }
            str = "                                                                                              ";
            str1 = "";
            str2 = "LINInterface";
            str3 = "Timeout";
            privateProfileString = WindowsApplication1.Network.GetPrivateProfileString(ref str2, ref str3, ref str1, ref str, length, ref this.INIpath);
            if (Operators.CompareString(Strings.Left(str, privateProfileString), "", false) != 0)
            {
                integer = Conversions.ToInteger(Strings.Left(str, privateProfileString));
                if (!LIN.Set_OnReceive_Timeout(integer))
                {
                    this.StatusError.Text = "Timeout failed to load";
                }
            }
            str2 = "LINMstrCommands";
            this.MessageLstBox.Items.Clear();
            integer = 0;
            do
            {
                str1 = "";
                str3 = string.Concat("Message", integer.ToString());
                privateProfileString = WindowsApplication1.Network.GetPrivateProfileString(ref str2, ref str3, ref str1, ref str, length, ref this.INIpath);
                if (privateProfileString != 0)
                {
                    this.MessageLstBox.Items.Add(Strings.Left(str, privateProfileString));
                }
                integer = checked(integer + 1);
            }
            while (privateProfileString != 0);
            str2 = "LINSlaveCommands";
            MyProject.Forms.Slave.MessageLstBox.Items.Clear();
            integer = 0;
            do
            {
                str1 = "";
                str3 = string.Concat("Message", integer.ToString());
                privateProfileString = WindowsApplication1.Network.GetPrivateProfileString(ref str2, ref str3, ref str1, ref str, length, ref this.INIpath);
                if (privateProfileString != 0)
                {
                    MyProject.Forms.Slave.MessageLstBox.Items.Add(Strings.Left(str, privateProfileString));
                }
                integer = checked(integer + 1);
            }
            while (privateProfileString != 0);
            str1 = "";
            str2 = "LogFile";
            str3 = "FilePath";
            privateProfileString = WindowsApplication1.Network.GetPrivateProfileString(ref str2, ref str3, ref str1, ref str, length, ref this.INIpath);
            this.LOGpath = Strings.Left(str, privateProfileString);
            str1 = "";
            str = "                                                                                              ";
            str2 = "Transaction Mode";
            str3 = "Mode";
            privateProfileString = WindowsApplication1.Network.GetPrivateProfileString(ref str2, ref str3, ref str1, ref str, length, ref this.INIpath);
            if (Operators.CompareString(Strings.Left(str, 5), "Transmit", false) == 0)
            {
                this.TransmitToolStripMenuItem.Checked = true;
                this.ListenToolStripMenuItem.Checked = false;
                this.SnoopToolStripMenuItem.Checked = false;
            }
            if (Operators.CompareString(Strings.Left(str, 5), "Listen", false) == 0)
            {
                this.TransmitToolStripMenuItem.Checked = false;
                this.ListenToolStripMenuItem.Checked = true;
                this.SnoopToolStripMenuItem.Checked = false;
            }
            if (Operators.CompareString(Strings.Left(str, privateProfileString), "DisplayAll", false) == 0)
            {
                this.TransmitToolStripMenuItem.Checked = false;
                this.ListenToolStripMenuItem.Checked = false;
                this.SnoopToolStripMenuItem.Checked = true;
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int num;
            int num1;
            Font font = new Font(this.TextBox1.Font.Name, 8f);
            PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
            int height = checked(defaultPageSettings.PaperSize.Height - defaultPageSettings.Margins.Top - defaultPageSettings.Margins.Bottom);
            int width = checked(defaultPageSettings.PaperSize.Width - defaultPageSettings.Margins.Left - defaultPageSettings.Margins.Right);
            int left = defaultPageSettings.Margins.Left;
            int top = defaultPageSettings.Margins.Top;

            if (this.PrintDocument1.DefaultPageSettings.Landscape)
            {
                int num2 = height;
                height = width;
                width = num2;
            }

            int num3 = checked((int)Math.Round((double)height / (double)font.Height));
            RectangleF rectangleF = new RectangleF(left, top, width, height);
            StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
            Graphics graphics = e.Graphics;
            string str = this.TextBox1.Text.Substring(intCurrentChar);
            SizeF sizeF = new SizeF(width, height);
            graphics.MeasureString(str, font, sizeF, stringFormat, out num, out num1);
            e.Graphics.DrawString(str, font, Brushes.Black, rectangleF, stringFormat);
            intCurrentChar += num;

            if (intCurrentChar >= this.TextBox1.Text.Length)
            {
                e.HasMorePages = false;
                intCurrentChar = 0;
            }
            else
            {
                e.HasMorePages = true;
            }
        }
        private static int intCurrentChar;


        private void PrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.PrintPreviewDialog1.Document = this.PrintDocument1;
                this.PrintPreviewDialog1.ShowDialog();
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Interaction.MsgBox("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.", MsgBoxStyle.OkOnly, this.Text);
                ProjectData.ClearProjectError();
            }
        }

        private void PrintSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog1 = this.PageSetupDialog1;
            pageSetupDialog1.Document = this.PrintDocument1;
            pageSetupDialog1.PageSettings = this.PrintDocument1.DefaultPageSettings;
            pageSetupDialog1 = null;
            if (this.PageSetupDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PrintDocument1.DefaultPageSettings = this.PageSetupDialog1.PageSettings;
            }
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PrintDialog1.Document = this.PrintDocument1;
            if (this.PrintDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PrintDocument1.Print();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ReconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Basic.Initialize_MyDevice(0, this.PID))
            {
                if (!LIN.Configure_PICkitSerial_For_LIN())
                {
                    this.StatusError.Text = "Error configuring APG Analyser for LIN";
                    this.SelectedCOMport = -1;
                }
                else
                {
                    Device.Set_Buffer_Flush_Parameters(true, true, 10, 10);
                    this.StatusError.Text = "APG LIN Analyser correctly configured for LIN";
                    this.SelectedCOMport = 0;
                }
            }
            else if (!Basic.Initialize_MyDevice(0, this.PKSAPID))
            {
                this.StatusError.Text = "Error initializing tool";
            }
            else if (!LIN.Configure_PICkitSerial_For_LIN())
            {
                this.StatusError.Text = "Error configuring PICkit Serial for LIN";
                this.SelectedCOMport = -1;
            }
            else
            {
                Device.Set_Buffer_Flush_Parameters(true, true, 10, 10);
                this.StatusError.Text = "PICkit Serial correctly configured for LIN";
                this.SelectedCOMport = 0;
            }
            LIN.SetModeDisplayAll();
        }

        public void RegisterEvents(LIN s)
        {
            this.OnAnswerSource = s;
            this.OnReceiveSource = s;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = this.SaveFileDialog1;
            saveFileDialog1.FileName = this.INIpath;
            saveFileDialog1.Filter = "Initialisation Files (*.ini)|*.ini|All Files (*.*)|*,*";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            if (Strings.Len(saveFileDialog1.FileName) == 0)
            {
                return;
            }
            string fileName = saveFileDialog1.FileName;
            Strings.Mid(this.SaveFileDialog1.FileName, 1, checked(Strings.InStr(1, this.SaveFileDialog1.FileName, this.SaveFileDialog1.Title, CompareMethod.Text) - 1));
            string title = saveFileDialog1.Title;
            saveFileDialog1 = null;
            this.INIpath = fileName;
            this.SaveToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "";
            string section, key, value;
            bool result;

            section = "COMMInterface";
            key = "USBport";
            value = SelectedCOMport.ToString();
            result = WritePrivateProfileString(ref section, ref key, ref value, ref INIpath);
            if (!result)
            {
                MessageBox.Show("Error", "Save .config error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            section = "LINInterface";
            key = "Speed";
            value = MasterBaudRate.ToString();
            result = WritePrivateProfileString(ref section, ref key, ref value, ref INIpath);
            if (!result)
            {
                MessageBox.Show("Error", "Save .config error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            key = "Timeout";
            value = LIN.Get_OnReceive_Timeout().ToString();
            result = WritePrivateProfileString(ref section, ref key, ref value, ref INIpath);
            if (!result)
            {
                MessageBox.Show("Error", "Save .config error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            section = "LINMstrCommands";
            for (int i = 0; i < MessageLstBox.Items.Count; i++)
            {
                key = "Message" + i.ToString();
                value = MessageLstBox.Items[i].ToString();
                result = WritePrivateProfileString(ref section, ref key, ref value, ref INIpath);
                if (!result)
                {
                    MessageBox.Show("Error", "Save .config error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            section = "LINSlaveCommands";
            for (int i = 0; i < MyProject.Forms.Slave.MessageLstBox.Items.Count; i++)
            {
                key = "Message" + i.ToString();
                value = MyProject.Forms.Slave.MessageLstBox.Items[i].ToString();
                result = WritePrivateProfileString(ref section, ref key, ref value, ref INIpath);
                if (!result)
                {
                    MessageBox.Show("Error", "Save .config error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            section = "LogFile";
            key = "FilePath";
            value = LOGpath;
            result = WritePrivateProfileString(ref section, ref key, ref value, ref INIpath);
            if (!result)
            {
                MessageBox.Show("Error", "Save .config error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (LIN.Transmit_mode_Is_Set())
            {
                str = "Transmit";
            }
            else if (LIN.Listen_mode_Is_Set())
            {
                str = "Listen";
            }
            else if (LIN.DisplayAll_mode_Is_Set())
            {
                str = "DisplayAll";
            }

            section = "Transaction Mode";
            key = "Mode";
            result = WritePrivateProfileString(ref section, ref key, ref value, ref INIpath);
            if (!result)
            {
                MessageBox.Show("Error", "Save .config error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScriptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ScriptFileToolStripMenuItem.Checked)
            {
                this.SCRIPTfile.Close();
                this.ScriptFileToolStripMenuItem.Checked = false;
                this.SCRIPTfilelbl.Text = "No script file open";
            }
            else
            {
                OpenFileDialog openFileDialog1 = this.OpenFileDialog1;
                openFileDialog1.FileName = "*.scr";
                openFileDialog1.Filter = "Script Files (*.scr)|*.scr|Log Files (*.log)|*.log|All Files (*.*)|*,*";
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
                if (Strings.Len(openFileDialog1.FileName) == 0)
                {
                    return;
                }
                string fileName = openFileDialog1.FileName;
                Strings.Mid(this.OpenFileDialog1.FileName, 1, checked(Strings.InStr(1, this.OpenFileDialog1.FileName, this.OpenFileDialog1.Title, CompareMethod.Text) - 1));
                string title = openFileDialog1.Title;
                openFileDialog1 = null;
                this.SCRIPTpath = fileName;
                if (Operators.CompareString(this.SCRIPTpath, "*.log", false) == 0)
                {
                    this.SCRIPTpath = "";
                    this.SCRIPTfilelbl.Text = "No script file open";
                }
                else
                {
                    using (TextFieldParser textFieldParser = new TextFieldParser(this.SCRIPTpath))
                    {
                        textFieldParser.TextFieldType = FieldType.FixedWidth;
                        int[] numArray = new int[] { 9, 5, 4, 4, 4, 4, 4, 4, 4, 4, 8, 12, 8, -1 };
                        textFieldParser.SetFieldWidths(numArray);
                        while (!textFieldParser.EndOfData)
                        {
                            try
                            {
                                string[] strArrays = textFieldParser.ReadFields();
                                for (int i = 0; i < checked((int)strArrays.Length); i = checked(i + 1))
                                {
                                    Interaction.MsgBox(strArrays[i], MsgBoxStyle.OkOnly, null);
                                }
                            }
                            catch (MalformedLineException malformedLineException1)
                            {
                                ProjectData.SetProjectError(malformedLineException1);
                                MalformedLineException malformedLineException = malformedLineException1;
                                Interaction.MsgBox(string.Concat("Line ", malformedLineException.Message, "is not valid and will be skipped."), MsgBoxStyle.OkOnly, null);
                                ProjectData.ClearProjectError();
                            }
                        }
                    }
                    this.ScriptFileToolStripMenuItem.Checked = true;
                    this.SCRIPTfilelbl.Text = this.SCRIPTpath;
                }
            }
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            byte[] numArray = new byte[11];
            if (!this.ScriptFileToolStripMenuItem.Checked && this.MessageLstBox.SelectedIndex != -1)
            {
                if (this.MessageLstBox.SelectedItems.Count <= 1)
                {
                    this.selectedmessagepointer = 0;
                    this.Timer1_Tick(RuntimeHelpers.GetObjectValue(sender), e);
                }
                else if (decimal.Compare(this.NumericUpDown1.Value, new decimal((long)10)) > 0)
                {
                    this.selectedmessagepointer = 0;
                    this.Timer1.Interval = Convert.ToInt32(this.NumericUpDown1.Value);
                    this.Timer1.Enabled = true;
                    this.Timer1.Start();
                }
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private void SlaveResponseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.Slave.Show();
        }

        private void SnoopToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SnoopToolStripMenuItem.Checked)
            {
                if (!LIN.SetModeDisplayAll())
                {
                    this.StatusError.Text = "Error setting Display All mode.";
                }
                else
                {
                    this.StatusError.Text = "Mode = Display All.";
                }
            }
        }

        private void SnoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SnoopToolStripMenuItem.Checked = true;
            this.ListenToolStripMenuItem.Checked = false;
            this.TransmitToolStripMenuItem.Checked = false;
            this.DisplayErrors.Checked = false;
            this.DisplayNextScheduleToolStripMenuItem1.Checked = false;
        }

        private void SupressBusTimeoutErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.SupressBusTimeoutErrorToolStripMenuItem.Checked)
            {
                this.SupressBusTimeoutErrorToolStripMenuItem.Checked = true;
            }
            else
            {
                this.SupressBusTimeoutErrorToolStripMenuItem.Checked = false;
            }
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            this.m_need_to_scroll_to_bottom_next_time = true;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.m_need_to_scroll_to_bottom_next_time = true;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            this.m_need_to_scroll_to_bottom_next_time = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            byte masterId = 0;
            this.Timer1.Stop();
            string str = "";
            byte[] numArray = new byte[11];
            string str1 = "";
            byte dataByteLen = 1;
            byte[] numArray1 = new byte[0];
            ListBox.SelectedObjectCollection selectedItems = this.MessageLstBox.SelectedItems;
            if (this.MessageLstBox.SelectedIndex != -1)
            {
                int num2 = 0;
                int num3 = 0;
                str = Strings.Trim(Conversions.ToString(selectedItems[this.selectedmessagepointer]));
                this.selectedmessagepointer = checked(this.selectedmessagepointer + 1);
                if (!this.SendOnce && this.selectedmessagepointer == selectedItems.Count)
                {
                    this.selectedmessagepointer = 0;
                }
                char[] charArray = str.ToCharArray();
                int length = checked(checked((int)charArray.Length) - 1);
                int num4 = 0;
                while (num4 <= length)
                {
                    if (Operators.CompareString(Conversions.ToString(charArray[num4]), ";", false) != 0)
                    {
                        str = "&H";
                        while (Uri.IsHexDigit(charArray[num4]))
                        {
                            if (charArray[num4] != '\0')
                            {
                                str = string.Concat(str, Conversions.ToString(charArray[num4]));
                                if (num4 == checked(checked((int)charArray.Length) - 1))
                                {
                                    break;
                                }
                                num4 = checked(num4 + 1);
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (num2 < 10)
                        {
                            if (num2 == 0)
                            {
                                masterId = checked((byte)Math.Round(Conversion.Val(str)));
                            }
                            else
                            {
                                numArray[checked(num2 - 1)] = checked((byte)Math.Round(Conversion.Val(str)));
                                num3 = checked(num3 + numArray[checked(num2 - 1)]);
                                if (num3 >= 256)
                                {
                                    num3 = checked(num3 - 255);
                                }
                            }
                            num2 = checked(num2 + 1);
                        }
                        if (charArray[num4] != '\0')
                        {
                            num4 = checked(num4 + 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (masterId != 21)
                {
                    masterId = this.GenParityBits(masterId);
                }
                else
                {
                    masterId = this.GenParityBits(masterId);
                }
                if (this.enhancedRadioButton.Checked)
                {
                    num3 = checked(num3 + masterId);
                    if (num3 >= 256)
                    {
                        num3 = checked(num3 - 255);
                    }
                }
                if (!this.forcedRadioButton.Checked)
                {
                    numArray[checked(num2 - 1)] = checked((byte)(checked(255 - num3)));
                }
                else
                {
                    numArray[checked(num2 - 1)] = checked((byte)num3);
                    num2 = checked(num2 - 1);
                }
                if (num2 == 1)
                {
                    num2 = 0;
                }
                dataByteLen = checked((byte)num2);
                this.StatusError.Text = "Sent Frame ";
                if (!LIN.Transmit(masterId, numArray, dataByteLen, ref str1))
                {
                    this.StatusError.Text = string.Concat("Error: ", str1);
                    if (Operators.CompareString(str1, "No data returned", false) == 0)
                    {
                        this.HandleOnReceive(masterId, numArray1, dataByteLen, 6, this.MasterBaudRate, 0);
                    }
                    Basic.Reset_Control_Block();
                }
                else
                {
                    this.StatusError.Text = "Transmission successful";
                }
            }
            if (!this.SendOnce)
            {
                this.Timer1.Start();
            }
            else if (this.selectedmessagepointer < selectedItems.Count)
            {
                this.Timer1.Start();
            }
        }

        private void ToolStripStatusBaud_Click(object sender, EventArgs e)
        {
            string str = "Enter Baud rate to be used for LIN Master";
            string str1 = "Select LIN Master Baud rate";
            string text = MyProject.Forms.COMsetup.BaudrateValue.Text;
            string str2 = Interaction.InputBox(str, str1, text, -1, -1);
            MyProject.Forms.COMsetup.BaudrateValue.Text = str2;
            if (Operators.CompareString(str2, "", false) == 0)
            {
                str2 = text;
            }
            else if (!LIN.Change_LIN_BAUD_Rate(checked((ushort)Math.Round(Conversion.Val(str2)))))
            {
                str2 = text;
            }
            this.ToolStripStatusBaud.Text = str2;
            this.MasterBaudRate = checked((ushort)Math.Round(Conversion.Val(str2)));
        }

        private void TransmitToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TransmitToolStripMenuItem.Checked)
            {
                if (!LIN.SetModeTransmit())
                {
                    this.StatusError.Text = "Error setting Transmit mode.";
                }
                else
                {
                    this.StatusError.Text = "Mode set to Transmit.";
                }
            }
        }

        private void TransmitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TransmitToolStripMenuItem.Checked = true;
            this.ListenToolStripMenuItem.Checked = false;
            this.SnoopToolStripMenuItem.Checked = false;
            this.DisplayErrors.Checked = false;
            this.DisplayNextScheduleToolStripMenuItem1.Checked = false;
        }

        public void UnregisterEvents()
        {
            this.OnAnswerSource = null;
        }

        private void UpdateRTFstrng(string pText, Color pColor)
        {
            if (this.RTFstrng.InvokeRequired)
            {
                WindowsApplication1.Network network = this;
                WindowsApplication1.Network.Threaded_RTFUpdate threadedRTFUpdate = new WindowsApplication1.Network.Threaded_RTFUpdate(network.UpdateRTFstrng);
                object[] objArray = new object[] { pText, pColor };
                this.BeginInvoke(threadedRTFUpdate, objArray);
                return;
            }
            this.inter_textbox.Text = "";
            this.inter_textbox.DeselectAll();
            this.inter_textbox.SelectionColor = pColor;
            this.inter_textbox.SelectedText = pText;
            this.inter_textbox.SelectAll();
            this.RTFstrng.SelectedRtf = this.inter_textbox.SelectedRtf;
        }

        private void UpdateTextBox(string pText, Color pColor)
        {
            if (this.InvokeRequired)
            {
                WindowsApplication1.Network network = this;
                WindowsApplication1.Network.Threaded_Textbox_Update threadedTextboxUpdate = new WindowsApplication1.Network.Threaded_Textbox_Update(network.UpdateTextBox);
                object[] objArray = new object[] { pText, pColor };
                this.BeginInvoke(threadedTextboxUpdate, objArray);
                return;
            }
            this.temp_textbox.Rtf = pText;
            this.temp_textbox.DeselectAll();
            if (this.m_need_to_scroll_to_bottom_next_time)
            {
                this.m_need_to_scroll_to_bottom_next_time = false;
                RichTextBox textBox1 = this.TextBox1;
                textBox1.Text = string.Concat(textBox1.Text, "\r\n");
                this.TextBox1.SelectAll();
                this.TextBox1.SelectionStart = this.TextBox1.SelectionLength;
            }
            this.temp_textbox.SelectAll();
            this.temp_textbox.SelectionFont = this.TextBox1.Font;
            this.TextBox1.SelectedRtf = this.temp_textbox.SelectedRtf;
            WindowsApplication1.Network.SendMessage(this.TextBox1.Handle, 277, (IntPtr)7, (IntPtr)0);
            if (this.LOGrecord == -1)
            {
                this.LOGfile.WriteLine(this.temp_textbox.Text);
            }
            if (MyProject.Forms.Filters.Visible)
            {
                MyProject.Forms.Filters.UpdateFilterBox(pText, pColor);
            }
        }

        [DllImport("Kernel32", CharSet = CharSet.Ansi, EntryPoint = "WritePrivateProfileStringA", ExactSpelling = true, SetLastError = true)]
        public static extern bool WritePrivateProfileString(ref string lpApplicationName, ref string lpKeyName, ref string lpString, ref string lplFileName);

        public delegate void Threaded_OnAnswer(byte masterID, byte[] data, byte length, byte ErrorCode, ushort baudrate, double timestamp);

        public delegate void Threaded_OnReceive(byte masterID, byte[] data, byte length, byte ErrorCode, ushort baudrate, double timestamp);

        public delegate void Threaded_RTFUpdate(string pText, Color pColor);

        public delegate void Threaded_Textbox_Update(string pText, Color pColor);
    }
}
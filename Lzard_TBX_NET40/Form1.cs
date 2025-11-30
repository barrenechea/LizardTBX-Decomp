using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Lzard_TBX_NET40
{
	[DesignerGenerated]
	public class Form1 : Form
	{
		private IContainer icontainer_0;

		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;

		[AccessedThroughProperty("ToolStripSplitButton1")]
		private ToolStripSplitButton _ToolStripSplitButton1;

		[AccessedThroughProperty("COM1ToolStripMenuItem")]
		private ToolStripMenuItem _COM1ToolStripMenuItem;

		[AccessedThroughProperty("lblCOMSel")]
		private ToolStripStatusLabel toolStripStatusLabel_0;

		[AccessedThroughProperty("lblAction")]
		private ToolStripStatusLabel _lblAction;

		[AccessedThroughProperty("ProgressBar1")]
		private ToolStripProgressBar _ProgressBar1;

		[AccessedThroughProperty("SerialPort1")]
		private SerialPort serialPort_0;

		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog openFileDialog_0;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		[AccessedThroughProperty("Button12")]
		private Button _Button12;

		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog AboTuybkNo;

		[AccessedThroughProperty("Button17")]
		private Button _Button17;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("lblSerial")]
		private Label _lblSerial;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("lblName")]
		private Label _lblName;

		[AccessedThroughProperty("lblOSVer")]
		private Label nNdTiiiObY;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Button18")]
		private Button _Button18;

		[AccessedThroughProperty("lblFlashDevID")]
		private Label _lblFlashDevID;

		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		[AccessedThroughProperty("TabControl1")]
		private TabControl _TabControl1;

		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		[AccessedThroughProperty("TabPage3")]
		private TabPage _TabPage3;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("txbAV_SrcDVDSer")]
		private TextBox _txbAV_SrcDVDSer;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[AccessedThroughProperty("txbAV_SrcKey")]
		private TextBox _txbAV_SrcKey;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("ToolTip1")]
		private ToolTip toolTip_0;

		[AccessedThroughProperty("lblSrcSpoof")]
		private Label _lblSrcSpoof;

		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[AccessedThroughProperty("txbAV_DstDVDSer")]
		private TextBox _txbAV_DstDVDSer;

		[AccessedThroughProperty("txbAV_DstKey")]
		private TextBox _txbAV_DstKey;

		[AccessedThroughProperty("cmbAV_DstLogDrive")]
		private ComboBox _cmbAV_DstLogDrive;

		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[AccessedThroughProperty("lblDestSpoof")]
		private Label _lblDestSpoof;

		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[AccessedThroughProperty("TabControl2")]
		private TabControl _TabControl2;

		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		[AccessedThroughProperty("btnEV_LoadSrcFw")]
		private Button _btnEV_LoadSrcFw;

		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[AccessedThroughProperty("TabPage4")]
		private TabPage _TabPage4;

		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		[AccessedThroughProperty("btnEV_CFWSaveAs")]
		private Button _btnEV_CFWSaveAs;

		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		[AccessedThroughProperty("cmbEV_DstCFWTemplate")]
		private ComboBox _cmbEV_DstCFWTemplate;

		[AccessedThroughProperty("txbEV_SrcFile")]
		private TextBox _txbEV_SrcFile;

		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[AccessedThroughProperty("txbEV_SrcKey")]
		private TextBox _txbEV_SrcKey;

		[AccessedThroughProperty("txbEV_SrcFwInfo")]
		private TextBox _txbEV_SrcFwInfo;

		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		[AccessedThroughProperty("txbAV_SrcFile")]
		private TextBox _txbAV_SrcFile;

		[AccessedThroughProperty("btn_editDstKey")]
		private Button _btn_editDstKey;

		[AccessedThroughProperty("MNU_MAN_EDIT")]
		private ContextMenuStrip _MNU_MAN_EDIT;

		[AccessedThroughProperty("SMOAV_DSTEDIT_LOADF_FILE")]
		private ToolStripMenuItem _SMOAV_DSTEDIT_LOADF_FILE;

		[AccessedThroughProperty("SMOAV_DSTEDIT_LOADF_FW")]
		private ToolStripMenuItem _SMOAV_DSTEDIT_LOADF_FW;

		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[AccessedThroughProperty("txbAV_DstFile")]
		private TextBox _txbAV_DstFile;

		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		[AccessedThroughProperty("SMOAV_DSTEDIT_GOBACK")]
		private ToolStripMenuItem _SMOAV_DSTEDIT_GOBACK;

		[AccessedThroughProperty("txbAV_SrcLogDrive")]
		private TextBox _txbAV_SrcLogDrive;

		[AccessedThroughProperty("txbAV_SrcPhyDrive")]
		private TextBox _txbAV_SrcPhyDrive;

		[AccessedThroughProperty("txbAV_DstPhyDrive")]
		private TextBox _txbAV_DstPhyDrive;

		[AccessedThroughProperty("SMOAV_DSTEDIT_MAN_EDIT")]
		private ToolStripMenuItem _SMOAV_DSTEDIT_MAN_EDIT;

		[AccessedThroughProperty("btn_editDstSer")]
		private Button _btn_editDstSer;

		[AccessedThroughProperty("btn_editDstLogDrive")]
		private Button _btn_editDstLogDrive;

		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		[AccessedThroughProperty("Button4")]
		private Button CqEunbgPfj;

		[AccessedThroughProperty("Button8")]
		private Button _Button8;

		[AccessedThroughProperty("Label23")]
		private Label eehusjlwe0;

		[AccessedThroughProperty("TabPage6")]
		private TabPage _TabPage6;

		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		[AccessedThroughProperty("txbAddrSect")]
		private TextBox _txbAddrSect;

		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		[AccessedThroughProperty("Button13")]
		private Button _Button13;

		[AccessedThroughProperty("txbhitdst")]
		private TextBox _txbhitdst;

		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		[AccessedThroughProperty("txbhitsrc")]
		private TextBox layugkyTmw;

		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		[AccessedThroughProperty("lstSectors")]
		private ListBox _lstSectors;

		[AccessedThroughProperty("Button15")]
		private Button _Button15;

		[AccessedThroughProperty("Button16")]
		private Button _Button16;

		[AccessedThroughProperty("LoadHitCFW")]
		private Button button_0;

		[AccessedThroughProperty("txbFile2Flash")]
		private TextBox _txbFile2Flash;

		[AccessedThroughProperty("TxbLog")]
		private TextBox _TxbLog;

		[AccessedThroughProperty("RadioButton2")]
		private RadioButton _RadioButton2;

		[AccessedThroughProperty("RadioButton1")]
		private RadioButton _RadioButton1;

		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		[AccessedThroughProperty("BtnHitRead")]
		private Button _BtnHitRead;

		[AccessedThroughProperty("txbhitread")]
		private TextBox _txbhitread;

		[AccessedThroughProperty("lblSpeedMode")]
		private ToolStripStatusLabel _lblSpeedMode;

		[AccessedThroughProperty("Button20")]
		private Button _Button20;

		[AccessedThroughProperty("TabPage7")]
		private TabPage _TabPage7;

		[AccessedThroughProperty("TreeView1")]
		private TreeView _TreeView1;

		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog folderBrowserDialog_0;

		[AccessedThroughProperty("Button21")]
		private Button _Button21;

		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		[AccessedThroughProperty("mstxb_key")]
		private TextBox _mstxb_key;

		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		[AccessedThroughProperty("mslbl_jobname")]
		private Label _mslbl_jobname;

		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		[AccessedThroughProperty("mslbl_status")]
		private Label _mslbl_status;

		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		[AccessedThroughProperty("btn_mserase")]
		private Button _btn_mserase;

		[AccessedThroughProperty("btn_mssave")]
		private Button _btn_mssave;

		[AccessedThroughProperty("mslbl_logdrive")]
		private Label _mslbl_logdrive;

		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		[AccessedThroughProperty("TabPage8")]
		private TabPage OkHuqoVvNm;

		[AccessedThroughProperty("Button19")]
		private Button _Button19;

		[AccessedThroughProperty("Button6")]
		private Button doGuzyMynU;

		[AccessedThroughProperty("chkTurbo")]
		private CheckBox _chkTurbo;

		[AccessedThroughProperty("sett_tbxjobspath")]
		private TextBox _sett_tbxjobspath;

		[AccessedThroughProperty("Button22")]
		private Button _Button22;

		[AccessedThroughProperty("Button23")]
		private Button _Button23;

		[AccessedThroughProperty("GroupBox9")]
		private GroupBox _GroupBox9;

		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		[AccessedThroughProperty("Button24")]
		private Button _Button24;

		[AccessedThroughProperty("ImageList1")]
		private ImageList imageList_0;

		[AccessedThroughProperty("txbsync_ser")]
		private TextBox _txbsync_ser;

		[AccessedThroughProperty("TabControl3")]
		private TabControl _TabControl3;

		[AccessedThroughProperty("TabPage9")]
		private TabPage _TabPage9;

		[AccessedThroughProperty("TabPage10")]
		private TabPage tabPage_0;

		[AccessedThroughProperty("TabPage11")]
		private TabPage tabPage_1;

		[AccessedThroughProperty("txbsync_ide")]
		private TextBox _txbsync_ide;

		[AccessedThroughProperty("txbsync_inq")]
		private TextBox _txbsync_inq;

		[AccessedThroughProperty("chksync_freeafterbackup")]
		private CheckBox _chksync_freeafterbackup;

		[AccessedThroughProperty("Button25")]
		private Button _Button25;

		[AccessedThroughProperty("GroupBox10")]
		private GroupBox groupBox_0;

		[AccessedThroughProperty("LoggerList")]
		private ListBox _LoggerList;

		[AccessedThroughProperty("sett_rb_usbpowdef")]
		private RadioButton _sett_rb_usbpowdef;

		[AccessedThroughProperty("sett_rb_usbpowins")]
		private RadioButton _sett_rb_usbpowins;

		[AccessedThroughProperty("Button26")]
		private Button _Button26;

		[AccessedThroughProperty("Button27")]
		private Button _Button27;

		[AccessedThroughProperty("Button28")]
		private Button _Button28;

		[AccessedThroughProperty("Button29")]
		private Button _Button29;

		[AccessedThroughProperty("TabPage12")]
		private TabPage tabPage_2;

		[AccessedThroughProperty("Button34")]
		private Button _Button34;

		[AccessedThroughProperty("Button33")]
		private Button _Button33;

		[AccessedThroughProperty("Button32")]
		private Button _Button32;

		[AccessedThroughProperty("Button31")]
		private Button _Button31;

		[AccessedThroughProperty("TxbUARTLog")]
		private TextBox textBox_0;

		[AccessedThroughProperty("Timer1")]
		private System.Windows.Forms.Timer timer_0;

		[AccessedThroughProperty("TabControl4")]
		private TabControl _TabControl4;

		[AccessedThroughProperty("TabPage13")]
		private TabPage tabPage_3;

		[AccessedThroughProperty("TabPage14")]
		private TabPage tabPage_4;

		[AccessedThroughProperty("Button35")]
		private Button _Button35;

		[AccessedThroughProperty("Button36")]
		private Button _Button36;

		[AccessedThroughProperty("Button38")]
		private Button _Button38;

		[AccessedThroughProperty("Button37")]
		private Button _Button37;

		[AccessedThroughProperty("txbCompareLog")]
		private TextBox _txbCompareLog;

		[AccessedThroughProperty("Button39")]
		private Button _Button39;

		[AccessedThroughProperty("Button40")]
		private Button _Button40;

		[AccessedThroughProperty("Button42")]
		private Button XmyMeSoxkI;

		[AccessedThroughProperty("Button41")]
		private Button _Button41;

		[AccessedThroughProperty("GroupBox11")]
		private GroupBox groupBox_1;

		[AccessedThroughProperty("Button43")]
		private Button _Button43;

		[AccessedThroughProperty("Button44")]
		private Button _Button44;

		[AccessedThroughProperty("GroupBox12")]
		private GroupBox groupBox_2;

		[AccessedThroughProperty("txbTime")]
		private TextBox _txbTime;

		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		[AccessedThroughProperty("txbPeriod")]
		private TextBox _txbPeriod;

		[AccessedThroughProperty("Button45")]
		private Button _Button45;

		[AccessedThroughProperty("Button46")]
		private Button _Button46;

		[AccessedThroughProperty("TabPage15")]
		private TabPage tabPage_5;

		[AccessedThroughProperty("GroupBox13")]
		private GroupBox groupBox_3;

		[AccessedThroughProperty("Button48")]
		private Button _Button48;

		[AccessedThroughProperty("Button47")]
		private Button _Button47;

		[AccessedThroughProperty("GroupBox15")]
		private GroupBox groupBox_4;

		[AccessedThroughProperty("Button50")]
		private Button _Button50;

		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		[AccessedThroughProperty("cmbxkeydash")]
		private ComboBox _cmbxkeydash;

		[AccessedThroughProperty("GroupBox14")]
		private GroupBox groupBox_5;

		[AccessedThroughProperty("Button49")]
		private Button _Button49;

		[AccessedThroughProperty("chkxkey0225U")]
		private CheckBox _chkxkey0225U;

		[AccessedThroughProperty("chkxkeyMENUISO")]
		private CheckBox _chkxkeyMENUISO;

		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		[AccessedThroughProperty("cmbxkeylang")]
		private ComboBox _cmbxkeylang;

		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		[AccessedThroughProperty("Label39")]
		private Label _Label39;

		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		[AccessedThroughProperty("Label40")]
		private Label _Label40;

		[AccessedThroughProperty("Button51")]
		private Button VyrXikJyPG;

		[AccessedThroughProperty("Button52")]
		private Button _Button52;

		[AccessedThroughProperty("GroupBox16")]
		private GroupBox groupBox_6;

		[AccessedThroughProperty("Label41")]
		private Label _Label41;

		[AccessedThroughProperty("btn_msload")]
		private Button _btn_msload;

		[AccessedThroughProperty("picsync3")]
		private PictureBox _picsync3;

		[AccessedThroughProperty("picsync2")]
		private PictureBox _picsync2;

		[AccessedThroughProperty("picsync1")]
		private PictureBox _picsync1;

		[AccessedThroughProperty("Label44")]
		private Label _Label44;

		[AccessedThroughProperty("Label43")]
		private Label _Label43;

		[AccessedThroughProperty("Label42")]
		private Label _Label42;

		[AccessedThroughProperty("Label45")]
		private Label _Label45;

		[AccessedThroughProperty("txbxkeyUNIQUE")]
		private TextBox _txbxkeyUNIQUE;

		[AccessedThroughProperty("Label47")]
		private Label _Label47;

		[AccessedThroughProperty("txbxkeyPWD")]
		private TextBox textBox_1;

		[AccessedThroughProperty("Label46")]
		private Label _Label46;

		[AccessedThroughProperty("txbxkeySSID")]
		private TextBox textBox_2;

		[AccessedThroughProperty("Button53")]
		private Button _Button53;

		[AccessedThroughProperty("Button54")]
		private Button _Button54;

		[AccessedThroughProperty("TabPage16")]
		private TabPage tabPage_6;

		[AccessedThroughProperty("Label48")]
		private Label _Label48;

		[AccessedThroughProperty("Label49")]
		private Label _Label49;

		[AccessedThroughProperty("Button56")]
		private Button _Button56;

		[AccessedThroughProperty("txbLTU_key")]
		private TextBox _txbLTU_key;

		[AccessedThroughProperty("Label50")]
		private Label _Label50;

		[AccessedThroughProperty("Button55")]
		private Button _Button55;

		[AccessedThroughProperty("txbLTU_cr")]
		private TextBox _txbLTU_cr;

		[AccessedThroughProperty("Button57")]
		private Button _Button57;

		[AccessedThroughProperty("txbLTU_Unique")]
		private TextBox _txbLTU_Unique;

		[AccessedThroughProperty("Label51")]
		private Label _Label51;

		[AccessedThroughProperty("Button58")]
		private Button _Button58;

		[AccessedThroughProperty("Label53")]
		private Label _Label53;

		[AccessedThroughProperty("Label52")]
		private Label _Label52;

		[AccessedThroughProperty("Button59")]
		private Button _Button59;

		[AccessedThroughProperty("Button60")]
		private Button _Button60;

		[AccessedThroughProperty("Button61")]
		private Button _Button61;

		[AccessedThroughProperty("Button30")]
		private Button _Button30;

		[AccessedThroughProperty("Button62")]
		private Button _Button62;

		[AccessedThroughProperty("Button63")]
		private Button _Button63;

		[AccessedThroughProperty("Button64")]
		private Button _Button64;

		[AccessedThroughProperty("Button65")]
		private Button _Button65;

		[AccessedThroughProperty("Label54")]
		private Label _Label54;

		[AccessedThroughProperty("cmbLTUTemplate")]
		private ComboBox _cmbLTUTemplate;

		[AccessedThroughProperty("cmbLTUFileset")]
		private ComboBox _cmbLTUFileset;

		[AccessedThroughProperty("Button67")]
		private Button pofXfiTqii;

		[AccessedThroughProperty("Button66")]
		private Button _Button66;

		[AccessedThroughProperty("Button68")]
		private Button _Button68;

		[AccessedThroughProperty("TabControl5")]
		private TabControl _TabControl5;

		[AccessedThroughProperty("TabPage17")]
		private TabPage tabPage_7;

		[AccessedThroughProperty("TabPage18")]
		private TabPage tabPage_8;

		[AccessedThroughProperty("TxbLTU2_key")]
		private TextBox _TxbLTU2_key;

		[AccessedThroughProperty("Label55")]
		private Label _Label55;

		[AccessedThroughProperty("TxbLTU2_cr")]
		private TextBox _TxbLTU2_cr;

		[AccessedThroughProperty("Button69")]
		private Button _Button69;

		[AccessedThroughProperty("cmbLTU2Fileset")]
		private ComboBox _cmbLTU2Fileset;

		[AccessedThroughProperty("Label56")]
		private Label _Label56;

		[AccessedThroughProperty("Label57")]
		private Label _Label57;

		[AccessedThroughProperty("Button70")]
		private Button _Button70;

		[AccessedThroughProperty("Label58")]
		private Label GutaQuFvLg;

		[AccessedThroughProperty("Button71")]
		private Button _Button71;

		[AccessedThroughProperty("Label59")]
		private Label _Label59;

		[AccessedThroughProperty("Label60")]
		private Label nSoaZyWeLD;

		[AccessedThroughProperty("Label62")]
		private Label _Label62;

		[AccessedThroughProperty("cmbLTU2Template")]
		private ComboBox _cmbLTU2Template;

		[AccessedThroughProperty("Label61")]
		private Label _Label61;

		private string string_0;

		private bool bool_0;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private BitmapHeaders.BitmapFileHeader struct0_0;

		private BitmapHeaders.BitmapInfoHeader struct1_0;

		private bool bool_1;

		private string string_1;

		private long long_0;

		private bool bool_2;

		private ToolboxUtilities.Struct5[] struct5_0;

		private bool bool_3;

		private CfwTemplateParser.Struct3[] struct3_0;

		private CfwTemplateParser.Struct4[] struct4_0;

		private int int_4;

		private int int_5;

		private double double_0;

		private double double_1;

		private double double_2;

		private double double_3;

		private double double_4;

		private string string_2;

		private string string_3;

		private string string_4;

		private string string_5;

		private string string_6;

		private string string_7;

		private string string_8;

		private string string_9;

		private string string_10;

		private string string_11;

		private string string_12;

		private long long_1;

		private long pMkapSnyXg;

		private long long_2;

		private long long_3;

		private int kHmaKjHpik;

		private int int_6;

		private int TmcaFaJkxr;

		private byte[] byte_0;

		private byte[] byte_1;

		private byte[] byte_2;

		private byte[] byte_3;

		private int int_7;

		private byte[] byte_4;

		private int int_8;

		private byte[] byte_5;

		private long long_4;

		private byte[] byte_6;

		private long long_5;

		private int int_9;

		private string string_13;

		private string string_14;

		private string string_15;

		private string string_16;

		private string string_17;

		private string string_18;

		private string string_19;

		private string string_20;

		private long long_6;

		private long long_7;

		private long long_8;

		private long IKFQOTWSJJ;

		private int int_10;

		private int int_11;

		private int int_12;

		private byte[] byte_7;

		private byte[] byte_8;

		private byte[] byte_9;

		private byte[] byte_10;

		private int int_13;

		private byte[] byte_11;

		private int int_14;

		private byte[] byte_12;

		private long long_9;

		private byte[] byte_13;

		private long long_10;

		internal virtual StatusStrip StatusStrip1
		{
			get
			{
				return _StatusStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_StatusStrip1 = value;
			}
		}

		internal virtual ToolStripSplitButton ToolStripSplitButton1
		{
			get
			{
				return _ToolStripSplitButton1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(method_22);
				EventHandler value3 = new EventHandler(method_21);
				if (_ToolStripSplitButton1 != null)
				{
					_ToolStripSplitButton1.DropDownItemClicked -= value2;
					_ToolStripSplitButton1.ButtonClick -= value3;
				}
				_ToolStripSplitButton1 = value;
				if (_ToolStripSplitButton1 != null)
				{
					_ToolStripSplitButton1.DropDownItemClicked += value2;
					_ToolStripSplitButton1.ButtonClick += value3;
				}
			}
		}

		internal virtual ToolStripMenuItem COM1ToolStripMenuItem
		{
			get
			{
				return _COM1ToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(COM1ToolStripMenuItem_Click);
				if (_COM1ToolStripMenuItem != null)
				{
					_COM1ToolStripMenuItem.Click -= value2;
				}
				_COM1ToolStripMenuItem = value;
				if (_COM1ToolStripMenuItem != null)
				{
					_COM1ToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripStatusLabel ToolStripStatusLabel_0
		{
			get
			{
				return toolStripStatusLabel_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				toolStripStatusLabel_0 = value;
			}
		}

		internal virtual ToolStripStatusLabel lblAction
		{
			get
			{
				return _lblAction;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lblAction = value;
			}
		}

		internal virtual ToolStripProgressBar ProgressBar1
		{
			get
			{
				return _ProgressBar1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_ProgressBar1 = value;
			}
		}

		internal virtual SerialPort SerialPort1
		{
			get
			{
				return serialPort_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				serialPort_0 = value;
			}
		}

		internal virtual OpenFileDialog OpenFileDialog1
		{
			get
			{
				return openFileDialog_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				openFileDialog_0 = value;
			}
		}

		internal virtual Label Label1
		{
			get
			{
				return _Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label1 = value;
			}
		}

		internal virtual Button Button11
		{
			get
			{
				return _Button11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button11_Click);
				if (_Button11 != null)
				{
					_Button11.Click -= value2;
				}
				_Button11 = value;
				if (_Button11 != null)
				{
					_Button11.Click += value2;
				}
			}
		}

		internal virtual Button Button12
		{
			get
			{
				return _Button12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button12_Click);
				if (_Button12 != null)
				{
					_Button12.Click -= value2;
				}
				_Button12 = value;
				if (_Button12 != null)
				{
					_Button12.Click += value2;
				}
			}
		}

		internal virtual SaveFileDialog SaveFileDialog1
		{
			get
			{
				return AboTuybkNo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				AboTuybkNo = value;
			}
		}

		internal virtual Button Button17
		{
			get
			{
				return _Button17;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button17_Click);
				if (_Button17 != null)
				{
					_Button17.Click -= value2;
				}
				_Button17 = value;
				if (_Button17 != null)
				{
					_Button17.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox1
		{
			get
			{
				return _GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(GroupBox1_Enter);
				if (_GroupBox1 != null)
				{
					_GroupBox1.Enter -= value2;
				}
				_GroupBox1 = value;
				if (_GroupBox1 != null)
				{
					_GroupBox1.Enter += value2;
				}
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return _Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Label5_Click);
				if (_Label5 != null)
				{
					_Label5.Click -= value2;
				}
				_Label5 = value;
				if (_Label5 != null)
				{
					_Label5.Click += value2;
				}
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return _Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label4 = value;
			}
		}

		internal virtual Label lblSerial
		{
			get
			{
				return _lblSerial;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lblSerial = value;
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return _Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label2 = value;
			}
		}

		internal virtual Label lblName
		{
			get
			{
				return _lblName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lblName = value;
			}
		}

		internal virtual Label lblOSVer
		{
			get
			{
				return nNdTiiiObY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				nNdTiiiObY = value;
			}
		}

		internal virtual Label Label6
		{
			get
			{
				return _Label6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label6 = value;
			}
		}

		internal virtual Button Button18
		{
			get
			{
				return _Button18;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button18_Click);
				if (_Button18 != null)
				{
					_Button18.Click -= value2;
				}
				_Button18 = value;
				if (_Button18 != null)
				{
					_Button18.Click += value2;
				}
			}
		}

		internal virtual Label lblFlashDevID
		{
			get
			{
				return _lblFlashDevID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lblFlashDevID = value;
			}
		}

		internal virtual PictureBox PictureBox2
		{
			get
			{
				return _PictureBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(PictureBox2_Click);
				if (_PictureBox2 != null)
				{
					_PictureBox2.Click -= value2;
				}
				_PictureBox2 = value;
				if (_PictureBox2 != null)
				{
					_PictureBox2.Click += value2;
				}
			}
		}

		internal virtual TabControl TabControl1
		{
			get
			{
				return _TabControl1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TabControlCancelEventHandler value2 = new TabControlCancelEventHandler(method_53);
				TabControlCancelEventHandler value3 = new TabControlCancelEventHandler(method_52);
				if (_TabControl1 != null)
				{
					_TabControl1.Selecting -= value2;
					_TabControl1.Selecting -= value3;
				}
				_TabControl1 = value;
				if (_TabControl1 != null)
				{
					_TabControl1.Selecting += value2;
					_TabControl1.Selecting += value3;
				}
			}
		}

		internal virtual TabPage TabPage2
		{
			get
			{
				return _TabPage2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(TabPage2_Click);
				if (_TabPage2 != null)
				{
					_TabPage2.Click -= value2;
				}
				_TabPage2 = value;
				if (_TabPage2 != null)
				{
					_TabPage2.Click += value2;
				}
			}
		}

		internal virtual TabPage TabPage3
		{
			get
			{
				return _TabPage3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(TabPage3_Click);
				if (_TabPage3 != null)
				{
					_TabPage3.Click -= value2;
				}
				_TabPage3 = value;
				if (_TabPage3 != null)
				{
					_TabPage3.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox2
		{
			get
			{
				return _GroupBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_GroupBox2 = value;
			}
		}

		internal virtual Label Label7
		{
			get
			{
				return _Label7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label7 = value;
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return _Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label3 = value;
			}
		}

		internal virtual Button Button1
		{
			get
			{
				return _Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button1_Click);
				if (_Button1 != null)
				{
					_Button1.Click -= value2;
				}
				_Button1 = value;
				if (_Button1 != null)
				{
					_Button1.Click += value2;
				}
			}
		}

		internal virtual TextBox txbAV_SrcDVDSer
		{
			get
			{
				return _txbAV_SrcDVDSer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbAV_SrcDVDSer = value;
			}
		}

		internal virtual Label Label9
		{
			get
			{
				return _Label9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label9 = value;
			}
		}

		internal virtual TextBox txbAV_SrcKey
		{
			get
			{
				return _txbAV_SrcKey;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbAV_SrcKey = value;
			}
		}

		internal virtual Label Label8
		{
			get
			{
				return _Label8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label8 = value;
			}
		}

		internal virtual ToolTip ToolTip1
		{
			get
			{
				return toolTip_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				toolTip_0 = value;
			}
		}

		internal virtual Label lblSrcSpoof
		{
			get
			{
				return _lblSrcSpoof;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lblSrcSpoof = value;
			}
		}

		internal virtual GroupBox GroupBox3
		{
			get
			{
				return _GroupBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_GroupBox3 = value;
			}
		}

		internal virtual TextBox txbAV_DstDVDSer
		{
			get
			{
				return _txbAV_DstDVDSer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbAV_DstDVDSer = value;
			}
		}

		internal virtual TextBox txbAV_DstKey
		{
			get
			{
				return _txbAV_DstKey;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbAV_DstKey = value;
			}
		}

		internal virtual ComboBox cmbAV_DstLogDrive
		{
			get
			{
				return _cmbAV_DstLogDrive;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(cmbAV_DstLogDrive_SelectedIndexChanged);
				if (_cmbAV_DstLogDrive != null)
				{
					_cmbAV_DstLogDrive.SelectedIndexChanged -= value2;
				}
				_cmbAV_DstLogDrive = value;
				if (_cmbAV_DstLogDrive != null)
				{
					_cmbAV_DstLogDrive.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual Label Label10
		{
			get
			{
				return _Label10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label10 = value;
			}
		}

		internal virtual Label Label11
		{
			get
			{
				return _Label11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label11 = value;
			}
		}

		internal virtual Label Label12
		{
			get
			{
				return _Label12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label12 = value;
			}
		}

		internal virtual Label Label13
		{
			get
			{
				return _Label13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label13 = value;
			}
		}

		internal virtual Label lblDestSpoof
		{
			get
			{
				return _lblDestSpoof;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lblDestSpoof = value;
			}
		}

		internal virtual Button Button2
		{
			get
			{
				return _Button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(kAiRloIfj);
				if (_Button2 != null)
				{
					_Button2.Click -= value2;
				}
				_Button2 = value;
				if (_Button2 != null)
				{
					_Button2.Click += value2;
				}
			}
		}

		internal virtual Button Button3
		{
			get
			{
				return _Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button3_Click);
				if (_Button3 != null)
				{
					_Button3.Click -= value2;
				}
				_Button3 = value;
				if (_Button3 != null)
				{
					_Button3.Click += value2;
				}
			}
		}

		internal virtual TabControl TabControl2
		{
			get
			{
				return _TabControl2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabControl2 = value;
			}
		}

		internal virtual TabPage TabPage1
		{
			get
			{
				return _TabPage1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabPage1 = value;
			}
		}

		internal virtual GroupBox GroupBox4
		{
			get
			{
				return _GroupBox4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_GroupBox4 = value;
			}
		}

		internal virtual Button btnEV_LoadSrcFw
		{
			get
			{
				return _btnEV_LoadSrcFw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(btnEV_LoadSrcFw_Click);
				if (_btnEV_LoadSrcFw != null)
				{
					_btnEV_LoadSrcFw.Click -= value2;
				}
				_btnEV_LoadSrcFw = value;
				if (_btnEV_LoadSrcFw != null)
				{
					_btnEV_LoadSrcFw.Click += value2;
				}
			}
		}

		internal virtual Label Label17
		{
			get
			{
				return _Label17;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label17 = value;
			}
		}

		internal virtual Label Label19
		{
			get
			{
				return _Label19;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label19 = value;
			}
		}

		internal virtual TabPage TabPage4
		{
			get
			{
				return _TabPage4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabPage4 = value;
			}
		}

		internal virtual GroupBox GroupBox5
		{
			get
			{
				return _GroupBox5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_GroupBox5 = value;
			}
		}

		internal virtual Label Label20
		{
			get
			{
				return _Label20;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label20 = value;
			}
		}

		internal virtual Button btnEV_CFWSaveAs
		{
			get
			{
				return _btnEV_CFWSaveAs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(btnEV_CFWSaveAs_Click);
				if (_btnEV_CFWSaveAs != null)
				{
					_btnEV_CFWSaveAs.Click -= value2;
				}
				_btnEV_CFWSaveAs = value;
				if (_btnEV_CFWSaveAs != null)
				{
					_btnEV_CFWSaveAs.Click += value2;
				}
			}
		}

		internal virtual Label Label18
		{
			get
			{
				return _Label18;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label18 = value;
			}
		}

		internal virtual ComboBox cmbEV_DstCFWTemplate
		{
			get
			{
				return _cmbEV_DstCFWTemplate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(cmbEV_DstCFWTemplate_SelectedIndexChanged);
				if (_cmbEV_DstCFWTemplate != null)
				{
					_cmbEV_DstCFWTemplate.SelectedIndexChanged -= value2;
				}
				_cmbEV_DstCFWTemplate = value;
				if (_cmbEV_DstCFWTemplate != null)
				{
					_cmbEV_DstCFWTemplate.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual TextBox txbEV_SrcFile
		{
			get
			{
				return _txbEV_SrcFile;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbEV_SrcFile = value;
			}
		}

		internal virtual Label Label16
		{
			get
			{
				return _Label16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label16 = value;
			}
		}

		internal virtual TextBox txbEV_SrcKey
		{
			get
			{
				return _txbEV_SrcKey;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbEV_SrcKey = value;
			}
		}

		internal virtual TextBox txbEV_SrcFwInfo
		{
			get
			{
				return _txbEV_SrcFwInfo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbEV_SrcFwInfo = value;
			}
		}

		internal virtual Label Label15
		{
			get
			{
				return _Label15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(method_45);
				EventHandler value3 = new EventHandler(method_44);
				EventHandler value4 = new EventHandler(method_40);
				if (_Label15 != null)
				{
					_Label15.MouseLeave -= value2;
					_Label15.MouseEnter -= value3;
					_Label15.Click -= value4;
				}
				_Label15 = value;
				if (_Label15 != null)
				{
					_Label15.MouseLeave += value2;
					_Label15.MouseEnter += value3;
					_Label15.Click += value4;
				}
			}
		}

		internal virtual Label Label21
		{
			get
			{
				return _Label21;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label21 = value;
			}
		}

		internal virtual TextBox txbAV_SrcFile
		{
			get
			{
				return _txbAV_SrcFile;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbAV_SrcFile = value;
			}
		}

		internal virtual Button btn_editDstKey
		{
			get
			{
				return _btn_editDstKey;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(btn_editDstKey_Click);
				if (_btn_editDstKey != null)
				{
					_btn_editDstKey.Click -= value2;
				}
				_btn_editDstKey = value;
				if (_btn_editDstKey != null)
				{
					_btn_editDstKey.Click += value2;
				}
			}
		}

		internal virtual ContextMenuStrip MNU_MAN_EDIT
		{
			get
			{
				return _MNU_MAN_EDIT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(method_38);
				ToolStripItemClickedEventHandler value3 = new ToolStripItemClickedEventHandler(method_37);
				if (_MNU_MAN_EDIT != null)
				{
					_MNU_MAN_EDIT.Opening -= value2;
					_MNU_MAN_EDIT.ItemClicked -= value3;
				}
				_MNU_MAN_EDIT = value;
				if (_MNU_MAN_EDIT != null)
				{
					_MNU_MAN_EDIT.Opening += value2;
					_MNU_MAN_EDIT.ItemClicked += value3;
				}
			}
		}

		internal virtual ToolStripMenuItem SMOAV_DSTEDIT_LOADF_FILE
		{
			get
			{
				return _SMOAV_DSTEDIT_LOADF_FILE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(SMOAV_DSTEDIT_LOADF_FILE_Click);
				if (_SMOAV_DSTEDIT_LOADF_FILE != null)
				{
					_SMOAV_DSTEDIT_LOADF_FILE.Click -= value2;
				}
				_SMOAV_DSTEDIT_LOADF_FILE = value;
				if (_SMOAV_DSTEDIT_LOADF_FILE != null)
				{
					_SMOAV_DSTEDIT_LOADF_FILE.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem SMOAV_DSTEDIT_LOADF_FW
		{
			get
			{
				return _SMOAV_DSTEDIT_LOADF_FW;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(SMOAV_DSTEDIT_LOADF_FW_Click);
				if (_SMOAV_DSTEDIT_LOADF_FW != null)
				{
					_SMOAV_DSTEDIT_LOADF_FW.Click -= value2;
				}
				_SMOAV_DSTEDIT_LOADF_FW = value;
				if (_SMOAV_DSTEDIT_LOADF_FW != null)
				{
					_SMOAV_DSTEDIT_LOADF_FW.Click += value2;
				}
			}
		}

		internal virtual Button Button5
		{
			get
			{
				return _Button5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button5_Click);
				if (_Button5 != null)
				{
					_Button5.Click -= value2;
				}
				_Button5 = value;
				if (_Button5 != null)
				{
					_Button5.Click += value2;
				}
			}
		}

		internal virtual Label Label14
		{
			get
			{
				return _Label14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label14 = value;
			}
		}

		internal virtual TextBox txbAV_DstFile
		{
			get
			{
				return _txbAV_DstFile;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbAV_DstFile = value;
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get
			{
				return _ToolStripSeparator1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_ToolStripSeparator1 = value;
			}
		}

		internal virtual ToolStripMenuItem SMOAV_DSTEDIT_GOBACK
		{
			get
			{
				return _SMOAV_DSTEDIT_GOBACK;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_SMOAV_DSTEDIT_GOBACK = value;
			}
		}

		internal virtual TextBox txbAV_SrcLogDrive
		{
			get
			{
				return _txbAV_SrcLogDrive;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbAV_SrcLogDrive = value;
			}
		}

		internal virtual TextBox txbAV_SrcPhyDrive
		{
			get
			{
				return _txbAV_SrcPhyDrive;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbAV_SrcPhyDrive = value;
			}
		}

		internal virtual TextBox txbAV_DstPhyDrive
		{
			get
			{
				return _txbAV_DstPhyDrive;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbAV_DstPhyDrive = value;
			}
		}

		internal virtual ToolStripMenuItem SMOAV_DSTEDIT_MAN_EDIT
		{
			get
			{
				return _SMOAV_DSTEDIT_MAN_EDIT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_SMOAV_DSTEDIT_MAN_EDIT = value;
			}
		}

		internal virtual Button btn_editDstSer
		{
			get
			{
				return _btn_editDstSer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(btn_editDstSer_Click);
				if (_btn_editDstSer != null)
				{
					_btn_editDstSer.Click -= value2;
				}
				_btn_editDstSer = value;
				if (_btn_editDstSer != null)
				{
					_btn_editDstSer.Click += value2;
				}
			}
		}

		internal virtual Button btn_editDstLogDrive
		{
			get
			{
				return _btn_editDstLogDrive;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(btn_editDstLogDrive_Click);
				if (_btn_editDstLogDrive != null)
				{
					_btn_editDstLogDrive.Click -= value2;
				}
				_btn_editDstLogDrive = value;
				if (_btn_editDstLogDrive != null)
				{
					_btn_editDstLogDrive.Click += value2;
				}
			}
		}

		internal virtual Label Label22
		{
			get
			{
				return _Label22;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(method_43);
				EventHandler value3 = new EventHandler(method_42);
				EventHandler value4 = new EventHandler(method_41);
				EventHandler value5 = new EventHandler(method_39);
				if (_Label22 != null)
				{
					_Label22.MouseLeave -= value2;
					_Label22.MouseHover -= value3;
					_Label22.MouseEnter -= value4;
					_Label22.Click -= value5;
				}
				_Label22 = value;
				if (_Label22 != null)
				{
					_Label22.MouseLeave += value2;
					_Label22.MouseHover += value3;
					_Label22.MouseEnter += value4;
					_Label22.Click += value5;
				}
			}
		}

		internal virtual Button Button4
		{
			get
			{
				return CqEunbgPfj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button4_Click);
				if (CqEunbgPfj != null)
				{
					CqEunbgPfj.Click -= value2;
				}
				CqEunbgPfj = value;
				if (CqEunbgPfj != null)
				{
					CqEunbgPfj.Click += value2;
				}
			}
		}

		internal virtual Button Button8
		{
			get
			{
				return _Button8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button8_Click);
				if (_Button8 != null)
				{
					_Button8.Click -= value2;
				}
				_Button8 = value;
				if (_Button8 != null)
				{
					_Button8.Click += value2;
				}
			}
		}

		internal virtual Label Label23
		{
			get
			{
				return eehusjlwe0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				eehusjlwe0 = value;
			}
		}

		internal virtual TabPage TabPage6
		{
			get
			{
				return _TabPage6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabPage6 = value;
			}
		}

		internal virtual Label Label24
		{
			get
			{
				return _Label24;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Label24_Click);
				if (_Label24 != null)
				{
					_Label24.Click -= value2;
				}
				_Label24 = value;
				if (_Label24 != null)
				{
					_Label24.Click += value2;
				}
			}
		}

		internal virtual TextBox txbAddrSect
		{
			get
			{
				return _txbAddrSect;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbAddrSect = value;
			}
		}

		internal virtual Button Button7
		{
			get
			{
				return _Button7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button7_Click);
				if (_Button7 != null)
				{
					_Button7.Click -= value2;
				}
				_Button7 = value;
				if (_Button7 != null)
				{
					_Button7.Click += value2;
				}
			}
		}

		internal virtual Button Button13
		{
			get
			{
				return _Button13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button13_Click);
				if (_Button13 != null)
				{
					_Button13.Click -= value2;
				}
				_Button13 = value;
				if (_Button13 != null)
				{
					_Button13.Click += value2;
				}
			}
		}

		internal virtual TextBox txbhitdst
		{
			get
			{
				return _txbhitdst;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbhitdst = value;
			}
		}

		internal virtual Button Button10
		{
			get
			{
				return _Button10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button10_Click);
				if (_Button10 != null)
				{
					_Button10.Click -= value2;
				}
				_Button10 = value;
				if (_Button10 != null)
				{
					_Button10.Click += value2;
				}
			}
		}

		internal virtual TextBox txbhitsrc
		{
			get
			{
				return layugkyTmw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				layugkyTmw = value;
			}
		}

		internal virtual Button Button9
		{
			get
			{
				return _Button9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button9_Click);
				if (_Button9 != null)
				{
					_Button9.Click -= value2;
				}
				_Button9 = value;
				if (_Button9 != null)
				{
					_Button9.Click += value2;
				}
			}
		}

		internal virtual ListBox lstSectors
		{
			get
			{
				return _lstSectors;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lstSectors = value;
			}
		}

		internal virtual Button Button15
		{
			get
			{
				return _Button15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button15_Click);
				if (_Button15 != null)
				{
					_Button15.Click -= value2;
				}
				_Button15 = value;
				if (_Button15 != null)
				{
					_Button15.Click += value2;
				}
			}
		}

		internal virtual Button Button16
		{
			get
			{
				return _Button16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button16_Click);
				if (_Button16 != null)
				{
					_Button16.Click -= value2;
				}
				_Button16 = value;
				if (_Button16 != null)
				{
					_Button16.Click += value2;
				}
			}
		}

		internal virtual Button Button_0
		{
			get
			{
				return button_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button_0_Click);
				if (button_0 != null)
				{
					button_0.Click -= value2;
				}
				button_0 = value;
				if (button_0 != null)
				{
					button_0.Click += value2;
				}
			}
		}

		internal virtual TextBox txbFile2Flash
		{
			get
			{
				return _txbFile2Flash;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbFile2Flash = value;
			}
		}

		internal virtual TextBox TxbLog
		{
			get
			{
				return _TxbLog;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TxbLog = value;
			}
		}

		internal virtual RadioButton RadioButton2
		{
			get
			{
				return _RadioButton2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_RadioButton2 = value;
			}
		}

		internal virtual RadioButton RadioButton1
		{
			get
			{
				return _RadioButton1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(RadioButton1_CheckedChanged);
				if (_RadioButton1 != null)
				{
					_RadioButton1.CheckedChanged -= value2;
				}
				_RadioButton1 = value;
				if (_RadioButton1 != null)
				{
					_RadioButton1.CheckedChanged += value2;
				}
			}
		}

		internal virtual Button Button14
		{
			get
			{
				return _Button14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button14_Click);
				if (_Button14 != null)
				{
					_Button14.Click -= value2;
				}
				_Button14 = value;
				if (_Button14 != null)
				{
					_Button14.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox6
		{
			get
			{
				return _GroupBox6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_GroupBox6 = value;
			}
		}

		internal virtual Label Label25
		{
			get
			{
				return _Label25;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label25 = value;
			}
		}

		internal virtual Button BtnHitRead
		{
			get
			{
				return _BtnHitRead;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(BtnHitRead_Click);
				if (_BtnHitRead != null)
				{
					_BtnHitRead.Click -= value2;
				}
				_BtnHitRead = value;
				if (_BtnHitRead != null)
				{
					_BtnHitRead.Click += value2;
				}
			}
		}

		internal virtual TextBox txbhitread
		{
			get
			{
				return _txbhitread;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbhitread = value;
			}
		}

		internal virtual ToolStripStatusLabel lblSpeedMode
		{
			get
			{
				return _lblSpeedMode;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lblSpeedMode = value;
			}
		}

		internal virtual Button Button20
		{
			get
			{
				return _Button20;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button20_Click);
				if (_Button20 != null)
				{
					_Button20.Click -= value2;
				}
				_Button20 = value;
				if (_Button20 != null)
				{
					_Button20.Click += value2;
				}
			}
		}

		internal virtual TabPage TabPage7
		{
			get
			{
				return _TabPage7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabPage7 = value;
			}
		}

		internal virtual TreeView TreeView1
		{
			get
			{
				return _TreeView1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(TreeView1_AfterSelect);
				if (_TreeView1 != null)
				{
					_TreeView1.AfterSelect -= value2;
				}
				_TreeView1 = value;
				if (_TreeView1 != null)
				{
					_TreeView1.AfterSelect += value2;
				}
			}
		}

		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			get
			{
				return folderBrowserDialog_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				folderBrowserDialog_0 = value;
			}
		}

		internal virtual Button Button21
		{
			get
			{
				return _Button21;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button21_Click);
				if (_Button21 != null)
				{
					_Button21.Click -= value2;
				}
				_Button21 = value;
				if (_Button21 != null)
				{
					_Button21.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox7
		{
			get
			{
				return _GroupBox7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(GroupBox7_Enter);
				if (_GroupBox7 != null)
				{
					_GroupBox7.Enter -= value2;
				}
				_GroupBox7 = value;
				if (_GroupBox7 != null)
				{
					_GroupBox7.Enter += value2;
				}
			}
		}

		internal virtual TextBox mstxb_key
		{
			get
			{
				return _mstxb_key;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_mstxb_key = value;
			}
		}

		internal virtual Label Label30
		{
			get
			{
				return _Label30;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label30 = value;
			}
		}

		internal virtual Label mslbl_jobname
		{
			get
			{
				return _mslbl_jobname;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_mslbl_jobname = value;
			}
		}

		internal virtual Label Label28
		{
			get
			{
				return _Label28;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label28 = value;
			}
		}

		internal virtual Label mslbl_status
		{
			get
			{
				return _mslbl_status;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_mslbl_status = value;
			}
		}

		internal virtual Label Label26
		{
			get
			{
				return _Label26;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label26 = value;
			}
		}

		internal virtual Button btn_mserase
		{
			get
			{
				return _btn_mserase;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(btn_mserase_Click);
				if (_btn_mserase != null)
				{
					_btn_mserase.Click -= value2;
				}
				_btn_mserase = value;
				if (_btn_mserase != null)
				{
					_btn_mserase.Click += value2;
				}
			}
		}

		internal virtual Button btn_mssave
		{
			get
			{
				return _btn_mssave;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(btn_mssave_Click);
				if (_btn_mssave != null)
				{
					_btn_mssave.Click -= value2;
				}
				_btn_mssave = value;
				if (_btn_mssave != null)
				{
					_btn_mssave.Click += value2;
				}
			}
		}

		internal virtual Label mslbl_logdrive
		{
			get
			{
				return _mslbl_logdrive;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_mslbl_logdrive = value;
			}
		}

		internal virtual Label Label27
		{
			get
			{
				return _Label27;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label27 = value;
			}
		}

		internal virtual Label Label29
		{
			get
			{
				return _Label29;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label29 = value;
			}
		}

		internal virtual TabPage TabPage8
		{
			get
			{
				return OkHuqoVvNm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(TabPage8_Click);
				if (OkHuqoVvNm != null)
				{
					OkHuqoVvNm.Click -= value2;
				}
				OkHuqoVvNm = value;
				if (OkHuqoVvNm != null)
				{
					OkHuqoVvNm.Click += value2;
				}
			}
		}

		internal virtual Button Button19
		{
			get
			{
				return _Button19;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button19_Click);
				if (_Button19 != null)
				{
					_Button19.Click -= value2;
				}
				_Button19 = value;
				if (_Button19 != null)
				{
					_Button19.Click += value2;
				}
			}
		}

		internal virtual Button Button6
		{
			get
			{
				return doGuzyMynU;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button6_Click);
				if (doGuzyMynU != null)
				{
					doGuzyMynU.Click -= value2;
				}
				doGuzyMynU = value;
				if (doGuzyMynU != null)
				{
					doGuzyMynU.Click += value2;
				}
			}
		}

		internal virtual CheckBox chkTurbo
		{
			get
			{
				return _chkTurbo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(chkTurbo_CheckedChanged);
				if (_chkTurbo != null)
				{
					_chkTurbo.CheckedChanged -= value2;
				}
				_chkTurbo = value;
				if (_chkTurbo != null)
				{
					_chkTurbo.CheckedChanged += value2;
				}
			}
		}

		internal virtual TextBox sett_tbxjobspath
		{
			get
			{
				return _sett_tbxjobspath;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_sett_tbxjobspath = value;
			}
		}

		internal virtual Button Button22
		{
			get
			{
				return _Button22;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button22_Click);
				if (_Button22 != null)
				{
					_Button22.Click -= value2;
				}
				_Button22 = value;
				if (_Button22 != null)
				{
					_Button22.Click += value2;
				}
			}
		}

		internal virtual Button Button23
		{
			get
			{
				return _Button23;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button23_Click);
				if (_Button23 != null)
				{
					_Button23.Click -= value2;
				}
				_Button23 = value;
				if (_Button23 != null)
				{
					_Button23.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox9
		{
			get
			{
				return _GroupBox9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_GroupBox9 = value;
			}
		}

		internal virtual GroupBox GroupBox8
		{
			get
			{
				return _GroupBox8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(GroupBox8_Enter);
				if (_GroupBox8 != null)
				{
					_GroupBox8.Enter -= value2;
				}
				_GroupBox8 = value;
				if (_GroupBox8 != null)
				{
					_GroupBox8.Enter += value2;
				}
			}
		}

		internal virtual Label Label31
		{
			get
			{
				return _Label31;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label31 = value;
			}
		}

		internal virtual Button Button24
		{
			get
			{
				return _Button24;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button24_Click);
				if (_Button24 != null)
				{
					_Button24.Click -= value2;
				}
				_Button24 = value;
				if (_Button24 != null)
				{
					_Button24.Click += value2;
				}
			}
		}

		internal virtual ImageList ImageList1
		{
			get
			{
				return imageList_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				imageList_0 = value;
			}
		}

		internal virtual TextBox txbsync_ser
		{
			get
			{
				return _txbsync_ser;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbsync_ser = value;
			}
		}

		internal virtual TabControl TabControl3
		{
			get
			{
				return _TabControl3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabControl3 = value;
			}
		}

		internal virtual TabPage TabPage9
		{
			get
			{
				return _TabPage9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabPage9 = value;
			}
		}

		internal virtual TabPage TabPage_0
		{
			get
			{
				return tabPage_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				tabPage_0 = value;
			}
		}

		internal virtual TabPage TabPage_1
		{
			get
			{
				return tabPage_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				tabPage_1 = value;
			}
		}

		internal virtual TextBox txbsync_ide
		{
			get
			{
				return _txbsync_ide;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbsync_ide = value;
			}
		}

		internal virtual TextBox txbsync_inq
		{
			get
			{
				return _txbsync_inq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbsync_inq = value;
			}
		}

		internal virtual CheckBox chksync_freeafterbackup
		{
			get
			{
				return _chksync_freeafterbackup;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_chksync_freeafterbackup = value;
			}
		}

		internal virtual Button Button25
		{
			get
			{
				return _Button25;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button25_Click);
				if (_Button25 != null)
				{
					_Button25.Click -= value2;
				}
				_Button25 = value;
				if (_Button25 != null)
				{
					_Button25.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox_0
		{
			get
			{
				return groupBox_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				groupBox_0 = value;
			}
		}

		internal virtual ListBox LoggerList
		{
			get
			{
				return _LoggerList;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_LoggerList = value;
			}
		}

		internal virtual RadioButton sett_rb_usbpowdef
		{
			get
			{
				return _sett_rb_usbpowdef;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(sett_rb_usbpowdef_CheckedChanged);
				if (_sett_rb_usbpowdef != null)
				{
					_sett_rb_usbpowdef.CheckedChanged -= value2;
				}
				_sett_rb_usbpowdef = value;
				if (_sett_rb_usbpowdef != null)
				{
					_sett_rb_usbpowdef.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton sett_rb_usbpowins
		{
			get
			{
				return _sett_rb_usbpowins;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_sett_rb_usbpowins = value;
			}
		}

		internal virtual Button Button26
		{
			get
			{
				return _Button26;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button26_Click);
				if (_Button26 != null)
				{
					_Button26.Click -= value2;
				}
				_Button26 = value;
				if (_Button26 != null)
				{
					_Button26.Click += value2;
				}
			}
		}

		internal virtual Button Button27
		{
			get
			{
				return _Button27;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button27_Click);
				if (_Button27 != null)
				{
					_Button27.Click -= value2;
				}
				_Button27 = value;
				if (_Button27 != null)
				{
					_Button27.Click += value2;
				}
			}
		}

		internal virtual Button Button28
		{
			get
			{
				return _Button28;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button28_Click);
				if (_Button28 != null)
				{
					_Button28.Click -= value2;
				}
				_Button28 = value;
				if (_Button28 != null)
				{
					_Button28.Click += value2;
				}
			}
		}

		internal virtual Button Button29
		{
			get
			{
				return _Button29;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button29_Click);
				if (_Button29 != null)
				{
					_Button29.Click -= value2;
				}
				_Button29 = value;
				if (_Button29 != null)
				{
					_Button29.Click += value2;
				}
			}
		}

		internal virtual TabPage TabPage_2
		{
			get
			{
				return tabPage_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(TabPage_2_Click);
				if (tabPage_2 != null)
				{
					tabPage_2.Click -= value2;
				}
				tabPage_2 = value;
				if (tabPage_2 != null)
				{
					tabPage_2.Click += value2;
				}
			}
		}

		internal virtual Button Button34
		{
			get
			{
				return _Button34;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button34_Click);
				if (_Button34 != null)
				{
					_Button34.Click -= value2;
				}
				_Button34 = value;
				if (_Button34 != null)
				{
					_Button34.Click += value2;
				}
			}
		}

		internal virtual Button Button33
		{
			get
			{
				return _Button33;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button33_Click);
				if (_Button33 != null)
				{
					_Button33.Click -= value2;
				}
				_Button33 = value;
				if (_Button33 != null)
				{
					_Button33.Click += value2;
				}
			}
		}

		internal virtual Button Button32
		{
			get
			{
				return _Button32;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button32_Click);
				if (_Button32 != null)
				{
					_Button32.Click -= value2;
				}
				_Button32 = value;
				if (_Button32 != null)
				{
					_Button32.Click += value2;
				}
			}
		}

		internal virtual Button Button31
		{
			get
			{
				return _Button31;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button31_Click);
				if (_Button31 != null)
				{
					_Button31.Click -= value2;
				}
				_Button31 = value;
				if (_Button31 != null)
				{
					_Button31.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox_0
		{
			get
			{
				return textBox_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(TextBox_0_TextChanged);
				if (textBox_0 != null)
				{
					textBox_0.TextChanged -= value2;
				}
				textBox_0 = value;
				if (textBox_0 != null)
				{
					textBox_0.TextChanged += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Timer Timer1
		{
			get
			{
				return timer_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Timer1_Tick);
				if (timer_0 != null)
				{
					timer_0.Tick -= value2;
				}
				timer_0 = value;
				if (timer_0 != null)
				{
					timer_0.Tick += value2;
				}
			}
		}

		internal virtual TabControl TabControl4
		{
			get
			{
				return _TabControl4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TabControlCancelEventHandler value2 = new TabControlCancelEventHandler(method_53);
				TabControlCancelEventHandler value3 = new TabControlCancelEventHandler(method_52);
				if (_TabControl4 != null)
				{
					_TabControl4.Selecting -= value2;
					_TabControl4.Selecting -= value3;
				}
				_TabControl4 = value;
				if (_TabControl4 != null)
				{
					_TabControl4.Selecting += value2;
					_TabControl4.Selecting += value3;
				}
			}
		}

		internal virtual TabPage TabPage_3
		{
			get
			{
				return tabPage_3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				tabPage_3 = value;
			}
		}

		internal virtual TabPage TabPage_4
		{
			get
			{
				return tabPage_4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				tabPage_4 = value;
			}
		}

		internal virtual Button Button35
		{
			get
			{
				return _Button35;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button35_Click);
				if (_Button35 != null)
				{
					_Button35.Click -= value2;
				}
				_Button35 = value;
				if (_Button35 != null)
				{
					_Button35.Click += value2;
				}
			}
		}

		internal virtual Button Button36
		{
			get
			{
				return _Button36;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button36_Click);
				if (_Button36 != null)
				{
					_Button36.Click -= value2;
				}
				_Button36 = value;
				if (_Button36 != null)
				{
					_Button36.Click += value2;
				}
			}
		}

		internal virtual Button Button38
		{
			get
			{
				return _Button38;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button38_Click);
				if (_Button38 != null)
				{
					_Button38.Click -= value2;
				}
				_Button38 = value;
				if (_Button38 != null)
				{
					_Button38.Click += value2;
				}
			}
		}

		internal virtual Button Button37
		{
			get
			{
				return _Button37;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button37_Click);
				if (_Button37 != null)
				{
					_Button37.Click -= value2;
				}
				_Button37 = value;
				if (_Button37 != null)
				{
					_Button37.Click += value2;
				}
			}
		}

		internal virtual TextBox txbCompareLog
		{
			get
			{
				return _txbCompareLog;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbCompareLog = value;
			}
		}

		internal virtual Button Button39
		{
			get
			{
				return _Button39;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button39_Click);
				if (_Button39 != null)
				{
					_Button39.Click -= value2;
				}
				_Button39 = value;
				if (_Button39 != null)
				{
					_Button39.Click += value2;
				}
			}
		}

		internal virtual Button Button40
		{
			get
			{
				return _Button40;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button40_Click);
				if (_Button40 != null)
				{
					_Button40.Click -= value2;
				}
				_Button40 = value;
				if (_Button40 != null)
				{
					_Button40.Click += value2;
				}
			}
		}

		internal virtual Button Button42
		{
			get
			{
				return XmyMeSoxkI;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button42_Click);
				if (XmyMeSoxkI != null)
				{
					XmyMeSoxkI.Click -= value2;
				}
				XmyMeSoxkI = value;
				if (XmyMeSoxkI != null)
				{
					XmyMeSoxkI.Click += value2;
				}
			}
		}

		internal virtual Button Button41
		{
			get
			{
				return _Button41;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button41_Click);
				if (_Button41 != null)
				{
					_Button41.Click -= value2;
				}
				_Button41 = value;
				if (_Button41 != null)
				{
					_Button41.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox_1
		{
			get
			{
				return groupBox_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				groupBox_1 = value;
			}
		}

		internal virtual Button Button43
		{
			get
			{
				return _Button43;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button43_Click);
				if (_Button43 != null)
				{
					_Button43.Click -= value2;
				}
				_Button43 = value;
				if (_Button43 != null)
				{
					_Button43.Click += value2;
				}
			}
		}

		internal virtual Button Button44
		{
			get
			{
				return _Button44;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button44_Click);
				if (_Button44 != null)
				{
					_Button44.Click -= value2;
				}
				_Button44 = value;
				if (_Button44 != null)
				{
					_Button44.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox_2
		{
			get
			{
				return groupBox_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				groupBox_2 = value;
			}
		}

		internal virtual TextBox txbTime
		{
			get
			{
				return _txbTime;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbTime = value;
			}
		}

		internal virtual Label Label33
		{
			get
			{
				return _Label33;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label33 = value;
			}
		}

		internal virtual Label Label32
		{
			get
			{
				return _Label32;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label32 = value;
			}
		}

		internal virtual TextBox txbPeriod
		{
			get
			{
				return _txbPeriod;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbPeriod = value;
			}
		}

		internal virtual Button Button45
		{
			get
			{
				return _Button45;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button45_Click);
				if (_Button45 != null)
				{
					_Button45.Click -= value2;
				}
				_Button45 = value;
				if (_Button45 != null)
				{
					_Button45.Click += value2;
				}
			}
		}

		internal virtual Button Button46
		{
			get
			{
				return _Button46;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button46_Click);
				if (_Button46 != null)
				{
					_Button46.Click -= value2;
				}
				_Button46 = value;
				if (_Button46 != null)
				{
					_Button46.Click += value2;
				}
			}
		}

		internal virtual TabPage TabPage_5
		{
			get
			{
				return tabPage_5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				tabPage_5 = value;
			}
		}

		internal virtual GroupBox GroupBox_3
		{
			get
			{
				return groupBox_3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				groupBox_3 = value;
			}
		}

		internal virtual Button Button48
		{
			get
			{
				return _Button48;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button48_Click);
				if (_Button48 != null)
				{
					_Button48.Click -= value2;
				}
				_Button48 = value;
				if (_Button48 != null)
				{
					_Button48.Click += value2;
				}
			}
		}

		internal virtual Button Button47
		{
			get
			{
				return _Button47;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button47_Click);
				if (_Button47 != null)
				{
					_Button47.Click -= value2;
				}
				_Button47 = value;
				if (_Button47 != null)
				{
					_Button47.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox_4
		{
			get
			{
				return groupBox_4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				groupBox_4 = value;
			}
		}

		internal virtual Button Button50
		{
			get
			{
				return _Button50;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button50_Click);
				if (_Button50 != null)
				{
					_Button50.Click -= value2;
				}
				_Button50 = value;
				if (_Button50 != null)
				{
					_Button50.Click += value2;
				}
			}
		}

		internal virtual Label Label35
		{
			get
			{
				return _Label35;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label35 = value;
			}
		}

		internal virtual ComboBox cmbxkeydash
		{
			get
			{
				return _cmbxkeydash;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_cmbxkeydash = value;
			}
		}

		internal virtual GroupBox GroupBox_5
		{
			get
			{
				return groupBox_5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				groupBox_5 = value;
			}
		}

		internal virtual Button Button49
		{
			get
			{
				return _Button49;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button49_Click);
				if (_Button49 != null)
				{
					_Button49.Click -= value2;
				}
				_Button49 = value;
				if (_Button49 != null)
				{
					_Button49.Click += value2;
				}
			}
		}

		internal virtual CheckBox chkxkey0225U
		{
			get
			{
				return _chkxkey0225U;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_chkxkey0225U = value;
			}
		}

		internal virtual CheckBox chkxkeyMENUISO
		{
			get
			{
				return _chkxkeyMENUISO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_chkxkeyMENUISO = value;
			}
		}

		internal virtual Label Label34
		{
			get
			{
				return _Label34;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label34 = value;
			}
		}

		internal virtual ComboBox cmbxkeylang
		{
			get
			{
				return _cmbxkeylang;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_cmbxkeylang = value;
			}
		}

		internal virtual Label Label36
		{
			get
			{
				return _Label36;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Label36_Click);
				if (_Label36 != null)
				{
					_Label36.Click -= value2;
				}
				_Label36 = value;
				if (_Label36 != null)
				{
					_Label36.Click += value2;
				}
			}
		}

		internal virtual Label Label37
		{
			get
			{
				return _Label37;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Label37_Click);
				if (_Label37 != null)
				{
					_Label37.Click -= value2;
				}
				_Label37 = value;
				if (_Label37 != null)
				{
					_Label37.Click += value2;
				}
			}
		}

		internal virtual Label Label39
		{
			get
			{
				return _Label39;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label39 = value;
			}
		}

		internal virtual Label Label38
		{
			get
			{
				return _Label38;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label38 = value;
			}
		}

		internal virtual Label Label40
		{
			get
			{
				return _Label40;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Label40_Click);
				if (_Label40 != null)
				{
					_Label40.Click -= value2;
				}
				_Label40 = value;
				if (_Label40 != null)
				{
					_Label40.Click += value2;
				}
			}
		}

		internal virtual Button Button51
		{
			get
			{
				return VyrXikJyPG;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(tvQolXxoXE);
				if (VyrXikJyPG != null)
				{
					VyrXikJyPG.Click -= value2;
				}
				VyrXikJyPG = value;
				if (VyrXikJyPG != null)
				{
					VyrXikJyPG.Click += value2;
				}
			}
		}

		internal virtual Button Button52
		{
			get
			{
				return _Button52;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button52_Click);
				if (_Button52 != null)
				{
					_Button52.Click -= value2;
				}
				_Button52 = value;
				if (_Button52 != null)
				{
					_Button52.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox_6
		{
			get
			{
				return groupBox_6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				groupBox_6 = value;
			}
		}

		internal virtual Label Label41
		{
			get
			{
				return _Label41;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label41 = value;
			}
		}

		internal virtual Button btn_msload
		{
			get
			{
				return _btn_msload;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(btn_msload_Click);
				if (_btn_msload != null)
				{
					_btn_msload.Click -= value2;
				}
				_btn_msload = value;
				if (_btn_msload != null)
				{
					_btn_msload.Click += value2;
				}
			}
		}

		internal virtual PictureBox picsync3
		{
			get
			{
				return _picsync3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_picsync3 = value;
			}
		}

		internal virtual PictureBox picsync2
		{
			get
			{
				return _picsync2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_picsync2 = value;
			}
		}

		internal virtual PictureBox picsync1
		{
			get
			{
				return _picsync1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_picsync1 = value;
			}
		}

		internal virtual Label Label44
		{
			get
			{
				return _Label44;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label44 = value;
			}
		}

		internal virtual Label Label43
		{
			get
			{
				return _Label43;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label43 = value;
			}
		}

		internal virtual Label Label42
		{
			get
			{
				return _Label42;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label42 = value;
			}
		}

		internal virtual Label Label45
		{
			get
			{
				return _Label45;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Label45_Click);
				if (_Label45 != null)
				{
					_Label45.Click -= value2;
				}
				_Label45 = value;
				if (_Label45 != null)
				{
					_Label45.Click += value2;
				}
			}
		}

		internal virtual TextBox txbxkeyUNIQUE
		{
			get
			{
				return _txbxkeyUNIQUE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbxkeyUNIQUE = value;
			}
		}

		internal virtual Label Label47
		{
			get
			{
				return _Label47;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label47 = value;
			}
		}

		internal virtual TextBox TextBox_1
		{
			get
			{
				return textBox_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				textBox_1 = value;
			}
		}

		internal virtual Label Label46
		{
			get
			{
				return _Label46;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label46 = value;
			}
		}

		internal virtual TextBox TextBox_2
		{
			get
			{
				return textBox_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				textBox_2 = value;
			}
		}

		internal virtual Button Button53
		{
			get
			{
				return _Button53;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button53_Click);
				if (_Button53 != null)
				{
					_Button53.Click -= value2;
				}
				_Button53 = value;
				if (_Button53 != null)
				{
					_Button53.Click += value2;
				}
			}
		}

		internal virtual Button Button54
		{
			get
			{
				return _Button54;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(uEsoPgKroV);
				if (_Button54 != null)
				{
					_Button54.Click -= value2;
				}
				_Button54 = value;
				if (_Button54 != null)
				{
					_Button54.Click += value2;
				}
			}
		}

		internal virtual TabPage TabPage_6
		{
			get
			{
				return tabPage_6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				tabPage_6 = value;
			}
		}

		internal virtual Label Label48
		{
			get
			{
				return _Label48;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Label48_Click);
				if (_Label48 != null)
				{
					_Label48.Click -= value2;
				}
				_Label48 = value;
				if (_Label48 != null)
				{
					_Label48.Click += value2;
				}
			}
		}

		internal virtual Label Label49
		{
			get
			{
				return _Label49;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Label49_Click);
				if (_Label49 != null)
				{
					_Label49.Click -= value2;
				}
				_Label49 = value;
				if (_Label49 != null)
				{
					_Label49.Click += value2;
				}
			}
		}

		internal virtual Button Button56
		{
			get
			{
				return _Button56;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button56_Click);
				if (_Button56 != null)
				{
					_Button56.Click -= value2;
				}
				_Button56 = value;
				if (_Button56 != null)
				{
					_Button56.Click += value2;
				}
			}
		}

		internal virtual TextBox txbLTU_key
		{
			get
			{
				return _txbLTU_key;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbLTU_key = value;
			}
		}

		internal virtual Label Label50
		{
			get
			{
				return _Label50;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Label50_Click);
				if (_Label50 != null)
				{
					_Label50.Click -= value2;
				}
				_Label50 = value;
				if (_Label50 != null)
				{
					_Label50.Click += value2;
				}
			}
		}

		internal virtual Button Button55
		{
			get
			{
				return _Button55;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button55_Click);
				if (_Button55 != null)
				{
					_Button55.Click -= value2;
				}
				_Button55 = value;
				if (_Button55 != null)
				{
					_Button55.Click += value2;
				}
			}
		}

		internal virtual TextBox txbLTU_cr
		{
			get
			{
				return _txbLTU_cr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbLTU_cr = value;
			}
		}

		internal virtual Button Button57
		{
			get
			{
				return _Button57;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button57_Click);
				if (_Button57 != null)
				{
					_Button57.Click -= value2;
				}
				_Button57 = value;
				if (_Button57 != null)
				{
					_Button57.Click += value2;
				}
			}
		}

		internal virtual TextBox txbLTU_Unique
		{
			get
			{
				return _txbLTU_Unique;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txbLTU_Unique = value;
			}
		}

		internal virtual Label Label51
		{
			get
			{
				return _Label51;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Label51_Click);
				if (_Label51 != null)
				{
					_Label51.Click -= value2;
				}
				_Label51 = value;
				if (_Label51 != null)
				{
					_Label51.Click += value2;
				}
			}
		}

		internal virtual Button Button58
		{
			get
			{
				return _Button58;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button58_Click);
				if (_Button58 != null)
				{
					_Button58.Click -= value2;
				}
				_Button58 = value;
				if (_Button58 != null)
				{
					_Button58.Click += value2;
				}
			}
		}

		internal virtual Label Label53
		{
			get
			{
				return _Label53;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label53 = value;
			}
		}

		internal virtual Label Label52
		{
			get
			{
				return _Label52;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label52 = value;
			}
		}

		internal virtual Button Button59
		{
			get
			{
				return _Button59;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button59_Click);
				if (_Button59 != null)
				{
					_Button59.Click -= value2;
				}
				_Button59 = value;
				if (_Button59 != null)
				{
					_Button59.Click += value2;
				}
			}
		}

		internal virtual Button Button60
		{
			get
			{
				return _Button60;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button60_Click);
				if (_Button60 != null)
				{
					_Button60.Click -= value2;
				}
				_Button60 = value;
				if (_Button60 != null)
				{
					_Button60.Click += value2;
				}
			}
		}

		internal virtual Button Button61
		{
			get
			{
				return _Button61;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button61_Click);
				if (_Button61 != null)
				{
					_Button61.Click -= value2;
				}
				_Button61 = value;
				if (_Button61 != null)
				{
					_Button61.Click += value2;
				}
			}
		}

		internal virtual Button Button30
		{
			get
			{
				return _Button30;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button30_Click);
				if (_Button30 != null)
				{
					_Button30.Click -= value2;
				}
				_Button30 = value;
				if (_Button30 != null)
				{
					_Button30.Click += value2;
				}
			}
		}

		internal virtual Button Button62
		{
			get
			{
				return _Button62;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(lthoGsqhyQ);
				if (_Button62 != null)
				{
					_Button62.Click -= value2;
				}
				_Button62 = value;
				if (_Button62 != null)
				{
					_Button62.Click += value2;
				}
			}
		}

		internal virtual Button Button63
		{
			get
			{
				return _Button63;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button63_Click);
				if (_Button63 != null)
				{
					_Button63.Click -= value2;
				}
				_Button63 = value;
				if (_Button63 != null)
				{
					_Button63.Click += value2;
				}
			}
		}

		internal virtual Button Button64
		{
			get
			{
				return _Button64;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button64_Click);
				if (_Button64 != null)
				{
					_Button64.Click -= value2;
				}
				_Button64 = value;
				if (_Button64 != null)
				{
					_Button64.Click += value2;
				}
			}
		}

		internal virtual Button Button65
		{
			get
			{
				return _Button65;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button65_Click);
				if (_Button65 != null)
				{
					_Button65.Click -= value2;
				}
				_Button65 = value;
				if (_Button65 != null)
				{
					_Button65.Click += value2;
				}
			}
		}

		internal virtual Label Label54
		{
			get
			{
				return _Label54;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label54 = value;
			}
		}

		internal virtual ComboBox cmbLTUTemplate
		{
			get
			{
				return _cmbLTUTemplate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(cmbLTUTemplate_SelectedIndexChanged);
				if (_cmbLTUTemplate != null)
				{
					_cmbLTUTemplate.SelectedIndexChanged -= value2;
				}
				_cmbLTUTemplate = value;
				if (_cmbLTUTemplate != null)
				{
					_cmbLTUTemplate.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cmbLTUFileset
		{
			get
			{
				return _cmbLTUFileset;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(cmbLTUFileset_SelectedIndexChanged);
				if (_cmbLTUFileset != null)
				{
					_cmbLTUFileset.SelectedIndexChanged -= value2;
				}
				_cmbLTUFileset = value;
				if (_cmbLTUFileset != null)
				{
					_cmbLTUFileset.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual Button Button67
		{
			get
			{
				return pofXfiTqii;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button67_Click);
				if (pofXfiTqii != null)
				{
					pofXfiTqii.Click -= value2;
				}
				pofXfiTqii = value;
				if (pofXfiTqii != null)
				{
					pofXfiTqii.Click += value2;
				}
			}
		}

		internal virtual Button Button66
		{
			get
			{
				return _Button66;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button66_Click);
				if (_Button66 != null)
				{
					_Button66.Click -= value2;
				}
				_Button66 = value;
				if (_Button66 != null)
				{
					_Button66.Click += value2;
				}
			}
		}

		internal virtual Button Button68
		{
			get
			{
				return _Button68;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button68_Click);
				if (_Button68 != null)
				{
					_Button68.Click -= value2;
				}
				_Button68 = value;
				if (_Button68 != null)
				{
					_Button68.Click += value2;
				}
			}
		}

		internal virtual TabControl TabControl5
		{
			get
			{
				return _TabControl5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabControl5 = value;
			}
		}

		internal virtual TabPage TabPage_7
		{
			get
			{
				return tabPage_7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				tabPage_7 = value;
			}
		}

		internal virtual TabPage TabPage_8
		{
			get
			{
				return tabPage_8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				tabPage_8 = value;
			}
		}

		internal virtual TextBox TxbLTU2_key
		{
			get
			{
				return _TxbLTU2_key;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TxbLTU2_key = value;
			}
		}

		internal virtual Label Label55
		{
			get
			{
				return _Label55;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label55 = value;
			}
		}

		internal virtual TextBox TxbLTU2_cr
		{
			get
			{
				return _TxbLTU2_cr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TxbLTU2_cr = value;
			}
		}

		internal virtual Button Button69
		{
			get
			{
				return _Button69;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button69_Click);
				if (_Button69 != null)
				{
					_Button69.Click -= value2;
				}
				_Button69 = value;
				if (_Button69 != null)
				{
					_Button69.Click += value2;
				}
			}
		}

		internal virtual ComboBox cmbLTU2Fileset
		{
			get
			{
				return _cmbLTU2Fileset;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(cmbLTU2Fileset_SelectedIndexChanged);
				if (_cmbLTU2Fileset != null)
				{
					_cmbLTU2Fileset.SelectedIndexChanged -= value2;
				}
				_cmbLTU2Fileset = value;
				if (_cmbLTU2Fileset != null)
				{
					_cmbLTU2Fileset.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual Label Label56
		{
			get
			{
				return _Label56;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label56 = value;
			}
		}

		internal virtual Label Label57
		{
			get
			{
				return _Label57;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label57 = value;
			}
		}

		internal virtual Button Button70
		{
			get
			{
				return _Button70;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button70_Click);
				if (_Button70 != null)
				{
					_Button70.Click -= value2;
				}
				_Button70 = value;
				if (_Button70 != null)
				{
					_Button70.Click += value2;
				}
			}
		}

		internal virtual Label Label58
		{
			get
			{
				return GutaQuFvLg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				GutaQuFvLg = value;
			}
		}

		internal virtual Button Button71
		{
			get
			{
				return _Button71;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Button71_Click);
				if (_Button71 != null)
				{
					_Button71.Click -= value2;
				}
				_Button71 = value;
				if (_Button71 != null)
				{
					_Button71.Click += value2;
				}
			}
		}

		internal virtual Label Label59
		{
			get
			{
				return _Label59;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label59 = value;
			}
		}

		internal virtual Label Label60
		{
			get
			{
				return nSoaZyWeLD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				nSoaZyWeLD = value;
			}
		}

		internal virtual Label Label62
		{
			get
			{
				return _Label62;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label62 = value;
			}
		}

		internal virtual ComboBox cmbLTU2Template
		{
			get
			{
				return _cmbLTU2Template;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_cmbLTU2Template = value;
			}
		}

		internal virtual Label Label61
		{
			get
			{
				return _Label61;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label61 = value;
			}
		}

		public bool get_pc23log(byte pc, ref byte[] bPCLog)
		{
			if (Operators.CompareString(txbEV_SrcKey.Text, "", false) == 0)
			{
				Interaction.MsgBox("Please load a file on CFW Generator Easy view to grab key", MsgBoxStyle.Exclamation, "Error:");
				return false;
			}
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return false;
			}
			byte[] array = new byte[16];
			byte b = 0;
			array = ToolboxUtilities.cpoahSiso(txbEV_SrcKey.Text);
			bool bisvalid = false;
			byte num = LIZ_PageCodeLog(pc, ref array, ref bPCLog, ref bisvalid);
			b = (byte)(0u - (bisvalid ? 1u : 0u));
			byte b2 = num;
			if (b2 == 0)
			{
				if (b != 0)
				{
					return true;
				}
				Interaction.MsgBox("Make sure of the following:\r\n-Lizard in menu\r\n-Drive is Connected\r\n-Proper firmware for the drive is open in CFW Generator", MsgBoxStyle.Exclamation, "Error:");
				return false;
			}
			Interaction.MsgBox("Error checking key, return code:" + Conversions.ToString(b2), MsgBoxStyle.Exclamation, "Error");
			return false;
		}

		public Form1()
		{
			base.Load += new EventHandler(Form1_Load);
			struct5_0 = new ToolboxUtilities.Struct5[16];
			byte_0 = new byte[97];
			byte_1 = new byte[181];
			byte_2 = new byte[81];
			byte_3 = new byte[16];
			byte_4 = new byte[4096];
			byte_5 = new byte[4096];
			byte_6 = new byte[2];
			byte_7 = new byte[97];
			byte_8 = new byte[181];
			byte_9 = new byte[81];
			byte_10 = new byte[16];
			byte_11 = new byte[4096];
			byte_12 = new byte[4096];
			byte_13 = new byte[2];
			InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && icontainer_0 != null)
				{
					icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.icontainer_0 = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lzard_TBX_NET40.Form1));
			this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ToolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.COM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripStatusLabel_0 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblAction = new System.Windows.Forms.ToolStripStatusLabel();
			this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.lblSpeedMode = new System.Windows.Forms.ToolStripStatusLabel();
			this.SerialPort1 = new System.IO.Ports.SerialPort(this.icontainer_0);
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button11 = new System.Windows.Forms.Button();
			this.Button12 = new System.Windows.Forms.Button();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.Button17 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button54 = new System.Windows.Forms.Button();
			this.lblFlashDevID = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblOSVer = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Button18 = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.lblSerial = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.Button53 = new System.Windows.Forms.Button();
			this.GroupBox_6 = new System.Windows.Forms.GroupBox();
			this.Label41 = new System.Windows.Forms.Label();
			this.Button51 = new System.Windows.Forms.Button();
			this.Button52 = new System.Windows.Forms.Button();
			this.Button43 = new System.Windows.Forms.Button();
			this.Button29 = new System.Windows.Forms.Button();
			this.Button24 = new System.Windows.Forms.Button();
			this.Button20 = new System.Windows.Forms.Button();
			this.Label23 = new System.Windows.Forms.Label();
			this.Button8 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.TabControl2 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.btnEV_CFWSaveAs = new System.Windows.Forms.Button();
			this.Label18 = new System.Windows.Forms.Label();
			this.cmbEV_DstCFWTemplate = new System.Windows.Forms.ComboBox();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Button67 = new System.Windows.Forms.Button();
			this.txbEV_SrcKey = new System.Windows.Forms.TextBox();
			this.txbEV_SrcFwInfo = new System.Windows.Forms.TextBox();
			this.txbEV_SrcFile = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.btnEV_LoadSrcFw = new System.Windows.Forms.Button();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.TabPage4 = new System.Windows.Forms.TabPage();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.txbAV_SrcLogDrive = new System.Windows.Forms.TextBox();
			this.txbAV_SrcPhyDrive = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.txbAV_SrcFile = new System.Windows.Forms.TextBox();
			this.lblSrcSpoof = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.txbAV_SrcDVDSer = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txbAV_SrcKey = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.btn_editDstLogDrive = new System.Windows.Forms.Button();
			this.btn_editDstSer = new System.Windows.Forms.Button();
			this.txbAV_DstPhyDrive = new System.Windows.Forms.TextBox();
			this.Button5 = new System.Windows.Forms.Button();
			this.Label14 = new System.Windows.Forms.Label();
			this.txbAV_DstFile = new System.Windows.Forms.TextBox();
			this.btn_editDstKey = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.lblDestSpoof = new System.Windows.Forms.Label();
			this.txbAV_DstDVDSer = new System.Windows.Forms.TextBox();
			this.txbAV_DstKey = new System.Windows.Forms.TextBox();
			this.cmbAV_DstLogDrive = new System.Windows.Forms.ComboBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.TabPage_6 = new System.Windows.Forms.TabPage();
			this.TabControl5 = new System.Windows.Forms.TabControl();
			this.TabPage_7 = new System.Windows.Forms.TabPage();
			this.Label62 = new System.Windows.Forms.Label();
			this.cmbLTU2Template = new System.Windows.Forms.ComboBox();
			this.Label61 = new System.Windows.Forms.Label();
			this.TxbLTU2_key = new System.Windows.Forms.TextBox();
			this.Label55 = new System.Windows.Forms.Label();
			this.TxbLTU2_cr = new System.Windows.Forms.TextBox();
			this.Button69 = new System.Windows.Forms.Button();
			this.cmbLTU2Fileset = new System.Windows.Forms.ComboBox();
			this.Label56 = new System.Windows.Forms.Label();
			this.Label57 = new System.Windows.Forms.Label();
			this.Button70 = new System.Windows.Forms.Button();
			this.Label58 = new System.Windows.Forms.Label();
			this.Button71 = new System.Windows.Forms.Button();
			this.Label59 = new System.Windows.Forms.Label();
			this.Button59 = new System.Windows.Forms.Button();
			this.Button68 = new System.Windows.Forms.Button();
			this.Button60 = new System.Windows.Forms.Button();
			this.Button66 = new System.Windows.Forms.Button();
			this.Button61 = new System.Windows.Forms.Button();
			this.Button30 = new System.Windows.Forms.Button();
			this.Button65 = new System.Windows.Forms.Button();
			this.Button62 = new System.Windows.Forms.Button();
			this.Button64 = new System.Windows.Forms.Button();
			this.Button63 = new System.Windows.Forms.Button();
			this.TabPage_8 = new System.Windows.Forms.TabPage();
			this.Label60 = new System.Windows.Forms.Label();
			this.cmbLTUTemplate = new System.Windows.Forms.ComboBox();
			this.Label48 = new System.Windows.Forms.Label();
			this.txbLTU_key = new System.Windows.Forms.TextBox();
			this.Label49 = new System.Windows.Forms.Label();
			this.txbLTU_cr = new System.Windows.Forms.TextBox();
			this.Button55 = new System.Windows.Forms.Button();
			this.cmbLTUFileset = new System.Windows.Forms.ComboBox();
			this.Label50 = new System.Windows.Forms.Label();
			this.Label54 = new System.Windows.Forms.Label();
			this.Button56 = new System.Windows.Forms.Button();
			this.Label51 = new System.Windows.Forms.Label();
			this.txbLTU_Unique = new System.Windows.Forms.TextBox();
			this.Button57 = new System.Windows.Forms.Button();
			this.Label52 = new System.Windows.Forms.Label();
			this.Button58 = new System.Windows.Forms.Button();
			this.Label53 = new System.Windows.Forms.Label();
			this.TabPage6 = new System.Windows.Forms.TabPage();
			this.Label25 = new System.Windows.Forms.Label();
			this.BtnHitRead = new System.Windows.Forms.Button();
			this.txbhitread = new System.Windows.Forms.TextBox();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.txbhitsrc = new System.Windows.Forms.TextBox();
			this.Button9 = new System.Windows.Forms.Button();
			this.Button10 = new System.Windows.Forms.Button();
			this.txbhitdst = new System.Windows.Forms.TextBox();
			this.Button13 = new System.Windows.Forms.Button();
			this.Label24 = new System.Windows.Forms.Label();
			this.txbAddrSect = new System.Windows.Forms.TextBox();
			this.Button7 = new System.Windows.Forms.Button();
			this.Button15 = new System.Windows.Forms.Button();
			this.Button14 = new System.Windows.Forms.Button();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.TxbLog = new System.Windows.Forms.TextBox();
			this.Button_0 = new System.Windows.Forms.Button();
			this.txbFile2Flash = new System.Windows.Forms.TextBox();
			this.Button16 = new System.Windows.Forms.Button();
			this.lstSectors = new System.Windows.Forms.ListBox();
			this.TabPage7 = new System.Windows.Forms.TabPage();
			this.Label44 = new System.Windows.Forms.Label();
			this.Label43 = new System.Windows.Forms.Label();
			this.Label42 = new System.Windows.Forms.Label();
			this.picsync3 = new System.Windows.Forms.PictureBox();
			this.picsync2 = new System.Windows.Forms.PictureBox();
			this.picsync1 = new System.Windows.Forms.PictureBox();
			this.Button28 = new System.Windows.Forms.Button();
			this.chksync_freeafterbackup = new System.Windows.Forms.CheckBox();
			this.Button25 = new System.Windows.Forms.Button();
			this.Label29 = new System.Windows.Forms.Label();
			this.GroupBox7 = new System.Windows.Forms.GroupBox();
			this.btn_msload = new System.Windows.Forms.Button();
			this.TabControl3 = new System.Windows.Forms.TabControl();
			this.TabPage9 = new System.Windows.Forms.TabPage();
			this.txbsync_ide = new System.Windows.Forms.TextBox();
			this.TabPage_0 = new System.Windows.Forms.TabPage();
			this.txbsync_inq = new System.Windows.Forms.TextBox();
			this.TabPage_1 = new System.Windows.Forms.TabPage();
			this.txbsync_ser = new System.Windows.Forms.TextBox();
			this.mslbl_logdrive = new System.Windows.Forms.Label();
			this.Label27 = new System.Windows.Forms.Label();
			this.btn_mserase = new System.Windows.Forms.Button();
			this.btn_mssave = new System.Windows.Forms.Button();
			this.mstxb_key = new System.Windows.Forms.TextBox();
			this.Label30 = new System.Windows.Forms.Label();
			this.mslbl_jobname = new System.Windows.Forms.Label();
			this.Label28 = new System.Windows.Forms.Label();
			this.mslbl_status = new System.Windows.Forms.Label();
			this.Label26 = new System.Windows.Forms.Label();
			this.Button21 = new System.Windows.Forms.Button();
			this.TreeView1 = new System.Windows.Forms.TreeView();
			this.TabPage8 = new System.Windows.Forms.TabPage();
			this.GroupBox_2 = new System.Windows.Forms.GroupBox();
			this.txbTime = new System.Windows.Forms.TextBox();
			this.Label33 = new System.Windows.Forms.Label();
			this.Label32 = new System.Windows.Forms.Label();
			this.txbPeriod = new System.Windows.Forms.TextBox();
			this.Button45 = new System.Windows.Forms.Button();
			this.GroupBox_1 = new System.Windows.Forms.GroupBox();
			this.Button40 = new System.Windows.Forms.Button();
			this.Button42 = new System.Windows.Forms.Button();
			this.Button41 = new System.Windows.Forms.Button();
			this.GroupBox_0 = new System.Windows.Forms.GroupBox();
			this.Button27 = new System.Windows.Forms.Button();
			this.LoggerList = new System.Windows.Forms.ListBox();
			this.sett_rb_usbpowdef = new System.Windows.Forms.RadioButton();
			this.sett_rb_usbpowins = new System.Windows.Forms.RadioButton();
			this.Button26 = new System.Windows.Forms.Button();
			this.GroupBox9 = new System.Windows.Forms.GroupBox();
			this.Button46 = new System.Windows.Forms.Button();
			this.Button19 = new System.Windows.Forms.Button();
			this.Button6 = new System.Windows.Forms.Button();
			this.GroupBox8 = new System.Windows.Forms.GroupBox();
			this.chkTurbo = new System.Windows.Forms.CheckBox();
			this.Label31 = new System.Windows.Forms.Label();
			this.sett_tbxjobspath = new System.Windows.Forms.TextBox();
			this.Button22 = new System.Windows.Forms.Button();
			this.Button23 = new System.Windows.Forms.Button();
			this.TabPage_2 = new System.Windows.Forms.TabPage();
			this.TabControl4 = new System.Windows.Forms.TabControl();
			this.TabPage_3 = new System.Windows.Forms.TabPage();
			this.Button44 = new System.Windows.Forms.Button();
			this.TextBox_0 = new System.Windows.Forms.TextBox();
			this.Button34 = new System.Windows.Forms.Button();
			this.Button31 = new System.Windows.Forms.Button();
			this.Button33 = new System.Windows.Forms.Button();
			this.Button32 = new System.Windows.Forms.Button();
			this.TabPage_4 = new System.Windows.Forms.TabPage();
			this.Button39 = new System.Windows.Forms.Button();
			this.Button38 = new System.Windows.Forms.Button();
			this.Button37 = new System.Windows.Forms.Button();
			this.txbCompareLog = new System.Windows.Forms.TextBox();
			this.Button36 = new System.Windows.Forms.Button();
			this.Button35 = new System.Windows.Forms.Button();
			this.TabPage_5 = new System.Windows.Forms.TabPage();
			this.Label39 = new System.Windows.Forms.Label();
			this.Label38 = new System.Windows.Forms.Label();
			this.Label37 = new System.Windows.Forms.Label();
			this.GroupBox_4 = new System.Windows.Forms.GroupBox();
			this.Label36 = new System.Windows.Forms.Label();
			this.Button50 = new System.Windows.Forms.Button();
			this.Label35 = new System.Windows.Forms.Label();
			this.cmbxkeydash = new System.Windows.Forms.ComboBox();
			this.GroupBox_5 = new System.Windows.Forms.GroupBox();
			this.txbxkeyUNIQUE = new System.Windows.Forms.TextBox();
			this.Label47 = new System.Windows.Forms.Label();
			this.TextBox_1 = new System.Windows.Forms.TextBox();
			this.Label46 = new System.Windows.Forms.Label();
			this.TextBox_2 = new System.Windows.Forms.TextBox();
			this.Label45 = new System.Windows.Forms.Label();
			this.Button49 = new System.Windows.Forms.Button();
			this.chkxkey0225U = new System.Windows.Forms.CheckBox();
			this.chkxkeyMENUISO = new System.Windows.Forms.CheckBox();
			this.Label34 = new System.Windows.Forms.Label();
			this.cmbxkeylang = new System.Windows.Forms.ComboBox();
			this.GroupBox_3 = new System.Windows.Forms.GroupBox();
			this.Label40 = new System.Windows.Forms.Label();
			this.Button48 = new System.Windows.Forms.Button();
			this.Button47 = new System.Windows.Forms.Button();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.icontainer_0);
			this.MNU_MAN_EDIT = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.SMOAV_DSTEDIT_LOADF_FILE = new System.Windows.Forms.ToolStripMenuItem();
			this.SMOAV_DSTEDIT_LOADF_FW = new System.Windows.Forms.ToolStripMenuItem();
			this.SMOAV_DSTEDIT_MAN_EDIT = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.SMOAV_DSTEDIT_GOBACK = new System.Windows.Forms.ToolStripMenuItem();
			this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.icontainer_0);
			this.Timer1 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.StatusStrip1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.GroupBox_6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			this.TabPage3.SuspendLayout();
			this.TabControl2.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.TabPage4.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.TabPage_6.SuspendLayout();
			this.TabControl5.SuspendLayout();
			this.TabPage_7.SuspendLayout();
			this.TabPage_8.SuspendLayout();
			this.TabPage6.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.TabPage7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.picsync3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.picsync2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.picsync1).BeginInit();
			this.GroupBox7.SuspendLayout();
			this.TabControl3.SuspendLayout();
			this.TabPage9.SuspendLayout();
			this.TabPage_0.SuspendLayout();
			this.TabPage_1.SuspendLayout();
			this.TabPage8.SuspendLayout();
			this.GroupBox_2.SuspendLayout();
			this.GroupBox_1.SuspendLayout();
			this.GroupBox_0.SuspendLayout();
			this.GroupBox9.SuspendLayout();
			this.GroupBox8.SuspendLayout();
			this.TabPage_2.SuspendLayout();
			this.TabControl4.SuspendLayout();
			this.TabPage_3.SuspendLayout();
			this.TabPage_4.SuspendLayout();
			this.GroupBox_4.SuspendLayout();
			this.GroupBox_5.SuspendLayout();
			this.GroupBox_3.SuspendLayout();
			this.MNU_MAN_EDIT.SuspendLayout();
			this.SuspendLayout();
			this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.ToolStripSplitButton1, this.ToolStripStatusLabel_0, this.lblAction, this.ProgressBar1, this.lblSpeedMode });
			System.Windows.Forms.StatusStrip statusStrip = this.StatusStrip1;
			System.Drawing.Point location = new System.Drawing.Point(0, 460);
			statusStrip.Location = location;
			this.StatusStrip1.Name = "StatusStrip1";
			System.Windows.Forms.StatusStrip statusStrip2 = this.StatusStrip1;
			System.Drawing.Size size = new System.Drawing.Size(693, 22);
			statusStrip2.Size = size;
			this.StatusStrip1.TabIndex = 12;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.COM1ToolStripMenuItem });
			this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
			System.Windows.Forms.ToolStripSplitButton toolStripSplitButton = this.ToolStripSplitButton1;
			size = new System.Drawing.Size(77, 20);
			toolStripSplitButton.Size = size;
			this.ToolStripSplitButton1.Text = "Com Port:";
			this.COM1ToolStripMenuItem.Name = "COM1ToolStripMenuItem";
			System.Windows.Forms.ToolStripMenuItem cOM1ToolStripMenuItem = this.COM1ToolStripMenuItem;
			size = new System.Drawing.Size(108, 22);
			cOM1ToolStripMenuItem.Size = size;
			this.COM1ToolStripMenuItem.Text = "COM1";
			this.ToolStripStatusLabel_0.Name = "lblCOMSel";
			System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel = this.ToolStripStatusLabel_0;
			size = new System.Drawing.Size(41, 17);
			toolStripStatusLabel.Size = size;
			this.ToolStripStatusLabel_0.Text = "COM1";
			this.lblAction.Name = "lblAction";
			System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2 = this.lblAction;
			size = new System.Drawing.Size(26, 17);
			toolStripStatusLabel2.Size = size;
			this.lblAction.Text = "Idle";
			this.ProgressBar1.Name = "ProgressBar1";
			System.Windows.Forms.ToolStripProgressBar progressBar = this.ProgressBar1;
			size = new System.Drawing.Size(150, 16);
			progressBar.Size = size;
			this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgressBar1.Visible = false;
			this.lblSpeedMode.Name = "lblSpeedMode";
			System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3 = this.lblSpeedMode;
			size = new System.Drawing.Size(92, 17);
			toolStripStatusLabel3.Size = size;
			this.lblSpeedMode.Text = "Burst Mode OFF";
			this.SerialPort1.BaudRate = 115200;
			this.SerialPort1.ReceivedBytesThreshold = 2;
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			this.Label1.AutoSize = true;
			System.Windows.Forms.Label label = this.Label1;
			location = new System.Drawing.Point(350, 35);
			label.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Label label2 = this.Label1;
			size = new System.Drawing.Size(39, 13);
			label2.Size = size;
			this.Label1.TabIndex = 17;
			this.Label1.Text = "Label1";
			this.Button11.BackColor = System.Drawing.Color.Transparent;
			this.Button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			System.Windows.Forms.Button button = this.Button11;
			location = new System.Drawing.Point(6, 97);
			button.Location = location;
			this.Button11.Name = "Button11";
			System.Windows.Forms.Button button2 = this.Button11;
			size = new System.Drawing.Size(242, 40);
			button2.Size = size;
			this.Button11.TabIndex = 25;
			this.Button11.Text = "Lizard File Serve\r\n(Write or Send a file to Lizard)";
			this.Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button11.UseVisualStyleBackColor = false;
			this.Button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			System.Windows.Forms.Button button3 = this.Button12;
			location = new System.Drawing.Point(404, 223);
			button3.Location = location;
			this.Button12.Name = "Button12";
			System.Windows.Forms.Button button4 = this.Button12;
			size = new System.Drawing.Size(242, 40);
			button4.Size = size;
			this.Button12.TabIndex = 26;
			this.Button12.Text = "Lizard File Get\r\n(Read or Receive a file from Lizard)";
			this.Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button12.UseVisualStyleBackColor = true;
			this.Button12.Visible = false;
			this.Button17.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			System.Windows.Forms.Button button5 = this.Button17;
			location = new System.Drawing.Point(404, 269);
			button5.Location = location;
			this.Button17.Name = "Button17";
			System.Windows.Forms.Button button6 = this.Button17;
			size = new System.Drawing.Size(242, 40);
			button6.Size = size;
			this.Button17.TabIndex = 31;
			this.Button17.Text = "Lizard SNAPSHOT Get\r\n(Read or Receive a Snapshot from Lizard)";
			this.Button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button17.UseVisualStyleBackColor = true;
			this.Button17.Visible = false;
			this.GroupBox1.Controls.Add(this.Button54);
			this.GroupBox1.Controls.Add(this.lblFlashDevID);
			this.GroupBox1.Controls.Add(this.lblName);
			this.GroupBox1.Controls.Add(this.lblOSVer);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Button18);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.lblSerial);
			this.GroupBox1.Controls.Add(this.Label2);
			System.Windows.Forms.GroupBox groupBox = this.GroupBox1;
			location = new System.Drawing.Point(6, 6);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			System.Windows.Forms.GroupBox groupBox2 = this.GroupBox1;
			size = new System.Drawing.Size(646, 85);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 32;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Lizard Details";
			System.Windows.Forms.Button button7 = this.Button54;
			location = new System.Drawing.Point(524, 56);
			button7.Location = location;
			this.Button54.Name = "Button54";
			System.Windows.Forms.Button button8 = this.Button54;
			size = new System.Drawing.Size(114, 23);
			button8.Size = size;
			this.Button54.TabIndex = 22;
			this.Button54.Text = "Find Lizard";
			this.ToolTip1.SetToolTip(this.Button54, "This option will scan all COM ports to find Lizard Device, Make sure Lizard is plugged");
			this.Button54.UseVisualStyleBackColor = true;
			this.lblFlashDevID.AutoSize = true;
			System.Windows.Forms.Label label3 = this.lblFlashDevID;
			location = new System.Drawing.Point(95, 50);
			label3.Location = location;
			this.lblFlashDevID.Name = "lblFlashDevID";
			System.Windows.Forms.Label label4 = this.lblFlashDevID;
			size = new System.Drawing.Size(0, 13);
			label4.Size = size;
			this.lblFlashDevID.TabIndex = 21;
			this.lblName.AutoSize = true;
			System.Windows.Forms.Label label5 = this.lblName;
			location = new System.Drawing.Point(50, 32);
			label5.Location = location;
			this.lblName.Name = "lblName";
			System.Windows.Forms.Label label6 = this.lblName;
			size = new System.Drawing.Size(0, 13);
			label6.Size = size;
			this.lblName.TabIndex = 20;
			this.lblOSVer.AutoSize = true;
			System.Windows.Forms.Label label7 = this.lblOSVer;
			location = new System.Drawing.Point(71, 68);
			label7.Location = location;
			this.lblOSVer.Name = "lblOSVer";
			System.Windows.Forms.Label label8 = this.lblOSVer;
			size = new System.Drawing.Size(0, 13);
			label8.Size = size;
			this.lblOSVer.TabIndex = 18;
			this.Label6.AutoSize = true;
			System.Windows.Forms.Label label9 = this.Label6;
			location = new System.Drawing.Point(6, 67);
			label9.Location = location;
			this.Label6.Name = "Label6";
			System.Windows.Forms.Label label10 = this.Label6;
			size = new System.Drawing.Size(63, 13);
			label10.Size = size;
			this.Label6.TabIndex = 17;
			this.Label6.Text = "OS Version:";
			System.Windows.Forms.Button button9 = this.Button18;
			location = new System.Drawing.Point(399, 56);
			button9.Location = location;
			this.Button18.Name = "Button18";
			System.Windows.Forms.Button button10 = this.Button18;
			size = new System.Drawing.Size(114, 23);
			button10.Size = size;
			this.Button18.TabIndex = 16;
			this.Button18.Text = "Get Device Details";
			this.Button18.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			System.Windows.Forms.Label label11 = this.Label5;
			location = new System.Drawing.Point(6, 50);
			label11.Location = location;
			this.Label5.Name = "Label5";
			System.Windows.Forms.Label label12 = this.Label5;
			size = new System.Drawing.Size(83, 13);
			label12.Size = size;
			this.Label5.TabIndex = 3;
			this.Label5.Text = "On Board Flash:";
			this.Label4.AutoSize = true;
			System.Windows.Forms.Label label13 = this.Label4;
			location = new System.Drawing.Point(6, 33);
			label13.Location = location;
			this.Label4.Name = "Label4";
			System.Windows.Forms.Label label14 = this.Label4;
			size = new System.Drawing.Size(38, 13);
			label14.Size = size;
			this.Label4.TabIndex = 2;
			this.Label4.Text = "Name:";
			this.lblSerial.AutoSize = true;
			System.Windows.Forms.Label label15 = this.lblSerial;
			location = new System.Drawing.Point(48, 16);
			label15.Location = location;
			this.lblSerial.Name = "lblSerial";
			System.Windows.Forms.Label label16 = this.lblSerial;
			size = new System.Drawing.Size(0, 13);
			label16.Size = size;
			this.lblSerial.TabIndex = 1;
			this.Label2.AutoSize = true;
			System.Windows.Forms.Label label17 = this.Label2;
			location = new System.Drawing.Point(6, 16);
			label17.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Label label18 = this.Label2;
			size = new System.Drawing.Size(36, 13);
			label18.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "Serial:";
			this.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Controls.Add(this.TabPage_6);
			this.TabControl1.Controls.Add(this.TabPage6);
			this.TabControl1.Controls.Add(this.TabPage7);
			this.TabControl1.Controls.Add(this.TabPage8);
			this.TabControl1.Controls.Add(this.TabPage_2);
			this.TabControl1.Controls.Add(this.TabPage_5);
			System.Windows.Forms.TabControl tabControl = this.TabControl1;
			location = new System.Drawing.Point(12, 12);
			tabControl.Location = location;
			this.TabControl1.Multiline = true;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			System.Windows.Forms.TabControl tabControl2 = this.TabControl1;
			size = new System.Drawing.Size(681, 445);
			tabControl2.Size = size;
			this.TabControl1.TabIndex = 35;
			this.TabPage2.BackColor = System.Drawing.Color.Transparent;
			this.TabPage2.Controls.Add(this.Button53);
			this.TabPage2.Controls.Add(this.GroupBox_6);
			this.TabPage2.Controls.Add(this.Button43);
			this.TabPage2.Controls.Add(this.Button29);
			this.TabPage2.Controls.Add(this.Button24);
			this.TabPage2.Controls.Add(this.Button20);
			this.TabPage2.Controls.Add(this.Label23);
			this.TabPage2.Controls.Add(this.Button8);
			this.TabPage2.Controls.Add(this.Button4);
			this.TabPage2.Controls.Add(this.GroupBox1);
			this.TabPage2.Controls.Add(this.PictureBox2);
			this.TabPage2.Controls.Add(this.Label1);
			this.TabPage2.Controls.Add(this.Button11);
			this.TabPage2.Controls.Add(this.Button17);
			this.TabPage2.Controls.Add(this.Button12);
			System.Windows.Forms.TabPage tabPage = this.TabPage2;
			location = new System.Drawing.Point(4, 25);
			tabPage.Location = location;
			this.TabPage2.Name = "TabPage2";
			System.Windows.Forms.TabPage tabPage2 = this.TabPage2;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(3);
			tabPage2.Padding = padding;
			System.Windows.Forms.TabPage tabPage3 = this.TabPage2;
			size = new System.Drawing.Size(673, 416);
			tabPage3.Size = size;
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Interface";
			System.Windows.Forms.Button button11 = this.Button53;
			location = new System.Drawing.Point(119, 179);
			button11.Location = location;
			this.Button53.Name = "Button53";
			System.Windows.Forms.Button button12 = this.Button53;
			size = new System.Drawing.Size(75, 23);
			button12.Size = size;
			this.Button53.TabIndex = 50;
			this.Button53.Text = "Test500";
			this.Button53.UseVisualStyleBackColor = true;
			this.Button53.Visible = false;
			this.GroupBox_6.Controls.Add(this.Label41);
			this.GroupBox_6.Controls.Add(this.Button51);
			this.GroupBox_6.Controls.Add(this.Button52);
			System.Windows.Forms.GroupBox groupBox3 = this.GroupBox_6;
			location = new System.Drawing.Point(389, 223);
			groupBox3.Location = location;
			this.GroupBox_6.Name = "GroupBox16";
			System.Windows.Forms.GroupBox groupBox4 = this.GroupBox_6;
			size = new System.Drawing.Size(257, 163);
			groupBox4.Size = size;
			this.GroupBox_6.TabIndex = 49;
			this.GroupBox_6.TabStop = false;
			this.GroupBox_6.Text = "XGD3-Burner (Require Gecko 1.26+)";
			this.GroupBox_6.Visible = false;
			System.Windows.Forms.Label label19 = this.Label41;
			location = new System.Drawing.Point(12, 121);
			label19.Location = location;
			this.Label41.Name = "Label41";
			System.Windows.Forms.Label label20 = this.Label41;
			size = new System.Drawing.Size(237, 39);
			label20.Size = size;
			this.Label41.TabIndex = 49;
			this.Label41.Text = "Use this options to Read/Write to LT+MAX compatible dvd burners (Liteon iHASX24B)";
			this.Button51.BackColor = System.Drawing.Color.Transparent;
			this.Button51.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			System.Windows.Forms.Button button13 = this.Button51;
			location = new System.Drawing.Point(13, 19);
			button13.Location = location;
			this.Button51.Name = "Button51";
			System.Windows.Forms.Button button14 = this.Button51;
			size = new System.Drawing.Size(242, 40);
			button14.Size = size;
			this.Button51.TabIndex = 47;
			this.Button51.Text = "Write or Send a file > 256KB\r\n(XGD3 Burner Firmware)";
			this.Button51.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button51.UseVisualStyleBackColor = false;
			this.Button52.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			System.Windows.Forms.Button button15 = this.Button52;
			location = new System.Drawing.Point(13, 63);
			button15.Location = location;
			this.Button52.Name = "Button52";
			System.Windows.Forms.Button button16 = this.Button52;
			size = new System.Drawing.Size(242, 40);
			button16.Size = size;
			this.Button52.TabIndex = 48;
			this.Button52.Text = "Read or Receive a file > 256KB\r\n(XGD3 Burner Firmware)";
			this.Button52.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button17 = this.Button43;
			location = new System.Drawing.Point(237, 179);
			button17.Location = location;
			this.Button43.Name = "Button43";
			System.Windows.Forms.Button button18 = this.Button43;
			size = new System.Drawing.Size(75, 23);
			button18.Size = size;
			this.Button43.TabIndex = 46;
			this.Button43.Text = "Beep Test";
			this.Button43.UseVisualStyleBackColor = true;
			this.Button43.Visible = false;
			System.Windows.Forms.Button button19 = this.Button29;
			location = new System.Drawing.Point(237, 248);
			button19.Location = location;
			this.Button29.Name = "Button29";
			System.Windows.Forms.Button button20 = this.Button29;
			size = new System.Drawing.Size(75, 23);
			button20.Size = size;
			this.Button29.TabIndex = 44;
			this.Button29.Text = "Key Write";
			this.Button29.UseVisualStyleBackColor = true;
			this.Button29.Visible = false;
			System.Windows.Forms.Button button21 = this.Button24;
			location = new System.Drawing.Point(237, 345);
			button21.Location = location;
			this.Button24.Name = "Button24";
			System.Windows.Forms.Button button22 = this.Button24;
			size = new System.Drawing.Size(75, 23);
			button22.Size = size;
			this.Button24.TabIndex = 43;
			this.Button24.Text = "ForceTurboModeON";
			this.Button24.UseVisualStyleBackColor = true;
			this.Button24.Visible = false;
			System.Windows.Forms.Button button23 = this.Button20;
			location = new System.Drawing.Point(237, 286);
			button23.Location = location;
			this.Button20.Name = "Button20";
			System.Windows.Forms.Button button24 = this.Button20;
			size = new System.Drawing.Size(102, 23);
			button24.Size = size;
			this.Button20.TabIndex = 42;
			this.Button20.Text = "Process Snap";
			this.Button20.UseVisualStyleBackColor = true;
			this.Button20.Visible = false;
			this.Label23.AutoSize = true;
			System.Windows.Forms.Label label21 = this.Label23;
			location = new System.Drawing.Point(402, 144);
			label21.Location = location;
			this.Label23.Name = "Label23";
			System.Windows.Forms.Label label22 = this.Label23;
			size = new System.Drawing.Size(237, 39);
			label22.Size = size;
			this.Label23.TabIndex = 39;
			this.Label23.Text = "Starting from TBX 1.0.10 there is only 1 single\r\nbutton to read files from Lizard, it automatically\r\ndetect if its a SNAPSHOT or its a FULL Firmware";
			this.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			System.Windows.Forms.Button button25 = this.Button8;
			location = new System.Drawing.Point(402, 97);
			button25.Location = location;
			this.Button8.Name = "Button8";
			System.Windows.Forms.Button button26 = this.Button8;
			size = new System.Drawing.Size(242, 40);
			button26.Size = size;
			this.Button8.TabIndex = 38;
			this.Button8.Text = "Lizard File/Snapshot Get\r\n(Receive a File from Lizard)";
			this.Button8.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button27 = this.Button4;
			location = new System.Drawing.Point(237, 315);
			button27.Location = location;
			this.Button4.Name = "Button4";
			System.Windows.Forms.Button button28 = this.Button4;
			size = new System.Drawing.Size(75, 23);
			button28.Size = size;
			this.Button4.TabIndex = 35;
			this.Button4.Text = "Button4";
			this.Button4.UseVisualStyleBackColor = true;
			this.Button4.Visible = false;
			this.PictureBox2.BackColor = System.Drawing.SystemColors.Control;
			this.PictureBox2.Image = (System.Drawing.Image)resources.GetObject("PictureBox2.Image");
			System.Windows.Forms.PictureBox pictureBox = this.PictureBox2;
			location = new System.Drawing.Point(15, 248);
			pictureBox.Location = location;
			this.PictureBox2.Name = "PictureBox2";
			System.Windows.Forms.PictureBox pictureBox2 = this.PictureBox2;
			size = new System.Drawing.Size(160, 61);
			pictureBox2.Size = size;
			this.PictureBox2.TabIndex = 34;
			this.PictureBox2.TabStop = false;
			this.TabPage3.BackColor = System.Drawing.Color.Transparent;
			this.TabPage3.Controls.Add(this.TabControl2);
			System.Windows.Forms.TabPage tabPage4 = this.TabPage3;
			location = new System.Drawing.Point(4, 25);
			tabPage4.Location = location;
			this.TabPage3.Name = "TabPage3";
			System.Windows.Forms.TabPage tabPage5 = this.TabPage3;
			size = new System.Drawing.Size(673, 416);
			tabPage5.Size = size;
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "CFW Generator";
			this.TabControl2.Controls.Add(this.TabPage1);
			this.TabControl2.Controls.Add(this.TabPage4);
			System.Windows.Forms.TabControl tabControl3 = this.TabControl2;
			location = new System.Drawing.Point(3, 3);
			tabControl3.Location = location;
			this.TabControl2.Name = "TabControl2";
			this.TabControl2.SelectedIndex = 0;
			System.Windows.Forms.TabControl tabControl4 = this.TabControl2;
			size = new System.Drawing.Size(641, 410);
			tabControl4.Size = size;
			this.TabControl2.TabIndex = 2;
			this.TabPage1.BackColor = System.Drawing.Color.Transparent;
			this.TabPage1.Controls.Add(this.GroupBox5);
			this.TabPage1.Controls.Add(this.GroupBox4);
			System.Windows.Forms.TabPage tabPage6 = this.TabPage1;
			location = new System.Drawing.Point(4, 22);
			tabPage6.Location = location;
			this.TabPage1.Name = "TabPage1";
			System.Windows.Forms.TabPage tabPage7 = this.TabPage1;
			padding = new System.Windows.Forms.Padding(3);
			tabPage7.Padding = padding;
			System.Windows.Forms.TabPage tabPage8 = this.TabPage1;
			size = new System.Drawing.Size(633, 384);
			tabPage8.Size = size;
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Easy View";
			this.GroupBox5.Controls.Add(this.Label22);
			this.GroupBox5.Controls.Add(this.Label15);
			this.GroupBox5.Controls.Add(this.Label20);
			this.GroupBox5.Controls.Add(this.btnEV_CFWSaveAs);
			this.GroupBox5.Controls.Add(this.Label18);
			this.GroupBox5.Controls.Add(this.cmbEV_DstCFWTemplate);
			System.Windows.Forms.GroupBox groupBox5 = this.GroupBox5;
			location = new System.Drawing.Point(6, 119);
			groupBox5.Location = location;
			this.GroupBox5.Name = "GroupBox5";
			System.Windows.Forms.GroupBox groupBox6 = this.GroupBox5;
			size = new System.Drawing.Size(620, 165);
			groupBox6.Size = size;
			this.GroupBox5.TabIndex = 2;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Destination / Target Firmware";
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = System.Drawing.Color.Blue;
			System.Windows.Forms.Label label23 = this.Label22;
			location = new System.Drawing.Point(586, 22);
			label23.Location = location;
			this.Label22.Name = "Label22";
			System.Windows.Forms.Label label24 = this.Label22;
			size = new System.Drawing.Size(27, 13);
			label24.Size = size;
			this.Label22.TabIndex = 23;
			this.Label22.Text = "Split";
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.Color.Blue;
			System.Windows.Forms.Label label25 = this.Label15;
			location = new System.Drawing.Point(450, 22);
			label25.Location = location;
			this.Label15.Name = "Label15";
			System.Windows.Forms.Label label26 = this.Label15;
			size = new System.Drawing.Size(93, 13);
			label26.Size = size;
			this.Label15.TabIndex = 22;
			this.Label15.Text = "Download Filesets";
			this.Label20.AutoSize = true;
			System.Windows.Forms.Label label27 = this.Label20;
			location = new System.Drawing.Point(10, 52);
			label27.Location = location;
			this.Label20.Name = "Label20";
			System.Windows.Forms.Label label28 = this.Label20;
			size = new System.Drawing.Size(572, 39);
			label28.Size = size;
			this.Label20.TabIndex = 20;
			this.Label20.Text = resources.GetString("Label20.Text");
			System.Windows.Forms.Button button29 = this.btnEV_CFWSaveAs;
			location = new System.Drawing.Point(501, 127);
			button29.Location = location;
			this.btnEV_CFWSaveAs.Name = "btnEV_CFWSaveAs";
			System.Windows.Forms.Button button30 = this.btnEV_CFWSaveAs;
			size = new System.Drawing.Size(113, 23);
			button30.Size = size;
			this.btnEV_CFWSaveAs.TabIndex = 19;
			this.btnEV_CFWSaveAs.Text = "CFW Save as...";
			this.ToolTip1.SetToolTip(this.btnEV_CFWSaveAs, "Generate Custom Firmware and save to the location you specify");
			this.btnEV_CFWSaveAs.UseVisualStyleBackColor = true;
			this.Label18.AutoSize = true;
			System.Windows.Forms.Label label29 = this.Label18;
			location = new System.Drawing.Point(7, 22);
			label29.Location = location;
			this.Label18.Name = "Label18";
			System.Windows.Forms.Label label30 = this.Label18;
			size = new System.Drawing.Size(114, 13);
			label30.Size = size;
			this.Label18.TabIndex = 18;
			this.Label18.Text = "CFW Fileset Template:";
			this.cmbEV_DstCFWTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEV_DstCFWTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbEV_DstCFWTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbEV_DstCFWTemplate.FormattingEnabled = true;
			System.Windows.Forms.ComboBox comboBox = this.cmbEV_DstCFWTemplate;
			location = new System.Drawing.Point(127, 19);
			comboBox.Location = location;
			this.cmbEV_DstCFWTemplate.Name = "cmbEV_DstCFWTemplate";
			System.Windows.Forms.ComboBox comboBox2 = this.cmbEV_DstCFWTemplate;
			size = new System.Drawing.Size(317, 21);
			comboBox2.Size = size;
			this.cmbEV_DstCFWTemplate.TabIndex = 17;
			this.ToolTip1.SetToolTip(this.cmbEV_DstCFWTemplate, "The drive type that the console \"see\" (Aka spoofed)");
			this.GroupBox4.Controls.Add(this.Button67);
			this.GroupBox4.Controls.Add(this.txbEV_SrcKey);
			this.GroupBox4.Controls.Add(this.txbEV_SrcFwInfo);
			this.GroupBox4.Controls.Add(this.txbEV_SrcFile);
			this.GroupBox4.Controls.Add(this.Label16);
			this.GroupBox4.Controls.Add(this.btnEV_LoadSrcFw);
			this.GroupBox4.Controls.Add(this.Label17);
			this.GroupBox4.Controls.Add(this.Label19);
			System.Windows.Forms.GroupBox groupBox7 = this.GroupBox4;
			location = new System.Drawing.Point(6, 6);
			groupBox7.Location = location;
			this.GroupBox4.Name = "GroupBox4";
			System.Windows.Forms.GroupBox groupBox8 = this.GroupBox4;
			size = new System.Drawing.Size(620, 107);
			groupBox8.Size = size;
			this.GroupBox4.TabIndex = 1;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Source / Base Firmware:";
			System.Windows.Forms.Button button31 = this.Button67;
			location = new System.Drawing.Point(404, 69);
			button31.Location = location;
			this.Button67.Name = "Button67";
			System.Windows.Forms.Button button32 = this.Button67;
			size = new System.Drawing.Size(86, 20);
			button32.Size = size;
			this.Button67.TabIndex = 14;
			this.Button67.Text = "Verify";
			this.Button67.UseVisualStyleBackColor = true;
			this.txbEV_SrcKey.BackColor = System.Drawing.SystemColors.Control;
			this.txbEV_SrcKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbEV_SrcKey.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.TextBox textBox = this.txbEV_SrcKey;
			location = new System.Drawing.Point(90, 69);
			textBox.Location = location;
			this.txbEV_SrcKey.Name = "txbEV_SrcKey";
			this.txbEV_SrcKey.ReadOnly = true;
			System.Windows.Forms.TextBox textBox2 = this.txbEV_SrcKey;
			size = new System.Drawing.Size(308, 20);
			textBox2.Size = size;
			this.txbEV_SrcKey.TabIndex = 13;
			this.txbEV_SrcFwInfo.BackColor = System.Drawing.SystemColors.Control;
			this.txbEV_SrcFwInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.TextBox textBox3 = this.txbEV_SrcFwInfo;
			location = new System.Drawing.Point(90, 43);
			textBox3.Location = location;
			this.txbEV_SrcFwInfo.Name = "txbEV_SrcFwInfo";
			this.txbEV_SrcFwInfo.ReadOnly = true;
			System.Windows.Forms.TextBox textBox4 = this.txbEV_SrcFwInfo;
			size = new System.Drawing.Size(400, 20);
			textBox4.Size = size;
			this.txbEV_SrcFwInfo.TabIndex = 12;
			this.txbEV_SrcFile.BackColor = System.Drawing.SystemColors.Window;
			this.txbEV_SrcFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.TextBox textBox5 = this.txbEV_SrcFile;
			location = new System.Drawing.Point(90, 17);
			textBox5.Location = location;
			this.txbEV_SrcFile.Name = "txbEV_SrcFile";
			this.txbEV_SrcFile.ReadOnly = true;
			System.Windows.Forms.TextBox textBox6 = this.txbEV_SrcFile;
			size = new System.Drawing.Size(400, 20);
			textBox6.Size = size;
			this.txbEV_SrcFile.TabIndex = 11;
			this.Label16.AutoSize = true;
			System.Windows.Forms.Label label31 = this.Label16;
			location = new System.Drawing.Point(7, 20);
			label31.Location = location;
			this.Label16.Name = "Label16";
			System.Windows.Forms.Label label32 = this.Label16;
			size = new System.Drawing.Size(70, 13);
			label32.Size = size;
			this.Label16.TabIndex = 10;
			this.Label16.Text = "File Location:";
			System.Windows.Forms.Button button33 = this.btnEV_LoadSrcFw;
			location = new System.Drawing.Point(496, 15);
			button33.Location = location;
			this.btnEV_LoadSrcFw.Name = "btnEV_LoadSrcFw";
			System.Windows.Forms.Button button34 = this.btnEV_LoadSrcFw;
			size = new System.Drawing.Size(117, 23);
			button34.Size = size;
			this.btnEV_LoadSrcFw.TabIndex = 8;
			this.btnEV_LoadSrcFw.Text = "Load FW";
			this.ToolTip1.SetToolTip(this.btnEV_LoadSrcFw, "Opens a Firmware or Snapshot-dummy File");
			this.btnEV_LoadSrcFw.UseVisualStyleBackColor = true;
			this.Label17.AutoSize = true;
			System.Windows.Forms.Label label33 = this.Label17;
			location = new System.Drawing.Point(7, 71);
			label33.Location = location;
			this.Label17.Name = "Label17";
			System.Windows.Forms.Label label34 = this.Label17;
			size = new System.Drawing.Size(28, 13);
			label34.Size = size;
			this.Label17.TabIndex = 4;
			this.Label17.Text = "Key:";
			this.Label19.AutoSize = true;
			System.Windows.Forms.Label label35 = this.Label19;
			location = new System.Drawing.Point(6, 45);
			label35.Location = location;
			this.Label19.Name = "Label19";
			System.Windows.Forms.Label label36 = this.Label19;
			size = new System.Drawing.Size(79, 13);
			label36.Size = size;
			this.Label19.TabIndex = 0;
			this.Label19.Text = "Fw Information:";
			this.TabPage4.BackColor = System.Drawing.Color.Transparent;
			this.TabPage4.Controls.Add(this.GroupBox2);
			this.TabPage4.Controls.Add(this.GroupBox3);
			this.TabPage4.Controls.Add(this.Button2);
			System.Windows.Forms.TabPage tabPage9 = this.TabPage4;
			location = new System.Drawing.Point(4, 22);
			tabPage9.Location = location;
			this.TabPage4.Name = "TabPage4";
			System.Windows.Forms.TabPage tabPage10 = this.TabPage4;
			padding = new System.Windows.Forms.Padding(3);
			tabPage10.Padding = padding;
			System.Windows.Forms.TabPage tabPage11 = this.TabPage4;
			size = new System.Drawing.Size(633, 384);
			tabPage11.Size = size;
			this.TabPage4.TabIndex = 1;
			this.TabPage4.Text = "Advanced View";
			this.GroupBox2.Controls.Add(this.txbAV_SrcLogDrive);
			this.GroupBox2.Controls.Add(this.txbAV_SrcPhyDrive);
			this.GroupBox2.Controls.Add(this.Label21);
			this.GroupBox2.Controls.Add(this.txbAV_SrcFile);
			this.GroupBox2.Controls.Add(this.lblSrcSpoof);
			this.GroupBox2.Controls.Add(this.Button1);
			this.GroupBox2.Controls.Add(this.txbAV_SrcDVDSer);
			this.GroupBox2.Controls.Add(this.Label9);
			this.GroupBox2.Controls.Add(this.txbAV_SrcKey);
			this.GroupBox2.Controls.Add(this.Label8);
			this.GroupBox2.Controls.Add(this.Label7);
			this.GroupBox2.Controls.Add(this.Label3);
			System.Windows.Forms.GroupBox groupBox9 = this.GroupBox2;
			location = new System.Drawing.Point(6, 6);
			groupBox9.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			System.Windows.Forms.GroupBox groupBox10 = this.GroupBox2;
			size = new System.Drawing.Size(620, 157);
			groupBox10.Size = size;
			this.GroupBox2.TabIndex = 0;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Source / Base Firmware:";
			this.txbAV_SrcLogDrive.BackColor = System.Drawing.SystemColors.Control;
			this.txbAV_SrcLogDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.TextBox textBox7 = this.txbAV_SrcLogDrive;
			location = new System.Drawing.Point(91, 70);
			textBox7.Location = location;
			this.txbAV_SrcLogDrive.Name = "txbAV_SrcLogDrive";
			this.txbAV_SrcLogDrive.ReadOnly = true;
			System.Windows.Forms.TextBox textBox8 = this.txbAV_SrcLogDrive;
			size = new System.Drawing.Size(400, 20);
			textBox8.Size = size;
			this.txbAV_SrcLogDrive.TabIndex = 15;
			this.txbAV_SrcPhyDrive.BackColor = System.Drawing.SystemColors.Control;
			this.txbAV_SrcPhyDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.TextBox textBox9 = this.txbAV_SrcPhyDrive;
			location = new System.Drawing.Point(91, 43);
			textBox9.Location = location;
			this.txbAV_SrcPhyDrive.Name = "txbAV_SrcPhyDrive";
			this.txbAV_SrcPhyDrive.ReadOnly = true;
			System.Windows.Forms.TextBox textBox10 = this.txbAV_SrcPhyDrive;
			size = new System.Drawing.Size(400, 20);
			textBox10.Size = size;
			this.txbAV_SrcPhyDrive.TabIndex = 14;
			this.Label21.AutoSize = true;
			System.Windows.Forms.Label label37 = this.Label21;
			location = new System.Drawing.Point(7, 20);
			label37.Location = location;
			this.Label21.Name = "Label21";
			System.Windows.Forms.Label label38 = this.Label21;
			size = new System.Drawing.Size(70, 13);
			label38.Size = size;
			this.Label21.TabIndex = 13;
			this.Label21.Text = "File Location:";
			this.txbAV_SrcFile.BackColor = System.Drawing.SystemColors.Window;
			this.txbAV_SrcFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.TextBox textBox11 = this.txbAV_SrcFile;
			location = new System.Drawing.Point(90, 17);
			textBox11.Location = location;
			this.txbAV_SrcFile.Name = "txbAV_SrcFile";
			this.txbAV_SrcFile.ReadOnly = true;
			System.Windows.Forms.TextBox textBox12 = this.txbAV_SrcFile;
			size = new System.Drawing.Size(400, 20);
			textBox12.Size = size;
			this.txbAV_SrcFile.TabIndex = 12;
			this.lblSrcSpoof.AutoSize = true;
			this.lblSrcSpoof.ForeColor = System.Drawing.Color.Red;
			System.Windows.Forms.Label label39 = this.lblSrcSpoof;
			location = new System.Drawing.Point(498, 72);
			label39.Location = location;
			this.lblSrcSpoof.Name = "lblSrcSpoof";
			System.Windows.Forms.Label label40 = this.lblSrcSpoof;
			size = new System.Drawing.Size(58, 13);
			label40.Size = size;
			this.lblSrcSpoof.TabIndex = 9;
			this.lblSrcSpoof.Text = "SPOOFED";
			this.lblSrcSpoof.Visible = false;
			System.Windows.Forms.Button button35 = this.Button1;
			location = new System.Drawing.Point(497, 16);
			button35.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Button button36 = this.Button1;
			size = new System.Drawing.Size(117, 23);
			button36.Size = size;
			this.Button1.TabIndex = 8;
			this.Button1.Text = "Load FW";
			this.Button1.UseVisualStyleBackColor = true;
			this.txbAV_SrcDVDSer.BackColor = System.Drawing.SystemColors.Control;
			this.txbAV_SrcDVDSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbAV_SrcDVDSer.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.TextBox textBox13 = this.txbAV_SrcDVDSer;
			location = new System.Drawing.Point(91, 122);
			textBox13.Location = location;
			this.txbAV_SrcDVDSer.Name = "txbAV_SrcDVDSer";
			this.txbAV_SrcDVDSer.ReadOnly = true;
			System.Windows.Forms.TextBox textBox14 = this.txbAV_SrcDVDSer;
			size = new System.Drawing.Size(262, 20);
			textBox14.Size = size;
			this.txbAV_SrcDVDSer.TabIndex = 7;
			this.Label9.AutoSize = true;
			System.Windows.Forms.Label label41 = this.Label9;
			location = new System.Drawing.Point(7, 128);
			label41.Location = location;
			this.Label9.Name = "Label9";
			System.Windows.Forms.Label label42 = this.Label9;
			size = new System.Drawing.Size(62, 13);
			label42.Size = size;
			this.Label9.TabIndex = 6;
			this.Label9.Text = "DVD Serial:";
			this.txbAV_SrcKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbAV_SrcKey.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.TextBox textBox15 = this.txbAV_SrcKey;
			location = new System.Drawing.Point(91, 96);
			textBox15.Location = location;
			this.txbAV_SrcKey.MaxLength = 32;
			this.txbAV_SrcKey.Name = "txbAV_SrcKey";
			this.txbAV_SrcKey.ReadOnly = true;
			System.Windows.Forms.TextBox textBox16 = this.txbAV_SrcKey;
			size = new System.Drawing.Size(262, 20);
			textBox16.Size = size;
			this.txbAV_SrcKey.TabIndex = 5;
			this.Label8.AutoSize = true;
			System.Windows.Forms.Label label43 = this.Label8;
			location = new System.Drawing.Point(7, 101);
			label43.Location = location;
			this.Label8.Name = "Label8";
			System.Windows.Forms.Label label44 = this.Label8;
			size = new System.Drawing.Size(28, 13);
			label44.Size = size;
			this.Label8.TabIndex = 4;
			this.Label8.Text = "Key:";
			this.Label7.AutoSize = true;
			System.Windows.Forms.Label label45 = this.Label7;
			location = new System.Drawing.Point(7, 74);
			label45.Location = location;
			this.Label7.Name = "Label7";
			System.Windows.Forms.Label label46 = this.Label7;
			size = new System.Drawing.Size(72, 13);
			label46.Size = size;
			this.Label7.TabIndex = 2;
			this.Label7.Text = "Logical Drive:";
			this.Label3.AutoSize = true;
			System.Windows.Forms.Label label47 = this.Label3;
			location = new System.Drawing.Point(7, 46);
			label47.Location = location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Label label48 = this.Label3;
			size = new System.Drawing.Size(77, 13);
			label48.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "Physical Drive:";
			this.GroupBox3.Controls.Add(this.btn_editDstLogDrive);
			this.GroupBox3.Controls.Add(this.btn_editDstSer);
			this.GroupBox3.Controls.Add(this.txbAV_DstPhyDrive);
			this.GroupBox3.Controls.Add(this.Button5);
			this.GroupBox3.Controls.Add(this.Label14);
			this.GroupBox3.Controls.Add(this.txbAV_DstFile);
			this.GroupBox3.Controls.Add(this.btn_editDstKey);
			this.GroupBox3.Controls.Add(this.Button3);
			this.GroupBox3.Controls.Add(this.lblDestSpoof);
			this.GroupBox3.Controls.Add(this.txbAV_DstDVDSer);
			this.GroupBox3.Controls.Add(this.txbAV_DstKey);
			this.GroupBox3.Controls.Add(this.cmbAV_DstLogDrive);
			this.GroupBox3.Controls.Add(this.Label10);
			this.GroupBox3.Controls.Add(this.Label11);
			this.GroupBox3.Controls.Add(this.Label12);
			this.GroupBox3.Controls.Add(this.Label13);
			System.Windows.Forms.GroupBox groupBox11 = this.GroupBox3;
			location = new System.Drawing.Point(6, 228);
			groupBox11.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			System.Windows.Forms.GroupBox groupBox12 = this.GroupBox3;
			size = new System.Drawing.Size(620, 156);
			groupBox12.Size = size;
			this.GroupBox3.TabIndex = 1;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Destination / Target Firmware";
			System.Windows.Forms.Button button37 = this.btn_editDstLogDrive;
			location = new System.Drawing.Point(464, 69);
			button37.Location = location;
			this.btn_editDstLogDrive.Name = "btn_editDstLogDrive";
			System.Windows.Forms.Button button38 = this.btn_editDstLogDrive;
			size = new System.Drawing.Size(26, 23);
			button38.Size = size;
			this.btn_editDstLogDrive.TabIndex = 26;
			this.btn_editDstLogDrive.Text = "...";
			this.btn_editDstLogDrive.UseVisualStyleBackColor = true;
			this.btn_editDstSer.Enabled = false;
			System.Windows.Forms.Button button39 = this.btn_editDstSer;
			location = new System.Drawing.Point(357, 122);
			button39.Location = location;
			this.btn_editDstSer.Name = "btn_editDstSer";
			System.Windows.Forms.Button button40 = this.btn_editDstSer;
			size = new System.Drawing.Size(26, 23);
			button40.Size = size;
			this.btn_editDstSer.TabIndex = 25;
			this.btn_editDstSer.Text = "...";
			this.btn_editDstSer.UseVisualStyleBackColor = true;
			this.txbAV_DstPhyDrive.BackColor = System.Drawing.SystemColors.Control;
			this.txbAV_DstPhyDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.TextBox textBox17 = this.txbAV_DstPhyDrive;
			location = new System.Drawing.Point(90, 43);
			textBox17.Location = location;
			this.txbAV_DstPhyDrive.Name = "txbAV_DstPhyDrive";
			this.txbAV_DstPhyDrive.ReadOnly = true;
			System.Windows.Forms.TextBox textBox18 = this.txbAV_DstPhyDrive;
			size = new System.Drawing.Size(400, 20);
			textBox18.Size = size;
			this.txbAV_DstPhyDrive.TabIndex = 24;
			System.Windows.Forms.Button button41 = this.Button5;
			location = new System.Drawing.Point(497, 16);
			button41.Location = location;
			this.Button5.Name = "Button5";
			System.Windows.Forms.Button button42 = this.Button5;
			size = new System.Drawing.Size(117, 23);
			button42.Size = size;
			this.Button5.TabIndex = 23;
			this.Button5.Text = "Load FW";
			this.Button5.UseVisualStyleBackColor = true;
			this.Label14.AutoSize = true;
			System.Windows.Forms.Label label49 = this.Label14;
			location = new System.Drawing.Point(7, 20);
			label49.Location = location;
			this.Label14.Name = "Label14";
			System.Windows.Forms.Label label50 = this.Label14;
			size = new System.Drawing.Size(70, 13);
			label50.Size = size;
			this.Label14.TabIndex = 22;
			this.Label14.Text = "File Location:";
			this.txbAV_DstFile.BackColor = System.Drawing.SystemColors.Window;
			this.txbAV_DstFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.TextBox textBox19 = this.txbAV_DstFile;
			location = new System.Drawing.Point(90, 17);
			textBox19.Location = location;
			this.txbAV_DstFile.Name = "txbAV_DstFile";
			this.txbAV_DstFile.ReadOnly = true;
			System.Windows.Forms.TextBox textBox20 = this.txbAV_DstFile;
			size = new System.Drawing.Size(400, 20);
			textBox20.Size = size;
			this.txbAV_DstFile.TabIndex = 21;
			System.Windows.Forms.Button button43 = this.btn_editDstKey;
			location = new System.Drawing.Point(357, 97);
			button43.Location = location;
			this.btn_editDstKey.Name = "btn_editDstKey";
			System.Windows.Forms.Button button44 = this.btn_editDstKey;
			size = new System.Drawing.Size(26, 23);
			button44.Size = size;
			this.btn_editDstKey.TabIndex = 20;
			this.btn_editDstKey.Text = "...";
			this.btn_editDstKey.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button45 = this.Button3;
			location = new System.Drawing.Point(497, 122);
			button45.Location = location;
			this.Button3.Name = "Button3";
			System.Windows.Forms.Button button46 = this.Button3;
			size = new System.Drawing.Size(113, 23);
			button46.Size = size;
			this.Button3.TabIndex = 19;
			this.Button3.Text = "CFW Save as...";
			this.ToolTip1.SetToolTip(this.Button3, "Generate a Custom FW and save to the location you specify");
			this.Button3.UseVisualStyleBackColor = true;
			this.lblDestSpoof.AutoSize = true;
			this.lblDestSpoof.ForeColor = System.Drawing.Color.Red;
			System.Windows.Forms.Label label51 = this.lblDestSpoof;
			location = new System.Drawing.Point(498, 74);
			label51.Location = location;
			this.lblDestSpoof.Name = "lblDestSpoof";
			System.Windows.Forms.Label label52 = this.lblDestSpoof;
			size = new System.Drawing.Size(58, 13);
			label52.Size = size;
			this.lblDestSpoof.TabIndex = 16;
			this.lblDestSpoof.Text = "SPOOFED";
			this.lblDestSpoof.Visible = false;
			this.txbAV_DstDVDSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbAV_DstDVDSer.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.TextBox textBox21 = this.txbAV_DstDVDSer;
			location = new System.Drawing.Point(89, 125);
			textBox21.Location = location;
			this.txbAV_DstDVDSer.MaxLength = 20;
			this.txbAV_DstDVDSer.Name = "txbAV_DstDVDSer";
			this.txbAV_DstDVDSer.ReadOnly = true;
			System.Windows.Forms.TextBox textBox22 = this.txbAV_DstDVDSer;
			size = new System.Drawing.Size(262, 20);
			textBox22.Size = size;
			this.txbAV_DstDVDSer.TabIndex = 14;
			this.txbAV_DstKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbAV_DstKey.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.TextBox textBox23 = this.txbAV_DstKey;
			location = new System.Drawing.Point(89, 99);
			textBox23.Location = location;
			this.txbAV_DstKey.MaxLength = 32;
			this.txbAV_DstKey.Name = "txbAV_DstKey";
			this.txbAV_DstKey.ReadOnly = true;
			System.Windows.Forms.TextBox textBox24 = this.txbAV_DstKey;
			size = new System.Drawing.Size(262, 20);
			textBox24.Size = size;
			this.txbAV_DstKey.TabIndex = 13;
			this.cmbAV_DstLogDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAV_DstLogDrive.Enabled = false;
			this.cmbAV_DstLogDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbAV_DstLogDrive.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbAV_DstLogDrive.FormattingEnabled = true;
			System.Windows.Forms.ComboBox comboBox3 = this.cmbAV_DstLogDrive;
			location = new System.Drawing.Point(90, 71);
			comboBox3.Location = location;
			this.cmbAV_DstLogDrive.Name = "cmbAV_DstLogDrive";
			System.Windows.Forms.ComboBox comboBox4 = this.cmbAV_DstLogDrive;
			size = new System.Drawing.Size(368, 22);
			comboBox4.Size = size;
			this.cmbAV_DstLogDrive.TabIndex = 12;
			this.ToolTip1.SetToolTip(this.cmbAV_DstLogDrive, "The drive type that the console \"see\" (Aka spoofed)");
			this.Label10.AutoSize = true;
			System.Windows.Forms.Label label53 = this.Label10;
			location = new System.Drawing.Point(7, 128);
			label53.Location = location;
			this.Label10.Name = "Label10";
			System.Windows.Forms.Label label54 = this.Label10;
			size = new System.Drawing.Size(62, 13);
			label54.Size = size;
			this.Label10.TabIndex = 10;
			this.Label10.Text = "DVD Serial:";
			this.Label11.AutoSize = true;
			System.Windows.Forms.Label label55 = this.Label11;
			location = new System.Drawing.Point(7, 99);
			label55.Location = location;
			this.Label11.Name = "Label11";
			System.Windows.Forms.Label label56 = this.Label11;
			size = new System.Drawing.Size(28, 13);
			label56.Size = size;
			this.Label11.TabIndex = 9;
			this.Label11.Text = "Key:";
			this.Label12.AutoSize = true;
			System.Windows.Forms.Label label57 = this.Label12;
			location = new System.Drawing.Point(7, 74);
			label57.Location = location;
			this.Label12.Name = "Label12";
			System.Windows.Forms.Label label58 = this.Label12;
			size = new System.Drawing.Size(72, 13);
			label58.Size = size;
			this.Label12.TabIndex = 8;
			this.Label12.Text = "Logical Drive:";
			this.Label13.AutoSize = true;
			System.Windows.Forms.Label label59 = this.Label13;
			location = new System.Drawing.Point(7, 46);
			label59.Location = location;
			this.Label13.Name = "Label13";
			System.Windows.Forms.Label label60 = this.Label13;
			size = new System.Drawing.Size(77, 13);
			label60.Size = size;
			this.Label13.TabIndex = 7;
			this.Label13.Text = "Physical Drive:";
			System.Windows.Forms.Button button47 = this.Button2;
			location = new System.Drawing.Point(505, 169);
			button47.Location = location;
			this.Button2.Name = "Button2";
			System.Windows.Forms.Button button48 = this.Button2;
			size = new System.Drawing.Size(115, 53);
			button48.Size = size;
			this.Button2.TabIndex = 15;
			this.Button2.Text = "Copy data from Source to Destination (SPOOF)";
			this.Button2.UseVisualStyleBackColor = true;
			this.TabPage_6.BackColor = System.Drawing.Color.Transparent;
			this.TabPage_6.Controls.Add(this.TabControl5);
			System.Windows.Forms.TabPage tabPage12 = this.TabPage_6;
			location = new System.Drawing.Point(4, 25);
			tabPage12.Location = location;
			this.TabPage_6.Name = "TabPage16";
			System.Windows.Forms.TabPage tabPage13 = this.TabPage_6;
			padding = new System.Windows.Forms.Padding(3);
			tabPage13.Padding = padding;
			System.Windows.Forms.TabPage tabPage14 = this.TabPage_6;
			size = new System.Drawing.Size(673, 416);
			tabPage14.Size = size;
			this.TabPage_6.TabIndex = 9;
			this.TabPage_6.Text = "LTU Generator";
			this.TabControl5.Controls.Add(this.TabPage_7);
			this.TabControl5.Controls.Add(this.TabPage_8);
			System.Windows.Forms.TabControl tabControl5 = this.TabControl5;
			location = new System.Drawing.Point(5, 3);
			tabControl5.Location = location;
			this.TabControl5.Name = "TabControl5";
			this.TabControl5.SelectedIndex = 0;
			System.Windows.Forms.TabControl tabControl6 = this.TabControl5;
			size = new System.Drawing.Size(662, 407);
			tabControl6.Size = size;
			this.TabControl5.TabIndex = 27;
			this.TabPage_7.BackColor = System.Drawing.SystemColors.Control;
			this.TabPage_7.Controls.Add(this.Label62);
			this.TabPage_7.Controls.Add(this.cmbLTU2Template);
			this.TabPage_7.Controls.Add(this.Label61);
			this.TabPage_7.Controls.Add(this.TxbLTU2_key);
			this.TabPage_7.Controls.Add(this.Label55);
			this.TabPage_7.Controls.Add(this.TxbLTU2_cr);
			this.TabPage_7.Controls.Add(this.Button69);
			this.TabPage_7.Controls.Add(this.cmbLTU2Fileset);
			this.TabPage_7.Controls.Add(this.Label56);
			this.TabPage_7.Controls.Add(this.Label57);
			this.TabPage_7.Controls.Add(this.Button70);
			this.TabPage_7.Controls.Add(this.Label58);
			this.TabPage_7.Controls.Add(this.Button71);
			this.TabPage_7.Controls.Add(this.Label59);
			this.TabPage_7.Controls.Add(this.Button59);
			this.TabPage_7.Controls.Add(this.Button68);
			this.TabPage_7.Controls.Add(this.Button60);
			this.TabPage_7.Controls.Add(this.Button66);
			this.TabPage_7.Controls.Add(this.Button61);
			this.TabPage_7.Controls.Add(this.Button30);
			this.TabPage_7.Controls.Add(this.Button65);
			this.TabPage_7.Controls.Add(this.Button62);
			this.TabPage_7.Controls.Add(this.Button64);
			this.TabPage_7.Controls.Add(this.Button63);
			System.Windows.Forms.TabPage tabPage15 = this.TabPage_7;
			location = new System.Drawing.Point(4, 22);
			tabPage15.Location = location;
			this.TabPage_7.Name = "TabPage17";
			System.Windows.Forms.TabPage tabPage16 = this.TabPage_7;
			padding = new System.Windows.Forms.Padding(3);
			tabPage16.Padding = padding;
			System.Windows.Forms.TabPage tabPage17 = this.TabPage_7;
			size = new System.Drawing.Size(654, 381);
			tabPage17.Size = size;
			this.TabPage_7.TabIndex = 0;
			this.TabPage_7.Text = "LTU for V2 Board (MT1319E)";
			this.Label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label62.ForeColor = System.Drawing.Color.Red;
			System.Windows.Forms.Label label61 = this.Label62;
			location = new System.Drawing.Point(6, 272);
			label61.Location = location;
			this.Label62.Name = "Label62";
			System.Windows.Forms.Label label62 = this.Label62;
			size = new System.Drawing.Size(642, 106);
			label62.Size = size;
			this.Label62.TabIndex = 40;
			this.Label62.Text = resources.GetString("Label62.Text");
			this.cmbLTU2Template.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLTU2Template.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbLTU2Template.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbLTU2Template.FormattingEnabled = true;
			System.Windows.Forms.ComboBox comboBox5 = this.cmbLTU2Template;
			location = new System.Drawing.Point(113, 117);
			comboBox5.Location = location;
			this.cmbLTU2Template.Name = "cmbLTU2Template";
			System.Windows.Forms.ComboBox comboBox6 = this.cmbLTU2Template;
			size = new System.Drawing.Size(484, 21);
			comboBox6.Size = size;
			this.cmbLTU2Template.TabIndex = 39;
			this.ToolTip1.SetToolTip(this.cmbLTU2Template, "Select the Base File (must match your original drive Model-Rom)");
			this.Label61.AutoSize = true;
			System.Windows.Forms.Label label63 = this.Label61;
			location = new System.Drawing.Point(36, 120);
			label63.Location = location;
			this.Label61.Name = "Label61";
			System.Windows.Forms.Label label64 = this.Label61;
			size = new System.Drawing.Size(54, 13);
			label64.Size = size;
			this.Label61.TabIndex = 38;
			this.Label61.Text = "Template:";
			System.Windows.Forms.TextBox txbLTU2_key = this.TxbLTU2_key;
			location = new System.Drawing.Point(113, 7);
			txbLTU2_key.Location = location;
			this.TxbLTU2_key.Name = "TxbLTU2_key";
			this.TxbLTU2_key.ReadOnly = true;
			System.Windows.Forms.TextBox txbLTU2_key2 = this.TxbLTU2_key;
			size = new System.Drawing.Size(452, 20);
			txbLTU2_key2.Size = size;
			this.TxbLTU2_key.TabIndex = 33;
			this.TxbLTU2_key.Text = "[REQUIRED]";
			this.Label55.AutoSize = true;
			System.Windows.Forms.Label label65 = this.Label55;
			location = new System.Drawing.Point(40, 38);
			label65.Location = location;
			this.Label55.Name = "Label55";
			System.Windows.Forms.Label label66 = this.Label55;
			size = new System.Drawing.Size(61, 13);
			label66.Size = size;
			this.Label55.TabIndex = 27;
			this.Label55.Text = "C-R.bin file:";
			System.Windows.Forms.TextBox txbLTU2_cr = this.TxbLTU2_cr;
			location = new System.Drawing.Point(113, 35);
			txbLTU2_cr.Location = location;
			this.TxbLTU2_cr.Name = "TxbLTU2_cr";
			this.TxbLTU2_cr.ReadOnly = true;
			System.Windows.Forms.TextBox txbLTU2_cr2 = this.TxbLTU2_cr;
			size = new System.Drawing.Size(452, 20);
			txbLTU2_cr2.Size = size;
			this.TxbLTU2_cr.TabIndex = 30;
			this.TxbLTU2_cr.Text = "[REQUIRED]";
			System.Windows.Forms.Button button49 = this.Button69;
			location = new System.Drawing.Point(571, 33);
			button49.Location = location;
			this.Button69.Name = "Button69";
			System.Windows.Forms.Button button50 = this.Button69;
			size = new System.Drawing.Size(27, 23);
			button50.Size = size;
			this.Button69.TabIndex = 28;
			this.Button69.Text = "...";
			this.Button69.UseVisualStyleBackColor = true;
			this.cmbLTU2Fileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLTU2Fileset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbLTU2Fileset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbLTU2Fileset.FormattingEnabled = true;
			System.Windows.Forms.ComboBox comboBox7 = this.cmbLTU2Fileset;
			location = new System.Drawing.Point(113, 90);
			comboBox7.Location = location;
			this.cmbLTU2Fileset.Name = "cmbLTU2Fileset";
			System.Windows.Forms.ComboBox comboBox8 = this.cmbLTU2Fileset;
			size = new System.Drawing.Size(484, 21);
			comboBox8.Size = size;
			this.cmbLTU2Fileset.TabIndex = 37;
			this.ToolTip1.SetToolTip(this.cmbLTU2Fileset, "Choose the Fileset that contains the LTU files");
			this.Label56.AutoSize = true;
			System.Windows.Forms.Label label67 = this.Label56;
			location = new System.Drawing.Point(40, 10);
			label67.Location = location;
			this.Label56.Name = "Label56";
			System.Windows.Forms.Label label68 = this.Label56;
			size = new System.Drawing.Size(60, 13);
			label68.Size = size;
			this.Label56.TabIndex = 31;
			this.Label56.Text = "key.bin file:";
			this.Label57.AutoSize = true;
			System.Windows.Forms.Label label69 = this.Label57;
			location = new System.Drawing.Point(36, 93);
			label69.Location = location;
			this.Label57.Name = "Label57";
			System.Windows.Forms.Label label70 = this.Label57;
			size = new System.Drawing.Size(40, 13);
			label70.Size = size;
			this.Label57.TabIndex = 36;
			this.Label57.Text = "Fileset:";
			System.Windows.Forms.Button button51 = this.Button70;
			location = new System.Drawing.Point(571, 5);
			button51.Location = location;
			this.Button70.Name = "Button70";
			System.Windows.Forms.Button button52 = this.Button70;
			size = new System.Drawing.Size(27, 23);
			button52.Size = size;
			this.Button70.TabIndex = 29;
			this.Button70.Text = "...";
			this.Button70.UseVisualStyleBackColor = true;
			this.Label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label71 = this.Label58;
			location = new System.Drawing.Point(36, 142);
			label71.Location = location;
			this.Label58.Name = "Label58";
			System.Windows.Forms.Label label72 = this.Label58;
			size = new System.Drawing.Size(566, 30);
			label72.Size = size;
			this.Label58.TabIndex = 34;
			this.Label58.Text = "In order to grab the C-R.BIN and DVDKEY.BIN files you need read your console Nand and extract CPU KEY with RGH.  Then on J-RUNNER v290+ do a TOOLS->EXTRACT FILES";
			System.Windows.Forms.Button button53 = this.Button71;
			location = new System.Drawing.Point(431, 246);
			button53.Location = location;
			this.Button71.Name = "Button71";
			System.Windows.Forms.Button button54 = this.Button71;
			size = new System.Drawing.Size(164, 23);
			button54.Size = size;
			this.Button71.TabIndex = 32;
			this.Button71.Text = "Generate Firmware as..";
			this.Button71.UseVisualStyleBackColor = true;
			this.Label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label73 = this.Label59;
			location = new System.Drawing.Point(36, 186);
			label73.Location = location;
			this.Label59.Name = "Label59";
			System.Windows.Forms.Label label74 = this.Label59;
			size = new System.Drawing.Size(566, 57);
			label74.Size = size;
			this.Label59.TabIndex = 35;
			this.Label59.Text = resources.GetString("Label59.Text");
			System.Windows.Forms.Button button55 = this.Button59;
			location = new System.Drawing.Point(10, 255);
			button55.Location = location;
			this.Button59.Name = "Button59";
			System.Windows.Forms.Button button56 = this.Button59;
			size = new System.Drawing.Size(147, 23);
			button56.Size = size;
			this.Button59.TabIndex = 13;
			this.Button59.Text = "ATA IDENTIFY";
			this.Button59.UseVisualStyleBackColor = true;
			this.Button59.Visible = false;
			System.Windows.Forms.Button button57 = this.Button68;
			location = new System.Drawing.Point(319, 254);
			button57.Location = location;
			this.Button68.Name = "Button68";
			System.Windows.Forms.Button button58 = this.Button68;
			size = new System.Drawing.Size(117, 23);
			button58.Size = size;
			this.Button68.TabIndex = 26;
			this.Button68.Text = "FCRT_DEC Test";
			this.Button68.UseVisualStyleBackColor = true;
			this.Button68.Visible = false;
			System.Windows.Forms.Button button59 = this.Button60;
			location = new System.Drawing.Point(10, 284);
			button59.Location = location;
			this.Button60.Name = "Button60";
			System.Windows.Forms.Button button60 = this.Button60;
			size = new System.Drawing.Size(147, 23);
			button60.Size = size;
			this.Button60.TabIndex = 14;
			this.Button60.Text = "ATAPI INQUIRY";
			this.Button60.UseVisualStyleBackColor = true;
			this.Button60.Visible = false;
			System.Windows.Forms.Button button61 = this.Button66;
			location = new System.Drawing.Point(319, 342);
			button61.Location = location;
			this.Button66.Name = "Button66";
			System.Windows.Forms.Button button62 = this.Button66;
			size = new System.Drawing.Size(129, 23);
			button62.Size = size;
			this.Button66.TabIndex = 25;
			this.Button66.Text = "BB Set Key";
			this.Button66.UseVisualStyleBackColor = true;
			this.Button66.Visible = false;
			System.Windows.Forms.Button button63 = this.Button61;
			location = new System.Drawing.Point(10, 313);
			button63.Location = location;
			this.Button61.Name = "Button61";
			System.Windows.Forms.Button button64 = this.Button61;
			size = new System.Drawing.Size(147, 23);
			button64.Size = size;
			this.Button61.TabIndex = 15;
			this.Button61.Text = "PC25";
			this.Button61.UseVisualStyleBackColor = true;
			this.Button61.Visible = false;
			System.Windows.Forms.Button button65 = this.Button30;
			location = new System.Drawing.Point(181, 254);
			button65.Location = location;
			this.Button30.Name = "Button30";
			System.Windows.Forms.Button button66 = this.Button30;
			size = new System.Drawing.Size(129, 23);
			button66.Size = size;
			this.Button30.TabIndex = 16;
			this.Button30.Text = "Key Check / Auth";
			this.Button30.UseVisualStyleBackColor = true;
			this.Button30.Visible = false;
			System.Windows.Forms.Button button67 = this.Button65;
			location = new System.Drawing.Point(11, 342);
			button67.Location = location;
			this.Button65.Name = "Button65";
			System.Windows.Forms.Button button68 = this.Button65;
			size = new System.Drawing.Size(129, 23);
			button68.Size = size;
			this.Button65.TabIndex = 20;
			this.Button65.Text = "21 DramDump";
			this.Button65.UseVisualStyleBackColor = true;
			this.Button65.Visible = false;
			System.Windows.Forms.Button button69 = this.Button62;
			location = new System.Drawing.Point(181, 284);
			button69.Location = location;
			this.Button62.Name = "Button62";
			System.Windows.Forms.Button button70 = this.Button62;
			size = new System.Drawing.Size(129, 23);
			button70.Size = size;
			this.Button62.TabIndex = 17;
			this.Button62.Text = "AESTEST";
			this.Button62.UseVisualStyleBackColor = true;
			this.Button62.Visible = false;
			System.Windows.Forms.Button button71 = this.Button64;
			location = new System.Drawing.Point(181, 342);
			button71.Location = location;
			this.Button64.Name = "Button64";
			System.Windows.Forms.Button button72 = this.Button64;
			size = new System.Drawing.Size(129, 23);
			button72.Size = size;
			this.Button64.TabIndex = 19;
			this.Button64.Text = "3B Auth";
			this.Button64.UseVisualStyleBackColor = true;
			this.Button64.Visible = false;
			System.Windows.Forms.Button button73 = this.Button63;
			location = new System.Drawing.Point(181, 313);
			button73.Location = location;
			this.Button63.Name = "Button63";
			System.Windows.Forms.Button button74 = this.Button63;
			size = new System.Drawing.Size(129, 23);
			button74.Size = size;
			this.Button63.TabIndex = 18;
			this.Button63.Text = "PC28Test";
			this.Button63.UseVisualStyleBackColor = true;
			this.Button63.Visible = false;
			this.TabPage_8.BackColor = System.Drawing.SystemColors.Control;
			this.TabPage_8.Controls.Add(this.Label60);
			this.TabPage_8.Controls.Add(this.cmbLTUTemplate);
			this.TabPage_8.Controls.Add(this.Label48);
			this.TabPage_8.Controls.Add(this.txbLTU_key);
			this.TabPage_8.Controls.Add(this.Label49);
			this.TabPage_8.Controls.Add(this.txbLTU_cr);
			this.TabPage_8.Controls.Add(this.Button55);
			this.TabPage_8.Controls.Add(this.cmbLTUFileset);
			this.TabPage_8.Controls.Add(this.Label50);
			this.TabPage_8.Controls.Add(this.Label54);
			this.TabPage_8.Controls.Add(this.Button56);
			this.TabPage_8.Controls.Add(this.Label51);
			this.TabPage_8.Controls.Add(this.txbLTU_Unique);
			this.TabPage_8.Controls.Add(this.Button57);
			this.TabPage_8.Controls.Add(this.Label52);
			this.TabPage_8.Controls.Add(this.Button58);
			this.TabPage_8.Controls.Add(this.Label53);
			System.Windows.Forms.TabPage tabPage18 = this.TabPage_8;
			location = new System.Drawing.Point(4, 22);
			tabPage18.Location = location;
			this.TabPage_8.Name = "TabPage18";
			System.Windows.Forms.TabPage tabPage19 = this.TabPage_8;
			padding = new System.Windows.Forms.Padding(3);
			tabPage19.Padding = padding;
			System.Windows.Forms.TabPage tabPage20 = this.TabPage_8;
			size = new System.Drawing.Size(654, 381);
			tabPage20.Size = size;
			this.TabPage_8.TabIndex = 1;
			this.TabPage_8.Text = "LTU for V1 Board (MT1332E)";
			this.Label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label60.ForeColor = System.Drawing.Color.Red;
			System.Windows.Forms.Label label75 = this.Label60;
			location = new System.Drawing.Point(36, 302);
			label75.Location = location;
			this.Label60.Name = "Label60";
			System.Windows.Forms.Label label76 = this.Label60;
			size = new System.Drawing.Size(566, 57);
			label76.Size = size;
			this.Label60.TabIndex = 24;
			this.Label60.Text = resources.GetString("Label60.Text");
			this.cmbLTUTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLTUTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbLTUTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbLTUTemplate.FormattingEnabled = true;
			System.Windows.Forms.ComboBox comboBox9 = this.cmbLTUTemplate;
			location = new System.Drawing.Point(113, 117);
			comboBox9.Location = location;
			this.cmbLTUTemplate.Name = "cmbLTUTemplate";
			System.Windows.Forms.ComboBox comboBox10 = this.cmbLTUTemplate;
			size = new System.Drawing.Size(484, 21);
			comboBox10.Size = size;
			this.cmbLTUTemplate.TabIndex = 24;
			this.ToolTip1.SetToolTip(this.cmbLTUTemplate, "Select the Base File (must match your original drive Model-Rom)");
			this.Label48.AutoSize = true;
			System.Windows.Forms.Label label77 = this.Label48;
			location = new System.Drawing.Point(36, 120);
			label77.Location = location;
			this.Label48.Name = "Label48";
			System.Windows.Forms.Label label78 = this.Label48;
			size = new System.Drawing.Size(54, 13);
			label78.Size = size;
			this.Label48.TabIndex = 1;
			this.Label48.Text = "Template:";
			System.Windows.Forms.TextBox textBox25 = this.txbLTU_key;
			location = new System.Drawing.Point(113, 7);
			textBox25.Location = location;
			this.txbLTU_key.Name = "txbLTU_key";
			this.txbLTU_key.ReadOnly = true;
			System.Windows.Forms.TextBox textBox26 = this.txbLTU_key;
			size = new System.Drawing.Size(452, 20);
			textBox26.Size = size;
			this.txbLTU_key.TabIndex = 6;
			this.txbLTU_key.Text = "[REQUIRED]";
			this.Label49.AutoSize = true;
			System.Windows.Forms.Label label79 = this.Label49;
			location = new System.Drawing.Point(40, 38);
			label79.Location = location;
			this.Label49.Name = "Label49";
			System.Windows.Forms.Label label80 = this.Label49;
			size = new System.Drawing.Size(61, 13);
			label80.Size = size;
			this.Label49.TabIndex = 2;
			this.Label49.Text = "C-R.bin file:";
			System.Windows.Forms.TextBox textBox27 = this.txbLTU_cr;
			location = new System.Drawing.Point(113, 35);
			textBox27.Location = location;
			this.txbLTU_cr.Name = "txbLTU_cr";
			this.txbLTU_cr.ReadOnly = true;
			System.Windows.Forms.TextBox textBox28 = this.txbLTU_cr;
			size = new System.Drawing.Size(452, 20);
			textBox28.Size = size;
			this.txbLTU_cr.TabIndex = 3;
			this.txbLTU_cr.Text = "[REQUIRED]";
			System.Windows.Forms.Button button75 = this.Button55;
			location = new System.Drawing.Point(571, 33);
			button75.Location = location;
			this.Button55.Name = "Button55";
			System.Windows.Forms.Button button76 = this.Button55;
			size = new System.Drawing.Size(27, 23);
			button76.Size = size;
			this.Button55.TabIndex = 2;
			this.Button55.Text = "...";
			this.Button55.UseVisualStyleBackColor = true;
			this.cmbLTUFileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLTUFileset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbLTUFileset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbLTUFileset.FormattingEnabled = true;
			System.Windows.Forms.ComboBox comboBox11 = this.cmbLTUFileset;
			location = new System.Drawing.Point(113, 90);
			comboBox11.Location = location;
			this.cmbLTUFileset.Name = "cmbLTUFileset";
			System.Windows.Forms.ComboBox comboBox12 = this.cmbLTUFileset;
			size = new System.Drawing.Size(484, 21);
			comboBox12.Size = size;
			this.cmbLTUFileset.TabIndex = 23;
			this.ToolTip1.SetToolTip(this.cmbLTUFileset, "Choose the Fileset that contains the LTU files");
			this.Label50.AutoSize = true;
			System.Windows.Forms.Label label81 = this.Label50;
			location = new System.Drawing.Point(40, 10);
			label81.Location = location;
			this.Label50.Name = "Label50";
			System.Windows.Forms.Label label82 = this.Label50;
			size = new System.Drawing.Size(60, 13);
			label82.Size = size;
			this.Label50.TabIndex = 5;
			this.Label50.Text = "key.bin file:";
			this.Label54.AutoSize = true;
			System.Windows.Forms.Label label83 = this.Label54;
			location = new System.Drawing.Point(36, 93);
			label83.Location = location;
			this.Label54.Name = "Label54";
			System.Windows.Forms.Label label84 = this.Label54;
			size = new System.Drawing.Size(40, 13);
			label84.Size = size;
			this.Label54.TabIndex = 22;
			this.Label54.Text = "Fileset:";
			System.Windows.Forms.Button button77 = this.Button56;
			location = new System.Drawing.Point(571, 5);
			button77.Location = location;
			this.Button56.Name = "Button56";
			System.Windows.Forms.Button button78 = this.Button56;
			size = new System.Drawing.Size(27, 23);
			button78.Size = size;
			this.Button56.TabIndex = 3;
			this.Button56.Text = "...";
			this.Button56.UseVisualStyleBackColor = true;
			this.Label51.AutoSize = true;
			System.Windows.Forms.Label label85 = this.Label51;
			location = new System.Drawing.Point(29, 66);
			label85.Location = location;
			this.Label51.Name = "Label51";
			System.Windows.Forms.Label label86 = this.Label51;
			size = new System.Drawing.Size(82, 13);
			label86.Size = size;
			this.Label51.TabIndex = 8;
			this.Label51.Text = "Serial n Unique:";
			System.Windows.Forms.TextBox textBox29 = this.txbLTU_Unique;
			location = new System.Drawing.Point(113, 63);
			textBox29.Location = location;
			this.txbLTU_Unique.Name = "txbLTU_Unique";
			this.txbLTU_Unique.ReadOnly = true;
			System.Windows.Forms.TextBox textBox30 = this.txbLTU_Unique;
			size = new System.Drawing.Size(356, 20);
			textBox30.Size = size;
			this.txbLTU_Unique.TabIndex = 9;
			this.txbLTU_Unique.Text = "OPTIONAL";
			System.Windows.Forms.Button button79 = this.Button57;
			location = new System.Drawing.Point(475, 61);
			button79.Location = location;
			this.Button57.Name = "Button57";
			System.Windows.Forms.Button button80 = this.Button57;
			size = new System.Drawing.Size(123, 23);
			button80.Size = size;
			this.Button57.TabIndex = 4;
			this.Button57.Text = "Grab from Drive";
			this.ToolTip1.SetToolTip(this.Button57, "Read the Unique data from the drive");
			this.Button57.UseVisualStyleBackColor = true;
			this.Label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label87 = this.Label52;
			location = new System.Drawing.Point(36, 142);
			label87.Location = location;
			this.Label52.Name = "Label52";
			System.Windows.Forms.Label label88 = this.Label52;
			size = new System.Drawing.Size(566, 30);
			label88.Size = size;
			this.Label52.TabIndex = 11;
			this.Label52.Text = "In order to grab the C-R.BIN and DVDKEY.BIN files you need read your console Nand and extract CPU KEY with RGH.  Then on J-RUNNER v287/v288 do a TOOLS->EXTRACT FILES";
			System.Windows.Forms.Button button81 = this.Button58;
			location = new System.Drawing.Point(431, 246);
			button81.Location = location;
			this.Button58.Name = "Button58";
			System.Windows.Forms.Button button82 = this.Button58;
			size = new System.Drawing.Size(164, 23);
			button82.Size = size;
			this.Button58.TabIndex = 5;
			this.Button58.Text = "Generate Firmware as..";
			this.Button58.UseVisualStyleBackColor = true;
			this.Label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label89 = this.Label53;
			location = new System.Drawing.Point(36, 186);
			label89.Location = location;
			this.Label53.Name = "Label53";
			System.Windows.Forms.Label label90 = this.Label53;
			size = new System.Drawing.Size(566, 57);
			label90.Size = size;
			this.Label53.TabIndex = 12;
			this.Label53.Text = resources.GetString("Label53.Text");
			this.TabPage6.Controls.Add(this.Label25);
			this.TabPage6.Controls.Add(this.BtnHitRead);
			this.TabPage6.Controls.Add(this.txbhitread);
			this.TabPage6.Controls.Add(this.GroupBox6);
			this.TabPage6.Controls.Add(this.Button14);
			this.TabPage6.Controls.Add(this.RadioButton2);
			this.TabPage6.Controls.Add(this.RadioButton1);
			this.TabPage6.Controls.Add(this.TxbLog);
			this.TabPage6.Controls.Add(this.Button_0);
			this.TabPage6.Controls.Add(this.txbFile2Flash);
			this.TabPage6.Controls.Add(this.Button16);
			this.TabPage6.Controls.Add(this.lstSectors);
			System.Windows.Forms.TabPage tabPage23 = this.TabPage6;
			location = new System.Drawing.Point(4, 25);
			tabPage23.Location = location;
			this.TabPage6.Name = "TabPage6";
			System.Windows.Forms.TabPage tabPage24 = this.TabPage6;
			size = new System.Drawing.Size(673, 416);
			tabPage24.Size = size;
			this.TabPage6.TabIndex = 4;
			this.TabPage6.Text = "Hitachi Flasher";
			this.TabPage6.UseVisualStyleBackColor = true;
			this.Label25.AutoSize = true;
			System.Windows.Forms.Label label91 = this.Label25;
			location = new System.Drawing.Point(3, 14);
			label91.Location = location;
			this.Label25.Name = "Label25";
			System.Windows.Forms.Label label92 = this.Label25;
			size = new System.Drawing.Size(64, 13);
			label92.Size = size;
			this.Label25.TabIndex = 21;
			this.Label25.Text = "Read Drive:";
			System.Windows.Forms.Button btnHitRead = this.BtnHitRead;
			location = new System.Drawing.Point(574, 9);
			btnHitRead.Location = location;
			this.BtnHitRead.Name = "BtnHitRead";
			System.Windows.Forms.Button btnHitRead2 = this.BtnHitRead;
			size = new System.Drawing.Size(75, 23);
			btnHitRead2.Size = size;
			this.BtnHitRead.TabIndex = 20;
			this.BtnHitRead.Text = "Choose File";
			this.BtnHitRead.UseVisualStyleBackColor = true;
			System.Windows.Forms.TextBox textBox31 = this.txbhitread;
			location = new System.Drawing.Point(90, 11);
			textBox31.Location = location;
			this.txbhitread.Name = "txbhitread";
			System.Windows.Forms.TextBox textBox32 = this.txbhitread;
			size = new System.Drawing.Size(478, 20);
			textBox32.Size = size;
			this.txbhitread.TabIndex = 19;
			this.GroupBox6.Controls.Add(this.txbhitsrc);
			this.GroupBox6.Controls.Add(this.Button9);
			this.GroupBox6.Controls.Add(this.Button10);
			this.GroupBox6.Controls.Add(this.txbhitdst);
			this.GroupBox6.Controls.Add(this.Button13);
			this.GroupBox6.Controls.Add(this.Label24);
			this.GroupBox6.Controls.Add(this.txbAddrSect);
			this.GroupBox6.Controls.Add(this.Button7);
			this.GroupBox6.Controls.Add(this.Button15);
			System.Windows.Forms.GroupBox groupBox13 = this.GroupBox6;
			location = new System.Drawing.Point(449, 189);
			groupBox13.Location = location;
			this.GroupBox6.Name = "GroupBox6";
			System.Windows.Forms.GroupBox groupBox14 = this.GroupBox6;
			size = new System.Drawing.Size(200, 213);
			groupBox14.Size = size;
			this.GroupBox6.TabIndex = 18;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "GroupBox6";
			this.GroupBox6.Visible = false;
			System.Windows.Forms.TextBox textBox33 = this.txbhitsrc;
			location = new System.Drawing.Point(6, 19);
			textBox33.Location = location;
			this.txbhitsrc.Name = "txbhitsrc";
			System.Windows.Forms.TextBox textBox34 = this.txbhitsrc;
			size = new System.Drawing.Size(92, 20);
			textBox34.Size = size;
			this.txbhitsrc.TabIndex = 5;
			System.Windows.Forms.Button button83 = this.Button9;
			location = new System.Drawing.Point(104, 17);
			button83.Location = location;
			this.Button9.Name = "Button9";
			System.Windows.Forms.Button button84 = this.Button9;
			size = new System.Drawing.Size(75, 23);
			button84.Size = size;
			this.Button9.TabIndex = 4;
			this.Button9.Text = "Choose Src";
			this.Button9.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button85 = this.Button10;
			location = new System.Drawing.Point(104, 43);
			button85.Location = location;
			this.Button10.Name = "Button10";
			System.Windows.Forms.Button button86 = this.Button10;
			size = new System.Drawing.Size(75, 23);
			button86.Size = size;
			this.Button10.TabIndex = 6;
			this.Button10.Text = "Choose Dst";
			this.Button10.UseVisualStyleBackColor = true;
			System.Windows.Forms.TextBox textBox35 = this.txbhitdst;
			location = new System.Drawing.Point(6, 45);
			textBox35.Location = location;
			this.txbhitdst.Name = "txbhitdst";
			System.Windows.Forms.TextBox textBox36 = this.txbhitdst;
			size = new System.Drawing.Size(92, 20);
			textBox36.Size = size;
			this.txbhitdst.TabIndex = 7;
			System.Windows.Forms.Button button87 = this.Button13;
			location = new System.Drawing.Point(48, 104);
			button87.Location = location;
			this.Button13.Name = "Button13";
			System.Windows.Forms.Button button88 = this.Button13;
			size = new System.Drawing.Size(131, 23);
			button88.Size = size;
			this.Button13.TabIndex = 8;
			this.Button13.Text = "Get Sectors";
			this.Button13.UseVisualStyleBackColor = true;
			this.Label24.AutoSize = true;
			System.Windows.Forms.Label label93 = this.Label24;
			location = new System.Drawing.Point(6, 168);
			label93.Location = location;
			this.Label24.Name = "Label24";
			System.Windows.Forms.Label label94 = this.Label24;
			size = new System.Drawing.Size(119, 13);
			label94.Size = size;
			this.Label24.TabIndex = 1;
			this.Label24.Text = "Sector Address to Flash";
			System.Windows.Forms.TextBox textBox37 = this.txbAddrSect;
			location = new System.Drawing.Point(17, 184);
			textBox37.Location = location;
			this.txbAddrSect.Name = "txbAddrSect";
			System.Windows.Forms.TextBox textBox38 = this.txbAddrSect;
			size = new System.Drawing.Size(81, 20);
			textBox38.Size = size;
			this.txbAddrSect.TabIndex = 0;
			this.txbAddrSect.Text = "91001000";
			System.Windows.Forms.Button button89 = this.Button7;
			location = new System.Drawing.Point(17, 210);
			button89.Location = location;
			this.Button7.Name = "Button7";
			System.Windows.Forms.Button button90 = this.Button7;
			size = new System.Drawing.Size(131, 23);
			button90.Size = size;
			this.Button7.TabIndex = 2;
			this.Button7.Text = "Send to Flashing Buffer";
			this.Button7.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button91 = this.Button15;
			location = new System.Drawing.Point(17, 239);
			button91.Location = location;
			this.Button15.Name = "Button15";
			System.Windows.Forms.Button button92 = this.Button15;
			size = new System.Drawing.Size(131, 23);
			button92.Size = size;
			this.Button15.TabIndex = 10;
			this.Button15.Text = "Dump Sector Buffer";
			this.Button15.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button93 = this.Button14;
			location = new System.Drawing.Point(154, 116);
			button93.Location = location;
			this.Button14.Name = "Button14";
			System.Windows.Forms.Button button94 = this.Button14;
			size = new System.Drawing.Size(111, 23);
			button94.Size = size;
			this.Button14.TabIndex = 17;
			this.Button14.Text = "Write !";
			this.Button14.UseVisualStyleBackColor = true;
			this.RadioButton2.AutoSize = true;
			System.Windows.Forms.RadioButton radioButton = this.RadioButton2;
			location = new System.Drawing.Point(4, 60);
			radioButton.Location = location;
			this.RadioButton2.Name = "RadioButton2";
			System.Windows.Forms.RadioButton radioButton2 = this.RadioButton2;
			size = new System.Drawing.Size(80, 17);
			radioButton2.Size = size;
			this.RadioButton2.TabIndex = 16;
			this.RadioButton2.Text = "Flash CFW:";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Checked = true;
			System.Windows.Forms.RadioButton radioButton3 = this.RadioButton1;
			location = new System.Drawing.Point(4, 37);
			radioButton3.Location = location;
			this.RadioButton1.Name = "RadioButton1";
			System.Windows.Forms.RadioButton radioButton4 = this.RadioButton1;
			size = new System.Drawing.Size(105, 17);
			radioButton4.Size = size;
			this.RadioButton1.TabIndex = 15;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "Restore to Stock";
			this.RadioButton1.UseVisualStyleBackColor = true;
			System.Windows.Forms.TextBox txbLog = this.TxbLog;
			location = new System.Drawing.Point(4, 309);
			txbLog.Location = location;
			this.TxbLog.Multiline = true;
			this.TxbLog.Name = "TxbLog";
			this.TxbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox txbLog2 = this.TxbLog;
			size = new System.Drawing.Size(627, 93);
			txbLog2.Size = size;
			this.TxbLog.TabIndex = 14;
			System.Windows.Forms.Button button95 = this.Button_0;
			location = new System.Drawing.Point(574, 58);
			button95.Location = location;
			this.Button_0.Name = "LoadHitCFW";
			System.Windows.Forms.Button button96 = this.Button_0;
			size = new System.Drawing.Size(75, 23);
			button96.Size = size;
			this.Button_0.TabIndex = 13;
			this.Button_0.Text = "Choose File";
			this.Button_0.UseVisualStyleBackColor = true;
			System.Windows.Forms.TextBox textBox39 = this.txbFile2Flash;
			location = new System.Drawing.Point(90, 60);
			textBox39.Location = location;
			this.txbFile2Flash.Name = "txbFile2Flash";
			System.Windows.Forms.TextBox textBox40 = this.txbFile2Flash;
			size = new System.Drawing.Size(478, 20);
			textBox40.Size = size;
			this.txbFile2Flash.TabIndex = 12;
			System.Windows.Forms.Button button97 = this.Button16;
			location = new System.Drawing.Point(154, 86);
			button97.Location = location;
			this.Button16.Name = "Button16";
			System.Windows.Forms.Button button98 = this.Button16;
			size = new System.Drawing.Size(111, 23);
			button98.Size = size;
			this.Button16.TabIndex = 11;
			this.Button16.Text = "Analyze Changes";
			this.Button16.UseVisualStyleBackColor = true;
			this.lstSectors.FormattingEnabled = true;
			System.Windows.Forms.ListBox listBox = this.lstSectors;
			location = new System.Drawing.Point(3, 86);
			listBox.Location = location;
			this.lstSectors.Name = "lstSectors";
			System.Windows.Forms.ListBox listBox2 = this.lstSectors;
			size = new System.Drawing.Size(145, 212);
			listBox2.Size = size;
			this.lstSectors.TabIndex = 3;
			this.TabPage7.Controls.Add(this.Label44);
			this.TabPage7.Controls.Add(this.Label43);
			this.TabPage7.Controls.Add(this.Label42);
			this.TabPage7.Controls.Add(this.picsync3);
			this.TabPage7.Controls.Add(this.picsync2);
			this.TabPage7.Controls.Add(this.picsync1);
			this.TabPage7.Controls.Add(this.Button28);
			this.TabPage7.Controls.Add(this.chksync_freeafterbackup);
			this.TabPage7.Controls.Add(this.Button25);
			this.TabPage7.Controls.Add(this.Label29);
			this.TabPage7.Controls.Add(this.GroupBox7);
			this.TabPage7.Controls.Add(this.Button21);
			this.TabPage7.Controls.Add(this.TreeView1);
			System.Windows.Forms.TabPage tabPage25 = this.TabPage7;
			location = new System.Drawing.Point(4, 25);
			tabPage25.Location = location;
			this.TabPage7.Name = "TabPage7";
			System.Windows.Forms.TabPage tabPage26 = this.TabPage7;
			size = new System.Drawing.Size(673, 416);
			tabPage26.Size = size;
			this.TabPage7.TabIndex = 5;
			this.TabPage7.Text = "Sync";
			this.TabPage7.UseVisualStyleBackColor = true;
			this.Label44.AutoSize = true;
			System.Windows.Forms.Label label95 = this.Label44;
			location = new System.Drawing.Point(441, 376);
			label95.Location = location;
			this.Label44.Name = "Label44";
			System.Windows.Forms.Label label96 = this.Label44;
			size = new System.Drawing.Size(74, 13);
			label96.Size = size;
			this.Label44.TabIndex = 12;
			this.Label44.Text = "Uploaded Slot";
			this.Label43.AutoSize = true;
			System.Windows.Forms.Label label97 = this.Label43;
			location = new System.Drawing.Point(303, 376);
			label97.Location = location;
			this.Label43.Name = "Label43";
			System.Windows.Forms.Label label98 = this.Label43;
			size = new System.Drawing.Size(74, 13);
			label98.Size = size;
			this.Label43.TabIndex = 11;
			this.Label43.Text = "Occupied Slot";
			this.Label42.AutoSize = true;
			System.Windows.Forms.Label label99 = this.Label42;
			location = new System.Drawing.Point(172, 376);
			label99.Location = location;
			this.Label42.Name = "Label42";
			System.Windows.Forms.Label label100 = this.Label42;
			size = new System.Drawing.Size(57, 13);
			label100.Size = size;
			this.Label42.TabIndex = 10;
			this.Label42.Text = "Empty Slot";
			System.Windows.Forms.PictureBox pictureBox3 = this.picsync3;
			location = new System.Drawing.Point(419, 374);
			pictureBox3.Location = location;
			this.picsync3.Name = "picsync3";
			System.Windows.Forms.PictureBox pictureBox4 = this.picsync3;
			size = new System.Drawing.Size(16, 16);
			pictureBox4.Size = size;
			this.picsync3.TabIndex = 9;
			this.picsync3.TabStop = false;
			System.Windows.Forms.PictureBox pictureBox5 = this.picsync2;
			location = new System.Drawing.Point(281, 374);
			pictureBox5.Location = location;
			this.picsync2.Name = "picsync2";
			System.Windows.Forms.PictureBox pictureBox6 = this.picsync2;
			size = new System.Drawing.Size(16, 16);
			pictureBox6.Size = size;
			this.picsync2.TabIndex = 8;
			this.picsync2.TabStop = false;
			System.Windows.Forms.PictureBox pictureBox7 = this.picsync1;
			location = new System.Drawing.Point(150, 374);
			pictureBox7.Location = location;
			this.picsync1.Name = "picsync1";
			System.Windows.Forms.PictureBox pictureBox8 = this.picsync1;
			size = new System.Drawing.Size(16, 16);
			pictureBox8.Size = size;
			this.picsync1.TabIndex = 7;
			this.picsync1.TabStop = false;
			System.Windows.Forms.Button button99 = this.Button28;
			location = new System.Drawing.Point(3, 374);
			button99.Location = location;
			this.Button28.Name = "Button28";
			System.Windows.Forms.Button button100 = this.Button28;
			size = new System.Drawing.Size(136, 23);
			button100.Size = size;
			this.Button28.TabIndex = 6;
			this.Button28.Text = "Free Slots in Lizard";
			this.Button28.UseVisualStyleBackColor = true;
			this.chksync_freeafterbackup.AutoSize = true;
			this.chksync_freeafterbackup.Checked = true;
			this.chksync_freeafterbackup.CheckState = System.Windows.Forms.CheckState.Checked;
			System.Windows.Forms.CheckBox checkBox = this.chksync_freeafterbackup;
			location = new System.Drawing.Point(144, 399);
			checkBox.Location = location;
			this.chksync_freeafterbackup.Name = "chksync_freeafterbackup";
			System.Windows.Forms.CheckBox checkBox2 = this.chksync_freeafterbackup;
			size = new System.Drawing.Size(136, 17);
			checkBox2.Size = size;
			this.chksync_freeafterbackup.TabIndex = 5;
			this.chksync_freeafterbackup.Text = "Free Slots after backup";
			this.chksync_freeafterbackup.UseVisualStyleBackColor = true;
			this.chksync_freeafterbackup.Visible = false;
			System.Windows.Forms.Button button101 = this.Button25;
			location = new System.Drawing.Point(2, 345);
			button101.Location = location;
			this.Button25.Name = "Button25";
			System.Windows.Forms.Button button102 = this.Button25;
			size = new System.Drawing.Size(136, 23);
			button102.Size = size;
			this.Button25.TabIndex = 4;
			this.Button25.Text = "Backup Slots to PC";
			this.Button25.UseVisualStyleBackColor = true;
			this.Label29.AutoSize = true;
			System.Windows.Forms.Label label101 = this.Label29;
			location = new System.Drawing.Point(0, 8);
			label101.Location = location;
			this.Label29.Name = "Label29";
			System.Windows.Forms.Label label102 = this.Label29;
			size = new System.Drawing.Size(64, 13);
			label102.Size = size;
			this.Label29.TabIndex = 3;
			this.Label29.Text = "Lizard Slots:";
			this.GroupBox7.Controls.Add(this.btn_msload);
			this.GroupBox7.Controls.Add(this.TabControl3);
			this.GroupBox7.Controls.Add(this.mslbl_logdrive);
			this.GroupBox7.Controls.Add(this.Label27);
			this.GroupBox7.Controls.Add(this.btn_mserase);
			this.GroupBox7.Controls.Add(this.btn_mssave);
			this.GroupBox7.Controls.Add(this.mstxb_key);
			this.GroupBox7.Controls.Add(this.Label30);
			this.GroupBox7.Controls.Add(this.mslbl_jobname);
			this.GroupBox7.Controls.Add(this.Label28);
			this.GroupBox7.Controls.Add(this.mslbl_status);
			this.GroupBox7.Controls.Add(this.Label26);
			System.Windows.Forms.GroupBox groupBox15 = this.GroupBox7;
			location = new System.Drawing.Point(144, 24);
			groupBox15.Location = location;
			this.GroupBox7.Name = "GroupBox7";
			System.Windows.Forms.GroupBox groupBox16 = this.GroupBox7;
			size = new System.Drawing.Size(521, 344);
			groupBox16.Size = size;
			this.GroupBox7.TabIndex = 2;
			this.GroupBox7.TabStop = false;
			this.GroupBox7.Text = "Selected Slot Details:";
			this.btn_msload.Enabled = false;
			System.Windows.Forms.Button button103 = this.btn_msload;
			location = new System.Drawing.Point(413, 91);
			button103.Location = location;
			this.btn_msload.Name = "btn_msload";
			System.Windows.Forms.Button button104 = this.btn_msload;
			size = new System.Drawing.Size(102, 23);
			button104.Size = size;
			this.btn_msload.TabIndex = 12;
			this.btn_msload.Text = "Load a file to slot";
			this.ToolTip1.SetToolTip(this.btn_msload, "BETA FEATURE ! : Upload a full dump or dummy file to Lizard Slot.");
			this.btn_msload.UseVisualStyleBackColor = true;
			this.TabControl3.Controls.Add(this.TabPage9);
			this.TabControl3.Controls.Add(this.TabPage_0);
			this.TabControl3.Controls.Add(this.TabPage_1);
			System.Windows.Forms.TabControl tabControl7 = this.TabControl3;
			location = new System.Drawing.Point(6, 123);
			tabControl7.Location = location;
			this.TabControl3.Name = "TabControl3";
			this.TabControl3.SelectedIndex = 0;
			System.Windows.Forms.TabControl tabControl8 = this.TabControl3;
			size = new System.Drawing.Size(509, 211);
			tabControl8.Size = size;
			this.TabControl3.TabIndex = 11;
			this.TabPage9.Controls.Add(this.txbsync_ide);
			System.Windows.Forms.TabPage tabPage27 = this.TabPage9;
			location = new System.Drawing.Point(4, 22);
			tabPage27.Location = location;
			this.TabPage9.Name = "TabPage9";
			System.Windows.Forms.TabPage tabPage28 = this.TabPage9;
			padding = new System.Windows.Forms.Padding(3);
			tabPage28.Padding = padding;
			System.Windows.Forms.TabPage tabPage29 = this.TabPage9;
			size = new System.Drawing.Size(501, 185);
			tabPage29.Size = size;
			this.TabPage9.TabIndex = 0;
			this.TabPage9.Text = "Identify";
			this.TabPage9.UseVisualStyleBackColor = true;
			this.txbsync_ide.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.TextBox textBox41 = this.txbsync_ide;
			location = new System.Drawing.Point(3, 3);
			textBox41.Location = location;
			this.txbsync_ide.Multiline = true;
			this.txbsync_ide.Name = "txbsync_ide";
			System.Windows.Forms.TextBox textBox42 = this.txbsync_ide;
			size = new System.Drawing.Size(493, 176);
			textBox42.Size = size;
			this.txbsync_ide.TabIndex = 13;
			this.TabPage_0.Controls.Add(this.txbsync_inq);
			System.Windows.Forms.TabPage tabPage30 = this.TabPage_0;
			location = new System.Drawing.Point(4, 22);
			tabPage30.Location = location;
			this.TabPage_0.Name = "TabPage10";
			System.Windows.Forms.TabPage tabPage31 = this.TabPage_0;
			padding = new System.Windows.Forms.Padding(3);
			tabPage31.Padding = padding;
			System.Windows.Forms.TabPage tabPage32 = this.TabPage_0;
			size = new System.Drawing.Size(501, 185);
			tabPage32.Size = size;
			this.TabPage_0.TabIndex = 1;
			this.TabPage_0.Text = "Inquiry";
			this.TabPage_0.UseVisualStyleBackColor = true;
			this.txbsync_inq.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.TextBox textBox43 = this.txbsync_inq;
			location = new System.Drawing.Point(3, 3);
			textBox43.Location = location;
			this.txbsync_inq.Multiline = true;
			this.txbsync_inq.Name = "txbsync_inq";
			System.Windows.Forms.TextBox textBox44 = this.txbsync_inq;
			size = new System.Drawing.Size(493, 176);
			textBox44.Size = size;
			this.txbsync_inq.TabIndex = 12;
			this.TabPage_1.Controls.Add(this.txbsync_ser);
			System.Windows.Forms.TabPage tabPage33 = this.TabPage_1;
			location = new System.Drawing.Point(4, 22);
			tabPage33.Location = location;
			this.TabPage_1.Name = "TabPage11";
			System.Windows.Forms.TabPage tabPage34 = this.TabPage_1;
			size = new System.Drawing.Size(501, 185);
			tabPage34.Size = size;
			this.TabPage_1.TabIndex = 2;
			this.TabPage_1.Text = "Serial";
			this.TabPage_1.UseVisualStyleBackColor = true;
			this.txbsync_ser.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.TextBox textBox45 = this.txbsync_ser;
			location = new System.Drawing.Point(3, 3);
			textBox45.Location = location;
			this.txbsync_ser.Multiline = true;
			this.txbsync_ser.Name = "txbsync_ser";
			System.Windows.Forms.TextBox textBox46 = this.txbsync_ser;
			size = new System.Drawing.Size(493, 176);
			textBox46.Size = size;
			this.txbsync_ser.TabIndex = 10;
			this.mslbl_logdrive.AutoSize = true;
			System.Windows.Forms.Label label103 = this.mslbl_logdrive;
			location = new System.Drawing.Point(85, 69);
			label103.Location = location;
			this.mslbl_logdrive.Name = "mslbl_logdrive";
			System.Windows.Forms.Label label104 = this.mslbl_logdrive;
			size = new System.Drawing.Size(10, 13);
			label104.Size = size;
			this.mslbl_logdrive.TabIndex = 9;
			this.mslbl_logdrive.Text = "-";
			this.Label27.AutoSize = true;
			System.Windows.Forms.Label label105 = this.Label27;
			location = new System.Drawing.Point(7, 69);
			label105.Location = location;
			this.Label27.Name = "Label27";
			System.Windows.Forms.Label label106 = this.Label27;
			size = new System.Drawing.Size(72, 13);
			label106.Size = size;
			this.Label27.TabIndex = 8;
			this.Label27.Text = "Logical Drive:";
			this.btn_mserase.Enabled = false;
			System.Windows.Forms.Button button105 = this.btn_mserase;
			location = new System.Drawing.Point(413, 43);
			button105.Location = location;
			this.btn_mserase.Name = "btn_mserase";
			System.Windows.Forms.Button button106 = this.btn_mserase;
			size = new System.Drawing.Size(102, 23);
			button106.Size = size;
			this.btn_mserase.TabIndex = 7;
			this.btn_mserase.Text = "Erase Slot";
			this.btn_mserase.UseVisualStyleBackColor = true;
			this.btn_mssave.Enabled = false;
			System.Windows.Forms.Button button107 = this.btn_mssave;
			location = new System.Drawing.Point(413, 15);
			button107.Location = location;
			this.btn_mssave.Name = "btn_mssave";
			System.Windows.Forms.Button button108 = this.btn_mssave;
			size = new System.Drawing.Size(102, 23);
			button108.Size = size;
			this.btn_mssave.TabIndex = 6;
			this.btn_mssave.Text = "Save to Local File";
			this.btn_mssave.UseVisualStyleBackColor = true;
			System.Windows.Forms.TextBox textBox47 = this.mstxb_key;
			location = new System.Drawing.Point(44, 96);
			textBox47.Location = location;
			this.mstxb_key.Name = "mstxb_key";
			System.Windows.Forms.TextBox textBox48 = this.mstxb_key;
			size = new System.Drawing.Size(271, 20);
			textBox48.Size = size;
			this.mstxb_key.TabIndex = 5;
			this.Label30.AutoSize = true;
			System.Windows.Forms.Label label107 = this.Label30;
			location = new System.Drawing.Point(9, 96);
			label107.Location = location;
			this.Label30.Name = "Label30";
			System.Windows.Forms.Label label108 = this.Label30;
			size = new System.Drawing.Size(28, 13);
			label108.Size = size;
			this.Label30.TabIndex = 4;
			this.Label30.Text = "Key:";
			this.mslbl_jobname.AutoSize = true;
			System.Windows.Forms.Label label109 = this.mslbl_jobname;
			location = new System.Drawing.Point(85, 43);
			label109.Location = location;
			this.mslbl_jobname.Name = "mslbl_jobname";
			System.Windows.Forms.Label label110 = this.mslbl_jobname;
			size = new System.Drawing.Size(10, 13);
			label110.Size = size;
			this.mslbl_jobname.TabIndex = 3;
			this.mslbl_jobname.Text = "-";
			this.Label28.AutoSize = true;
			System.Windows.Forms.Label label111 = this.Label28;
			location = new System.Drawing.Point(7, 43);
			label111.Location = location;
			this.Label28.Name = "Label28";
			System.Windows.Forms.Label label112 = this.Label28;
			size = new System.Drawing.Size(58, 13);
			label112.Size = size;
			this.Label28.TabIndex = 2;
			this.Label28.Text = "Job Name:";
			this.mslbl_status.AutoSize = true;
			System.Windows.Forms.Label label113 = this.mslbl_status;
			location = new System.Drawing.Point(85, 20);
			label113.Location = location;
			this.mslbl_status.Name = "mslbl_status";
			System.Windows.Forms.Label label114 = this.mslbl_status;
			size = new System.Drawing.Size(10, 13);
			label114.Size = size;
			this.mslbl_status.TabIndex = 1;
			this.mslbl_status.Text = "-";
			this.Label26.AutoSize = true;
			System.Windows.Forms.Label label115 = this.Label26;
			location = new System.Drawing.Point(7, 20);
			label115.Location = location;
			this.Label26.Name = "Label26";
			System.Windows.Forms.Label label116 = this.Label26;
			size = new System.Drawing.Size(40, 13);
			label116.Size = size;
			this.Label26.TabIndex = 0;
			this.Label26.Text = "Status:";
			System.Windows.Forms.Button button109 = this.Button21;
			location = new System.Drawing.Point(2, 316);
			button109.Location = location;
			this.Button21.Name = "Button21";
			System.Windows.Forms.Button button110 = this.Button21;
			size = new System.Drawing.Size(136, 23);
			button110.Size = size;
			this.Button21.TabIndex = 1;
			this.Button21.Text = "Load Lizard Slots";
			this.Button21.UseVisualStyleBackColor = true;
			System.Windows.Forms.TreeView treeView = this.TreeView1;
			location = new System.Drawing.Point(3, 24);
			treeView.Location = location;
			this.TreeView1.Name = "TreeView1";
			System.Windows.Forms.TreeView treeView2 = this.TreeView1;
			size = new System.Drawing.Size(133, 286);
			treeView2.Size = size;
			this.TreeView1.TabIndex = 0;
			this.TabPage8.Controls.Add(this.GroupBox_2);
			this.TabPage8.Controls.Add(this.GroupBox_1);
			this.TabPage8.Controls.Add(this.GroupBox_0);
			this.TabPage8.Controls.Add(this.GroupBox9);
			this.TabPage8.Controls.Add(this.GroupBox8);
			System.Windows.Forms.TabPage tabPage35 = this.TabPage8;
			location = new System.Drawing.Point(4, 25);
			tabPage35.Location = location;
			this.TabPage8.Name = "TabPage8";
			System.Windows.Forms.TabPage tabPage36 = this.TabPage8;
			padding = new System.Windows.Forms.Padding(3);
			tabPage36.Padding = padding;
			System.Windows.Forms.TabPage tabPage37 = this.TabPage8;
			size = new System.Drawing.Size(673, 416);
			tabPage37.Size = size;
			this.TabPage8.TabIndex = 6;
			this.TabPage8.Text = "Settings";
			this.TabPage8.UseVisualStyleBackColor = true;
			this.GroupBox_2.Controls.Add(this.txbTime);
			this.GroupBox_2.Controls.Add(this.Label33);
			this.GroupBox_2.Controls.Add(this.Label32);
			this.GroupBox_2.Controls.Add(this.txbPeriod);
			this.GroupBox_2.Controls.Add(this.Button45);
			System.Windows.Forms.GroupBox groupBox17 = this.GroupBox_2;
			location = new System.Drawing.Point(280, 118);
			groupBox17.Location = location;
			this.GroupBox_2.Name = "GroupBox12";
			System.Windows.Forms.GroupBox groupBox18 = this.GroupBox_2;
			size = new System.Drawing.Size(158, 82);
			groupBox18.Size = size;
			this.GroupBox_2.TabIndex = 55;
			this.GroupBox_2.TabStop = false;
			this.GroupBox_2.Text = "Lizard Buzzer Test";
			System.Windows.Forms.TextBox textBox49 = this.txbTime;
			location = new System.Drawing.Point(53, 40);
			textBox49.Location = location;
			this.txbTime.Name = "txbTime";
			System.Windows.Forms.TextBox textBox50 = this.txbTime;
			size = new System.Drawing.Size(29, 20);
			textBox50.Size = size;
			this.txbTime.TabIndex = 4;
			this.txbTime.Text = "3";
			this.Label33.AutoSize = true;
			System.Windows.Forms.Label label117 = this.Label33;
			location = new System.Drawing.Point(6, 43);
			label117.Location = location;
			this.Label33.Name = "Label33";
			System.Windows.Forms.Label label118 = this.Label33;
			size = new System.Drawing.Size(33, 13);
			label118.Size = size;
			this.Label33.TabIndex = 3;
			this.Label33.Text = "Time:";
			this.Label32.AutoSize = true;
			System.Windows.Forms.Label label119 = this.Label32;
			location = new System.Drawing.Point(7, 19);
			label119.Location = location;
			this.Label32.Name = "Label32";
			System.Windows.Forms.Label label120 = this.Label32;
			size = new System.Drawing.Size(40, 13);
			label120.Size = size;
			this.Label32.TabIndex = 2;
			this.Label32.Text = "Period:";
			System.Windows.Forms.TextBox textBox51 = this.txbPeriod;
			location = new System.Drawing.Point(53, 16);
			textBox51.Location = location;
			this.txbPeriod.Name = "txbPeriod";
			System.Windows.Forms.TextBox textBox52 = this.txbPeriod;
			size = new System.Drawing.Size(29, 20);
			textBox52.Size = size;
			this.txbPeriod.TabIndex = 1;
			this.txbPeriod.Text = "D0";
			System.Windows.Forms.Button button111 = this.Button45;
			location = new System.Drawing.Point(96, 13);
			button111.Location = location;
			this.Button45.Name = "Button45";
			System.Windows.Forms.Button button112 = this.Button45;
			size = new System.Drawing.Size(56, 23);
			button112.Size = size;
			this.Button45.TabIndex = 0;
			this.Button45.Text = "TEST";
			this.Button45.UseVisualStyleBackColor = true;
			this.GroupBox_1.Controls.Add(this.Button40);
			this.GroupBox_1.Controls.Add(this.Button42);
			this.GroupBox_1.Controls.Add(this.Button41);
			System.Windows.Forms.GroupBox groupBox19 = this.GroupBox_1;
			location = new System.Drawing.Point(444, 118);
			groupBox19.Location = location;
			this.GroupBox_1.Name = "GroupBox11";
			System.Windows.Forms.GroupBox groupBox20 = this.GroupBox_1;
			size = new System.Drawing.Size(200, 82);
			groupBox20.Size = size;
			this.GroupBox_1.TabIndex = 54;
			this.GroupBox_1.TabStop = false;
			this.GroupBox_1.Text = "Unlock Alert";
			System.Windows.Forms.Button button113 = this.Button40;
			location = new System.Drawing.Point(6, 14);
			button113.Location = location;
			this.Button40.Name = "Button40";
			System.Windows.Forms.Button button114 = this.Button40;
			size = new System.Drawing.Size(170, 23);
			button114.Size = size;
			this.Button40.TabIndex = 51;
			this.Button40.Text = "Wait Unlock, Play Sound";
			this.Button40.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button115 = this.Button42;
			location = new System.Drawing.Point(94, 43);
			button115.Location = location;
			this.Button42.Name = "Button42";
			System.Windows.Forms.Button button116 = this.Button42;
			size = new System.Drawing.Size(82, 23);
			button116.Size = size;
			this.Button42.TabIndex = 53;
			this.Button42.Text = "Stop Sound";
			this.Button42.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button117 = this.Button41;
			location = new System.Drawing.Point(6, 43);
			button117.Location = location;
			this.Button41.Name = "Button41";
			System.Windows.Forms.Button button118 = this.Button41;
			size = new System.Drawing.Size(82, 23);
			button118.Size = size;
			this.Button41.TabIndex = 52;
			this.Button41.Text = "Test Sound";
			this.Button41.UseVisualStyleBackColor = true;
			this.GroupBox_0.Controls.Add(this.Button27);
			this.GroupBox_0.Controls.Add(this.LoggerList);
			this.GroupBox_0.Controls.Add(this.sett_rb_usbpowdef);
			this.GroupBox_0.Controls.Add(this.sett_rb_usbpowins);
			this.GroupBox_0.Controls.Add(this.Button26);
			System.Windows.Forms.GroupBox groupBox21 = this.GroupBox_0;
			location = new System.Drawing.Point(3, 206);
			groupBox21.Location = location;
			this.GroupBox_0.Name = "GroupBox10";
			System.Windows.Forms.GroupBox groupBox22 = this.GroupBox_0;
			size = new System.Drawing.Size(641, 204);
			groupBox22.Size = size;
			this.GroupBox_0.TabIndex = 50;
			this.GroupBox_0.TabStop = false;
			this.GroupBox_0.Text = "USB Power Settings";
			System.Windows.Forms.Button button119 = this.Button27;
			location = new System.Drawing.Point(544, 17);
			button119.Location = location;
			this.Button27.Name = "Button27";
			System.Windows.Forms.Button button120 = this.Button27;
			size = new System.Drawing.Size(75, 23);
			button120.Size = size;
			this.Button27.TabIndex = 4;
			this.Button27.Text = "Set";
			this.Button27.UseVisualStyleBackColor = true;
			this.LoggerList.FormattingEnabled = true;
			System.Windows.Forms.ListBox loggerList = this.LoggerList;
			location = new System.Drawing.Point(5, 49);
			loggerList.Location = location;
			this.LoggerList.Name = "LoggerList";
			System.Windows.Forms.ListBox loggerList2 = this.LoggerList;
			size = new System.Drawing.Size(623, 121);
			loggerList2.Size = size;
			this.LoggerList.TabIndex = 3;
			this.sett_rb_usbpowdef.AutoSize = true;
			System.Windows.Forms.RadioButton radioButton5 = this.sett_rb_usbpowdef;
			location = new System.Drawing.Point(120, 23);
			radioButton5.Location = location;
			this.sett_rb_usbpowdef.Name = "sett_rb_usbpowdef";
			System.Windows.Forms.RadioButton radioButton6 = this.sett_rb_usbpowdef;
			size = new System.Drawing.Size(197, 17);
			radioButton6.Size = size;
			this.sett_rb_usbpowdef.TabIndex = 2;
			this.sett_rb_usbpowdef.TabStop = true;
			this.sett_rb_usbpowdef.Text = "Set Power when Enumerate: Default";
			this.sett_rb_usbpowdef.UseVisualStyleBackColor = true;
			this.sett_rb_usbpowins.AutoSize = true;
			System.Windows.Forms.RadioButton radioButton7 = this.sett_rb_usbpowins;
			location = new System.Drawing.Point(352, 23);
			radioButton7.Location = location;
			this.sett_rb_usbpowins.Name = "sett_rb_usbpowins";
			System.Windows.Forms.RadioButton radioButton8 = this.sett_rb_usbpowins;
			size = new System.Drawing.Size(145, 17);
			radioButton8.Size = size;
			this.sett_rb_usbpowins.TabIndex = 1;
			this.sett_rb_usbpowins.TabStop = true;
			this.sett_rb_usbpowins.Text = "Set Power since Insertion";
			this.sett_rb_usbpowins.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button121 = this.Button26;
			location = new System.Drawing.Point(9, 20);
			button121.Location = location;
			this.Button26.Name = "Button26";
			System.Windows.Forms.Button button122 = this.Button26;
			size = new System.Drawing.Size(75, 23);
			button122.Size = size;
			this.Button26.TabIndex = 0;
			this.Button26.Text = "Query";
			this.Button26.UseVisualStyleBackColor = true;
			this.GroupBox9.Controls.Add(this.Button46);
			this.GroupBox9.Controls.Add(this.Button19);
			this.GroupBox9.Controls.Add(this.Button6);
			System.Windows.Forms.GroupBox groupBox23 = this.GroupBox9;
			location = new System.Drawing.Point(3, 118);
			groupBox23.Location = location;
			this.GroupBox9.Name = "GroupBox9";
			System.Windows.Forms.GroupBox groupBox24 = this.GroupBox9;
			size = new System.Drawing.Size(271, 82);
			groupBox24.Size = size;
			this.GroupBox9.TabIndex = 49;
			this.GroupBox9.TabStop = false;
			this.GroupBox9.Text = "Other Settings/Options";
			System.Windows.Forms.Button button123 = this.Button46;
			location = new System.Drawing.Point(9, 19);
			button123.Location = location;
			this.Button46.Name = "Button46";
			System.Windows.Forms.Button button124 = this.Button46;
			size = new System.Drawing.Size(247, 23);
			button124.Size = size;
			this.Button46.TabIndex = 44;
			this.Button46.Text = "Check Lizard Updates";
			this.ToolTip1.SetToolTip(this.Button46, "This option will check for latest Updates on Lizard components");
			this.Button46.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button125 = this.Button19;
			location = new System.Drawing.Point(134, 48);
			button125.Location = location;
			this.Button19.Name = "Button19";
			System.Windows.Forms.Button button126 = this.Button19;
			size = new System.Drawing.Size(122, 23);
			button126.Size = size;
			this.Button19.TabIndex = 42;
			this.Button19.Text = "Rename My Lizard";
			this.Button19.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button127 = this.Button6;
			location = new System.Drawing.Point(7, 48);
			button127.Location = location;
			this.Button6.Name = "Button6";
			System.Windows.Forms.Button button128 = this.Button6;
			size = new System.Drawing.Size(121, 23);
			button128.Size = size;
			this.Button6.TabIndex = 43;
			this.Button6.Text = "Update Live Counter";
			this.ToolTip1.SetToolTip(this.Button6, resources.GetString("Button6.ToolTip"));
			this.Button6.UseVisualStyleBackColor = true;
			this.GroupBox8.Controls.Add(this.chkTurbo);
			this.GroupBox8.Controls.Add(this.Label31);
			this.GroupBox8.Controls.Add(this.sett_tbxjobspath);
			this.GroupBox8.Controls.Add(this.Button22);
			this.GroupBox8.Controls.Add(this.Button23);
			System.Windows.Forms.GroupBox groupBox25 = this.GroupBox8;
			location = new System.Drawing.Point(3, 6);
			groupBox25.Location = location;
			this.GroupBox8.Name = "GroupBox8";
			System.Windows.Forms.GroupBox groupBox26 = this.GroupBox8;
			size = new System.Drawing.Size(641, 106);
			groupBox26.Size = size;
			this.GroupBox8.TabIndex = 48;
			this.GroupBox8.TabStop = false;
			this.GroupBox8.Text = "Application Settings";
			this.chkTurbo.AutoSize = true;
			this.chkTurbo.Checked = true;
			this.chkTurbo.CheckState = System.Windows.Forms.CheckState.Checked;
			System.Windows.Forms.CheckBox checkBox3 = this.chkTurbo;
			location = new System.Drawing.Point(10, 45);
			checkBox3.Location = location;
			this.chkTurbo.Name = "chkTurbo";
			System.Windows.Forms.CheckBox checkBox4 = this.chkTurbo;
			size = new System.Drawing.Size(217, 17);
			checkBox4.Size = size;
			this.chkTurbo.TabIndex = 44;
			this.chkTurbo.Text = "Enable Burstmode Reads (Gecko 1.06+)";
			this.ToolTip1.SetToolTip(this.chkTurbo, "Require Gecko 1.06, it can double the speed of the Firmware Reads\r\nMake sure you click on Get Device Details");
			this.chkTurbo.UseVisualStyleBackColor = true;
			this.Label31.AutoSize = true;
			System.Windows.Forms.Label label121 = this.Label31;
			location = new System.Drawing.Point(7, 21);
			label121.Location = location;
			this.Label31.Name = "Label31";
			System.Windows.Forms.Label label122 = this.Label31;
			size = new System.Drawing.Size(134, 13);
			label122.Size = size;
			this.Label31.TabIndex = 48;
			this.Label31.Text = "Default Path to Store Jobs:";
			System.Windows.Forms.TextBox textBox53 = this.sett_tbxjobspath;
			location = new System.Drawing.Point(147, 19);
			textBox53.Location = location;
			this.sett_tbxjobspath.Name = "sett_tbxjobspath";
			this.sett_tbxjobspath.ReadOnly = true;
			System.Windows.Forms.TextBox textBox54 = this.sett_tbxjobspath;
			size = new System.Drawing.Size(407, 20);
			textBox54.Size = size;
			this.sett_tbxjobspath.TabIndex = 46;
			System.Windows.Forms.Button button129 = this.Button22;
			location = new System.Drawing.Point(560, 16);
			button129.Location = location;
			this.Button22.Name = "Button22";
			System.Windows.Forms.Button button130 = this.Button22;
			size = new System.Drawing.Size(75, 23);
			button130.Size = size;
			this.Button22.TabIndex = 45;
			this.Button22.Text = "Select";
			this.Button22.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button131 = this.Button23;
			location = new System.Drawing.Point(528, 71);
			button131.Location = location;
			this.Button23.Name = "Button23";
			System.Windows.Forms.Button button132 = this.Button23;
			size = new System.Drawing.Size(107, 23);
			button132.Size = size;
			this.Button23.TabIndex = 47;
			this.Button23.Text = "Save Settings";
			this.Button23.UseVisualStyleBackColor = true;
			this.TabPage_2.Controls.Add(this.TabControl4);
			System.Windows.Forms.TabPage tabPage38 = this.TabPage_2;
			location = new System.Drawing.Point(4, 25);
			tabPage38.Location = location;
			this.TabPage_2.Name = "TabPage12";
			System.Windows.Forms.TabPage tabPage39 = this.TabPage_2;
			padding = new System.Windows.Forms.Padding(3);
			tabPage39.Padding = padding;
			System.Windows.Forms.TabPage tabPage40 = this.TabPage_2;
			size = new System.Drawing.Size(673, 416);
			tabPage40.Size = size;
			this.TabPage_2.TabIndex = 7;
			this.TabPage_2.Text = "Debug";
			this.TabPage_2.UseVisualStyleBackColor = true;
			this.TabControl4.Controls.Add(this.TabPage_3);
			this.TabControl4.Controls.Add(this.TabPage_4);
			System.Windows.Forms.TabControl tabControl9 = this.TabControl4;
			location = new System.Drawing.Point(4, 4);
			tabControl9.Location = location;
			this.TabControl4.Name = "TabControl4";
			this.TabControl4.SelectedIndex = 0;
			System.Windows.Forms.TabControl tabControl10 = this.TabControl4;
			size = new System.Drawing.Size(663, 409);
			tabControl10.Size = size;
			this.TabControl4.TabIndex = 5;
			this.TabPage_3.Controls.Add(this.Button44);
			this.TabPage_3.Controls.Add(this.TextBox_0);
			this.TabPage_3.Controls.Add(this.Button34);
			this.TabPage_3.Controls.Add(this.Button31);
			this.TabPage_3.Controls.Add(this.Button33);
			this.TabPage_3.Controls.Add(this.Button32);
			System.Windows.Forms.TabPage tabPage41 = this.TabPage_3;
			location = new System.Drawing.Point(4, 22);
			tabPage41.Location = location;
			this.TabPage_3.Name = "TabPage13";
			System.Windows.Forms.TabPage tabPage42 = this.TabPage_3;
			padding = new System.Windows.Forms.Padding(3);
			tabPage42.Padding = padding;
			System.Windows.Forms.TabPage tabPage43 = this.TabPage_3;
			size = new System.Drawing.Size(655, 383);
			tabPage43.Size = size;
			this.TabPage_3.TabIndex = 0;
			this.TabPage_3.Text = "UART Monitor";
			this.TabPage_3.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button133 = this.Button44;
			location = new System.Drawing.Point(275, 354);
			button133.Location = location;
			this.Button44.Name = "Button44";
			System.Windows.Forms.Button button134 = this.Button44;
			size = new System.Drawing.Size(75, 23);
			button134.Size = size;
			this.Button44.TabIndex = 48;
			this.Button44.Text = "Button44";
			this.Button44.UseVisualStyleBackColor = true;
			this.TextBox_0.BackColor = System.Drawing.Color.Ivory;
			this.TextBox_0.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.TextBox_0.ForeColor = System.Drawing.Color.Black;
			System.Windows.Forms.TextBox textBox55 = this.TextBox_0;
			location = new System.Drawing.Point(6, 6);
			textBox55.Location = location;
			this.TextBox_0.Multiline = true;
			this.TextBox_0.Name = "TxbUARTLog";
			this.TextBox_0.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox textBox56 = this.TextBox_0;
			size = new System.Drawing.Size(643, 342);
			textBox56.Size = size;
			this.TextBox_0.TabIndex = 0;
			System.Windows.Forms.Button button135 = this.Button34;
			location = new System.Drawing.Point(574, 354);
			button135.Location = location;
			this.Button34.Name = "Button34";
			System.Windows.Forms.Button button136 = this.Button34;
			size = new System.Drawing.Size(75, 23);
			button136.Size = size;
			this.Button34.TabIndex = 4;
			this.Button34.Text = "Save Log...";
			this.Button34.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button137 = this.Button31;
			location = new System.Drawing.Point(3, 354);
			button137.Location = location;
			this.Button31.Name = "Button31";
			System.Windows.Forms.Button button138 = this.Button31;
			size = new System.Drawing.Size(75, 23);
			button138.Size = size;
			this.Button31.TabIndex = 1;
			this.Button31.Text = "Connect";
			this.Button31.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button139 = this.Button33;
			location = new System.Drawing.Point(493, 354);
			button139.Location = location;
			this.Button33.Name = "Button33";
			System.Windows.Forms.Button button140 = this.Button33;
			size = new System.Drawing.Size(75, 23);
			button140.Size = size;
			this.Button33.TabIndex = 3;
			this.Button33.Text = "Clear Log";
			this.Button33.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button141 = this.Button32;
			location = new System.Drawing.Point(84, 354);
			button141.Location = location;
			this.Button32.Name = "Button32";
			System.Windows.Forms.Button button142 = this.Button32;
			size = new System.Drawing.Size(75, 23);
			button142.Size = size;
			this.Button32.TabIndex = 2;
			this.Button32.Text = "Disconnect";
			this.Button32.UseVisualStyleBackColor = true;
			this.TabPage_4.Controls.Add(this.Button39);
			this.TabPage_4.Controls.Add(this.Button38);
			this.TabPage_4.Controls.Add(this.Button37);
			this.TabPage_4.Controls.Add(this.txbCompareLog);
			this.TabPage_4.Controls.Add(this.Button36);
			this.TabPage_4.Controls.Add(this.Button35);
			System.Windows.Forms.TabPage tabPage44 = this.TabPage_4;
			location = new System.Drawing.Point(4, 22);
			tabPage44.Location = location;
			this.TabPage_4.Name = "TabPage14";
			System.Windows.Forms.TabPage tabPage45 = this.TabPage_4;
			padding = new System.Windows.Forms.Padding(3);
			tabPage45.Padding = padding;
			System.Windows.Forms.TabPage tabPage46 = this.TabPage_4;
			size = new System.Drawing.Size(655, 383);
			tabPage46.Size = size;
			this.TabPage_4.TabIndex = 1;
			this.TabPage_4.Text = "DC3-DC4";
			this.TabPage_4.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button143 = this.Button39;
			location = new System.Drawing.Point(373, 7);
			button143.Location = location;
			this.Button39.Name = "Button39";
			System.Windows.Forms.Button button144 = this.Button39;
			size = new System.Drawing.Size(192, 52);
			button144.Size = size;
			this.Button39.TabIndex = 5;
			this.Button39.Text = "Verify File against File...";
			this.Button39.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button145 = this.Button38;
			location = new System.Drawing.Point(175, 36);
			button145.Location = location;
			this.Button38.Name = "Button38";
			System.Windows.Forms.Button button146 = this.Button38;
			size = new System.Drawing.Size(192, 23);
			button146.Size = size;
			this.Button38.TabIndex = 4;
			this.Button38.Text = "Verify Drive against DC4 File...";
			this.Button38.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button147 = this.Button37;
			location = new System.Drawing.Point(175, 7);
			button147.Location = location;
			this.Button37.Name = "Button37";
			System.Windows.Forms.Button button148 = this.Button37;
			size = new System.Drawing.Size(192, 23);
			button148.Size = size;
			this.Button37.TabIndex = 3;
			this.Button37.Text = "Verify Drive against DC3 File...";
			this.Button37.UseVisualStyleBackColor = true;
			this.txbCompareLog.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.TextBox textBox57 = this.txbCompareLog;
			location = new System.Drawing.Point(7, 66);
			textBox57.Location = location;
			this.txbCompareLog.Multiline = true;
			this.txbCompareLog.Name = "txbCompareLog";
			this.txbCompareLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox textBox58 = this.txbCompareLog;
			size = new System.Drawing.Size(642, 295);
			textBox58.Size = size;
			this.txbCompareLog.TabIndex = 2;
			System.Windows.Forms.Button button149 = this.Button36;
			location = new System.Drawing.Point(7, 36);
			button149.Location = location;
			this.Button36.Name = "Button36";
			System.Windows.Forms.Button button150 = this.Button36;
			size = new System.Drawing.Size(162, 23);
			button150.Size = size;
			this.Button36.TabIndex = 1;
			this.Button36.Text = "Read Drive to DC4 File...";
			this.Button36.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button151 = this.Button35;
			location = new System.Drawing.Point(7, 7);
			button151.Location = location;
			this.Button35.Name = "Button35";
			System.Windows.Forms.Button button152 = this.Button35;
			size = new System.Drawing.Size(162, 23);
			button152.Size = size;
			this.Button35.TabIndex = 0;
			this.Button35.Text = "Read Drive to DC3 File...";
			this.Button35.UseVisualStyleBackColor = true;
			this.TabPage_5.Controls.Add(this.Label39);
			this.TabPage_5.Controls.Add(this.Label38);
			this.TabPage_5.Controls.Add(this.Label37);
			this.TabPage_5.Controls.Add(this.GroupBox_4);
			this.TabPage_5.Controls.Add(this.GroupBox_5);
			this.TabPage_5.Controls.Add(this.GroupBox_3);
			System.Windows.Forms.TabPage tabPage47 = this.TabPage_5;
			location = new System.Drawing.Point(4, 25);
			tabPage47.Location = location;
			this.TabPage_5.Name = "TabPage15";
			System.Windows.Forms.TabPage tabPage48 = this.TabPage_5;
			size = new System.Drawing.Size(673, 416);
			tabPage48.Size = size;
			this.TabPage_5.TabIndex = 8;
			this.TabPage_5.Text = "XK3Y-TOOLS";
			this.TabPage_5.UseVisualStyleBackColor = true;
			this.Label39.AutoSize = true;
			System.Windows.Forms.Label label123 = this.Label39;
			location = new System.Drawing.Point(9, 320);
			label123.Location = location;
			this.Label39.Name = "Label39";
			System.Windows.Forms.Label label124 = this.Label39;
			size = new System.Drawing.Size(450, 13);
			label124.Size = size;
			this.Label39.TabIndex = 7;
			this.Label39.Text = "For SLIM: put the Dummy.bin file (preferable generated with Lizard) in a file called \"dummy.bin\"";
			this.Label38.AutoSize = true;
			System.Windows.Forms.Label label125 = this.Label38;
			location = new System.Drawing.Point(9, 307);
			label125.Location = location;
			this.Label38.Name = "Label38";
			System.Windows.Forms.Label label126 = this.Label38;
			size = new System.Drawing.Size(426, 13);
			label126.Size = size;
			this.Label38.TabIndex = 6;
			this.Label38.Text = "For PHAT: put the full dump firmware (custom or original) inside a file called \"firmware.bin\"";
			this.Label37.AutoSize = true;
			System.Windows.Forms.Label label127 = this.Label37;
			location = new System.Drawing.Point(9, 284);
			label127.Location = location;
			this.Label37.Name = "Label37";
			System.Windows.Forms.Label label128 = this.Label37;
			size = new System.Drawing.Size(389, 13);
			label128.Size = size;
			this.Label37.TabIndex = 5;
			this.Label37.Text = "XKEY require the dvd drive information is stored as follows on the board SD Card:";
			this.GroupBox_4.Controls.Add(this.Label36);
			this.GroupBox_4.Controls.Add(this.Button50);
			this.GroupBox_4.Controls.Add(this.Label35);
			this.GroupBox_4.Controls.Add(this.cmbxkeydash);
			System.Windows.Forms.GroupBox groupBox27 = this.GroupBox_4;
			location = new System.Drawing.Point(425, 3);
			groupBox27.Location = location;
			this.GroupBox_4.Name = "GroupBox15";
			System.Windows.Forms.GroupBox groupBox28 = this.GroupBox_4;
			size = new System.Drawing.Size(240, 139);
			groupBox28.Size = size;
			this.GroupBox_4.TabIndex = 4;
			this.GroupBox_4.TabStop = false;
			this.GroupBox_4.Text = "DAE.bin";
			System.Windows.Forms.Label label129 = this.Label36;
			location = new System.Drawing.Point(7, 91);
			label129.Location = location;
			this.Label36.Name = "Label36";
			System.Windows.Forms.Label label130 = this.Label36;
			size = new System.Drawing.Size(227, 45);
			label130.Size = size;
			this.Label36.TabIndex = 5;
			this.Label36.Text = "*This is Just a link referer service.  You are responsible for download the file and install on your HDD (under \\games folder)";
			System.Windows.Forms.Button button153 = this.Button50;
			location = new System.Drawing.Point(6, 43);
			button153.Location = location;
			this.Button50.Name = "Button50";
			System.Windows.Forms.Button button154 = this.Button50;
			size = new System.Drawing.Size(228, 41);
			button154.Size = size;
			this.Button50.TabIndex = 4;
			this.Button50.Text = "Grab Link";
			this.Button50.UseVisualStyleBackColor = true;
			this.Label35.AutoSize = true;
			System.Windows.Forms.Label label131 = this.Label35;
			location = new System.Drawing.Point(7, 19);
			label131.Location = location;
			this.Label35.Name = "Label35";
			System.Windows.Forms.Label label132 = this.Label35;
			size = new System.Drawing.Size(35, 13);
			label132.Size = size;
			this.Label35.TabIndex = 1;
			this.Label35.Text = "Dash:";
			this.cmbxkeydash.FormattingEnabled = true;
			this.cmbxkeydash.Items.AddRange(new object[1] { "13599" });
			System.Windows.Forms.ComboBox comboBox13 = this.cmbxkeydash;
			location = new System.Drawing.Point(71, 16);
			comboBox13.Location = location;
			this.cmbxkeydash.Name = "cmbxkeydash";
			System.Windows.Forms.ComboBox comboBox14 = this.cmbxkeydash;
			size = new System.Drawing.Size(163, 21);
			comboBox14.Size = size;
			this.cmbxkeydash.TabIndex = 0;
			this.GroupBox_5.Controls.Add(this.txbxkeyUNIQUE);
			this.GroupBox_5.Controls.Add(this.Label47);
			this.GroupBox_5.Controls.Add(this.TextBox_1);
			this.GroupBox_5.Controls.Add(this.Label46);
			this.GroupBox_5.Controls.Add(this.TextBox_2);
			this.GroupBox_5.Controls.Add(this.Label45);
			this.GroupBox_5.Controls.Add(this.Button49);
			this.GroupBox_5.Controls.Add(this.chkxkey0225U);
			this.GroupBox_5.Controls.Add(this.chkxkeyMENUISO);
			this.GroupBox_5.Controls.Add(this.Label34);
			this.GroupBox_5.Controls.Add(this.cmbxkeylang);
			System.Windows.Forms.GroupBox groupBox29 = this.GroupBox_5;
			location = new System.Drawing.Point(214, 3);
			groupBox29.Location = location;
			this.GroupBox_5.Name = "GroupBox14";
			System.Windows.Forms.GroupBox groupBox30 = this.GroupBox_5;
			size = new System.Drawing.Size(205, 217);
			groupBox30.Size = size;
			this.GroupBox_5.TabIndex = 3;
			this.GroupBox_5.TabStop = false;
			this.GroupBox_5.Text = "xkey.cfg generation";
			System.Windows.Forms.TextBox textBox59 = this.txbxkeyUNIQUE;
			location = new System.Drawing.Point(87, 142);
			textBox59.Location = location;
			this.txbxkeyUNIQUE.Name = "txbxkeyUNIQUE";
			System.Windows.Forms.TextBox textBox60 = this.txbxkeyUNIQUE;
			size = new System.Drawing.Size(105, 20);
			textBox60.Size = size;
			this.txbxkeyUNIQUE.TabIndex = 10;
			this.ToolTip1.SetToolTip(this.txbxkeyUNIQUE, "The Unique Key of your xk3y WiFi Dongle");
			this.Label47.AutoSize = true;
			System.Windows.Forms.Label label133 = this.Label47;
			location = new System.Drawing.Point(10, 145);
			label133.Location = location;
			this.Label47.Name = "Label47";
			System.Windows.Forms.Label label134 = this.Label47;
			size = new System.Drawing.Size(71, 13);
			label134.Size = size;
			this.Label47.TabIndex = 9;
			this.Label47.Text = "Xk3y Unique:";
			System.Windows.Forms.TextBox textBox61 = this.TextBox_1;
			location = new System.Drawing.Point(87, 116);
			textBox61.Location = location;
			this.TextBox_1.Name = "txbxkeyPWD";
			this.TextBox_1.PasswordChar = '*';
			System.Windows.Forms.TextBox textBox62 = this.TextBox_1;
			size = new System.Drawing.Size(105, 20);
			textBox62.Size = size;
			this.TextBox_1.TabIndex = 8;
			this.ToolTip1.SetToolTip(this.TextBox_1, "This is the password you use to connect to your WiFi Network");
			this.Label46.AutoSize = true;
			System.Windows.Forms.Label label135 = this.Label46;
			location = new System.Drawing.Point(10, 119);
			label135.Location = location;
			this.Label46.Name = "Label46";
			System.Windows.Forms.Label label136 = this.Label46;
			size = new System.Drawing.Size(56, 13);
			label136.Size = size;
			this.Label46.TabIndex = 7;
			this.Label46.Text = "Password:";
			System.Windows.Forms.TextBox textBox63 = this.TextBox_2;
			location = new System.Drawing.Point(87, 91);
			textBox63.Location = location;
			this.TextBox_2.Name = "txbxkeySSID";
			System.Windows.Forms.TextBox textBox64 = this.TextBox_2;
			size = new System.Drawing.Size(105, 20);
			textBox64.Size = size;
			this.TextBox_2.TabIndex = 6;
			this.ToolTip1.SetToolTip(this.TextBox_2, "This is the Broadcast name of your Network");
			this.Label45.AutoSize = true;
			System.Windows.Forms.Label label137 = this.Label45;
			location = new System.Drawing.Point(10, 94);
			label137.Location = location;
			this.Label45.Name = "Label45";
			System.Windows.Forms.Label label138 = this.Label45;
			size = new System.Drawing.Size(59, 13);
			label138.Size = size;
			this.Label45.TabIndex = 5;
			this.Label45.Text = "WiFi SSID:";
			System.Windows.Forms.Button button155 = this.Button49;
			location = new System.Drawing.Point(2, 168);
			button155.Location = location;
			this.Button49.Name = "Button49";
			System.Windows.Forms.Button button156 = this.Button49;
			size = new System.Drawing.Size(190, 41);
			button156.Size = size;
			this.Button49.TabIndex = 4;
			this.Button49.Text = "Generate";
			this.Button49.UseVisualStyleBackColor = true;
			this.chkxkey0225U.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox5 = this.chkxkey0225U;
			location = new System.Drawing.Point(10, 66);
			checkBox5.Location = location;
			this.chkxkey0225U.Name = "chkxkey0225U";
			System.Windows.Forms.CheckBox checkBox6 = this.chkxkey0225U;
			size = new System.Drawing.Size(58, 17);
			checkBox6.Size = size;
			this.chkxkey0225U.TabIndex = 3;
			this.chkxkey0225U.Text = "0225U";
			this.chkxkey0225U.UseVisualStyleBackColor = true;
			this.chkxkey0225U.Visible = false;
			this.chkxkeyMENUISO.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox7 = this.chkxkeyMENUISO;
			location = new System.Drawing.Point(10, 43);
			checkBox7.Location = location;
			this.chkxkeyMENUISO.Name = "chkxkeyMENUISO";
			System.Windows.Forms.CheckBox checkBox8 = this.chkxkeyMENUISO;
			size = new System.Drawing.Size(74, 17);
			checkBox8.Size = size;
			this.chkxkeyMENUISO.TabIndex = 2;
			this.chkxkeyMENUISO.Text = "Menu ISO";
			this.chkxkeyMENUISO.UseVisualStyleBackColor = true;
			this.Label34.AutoSize = true;
			System.Windows.Forms.Label label139 = this.Label34;
			location = new System.Drawing.Point(7, 19);
			label139.Location = location;
			this.Label34.Name = "Label34";
			System.Windows.Forms.Label label140 = this.Label34;
			size = new System.Drawing.Size(58, 13);
			label140.Size = size;
			this.Label34.TabIndex = 1;
			this.Label34.Text = "Language:";
			this.cmbxkeylang.FormattingEnabled = true;
			this.cmbxkeylang.Items.AddRange(new object[9] { "ENGLISH (ENG)", "SPANISH (ESP)", "GERMAN (DEU)", "ITALIAN (ITA)", "SWEDISH (SWD)", "PORTUGUESE (PGS)", "DUTCH (NDL)", "TCHINESE (TCN)", "SCHINESE (SCN)" });
			System.Windows.Forms.ComboBox comboBox15 = this.cmbxkeylang;
			location = new System.Drawing.Point(71, 16);
			comboBox15.Location = location;
			this.cmbxkeylang.Name = "cmbxkeylang";
			System.Windows.Forms.ComboBox comboBox16 = this.cmbxkeylang;
			size = new System.Drawing.Size(121, 21);
			comboBox16.Size = size;
			this.cmbxkeylang.TabIndex = 0;
			this.GroupBox_3.Controls.Add(this.Label40);
			this.GroupBox_3.Controls.Add(this.Button48);
			this.GroupBox_3.Controls.Add(this.Button47);
			System.Windows.Forms.GroupBox groupBox31 = this.GroupBox_3;
			location = new System.Drawing.Point(3, 3);
			groupBox31.Location = location;
			this.GroupBox_3.Name = "GroupBox13";
			System.Windows.Forms.GroupBox groupBox32 = this.GroupBox_3;
			size = new System.Drawing.Size(205, 191);
			groupBox32.Size = size;
			this.GroupBox_3.TabIndex = 2;
			this.GroupBox_3.TabStop = false;
			this.GroupBox_3.Text = "Dummy Conversion/Generation";
			System.Windows.Forms.Label label141 = this.Label40;
			location = new System.Drawing.Point(6, 110);
			label141.Location = location;
			this.Label40.Name = "Label40";
			System.Windows.Forms.Label label142 = this.Label40;
			size = new System.Drawing.Size(190, 49);
			label142.Size = size;
			this.Label40.TabIndex = 6;
			this.Label40.Text = "* To generate a Full dump from a Dummy file use the CFW Generator Tab";
			System.Windows.Forms.Button button157 = this.Button48;
			location = new System.Drawing.Point(6, 66);
			button157.Location = location;
			this.Button48.Name = "Button48";
			System.Windows.Forms.Button button158 = this.Button48;
			size = new System.Drawing.Size(190, 41);
			button158.Size = size;
			this.Button48.TabIndex = 1;
			this.Button48.Text = "Generate Dummy.bin from FULL DUMP";
			this.Button48.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button button159 = this.Button47;
			location = new System.Drawing.Point(9, 19);
			button159.Location = location;
			this.Button47.Name = "Button47";
			System.Windows.Forms.Button button160 = this.Button47;
			size = new System.Drawing.Size(190, 41);
			button160.Size = size;
			this.Button47.TabIndex = 0;
			this.Button47.Text = "Convert OLD or Incomplete Dummy to Dummy V3";
			this.Button47.UseVisualStyleBackColor = true;
			this.ToolTip1.AutoPopDelay = 10000;
			this.ToolTip1.InitialDelay = 500;
			this.ToolTip1.IsBalloon = true;
			this.ToolTip1.ReshowDelay = 100;
			this.ToolTip1.ShowAlways = true;
			this.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ToolTip1.ToolTipTitle = "Help:";
			this.MNU_MAN_EDIT.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.SMOAV_DSTEDIT_LOADF_FILE, this.SMOAV_DSTEDIT_LOADF_FW, this.SMOAV_DSTEDIT_MAN_EDIT, this.ToolStripSeparator1, this.SMOAV_DSTEDIT_GOBACK });
			this.MNU_MAN_EDIT.Name = "MNU_MAN_EDIT";
			System.Windows.Forms.ContextMenuStrip mNU_MAN_EDIT = this.MNU_MAN_EDIT;
			size = new System.Drawing.Size(222, 98);
			mNU_MAN_EDIT.Size = size;
			this.MNU_MAN_EDIT.Text = "Key Load Options";
			this.SMOAV_DSTEDIT_LOADF_FILE.Name = "SMOAV_DSTEDIT_LOADF_FILE";
			System.Windows.Forms.ToolStripMenuItem sMOAV_DSTEDIT_LOADF_FILE = this.SMOAV_DSTEDIT_LOADF_FILE;
			size = new System.Drawing.Size(221, 22);
			sMOAV_DSTEDIT_LOADF_FILE.Size = size;
			this.SMOAV_DSTEDIT_LOADF_FILE.Text = "Load from KEY.bin file ...";
			this.SMOAV_DSTEDIT_LOADF_FW.Name = "SMOAV_DSTEDIT_LOADF_FW";
			System.Windows.Forms.ToolStripMenuItem sMOAV_DSTEDIT_LOADF_FW = this.SMOAV_DSTEDIT_LOADF_FW;
			size = new System.Drawing.Size(221, 22);
			sMOAV_DSTEDIT_LOADF_FW.Size = size;
			this.SMOAV_DSTEDIT_LOADF_FW.Text = "Load from another FW file...";
			this.SMOAV_DSTEDIT_MAN_EDIT.Name = "SMOAV_DSTEDIT_MAN_EDIT";
			System.Windows.Forms.ToolStripMenuItem sMOAV_DSTEDIT_MAN_EDIT = this.SMOAV_DSTEDIT_MAN_EDIT;
			size = new System.Drawing.Size(221, 22);
			sMOAV_DSTEDIT_MAN_EDIT.Size = size;
			this.SMOAV_DSTEDIT_MAN_EDIT.Text = "Allow me type Manually";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			System.Windows.Forms.ToolStripSeparator toolStripSeparator = this.ToolStripSeparator1;
			size = new System.Drawing.Size(218, 6);
			toolStripSeparator.Size = size;
			this.SMOAV_DSTEDIT_GOBACK.Name = "SMOAV_DSTEDIT_GOBACK";
			System.Windows.Forms.ToolStripMenuItem sMOAV_DSTEDIT_GOBACK = this.SMOAV_DSTEDIT_GOBACK;
			size = new System.Drawing.Size(221, 22);
			sMOAV_DSTEDIT_GOBACK.Size = size;
			this.SMOAV_DSTEDIT_GOBACK.Text = "Go Back";
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "Computer_File_053.gif");
			this.ImageList1.Images.SetKeyName(1, "Computer_File_077.gif");
			this.ImageList1.Images.SetKeyName(2, "People_014.gif");
			this.ImageList1.Images.SetKeyName(3, "Application.gif");
			System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(693, 482);
			this.ClientSize = size;
			this.Controls.Add(this.StatusStrip1);
			this.Controls.Add(this.TabControl1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lizard Toolbox *BETA*";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.GroupBox_6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			this.TabPage3.ResumeLayout(false);
			this.TabControl2.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.TabPage4.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.TabPage_6.ResumeLayout(false);
			this.TabControl5.ResumeLayout(false);
			this.TabPage_7.ResumeLayout(false);
			this.TabPage_7.PerformLayout();
			this.TabPage_8.ResumeLayout(false);
			this.TabPage_8.PerformLayout();
			this.TabPage6.ResumeLayout(false);
			this.TabPage6.PerformLayout();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox6.PerformLayout();
			this.TabPage7.ResumeLayout(false);
			this.TabPage7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.picsync3).EndInit();
			((System.ComponentModel.ISupportInitialize)this.picsync2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.picsync1).EndInit();
			this.GroupBox7.ResumeLayout(false);
			this.GroupBox7.PerformLayout();
			this.TabControl3.ResumeLayout(false);
			this.TabPage9.ResumeLayout(false);
			this.TabPage9.PerformLayout();
			this.TabPage_0.ResumeLayout(false);
			this.TabPage_0.PerformLayout();
			this.TabPage_1.ResumeLayout(false);
			this.TabPage_1.PerformLayout();
			this.TabPage8.ResumeLayout(false);
			this.GroupBox_2.ResumeLayout(false);
			this.GroupBox_2.PerformLayout();
			this.GroupBox_1.ResumeLayout(false);
			this.GroupBox_0.ResumeLayout(false);
			this.GroupBox_0.PerformLayout();
			this.GroupBox9.ResumeLayout(false);
			this.GroupBox8.ResumeLayout(false);
			this.GroupBox8.PerformLayout();
			this.TabPage_2.ResumeLayout(false);
			this.TabControl4.ResumeLayout(false);
			this.TabPage_3.ResumeLayout(false);
			this.TabPage_3.PerformLayout();
			this.TabPage_4.ResumeLayout(false);
			this.TabPage_4.PerformLayout();
			this.TabPage_5.ResumeLayout(false);
			this.TabPage_5.PerformLayout();
			this.GroupBox_4.ResumeLayout(false);
			this.GroupBox_4.PerformLayout();
			this.GroupBox_5.ResumeLayout(false);
			this.GroupBox_5.PerformLayout();
			this.GroupBox_3.ResumeLayout(false);
			this.MNU_MAN_EDIT.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void Form1_Load(object sender, EventArgs e)
		{
			Text += " 1.60";
			bool_0 = false;
			if (!utmuBufTB())
			{
				ProjectData.EndApp();
			}
			if (Conversions.ToDouble(Interaction.GetSetting("LIZ_TBX", "Settings", "GLOBAL_COUNT", Conversions.ToString(0))) == 0.0)
			{
				Interaction.SaveSetting("LIZ_TBX", "Settings", "GLOBAL_COUNT", Conversions.ToString(0));
			}
			if (Conversions.ToDouble(Interaction.GetSetting("LIZ_TBX", "Settings", "TEMP_COUNT", Conversions.ToString(0))) == 0.0)
			{
				Interaction.SaveSetting("LIZ_TBX", "Settings", "TEMP_COUNT", Conversions.ToString(0));
			}
			double_3 = ToolboxUtilities.smethod_27("1.60");
			double_4 = 0.0;
			method_0();
			if (int_4 == 0 && Interaction.MsgBox("You want to download latest CFW Filesets Now?\r\nIf you choose not download now you can get them later on the Easy View tab of the CFW Generator Pane", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Question") == MsgBoxResult.Yes)
			{
				Process.Start("http://cfwfileset.blogspot.com/");
			}
			method_23();
			LoadAppSettings();
			SerialPort1.DataBits = 8;
			SerialPort1.Parity = Parity.None;
			SerialPort1.StopBits = StopBits.One;
			SerialPort1.Handshake = Handshake.None;
			SerialPort1.ReadTimeout = 1000;
			SerialPort1.WriteTimeout = 1000;
			init_controls();
			bool_2 = false;
			cmbxkeylang.SelectedIndex = 0;
			cmbxkeydash.SelectedIndex = 0;
			picsync1.Image = ImageList1.Images[0];
			picsync2.Image = ImageList1.Images[3];
			picsync3.Image = ImageList1.Images[2];
		}

		public void init_controls()
		{
			cmbAV_DstLogDrive.Items.Add("[SELECT]");
			cmbAV_DstLogDrive.Items.Add("HITACHI-GDR3120L-32");
			cmbAV_DstLogDrive.Items.Add("HITACHI-GDR3120L-36");
			cmbAV_DstLogDrive.Items.Add("HITACHI-GDR3120L-40");
			cmbAV_DstLogDrive.Items.Add("HITACHI-GDR3120L-46");
			cmbAV_DstLogDrive.Items.Add("HITACHI-GDR3120L-47");
			cmbAV_DstLogDrive.Items.Add("HITACHI-GDR3120L-58");
			cmbAV_DstLogDrive.Items.Add("HITACHI-GDR3120L-59");
			cmbAV_DstLogDrive.Items.Add("HITACHI-GDR3120L-78");
			cmbAV_DstLogDrive.Items.Add("HITACHI-GDR3120L-79");
			cmbAV_DstLogDrive.Items.Add("SAMSUNG-TSH943A-MS25");
			cmbAV_DstLogDrive.Items.Add("SAMSUNG-TSH943A-MS28");
			cmbAV_DstLogDrive.Items.Add("BENQ-VAD6038-62430");
			cmbAV_DstLogDrive.Items.Add("BENQ-VAD6038-64930");
			cmbAV_DstLogDrive.Items.Add("BENQ-VAD6038-04421");
			cmbAV_DstLogDrive.Items.Add("LITEON-DG16D2S-74850");
			cmbAV_DstLogDrive.Items.Add("LITEON-DG16D2S-83850");
			cmbAV_DstLogDrive.Items.Add("LITEON-DG16D2S-83850V2");
			cmbAV_DstLogDrive.Items.Add("LITEON-DG16D2S-93450");
			cmbAV_DstLogDrive.Items.Add("LITEON-DG16D2S-02510");
			cmbAV_DstLogDrive.Items.Add("LITEON-DG16D4S-9504");
			cmbAV_DstLogDrive.Items.Add("LITEON-DG16D4S-0272");
			cmbAV_DstLogDrive.Items.Add("LITEON-DG16D4S-0225");
			cmbAV_DstLogDrive.SelectedIndex = 0;
			init_templatecombo();
		}

		public void init_templatecombo()
		{
			cmbEV_DstCFWTemplate.Items.Clear();
			cmbEV_DstCFWTemplate.Items.Add("[SELECT]");
			cmbLTUFileset.Items.Clear();
			cmbLTUFileset.Items.Add("[SELECT]");
			cmbLTU2Fileset.Items.Clear();
			cmbLTU2Fileset.Items.Add("[SELECT]");
			int num = int_4 - 1;
			for (int i = 0; i <= num; i++)
			{
				cmbEV_DstCFWTemplate.Items.Add(struct3_0[i].string_0);
				cmbLTUFileset.Items.Add(struct3_0[i].string_0);
				cmbLTU2Fileset.Items.Add(struct3_0[i].string_0);
			}
			cmbEV_DstCFWTemplate.SelectedIndex = 0;
			cmbLTUFileset.SelectedIndex = 0;
			cmbLTU2Fileset.SelectedIndex = 0;
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void method_0()
		{
			string pathName = Application.StartupPath + "\\CFW_Templates\\";
			string text = FileSystem.Dir(pathName);
			int_4 = 0;
			CfwTemplateParser.Struct3 @struct = default(CfwTemplateParser.Struct3);
			@struct.string_0 = "";
			@struct.string_1 = "";
			@struct.string_2 = "";
			@struct.string_3 = "";
			while (Operators.CompareString(text, "", false) != 0)
			{
				string text2 = Application.StartupPath + "\\CFW_Templates\\" + text;
				if (CfwTemplateParser.smethod_0(text2, ref @struct))
				{
					struct3_0 = (CfwTemplateParser.Struct3[])Utils.CopyArray(struct3_0, new CfwTemplateParser.Struct3[int_4 + 1]);
					struct3_0[int_4] = @struct;
					int_4++;
				}
				text = FileSystem.Dir();
			}
			bool flag = false;
			double_0 = 0.0;
			int num = int_4 - 1;
			for (int i = 0; i <= num; i++)
			{
				if ((Strings.InStr(struct3_0[i].string_0, "LTPLUS", CompareMethod.Text) != 0) & (decimal.Compare(Convert.ToDecimal(struct3_0[i].string_2), 116m) >= 0))
				{
					double_0 = Convert.ToDouble(Convert.ToDecimal(struct3_0[i].string_2));
					string_3 = struct3_0[i].string_3;
					flag = true;
				}
			}
			if (!flag && Interaction.MsgBox("Please download the latest LT Plus Fileset\r\nYou can use the Settings->Check Lizard Updates option\r\nAlso you can manually download the Filesets from http://cfwfileset.blogspot.com/\r\nWithout those files this application will not allow full functionallity\r\nDo you want to visit the Website now?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Your Filesets are too OLD") == MsgBoxResult.Yes)
			{
				Process.Start("http://cfwfileset.blogspot.com/");
			}
			flag = false;
			double_2 = 0.0;
			int num2 = int_4 - 1;
			for (int i = 0; i <= num2; i++)
			{
				if ((Strings.InStr(struct3_0[i].string_0, "LTU", CompareMethod.Text) != 0) & (decimal.Compare(Convert.ToDecimal(struct3_0[i].string_2), 118m) >= 0))
				{
					double_2 = Convert.ToDouble(Convert.ToDecimal(struct3_0[i].string_2));
					string_4 = struct3_0[i].string_3;
					flag = true;
				}
			}
			if (!flag && Interaction.MsgBox("Please download the latest LTU Fileset\r\nYou can use the Settings->Check Lizard Updates option\r\nAlso you can manually download the Filesets from http://cfwfileset.blogspot.com/\r\nWithout those files this application will not allow full functionallity\r\nDo you want to visit the Website now?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Your Filesets are too OLD") == MsgBoxResult.Yes)
			{
				Process.Start("http://cfwfileset.blogspot.com/");
			}
			flag = false;
			double_1 = 0.0;
			int num3 = int_4 - 1;
			for (int i = 0; i <= num3; i++)
			{
				if ((Strings.InStr(struct3_0[i].string_0, "Original", CompareMethod.Text) != 0) & (decimal.Compare(Convert.ToDecimal(struct3_0[i].string_2), 106m) >= 0))
				{
					double_1 = Convert.ToDouble(Convert.ToDecimal(struct3_0[i].string_2));
					string_2 = struct3_0[i].string_3;
					flag = true;
				}
			}
			if (!flag && Interaction.MsgBox("Please download the latest Original Fileset\r\nYou can use the Settings->Check Lizard Updates option\r\nAlso you can manually download the Filesets from http://cfwfileset.blogspot.com/\r\nWithout those files this application will not allow full functionallity\r\nDo you want to visit the Website now?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Your Filesets are too OLD") == MsgBoxResult.Yes)
			{
				Process.Start("http://cfwfileset.blogspot.com/");
			}
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private bool utmuBufTB()
		{
			if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\graph.dll"), "", false) == 0)
			{
				Interaction.MsgBox("The file " + Application.StartupPath + "\\graph.dll does not exists", MsgBoxStyle.Exclamation, "Missing File");
				return false;
			}
			if (FileSystem.FileLen(Application.StartupPath + "\\graph.dll") < 883939L)
			{
				Interaction.MsgBox("Some Files seems old, make sure you are extracting full release contents on the folder", MsgBoxStyle.Exclamation, "Old Files Detected");
				return false;
			}
			if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\CFW_Templates", FileAttribute.Directory), "", false) == 0)
			{
				Interaction.MsgBox("The folder " + Application.StartupPath + "\\CFW_Templates does not exists", MsgBoxStyle.Exclamation, "Missing Folder");
				return false;
			}
			if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\Soup.exe"), "", false) == 0)
			{
				Interaction.MsgBox("The file " + Application.StartupPath + "\\Soup.exe does not exists", MsgBoxStyle.Exclamation, "Missing File");
				return false;
			}
			if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\unlocksound.wav"), "", false) == 0)
			{
				Interaction.MsgBox("The file " + Application.StartupPath + "\\unlocksound.wav does not exists", MsgBoxStyle.Exclamation, "Missing File");
				return false;
			}
			if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\crxt.bin"), "", false) == 0)
			{
				Interaction.MsgBox("The file " + Application.StartupPath + "\\crxt.bin does not exists", MsgBoxStyle.Exclamation, "Missing File");
				return false;
			}
			return true;
		}

		private void method_1(object sender, EventArgs e)
		{
			cmd_SPIF_QUERY();
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public bool method_2(ref byte[] buf, ref byte bheight, ref byte bwidth, ref int size, string sfile, bool Invertbits = true)
		{
			FileSystem.FileOpen(1, sfile, OpenMode.Binary);
			ValueType Value = struct0_0;
			FileSystem.FileGet(1, ref Value);
			ValueType valueType = Value;
			BitmapHeaders.BitmapFileHeader @struct = default(BitmapHeaders.BitmapFileHeader);
			struct0_0 = ((valueType != null) ? ((BitmapHeaders.BitmapFileHeader)valueType) : @struct);
			Value = struct1_0;
			FileSystem.FileGet(1, ref Value);
			ValueType valueType2 = Value;
			BitmapHeaders.BitmapInfoHeader struct2 = default(BitmapHeaders.BitmapInfoHeader);
			struct1_0 = ((valueType2 != null) ? ((BitmapHeaders.BitmapInfoHeader)valueType2) : struct2);
			FileSystem.FileClose(1);
			if (struct0_0.short_0 != 19778)
			{
				Interaction.MsgBox("BMP File not detected", MsgBoxStyle.Exclamation, "Error:");
				return false;
			}
			if (struct1_0.int_0 != 40)
			{
				Interaction.MsgBox("Bitmap Information Header Size Wrong value, Make sure its a valid Bitmap File", MsgBoxStyle.Exclamation, "Error:");
				return false;
			}
			if (struct1_0.short_0 != 1)
			{
				Interaction.MsgBox("Only Monocromatic (1 bit per pixel) Bitmap files supported", MsgBoxStyle.Exclamation, "Error:");
				return false;
			}
			if (struct1_0.int_3 != 0)
			{
				Interaction.MsgBox("Only Uncompressed Bitmap files supported", MsgBoxStyle.Exclamation, "Error:");
				return false;
			}
			bheight = (byte)struct1_0.int_2;
			bwidth = (byte)struct1_0.int_1;
			int num = struct1_0.int_1 / 8;
			int num2 = Conversions.ToInteger(Interaction.IIf(num % 4 > 0, 4 - num % 4, 0));
			int num3 = Conversions.ToInteger(Interaction.IIf(struct1_0.int_2 % 8 > 0, 8 - struct1_0.int_2 % 8, 0));
			byte[,] array = new byte[struct1_0.int_2 + num3 - 1 + 1, num - 1 + 1];
			FileStream fileStream = new FileStream(sfile, FileMode.Open);
			fileStream.Seek(struct0_0.int_1, SeekOrigin.Begin);
			for (int i = struct1_0.int_2 - 1; i >= 0; i += -1)
			{
				int num4 = num - 1;
				for (int j = 0; j <= num4; j++)
				{
					byte b = (byte)fileStream.ReadByte();
					if (struct1_0.int_9 == 0)
					{
						array[i, j] = Conversions.ToByte(Interaction.IIf(Invertbits, (byte)(~b), b));
					}
					else
					{
						array[i, j] = Conversions.ToByte(Interaction.IIf(Invertbits, b, (byte)(~b)));
					}
				}
				int num5 = num2;
				for (int k = 1; k <= num5; k++)
				{
					fileStream.ReadByte();
				}
			}
			fileStream.Close();
			int num6 = (struct1_0.int_2 + num3) / 8;
			int num7 = Conversions.ToInteger(Operators.AddObject(struct1_0.int_1 / 8, Interaction.IIf(struct1_0.int_1 % 8 != 0, 1, 0)));
			num7 *= 8;
			byte[,] array2 = new byte[num6 - 1 + 1, num7 - 1 + 1];
			int num8 = num6 - 1;
			int num10 = default(int);
			for (int l = 0; l <= num8; l++)
			{
				int num9 = struct1_0.int_1 - 1;
				for (int j = 0; j <= num9; j++)
				{
					array2[l, num10 * 8 + j] = 0;
					int i = 0;
					do
					{
						byte b = array[l * 8 + i, j / 8];
						byte b2 = getbit(b, j % 8);
						array2[l, j] = (byte)(array2[l, j] | (long)Math.Round((double)(int)b2 * Math.Pow(2.0, i)));
						i++;
					}
					while (i <= 7);
				}
			}
			int num11 = num6 - 1;
			for (int i = 0; i <= num11; i++)
			{
				int num12 = num7 / 8 - 1;
				for (int j = 0; j <= num12; j++)
				{
					int l = 0;
					do
					{
						byte b = array2[i, j * 8 + (7 - l)];
						array2[i, j * 8 + (7 - l)] = array2[i, j * 8 + l];
						array2[i, j * 8 + l] = b;
						l++;
					}
					while (l <= 3);
				}
			}
			buf = new byte[num6 * num7 - 1 + 1];
			int num13 = num6 - 1;
			for (int i = 0; i <= num13; i++)
			{
				string text = "";
				int num14 = struct1_0.int_1 - 1;
				for (int j = 0; j <= num14; j++)
				{
					text = text + ToolboxUtilities.smethod_2(array2[i, j]) + " ";
					buf[i * num7 + j] = array2[i, j];
				}
			}
			size = num6 * num7;
			return true;
		}

		public byte getbit(byte bbyte, int numbit)
		{
			byte b = bbyte;
			for (int i = 1; i <= numbit; i++)
			{
				b /= 2;
			}
			return (byte)(b & 1);
		}

		public object maskbit(byte bbyte, int numbit)
		{
			byte b = 1;
			for (int i = 1; i <= numbit; i++)
			{
				b *= 2;
			}
			return (byte)(bbyte & b);
		}

		private void method_3(object sender, EventArgs e)
		{
			cmd_SPIF_QUERY();
		}

		public void cmd_SPIF_QUERY()
		{
			SerialPort1.PortName = "COM4";
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 2000;
			byte[] array = new byte[4];
			byte[] buf = new byte[11];
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			array[0] = 64;
			array[1] = 85;
			array[2] = 90;
			array[3] = 64;
			try
			{
				SerialPort1.Write(array, 0, 4);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
				ProjectData.ClearProjectError();
			}
			if (ReadUSARTw_to(ref buf, 3))
			{
				if (buf[2] == 6)
				{
					Label1.Text = ToolboxUtilities.smethod_2(buf[0]) + ToolboxUtilities.smethod_2(buf[1]);
				}
				else
				{
					Interaction.MsgBox("Wrong Response Received", MsgBoxStyle.Information, "Error:");
				}
			}
			else
			{
				Interaction.MsgBox("Read Response Failed", MsgBoxStyle.Information, "Error:");
			}
			SerialPort1.Close();
		}

		public void cmd_SPIF_CERASE()
		{
			SerialPort1.PortName = "COM4";
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 2000;
			byte[] array = new byte[4];
			byte[] buf = new byte[11];
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			array[0] = 64;
			array[1] = 85;
			array[2] = 80;
			array[3] = 64;
			try
			{
				SerialPort1.Write(array, 0, 4);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
				ProjectData.ClearProjectError();
			}
			if (ReadUSARTw_to(ref buf, 1))
			{
				if (buf[0] == 6)
				{
					array[0] = 6;
					try
					{
						SerialPort1.Write(array, 0, 1);
					}
					catch (TimeoutException projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
						ProjectData.ClearProjectError();
					}
					if (ReadUSARTw_to(ref buf, 1))
					{
						if (buf[0] == 6)
						{
							Interaction.MsgBox("SPI Flash Chip Erased", MsgBoxStyle.Information, "Sucess:");
						}
					}
					else
					{
						Interaction.MsgBox("Read Response Failed", MsgBoxStyle.Information, "Error:");
					}
				}
				else
				{
					Interaction.MsgBox("Wrong Response Received", MsgBoxStyle.Information, "Error:");
				}
			}
			else
			{
				Interaction.MsgBox("Read Response Failed", MsgBoxStyle.Information, "Error:");
			}
			SerialPort1.Close();
		}

		public void cmd_OLED_Clear()
		{
			SerialPort1.PortName = "COM4";
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 2000;
			byte[] array = new byte[4];
			byte[] buf = new byte[11];
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			array[0] = 64;
			array[1] = 85;
			array[2] = 97;
			array[3] = 64;
			try
			{
				SerialPort1.Write(array, 0, 4);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
				ProjectData.ClearProjectError();
			}
			if (ReadUSARTw_to(ref buf, 1))
			{
				if (buf[0] != 6)
				{
					Interaction.MsgBox("Wrong Response Received", MsgBoxStyle.Information, "Error:");
				}
			}
			else
			{
				Interaction.MsgBox("Read Response Failed", MsgBoxStyle.Information, "Error:");
			}
			SerialPort1.Close();
		}

		public bool ReadUSARTw_to(ref byte[] buf, int bqty, bool VerifyChk = false)
		{
			bool result;
			try
			{
				int num = bqty - 1;
				for (int i = 0; i <= num; i++)
				{
					buf[i] = (byte)SerialPort1.ReadByte();
				}
				if (VerifyChk)
				{
					byte b = (byte)SerialPort1.ReadByte();
					result = true;
				}
				else
				{
					result = true;
				}
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private void method_4(object sender, EventArgs e)
		{
			cmd_SPIF_READPAGE(256, 512);
		}

		public void cmd_SPIF_READPAGE(int iaddress, int isize)
		{
			SerialPort1.PortName = "COM4";
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 2000;
			byte[] array = new byte[11];
			byte[] buf = new byte[514];
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			array[0] = 64;
			array[1] = 85;
			array[2] = 83;
			array[3] = 64;
			try
			{
				SerialPort1.Write(array, 0, 4);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
				ProjectData.ClearProjectError();
			}
			if (ReadUSARTw_to(ref buf, 1))
			{
				if (buf[0] == 6)
				{
					array[0] = (byte)(iaddress & 0xFF);
					array[1] = (byte)((iaddress / 256) & 0xFF);
					array[2] = (byte)((iaddress / 65536) & 0xFF);
					array[3] = (byte)((iaddress / 16777216) & 0xFF);
					array[4] = (byte)(isize & 0xFF);
					array[5] = (byte)((isize / 256) & 0xFF);
					array[6] = ToolboxUtilities.smethod_4(array, 6);
					try
					{
						SerialPort1.Write(array, 0, 7);
					}
					catch (TimeoutException projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
						ProjectData.ClearProjectError();
					}
					if (ReadUSARTw_to(ref buf, 1))
					{
						if (buf[0] == 6)
						{
							if (ReadUSARTw_to(ref buf, 513))
							{
								if (ToolboxUtilities.smethod_4(buf, 512) == buf[512])
								{
									Interaction.MsgBox("Datos Recibido Exitosamente", MsgBoxStyle.Information, "Error:");
								}
								else
								{
									Interaction.MsgBox("Error Checksum in Received Data", MsgBoxStyle.Information, "Error:");
								}
							}
							else
							{
								Interaction.MsgBox("Timeout", MsgBoxStyle.Information, "Error:");
							}
						}
						else
						{
							Interaction.MsgBox("Wrong Response 2", MsgBoxStyle.Information, "Error:");
						}
					}
					else
					{
						Interaction.MsgBox("Timeout", MsgBoxStyle.Information, "Error:");
					}
				}
				else
				{
					Interaction.MsgBox("Wrong Response 1", MsgBoxStyle.Information, "Error:");
				}
			}
			else
			{
				Interaction.MsgBox("Timeout", MsgBoxStyle.Information, "Error:");
			}
			SerialPort1.Close();
		}

		public byte SPIF_READPAGE(int iaddress, int isize, ref byte[] buf, bool bContinuedRead = false, bool bSendAddress = false)
		{
			byte[] array = new byte[11];
			int count;
			if (!bContinuedRead)
			{
				array[0] = 64;
				array[1] = 85;
				array[2] = 83;
				array[3] = 64;
				count = 4;
			}
			else
			{
				if (bSendAddress)
				{
					array[0] = 16;
				}
				else
				{
					array[0] = 2;
				}
				count = 1;
			}
			byte result;
			try
			{
				SerialPort1.Write(array, 0, count);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = 129;
				ProjectData.ClearProjectError();
				goto IL_0107;
			}
			if (!bContinuedRead || bSendAddress)
			{
				if (!ReadUSARTw_to(ref buf, 1))
				{
					return 132;
				}
				if (buf[0] != 6)
				{
					return 136;
				}
				array[0] = (byte)(iaddress & 0xFF);
				array[1] = (byte)((iaddress / 256) & 0xFF);
				array[2] = (byte)((iaddress / 65536) & 0xFF);
				array[3] = (byte)((iaddress / 16777216) & 0xFF);
				array[4] = (byte)(isize & 0xFF);
				array[5] = (byte)((isize / 256) & 0xFF);
				array[6] = ToolboxUtilities.smethod_4(array, 6);
				try
				{
					SerialPort1.Write(array, 0, 7);
				}
				catch (TimeoutException projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					result = 129;
					ProjectData.ClearProjectError();
					goto IL_0107;
				}
			}
			if (ReadUSARTw_to(ref buf, 1))
			{
				if (buf[0] == 6)
				{
					if (ReadUSARTw_to(ref buf, isize, true))
					{
						return 0;
					}
					return 132;
				}
				return 136;
			}
			return 132;
			IL_0107:
			return result;
		}

		public byte SPIF_BSERASE(int iaddress, byte isize, bool bContinuedRead = false)
		{
			byte[] buf = new byte[11];
			int count;
			if (!bContinuedRead)
			{
				buf[0] = 64;
				buf[1] = 85;
				buf[2] = 81;
				buf[3] = 64;
				count = 4;
			}
			else
			{
				buf[0] = 2;
				count = 1;
			}
			byte result;
			try
			{
				SerialPort1.Write(buf, 0, count);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = 129;
				ProjectData.ClearProjectError();
				goto IL_00de;
			}
			if (!bContinuedRead)
			{
				if (!ReadUSARTw_to(ref buf, 1))
				{
					return 132;
				}
				if (buf[0] != 6)
				{
					return 136;
				}
				buf[0] = (byte)(iaddress & 0xFF);
				buf[1] = (byte)((iaddress / 256) & 0xFF);
				buf[2] = (byte)((iaddress / 65536) & 0xFF);
				buf[3] = (byte)((iaddress / 16777216) & 0xFF);
				buf[4] = isize;
				buf[5] = ToolboxUtilities.smethod_4(buf, 5);
				try
				{
					SerialPort1.Write(buf, 0, 6);
				}
				catch (TimeoutException projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					result = 129;
					ProjectData.ClearProjectError();
					goto IL_00de;
				}
			}
			if (ReadUSARTw_to(ref buf, 1))
			{
				if (buf[0] == 6)
				{
					return 0;
				}
				return 136;
			}
			return 132;
			IL_00de:
			return result;
		}

		public byte SPIF_WRITEPAGE(int iaddress, int isize, ref byte[] buf, bool bContinuedRead = false)
		{
			byte[] buf2 = new byte[11];
			buf[isize] = ToolboxUtilities.smethod_4(buf, isize);
			int count;
			if (!bContinuedRead)
			{
				buf2[0] = 64;
				buf2[1] = 85;
				buf2[2] = 82;
				buf2[3] = 64;
				count = 4;
			}
			else
			{
				buf2[0] = 2;
				count = 1;
			}
			byte result;
			try
			{
				SerialPort1.Write(buf2, 0, count);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = 129;
				ProjectData.ClearProjectError();
				goto IL_013d;
			}
			if (!bContinuedRead)
			{
				if (!ReadUSARTw_to(ref buf2, 1))
				{
					return 132;
				}
				if (buf2[0] != 6)
				{
					return 136;
				}
				buf2[0] = (byte)(iaddress & 0xFF);
				buf2[1] = (byte)((iaddress / 256) & 0xFF);
				buf2[2] = (byte)((iaddress / 65536) & 0xFF);
				buf2[3] = (byte)((iaddress / 16777216) & 0xFF);
				buf2[4] = (byte)(isize & 0xFF);
				buf2[5] = (byte)((isize / 256) & 0xFF);
				buf2[6] = ToolboxUtilities.smethod_4(buf2, 6);
				try
				{
					SerialPort1.Write(buf2, 0, 7);
				}
				catch (TimeoutException projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					result = 129;
					ProjectData.ClearProjectError();
					goto IL_013d;
				}
			}
			if (ReadUSARTw_to(ref buf2, 1))
			{
				if (buf2[0] == 6)
				{
					try
					{
						SerialPort1.Write(buf, 0, isize + 1);
					}
					catch (TimeoutException projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						result = 129;
						ProjectData.ClearProjectError();
						goto IL_013d;
					}
					if (ReadUSARTw_to(ref buf2, 1))
					{
						if (buf2[0] == 6)
						{
							return 0;
						}
						return 136;
					}
					return 132;
				}
				return 136;
			}
			return 132;
			IL_013d:
			return result;
		}

		public byte send_STX()
		{
			byte[] buffer = new byte[2] { 2, 0 };
			try
			{
				SerialPort1.Write(buffer, 0, 1);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte result = 129;
				ProjectData.ClearProjectError();
				return result;
			}
			return 0;
		}

		public byte send_ETX()
		{
			byte[] buffer = new byte[2] { 3, 0 };
			try
			{
				SerialPort1.Write(buffer, 0, 1);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte result = 129;
				ProjectData.ClearProjectError();
				return result;
			}
			return 0;
		}

		public byte liz_SERVEPAGE(int isize, ref byte[] buf)
		{
			byte[] buf2 = new byte[11];
			buf[isize] = ToolboxUtilities.smethod_4(buf, isize);
			if (ReadUSARTw_to(ref buf2, 1))
			{
				if (buf2[0] == 2)
				{
					try
					{
						SerialPort1.Write(buf, 0, isize + 1);
					}
					catch (TimeoutException projectError)
					{
						ProjectData.SetProjectError(projectError);
						byte result = 129;
						ProjectData.ClearProjectError();
						return result;
					}
					if (ReadUSARTw_to(ref buf2, 1))
					{
						if (buf2[0] == 6)
						{
							return 0;
						}
						return 136;
					}
					return 132;
				}
				return 136;
			}
			return 132;
		}

		public byte liz_GETPAGE(int isize, ref byte[] buf)
		{
			byte[] buf2 = new byte[11];
			if (ReadUSARTw_to(ref buf2, 1))
			{
				if (buf2[0] == 2)
				{
					buf2[0] = 6;
					try
					{
						SerialPort1.Write(buf2, 0, 1);
					}
					catch (TimeoutException projectError)
					{
						ProjectData.SetProjectError(projectError);
						byte result = 129;
						ProjectData.ClearProjectError();
						return result;
					}
					if (ReadUSARTw_to(ref buf, isize, true))
					{
						return 0;
					}
					return 132;
				}
				return 136;
			}
			return 132;
		}

		private void method_5(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				OpenFileDialog1.InitialDirectory = "";
				cmd_OLED_SHOWBMP(OpenFileDialog1.FileName, 0, 0);
			}
		}

		public void cmd_OLED_SHOWBMP(string sfile, byte brow, byte bcol, bool Invertbits = true)
		{
			SerialPort1.PortName = "COM4";
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 2000;
			byte[] array = new byte[11];
			byte[] buf = new byte[11];
			byte[] buf2 = new byte[1];
			byte bheight = default(byte);
			byte bwidth = default(byte);
			int size = default(int);
			if (method_2(ref buf2, ref bheight, ref bwidth, ref size, sfile, Invertbits))
			{
				buf2 = (byte[])Utils.CopyArray(buf2, new byte[size + 1]);
				buf2[size] = ToolboxUtilities.smethod_4(buf2, size);
				if (!method_11())
				{
					Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				array[0] = 64;
				array[1] = 85;
				array[2] = 96;
				array[3] = 64;
				try
				{
					SerialPort1.Write(array, 0, 4);
				}
				catch (TimeoutException projectError)
				{
					ProjectData.SetProjectError(projectError);
					Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
					ProjectData.ClearProjectError();
				}
				if (ReadUSARTw_to(ref buf, 1))
				{
					if (buf[0] == 6)
					{
						array[0] = brow;
						array[1] = bcol;
						array[2] = bheight;
						array[3] = bwidth;
						array[4] = (byte)(size & 0xFF);
						array[5] = (byte)((size / 256) & 0xFF);
						array[6] = ToolboxUtilities.smethod_4(array, 6);
						try
						{
							SerialPort1.Write(array, 0, 7);
						}
						catch (TimeoutException projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
							ProjectData.ClearProjectError();
						}
						if (ReadUSARTw_to(ref buf, 1))
						{
							if (buf[0] == 6)
							{
								try
								{
									SerialPort1.Write(buf2, 0, size + 1);
								}
								catch (TimeoutException projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
									ProjectData.ClearProjectError();
								}
								if (ReadUSARTw_to(ref buf, 1))
								{
									if (buf[0] != 6)
									{
										Interaction.MsgBox("Wrong Response 3", MsgBoxStyle.Information, "Error:");
									}
								}
								else
								{
									Interaction.MsgBox("Timeout 3", MsgBoxStyle.Information, "Error:");
								}
							}
							else
							{
								Interaction.MsgBox("Wrong Response 2", MsgBoxStyle.Information, "Error:");
							}
						}
						else
						{
							Interaction.MsgBox("Timeout 2", MsgBoxStyle.Information, "Error:");
						}
					}
					else
					{
						Interaction.MsgBox("Wrong Response 1", MsgBoxStyle.Information, "Error:");
					}
				}
				else
				{
					Interaction.MsgBox("Timeout 1", MsgBoxStyle.Information, "Error:");
				}
			}
			else
			{
				Interaction.MsgBox("Error Converting BMP", MsgBoxStyle.Information, "Error:");
			}
			SerialPort1.Close();
		}

		private void method_6(object sender, EventArgs e)
		{
			SerialPort1.PortName = "COM4";
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 2000;
			DateTime timeOfDay = DateAndTime.TimeOfDay;
			int num = 1024;
			int num2 = (int)Math.Round(256.0);
			byte[] buf = new byte[1025];
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			FileStream fileStream = new FileStream(Application.StartupPath + "\\tmp.st2", FileMode.Create);
			int num3 = num2 - 1;
			for (int i = 0; i <= num3; i++)
			{
				bool bContinuedRead = ((i != 0) ? true : false);
				if (SPIF_READPAGE(i * num, num, ref buf, bContinuedRead) == 0)
				{
					fileStream.Write(buf, 0, num);
					continue;
				}
				Interaction.MsgBox("Error occurred at address " + Conversion.Hex(i * num), MsgBoxStyle.Exclamation, "Error:");
				break;
			}
			fileStream.Close();
			SerialPort1.Close();
			DateTime timeOfDay2 = DateAndTime.TimeOfDay;
			Interaction.MsgBox("Total Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, timeOfDay, timeOfDay2)) + " secs", MsgBoxStyle.Information, "Read Complete:");
		}

		private void method_7(object sender, EventArgs e)
		{
			cmd_SPIF_CERASE();
		}

		private void method_8(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			OpenFileDialog1.InitialDirectory = "";
			SerialPort1.PortName = "COM4";
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 2000;
			DateTime timeOfDay = DateAndTime.TimeOfDay;
			int num = 1024;
			int num2 = (int)Math.Round(256.0);
			byte[] buf = new byte[1025];
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			FileStream fileStream = new FileStream(OpenFileDialog1.FileName, FileMode.Open);
			int num3 = num2 - 1;
			for (int i = 0; i <= num3; i++)
			{
				bool bContinuedRead = ((i != 0) ? true : false);
				fileStream.Read(buf, 0, num);
				if (SPIF_WRITEPAGE(i * num, num, ref buf, bContinuedRead) != 0)
				{
					Interaction.MsgBox("Error occurred at address " + Conversion.Hex(i * num), MsgBoxStyle.Exclamation, "Error:");
					break;
				}
			}
			fileStream.Close();
			SerialPort1.Close();
			DateTime timeOfDay2 = DateAndTime.TimeOfDay;
			Interaction.MsgBox("Total Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, timeOfDay, timeOfDay2)) + " secs", MsgBoxStyle.Information, "Read Complete:");
		}

		private void method_9(object sender, EventArgs e)
		{
			cmd_OLED_Clear();
		}

		private void method_10(object sender, EventArgs e)
		{
			SerialPort1.PortName = "COM4";
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 2000;
			DateTime timeOfDay = DateAndTime.TimeOfDay;
			byte b = 4;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			int num = 0;
			do
			{
				bool bContinuedRead = ((num != 0) ? true : false);
				if (SPIF_BSERASE(num * b * 1024, b, bContinuedRead) == 0)
				{
					num++;
					continue;
				}
				Interaction.MsgBox("Error occurred at address " + Conversion.Hex(num * b * 1024), MsgBoxStyle.Exclamation, "Error:");
				break;
			}
			while (num <= 1);
			SerialPort1.Close();
			DateTime timeOfDay2 = DateAndTime.TimeOfDay;
			Interaction.MsgBox("Total Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, timeOfDay, timeOfDay2)) + " secs", MsgBoxStyle.Information, "Erase Complete:");
		}

		private void Button11_Click(object sender, EventArgs e)
		{
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			OpenFileDialog1.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			OpenFileDialog1.InitialDirectory = "";
			if ((double)FileSystem.FileLen(OpenFileDialog1.FileName) / 1024.0 != 256.0)
			{
				Interaction.MsgBox("You cannot flash files bigger than 256KB maybe u choose wrong file?", MsgBoxStyle.Exclamation, "Error");
				return;
			}
			if (FirmwareUtilities.smethod_8(OpenFileDialog1.FileName))
			{
				Interaction.MsgBox("You cannot send Snapshot/Dummy Files to be written\r\nUse the CFW Generator Pane to create a custom firmware with this snapshot/dummy ", MsgBoxStyle.Exclamation, "Error");
				return;
			}
			DateTime timeOfDay = DateAndTime.TimeOfDay;
			int num = 1024;
			int num2 = (int)Math.Round((double)FileSystem.FileLen(OpenFileDialog1.FileName) / 1024.0);
			byte[] buf = new byte[1025];
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			FileStream fileStream = new FileStream(OpenFileDialog1.FileName, FileMode.Open);
			ProgressBar1.Maximum = num2 - 1;
			ProgressBar1.Value = 0;
			ProgressBar1.Visible = true;
			lblAction.Text = "Sending";
			Enabled = false;
			int num3 = num2 - 1;
			int num4 = 0;
			while (true)
			{
				if (num4 <= num3)
				{
					fileStream.Read(buf, 0, num);
					if (num4 == 0)
					{
					}
					if (num4 == 0)
					{
						send_STX();
					}
					if (liz_SERVEPAGE(num, ref buf) == 0)
					{
						ProgressBar1.Value = num4;
						num4++;
						continue;
					}
					Interaction.MsgBox("Error occurred at address " + Conversion.Hex(num4 * num), MsgBoxStyle.Exclamation, "Error:");
					break;
				}
				Convert.ToInt16(Interaction.GetSetting("LIZ_TBX", "Settings", "GLOBAL_COUNT", "0"));
				int num5 = Convert.ToInt16(Interaction.GetSetting("LIZ_TBX", "Settings", "TEMP_COUNT", "0"));
				try
				{
					Interaction.SaveSetting("LIZ_TBX", "Settings", "TEMP_COUNT", Conversions.ToString(num5 + 1));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				break;
			}
			ProgressBar1.Value = 0;
			ProgressBar1.Visible = false;
			lblAction.Text = "Idle";
			Enabled = true;
			fileStream.Close();
			SerialPort1.Close();
			DateTime timeOfDay2 = DateAndTime.TimeOfDay;
			Interaction.MsgBox("Total Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, timeOfDay, timeOfDay2)) + " secs", MsgBoxStyle.Information, "Write Complete:");
		}

		private bool method_11()
		{
			bool result;
			try
			{
				SerialPort1.Open();
				result = true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private void Button12_Click(object sender, EventArgs e)
		{
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			SaveFileDialog1.CreatePrompt = false;
			SaveFileDialog1.OverwritePrompt = true;
			SaveFileDialog1.FileName = "output";
			SaveFileDialog1.DefaultExt = "bin";
			SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
			DialogResult dialogResult = SaveFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			DateTime timeOfDay = DateAndTime.TimeOfDay;
			int num = 1024;
			int num2 = (int)Math.Round(256.0);
			byte[] buf = new byte[1025];
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			FileStream fileStream = new FileStream(SaveFileDialog1.FileName, FileMode.Create);
			int num3 = num2 - 1;
			for (int i = 0; i <= num3; i++)
			{
				if (i == 0)
				{
				}
				if (i == 0)
				{
					send_STX();
				}
				if (liz_GETPAGE(num, ref buf) == 0)
				{
					fileStream.Write(buf, 0, num);
					continue;
				}
				Interaction.MsgBox("Error occurred at address " + Conversion.Hex(i * num), MsgBoxStyle.Exclamation, "Error:");
				break;
			}
			fileStream.Close();
			SerialPort1.Close();
			DateTime timeOfDay2 = DateAndTime.TimeOfDay;
			Interaction.MsgBox("Total Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, timeOfDay, timeOfDay2)) + " secs", MsgBoxStyle.Information, "Read Complete:");
		}

		private void method_12(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				OpenFileDialog1.InitialDirectory = "";
				cmd_OLED_SHOWBMP(OpenFileDialog1.FileName, 24, 56);
			}
		}

		private void method_13(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				OpenFileDialog1.InitialDirectory = "";
				cmd_OLED_SHOWBMP(OpenFileDialog1.FileName, 16, 48);
			}
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void method_14(object sender, EventArgs e)
		{
			string text = FileSystem.Dir("C:\\Lizard\\lzrd_os\\IconPack\\bmpconv\\32x32\\", FileAttribute.Archive);
			while (Operators.CompareString(text, "", false) != 0)
			{
				cmd_OLED_SHOWBMP("C:\\Lizard\\lzrd_os\\IconPack\\bmpconv\\32x32\\" + text, 16, 48);
				if (Interaction.MsgBox("Press Ok for next image", MsgBoxStyle.OkCancel | MsgBoxStyle.Information, "Note:") == MsgBoxResult.Cancel)
				{
					break;
				}
				text = FileSystem.Dir();
			}
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void method_15(object sender, EventArgs e)
		{
			string text = FileSystem.Dir("C:\\Lizard\\lzrd_os\\IconPack\\bmpconv\\", FileAttribute.Archive);
			while (Operators.CompareString(text, "", false) != 0)
			{
				cmd_OLED_SHOWBMP("C:\\Lizard\\lzrd_os\\IconPack\\bmpconv\\" + text, 24, 56);
				if (Interaction.MsgBox("Press Ok for next image", MsgBoxStyle.OkCancel | MsgBoxStyle.Information, "Note:") == MsgBoxResult.Cancel)
				{
					break;
				}
				text = FileSystem.Dir();
			}
		}

		private void Button17_Click(object sender, EventArgs e)
		{
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			SaveFileDialog1.CreatePrompt = false;
			SaveFileDialog1.OverwritePrompt = true;
			SaveFileDialog1.FileName = "dummysnap";
			SaveFileDialog1.DefaultExt = "bin";
			SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
			DialogResult dialogResult = SaveFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string text = Strings.Replace(SaveFileDialog1.FileName, ".bin", ".snp");
			DateTime timeOfDay = DateAndTime.TimeOfDay;
			byte[] buf = new byte[1025];
			byte[] buf2 = new byte[1025];
			FileStream fileStream = new FileStream(text, FileMode.Create);
			send_STX();
			if (liz_GETPAGE(1024, ref buf) != 0)
			{
				fileStream.Close();
				int num = default(int);
				Interaction.MsgBox("Error occurred reading Transmission Header " + Conversions.ToString(num), MsgBoxStyle.Exclamation, "Error:");
			}
			else
			{
				fileStream.Write(buf, 0, 1024);
				int num2 = buf[1];
				int num3 = buf[0];
				int num4 = num2 - 1;
				int num = 0;
				while (true)
				{
					if (num <= num4)
					{
						if (liz_GETPAGE(1024, ref buf2) == 0)
						{
							fileStream.Write(buf2, 0, 1024);
							num++;
							continue;
						}
						fileStream.Close();
						Interaction.MsgBox("Error occurred reading page " + Conversions.ToString(num), MsgBoxStyle.Exclamation, "Error:");
						break;
					}
					fileStream.Close();
					string text2 = Strings.Mid(text, 1, Strings.InStrRev(text, "\\", -1, CompareMethod.Text));
					long num5 = 1024L;
					FileStream fileStream2 = new FileStream(text, FileMode.Open);
					int num6 = num3 - 1;
					for (num = 0; num <= num6; num++)
					{
						string text3 = method_17(ref buf, num);
						long num7 = method_18(ref buf, num);
						bool flag = method_19(ref buf, num);
						int num8 = (int)(num7 / 1024L + 1L);
						if (flag && (num5 & 0x3FFL) > 0L)
						{
							num5 = (num5 + 1024L) & 0xFC00L;
						}
						long num9 = num5;
						fileStream2.Seek(num9, SeekOrigin.Begin);
						FileStream fileStream3 = new FileStream(text2 + text3, FileMode.Create);
						int num10 = num8 - 1;
						for (int i = 0; i <= num10; i++)
						{
							int count = (int)((i != num8 - 1) ? 1024 : (num7 & 0x3FFL));
							fileStream2.Read(buf2, 0, count);
							fileStream3.Write(buf2, 0, count);
						}
						fileStream3.Close();
						num5 = num9 + num7;
					}
					fileStream2.Close();
					method_16(text, SaveFileDialog1.FileName);
					break;
				}
			}
			SerialPort1.Close();
			DateTime timeOfDay2 = DateAndTime.TimeOfDay;
			Interaction.MsgBox("Total Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, timeOfDay, timeOfDay2)) + " secs", MsgBoxStyle.Information, "Read Complete:");
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private bool method_16(string string_21, string string_22)
		{
			string text = Strings.Mid(string_21, 1, Strings.InStrRev(string_21, "\\", -1, CompareMethod.Text));
			byte[] array = new byte[512];
			byte[] array2 = new byte[116];
			byte[] array3 = new byte[116];
			byte[] array4 = new byte[80];
			byte[] array5 = new byte[16];
			byte[] array6 = new byte[1];
			byte[] array7 = new byte[48];
			byte[] array8 = new byte[32];
			byte[] array9 = new byte[16];
			byte[] array10 = new byte[2];
			ToolboxUtilities.smethod_19(ref array, 0, 512, 0);
			ToolboxUtilities.smethod_19(ref array2, 0, 116, 0);
			ToolboxUtilities.smethod_19(ref array3, 0, 116, 0);
			ToolboxUtilities.smethod_19(ref array5, 0, 16, 0);
			ToolboxUtilities.smethod_19(ref array4, 0, 80, byte.MaxValue);
			ToolboxUtilities.smethod_19(ref array6, 0, array6.Length, byte.MaxValue);
			ToolboxUtilities.smethod_19(ref array7, 0, 48, 0);
			ToolboxUtilities.smethod_19(ref array8, 0, 32, 0);
			string pathName = text + "INQUIRY.BIN";
			if (Operators.CompareString(FileSystem.Dir(pathName), "", false) != 0)
			{
				long num = FileSystem.FileLen(pathName);
				int int_;
				if (num >= 116L)
				{
					array2 = FirmwareUtilities.smethod_35(pathName, 0L, 116);
					int_ = 116;
				}
				else
				{
					if (num < 96L)
					{
						Interaction.MsgBox("Inquiry file has wrong size", MsgBoxStyle.Information, "Error:");
						return false;
					}
					array2 = FirmwareUtilities.smethod_35(pathName, 0L, 96);
					int_ = 96;
				}
				pathName = text + "SECINQ.BIN";
				int int_2 = default(int);
				if (Operators.CompareString(FileSystem.Dir(pathName), "", false) != 0)
				{
					num = FileSystem.FileLen(pathName);
					if (num >= 116L)
					{
						array3 = FirmwareUtilities.smethod_35(pathName, 0L, 116);
						int_2 = 116;
					}
					else
					{
						if (num < 96L)
						{
							Interaction.MsgBox("Inquiry file has wrong size", MsgBoxStyle.Information, "Error:");
							return false;
						}
						array3 = FirmwareUtilities.smethod_35(pathName, 0L, 96);
						int_2 = 96;
					}
				}
				pathName = text + "IDENTIFY.BIN";
				if (Operators.CompareString(FileSystem.Dir(pathName), "", false) != 0)
				{
					num = FileSystem.FileLen(pathName);
					if (num != 512L)
					{
						Interaction.MsgBox("Identify file has wrong size", MsgBoxStyle.Information, "Error:");
						return false;
					}
					array = FirmwareUtilities.smethod_35(pathName, 0L, 512);
					string text2 = ToolboxUtilities.smethod_1(ref array2) + ToolboxUtilities.smethod_1(ref array3);
					string text3 = default(string);
					string text4 = FirmwareUtilities.smethod_21(text2, ref text3);
					string text5 = FirmwareUtilities.smethod_22(text2, text4, ref text3);
					string text6 = FirmwareUtilities.smethod_24(text2, text4, text5, ref text3);
					pathName = text + "KEY.BIN";
					if (Operators.CompareString(FileSystem.Dir(pathName), "", false) != 0)
					{
						num = FileSystem.FileLen(pathName);
						if (num != 16L)
						{
							Interaction.MsgBox("Key file has wrong size", MsgBoxStyle.Information, "Error:");
							return false;
						}
						array5 = FirmwareUtilities.smethod_35(pathName, 0L, 16);
						pathName = text + "SERIAL.BIN";
						if (Operators.CompareString(FileSystem.Dir(pathName), "", false) != 0)
						{
							num = FileSystem.FileLen(pathName);
							if (num != 80L)
							{
								Interaction.MsgBox("Serial file has wrong size", MsgBoxStyle.Information, "Error:");
								return false;
							}
							array4 = FirmwareUtilities.smethod_35(pathName, 0L, 80);
						}
						else
						{
							string text7 = "";
							if (FirmwareUtilities.smethod_33(array, ref text7))
							{
								FirmwareUtilities.smethod_38(ref array2, ref array, ref array4, 80, text7);
							}
						}
						pathName = text + "SUBSER.BIN";
						if (Operators.CompareString(FileSystem.Dir(pathName), "", false) != 0)
						{
							num = FileSystem.FileLen(pathName);
							if (num != 320L)
							{
								Interaction.MsgBox("Subser.bin file has wrong size", MsgBoxStyle.Information, "Error:");
								return false;
							}
							array4 = (byte[])Utils.CopyArray(array4, new byte[224]);
							ToolboxUtilities.smethod_19(ref array4, 80, 144, byte.MaxValue);
							byte[] array11 = FirmwareUtilities.smethod_35(pathName, 96L, 16);
							byte[] array12 = FirmwareUtilities.smethod_35(pathName, 112L, 4);
							byte[] array13 = FirmwareUtilities.smethod_35(pathName, 116L, 32);
							byte[] array14 = FirmwareUtilities.smethod_35(pathName, 148L, 4);
							byte[] array15 = FirmwareUtilities.smethod_35(pathName, 152L, 32);
							byte[] array16 = FirmwareUtilities.smethod_35(pathName, 184L, 96);
							FirmwareUtilities.smethod_35(pathName, 96L, 54);
							array9 = FirmwareUtilities.smethod_35(pathName, 280L, 16);
							ToolboxUtilities.smethod_13(ref array11, 0, 16, ref array4, 24);
							ToolboxUtilities.smethod_13(ref array12, 0, 4, ref array4, 40);
							ToolboxUtilities.smethod_13(ref array13, 0, 32, ref array4, 44);
							ToolboxUtilities.smethod_13(ref array14, 0, 4, ref array4, 76);
							ToolboxUtilities.smethod_13(ref array15, 0, 32, ref array4, 80);
							ToolboxUtilities.smethod_13(ref array16, 0, 96, ref array4, 128);
						}
						pathName = text + "FWH.BIN";
						if (Operators.CompareString(FileSystem.Dir(pathName), "", false) != 0)
						{
							num = FileSystem.FileLen(pathName);
							if (num != 16L)
							{
								Interaction.MsgBox("FWH.bin file has wrong size", MsgBoxStyle.Information, "Error:");
								return false;
							}
							byte[] array17 = FirmwareUtilities.smethod_35(pathName, 1L, 3);
							array7 = FirmwareUtilities.smethod_35(pathName, 0L, 1);
							if (ToolboxUtilities.smethod_10(ref array6, pathName, 4L, byte.MaxValue) == -1)
							{
								Interaction.MsgBox("Error Loading fwh.bin bytes", MsgBoxStyle.Information, "Error:");
								return false;
							}
							if (!ToolboxUtilities.smethod_17(ref array4, 0, 20, byte.MaxValue))
							{
								ToolboxUtilities.smethod_13(ref array17, 0, 3, ref array4, 17);
							}
						}
						pathName = text + "RTC.BIN";
						if (Operators.CompareString(FileSystem.Dir(pathName), "", false) != 0)
						{
							num = FileSystem.FileLen(pathName);
							if (num != 32L)
							{
								Interaction.MsgBox("RTC.bin file has wrong size", MsgBoxStyle.Information, "Error:");
								return false;
							}
							array8 = FirmwareUtilities.smethod_35(pathName, 0L, 32);
						}
						pathName = text + "KEYAREA.BIN";
						if (Operators.CompareString(FileSystem.Dir(pathName), "", false) != 0)
						{
							num = FileSystem.FileLen(pathName);
							if (num != 4096L)
							{
								Interaction.MsgBox("KEYAREA.bin file has wrong size", MsgBoxStyle.Information, "Error:");
								return false;
							}
							array10 = (byte[])Utils.CopyArray(array10, new byte[4096]);
							array10 = FirmwareUtilities.smethod_35(pathName, 0L, 4096);
							byte[] array18 = new byte[16];
							if (!ToolboxUtilities.smethod_16(ref array10, 4080, 16, ref array9, 0))
							{
								Interaction.MsgBox("The Key Area dont match Subserial.bin file", MsgBoxStyle.Information, "Error:");
								return false;
							}
							if (!FirmwareUtilities.smethod_40(text4, text5, text6, ref text3, ref array10, ref array4, ref array18))
							{
								Interaction.MsgBox("Cannot Get Key from the Keyarea file\r\nError: " + text3, MsgBoxStyle.Information, "Error:");
								return false;
							}
							if (!ToolboxUtilities.smethod_16(ref array5, 0, 16, ref array18, 0))
							{
								Interaction.MsgBox("The Key read on the KeyArea dont match the key on Key.bin", MsgBoxStyle.Critical, "Error:");
								return false;
							}
						}
						return FirmwareUtilities.smethod_30(string_22, array, array2, int_, array3, int_2, array5, array4, array10, array6, array7, array8);
					}
					Interaction.MsgBox("Key file not found in snapshot", MsgBoxStyle.Information, "Error:");
					return false;
				}
				Interaction.MsgBox("Identify file not found in snapshot", MsgBoxStyle.Information, "Error:");
				return false;
			}
			Interaction.MsgBox("Inquiry file not found in snapshot", MsgBoxStyle.Information, "Error:");
			return false;
		}

		private string method_17(ref byte[] byte_14, int int_15)
		{
			int num = int_15 * 30 + 2;
			string text = "";
			int num2 = 0;
			do
			{
				if (byte_14[num + num2] != 0)
				{
					text += Conversions.ToString(Strings.Chr(byte_14[num + num2]));
					num2++;
					continue;
				}
				return text;
			}
			while (num2 <= 24);
			return "";
		}

		private int method_18(ref byte[] byte_14, int int_15)
		{
			int num = int_15 * 30 + 2;
			int num2 = 0;
			num2 = 0 + byte_14[num + 25 + 3] << 24;
			num2 = num2 + byte_14[num + 25 + 2] << 16;
			num2 = num2 + byte_14[num + 25 + 1] << 8;
			return num2 + byte_14[num + 25 + 0];
		}

		private bool method_19(ref byte[] byte_14, int int_15)
		{
			int num = int_15 * 30 + 2;
			if (byte_14[num + 25 + 4] == 0)
			{
				return false;
			}
			return true;
		}

		private void method_20(object sender, EventArgs e)
		{
		}

		private void method_21(object sender, EventArgs e)
		{
		}

		private void Label5_Click(object sender, EventArgs e)
		{
		}

		private void method_22(object sender, ToolStripItemClickedEventArgs e)
		{
			if (Operators.CompareString(e.ClickedItem.Text, "Re-scan", false) != 0)
			{
				ToolStripStatusLabel_0.Text = e.ClickedItem.Text;
			}
			else
			{
				method_23();
			}
		}

		private void method_23()
		{
			ToolStripSplitButton1.DropDownItems.Clear();
			string[] portNames = SerialPort.GetPortNames();
			foreach (string text in portNames)
			{
				ToolStripSplitButton1.DropDownItems.Add(text);
			}
			ToolStripSplitButton1.DropDownItems.Add("Re-scan");
		}

		public void PortClose()
		{
			try
			{
				if (SerialPort1.IsOpen)
				{
					SerialPort1.Close();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Error Closing Port", MsgBoxStyle.OkOnly, "Error");
				ProjectData.ClearProjectError();
			}
			Application.DoEvents();
		}

		private void Button18_Click(object sender, EventArgs e)
		{
			method_24();
		}

		private void method_24()
		{
			PortClose();
			lblFlashDevID.Text = "";
			lblSerial.Text = "";
			lblOSVer.Text = "";
			ToolboxUtilities.string_6 = "";
			string_1 = "";
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			try
			{
				if (Operators.CompareString(Interaction.GetSetting("LIZ_TBX", "Settings", "DEFCOMPORT"), ToolStripStatusLabel_0.Text, false) != 0)
				{
					Interaction.SaveSetting("LIZ_TBX", "Settings", "DEFCOMPORT", ToolStripStatusLabel_0.Text);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Problem Writing Settings", MsgBoxStyle.Exclamation, "Error:");
				ProjectData.ClearProjectError();
			}
			byte[] array = new byte[4];
			byte[] buf = new byte[51];
			int_1 = 115200;
			PortClose();
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			array[0] = 64;
			array[1] = 85;
			array[2] = 90;
			array[3] = 64;
			try
			{
				SerialPort1.Write(array, 0, 4);
			}
			catch (TimeoutException projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
				ProjectData.ClearProjectError();
				return;
			}
			if (ReadUSARTw_to(ref buf, 3))
			{
				if (buf[2] == 6)
				{
					string_1 = Strings.Mid(ToolboxUtilities.smethod_5(ref buf), 1, 4);
					long_0 = ToolboxUtilities.smethod_6(string_1);
					if (long_0 == 0L)
					{
						Interaction.MsgBox("Unknown Flash Type", MsgBoxStyle.Information, "Error:");
						return;
					}
					lblFlashDevID.Text = ToolboxUtilities.smethod_2(buf[0]) + ToolboxUtilities.smethod_2(buf[1]) + "  Size: " + Conversions.ToString((double)long_0 / 1024.0 / 1024.0) + "MB";
					Thread.Sleep(100);
					array[0] = 64;
					array[1] = 85;
					array[2] = 48;
					array[3] = 64;
					try
					{
						SerialPort1.Write(array, 0, 4);
					}
					catch (TimeoutException projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
						ProjectData.ClearProjectError();
						return;
					}
					if (ReadUSARTw_to(ref buf, 34))
					{
						if (buf[33] == 6)
						{
							ToolboxUtilities.string_6 = Strings.Mid(ToolboxUtilities.smethod_5(ref buf), 33, 32);
							lblSerial.Text = ToolboxUtilities.smethod_1(ref buf, 16) + "-" + ToolboxUtilities.string_6;
							Thread.Sleep(100);
							array[0] = 64;
							array[1] = 85;
							array[2] = 49;
							array[3] = 64;
							try
							{
								SerialPort1.Write(array, 0, 4);
							}
							catch (TimeoutException projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
								ProjectData.ClearProjectError();
								return;
							}
							if (ReadUSARTw_to(ref buf, 22))
							{
								if (buf[21] == 6)
								{
									lblOSVer.Text = Strings.Trim(ToolboxUtilities.smethod_1(ref buf, 20));
									byte[] buf2 = new byte[1025];
									SPIF_READPAGE(131072, 1024, ref buf2);
									send_ETX();
									lblName.Text = ToolboxUtilities.smethod_1(ref buf2, 12, 2);
									FtdiNativeMethods.Sleep(100);
									method_48(Conversions.ToInteger(Interaction.IIf(chkTurbo.Checked, 1, 0)));
									bool_1 = true;
									PortClose();
									if ((double_4 = method_25(lblOSVer.Text)) < 1.3)
									{
										Interaction.MsgBox("Your Lizard require update to Gecko " + 1.3 + " or above\r\nIf you dont Update the results will not be Optimal\r\nPlease check Manual to learn how to update", MsgBoxStyle.Exclamation, "Important:");
									}
								}
								else
								{
									Interaction.MsgBox("Wrong Response Received", MsgBoxStyle.Information, "Error:");
								}
							}
							else
							{
								Interaction.MsgBox("Read Response Failed", MsgBoxStyle.Information, "Error:");
							}
						}
						else
						{
							Interaction.MsgBox("Wrong Response Received", MsgBoxStyle.Information, "Error:");
						}
					}
					else
					{
						Interaction.MsgBox("Read Response Failed", MsgBoxStyle.Information, "Error:");
					}
				}
				else
				{
					Interaction.MsgBox("Wrong Response Received", MsgBoxStyle.Information, "Error:");
				}
			}
			else
			{
				Interaction.MsgBox("Read Response Failed", MsgBoxStyle.Information, "Error:");
			}
		}

		private double method_25(string string_21)
		{
			string string_22 = Strings.Replace(string_21, "GECKO_OS", "", 1, -1, CompareMethod.Text);
			return ToolboxUtilities.smethod_27(string_22);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			method_27("");
		}

		private void TabPage3_Click(object sender, EventArgs e)
		{
		}

		public void refresh_spoofed()
		{
			string expression = Strings.Replace(txbAV_SrcPhyDrive.Text, "-4B00", "");
			expression = Strings.Replace(expression, "-4D20", "");
			expression = Strings.Replace(expression, "-4C30", "");
			expression = Strings.Replace(expression, "-4E10", "");
			if (Operators.CompareString(txbAV_SrcLogDrive.Text, expression, false) == 0)
			{
				lblSrcSpoof.Visible = false;
			}
			else
			{
				lblSrcSpoof.Visible = true;
			}
			expression = Strings.Replace(txbAV_DstPhyDrive.Text, "-4B00", "");
			expression = Strings.Replace(expression, "-4D20", "");
			expression = Strings.Replace(expression, "-4C30", "");
			expression = Strings.Replace(expression, "-4E10", "");
			if (Operators.CompareString(cmbAV_DstLogDrive.Text, expression, false) == 0)
			{
				lblDestSpoof.Visible = false;
			}
			else
			{
				lblDestSpoof.Visible = true;
			}
		}

		private void cmbAV_DstLogDrive_SelectedIndexChanged(object sender, EventArgs e)
		{
			refresh_spoofed();
		}

		private bool method_26()
		{
			byte[] array = new byte[117];
			byte[] array2 = new byte[117];
			byte[] array3 = new byte[181];
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = cmbAV_DstLogDrive.Text;
			int int_ = default(int);
			int int_2 = default(int);
			int int_3 = default(int);
			if (FirmwareUtilities.smethod_23(text4, ref text2, ref text, ref text3, ref array, ref int_, ref array2, ref int_2, ref array3, ref int_3))
			{
				string_17 = text2;
				string_18 = text;
				string_19 = text3;
				byte_7 = array;
				if (int_12 > int_)
				{
					int_12 = int_;
				}
				byte_8 = array3;
				method_34();
				return true;
			}
			Interaction.MsgBox("Cannot determine the data to spoof, make sure you select a valid option");
			return false;
		}

		private void kAiRloIfj(object sender, EventArgs e)
		{
			if (Operators.CompareString(string_5, "", false) == 0)
			{
				Interaction.MsgBox("Please open a file on the Source box first", MsgBoxStyle.Information, "Notice:");
				return;
			}
			if (Operators.CompareString(string_13, "", false) == 0)
			{
				Interaction.MsgBox("Please open a file on the Destination box first", MsgBoxStyle.Information, "Notice:");
				return;
			}
			if (int_14 != -1 && int_8 == -1)
			{
				Interaction.MsgBox("The Destination Firmware require Full Keyarea and your source File dont support it, this Spoofing is not allowed", MsgBoxStyle.Information, "Notice:");
				return;
			}
			if (int_13 != -1 && int_7 == -1)
			{
				Interaction.MsgBox("The Destination Firmware require Secret Key and your source File dont support it, this Spoofing is not allowed", MsgBoxStyle.Information, "Notice:");
				return;
			}
			string text;
			if (int_13 != -1)
			{
				ref byte[] reference = ref byte_4;
				byte[] array = ToolboxUtilities.cpoahSiso("000000000000000000000000");
				bool num = ToolboxUtilities.smethod_16(ref reference, 0, 8, ref array, 0);
				ref byte[] reference2 = ref byte_4;
				byte[] array2 = ToolboxUtilities.cpoahSiso("FFFFFFFFFFFFFFFFFFFF");
				if (num | ToolboxUtilities.smethod_16(ref reference2, 0, 8, ref array2, 0))
				{
					Interaction.MsgBox("The Key area on your source file is blank\r\nPlease update your Lizard to latest gecko and re-dump", MsgBoxStyle.Information, "Returns:");
					return;
				}
				text = "";
				byte[] array3 = new byte[16];
				if (!FirmwareUtilities.smethod_40(string_6, string_7, string_8, ref text, ref byte_4, ref byte_2, ref array3))
				{
					Interaction.MsgBox("Cannot Get the Key from Keyarea on the Source File\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
					return;
				}
				if (Operators.CompareString(string_12, ToolboxUtilities.smethod_5(ref array3, 16), false) != 0)
				{
					Interaction.MsgBox("The Key read from the Source File Key Area dont Match key read from key.bin\r\nPlease update your Lizard to latest gecko and re-dump", MsgBoxStyle.Information, "Returns:");
					return;
				}
			}
			if (kHmaKjHpik > 0 && int_10 > 0)
			{
				ToolboxUtilities.smethod_13(ref byte_2, 0, int_10, ref byte_9, 0);
			}
			if (Operators.CompareString(Strings.Trim(string_14) + "-" + Strings.Trim(string_15) + "-" + Strings.Trim(string_16), "LITEON-DG16D2S-02510", false) == 0)
			{
				string str = "4436303843473733383830383030333438202020FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF4130FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF4130FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF576973656C79204C6F766573204C616EFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
				byte[] array2 = ToolboxUtilities.cpoahSiso(Strings.Mid(str, 1, int_10 * 2));
				if (!ToolboxUtilities.smethod_16(ref array2, 0, kHmaKjHpik, ref byte_9, 0) && Interaction.MsgBox("Starting from Dashboard 13146 all Liteon 02510C seems were reflashed with the Same Fixed Serial Number\r\nSo its recommended you use that fixed Serial on the Generated File\r\nDo you want to use that Fixed value? (If you choose NO we will copy your Source Serial data)", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Important:") == MsgBoxResult.Yes)
				{
					byte_9 = ToolboxUtilities.cpoahSiso(Strings.Mid(str, 1, int_10 * 2));
				}
				string_9 = string_14;
				string_10 = string_15;
				string_11 = string_16;
			}
			text = "";
			byte[] array4 = FirmwareUtilities.smethod_29(string_6, string_7, string_8, string_9, string_10, string_11, byte_1, ref text);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Cannot fix Identify string while preparing spoofing\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return;
			}
			string_17 = string_9;
			string_18 = string_10;
			string_19 = string_11;
			byte_7 = byte_0;
			if (int_12 > TmcaFaJkxr)
			{
				int_12 = TmcaFaJkxr;
			}
			byte_8 = array4;
			string_20 = string_12;
			byte_10 = byte_3;
			byte_11 = byte_4;
			byte_12 = byte_5;
			long_9 = long_4;
			byte_13 = byte_6;
			long_10 = long_5;
			method_34();
		}

		private void method_27(string string_21 = "")
		{
			string string_22;
			if (Operators.CompareString(string_21, "", false) == 0)
			{
				OpenFileDialog1.Filter = "Layout files (*.bin)|*.bin|All files (*.*)|*.*";
				OpenFileDialog1.FileName = "";
				DialogResult dialogResult = OpenFileDialog1.ShowDialog();
				if (dialogResult != DialogResult.OK)
				{
					return;
				}
				string_22 = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
			}
			else
			{
				OpenFileDialog1.InitialDirectory = ToolboxUtilities.smethod_20(string_21);
				SaveFileDialog1.InitialDirectory = ToolboxUtilities.smethod_20(string_21);
				string_22 = string_21;
			}
			method_32();
			method_33();
			byte[] byte_ = new byte[97];
			byte[] byte_2 = new byte[97];
			byte[] byte_3 = new byte[181];
			byte[] byte_4 = new byte[81];
			byte[] byte_5 = new byte[16];
			byte[] byte_6 = new byte[4096];
			string string_23 = "";
			string string_24 = "";
			string string_25 = "";
			object obj = "";
			string string_26 = "";
			string string_27 = "";
			string string_28 = "";
			int int_ = -1;
			long long_ = default(long);
			long long_2 = default(long);
			int int_2 = default(int);
			long long_3 = default(long);
			int int_3 = default(int);
			long long_4 = default(long);
			int int_4 = default(int);
			long long_5 = default(long);
			int int_5 = default(int);
			long long_6 = default(long);
			long long_7 = default(long);
			byte[] byte_7 = default(byte[]);
			long long_8 = default(long);
			bool flag;
			long long_9 = default(long);
			byte[] byte_8 = default(byte[]);
			if (FirmwareUtilities.smethod_8(string_22))
			{
				string string_29 = Conversions.ToString(obj);
				bool num = method_30(ref string_22, ref string_23, ref string_24, ref string_25, ref string_29, ref long_, ref string_26, ref string_27, ref string_28, ref long_2, ref byte_, ref int_2, ref long_3, ref byte_2, ref int_3, ref long_4, ref byte_3, ref int_4, ref long_5, ref byte_4, ref int_5, ref byte_5, ref long_6, ref byte_6, ref long_7, ref byte_7, ref long_8, ref int_);
				obj = string_29;
				flag = num;
				long_9 = -1L;
			}
			else
			{
				string string_29 = Conversions.ToString(obj);
				bool num2 = method_31(ref string_22, ref string_23, ref string_24, ref string_25, ref string_29, ref long_, ref string_26, ref string_27, ref string_28, ref long_2, ref byte_, ref int_2, ref long_3, ref byte_2, ref int_3, ref long_4, ref byte_3, ref int_4, ref long_5, ref byte_4, ref int_5, ref byte_5, ref long_6, ref byte_6, ref long_7, ref byte_8, ref long_9, ref byte_7, ref long_8);
				obj = string_29;
				flag = num2;
			}
			if (flag)
			{
				string text2 = Strings.Trim(string_26) + "-" + Strings.Trim(string_27) + "-" + Strings.Trim(string_28);
				string_5 = string_22;
				string_6 = string_23;
				string_7 = string_24;
				string_8 = string_25;
				string_9 = string_26;
				string_10 = string_27;
				string_11 = string_28;
				string_12 = Conversions.ToString(obj);
				long_1 = long_;
				TmcaFaJkxr = int_2;
				int_6 = int_4;
				byte_0 = byte_;
				byte_1 = byte_3;
				this.long_3 = long_5;
				this.byte_2 = byte_4;
				kHmaKjHpik = int_5;
				this.byte_3 = byte_5;
				int_7 = (int)long_6;
				this.byte_4 = byte_6;
				int_8 = (int)long_7;
				this.byte_5 = byte_8;
				this.long_4 = long_9;
				this.byte_6 = byte_7;
				this.long_5 = long_8;
				int_9 = int_;
				method_33();
			}
		}

		private bool method_28(string string_21, ref string string_22, ref byte[] byte_14)
		{
			byte[] byte_15 = new byte[97];
			byte[] byte_16 = new byte[97];
			byte[] byte_17 = new byte[181];
			string string_23 = "";
			string string_24 = "";
			string string_25 = "";
			string_22 = "";
			string string_26 = "";
			string string_27 = "";
			string string_28 = "";
			long long_ = default(long);
			long long_2 = default(long);
			int int_ = default(int);
			long long_3 = default(long);
			int int_2 = default(int);
			long long_4 = default(long);
			int int_3 = default(int);
			long long_5 = default(long);
			int int_4 = default(int);
			byte[] byte_18 = default(byte[]);
			long long_6 = default(long);
			byte[] byte_19 = default(byte[]);
			long long_7 = default(long);
			byte[] byte_20 = default(byte[]);
			long long_8 = default(long);
			byte[] byte_21 = default(byte[]);
			long long_9 = default(long);
			int int_5 = default(int);
			if (!((!FirmwareUtilities.smethod_8(string_21)) ? method_31(ref string_21, ref string_23, ref string_24, ref string_25, ref string_22, ref long_, ref string_26, ref string_27, ref string_28, ref long_2, ref byte_15, ref int_, ref long_3, ref byte_16, ref int_2, ref long_4, ref byte_17, ref int_3, ref long_5, ref byte_14, ref int_4, ref byte_18, ref long_6, ref byte_19, ref long_7, ref byte_20, ref long_8, ref byte_21, ref long_9) : method_30(ref string_21, ref string_23, ref string_24, ref string_25, ref string_22, ref long_, ref string_26, ref string_27, ref string_28, ref long_2, ref byte_15, ref int_, ref long_3, ref byte_16, ref int_2, ref long_4, ref byte_17, ref int_3, ref long_5, ref byte_14, ref int_4, ref byte_18, ref long_6, ref byte_19, ref long_7, ref byte_21, ref long_9, ref int_5)))
			{
				return false;
			}
			return true;
		}

		private void method_29()
		{
			OpenFileDialog1.Filter = "Layout files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string string_ = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
				method_35();
				method_34();
				byte[] byte_ = new byte[97];
				byte[] byte_2 = new byte[97];
				byte[] byte_3 = new byte[181];
				byte[] byte_4 = new byte[81];
				string string_2 = "";
				string string_3 = "";
				string string_4 = "";
				object obj = "";
				string string_5 = "";
				string string_6 = "";
				string string_7 = "";
				bool flag;
				long long_ = default(long);
				long long_2 = default(long);
				int int_ = default(int);
				long long_4 = default(long);
				int int_3 = default(int);
				long long_5 = default(long);
				int int_4 = default(int);
				byte[] byte_5 = default(byte[]);
				long long_6 = default(long);
				byte[] byte_6 = default(byte[]);
				long long_7 = default(long);
				byte[] byte_7 = default(byte[]);
				long long_8 = default(long);
				byte[] byte_8 = default(byte[]);
				long long_9 = default(long);
				if (FirmwareUtilities.smethod_8(string_))
				{
					Interaction.MsgBox("On this section you need to open a full firmware, not snapshots-dummy files", MsgBoxStyle.Information, "Error");
					flag = false;
				}
				else
				{
					string string_8 = Conversions.ToString(obj);
					long long_3 = default(long);
					int int_2 = default(int);
					bool num = method_31(ref string_, ref string_2, ref string_3, ref string_4, ref string_8, ref long_, ref string_5, ref string_6, ref string_7, ref long_2, ref byte_, ref int_, ref long_3, ref byte_2, ref int_2, ref long_4, ref byte_3, ref int_3, ref long_5, ref byte_4, ref int_4, ref byte_5, ref long_6, ref byte_6, ref long_7, ref byte_7, ref long_8, ref byte_8, ref long_9);
					obj = string_8;
					flag = num;
				}
				if (flag)
				{
					string text2 = Strings.Trim(string_5) + "-" + Strings.Trim(string_6) + "-" + Strings.Trim(string_7);
					string_13 = string_;
					string_14 = string_2;
					string_15 = string_3;
					string_16 = string_4;
					string_17 = string_5;
					string_18 = string_6;
					string_19 = string_7;
					string_20 = Conversions.ToString(obj);
					this.long_6 = long_;
					int_12 = int_;
					this.long_8 = long_2;
					int_11 = int_3;
					this.long_7 = long_4;
					this.byte_7 = byte_;
					this.byte_8 = byte_3;
					IKFQOTWSJJ = long_5;
					byte_9 = byte_4;
					int_10 = int_4;
					byte_10 = byte_5;
					int_13 = (int)long_6;
					byte_11 = byte_6;
					int_14 = (int)long_7;
					byte_12 = byte_7;
					this.long_9 = long_8;
					byte_13 = byte_8;
					long_10 = long_9;
					method_34();
				}
			}
		}

		private bool method_30(ref string string_21, ref string string_22, ref string string_23, ref string string_24, ref string string_25, ref long long_11, ref string string_26, ref string string_27, ref string string_28, ref long long_12, ref byte[] byte_14, ref int int_15, ref long long_13, ref byte[] byte_15, ref int int_16, ref long long_14, ref byte[] byte_16, ref int int_17, ref long long_15, ref byte[] byte_17, ref int int_18, ref byte[] byte_18, ref long long_16, ref byte[] byte_19, ref long long_17, ref byte[] byte_20, ref long long_18, ref int int_19)
		{
			byte[] array = new byte[16];
			string text = "";
			if (!FirmwareUtilities.smethod_28(string_21, ref text, ref string_26, ref string_27, ref string_28, ref long_12, ref byte_14, ref int_15, ref long_13, ref byte_15, ref int_16, ref long_14, ref byte_16, ref int_17))
			{
				Interaction.MsgBox("Error retrieving drive type from snapshot file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			string_22 = string_26;
			string_23 = string_27;
			string_24 = string_28;
			long_11 = 0L;
			string_25 = FirmwareUtilities.smethod_10(string_21, ref text, ref long_11);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Unable to extract key from snapshot file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			if (!FirmwareUtilities.smethod_16(string_22, string_23, string_24, string_21, ref text, ref long_15, ref int_18, ref byte_17))
			{
				Interaction.MsgBox("Cannot extract serial Data\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			FirmwareUtilities.smethod_38(ref byte_14, ref byte_16, ref byte_17, int_18, string_23);
			if (!FirmwareUtilities.smethod_12(string_26, string_27, string_28, string_21, ref text, ref byte_20, ref long_18, ref int_19))
			{
				Interaction.MsgBox("Unable to extract Bytes from snapshot file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			if (!FirmwareUtilities.smethod_11(string_26, string_27, string_28, string_21, ref text, ref byte_18, ref long_16, ref byte_19, ref long_17))
			{
				Interaction.MsgBox("Unable to extract Key Area from snapshot file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			if (long_17 != -1L)
			{
				byte[] array2 = ToolboxUtilities.cpoahSiso("000000000000000000000000");
				bool num = ToolboxUtilities.smethod_16(ref byte_19, 0, 8, ref array2, 0);
				byte[] array3 = ToolboxUtilities.cpoahSiso("FFFFFFFFFFFFFFFFFFFF");
				if (num | ToolboxUtilities.smethod_16(ref byte_19, 0, 8, ref array3, 0))
				{
					Interaction.MsgBox("The Key area on your source file is blank\r\nPlease update your Lizard to latest gecko and re-dump", MsgBoxStyle.Information, "Returns:");
					return false;
				}
				if (!FirmwareUtilities.smethod_40(string_22, string_23, string_24, ref text, ref byte_19, ref byte_17, ref array))
				{
					Interaction.MsgBox("Cannot Get the Key from Keyarea\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
					return false;
				}
				if (Operators.CompareString(string_25, ToolboxUtilities.smethod_5(ref array, 16), false) != 0)
				{
					Interaction.MsgBox("The Key read from the Key Area dont Match key read from key.bin\r\nPlease update your Lizard to latest gecko and re-dump", MsgBoxStyle.Information, "Returns:");
					return false;
				}
			}
			return true;
		}

		private bool method_31(ref string string_21, ref string string_22, ref string string_23, ref string string_24, ref string string_25, ref long long_11, ref string string_26, ref string string_27, ref string string_28, ref long long_12, ref byte[] byte_14, ref int int_15, ref long long_13, ref byte[] byte_15, ref int int_16, ref long long_14, ref byte[] byte_16, ref int int_17, ref long long_15, ref byte[] byte_17, ref int int_18, ref byte[] byte_18, ref long long_16, ref byte[] byte_19, ref long long_17, ref byte[] byte_20, ref long long_18, ref byte[] byte_21, ref long long_19)
		{
			string text = "";
			byte[] array = new byte[16];
			string_22 = FirmwareUtilities.smethod_3(string_21, ref text);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Vendor: " + string_22 + "\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			string_23 = FirmwareUtilities.smethod_4(string_22, string_21, ref text);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Vendor: " + string_22 + "\r\nModel: " + string_23 + "Error: " + text, MsgBoxStyle.Information, "Returns:");
				return true;
			}
			string_24 = FirmwareUtilities.smethod_9(string_22, string_23, string_21, ref text);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Vendor: " + string_22 + "\r\nModel: " + string_23 + "\r\nROM:" + string_24 + "Error: " + text, MsgBoxStyle.Information, "Returns:");
				return true;
			}
			long_11 = 0L;
			string_25 = FirmwareUtilities.smethod_15(string_22, string_23, string_24, string_21, ref text, ref long_11);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Vendor: " + string_22 + "\r\nModel: " + string_23 + "\r\nROM:" + string_24 + "\r\nKey:" + string_25 + "\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			if (!FirmwareUtilities.smethod_17(string_22, string_23, string_24, string_21, ref text, ref long_15, ref int_18, ref byte_17))
			{
				Interaction.MsgBox("Cannot extract serial Data\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			if (!FirmwareUtilities.smethod_14(string_22, string_23, string_24, string_21, ref text, ref byte_20, ref long_18))
			{
				Interaction.MsgBox("Unable to extract Serial Area from Firmware\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			int int_19 = default(int);
			if (!FirmwareUtilities.smethod_12(string_22, string_23, string_24, string_21, ref text, ref byte_21, ref long_19, ref int_19))
			{
				Interaction.MsgBox("Unable to extract Bytes from snapshot file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			if (!FirmwareUtilities.smethod_13(string_22, string_23, string_24, string_21, ref text, ref byte_18, ref long_16, ref byte_19, ref long_17))
			{
				Interaction.MsgBox("Unable to extract Key Area from Firmware\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			if (long_17 != -1L)
			{
				if (!FirmwareUtilities.smethod_40(string_22, string_23, string_24, ref text, ref byte_19, ref byte_17, ref array))
				{
					Interaction.MsgBox("Cannot Get the Key from Keyarea\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
					return false;
				}
				if (Operators.CompareString(string_25, ToolboxUtilities.smethod_5(ref array, 16), false) != 0)
				{
					Interaction.MsgBox("The Key read from the Key Area dont Match key read from key.bin\r\nPlease update your Lizard to latest gecko and re-dump", MsgBoxStyle.Information, "Returns:");
					return false;
				}
			}
			if (!FirmwareUtilities.smethod_25(string_22, string_23, string_24, string_21, ref text, ref string_26, ref string_27, ref string_28, ref long_12, ref long_13, ref long_14, ref byte_14, ref int_15, ref byte_15, ref int_16, ref byte_16, ref int_17))
			{
				Interaction.MsgBox("Cannot determine Logical Drive Data\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return false;
			}
			return true;
		}

		private void method_32()
		{
			string_5 = "";
			string_6 = "";
			string_7 = "";
			string_8 = "";
			string_9 = "";
			string_10 = "";
			string_11 = "";
			string_12 = "";
			long_1 = -1L;
			pMkapSnyXg = -1L;
			int_6 = 0;
			long_2 = -1L;
			TmcaFaJkxr = 0;
			long_3 = -1L;
			kHmaKjHpik = 0;
		}

		private void method_33()
		{
			txbEV_SrcFile.Text = string_5;
			string left = "";
			if (Operators.CompareString(string_8, "", false) != 0)
			{
				left = Strings.Trim(string_6) + "-" + Strings.Trim(string_7) + "-" + Strings.Trim(FirmwareUtilities.smethod_34(string_8));
			}
			string text = "";
			if (Operators.CompareString(string_11, "", false) != 0)
			{
				text = Strings.Trim(string_9) + "-" + Strings.Trim(string_10) + "-" + Strings.Trim(FirmwareUtilities.smethod_34(string_11));
			}
			txbEV_SrcFwInfo.Text = left;
			if (Operators.CompareString(left, text, false) != 0)
			{
				txbEV_SrcFwInfo.Text = txbEV_SrcFwInfo.Text + " spoofed as " + text;
			}
			txbEV_SrcKey.Text = string_12;
			txbAV_SrcFile.Text = string_5;
			txbAV_SrcPhyDrive.Text = left;
			txbAV_SrcLogDrive.Text = text;
			txbAV_SrcKey.Text = string_12;
			if (kHmaKjHpik != 0)
			{
				txbAV_SrcDVDSer.Text = ToolboxUtilities.smethod_1(ref byte_2, 20);
			}
			else
			{
				txbAV_SrcDVDSer.Text = "";
			}
			refresh_spoofed();
		}

		private void method_34()
		{
			if (Operators.CompareString(string_16, "", false) != 0)
			{
				string text2 = Strings.Trim(string_14) + "-" + Strings.Trim(string_15) + "-" + Strings.Trim(FirmwareUtilities.smethod_34(string_16));
			}
			string text = "";
			if (Operators.CompareString(string_19, "", false) != 0)
			{
				text = Strings.Trim(string_17) + "-" + Strings.Trim(string_18) + "-" + Strings.Trim(FirmwareUtilities.smethod_34(string_19));
			}
			txbAV_DstFile.Text = string_13;
			txbAV_DstPhyDrive.Text = Strings.Trim(string_14) + "-" + Strings.Trim(string_15) + "-" + Strings.Trim(string_16);
			cmbAV_DstLogDrive.Text = text;
			txbAV_DstKey.Text = string_20;
			if (int_10 != 0)
			{
				btn_editDstSer.Enabled = true;
				txbAV_DstDVDSer.Text = ToolboxUtilities.smethod_1(ref byte_9, 20);
			}
			else
			{
				txbAV_DstDVDSer.Text = "";
				btn_editDstSer.Enabled = false;
			}
			refresh_spoofed();
		}

		private void method_35()
		{
			string_13 = "";
			string_14 = "";
			string_15 = "";
			string_16 = "";
			string_17 = "";
			string_18 = "";
			string_19 = "";
			string_20 = "";
			long_6 = -1L;
			long_7 = -1L;
			int_11 = 0;
			long_8 = -1L;
			int_12 = 0;
			IKFQOTWSJJ = -1L;
			int_10 = 0;
		}

		private void btnEV_LoadSrcFw_Click(object sender, EventArgs e)
		{
			method_27("");
		}

		private void cmbEV_DstCFWTemplate_SelectedIndexChanged(object sender, EventArgs e)
		{
			int num = cmbEV_DstCFWTemplate.SelectedIndex - 1;
			string caption = ((num <= -1) ? "Choose a CFW Template, if none listed please download them and put under CFW_Templates folder" : (struct3_0[num].string_0 + " Template Release " + Strings.Mid(struct3_0[num].string_2, 1, 2) + "." + Strings.Mid(struct3_0[num].string_2, 3, 2) + " Date: " + Strings.Mid(struct3_0[num].string_1, 1, 2) + "/" + Strings.Mid(struct3_0[num].string_1, 3, 2) + "/" + Strings.Mid(struct3_0[num].string_1, 5, 4)));
			ToolTip1.SetToolTip(cmbEV_DstCFWTemplate, caption);
		}

		private void btnEV_CFWSaveAs_Click(object sender, EventArgs e)
		{
			genCFW_FromTemplate();
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void genCFW_FromTemplate()
		{
			string text = "";
			if (Operators.CompareString(this.string_5, "", false) == 0)
			{
				Interaction.MsgBox("Open a Firmware or Snapshot file to take as base first", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (cmbEV_DstCFWTemplate.SelectedIndex == 0)
			{
				Interaction.MsgBox("Select a Template from the list, if none listed use the download button to get them", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			int num = cmbEV_DstCFWTemplate.SelectedIndex - 1;
			CfwTemplateParser.smethod_1(struct3_0[num].string_3, ref struct4_0, ref int_5);
			if (int_5 == 0)
			{
				Interaction.MsgBox("No TOC Entries found on the Fileset " + struct3_0[num].string_3, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			FirmwareUtilities.bool_0 = false;
			if ((Strings.InStr(Strings.UCase(struct3_0[num].string_0), "LTPLUS", CompareMethod.Text) != 0) & (decimal.Compare(Convert.ToDecimal(struct3_0[num].string_2), 115m) >= 0))
			{
				FirmwareUtilities.bool_0 = true;
			}
			if (Strings.InStr(struct3_0[num].string_0, "ORIGINAL", CompareMethod.Text) != 0)
			{
				FirmwareUtilities.bool_0 = true;
			}
			if (((Operators.CompareString(Strings.Trim(this.string_6) + "-" + Strings.Trim(this.string_7) + "-" + Strings.Trim(this.string_8), "LITEON-DG16D2S-74850", false) == 0) | (Operators.CompareString(Strings.Trim(this.string_6) + "-" + Strings.Trim(this.string_7) + "-" + Strings.Trim(this.string_8), "LITEON-DG16D2S-83850", false) == 0) | (Operators.CompareString(Strings.Trim(this.string_6) + "-" + Strings.Trim(this.string_7) + "-" + Strings.Trim(this.string_8), "LITEON-DG16D2S-83850V2", false) == 0) | (Operators.CompareString(Strings.Trim(this.string_6) + "-" + Strings.Trim(this.string_7) + "-" + Strings.Trim(this.string_8), "LITEON-DG16D2S-93450", false) == 0)) && Interaction.MsgBox("Starting from Dashboard 13146 all Phat Liteon are being updated to 02510CDo you want to generate the file for 02510C ? (choose yes if you have updated your console to Dash 13146 or above)", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Important:") == MsgBoxResult.Yes)
			{
				this.string_8 = "02510     ";
			}
			if (((Operators.CompareString(Strings.Trim(this.string_6) + "-" + Strings.Trim(this.string_7) + "-" + Strings.Trim(this.string_8), "BENQ-VAD6038-62430", false) == 0) | (Operators.CompareString(Strings.Trim(this.string_6) + "-" + Strings.Trim(this.string_7) + "-" + Strings.Trim(this.string_8), "BENQ-VAD6038-64930", false) == 0)) && Interaction.MsgBox("Starting from Dashboard 13146 all BENQ Drives are being updated to 04421Do you want to generate the file for 04421 ? (choose yes if you have updated your console to Dash 13146 or above)", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Important:") == MsgBoxResult.Yes)
			{
				this.string_8 = "04421     ";
			}
			if (Operators.CompareString(Strings.Trim(this.string_6) + "-" + Strings.Trim(this.string_7) + "-" + Strings.Trim(this.string_8), "LITEON-DG16D4S-9504", false) == 0 && Interaction.MsgBox("Starting from Dashboard 13146 all Slim Liteon Drives 9504 are being updated to 0272Do you want to generate the file for 0272 ? (choose yes if you have updated your console to Dash 13146 or above)", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Important:") == MsgBoxResult.Yes)
			{
				this.string_8 = "0272      ";
			}
			string str = this.string_8;
			if (Operators.CompareString(Strings.Trim(this.string_6) + "-" + Strings.Trim(this.string_7) + "-" + Strings.Trim(this.string_8), "LITEON-DG16D4S-0225", false) == 0 && FirmwareUtilities.smethod_8(this.string_5) && int_9 == 2)
			{
				str = "0225-U";
			}
			string text2 = Strings.Trim(this.string_6) + "-" + Strings.Trim(this.string_7) + "-" + Strings.Trim(str);
			bool flag = false;
			int num2 = int_5 - 1;
			int i;
			for (i = 0; i <= num2; i++)
			{
				string right = Strings.Trim(struct4_0[i].string_3) + "-" + Strings.Trim(struct4_0[i].string_4) + "-" + Strings.Trim(struct4_0[i].string_5);
				if (Operators.CompareString(text2, right, false) == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				Interaction.MsgBox("No TOC Entries found to generate a " + text2 + " firmware on the Selected Fileset\r\nTry to get updated Fileset", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string string_ = Application.StartupPath + "\\temp.tmp";
			if (!ToolboxUtilities.smethod_8(struct3_0[num].string_3, string_, 33792L + struct4_0[i].long_1, struct4_0[i].long_0))
			{
				Interaction.MsgBox("The temporary file cannot be created, check the application is on folder with write privileges\r\nIf problem persist make sure you use latest Fileset Templates", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			method_35();
			byte[] byte_ = new byte[97];
			byte[] byte_2 = new byte[97];
			byte[] byte_3 = new byte[181];
			byte[] byte_4 = new byte[81];
			string string_2 = "";
			string string_3 = "";
			string string_4 = "";
			object obj = "";
			string string_5 = "";
			string string_6 = "";
			string string_7 = "";
			string string_8 = Conversions.ToString(obj);
			long long_ = default(long);
			long long_2 = default(long);
			int int_ = default(int);
			long long_3 = default(long);
			int int_2 = default(int);
			long long_4 = default(long);
			int int_3 = default(int);
			long long_5 = default(long);
			int int_4 = default(int);
			byte[] byte_5 = default(byte[]);
			long long_6 = default(long);
			byte[] byte_6 = default(byte[]);
			long long_7 = default(long);
			byte[] byte_7 = default(byte[]);
			long long_8 = default(long);
			byte[] byte_8 = default(byte[]);
			long long_9 = default(long);
			bool num3 = method_31(ref string_, ref string_2, ref string_3, ref string_4, ref string_8, ref long_, ref string_5, ref string_6, ref string_7, ref long_2, ref byte_, ref int_, ref long_3, ref byte_2, ref int_2, ref long_4, ref byte_3, ref int_3, ref long_5, ref byte_4, ref int_4, ref byte_5, ref long_6, ref byte_6, ref long_7, ref byte_7, ref long_8, ref byte_8, ref long_9);
			obj = string_8;
			if (!num3)
			{
				return;
			}
			string_13 = string_;
			string_14 = string_2;
			string_15 = string_3;
			string_16 = string_4;
			string_17 = string_5;
			string_18 = string_6;
			string_19 = string_7;
			string_20 = Conversions.ToString(obj);
			this.long_6 = long_;
			this.long_7 = long_4;
			this.long_8 = long_2;
			int_12 = int_;
			int_11 = int_3;
			this.byte_7 = byte_;
			this.byte_8 = byte_3;
			IKFQOTWSJJ = long_5;
			byte_9 = byte_4;
			int_10 = int_4;
			byte_10 = byte_5;
			int_13 = (int)long_6;
			byte_11 = byte_6;
			int_14 = (int)long_7;
			byte_12 = byte_7;
			this.long_9 = long_8;
			byte_13 = byte_8;
			long_10 = long_9;
			if (Operators.CompareString(Strings.Trim(string_14) + "-" + Strings.Trim(string_15) + "-" + Strings.Trim(string_16), "LITEON-DG16D2S-02510", false) == 0)
			{
				if (!ToolboxUtilities.smethod_16(ref this.byte_2, 0, kHmaKjHpik, ref byte_9, 0) && Interaction.MsgBox("Starting from Dashboard 13146 all Liteon 02510C seems were reflashed with the Same Fixed Serial Number\r\nSo its recommended you use that fixed Serial on the Generated File\r\nDo you want to use that Fixed value? (If you choose NO we will copy your Source Serial data)", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Important:") == MsgBoxResult.Yes)
				{
					string str2 = "4436303843473733383830383030333438202020FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF4130FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF4130FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF576973656C79204C6F766573204C616EFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
					this.byte_2 = ToolboxUtilities.cpoahSiso(Strings.Mid(str2, 1, int_10 * 2));
				}
				string_9 = string_14;
				string_10 = string_15;
				string_11 = string_16;
			}
			if (!FirmwareUtilities.smethod_18(string_14, string_15, string_16, string_13, ref text, this.long_6, string_12))
			{
				Interaction.MsgBox("Cannot patch keys on temporal file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return;
			}
			byte[] array = FirmwareUtilities.smethod_29(string_9, string_10, string_11, string_14, string_15, string_16, byte_1, ref text, true);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Cannot fix Identify string while preparing temporal file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return;
			}
			if (FirmwareUtilities.smethod_44(string_14, string_15, string_16, ref text) && Operators.CompareString(Strings.Trim(string_17) + Strings.Trim(string_18) + Strings.Trim(string_19), Strings.Trim(string_14) + Strings.Trim(string_15) + Strings.Trim(string_16), false) != 0 && !FirmwareUtilities.smethod_19(this.string_6, this.string_7, this.string_8, string_13, ref text, this.long_8, byte_0, TmcaFaJkxr, this.long_7, array, Conversions.ToString(int_6)))
			{
				Interaction.MsgBox("Cannot patch Identify/Inquiry on temporal file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return;
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Problem checking if Drive support Spoofing\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return;
			}
			if (!FirmwareUtilities.smethod_20(this.string_6, this.string_7, this.string_8, string_13, ref text, IKFQOTWSJJ, this.byte_2, kHmaKjHpik))
			{
				Interaction.MsgBox("Cannot patch Serial Data on temporal file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return;
			}
			if (int_14 != -1)
			{
				if (int_8 == -1)
				{
					Interaction.MsgBox("The Phisical Drive must have Keyarea but your source File dont have one to supply it\r\nMake sure you are not trying to Spoof a drive with another unsupported\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
					return;
				}
				FirmwareUtilities.smethod_36(string_13, int_14, 4096, this.byte_4);
			}
			if (int_13 != -1)
			{
				if (int_7 == -1)
				{
					Interaction.MsgBox("The Phisical Drive must have Secret Key but your source File dont have one to supply it\r\nMake sure you are not trying to Spoof a drive with another unsupported\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
					return;
				}
				FirmwareUtilities.smethod_36(string_13, int_13, 16, this.byte_3);
			}
			if (this.long_4 != -1L)
			{
				if (this.long_9 == -1L)
				{
					Interaction.MsgBox("The Phisical Drive must have 1F Sector but your Destination File dont support it\r\nMake sure you are not trying to Spoof a drive with another unsupported\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
					return;
				}
				FirmwareUtilities.smethod_36(string_13, 126976L, (int)this.long_4, this.byte_5);
			}
			if (this.long_5 != -1L)
			{
				if (long_10 == -1L)
				{
					Interaction.MsgBox("The Phisical Drive must have 3F bytes but your Destination File dont support it\r\nMake sure you are not trying to Spoof a drive with another unsupported\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
					return;
				}
				FirmwareUtilities.smethod_36(string_13, 258048L, 4, ToolboxUtilities.cpoahSiso("FFFFFFFF"));
				if (FirmwareUtilities.bool_0)
				{
					FirmwareUtilities.smethod_36(string_13, 258048L, (int)this.long_5, this.byte_6);
				}
				else if (this.long_5 > 4L)
				{
					FirmwareUtilities.smethod_36(string_13, 258048L, 4, this.byte_6);
				}
				else
				{
					FirmwareUtilities.smethod_36(string_13, 258048L, (int)this.long_5, this.byte_6);
				}
			}
			SaveFileDialog1.CreatePrompt = false;
			SaveFileDialog1.OverwritePrompt = true;
			if (Strings.InStr(Strings.UCase(cmbEV_DstCFWTemplate.Text), "ORIG", CompareMethod.Text) != 0)
			{
				SaveFileDialog1.FileName = Strings.Trim(string_17) + "_OFW";
			}
			else
			{
				SaveFileDialog1.FileName = Strings.Trim(string_17) + "_CFW";
			}
			SaveFileDialog1.DefaultExt = "bin";
			SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
			DialogResult dialogResult = SaveFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				bool flag2 = default(bool);
				uint uint_ = default(uint);
				if (((Operators.CompareString(Strings.Trim(string_14), "HITACHI", false) == 0) & (Operators.CompareString(Strings.Trim(string_15), "GDR3120L", false) == 0)) && !FirmwareUtilities.smethod_6(string_13, ref flag2, ref uint_))
				{
					FirmwareUtilities.smethod_7(string_13, 0u);
				}
				FileSystem.FileCopy(string_13, SaveFileDialog1.FileName);
			}
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void genCFW_FromFile()
		{
			string text = "";
			if (Operators.CompareString(string_13, "", false) == 0)
			{
				Interaction.MsgBox("Open a Destination Firmware or Snapshot file to take as base first", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string text2 = Application.StartupPath + "\\temp.tmp";
			try
			{
				FileSystem.FileCopy(string_13, text2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("The temporary file cannot be created, check the application is on folder with write privileges\r\nIf problem persist make sure you use latest Fileset Templates", MsgBoxStyle.Exclamation, "Error:");
				ProjectData.ClearProjectError();
				return;
			}
			byte[] array = FirmwareUtilities.smethod_35(text2, 258048L, 16);
			int num = 4;
			int num2 = 4;
			while (array[num2] != byte.MaxValue)
			{
				num++;
				num2++;
				if (num2 > 15)
				{
					break;
				}
			}
			if (!FirmwareUtilities.smethod_18(string_14, string_15, string_16, text2, ref text, long_6, string_20))
			{
				Interaction.MsgBox("Cannot patch keys on temporal file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return;
			}
			byte[] array2 = FirmwareUtilities.smethod_29(string_17, string_18, string_19, string_14, string_15, string_16, byte_8, ref text, true);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Cannot fix Identify string while preparing temporal file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return;
			}
			if (FirmwareUtilities.smethod_44(string_14, string_15, string_16, ref text) && Operators.CompareString(Strings.Trim(string_17) + Strings.Trim(string_18) + Strings.Trim(string_19), Strings.Trim(string_14) + Strings.Trim(string_15) + Strings.Trim(string_16), false) != 0 && !FirmwareUtilities.smethod_19(string_14, string_15, string_16, text2, ref text, long_8, byte_7, int_12, long_7, array2, Conversions.ToString(int_11)))
			{
				Interaction.MsgBox("Cannot patch Identify/Inquiry on temporal file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return;
			}
			if (!FirmwareUtilities.smethod_20(string_14, string_15, string_16, text2, ref text, IKFQOTWSJJ, byte_9, int_10))
			{
				Interaction.MsgBox("Cannot patch Serial Data on temporal file\r\nError: " + text, MsgBoxStyle.Information, "Returns:");
				return;
			}
			if (int_14 != -1)
			{
				FirmwareUtilities.smethod_36(text2, int_14, 4096, byte_11);
			}
			if (int_13 != -1)
			{
				FirmwareUtilities.smethod_36(text2, int_13, 16, byte_10);
			}
			if (long_9 != -1L)
			{
				FirmwareUtilities.smethod_36(text2, 126976L, (int)long_9, byte_12);
			}
			if (long_10 != -1L)
			{
				if (long_10 > num)
				{
					FirmwareUtilities.smethod_36(text2, 258048L, num, byte_13);
				}
				else
				{
					FirmwareUtilities.smethod_36(text2, 258048L, (int)long_10, byte_13);
				}
			}
			SaveFileDialog1.CreatePrompt = false;
			SaveFileDialog1.OverwritePrompt = true;
			SaveFileDialog1.FileName = Strings.Trim(string_14) + "_CFW";
			SaveFileDialog1.DefaultExt = "bin";
			SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
			DialogResult dialogResult = SaveFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				bool flag = default(bool);
				uint uint_ = default(uint);
				if (((Operators.CompareString(Strings.Trim(string_14), "HITACHI", false) == 0) & (Operators.CompareString(Strings.Trim(string_15), "GDR3120L", false) == 0)) && !FirmwareUtilities.smethod_6(text2, ref flag, ref uint_))
				{
					FirmwareUtilities.smethod_7(text2, 0u);
				}
				FileSystem.FileCopy(text2, SaveFileDialog1.FileName);
				Interaction.MsgBox("The file has been generated", MsgBoxStyle.Information, "Success");
			}
		}

		private void method_36(object sender, EventArgs e)
		{
		}

		private void method_37(object sender, ToolStripItemClickedEventArgs e)
		{
			if (Operators.CompareString(MNU_MAN_EDIT.Text, "KEY LOAD OPTIONS", false) == 0 && Operators.CompareString(e.ClickedItem.Name, "SMOAV_DSTEDIT_MAN_EDIT", false) == 0)
			{
				txbAV_DstKey.ReadOnly = false;
				txbAV_DstKey.Focus();
			}
			if (Operators.CompareString(MNU_MAN_EDIT.Text, "SERIAL LOAD OPTIONS", false) == 0 && Operators.CompareString(e.ClickedItem.Name, "SMOAV_DSTEDIT_MAN_EDIT", false) == 0)
			{
				txbAV_DstDVDSer.ReadOnly = false;
				txbAV_DstDVDSer.Focus();
			}
			if (Operators.CompareString(MNU_MAN_EDIT.Text, "LOGICAL DRIVE LOAD OPTIONS", false) == 0 && Operators.CompareString(e.ClickedItem.Name, "SMOAV_DSTEDIT_MAN_EDIT", false) == 0)
			{
				cmbAV_DstLogDrive.Enabled = true;
				cmbAV_DstLogDrive.Focus();
			}
		}

		private void btn_editDstKey_Click(object sender, EventArgs e)
		{
			SMOAV_DSTEDIT_LOADF_FILE.Text = "Load from KEY.bin file";
			SMOAV_DSTEDIT_MAN_EDIT.Text = "Allow me to Manually type a value";
			SMOAV_DSTEDIT_LOADF_FILE.Visible = true;
			SMOAV_DSTEDIT_LOADF_FW.Visible = true;
			MNU_MAN_EDIT.Text = "KEY LOAD OPTIONS";
			MNU_MAN_EDIT.Show(Control.MousePosition);
		}

		private void btn_editDstSer_Click(object sender, EventArgs e)
		{
			SMOAV_DSTEDIT_LOADF_FILE.Text = "Load from SERIAL.bin file";
			SMOAV_DSTEDIT_MAN_EDIT.Text = "Allow me to Manually type a value";
			SMOAV_DSTEDIT_LOADF_FILE.Visible = true;
			SMOAV_DSTEDIT_LOADF_FW.Visible = true;
			MNU_MAN_EDIT.Text = "SERIAL LOAD OPTIONS";
			MNU_MAN_EDIT.Show(Control.MousePosition);
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			method_29();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(string_13, "", false) == 0)
			{
				Interaction.MsgBox("Please open destination file first", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string text = "";
			if (!FirmwareUtilities.smethod_26(txbAV_DstKey.Text, ref text))
			{
				Interaction.MsgBox(text, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (!txbAV_DstDVDSer.ReadOnly && int_10 > 0)
			{
				byte[] array = (byte[])ToolboxUtilities.smethod_7(Strings.Mid(txbAV_DstDVDSer.Text + Strings.Space(20), 1, 20));
				ToolboxUtilities.smethod_13(ref array, 0, 20, ref byte_9, 0);
			}
			if (!txbAV_DstKey.ReadOnly)
			{
				string_20 = txbAV_DstKey.Text;
			}
			if (int_14 != -1)
			{
				byte[] array2 = new byte[16];
				if (!FirmwareUtilities.smethod_40(string_14, string_15, string_16, ref text, ref byte_11, ref byte_9, ref array2))
				{
					Interaction.MsgBox("Cannot Get Key from Destination Key Area\r\nError: " + text, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				if (Operators.CompareString(string_20, ToolboxUtilities.smethod_5(ref array2), false) != 0 && Interaction.MsgBox("If you continue we will re-generate a keyarea for this firmware but due to Console checks it might not work\r\nIt is recommended you stop now and Load a source Firmware with a valid Keyarea\r\nIf you continue there is possibility the games not boot and your console being flagged for ban\r\nDo you want to continue?", MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2, "Warning!") == MsgBoxResult.Yes && Interaction.MsgBox("It is recommended you stop now and Load a source Firmware with a valid Keyarea\r\nIf you continue there is possibility the games not boot and your console being flagged for ban\r\nReally Sure?", MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2, "Warning!") == MsgBoxResult.Yes)
				{
					string obj = string_14;
					string obj2 = string_15;
					string obj3 = string_16;
					ref byte[] reference = ref byte_9;
					ref byte[] reference2 = ref byte_11;
					byte[] array = ToolboxUtilities.cpoahSiso(string_20);
					if (!FirmwareUtilities.smethod_42(obj, obj2, obj3, ref reference, ref text, ref reference2, ref array))
					{
						Interaction.MsgBox("Cannot Regenerate Keyarea on the Destination File\r\nError: " + text, MsgBoxStyle.Exclamation, "Error:");
						return;
					}
				}
			}
			if (cmbAV_DstLogDrive.Enabled && Operators.CompareString(cmbAV_DstLogDrive.Text, Strings.Trim(string_17) + "-" + Strings.Trim(string_18) + "-" + Strings.Trim(string_19), false) != 0 && !method_26())
			{
				return;
			}
			string right;
			if (Operators.CompareString(string_5, "", false) != 0)
			{
				string left = Strings.Trim(string_9) + "-" + Strings.Trim(string_10) + "-" + Strings.Trim(string_11);
				right = Strings.Trim(string_17) + "-" + Strings.Trim(string_18) + "-" + Strings.Trim(string_19);
				if ((Operators.CompareString(left, right, false) != 0 && Interaction.MsgBox("The Generated file will be seen by the console different as was seen with the Source file\r\nMaybe you forget click on the Spoof Button?\r\nDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "Warning") == MsgBoxResult.No) || (Operators.CompareString(string_12, string_20, false) != 0 && Interaction.MsgBox("The Generated file will be have different key as the Source file\r\nMaybe you forget click on the Spoof Button?\r\nDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "Warning") == MsgBoxResult.No))
				{
					return;
				}
			}
			string left2 = Strings.Trim(string_14) + "-" + Strings.Trim(string_15) + "-" + Strings.Trim(string_16);
			right = Strings.Trim(string_17) + "-" + Strings.Trim(string_18) + "-" + Strings.Trim(string_19);
			if (Operators.CompareString(left2, right, false) != 0 && !FirmwareUtilities.smethod_44(string_14, string_15, string_16, ref text))
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					Interaction.MsgBox("Cannot Check if Destination is Spoofeable\r\nError: " + text, MsgBoxStyle.Exclamation, "Error:");
				}
				else
				{
					Interaction.MsgBox("The Destination File does not Support Spoofing", MsgBoxStyle.Exclamation, "Error:");
				}
			}
			else if (FirmwareUtilities.smethod_27(string_20, ref text) || Interaction.MsgBox("The Key used on the Generated file has the following issue:\r\n" + text + "\r\nDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.No)
			{
				genCFW_FromFile();
			}
		}

		private void btn_editDstLogDrive_Click(object sender, EventArgs e)
		{
			SMOAV_DSTEDIT_LOADF_FILE.Visible = false;
			SMOAV_DSTEDIT_LOADF_FW.Visible = false;
			SMOAV_DSTEDIT_MAN_EDIT.Text = "Allow me to change this value";
			MNU_MAN_EDIT.Text = "LOGICAL DRIVE LOAD OPTIONS";
			MNU_MAN_EDIT.Show(Control.MousePosition);
		}

		private void method_38(object sender, CancelEventArgs e)
		{
		}

		private void method_39(object sender, EventArgs e)
		{
			if (cmbEV_DstCFWTemplate.SelectedIndex == 0)
			{
				Interaction.MsgBox("Select a Template from the list, if none listed use the download button to get them", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			int num = cmbEV_DstCFWTemplate.SelectedIndex - 1;
			SaveFileDialog1.CreatePrompt = false;
			SaveFileDialog1.OverwritePrompt = true;
			SaveFileDialog1.FileName = "output";
			SaveFileDialog1.DefaultExt = "bin";
			SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
			DialogResult dialogResult = SaveFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string text = Strings.Mid(SaveFileDialog1.FileName, 1, Strings.InStrRev(SaveFileDialog1.FileName, "\\", -1, CompareMethod.Text));
				CfwTemplateParser.smethod_2(struct3_0[num].string_3, text);
			}
		}

		private void method_40(object sender, EventArgs e)
		{
			Process.Start("http://cfwfileset.blogspot.com/");
		}

		private void method_41(object sender, EventArgs e)
		{
			Label22.ForeColor = Color.Red;
		}

		private void method_42(object sender, EventArgs e)
		{
		}

		private void method_43(object sender, EventArgs e)
		{
			Label22.ForeColor = Color.Blue;
		}

		private void method_44(object sender, EventArgs e)
		{
			Label15.ForeColor = Color.Red;
		}

		private void method_45(object sender, EventArgs e)
		{
			Label15.ForeColor = Color.Blue;
		}

		private void SMOAV_DSTEDIT_LOADF_FILE_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(MNU_MAN_EDIT.Text, "KEY LOAD OPTIONS", false) == 0)
			{
				OpenFileDialog1.Filter = "Key files (*.bin)|*.bin|All files (*.*)|*.*";
				OpenFileDialog1.FileName = "";
				DialogResult dialogResult = OpenFileDialog1.ShowDialog();
				if (dialogResult != DialogResult.OK)
				{
					return;
				}
				string fileName = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
				if (FileSystem.FileLen(fileName) != 16L)
				{
					Interaction.MsgBox("Please choose a valid 16 byte Key file", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				byte[] array = FirmwareUtilities.smethod_35(fileName, 0L, 16);
				string text = ToolboxUtilities.smethod_5(ref array);
				txbAV_DstKey.ReadOnly = false;
				txbAV_DstKey.Text = text;
			}
			if (Operators.CompareString(MNU_MAN_EDIT.Text, "SERIAL LOAD OPTIONS", false) != 0)
			{
				return;
			}
			OpenFileDialog1.Filter = "Serial files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult2 = OpenFileDialog1.ShowDialog();
			if (dialogResult2 == DialogResult.OK)
			{
				string fileName = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
				if (FileSystem.FileLen(fileName) != 80L)
				{
					Interaction.MsgBox("Please choose a valid 80 byte Serial file", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				byte[] array = FirmwareUtilities.smethod_35(fileName, 0L, 20);
				string text2 = Strings.Trim(ToolboxUtilities.smethod_1(ref array));
				txbAV_DstDVDSer.ReadOnly = false;
				txbAV_DstDVDSer.Text = text2;
			}
		}

		private void SMOAV_DSTEDIT_LOADF_FW_Click(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "Fw files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			string fileName = OpenFileDialog1.FileName;
			OpenFileDialog1.InitialDirectory = "";
			string string_ = "";
			byte[] byte_ = default(byte[]);
			if (!method_28(fileName, ref string_, ref byte_))
			{
				return;
			}
			if (Operators.CompareString(MNU_MAN_EDIT.Text, "KEY LOAD OPTIONS", false) == 0)
			{
				txbAV_DstKey.ReadOnly = false;
				txbAV_DstKey.Text = string_;
			}
			if (Operators.CompareString(MNU_MAN_EDIT.Text, "SERIAL LOAD OPTIONS", false) != 0)
			{
				return;
			}
			txbAV_DstDVDSer.ReadOnly = false;
			try
			{
				txbAV_DstDVDSer.Text = Strings.Trim(ToolboxUtilities.smethod_1(ref byte_, 20));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				txbAV_DstDVDSer.Text = "";
				ProjectData.ClearProjectError();
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			ResXResourceSet resXResourceSet = new ResXResourceSet(Application.StartupPath + "\\es.resx");
			Button4.Text = resXResourceSet.GetString("String1");
			resXResourceSet.Close();
		}

		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		private void TabPage2_Click(object sender, EventArgs e)
		{
		}

		private void method_46(object sender, EventArgs e)
		{
			SerialPort1.BaudRate = 115200;
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			method_11();
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			byte[] buf = new byte[1025];
			byte[] buf2 = new byte[1025];
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 2000;
			FolderBrowserDialog1.ShowNewFolderButton = true;
			DialogResult dialogResult = FolderBrowserDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK || !chkfolder_overwrite(FolderBrowserDialog1.SelectedPath))
			{
				return;
			}
			SaveFileDialog1.InitialDirectory = FolderBrowserDialog1.SelectedPath + "\\";
			SaveFileDialog1.FileName = FolderBrowserDialog1.SelectedPath + "\\source.bin";
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			DateTime timeOfDay = DateAndTime.TimeOfDay;
			int num = 0;
			int num2 = default(int);
			while (true)
			{
				if (!method_49())
				{
					return;
				}
				send_STX();
				if (liz_GETPAGE(1024, ref buf) != 0)
				{
					if (num == 0)
					{
						bool_3 = !bool_3;
						tbmode_refreshlabel();
						num = 1;
						continue;
					}
					bool_3 = !bool_3;
					tbmode_refreshlabel();
					Interaction.MsgBox("Error occurred reading Transmission Header " + Conversions.ToString(num2), MsgBoxStyle.Exclamation, "Error:");
					break;
				}
				string text2;
				if (((buf[2] == 75) & (buf[3] == 69) & (buf[4] == 89)) | ((buf[2] == 83) & (buf[3] == 78) & (buf[4] == 65) & (buf[5] == 80)))
				{
					string text = Strings.Replace(SaveFileDialog1.FileName, ".bin", ".snp");
					text2 = Strings.Replace(SaveFileDialog1.FileName, ".bin", "_dummy.bin");
					FileStream fileStream = new FileStream(text, FileMode.Create);
					fileStream.Write(buf, 0, 1024);
					int num3 = buf[1];
					int num4 = buf[0];
					int num5 = num3 - 1;
					num2 = 0;
					while (true)
					{
						if (num2 <= num5)
						{
							if (liz_GETPAGE(1024, ref buf2) == 0)
							{
								fileStream.Write(buf2, 0, 1024);
								num2++;
								continue;
							}
							fileStream.Close();
							Interaction.MsgBox("Error occurred reading page " + Conversions.ToString(num2), MsgBoxStyle.Exclamation, "Error:");
							break;
						}
						fileStream.Close();
						string text3 = Strings.Mid(text, 1, Strings.InStrRev(text, "\\", -1, CompareMethod.Text));
						if (!clear_folder(text3))
						{
							break;
						}
						long num6 = 1024L;
						FileStream fileStream2 = new FileStream(text, FileMode.Open);
						int num7 = num4 - 1;
						for (num2 = 0; num2 <= num7; num2++)
						{
							string text4 = method_17(ref buf, num2);
							long num8 = method_18(ref buf, num2);
							bool flag = method_19(ref buf, num2);
							int num9 = (int)(num8 / 1024L + 1L);
							if (flag && (num6 & 0x3FFL) > 0L)
							{
								num6 = (num6 + 1024L) & 0xFC00L;
							}
							long num10 = num6;
							fileStream2.Seek(num10, SeekOrigin.Begin);
							FileStream fileStream3 = new FileStream(text3 + text4, FileMode.Create);
							int num11 = num9 - 1;
							for (int i = 0; i <= num11; i++)
							{
								int count = (int)((i != num9 - 1) ? 1024 : (num8 & 0x3FFL));
								fileStream2.Read(buf2, 0, count);
								fileStream3.Write(buf2, 0, count);
							}
							fileStream3.Close();
							num6 = num10 + num8;
						}
						fileStream2.Close();
						DateTime timeOfDay2 = DateAndTime.TimeOfDay;
						if (!method_16(text, text2))
						{
							Interaction.MsgBox("Problem Generating " + text2 + " file", MsgBoxStyle.Exclamation, "Error:");
							break;
						}
						Interaction.MsgBox("The File " + text2 + " has been Created\r\nTotal Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, timeOfDay, timeOfDay2)) + " secs\r\nThe file will Auto-load Now on CFW Generator Tab", MsgBoxStyle.Information, "Read Complete:");
						method_27(text2);
						break;
					}
					break;
				}
				text2 = SaveFileDialog1.FileName;
				FileStream fileStream4 = new FileStream(text2, FileMode.Create);
				fileStream4.Write(buf, 0, 1024);
				ProgressBar1.Maximum = 255;
				ProgressBar1.Value = 0;
				ProgressBar1.Visible = true;
				lblAction.Text = "Reading";
				Enabled = false;
				int num12 = 255;
				num2 = 1;
				while (true)
				{
					if (num2 <= num12)
					{
						if (liz_GETPAGE(1024, ref buf2) == 0)
						{
							fileStream4.Write(buf2, 0, 1024);
							ProgressBar1.Value = num2;
							num2++;
							continue;
						}
						Interaction.MsgBox("Error occurred at address " + Conversion.Hex(num2 * 1024), MsgBoxStyle.Exclamation, "Error:");
						break;
					}
					fileStream4.Close();
					DateTime timeOfDay2 = DateAndTime.TimeOfDay;
					Interaction.MsgBox("The File " + text2 + " has been Created\r\nTotal Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, timeOfDay, timeOfDay2)) + " secs\r\nThe file will Auto-load Now on CFW Generator Tab", MsgBoxStyle.Information, "Read Complete:");
					method_27(text2);
					break;
				}
				break;
			}
			ProgressBar1.Value = 0;
			ProgressBar1.Visible = false;
			lblAction.Text = "Idle";
			Enabled = true;
			SerialPort1.Close();
		}

		private void Label24_Click(object sender, EventArgs e)
		{
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(txbAddrSect.Text, 16) & 0x3FFFF;
			byte[] array = FirmwareUtilities.smethod_35(Application.StartupPath + "\\fc.bin", 0L, 8192);
			array[11] = 144;
			array[10] = (byte)((num >> 16) & 0xFF);
			array[9] = (byte)((num >> 8) & 0xFF);
			array[8] = (byte)(num & 0xFF);
			array[33] = 144;
			array[32] = (byte)((num >> 16) & 0xFF);
			array[31] = (byte)((num >> 8) & 0xFF);
			array[30] = (byte)(num & 0xFF);
			array[51] = 0;
			array[50] = 0;
			array[49] = 16;
			array[48] = 0;
			byte[] array2 = FirmwareUtilities.smethod_35(string_5, num, 4096);
			string path = Application.StartupPath + "\\fco.bin";
			FileStream fileStream = new FileStream(path, FileMode.Create);
			fileStream.Write(array, 0, 8192);
			fileStream.Close();
			HitachiKeyScrambler.smethod_8(path, 2208L, 4096, true, array2);
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			Application.DoEvents();
			int num2 = 0;
			do
			{
				bool bContinuedRead = ((num2 != 0) ? true : false);
				int num3 = 262144 + num2 * 4096;
				if (SPIF_BSERASE(num3, 4, bContinuedRead) == 0)
				{
					num2++;
					continue;
				}
				Interaction.MsgBox("Error occurred Erasing address " + Conversion.Hex(num3), MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			while (num2 <= 1);
			ToolboxUtilities.smethod_22(1);
			FileStream fileStream2 = new FileStream(path, FileMode.Open);
			byte[] buf = new byte[1025];
			num2 = 0;
			do
			{
				bool bContinuedRead = ((num2 != 0) ? true : false);
				int num3 = 262144 + num2 * 1024;
				fileStream2.Read(buf, 0, 1024);
				if (SPIF_WRITEPAGE(num3, 1024, ref buf, bContinuedRead) == 0)
				{
					num2++;
					continue;
				}
				fileStream2.Close();
				Interaction.MsgBox("Error occurred writting address " + Conversion.Hex(num3), MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			while (num2 <= 7);
			fileStream2.Close();
			ToolboxUtilities.smethod_22(1);
			path = Application.StartupPath + "\\fco_rb.bin";
			FileStream fileStream3 = new FileStream(path, FileMode.Create);
			num2 = 0;
			do
			{
				bool bContinuedRead = ((num2 != 0) ? true : false);
				int num3 = 262144 + num2 * 1024;
				if (SPIF_READPAGE(num3, 1024, ref buf, bContinuedRead) == 0)
				{
					fileStream3.Write(buf, 0, 1024);
					num2++;
					continue;
				}
				fileStream3.Close();
				Interaction.MsgBox("Error occurred Reading address " + Conversion.Hex(num3), MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			while (num2 <= 7);
			fileStream3.Close();
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "FW files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				txbhitsrc.Text = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
			}
		}

		private void Button10_Click(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "FW files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				txbhitdst.Text = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
			}
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void Button13_Click(object sender, EventArgs e)
		{
			if ((Operators.CompareString(txbhitdst.Text, "", false) == 0) | (Operators.CompareString(txbhitsrc.Text, "", false) == 0))
			{
				Interaction.MsgBox("Choose Source and Destination Filenames to compare", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if ((Operators.CompareString(FileSystem.Dir(txbhitsrc.Text), "", false) == 0) | (Operators.CompareString(FileSystem.Dir(txbhitdst.Text), "", false) == 0))
			{
				Interaction.MsgBox("Choose valid Source and Destination Filenames to compare", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string text = "";
			string str = FirmwareUtilities.smethod_3(txbhitsrc.Text, ref text);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Error Ocurred: " + text, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (Operators.CompareString(Strings.Trim(str), "HITACHI", false) != 0)
			{
				Interaction.MsgBox("The file " + txbhitsrc.Text + " is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string str2 = FirmwareUtilities.smethod_4(str, txbhitsrc.Text, ref text);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Error Ocurred: " + text, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (Operators.CompareString(Strings.Trim(str2), "GDR3120L", false) != 0)
			{
				Interaction.MsgBox("The file " + txbhitsrc.Text + " is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			FirmwareUtilities.smethod_9(str, str2, txbhitsrc.Text, ref text);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Error Ocurred: " + text, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			bool flag = FirmwareUtilities.cpoahSiso(str, str2, txbhitsrc.Text, ref text);
			bool flag2 = FirmwareUtilities.smethod_5(str, str2, txbhitsrc.Text, flag, ref text);
			text = "";
			string str3 = FirmwareUtilities.smethod_3(txbhitdst.Text, ref text);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Error Ocurred: " + text, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (Operators.CompareString(Strings.Trim(str3), "HITACHI", false) != 0)
			{
				Interaction.MsgBox("The file " + txbhitdst.Text + " is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string str4 = FirmwareUtilities.smethod_4(str3, txbhitdst.Text, ref text);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Error Ocurred: " + text, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (Operators.CompareString(Strings.Trim(str4), "GDR3120L", false) != 0)
			{
				Interaction.MsgBox("The file " + txbhitsrc.Text + " is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			FirmwareUtilities.smethod_9(str3, str4, txbhitdst.Text, ref text);
			if (Operators.CompareString(text, "", false) != 0)
			{
				Interaction.MsgBox("Error Ocurred: " + text, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			FirmwareUtilities.cpoahSiso(str3, str4, txbhitdst.Text, ref text);
			bool flag3 = FirmwareUtilities.smethod_5(str, str2, txbhitdst.Text, flag, ref text);
			if (flag2 && flag3)
			{
				Interaction.MsgBox("Both Files seems to be original, nothing to do", MsgBoxStyle.Exclamation, "Notice:");
				return;
			}
			if (!flag2 && !flag3)
			{
				Interaction.MsgBox("You are trying to put a CFW over a drive that already has a CFW\r\nYou need to restore your drive to original first", MsgBoxStyle.Exclamation, "Notice:");
				return;
			}
			int[] int_ = default(int[]);
			int int_2 = default(int);
			if (flag2 && !flag3)
			{
				FirmwareUtilities.smethod_39(txbhitsrc.Text, txbhitdst.Text, ref int_, ref int_2);
			}
			if (!flag2 && flag3)
			{
				FirmwareUtilities.smethod_39(txbhitsrc.Text, txbhitdst.Text, ref int_, ref int_2, true);
			}
			lstSectors.Items.Clear();
			int num = int_2 - 1;
			for (int i = 0; i <= num; i++)
			{
				string item = Strings.Right("00" + Conversion.Hex(int_[i]), 5);
				lstSectors.Items.Add(item);
			}
		}

		private void method_47(object sender, EventArgs e)
		{
		}

		public void send_HitSectors2FlashBuffer(string sFileBase)
		{
			string path = Application.StartupPath + "\\fco.bin";
			FileStream fileStream = new FileStream(path, FileMode.Create);
			int num = 0;
			int num2 = lstSectors.Items.Count - 1;
			int i;
			for (i = 0; i <= num2; i++)
			{
				int num3 = Convert.ToInt32(Conversions.ToString(lstSectors.Items[i]), 16) & 0x3FFFF;
				byte[] array = ToolboxUtilities.cpoahSiso("CFF8FAFCFFFDFCCC00000000013409FCFF41000000342E09A000C923FCCC00000000013409FCCCA0080080013809FCCC00000000012C09FCFF8904000000421CCBCBFAFD0002CEF8DF0008CBCBCBCBCBCF08CF20F8FEFCFCFF29040000F8FE0434A8D98501F21402A8D9F8FEFCFCFF76000000F8FE04FCA8203000802DFF00A1C8398005FC8100300080F8FEFCFCFF80020000F8FE04F8FEFCFCFFA2030000F8FE0481C81EFCA400300080FCC401000000FC8100300080C9D32CFF00022E09CA078000022E0934A8D92DFE00F20402A8D9F8FEFCFCFFCC030000F8FE04CE20CE08F0FCFCDC00000090FAD055552CAA00F050FCDD00000090FAD1AA2A8055F0512C9000F050CBCBFCA800000090FC8220300080FCA800100090FC8224300080FCA800200090FC8228300080FCA801000090FC82043000802CAA00F0508055F0512CF000F050CBCBF8FEFCFCFF16030000F8FE04851FFCA820300080A4C920FCA824300080A4C917FCA828300080A4C90E2C0020FC812C300080CC9201FCDC00000090FAD055052CAA00F050FCDD00000090FAD1AA028055F0512C9000F050CBCBFCA800000090FC8220300080FCA800100090FC8224300080FCA800200090FC8228300080FCA801000090FC82043000802CAA00F0508055F0512CF000F050CBCBF8FEFCFCFF7D020000F8FE042DC200FCA820300080A4C920FCA824300080A4C917FCA828300080A4C90E2C0020FC812C300080CCF8002D9D00FCA820300080A4C920FCA824300080A4C917FCA828300080A4C90E2C0010FC812C300080CCCE008537FCA820300080A4C920FCA824300080A4C917FCA828300080A4C90E2C0020FC812C300080CCA500FCDC00000090FAD055552CAA00F050FCDD00000090FAD1AA2A8055F0512C9000F050CBCBFCA800000090FC8220300080FCA800000090FC8224300080FCA800000090FC8228300080FCA801000090FC82043000802CAA00F0508055F0512CF000F050CBCBF8FEFCFCFF90010000F8FE042DBF00FCA820300080A4C91FFCA824300080A4C916FCA828300080A4C90D2C0010FC812C300080CA0B2CFF00FC8220300080F0FCFCA820300080851FA4C8192DC200A4C8552D9D00A4C905CC8F008537A4C847CC9D00FCDC00000090FAD055552CAA00F050FCDD00000090FAD1AA2A8055F0512C8000F0502CAA00F0508055F051FAA034098030F050F8FEFCFCFFFB000000F8FE04CCCB00FCDC00000090FAD055052CAA00F050FCDD00000090FAD1AA028055F0512C8000F0502CAA00F0508055F051FAA034098030F050F8FEFCFCFFB9000000F8FE04CC8900FCDC00000090FAD05505FCDD00000090FAD1AA02CA16FCDC00000090FAD05555FCDD00000090FAD1AA2A2CAA00F0508055F0512C8000F0502CAA00F0508055F051FAA234098030F052F8FEFCFCFF61000000F8FE04CBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCA02F0FCFCA52C300080FAA03409F040FAC8FF00C91041FCC501000000C9F18000DF00002CFF00F0FCFCA800000090CBCBFCA900000090CBCBA1C9EFFCA900000090CBCBA1C9E4F0FC3404D9F8E080C9FACBCB80010200DFCBCB80000201DFCBCB2C9A000228DFF0FC3404D9F8E080C9FACBCB80000200DFCBCB80000201DFCBCB2C9A000228DFF0FCCF08F8FEFCFCFF9A030000F8FE0434A8D98501F21402A8D9F8FEFCFCFFA3000000F8FE04FCA8203000802DFF00A1C842382C09FC812C300080800AFC8100300080F8FEFCFCFF8C020000F8FE04F8FEFCFCFF16030000F8FE0481C81EFCA400300080FCC401000000FC8100300080C9D32CFF00022E09CA2DFAA0340941FA803409FAA0380941FA803809FCA42C300080FCC401000000FC812C300080C99D8000022E0934A8D92DFE00F20402A8D9F8FEFCFCFF0E030000F8FE04CE08F0FCFCDC00000090FAD055552CAA00F050FCDD00000090FAD1AA2A8055F0512C9000F050CBCBFCA800000090FC8220300080FCA800100090FC8224300080FCA800200090FC8228300080FCA801000090FC82043000802CAA00F0508055F0512CF000F050CBCBF8FEFCFCFF5A020000F8FE04851FFCA820300080A4C919FCA824300080A4C910FCA828300080A4C907C905CC6E01FCDC00000090FAD055052CAA00F050FCDD00000090FAD1AA028055F0512C9000F050CBCBFCA800000090FC8220300080FCA800100090FC8224300080FCA800200090FC8228300080FCA801000090FC82043000802CAA00F0508055F0512CF000F050CBCBF8FEFCFCFFC8010000F8FE042DC200FCA820300080A4C917FCA824300080A4C90EFCA828300080A4C905CCDD002D9D00FCA820300080A4C917FCA824300080A4C90EFCA828300080A4C905CCBC008537FCA820300080A4C917FCA824300080A4C90EFCA828300080A4C905CC9C00FCDC00000090FAD055552CAA00F050FCDD00000090FAD1AA2A8055F0512C9000F050CBCBFCA800000090FC8220300080FCA800000090FC8224300080FCA800000090FC8228300080FCA801000090FC82043000802CAA00F0508055F0512CF000F050CBCBF8FEFCFCFFF6000000F8FE042DBF00FCA820300080A4C916FCA824300080A4C90DFCA828300080A4C904C80B2CFF00FC8220300080F0FCCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBCBFCA820300080851FA4C8152DC200A4C84B2D9D00A4C8458537A4C840CA02FCDC00000090FAD055552CAA00F050FCDD00000090FAD1AA2A8055F0512CA000F050FAA13409FAA03809F040F051F8FEFCFCFF60000000F8FE04CA3CFCDC00000090FAD055052CAA00F050FCDD00000090FAD1AA028055F0512CA000F050FAA13409FAA03809F040F051F8FEFCFCFF24000000F8FE04F0FCFAA13409FAA03809F040F045A4C9078000DF00002CFF00F0FCFCA800000090CBCBFCA900000090CBCBA1C9EFFCA900000090CBCBA1C9E4F0FC3404D9F8E080C9FACBCB80010200DFCBCB80000201DFCBCB2C9A000228DFF0FC3404D9F8E080C9FACBCB80000200DFCBCB80000201DFCBCB2C9A000228DFF0FCCBFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF44554D4D5920415245412044554D4D59000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
				array[11] = 144;
				array[10] = (byte)((num3 >> 16) & 0xFF);
				array[9] = (byte)((num3 >> 8) & 0xFF);
				array[8] = (byte)(num3 & 0xFF);
				array[33] = 144;
				array[32] = (byte)((num3 >> 16) & 0xFF);
				array[31] = (byte)((num3 >> 8) & 0xFF);
				array[30] = (byte)(num3 & 0xFF);
				array[51] = 0;
				array[50] = 0;
				array[49] = 16;
				array[48] = 0;
				byte[] array2 = FirmwareUtilities.smethod_35(sFileBase, num3, 4096);
				HitachiKeyScrambler.smethod_9(ref array2, 4096);
				ToolboxUtilities.smethod_13(ref array2, 0, 4096, ref array, 2208);
				fileStream.Write(array, 0, 8192);
				num++;
			}
			fileStream.Close();
			if (num == 0)
			{
				return;
			}
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			Application.DoEvents();
			int num4 = num * 2;
			int num5 = num4;
			i = 0;
			int num8;
			while (true)
			{
				bool bContinuedRead;
				if (i > num5)
				{
					ToolboxUtilities.smethod_22(1);
					int num6 = (int)Math.Round((double)num * 4.0 * 2.0);
					FileStream fileStream2 = new FileStream(path, FileMode.Open);
					byte[] buf = new byte[1025];
					ProgressBar1.Maximum = num6 - 1;
					ProgressBar1.Value = 0;
					ProgressBar1.Visible = true;
					lblAction.Text = "Filling Flashing Buffer";
					int num7 = num6 - 1;
					i = 0;
					while (true)
					{
						if (i > num7)
						{
							fileStream2.Close();
							hitminilog("Flashing Buffer Ready, Click on WRITE Now !");
							lblAction.Text = "Idle";
							ProgressBar1.Visible = false;
							return;
						}
						bContinuedRead = ((i != 0) ? true : false);
						num8 = 262144 + i * 1024;
						fileStream2.Read(buf, 0, 1024);
						if (SPIF_WRITEPAGE(num8, 1024, ref buf, bContinuedRead) != 0)
						{
							break;
						}
						ProgressBar1.Value = i;
						Application.DoEvents();
						i++;
					}
					fileStream2.Close();
					lblAction.Text = "Idle";
					ProgressBar1.Visible = false;
					Interaction.MsgBox("Error occurred writting address " + Conversion.Hex(num8), MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				bContinuedRead = ((i != 0) ? true : false);
				num8 = 262144 + i * 4096;
				if (SPIF_BSERASE(num8, 4, bContinuedRead) != 0)
				{
					break;
				}
				i++;
			}
			Interaction.MsgBox("Error occurred Erasing address " + Conversion.Hex(num8), MsgBoxStyle.Exclamation, "Error:");
		}

		private void Button15_Click(object sender, EventArgs e)
		{
			byte[] buf = new byte[1025];
			int num = 256;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			ToolboxUtilities.smethod_22(1);
			string path = Application.StartupPath + "\\bufsect.bin";
			FileStream fileStream = new FileStream(path, FileMode.Create);
			int num2 = num - 1;
			int num3 = 0;
			int num4;
			while (true)
			{
				if (num3 > num2)
				{
					fileStream.Close();
					return;
				}
				bool bContinuedRead = ((num3 != 0) ? true : false);
				num4 = 262144 + num3 * 1024;
				if (SPIF_READPAGE(num4, 1024, ref buf, bContinuedRead) != 0)
				{
					break;
				}
				fileStream.Write(buf, 0, 1024);
				num3++;
			}
			fileStream.Close();
			Interaction.MsgBox("Error occurred Reading address " + Conversion.Hex(num4), MsgBoxStyle.Exclamation, "Error:");
		}

		private void Button16_Click(object sender, EventArgs e)
		{
			Hit_Analyze_Changes(false, "");
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void Hit_Analyze_Changes(bool bForceRestore, string sFileBaseForRestore)
		{
			byte[] array = new byte[4];
			byte[] buf = new byte[51];
			if (bForceRestore)
			{
				RadioButton1.Checked = true;
				Application.DoEvents();
			}
			lstSectors.Items.Clear();
			Application.DoEvents();
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			hitminilog("", true);
			string text;
			string str;
			string str2;
			string str3;
			string right;
			long num = default(long);
			bool flag2;
			bool flag3 = default(bool);
			uint uint_ = default(uint);
			string text3;
			string str4;
			string str5;
			string text4;
			string left;
			long num3 = default(long);
			bool flag4;
			if (RadioButton2.Checked)
			{
				if (Operators.CompareString(txbFile2Flash.Text, "", false) == 0)
				{
					Interaction.MsgBox("Choose the File you want to Flash", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				hitminilog("Parsing Destination File", true);
				text = txbFile2Flash.Text;
				string text2 = "";
				str = FirmwareUtilities.smethod_3(text, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				if (Operators.CompareString(Strings.Trim(str), "HITACHI", false) != 0)
				{
					Interaction.MsgBox("The file " + text + " is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				str2 = FirmwareUtilities.smethod_4(str, text, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				if (Operators.CompareString(Strings.Trim(str2), "GDR3120L", false) != 0)
				{
					Interaction.MsgBox("The file " + text + " is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				str3 = FirmwareUtilities.smethod_9(str, str2, text, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				right = FirmwareUtilities.smethod_15(str, str2, str3, text, ref text2, ref num);
				if (FirmwareUtilities.cpoahSiso(str, str2, text, ref text2))
				{
					Interaction.MsgBox("The file you want to flash is crypted, cannot continue", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				bool flag = default(bool);
				flag2 = FirmwareUtilities.smethod_5(str, str2, text, flag, ref text2);
				if (!FirmwareUtilities.smethod_6(text, ref flag3, ref uint_))
				{
					FirmwareUtilities.smethod_7(text, 0u);
				}
				hitminilog("Retrieving File from Drive");
				if (!method_11())
				{
					Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				if (!method_48(Conversions.ToInteger(Interaction.IIf(chkTurbo.Checked, 1, 0))))
				{
					return;
				}
				ToolboxUtilities.smethod_22(1);
				array[0] = 64;
				array[1] = 85;
				array[2] = 113;
				array[3] = 64;
				try
				{
					SerialPort1.Write(array, 0, 4);
				}
				catch (TimeoutException projectError)
				{
					ProjectData.SetProjectError(projectError);
					Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
					ProjectData.ClearProjectError();
					return;
				}
				if (!ReadUSARTw_to(ref buf, 1))
				{
					Interaction.MsgBox("Make sure a drive is attached to Lizard and it is in MODEB", MsgBoxStyle.Information, "Error:");
					return;
				}
				if (buf[0] != 6)
				{
					Interaction.MsgBox("Make sure drive is attached to Lizard and it is in MODEB [Response:" + Conversion.Hex(buf[0]) + "]", MsgBoxStyle.Information, "Error:");
					return;
				}
				if (!method_49())
				{
					return;
				}
				byte[] buf2 = new byte[1025];
				object obj = Application.StartupPath + "\\autodump.bin";
				FileStream fileStream = new FileStream(Conversions.ToString(obj), FileMode.Create);
				Enabled = false;
				ProgressBar1.Maximum = 255;
				ProgressBar1.Value = 0;
				ProgressBar1.Visible = true;
				lblAction.Text = "Reading from Drive";
				int num2 = 255;
				for (int i = 0; i <= num2; i++)
				{
					if (i == 0)
					{
						send_STX();
					}
					if (liz_GETPAGE(1024, ref buf2) == 0)
					{
						ProgressBar1.Value = i;
						fileStream.Write(buf2, 0, 1024);
						Application.DoEvents();
						continue;
					}
					lblAction.Text = "Idle";
					ProgressBar1.Visible = false;
					Interaction.MsgBox("Error occurred at address " + Conversion.Hex(i * 1024), MsgBoxStyle.Exclamation, "Error:");
					fileStream.Close();
					Enabled = true;
					return;
				}
				fileStream.Close();
				lblAction.Text = "Idle";
				Enabled = true;
				ProgressBar1.Visible = false;
				hitminilog("Parsing Drive File");
				text3 = Conversions.ToString(obj);
				text2 = "";
				str4 = FirmwareUtilities.smethod_3(text3, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				if (Operators.CompareString(Strings.Trim(str4), "HITACHI", false) != 0)
				{
					Interaction.MsgBox("The file read from the drive is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				str5 = FirmwareUtilities.smethod_4(str4, text3, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				if (Operators.CompareString(Strings.Trim(str5), "GDR3120L", false) != 0)
				{
					Interaction.MsgBox("The file read from the drive is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				text4 = FirmwareUtilities.smethod_9(str4, str5, text3, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				left = FirmwareUtilities.smethod_15(str4, str5, text4, text3, ref text2, ref num3);
				if (flag = FirmwareUtilities.cpoahSiso(str4, str5, text3, ref text2))
				{
					Interaction.MsgBox("The file read from the drive is crypted, cannot continue", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				flag4 = FirmwareUtilities.smethod_5(str4, str5, text3, flag, ref text2);
			}
			else
			{
				int i;
				if (!bForceRestore)
				{
					hitminilog("Retrieving File from Drive");
					if (!method_11())
					{
						Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
						return;
					}
					if (!method_48(Conversions.ToInteger(Interaction.IIf(chkTurbo.Checked, 1, 0))))
					{
						return;
					}
					ToolboxUtilities.smethod_22(1);
					array[0] = 64;
					array[1] = 85;
					array[2] = 113;
					array[3] = 64;
					try
					{
						SerialPort1.Write(array, 0, 4);
					}
					catch (TimeoutException projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
						ProjectData.ClearProjectError();
						return;
					}
					if (!ReadUSARTw_to(ref buf, 1))
					{
						Interaction.MsgBox("Make sure a drive is attached to Lizard and it is in MODEB", MsgBoxStyle.Information, "Error:");
						return;
					}
					if (buf[0] != 6)
					{
						Interaction.MsgBox("Make sure drive is attached to Lizard and it is in MODEB [Response:" + Conversion.Hex(buf[0]) + "]", MsgBoxStyle.Information, "Error:");
						return;
					}
					if (!method_49())
					{
						return;
					}
					byte[] buf3 = new byte[1025];
					string text5 = Application.StartupPath + "\\autodump.bin";
					FileStream fileStream2 = new FileStream(text5, FileMode.Create);
					Enabled = false;
					ProgressBar1.Maximum = 255;
					ProgressBar1.Value = 0;
					ProgressBar1.Visible = true;
					lblAction.Text = "Reading from Drive";
					int num4 = 255;
					for (i = 0; i <= num4; i++)
					{
						if (i == 0)
						{
							send_STX();
						}
						if (liz_GETPAGE(1024, ref buf3) == 0)
						{
							ProgressBar1.Value = i;
							fileStream2.Write(buf3, 0, 1024);
							Application.DoEvents();
							continue;
						}
						lblAction.Text = "Idle";
						ProgressBar1.Visible = false;
						Interaction.MsgBox("Error occurred at address " + Conversion.Hex(i * 1024), MsgBoxStyle.Exclamation, "Error:");
						Enabled = true;
						fileStream2.Close();
						return;
					}
					fileStream2.Close();
					lblAction.Text = "Idle";
					ProgressBar1.Visible = false;
					Enabled = true;
					text3 = text5;
				}
				else
				{
					text3 = sFileBaseForRestore;
				}
				hitminilog("Parsing Drive File");
				string text2 = "";
				str4 = FirmwareUtilities.smethod_3(text3, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				if (Operators.CompareString(Strings.Trim(str4), "HITACHI", false) != 0)
				{
					Interaction.MsgBox("The file read from the drive is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				str5 = FirmwareUtilities.smethod_4(str4, text3, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				if (Operators.CompareString(Strings.Trim(str5), "GDR3120L", false) != 0)
				{
					Interaction.MsgBox("The file read from the drive is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				text4 = FirmwareUtilities.smethod_9(str4, str5, text3, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				left = FirmwareUtilities.smethod_15(str4, str5, text4, text3, ref text2, ref num3);
				bool flag;
				if (flag = FirmwareUtilities.cpoahSiso(str4, str5, text3, ref text2))
				{
					Interaction.MsgBox("The file read from the drive is crypted, cannot continue", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				flag4 = FirmwareUtilities.smethod_5(str4, str5, text3, flag, ref text2);
				hitminilog("Extracting Original from Fileset");
				string text6 = Application.StartupPath + "\\CFW_Templates\\Original_Fileset.set";
				if (Operators.CompareString(FileSystem.Dir(text6), "", false) == 0)
				{
					Interaction.MsgBox("Cannot Find the File " + text6 + " Please download the Filesets", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				CfwTemplateParser.Struct4[] array2 = default(CfwTemplateParser.Struct4[]);
				int num5 = default(int);
				CfwTemplateParser.smethod_1(text6, ref array2, ref num5);
				if (num5 == 0)
				{
					Interaction.MsgBox("No TOC Entries found on the Fileset " + text6, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				string text7 = Strings.Trim(str4) + "-" + Strings.Trim(str5) + "-" + Strings.Trim(text4);
				bool flag5 = false;
				int num6 = num5 - 1;
				for (i = 0; i <= num6; i++)
				{
					string right2 = Strings.Trim(array2[i].string_3) + "-" + Strings.Trim(array2[i].string_4) + "-" + Strings.Trim(array2[i].string_5);
					if (Operators.CompareString(text7, right2, false) == 0)
					{
						flag5 = true;
						break;
					}
				}
				if (!flag5)
				{
					Interaction.MsgBox("No TOC Entries found to generate a " + text7 + " firmware on the Originals Fileset (" + text6 + ")\r\nTry to get updated Fileset", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				string text8 = Application.StartupPath + "\\ori.bin";
				if (!ToolboxUtilities.smethod_8(text6, text8, 33792L + array2[i].long_1, array2[i].long_0))
				{
					Interaction.MsgBox("The temporary file cannot be created, check the application is on folder with write privileges\r\nIf problem persist make sure you use latest Fileset Templates", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				hitminilog("Parsing Original File");
				text = text8;
				text2 = "";
				str = FirmwareUtilities.smethod_3(text, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				if (Operators.CompareString(Strings.Trim(str), "HITACHI", false) != 0)
				{
					Interaction.MsgBox("The file " + text + " is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				str2 = FirmwareUtilities.smethod_4(str, text, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				if (Operators.CompareString(Strings.Trim(str2), "GDR3120L", false) != 0)
				{
					Interaction.MsgBox("The file " + text + " is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				str3 = FirmwareUtilities.smethod_9(str, str2, text, ref text2);
				if (Operators.CompareString(text2, "", false) != 0)
				{
					Interaction.MsgBox("Error Ocurred: " + text2, MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				right = FirmwareUtilities.smethod_15(str, str2, str3, text, ref text2, ref num);
				if (FirmwareUtilities.cpoahSiso(str, str2, text, ref text2))
				{
					Interaction.MsgBox("The file you want to flash is crypted, cannot continue", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				flag2 = FirmwareUtilities.smethod_5(str, str2, text, flag, ref text2);
				if (!FirmwareUtilities.smethod_6(text, ref flag3, ref uint_))
				{
					FirmwareUtilities.smethod_7(text, 0u);
				}
			}
			string left2 = Strings.Trim(str4) + "-" + Strings.Trim(str5) + "-" + Strings.Trim(text4);
			string right3 = Strings.Trim(str) + "-" + Strings.Trim(str2) + "-" + Strings.Trim(str3);
			if (Operators.CompareString(left2, right3, false) != 0)
			{
				Interaction.MsgBox("The File choosen seems to be different than the one in the drive\r\nThe Firmware on the Drive firmware is a : " + Strings.Trim(str4) + " " + text4 + "\r\nPlease Choose a compatible file", MsgBoxStyle.Exclamation, "Notice:");
				return;
			}
			int[] int_ = default(int[]);
			int int_2 = default(int);
			if (flag4 && flag2)
			{
				FirmwareUtilities.smethod_39(text3, text, ref int_, ref int_2);
				if (RadioButton1.Checked && int_2 == 1 && int_[0] == 16384)
				{
					int_2--;
				}
			}
			if (!flag4 && !flag2)
			{
				Interaction.MsgBox("You are trying to put a CFW over a drive that already has a CFW\r\nYou need to restore your drive to original first", MsgBoxStyle.Exclamation, "Notice:");
				return;
			}
			hitminilog("Analizying Differences");
			if (flag4 && !flag2)
			{
				FirmwareUtilities.smethod_39(text3, text, ref int_, ref int_2);
				if (int_[int_2 - 1] == 253952)
				{
					ToolboxUtilities.smethod_23(ref int_, int_2 - 1, 0);
				}
			}
			if (!flag4 && flag2)
			{
				FirmwareUtilities.smethod_39(text3, text, ref int_, ref int_2, true);
				if (int_[0] == 253952)
				{
					ToolboxUtilities.smethod_23(ref int_, 0, int_2 - 1);
				}
			}
			if (int_2 > 0)
			{
				int_ = (int[])Utils.CopyArray(int_, new int[int_2 + 1]);
				int_[int_2] = 258048;
				int_2++;
				ToolboxUtilities.smethod_23(ref int_, int_2 - 1, 0);
			}
			int num7 = int_2 - 1;
			for (int i = 0; i <= num7; i++)
			{
				if (int_[i] != 16384 || (!RadioButton1.Checked && Operators.CompareString(left, right, false) != 0 && Interaction.MsgBox("The KEY of the file you want to flash is different than the KEY on the Drive\r\nDo you want to keep the one on the Drive?", MsgBoxStyle.YesNo | MsgBoxStyle.Question) != MsgBoxResult.Yes))
				{
					string item = Strings.Right("00" + Conversion.Hex(int_[i]), 5);
					lstSectors.Items.Add(item);
				}
			}
			if (lstSectors.Items.Count > 0)
			{
				Enabled = false;
				hitminilog("Sending Buffer to Lizard, Your drive is not being written yet");
				send_HitSectors2FlashBuffer(text);
				Enabled = true;
			}
			else
			{
				Interaction.MsgBox("No Differences Detected", MsgBoxStyle.Information, "Nothing to Flash:");
			}
		}

		private bool method_48(int int_15)
		{
			byte[] array = new byte[5];
			byte[] buf = new byte[5];
			array[0] = 64;
			array[1] = 85;
			if (int_15 == 0)
			{
				array[2] = 4;
			}
			else
			{
				array[2] = 5;
			}
			array[3] = 64;
			try
			{
				SerialPort1.Write(array, 0, 4);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			if (ReadUSARTw_to(ref buf, 1))
			{
				if (buf[0] == 21)
				{
					lblSpeedMode.ForeColor = Color.Black;
					lblSpeedMode.Text = "Burst Mode OFF";
					bool_3 = false;
					return true;
				}
				if (buf[0] != 6)
				{
					Interaction.MsgBox("Bad Response [Response:" + Conversion.Hex(buf[0]) + "]", MsgBoxStyle.Information, "Error:");
					return false;
				}
				if (int_15 == 1)
				{
					bool_3 = true;
				}
				else
				{
					bool_3 = false;
				}
				tbmode_refreshlabel();
				return true;
			}
			Interaction.MsgBox("Device not Responding, make sure you choose the proper COM port", MsgBoxStyle.Information, "Error:");
			return false;
		}

		public void tbmode_refreshlabel()
		{
			if (bool_3)
			{
				lblSpeedMode.ForeColor = Color.Green;
				lblSpeedMode.Text = "Burst Mode ON";
			}
			else
			{
				lblSpeedMode.ForeColor = Color.Black;
				lblSpeedMode.Text = "Burst Mode OFF";
			}
		}

		private bool method_49()
		{
			if (bool_3)
			{
				PortClose();
				SerialPort1.BaudRate = 1000000;
				if (!method_11())
				{
					Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
					return false;
				}
			}
			return true;
		}

		private void Button_0_Click(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "FW files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				txbFile2Flash.Text = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
			}
		}

		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioButton1.Checked)
			{
				txbFile2Flash.Enabled = false;
				Button_0.Enabled = false;
			}
			else
			{
				txbFile2Flash.Enabled = true;
				Button_0.Enabled = true;
			}
			lstSectors.Items.Clear();
		}

		private void Button14_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			byte[] buf = new byte[51];
			if (lstSectors.Items.Count == 0)
			{
				Interaction.MsgBox("Please Choose an Action and Analyze Changes First", MsgBoxStyle.Information, "Nothing to Do");
			}
			else
			{
				if (Interaction.MsgBox("This will Write your Drive\r\nAre you sure to continue?", MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo) != MsgBoxResult.Yes)
				{
					return;
				}
				int_1 = 115200;
				PortClose();
				SerialPort1.PortName = ToolStripStatusLabel_0.Text;
				SerialPort1.BaudRate = int_1;
				if (!method_11())
				{
					Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				array[0] = 64;
				array[1] = 85;
				array[2] = 114;
				array[3] = 64;
				try
				{
					SerialPort1.Write(array, 0, 4);
				}
				catch (TimeoutException projectError)
				{
					ProjectData.SetProjectError(projectError);
					Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
					ProjectData.ClearProjectError();
					return;
				}
				Enabled = false;
				if (ReadUSARTw_to(ref buf, 1))
				{
					if (buf[0] != 6)
					{
						Interaction.MsgBox("Make sure drive is attached to Lizard and it is in MODEB", MsgBoxStyle.Information, "Error:");
						Enabled = true;
					}
					else
					{
						Enabled = true;
						lstSectors.Items.Clear();
						hitminilog("Write Command Sent Wait for Completion in Lizard!");
					}
				}
				else
				{
					Interaction.MsgBox("Make sure a drive is attached to Lizard and it is in MODEB", MsgBoxStyle.Information, "Error:");
					Enabled = true;
				}
			}
		}

		public void hitminilog(string sMsg, bool bClear = false)
		{
			if (bClear)
			{
				TxbLog.Text = "";
			}
			Application.DoEvents();
			if (Operators.CompareString(sMsg, "", false) != 0)
			{
				TxbLog.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(TxbLog.Text, Interaction.IIf(Operators.CompareString(TxbLog.Text, "", false) == 0, "", "\r\n")), sMsg));
				TxbLog.SelectionStart = TxbLog.TextLength - 1;
				TxbLog.SelectionLength = 0;
				TxbLog.ScrollToCaret();
				Application.DoEvents();
			}
		}

		private void BtnHitRead_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			byte[] buf = new byte[51];
			SaveFileDialog1.CreatePrompt = false;
			SaveFileDialog1.OverwritePrompt = true;
			SaveFileDialog1.FileName = "source";
			SaveFileDialog1.DefaultExt = "bin";
			SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
			DialogResult dialogResult = SaveFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			txbhitread.Text = SaveFileDialog1.FileName;
			string fileName = SaveFileDialog1.FileName;
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			hitminilog("Retrieving File from Drive", true);
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
			}
			else
			{
				if (!method_48(Conversions.ToInteger(Interaction.IIf(chkTurbo.Checked, 1, 0))))
				{
					return;
				}
				ToolboxUtilities.smethod_22(1);
				array[0] = 64;
				array[1] = 85;
				array[2] = 113;
				array[3] = 64;
				try
				{
					SerialPort1.Write(array, 0, 4);
				}
				catch (TimeoutException projectError)
				{
					ProjectData.SetProjectError(projectError);
					Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
					ProjectData.ClearProjectError();
					return;
				}
				Enabled = false;
				if (ReadUSARTw_to(ref buf, 1))
				{
					if (buf[0] != 6)
					{
						Interaction.MsgBox("Make sure drive is attached to Lizard and it is in MODEB [Response:" + Conversion.Hex(buf[0]) + "]", MsgBoxStyle.Information, "Error:");
						Enabled = true;
					}
					else
					{
						if (!method_49())
						{
							return;
						}
						byte[] buf2 = new byte[1025];
						object obj = fileName;
						FileStream fileStream = new FileStream(Conversions.ToString(obj), FileMode.Create);
						ProgressBar1.Maximum = 255;
						ProgressBar1.Value = 0;
						ProgressBar1.Visible = true;
						lblAction.Text = "Reading from Drive";
						int num = 255;
						int num2 = 0;
						long num3 = default(long);
						while (true)
						{
							if (num2 <= num)
							{
								if (num2 == 0)
								{
									send_STX();
								}
								if (liz_GETPAGE(1024, ref buf2) != 0)
								{
									break;
								}
								ProgressBar1.Value = num2;
								fileStream.Write(buf2, 0, 1024);
								Application.DoEvents();
								num2++;
								continue;
							}
							fileStream.Close();
							lblAction.Text = "Idle";
							Enabled = true;
							ProgressBar1.Visible = false;
							hitminilog("Parsing Drive File");
							fileName = Conversions.ToString(obj);
							string text = "";
							string str = FirmwareUtilities.smethod_3(fileName, ref text);
							if (Operators.CompareString(text, "", false) != 0)
							{
								Interaction.MsgBox("Error Ocurred: " + text, MsgBoxStyle.Exclamation, "Error:");
								return;
							}
							if (Operators.CompareString(Strings.Trim(str), "HITACHI", false) != 0)
							{
								Interaction.MsgBox("The file read from the drive is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
								return;
							}
							string str2 = FirmwareUtilities.smethod_4(str, fileName, ref text);
							if (Operators.CompareString(text, "", false) != 0)
							{
								Interaction.MsgBox("Error Ocurred: " + text, MsgBoxStyle.Exclamation, "Error:");
								return;
							}
							if (Operators.CompareString(Strings.Trim(str2), "GDR3120L", false) != 0)
							{
								Interaction.MsgBox("The file read from the drive is not a Hitachi Fw File", MsgBoxStyle.Exclamation, "Error:");
								return;
							}
							string text2 = FirmwareUtilities.smethod_9(str, str2, fileName, ref text);
							if (Operators.CompareString(text, "", false) != 0)
							{
								Interaction.MsgBox("Error Ocurred: " + text, MsgBoxStyle.Exclamation, "Error:");
								return;
							}
							FirmwareUtilities.smethod_15(str, str2, text2, fileName, ref text, ref num3);
							bool flag;
							if (flag = FirmwareUtilities.cpoahSiso(str, str2, fileName, ref text))
							{
								Interaction.MsgBox("The file read from the drive is crypted, cannot continue", MsgBoxStyle.Exclamation, "Error:");
							}
							else if (!FirmwareUtilities.smethod_5(str, str2, fileName, flag, ref text) && Interaction.MsgBox("The Drive's Firmware is not STOCK, before you flash a custom firmware IS MANDATORY you restore the firmware to Stock\r\nDo you want to Restore it Now?", MsgBoxStyle.YesNo | MsgBoxStyle.Question) != MsgBoxResult.No)
							{
								Hit_Analyze_Changes(true, fileName);
							}
							return;
						}
						lblAction.Text = "Idle";
						ProgressBar1.Visible = false;
						Interaction.MsgBox("Error occurred at address " + Conversion.Hex(num2 * 1024), MsgBoxStyle.Exclamation, "Error:");
						fileStream.Close();
						Enabled = true;
					}
				}
				else
				{
					Interaction.MsgBox("Make sure a drive is attached to Lizard and it is in MODEB", MsgBoxStyle.Information, "Error:");
					Enabled = true;
				}
			}
		}

		private void Button20_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[1025];
			byte[] array2 = new byte[1025];
			OpenFileDialog1.Filter = "SNP files (*.snp)|*.snp|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			string fileName = OpenFileDialog1.FileName;
			OpenFileDialog1.InitialDirectory = "";
			string text = Strings.Replace(fileName, ".snp", "_dummy.bin");
			array = FirmwareUtilities.smethod_35(fileName, 0L, 1024);
			int num = array[0];
			string text2 = Strings.Mid(fileName, 1, Strings.InStrRev(fileName, "\\", -1, CompareMethod.Text));
			long num2 = 1024L;
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			int num3 = num - 1;
			for (int i = 0; i <= num3; i++)
			{
				string text3 = method_17(ref array, i);
				long num4 = method_18(ref array, i);
				bool flag = method_19(ref array, i);
				int num5 = (int)(num4 / 1024L + 1L);
				if (flag && (num2 & 0x3FFL) > 0L)
				{
					num2 = (num2 + 1024L) & 0xFC00L;
				}
				long num6 = num2;
				fileStream.Seek(num6, SeekOrigin.Begin);
				FileStream fileStream2 = new FileStream(text2 + text3, FileMode.Create);
				int num7 = num5 - 1;
				for (int j = 0; j <= num7; j++)
				{
					int count = (int)((j != num5 - 1) ? 1024 : (num4 & 0x3FFL));
					fileStream.Read(array2, 0, count);
					fileStream2.Write(array2, 0, count);
				}
				fileStream2.Close();
				num2 = num6 + num4;
			}
			fileStream.Close();
			DateTime timeOfDay = DateAndTime.TimeOfDay;
			if (!method_16(fileName, text))
			{
				Interaction.MsgBox("Problem Generating " + text + " file", MsgBoxStyle.Exclamation, "Error:");
			}
			else
			{
				DateTime date = default(DateTime);
				Interaction.MsgBox("The File " + text + " has been Created\r\nTotal Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, date, timeOfDay)) + " secs", MsgBoxStyle.Information, "Read Complete:");
			}
			ProgressBar1.Value = 0;
			ProgressBar1.Visible = false;
			lblAction.Text = "Idle";
			Enabled = true;
			SerialPort1.Close();
		}

		private void Button21_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[13];
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			ProgressBar1.Maximum = 15;
			ProgressBar1.Value = 0;
			ProgressBar1.Visible = true;
			lblAction.Text = "Reading";
			Enabled = false;
			TreeView1.Nodes.Clear();
			byte[] buf = new byte[1025];
			int num = 15;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (SPIF_READPAGE(786432 + num2 * 8192, 1024, ref buf, Conversions.ToBoolean(Interaction.IIf(num2 == 0, false, true)), true) == 0)
					{
						ProgressBar1.Value = num2;
						struct5_0[num2].int_0 = buf[1];
						struct5_0[num2].int_1 = buf[2];
						struct5_0[num2].bool_0 = Conversions.ToBoolean(Interaction.IIf(buf[0] == byte.MaxValue, false, true));
						struct5_0[num2].byte_0 = buf[0];
						ToolboxUtilities.smethod_19(ref array, 0, 13, 0);
						ToolboxUtilities.smethod_13(ref buf, 3, 12, ref array, 0);
						struct5_0[num2].string_0 = ToolboxUtilities.smethod_18(ref array);
						struct5_0[num2].cpoahSiso = new byte[16];
						struct5_0[num2].byte_1 = new byte[96];
						struct5_0[num2].byte_2 = new byte[96];
						struct5_0[num2].byte_3 = new byte[512];
						struct5_0[num2].byte_4 = new byte[320];
						struct5_0[num2].byte_5 = new byte[16];
						struct5_0[num2].byte_6 = new byte[32];
						ToolboxUtilities.smethod_13(ref buf, 35, 16, ref struct5_0[num2].cpoahSiso, 0);
						ToolboxUtilities.smethod_13(ref buf, 64, 96, ref struct5_0[num2].byte_1, 0);
						ToolboxUtilities.smethod_13(ref buf, 256, 96, ref struct5_0[num2].byte_2, 0);
						ToolboxUtilities.smethod_13(ref buf, 512, 512, ref struct5_0[num2].byte_3, 0);
						if (SPIF_READPAGE(786432 + num2 * 8192 + 1024, 1024, ref buf, true, true) == 0)
						{
							ToolboxUtilities.smethod_13(ref buf, 0, 320, ref struct5_0[num2].byte_4, 0);
							ToolboxUtilities.smethod_13(ref buf, 512, 16, ref struct5_0[num2].byte_5, 0);
							ToolboxUtilities.smethod_13(ref buf, 768, 32, ref struct5_0[num2].byte_6, 0);
							Application.DoEvents();
							num2++;
							continue;
						}
						Interaction.MsgBox("Cannot retrieve Lizard Details, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
						break;
					}
					Interaction.MsgBox("Cannot retrieve Lizard Details, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
					break;
				}
				ms_refresh_tree();
				break;
			}
			ProgressBar1.Value = 0;
			ProgressBar1.Visible = false;
			lblAction.Text = "Idle";
			Enabled = true;
			PortClose();
		}

		private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			ms_filldet(TreeView1.SelectedNode.Index);
		}

		public void ms_filldet(int iNode)
		{
			byte[] array = new byte[224];
			if (struct5_0[iNode].bool_0)
			{
				mslbl_status.Text = "FULL";
				mslbl_jobname.Text = struct5_0[iNode].string_0;
				mstxb_key.Text = ToolboxUtilities.smethod_5(ref struct5_0[iNode].cpoahSiso);
				string text = ToolboxUtilities.smethod_1(ref struct5_0[iNode].byte_1) + ToolboxUtilities.smethod_1(ref struct5_0[iNode].byte_2);
				string text2 = "";
				string str = FirmwareUtilities.smethod_21(text, ref text2);
				text2 = "";
				string str2 = FirmwareUtilities.smethod_22(text, str, ref text2);
				text2 = "";
				string str3 = FirmwareUtilities.smethod_24(text, str, str2, ref text2);
				ToolboxUtilities.smethod_19(ref array, 0, array.Length, 0);
				if (Operators.CompareString(Strings.Trim(str2), "DG16D2S", false) == 0)
				{
					ToolboxUtilities.smethod_13(ref struct5_0[iNode].byte_4, 0, array.Length, ref array, 0);
				}
				if (Operators.CompareString(Strings.Trim(str2), "DG16D4S", false) == 0)
				{
					array = dg16d4s_fix_serial(struct5_0[iNode].byte_3, struct5_0[iNode].byte_1, struct5_0[iNode].byte_4, struct5_0[iNode].byte_5);
				}
				txbsync_ide.Text = ToolboxUtilities.smethod_24(ref struct5_0[iNode].byte_3, 0, struct5_0[iNode].byte_3.Length);
				txbsync_inq.Text = ToolboxUtilities.smethod_24(ref struct5_0[iNode].byte_1, 0, struct5_0[iNode].byte_1.Length);
				txbsync_ser.Text = ToolboxUtilities.smethod_24(ref array, 0, Conversions.ToInteger(Interaction.IIf(Operators.CompareString(Strings.Trim(str2), "DG16D4S", false) == 0, array.Length, 95)));
				mslbl_logdrive.Text = Strings.Trim(str) + "-" + Strings.Trim(str2) + "-" + Strings.Trim(str3);
				btn_mserase.Enabled = true;
				btn_mssave.Enabled = true;
				btn_msload.Enabled = true;
			}
			else
			{
				mslbl_status.Text = "-";
				mslbl_jobname.Text = "-";
				mslbl_logdrive.Text = "-";
				mstxb_key.Text = "";
				txbsync_ser.Text = "";
				txbsync_ide.Text = "";
				txbsync_inq.Text = "";
				btn_mserase.Enabled = false;
				btn_mssave.Enabled = false;
				btn_msload.Enabled = true;
			}
		}

		public byte[] dg16d4s_fix_serial(byte[] bIDE, byte[] bINQ, byte[] bSubSer, byte[] bFWHash)
		{
			byte[] array = new byte[224];
			byte[] array2 = new byte[20];
			byte[] array3 = new byte[16];
			byte[] array4 = ToolboxUtilities.cpoahSiso("FFFFFFFFFFFFFFFFFF");
			array3 = ((!ToolboxUtilities.smethod_16(ref bFWHash, 0, 16, ref array4, 0)) ? bFWHash : ToolboxUtilities.cpoahSiso("01000000BB01"));
			ToolboxUtilities.smethod_19(ref array, 0, array.Length, byte.MaxValue);
			ToolboxUtilities.smethod_13(ref bIDE, 20, 20, ref array2, 0);
			array4 = ToolboxUtilities.smethod_12(array2, 0, array2.Length);
			ToolboxUtilities.smethod_13(ref array4, 0, 20, ref array, 0);
			ToolboxUtilities.smethod_13(ref array3, 1, 3, ref array, 17);
			ToolboxUtilities.smethod_13(ref bSubSer, 96, 16, ref array, 24);
			ToolboxUtilities.smethod_13(ref bSubSer, 112, 4, ref array, 40);
			ToolboxUtilities.smethod_13(ref bSubSer, 116, 32, ref array, 44);
			ToolboxUtilities.smethod_13(ref bSubSer, 148, 4, ref array, 76);
			ToolboxUtilities.smethod_13(ref bSubSer, 152, 32, ref array, 80);
			ToolboxUtilities.smethod_13(ref bSubSer, 184, 96, ref array, 128);
			return array;
		}

		private void GroupBox7_Enter(object sender, EventArgs e)
		{
		}

		private void btn_mserase_Click(object sender, EventArgs e)
		{
			int index = TreeView1.SelectedNode.Index;
			slot_erase(index, false);
		}

		public bool slot_erase(int iNode, bool bAutoMode)
		{
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return false;
			}
			if (SPIF_BSERASE(786432 + iNode * 8192, 4) != 0)
			{
				Interaction.MsgBox("Cannot Erase, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
			}
			else
			{
				if (SPIF_BSERASE(786432 + iNode * 8192 + 4096, 4, true) == 0)
				{
					send_ETX();
					struct5_0[iNode].bool_0 = false;
					struct5_0[iNode].byte_0 = byte.MaxValue;
					ms_filldet(iNode);
					ms_refresh_tree();
					PortClose();
					return true;
				}
				Interaction.MsgBox("Cannot Erase, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
			}
			return false;
		}

		public void ms_refresh_tree()
		{
			TreeView1.Nodes.Clear();
			TreeView1.ImageList = ImageList1;
			int num = 0;
			do
			{
				string key = num.ToString();
				string text = Conversions.ToString(Interaction.IIf(struct5_0[num].bool_0, struct5_0[num].string_0, "(Empty)"));
				int num2 = (struct5_0[num].bool_0 ? ((struct5_0[num].byte_0 != 5) ? 3 : 2) : 0);
				TreeView1.Nodes.Add(key, text, num2, num2);
				num++;
			}
			while (num <= 15);
		}

		private void btn_mssave_Click(object sender, EventArgs e)
		{
			int index = TreeView1.SelectedNode.Index;
			if (!struct5_0[index].bool_0)
			{
				Interaction.MsgBox("Empty Slot", MsgBoxStyle.Information, "Not Allowed");
			}
			else if (struct5_0[index].byte_0 == 5)
			{
				Interaction.MsgBox("Uploaded slots cannot be read back", MsgBoxStyle.Information, "Not Allowed");
			}
			else
			{
				slot_backup_to_pc(index, false);
			}
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public bool slot_backup_to_pc(int iNode, bool bAutoMode)
		{
			byte[] array = new byte[320];
			byte[] array2 = new byte[4096];
			byte[] buf = new byte[1024];
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return false;
			}
			string text = ToolboxUtilities.smethod_1(ref struct5_0[iNode].byte_1) + ToolboxUtilities.smethod_1(ref struct5_0[iNode].byte_2);
			string text2 = "";
			string text3 = FirmwareUtilities.smethod_21(text, ref text2);
			text2 = "";
			string str = FirmwareUtilities.smethod_22(text, text3, ref text2);
			text2 = "";
			FirmwareUtilities.smethod_24(text, text3, str, ref text2);
			if (Operators.CompareString(Strings.Trim(str), "DG16D2S", false) == 0)
			{
				if (SPIF_READPAGE(786432 + iNode * 8192 + 1024, 1024, ref buf) != 0)
				{
					Interaction.MsgBox("Cannot retrieve Lizard Data, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
					goto IL_0745;
				}
				send_ETX();
				ToolboxUtilities.smethod_13(ref buf, 0, 320, ref array, 0);
			}
			if (Operators.CompareString(Strings.Trim(str), "DG16D4S", false) != 0)
			{
				goto IL_03b7;
			}
			ref byte[] reference = ref struct5_0[iNode].byte_5;
			byte[] array3 = ToolboxUtilities.cpoahSiso("FFFFFFFFFFFFFFFFFF");
			if (ToolboxUtilities.smethod_16(ref reference, 0, 16, ref array3, 0))
			{
				if (struct5_0[iNode].int_0 != 65)
				{
					Interaction.MsgBox("The Slot labeled " + struct5_0[iNode].string_0 + " needs to be re-dumped, cannot save it", MsgBoxStyle.Information, "Error");
					goto IL_0745;
				}
				struct5_0[iNode].byte_5 = ToolboxUtilities.cpoahSiso("01000000BB01");
			}
			if (SPIF_READPAGE(786432 + iNode * 8192 + 1024, 1024, ref buf) != 0)
			{
				Interaction.MsgBox("Cannot retrieve Lizard Data, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
			}
			else
			{
				ToolboxUtilities.smethod_13(ref buf, 0, 320, ref array, 0);
				if (SPIF_READPAGE(786432 + iNode * 8192 + 4096, 1024, ref buf, true, true) != 0)
				{
					Interaction.MsgBox("Cannot retrieve Lizard Data, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
				}
				else
				{
					ToolboxUtilities.smethod_13(ref buf, 0, 1024, ref array2, 0);
					if (SPIF_READPAGE(786432 + iNode * 8192 + 4096 + 1024, 1024, ref buf, true, true) != 0)
					{
						Interaction.MsgBox("Cannot retrieve Lizard Data, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
					}
					else
					{
						ToolboxUtilities.smethod_13(ref buf, 0, 1024, ref array2, 1024);
						if (SPIF_READPAGE(786432 + iNode * 8192 + 4096 + 2048, 1024, ref buf, true, true) != 0)
						{
							Interaction.MsgBox("Cannot retrieve Lizard Data, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
						}
						else
						{
							ToolboxUtilities.smethod_13(ref buf, 0, 1024, ref array2, 2048);
							if (SPIF_READPAGE(786432 + iNode * 8192 + 4096 + 3072, 1024, ref buf, true, true) == 0)
							{
								send_ETX();
								ToolboxUtilities.smethod_13(ref buf, 0, 1024, ref array2, 3072);
								goto IL_03b7;
							}
							Interaction.MsgBox("Cannot retrieve Lizard Data, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
						}
					}
				}
			}
			goto IL_0745;
			IL_047c:
			if (Operators.CompareString(FileSystem.Dir(FolderBrowserDialog1.SelectedPath, FileAttribute.Directory), "", false) == 0)
			{
				FileSystem.MkDir(FolderBrowserDialog1.SelectedPath);
			}
			if (clear_folder(FolderBrowserDialog1.SelectedPath))
			{
				string path;
				try
				{
					path = FolderBrowserDialog1.SelectedPath + "\\INQUIRY.bin";
					FileStream fileStream = new FileStream(path, FileMode.Create);
					fileStream.Write(struct5_0[iNode].byte_1, 0, 96);
					fileStream.Close();
					path = FolderBrowserDialog1.SelectedPath + "\\SECINQ.bin";
					fileStream = new FileStream(path, FileMode.Create);
					fileStream.Write(struct5_0[iNode].byte_2, 0, 96);
					fileStream.Close();
					path = FolderBrowserDialog1.SelectedPath + "\\IDENTIFY.bin";
					fileStream = new FileStream(path, FileMode.Create);
					fileStream.Write(struct5_0[iNode].byte_3, 0, 512);
					fileStream.Close();
					path = FolderBrowserDialog1.SelectedPath + "\\KEY.bin";
					fileStream = new FileStream(path, FileMode.Create);
					fileStream.Write(struct5_0[iNode].cpoahSiso, 0, 16);
					fileStream.Close();
					if (Operators.CompareString(Strings.Trim(str), "DG16D2S", false) == 0)
					{
						path = FolderBrowserDialog1.SelectedPath + "\\serial.bin";
						fileStream = new FileStream(path, FileMode.Create);
						fileStream.Write(array, 0, 80);
						fileStream.Close();
					}
					if (Operators.CompareString(Strings.Trim(str), "DG16D4S", false) == 0)
					{
						path = FolderBrowserDialog1.SelectedPath + "\\SUBSER.bin";
						fileStream = new FileStream(path, FileMode.Create);
						fileStream.Write(array, 0, 320);
						fileStream.Close();
						path = FolderBrowserDialog1.SelectedPath + "\\KEYAREA.bin";
						fileStream = new FileStream(path, FileMode.Create);
						fileStream.Write(array2, 0, 4096);
						fileStream.Close();
						path = FolderBrowserDialog1.SelectedPath + "\\FWH.bin";
						fileStream = new FileStream(path, FileMode.Create);
						fileStream.Write(struct5_0[iNode].byte_5, 0, 16);
						fileStream.Close();
						path = FolderBrowserDialog1.SelectedPath + "\\RTC.bin";
						fileStream = new FileStream(path, FileMode.Create);
						fileStream.Write(struct5_0[iNode].byte_6, 0, 32);
						fileStream.Close();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Interaction.MsgBox("Problem saving data to disc", MsgBoxStyle.Exclamation, "Error:");
					ProjectData.ClearProjectError();
					goto IL_0745;
				}
				path = FolderBrowserDialog1.SelectedPath + "\\source_dummy.snp";
				string text4 = FolderBrowserDialog1.SelectedPath + "\\source_dummy.bin";
				if (method_16(path, text4))
				{
					if (!bAutoMode)
					{
						Interaction.MsgBox("The File " + text4 + " has been generated", MsgBoxStyle.Information, "Success:");
					}
				}
				else if (!bAutoMode)
				{
					Interaction.MsgBox("Problem Generating " + text4 + " file", MsgBoxStyle.Exclamation, "Error:");
				}
				PortClose();
				return true;
			}
			goto IL_0745;
			IL_03b7:
			if (!bAutoMode)
			{
				FolderBrowserDialog1.ShowNewFolderButton = true;
				FolderBrowserDialog1.SelectedPath = sett_tbxjobspath.Text;
				DialogResult dialogResult = FolderBrowserDialog1.ShowDialog();
				if (dialogResult != DialogResult.OK)
				{
					goto IL_0745;
				}
			}
			else
			{
				FolderBrowserDialog1.SelectedPath = sett_tbxjobspath.Text + "\\" + struct5_0[iNode].string_0;
			}
			if (!bAutoMode)
			{
				if (chkfolder_overwrite(FolderBrowserDialog1.SelectedPath))
				{
					goto IL_047c;
				}
			}
			else if (chkfolder_overwrite(FolderBrowserDialog1.SelectedPath, "The folder for the Job " + struct5_0[iNode].string_0 + " already Exists\r\nDo you want Overwrite?", true))
			{
				goto IL_047c;
			}
			goto IL_0745;
			IL_0745:
			PortClose();
			return false;
		}

		public bool slot_backup_to_lizard(int iNode)
		{
			byte[] array = new byte[2048];
			byte[] buf = new byte[1025];
			OpenFileDialog1.Filter = "Layout files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string string_ = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
				string defaultResponse = ToolboxUtilities.smethod_21(ToolboxUtilities.smethod_20(string_, false));
				defaultResponse = Interaction.InputBox("Name:", "Enter a name for Slot (12 chars maximum):", defaultResponse);
				byte[] byte_ = new byte[97];
				byte[] byte_2 = new byte[97];
				byte[] byte_3 = new byte[181];
				byte[] byte_4 = new byte[81];
				byte[] byte_5 = new byte[16];
				byte[] byte_6 = new byte[4096];
				string string_2 = "";
				string string_3 = "";
				string string_4 = "";
				object obj = "";
				string string_5 = "";
				string string_6 = "";
				string string_7 = "";
				int int_ = -1;
				long long_ = default(long);
				long long_2 = default(long);
				int int_2 = default(int);
				long long_3 = default(long);
				int int_3 = default(int);
				long long_4 = default(long);
				int int_4 = default(int);
				long long_5 = default(long);
				int int_5 = default(int);
				long long_6 = default(long);
				long long_7 = default(long);
				byte[] byte_7 = default(byte[]);
				long long_8 = default(long);
				bool flag;
				if (FirmwareUtilities.smethod_8(string_))
				{
					string string_8 = Conversions.ToString(obj);
					bool num = method_30(ref string_, ref string_2, ref string_3, ref string_4, ref string_8, ref long_, ref string_5, ref string_6, ref string_7, ref long_2, ref byte_, ref int_2, ref long_3, ref byte_2, ref int_3, ref long_4, ref byte_3, ref int_4, ref long_5, ref byte_4, ref int_5, ref byte_5, ref long_6, ref byte_6, ref long_7, ref byte_7, ref long_8, ref int_);
					obj = string_8;
					flag = num;
					long num2 = -1L;
				}
				else
				{
					string string_8 = Conversions.ToString(obj);
					byte[] byte_8 = default(byte[]);
					long num2 = default(long);
					bool num3 = method_31(ref string_, ref string_2, ref string_3, ref string_4, ref string_8, ref long_, ref string_5, ref string_6, ref string_7, ref long_2, ref byte_, ref int_2, ref long_3, ref byte_2, ref int_3, ref long_4, ref byte_3, ref int_4, ref long_5, ref byte_4, ref int_5, ref byte_5, ref long_6, ref byte_6, ref long_7, ref byte_8, ref num2, ref byte_7, ref long_8);
					obj = string_8;
					flag = num3;
				}
				if (flag)
				{
					if (!FirmwareUtilities.smethod_46(string_2, string_3))
					{
						Interaction.MsgBox("Firmware for " + Strings.Trim(string_2) + "-" + Strings.Trim(string_3) + " are not allowed", MsgBoxStyle.Information, "Not allowed:");
					}
					else
					{
						string text = Strings.Trim(string_5) + "-" + Strings.Trim(string_6) + "-" + Strings.Trim(string_7);
						string left = Strings.Trim(string_2) + "-" + Strings.Trim(string_3) + "-" + Strings.Trim(string_4);
						if (Operators.CompareString(left, text, false) == 0 || Interaction.MsgBox("Spoofed firmwares not allowed, we will use the logical model to load the slot (" + text + ")\r\nIt is ok?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Spoofed firmware not allowed") == MsgBoxResult.Yes)
						{
							ToolboxUtilities.smethod_19(ref array, 0, 2048, byte.MaxValue);
							struct5_0[iNode].byte_0 = 5;
							struct5_0[iNode].int_0 = FirmwareUtilities.smethod_47(string_6, string_7);
							struct5_0[iNode].int_1 = struct5_0[iNode].int_0;
							if (struct5_0[iNode].int_0 != 255)
							{
								struct5_0[iNode].string_0 = defaultResponse;
								struct5_0[iNode].string_0 = Strings.Trim(Strings.Mid(struct5_0[iNode].string_0, 1, 12));
								struct5_0[iNode].cpoahSiso = new byte[16];
								struct5_0[iNode].cpoahSiso = ToolboxUtilities.cpoahSiso(Conversions.ToString(obj));
								struct5_0[iNode].byte_1 = new byte[96];
								ToolboxUtilities.smethod_13(ref byte_, 0, int_2, ref struct5_0[iNode].byte_1, 0);
								struct5_0[iNode].byte_2 = new byte[96];
								ToolboxUtilities.smethod_13(ref byte_2, 0, int_3, ref struct5_0[iNode].byte_2, 0);
								struct5_0[iNode].byte_3 = new byte[512];
								byte[] array2 = FirmwareUtilities.smethod_32(byte_3);
								ToolboxUtilities.smethod_13(ref array2, 0, int_4, ref struct5_0[iNode].byte_3, 0);
								byte[] array3 = new byte[20];
								ToolboxUtilities.smethod_13(ref byte_4, 0, 20, ref array3, 0);
								if (Operators.CompareString(Strings.Trim(string_6), "DG16D2S", false) == 0)
								{
									ToolboxUtilities.smethod_13(ref byte_4, 0, int_5, ref struct5_0[iNode].byte_4, 0);
									ToolboxUtilities.smethod_13(ref array3, 0, 20, ref struct5_0[iNode].byte_3, 20);
									ToolboxUtilities.smethod_13(ref byte_4, 40, 2, ref struct5_0[iNode].byte_1, 38);
									ToolboxUtilities.smethod_13(ref byte_4, 76, 2, ref struct5_0[iNode].byte_1, 40);
									ToolboxUtilities.smethod_13(ref byte_4, 0, 20, ref struct5_0[iNode].byte_1, 42);
								}
								if (Operators.CompareString(Strings.Trim(string_6), "DG16D4S", false) == 0)
								{
									byte[] array4 = new byte[320];
									ToolboxUtilities.smethod_19(ref array4, 0, 320, byte.MaxValue);
									ToolboxUtilities.smethod_13(ref byte_4, 24, 16, ref array4, 96);
									ToolboxUtilities.smethod_13(ref byte_4, 40, 4, ref array4, 112);
									ToolboxUtilities.smethod_13(ref byte_4, 44, 32, ref array4, 116);
									ToolboxUtilities.smethod_13(ref byte_4, 76, 4, ref array4, 148);
									ToolboxUtilities.smethod_13(ref byte_4, 80, 32, ref array4, 152);
									ToolboxUtilities.smethod_13(ref byte_4, 128, 96, ref array4, 184);
									struct5_0[iNode].byte_4 = new byte[320];
									ToolboxUtilities.smethod_13(ref array4, 0, 320, ref struct5_0[iNode].byte_4, 0);
									byte[] array5 = default(byte[]);
									byte[] array6 = default(byte[]);
									if (!FirmwareUtilities.smethod_45(string_2, string_3, string_4, string_, ref byte_7, ref array5, ref array6))
									{
										goto IL_0c22;
									}
									if (array5[0] == 2 && byte_4[24] == byte.MaxValue)
									{
										array5[1] = 32;
										array5[2] = 32;
										array5[3] = 32;
									}
									struct5_0[iNode].byte_5 = new byte[16];
									ToolboxUtilities.smethod_13(ref array5, 0, 4, ref struct5_0[iNode].byte_5, 0);
									ToolboxUtilities.smethod_13(ref byte_7, 0, (int)long_8, ref struct5_0[iNode].byte_5, 4);
									struct5_0[iNode].byte_6 = new byte[32];
									ToolboxUtilities.smethod_13(ref array6, 0, array6.Length, ref struct5_0[iNode].byte_6, 0);
									array2 = ToolboxUtilities.smethod_12(array3, 0, array3.Length);
									ToolboxUtilities.smethod_13(ref array2, 0, 20, ref struct5_0[iNode].byte_3, 20);
									ToolboxUtilities.smethod_13(ref byte_4, 40, 2, ref struct5_0[iNode].byte_1, 52);
									ToolboxUtilities.smethod_13(ref byte_4, 76, 2, ref struct5_0[iNode].byte_1, 54);
									ToolboxUtilities.smethod_13(ref struct5_0[iNode].byte_5, 0, 16, ref array, 1536);
									ToolboxUtilities.smethod_13(ref struct5_0[iNode].byte_6, 0, 32, ref array, 1792);
								}
								array[0] = struct5_0[iNode].byte_0;
								array[1] = (byte)struct5_0[iNode].int_0;
								array[2] = (byte)struct5_0[iNode].int_1;
								ToolboxUtilities.smethod_19(ref array, 3, 12, 0);
								byte[] array7 = new byte[12];
								array7 = (byte[])ToolboxUtilities.smethod_7(struct5_0[iNode].string_0);
								ToolboxUtilities.smethod_13(ref array7, 0, array7.Length, ref array, 3);
								array[15] = 0;
								ToolboxUtilities.smethod_13(ref struct5_0[iNode].cpoahSiso, 0, 16, ref array, 35);
								ToolboxUtilities.smethod_13(ref struct5_0[iNode].byte_1, 0, 96, ref array, 64);
								ToolboxUtilities.smethod_13(ref struct5_0[iNode].byte_2, 0, 96, ref array, 256);
								ToolboxUtilities.smethod_13(ref struct5_0[iNode].byte_4, 0, 320, ref array, 1024);
								ToolboxUtilities.smethod_13(ref struct5_0[iNode].byte_3, 0, 512, ref array, 512);
								int_1 = 115200;
								PortClose();
								SerialPort1.PortName = ToolStripStatusLabel_0.Text;
								SerialPort1.BaudRate = int_1;
								SerialPort1.WriteTimeout = 1000;
								SerialPort1.ReadTimeout = 5000;
								bool_1 = false;
								if (!method_11())
								{
									Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
									return false;
								}
								ToolboxUtilities.smethod_13(ref array, 0, 1024, ref buf, 0);
								if (SPIF_WRITEPAGE(786432 + iNode * 8192, 1024, ref buf) != 0)
								{
									Interaction.MsgBox("Error occurred at address " + Conversion.Hex(786432 + iNode * 8192), MsgBoxStyle.Exclamation, "Error:");
								}
								else
								{
									ToolboxUtilities.smethod_13(ref array, 1024, 1024, ref buf, 0);
									if (SPIF_WRITEPAGE(786432 + iNode * 8192 + 1024, 1024, ref buf, true) != 0)
									{
										Interaction.MsgBox("Error occurred at address " + Conversion.Hex(786432 + iNode * 8192), MsgBoxStyle.Exclamation, "Error:");
									}
									else
									{
										send_ETX();
										FtdiNativeMethods.Sleep(100);
										if (Operators.CompareString(Strings.Trim(string_6), "DG16D4S", false) != 0)
										{
											goto IL_0bfb;
										}
										if (SPIF_BSERASE(786432 + iNode * 8192 + 4096, 4) != 0)
										{
											Interaction.MsgBox("Error Block Erasing at " + Conversion.Hex(786432 + iNode * 8192), MsgBoxStyle.Exclamation, "Error:");
										}
										else
										{
											send_ETX();
											FtdiNativeMethods.Sleep(100);
											ToolboxUtilities.smethod_13(ref byte_6, 0, 1024, ref buf, 0);
											if (SPIF_WRITEPAGE(786432 + iNode * 8192 + 4096, 1024, ref buf) != 0)
											{
												Interaction.MsgBox("Error occurred at address " + Conversion.Hex(786432 + iNode * 8192), MsgBoxStyle.Exclamation, "Error:");
											}
											else
											{
												ToolboxUtilities.smethod_13(ref byte_6, 1024, 1024, ref buf, 0);
												if (SPIF_WRITEPAGE(786432 + iNode * 8192 + 4096 + 1024, 1024, ref buf, true) != 0)
												{
													Interaction.MsgBox("Error occurred at address " + Conversion.Hex(786432 + iNode * 8192), MsgBoxStyle.Exclamation, "Error:");
												}
												else
												{
													ToolboxUtilities.smethod_13(ref byte_6, 2048, 1024, ref buf, 0);
													if (SPIF_WRITEPAGE(786432 + iNode * 8192 + 4096 + 2048, 1024, ref buf, true) != 0)
													{
														Interaction.MsgBox("Error occurred at address " + Conversion.Hex(786432 + iNode * 8192), MsgBoxStyle.Exclamation, "Error:");
													}
													else
													{
														ToolboxUtilities.smethod_13(ref byte_6, 3072, 1024, ref buf, 0);
														if (SPIF_WRITEPAGE(786432 + iNode * 8192 + 4096 + 3072, 1024, ref buf, true) == 0)
														{
															send_ETX();
															goto IL_0bfb;
														}
														Interaction.MsgBox("Error occurred at address " + Conversion.Hex(786432 + iNode * 8192), MsgBoxStyle.Exclamation, "Error:");
													}
												}
											}
										}
									}
								}
								PortClose();
								return false;
							}
							Interaction.MsgBox("Unable to determine OSIG for this Model-Rom", MsgBoxStyle.Information, "Error");
						}
					}
				}
			}
			goto IL_0c22;
			IL_0c22:
			bool result = default(bool);
			return result;
			IL_0bfb:
			struct5_0[iNode].bool_0 = true;
			ms_filldet(iNode);
			ms_refresh_tree();
			PortClose();
			return true;
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public bool chkfolder_overwrite(string spath, string string_21 = "", bool bSkip2ndPrompt = false)
		{
			string prompt = ((Operators.CompareString(string_21, "", false) != 0) ? string_21 : "If you are reading a Dummy file, previous files on the folder will be overwritten\r\nIf you are reading a full Dump, existing Dummy files on the folder will be preserved\r\nDo you want to overwrite the current files on folder?");
			if ((Operators.CompareString(FileSystem.Dir(spath + "\\SOURCE.bin"), "", false) != 0) | (Operators.CompareString(FileSystem.Dir(spath + "\\INQUIRY.bin"), "", false) != 0) | (Operators.CompareString(FileSystem.Dir(spath + "\\SECINQ.bin"), "", false) != 0) | (Operators.CompareString(FileSystem.Dir(spath + "\\IDENTIFY.bin"), "", false) != 0) | (Operators.CompareString(FileSystem.Dir(spath + "\\KEY.bin"), "", false) != 0) | (Operators.CompareString(FileSystem.Dir(spath + "\\SUBSER.bin"), "", false) != 0) | (Operators.CompareString(FileSystem.Dir(spath + "\\FWH.bin"), "", false) != 0) | (Operators.CompareString(FileSystem.Dir(spath + "\\RTC.bin"), "", false) != 0) | (Operators.CompareString(FileSystem.Dir(spath + "\\KEYAREA.bin"), "", false) != 0))
			{
				if (Interaction.MsgBox(prompt, MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Warning:") != MsgBoxResult.Yes)
				{
					return false;
				}
				if (!bSkip2ndPrompt && Interaction.MsgBox("The data will never be recovered", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Really Sure?") != MsgBoxResult.Yes)
				{
					return false;
				}
				return true;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public bool chk_fulldumpoverwrite(string sfile, string string_21 = "", bool bSkip2ndPrompt = false)
		{
			string prompt = ((Operators.CompareString(string_21, "", false) != 0) ? string_21 : "Do you want to overwrite the current file on folder?");
			if (Operators.CompareString(FileSystem.Dir(sfile), "", false) != 0)
			{
				if (Interaction.MsgBox(prompt, MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Warning:") != MsgBoxResult.Yes)
				{
					return false;
				}
				if (!bSkip2ndPrompt && Interaction.MsgBox("The data will never be recovered", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Really Sure?") != MsgBoxResult.Yes)
				{
					return false;
				}
				return true;
			}
			return true;
		}

		public bool clear_folder(string spath)
		{
			if (!ToolboxUtilities.smethod_28(spath + "\\INQUIRY.bin"))
			{
				return false;
			}
			if (!ToolboxUtilities.smethod_28(spath + "\\SECINQ.bin"))
			{
				return false;
			}
			if (!ToolboxUtilities.smethod_28(spath + "\\IDENTIFY.bin"))
			{
				return false;
			}
			if (!ToolboxUtilities.smethod_28(spath + "\\KEY.bin"))
			{
				return false;
			}
			if (!ToolboxUtilities.smethod_28(spath + "\\SUBSER.bin"))
			{
				return false;
			}
			if (!ToolboxUtilities.smethod_28(spath + "\\KEYAREA.bin"))
			{
				return false;
			}
			if (!ToolboxUtilities.smethod_28(spath + "\\FWH.bin"))
			{
				return false;
			}
			if (!ToolboxUtilities.smethod_28(spath + "\\RTC.bin"))
			{
				return false;
			}
			return true;
		}

		private void method_50(object sender, EventArgs e)
		{
		}

		private void Button19_Click(object sender, EventArgs e)
		{
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] array = new byte[4097];
			byte[] buf = new byte[1025];
			int num = 0;
			while (true)
			{
				if (SPIF_READPAGE(131072 + num * 1024, 1024, ref buf, Conversions.ToBoolean(Interaction.IIf(num == 0, false, true))) == 0)
				{
					ToolboxUtilities.smethod_13(ref buf, 0, 1024, ref array, num * 1024);
					num++;
					if (num <= 3)
					{
						continue;
					}
					string text = Strings.Trim(Strings.Mid(ToolboxUtilities.smethod_1(ref array, 12, 2), 1, 9));
					while (true)
					{
						string text2 = Interaction.InputBox("Type a name for your Lizard (9 characters maximum)", "Current Name:" + text, text);
						if (Operators.CompareString(text2, "", false) == 0)
						{
							break;
						}
						if (text2.Length > 9)
						{
							Interaction.MsgBox("Please just a Maximum of 9 characters for the name", MsgBoxStyle.Information, "Error");
							continue;
						}
						byte[] array2 = (byte[])ToolboxUtilities.smethod_7(text2 + "          ");
						ToolboxUtilities.smethod_13(ref array2, 0, 9, ref array, 2);
						array[11] = 0;
						ToolboxUtilities.smethod_22(1);
						if (SPIF_BSERASE(131072, 4) != 0)
						{
							Interaction.MsgBox("Cannot write back Lizard Details, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
							break;
						}
						ToolboxUtilities.smethod_22(1);
						int num2 = 0;
						while (true)
						{
							ToolboxUtilities.smethod_13(ref array, num2 * 1024, 1024, ref buf, 0);
							if (SPIF_WRITEPAGE(131072 + num2 * 1024, 1024, ref buf, Conversions.ToBoolean(Interaction.IIf(num2 == 0, false, true))) == 0)
							{
								num2++;
								if (num2 > 3)
								{
									Interaction.MsgBox("Name changed to " + text2, MsgBoxStyle.Information, "Success:");
									break;
								}
								continue;
							}
							Interaction.MsgBox("Cannot retrieve Lizard Details, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
							break;
						}
						break;
					}
					break;
				}
				Interaction.MsgBox("Cannot retrieve Lizard Details, Make sure Lizard is on Menu screen and proper com port is selected", MsgBoxStyle.Information, "Error");
				break;
			}
			PortClose();
		}

		private void method_51(object sender, EventArgs e)
		{
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			if (!bool_1)
			{
				Interaction.MsgBox("Please connect a Lizard and click on Get Device Details First", MsgBoxStyle.Information, "Message:");
				return;
			}
			int num = Convert.ToInt16(Interaction.GetSetting("LIZ_TBX", "Settings", "GLOBAL_COUNT", "0"));
			int num2 = Convert.ToInt16(Interaction.GetSetting("LIZ_TBX", "Settings", "TEMP_COUNT", "0"));
			// Assume remote counter update succeeds.
			try
			{
				Interaction.SaveSetting("LIZ_TBX", "Settings", "GLOBAL_COUNT", Conversions.ToString(num2 + num));
				Interaction.SaveSetting("LIZ_TBX", "Settings", "TEMP_COUNT", Conversions.ToString(0));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Interaction.MsgBox("Counter Stats Updated, thank you !!", MsgBoxStyle.Information, "Error:");
		}

		private void Button22_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog1.ShowNewFolderButton = true;
			FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
			DialogResult dialogResult = FolderBrowserDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				sett_tbxjobspath.Text = FolderBrowserDialog1.SelectedPath;
			}
		}

		private void chkTurbo_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void Button23_Click(object sender, EventArgs e)
		{
			SaveAppSettings();
		}

		public void SaveAppSettings()
		{
			Interaction.SaveSetting("LIZ_TBX", "Settings", "JOBSPATH", sett_tbxjobspath.Text);
			Interaction.SaveSetting("LIZ_TBX", "Settings", "BURSTMODE", Conversions.ToString(Interaction.IIf(chkTurbo.Checked, "ON", "OFF")));
			Interaction.SaveSetting("LIZ_TBX", "Settings", "DEFCOMPORT", ToolStripStatusLabel_0.Text);
			Interaction.MsgBox("In order to apply the changes please Restart the Application", MsgBoxStyle.Information, "Attention:");
		}

		public void LoadAppSettings()
		{
			sett_tbxjobspath.Text = Interaction.GetSetting("LIZ_TBX", "Settings", "JOBSPATH");
			chkTurbo.Checked = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(Interaction.GetSetting("LIZ_TBX", "Settings", "BURSTMODE", "ON"), "ON", false) == 0, true, false));
			FolderBrowserDialog1.SelectedPath = sett_tbxjobspath.Text;
			OpenFileDialog1.InitialDirectory = sett_tbxjobspath.Text;
			SaveFileDialog1.InitialDirectory = sett_tbxjobspath.Text;
			if (Operators.CompareString(Interaction.GetSetting("LIZ_TBX", "Settings", "DEFCOMPORT", "NONE"), "NONE", false) != 0)
			{
				ToolStripStatusLabel_0.Text = Interaction.GetSetting("LIZ_TBX", "Settings", "DEFCOMPORT", "NONE");
			}
			else
			{
				ToolStripStatusLabel_0.Text = ToolStripSplitButton1.DropDownItems[0].Text;
			}
		}

		private void TabPage8_Click(object sender, EventArgs e)
		{
		}

		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}

		private void Button24_Click(object sender, EventArgs e)
		{
			bool_3 = true;
		}

		private void method_52(object sender, TabControlCancelEventArgs e)
		{
			if (Operators.CompareString(TabControl1.TabPages[e.TabPageIndex].Text, "Debug", false) == 0)
			{
				if (!method_57())
				{
					Interaction.MsgBox("Module not enabled", MsgBoxStyle.Information, "Disabled");
					e.Cancel = true;
				}
			}
			else if (Timer1.Enabled)
			{
				Timer1.Enabled = false;
				PortClose();
			}
		}

		private void method_53(object sender, TabControlCancelEventArgs e)
		{
			if (Timer1.Enabled)
			{
				Timer1.Enabled = false;
				PortClose();
			}
		}

		private void Button25_Click(object sender, EventArgs e)
		{
			Enabled = false;
			bool flag = false;
			int num = TreeView1.Nodes.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (struct5_0[i].byte_0 == 5)
				{
					flag = true;
				}
			}
			if (flag && Interaction.MsgBox("There are some slots uploaded from the PC, those slots will not be backed up\r\nDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Confirm:") != MsgBoxResult.Yes)
			{
				return;
			}
			int num2 = TreeView1.Nodes.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				if (struct5_0[j].bool_0 && struct5_0[j].byte_0 == 0)
				{
					slot_backup_to_pc(j, true);
				}
			}
			Enabled = true;
			Interaction.MsgBox("The backups were stored to:\r\n" + sett_tbxjobspath.Text, MsgBoxStyle.Information, "Backup Done:");
		}

		private void method_54(int int_15)
		{
			PortClose();
			Enabled = false;
			LoggerList.Items.Clear();
			log_item("PROCESS STARTED", "HEADER");
			int num = 0;
			while (true)
			{
				FtdiNativeMethods.smethod_0();
				if (FtdiNativeMethods.int_72 == 0)
				{
					if (FtdiNativeMethods.int_73 == 0)
					{
						if (num <= 5)
						{
							log_item("WAITING USB...");
							FtdiNativeMethods.Sleep(3000);
							num++;
							continue;
						}
						log_item("ERROR: NO USB DEVICES FOUND");
						Enabled = true;
						return;
					}
					if (FtdiNativeMethods.int_73 <= 1)
					{
						FtdiNativeMethods.int_72 = FtdiNativeMethods.FT_Open(0, ref FtdiNativeMethods.int_74);
						if (FtdiNativeMethods.int_72 == 0)
						{
							break;
						}
						if (num <= 5)
						{
							log_item("WAITING USB...");
							FtdiNativeMethods.Sleep(3000);
							num++;
							continue;
						}
						log_item("ERROR:UNABLE TO OPEN DEVICES");
						Enabled = true;
						return;
					}
					log_item("ERROR: MORE THAN 1 DEVICE DETECTED, REMOVE UNNECESARY USB DEVICES");
					Enabled = true;
					return;
				}
				log_item("ERROR: CANNOT QUERY DEVICES");
				Enabled = true;
				return;
			}
			FtdiNativeMethods.smethod_35();
			if (FtdiNativeMethods.int_72 != 0)
			{
				log_item("ERROR:UNABLE TO READ EEPROM");
				Enabled = true;
				return;
			}
			log_item("Manuf/Region/Desc/Serial   :" + FtdiNativeMethods.string_4 + "/" + FtdiNativeMethods.string_5 + "/" + FtdiNativeMethods.string_6 + "/" + FtdiNativeMethods.string_7);
			log_item("VID/PID/Version            :" + Conversion.Hex(FtdiNativeMethods.struct2_0.short_0) + "/" + Conversion.Hex(FtdiNativeMethods.struct2_0.short_1) + "/" + Conversion.Hex(FtdiNativeMethods.struct2_0.int_2));
			string text = "US";
			FtdiNativeMethods.smethod_37(FtdiNativeMethods.struct2_0, "Maximus", text, "360 Lizard", "", int_15);
			if (FtdiNativeMethods.int_72 != 0)
			{
				log_item("ERROR:UNABLE TO WRITE EEPROM");
				Enabled = true;
				return;
			}
			log_item("***STAGE 1 COMPLETE: DEVICE INITIALIZED", "HEADER");
			Application.DoEvents();
			if (FtdiNativeMethods.FT_Close(FtdiNativeMethods.int_74) != 0)
			{
				log_item("Close Failed");
				Enabled = true;
			}
			else
			{
				Enabled = true;
				log_item("PROCESS ENDED", "HEADER");
			}
		}

		public void log_item(string sString, string stype = "")
		{
			if (Operators.CompareString(stype, "HEADER", false) == 0)
			{
				LoggerList.Items.Add(sString);
			}
			else
			{
				LoggerList.Items.Add("          " + sString);
			}
			LoggerList.SelectedIndex = LoggerList.Items.Count - 1;
			Application.DoEvents();
		}

		private void method_55()
		{
			PortClose();
			Enabled = false;
			LoggerList.Items.Clear();
			log_item("PROCESS STARTED", "HEADER");
			int num = 0;
			while (true)
			{
				FtdiNativeMethods.smethod_0();
				if (FtdiNativeMethods.int_72 == 0)
				{
					if (FtdiNativeMethods.int_73 == 0)
					{
						if (num <= 5)
						{
							log_item("WAITING USB...");
							FtdiNativeMethods.Sleep(3000);
							num++;
							continue;
						}
						log_item("ERROR: NO USB DEVICES FOUND");
						Enabled = true;
						return;
					}
					if (FtdiNativeMethods.int_73 <= 1)
					{
						FtdiNativeMethods.int_72 = FtdiNativeMethods.FT_Open(0, ref FtdiNativeMethods.int_74);
						if (FtdiNativeMethods.int_72 == 0)
						{
							break;
						}
						if (num <= 5)
						{
							log_item("WAITING USB...");
							FtdiNativeMethods.Sleep(3000);
							num++;
							continue;
						}
						log_item("ERROR:UNABLE TO OPEN DEVICES");
						Enabled = true;
						return;
					}
					log_item("ERROR: MORE THAN 1 DEVICE DETECTED, REMOVE UNNECESARY USB DEVICES");
					Enabled = true;
					return;
				}
				log_item("ERROR: CANNOT QUERY DEVICES");
				Enabled = true;
				return;
			}
			FtdiNativeMethods.smethod_35();
			if (FtdiNativeMethods.int_72 != 0)
			{
				log_item("ERROR:UNABLE TO READ EEPROM");
				Enabled = true;
				return;
			}
			string text;
			if (FtdiNativeMethods.struct2_0.byte_27 == 1)
			{
				text = "Powered after enumeration (Default)";
				sett_rb_usbpowdef.Checked = true;
			}
			else
			{
				text = "Powered since Insertion";
				sett_rb_usbpowins.Checked = true;
			}
			log_item("Manuf/Region/Desc/Serial   :" + FtdiNativeMethods.string_4 + "/" + FtdiNativeMethods.string_5 + "/" + FtdiNativeMethods.string_6 + "/" + FtdiNativeMethods.string_7);
			log_item("VID/PID/Version            :" + Conversion.Hex(FtdiNativeMethods.struct2_0.short_0) + "/" + Conversion.Hex(FtdiNativeMethods.struct2_0.short_1) + "/" + Conversion.Hex(FtdiNativeMethods.struct2_0.int_2));
			log_item("Power Setting              :" + text);
			if (FtdiNativeMethods.FT_Close(FtdiNativeMethods.int_74) != 0)
			{
				log_item("Close Failed");
				Enabled = true;
			}
			else
			{
				Enabled = true;
				log_item("PROCESS ENDED", "HEADER");
			}
		}

		private void sett_rb_usbpowdef_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void Button26_Click(object sender, EventArgs e)
		{
			method_55();
		}

		private void Button27_Click(object sender, EventArgs e)
		{
			if (Interaction.MsgBox("You are about to change the USB Power configuration of your Lizard Device\r\nYou can revert back later to default mode\r\nDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Please Confirm:") == MsgBoxResult.Yes)
			{
				if (sett_rb_usbpowdef.Checked)
				{
					method_54(0);
				}
				if (sett_rb_usbpowins.Checked)
				{
					method_54(1);
				}
			}
		}

		private void Button28_Click(object sender, EventArgs e)
		{
			if (Interaction.MsgBox("This will erase the Slots in your Lizard device so make sure you did backup first\r\nDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Please Confirm:") != MsgBoxResult.Yes || Interaction.MsgBox("Are you Really Sure?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Last chance to cancel:") != MsgBoxResult.Yes)
			{
				return;
			}
			Enabled = false;
			int num = TreeView1.Nodes.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (struct5_0[i].bool_0)
				{
					slot_erase(i, true);
				}
			}
			Enabled = true;
			Interaction.MsgBox("The Slots have been erased", MsgBoxStyle.Information, "Done:");
		}

		private void Button29_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(txbEV_SrcKey.Text, "", false) == 0)
			{
				Interaction.MsgBox("Please load a file on CFW Generator Easy view to grab key", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] array = new byte[16];
			byte b = 0;
			array = ToolboxUtilities.cpoahSiso(txbEV_SrcKey.Text);
			bool bisvalid = false;
			byte num = LIZ_WRKEY(ref array, ref bisvalid);
			b = (byte)(0u - (bisvalid ? 1u : 0u));
			byte b2 = num;
			if (b2 == 0)
			{
				if (b != 0)
				{
					Interaction.MsgBox("Key Match [" + ToolboxUtilities.smethod_5(ref array) + "]", MsgBoxStyle.Information, "Match");
				}
				else
				{
					Interaction.MsgBox("Key Not Match [" + ToolboxUtilities.smethod_5(ref array) + "]", MsgBoxStyle.Exclamation, "Not Match");
				}
			}
			else
			{
				Interaction.MsgBox("Error checking key, return code:" + Conversions.ToString(b2), MsgBoxStyle.Exclamation, "Error");
			}
			PortClose();
		}

		public byte LIZ_CHKKEY(ref byte[] buf, ref bool bisvalid, bool bContinuedRead = false)
		{
			byte[] buf2 = new byte[17];
			int count;
			if (!bContinuedRead)
			{
				buf2[0] = 64;
				buf2[1] = 85;
				buf2[2] = 112;
				buf2[3] = 64;
				count = 4;
			}
			else
			{
				buf2[0] = 2;
				count = 1;
			}
			byte result;
			try
			{
				SerialPort1.Write(buf2, 0, count);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = 129;
				ProjectData.ClearProjectError();
				goto IL_009f;
			}
			if (ReadUSARTw_to(ref buf2, 1))
			{
				if (buf2[0] == 6)
				{
					ToolboxUtilities.smethod_13(ref buf, 0, 16, ref buf2, 0);
					buf2[16] = ToolboxUtilities.smethod_4(buf2, 16);
					try
					{
						SerialPort1.Write(buf2, 0, 17);
					}
					catch (TimeoutException projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						result = 129;
						ProjectData.ClearProjectError();
						goto IL_009f;
					}
					if (ReadUSARTw_to(ref buf2, 1))
					{
						if ((buf2[0] == 6) | (buf2[0] == 21))
						{
							if (buf2[0] == 6)
							{
								bisvalid = true;
							}
							else
							{
								bisvalid = false;
							}
							return 0;
						}
						return 136;
					}
					return 132;
				}
				return 136;
			}
			return 132;
			IL_009f:
			return result;
		}

		public byte LIZ_PageCodeLog(byte pc, ref byte[] buf, ref byte[] bPCLog, ref bool bisvalid, bool bContinuedRead = false)
		{
			byte[] buf2 = new byte[18];
			bisvalid = false;
			int count;
			if (!bContinuedRead)
			{
				buf2[0] = 64;
				buf2[1] = 85;
				buf2[2] = 116;
				buf2[3] = 64;
				count = 4;
			}
			else
			{
				buf2[0] = 2;
				count = 1;
			}
			byte result;
			try
			{
				SerialPort1.Write(buf2, 0, count);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = 129;
				ProjectData.ClearProjectError();
				goto IL_00ac;
			}
			if (ReadUSARTw_to(ref buf2, 1))
			{
				if (buf2[0] == 6)
				{
					ToolboxUtilities.smethod_13(ref buf, 0, 16, ref buf2, 0);
					buf2[16] = pc;
					buf2[17] = ToolboxUtilities.smethod_4(buf2, 17);
					try
					{
						SerialPort1.Write(buf2, 0, 18);
					}
					catch (TimeoutException projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						result = 129;
						ProjectData.ClearProjectError();
						goto IL_00ac;
					}
					if (ReadUSARTw_to(ref buf2, 1))
					{
						if ((buf2[0] == 6) | (buf2[0] == 21))
						{
							if (buf2[0] == 6)
							{
								SerialPort1.ReadTimeout = 15000;
								if (ReadUSARTw_to(ref bPCLog, 1008))
								{
									bisvalid = true;
								}
							}
							else
							{
								bisvalid = false;
							}
							return 0;
						}
						return 136;
					}
					return 132;
				}
				return 136;
			}
			return 132;
			IL_00ac:
			return result;
		}

		public byte LIZ_ATA_CMD(ref SerialPort SerPort, byte command, byte direction, int tsize, ref byte[] buf, ref byte errstat, bool bContinuedRead = false)
		{
			byte[] buf2 = new byte[514];
			int count;
			if (!bContinuedRead)
			{
				buf2[0] = 64;
				buf2[1] = 85;
				buf2[2] = 119;
				buf2[3] = 64;
				count = 4;
			}
			else
			{
				buf2[0] = 2;
				count = 1;
			}
			byte result;
			try
			{
				SerPort.Write(buf2, 0, count);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = 129;
				ProjectData.ClearProjectError();
				goto IL_01d6;
			}
			if (ReadUSARTw_to(ref buf2, 1))
			{
				if (buf2[0] == 6)
				{
					buf2[0] = command;
					buf2[1] = direction;
					buf2[2] = (byte)(tsize & 0xFF);
					buf2[3] = (byte)((tsize / 256) & 0xFF);
					buf2[4] = ToolboxUtilities.smethod_4(buf2, 4);
					try
					{
						SerPort.Write(buf2, 0, 5);
					}
					catch (TimeoutException projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						result = 129;
						ProjectData.ClearProjectError();
						goto IL_01d6;
					}
					if (ReadUSARTw_to(ref buf2, 1))
					{
						if (buf2[0] == 6)
						{
							if (direction == 1)
							{
								ToolboxUtilities.smethod_13(ref buf, 0, tsize, ref buf2, 0);
								buf2[tsize] = ToolboxUtilities.smethod_4(buf2, tsize);
								try
								{
									SerPort.Write(buf2, 0, tsize + 1);
								}
								catch (TimeoutException projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									result = 129;
									ProjectData.ClearProjectError();
									goto IL_01d6;
								}
								if (!ReadUSARTw_to(ref buf2, 1))
								{
									return 132;
								}
								if (buf2[0] != 6)
								{
									return 136;
								}
							}
							if (ReadUSARTw_to(ref buf2, 2))
							{
								errstat = buf2[0];
								if (errstat == 80)
								{
									buf2[0] = 6;
									try
									{
										SerPort.Write(buf2, 0, 1);
									}
									catch (TimeoutException projectError4)
									{
										ProjectData.SetProjectError(projectError4);
										result = 129;
										ProjectData.ClearProjectError();
										goto IL_01d6;
									}
									if (direction == 0)
									{
										if (!ReadUSARTw_to(ref buf, tsize, true))
										{
											return 132;
										}
										buf2[0] = 6;
										try
										{
											SerPort.Write(buf2, 0, 1);
										}
										catch (TimeoutException projectError5)
										{
											ProjectData.SetProjectError(projectError5);
											result = 129;
											ProjectData.ClearProjectError();
											goto IL_01d6;
										}
										return 0;
									}
								}
								else
								{
									buf2[0] = 21;
									try
									{
										SerPort.Write(buf2, 0, 1);
									}
									catch (TimeoutException projectError6)
									{
										ProjectData.SetProjectError(projectError6);
										result = 129;
										ProjectData.ClearProjectError();
										goto IL_01d6;
									}
								}
							}
							return 0;
						}
						return 136;
					}
					return 132;
				}
				return 136;
			}
			return 132;
			IL_01d6:
			return result;
		}

		public byte LIZ_ATAPI_CMD(ref SerialPort SerPort, byte[] command, byte direction, int rsize, int wsize, ref byte[] buf, ref byte errstat, ref byte sense, bool bContinuedRead = false)
		{
			byte[] buf2 = new byte[514];
			int count;
			if (!bContinuedRead)
			{
				buf2[0] = 64;
				buf2[1] = 85;
				buf2[2] = 120;
				buf2[3] = 64;
				count = 4;
			}
			else
			{
				buf2[0] = 2;
				count = 1;
			}
			byte result;
			try
			{
				SerPort.Write(buf2, 0, count);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = 129;
				ProjectData.ClearProjectError();
				goto IL_0212;
			}
			if (ReadUSARTw_to(ref buf2, 1))
			{
				if (buf2[0] == 6)
				{
					ToolboxUtilities.smethod_13(ref command, 0, 12, ref buf2, 0);
					buf2[12] = direction;
					buf2[13] = 0;
					buf2[14] = (byte)(wsize & 0xFF);
					buf2[15] = (byte)((wsize / 256) & 0xFF);
					buf2[16] = (byte)(rsize & 0xFF);
					buf2[17] = (byte)((rsize / 256) & 0xFF);
					buf2[18] = ToolboxUtilities.smethod_4(buf2, 18);
					try
					{
						SerPort.Write(buf2, 0, 19);
					}
					catch (TimeoutException projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						result = 129;
						ProjectData.ClearProjectError();
						goto IL_0212;
					}
					if (ReadUSARTw_to(ref buf2, 1))
					{
						if (buf2[0] == 6)
						{
							if (wsize > 0)
							{
								ToolboxUtilities.smethod_13(ref buf, 0, wsize, ref buf2, 0);
								buf2[wsize] = ToolboxUtilities.smethod_4(buf2, wsize);
								try
								{
									SerPort.Write(buf2, 0, wsize + 1);
								}
								catch (TimeoutException projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									result = 129;
									ProjectData.ClearProjectError();
									goto IL_0212;
								}
								if (!ReadUSARTw_to(ref buf2, 1))
								{
									return 132;
								}
								if (buf2[0] != 6)
								{
									return 136;
								}
							}
							if (ReadUSARTw_to(ref buf2, 2))
							{
								errstat = buf2[0];
								sense = buf2[1];
								if (errstat == 80)
								{
									buf2[0] = 6;
									try
									{
										SerPort.Write(buf2, 0, 1);
									}
									catch (TimeoutException projectError4)
									{
										ProjectData.SetProjectError(projectError4);
										result = 129;
										ProjectData.ClearProjectError();
										goto IL_0212;
									}
									if (rsize > 0)
									{
										if (!ReadUSARTw_to(ref buf, rsize, true))
										{
											return 132;
										}
										buf2[0] = 6;
										try
										{
											SerPort.Write(buf2, 0, 1);
										}
										catch (TimeoutException projectError5)
										{
											ProjectData.SetProjectError(projectError5);
											result = 129;
											ProjectData.ClearProjectError();
											goto IL_0212;
										}
										return 0;
									}
								}
								else
								{
									buf2[0] = 21;
									try
									{
										SerPort.Write(buf2, 0, 1);
									}
									catch (TimeoutException projectError6)
									{
										ProjectData.SetProjectError(projectError6);
										result = 129;
										ProjectData.ClearProjectError();
										goto IL_0212;
									}
								}
							}
							return 0;
						}
						return 136;
					}
					return 132;
				}
				return 136;
			}
			return 132;
			IL_0212:
			return result;
		}

		public byte LIZ_BUZZTEST(byte[] buf)
		{
			byte[] buf2 = new byte[17]
			{
				64, 85, 128, 64, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0
			};
			int count = 4;
			byte result;
			try
			{
				SerialPort1.Write(buf2, 0, count);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = 129;
				ProjectData.ClearProjectError();
				goto IL_0091;
			}
			if (ReadUSARTw_to(ref buf2, 1))
			{
				if (buf2[0] == 6)
				{
					ToolboxUtilities.smethod_13(ref buf, 0, 2, ref buf2, 0);
					buf2[2] = ToolboxUtilities.smethod_4(buf2, 2);
					try
					{
						SerialPort1.Write(buf2, 0, 3);
					}
					catch (TimeoutException projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						result = 129;
						ProjectData.ClearProjectError();
						goto IL_0091;
					}
					return 0;
				}
				return 136;
			}
			return 132;
			IL_0091:
			return result;
		}

		public byte LIZ_WRKEY(ref byte[] buf, ref bool bisvalid)
		{
			byte[] buf2 = new byte[17]
			{
				64, 85, 115, 64, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0
			};
			int count = 4;
			byte result;
			try
			{
				SerialPort1.Write(buf2, 0, count);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = 129;
				ProjectData.ClearProjectError();
				goto IL_0094;
			}
			if (ReadUSARTw_to(ref buf2, 1))
			{
				if (buf2[0] == 6)
				{
					ToolboxUtilities.smethod_13(ref buf, 0, 16, ref buf2, 0);
					buf2[16] = ToolboxUtilities.smethod_4(buf2, 16);
					try
					{
						SerialPort1.Write(buf2, 0, 17);
					}
					catch (TimeoutException projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						result = 129;
						ProjectData.ClearProjectError();
						goto IL_0094;
					}
					if (ReadUSARTw_to(ref buf2, 1))
					{
						if ((buf2[0] == 6) | (buf2[0] == 21))
						{
							if (buf2[0] == 6)
							{
								bisvalid = true;
							}
							else
							{
								bisvalid = false;
							}
							return 0;
						}
						return 136;
					}
					return 132;
				}
				return 136;
			}
			return 132;
			IL_0094:
			return result;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			string string_ = SerialPort1.ReadExisting();
			string_ = ToolboxUtilities.smethod_26(string_);
			TextBox_0.Text += string_;
			TextBox_0.SelectionStart = TextBox_0.TextLength;
			TextBox_0.ScrollToCaret();
			if (bool_2)
			{
				method_56(string_);
			}
		}

		private void method_56(string string_21)
		{
			if (Strings.InStr(string_21, "SR2:00", CompareMethod.Text) > 0)
			{
				try
				{
					MyProject.Computer.Audio.Play(Application.StartupPath + "\\unlocksound.wav", AudioPlayMode.BackgroundLoop);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Interaction.MsgBox("Unable to Play file: " + Application.StartupPath + "\\unlocksound.wav\r\nMake sure file exists", MsgBoxStyle.Exclamation, "Error:");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void Button31_Click(object sender, EventArgs e)
		{
			Timer1.Enabled = false;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			SerialPort1.ReceivedBytesThreshold = 1;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
			}
			else
			{
				Timer1.Enabled = true;
			}
		}

		private void Button32_Click(object sender, EventArgs e)
		{
			Timer1.Enabled = false;
			PortClose();
		}

		private void Button33_Click(object sender, EventArgs e)
		{
			TextBox_0.Text = "";
		}

		private void Button34_Click(object sender, EventArgs e)
		{
			SaveFileDialog1.CreatePrompt = false;
			SaveFileDialog1.OverwritePrompt = true;
			SaveFileDialog1.FileName = "lizlog";
			SaveFileDialog1.DefaultExt = "txt";
			SaveFileDialog1.Filter = "TXT files (*.txt)|*.txt";
			DialogResult dialogResult = SaveFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(SaveFileDialog1.FileName))
			{
				streamWriter.Write(TextBox_0.Text);
			}
		}

		private void TabPage_2_Click(object sender, EventArgs e)
		{
		}

		private bool method_57()
		{
			byte[] array = new byte[4];
			byte[] buf = new byte[2];
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return false;
			}
			array[0] = 64;
			array[1] = 85;
			array[2] = 6;
			array[3] = 64;
			try
			{
				SerialPort1.Write(array, 0, 4);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Cannot write to port", MsgBoxStyle.Information, "Error:");
				ProjectData.ClearProjectError();
				goto IL_00e7;
			}
			if (ReadUSARTw_to(ref buf, 1))
			{
				PortClose();
				if (buf[0] == 6)
				{
					return true;
				}
				return false;
			}
			Interaction.MsgBox("Read Response Failed", MsgBoxStyle.Information, "Error:");
			goto IL_00e7;
			IL_00e7:
			return false;
		}

		private void TextBox_0_TextChanged(object sender, EventArgs e)
		{
		}

		private void Button35_Click(object sender, EventArgs e)
		{
			byte[] bPCLog = new byte[1008];
			if (this.get_pc23log((byte)35, ref bPCLog))
			{
				SaveFileDialog1.CreatePrompt = false;
				SaveFileDialog1.OverwritePrompt = true;
				SaveFileDialog1.FileName = "DC3";
				SaveFileDialog1.DefaultExt = "bin";
				SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
				DialogResult dialogResult = SaveFileDialog1.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					FileStream fileStream = new FileStream(SaveFileDialog1.FileName, FileMode.Create);
					fileStream.Write(bPCLog, 0, 1008);
					fileStream.Close();
				}
			}
		}

		private void Button36_Click(object sender, EventArgs e)
		{
			byte[] bPCLog = new byte[1008];
			if (this.get_pc23log((byte)36, ref bPCLog))
			{
				SaveFileDialog1.CreatePrompt = false;
				SaveFileDialog1.OverwritePrompt = true;
				SaveFileDialog1.FileName = "DC4";
				SaveFileDialog1.DefaultExt = "bin";
				SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
				DialogResult dialogResult = SaveFileDialog1.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					FileStream fileStream = new FileStream(SaveFileDialog1.FileName, FileMode.Create);
					fileStream.Write(bPCLog, 0, 1008);
					fileStream.Close();
				}
			}
		}

		private void Button37_Click(object sender, EventArgs e)
		{
			byte[] bPCLog = new byte[1008];
			byte[] array = new byte[1008];
			txbCompareLog.Text = "";
			OpenFileDialog1.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (FileSystem.FileLen(OpenFileDialog1.FileName) != 1008L)
			{
				Interaction.MsgBox("Please choose a valid file", MsgBoxStyle.Information, "Error:");
				return;
			}
			array = FirmwareUtilities.smethod_35(OpenFileDialog1.FileName, 0L, 1008);
			if (this.get_pc23log((byte)35, ref bPCLog))
			{
				compare_logs(ref array, ref bPCLog, "File Contents", "Drive Contents");
			}
		}

		public void compare_logs(ref byte[] buf1, ref byte[] buf2, string sLabel1, string sLabel2)
		{
			byte[] array = new byte[16];
			byte[] array2 = new byte[16];
			string text = Strings.Mid(sLabel1 + Strings.StrDup(32, " "), 1, 32) + " - " + Strings.Mid(sLabel2 + Strings.StrDup(32, " "), 1, 32) + "\r\n";
			txbCompareLog.Text = text;
			txbCompareLog.Text += Strings.StrDup(67, "-");
			int num = 0;
			do
			{
				ToolboxUtilities.smethod_13(ref buf1, 16 + num * 16, 16, ref array, 0);
				ToolboxUtilities.smethod_13(ref buf2, 16 + num * 16, 16, ref array2, 0);
				bool expression = ToolboxUtilities.smethod_16(ref array, 0, 16, ref array2, 0);
				text = Conversions.ToString(Operators.AddObject(Operators.AddObject(string.Concat(string.Concat(ToolboxUtilities.smethod_5(ref array, 16) + " - ", ToolboxUtilities.smethod_5(ref array2, 16)), " -->"), Interaction.IIf(expression, "Ok", "Fail")), "\r\n"));
				txbCompareLog.Text += text;
				num++;
			}
			while (num <= 61);
		}

		private void Button38_Click(object sender, EventArgs e)
		{
			byte[] bPCLog = new byte[1008];
			byte[] array = new byte[1008];
			txbCompareLog.Text = "";
			OpenFileDialog1.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (FileSystem.FileLen(OpenFileDialog1.FileName) != 1008L)
			{
				Interaction.MsgBox("Please choose a valid file", MsgBoxStyle.Information, "Error:");
				return;
			}
			array = FirmwareUtilities.smethod_35(OpenFileDialog1.FileName, 0L, 1008);
			if (this.get_pc23log((byte)36, ref bPCLog))
			{
				compare_logs(ref array, ref bPCLog, "File Contents", "Drive Contents");
			}
		}

		private void Button39_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[1008];
			byte[] array2 = new byte[1008];
			txbCompareLog.Text = "";
			OpenFileDialog1.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (FileSystem.FileLen(OpenFileDialog1.FileName) != 1008L)
			{
				Interaction.MsgBox("Please choose a valid file", MsgBoxStyle.Information, "Error:");
				return;
			}
			array2 = FirmwareUtilities.smethod_35(OpenFileDialog1.FileName, 0L, 1008);
			OpenFileDialog1.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult2 = OpenFileDialog1.ShowDialog();
			if (dialogResult2 == DialogResult.OK)
			{
				if (FileSystem.FileLen(OpenFileDialog1.FileName) != 1008L)
				{
					Interaction.MsgBox("Please choose a valid file", MsgBoxStyle.Information, "Error:");
					return;
				}
				array = FirmwareUtilities.smethod_35(OpenFileDialog1.FileName, 0L, 1008);
				compare_logs(ref array2, ref array, "File 1", "File 2");
			}
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void Button40_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\unlocksound.wav"), "", false) == 0)
			{
				Interaction.MsgBox("The File: " + Application.StartupPath + "\\unlocksound.wav\r\nDoes not exists", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			bool_2 = true;
			Timer1.Enabled = false;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			SerialPort1.ReceivedBytesThreshold = 1;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
			}
			else
			{
				Timer1.Enabled = true;
			}
		}

		private void Button41_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\unlocksound.wav", AudioPlayMode.BackgroundLoop);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Unable to Play file: " + Application.StartupPath + "\\unlocksound.wav\r\nMake sure file exists", MsgBoxStyle.Exclamation, "Error:");
				ProjectData.ClearProjectError();
			}
		}

		private void Button42_Click(object sender, EventArgs e)
		{
			Timer1.Enabled = false;
			PortClose();
			bool_2 = false;
			MyProject.Computer.Audio.Stop();
		}

		private void Button43_Click(object sender, EventArgs e)
		{
		}

		private void ibkoaCbUd2(object sender, EventArgs e)
		{
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void Button44_Click(object sender, EventArgs e)
		{
			string text = "C:\\f_inbox\\FW Collection\\LITEON DG16D4S\\100 dumps\\";
			string text2 = FileSystem.Dir(text, FileAttribute.Directory);
			int num = 0;
			TextBox_0.Text = "";
			StreamWriter streamWriter = new StreamWriter(text + "log.txt", false);
			string[] array = default(string[]);
			while (Operators.CompareString(text2, "", false) != 0)
			{
				if ((FileSystem.GetAttr(text + text2) & FileAttribute.Directory) == FileAttribute.Directory)
				{
					array = (string[])Utils.CopyArray(array, new string[num + 1]);
					array[num] = text + text2 + "\\source.bin";
					byte[] array2 = FirmwareUtilities.smethod_35(array[num], 258048L, 16);
					string text3 = ToolboxUtilities.smethod_5(ref array2);
					string text4 = Conversions.ToString(Operators.AddObject(Operators.AddObject(string.Concat(Strings.Mid(num + Strings.Space(4), 1, 4) + Strings.Mid(array[num] + Strings.Space(80), 1, 80), text3), Interaction.IIf(Operators.CompareString(Strings.Mid(text3, 1, 6), "BB01FF", false) == 0, " ", "*")), "\r\n"));
					TextBox_0.Text += text4;
					streamWriter.Write(text4);
					num++;
				}
				text2 = FileSystem.Dir();
			}
			streamWriter.Close();
		}

		private void Button45_Click(object sender, EventArgs e)
		{
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte b = LIZ_BUZZTEST(new byte[16]
			{
				Convert.ToByte(txbPeriod.Text, 16),
				Convert.ToByte(txbTime.Text),
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			});
			if (b != 0)
			{
				Interaction.MsgBox("Error testing buzzer" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
			}
			PortClose();
		}

		private void Button46_Click(object sender, EventArgs e)
		{
			method_58();
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void method_58()
		{
			WebClient webClient = new WebClient();
			string text = "";
			string text2 = "";
			string text3 = "";
			int num = 0;
			bool flag = false;
			if (!bool_1)
			{
				Interaction.MsgBox("Please connect a Lizard and click on Get Device Details First", MsgBoxStyle.Information, "Message:");
				return;
			}
			LoggerList.Items.Clear();
			log_item("UPDATE CHECK STARTED", "HEADER");
			double num2 = default(double);
			string text5 = default(string);
			string[] array = default(string[]);
			double num3 = default(double);
			double num4 = default(double);
			double num5 = default(double);
			double num6 = default(double);
			try
			{
				Stream stream = webClient.OpenRead("http://www.drivehq.com/file/df.aspx/publish/carranzafp/TBX/version.txt");
				StreamReader streamReader = new StreamReader(stream);
				log_item("Checking latest versions...OK");
				while (true)
				{
					string text4 = streamReader.ReadLine();
					if (Strings.InStr(text4, "[GECKO]", CompareMethod.Text) <= 0)
					{
						if (Strings.InStr(text4, "[TBX]", CompareMethod.Text) > 0)
						{
							while (true)
							{
								text4 = streamReader.ReadLine();
								if (Strings.InStr(text4, "[END]", CompareMethod.Text) > 0)
								{
									break;
								}
								if (Strings.InStr(text4, "CurVersion:", CompareMethod.Text) > 0)
								{
									string string_ = Strings.Trim(Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1));
									num2 = ToolboxUtilities.smethod_27(string_);
									log_item(Conversions.ToString(Operators.AddObject("TBX Version: " + num2, Interaction.IIf(double_3 < num2, "...REQUIRE UPDATE", "...OK"))));
								}
								if (Strings.InStr(Strings.UCase(text4), "MAINEXE:", CompareMethod.Text) > 0)
								{
									text5 = Strings.Trim(Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1));
								}
								if (Strings.InStr(Strings.UCase(text4), "FILE:", CompareMethod.Text) > 0)
								{
									string string_ = Strings.Trim(Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1));
									array = (string[])Utils.CopyArray(array, new string[num + 1 + 1]);
									array[num] = string_;
									num++;
								}
							}
						}
						else if (Strings.InStr(text4, "[OFW_Template]", CompareMethod.Text) > 0)
						{
							while (true)
							{
								text4 = streamReader.ReadLine();
								if (Strings.InStr(text4, "[END]", CompareMethod.Text) > 0)
								{
									break;
								}
								if (Strings.InStr(text4, "CurVersion:", CompareMethod.Text) > 0)
								{
									string string_ = Strings.Trim(Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1));
									num3 = ToolboxUtilities.smethod_27(string_);
									log_item(Conversions.ToString(Operators.AddObject("OFW Template Version: " + num3, Interaction.IIf(double_1 < num3, "...REQUIRE UPDATE", "...OK"))));
								}
								if (Strings.InStr(text4, "Filename:", CompareMethod.Text) > 0)
								{
									text = Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1);
									text = Strings.Trim(text);
								}
							}
						}
						else if (Strings.InStr(text4, "[CFW_Template]", CompareMethod.Text) > 0)
						{
							while (true)
							{
								text4 = streamReader.ReadLine();
								if (Strings.InStr(text4, "[END]", CompareMethod.Text) > 0)
								{
									break;
								}
								if (Strings.InStr(text4, "CurVersion:", CompareMethod.Text) > 0)
								{
									string string_ = Strings.Trim(Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1));
									num4 = ToolboxUtilities.smethod_27(string_);
									log_item(Conversions.ToString(Operators.AddObject("CFW Template Version: " + num4, Interaction.IIf(double_0 < num4, "...REQUIRE UPDATE!", "...OK"))));
								}
								if (Strings.InStr(text4, "Filename:", CompareMethod.Text) > 0)
								{
									text2 = Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1);
									text2 = Strings.Trim(text2);
								}
							}
						}
						else if (Strings.InStr(text4, "[LTU_Template]", CompareMethod.Text) > 0)
						{
							while (true)
							{
								text4 = streamReader.ReadLine();
								if (Strings.InStr(text4, "[END]", CompareMethod.Text) > 0)
								{
									break;
								}
								if (Strings.InStr(text4, "CurVersion:", CompareMethod.Text) > 0)
								{
									string string_ = Strings.Trim(Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1));
									num5 = ToolboxUtilities.smethod_27(string_);
									log_item(Conversions.ToString(Operators.AddObject("LTU Template Version: " + num5, Interaction.IIf(double_2 < num5, "...REQUIRE UPDATE!", "...OK"))));
								}
								if (Strings.InStr(text4, "Filename:", CompareMethod.Text) > 0)
								{
									text3 = Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1);
									text3 = Strings.Trim(text3);
								}
							}
						}
						else if (text4 == null)
						{
							break;
						}
						continue;
					}
					while (true)
					{
						text4 = streamReader.ReadLine();
						if (Strings.InStr(text4, "[END]", CompareMethod.Text) > 0)
						{
							break;
						}
						if (Strings.InStr(text4, "CurVersion:", CompareMethod.Text) > 0)
						{
							string string_ = Strings.Trim(Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1));
							num6 = ToolboxUtilities.smethod_27(string_);
							log_item(Conversions.ToString(Operators.AddObject("Gecko Version: " + num6, Interaction.IIf(double_4 < num6, "...REQUIRE UPDATE", "...OK"))));
						}
						if (Strings.InStr(text4, "ForcedUpdate:", CompareMethod.Text) > 0)
						{
							string string_ = Strings.Trim(Strings.Mid(text4, Strings.InStr(text4, ":", CompareMethod.Text) + 1));
							if (flag = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(string_, "Y", false) == 0, true, false)))
							{
								log_item("Mandatory Gecko Update !");
							}
						}
					}
				}
				streamReader.Close();
				stream.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Make sure you have Internet Conectivity from this PC", MsgBoxStyle.Exclamation, "Cannot check Version");
				ProjectData.ClearProjectError();
				return;
			}
			if (double_3 < num2)
			{
				log_item("TBX APPLICATION UPDATE STARTED", "HEADER");
				if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\CFW_Templates\\_old", FileAttribute.Directory), "", false) == 0)
				{
					FileSystem.MkDir(Application.StartupPath + "\\CFW_Templates\\_old");
					log_item("Creating backup _old folder...Done");
				}
				string text6 = Application.StartupPath + "\\" + text5;
				if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\newver.exe"), "", false) != 0)
				{
					FileSystem.Kill(Application.StartupPath + "\\newver.exe");
				}
				Application.DoEvents();
				try
				{
					webClient.DownloadFile("http://www.drivehq.com/file/df.aspx/publish/carranzafp/TBX/" + text5, Application.StartupPath + "\\newver.exe");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "Error:");
					if (Interaction.MsgBox("The Application update has failed, do you want to go to the download Page to manually download the update?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Error:") == MsgBoxResult.Yes)
					{
						Process.Start("http://360lizard.com/website/downloads.php");
					}
					ProjectData.ClearProjectError();
					return;
				}
				log_item("Downloading New file " + text5 + "...Done");
				int num7 = num - 1;
				for (int i = 0; i <= num7; i++)
				{
					text6 = Application.StartupPath + "\\" + array[i];
					if (Operators.CompareString(FileSystem.Dir(text6), "", false) != 0)
					{
						FileSystem.Kill(text6);
					}
					log_item("Deleting Old file " + array[i] + "...Done");
					Application.DoEvents();
					try
					{
						webClient.DownloadFile("http://www.drivehq.com/file/df.aspx/publish/carranzafp/TBX/" + array[i], Application.StartupPath + "\\" + array[i]);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						Interaction.MsgBox(ex4.Message, MsgBoxStyle.Exclamation, "Error:");
						if (Interaction.MsgBox("The Application update has failed, do you want to go to the download Page to manually download the update?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Error:") == MsgBoxResult.Yes)
						{
							Process.Start("http://360lizard.com/website/downloads.php");
						}
						ProjectData.ClearProjectError();
						return;
					}
					log_item("Downloading New file " + array[i] + "...Done");
				}
				Interaction.MsgBox("We will now close the App to finish the Update, after update is done should restart again\r\nAfter restart please run the Check Update option again to continue with update of other elements", MsgBoxStyle.Information, "Notice:");
				Process.Start(Application.StartupPath + "\\soup.exe");
				Application.Exit();
				return;
			}
			if (double_4 != 0.0 && double_4 < num6)
			{
				if (flag)
				{
					log_item("Online update stopped");
					Interaction.MsgBox("Your Lizard require update to Latest Gecko Version (" + num6 + ")\r\nPlease Update this software before continue", MsgBoxStyle.Exclamation, "Lizard Firmware require update");
					if (Interaction.MsgBox("Press Yes to view Update Manual", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Do you want to view the Update Manual?") == MsgBoxResult.Yes)
					{
						Process.Start("http://360lizard.com/website/downloads/Updating%20the%20Lizard.pdf");
					}
					return;
				}
				Interaction.MsgBox("There is a new Gecko Version available for your Lizard (Gecko " + num6 + ")\r\nThis update is not mandatory to continue but its strongly recommended to have it\r\nPress Ok to continue", MsgBoxStyle.Exclamation, "Lizard Firmware require update");
				if (Interaction.MsgBox("Press Yes to view Update Manual", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Do you want to view the Update Manual?") == MsgBoxResult.Yes)
				{
					Process.Start("http://360lizard.com/website/downloads/Updating%20the%20Lizard.pdf");
				}
			}
			bool flag2 = false;
			if ((double_1 < num3) | (double_0 < num4) | (double_2 < num5))
			{
				flag2 = true;
			}
			if (flag2 && Interaction.MsgBox("The Templates Online Update Feature is a free feature for every Lizard owner.\r\nEvery time you use this service your Lizard serial number is logged in our database\r\nTo Preserve bandwith we have set a limit of uses per day to every Lizard user\r\nAny abuse of this service will cause that your Lizard will be flagged and lost this feature", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Do you agree?") != MsgBoxResult.Yes)
			{
				return;
			}
			if (flag2)
			{
				if (method_59())
				{
					log_item("TEMPLATE FILES UPDATE STARTED", "HEADER");
					if (double_1 < num3)
					{
						if (Operators.CompareString(text, "", false) == 0)
						{
							Interaction.MsgBox("Error retrieving update file", MsgBoxStyle.Exclamation, "Error:");
							return;
						}
						if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\CFW_Templates\\_old", FileAttribute.Directory), "", false) == 0)
						{
							FileSystem.MkDir(Application.StartupPath + "\\CFW_Templates\\_old");
							log_item("Creating backup _old folder...Done");
						}
						if (Operators.CompareString(string_2, "", false) != 0)
						{
							string text6 = Application.StartupPath + "\\CFW_Templates\\_old\\" + ToolboxUtilities.smethod_21(string_2);
							if (Operators.CompareString(FileSystem.Dir(text6), "", false) != 0)
							{
								FileSystem.Kill(text6);
							}
							FileSystem.FileCopy(string_2, text6);
							FileSystem.Kill(string_2);
							log_item("Backing up previous OFW file to _old subfolder...Done");
						}
						log_item("Downloading OFW Template...(This can take several minutes based on your bandwidth)");
						Application.DoEvents();
						try
						{
							webClient.DownloadFile("http://www.drivehq.com/file/df.aspx/publish/carranzafp/TBX/" + text, Application.StartupPath + "\\CFW_Templates\\" + text);
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							Interaction.MsgBox(ex6.Message, MsgBoxStyle.Exclamation, "Error:");
							ProjectData.ClearProjectError();
						}
						log_item("Downloading OFW Template...Done");
					}
					if (double_0 < num4)
					{
						if (Operators.CompareString(text2, "", false) == 0)
						{
							Interaction.MsgBox("Error retrieving update file", MsgBoxStyle.Exclamation, "Error:");
							return;
						}
						if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\CFW_Templates\\_old", FileAttribute.Directory), "", false) == 0)
						{
							FileSystem.MkDir(Application.StartupPath + "\\CFW_Templates\\_old");
							log_item("Creating backup _old folder...Done");
						}
						if (Operators.CompareString(string_3, "", false) != 0)
						{
							string text6 = Application.StartupPath + "\\CFW_Templates\\_old\\" + ToolboxUtilities.smethod_21(string_3);
							if (Operators.CompareString(FileSystem.Dir(text6), "", false) != 0)
							{
								FileSystem.Kill(text6);
							}
							FileSystem.FileCopy(string_3, text6);
							FileSystem.Kill(string_3);
							log_item("Backing up previous CFW file to _old subfolder...Done");
						}
						log_item("Downloading CFW Template...(This can take several minutes based on your bandwidth)");
						Application.DoEvents();
						try
						{
							webClient.DownloadFile("http://www.drivehq.com/file/df.aspx/publish/carranzafp/TBX/" + text2, Application.StartupPath + "\\CFW_Templates\\" + text2);
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							Interaction.MsgBox(ex8.Message, MsgBoxStyle.Exclamation, "Error:");
							ProjectData.ClearProjectError();
						}
						log_item("Downloading CFW Template...Done");
					}
					if (double_2 < num5)
					{
						if (Operators.CompareString(text3, "", false) == 0)
						{
							Interaction.MsgBox("Error retrieving update file", MsgBoxStyle.Exclamation, "Error:");
							return;
						}
						if (Operators.CompareString(FileSystem.Dir(Application.StartupPath + "\\CFW_Templates\\_old", FileAttribute.Directory), "", false) == 0)
						{
							FileSystem.MkDir(Application.StartupPath + "\\CFW_Templates\\_old");
							log_item("Creating backup _old folder...Done");
						}
						if (Operators.CompareString(string_4, "", false) != 0)
						{
							string text6 = Application.StartupPath + "\\CFW_Templates\\_old\\" + ToolboxUtilities.smethod_21(string_4);
							if (Operators.CompareString(FileSystem.Dir(text6), "", false) != 0)
							{
								FileSystem.Kill(text6);
							}
							FileSystem.FileCopy(string_4, text6);
							FileSystem.Kill(string_4);
							log_item("Backing up previous LTU file to _old subfolder...Done");
						}
						log_item("Downloading LTU Template...(This can take several minutes based on your bandwidth)");
						Application.DoEvents();
						try
						{
							webClient.DownloadFile("http://www.drivehq.com/file/df.aspx/publish/carranzafp/TBX/" + text3, Application.StartupPath + "\\CFW_Templates\\" + text3);
						}
						catch (Exception ex9)
						{
							ProjectData.SetProjectError(ex9);
							Exception ex10 = ex9;
							Interaction.MsgBox(ex10.Message, MsgBoxStyle.Exclamation, "Error:");
							ProjectData.ClearProjectError();
						}
						log_item("Downloading LTU Template...Done");
					}
					method_0();
					init_templatecombo();
				}
				else if (Interaction.MsgBox("Cannot use Online Update for templates at this time, try again later or visit our Fileset blog for manual update\r\nDo you want to visit our Fileset blog for manual update now?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Error:") == MsgBoxResult.Yes)
				{
					Process.Start("http://cfwfileset.blogspot.com");
				}
			}
			log_item("ALL DONE", "HEADER");
		}

		private bool method_59()
		{
			if (!bool_1)
			{
				Interaction.MsgBox("Please connect a Lizard and click on Get Device Details First", MsgBoxStyle.Information, "Message:");
				return false;
			}
			// Assume authorization is granted since the remote API is no longer available.
			return true;
		}

		private void GroupBox8_Enter(object sender, EventArgs e)
		{
		}

		private void Button47_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox("This option is not ready yet...", MsgBoxStyle.Information, "Sorry:");
		}

		private void method_60(object sender, EventArgs e)
		{
		}

		private void Label36_Click(object sender, EventArgs e)
		{
		}

		private void Button49_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog1.ShowNewFolderButton = true;
			DialogResult dialogResult = FolderBrowserDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				SaveFileDialog1.InitialDirectory = FolderBrowserDialog1.SelectedPath + "\\";
				SaveFileDialog1.FileName = FolderBrowserDialog1.SelectedPath + "\\xkey.cfg";
				string fileName = SaveFileDialog1.FileName;
				if (ToolboxUtilities.smethod_28(fileName))
				{
					StreamWriter streamWriter = new StreamWriter(fileName);
					streamWriter.WriteLine("######################################################");
					streamWriter.WriteLine("# XKEY CONFIGURATION FILE #");
					streamWriter.WriteLine("######################################################");
					string expression = Strings.Trim(Strings.Mid(Conversions.ToString(cmbxkeylang.SelectedItem), Strings.InStr(Conversions.ToString(cmbxkeylang.SelectedItem), "(", CompareMethod.Text)));
					expression = Strings.Replace(expression, "(", "");
					expression = Strings.Replace(expression, ")", "");
					streamWriter.WriteLine("LANGUAGE=" + expression);
					streamWriter.WriteLine(Operators.AddObject("MENUISO=", Interaction.IIf(chkxkeyMENUISO.Checked, "Y", "N")));
					streamWriter.WriteLine("SSID=" + TextBox_2.Text);
					streamWriter.WriteLine("PSK=" + TextBox_1.Text);
					streamWriter.WriteLine("KEY=" + txbxkeyUNIQUE.Text);
					streamWriter.WriteLine("######################################################");
					streamWriter.Close();
				}
			}
		}

		private void Button50_Click(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(cmbxkeydash.SelectedItem, "13599", false))
			{
				Process.Start("http://www.multiupload.com/NU75KIKAHD");
			}
		}

		private void Label37_Click(object sender, EventArgs e)
		{
		}

		private void Label40_Click(object sender, EventArgs e)
		{
		}

		private void Button48_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox("This option will generate the most accurate dummy.bin file based on your full dump\r\nPlease note the only way to guarantee a 100% true dummy is dumping directly from the Drive with Lizard", MsgBoxStyle.Information, "Note:");
			OpenFileDialog1.Filter = "Layout files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			string string_ = OpenFileDialog1.FileName;
			OpenFileDialog1.InitialDirectory = "";
			byte[] byte_ = new byte[97];
			byte[] byte_2 = new byte[97];
			byte[] byte_3 = new byte[181];
			byte[] byte_4 = new byte[81];
			byte[] byte_5 = new byte[16];
			byte[] byte_6 = new byte[4096];
			string string_2 = "";
			string string_3 = "";
			string string_4 = "";
			object obj = "";
			string string_5 = "";
			string string_6 = "";
			string string_7 = "";
			if (FirmwareUtilities.smethod_8(string_))
			{
				Interaction.MsgBox("Please select a NON-DUMMY file", MsgBoxStyle.Information, "Error:");
				return;
			}
			string string_8 = Conversions.ToString(obj);
			long long_ = default(long);
			long long_2 = default(long);
			int int_ = default(int);
			long long_3 = default(long);
			int int_2 = default(int);
			long long_4 = default(long);
			int int_3 = default(int);
			long long_5 = default(long);
			int int_4 = default(int);
			long long_6 = default(long);
			long long_7 = default(long);
			byte[] byte_7 = default(byte[]);
			long long_8 = default(long);
			byte[] byte_8 = default(byte[]);
			long long_9 = default(long);
			bool num = method_31(ref string_, ref string_2, ref string_3, ref string_4, ref string_8, ref long_, ref string_5, ref string_6, ref string_7, ref long_2, ref byte_, ref int_, ref long_3, ref byte_2, ref int_2, ref long_4, ref byte_3, ref int_3, ref long_5, ref byte_4, ref int_4, ref byte_5, ref long_6, ref byte_6, ref long_7, ref byte_7, ref long_8, ref byte_8, ref long_9);
			obj = string_8;
			if (!num)
			{
				return;
			}
			if ((Operators.CompareString(Strings.Trim(string_2), "LITEON", false) == 0) & ((Operators.CompareString(Strings.Trim(string_3), "DG16D2S", false) == 0) | (Operators.CompareString(Strings.Trim(string_3), "DG16D4S", false) == 0)))
			{
				ToolboxUtilities.smethod_13(ref byte_4, 0, 20, ref byte_3, 20);
				if (Operators.CompareString(Strings.Trim(string_3), "DG16D4S", false) == 0)
				{
					byte_3[158] = 0;
				}
				if (int_ == 52)
				{
					int_ = 56;
					byte_ = (byte[])Utils.CopyArray(byte_, new byte[56]);
				}
				ToolboxUtilities.smethod_13(ref byte_4, 40, 2, ref byte_, 52);
				ToolboxUtilities.smethod_13(ref byte_4, 76, 2, ref byte_, 54);
			}
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			if (FirmwareUtilities.smethod_45(string_2, string_3, string_4, string_, ref byte_8, ref array, ref array2))
			{
				if (byte_3.Length < 512)
				{
					byte_3 = (byte[])Utils.CopyArray(byte_3, new byte[512]);
				}
				string text = ToolboxUtilities.smethod_20(string_);
				text = Strings.Mid(text, 1, Strings.Len(text) - 1);
				SaveFileDialog1.InitialDirectory = text;
				SaveFileDialog1.CreatePrompt = false;
				SaveFileDialog1.OverwritePrompt = true;
				SaveFileDialog1.DefaultExt = "bin";
				SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
				DialogResult dialogResult2 = SaveFileDialog1.ShowDialog();
				if (dialogResult2 == DialogResult.OK && FirmwareUtilities.smethod_30(SaveFileDialog1.FileName, byte_3, byte_, int_, byte_, int_, ToolboxUtilities.cpoahSiso(Conversions.ToString(obj)), byte_4, byte_6, byte_8, array, array2))
				{
					Interaction.MsgBox("Dummy created successfully", MsgBoxStyle.Information, "Success:");
				}
			}
		}

		private void tvQolXxoXE(object sender, EventArgs e)
		{
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			OpenFileDialog1.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			OpenFileDialog1.InitialDirectory = "";
			if ((double)FileSystem.FileLen(OpenFileDialog1.FileName) / 1024.0 != 2048.0)
			{
				Interaction.MsgBox("You cannot flash iHASx24B files different than 2MB maybe u choose wrong file?", MsgBoxStyle.Exclamation, "Error");
				return;
			}
			DateTime timeOfDay = DateAndTime.TimeOfDay;
			int num = 1024;
			int num2 = (int)Math.Round((double)FileSystem.FileLen(OpenFileDialog1.FileName) / 1024.0);
			byte[] buf = new byte[1025];
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			FileStream fileStream = new FileStream(OpenFileDialog1.FileName, FileMode.Open);
			ProgressBar1.Maximum = num2 - 1;
			ProgressBar1.Value = 0;
			ProgressBar1.Visible = true;
			lblAction.Text = "Sending";
			Enabled = false;
			int num3 = num2 - 1;
			int num4 = 0;
			while (true)
			{
				if (num4 <= num3)
				{
					fileStream.Read(buf, 0, num);
					if (num4 == 0)
					{
					}
					if (num4 == 0)
					{
						send_STX();
					}
					if (liz_SERVEPAGE(num, ref buf) == 0)
					{
						ProgressBar1.Value = num4;
						num4++;
						continue;
					}
					Interaction.MsgBox("Error occurred at address " + Conversion.Hex(num4 * num), MsgBoxStyle.Exclamation, "Error:");
					break;
				}
				Convert.ToInt16(Interaction.GetSetting("LIZ_TBX", "Settings", "GLOBAL_COUNT", "0"));
				int num5 = Convert.ToInt16(Interaction.GetSetting("LIZ_TBX", "Settings", "TEMP_COUNT", "0"));
				try
				{
					Interaction.SaveSetting("LIZ_TBX", "Settings", "TEMP_COUNT", Conversions.ToString(num5 + 1));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				break;
			}
			ProgressBar1.Value = 0;
			ProgressBar1.Visible = false;
			lblAction.Text = "Idle";
			Enabled = true;
			fileStream.Close();
			SerialPort1.Close();
			DateTime timeOfDay2 = DateAndTime.TimeOfDay;
			Interaction.MsgBox("Total Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, timeOfDay, timeOfDay2)) + " secs", MsgBoxStyle.Information, "Write Complete:");
		}

		private void Button52_Click(object sender, EventArgs e)
		{
			byte[] buf = new byte[1025];
			byte[] buf2 = new byte[1025];
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 2000;
			FolderBrowserDialog1.ShowNewFolderButton = true;
			DialogResult dialogResult = FolderBrowserDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK || !chk_fulldumpoverwrite(FolderBrowserDialog1.SelectedPath + "\\source.bin"))
			{
				return;
			}
			SaveFileDialog1.InitialDirectory = FolderBrowserDialog1.SelectedPath + "\\";
			SaveFileDialog1.FileName = FolderBrowserDialog1.SelectedPath + "\\source.bin";
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			DateTime timeOfDay = DateAndTime.TimeOfDay;
			int num = 0;
			int num2 = default(int);
			while (true)
			{
				if (!method_49())
				{
					return;
				}
				send_STX();
				if (liz_GETPAGE(1024, ref buf) != 0)
				{
					if (num == 0)
					{
						bool_3 = !bool_3;
						tbmode_refreshlabel();
						num = 1;
						continue;
					}
					bool_3 = !bool_3;
					tbmode_refreshlabel();
					Interaction.MsgBox("Error occurred reading Transmission Header " + Conversions.ToString(num2), MsgBoxStyle.Exclamation, "Error:");
					break;
				}
				string fileName = SaveFileDialog1.FileName;
				FileStream fileStream = new FileStream(fileName, FileMode.Create);
				fileStream.Write(buf, 0, 1024);
				ProgressBar1.Maximum = 2047;
				ProgressBar1.Value = 0;
				ProgressBar1.Visible = true;
				lblAction.Text = "Reading";
				Enabled = false;
				int num3 = 2047;
				num2 = 1;
				while (true)
				{
					if (num2 <= num3)
					{
						if (liz_GETPAGE(1024, ref buf2) == 0)
						{
							fileStream.Write(buf2, 0, 1024);
							ProgressBar1.Value = num2;
							num2++;
							continue;
						}
						Interaction.MsgBox("Error occurred at address " + Conversion.Hex(num2 * 1024), MsgBoxStyle.Exclamation, "Error:");
						break;
					}
					fileStream.Close();
					DateTime timeOfDay2 = DateAndTime.TimeOfDay;
					Interaction.MsgBox("The File " + fileName + " has been Created\r\nTotal Time Elapsed: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, timeOfDay, timeOfDay2)) + " secs\r\nThe file will Auto-load Now on CFW Generator Tab", MsgBoxStyle.Information, "Read Complete:");
					break;
				}
				break;
			}
			ProgressBar1.Value = 0;
			ProgressBar1.Visible = false;
			lblAction.Text = "Idle";
			Enabled = true;
			SerialPort1.Close();
		}

		private void btn_msload_Click(object sender, EventArgs e)
		{
			if (TreeView1.SelectedNode == null)
			{
				return;
			}
			int index = TreeView1.SelectedNode.Index;
			if (struct5_0[index].byte_0 != byte.MaxValue)
			{
				if (Interaction.MsgBox("Do you want overwrite current slot data on your Lizard?\r\n(Data cannot be recovered)", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Confirm:") != MsgBoxResult.Yes)
				{
					return;
				}
				slot_erase(index, false);
			}
			slot_backup_to_lizard(index);
		}

		private void Label45_Click(object sender, EventArgs e)
		{
		}

		private void Button53_Click(object sender, EventArgs e)
		{
			int num = 32768;
			bool flag = false;
			int num2 = (int)Math.Round(7.0);
			for (int i = 0; i <= num2; i++)
			{
				byte[] array = HitachiKeyScrambler.smethod_7("c:\\bank0.bin", i * num, num, true);
				ToolboxUtilities.smethod_9(ref array, num, "c:\\bank0-d.bin", flag);
				flag = true;
			}
		}

		private void uEsoPgKroV(object sender, EventArgs e)
		{
			string[] portNames = SerialPort.GetPortNames();
			int num = 0;
			string text;
			while (true)
			{
				if (num < portNames.Length)
				{
					text = portNames[num];
					lblAction.Text = "Scanning " + text;
					Application.DoEvents();
					if (cmd_TEST_PRESENCE(text) == 0)
					{
						break;
					}
					num++;
					continue;
				}
				lblAction.Text = "Lizard Not Found on COM Ports";
				return;
			}
			lblAction.Text = "Found at " + text;
			ToolStripStatusLabel_0.Text = text;
			method_24();
		}

		public int cmd_TEST_PRESENCE(string sComName)
		{
			SerialPort1.PortName = sComName;
			SerialPort1.BaudRate = 115200;
			SerialPort1.WriteTimeout = 100;
			SerialPort1.ReadTimeout = 100;
			byte[] array = new byte[4];
			byte[] buf = new byte[11];
			PortClose();
			int result;
			if (!method_11())
			{
				result = 1;
			}
			else
			{
				array[0] = 64;
				array[1] = 85;
				array[2] = 90;
				array[3] = 64;
				try
				{
					SerialPort1.Write(array, 0, 4);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					result = 2;
					ProjectData.ClearProjectError();
					goto IL_00a8;
				}
				result = ((!ReadUSARTw_to(ref buf, 3)) ? 4 : ((buf[2] != 6) ? 3 : 0));
			}
			goto IL_00a8;
			IL_00a8:
			try
			{
				SerialPort1.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private void COM1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void Label48_Click(object sender, EventArgs e)
		{
		}

		private void Label49_Click(object sender, EventArgs e)
		{
		}

		private void Label50_Click(object sender, EventArgs e)
		{
		}

		private void Label51_Click(object sender, EventArgs e)
		{
		}

		private void Button59_Click(object sender, EventArgs e)
		{
			byte[] buf = new byte[513];
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			SerialPort SerPort = SerialPort1;
			byte errstat = default(byte);
			byte num = LIZ_ATA_CMD(ref SerPort, 161, 0, 512, ref buf, ref errstat);
			SerialPort1 = SerPort;
			byte b = num;
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATA CMD, return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
			}
			SerPort = SerialPort1;
			byte num2 = LIZ_ATA_CMD(ref SerPort, 161, 0, 512, ref buf, ref errstat, true);
			SerialPort1 = SerPort;
			b = num2;
			if (b == 0)
			{
				send_ETX();
				Clipboard.Clear();
				Clipboard.SetText(ToolboxUtilities.smethod_5(ref buf, 512));
				Interaction.MsgBox(ToolboxUtilities.smethod_5(ref buf, 512), MsgBoxStyle.Information, "Success (err stat)" + Conversion.Hex(errstat) + ":");
			}
			else
			{
				Interaction.MsgBox("Error Executing ATA CMD, return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
			}
			PortClose();
		}

		private void Button60_Click(object sender, EventArgs e)
		{
			byte[] buf = new byte[513];
			byte[] array = new byte[12];
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			array = ToolboxUtilities.cpoahSiso("1200000074C0000000000000");
			SerialPort SerPort = SerialPort1;
			byte errstat = default(byte);
			byte sense = default(byte);
			byte num = LIZ_ATAPI_CMD(ref SerPort, array, 0, 116, 0, ref buf, ref errstat, ref sense);
			SerialPort1 = SerPort;
			byte b = num;
			if (b == 0)
			{
				send_ETX();
				Interaction.MsgBox(ToolboxUtilities.smethod_5(ref buf, 116), MsgBoxStyle.Information, "Success (ErrStat:" + Conversion.Hex(errstat) + ", Sense:" + Conversion.Hex(sense) + "):");
				Clipboard.Clear();
				Clipboard.SetText(ToolboxUtilities.smethod_5(ref buf, 116));
			}
			else
			{
				Interaction.MsgBox("Error Executing ATAPI CMD, return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
			}
			PortClose();
		}

		private void Button61_Click(object sender, EventArgs e)
		{
			byte[] buf = new byte[513];
			byte[] array = new byte[12];
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			array = ToolboxUtilities.cpoahSiso("030000001200000000000000");
			SerialPort SerPort = SerialPort1;
			byte errstat = default(byte);
			byte sense = default(byte);
			byte num = LIZ_ATAPI_CMD(ref SerPort, array, 0, 18, 0, ref buf, ref errstat, ref sense);
			SerialPort1 = SerPort;
			byte b = num;
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
			}
			array = ToolboxUtilities.cpoahSiso("5A002500000000001A000000");
			SerPort = SerialPort1;
			byte num2 = LIZ_ATAPI_CMD(ref SerPort, array, 0, 26, 0, ref buf, ref errstat, ref sense, true);
			SerialPort1 = SerPort;
			b = num2;
			if (b == 0)
			{
				send_ETX();
				Interaction.MsgBox(ToolboxUtilities.smethod_5(ref buf, 26), MsgBoxStyle.Information, "Success (ErrStat:" + Conversion.Hex(errstat) + ", Sense:" + Conversion.Hex(sense) + "):");
				Clipboard.Clear();
				Clipboard.SetText(ToolboxUtilities.smethod_5(ref buf, 26));
			}
			else
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
			}
			PortClose();
		}

		private void Button30_Click(object sender, EventArgs e)
		{
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] array = new byte[16];
			byte b = 0;
			array = ToolboxUtilities.cpoahSiso("5E7AEB70769F7347F8B3419903FFF8E5");
			bool bisvalid = false;
			byte num = LIZ_CHKKEY(ref array, ref bisvalid);
			b = (byte)(0u - (bisvalid ? 1u : 0u));
			byte b2 = num;
			if (b2 == 0)
			{
				if (b != 0)
				{
					Interaction.MsgBox("Key Match [" + ToolboxUtilities.smethod_5(ref array) + "]", MsgBoxStyle.Information, "Match");
				}
				else
				{
					Interaction.MsgBox("Key Not Match [" + ToolboxUtilities.smethod_5(ref array) + "]", MsgBoxStyle.Exclamation, "Not Match");
				}
				send_ETX();
			}
			else
			{
				Interaction.MsgBox("Error checking key, return code:" + Conversions.ToString(b2), MsgBoxStyle.Exclamation, "Error");
			}
			PortClose();
		}

		private void lthoGsqhyQ(object sender, EventArgs e)
		{
			byte[] array = new byte[64];
			byte[] array2 = new byte[16];
			byte[] array3 = new byte[array.GetLength(0) - 1 + 1];
			byte[] array4 = new byte[array.GetLength(0) - 1 + 1];
			int num = array.GetLength(0) - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Math.Round(VBMath.Rnd() * 256f);
			}
			array = ToolboxUtilities.cpoahSiso("a0a1a2a3a4a5a6a7a8a9aaabacadaeafb0b1b2b3b4b5b6b7b8b9babbbcbdbebfc0c1c2c3c4c5c6c7c8c9cacbcccdcecfd0d1d2d3d4d5d6d7d8d9dadbdcdddedf");
			ToolboxUtilities.cpoahSiso("8ce82eefbea0da3c44699ed7db51b7d9");
			array2 = ToolboxUtilities.cpoahSiso("56e47a38c5598974bc46903dba290349");
			array = ToolboxUtilities.cpoahSiso("6bc1bee22e409f96e93d7e117393172aae2d8a571e03ac9c9eb76fac45af8e5130c81c46a35ce411e5fbc1191a0a52eff69f2445df4f9b17ad2b417be66c3710");
			ToolboxUtilities.cpoahSiso("00000000000000000000000000000000");
			array2 = ToolboxUtilities.cpoahSiso("2b7e151628aed2a6abf7158809cf4f3c");
			array3 = AesCrypto.smethod_2(array, array2);
			array4 = AesCrypto.utmuBufTB(array3, array2);
			string text = ToolboxUtilities.smethod_24(ref array, 0, array.GetLength(0), 16, true, "Orig Buffer") + "\r\n";
			text = text + ToolboxUtilities.smethod_24(ref array3, 0, array.GetLength(0), 16, true, "Encrypted Buffer") + "\r\n";
			text += ToolboxUtilities.smethod_24(ref array4, 0, array.GetLength(0), 16, true, "Round Trip Buffer");
			Clipboard.Clear();
			Clipboard.SetText(text);
			if (ToolboxUtilities.smethod_16(ref array, 0, array.GetLength(0), ref array4, 0))
			{
				Interaction.MsgBox("Both Buffer Match!", MsgBoxStyle.Information, "Success");
			}
			else
			{
				Interaction.MsgBox("Both Buffer Differ!", MsgBoxStyle.Exclamation, "Failure");
			}
		}

		public void AESECBMAC(byte[] DVDKey, byte[] ShiftData, ref byte[] Mac)
		{
			byte[] array = new byte[16];
			byte[] array2 = new byte[16];
			byte[] array3 = new byte[16];
			ToolboxUtilities.smethod_13(ref ShiftData, 0, 16, ref array, 0);
			array2 = ToolboxUtilities.cpoahSiso("00000000000000000000000000000001");
			ToolboxUtilities.smethod_13(ref DVDKey, 0, 16, ref Mac, 0);
			int num = 0;
			do
			{
				array2[0] = (byte)(array2[0] << 1);
				array2[0] = (byte)(array2[0] | ((array2[1] & 0x80) >> 7));
				array2[1] = (byte)(array2[1] << 1);
				array2[1] = (byte)(array2[1] | ((array2[2] & 0x80) >> 7));
				array2[2] = (byte)(array2[2] << 1);
				array2[2] = (byte)(array2[2] | ((array2[3] & 0x80) >> 7));
				array2[3] = (byte)(array2[3] << 1);
				array2[3] = (byte)(array2[3] | ((array2[4] & 0x80) >> 7));
				array2[4] = (byte)(array2[4] << 1);
				array2[4] = (byte)(array2[4] | ((array2[5] & 0x80) >> 7));
				array2[5] = (byte)(array2[5] << 1);
				array2[5] = (byte)(array2[5] | ((array2[6] & 0x80) >> 7));
				array2[6] = (byte)(array2[6] << 1);
				array2[6] = (byte)(array2[6] | ((array2[7] & 0x80) >> 7));
				array2[7] = (byte)(array2[7] << 1);
				array2[7] = (byte)(array2[7] | ((array2[8] & 0x80) >> 7));
				array2[8] = (byte)(array2[8] << 1);
				array2[8] = (byte)(array2[8] | ((array2[9] & 0x80) >> 7));
				array2[9] = (byte)(array2[9] << 1);
				array2[9] = (byte)(array2[9] | ((array2[10] & 0x80) >> 7));
				array2[10] = (byte)(array2[10] << 1);
				array2[10] = (byte)(array2[10] | ((array2[11] & 0x80) >> 7));
				array2[11] = (byte)(array2[11] << 1);
				array2[11] = (byte)(array2[11] | ((array2[12] & 0x80) >> 7));
				array2[12] = (byte)(array2[12] << 1);
				array2[12] = (byte)(array2[12] | ((array2[13] & 0x80) >> 7));
				array2[13] = (byte)(array2[13] << 1);
				array2[13] = (byte)(array2[13] | ((array2[14] & 0x80) >> 7));
				array2[14] = (byte)(array2[14] << 1);
				array2[14] = (byte)(array2[14] | ((array2[15] & 0x80) >> 7));
				array2[15] = (byte)(array2[15] << 1);
				array2[15] = (byte)(array2[15] | ((array[0] & 0x80) >> 7));
				array[0] = (byte)(array[0] << 1);
				array[0] = (byte)(array[0] | ((array[1] & 0x80) >> 7));
				array[1] = (byte)(array[1] << 1);
				array[1] = (byte)(array[1] | ((array[2] & 0x80) >> 7));
				array[2] = (byte)(array[2] << 1);
				array[2] = (byte)(array[2] | ((array[3] & 0x80) >> 7));
				array[3] = (byte)(array[3] << 1);
				array[3] = (byte)(array[3] | ((array[4] & 0x80) >> 7));
				array[4] = (byte)(array[4] << 1);
				array[4] = (byte)(array[4] | ((array[5] & 0x80) >> 7));
				array[5] = (byte)(array[5] << 1);
				array[5] = (byte)(array[5] | ((array[6] & 0x80) >> 7));
				array[6] = (byte)(array[6] << 1);
				array[6] = (byte)(array[6] | ((array[7] & 0x80) >> 7));
				array[7] = (byte)(array[7] << 1);
				array[7] = (byte)(array[7] | ((array[8] & 0x80) >> 7));
				array[8] = (byte)(array[8] << 1);
				array[8] = (byte)(array[8] | ((array[9] & 0x80) >> 7));
				array[9] = (byte)(array[9] << 1);
				array[9] = (byte)(array[9] | ((array[10] & 0x80) >> 7));
				array[10] = (byte)(array[10] << 1);
				array[10] = (byte)(array[10] | ((array[11] & 0x80) >> 7));
				array[11] = (byte)(array[11] << 1);
				array[11] = (byte)(array[11] | ((array[12] & 0x80) >> 7));
				array[12] = (byte)(array[12] << 1);
				array[12] = (byte)(array[12] | ((array[13] & 0x80) >> 7));
				array[13] = (byte)(array[13] << 1);
				array[13] = (byte)(array[13] | ((array[14] & 0x80) >> 7));
				array[14] = (byte)(array[14] << 1);
				array[14] = (byte)(array[14] | ((array[15] & 0x80) >> 7));
				array[15] = (byte)(array[15] << 1);
				array3 = Mac;
				Mac = AesCrypto.smethod_2(array2, array3);
				num++;
			}
			while (num <= 127);
		}

		public void AESEBCGENUINE(byte[] bKeysbuff, ref byte[] boutseed)
		{
			byte[] array = new byte[16];
			byte[] array2 = new byte[16];
			byte[] array3 = new byte[16];
			array3 = ToolboxUtilities.cpoahSiso("47454E55494E452058424F58204F4444");
			ToolboxUtilities.smethod_13(ref bKeysbuff, 0, 16, ref array, 0);
			ToolboxUtilities.smethod_13(ref array3, 0, 16, ref array2, 0);
			array2 = AesCrypto.smethod_2(array2, array);
			array2 = ToolboxUtilities.smethod_15(ref array2, array3);
			ToolboxUtilities.smethod_13(ref bKeysbuff, 16, 16, ref array, 0);
			ToolboxUtilities.smethod_13(ref array2, 0, 16, ref boutseed, 0);
			array2 = AesCrypto.smethod_2(array2, array);
			boutseed = ToolboxUtilities.smethod_15(ref boutseed, array2);
		}

		private void Button63_Click(object sender, EventArgs e)
		{
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] array = ToolboxUtilities.cpoahSiso("69C573502DE35E24B92271D78C56B64F");
			array = ToolboxUtilities.cpoahSiso("5E7AEB70769F7347F8B3419903FFF8E5");
			ToolboxUtilities.byte_0 = ToolboxUtilities.cpoahSiso("BEBECAFEBEBECAFEBEBECAFEBEBECAFE");
			ToolboxUtilities.byte_1 = ToolboxUtilities.cpoahSiso("DEADBEEFDEADBEEFDEADBEEFDEADBEEF");
			SerialPort SerPort = SerialPort1;
			bool num = DRIVE_AUTH28(ref SerPort, array, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1);
			SerialPort1 = SerPort;
			if (num)
			{
				Interaction.MsgBox("Verification Succeed, DVD Key Match!", MsgBoxStyle.Information, "Success:");
			}
			else
			{
				Interaction.MsgBox("Verification Failed, Seems Wrong DVD!", MsgBoxStyle.Exclamation, "Failure:");
			}
			PortClose();
		}

		private void Button64_Click(object sender, EventArgs e)
		{
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] bDVDKey = ToolboxUtilities.cpoahSiso("5E7AEB70769F7347F8B3419903FFF8E5");
			ToolboxUtilities.byte_0 = ToolboxUtilities.cpoahSiso("BEBECAFEBEBECAFEBEBECAFEBEBECAFE");
			ToolboxUtilities.byte_1 = ToolboxUtilities.cpoahSiso("DEADBEEFDEADBEEFDEADBEEFDEADBEEF");
			SerialPort SerPort = SerialPort1;
			bool num = DRIVE_AUTH3B(ref SerPort, bDVDKey, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1);
			SerialPort1 = SerPort;
			if (num)
			{
				Interaction.MsgBox("Verification Succeed, DVD Key Match!", MsgBoxStyle.Information, "Success:");
			}
			else
			{
				Interaction.MsgBox("Verification Failed, Seems Wrong DVD!", MsgBoxStyle.Exclamation, "Failure:");
			}
			PortClose();
		}

		public bool DRIVE_AUTH28(ref SerialPort SerPort, byte[] bDVDKey, byte[] bSessKey, byte[] bXORKey)
		{
			byte[] array = new byte[16];
			byte[] Mac = new byte[16];
			byte[] boutseed = new byte[16];
			byte[] array2 = new byte[16];
			byte[] Mac2 = new byte[16];
			byte[] array3 = new byte[74];
			byte[] buf = new byte[74];
			byte[] array4 = new byte[32];
			ToolboxUtilities.smethod_19(ref array2, 0, 16, 0);
			array = ToolboxUtilities.smethod_14(16);
			AESECBMAC(bDVDKey, bXORKey, ref Mac);
			byte[] array5 = ToolboxUtilities.cpoahSiso("00480000000000002840");
			ToolboxUtilities.smethod_13(ref array5, 0, 10, ref array3, 0);
			ToolboxUtilities.smethod_13(ref bSessKey, 0, 16, ref array3, 10);
			ToolboxUtilities.smethod_13(ref array, 0, 16, ref array3, 26);
			ToolboxUtilities.smethod_13(ref bXORKey, 0, 16, ref array3, 42);
			ToolboxUtilities.smethod_13(ref array3, 0, 58, ref buf, 0);
			ToolboxUtilities.smethod_13(ref array3, 10, 32, ref array4, 0);
			array4 = AesCrypto.smethod_0(array4, Mac, bXORKey);
			ToolboxUtilities.smethod_13(ref array4, 0, 32, ref buf, 10);
			AESEBCGENUINE(array4, ref boutseed);
			AESECBMAC(Mac, boutseed, ref Mac2);
			ToolboxUtilities.smethod_13(ref Mac2, 0, 16, ref buf, 58);
			byte[] buf2 = new byte[513];
			byte[] array6 = new byte[12];
			array6 = ToolboxUtilities.cpoahSiso("030000001200000000000000");
			byte errstat = default(byte);
			byte sense = default(byte);
			byte b = LIZ_ATAPI_CMD(ref SerPort, array6, 0, 18, 0, ref buf2, ref errstat, ref sense);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array6) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			string text = "CMD: " + ToolboxUtilities.smethod_5(ref array6) + " Returned : 0x" + Conversion.Hex(errstat) + " Sense: 0x" + Conversion.Hex(sense) + "\r\n";
			array6 = ToolboxUtilities.cpoahSiso("55000000000000004C000000");
			b = LIZ_ATAPI_CMD(ref SerPort, array6, 1, 0, 74, ref buf, ref errstat, ref sense, true);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array6) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			array6 = ToolboxUtilities.cpoahSiso("5A002800000000003A000000");
			b = LIZ_ATAPI_CMD(ref SerPort, array6, 0, 58, 0, ref buf2, ref errstat, ref sense, true);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array6) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			send_ETX();
			ToolboxUtilities.smethod_13(ref buf2, 0, 58, ref array3, 0);
			ToolboxUtilities.smethod_13(ref buf2, 10, 32, ref array4, 0);
			array4 = AesCrypto.smethod_1(array4, bSessKey, bXORKey);
			ToolboxUtilities.smethod_13(ref array4, 0, 32, ref array3, 10);
			text = text + ToolboxUtilities.smethod_24(ref array3, 0, 10, 16, true, "PAYLOAD HEADER:") + "\r\n";
			text = text + ToolboxUtilities.smethod_24(ref array3, 10, 48, 16, true, "CLEAR REPLY PAGE:") + "\r\n";
			if (!ToolboxUtilities.smethod_16(ref array3, 10, 16, ref array2, 0) | !ToolboxUtilities.smethod_16(ref array3, 26, 16, ref array, 0))
			{
				return false;
			}
			return true;
		}

		public bool DRIVE_SETKEY_BB(ref SerialPort SerPort, byte[] bDVDKey)
		{
			byte[] array = new byte[74];
			byte[] buf = new byte[74];
			byte[] array2 = ToolboxUtilities.cpoahSiso("0000000000000000BB30000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
			ToolboxUtilities.smethod_13(ref array2, 0, 10, ref array, 0);
			ToolboxUtilities.smethod_13(ref bDVDKey, 0, 16, ref array, 10);
			string text = ToolboxUtilities.smethod_24(ref array, 0, 10, 16, true, "PAYLOAD HEADER:") + "\r\n";
			text = text + ToolboxUtilities.smethod_24(ref array, 10, 48, 16, true, "CLEAR DATA:") + "\r\n";
			ToolboxUtilities.smethod_13(ref array, 0, 26, ref buf, 0);
			text = text + ToolboxUtilities.smethod_24(ref buf, 0, 10, 16, true, "PAYLOAD HEADER:") + "\r\n";
			text += ToolboxUtilities.smethod_24(ref buf, 10, 48, 16, true, "ENCRYPTED DATA:");
			byte[] buf2 = new byte[513];
			byte[] array3 = new byte[12];
			array3 = ToolboxUtilities.cpoahSiso("030000001200000000000000");
			byte errstat = default(byte);
			byte sense = default(byte);
			byte b = LIZ_ATAPI_CMD(ref SerPort, array3, 0, 18, 0, ref buf2, ref errstat, ref sense);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array3) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			array3 = ToolboxUtilities.cpoahSiso("55000000000000003C000000");
			b = LIZ_ATAPI_CMD(ref SerPort, array3, 1, 0, 58, ref buf, ref errstat, ref sense, true);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array3) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			text = text + "CMD: " + ToolboxUtilities.smethod_5(ref array3) + " Returned : 0x" + Conversion.Hex(errstat) + " Sense: 0x" + Conversion.Hex(sense) + "\r\n";
			send_ETX();
			Clipboard.Clear();
			Clipboard.SetText(text);
			return true;
		}

		public bool DRIVE_AUTH3B(ref SerialPort SerPort, byte[] bDVDKey, byte[] bSessKey, byte[] bXORKey)
		{
			byte[] array = new byte[16];
			byte[] array2 = new byte[74];
			byte[] buf = new byte[74];
			byte[] array3 = new byte[16];
			byte[] array4 = new byte[16];
			array = ToolboxUtilities.smethod_14(16);
			byte[] array5 = ToolboxUtilities.cpoahSiso("00000000000000003B30");
			ToolboxUtilities.smethod_13(ref array5, 0, 10, ref array2, 0);
			ToolboxUtilities.smethod_13(ref bSessKey, 0, 16, ref array2, 10);
			ToolboxUtilities.smethod_13(ref array, 0, 16, ref array2, 26);
			ToolboxUtilities.smethod_13(ref bXORKey, 0, 16, ref array2, 42);
			ToolboxUtilities.smethod_13(ref array2, 0, 58, ref buf, 0);
			array3 = ToolboxUtilities.smethod_15(ref bSessKey, bXORKey);
			array3 = AesCrypto.smethod_2(array3, bDVDKey);
			ToolboxUtilities.smethod_13(ref array3, 0, 16, ref buf, 10);
			array3 = ToolboxUtilities.smethod_15(ref array, array3);
			array3 = AesCrypto.smethod_2(array3, bDVDKey);
			ToolboxUtilities.smethod_13(ref array3, 0, 16, ref buf, 26);
			byte[] buf2 = new byte[513];
			byte[] array6 = new byte[12];
			array6 = ToolboxUtilities.cpoahSiso("030000001200000000000000");
			byte errstat = default(byte);
			byte sense = default(byte);
			byte b = LIZ_ATAPI_CMD(ref SerPort, array6, 0, 18, 0, ref buf2, ref errstat, ref sense);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array6) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			array6 = ToolboxUtilities.cpoahSiso("55000000000000003C000000");
			b = LIZ_ATAPI_CMD(ref SerPort, array6, 1, 0, 74, ref buf, ref errstat, ref sense, true);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array6) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			array6 = ToolboxUtilities.cpoahSiso("5A003B00000000003A000000");
			b = LIZ_ATAPI_CMD(ref SerPort, array6, 0, 58, 0, ref buf2, ref errstat, ref sense, true);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array6) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			send_ETX();
			ToolboxUtilities.smethod_13(ref buf2, 0, 58, ref array2, 0);
			ToolboxUtilities.smethod_13(ref array2, 26, 16, ref array3, 0);
			ToolboxUtilities.smethod_13(ref array2, 10, 16, ref array4, 0);
			array3 = AesCrypto.utmuBufTB(array3, bSessKey);
			array3 = ToolboxUtilities.smethod_15(ref array3, array4);
			ToolboxUtilities.smethod_13(ref array3, 0, 16, ref array2, 26);
			if (!ToolboxUtilities.smethod_16(ref array2, 26, 16, ref array, 0))
			{
				return false;
			}
			return true;
		}

		public bool DRIVE_DRAMDUMP(ref SerialPort SerPort, byte[] bSessKey, byte[] bXORKey, long lAddress, ref byte[] buff)
		{
			byte[] array = new byte[58];
			byte[] array2 = new byte[58];
			byte[] array3 = new byte[48];
			byte[] array4 = new byte[16];
			byte[] array5 = ToolboxUtilities.cpoahSiso("00380000000000002130");
			ToolboxUtilities.smethod_13(ref array5, 0, 10, ref array, 0);
			ToolboxUtilities.smethod_13(ref bSessKey, 0, 16, ref array, 10);
			ToolboxUtilities.smethod_19(ref array, 26, 32, 0);
			array[42] = 4;
			array[46] = (byte)((lAddress >> 24) & 0xFFL);
			array[47] = (byte)((lAddress >> 16) & 0xFFL);
			array[48] = (byte)((lAddress >> 8) & 0xFFL);
			array[49] = (byte)(lAddress & 0xFFL);
			array[53] = 16;
			ToolboxUtilities.smethod_13(ref array, 10, 48, ref array3, 0);
			array3 = AesCrypto.smethod_0(array3, bSessKey, bXORKey);
			array2 = array;
			ToolboxUtilities.smethod_13(ref array3, 0, 48, ref array2, 10);
			byte[] buf = new byte[513];
			byte[] array6 = new byte[12];
			array6 = ToolboxUtilities.cpoahSiso("030000001200000000000000");
			byte errstat = default(byte);
			byte sense = default(byte);
			byte b = LIZ_ATAPI_CMD(ref SerPort, array6, 0, 18, 0, ref buf, ref errstat, ref sense);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array6) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			array6 = ToolboxUtilities.cpoahSiso("55000000000000003C000000");
			b = LIZ_ATAPI_CMD(ref SerPort, array6, 1, 0, 58, ref array2, ref errstat, ref sense, true);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array6) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			array6 = ToolboxUtilities.cpoahSiso("5A002100000000003A000000");
			b = LIZ_ATAPI_CMD(ref SerPort, array6, 0, 58, 0, ref buf, ref errstat, ref sense, true);
			if (b != 0)
			{
				Interaction.MsgBox("Error Executing ATAPI CMD (" + ToolboxUtilities.smethod_5(ref array6) + "), return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
				return false;
			}
			send_ETX();
			ToolboxUtilities.smethod_13(ref buf, 10, 32, ref array3, 0);
			array3 = AesCrypto.smethod_1(array3, bSessKey, bXORKey);
			ToolboxUtilities.smethod_13(ref array3, 16, 16, ref array4, 0);
			array4 = AesCrypto.smethod_1(array4, bSessKey, ToolboxUtilities.cpoahSiso("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"));
			array4 = AesCrypto.smethod_1(array4, bSessKey, ToolboxUtilities.cpoahSiso("00000000000000000000000000000000"));
			buff = array4;
			return true;
		}

		private void Button65_Click(object sender, EventArgs e)
		{
			byte[] buff = new byte[16];
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			ToolboxUtilities.byte_0 = ToolboxUtilities.cpoahSiso("BEBECAFEBEBECAFEBEBECAFEBEBECAFE");
			ToolboxUtilities.byte_1 = ToolboxUtilities.cpoahSiso("DEADBEEFDEADBEEFDEADBEEFDEADBEEF");
			string text = "";
			int num = 0;
			while (true)
			{
				SerialPort SerPort = SerialPort1;
				bool num2 = DRIVE_DRAMDUMP(ref SerPort, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1, num + 198798, ref buff);
				SerialPort1 = SerPort;
				if (!num2)
				{
					break;
				}
				text = text + ToolboxUtilities.smethod_5(ref buff) + "\r\n";
				num += 16;
				if (num > 319)
				{
					Clipboard.Clear();
					Clipboard.SetText(text);
					PortClose();
					return;
				}
			}
			Interaction.MsgBox("Cant Get Data", MsgBoxStyle.Exclamation, "Failure:");
		}

		private void Button56_Click(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "keybin files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
				if (FileSystem.FileLen(fileName) != 16L)
				{
					Interaction.MsgBox("The Key file must be 16 byte size", MsgBoxStyle.Exclamation, "Error:");
				}
				else
				{
					txbLTU_key.Text = fileName;
				}
			}
		}

		private void Button55_Click(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "C-R files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
				txbLTU_cr.Text = fileName;
			}
		}

		private void Button57_Click(object sender, EventArgs e)
		{
			byte[] buf = new byte[513];
			byte[] array = new byte[12];
			byte[] bDVDKey = new byte[16];
			byte[] buff = new byte[16];
			byte[] array2 = new byte[320];
			byte_6 = new byte[256];
			ToolboxUtilities.smethod_19(ref byte_6, 0, byte_6.GetLength(0), 0);
			ToolboxUtilities.smethod_19(ref byte_6, 0, 112, byte.MaxValue);
			ToolboxUtilities.smethod_19(ref byte_6, 0, 20, 32);
			if (Operators.CompareString(txbLTU_key.Text, "REQUIRED", false) == 0)
			{
				Interaction.MsgBox("Please enter your key.bin file before continue", MsgBoxStyle.Information, "Error:");
			}
			else
			{
				if (Interaction.MsgBox("Attach your Original Drive (or only the drive board) to your Lizard\r\n(If you dont have it skip this step)\r\nPress OK to Continue", MsgBoxStyle.OkCancel | MsgBoxStyle.Information, "Note:") == MsgBoxResult.Cancel)
				{
					return;
				}
				int_1 = 115200;
				PortClose();
				SerialPort1.PortName = ToolStripStatusLabel_0.Text;
				SerialPort1.BaudRate = int_1;
				SerialPort1.WriteTimeout = 1000;
				SerialPort1.ReadTimeout = 5000;
				bool_1 = false;
				if (!method_11())
				{
					Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				SerialPort SerPort = SerialPort1;
				byte errstat = default(byte);
				byte num = LIZ_ATA_CMD(ref SerPort, 161, 0, 512, ref buf, ref errstat);
				SerialPort1 = SerPort;
				byte b = num;
				if (b != 0)
				{
					Interaction.MsgBox("Error Executing ATA CMD, return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
					return;
				}
				send_ETX();
				array = ToolboxUtilities.cpoahSiso("1200000074C0000000000000");
				SerPort = SerialPort1;
				byte sense = default(byte);
				byte num2 = LIZ_ATAPI_CMD(ref SerPort, array, 0, 116, 0, ref buf, ref errstat, ref sense);
				SerialPort1 = SerPort;
				b = num2;
				if (b != 0)
				{
					Interaction.MsgBox("Error Executing ATAPI CMD, return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
					return;
				}
				send_ETX();
				ToolboxUtilities.smethod_13(ref buf, 96, 20, ref byte_6, 0);
				string left = "";
				string_9 = FirmwareUtilities.smethod_21(ToolboxUtilities.smethod_1(ref buf), ref left);
				if (Operators.CompareString(left, "", false) != 0)
				{
					Interaction.MsgBox("Cant Get the Vendor of the Drive Inquiry", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				string_10 = FirmwareUtilities.smethod_22(ToolboxUtilities.smethod_1(ref buf), string_9, ref left);
				if (Operators.CompareString(left, "", false) != 0)
				{
					Interaction.MsgBox("Cant Get the Model of the Drive Inquiry", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				string_11 = FirmwareUtilities.smethod_24(ToolboxUtilities.smethod_1(ref buf), string_9, string_10, ref left);
				if (Operators.CompareString(left, "", false) != 0)
				{
					Interaction.MsgBox("Cant Get the ROM of the Drive Inquiry", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				string text = Strings.Trim(string_9) + "-" + Strings.Trim(string_10);
				switch (text)
				{
				case "LITEON-DG16D4S":
				{
					ToolboxUtilities.smethod_11(ref bDVDKey, txbLTU_key.Text, 0L, 16);
					ToolboxUtilities.byte_0 = ToolboxUtilities.cpoahSiso("BEBECAFEBEBECAFEBEBECAFEBEBECAFE");
					ToolboxUtilities.byte_1 = ToolboxUtilities.cpoahSiso("DEADBEEFDEADBEEFDEADBEEFDEADBEEF");
					ProgressBar1.Maximum = 20;
					ProgressBar1.Value = 0;
					ProgressBar1.Visible = true;
					lblAction.Text = "Reading";
					Enabled = false;
					SerPort = SerialPort1;
					bool num6 = DRIVE_AUTH3B(ref SerPort, bDVDKey, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1);
					SerialPort1 = SerPort;
					if (num6)
					{
						int num7 = 0;
						do
						{
							SerPort = SerialPort1;
							bool num8 = DRIVE_DRAMDUMP(ref SerPort, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1, num7 + 198798, ref buff);
							SerialPort1 = SerPort;
							if (num8)
							{
								ToolboxUtilities.smethod_13(ref buff, 0, 16, ref array2, num7);
								Application.DoEvents();
								ProgressBar1.Value = (int)Math.Round((double)num7 / 16.0);
								num7 += 16;
								continue;
							}
							Interaction.MsgBox("Cant Get Data", MsgBoxStyle.Exclamation, "Failure:");
							ProgressBar1.Value = 0;
							ProgressBar1.Visible = false;
							lblAction.Text = "Idle";
							Enabled = true;
							return;
						}
						while (num7 <= 319);
						ToolboxUtilities.smethod_13(ref array2, 96, 54, ref byte_6, 24);
						txbLTU_Unique.Text = "CAPTURED";
						ProgressBar1.Value = 0;
						ProgressBar1.Visible = false;
						lblAction.Text = "Idle";
						Enabled = true;
						goto IL_0738;
					}
					Interaction.MsgBox("Verification Failed, Seems Wrong DVD!", MsgBoxStyle.Exclamation, "Failure:");
					ProgressBar1.Value = 0;
					ProgressBar1.Visible = false;
					lblAction.Text = "Idle";
					Enabled = true;
					break;
				}
				case "LITEON-DG16D5S":
				{
					ToolboxUtilities.smethod_11(ref bDVDKey, txbLTU_key.Text, 0L, 16);
					ToolboxUtilities.byte_0 = ToolboxUtilities.cpoahSiso("BEBECAFEBEBECAFEBEBECAFEBEBECAFE");
					ToolboxUtilities.byte_1 = ToolboxUtilities.cpoahSiso("DEADBEEFDEADBEEFDEADBEEFDEADBEEF");
					ProgressBar1.Maximum = 20;
					ProgressBar1.Value = 0;
					ProgressBar1.Visible = true;
					lblAction.Text = "Reading";
					Enabled = false;
					SerPort = SerialPort1;
					bool num3 = DRIVE_AUTH28(ref SerPort, bDVDKey, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1);
					SerialPort1 = SerPort;
					if (num3)
					{
						int num4 = 0;
						do
						{
							SerPort = SerialPort1;
							bool num5 = DRIVE_DRAMDUMP(ref SerPort, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1, num4 + 198798, ref buff);
							SerialPort1 = SerPort;
							if (num5)
							{
								ToolboxUtilities.smethod_13(ref buff, 0, 16, ref array2, num4);
								Application.DoEvents();
								ProgressBar1.Value = (int)Math.Round((double)num4 / 16.0);
								num4 += 16;
								continue;
							}
							Interaction.MsgBox("Cant Get Data", MsgBoxStyle.Exclamation, "Failure:");
							ProgressBar1.Value = 0;
							ProgressBar1.Visible = false;
							lblAction.Text = "Idle";
							Enabled = true;
							return;
						}
						while (num4 <= 319);
						ToolboxUtilities.smethod_13(ref array2, 74, 54, ref byte_6, 24);
						ToolboxUtilities.smethod_13(ref array2, 162, 96, ref byte_6, 128);
						ToolboxUtilities.smethod_13(ref array2, 258, 16, ref byte_6, 240);
						txbLTU_Unique.Text = "CAPTURED";
						ProgressBar1.Value = 0;
						ProgressBar1.Visible = false;
						lblAction.Text = "Idle";
						Enabled = true;
						goto IL_0738;
					}
					Interaction.MsgBox("Verification Failed, Seems Wrong DVD!", MsgBoxStyle.Exclamation, "Failure:");
					ProgressBar1.Value = 0;
					ProgressBar1.Visible = false;
					lblAction.Text = "Idle";
					Enabled = true;
					break;
				}
				case "HITACHI-DL10N":
					txbLTU_Unique.Text = "CAPTURED";
					goto IL_0738;
				default:
					{
						Interaction.MsgBox("Extract Unique Data for Drives of type " + text + " Not Implemented Yet, you can Skip this Step for Now", MsgBoxStyle.Information, "Not Ready");
						break;
					}
					IL_0738:
					PortClose();
					break;
				}
			}
		}

		private void cmbLTUFileset_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int num = cmbLTUFileset.SelectedIndex - 1;
				CfwTemplateParser.smethod_1(struct3_0[num].string_3, ref struct4_0, ref int_5);
				cmbLTUTemplate.Items.Clear();
				int num2 = int_5 - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (Operators.CompareString(struct4_0[i].string_0, "LTUMT1332E", false) == 0)
					{
						cmbLTUTemplate.Items.Add(Strings.Trim(struct4_0[i].string_3) + "-" + Strings.Trim(struct4_0[i].string_4) + "-" + Strings.Trim(struct4_0[i].string_5));
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void cmbLTU2Fileset_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int num = cmbLTU2Fileset.SelectedIndex - 1;
				CfwTemplateParser.smethod_1(struct3_0[num].string_3, ref struct4_0, ref int_5);
				cmbLTU2Template.Items.Clear();
				int num2 = int_5 - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (Operators.CompareString(struct4_0[i].string_0, "LTUMT1319E", false) == 0)
					{
						cmbLTU2Template.Items.Add(Strings.Trim(struct4_0[i].string_3) + "-" + Strings.Trim(struct4_0[i].string_4) + "-" + Strings.Trim(struct4_0[i].string_5));
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void Button58_Click(object sender, EventArgs e)
		{
			Generate_LTU();
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void Generate_LTU()
		{
			int num = (int)FileSystem.FileLen(Application.StartupPath + "\\crxt.bin");
			if (Operators.CompareString(txbLTU_key.Text, "REQUIRED", false) == 0)
			{
				Interaction.MsgBox("Enter your Key.bin File", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (Operators.CompareString(txbLTU_cr.Text, "REQUIRED", false) == 0)
			{
				Interaction.MsgBox("Enter your C-R.bin File", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if ((Operators.CompareString(cmbLTUFileset.Text, "", false) == 0) | (Operators.CompareString(cmbLTUFileset.Text, "[SELECT]", false) == 0))
			{
				Interaction.MsgBox("Choose a Fileset that contains LTU firmware", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (Operators.CompareString(cmbLTUTemplate.Text, "", false) == 0)
			{
				Interaction.MsgBox("Choose a Fileset/Template for LTU firmware", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (FileSystem.FileLen(txbLTU_cr.Text) != num)
			{
				Interaction.MsgBox("The C-R File must be have a Size of " + num + " bytes", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			int num2 = cmbLTUFileset.SelectedIndex - 1;
			CfwTemplateParser.smethod_1(struct3_0[num2].string_3, ref struct4_0, ref int_5);
			if (int_5 == 0)
			{
				Interaction.MsgBox("No TOC Entries found on the Fileset " + struct3_0[num2].string_3, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string text = cmbLTUTemplate.Text;
			bool flag = false;
			int num3 = int_5 - 1;
			int i;
			for (i = 0; i <= num3; i++)
			{
				if (Operators.CompareString(struct4_0[i].string_0, "LTUMT1332E", false) == 0)
				{
					string right = Strings.Trim(struct4_0[i].string_3) + "-" + Strings.Trim(struct4_0[i].string_4) + "-" + Strings.Trim(struct4_0[i].string_5);
					if (Operators.CompareString(text, right, false) == 0)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				Interaction.MsgBox("No TOC Entries found to generate a LTU-MT133E for " + text + " firmware on the Selected Fileset\r\nTry to get updated Fileset", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string text2 = Application.StartupPath + "\\temp.tmp";
			if (!ToolboxUtilities.smethod_8(struct3_0[num2].string_3, text2, 33792L + struct4_0[i].long_1, struct4_0[i].long_0))
			{
				Interaction.MsgBox("The temporary file cannot be created, check the application is on folder with write privileges\r\nIf problem persist make sure you use latest Fileset Templates", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] array = new byte[16];
			string prompt = "";
			if (ToolboxUtilities.smethod_11(ref array, txbLTU_key.Text, 0L, 16) < 0)
			{
				Interaction.MsgBox("Cant Read Key File contents", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (!GraphDllCrypto.smethod_12(text2, 126960L, 16, true, ref prompt, array))
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] array2 = new byte[num - 1 + 1];
			if (ToolboxUtilities.smethod_11(ref array2, Application.StartupPath + "\\crxt.bin", 0L, num) < num)
			{
				Interaction.MsgBox("Cant Read crxt.bin File contents", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] array3 = new byte[num - 1 + 1];
			if (ToolboxUtilities.smethod_11(ref array3, txbLTU_cr.Text, 0L, num) < num)
			{
				Interaction.MsgBox("Cant Read the specified C-R file contents", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			array3 = ToolboxUtilities.smethod_15(ref array2, array3);
			FirmwareUtilities.smethod_36(text2, 62464L, 3059, array3);
			FirmwareUtilities.smethod_36(text2, 127488L, 3572, array3, 3059);
			FirmwareUtilities.smethod_36(text2, 193024L, 2907, array3, 6631);
			if (Operators.CompareString(txbLTU_Unique.Text, "CAPTURED", false) == 0)
			{
				switch (Strings.Trim(string_9) + "-" + Strings.Trim(string_10))
				{
				case "LITEON-DG16D4S":
					FirmwareUtilities.smethod_36(text2, 261888L, 112, byte_6);
					break;
				case "LITEON-DG16D5S":
					FirmwareUtilities.smethod_36(text2, 261888L, 112, byte_6);
					FirmwareUtilities.smethod_36(text2, 262016L, 96, byte_6, 128);
					FirmwareUtilities.smethod_36(text2, 262128L, 16, byte_6, 240);
					break;
				case "HITACHI-DL10N":
					FirmwareUtilities.smethod_36(text2, 261888L, 20, byte_6);
					break;
				}
			}
			SaveFileDialog1.CreatePrompt = false;
			SaveFileDialog1.OverwritePrompt = true;
			SaveFileDialog1.FileName = Strings.Trim(struct4_0[i].string_3) + "_LTU";
			SaveFileDialog1.DefaultExt = "bin";
			SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
			DialogResult dialogResult = SaveFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				FileSystem.FileCopy(text2, SaveFileDialog1.FileName);
			}
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void Generate_LTU2()
		{
			int num = (int)FileSystem.FileLen(Application.StartupPath + "\\crxt.bin");
			if (Operators.CompareString(TxbLTU2_key.Text, "REQUIRED", false) == 0)
			{
				Interaction.MsgBox("Enter your Key.bin File", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (Operators.CompareString(TxbLTU2_cr.Text, "REQUIRED", false) == 0)
			{
				Interaction.MsgBox("Enter your C-R.bin File", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if ((Operators.CompareString(cmbLTU2Fileset.Text, "", false) == 0) | (Operators.CompareString(cmbLTU2Fileset.Text, "[SELECT]", false) == 0))
			{
				Interaction.MsgBox("Choose a Fileset that contains LTUv2 firmware", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (Operators.CompareString(cmbLTU2Template.Text, "", false) == 0)
			{
				Interaction.MsgBox("Choose a Fileset/Template for LTUv2 firmware", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (FileSystem.FileLen(TxbLTU2_cr.Text) != num)
			{
				Interaction.MsgBox("The C-R File must be have a Size of " + num + " bytes", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			int num2 = cmbLTU2Fileset.SelectedIndex - 1;
			CfwTemplateParser.smethod_1(struct3_0[num2].string_3, ref struct4_0, ref int_5);
			if (int_5 == 0)
			{
				Interaction.MsgBox("No TOC Entries found on the Fileset " + struct3_0[num2].string_3, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string text = cmbLTU2Template.Text;
			bool flag = false;
			int num3 = int_5 - 1;
			int i;
			for (i = 0; i <= num3; i++)
			{
				if (Operators.CompareString(struct4_0[i].string_0, "LTUMT1319E", false) == 0)
				{
					string right = Strings.Trim(struct4_0[i].string_3) + "-" + Strings.Trim(struct4_0[i].string_4) + "-" + Strings.Trim(struct4_0[i].string_5);
					if (Operators.CompareString(text, right, false) == 0)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				Interaction.MsgBox("No TOC Entries found to generate a LTUv2 for " + text + " firmware on the Selected Fileset\r\nTry to get updated Fileset", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			string text2 = Application.StartupPath + "\\temp.tmp";
			if (!ToolboxUtilities.smethod_8(struct3_0[num2].string_3, text2, 33792L + struct4_0[i].long_1, struct4_0[i].long_0))
			{
				Interaction.MsgBox("The temporary file cannot be created, check the application is on folder with write privileges\r\nIf problem persist make sure you use latest Fileset Templates", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] array = new byte[16];
			string prompt = "";
			if (ToolboxUtilities.smethod_11(ref array, TxbLTU2_key.Text, 0L, 16) < 0)
			{
				Interaction.MsgBox("Cant Read Key File contents", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			if (!FirmwareUtilities.smethod_18(struct4_0[i].string_0, struct4_0[i].string_1, struct4_0[i].string_2, text2, ref prompt, 114688L, ToolboxUtilities.smethod_5(ref array)))
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] array2 = new byte[num - 1 + 1];
			if (ToolboxUtilities.smethod_11(ref array2, TxbLTU2_cr.Text, 0L, num) < num)
			{
				Interaction.MsgBox("Cant Read the specified C-R file contents", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			FirmwareUtilities.smethod_36(text2, 186624L, 9538, array2);
			SaveFileDialog1.CreatePrompt = false;
			SaveFileDialog1.OverwritePrompt = true;
			SaveFileDialog1.FileName = Strings.Trim(struct4_0[i].string_3) + "_LTU";
			SaveFileDialog1.DefaultExt = "bin";
			SaveFileDialog1.Filter = "BIN files (*.bin)|*.bin";
			DialogResult dialogResult = SaveFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				FileSystem.FileCopy(text2, SaveFileDialog1.FileName);
			}
		}

		private void Button67_Click(object sender, EventArgs e)
		{
			byte[] buf = new byte[513];
			byte[] array = new byte[12];
			byte[] array2 = new byte[16];
			if (Strings.Len(txbEV_SrcKey.Text) != 32)
			{
				Interaction.MsgBox("Load a File first", MsgBoxStyle.Exclamation, "Error:");
			}
			else
			{
				if (Interaction.MsgBox("Attach your Drive to your Lizard\r\nPress OK to Continue", MsgBoxStyle.OkCancel | MsgBoxStyle.Information, "Note:") == MsgBoxResult.Cancel)
				{
					return;
				}
				int_1 = 115200;
				PortClose();
				SerialPort1.PortName = ToolStripStatusLabel_0.Text;
				SerialPort1.BaudRate = int_1;
				SerialPort1.WriteTimeout = 1000;
				SerialPort1.ReadTimeout = 5000;
				bool_1 = false;
				if (!method_11())
				{
					Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				SerialPort SerPort = SerialPort1;
				byte errstat = default(byte);
				byte num = LIZ_ATA_CMD(ref SerPort, 161, 0, 512, ref buf, ref errstat);
				SerialPort1 = SerPort;
				byte b = num;
				if (b != 0)
				{
					Interaction.MsgBox("Error Executing ATA CMD, return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
					return;
				}
				send_ETX();
				array = ToolboxUtilities.cpoahSiso("1200000074C0000000000000");
				SerPort = SerialPort1;
				byte sense = default(byte);
				byte num2 = LIZ_ATAPI_CMD(ref SerPort, array, 0, 116, 0, ref buf, ref errstat, ref sense);
				SerialPort1 = SerPort;
				b = num2;
				if (b != 0)
				{
					Interaction.MsgBox("Error Executing ATAPI CMD, return code:" + Conversions.ToString(b), MsgBoxStyle.Exclamation, "Error");
					return;
				}
				send_ETX();
				string left = "";
				string str = FirmwareUtilities.smethod_21(ToolboxUtilities.smethod_1(ref buf), ref left);
				if (Operators.CompareString(left, "", false) != 0)
				{
					Interaction.MsgBox("Cant Get the Vendor of the Drive Inquiry", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				string str2 = FirmwareUtilities.smethod_22(ToolboxUtilities.smethod_1(ref buf), string_9, ref left);
				if (Operators.CompareString(left, "", false) != 0)
				{
					Interaction.MsgBox("Cant Get the Model of the Drive Inquiry", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				FirmwareUtilities.smethod_24(ToolboxUtilities.smethod_1(ref buf), string_9, string_10, ref left);
				if (Operators.CompareString(left, "", false) != 0)
				{
					Interaction.MsgBox("Cant Get the ROM of the Drive Inquiry", MsgBoxStyle.Exclamation, "Error:");
					return;
				}
				array2 = ToolboxUtilities.cpoahSiso(txbEV_SrcKey.Text);
				ToolboxUtilities.byte_0 = ToolboxUtilities.cpoahSiso("BEBECAFEBEBECAFEBEBECAFEBEBECAFE");
				ToolboxUtilities.byte_1 = ToolboxUtilities.cpoahSiso("DEADBEEFDEADBEEFDEADBEEFDEADBEEF");
				string text = Strings.Trim(str) + "-" + Strings.Trim(str2);
				switch (text)
				{
				case "BENQ-VAD6038":
				{
					SerPort = SerialPort1;
					bool num4 = DRIVE_AUTH3B(ref SerPort, array2, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1);
					SerialPort1 = SerPort;
					if (num4)
					{
						Interaction.MsgBox("Verification Succeed, DVD Key Match the one in the Drive", MsgBoxStyle.Information, "Success:");
					}
					else
					{
						Interaction.MsgBox("Verification Failed, Seems Wrong DVD!", MsgBoxStyle.Exclamation, "Failure:");
					}
					break;
				}
				case "LITEON-DG16D2S":
				{
					SerPort = SerialPort1;
					bool num7 = DRIVE_AUTH3B(ref SerPort, array2, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1);
					SerialPort1 = SerPort;
					if (num7)
					{
						Interaction.MsgBox("Verification Succeed, DVD Key Match the one in the Drive", MsgBoxStyle.Information, "Success:");
					}
					else
					{
						Interaction.MsgBox("Verification Failed, Seems Wrong DVD!", MsgBoxStyle.Exclamation, "Failure:");
					}
					break;
				}
				case "LITEON-DG16D4S":
				{
					SerPort = SerialPort1;
					bool num5 = DRIVE_AUTH3B(ref SerPort, array2, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1);
					SerialPort1 = SerPort;
					if (num5)
					{
						Interaction.MsgBox("Verification Succeed, DVD Key Match the one in the Drive", MsgBoxStyle.Information, "Success:");
					}
					else
					{
						Interaction.MsgBox("Verification Failed, Seems Wrong DVD!", MsgBoxStyle.Exclamation, "Failure:");
					}
					break;
				}
				case "LITEON-DG16D5S":
				{
					SerPort = SerialPort1;
					bool num6 = DRIVE_AUTH28(ref SerPort, array2, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1);
					SerialPort1 = SerPort;
					if (num6)
					{
						Interaction.MsgBox("Verification Succeed, DVD Key Match the one in the Drive", MsgBoxStyle.Information, "Success:");
					}
					else
					{
						Interaction.MsgBox("Verification Failed, Seems Wrong DVD!", MsgBoxStyle.Exclamation, "Failure:");
					}
					break;
				}
				case "HITACHI-DL10N":
				{
					SerPort = SerialPort1;
					bool num3 = DRIVE_AUTH28(ref SerPort, array2, ToolboxUtilities.byte_0, ToolboxUtilities.byte_1);
					SerialPort1 = SerPort;
					if (num3)
					{
						Interaction.MsgBox("Verification Succeed, DVD Key Match the one in the Drive", MsgBoxStyle.Information, "Success:");
					}
					else
					{
						Interaction.MsgBox("Verification Failed, Seems Wrong DVD!", MsgBoxStyle.Exclamation, "Failure:");
					}
					break;
				}
				default:
					Interaction.MsgBox("DVD Key Verification for Drives of type " + text + " Not Implemented Yet", MsgBoxStyle.Information, "Not Ready");
					break;
				}
				PortClose();
			}
		}

		private void Button66_Click(object sender, EventArgs e)
		{
			int_1 = 115200;
			PortClose();
			SerialPort1.PortName = ToolStripStatusLabel_0.Text;
			SerialPort1.BaudRate = int_1;
			SerialPort1.WriteTimeout = 1000;
			SerialPort1.ReadTimeout = 5000;
			bool_1 = false;
			if (!method_11())
			{
				Interaction.MsgBox("Cannot Open COM Port, select a valid port", MsgBoxStyle.Exclamation, "Error:");
				return;
			}
			byte[] bDVDKey = ToolboxUtilities.cpoahSiso("5E7AEB70769F7347F8B3419903FFF8E5");
			SerialPort SerPort = SerialPort1;
			bool num = DRIVE_SETKEY_BB(ref SerPort, bDVDKey);
			SerialPort1 = SerPort;
			if (num)
			{
				Interaction.MsgBox("Write Key Succeed!", MsgBoxStyle.Information, "Success:");
			}
			else
			{
				Interaction.MsgBox("Write Key Failed!", MsgBoxStyle.Exclamation, "Failure:");
			}
			PortClose();
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void Button68_Click(object sender, EventArgs e)
		{
			string text = "Z:\\LTUv2\\000031330543\\fcrt_dec.bin";
			txbLTU_cr.Text = text;
			ToolboxUtilities.Struct6[] array = new ToolboxUtilities.Struct6[502];
			if (Operators.CompareString(FileSystem.Dir(text), "", false) == 0)
			{
				Interaction.MsgBox("File " + text + " does not exists", MsgBoxStyle.Exclamation, "Error");
				return;
			}
			int num = (int)FileSystem.FileLen(text);
			if (num < 16384)
			{
				Interaction.MsgBox("File " + text + " does not have the required size", MsgBoxStyle.Exclamation, "Error");
				return;
			}
			FileStream fileStream = new FileStream(text, FileMode.Open);
			fileStream.Seek(320L, SeekOrigin.Begin);
			int num2 = 0;
			do
			{
				array[num2].byte_0 = ToolboxUtilities.cpoahSiso("00000000000000000000000000000000");
				array[num2].byte_1 = ToolboxUtilities.cpoahSiso("00000000000000000000000000000000");
				fileStream.Read(array[num2].byte_0, 0, 16);
				fileStream.Read(array[num2].byte_1, 0, 16);
				num2++;
			}
			while (num2 <= 501);
			fileStream.Close();
			string text2 = "";
			num2 = 0;
			do
			{
				text2 = text2 + ToolboxUtilities.smethod_2(array[num2].byte_0[0]) + ToolboxUtilities.smethod_2(array[num2].byte_0[1]) + ToolboxUtilities.smethod_2(array[num2].byte_0[15]) + "-" + ToolboxUtilities.smethod_5(ref array[num2].byte_1, 16) + "\r\n";
				num2++;
			}
			while (num2 <= 501);
			Clipboard.Clear();
			Clipboard.SetText(text2);
		}

		private void cmbLTUTemplate_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void Button70_Click(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "keybin files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
				if (FileSystem.FileLen(fileName) != 16L)
				{
					Interaction.MsgBox("The Key file must be 16 byte size", MsgBoxStyle.Exclamation, "Error:");
				}
				else
				{
					TxbLTU2_key.Text = fileName;
				}
			}
		}

		private void Button69_Click(object sender, EventArgs e)
		{
			OpenFileDialog1.Filter = "C-R files (*.bin)|*.bin|All files (*.*)|*.*";
			OpenFileDialog1.FileName = "";
			DialogResult dialogResult = OpenFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = OpenFileDialog1.FileName;
				OpenFileDialog1.InitialDirectory = "";
				TxbLTU2_cr.Text = fileName;
			}
		}

		private void Button71_Click(object sender, EventArgs e)
		{
			Generate_LTU2();
		}
	}
}

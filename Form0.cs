using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "10.0.0.0")]
internal class Form0 : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		MyProject.Application.Run(args);
	}

	[DebuggerStepThrough]
	public Form0()
		: base(AuthenticationMode.Windows)
	{
		IsSingleInstance = false;
		EnableVisualStyles = true;
		SaveMySettingsOnExit = true;
		ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		MainForm = MyProject.Forms.Form1;
	}
}

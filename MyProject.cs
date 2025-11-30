using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Lzard_TBX_NET40;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[GeneratedCode("MyTemplate", "10.0.0.0")]
[StandardModule]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyForms
	{
		public Form1 _form1Instance;

		[ThreadStatic]
		private static Hashtable _formBeingCreated;

		[SpecialName]
		public Form1 Form1
		{
			[DebuggerHidden]
			get
			{
				_form1Instance = CreateInstance(_form1Instance);
				return _form1Instance;
			}
			[DebuggerHidden]
			set
			{
				if (value != _form1Instance)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					DisposeInstance(ref _form1Instance);
				}
			}
		}

		[DebuggerHidden]
		private static T CreateInstance<T>(T instance) where T : Form, new()
		{
			if (instance != null && !instance.IsDisposed)
			{
				return instance;
			}
			if (_formBeingCreated != null)
			{
				if (_formBeingCreated.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
				}
			}
			else
			{
				_formBeingCreated = new Hashtable();
			}
			_formBeingCreated.Add(typeof(T), null);
			try
			{
				return new T();
			}
			catch (TargetInvocationException ex) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError(ex);
				return ex.InnerException != null;
			}).Invoke())
			{
				string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
				throw new InvalidOperationException(resourceString, ex.InnerException);
			}
			finally
			{
				_formBeingCreated.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void DisposeInstance<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type GetFormType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T _instance;

		[SpecialName]
		[DebuggerHidden]
		internal T GetInstance()
		{
			if (_instance == null)
			{
				_instance = new T();
			}
			return _instance;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> _computerProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<Form0> _applicationProvider = new ThreadSafeObjectProvider<Form0>();

	private static ThreadSafeObjectProvider<MyForms> _formsProvider = new ThreadSafeObjectProvider<MyForms>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return _computerProvider.GetInstance();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Application
	{
		[DebuggerHidden]
		get
		{
			return _applicationProvider.GetInstance();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return _formsProvider.GetInstance();
		}
	}
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1378
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------




//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace NorthwindApp
{
	namespace My
	{

		//NOTE: This file is auto-generated; do not modify it directly.  To make changes,
		// or if you encounter build errors in this file, go to the Project Designer
		// (go to Project Properties or double-click the My Project node in
		// Solution Explorer), and make changes on the Application tab.
		//
		internal partial class MyApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
		{

			[global::System.Diagnostics.DebuggerStepThroughAttribute()]
			public MyApplication() : base(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
			{
				this.IsSingleInstance = false;
				this.EnableVisualStyles = true;
				this.SaveMySettingsOnExit = true;
				this.ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;
			}

			[global::System.Diagnostics.DebuggerStepThroughAttribute()]
			protected override void OnCreateMainForm()
			{
                this.MainForm = global::CSDynamicallyBuildLambdaExpressionWithField.MainForm.DefaultInstance;
			}

			private static MyApplication MyApp;
			internal static MyApplication Application
			{
				get
				{
					return MyApp;
				}
			}

			[STAThread]
			static void Main(string[] args)
			{
				System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
				MyApp = new MyApplication();
				MyApp.Run(args);
			}

		}
	}

}
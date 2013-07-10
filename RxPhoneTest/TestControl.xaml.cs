using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ReactiveUI;

namespace RxPhoneTest
{
	public partial class TestControl : UserControl
	{
		public TestControl()
		{
			InitializeComponent();
			if (DesignModeDetector.IsInDesignMode())
				AmIDesign.Text = "Yes!";
			else
				AmIDesign.Text = "No!";
		}
	}
}

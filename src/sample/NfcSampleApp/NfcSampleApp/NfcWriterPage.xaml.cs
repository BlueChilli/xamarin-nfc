﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NfcSampleApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NfcWriterPage : ContentPage
	{
		public NfcWriterPage ()
		{
			InitializeComponent ();

            this.Title = "Write";
		}
	}
}
using System;
using System.Collections.Generic;
using ExcelFilesCreator.ViewModels;
using Xamarin.Forms;

namespace ExcelFilesCreator.Views
{
    public partial class ExportingEPage : ContentPage
    {
        public ExportingEPage()
        {
            InitializeComponent();
            BindingContext = new ExportingExcelViewModel();
        }
    }
}

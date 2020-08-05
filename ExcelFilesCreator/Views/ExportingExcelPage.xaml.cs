using System;
using System.Collections.Generic;
using ExcelFilesCreator.ViewModels;
using Xamarin.Forms;

namespace ExcelFilesCreator.Views
{
    public partial class ExportingExcelPage : ContentPage
    {
        public ExportingExcelPage()
        {
            InitializeComponent();
            BindingContext = new ExportingExcelViewModel();
        }
    }
}

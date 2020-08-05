using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using ExcelFilesCreator.Models;
using ExcelFilesCreator.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ExcelFilesCreator.ViewModels
{
    public class ExportingExcelViewModel
    {
        public  ICommand ExportToExcelCommand { private set; get; }
        private ExcelService excelService;
        public  ObservableCollection<Contacts> contacts;
        

        public ExportingExcelViewModel()
        {
            contacts = new ObservableCollection<Contacts>
            {
                new Contacts{  Name="Leomaris", LastName="Reyes",   Telephone="8093334434" },
                new Contacts{  Name="Leo",      LastName="Rosario", Telephone="8294445565" },
                new Contacts{  Name="Mary",     LastName="Mendez",  Telephone="8093334434" }, 
            };

            ExportToExcelCommand = new Command(async () => await ExportToExcel());
            excelService = new ExcelService();
        }

        async Task ExportToExcel()
        { 
            var fileName = $"Contacts-{Guid.NewGuid()}.xlsx";
            string filepath = excelService.GenerateExcel(fileName);

            var data = new ExcelStructure
            {
                Headers = new List<string>() { "Name", "Lastname", "Telephone" }
            };

            foreach (var item in contacts)
            { 
                data.Values.Add(new List<string>() { item.Name, item.LastName, item.Telephone });
            }

            excelService.InsertDataIntoSheet(filepath, "Contacts",data);

            await Launcher.OpenAsync(new OpenFileRequest()
            {
                File = new ReadOnlyFile(filepath)
            });
        }

        
    }
}

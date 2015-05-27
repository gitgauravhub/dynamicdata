using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;

namespace TestWpfApplication.ViewModels
{
    internal class FileListViewModel : NotificationObject
    {
        private ObservableCollection<string> _fileList;
        private string _selectedFile;

        public FileListViewModel()
        {
            InitializeCommand = new DelegateCommand(Initialize);
        }

        public DelegateCommand InitializeCommand { get; private set; }

        public ObservableCollection<string> FileList
        {
            get { return _fileList; }
            set
            {
                if (value == _fileList)
                    return;

                _fileList = value;
                RaisePropertyChanged(() => FileList);
            }
        }

        public string SelectedFile
        {
            get { return _selectedFile; }
            set
            {
                if (value == _selectedFile)
                    return;

                _selectedFile = value;
                RaisePropertyChanged(() => SelectedFile);

                //we only use single line of code to trigger event
                FileSelectedGlobalEvent.Instance.Publish(value);
            }
        }

        public void Initialize()
        {
            var files = Directory.GetFiles(GlobalVariables.RootPath)
                                 .Select(Path.GetFileName)
                                 .OrderBy(q => q)
                                 .ToList();

            FileList = new ObservableCollection<string>(files);
        }
    }
}
using System;
using System.IO;
using Microsoft.Practices.Prism.ViewModel;

namespace TestWpfApplication.ViewModels
{
    internal class FileInfoViewModel : NotificationObject
    {
        private DateTime _createdDate;
        private string _fileName;
        private DateTime _updatedDate;

        public FileInfoViewModel()
        {
            FileSelectedGlobalEvent.Instance.Subscribe(ProcessFile);
        }

        public string FileName
        {
            get { return _fileName; }
            set
            {
                if (value == _fileName)
                    return;

                _fileName = value;
                RaisePropertyChanged(() => FileName);
            }
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                if (value == _createdDate)
                    return;

                _createdDate = value;
                RaisePropertyChanged(() => CreatedDate);
            }
        }

        public DateTime UpdatedDate
        {
            get { return _updatedDate; }
            set
            {
                if (value == _updatedDate)
                    return;

                _updatedDate = value;
                RaisePropertyChanged(() => UpdatedDate);
            }
        }

        private void ProcessFile(string fileName)
        {
            var fileInfo = new FileInfo(Path.Combine(GlobalVariables.RootPath, fileName));

            FileName = fileName;
            CreatedDate = fileInfo.CreationTime;
            UpdatedDate = fileInfo.LastWriteTime;
        }
    }
}
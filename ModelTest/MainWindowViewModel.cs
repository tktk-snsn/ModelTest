using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTest
{
    public class MainWindowViewModel: ObservableObject
    {
        private PersonModel _model;
        public PersonModel Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }


        private string _message = "default";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public MainWindowViewModel()
        {
            _model = new PersonModel
            {
                Val = 5,
                Seed = 2.0,
            };
            Model.PropertyChanged += Model_PropertyChanged;
        }

        private void Model_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            /// sender: PersonModel, e.PropertyName: 変更されたプロパティ名
            if (e.PropertyName == nameof(Model.Seed))
                return;
            UpdateMessage();
        }

        private void UpdateMessage()
        {
            Message = $"Value = {Model.Val}, Seed = {Model.Seed}";
        }
    }
}

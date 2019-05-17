﻿using Models;
using Models.Implementations;
using MVVM_Base;
using MVVM_Base.Implementations;
using System.Windows.Input;

namespace ViewModels.MockViewModels
{
    public class MockMainPageViewModel : IMainPageViewModel
    {
        public MockMainPageViewModel()
        {
            Images = new RangeObservableCollection<IPhotoModel>
            {
                new PhotoModel { ImagePath = @"TestImages/leopard1.jpg" },
                new PhotoModel { ImagePath = @"TestImages/leopard2.jpg" }
            };
        }

        public ICommand SettingsCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand ImportCommand { get; }
        public ICommand EditCommand { get; }
        public IPhotoModel SelectedPhoto { get; set; }
        public IRangeObservableCollection<IPhotoModel> Images { get; }
    }
}
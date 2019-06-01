﻿using Models.Implementations;
using MVVM_Base;
using System;
using System.Windows.Input;
using Windows.UI.Xaml.Input;

namespace ViewModels.Implementations
{
    public class RedundantPhotoViewModel : ViewModelBase<RedundantPhotoModel>, IRedundantPhotoViewModel
    {
        public string ImageName
        {
            get => Model.ImageName;
            set
            {
                if (value == Model.ImageName) return;

                Model.ImageName = value;
                OnPropertyChanged();
            }
        }

        public string ImagePath
        {
            get => Model.ImagePath;
            set
            {
                if (value == Model.ImagePath) return;

                Model.ImagePath = value;
                OnPropertyChanged();
            }
        }

        public float Similarity
        {
            get => Model.Similarity;
            set
            {
                if (Math.Abs(value - Model.Similarity) < 0.2) return;

                Model.Similarity = value;
                OnPropertyChanged();
            }
        }

        public ICommand DeleteCommand { get; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public ViewModelBase()
        {
        }

        private string title = string.Empty;
        public const string TitlePropertyName = "Title";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
        private string subtitle = string.Empty;
        public const string SubtitlePropertyName = "Subtitle";
        public string Subtitle
        {
            get { return subtitle; }
            set { SetProperty(ref subtitle, value); }
        }

        private string icon = null;
        public const string IconPropertyName = "Icon";
        public string Icon
        {
            get { return icon; }
            set { SetProperty(ref icon, value); }
        }

        bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                if (SetProperty(ref isBusy, value))
                    IsNotBusy = !isBusy;
            }
        }
        private bool busyIndicator = false;
        public bool BusyIndicator
        {
            get
            {
                return busyIndicator;
            }
            set
            {
                busyIndicator = value;
                OnPropertyChanged("BusyIndicator");
            }
        }
        private bool bottomIndicator = false;
        public bool BottomIndicator
        {
            get { return bottomIndicator; }
            set
            {
                bottomIndicator = value;
                OnPropertyChanged("BottomIndicator");
            }
        }

        private bool disablePicker = true;
        public bool DisablePicker
        {
            get { return disablePicker; }
            set
            {
                disablePicker = value;
                OnPropertyChanged("DisablePicker");
            }
        }
        bool isNotBusy = true;
        public bool IsNotBusy
        {
            get { return isNotBusy; }
            private set { SetProperty(ref isNotBusy, value); }
        }
        private bool canLoadMore = true;
        public const string CanLoadMorePropertyName = "CanLoadMore";
        public bool CanLoadMore
        {
            get { return canLoadMore; }
            set { SetProperty(ref canLoadMore, value); }
        }
        protected bool SetProperty<T>(
            ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;

            if (onChanged != null)
                onChanged();

            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;
            changed(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

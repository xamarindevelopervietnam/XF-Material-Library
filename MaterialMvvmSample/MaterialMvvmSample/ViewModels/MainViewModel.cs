﻿using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XF.Material.Forms.Dialogs;

namespace MaterialMvvmSample.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            this.SelectedJobs.CollectionChanged += this.SelectedJobs_CollectionChanged;
        }

        private void SelectedJobs_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach(var item in this.SelectedJobs)
            {
                System.Diagnostics.Debug.WriteLine(this.Jobs[item]);
            }
        }

        public string[] Jobs => new string[] { "Developer", "QA Engineer", "Team Leader" };

        public ICommand ButtonCommand => new Command(async () => await this.SelectJobsAsync());

        private int _selectedJobIndex = 1;
        public int SelectedJobIndex
        {
            get => _selectedJobIndex;
            set => this.Set(ref _selectedJobIndex, value);
        }

        private ObservableCollection<int> _selectedJobs = new ObservableCollection<int>();
        public ObservableCollection<int> SelectedJobs
        {
            get => _selectedJobs;
            set => this.Set(ref _selectedJobs, value);
        }

        private async Task SelectJobsAsync()
        {
            var result = await MaterialDialog.Instance.SelectChoicesAsync("Select any", this.Jobs);

            foreach (var ind in result)
            {
                System.Diagnostics.Debug.WriteLine(this.Jobs[ind]);
            }
        } 

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if(propertyName == nameof(this.SelectedJobIndex))
            {
                System.Diagnostics.Debug.WriteLine("Selected: " + this.Jobs[this.SelectedJobIndex]);
            }
        }
    }
}

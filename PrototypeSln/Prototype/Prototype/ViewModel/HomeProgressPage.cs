using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Text;
using MvvmHelpers;
using Prototype.View;
using Prototype.Model;
using MvvmHelpers.Commands;

namespace Prototype.ViewModel
{
    /// <summary>
    /// This page refers to the dummy data from ChildProgress.cs.
    /// Actually now that i think about it...
    /// The dummy data is actually on this page.
    /// The ChildProgress is housing the necessaties for the app display anything.
    /// </summary>

    public class HomeProgressPage : ViewModelBase
    {
        /// <summary>
        /// Thanks to the MvvmHelpers, I was able to display the data
        /// without having to populate the listview in the xaml page.
        /// </summary>

        public ObservableRangeCollection<ChildProgress> ChildProgress { get; set; }
        public ObservableRangeCollection<Grouping<string, ChildProgress>> ChildGroups { get; set; }
        public AsyncCommand RefreshCommand { get; set; }
        public HomeProgressPage()
        {
            Title = "asdfasdfasdf";

            ChildProgress = new ObservableRangeCollection<ChildProgress>();
            ChildGroups = new ObservableRangeCollection<Grouping<string, ChildProgress>>();

            var icon = "user.png";

            ChildProgress.Add(new ChildProgress { ID = 0, ChildName = "Child 1", ProgressBar = 0.5, Icon = icon });
            ChildProgress.Add(new ChildProgress { ID = 1, ChildName = "Child 2", ProgressBar = 0.4, Icon = icon });

            RefreshCommand = new AsyncCommand(Refresh);
        }

        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
        }
    }
}

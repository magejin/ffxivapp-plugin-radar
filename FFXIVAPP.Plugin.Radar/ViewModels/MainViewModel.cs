﻿// FFXIVAPP.Plugin.Radar ~ MainViewModel.cs
// 
// Copyright © 2007 - 2016 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using FFXIVAPP.Common.RegularExpressions;
using FFXIVAPP.Common.Utilities;
using FFXIVAPP.Common.ViewModelBase;
using FFXIVAPP.Memory.Core.Enums;
using FFXIVAPP.Plugin.Radar.Models;
using FFXIVAPP.Plugin.Radar.Properties;
using FFXIVAPP.Plugin.Radar.Views;
using NLog;

namespace FFXIVAPP.Plugin.Radar.ViewModels
{
    internal sealed class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            AddOrUpdateFilterCommand = new DelegateCommand(AddOrUpdateFilter);
            DeleteFilterCommand = new DelegateCommand(DeleteFilter);
            FilterSelectionCommand = new DelegateCommand(FilterSelection);
            ResetRadarWidgetCommand = new DelegateCommand(ResetRadarWidget);
            OpenRadarWidgetCommand = new DelegateCommand(OpenRadarWidget);
        }

        #region Utility Functions

        /// <summary>
        /// </summary>
        /// <param name="listView"> </param>
        /// <param name="key"> </param>
        private static string GetValueBySelectedItem(Selector listView, string key)
        {
            var type = listView.SelectedItem.GetType();
            var property = type.GetProperty(key);
            return property.GetValue(listView.SelectedItem, null)
                           .ToString();
        }

        #endregion

        #region Property Bindings

        private static MainViewModel _instance;

        public static MainViewModel Instance
        {
            get { return _instance ?? (_instance = new MainViewModel()); }
        }

        #endregion

        #region Declarations

        public ICommand AddOrUpdateFilterCommand { get; private set; }
        public ICommand DeleteFilterCommand { get; private set; }
        public ICommand FilterSelectionCommand { get; private set; }
        public ICommand ResetRadarWidgetCommand { get; private set; }
        public ICommand OpenRadarWidgetCommand { get; private set; }

        #endregion

        #region Loading Functions

        #endregion

        #region Command Bindings

        /// <summary>
        /// </summary>
        private static void AddOrUpdateFilter()
        {
            var selectedKey = "";
            try
            {
                if (MainView.View.Filters.SelectedItems.Count == 1)
                {
                    selectedKey = GetValueBySelectedItem(MainView.View.Filters, "Key");
                }
            }
            catch (Exception ex)
            {
                Logging.Log(LogManager.GetCurrentClassLogger(), "", ex);
            }
            if (MainView.View.TKey.Text.Trim() == "" || MainView.View.TLevel.Text.Trim() == "")
            {
                return;
            }
            var xKey = MainView.View.TKey.Text;
            if (!SharedRegEx.IsValidRegex(xKey))
            {
                return;
            }
            var radarFilterItem = new RadarFilterItem(xKey);
            int level;
            if (Int32.TryParse(MainView.View.TLevel.Text, out level))
            {
                radarFilterItem.Level = level;
            }
            switch (MainView.View.TType.Text)
            {
                case "PC":
                    radarFilterItem.Type = Actor.Type.PC;
                    break;
                case "Monster":
                    radarFilterItem.Type = Actor.Type.Monster;
                    break;
                case "NPC":
                    radarFilterItem.Type = Actor.Type.NPC;
                    break;
                case "Aetheryte":
                    radarFilterItem.Type = Actor.Type.Aetheryte;
                    break;
                case "Gathering":
                    radarFilterItem.Type = Actor.Type.Gathering;
                    break;
                case "Minion":
                    radarFilterItem.Type = Actor.Type.Minion;
                    break;
            }
            if (String.IsNullOrWhiteSpace(selectedKey))
            {
                PluginViewModel.Instance.Filters.Add(radarFilterItem);
            }
            else
            {
                var index = PluginViewModel.Instance.Filters.TakeWhile(@event => @event.Key != selectedKey)
                                           .Count();
                PluginViewModel.Instance.Filters[index] = radarFilterItem;
            }
            MainView.View.Filters.UnselectAll();
            MainView.View.TKey.Text = "";
        }

        /// <summary>
        /// </summary>
        private static void DeleteFilter()
        {
            string selectedKey;
            try
            {
                selectedKey = GetValueBySelectedItem(MainView.View.Filters, "Key");
            }
            catch (Exception ex)
            {
                Logging.Log(LogManager.GetCurrentClassLogger(), "", ex);
                return;
            }
            var index = PluginViewModel.Instance.Filters.TakeWhile(@event => @event.Key.ToString() != selectedKey)
                                       .Count();
            PluginViewModel.Instance.Filters.RemoveAt(index);
        }

        /// <summary>
        /// </summary>
        private static void FilterSelection()
        {
            if (MainView.View.Filters.SelectedItems.Count != 1)
            {
                return;
            }
            if (MainView.View.Filters.SelectedIndex < 0)
            {
                return;
            }
            MainView.View.TKey.Text = GetValueBySelectedItem(MainView.View.Filters, "Key");
            MainView.View.TLevel.Text = GetValueBySelectedItem(MainView.View.Filters, "Level");
            MainView.View.TType.Text = GetValueBySelectedItem(MainView.View.Filters, "Type");
        }

        public void ResetRadarWidget()
        {
            Settings.Default.RadarWidgetUIScale = Settings.Default.Properties["RadarWidgetUIScale"].DefaultValue.ToString();
            Settings.Default.RadarWidgetTop = Int32.Parse(Settings.Default.Properties["RadarWidgetTop"].DefaultValue.ToString());
            Settings.Default.RadarWidgetLeft = Int32.Parse(Settings.Default.Properties["RadarWidgetLeft"].DefaultValue.ToString());
            Settings.Default.RadarWidgetHeight = Int32.Parse(Settings.Default.Properties["RadarWidgetHeight"].DefaultValue.ToString());
            Settings.Default.RadarWidgetWidth = Int32.Parse(Settings.Default.Properties["RadarWidgetWidth"].DefaultValue.ToString());
        }

        public void OpenRadarWidget()
        {
            Settings.Default.ShowRadarWidgetOnLoad = true;
            Widgets.Instance.ShowRadarWidget();
        }

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}

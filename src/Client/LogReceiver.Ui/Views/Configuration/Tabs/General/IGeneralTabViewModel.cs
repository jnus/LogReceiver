﻿﻿/* -----------------------------------------------------------------------------
 * This source file is part of LogReceiver application
 * For the latest info, contact r@smus.nu
 *
 * Copyright (c) 2012 BLOCKS.DK
 * 
 * This program is free software; you can redistribute it and/or modify it under
 * the terms of the GNU Lesser General Public License as published by the Free Software
 * Foundation; either version 3 of the License, or (at your option) any later
 * version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public License along with
 * this program; if not, write to the Free Software Foundation, Inc., 59 Temple
 * Place - Suite 330, Boston, MA 02111-1307, USA, or go to
 * http://www.gnu.org/copyleft/lesser.txt.
 * -----------------------------------------------------------------------------
 */

using System.Collections.Generic;
using Blocks.Mvvm.ViewModels;
using LogReceiver.Ui.Views.Configuration.Tabs.General.Commands;
using LogReceiver.Ui.Views.Configuration.Tabs.General.DOM;

namespace LogReceiver.Ui.Views.Configuration.Tabs.General
{
    public interface IGeneralTabViewModel : ISpecificViewModelChild<IConfigurationViewModel>, IViewModel
    {
        ISaveSettingsCommand SaveSettingsCommand { get; }
        IResetSettingsCommand ResetSettingsCommand { get; }

        IEnumerable<int> AllMaxNumberOfLogEntries { get; }
        IReadOnlyCollection<PLogFetchTimeSpanType> AllLogFetchTimeSpans { get; }

        PLogFetchTimeSpanType SelectedLogFetchTimeSpan { get; set; }

        bool IsDirty { get; set; }

        bool WordWrap { get; set; }
        bool ParseCSharpStackTrace { get; set; }
        int MaxNumberOfLogEntries { get; set; }

        void LoadSettings();
    }
}

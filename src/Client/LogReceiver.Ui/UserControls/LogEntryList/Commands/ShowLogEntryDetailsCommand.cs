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

using Blocks.Mvvm.Commands;
using LogReceiver.Ui.Views.LogEntryDetails;

namespace LogReceiver.Ui.UserControls.LogEntryList.Commands
{
    public class ShowLogEntryDetailsCommand : ViewModelCommandBase<ILogEntryListViewModel>, IShowLogEntryDetailsCommand
    {
        public override void Execute(object parameter)
        {
            var selected = ParentViewModel.SelectedLogEntry;
            if (null == selected)
            {
                return;
            }

            MvvmManager.Show<ILogEntryDetailsView, ILogEntryDetailsViewModel>(ResidingWindowViewViewModel, vm =>
                {
                    vm.Receiver = ParentViewModel.Receiver;
                    vm.LogEntry = selected;
                });
        }
    }
}
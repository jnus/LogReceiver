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

using System;
using System.IO;
using System.Xml.Serialization;
using Blocks.Mvvm.Commands;
using Blocks.Mvvm.Services;
using LogReceiver.Ui.UserControls.LogEntryList.UserControls.FilterSelection.DOM.Export;
using LogReceiver.Ui.UserControls.LogEntryList.UserControls.FilterSelection.DOM.Mapping;

namespace LogReceiver.Ui.UserControls.LogEntryList.UserControls.FilterSelection.Commands
{
    public class SaveFilterProfileCommand : ViewModelCommandBase<IFilterSelectionControlModel>, ISaveFilterProfileCommand
    {
        private readonly IDialogService _dialogService;
        private readonly IFilterConfigurationMapper _mapper;

        public SaveFilterProfileCommand(
            IDialogService dialogService,
            IFilterConfigurationMapper mapper)
        {
            _dialogService = dialogService;
            _mapper = mapper;
        }

        public override void Execute(object parameter)
        {
            if (ParentViewModel.SelectedFilterProfile.Filters == null)
            {
                return;
            }

            var exFilterProfile = _mapper.ToExFilterProfile(ParentViewModel.SelectedFilterProfile);

            var filePath = _dialogService.SaveFile(ResidingWindowViewViewModel, "xml");
            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }

            try
            {
                using (var fileStream = File.OpenWrite(filePath))
                {
                    var ser = new XmlSerializer(typeof(ExFilterProfile));
                    ser.Serialize(fileStream, exFilterProfile);
                }
            }
            catch (Exception exception)
            {
                _dialogService.ShowErrorFormat(
                    ResidingWindowViewViewModel,
                    "Save error",
                    "Could not save filter configuration due to: {0}",
                    exception.Message);
            }
        }
    }
}

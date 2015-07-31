/*
* Copyright (c) 2014 Universal Technical Resource Services, Inc.
* 
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATMLDataAccessLibrary.db.beans;


namespace ATMLDataAccessLibrary.model
{
    public class dbSignalAttribute : SignalAttributeMasterBean
    {
        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
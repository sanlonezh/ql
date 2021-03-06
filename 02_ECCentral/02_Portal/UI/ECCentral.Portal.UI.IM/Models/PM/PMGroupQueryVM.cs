﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Newegg.Oversea.Silverlight.ControlPanel.Core.Base;
using System.Collections.Generic;
using ECCentral.Portal.Basic.Utilities;
using ECCentral.BizEntity.IM;
using ECCentral.Portal.UI.IM.Resources;

namespace ECCentral.Portal.UI.IM.Models
{
    public class PMGroupQueryVM : ModelBase
    {

        public string Status { get; set; }

        public string PMGroupName { get; set; }

        //public List<KeyValuePair<ValidStatus?, string>> PMGroupStatusList { get; set; }
        public List<KeyValuePair<int, string>> PMGroupStatusList { get; set; }

        public PMGroupQueryVM()
        {
            //this.PMGroupStatusList = EnumConverter.GetKeyValuePairs<ValidStatus>(EnumConverter.EnumAppendItemType.All);
            List<KeyValuePair<int, string>> statusList = new List<KeyValuePair<int, string>>();

            statusList.Add(new KeyValuePair<int, string>(-999, ResCategoryKPIMaintain.SelectTextAll));
            statusList.Add(new KeyValuePair<int, string>(0, ResCategoryKPIMaintain.SelectTextValid));
            statusList.Add(new KeyValuePair<int, string>(-1, ResCategoryKPIMaintain.SelectTextInvalid));

            this.PMGroupStatusList = statusList;
        }
    }
}

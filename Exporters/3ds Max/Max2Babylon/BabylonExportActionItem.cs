﻿using System;
using Autodesk.Max;
using Autodesk.Max.IQuadMenuContext;
using MaxSharp;
using ActionItem = Autodesk.Max.Plugins.ActionItem;

namespace Max2Babylon
{
    public class BabylonExportActionItem : ActionItem
    {
        private ExporterForm form;

        public override bool ExecuteAction()
        {
            if (form == null)
                form = new ExporterForm(this);
            form.Show();

            return true;
        }

        public void Close()
        {
            form.Dispose();
            form = null;
        }

        public override int Id_
        {
            get { return 1; }
        }

        public override string ButtonText
        {
            get { return "Babylon File Exporter"; }
        }

        public override string MenuText
        {
            get { return "&Babylon File Exporter..."; }
        }

        public override string DescriptionText
        {
            get { return "Generate a babylon.js scene file2"; }
        }

        public override string CategoryText
        {
            get { return "Babylon"; }
        }

        public override bool IsChecked_
        {
            get { return false; }
        }

        public override bool IsItemVisible
        {
            get { return true; }
        }

        public override bool IsEnabled_
        {
            get { return true; }
        }
    }
}

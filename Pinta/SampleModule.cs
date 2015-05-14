using System;
using Pinta.IModule;
using Gtk;

namespace Pinta
{
    public class SampleModule : IApplicationModule
    {
        private Notebook mParent;
        public SampleModule (Notebook parent)
        {
            mParent = parent;
        }

        #region IApplicationModule implementation

        public Pinta.IModule.IWindowsTab CreateNewPage ()
        {
            var paintTab = new WindowsTab (mParent);
            paintTab.Initialize ("tab01", new Label ("Example"));
            return paintTab;
        }

        #endregion
    }
}


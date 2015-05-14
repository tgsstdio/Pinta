using System;
using Gtk;

namespace Pinta.IModule
{
    public interface IWindowsTab
    {
        void Initialize(string name, Label tabHeader);
        MenuBar CreateMainMenu (string name);
        Toolbar CreateToolBar (string name);
        HBox CreateWorkspace ();
    }
}


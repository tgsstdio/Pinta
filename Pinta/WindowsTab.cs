using System;
using Gtk;
using Pinta.IModule;

public class WindowsTab : IWindowsTab
{
    private VBox mShellLayout;
    private VBox mMenuLayout;
    private HBox mWorkspaceLayout;

    private MenuBar mMainMenu;
    private Toolbar mMainToolbar;
    private Notebook mParent;
    private string mWidgetName;

    public WindowsTab (Notebook parent)
    {
        mParent = parent;
    }

    public void Initialize(string name, Label tabHeader)
    {
        mWidgetName = name;
        mShellLayout = new VBox () { Name =  mWidgetName + "shell_layout" };
        mMenuLayout = new VBox () { Name = mWidgetName + "menu_layout" };

        mShellLayout.PackStart (mMenuLayout, false, false, 0);

        int pageNo = mParent.InsertPage (mShellLayout, tabHeader, 0);
        if (mParent.NPages > 0)
        {
            Widget page = mParent.GetNthPage (pageNo);
        }
        mParent.ShowAll ();
    }

    public MenuBar CreateMainMenu (string name)
    {
        mMainMenu = new MenuBar ();
        mMainMenu.Name = name;

        mMenuLayout.PackStart (mMainMenu, false, false, 0);
        mMainMenu.Show ();

        return mMainMenu;
    }

    public Toolbar CreateToolBar (string name)
    {
        mMainToolbar = new Toolbar ();
        mMainToolbar.Name = name;

        mMenuLayout.PackStart (mMainToolbar, false, false, 0);
        mMainToolbar.Show ();

        return mMainToolbar;
    }

    public HBox CreateWorkspace ()
    {
        mWorkspaceLayout = new HBox ();
        mWorkspaceLayout.Name = mWidgetName + "workspace_layout";

        mShellLayout.PackStart (mWorkspaceLayout);
        mWorkspaceLayout.ShowAll ();

        return mWorkspaceLayout;
    }
}



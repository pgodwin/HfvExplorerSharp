using System;
using Eto.Forms;
using Eto.Drawing;
using HfvExplorerSharp.Controls;

namespace HfvExplorerSharp
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			Title = "HFV Explorer";
			ClientSize = new Size(400, 350);

            var mainRow = new TableRow()
            {
                Cells =
                {
                    new DirectoryTree(),
                    new Splitter(),
                    new IconView()
                }
            };

            

            Content = new TableLayout {
                Rows = { mainRow },
                Padding = 10
            };



			//Content = new StackLayout
			//{
			//	Padding = 10,
			//	Items =
			//	{
			//		"Hello World!",
			//		// add more controls here
			//	}
			//};

			// create a few commands that can be used for the menu and toolbar
			var clickMe = new Command { MenuText = "Click Me!", ToolBarText = "Click Me!" };
			clickMe.Executed += (sender, e) => MessageBox.Show(this, "I was clicked!");

			var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
			quitCommand.Executed += (sender, e) => Application.Instance.Quit();

			var aboutCommand = new Command { MenuText = "About..." };
			aboutCommand.Executed += (sender, e) => new AboutDialog().ShowDialog(this);

			// create menu
			Menu = new MenuBar
			{
				Items =
				{
					// File submenu
					new ButtonMenuItem { Text = "&File", Items = { clickMe } },
					// new ButtonMenuItem { Text = "&Edit", Items = { /* commands/items */ } },
					// new ButtonMenuItem { Text = "&View", Items = { /* commands/items */ } },
				},
				ApplicationItems =
				{
					// application (OS X) or file menu (others)
					new ButtonMenuItem { Text = "&Preferences..." },
				},
				QuitItem = quitCommand,
				AboutItem = aboutCommand
			};

			// create toolbar			
			ToolBar = new ToolBar { Items = { clickMe } };

            
		}
	}
}

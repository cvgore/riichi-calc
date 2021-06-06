using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RiichiCalc.Controls;
using RiichiCalc.Core.States;
using RiichiCalc.Tiles;

namespace RiichiCalc
{
    public partial class MainWnd : Form
    {
        private readonly string Version;
        private HandContext handCtx;

        public MainWnd()
        {
            handCtx = new(new EmptyHandState());
            
            InitializeComponent();

            var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            Version = $"{info.FileMajorPart}.{info.FileMinorPart}.{info.FileBuildPart}";

            versionInfo.Text = $"{versionInfo}{Version}";

        }

        private void statusBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var item = (string) e.ClickedItem.Tag;

            if (item == "version_info")
            {
                var page = new TaskDialogPage
                {
                    Caption = $"About RiichiCalc v.{Version}",
                    Heading = $"RiichiCalc v.{Version}",
                    AllowMinimize = false,
                    AllowCancel = true,
                    Text = "(c) 2021 Kacper Palka\nLicensed under GPLv2-only terms.",
                    Icon = TaskDialogIcon.Information
                };

                var ghRepoBtn = page.Buttons.Add("Show GitHub repo");
                ghRepoBtn.Click += (_, _) =>
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://github.com/cvgore/riichi-calc",
                        UseShellExecute = true
                    });
                };

                var thirdPartyBtn = page.Buttons.Add("Third-party components used");
                thirdPartyBtn.Click += (_, _) =>
                {
                    var tempFile = Path.GetTempFileName();
                    File.WriteAllText(tempFile, MainRes.ThirdParty);
                    Process.Start("notepad.exe", tempFile);
                };

                TaskDialog.ShowDialog(page);
            }
        }

        private void MahjongTileBtn_Click(object sender, EventArgs e)
        {
            var btn = (MahjongTileBtn) sender;

            handCtx.AddTile(btn.Tile);
        }
    }
}

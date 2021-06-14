using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RiichiCalc.Controls;
using RiichiCalc.Core;
using RiichiCalc.Core.States;
using RiichiCalc.Tiles;

namespace RiichiCalc
{
    public partial class MainWnd : Form
    {
        private readonly string _version;
        private TableContext _tableCtx;

        public MainWnd()
        {
            _tableCtx = new();
            _tableCtx.Hand.StateChanged += Hand_StateChanged;

            InitializeComponent();

            handCont.SetHandContext(_tableCtx.Hand);

            var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            _version = $"{info.FileMajorPart}.{info.FileMinorPart}.{info.FileBuildPart}";

            versionInfo.Text = $"{versionInfo}{_version}";

        }

        private void Hand_StateChanged([NotNull] object? sender, IHandState e)
        {
            deck.Enabled = true;

            if (e is InvalidFullHandState)
            {
                test.Text = "Invalid";
                deck.Enabled = false;
            }
            else if (e is FullHandState fhs)
            {
                fhs.FullHand.Calculate(_tableCtx);

                if (fhs.FullHand.BigPoints == 0)
                {
                    _tableCtx.Hand.SetState(new InvalidFullHandState(_tableCtx.Hand.GetHandItems()));

                    return;
                }

                test.Text = string.Join(',', fhs.FullHand.MatchedPatterns.Select(x => x.Name()));
                deck.Enabled = false;
            }
        }

        private void statusBar_ItemClicked([NotNull] object? sender, ToolStripItemClickedEventArgs e)
        {
            var item = (string) e.ClickedItem.Tag;

            if (item == "version_info")
            {
                var page = new TaskDialogPage
                {
                    Caption = $"About RiichiCalc v.{_version}",
                    Heading = $"RiichiCalc v.{_version}",
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

        private void MahjongTileBtn_Click([NotNull] object? sender, EventArgs e)
        {
            var btn = (MahjongTileBtn) sender!;

            _tableCtx.Hand.AddTile(btn.Tile);
        }
    }
}

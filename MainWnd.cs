using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin;
using RiichiCalc.Controls;
using RiichiCalc.Core;
using RiichiCalc.Core.States;
using RiichiCalc.Tiles;

namespace RiichiCalc
{
    public partial class MainWnd : MaterialSkin.Controls.MaterialForm
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

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Amber600,
                Primary.Amber700,
                Primary.Grey200,
                Accent.DeepOrange400,
                TextShade.BLACK
            );
        }

        private void Hand_StateChanged(object? sender, IHandState e)
        {
            deck.Enabled = true;
            ponStateCheckBtn.Enabled = true;
            chiStateCheckBtn.Enabled = true;
            kanStateCheckBtn.Enabled = true;
            closedKanCheckBtn.Enabled = true;

            if (e is InvalidFullHandState)
            {
                summaryBox.BeginUpdate();
                summaryBox.Clear();
                summaryBox.Items.Add(new MaterialListBoxItem
                {
                    Text = "Invalid hand composition"
                });
                summaryBox.EndUpdate();
                deck.Enabled = false;
            }
            else if (e is FullHandState fhs)
            {
                fhs.FullHand.Calculate(_tableCtx);

                if (fhs.FullHand.BigPoints == 0)
                {
                    _tableCtx.Hand.SetState(new InvalidFullHandState(_tableCtx.Hand.GetHandTiles()));

                    return;
                }

                summaryBox.BeginUpdate();
                summaryBox.Clear();
                summaryBox.Items.Add(new MaterialListBoxItem
                {
                    Text = $"Matched: {string.Join(", ", fhs.FullHand.MatchedPatterns.Select(x => x.Name()))}"
                });
                summaryBox.Items.Add(new MaterialListBoxItem
                {
                    Text = $"Han: {fhs.FullHand.BigPoints}"
                });
                summaryBox.EndUpdate();

                deck.Enabled = false;
            }
            else if (e is PonReadyHandState)
            {
                chiStateCheckBtn.Enabled = false;
                kanStateCheckBtn.Enabled = false;
                closedKanCheckBtn.Enabled = false;
            }
            else if (e is ChiReadyHandState)
            {
                ponStateCheckBtn.Enabled = false;
                kanStateCheckBtn.Enabled = false;
                closedKanCheckBtn.Enabled = false;
            }
            else if (e is KanReadyHandState)
            {
                chiStateCheckBtn.Enabled = false;
                ponStateCheckBtn.Enabled = false;
                closedKanCheckBtn.Enabled = false;
            }
            else if (e is ClosedKanReadyHandState)
            {
                chiStateCheckBtn.Enabled = false;
                ponStateCheckBtn.Enabled = false;
                kanStateCheckBtn.Enabled = false;
            }
        }

        private void statusBar_ItemClicked(object? sender, ToolStripItemClickedEventArgs e)
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

        private void MahjongTileBtn_Click(object? sender, EventArgs e)
        {
            var btn = (MahjongTileBtn) sender!;

            _tableCtx.Hand.AddTile(btn.Tile);
        }

        private void tableWindBtn_ValueChanged(object sender, EventArgs e)
        {
            _tableCtx.TableWind = tableWindBtn.Value;
        }

        private void seatWindBtn_ValueChanged(object sender, EventArgs e)
        {
            _tableCtx.PlayerWind = seatWindBtn.Value;
        }

        private void clearHandBtn_Click(object sender, EventArgs e)
        {
            _tableCtx.Hand.SetState(new EmptyHandState());
        }

        private void winMethodEnumBtn_ValueChanged(object sender, EventArgs e)
        {
            var value = winMethodEnumBtn.Value;

            if (value == WinMethod.Tsumo && extraYakuEnumBtn.Value != ExtraYaku.Haitei)
            {
                extraYakuEnumBtn.Value = ExtraYaku.None;
            }
            else if (value == WinMethod.Ron && extraYakuEnumBtn.Value != ExtraYaku.Houtei)
            {
                extraYakuEnumBtn.Value = ExtraYaku.None;
            }

            _tableCtx.WinMethod = value;
        }

        private void extraYakuEnumBtn_ValueChanged(object sender, EventArgs e)
        {
            var value = extraYakuEnumBtn.Value;

            if (value == ExtraYaku.Ippatsu && betYakuEnumBtn.Value != BetYaku.Riichi)
            {
                betYakuEnumBtn.Value = BetYaku.Riichi;
            }
            else if (value == ExtraYaku.Haitei && winMethodEnumBtn.Value != WinMethod.Tsumo)
            {
                winMethodEnumBtn.Value = WinMethod.Tsumo;
            }
            else if (value == ExtraYaku.Houtei && winMethodEnumBtn.Value != WinMethod.Ron)
            {
                winMethodEnumBtn.Value = WinMethod.Ron;
            }

            _tableCtx.ExtraYaku = value;
        }

        private void betYakuEnumBtn_ValueChanged(object sender, EventArgs e)
        {
            var value = betYakuEnumBtn.Value;

            if (value == BetYaku.NoRiichi && extraYakuEnumBtn.Value == ExtraYaku.Ippatsu)
            {
                extraYakuEnumBtn.Value = ExtraYaku.None;
            }

            _tableCtx.BetYaku = value;
        }

        private void ponStateCheckBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ponStateCheckBtn.Checked)
            {
                _tableCtx.Hand.SetState(
                    new PonReadyHandState(_tableCtx.Hand.GetHandTiles(), _tableCtx.Hand.GetHandGroups())
                );
            }
            else
            {
                _tableCtx.Hand.RestorePreviousState();
            }
        }

        private void chiStateCheckBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (chiStateCheckBtn.Checked)
            {
                _tableCtx.Hand.SetState(
                    new ChiReadyHandState(_tableCtx.Hand.GetHandTiles(), _tableCtx.Hand.GetHandGroups())
                );
            }
            else
            {
                _tableCtx.Hand.RestorePreviousState();
            }
        }

        private void kanStateCheckBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (kanStateCheckBtn.Checked)
            {
                _tableCtx.Hand.SetState(
                    new KanReadyHandState(_tableCtx.Hand.GetHandTiles(), _tableCtx.Hand.GetHandGroups())
                );
            }
            else
            {
                _tableCtx.Hand.RestorePreviousState();
            }
        }

        private void closedKanCheckBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (closedKanCheckBtn.Checked)
            {
                _tableCtx.Hand.SetState(
                    new ClosedKanReadyHandState(_tableCtx.Hand.GetHandTiles(), _tableCtx.Hand.GetHandGroups())
                );
            }
            else
            {
                _tableCtx.Hand.RestorePreviousState();
            }
        }
    }
}
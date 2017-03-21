using Sulakore.Habbo;
using Sulakore.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tangine;
using Sulakore.Communication;
using System.Text.RegularExpressions;

namespace PosterGrabber
{
    [Module("PosterGrabber", "Does some magical shit with posters d/w about it.")]
    [Author("Scott Stamp", HabboName = "Iterator", Hotel = HHotel.Com)]
    public partial class frmMain : ExtensionForm
    {
        private ushort movePoster = 0;
        private ushort placePoster = 0;
        public override bool IsRemoteModule => true;
        private static string movePattern = @":w=(-?[0-9]+),(-?[0-9]+) l=(-?[0-9]+),(-?[0-9]+) ([l|r])";
        private static string placePattern = @"([0-9]+) :w=(-?[0-9]+),(-?[0-9]+) l=(-?[0-9]+),(-?[0-9]+) ([l|r])";
        private Regex r;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            movePoster = Game.GetHeader("ac0a5da536aba32cd6e1ab52a7a1cbb5");
            placePoster = Game.GetHeader("3c90715d21c127bcbce295c8c10cdc5c");

            Triggers.OutAttach(movePoster, MovePoster);
            Triggers.OutAttach(placePoster, PlacePoster);
        }

        private void MovePoster(DataInterceptedEventArgs e)
        {
            r = new Regex(movePattern, RegexOptions.IgnoreCase);

            int posterId = e.Packet.ReadInteger();
            string posterLoc = e.Packet.ReadString();

            numId.Value = posterId;

            Match m = Regex.Match(posterLoc, movePattern, RegexOptions.IgnoreCase);
            if (m.Success)
            {
                numW1.Value = int.Parse(m.Groups[1].Value);
                numW2.Value = int.Parse(m.Groups[2].Value);
                numL1.Value = int.Parse(m.Groups[3].Value);
                numL2.Value = int.Parse(m.Groups[4].Value);
                cmbRot.Text = m.Groups[5].Value;
            }
        }

        private void PlacePoster(DataInterceptedEventArgs e)
        {
            string posterData = e.Packet.ReadString();

            Match m = Regex.Match(posterData, placePattern, RegexOptions.IgnoreCase);
            if (m.Success)
            {
                numId.Value = int.Parse(m.Groups[1].Value);
                numW1.Value = int.Parse(m.Groups[2].Value);
                numW2.Value = int.Parse(m.Groups[3].Value);
                numL1.Value = int.Parse(m.Groups[4].Value);
                numL2.Value = int.Parse(m.Groups[5].Value);
                cmbRot.Text = m.Groups[6].Value;
            }
        }

        private void btnMovePoster_Click(object sender, EventArgs e)
        {
            Connection.SendToServerAsync(movePoster, (int)numId.Value, $":w={numW1.Value},{numW2.Value} l={numL1.Value},{numL2.Value} {cmbRot.Text}");
        }
    }
}

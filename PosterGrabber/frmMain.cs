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

namespace PosterGrabber
{
    [Module("PosterGrabber", "Does some magical shit with posters d/w about it.")]
    [Author("Scott Stamp", HabboName = "Iterator", Hotel = HHotel.Com)]
    public partial class frmMain : ExtensionForm
    {
        private ushort movePoster = 0;
        private ushort placePoster = 0;
        public override bool IsRemoteModule => true;

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
            int posterId = e.Packet.ReadInteger();
            string posterLoc = e.Packet.ReadString();

            txtInject.Text += "{l}{u:" + movePoster + "}{i:" + posterId + "}{s:" + posterLoc + "}\r\n";
        }

        private void PlacePoster(DataInterceptedEventArgs e)
        {
            string posterData = e.Packet.ReadString();
            string posterId = posterData.Substring(0, posterData.IndexOf(' '));
            string posterLoc = posterData.Substring(posterData.IndexOf(' ') + 1, posterData.Length - (posterData.IndexOf(' ')+1));

            txtInject.Text += "{l}{u:" + movePoster + "}{i:" + posterId + "}{s:" + posterLoc + "}\r\n";
        }
    }
}

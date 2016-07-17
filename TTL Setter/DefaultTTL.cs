using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Reg_ns;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TTL_Setter {
    public partial class DefaultTTL : Form {
        private string Path = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters";
        private string VName = "DefaultTTL";
        private int Value= 65;

        private string MessageBoxText = "Current user can't edit register.\r\nRun the program as Administrator and try again.";
        private string MessageBoxTitle = "I plee you for more power, my lord.";
        private string HelpTitle = "I'll tell you what is going on here...";
        private string HelpText = "You want to use your smartphone as a hotspot for your computer/laptop but the provider says" +
            " you have to extend your plan (or just blocks traffic)?" +
            "\r\n\r\nNot a problem. Just run this software as administrator, choose 65 for TTL and reboot afterwards." +
            "\r\n\r\nAll the point of the program is to set a value for decimal \"DWORD\" key called \"DefaultTTL\" " +
            "under the following path: HEKY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters" +
            "\r\n\r\nTo check the value which was read at last boot you can \"ping 127.0.0.1\"." +
            "\r\nIt is the value which is current for your OS untill you reboot." +
            "\r\n\r\n\r\n17th of June 2015\tv1.00";
        private string DefaultLabelString = "none";
        string MyContacts = "cccpmade@gmail.com";
        EventHandler EventHandlerForDropDown = null;

        Reg R = new Reg();

        Font ExitUsual = new Font("Arial", 10F, FontStyle.Regular);
        Font ExitHover = new Font("Arial", 10F, FontStyle.Underline);
        Color MeRegular = Color.FromName("ControlLight");
        Color MeHover = Color.DarkBlue;
        Color UnitHover = Color.BlueViolet;
        Color UnitRegular = Color.DarkGray;


//#region fro window dragging and rounding...
//        private const int WM_NCHITTEST = 0x84;
//        private const int HTCLIENT = 0x1;
//        private const int HTCAPTION = 0x2;
//        protected override void WndProc(ref Message message)
//        {
//            base.WndProc(ref message);

//            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
//                message.Result = (IntPtr)HTCAPTION;
//        }

//        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
//        private static extern IntPtr CreateRoundRectRgn
//        (
//            int nLeftRect, // x-coordinate of upper-left corner
//            int nTopRect, // y-coordinate of upper-left corner
//            int nRightRect, // x-coordinate of lower-right corner
//            int nBottomRect, // y-coordinate of lower-right corner
//            int nWidthEllipse, // height of ellipse
//            int nHeightEllipse // width of ellipse
//         );
//#endregion
        
        public DefaultTTL() {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            for (int i = 1; i < 255; i++) {
                comboBoxTTL.Items.Add(i);
            }
            EventHandlerForDropDown = new EventHandler(comboBoxTTL_SelectedValueChanged);
            comboBoxTTL.SelectedItem = Value;
            comboBoxTTL.DropDownStyle = ComboBoxStyle.DropDownList;

            labelExit.ForeColor = Color.DarkGray;
            labelExit.Font = ExitUsual;
            Refresh_Controls();
            comboBoxTTL.SelectedValueChanged += EventHandlerForDropDown;
        }
        private void button1_Click(object sender, EventArgs e) {                    ///////////////////////////////
            string[] Result = R.GetKeys(Path);
            StringBuilder Sb = new StringBuilder();
            foreach (string s in Result) {
                Sb.Append(s + "\r\n");
            }
            MessageBox.Show(Sb.ToString());
        }
        private void Refresh_Controls() {
            UpdateLabel();
            CurrentValueToDropDown();
        }
        private void UpdateLabel() {
            try {
                int Result = (int)R.GetKeyValue(Path, VName);
                labelCurrentTTL.Text = Result.ToString();
            }
            catch {
                labelCurrentTTL.Text = DefaultLabelString;
            }
        }
        private void CurrentValueToDropDown() {
            try {
                comboBoxTTL.SelectedItem = (int)R.GetKeyValue(Path, VName);
            }
            catch {
                comboBoxTTL.SelectedItem = null;
            }
        }
        private void comboBoxTTL_SelectedValueChanged(object sender, EventArgs e) {
            try {
                int SelVal = (int)((ComboBox)sender).SelectedItem;
                R.CreateSetKey(Path, VName, ((ComboBox)sender).SelectedItem);
                Refresh_Controls();
            }
            catch {
                ShowMessageLowPowerExit();
            }
        }
        private void labelDelete_Click(object sender, EventArgs e) {
            comboBoxTTL.SelectedValueChanged -= EventHandlerForDropDown;
            try {
                R.DeleteKey(Path, VName);
                Refresh_Controls();
            }
            catch {
                ShowMessageLowPowerExit();
            }
            comboBoxTTL.SelectedValueChanged += EventHandlerForDropDown;
        }
        private void ShowMessageLowPowerExit() {
            MessageBox.Show(this, MessageBoxText, MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Environment.Exit(0);
        }

        private void labelHelp_Click(object sender, EventArgs e) {
            MessageBox.Show(HelpText, HelpTitle);
        }

        private void labelMe_MouseEnter(object sender, EventArgs e) {
            labelMe.ForeColor = MeHover;
        }

        private void labelMe_MouseLeave(object sender, EventArgs e) {
            labelMe.ForeColor = MeRegular;
        }

        private void labelDelete_MouseEnter(object sender, EventArgs e) {
            labelDelete.ForeColor = UnitHover;
        }

        private void labelDelete_MouseLeave(object sender, EventArgs e) {
            labelDelete.ForeColor = UnitRegular;
        }

        private void labelHelp_MouseEnter(object sender, EventArgs e) {
            labelHelp.ForeColor = UnitHover;
        }

        private void labelHelp_MouseLeave(object sender, EventArgs e) {
            labelHelp.ForeColor = UnitRegular;
        }

        private void labelMe_Click(object sender, EventArgs e) {
            Clipboard.SetText(MyContacts);
        }
    }
}

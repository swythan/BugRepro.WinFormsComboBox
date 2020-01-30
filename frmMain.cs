namespace ComboBugRepro
{
    using System;
    using System.Windows.Forms;

    public partial class frmMain : Form
    {

        private static readonly string[] AppOptions = new[] { "App_1", "App_2", "App_3" };

        private static readonly string[] OwnerOptions = new[] { "Control", "RaceEng", "Engine", "Rack" };

        public enum FileOwner
        {
            ControlEngineer,
            RaceEngineer,
            EngineEngineer,
            RackMan,
        }

        int RowCount;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmDirSetup_Load(object sender, EventArgs e)
        {
            // Configure the display
            ClearDirTable();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            // Configure the display
            ClearDirTable();
            PopulateDirTable();
        }

        public void PopulateDirTable()
        {
            tableDirs.SuspendLayout();

            AddNewRow("App_1", "Foo", FileOwner.EngineEngineer);
            AddNewRow("App_2", "Bar", FileOwner.ControlEngineer);
            AddNewRow("App_3", "Quux", FileOwner.RaceEngineer);

            tableDirs.Visible = true;
            tableDirs.ResumeLayout();

            this.Height = (tableDirs.RowCount * 33) + 180;
        }

        public void ClearDirTable()
        {
            int Index = RowCount - 1;

            tableDirs.Visible = false;

            // Remove controls for each row
            while (Index >= 0)
            {
                for (int i = 0; i < tableDirs.ColumnCount; i++)
                {
                    var control = tableDirs.GetControlFromPosition(0, Index);
                    tableDirs.Controls.Remove(control);
                }

                RowCount--;
                tableDirs.RowCount = RowCount;

                Index--;
            }

            this.Height = (tableDirs.RowCount * 33) + 180;
        }

        private void AddNewRow(
            string application,
            string area,
            FileOwner owner)
        {
            RowCount++;

            //Add the controls that constitute a row
            var cboApp = new ComboBox
            {
                Anchor = AnchorStyles.Right | AnchorStyles.Left,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cboApp.Items.AddRange(AppOptions);
            cboApp.SelectedIndexChanged += new EventHandler(cboApp_SelectedIndexChanged);
            tableDirs.Controls.Add(cboApp);

            var txtArea = new TextBox
            {
                Anchor = AnchorStyles.Right | AnchorStyles.Left
            };
            tableDirs.Controls.Add(txtArea);

            var cboOwner = new ComboBox
            {
                Anchor = AnchorStyles.Right | AnchorStyles.Left,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboOwner.Items.AddRange(OwnerOptions);
            tableDirs.Controls.Add(cboOwner);

            var cboTrackParam = new ComboBox
            {
                Anchor = AnchorStyles.Right | AnchorStyles.Left,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            tableDirs.Controls.Add(cboTrackParam);

            tableDirs.RowCount = RowCount;

            // Populate the controls with the input arguments
            if (!cboApp.Items.Contains(application))
            {
                return;
            }

            cboApp.SelectedItem = application;

            // We've already hit the bug by now, these lines are superfluous
            txtArea.Text = area;
            cboOwner.SelectedItem = OwnerOptions[(int)owner];

            this.Height = (tableDirs.RowCount * 33) + 180;
            tableDirs.Visible = true;
        }

        void cboApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cboApp = (ComboBox)sender;

            // Update the available "Tracking parameters"
            var cboAppPosition = tableDirs.GetPositionFromControl(cboApp);
            var cboTrackParam = (ComboBox)tableDirs.GetControlFromPosition(3, cboAppPosition.Row);
            cboTrackParam.Items.Clear();

            // N.B. In the real application, the avaiable list depends on the cboApp 
            // selected item (hence the event handler).
            // This is enough to repro the bug, though.
            cboTrackParam.Items.Add("No Tracking");

#warning This line triggers the bug (when hit whilst populating the table)
            cboTrackParam.SelectedIndex = 0;
        }

    }
}
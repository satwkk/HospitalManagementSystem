namespace HotelManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            menuStrip1=new MenuStrip();
            dashboardMenuFileButton=new ToolStripMenuItem();
            addPatientToolStripMenuItem=new ToolStripMenuItem();
            editPatientToolStripMenuItem=new ToolStripMenuItem();
            deletePatientToolStripMenuItem=new ToolStripMenuItem();
            dashboardMenuAboutButton=new ToolStripMenuItem();
            aboutPMSToolStripMenuItem=new ToolStripMenuItem();
            addPatientGroupBox=new GroupBox();
            dashboardEmergencyNumberValue=new TextBox();
            dashboardAddPatientButton=new Button();
            label7=new Label();
            dashboardContactEmailValue=new TextBox();
            label6=new Label();
            label5=new Label();
            dashboardContactNumberValue=new TextBox();
            dashboardAdmissionDateValue=new DateTimePicker();
            label4=new Label();
            label3=new Label();
            dashboardMedicalProblemDescriptionValue=new TextBox();
            dashboardMedicalProblemValue=new TextBox();
            label2=new Label();
            dashboardPatientNameValue=new TextBox();
            label1=new Label();
            dashboardMainGroupBox=new GroupBox();
            editPatientGroupBox=new GroupBox();
            dashboardPatientViewTable=new TableLayoutPanel();
            dataGridView1=new DataGridView();
            dashboardPatientTextValue=new TextBox();
            contextMenuStrip1=new ContextMenuStrip( components );
            editPatientGroupBoxPopup=new GroupBox();
            button2=new Button();
            editGroupBoxEmergencyNumber=new TextBox();
            button1=new Button();
            label8=new Label();
            editGroupBoxEmail=new TextBox();
            label9=new Label();
            label10=new Label();
            editGroupBoxContactNumber=new TextBox();
            editGroupBoxAdmissionDate=new DateTimePicker();
            label11=new Label();
            label12=new Label();
            editGroupBoxIllnessDescription=new TextBox();
            editGroupBoxMedicalIllness=new TextBox();
            label13=new Label();
            editGroupBoxPatientName=new TextBox();
            label14=new Label();
            menuStrip1.SuspendLayout();
            addPatientGroupBox.SuspendLayout();
            editPatientGroupBox.SuspendLayout();
            dashboardPatientViewTable.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) dataGridView1  ).BeginInit();
            editPatientGroupBoxPopup.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange( new ToolStripItem[] { dashboardMenuFileButton, dashboardMenuAboutButton } );
            menuStrip1.Location=new Point( 0, 0 );
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size( 916, 24 );
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // dashboardMenuFileButton
            // 
            dashboardMenuFileButton.DropDownItems.AddRange( new ToolStripItem[] { addPatientToolStripMenuItem, editPatientToolStripMenuItem, deletePatientToolStripMenuItem } );
            dashboardMenuFileButton.Name="dashboardMenuFileButton";
            dashboardMenuFileButton.Size=new Size( 37, 20 );
            dashboardMenuFileButton.Text="File";
            dashboardMenuFileButton.Click+=dashboardMenuFileButton_Click;
            // 
            // addPatientToolStripMenuItem
            // 
            addPatientToolStripMenuItem.Name="addPatientToolStripMenuItem";
            addPatientToolStripMenuItem.Size=new Size( 147, 22 );
            addPatientToolStripMenuItem.Text="Add Patient";
            addPatientToolStripMenuItem.Click+=addPatientToolStripMenuItem_Click;
            // 
            // editPatientToolStripMenuItem
            // 
            editPatientToolStripMenuItem.Name="editPatientToolStripMenuItem";
            editPatientToolStripMenuItem.Size=new Size( 147, 22 );
            editPatientToolStripMenuItem.Text="Edit Patient";
            editPatientToolStripMenuItem.Click+=editPatientToolStripMenuItem_Click;
            // 
            // deletePatientToolStripMenuItem
            // 
            deletePatientToolStripMenuItem.Name="deletePatientToolStripMenuItem";
            deletePatientToolStripMenuItem.Size=new Size( 147, 22 );
            deletePatientToolStripMenuItem.Text="Delete Patient";
            deletePatientToolStripMenuItem.Click+=deletePatientToolStripMenuItem_Click;
            // 
            // dashboardMenuAboutButton
            // 
            dashboardMenuAboutButton.DropDownItems.AddRange( new ToolStripItem[] { aboutPMSToolStripMenuItem } );
            dashboardMenuAboutButton.Name="dashboardMenuAboutButton";
            dashboardMenuAboutButton.Size=new Size( 52, 20 );
            dashboardMenuAboutButton.Text="About";
            // 
            // aboutPMSToolStripMenuItem
            // 
            aboutPMSToolStripMenuItem.Name="aboutPMSToolStripMenuItem";
            aboutPMSToolStripMenuItem.Size=new Size( 134, 22 );
            aboutPMSToolStripMenuItem.Text="About PMS";
            // 
            // addPatientGroupBox
            // 
            addPatientGroupBox.Controls.Add( dashboardEmergencyNumberValue );
            addPatientGroupBox.Controls.Add( dashboardAddPatientButton );
            addPatientGroupBox.Controls.Add( label7 );
            addPatientGroupBox.Controls.Add( dashboardContactEmailValue );
            addPatientGroupBox.Controls.Add( label6 );
            addPatientGroupBox.Controls.Add( label5 );
            addPatientGroupBox.Controls.Add( dashboardContactNumberValue );
            addPatientGroupBox.Controls.Add( dashboardAdmissionDateValue );
            addPatientGroupBox.Controls.Add( label4 );
            addPatientGroupBox.Controls.Add( label3 );
            addPatientGroupBox.Controls.Add( dashboardMedicalProblemDescriptionValue );
            addPatientGroupBox.Controls.Add( dashboardMedicalProblemValue );
            addPatientGroupBox.Controls.Add( label2 );
            addPatientGroupBox.Controls.Add( dashboardPatientNameValue );
            addPatientGroupBox.Controls.Add( label1 );
            addPatientGroupBox.Dock=DockStyle.Fill;
            addPatientGroupBox.Location=new Point( 0, 24 );
            addPatientGroupBox.Name="addPatientGroupBox";
            addPatientGroupBox.Size=new Size( 916, 581 );
            addPatientGroupBox.TabIndex=1;
            addPatientGroupBox.TabStop=false;
            // 
            // dashboardEmergencyNumberValue
            // 
            dashboardEmergencyNumberValue.Location=new Point( 581, 124 );
            dashboardEmergencyNumberValue.Name="dashboardEmergencyNumberValue";
            dashboardEmergencyNumberValue.Size=new Size( 204, 23 );
            dashboardEmergencyNumberValue.TabIndex=13;
            // 
            // dashboardAddPatientButton
            // 
            dashboardAddPatientButton.Anchor=  AnchorStyles.Bottom | AnchorStyles.Right  ;
            dashboardAddPatientButton.Location=new Point( 803, 537 );
            dashboardAddPatientButton.Name="dashboardAddPatientButton";
            dashboardAddPatientButton.Size=new Size( 98, 32 );
            dashboardAddPatientButton.TabIndex=14;
            dashboardAddPatientButton.Text="Add Patient";
            dashboardAddPatientButton.UseVisualStyleBackColor=true;
            dashboardAddPatientButton.Click+=button1_Click;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point( 431, 127 );
            label7.Name="label7";
            label7.Size=new Size( 113, 15 );
            label7.TabIndex=12;
            label7.Text="Emergency Number";
            // 
            // dashboardContactEmailValue
            // 
            dashboardContactEmailValue.Location=new Point( 581, 74 );
            dashboardContactEmailValue.Name="dashboardContactEmailValue";
            dashboardContactEmailValue.Size=new Size( 204, 23 );
            dashboardContactEmailValue.TabIndex=11;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point( 431, 77 );
            label6.Name="label6";
            label6.Size=new Size( 36, 15 );
            label6.TabIndex=10;
            label6.Text="Email";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point( 431, 30 );
            label5.Name="label5";
            label5.Size=new Size( 71, 15 );
            label5.TabIndex=8;
            label5.Text="Contact No.";
            // 
            // dashboardContactNumberValue
            // 
            dashboardContactNumberValue.Location=new Point( 581, 27 );
            dashboardContactNumberValue.Name="dashboardContactNumberValue";
            dashboardContactNumberValue.Size=new Size( 204, 23 );
            dashboardContactNumberValue.TabIndex=9;
            // 
            // dashboardAdmissionDateValue
            // 
            dashboardAdmissionDateValue.Location=new Point( 136, 263 );
            dashboardAdmissionDateValue.Name="dashboardAdmissionDateValue";
            dashboardAdmissionDateValue.Size=new Size( 200, 23 );
            dashboardAdmissionDateValue.TabIndex=7;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point( 12, 269 );
            label4.Name="label4";
            label4.Size=new Size( 90, 15 );
            label4.TabIndex=6;
            label4.Text="Admission Date";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point( 12, 127 );
            label3.Name="label3";
            label3.Size=new Size( 102, 15 );
            label3.TabIndex=5;
            label3.Text="Illness Description";
            // 
            // dashboardMedicalProblemDescriptionValue
            // 
            dashboardMedicalProblemDescriptionValue.Location=new Point( 136, 127 );
            dashboardMedicalProblemDescriptionValue.Multiline=true;
            dashboardMedicalProblemDescriptionValue.Name="dashboardMedicalProblemDescriptionValue";
            dashboardMedicalProblemDescriptionValue.Size=new Size( 204, 97 );
            dashboardMedicalProblemDescriptionValue.TabIndex=4;
            // 
            // dashboardMedicalProblemValue
            // 
            dashboardMedicalProblemValue.Location=new Point( 136, 74 );
            dashboardMedicalProblemValue.Name="dashboardMedicalProblemValue";
            dashboardMedicalProblemValue.Size=new Size( 204, 23 );
            dashboardMedicalProblemValue.TabIndex=3;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point( 12, 74 );
            label2.Name="label2";
            label2.Size=new Size( 84, 15 );
            label2.TabIndex=2;
            label2.Text="Medical Illness";
            // 
            // dashboardPatientNameValue
            // 
            dashboardPatientNameValue.Location=new Point( 136, 27 );
            dashboardPatientNameValue.Name="dashboardPatientNameValue";
            dashboardPatientNameValue.Size=new Size( 204, 23 );
            dashboardPatientNameValue.TabIndex=1;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point( 12, 30 );
            label1.Name="label1";
            label1.Size=new Size( 79, 15 );
            label1.TabIndex=0;
            label1.Text="Patient Name";
            // 
            // dashboardMainGroupBox
            // 
            dashboardMainGroupBox.AutoSize=true;
            dashboardMainGroupBox.Dock=DockStyle.Fill;
            dashboardMainGroupBox.Location=new Point( 0, 24 );
            dashboardMainGroupBox.Name="dashboardMainGroupBox";
            dashboardMainGroupBox.Size=new Size( 916, 581 );
            dashboardMainGroupBox.TabIndex=15;
            dashboardMainGroupBox.TabStop=false;
            // 
            // editPatientGroupBox
            // 
            editPatientGroupBox.AutoSize=true;
            editPatientGroupBox.Controls.Add( dashboardPatientViewTable );
            editPatientGroupBox.Controls.Add( dashboardPatientTextValue );
            editPatientGroupBox.Dock=DockStyle.Fill;
            editPatientGroupBox.Location=new Point( 0, 24 );
            editPatientGroupBox.Name="editPatientGroupBox";
            editPatientGroupBox.Size=new Size( 916, 581 );
            editPatientGroupBox.TabIndex=15;
            editPatientGroupBox.TabStop=false;
            // 
            // dashboardPatientViewTable
            // 
            dashboardPatientViewTable.ColumnCount=5;
            dashboardPatientViewTable.ColumnStyles.Add( new ColumnStyle() );
            dashboardPatientViewTable.ColumnStyles.Add( new ColumnStyle() );
            dashboardPatientViewTable.ColumnStyles.Add( new ColumnStyle() );
            dashboardPatientViewTable.ColumnStyles.Add( new ColumnStyle() );
            dashboardPatientViewTable.ColumnStyles.Add( new ColumnStyle() );
            dashboardPatientViewTable.Controls.Add( dataGridView1, 4, 1 );
            dashboardPatientViewTable.Dock=DockStyle.Fill;
            dashboardPatientViewTable.Location=new Point( 3, 19 );
            dashboardPatientViewTable.Name="dashboardPatientViewTable";
            dashboardPatientViewTable.RowCount=2;
            dashboardPatientViewTable.RowStyles.Add( new RowStyle() );
            dashboardPatientViewTable.RowStyles.Add( new RowStyle() );
            dashboardPatientViewTable.Size=new Size( 910, 559 );
            dashboardPatientViewTable.TabIndex=1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode=DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor=Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock=DockStyle.Fill;
            dataGridView1.Location=new Point( 3, 3 );
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowTemplate.Height=25;
            dataGridView1.Size=new Size( 910, 559 );
            dataGridView1.TabIndex=0;
            // 
            // dashboardPatientTextValue
            // 
            dashboardPatientTextValue.Location=new Point( 29, 22 );
            dashboardPatientTextValue.Name="dashboardPatientTextValue";
            dashboardPatientTextValue.Size=new Size( 796, 23 );
            dashboardPatientTextValue.TabIndex=0;
            dashboardPatientTextValue.TextChanged+=dashboardPatientTextValue_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size( 61, 4 );
            // 
            // editPatientGroupBoxPopup
            // 
            editPatientGroupBoxPopup.Controls.Add( button2 );
            editPatientGroupBoxPopup.Controls.Add( editGroupBoxEmergencyNumber );
            editPatientGroupBoxPopup.Controls.Add( button1 );
            editPatientGroupBoxPopup.Controls.Add( label8 );
            editPatientGroupBoxPopup.Controls.Add( editGroupBoxEmail );
            editPatientGroupBoxPopup.Controls.Add( label9 );
            editPatientGroupBoxPopup.Controls.Add( label10 );
            editPatientGroupBoxPopup.Controls.Add( editGroupBoxContactNumber );
            editPatientGroupBoxPopup.Controls.Add( editGroupBoxAdmissionDate );
            editPatientGroupBoxPopup.Controls.Add( label11 );
            editPatientGroupBoxPopup.Controls.Add( label12 );
            editPatientGroupBoxPopup.Controls.Add( editGroupBoxIllnessDescription );
            editPatientGroupBoxPopup.Controls.Add( editGroupBoxMedicalIllness );
            editPatientGroupBoxPopup.Controls.Add( label13 );
            editPatientGroupBoxPopup.Controls.Add( editGroupBoxPatientName );
            editPatientGroupBoxPopup.Controls.Add( label14 );
            editPatientGroupBoxPopup.Dock=DockStyle.Fill;
            editPatientGroupBoxPopup.Location=new Point( 0, 24 );
            editPatientGroupBoxPopup.Name="editPatientGroupBoxPopup";
            editPatientGroupBoxPopup.Size=new Size( 916, 581 );
            editPatientGroupBoxPopup.TabIndex=15;
            editPatientGroupBoxPopup.TabStop=false;
            // 
            // button2
            // 
            button2.Anchor=  AnchorStyles.Bottom | AnchorStyles.Right  ;
            button2.Location=new Point( 816, 537 );
            button2.Name="button2";
            button2.Size=new Size( 88, 38 );
            button2.TabIndex=15;
            button2.Text="Edit Patient";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // editGroupBoxEmergencyNumber
            // 
            editGroupBoxEmergencyNumber.Location=new Point( 581, 124 );
            editGroupBoxEmergencyNumber.Name="editGroupBoxEmergencyNumber";
            editGroupBoxEmergencyNumber.Size=new Size( 204, 23 );
            editGroupBoxEmergencyNumber.TabIndex=13;
            // 
            // button1
            // 
            button1.Anchor=  AnchorStyles.Bottom | AnchorStyles.Right  ;
            button1.Location=new Point( 1519, 1018 );
            button1.Name="button1";
            button1.Size=new Size( 98, 32 );
            button1.TabIndex=14;
            button1.Text="Edit Patient";
            button1.UseVisualStyleBackColor=true;
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Location=new Point( 431, 127 );
            label8.Name="label8";
            label8.Size=new Size( 113, 15 );
            label8.TabIndex=12;
            label8.Text="Emergency Number";
            // 
            // editGroupBoxEmail
            // 
            editGroupBoxEmail.Location=new Point( 581, 74 );
            editGroupBoxEmail.Name="editGroupBoxEmail";
            editGroupBoxEmail.Size=new Size( 204, 23 );
            editGroupBoxEmail.TabIndex=11;
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Location=new Point( 431, 77 );
            label9.Name="label9";
            label9.Size=new Size( 36, 15 );
            label9.TabIndex=10;
            label9.Text="Email";
            // 
            // label10
            // 
            label10.AutoSize=true;
            label10.Location=new Point( 431, 30 );
            label10.Name="label10";
            label10.Size=new Size( 71, 15 );
            label10.TabIndex=8;
            label10.Text="Contact No.";
            // 
            // editGroupBoxContactNumber
            // 
            editGroupBoxContactNumber.Location=new Point( 581, 27 );
            editGroupBoxContactNumber.Name="editGroupBoxContactNumber";
            editGroupBoxContactNumber.Size=new Size( 204, 23 );
            editGroupBoxContactNumber.TabIndex=9;
            // 
            // editGroupBoxAdmissionDate
            // 
            editGroupBoxAdmissionDate.Location=new Point( 136, 263 );
            editGroupBoxAdmissionDate.Name="editGroupBoxAdmissionDate";
            editGroupBoxAdmissionDate.Size=new Size( 200, 23 );
            editGroupBoxAdmissionDate.TabIndex=7;
            // 
            // label11
            // 
            label11.AutoSize=true;
            label11.Location=new Point( 12, 269 );
            label11.Name="label11";
            label11.Size=new Size( 90, 15 );
            label11.TabIndex=6;
            label11.Text="Admission Date";
            // 
            // label12
            // 
            label12.AutoSize=true;
            label12.Location=new Point( 12, 127 );
            label12.Name="label12";
            label12.Size=new Size( 102, 15 );
            label12.TabIndex=5;
            label12.Text="Illness Description";
            // 
            // editGroupBoxIllnessDescription
            // 
            editGroupBoxIllnessDescription.Location=new Point( 136, 127 );
            editGroupBoxIllnessDescription.Multiline=true;
            editGroupBoxIllnessDescription.Name="editGroupBoxIllnessDescription";
            editGroupBoxIllnessDescription.Size=new Size( 204, 97 );
            editGroupBoxIllnessDescription.TabIndex=4;
            // 
            // editGroupBoxMedicalIllness
            // 
            editGroupBoxMedicalIllness.Location=new Point( 136, 74 );
            editGroupBoxMedicalIllness.Name="editGroupBoxMedicalIllness";
            editGroupBoxMedicalIllness.Size=new Size( 204, 23 );
            editGroupBoxMedicalIllness.TabIndex=3;
            // 
            // label13
            // 
            label13.AutoSize=true;
            label13.Location=new Point( 12, 74 );
            label13.Name="label13";
            label13.Size=new Size( 84, 15 );
            label13.TabIndex=2;
            label13.Text="Medical Illness";
            // 
            // editGroupBoxPatientName
            // 
            editGroupBoxPatientName.Location=new Point( 136, 27 );
            editGroupBoxPatientName.Name="editGroupBoxPatientName";
            editGroupBoxPatientName.Size=new Size( 204, 23 );
            editGroupBoxPatientName.TabIndex=1;
            // 
            // label14
            // 
            label14.AutoSize=true;
            label14.Location=new Point( 12, 30 );
            label14.Name="label14";
            label14.Size=new Size( 79, 15 );
            label14.TabIndex=0;
            label14.Text="Patient Name";
            // 
            // Dashboard
            // 
            AutoScaleDimensions=new SizeF( 7F, 15F );
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size( 916, 605 );
            Controls.Add( editPatientGroupBox );
            Controls.Add( editPatientGroupBoxPopup );
            Controls.Add( addPatientGroupBox );
            Controls.Add( dashboardMainGroupBox );
            Controls.Add( menuStrip1 );
            MainMenuStrip=menuStrip1;
            Name="Dashboard";
            Text="Dashboard";
            menuStrip1.ResumeLayout( false );
            menuStrip1.PerformLayout();
            addPatientGroupBox.ResumeLayout( false );
            addPatientGroupBox.PerformLayout();
            editPatientGroupBox.ResumeLayout( false );
            editPatientGroupBox.PerformLayout();
            dashboardPatientViewTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) dataGridView1  ).EndInit();
            editPatientGroupBoxPopup.ResumeLayout( false );
            editPatientGroupBoxPopup.PerformLayout();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardMenuFileButton;
        private ToolStripMenuItem addPatientToolStripMenuItem;
        private ToolStripMenuItem editPatientToolStripMenuItem;
        private ToolStripMenuItem deletePatientToolStripMenuItem;
        private ToolStripMenuItem dashboardMenuAboutButton;
        private GroupBox addPatientGroupBox;
        private Label label1;
        private TextBox dashboardMedicalProblemValue;
        private Label label2;
        private TextBox dashboardPatientNameValue;
        private Label label3;
        private TextBox dashboardMedicalProblemDescriptionValue;
        private DateTimePicker dashboardAdmissionDateValue;
        private Label label4;
        private Button dashboardAddPatientButton;
        private TextBox dashboardEmergencyNumberValue;
        private Label label7;
        private TextBox dashboardContactEmailValue;
        private Label label6;
        private TextBox dashboardContactNumberValue;
        private Label label5;
        private GroupBox editPatientGroupBox;
        private ToolStripMenuItem aboutPMSToolStripMenuItem;
        private TextBox dashboardPatientTextValue;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox dashboardMainGroupBox;
        private TableLayoutPanel dashboardPatientViewTable;
        private DataGridView dataGridView1;
        private GroupBox editPatientGroupBoxPopup;
        private TextBox editGroupBoxEmergencyNumber;
        private Button button1;
        private Label label8;
        private TextBox editGroupBoxEmail;
        private Label label9;
        private Label label10;
        private TextBox editGroupBoxContactNumber;
        private DateTimePicker editGroupBoxAdmissionDate;
        private Label label11;
        private Label label12;
        private TextBox editGroupBoxIllnessDescription;
        private TextBox editGroupBoxMedicalIllness;
        private Label label13;
        private TextBox editGroupBoxPatientName;
        private Label label14;
        private Button button2;
    }
}
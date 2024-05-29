namespace HotelManagementSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            loginUsername=new TextBox();
            loginPassword=new TextBox();
            loginButton=new Button();
            linkLabel1=new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font( "Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point );
            label1.Location=new Point( 357, 66 );
            label1.Name="label1";
            label1.Size=new Size( 95, 37 );
            label1.TabIndex=0;
            label1.Text="LOGIN";
            // 
            // loginUsername
            // 
            loginUsername.AccessibleName="loginUsernameValue";
            loginUsername.Anchor=    AnchorStyles.Top | AnchorStyles.Bottom  | AnchorStyles.Left  | AnchorStyles.Right  ;
            loginUsername.Location=new Point( 314, 142 );
            loginUsername.Name="loginUsername";
            loginUsername.Size=new Size( 188, 23 );
            loginUsername.TabIndex=1;
            // 
            // loginPassword
            // 
            loginPassword.AccessibleName="loginPasswordValue";
            loginPassword.Anchor=    AnchorStyles.Top | AnchorStyles.Bottom  | AnchorStyles.Left  | AnchorStyles.Right  ;
            loginPassword.Location=new Point( 314, 200 );
            loginPassword.Name="loginPassword";
            loginPassword.Size=new Size( 188, 23 );
            loginPassword.TabIndex=2;
            // 
            // loginButton
            // 
            loginButton.Anchor=    AnchorStyles.Top | AnchorStyles.Bottom  | AnchorStyles.Left  | AnchorStyles.Right  ;
            loginButton.Location=new Point( 377, 271 );
            loginButton.Name="loginButton";
            loginButton.Size=new Size( 75, 23 );
            loginButton.TabIndex=3;
            loginButton.Text="Sign In";
            loginButton.UseVisualStyleBackColor=true;
            loginButton.Click+=button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize=true;
            linkLabel1.Location=new Point( 325, 312 );
            linkLabel1.Name="linkLabel1";
            linkLabel1.Size=new Size( 191, 15 );
            linkLabel1.TabIndex=4;
            linkLabel1.TabStop=true;
            linkLabel1.Text="No Account ? Create New Account";
            linkLabel1.LinkClicked+=linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions=new SizeF( 7F, 15F );
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size( 800, 450 );
            Controls.Add( linkLabel1 );
            Controls.Add( loginButton );
            Controls.Add( loginPassword );
            Controls.Add( loginUsername );
            Controls.Add( label1 );
            Name="Login";
            Text="Form1";
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginUsername;
        private TextBox loginPassword;
        private Button loginButton;
        private LinkLabel linkLabel1;
    }
}
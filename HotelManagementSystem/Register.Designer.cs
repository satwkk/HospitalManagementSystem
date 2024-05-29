namespace HotelManagementSystem
{
    partial class Register
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
            label1=new Label();
            label2=new Label();
            registerUsernameValue=new TextBox();
            label3=new Label();
            registerEmailValue=new TextBox();
            label4=new Label();
            registerPasswordValue=new TextBox();
            label5=new Label();
            registerConfirmPasswordValue=new TextBox();
            button1=new Button();
            linkLabel1=new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font( "Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point );
            label1.Location=new Point( 279, 9 );
            label1.Name="label1";
            label1.Size=new Size( 191, 54 );
            label1.TabIndex=0;
            label1.Text="REGISTER";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point( 229, 99 );
            label2.Name="label2";
            label2.Size=new Size( 60, 15 );
            label2.TabIndex=1;
            label2.Text="Username";
            label2.Click+=label2_Click;
            // 
            // registerUsernameValue
            // 
            registerUsernameValue.Location=new Point( 391, 91 );
            registerUsernameValue.Name="registerUsernameValue";
            registerUsernameValue.Size=new Size( 190, 23 );
            registerUsernameValue.TabIndex=2;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point( 229, 146 );
            label3.Name="label3";
            label3.Size=new Size( 36, 15 );
            label3.TabIndex=3;
            label3.Text="Email";
            // 
            // registerEmailValue
            // 
            registerEmailValue.Location=new Point( 391, 138 );
            registerEmailValue.Name="registerEmailValue";
            registerEmailValue.Size=new Size( 190, 23 );
            registerEmailValue.TabIndex=4;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point( 229, 190 );
            label4.Name="label4";
            label4.Size=new Size( 57, 15 );
            label4.TabIndex=5;
            label4.Text="Password";
            // 
            // registerPasswordValue
            // 
            registerPasswordValue.Location=new Point( 391, 187 );
            registerPasswordValue.Name="registerPasswordValue";
            registerPasswordValue.Size=new Size( 190, 23 );
            registerPasswordValue.TabIndex=6;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point( 229, 242 );
            label5.Name="label5";
            label5.Size=new Size( 104, 15 );
            label5.TabIndex=7;
            label5.Text="Confirm Password";
            // 
            // registerConfirmPasswordValue
            // 
            registerConfirmPasswordValue.Location=new Point( 391, 234 );
            registerConfirmPasswordValue.Name="registerConfirmPasswordValue";
            registerConfirmPasswordValue.Size=new Size( 190, 23 );
            registerConfirmPasswordValue.TabIndex=8;
            // 
            // button1
            // 
            button1.Location=new Point( 318, 291 );
            button1.Name="button1";
            button1.Size=new Size( 116, 34 );
            button1.TabIndex=9;
            button1.Text="Sign up";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize=true;
            linkLabel1.Location=new Point( 302, 342 );
            linkLabel1.Name="linkLabel1";
            linkLabel1.Size=new Size( 168, 15 );
            linkLabel1.TabIndex=10;
            linkLabel1.TabStop=true;
            linkLabel1.Text="Already have account ? Sign in";
            linkLabel1.LinkClicked+=linkLabel1_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions=new SizeF( 7F, 15F );
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size( 800, 450 );
            Controls.Add( linkLabel1 );
            Controls.Add( button1 );
            Controls.Add( registerConfirmPasswordValue );
            Controls.Add( label5 );
            Controls.Add( registerPasswordValue );
            Controls.Add( label4 );
            Controls.Add( registerEmailValue );
            Controls.Add( label3 );
            Controls.Add( registerUsernameValue );
            Controls.Add( label2 );
            Controls.Add( label1 );
            Name="Register";
            Text="Form1";
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox registerUsernameValue;
        private Label label3;
        private TextBox registerEmailValue;
        private Label label4;
        private TextBox registerPasswordValue;
        private Label label5;
        private TextBox registerConfirmPasswordValue;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}
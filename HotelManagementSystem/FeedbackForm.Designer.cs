namespace HotelManagementSystem
{
    partial class FeedbackForm
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
            feedbackStringLabel=new Label();
            imageList1=new ImageList( components );
            SuspendLayout();
            // 
            // feedbackStringLabel
            // 
            feedbackStringLabel.Anchor=  AnchorStyles.Left | AnchorStyles.Right  ;
            feedbackStringLabel.AutoSize=true;
            feedbackStringLabel.Font=new Font( "Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point );
            feedbackStringLabel.Location=new Point( 141, 44 );
            feedbackStringLabel.Name="feedbackStringLabel";
            feedbackStringLabel.Size=new Size( 65, 28 );
            feedbackStringLabel.TabIndex=0;
            feedbackStringLabel.Text="label1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth=ColorDepth.Depth8Bit;
            imageList1.ImageSize=new Size( 16, 16 );
            imageList1.TransparentColor=Color.Transparent;
            // 
            // Success
            // 
            AutoScaleDimensions=new SizeF( 7F, 15F );
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            ClientSize=new Size( 367, 138 );
            Controls.Add( feedbackStringLabel );
            Name="Success";
            Text="Success";
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Label feedbackStringLabel;
        private ImageList imageList1;
    }
}
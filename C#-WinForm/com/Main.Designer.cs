using static System.Net.Mime.MediaTypeNames;

namespace com
{
	partial class Main
	{
		private System.ComponentModel.IContainer components = null;
		private Button btnInitializeCOM;
		private Button btnUninitializeCOM;
		private Button btnInitializeWMI;
		private Button btnUninitializeWMI;
		private Label lblCOMStatus;
		private Label lblWMIStatus;
		private PictureBox pictureBoxCOM;
		private PictureBox pictureBoxWMI;

		private void InitializeComponent()
		{
			btnInitializeCOM = new Button();
			btnUninitializeCOM = new Button();
			btnInitializeWMI = new Button();
			btnUninitializeWMI = new Button();
			lblCOMStatus = new Label();
			lblWMIStatus = new Label();
			pictureBoxCOM = new PictureBox();
			pictureBoxWMI = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBoxCOM).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxWMI).BeginInit();
			SuspendLayout();
			// 
			// btnInitializeCOM
			// 
			btnInitializeCOM.BackColor = Color.FromArgb(33, 33, 33);
			btnInitializeCOM.BackgroundImageLayout = ImageLayout.None;
			btnInitializeCOM.FlatStyle = FlatStyle.Flat;
			btnInitializeCOM.ForeColor = Color.White;
			btnInitializeCOM.Location = new Point(12, 12);
			btnInitializeCOM.Name = "btnInitializeCOM";
			btnInitializeCOM.Size = new Size(120, 23);
			btnInitializeCOM.TabIndex = 0;
			btnInitializeCOM.Text = "Initialize COM";
			btnInitializeCOM.UseVisualStyleBackColor = false;
			btnInitializeCOM.Click += btnInitializeCOM_Click;
			// 
			// btnUninitializeCOM
			// 
			btnUninitializeCOM.BackColor = Color.FromArgb(33, 33, 33);
			btnUninitializeCOM.FlatStyle = FlatStyle.Flat;
			btnUninitializeCOM.ForeColor = Color.White;
			btnUninitializeCOM.Location = new Point(12, 41);
			btnUninitializeCOM.Name = "btnUninitializeCOM";
			btnUninitializeCOM.Size = new Size(120, 23);
			btnUninitializeCOM.TabIndex = 1;
			btnUninitializeCOM.Text = "Uninitialize COM";
			btnUninitializeCOM.UseVisualStyleBackColor = false;
			btnUninitializeCOM.Click += btnUninitializeCOM_Click;
			// 
			// btnInitializeWMI
			// 
			btnInitializeWMI.BackColor = Color.FromArgb(33, 33, 33);
			btnInitializeWMI.FlatStyle = FlatStyle.Flat;
			btnInitializeWMI.ForeColor = Color.White;
			btnInitializeWMI.Location = new Point(12, 70);
			btnInitializeWMI.Name = "btnInitializeWMI";
			btnInitializeWMI.Size = new Size(120, 23);
			btnInitializeWMI.TabIndex = 2;
			btnInitializeWMI.Text = "Initialize WMI";
			btnInitializeWMI.UseVisualStyleBackColor = false;
			btnInitializeWMI.Click += btnInitializeWMI_Click;
			// 
			// btnUninitializeWMI
			// 
			btnUninitializeWMI.BackColor = Color.FromArgb(33, 33, 33);
			btnUninitializeWMI.FlatStyle = FlatStyle.Flat;
			btnUninitializeWMI.ForeColor = Color.White;
			btnUninitializeWMI.Location = new Point(12, 99);
			btnUninitializeWMI.Name = "btnUninitializeWMI";
			btnUninitializeWMI.Size = new Size(120, 23);
			btnUninitializeWMI.TabIndex = 3;
			btnUninitializeWMI.Text = "Uninitialize WMI";
			btnUninitializeWMI.UseVisualStyleBackColor = false;
			btnUninitializeWMI.Click += btnUninitializeWMI_Click;
			// 
			// lblCOMStatus
			// 
			lblCOMStatus.AutoSize = true;
			lblCOMStatus.Location = new Point(150, 17);
			lblCOMStatus.Name = "lblCOMStatus";
			lblCOMStatus.ForeColor = Color.White; // Yazı rengini beyaz olarak ayarlayın
			lblCOMStatus.Size = new Size(0, 15);
			lblCOMStatus.TabIndex = 4;

			// 
			// lblWMIStatus
			// 
			lblWMIStatus.AutoSize = true;
			lblWMIStatus.Location = new Point(150, 75);
			lblWMIStatus.Name = "lblWMIStatus";
			lblWMIStatus.ForeColor = Color.White; // Yazı rengini beyaz olarak ayarlayın
			lblWMIStatus.Size = new Size(0, 15);
			lblWMIStatus.TabIndex = 5;

			// 
			// pictureBoxCOM
			// 
			pictureBoxCOM.BackColor = Color.Red;
			pictureBoxCOM.BackgroundImageLayout = ImageLayout.None;
			pictureBoxCOM.Location = new Point(12, 153);
			pictureBoxCOM.Name = "pictureBoxCOM";
			pictureBoxCOM.Size = new Size(35, 23);
			pictureBoxCOM.TabIndex = 6;
			pictureBoxCOM.TabStop = false;
			pictureBoxCOM.Click += pictureBoxCOM_Click;
			// 
			// pictureBoxWMI
			// 
			pictureBoxWMI.BackColor = Color.Red;
			pictureBoxWMI.Location = new Point(100, 153);
			pictureBoxWMI.Name = "pictureBoxWMI";
			pictureBoxWMI.Size = new Size(32, 23);
			pictureBoxWMI.TabIndex = 7;
			pictureBoxWMI.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.White;
			label1.Location = new Point(12, 135);
			label1.Name = "label1";
			label1.Size = new Size(35, 15);
			label1.TabIndex = 8;
			label1.Text = "COM";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.White;
			label2.Location = new Point(100, 135);
			label2.Name = "label2";
			label2.Size = new Size(32, 15);
			label2.TabIndex = 9;
			label2.Text = "WMI";
			// 
			// Main
			// 
			BackColor = Color.FromArgb(22, 22, 22);
			ClientSize = new Size(600, 200);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBoxWMI);
			Controls.Add(pictureBoxCOM);
			Controls.Add(lblWMIStatus);
			Controls.Add(lblCOMStatus);
			Controls.Add(btnUninitializeWMI);
			Controls.Add(btnInitializeWMI);
			Controls.Add(btnUninitializeCOM);
			Controls.Add(btnInitializeCOM);
			Name = "Main";
			Text = "COM & WMI Starter";
			((System.ComponentModel.ISupportInitialize)pictureBoxCOM).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxWMI).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private Label label1;
		private Label label2;
	}
}

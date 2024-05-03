namespace QuietAttic
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            productionBtn = new Button();
            clientBtn = new Button();
            staffBtn = new Button();
            staffTypeBtn = new Button();
            propertyBtn = new Button();
            propertyTypeBtn = new Button();
            locationBtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // productionBtn
            // 
            productionBtn.BackColor = SystemColors.ActiveCaption;
            productionBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productionBtn.Location = new Point(307, 173);
            productionBtn.Name = "productionBtn";
            productionBtn.Size = new Size(171, 57);
            productionBtn.TabIndex = 1;
            productionBtn.Text = "PRODUCTION";
            productionBtn.UseVisualStyleBackColor = false;
            // 
            // clientBtn
            // 
            clientBtn.BackColor = SystemColors.ActiveCaption;
            clientBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientBtn.Location = new Point(47, 56);
            clientBtn.Name = "clientBtn";
            clientBtn.Size = new Size(171, 57);
            clientBtn.TabIndex = 2;
            clientBtn.Text = "CLIENT";
            clientBtn.UseVisualStyleBackColor = false;
            clientBtn.Click += clientBtn_Click;
            // 
            // staffBtn
            // 
            staffBtn.BackColor = SystemColors.ActiveCaption;
            staffBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffBtn.Location = new Point(47, 173);
            staffBtn.Name = "staffBtn";
            staffBtn.Size = new Size(171, 57);
            staffBtn.TabIndex = 3;
            staffBtn.Text = "STAFF";
            staffBtn.UseVisualStyleBackColor = false;
            staffBtn.Click += staffBtn_Click;
            // 
            // staffTypeBtn
            // 
            staffTypeBtn.BackColor = SystemColors.ActiveCaption;
            staffTypeBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffTypeBtn.Location = new Point(47, 299);
            staffTypeBtn.Name = "staffTypeBtn";
            staffTypeBtn.Size = new Size(171, 57);
            staffTypeBtn.TabIndex = 4;
            staffTypeBtn.Text = "STAFF TYPE";
            staffTypeBtn.UseVisualStyleBackColor = false;
            staffTypeBtn.Click += staffTypeBtn_Click;
            // 
            // propertyBtn
            // 
            propertyBtn.BackColor = SystemColors.ActiveCaption;
            propertyBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            propertyBtn.Location = new Point(578, 173);
            propertyBtn.Name = "propertyBtn";
            propertyBtn.Size = new Size(187, 57);
            propertyBtn.TabIndex = 5;
            propertyBtn.Text = "PROPERTY";
            propertyBtn.UseVisualStyleBackColor = false;
            propertyBtn.Click += propertyBtn_Click;
            // 
            // propertyTypeBtn
            // 
            propertyTypeBtn.BackColor = SystemColors.ActiveCaption;
            propertyTypeBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            propertyTypeBtn.Location = new Point(578, 299);
            propertyTypeBtn.Name = "propertyTypeBtn";
            propertyTypeBtn.Size = new Size(187, 57);
            propertyTypeBtn.TabIndex = 6;
            propertyTypeBtn.Text = "PROPERTY TYPE";
            propertyTypeBtn.UseVisualStyleBackColor = false;
            propertyTypeBtn.Click += propertyTypeBtn_Click;
            // 
            // locationBtn
            // 
            locationBtn.BackColor = SystemColors.ActiveCaption;
            locationBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            locationBtn.Location = new Point(578, 56);
            locationBtn.Name = "locationBtn";
            locationBtn.Size = new Size(187, 57);
            locationBtn.TabIndex = 7;
            locationBtn.Text = "LOCATION";
            locationBtn.UseVisualStyleBackColor = false;
            locationBtn.Click += locationBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(locationBtn);
            Controls.Add(propertyTypeBtn);
            Controls.Add(propertyBtn);
            Controls.Add(staffTypeBtn);
            Controls.Add(staffBtn);
            Controls.Add(clientBtn);
            Controls.Add(productionBtn);
            Controls.Add(button1);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button productionBtn;
        private Button clientBtn;
        private Button staffBtn;
        private Button staffTypeBtn;
        private Button propertyBtn;
        private Button propertyTypeBtn;
        private Button locationBtn;
    }
}
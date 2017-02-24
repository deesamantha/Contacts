namespace Contacts
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.lblErr = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.pbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.White;
            this.tbLastName.Location = new System.Drawing.Point(228, 112);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 25;
            this.tbLastName.Text = "Last";
            // 
            // pbSave
            // 
            this.pbSave.Image = global::Contacts.Properties.Resources.commit;
            this.pbSave.Location = new System.Drawing.Point(427, 261);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(16, 16);
            this.pbSave.TabIndex = 24;
            this.pbSave.TabStop = false;
            // 
            // pbEdit
            // 
            this.pbEdit.Image = global::Contacts.Properties.Resources.delete;
            this.pbEdit.Location = new System.Drawing.Point(405, 261);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(16, 16);
            this.pbEdit.TabIndex = 23;
            this.pbEdit.TabStop = false;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Location = new System.Drawing.Point(143, 292);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 13);
            this.lblErr.TabIndex = 22;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(151, 181);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(177, 20);
            this.tbEmail.TabIndex = 21;
            this.tbEmail.Text = "Email";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.White;
            this.tbPhone.Location = new System.Drawing.Point(151, 140);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(177, 20);
            this.tbPhone.TabIndex = 20;
            this.tbPhone.Text = "Phone";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(129, 112);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(93, 20);
            this.tbFirstName.TabIndex = 19;
            this.tbFirstName.Text = "First";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Contacts.Properties.Resources.email;
            this.pictureBox3.Location = new System.Drawing.Point(129, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Contacts.Properties.Resources.phone;
            this.pictureBox2.Location = new System.Drawing.Point(129, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.LargeImageList = this.largeImageList;
            this.listView1.Location = new System.Drawing.Point(0, 292);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(461, 234);
            this.listView1.SmallImageList = this.smallImageList;
            this.listView1.TabIndex = 16;
            this.listView1.TileSize = new System.Drawing.Size(200, 200);
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contacts";
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "profile.png");
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "profile16x16.png");
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::Contacts.Properties.Resources.profile;
            this.pbIcon.Location = new System.Drawing.Point(209, 71);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(32, 32);
            this.pbIcon.TabIndex = 15;
            this.pbIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 526);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pbIcon);
            this.Name = "Form1";
            this.Text = "Contacts";
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ImageList largeImageList;
        private System.Windows.Forms.ImageList smallImageList;
    }
}


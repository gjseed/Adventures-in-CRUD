
namespace Adventures_in_CRUD_
{
    partial class CustomerForm
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
            this.FirstName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.MNameBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.LoadCust = new System.Windows.Forms.Button();
            this.CName = new System.Windows.Forms.TextBox();
            this.CompanyName = new System.Windows.Forms.Label();
            this.EmailAddress = new System.Windows.Forms.Label();
            this.EAddress = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.AddressT = new System.Windows.Forms.Label();
            this.AddT = new System.Windows.Forms.TextBox();
            this.AddL1 = new System.Windows.Forms.Label();
            this.AddLine1 = new System.Windows.Forms.TextBox();
            this.AddLine2 = new System.Windows.Forms.TextBox();
            this.AddL2 = new System.Windows.Forms.Label();
            this.StBox = new System.Windows.Forms.TextBox();
            this.PcBox = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.PostalC = new System.Windows.Forms.Label();
            this.ShowProd = new System.Windows.Forms.Button();
            this.CustID = new System.Windows.Forms.Label();
            this.CustIDbox = new System.Windows.Forms.TextBox();
            this.Insertbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(84, 36);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(54, 13);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "FirstName";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(84, 75);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(66, 13);
            this.MiddleName.TabIndex = 1;
            this.MiddleName.Text = "MiddleName";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(84, 114);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(55, 13);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "LastName";
            // 
            // FNameBox
            // 
            this.FNameBox.Location = new System.Drawing.Point(64, 52);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(100, 20);
            this.FNameBox.TabIndex = 3;
            // 
            // MNameBox
            // 
            this.MNameBox.Location = new System.Drawing.Point(64, 91);
            this.MNameBox.Name = "MNameBox";
            this.MNameBox.Size = new System.Drawing.Size(100, 20);
            this.MNameBox.TabIndex = 4;
            // 
            // LNameBox
            // 
            this.LNameBox.Location = new System.Drawing.Point(64, 130);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(100, 20);
            this.LNameBox.TabIndex = 5;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(33, 484);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(128, 484);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(222, 52);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(861, 482);
            this.Grid.TabIndex = 10;
            // 
            // LoadCust
            // 
            this.LoadCust.Location = new System.Drawing.Point(255, 23);
            this.LoadCust.Name = "LoadCust";
            this.LoadCust.Size = new System.Drawing.Size(179, 23);
            this.LoadCust.TabIndex = 11;
            this.LoadCust.Text = "Show Customers Table\r\n";
            this.LoadCust.UseVisualStyleBackColor = false;
            this.LoadCust.Click += new System.EventHandler(this.CustLoad_Click);
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(64, 169);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(100, 20);
            this.CName.TabIndex = 12;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(68, 153);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(82, 13);
            this.CompanyName.TabIndex = 13;
            this.CompanyName.Text = "Company Name";
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSize = true;
            this.EmailAddress.Location = new System.Drawing.Point(77, 192);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(73, 13);
            this.EmailAddress.TabIndex = 14;
            this.EmailAddress.Text = "Email Address";
            // 
            // EAddress
            // 
            this.EAddress.Location = new System.Drawing.Point(64, 208);
            this.EAddress.Name = "EAddress";
            this.EAddress.Size = new System.Drawing.Size(100, 20);
            this.EAddress.TabIndex = 15;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(96, 387);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(32, 13);
            this.State.TabIndex = 16;
            this.State.Text = "State";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(64, 364);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 17;
            // 
            // AddressT
            // 
            this.AddressT.AutoSize = true;
            this.AddressT.Location = new System.Drawing.Point(76, 231);
            this.AddressT.Name = "AddressT";
            this.AddressT.Size = new System.Drawing.Size(72, 13);
            this.AddressT.TabIndex = 18;
            this.AddressT.Text = "Address Type";
            // 
            // AddT
            // 
            this.AddT.Location = new System.Drawing.Point(64, 247);
            this.AddT.Name = "AddT";
            this.AddT.Size = new System.Drawing.Size(100, 20);
            this.AddT.TabIndex = 19;
            // 
            // AddL1
            // 
            this.AddL1.AutoSize = true;
            this.AddL1.Location = new System.Drawing.Point(71, 270);
            this.AddL1.Name = "AddL1";
            this.AddL1.Size = new System.Drawing.Size(77, 13);
            this.AddL1.TabIndex = 20;
            this.AddL1.Text = "Address Line 1";
            // 
            // AddLine1
            // 
            this.AddLine1.Location = new System.Drawing.Point(64, 286);
            this.AddLine1.Name = "AddLine1";
            this.AddLine1.Size = new System.Drawing.Size(100, 20);
            this.AddLine1.TabIndex = 21;
            // 
            // AddLine2
            // 
            this.AddLine2.Location = new System.Drawing.Point(64, 325);
            this.AddLine2.Name = "AddLine2";
            this.AddLine2.Size = new System.Drawing.Size(100, 20);
            this.AddLine2.TabIndex = 22;
            // 
            // AddL2
            // 
            this.AddL2.AutoSize = true;
            this.AddL2.Location = new System.Drawing.Point(71, 309);
            this.AddL2.Name = "AddL2";
            this.AddL2.Size = new System.Drawing.Size(77, 13);
            this.AddL2.TabIndex = 23;
            this.AddL2.Text = "Address Line 2";
            // 
            // StBox
            // 
            this.StBox.Location = new System.Drawing.Point(64, 403);
            this.StBox.Name = "StBox";
            this.StBox.Size = new System.Drawing.Size(100, 20);
            this.StBox.TabIndex = 24;
            // 
            // PcBox
            // 
            this.PcBox.Location = new System.Drawing.Point(64, 442);
            this.PcBox.Name = "PcBox";
            this.PcBox.Size = new System.Drawing.Size(100, 20);
            this.PcBox.TabIndex = 26;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(96, 348);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(24, 13);
            this.City.TabIndex = 27;
            this.City.Text = "City";
            // 
            // PostalC
            // 
            this.PostalC.AutoSize = true;
            this.PostalC.Location = new System.Drawing.Point(84, 426);
            this.PostalC.Name = "PostalC";
            this.PostalC.Size = new System.Drawing.Size(61, 13);
            this.PostalC.TabIndex = 28;
            this.PostalC.Text = "PostalCode";
            // 
            // ShowProd
            // 
            this.ShowProd.Location = new System.Drawing.Point(468, 23);
            this.ShowProd.Name = "ShowProd";
            this.ShowProd.Size = new System.Drawing.Size(167, 23);
            this.ShowProd.TabIndex = 29;
            this.ShowProd.Text = "Show Product Table";
            this.ShowProd.UseVisualStyleBackColor = true;
            this.ShowProd.Click += new System.EventHandler(this.LoadProd_Click);
            // 
            // CustID
            // 
            this.CustID.AutoSize = true;
            this.CustID.Location = new System.Drawing.Point(2, 8);
            this.CustID.Name = "CustID";
            this.CustID.Size = new System.Drawing.Size(65, 13);
            this.CustID.TabIndex = 30;
            this.CustID.Text = "Customer ID";
            // 
            // CustIDbox
            // 
            this.CustIDbox.Location = new System.Drawing.Point(73, 5);
            this.CustIDbox.Name = "CustIDbox";
            this.CustIDbox.Size = new System.Drawing.Size(130, 20);
            this.CustIDbox.TabIndex = 31;
            // 
            // Insertbtn
            // 
            this.Insertbtn.Location = new System.Drawing.Point(80, 511);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(75, 23);
            this.Insertbtn.TabIndex = 32;
            this.Insertbtn.Text = "Insert New";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 546);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.CustIDbox);
            this.Controls.Add(this.CustID);
            this.Controls.Add(this.ShowProd);
            this.Controls.Add(this.PostalC);
            this.Controls.Add(this.City);
            this.Controls.Add(this.PcBox);
            this.Controls.Add(this.StBox);
            this.Controls.Add(this.AddL2);
            this.Controls.Add(this.AddLine2);
            this.Controls.Add(this.AddLine1);
            this.Controls.Add(this.AddL1);
            this.Controls.Add(this.AddT);
            this.Controls.Add(this.AddressT);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.State);
            this.Controls.Add(this.EAddress);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.LoadCust);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.MNameBox);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox MNameBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button LoadCust;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Label EmailAddress;
        private System.Windows.Forms.TextBox EAddress;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label AddressT;
        private System.Windows.Forms.TextBox AddT;
        private System.Windows.Forms.Label AddL1;
        private System.Windows.Forms.TextBox AddLine1;
        private System.Windows.Forms.TextBox AddLine2;
        private System.Windows.Forms.Label AddL2;
        private System.Windows.Forms.TextBox StBox;
        private System.Windows.Forms.TextBox PcBox;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label PostalC;
        private System.Windows.Forms.Button ShowProd;
        private System.Windows.Forms.Label CustID;
        private System.Windows.Forms.TextBox CustIDbox;
        private System.Windows.Forms.Button Insertbtn;
    }
}
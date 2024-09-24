namespace winda1.DBContext
{
    partial class FormAddUsers
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logintextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxname2 = new System.Windows.Forms.TextBox();
            this.comboBoxroleID = new System.Windows.Forms.ComboBox();
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menradioButton = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.woradioButton = new System.Windows.Forms.RadioButton();
            this.buttonADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(23, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(234, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление нового пользователя";
            // 
            // logintextBox
            // 
            this.logintextBox.Location = new System.Drawing.Point(166, 154);
            this.logintextBox.Name = "logintextBox";
            this.logintextBox.Size = new System.Drawing.Size(112, 20);
            this.logintextBox.TabIndex = 2;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(166, 200);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(112, 20);
            this.passwordtextBox.TabIndex = 3;
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Location = new System.Drawing.Point(166, 241);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.PasswordChar = '*';
            this.passwordtextBox2.Size = new System.Drawing.Size(112, 20);
            this.passwordtextBox2.TabIndex = 4;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(166, 290);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(112, 20);
            this.emailtextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Повтор пароля:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Эл.почта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Телефон:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(491, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Имя:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(491, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Фамилия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(491, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Роль:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(491, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Пол:";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(648, 153);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(117, 20);
            this.textBoxname.TabIndex = 16;
            // 
            // textBoxname2
            // 
            this.textBoxname2.Location = new System.Drawing.Point(648, 200);
            this.textBoxname2.Name = "textBoxname2";
            this.textBoxname2.Size = new System.Drawing.Size(117, 20);
            this.textBoxname2.TabIndex = 17;
            // 
            // comboBoxroleID
            // 
            this.comboBoxroleID.DataSource = this.BindingSource1;
            this.comboBoxroleID.DisplayMember = "Name";
            this.comboBoxroleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxroleID.FormattingEnabled = true;
            this.comboBoxroleID.Location = new System.Drawing.Point(648, 239);
            this.comboBoxroleID.Name = "comboBoxroleID";
            this.comboBoxroleID.Size = new System.Drawing.Size(117, 21);
            this.comboBoxroleID.TabIndex = 18;
            this.comboBoxroleID.ValueMember = "ID";
            // 
            // BindingSource1
            // 
            this.BindingSource1.DataSource = typeof(winda1.DBContext.Roles);
            this.BindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // menradioButton
            // 
            this.menradioButton.AutoSize = true;
            this.menradioButton.Checked = true;
            this.menradioButton.Location = new System.Drawing.Point(605, 293);
            this.menradioButton.Name = "menradioButton";
            this.menradioButton.Size = new System.Drawing.Size(71, 17);
            this.menradioButton.TabIndex = 19;
            this.menradioButton.TabStop = true;
            this.menradioButton.Text = "Мужской";
            this.menradioButton.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(166, 339);
            this.maskedTextBox1.Mask = "+ 7 (000) 000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // woradioButton
            // 
            this.woradioButton.AutoSize = true;
            this.woradioButton.Location = new System.Drawing.Point(693, 293);
            this.woradioButton.Name = "woradioButton";
            this.woradioButton.Size = new System.Drawing.Size(72, 17);
            this.woradioButton.TabIndex = 21;
            this.woradioButton.Text = "Женский";
            this.woradioButton.UseVisualStyleBackColor = true;
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonADD.Location = new System.Drawing.Point(639, 373);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(136, 56);
            this.buttonADD.TabIndex = 22;
            this.buttonADD.Text = "Добавить";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.woradioButton);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.menradioButton);
            this.Controls.Add(this.comboBoxroleID);
            this.Controls.Add(this.textBoxname2);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.logintextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormAddUsers";
            this.Text = "FormAddUsers";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logintextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxname2;
        private System.Windows.Forms.ComboBox comboBoxroleID;
        private System.Windows.Forms.RadioButton menradioButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton woradioButton;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.BindingSource BindingSource1;
    }
}

namespace Message_Digest
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
            this.button_select_file = new System.Windows.Forms.Button();
            this.button_comp_md5 = new System.Windows.Forms.Button();
            this.button_comp_sha1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_box_file_location = new System.Windows.Forms.TextBox();
            this.rb_md5 = new System.Windows.Forms.RadioButton();
            this.rb_sha1 = new System.Windows.Forms.RadioButton();
            this.button_gen_sig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_all_sig = new System.Windows.Forms.RadioButton();
            this.label_status_md5 = new System.Windows.Forms.Label();
            this.label_status_sha1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_generated = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label_file_source = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_select_file
            // 
            this.button_select_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_file.Location = new System.Drawing.Point(480, 23);
            this.button_select_file.Name = "button_select_file";
            this.button_select_file.Size = new System.Drawing.Size(126, 36);
            this.button_select_file.TabIndex = 0;
            this.button_select_file.Text = "Select File";
            this.button_select_file.UseVisualStyleBackColor = true;
            this.button_select_file.Click += new System.EventHandler(this.button_select_file_Click);
            // 
            // button_comp_md5
            // 
            this.button_comp_md5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_comp_md5.Location = new System.Drawing.Point(308, 154);
            this.button_comp_md5.Name = "button_comp_md5";
            this.button_comp_md5.Size = new System.Drawing.Size(166, 54);
            this.button_comp_md5.TabIndex = 1;
            this.button_comp_md5.Text = "Select MD5 File";
            this.button_comp_md5.UseVisualStyleBackColor = true;
            this.button_comp_md5.Click += new System.EventHandler(this.button_comp_md5_Click);
            // 
            // button_comp_sha1
            // 
            this.button_comp_sha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_comp_sha1.Location = new System.Drawing.Point(308, 229);
            this.button_comp_sha1.Name = "button_comp_sha1";
            this.button_comp_sha1.Size = new System.Drawing.Size(166, 54);
            this.button_comp_sha1.TabIndex = 2;
            this.button_comp_sha1.Text = "Select SHA-1 File";
            this.button_comp_sha1.UseVisualStyleBackColor = true;
            this.button_comp_sha1.Click += new System.EventHandler(this.button_comp_sha1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Generate Message Digest";
            // 
            // text_box_file_location
            // 
            this.text_box_file_location.Enabled = false;
            this.text_box_file_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_file_location.Location = new System.Drawing.Point(74, 26);
            this.text_box_file_location.Name = "text_box_file_location";
            this.text_box_file_location.Size = new System.Drawing.Size(388, 28);
            this.text_box_file_location.TabIndex = 4;
            // 
            // rb_md5
            // 
            this.rb_md5.AutoSize = true;
            this.rb_md5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_md5.Location = new System.Drawing.Point(22, 21);
            this.rb_md5.Name = "rb_md5";
            this.rb_md5.Size = new System.Drawing.Size(70, 28);
            this.rb_md5.TabIndex = 5;
            this.rb_md5.Text = "MD5";
            this.rb_md5.UseVisualStyleBackColor = true;
            // 
            // rb_sha1
            // 
            this.rb_sha1.AutoSize = true;
            this.rb_sha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sha1.Location = new System.Drawing.Point(22, 55);
            this.rb_sha1.Name = "rb_sha1";
            this.rb_sha1.Size = new System.Drawing.Size(86, 28);
            this.rb_sha1.TabIndex = 6;
            this.rb_sha1.Text = "SHA-1";
            this.rb_sha1.UseVisualStyleBackColor = true;
            // 
            // button_gen_sig
            // 
            this.button_gen_sig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gen_sig.Location = new System.Drawing.Point(74, 264);
            this.button_gen_sig.Name = "button_gen_sig";
            this.button_gen_sig.Size = new System.Drawing.Size(126, 54);
            this.button_gen_sig.TabIndex = 7;
            this.button_gen_sig.Text = "Generate";
            this.button_gen_sig.UseVisualStyleBackColor = true;
            this.button_gen_sig.Click += new System.EventHandler(this.button_gen_sig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Compare Message Digest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "File:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // rb_all_sig
            // 
            this.rb_all_sig.AutoSize = true;
            this.rb_all_sig.Checked = true;
            this.rb_all_sig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_all_sig.Location = new System.Drawing.Point(22, 89);
            this.rb_all_sig.Name = "rb_all_sig";
            this.rb_all_sig.Size = new System.Drawing.Size(52, 28);
            this.rb_all_sig.TabIndex = 11;
            this.rb_all_sig.TabStop = true;
            this.rb_all_sig.Text = "All";
            this.rb_all_sig.UseVisualStyleBackColor = true;
            // 
            // label_status_md5
            // 
            this.label_status_md5.AutoSize = true;
            this.label_status_md5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status_md5.Location = new System.Drawing.Point(499, 170);
            this.label_status_md5.Name = "label_status_md5";
            this.label_status_md5.Size = new System.Drawing.Size(120, 24);
            this.label_status_md5.TabIndex = 12;
            this.label_status_md5.Text = "Not Checked";
            // 
            // label_status_sha1
            // 
            this.label_status_sha1.AutoSize = true;
            this.label_status_sha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status_sha1.Location = new System.Drawing.Point(499, 245);
            this.label_status_sha1.Name = "label_status_sha1";
            this.label_status_sha1.Size = new System.Drawing.Size(120, 24);
            this.label_status_sha1.TabIndex = 13;
            this.label_status_sha1.Text = "Not Checked";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_md5);
            this.groupBox1.Controls.Add(this.rb_sha1);
            this.groupBox1.Controls.Add(this.rb_all_sig);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 135);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label_generated
            // 
            this.label_generated.AutoSize = true;
            this.label_generated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_generated.ForeColor = System.Drawing.Color.Green;
            this.label_generated.Location = new System.Drawing.Point(86, 346);
            this.label_generated.Name = "label_generated";
            this.label_generated.Size = new System.Drawing.Size(104, 24);
            this.label_generated.TabIndex = 15;
            this.label_generated.Text = "Generated!";
            this.label_generated.Visible = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label_file_source
            // 
            this.label_file_source.AutoSize = true;
            this.label_file_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_file_source.ForeColor = System.Drawing.Color.Red;
            this.label_file_source.Location = new System.Drawing.Point(401, 346);
            this.label_file_source.Name = "label_file_source";
            this.label_file_source.Size = new System.Drawing.Size(131, 24);
            this.label_file_source.TabIndex = 16;
            this.label_file_source.Text = "No file source!";
            this.label_file_source.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 403);
            this.Controls.Add(this.label_file_source);
            this.Controls.Add(this.label_generated);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_status_sha1);
            this.Controls.Add(this.label_status_md5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_gen_sig);
            this.Controls.Add(this.text_box_file_location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_comp_sha1);
            this.Controls.Add(this.button_comp_md5);
            this.Controls.Add(this.button_select_file);
            this.MaximumSize = new System.Drawing.Size(659, 450);
            this.MinimumSize = new System.Drawing.Size(659, 450);
            this.Name = "Form1";
            this.Text = "Message Digest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_select_file;
        private System.Windows.Forms.Button button_comp_md5;
        private System.Windows.Forms.Button button_comp_sha1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_box_file_location;
        private System.Windows.Forms.RadioButton rb_md5;
        private System.Windows.Forms.RadioButton rb_sha1;
        private System.Windows.Forms.Button button_gen_sig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_all_sig;
        private System.Windows.Forms.Label label_status_md5;
        private System.Windows.Forms.Label label_status_sha1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_generated;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label_file_source;
    }
}


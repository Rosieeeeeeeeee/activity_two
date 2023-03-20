namespace WindowsFormsApplication5
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
            this.wishList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectionTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fillBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.selectionOutputBox = new System.Windows.Forms.Button();
            this.countTxt = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wishList
            // 
            this.wishList.FormattingEnabled = true;
            this.wishList.Location = new System.Drawing.Point(34, 74);
            this.wishList.Name = "wishList";
            this.wishList.Size = new System.Drawing.Size(162, 225);
            this.wishList.TabIndex = 0;
            this.wishList.SelectedIndexChanged += new System.EventHandler(this.wishList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wish List";
            // 
            // selectionTxt
            // 
            this.selectionTxt.AutoSize = true;
            this.selectionTxt.Location = new System.Drawing.Point(31, 339);
            this.selectionTxt.Name = "selectionTxt";
            this.selectionTxt.Size = new System.Drawing.Size(54, 13);
            this.selectionTxt.TabIndex = 1;
            this.selectionTxt.Text = "Selection:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Count:";
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(255, 74);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(75, 23);
            this.fillBtn.TabIndex = 2;
            this.fillBtn.Text = "Fill";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(255, 125);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 2;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(255, 177);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(255, 228);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(75, 23);
            this.countBtn.TabIndex = 2;
            this.countBtn.Text = "Count";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // selectionOutputBox
            // 
            this.selectionOutputBox.Location = new System.Drawing.Point(102, 334);
            this.selectionOutputBox.Name = "selectionOutputBox";
            this.selectionOutputBox.Size = new System.Drawing.Size(75, 23);
            this.selectionOutputBox.TabIndex = 2;
            this.selectionOutputBox.UseVisualStyleBackColor = true;
            this.selectionOutputBox.Click += new System.EventHandler(this.selectionOutputBox_Click);
            // 
            // countTxt
            // 
            this.countTxt.Location = new System.Drawing.Point(102, 380);
            this.countTxt.Name = "countTxt";
            this.countTxt.Size = new System.Drawing.Size(75, 23);
            this.countTxt.TabIndex = 2;
            this.countTxt.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(255, 276);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 507);
            this.Controls.Add(this.countTxt);
            this.Controls.Add(this.selectionOutputBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectionTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wishList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wishList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectionTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.Button selectionOutputBox;
        private System.Windows.Forms.Button countTxt;
        private System.Windows.Forms.Button closeBtn;
    }
}


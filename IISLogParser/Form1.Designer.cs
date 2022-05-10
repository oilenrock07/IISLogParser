namespace IISLogParser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.MainGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1347, 822);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // MainGrid
            // 
            this.MainGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainGrid.Location = new System.Drawing.Point(3, 94);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowTemplate.Height = 25;
            this.MainGrid.Size = new System.Drawing.Size(1341, 724);
            this.MainGrid.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Controls.Add(this.FileBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1341, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(448, 26);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(77, 31);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FileBox
            // 
            this.FileBox.AllowDrop = true;
            this.FileBox.Location = new System.Drawing.Point(49, 30);
            this.FileBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(393, 26);
            this.FileBox.TabIndex = 1;
            this.FileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileBox_DragDrop);
            this.FileBox.DragOver += new System.Windows.Forms.DragEventHandler(this.FileBox_DragOver);
            this.FileBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FileBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "File:";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(608, 26);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(236, 26);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 822);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "IIS Log Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView MainGrid;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox SearchBox;
        private TextBox FileBox;
        private Label label2;
        private Button LoadButton;
    }
}
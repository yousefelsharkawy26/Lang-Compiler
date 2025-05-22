namespace WindowsFormsApp1
{
    partial class Compiler
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
            this.btnClose = new CuoreUI.Controls.Shapes.cuiEllipse();
            this.btnMaximize = new CuoreUI.Controls.Shapes.cuiEllipse();
            this.btnMinimize = new CuoreUI.Controls.Shapes.cuiEllipse();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cuiControlDrag1 = new CuoreUI.Components.cuiControlDrag(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstErrors = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstReadTokens = new System.Windows.Forms.ListView();
            this.Token = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnExpectedError = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpectedToken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1307, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.OutlineColor = System.Drawing.Color.Empty;
            this.btnClose.OutlineThickness = 1;
            this.btnClose.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(69)))), ((int)(((byte)(80)))));
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Location = new System.Drawing.Point(1271, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.OutlineColor = System.Drawing.Color.Empty;
            this.btnMaximize.OutlineThickness = 1;
            this.btnMaximize.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(190)))), ((int)(((byte)(84)))));
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Location = new System.Drawing.Point(1235, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OutlineColor = System.Drawing.Color.Empty;
            this.btnMinimize.OutlineThickness = 1;
            this.btnMinimize.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(170)))), ((int)(((byte)(91)))));
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 47);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(202)))), ((int)(((byte)(183)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(177, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compiler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lang_Compiler.Properties.Resources.PNG_000055;
            this.pictureBox1.Location = new System.Drawing.Point(17, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(72)))), ((int)(((byte)(79)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(82, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lang";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cuiControlDrag1
            // 
            this.cuiControlDrag1.TargetControl = this.panel1;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(899, 594);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lstErrors
            // 
            this.lstErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lstErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Line,
            this.UnExpectedError,
            this.ExpectedToken});
            this.lstErrors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstErrors.ForeColor = System.Drawing.Color.White;
            this.lstErrors.HideSelection = false;
            this.lstErrors.Location = new System.Drawing.Point(0, 594);
            this.lstErrors.Name = "lstErrors";
            this.lstErrors.Size = new System.Drawing.Size(1349, 192);
            this.lstErrors.TabIndex = 3;
            this.lstErrors.UseCompatibleStateImageBehavior = false;
            this.lstErrors.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lstReadTokens);
            this.panel2.Controls.Add(this.lstErrors);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1349, 786);
            this.panel2.TabIndex = 4;
            // 
            // lstReadTokens
            // 
            this.lstReadTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lstReadTokens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Token});
            this.lstReadTokens.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstReadTokens.ForeColor = System.Drawing.Color.White;
            this.lstReadTokens.FullRowSelect = true;
            this.lstReadTokens.HideSelection = false;
            this.lstReadTokens.Location = new System.Drawing.Point(899, 0);
            this.lstReadTokens.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.lstReadTokens.MultiSelect = false;
            this.lstReadTokens.Name = "lstReadTokens";
            this.lstReadTokens.Size = new System.Drawing.Size(450, 594);
            this.lstReadTokens.TabIndex = 4;
            this.lstReadTokens.UseCompatibleStateImageBehavior = false;
            this.lstReadTokens.View = System.Windows.Forms.View.Details;
            // 
            // Token
            // 
            this.Token.Text = "Token";
            this.Token.Width = 350;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 100;
            // 
            // Line
            // 
            this.Line.Text = "Line";
            this.Line.Width = 100;
            // 
            // UnExpectedError
            // 
            this.UnExpectedError.Text = "Un Expected Error";
            this.UnExpectedError.Width = 450;
            // 
            // ExpectedToken
            // 
            this.ExpectedToken.Text = "Expected Token";
            this.ExpectedToken.Width = 690;
            // 
            // Compiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1349, 833);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compiler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.Shapes.cuiEllipse btnClose;
        private CuoreUI.Controls.Shapes.cuiEllipse btnMinimize;
        private CuoreUI.Controls.Shapes.cuiEllipse btnMaximize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CuoreUI.Components.cuiControlDrag cuiControlDrag1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lstErrors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstReadTokens;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Token;
        private System.Windows.Forms.ColumnHeader Line;
        private System.Windows.Forms.ColumnHeader UnExpectedError;
        private System.Windows.Forms.ColumnHeader ExpectedToken;
    }
}


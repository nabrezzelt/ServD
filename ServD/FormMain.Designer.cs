namespace ServD
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_move = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.pb_min = new System.Windows.Forms.PictureBox();
            this.pb_max = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.panel_move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_move
            // 
            this.panel_move.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_move.Controls.Add(this.lbl_title);
            this.panel_move.Controls.Add(this.tb_search);
            this.panel_move.Controls.Add(this.pb_min);
            this.panel_move.Controls.Add(this.pb_max);
            this.panel_move.Controls.Add(this.pb_close);
            this.panel_move.Location = new System.Drawing.Point(0, 0);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(951, 25);
            this.panel_move.TabIndex = 0;
            this.panel_move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_move_MouseDown);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbl_title.Location = new System.Drawing.Point(28, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(35, 13);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "label1";
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_search.ForeColor = System.Drawing.Color.White;
            this.tb_search.Location = new System.Drawing.Point(706, 3);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(134, 20);
            this.tb_search.TabIndex = 0;
            // 
            // pb_min
            // 
            this.pb_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_min.Image = global::ServD.Properties.Resources.min;
            this.pb_min.Location = new System.Drawing.Point(849, 0);
            this.pb_min.Name = "pb_min";
            this.pb_min.Size = new System.Drawing.Size(34, 25);
            this.pb_min.TabIndex = 1;
            this.pb_min.TabStop = false;
            this.pb_min.Tag = "";
            this.pb_min.Click += new System.EventHandler(this.pb_min_Click);
            this.pb_min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_min_MouseDown);
            this.pb_min.MouseEnter += new System.EventHandler(this.pb_min_MouseEnter);
            this.pb_min.MouseLeave += new System.EventHandler(this.pb_min_MouseLeave);
            this.pb_min.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_min_MouseUp);
            // 
            // pb_max
            // 
            this.pb_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_max.Image = global::ServD.Properties.Resources.max;
            this.pb_max.Location = new System.Drawing.Point(883, 0);
            this.pb_max.Name = "pb_max";
            this.pb_max.Size = new System.Drawing.Size(34, 25);
            this.pb_max.TabIndex = 4;
            this.pb_max.TabStop = false;
            this.pb_max.Click += new System.EventHandler(this.pb_max_Click);
            this.pb_max.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_max_MouseDown);
            this.pb_max.MouseEnter += new System.EventHandler(this.pb_max_MouseEnter);
            this.pb_max.MouseLeave += new System.EventHandler(this.pb_max_MouseLeave);
            this.pb_max.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_max_MouseUp);
            // 
            // pb_close
            // 
            this.pb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_close.Image = global::ServD.Properties.Resources.close;
            this.pb_close.Location = new System.Drawing.Point(917, 0);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(34, 25);
            this.pb_close.TabIndex = 0;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            this.pb_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_close_MouseDown);
            this.pb_close.MouseEnter += new System.EventHandler(this.pb_close_MouseEnter);
            this.pb_close.MouseLeave += new System.EventHandler(this.pb_close_MouseLeave);
            this.pb_close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_close_MouseUp);
            // 
            // pb_icon
            // 
            this.pb_icon.Location = new System.Drawing.Point(3, 3);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(19, 19);
            this.pb_icon.TabIndex = 2;
            this.pb_icon.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(951, 608);
            this.Controls.Add(this.pb_icon);
            this.Controls.Add(this.panel_move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "ServD";
            this.panel_move.ResumeLayout(false);
            this.panel_move.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.PictureBox pb_min;
        private System.Windows.Forms.PictureBox pb_max;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_title;
    }
}



namespace CoinTracker.WFAUI
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
            this.dgwCoin = new System.Windows.Forms.DataGridView();
            this.tbCoinSearch = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.CoinTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCoin
            // 
            this.dgwCoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCoin.Location = new System.Drawing.Point(38, 147);
            this.dgwCoin.Name = "dgwCoin";
            this.dgwCoin.Size = new System.Drawing.Size(723, 291);
            this.dgwCoin.TabIndex = 0;
            // 
            // tbCoinSearch
            // 
            this.tbCoinSearch.Location = new System.Drawing.Point(121, 112);
            this.tbCoinSearch.Name = "tbCoinSearch";
            this.tbCoinSearch.Size = new System.Drawing.Size(640, 20);
            this.tbCoinSearch.TabIndex = 1;
            this.tbCoinSearch.TextChanged += new System.EventHandler(this.tbCoinSearch_TextChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(60, 115);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(43, 13);
            this.lbl_search.TabIndex = 2;
            this.lbl_search.Text = "Arama :";
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Vladimir Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(225, 21);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(320, 78);
            this.lbl_heading.TabIndex = 3;
            this.lbl_heading.Text = "Coin Tracker";
            // 
            // CoinTimer
            // 
            this.CoinTimer.Tick += new System.EventHandler(this.CoinTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.tbCoinSearch);
            this.Controls.Add(this.dgwCoin);
            this.Name = "Form1";
            this.Text = "CoinTracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCoin;
        private System.Windows.Forms.TextBox tbCoinSearch;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Timer CoinTimer;
    }
}


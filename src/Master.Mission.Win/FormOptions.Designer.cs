namespace Master.Mission.Win
{
    partial class FormOptions
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
            this.labelApparence = new System.Windows.Forms.Label();
            this.textBoxApparence = new System.Windows.Forms.TextBox();
            this.labelLangue = new System.Windows.Forms.Label();
            this.comboBoxLangue = new System.Windows.Forms.ComboBox();
            this.listViewLangues = new System.Windows.Forms.ListView();
            this.labelHeure = new System.Windows.Forms.Label();
            this.timerHeure = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labelApparence
            // 
            this.labelApparence.AutoSize = true;
            this.labelApparence.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApparence.Location = new System.Drawing.Point(87, 56);
            this.labelApparence.Name = "labelApparence";
            this.labelApparence.Size = new System.Drawing.Size(325, 67);
            this.labelApparence.TabIndex = 0;
            this.labelApparence.Text = "Apparence";
            // 
            // textBoxApparence
            // 
            this.textBoxApparence.AutoCompleteCustomSource.AddRange(new string[] {
            "Bleu cerise",
            "Bleu jonquille",
            "Noir"});
            this.textBoxApparence.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxApparence.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxApparence.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApparence.Location = new System.Drawing.Point(99, 126);
            this.textBoxApparence.Name = "textBoxApparence";
            this.textBoxApparence.Size = new System.Drawing.Size(575, 74);
            this.textBoxApparence.TabIndex = 1;
            // 
            // labelLangue
            // 
            this.labelLangue.AutoSize = true;
            this.labelLangue.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLangue.Location = new System.Drawing.Point(87, 216);
            this.labelLangue.Name = "labelLangue";
            this.labelLangue.Size = new System.Drawing.Size(233, 67);
            this.labelLangue.TabIndex = 0;
            this.labelLangue.Text = "Langue";
            // 
            // comboBoxLangue
            // 
            this.comboBoxLangue.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLangue.Location = new System.Drawing.Point(112, 303);
            this.comboBoxLangue.Name = "comboBoxLangue";
            this.comboBoxLangue.Size = new System.Drawing.Size(562, 75);
            this.comboBoxLangue.TabIndex = 2;
            this.comboBoxLangue.SelectedValueChanged += new System.EventHandler(this.comboBoxLangue_SelectedValueChanged);
            // 
            // listViewLangues
            // 
            this.listViewLangues.Location = new System.Drawing.Point(795, 77);
            this.listViewLangues.Name = "listViewLangues";
            this.listViewLangues.Size = new System.Drawing.Size(230, 301);
            this.listViewLangues.TabIndex = 3;
            this.listViewLangues.UseCompatibleStateImageBehavior = false;
            // 
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeure.Location = new System.Drawing.Point(467, 9);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(293, 67);
            this.labelHeure.TabIndex = 0;
            this.labelHeure.Text = "hh:mm:ss";
            // 
            // timerHeure
            // 
            this.timerHeure.Enabled = true;
            this.timerHeure.Interval = 1000;
            this.timerHeure.Tick += new System.EventHandler(this.timerHeure_Tick);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 456);
            this.Controls.Add(this.listViewLangues);
            this.Controls.Add(this.comboBoxLangue);
            this.Controls.Add(this.textBoxApparence);
            this.Controls.Add(this.labelLangue);
            this.Controls.Add(this.labelHeure);
            this.Controls.Add(this.labelApparence);
            this.Name = "FormOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApparence;
        private System.Windows.Forms.TextBox textBoxApparence;
        private System.Windows.Forms.Label labelLangue;
        private System.Windows.Forms.ComboBox comboBoxLangue;
        private System.Windows.Forms.ListView listViewLangues;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.Timer timerHeure;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}
namespace Master.Mission.Win
{
    partial class FormSalarie
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
            System.Windows.Forms.Label identifiantLabel;
            System.Windows.Forms.Label matriculeLabel;
            System.Windows.Forms.Label nomLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalarie));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.salarieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.salarieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salarieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.identifiantTextBox = new System.Windows.Forms.TextBox();
            this.matriculeTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.salarieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            identifiantLabel = new System.Windows.Forms.Label();
            matriculeLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingNavigator)).BeginInit();
            this.salarieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // identifiantLabel
            // 
            identifiantLabel.AutoSize = true;
            identifiantLabel.Location = new System.Drawing.Point(51, 39);
            identifiantLabel.Name = "identifiantLabel";
            identifiantLabel.Size = new System.Drawing.Size(63, 15);
            identifiantLabel.TabIndex = 1;
            identifiantLabel.Text = "Identifiant:";
            // 
            // matriculeLabel
            // 
            matriculeLabel.AutoSize = true;
            matriculeLabel.Location = new System.Drawing.Point(283, 41);
            matriculeLabel.Name = "matriculeLabel";
            matriculeLabel.Size = new System.Drawing.Size(61, 15);
            matriculeLabel.TabIndex = 3;
            matriculeLabel.Text = "Matricule:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(517, 41);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(37, 15);
            nomLabel.TabIndex = 5;
            nomLabel.Text = "Nom:";
            // 
            // salarieBindingNavigator
            // 
            this.salarieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salarieBindingNavigator.BindingSource = this.salarieBindingSource;
            this.salarieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salarieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salarieBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.salarieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.salarieBindingNavigatorSaveItem});
            this.salarieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.salarieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salarieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salarieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salarieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salarieBindingNavigator.Name = "salarieBindingNavigator";
            this.salarieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salarieBindingNavigator.Size = new System.Drawing.Size(976, 27);
            this.salarieBindingNavigator.TabIndex = 0;
            this.salarieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // salarieBindingSource
            // 
            this.salarieBindingSource.DataSource = typeof(Metier.Modele.Salarie);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // salarieBindingNavigatorSaveItem
            // 
            this.salarieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salarieBindingNavigatorSaveItem.Enabled = false;
            this.salarieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salarieBindingNavigatorSaveItem.Image")));
            this.salarieBindingNavigatorSaveItem.Name = "salarieBindingNavigatorSaveItem";
            this.salarieBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.salarieBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // identifiantTextBox
            // 
            this.identifiantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Identifiant", true));
            this.identifiantTextBox.Location = new System.Drawing.Point(120, 36);
            this.identifiantTextBox.Name = "identifiantTextBox";
            this.identifiantTextBox.Size = new System.Drawing.Size(100, 20);
            this.identifiantTextBox.TabIndex = 2;
            // 
            // matriculeTextBox
            // 
            this.matriculeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Matricule", true));
            this.matriculeTextBox.Location = new System.Drawing.Point(350, 38);
            this.matriculeTextBox.Name = "matriculeTextBox";
            this.matriculeTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculeTextBox.TabIndex = 4;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(560, 38);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 6;
            // 
            // salarieDataGridView
            // 
            this.salarieDataGridView.AutoGenerateColumns = false;
            this.salarieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salarieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.salarieDataGridView.DataSource = this.salarieBindingSource;
            this.salarieDataGridView.Location = new System.Drawing.Point(22, 120);
            this.salarieDataGridView.Name = "salarieDataGridView";
            this.salarieDataGridView.Size = new System.Drawing.Size(920, 344);
            this.salarieDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Profil";
            this.dataGridViewTextBoxColumn1.HeaderText = "Profil";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Matricule";
            this.dataGridViewTextBoxColumn2.HeaderText = "Matricule";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateEntree";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateEntree";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateSortie";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateSortie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Identifiant";
            this.dataGridViewTextBoxColumn5.HeaderText = "Identifiant";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MotPasse";
            this.dataGridViewTextBoxColumn7.HeaderText = "MotPasse";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn8.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn9.HeaderText = "Email";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // FormSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 476);
            this.Controls.Add(this.salarieDataGridView);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(matriculeLabel);
            this.Controls.Add(this.matriculeTextBox);
            this.Controls.Add(identifiantLabel);
            this.Controls.Add(this.identifiantTextBox);
            this.Controls.Add(this.salarieBindingNavigator);
            this.Name = "FormSalarie";
            this.Text = "Gestion des salariés";
            this.Load += new System.EventHandler(this.FormSalarie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingNavigator)).EndInit();
            this.salarieBindingNavigator.ResumeLayout(false);
            this.salarieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource salarieBindingSource;
        private System.Windows.Forms.BindingNavigator salarieBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton salarieBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox identifiantTextBox;
        private System.Windows.Forms.TextBox matriculeTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.DataGridView salarieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
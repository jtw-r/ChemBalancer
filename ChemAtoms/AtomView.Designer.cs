namespace ChemAtoms {
	partial class AtomView {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lb_atomSymbol = new System.Windows.Forms.Label();
			this.lb_atomName = new System.Windows.Forms.Label();
			this.lb_atomNumber = new System.Windows.Forms.Label();
			this.lb_atomMass = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lb_atomElectrons = new System.Windows.Forms.Label();
			this.lb_atomNeutrons = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lb_atomProtons = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lb_atomShells = new System.Windows.Forms.Label();
			this.lb_atomPosition = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_atomSymbol
			// 
			this.lb_atomSymbol.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb_atomSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_atomSymbol.Location = new System.Drawing.Point(0, 19);
			this.lb_atomSymbol.Margin = new System.Windows.Forms.Padding(0);
			this.lb_atomSymbol.Name = "lb_atomSymbol";
			this.lb_atomSymbol.Size = new System.Drawing.Size(255, 29);
			this.lb_atomSymbol.TabIndex = 1;
			this.lb_atomSymbol.Text = "Sy";
			this.lb_atomSymbol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lb_atomName
			// 
			this.lb_atomName.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb_atomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_atomName.Location = new System.Drawing.Point(0, 48);
			this.lb_atomName.Name = "lb_atomName";
			this.lb_atomName.Size = new System.Drawing.Size(255, 17);
			this.lb_atomName.TabIndex = 2;
			this.lb_atomName.Text = "Name";
			this.lb_atomName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lb_atomNumber
			// 
			this.lb_atomNumber.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb_atomNumber.Location = new System.Drawing.Point(0, 0);
			this.lb_atomNumber.Name = "lb_atomNumber";
			this.lb_atomNumber.Size = new System.Drawing.Size(255, 19);
			this.lb_atomNumber.TabIndex = 0;
			this.lb_atomNumber.Text = "AN";
			this.lb_atomNumber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lb_atomMass
			// 
			this.lb_atomMass.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb_atomMass.Location = new System.Drawing.Point(0, 65);
			this.lb_atomMass.Name = "lb_atomMass";
			this.lb_atomMass.Size = new System.Drawing.Size(255, 26);
			this.lb_atomMass.TabIndex = 3;
			this.lb_atomMass.Text = "Mass";
			this.lb_atomMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.lb_atomElectrons, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lb_atomNeutrons, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lb_atomProtons, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.lb_atomShells, 1, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 117);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 82);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// lb_atomElectrons
			// 
			this.lb_atomElectrons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_atomElectrons.AutoSize = true;
			this.lb_atomElectrons.Location = new System.Drawing.Point(130, 26);
			this.lb_atomElectrons.Name = "lb_atomElectrons";
			this.lb_atomElectrons.Size = new System.Drawing.Size(122, 13);
			this.lb_atomElectrons.TabIndex = 5;
			this.lb_atomElectrons.Text = "# of Electrons";
			this.lb_atomElectrons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lb_atomNeutrons
			// 
			this.lb_atomNeutrons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_atomNeutrons.AutoSize = true;
			this.lb_atomNeutrons.Location = new System.Drawing.Point(130, 13);
			this.lb_atomNeutrons.Name = "lb_atomNeutrons";
			this.lb_atomNeutrons.Size = new System.Drawing.Size(122, 13);
			this.lb_atomNeutrons.TabIndex = 4;
			this.lb_atomNeutrons.Text = "# of Neutrons";
			this.lb_atomNeutrons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Protons:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Neutrons:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Electrons:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lb_atomProtons
			// 
			this.lb_atomProtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_atomProtons.AutoSize = true;
			this.lb_atomProtons.Location = new System.Drawing.Point(130, 0);
			this.lb_atomProtons.Name = "lb_atomProtons";
			this.lb_atomProtons.Size = new System.Drawing.Size(122, 13);
			this.lb_atomProtons.TabIndex = 3;
			this.lb_atomProtons.Text = "# of Protons";
			this.lb_atomProtons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Electron Shells:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lb_atomShells
			// 
			this.lb_atomShells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_atomShells.AutoSize = true;
			this.lb_atomShells.Location = new System.Drawing.Point(130, 49);
			this.lb_atomShells.Name = "lb_atomShells";
			this.lb_atomShells.Size = new System.Drawing.Size(122, 13);
			this.lb_atomShells.TabIndex = 7;
			this.lb_atomShells.Text = "# Electron Shells";
			this.lb_atomShells.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lb_atomPosition
			// 
			this.lb_atomPosition.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb_atomPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_atomPosition.Location = new System.Drawing.Point(0, 91);
			this.lb_atomPosition.Name = "lb_atomPosition";
			this.lb_atomPosition.Size = new System.Drawing.Size(255, 26);
			this.lb_atomPosition.TabIndex = 5;
			this.lb_atomPosition.Text = "(Position)";
			this.lb_atomPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AtomView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(255, 207);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.lb_atomPosition);
			this.Controls.Add(this.lb_atomMass);
			this.Controls.Add(this.lb_atomName);
			this.Controls.Add(this.lb_atomSymbol);
			this.Controls.Add(this.lb_atomNumber);
			this.Name = "AtomView";
			this.Text = "AtomView";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_atomSymbol;
		private System.Windows.Forms.Label lb_atomName;
		private System.Windows.Forms.Label lb_atomNumber;
		private System.Windows.Forms.Label lb_atomMass;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lb_atomElectrons;
		private System.Windows.Forms.Label lb_atomNeutrons;
		private System.Windows.Forms.Label lb_atomProtons;
		private System.Windows.Forms.Label lb_atomPosition;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lb_atomShells;
	}
}
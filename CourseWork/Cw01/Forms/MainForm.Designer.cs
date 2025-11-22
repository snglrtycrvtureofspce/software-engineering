namespace Cw01.Forms
{
    partial class MainForm
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
            this.InputButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();
            // 
            // InputButton
            // 
            this.InputButton.FlatStyle = FlatStyle.Flat;
            this.InputButton.Location = new System.Drawing.Point(12, 12);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(180, 35);
            this.InputButton.TabIndex = 0;
            this.InputButton.Text = "Ввод заявки";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(202, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(180, 35);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Поиск варианта";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.FlatStyle = FlatStyle.Flat;
            this.OutputButton.Location = new System.Drawing.Point(392, 12);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(180, 35);
            this.OutputButton.TabIndex = 2;
            this.OutputButton.Text = "Вывод картотеки";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(582, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 35);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 58);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(750, 500);
            this.dataGridView.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 570);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.InputButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет заявок на обмен квартир";
            this.ResumeLayout(false);

        }

        #endregion

        private Button InputButton;
        private Button SearchButton;
        private Button OutputButton;
        private Button ExitButton;
        private DataGridView dataGridView;
    }
}
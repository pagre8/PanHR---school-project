namespace wroom
{
    partial class Pracownicy
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clearButton = new System.Windows.Forms.Button();
            this.internshipNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.peselMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.internshipLabel = new System.Windows.Forms.Label();
            this.peselLabel = new System.Windows.Forms.Label();
            this.educationLabel = new System.Windows.Forms.Label();
            this.educationTextBox = new System.Windows.Forms.TextBox();
            this.contractComboBox = new System.Windows.Forms.ComboBox();
            this.contractLabel = new System.Windows.Forms.Label();
            this.ageMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.paymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDBDataSet = new wroom.HRDBDataSet();
            this.chartButton = new System.Windows.Forms.Button();
            this.workersTableAdapter = new wroom.HRDBDataSetTableAdapters.WorkersTableAdapter();
            this.Zmiana = new System.Windows.Forms.Label();
            this.shiftTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staż = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payperhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.internshipNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearButton.Location = new System.Drawing.Point(779, 42);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Cliick);
            // 
            // internshipNumericUpDown
            // 
            this.internshipNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.internshipNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.internshipNumericUpDown.Location = new System.Drawing.Point(298, 42);
            this.internshipNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.internshipNumericUpDown.Name = "internshipNumericUpDown";
            this.internshipNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.internshipNumericUpDown.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameTextBox.Location = new System.Drawing.Point(63, 41);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.surnameTextBox.Multiline = true;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(121, 21);
            this.surnameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(63, 14);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 21);
            this.nameTextBox.TabIndex = 0;
            // 
            // peselMaskedTextBox
            // 
            this.peselMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.peselMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.peselMaskedTextBox.Location = new System.Drawing.Point(63, 68);
            this.peselMaskedTextBox.Mask = "00000000000";
            this.peselMaskedTextBox.Name = "peselMaskedTextBox";
            this.peselMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.peselMaskedTextBox.TabIndex = 2;
            // 
            // positionTextBox
            // 
            this.positionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.positionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionTextBox.Location = new System.Drawing.Point(518, 42);
            this.positionTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.positionTextBox.Multiline = true;
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(121, 21);
            this.positionTextBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(31, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(26, 13);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Imie";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.ForeColor = System.Drawing.Color.White;
            this.surnameLabel.Location = new System.Drawing.Point(4, 44);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(53, 13);
            this.surnameLabel.TabIndex = 19;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.ForeColor = System.Drawing.Color.White;
            this.positionLabel.Location = new System.Drawing.Point(450, 46);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(62, 13);
            this.positionLabel.TabIndex = 20;
            this.positionLabel.Text = "Stanowisko";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(213, 16);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(79, 13);
            this.ageLabel.TabIndex = 21;
            this.ageLabel.Text = "Data urodzenia";
            // 
            // internshipLabel
            // 
            this.internshipLabel.AutoSize = true;
            this.internshipLabel.ForeColor = System.Drawing.Color.White;
            this.internshipLabel.Location = new System.Drawing.Point(264, 47);
            this.internshipLabel.Name = "internshipLabel";
            this.internshipLabel.Size = new System.Drawing.Size(28, 13);
            this.internshipLabel.TabIndex = 22;
            this.internshipLabel.Text = "Staż";
            // 
            // peselLabel
            // 
            this.peselLabel.AutoSize = true;
            this.peselLabel.ForeColor = System.Drawing.Color.White;
            this.peselLabel.Location = new System.Drawing.Point(24, 71);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(33, 13);
            this.peselLabel.TabIndex = 23;
            this.peselLabel.Text = "Pesel";
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.ForeColor = System.Drawing.Color.White;
            this.educationLabel.Location = new System.Drawing.Point(434, 16);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(78, 13);
            this.educationLabel.TabIndex = 24;
            this.educationLabel.Text = "Wykształcenie";
            // 
            // educationTextBox
            // 
            this.educationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.educationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.educationTextBox.Location = new System.Drawing.Point(518, 13);
            this.educationTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.educationTextBox.Multiline = true;
            this.educationTextBox.Name = "educationTextBox";
            this.educationTextBox.Size = new System.Drawing.Size(121, 21);
            this.educationTextBox.TabIndex = 6;
            // 
            // contractComboBox
            // 
            this.contractComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.contractComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contractComboBox.FormattingEnabled = true;
            this.contractComboBox.Items.AddRange(new object[] {
            "Umowa o prace",
            "Umowa zlecenie",
            "Umowa o dzieło"});
            this.contractComboBox.Location = new System.Drawing.Point(518, 70);
            this.contractComboBox.Name = "contractComboBox";
            this.contractComboBox.Size = new System.Drawing.Size(121, 21);
            this.contractComboBox.TabIndex = 8;
            // 
            // contractLabel
            // 
            this.contractLabel.AutoSize = true;
            this.contractLabel.ForeColor = System.Drawing.Color.White;
            this.contractLabel.Location = new System.Drawing.Point(469, 74);
            this.contractLabel.Name = "contractLabel";
            this.contractLabel.Size = new System.Drawing.Size(43, 13);
            this.contractLabel.TabIndex = 27;
            this.contractLabel.Text = "Umowa";
            // 
            // ageMaskedTextBox
            // 
            this.ageMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.ageMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageMaskedTextBox.Location = new System.Drawing.Point(298, 13);
            this.ageMaskedTextBox.Mask = "00/00/0000";
            this.ageMaskedTextBox.Name = "ageMaskedTextBox";
            this.ageMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.ageMaskedTextBox.TabIndex = 3;
            this.ageMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // paymentUpDown
            // 
            this.paymentUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.paymentUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentUpDown.Location = new System.Drawing.Point(298, 73);
            this.paymentUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.paymentUpDown.Name = "paymentUpDown";
            this.paymentUpDown.Size = new System.Drawing.Size(121, 20);
            this.paymentUpDown.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Stawka godzinowa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.Pesel,
            this.bdayDataGridViewTextBoxColumn,
            this.Staż,
            this.payperhDataGridViewTextBoxColumn,
            this.education,
            this.positionDataGridViewTextBoxColumn,
            this.contracttypeDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(11, 115);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(843, 314);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.hRDBDataSet;
            // 
            // hRDBDataSet
            // 
            this.hRDBDataSet.DataSetName = "HRDBDataSet";
            this.hRDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartButton
            // 
            this.chartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.chartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chartButton.Location = new System.Drawing.Point(779, 70);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(75, 23);
            this.chartButton.TabIndex = 13;
            this.chartButton.Text = "Wykres";
            this.chartButton.UseVisualStyleBackColor = false;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // Zmiana
            // 
            this.Zmiana.AutoSize = true;
            this.Zmiana.ForeColor = System.Drawing.Color.White;
            this.Zmiana.Location = new System.Drawing.Point(668, 17);
            this.Zmiana.Name = "Zmiana";
            this.Zmiana.Size = new System.Drawing.Size(42, 13);
            this.Zmiana.TabIndex = 24;
            this.Zmiana.Text = "Zmiana";
            // 
            // shiftTextBox
            // 
            this.shiftTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.shiftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shiftTextBox.Location = new System.Drawing.Point(716, 14);
            this.shiftTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.shiftTextBox.Multiline = true;
            this.shiftTextBox.Name = "shiftTextBox";
            this.shiftTextBox.Size = new System.Drawing.Size(121, 21);
            this.shiftTextBox.TabIndex = 9;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmButton.Location = new System.Drawing.Point(698, 69);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Location = new System.Drawing.Point(698, 42);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pesel
            // 
            this.Pesel.DataPropertyName = "Pesel";
            this.Pesel.HeaderText = "Pesel";
            this.Pesel.Name = "Pesel";
            this.Pesel.ReadOnly = true;
            // 
            // bdayDataGridViewTextBoxColumn
            // 
            this.bdayDataGridViewTextBoxColumn.DataPropertyName = "Bday1";
            this.bdayDataGridViewTextBoxColumn.HeaderText = "Data urodzenia";
            this.bdayDataGridViewTextBoxColumn.Name = "bdayDataGridViewTextBoxColumn";
            this.bdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Staż
            // 
            this.Staż.DataPropertyName = "seniority";
            this.Staż.HeaderText = "Staż";
            this.Staż.Name = "Staż";
            this.Staż.ReadOnly = true;
            // 
            // payperhDataGridViewTextBoxColumn
            // 
            this.payperhDataGridViewTextBoxColumn.DataPropertyName = "Pay_per_h";
            this.payperhDataGridViewTextBoxColumn.HeaderText = "Stawka godzinowa";
            this.payperhDataGridViewTextBoxColumn.Name = "payperhDataGridViewTextBoxColumn";
            this.payperhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // education
            // 
            this.education.DataPropertyName = "education";
            this.education.HeaderText = "Wykształcenie";
            this.education.Name = "education";
            this.education.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Stanowisko";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contracttypeDataGridViewTextBoxColumn
            // 
            this.contracttypeDataGridViewTextBoxColumn.DataPropertyName = "Contract_type";
            this.contracttypeDataGridViewTextBoxColumn.HeaderText = "Typ umowy";
            this.contracttypeDataGridViewTextBoxColumn.Name = "contracttypeDataGridViewTextBoxColumn";
            this.contracttypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "zmiana";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(866, 441);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentUpDown);
            this.Controls.Add(this.ageMaskedTextBox);
            this.Controls.Add(this.contractLabel);
            this.Controls.Add(this.contractComboBox);
            this.Controls.Add(this.shiftTextBox);
            this.Controls.Add(this.Zmiana);
            this.Controls.Add(this.educationTextBox);
            this.Controls.Add(this.educationLabel);
            this.Controls.Add(this.peselLabel);
            this.Controls.Add(this.internshipLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.internshipNumericUpDown);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.peselMaskedTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Pracownicy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzanie pracownikiem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.internshipNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.NumericUpDown internshipNumericUpDown;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox peselMaskedTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label internshipLabel;
        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.TextBox educationTextBox;
        private System.Windows.Forms.ComboBox contractComboBox;
        private System.Windows.Forms.Label contractLabel;
        private System.Windows.Forms.MaskedTextBox ageMaskedTextBox;
        private System.Windows.Forms.NumericUpDown paymentUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button chartButton;
        private HRDBDataSet hRDBDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private HRDBDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.Label Zmiana;
        private System.Windows.Forms.TextBox shiftTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staż;
        private System.Windows.Forms.DataGridViewTextBoxColumn payperhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn education;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
    }
}


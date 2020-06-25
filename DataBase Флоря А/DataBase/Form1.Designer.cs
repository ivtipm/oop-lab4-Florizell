namespace DataBase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearRow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxForSearch = new System.Windows.Forms.TextBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.textBoxFilm = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelFilm = new System.Windows.Forms.Label();
            this.labelProducer = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.panelSearchRecord = new System.Windows.Forms.Panel();
            this.pictureBoxOpen = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.pictureBoxFAQ = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.labelSave = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSort = new System.Windows.Forms.Button();
            this.comboBoxChoiceSort = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelSearchRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFAQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.filmname,
            this.Producer,
            this.year,
            this.genre});
            this.dataGridViewTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dataGridViewTable.Location = new System.Drawing.Point(0, 281);
            this.dataGridViewTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.Size = new System.Drawing.Size(783, 293);
            this.dataGridViewTable.TabIndex = 0;
            this.dataGridViewTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewTable_CellBeginEdit);
            this.dataGridViewTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_CellEndEdit);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(602, 32);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(181, 47);
            this.btnClearAll.TabIndex = 9;
            this.btnClearAll.Text = "Удалить всё";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearRow
            // 
            this.btnClearRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearRow.FlatAppearance.BorderSize = 0;
            this.btnClearRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRow.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearRow.ForeColor = System.Drawing.Color.White;
            this.btnClearRow.Location = new System.Drawing.Point(602, 87);
            this.btnClearRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearRow.Name = "btnClearRow";
            this.btnClearRow.Size = new System.Drawing.Size(181, 57);
            this.btnClearRow.TabIndex = 10;
            this.btnClearRow.Text = "Удалить выделенное";
            this.btnClearRow.UseVisualStyleBackColor = false;
            this.btnClearRow.Click += new System.EventHandler(this.btnClearRow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(57, 75);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(187, 42);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(110, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Поиск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxForSearch
            // 
            this.textBoxForSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForSearch.Location = new System.Drawing.Point(57, 43);
            this.textBoxForSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxForSearch.Name = "textBoxForSearch";
            this.textBoxForSearch.Size = new System.Drawing.Size(185, 26);
            this.textBoxForSearch.TabIndex = 13;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRecord.FlatAppearance.BorderSize = 0;
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRecord.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddRecord.Location = new System.Drawing.Point(528, 216);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(255, 57);
            this.btnAddRecord.TabIndex = 8;
            this.btnAddRecord.Text = "Добавить запись";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenre.Location = new System.Drawing.Point(135, 178);
            this.textBoxGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(132, 26);
            this.textBoxGenre.TabIndex = 7;
            this.textBoxGenre.TextChanged += new System.EventHandler(this.textBoxGenre_TextChanged);
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProducer.Location = new System.Drawing.Point(135, 115);
            this.textBoxProducer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(132, 26);
            this.textBoxProducer.TabIndex = 4;
            this.textBoxProducer.TextChanged += new System.EventHandler(this.textBoxProducer_TextChanged);
            // 
            // textBoxFilm
            // 
            this.textBoxFilm.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilm.Location = new System.Drawing.Point(135, 85);
            this.textBoxFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilm.Name = "textBoxFilm";
            this.textBoxFilm.Size = new System.Drawing.Size(132, 26);
            this.textBoxFilm.TabIndex = 0;
            this.textBoxFilm.TextChanged += new System.EventHandler(this.textBoxArtist_TextChanged);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGenre.Location = new System.Drawing.Point(8, 180);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(129, 24);
            this.labelGenre.TabIndex = 6;
            this.labelGenre.Text = "Жанр фильма:";
            this.labelGenre.Click += new System.EventHandler(this.labelGenre_Click);
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilm.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFilm.Location = new System.Drawing.Point(12, 87);
            this.labelFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(71, 24);
            this.labelFilm.TabIndex = 1;
            this.labelFilm.Text = "Фильм:";
            this.labelFilm.Click += new System.EventHandler(this.labelFilm_Click);
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProducer.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProducer.Location = new System.Drawing.Point(8, 117);
            this.labelProducer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(94, 24);
            this.labelProducer.TabIndex = 2;
            this.labelProducer.Text = "Режиссер:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(135, 145);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(132, 26);
            this.textBoxYear.TabIndex = 5;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.ForeColor = System.Drawing.SystemColors.Control;
            this.labelYear.Location = new System.Drawing.Point(8, 145);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(104, 24);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Год показа:";
            this.labelYear.Click += new System.EventHandler(this.labelYear_Click);
            // 
            // panelSearchRecord
            // 
            this.panelSearchRecord.Controls.Add(this.btnSearch);
            this.panelSearchRecord.Controls.Add(this.label1);
            this.panelSearchRecord.Controls.Add(this.textBoxForSearch);
            this.panelSearchRecord.Location = new System.Drawing.Point(211, 105);
            this.panelSearchRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearchRecord.Name = "panelSearchRecord";
            this.panelSearchRecord.Size = new System.Drawing.Size(292, 117);
            this.panelSearchRecord.TabIndex = 16;
            // 
            // pictureBoxOpen
            // 
            this.pictureBoxOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOpen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpen.Image")));
            this.pictureBoxOpen.Location = new System.Drawing.Point(0, 32);
            this.pictureBoxOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxOpen.Name = "pictureBoxOpen";
            this.pictureBoxOpen.Size = new System.Drawing.Size(47, 34);
            this.pictureBoxOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOpen.TabIndex = 17;
            this.pictureBoxOpen.TabStop = false;
            this.pictureBoxOpen.Click += new System.EventHandler(this.pictureBoxOpen_Click);
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSave.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSave.Image")));
            this.pictureBoxSave.Location = new System.Drawing.Point(65, 32);
            this.pictureBoxSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(47, 34);
            this.pictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSave.TabIndex = 18;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.pictureBoxSave_Click);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(135, 32);
            this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(47, 34);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 19;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            // 
            // pictureBoxFAQ
            // 
            this.pictureBoxFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFAQ.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFAQ.Image")));
            this.pictureBoxFAQ.Location = new System.Drawing.Point(284, 32);
            this.pictureBoxFAQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxFAQ.Name = "pictureBoxFAQ";
            this.pictureBoxFAQ.Size = new System.Drawing.Size(47, 34);
            this.pictureBoxFAQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFAQ.TabIndex = 20;
            this.pictureBoxFAQ.TabStop = false;
            this.pictureBoxFAQ.Click += new System.EventHandler(this.pictureBoxFAQ_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdd.Image")));
            this.pictureBoxAdd.Location = new System.Drawing.Point(211, 32);
            this.pictureBoxAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(47, 34);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdd.TabIndex = 21;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSave.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSave.Location = new System.Drawing.Point(468, 28);
            this.labelSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(107, 22);
            this.labelSave.TabIndex = 22;
            this.labelSave.Text = "Сохранение...";
            this.labelSave.Click += new System.EventHandler(this.labelSave_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(16, 241);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(181, 32);
            this.btnSort.TabIndex = 23;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // comboBoxChoiceSort
            // 
            this.comboBoxChoiceSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiceSort.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChoiceSort.FormattingEnabled = true;
            this.comboBoxChoiceSort.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.comboBoxChoiceSort.Location = new System.Drawing.Point(211, 245);
            this.comboBoxChoiceSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxChoiceSort.Name = "comboBoxChoiceSort";
            this.comboBoxChoiceSort.Size = new System.Drawing.Size(160, 28);
            this.comboBoxChoiceSort.TabIndex = 24;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutoSave.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAutoSave.Location = new System.Drawing.Point(454, 32);
            this.labelAutoSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(140, 22);
            this.labelAutoSave.TabIndex = 25;
            this.labelAutoSave.Text = "Автосохранение...";
            this.labelAutoSave.Visible = false;
            this.labelAutoSave.Click += new System.EventHandler(this.labelAutoSave_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Width = 125;
            // 
            // filmname
            // 
            this.filmname.HeaderText = "Фильм";
            this.filmname.MinimumWidth = 6;
            this.filmname.Name = "filmname";
            this.filmname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.filmname.Width = 125;
            // 
            // Producer
            // 
            this.Producer.HeaderText = "Рижиссер";
            this.Producer.MinimumWidth = 6;
            this.Producer.Name = "Producer";
            this.Producer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Producer.Width = 125;
            // 
            // year
            // 
            this.year.HeaderText = "Год показа";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.year.Width = 125;
            // 
            // genre
            // 
            this.genre.HeaderText = "Жанр";
            this.genre.MinimumWidth = 6;
            this.genre.Name = "genre";
            this.genre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.genre.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(783, 570);
            this.Controls.Add(this.textBoxProducer);
            this.Controls.Add(this.labelAutoSave);
            this.Controls.Add(this.comboBoxChoiceSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.pictureBoxAdd);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.pictureBoxFAQ);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.textBoxFilm);
            this.Controls.Add(this.pictureBoxSave);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.pictureBoxOpen);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.panelSearchRecord);
            this.Controls.Add(this.labelProducer);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.btnClearRow);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(801, 617);
            this.MinimumSize = new System.Drawing.Size(801, 617);
            this.Name = "Form1";
            this.Text = "База данных фильмов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSearchRecord.ResumeLayout(false);
            this.panelSearchRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFAQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearRow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxForSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.TextBox textBoxFilm;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Panel panelSearchRecord;
        private System.Windows.Forms.PictureBox pictureBoxOpen;
        private System.Windows.Forms.PictureBox pictureBoxSave;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxFAQ;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox comboBoxChoiceSort;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelAutoSave;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
    }
}


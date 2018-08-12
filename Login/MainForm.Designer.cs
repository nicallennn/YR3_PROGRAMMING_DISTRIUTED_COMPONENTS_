namespace DesktopNetworkEditor
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
            this.components = new System.ComponentModel.Container();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStationEditor = new System.Windows.Forms.Panel();
            this.txtEdit = new TextBoxLibrary.NumericEntryTextbox(this.components);
            this.txtRemove = new TextBoxLibrary.NumericEntryTextbox(this.components);
            this.lineList = new System.Windows.Forms.ListBox();
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.na2880gDataSet = new DesktopNetworkEditor.na2880gDataSet1();
            this.stationList = new System.Windows.Forms.ListBox();
            this.pnlRadio = new System.Windows.Forms.Panel();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbStation = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStationList = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnRem = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.lblNewStationName = new System.Windows.Forms.Label();
            this.lblSelectStation = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditStation = new System.Windows.Forms.Label();
            this.lblRemoveStation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddStation = new System.Windows.Forms.Label();
            this.lblStationEditor = new System.Windows.Forms.Label();
            this.pnlLineEditor = new System.Windows.Forms.Panel();
            this.txtTime = new TextBoxLibrary.NumericEntryTextbox(this.components);
            this.txtPosition = new TextBoxLibrary.NumericEntryTextbox(this.components);
            this.txtStationToLine = new TextBoxLibrary.NumericEntryTextbox(this.components);
            this.txtDelay = new TextBoxLibrary.NumericEntryTextbox(this.components);
            this.txtDelayStationId = new TextBoxLibrary.NumericEntryTextbox(this.components);
            this.txtRemoveFromLine = new TextBoxLibrary.NumericEntryTextbox(this.components);
            this.txtLineInfo = new TextBoxLibrary.NumericEntryTextbox(this.components);
            this.txtLineSelect = new TextBoxLibrary.NumericEntryTextbox(this.components);
            this.lblDelay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDeleteDelay = new System.Windows.Forms.RadioButton();
            this.rbAddDelay = new System.Windows.Forms.RadioButton();
            this.lblDelaySection = new System.Windows.Forms.Label();
            this.BtnAddDelay = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLineIdName = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.BtnRemoveFromLine = new System.Windows.Forms.Button();
            this.BtnLineView = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lineInfoList = new System.Windows.Forms.ListBox();
            this.BtnAddStationToLine = new System.Windows.Forms.Button();
            this.lblTimeToNext = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblStationName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDistance = new TextBoxLibrary.DistanceTextbox(this.components);
            this.lblLineName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblPanelInfo = new System.Windows.Forms.Label();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.BtnStationsAndLines = new System.Windows.Forms.Button();
            this.BtnLineEditor = new System.Windows.Forms.Button();
            this.stationsTableAdapter = new DesktopNetworkEditor.na2880gDataSet1TableAdapters.stationsTableAdapter();
            this.linesTableAdapter = new DesktopNetworkEditor.na2880gDataSet1TableAdapters.linesTableAdapter();
            this.flowContainer.SuspendLayout();
            this.pnlStationEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.na2880gDataSet)).BeginInit();
            this.pnlRadio.SuspendLayout();
            this.pnlLineEditor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowContainer
            // 
            this.flowContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.flowContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowContainer.Controls.Add(this.pnlStationEditor);
            this.flowContainer.Controls.Add(this.pnlLineEditor);
            this.flowContainer.Location = new System.Drawing.Point(-2, 136);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(791, 741);
            this.flowContainer.TabIndex = 0;
            // 
            // pnlStationEditor
            // 
            this.pnlStationEditor.BackColor = System.Drawing.Color.Transparent;
            this.pnlStationEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStationEditor.Controls.Add(this.txtEdit);
            this.pnlStationEditor.Controls.Add(this.txtRemove);
            this.pnlStationEditor.Controls.Add(this.lineList);
            this.pnlStationEditor.Controls.Add(this.stationList);
            this.pnlStationEditor.Controls.Add(this.pnlRadio);
            this.pnlStationEditor.Controls.Add(this.label2);
            this.pnlStationEditor.Controls.Add(this.label1);
            this.pnlStationEditor.Controls.Add(this.lblStationList);
            this.pnlStationEditor.Controls.Add(this.BtnEdit);
            this.pnlStationEditor.Controls.Add(this.BtnRem);
            this.pnlStationEditor.Controls.Add(this.BtnAdd);
            this.pnlStationEditor.Controls.Add(this.lblNewStationName);
            this.pnlStationEditor.Controls.Add(this.lblSelectStation);
            this.pnlStationEditor.Controls.Add(this.txtEditName);
            this.pnlStationEditor.Controls.Add(this.lblEditStation);
            this.pnlStationEditor.Controls.Add(this.lblRemoveStation);
            this.pnlStationEditor.Controls.Add(this.txtName);
            this.pnlStationEditor.Controls.Add(this.lblAddStation);
            this.pnlStationEditor.Controls.Add(this.lblStationEditor);
            this.pnlStationEditor.Location = new System.Drawing.Point(10, 3);
            this.pnlStationEditor.Margin = new System.Windows.Forms.Padding(10, 3, 10, 0);
            this.pnlStationEditor.Name = "pnlStationEditor";
            this.pnlStationEditor.Size = new System.Drawing.Size(764, 349);
            this.pnlStationEditor.TabIndex = 0;
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(15, 268);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(100, 20);
            this.txtEdit.TabIndex = 30;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(15, 190);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(100, 20);
            this.txtRemove.TabIndex = 29;
            // 
            // lineList
            // 
            this.lineList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.lineList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stationsBindingSource, "station_id", true));
            this.lineList.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineList.ForeColor = System.Drawing.Color.Silver;
            this.lineList.FormattingEnabled = true;
            this.lineList.ItemHeight = 16;
            this.lineList.Location = new System.Drawing.Point(491, 83);
            this.lineList.Name = "lineList";
            this.lineList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lineList.Size = new System.Drawing.Size(252, 244);
            this.lineList.TabIndex = 28;
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataMember = "stations";
            this.stationsBindingSource.DataSource = this.na2880gDataSet;
            // 
            // na2880gDataSet
            // 
            this.na2880gDataSet.DataSetName = "na2880gDataSet";
            this.na2880gDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationList
            // 
            this.stationList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.stationList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stationsBindingSource, "station_id", true));
            this.stationList.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationList.ForeColor = System.Drawing.Color.Silver;
            this.stationList.FormattingEnabled = true;
            this.stationList.ItemHeight = 16;
            this.stationList.Location = new System.Drawing.Point(231, 83);
            this.stationList.Name = "stationList";
            this.stationList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.stationList.Size = new System.Drawing.Size(251, 244);
            this.stationList.TabIndex = 25;
            // 
            // pnlRadio
            // 
            this.pnlRadio.Controls.Add(this.rbLine);
            this.pnlRadio.Controls.Add(this.rbStation);
            this.pnlRadio.Location = new System.Drawing.Point(15, 75);
            this.pnlRadio.Name = "pnlRadio";
            this.pnlRadio.Size = new System.Drawing.Size(200, 36);
            this.pnlRadio.TabIndex = 22;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLine.ForeColor = System.Drawing.Color.SeaShell;
            this.rbLine.Location = new System.Drawing.Point(108, 8);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(49, 20);
            this.rbLine.TabIndex = 1;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbStation
            // 
            this.rbStation.AutoSize = true;
            this.rbStation.Checked = true;
            this.rbStation.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStation.ForeColor = System.Drawing.Color.SeaShell;
            this.rbStation.Location = new System.Drawing.Point(2, 8);
            this.rbStation.Name = "rbStation";
            this.rbStation.Size = new System.Drawing.Size(63, 20);
            this.rbStation.TabIndex = 0;
            this.rbStation.TabStop = true;
            this.rbStation.Text = "Station";
            this.rbStation.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(228, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Stations";
            // 
            // lblStationList
            // 
            this.lblStationList.AutoSize = true;
            this.lblStationList.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStationList.Location = new System.Drawing.Point(488, 55);
            this.lblStationList.Name = "lblStationList";
            this.lblStationList.Size = new System.Drawing.Size(41, 18);
            this.lblStationList.TabIndex = 15;
            this.lblStationList.Text = "Lines";
            // 
            // BtnEdit
            // 
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnEdit.FlatAppearance.BorderSize = 2;
            this.BtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnEdit.Location = new System.Drawing.Point(123, 306);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(68, 27);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnRem
            // 
            this.BtnRem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnRem.FlatAppearance.BorderSize = 2;
            this.BtnRem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnRem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRem.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnRem.Location = new System.Drawing.Point(123, 186);
            this.BtnRem.Name = "BtnRem";
            this.BtnRem.Size = new System.Drawing.Size(68, 27);
            this.BtnRem.TabIndex = 13;
            this.BtnRem.Text = "Remove";
            this.BtnRem.UseVisualStyleBackColor = true;
            this.BtnRem.Click += new System.EventHandler(this.BtnRem_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnAdd.FlatAppearance.BorderSize = 2;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnAdd.Location = new System.Drawing.Point(123, 130);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(68, 27);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblNewStationName
            // 
            this.lblNewStationName.AutoSize = true;
            this.lblNewStationName.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStationName.ForeColor = System.Drawing.Color.Silver;
            this.lblNewStationName.Location = new System.Drawing.Point(14, 291);
            this.lblNewStationName.Name = "lblNewStationName";
            this.lblNewStationName.Size = new System.Drawing.Size(73, 16);
            this.lblNewStationName.TabIndex = 11;
            this.lblNewStationName.Text = "New Name:";
            // 
            // lblSelectStation
            // 
            this.lblSelectStation.AutoSize = true;
            this.lblSelectStation.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectStation.ForeColor = System.Drawing.Color.Silver;
            this.lblSelectStation.Location = new System.Drawing.Point(14, 248);
            this.lblSelectStation.Name = "lblSelectStation";
            this.lblSelectStation.Size = new System.Drawing.Size(23, 16);
            this.lblSelectStation.TabIndex = 10;
            this.lblSelectStation.Text = "ID:";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(17, 310);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(100, 20);
            this.txtEditName.TabIndex = 6;
            // 
            // lblEditStation
            // 
            this.lblEditStation.AutoSize = true;
            this.lblEditStation.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditStation.Location = new System.Drawing.Point(14, 230);
            this.lblEditStation.Name = "lblEditStation";
            this.lblEditStation.Size = new System.Drawing.Size(35, 18);
            this.lblEditStation.TabIndex = 5;
            this.lblEditStation.Text = "Edit ";
            // 
            // lblRemoveStation
            // 
            this.lblRemoveStation.AutoSize = true;
            this.lblRemoveStation.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveStation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemoveStation.Location = new System.Drawing.Point(14, 169);
            this.lblRemoveStation.Name = "lblRemoveStation";
            this.lblRemoveStation.Size = new System.Drawing.Size(85, 18);
            this.lblRemoveStation.TabIndex = 3;
            this.lblRemoveStation.Text = "Remove (ID)";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblAddStation
            // 
            this.lblAddStation.AutoSize = true;
            this.lblAddStation.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddStation.Location = new System.Drawing.Point(14, 114);
            this.lblAddStation.Name = "lblAddStation";
            this.lblAddStation.Size = new System.Drawing.Size(36, 18);
            this.lblAddStation.TabIndex = 1;
            this.lblAddStation.Text = "Add ";
            // 
            // lblStationEditor
            // 
            this.lblStationEditor.AutoSize = true;
            this.lblStationEditor.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationEditor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStationEditor.Location = new System.Drawing.Point(13, 12);
            this.lblStationEditor.Name = "lblStationEditor";
            this.lblStationEditor.Size = new System.Drawing.Size(130, 19);
            this.lblStationEditor.TabIndex = 1;
            this.lblStationEditor.Text = "Stations and Lines";
            // 
            // pnlLineEditor
            // 
            this.pnlLineEditor.BackColor = System.Drawing.Color.Transparent;
            this.pnlLineEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLineEditor.Controls.Add(this.txtTime);
            this.pnlLineEditor.Controls.Add(this.txtPosition);
            this.pnlLineEditor.Controls.Add(this.txtStationToLine);
            this.pnlLineEditor.Controls.Add(this.txtDelay);
            this.pnlLineEditor.Controls.Add(this.txtDelayStationId);
            this.pnlLineEditor.Controls.Add(this.txtRemoveFromLine);
            this.pnlLineEditor.Controls.Add(this.txtLineInfo);
            this.pnlLineEditor.Controls.Add(this.txtLineSelect);
            this.pnlLineEditor.Controls.Add(this.lblDelay);
            this.pnlLineEditor.Controls.Add(this.label9);
            this.pnlLineEditor.Controls.Add(this.panel1);
            this.pnlLineEditor.Controls.Add(this.lblDelaySection);
            this.pnlLineEditor.Controls.Add(this.BtnAddDelay);
            this.pnlLineEditor.Controls.Add(this.BtnSort);
            this.pnlLineEditor.Controls.Add(this.lblId);
            this.pnlLineEditor.Controls.Add(this.label8);
            this.pnlLineEditor.Controls.Add(this.lblName);
            this.pnlLineEditor.Controls.Add(this.lblLineIdName);
            this.pnlLineEditor.Controls.Add(this.lblRemove);
            this.pnlLineEditor.Controls.Add(this.BtnRemoveFromLine);
            this.pnlLineEditor.Controls.Add(this.BtnLineView);
            this.pnlLineEditor.Controls.Add(this.label5);
            this.pnlLineEditor.Controls.Add(this.label4);
            this.pnlLineEditor.Controls.Add(this.lineInfoList);
            this.pnlLineEditor.Controls.Add(this.BtnAddStationToLine);
            this.pnlLineEditor.Controls.Add(this.lblTimeToNext);
            this.pnlLineEditor.Controls.Add(this.lblPosition);
            this.pnlLineEditor.Controls.Add(this.lblStationName);
            this.pnlLineEditor.Controls.Add(this.label3);
            this.pnlLineEditor.Controls.Add(this.txtDistance);
            this.pnlLineEditor.Controls.Add(this.lblLineName);
            this.pnlLineEditor.Controls.Add(this.label7);
            this.pnlLineEditor.Location = new System.Drawing.Point(10, 355);
            this.pnlLineEditor.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnlLineEditor.Name = "pnlLineEditor";
            this.pnlLineEditor.Size = new System.Drawing.Size(764, 315);
            this.pnlLineEditor.TabIndex = 0;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(15, 279);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 63;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(15, 169);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 20);
            this.txtPosition.TabIndex = 62;
            // 
            // txtStationToLine
            // 
            this.txtStationToLine.Location = new System.Drawing.Point(15, 116);
            this.txtStationToLine.Name = "txtStationToLine";
            this.txtStationToLine.Size = new System.Drawing.Size(100, 20);
            this.txtStationToLine.TabIndex = 61;
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(570, 283);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(100, 20);
            this.txtDelay.TabIndex = 60;
            // 
            // txtDelayStationId
            // 
            this.txtDelayStationId.Location = new System.Drawing.Point(429, 283);
            this.txtDelayStationId.Name = "txtDelayStationId";
            this.txtDelayStationId.Size = new System.Drawing.Size(100, 20);
            this.txtDelayStationId.TabIndex = 59;
            // 
            // txtRemoveFromLine
            // 
            this.txtRemoveFromLine.Location = new System.Drawing.Point(570, 250);
            this.txtRemoveFromLine.Name = "txtRemoveFromLine";
            this.txtRemoveFromLine.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveFromLine.TabIndex = 58;
            // 
            // txtLineInfo
            // 
            this.txtLineInfo.Location = new System.Drawing.Point(531, 35);
            this.txtLineInfo.Name = "txtLineInfo";
            this.txtLineInfo.Size = new System.Drawing.Size(100, 20);
            this.txtLineInfo.TabIndex = 57;
            this.txtLineInfo.TextChanged += new System.EventHandler(this.txtLineInfo_TextChanged);
            // 
            // txtLineSelect
            // 
            this.txtLineSelect.Location = new System.Drawing.Point(15, 64);
            this.txtLineSelect.Name = "txtLineSelect";
            this.txtLineSelect.Size = new System.Drawing.Size(100, 20);
            this.txtLineSelect.TabIndex = 31;
            this.txtLineSelect.TextChanged += new System.EventHandler(this.txtLineSelect_TextChanged);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDelay.Location = new System.Drawing.Point(532, 285);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(38, 16);
            this.lblDelay.TabIndex = 56;
            this.lblDelay.Text = "Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(405, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDeleteDelay);
            this.panel1.Controls.Add(this.rbAddDelay);
            this.panel1.Location = new System.Drawing.Point(277, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 36);
            this.panel1.TabIndex = 54;
            // 
            // rbDeleteDelay
            // 
            this.rbDeleteDelay.AutoSize = true;
            this.rbDeleteDelay.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeleteDelay.ForeColor = System.Drawing.Color.SeaShell;
            this.rbDeleteDelay.Location = new System.Drawing.Point(51, 7);
            this.rbDeleteDelay.Name = "rbDeleteDelay";
            this.rbDeleteDelay.Size = new System.Drawing.Size(71, 20);
            this.rbDeleteDelay.TabIndex = 1;
            this.rbDeleteDelay.Text = "Remove";
            this.rbDeleteDelay.UseVisualStyleBackColor = true;
            this.rbDeleteDelay.CheckedChanged += new System.EventHandler(this.rbDeleteDelay_CheckedChanged);
            // 
            // rbAddDelay
            // 
            this.rbAddDelay.AutoSize = true;
            this.rbAddDelay.Checked = true;
            this.rbAddDelay.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAddDelay.ForeColor = System.Drawing.Color.SeaShell;
            this.rbAddDelay.Location = new System.Drawing.Point(5, 7);
            this.rbAddDelay.Name = "rbAddDelay";
            this.rbAddDelay.Size = new System.Drawing.Size(48, 20);
            this.rbAddDelay.TabIndex = 0;
            this.rbAddDelay.TabStop = true;
            this.rbAddDelay.Text = "Add";
            this.rbAddDelay.UseVisualStyleBackColor = true;
            // 
            // lblDelaySection
            // 
            this.lblDelaySection.AutoSize = true;
            this.lblDelaySection.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelaySection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDelaySection.Location = new System.Drawing.Point(228, 286);
            this.lblDelaySection.Name = "lblDelaySection";
            this.lblDelaySection.Size = new System.Drawing.Size(47, 16);
            this.lblDelaySection.TabIndex = 52;
            this.lblDelaySection.Text = "Delays:";
            // 
            // BtnAddDelay
            // 
            this.BtnAddDelay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnAddDelay.FlatAppearance.BorderSize = 2;
            this.BtnAddDelay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnAddDelay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAddDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddDelay.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddDelay.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnAddDelay.Location = new System.Drawing.Point(676, 278);
            this.BtnAddDelay.Name = "BtnAddDelay";
            this.BtnAddDelay.Size = new System.Drawing.Size(68, 27);
            this.BtnAddDelay.TabIndex = 51;
            this.BtnAddDelay.Text = "Go";
            this.BtnAddDelay.UseVisualStyleBackColor = true;
            this.BtnAddDelay.Click += new System.EventHandler(this.BtnAddDelay_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnSort.FlatAppearance.BorderSize = 2;
            this.BtnSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSort.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSort.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnSort.Location = new System.Drawing.Point(695, 29);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(48, 27);
            this.BtnSort.TabIndex = 49;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Silver;
            this.lblId.Location = new System.Drawing.Point(409, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 16);
            this.lblId.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(386, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Silver;
            this.lblName.Location = new System.Drawing.Point(301, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 46;
            // 
            // lblLineIdName
            // 
            this.lblLineIdName.AutoSize = true;
            this.lblLineIdName.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineIdName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLineIdName.Location = new System.Drawing.Point(228, 38);
            this.lblLineIdName.Name = "lblLineIdName";
            this.lblLineIdName.Size = new System.Drawing.Size(73, 16);
            this.lblLineIdName.TabIndex = 45;
            this.lblLineIdName.Text = "Line Name: ";
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemove.Location = new System.Drawing.Point(471, 254);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(96, 16);
            this.lblRemove.TabIndex = 44;
            this.lblRemove.Text = "Remove Station:";
            // 
            // BtnRemoveFromLine
            // 
            this.BtnRemoveFromLine.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnRemoveFromLine.FlatAppearance.BorderSize = 2;
            this.BtnRemoveFromLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnRemoveFromLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnRemoveFromLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveFromLine.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveFromLine.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnRemoveFromLine.Location = new System.Drawing.Point(676, 246);
            this.BtnRemoveFromLine.Name = "BtnRemoveFromLine";
            this.BtnRemoveFromLine.Size = new System.Drawing.Size(68, 27);
            this.BtnRemoveFromLine.TabIndex = 43;
            this.BtnRemoveFromLine.Text = "Remove";
            this.BtnRemoveFromLine.UseVisualStyleBackColor = true;
            this.BtnRemoveFromLine.Click += new System.EventHandler(this.BtnRemoveFromLine_Click);
            // 
            // BtnLineView
            // 
            this.BtnLineView.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnLineView.FlatAppearance.BorderSize = 2;
            this.BtnLineView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnLineView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnLineView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLineView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLineView.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnLineView.Location = new System.Drawing.Point(641, 29);
            this.BtnLineView.Name = "BtnLineView";
            this.BtnLineView.Size = new System.Drawing.Size(48, 27);
            this.BtnLineView.TabIndex = 40;
            this.BtnLineView.Text = "View";
            this.BtnLineView.UseVisualStyleBackColor = true;
            this.BtnLineView.Click += new System.EventHandler(this.BtnLineView_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(462, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Select Line:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(228, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Line Information";
            // 
            // lineInfoList
            // 
            this.lineInfoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.lineInfoList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stationsBindingSource, "station_id", true));
            this.lineInfoList.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineInfoList.ForeColor = System.Drawing.Color.Silver;
            this.lineInfoList.FormattingEnabled = true;
            this.lineInfoList.ItemHeight = 16;
            this.lineInfoList.Location = new System.Drawing.Point(231, 60);
            this.lineInfoList.Name = "lineInfoList";
            this.lineInfoList.Size = new System.Drawing.Size(512, 180);
            this.lineInfoList.TabIndex = 29;
            // 
            // BtnAddStationToLine
            // 
            this.BtnAddStationToLine.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnAddStationToLine.FlatAppearance.BorderSize = 2;
            this.BtnAddStationToLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnAddStationToLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAddStationToLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddStationToLine.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStationToLine.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnAddStationToLine.Location = new System.Drawing.Point(123, 275);
            this.BtnAddStationToLine.Name = "BtnAddStationToLine";
            this.BtnAddStationToLine.Size = new System.Drawing.Size(68, 27);
            this.BtnAddStationToLine.TabIndex = 29;
            this.BtnAddStationToLine.Text = "Add";
            this.BtnAddStationToLine.UseVisualStyleBackColor = true;
            this.BtnAddStationToLine.Click += new System.EventHandler(this.BtnAddStationToLine_Click);
            // 
            // lblTimeToNext
            // 
            this.lblTimeToNext.AutoSize = true;
            this.lblTimeToNext.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeToNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeToNext.Location = new System.Drawing.Point(12, 258);
            this.lblTimeToNext.Name = "lblTimeToNext";
            this.lblTimeToNext.Size = new System.Drawing.Size(92, 18);
            this.lblTimeToNext.TabIndex = 36;
            this.lblTimeToNext.Text = "Time to Next ";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPosition.Location = new System.Drawing.Point(12, 148);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(89, 18);
            this.lblPosition.TabIndex = 33;
            this.lblPosition.Text = "Line Position";
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStationName.Location = new System.Drawing.Point(12, 95);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(80, 18);
            this.lblStationName.TabIndex = 31;
            this.lblStationName.Text = "Add Station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Distance to Next ";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(15, 224);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 2;
            // 
            // lblLineName
            // 
            this.lblLineName.AutoSize = true;
            this.lblLineName.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLineName.Location = new System.Drawing.Point(12, 43);
            this.lblLineName.Name = "lblLineName";
            this.lblLineName.Size = new System.Drawing.Size(60, 18);
            this.lblLineName.TabIndex = 29;
            this.lblLineName.Text = "Line (ID)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(13, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Line Editor";
            // 
            // linesBindingSource
            // 
            this.linesBindingSource.DataMember = "lines";
            this.linesBindingSource.DataSource = this.na2880gDataSet;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrand.Location = new System.Drawing.Point(20, 9);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(223, 39);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Live Journeys";
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.ForeColor = System.Drawing.Color.Silver;
            this.lblTagline.Location = new System.Drawing.Point(23, 48);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(178, 19);
            this.lblTagline.TabIndex = 2;
            this.lblTagline.Text = "Journey Planning System";
            // 
            // lblPanelInfo
            // 
            this.lblPanelInfo.AutoSize = true;
            this.lblPanelInfo.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelInfo.ForeColor = System.Drawing.Color.SeaShell;
            this.lblPanelInfo.Location = new System.Drawing.Point(24, 89);
            this.lblPanelInfo.Name = "lblPanelInfo";
            this.lblPanelInfo.Size = new System.Drawing.Size(88, 18);
            this.lblPanelInfo.TabIndex = 3;
            this.lblPanelInfo.Text = "Admin Panel";
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTitle.ForeColor = System.Drawing.Color.SeaShell;
            this.lblUserTitle.Location = new System.Drawing.Point(24, 107);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(40, 18);
            this.lblUserTitle.TabIndex = 4;
            this.lblUserTitle.Text = "User:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Silver;
            this.lblUsername.Location = new System.Drawing.Point(64, 107);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 18);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "(set on login)";
            // 
            // BtnStationsAndLines
            // 
            this.BtnStationsAndLines.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnStationsAndLines.FlatAppearance.BorderSize = 2;
            this.BtnStationsAndLines.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnStationsAndLines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnStationsAndLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStationsAndLines.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStationsAndLines.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnStationsAndLines.Location = new System.Drawing.Point(575, 12);
            this.BtnStationsAndLines.Name = "BtnStationsAndLines";
            this.BtnStationsAndLines.Size = new System.Drawing.Size(179, 50);
            this.BtnStationsAndLines.TabIndex = 6;
            this.BtnStationsAndLines.Text = "Stations and Lines";
            this.BtnStationsAndLines.UseVisualStyleBackColor = true;
            this.BtnStationsAndLines.Click += new System.EventHandler(this.BtnStationsAndLines_Click);
            // 
            // BtnLineEditor
            // 
            this.BtnLineEditor.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnLineEditor.FlatAppearance.BorderSize = 2;
            this.BtnLineEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnLineEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnLineEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLineEditor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLineEditor.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnLineEditor.Location = new System.Drawing.Point(575, 75);
            this.BtnLineEditor.Name = "BtnLineEditor";
            this.BtnLineEditor.Size = new System.Drawing.Size(179, 50);
            this.BtnLineEditor.TabIndex = 7;
            this.BtnLineEditor.Text = "Line Editor";
            this.BtnLineEditor.UseVisualStyleBackColor = true;
            this.BtnLineEditor.Click += new System.EventHandler(this.BtnLineEditor_Click);
            // 
            // stationsTableAdapter
            // 
            this.stationsTableAdapter.ClearBeforeFill = true;
            // 
            // linesTableAdapter
            // 
            this.linesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(784, 816);
            this.Controls.Add(this.BtnLineEditor);
            this.Controls.Add(this.BtnStationsAndLines);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUserTitle);
            this.Controls.Add(this.lblPanelInfo);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.flowContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live Journeys - Admin Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowContainer.ResumeLayout(false);
            this.pnlStationEditor.ResumeLayout(false);
            this.pnlStationEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.na2880gDataSet)).EndInit();
            this.pnlRadio.ResumeLayout(false);
            this.pnlRadio.PerformLayout();
            this.pnlLineEditor.ResumeLayout(false);
            this.pnlLineEditor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblPanelInfo;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button BtnStationsAndLines;
        private System.Windows.Forms.Button BtnLineEditor;
        private System.Windows.Forms.Panel pnlStationEditor;
        private System.Windows.Forms.Label lblStationEditor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddStation;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblEditStation;
        private System.Windows.Forms.Label lblRemoveStation;
        private System.Windows.Forms.Label lblSelectStation;
        private System.Windows.Forms.Label lblNewStationName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnRem;
        private System.Windows.Forms.Label lblStationList;
        private System.Windows.Forms.Panel pnlLineEditor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private na2880gDataSet1 na2880gDataSet;
        private System.Windows.Forms.BindingSource stationsBindingSource;
        private na2880gDataSet1TableAdapters.stationsTableAdapter stationsTableAdapter;
        private System.Windows.Forms.BindingSource linesBindingSource;
        private na2880gDataSet1TableAdapters.linesTableAdapter linesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlRadio;
        private System.Windows.Forms.RadioButton rbStation;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.ListBox stationList;
        private System.Windows.Forms.ListBox lineList;
        private TextBoxLibrary.DistanceTextbox txtDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLineName;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblTimeToNext;
        private System.Windows.Forms.Button BtnAddStationToLine;
        private System.Windows.Forms.ListBox lineInfoList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLineView;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Button BtnRemoveFromLine;
        private System.Windows.Forms.Label lblLineIdName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Label lblDelaySection;
        private System.Windows.Forms.Button BtnAddDelay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDeleteDelay;
        private System.Windows.Forms.RadioButton rbAddDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label label9;
        private TextBoxLibrary.NumericEntryTextbox txtRemove;
        private TextBoxLibrary.NumericEntryTextbox txtEdit;
        private TextBoxLibrary.NumericEntryTextbox txtLineSelect;
        private TextBoxLibrary.NumericEntryTextbox txtLineInfo;
        private TextBoxLibrary.NumericEntryTextbox txtRemoveFromLine;
        private TextBoxLibrary.NumericEntryTextbox txtDelayStationId;
        private TextBoxLibrary.NumericEntryTextbox txtDelay;
        private TextBoxLibrary.NumericEntryTextbox txtStationToLine;
        private TextBoxLibrary.NumericEntryTextbox txtPosition;
        private TextBoxLibrary.NumericEntryTextbox txtTime;
    }
}
namespace GST_INVOICE
{
    partial class invoice
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.combo_client = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_gstin = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grid_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_hsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_tax_val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_gst_Rate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grid_gst_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_cgst_rate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grid_cgst_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_igst_rate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grid_igst_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_del_row = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_sgst = new System.Windows.Forms.Label();
            this.lbl_cgst = new System.Windows.Forms.Label();
            this.lbl_igst = new System.Windows.Forms.Label();
            this.lbl_other = new System.Windows.Forms.Label();
            this.lbl_grand = new System.Windows.Forms.Label();
            this.llb_bef_tax = new System.Windows.Forms.Label();
            this.txt_before_tax = new System.Windows.Forms.TextBox();
            this.txt_sgst = new System.Windows.Forms.TextBox();
            this.txt_cgst = new System.Windows.Forms.TextBox();
            this.txt_igst = new System.Windows.Forms.TextBox();
            this.txt_other = new System.Windows.Forms.TextBox();
            this.txt_grand = new System.Windows.Forms.TextBox();
            this.lbl_amt = new System.Windows.Forms.Label();
            this.lbl_amt_word = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.c_id_hidden = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_invoice_no = new System.Windows.Forms.Label();
            this.txt_invoice_no = new System.Windows.Forms.TextBox();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.panel_invoice = new System.Windows.Forms.Panel();
            this.lbl_inv_hid_date = new System.Windows.Forms.Label();
            this.combo_reserve = new System.Windows.Forms.ComboBox();
            this.gst_rev = new System.Windows.Forms.Label();
            this.gst_menu = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERREGISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERREGISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVOICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSIGNEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_cust_name = new System.Windows.Forms.Label();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_invoice.SuspendLayout();
            this.gst_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // combo_client
            // 
            this.combo_client.FormattingEnabled = true;
            this.combo_client.Location = new System.Drawing.Point(28, 118);
            this.combo_client.Name = "combo_client";
            this.combo_client.Size = new System.Drawing.Size(224, 24);
            this.combo_client.TabIndex = 1;
            this.combo_client.SelectedIndexChanged += new System.EventHandler(this.combo_client_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "or by GSTIN";
            // 
            // lbl_gstin
            // 
            this.lbl_gstin.AutoSize = true;
            this.lbl_gstin.Location = new System.Drawing.Point(446, 52);
            this.lbl_gstin.Name = "lbl_gstin";
            this.lbl_gstin.Size = new System.Drawing.Size(0, 17);
            this.lbl_gstin.TabIndex = 3;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(446, 125);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(0, 17);
            this.lbl_address.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(258, 213);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 33);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_part,
            this.grid_hsn,
            this.grid_qty,
            this.grid_unit,
            this.grid_rate,
            this.grid_value,
            this.grid_disc,
            this.grid_tax_val,
            this.grid_gst_Rate,
            this.grid_gst_amt,
            this.grid_cgst_rate,
            this.grid_cgst_amt,
            this.grid_igst_rate,
            this.grid_igst_amt,
            this.grid_del_row});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(3, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 336);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // grid_part
            // 
            this.grid_part.HeaderText = "PARTICULARS";
            this.grid_part.Name = "grid_part";
            this.grid_part.Width = 128;
            // 
            // grid_hsn
            // 
            this.grid_hsn.HeaderText = "HSN/SAC";
            this.grid_hsn.Name = "grid_hsn";
            this.grid_hsn.Width = 93;
            // 
            // grid_qty
            // 
            this.grid_qty.HeaderText = "QTY.";
            this.grid_qty.Name = "grid_qty";
            this.grid_qty.Width = 66;
            // 
            // grid_unit
            // 
            this.grid_unit.HeaderText = "UNIT(Measure)";
            this.grid_unit.Name = "grid_unit";
            this.grid_unit.Width = 130;
            // 
            // grid_rate
            // 
            this.grid_rate.HeaderText = "RATE";
            this.grid_rate.Name = "grid_rate";
            this.grid_rate.Width = 70;
            // 
            // grid_value
            // 
            this.grid_value.HeaderText = "VALUE";
            this.grid_value.Name = "grid_value";
            this.grid_value.ReadOnly = true;
            this.grid_value.Width = 78;
            // 
            // grid_disc
            // 
            this.grid_disc.HeaderText = "DISCOUNT";
            this.grid_disc.Name = "grid_disc";
            this.grid_disc.Width = 104;
            // 
            // grid_tax_val
            // 
            this.grid_tax_val.HeaderText = "TAXABLE VALUE";
            this.grid_tax_val.Name = "grid_tax_val";
            this.grid_tax_val.ReadOnly = true;
            this.grid_tax_val.Width = 132;
            // 
            // grid_gst_Rate
            // 
            this.grid_gst_Rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grid_gst_Rate.HeaderText = "SGST-RATE";
            this.grid_gst_Rate.Name = "grid_gst_Rate";
            this.grid_gst_Rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_gst_Rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.grid_gst_Rate.Width = 113;
            // 
            // grid_gst_amt
            // 
            this.grid_gst_amt.HeaderText = "AMOUNT(sgst)";
            this.grid_gst_amt.Name = "grid_gst_amt";
            this.grid_gst_amt.ReadOnly = true;
            this.grid_gst_amt.Width = 129;
            // 
            // grid_cgst_rate
            // 
            this.grid_cgst_rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grid_cgst_rate.HeaderText = "CGST-RATE";
            this.grid_cgst_rate.Name = "grid_cgst_rate";
            this.grid_cgst_rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_cgst_rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.grid_cgst_rate.Width = 113;
            // 
            // grid_cgst_amt
            // 
            this.grid_cgst_amt.HeaderText = "AMOUNT(cgst)";
            this.grid_cgst_amt.Name = "grid_cgst_amt";
            this.grid_cgst_amt.ReadOnly = true;
            this.grid_cgst_amt.Width = 129;
            // 
            // grid_igst_rate
            // 
            this.grid_igst_rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grid_igst_rate.HeaderText = "IGST-RATE";
            this.grid_igst_rate.Name = "grid_igst_rate";
            this.grid_igst_rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_igst_rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.grid_igst_rate.Width = 107;
            // 
            // grid_igst_amt
            // 
            this.grid_igst_amt.HeaderText = "AMOUNT(igst)";
            this.grid_igst_amt.Name = "grid_igst_amt";
            this.grid_igst_amt.ReadOnly = true;
            this.grid_igst_amt.Width = 125;
            // 
            // grid_del_row
            // 
            this.grid_del_row.HeaderText = "DELETE";
            this.grid_del_row.Name = "grid_del_row";
            this.grid_del_row.Width = 68;
            // 
            // lbl_sgst
            // 
            this.lbl_sgst.AutoSize = true;
            this.lbl_sgst.Location = new System.Drawing.Point(785, 518);
            this.lbl_sgst.Name = "lbl_sgst";
            this.lbl_sgst.Size = new System.Drawing.Size(102, 17);
            this.lbl_sgst.TabIndex = 7;
            this.lbl_sgst.Text = "TOTAL(SGST)";
            // 
            // lbl_cgst
            // 
            this.lbl_cgst.AutoSize = true;
            this.lbl_cgst.Location = new System.Drawing.Point(785, 552);
            this.lbl_cgst.Name = "lbl_cgst";
            this.lbl_cgst.Size = new System.Drawing.Size(102, 17);
            this.lbl_cgst.TabIndex = 8;
            this.lbl_cgst.Text = "TOTAL(CGST)";
            // 
            // lbl_igst
            // 
            this.lbl_igst.AutoSize = true;
            this.lbl_igst.Location = new System.Drawing.Point(785, 591);
            this.lbl_igst.Name = "lbl_igst";
            this.lbl_igst.Size = new System.Drawing.Size(96, 17);
            this.lbl_igst.TabIndex = 9;
            this.lbl_igst.Text = "TOTAL(IGST)";
            // 
            // lbl_other
            // 
            this.lbl_other.AutoSize = true;
            this.lbl_other.Location = new System.Drawing.Point(785, 623);
            this.lbl_other.Name = "lbl_other";
            this.lbl_other.Size = new System.Drawing.Size(90, 17);
            this.lbl_other.TabIndex = 10;
            this.lbl_other.Text = "ROUND OFF";
            // 
            // lbl_grand
            // 
            this.lbl_grand.AutoSize = true;
            this.lbl_grand.Location = new System.Drawing.Point(785, 665);
            this.lbl_grand.Name = "lbl_grand";
            this.lbl_grand.Size = new System.Drawing.Size(108, 17);
            this.lbl_grand.TabIndex = 11;
            this.lbl_grand.Text = "GRAND TOTAL";
            // 
            // llb_bef_tax
            // 
            this.llb_bef_tax.AutoSize = true;
            this.llb_bef_tax.Location = new System.Drawing.Point(785, 482);
            this.llb_bef_tax.Name = "llb_bef_tax";
            this.llb_bef_tax.Size = new System.Drawing.Size(127, 17);
            this.llb_bef_tax.TabIndex = 12;
            this.llb_bef_tax.Text = "TOTAL(before tax)";
            // 
            // txt_before_tax
            // 
            this.txt_before_tax.Location = new System.Drawing.Point(955, 479);
            this.txt_before_tax.Name = "txt_before_tax";
            this.txt_before_tax.ReadOnly = true;
            this.txt_before_tax.Size = new System.Drawing.Size(159, 22);
            this.txt_before_tax.TabIndex = 13;
            this.txt_before_tax.Text = "0";
            // 
            // txt_sgst
            // 
            this.txt_sgst.Location = new System.Drawing.Point(955, 513);
            this.txt_sgst.Name = "txt_sgst";
            this.txt_sgst.ReadOnly = true;
            this.txt_sgst.Size = new System.Drawing.Size(159, 22);
            this.txt_sgst.TabIndex = 14;
            this.txt_sgst.Text = "0";
            // 
            // txt_cgst
            // 
            this.txt_cgst.Location = new System.Drawing.Point(955, 552);
            this.txt_cgst.Name = "txt_cgst";
            this.txt_cgst.ReadOnly = true;
            this.txt_cgst.Size = new System.Drawing.Size(159, 22);
            this.txt_cgst.TabIndex = 15;
            this.txt_cgst.Text = "0";
            // 
            // txt_igst
            // 
            this.txt_igst.Location = new System.Drawing.Point(955, 591);
            this.txt_igst.Name = "txt_igst";
            this.txt_igst.ReadOnly = true;
            this.txt_igst.Size = new System.Drawing.Size(159, 22);
            this.txt_igst.TabIndex = 16;
            this.txt_igst.Text = "0";
            // 
            // txt_other
            // 
            this.txt_other.Location = new System.Drawing.Point(955, 623);
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(159, 22);
            this.txt_other.TabIndex = 17;
            this.txt_other.Text = "0";
            this.txt_other.TextChanged += new System.EventHandler(this.txt_other_TextChanged);
            this.txt_other.Leave += new System.EventHandler(this.txt_other_Leave);
            // 
            // txt_grand
            // 
            this.txt_grand.Location = new System.Drawing.Point(955, 660);
            this.txt_grand.Name = "txt_grand";
            this.txt_grand.ReadOnly = true;
            this.txt_grand.Size = new System.Drawing.Size(159, 22);
            this.txt_grand.TabIndex = 18;
            this.txt_grand.Text = "0";
            this.txt_grand.TextChanged += new System.EventHandler(this.txt_grand_TextChanged);
            // 
            // lbl_amt
            // 
            this.lbl_amt.AutoSize = true;
            this.lbl_amt.Location = new System.Drawing.Point(21, 499);
            this.lbl_amt.Name = "lbl_amt";
            this.lbl_amt.Size = new System.Drawing.Size(112, 17);
            this.lbl_amt.TabIndex = 19;
            this.lbl_amt.Text = "Amount in words";
            // 
            // lbl_amt_word
            // 
            this.lbl_amt_word.AutoSize = true;
            this.lbl_amt_word.Location = new System.Drawing.Point(193, 499);
            this.lbl_amt_word.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbl_amt_word.Name = "lbl_amt_word";
            this.lbl_amt_word.Size = new System.Drawing.Size(0, 17);
            this.lbl_amt_word.TabIndex = 20;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(841, 766);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(273, 37);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "SAVE and PRINT";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // c_id_hidden
            // 
            this.c_id_hidden.AutoSize = true;
            this.c_id_hidden.Location = new System.Drawing.Point(36, 159);
            this.c_id_hidden.Name = "c_id_hidden";
            this.c_id_hidden.Size = new System.Drawing.Size(0, 17);
            this.c_id_hidden.TabIndex = 22;
            this.c_id_hidden.Visible = false;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(762, 41);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(136, 22);
            this.txt_date.TabIndex = 23;
            this.txt_date.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_date_MouseClick);
            this.txt_date.TextChanged += new System.EventHandler(this.txt_date_TextChanged);
            this.txt_date.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txt_date.Leave += new System.EventHandler(this.txt_date_Leave);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(661, 41);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(81, 17);
            this.lbl_date.TabIndex = 24;
            this.lbl_date.Text = "Select Date";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(845, 39);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 25;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.Leave += new System.EventHandler(this.monthCalendar1_Leave);
            // 
            // lbl_invoice_no
            // 
            this.lbl_invoice_no.AutoSize = true;
            this.lbl_invoice_no.Location = new System.Drawing.Point(36, 52);
            this.lbl_invoice_no.Name = "lbl_invoice_no";
            this.lbl_invoice_no.Size = new System.Drawing.Size(78, 17);
            this.lbl_invoice_no.TabIndex = 26;
            this.lbl_invoice_no.Text = "Invoice No.";
            // 
            // txt_invoice_no
            // 
            this.txt_invoice_no.Location = new System.Drawing.Point(132, 52);
            this.txt_invoice_no.Name = "txt_invoice_no";
            this.txt_invoice_no.ReadOnly = true;
            this.txt_invoice_no.Size = new System.Drawing.Size(100, 22);
            this.txt_invoice_no.TabIndex = 27;
            // 
            // btn_pdf
            // 
            this.btn_pdf.Location = new System.Drawing.Point(664, 766);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(93, 43);
            this.btn_pdf.TabIndex = 33;
            this.btn_pdf.Text = "PDF";
            this.btn_pdf.UseVisualStyleBackColor = true;
            this.btn_pdf.Visible = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // panel_invoice
            // 
            this.panel_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_invoice.Controls.Add(this.lbl_inv_hid_date);
            this.panel_invoice.Controls.Add(this.combo_reserve);
            this.panel_invoice.Controls.Add(this.gst_rev);
            this.panel_invoice.Controls.Add(this.dataGridView1);
            this.panel_invoice.Controls.Add(this.btn_pdf);
            this.panel_invoice.Controls.Add(this.lbl_date);
            this.panel_invoice.Controls.Add(this.txt_date);
            this.panel_invoice.Controls.Add(this.lbl_amt_word);
            this.panel_invoice.Controls.Add(this.lbl_amt);
            this.panel_invoice.Controls.Add(this.llb_bef_tax);
            this.panel_invoice.Controls.Add(this.txt_before_tax);
            this.panel_invoice.Controls.Add(this.txt_sgst);
            this.panel_invoice.Controls.Add(this.lbl_sgst);
            this.panel_invoice.Controls.Add(this.lbl_cgst);
            this.panel_invoice.Controls.Add(this.txt_cgst);
            this.panel_invoice.Controls.Add(this.btn_save);
            this.panel_invoice.Controls.Add(this.txt_igst);
            this.panel_invoice.Controls.Add(this.txt_grand);
            this.panel_invoice.Controls.Add(this.lbl_igst);
            this.panel_invoice.Controls.Add(this.lbl_grand);
            this.panel_invoice.Controls.Add(this.txt_other);
            this.panel_invoice.Controls.Add(this.lbl_other);
            this.panel_invoice.Location = new System.Drawing.Point(39, 258);
            this.panel_invoice.Name = "panel_invoice";
            this.panel_invoice.Size = new System.Drawing.Size(1167, 817);
            this.panel_invoice.TabIndex = 34;
            this.panel_invoice.Visible = false;
            // 
            // lbl_inv_hid_date
            // 
            this.lbl_inv_hid_date.AutoSize = true;
            this.lbl_inv_hid_date.Location = new System.Drawing.Point(930, 44);
            this.lbl_inv_hid_date.Name = "lbl_inv_hid_date";
            this.lbl_inv_hid_date.Size = new System.Drawing.Size(0, 17);
            this.lbl_inv_hid_date.TabIndex = 36;
            this.lbl_inv_hid_date.Visible = false;
            // 
            // combo_reserve
            // 
            this.combo_reserve.FormattingEnabled = true;
            this.combo_reserve.Location = new System.Drawing.Point(955, 706);
            this.combo_reserve.Name = "combo_reserve";
            this.combo_reserve.Size = new System.Drawing.Size(96, 24);
            this.combo_reserve.TabIndex = 35;
            // 
            // gst_rev
            // 
            this.gst_rev.AutoSize = true;
            this.gst_rev.Location = new System.Drawing.Point(785, 709);
            this.gst_rev.Name = "gst_rev";
            this.gst_rev.Size = new System.Drawing.Size(131, 17);
            this.gst_rev.TabIndex = 34;
            this.gst_rev.Text = "GST ON RESERVE";
            // 
            // gst_menu
            // 
            this.gst_menu.BackColor = System.Drawing.Color.Lavender;
            this.gst_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gst_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.cUSTOMERREGISTRATIONToolStripMenuItem,
            this.uSERREGISTRATIONToolStripMenuItem,
            this.iNVOICEToolStripMenuItem,
            this.cONSIGNEToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.gst_menu.Location = new System.Drawing.Point(0, 0);
            this.gst_menu.Name = "gst_menu";
            this.gst_menu.Size = new System.Drawing.Size(1225, 28);
            this.gst_menu.TabIndex = 110;
            this.gst_menu.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // cUSTOMERREGISTRATIONToolStripMenuItem
            // 
            this.cUSTOMERREGISTRATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem1,
            this.eDITToolStripMenuItem1});
            this.cUSTOMERREGISTRATIONToolStripMenuItem.Name = "cUSTOMERREGISTRATIONToolStripMenuItem";
            this.cUSTOMERREGISTRATIONToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.cUSTOMERREGISTRATIONToolStripMenuItem.Text = "COMPANY";
            // 
            // nEWToolStripMenuItem1
            // 
            this.nEWToolStripMenuItem1.Name = "nEWToolStripMenuItem1";
            this.nEWToolStripMenuItem1.Size = new System.Drawing.Size(174, 24);
            this.nEWToolStripMenuItem1.Text = "NEW";
            this.nEWToolStripMenuItem1.Visible = false;
            this.nEWToolStripMenuItem1.Click += new System.EventHandler(this.nEWToolStripMenuItem1_Click);
            // 
            // eDITToolStripMenuItem1
            // 
            this.eDITToolStripMenuItem1.Name = "eDITToolStripMenuItem1";
            this.eDITToolStripMenuItem1.Size = new System.Drawing.Size(174, 24);
            this.eDITToolStripMenuItem1.Text = "VIEW/UPDATE";
            this.eDITToolStripMenuItem1.Click += new System.EventHandler(this.eDITToolStripMenuItem1_Click);
            // 
            // uSERREGISTRATIONToolStripMenuItem
            // 
            this.uSERREGISTRATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.eDITToolStripMenuItem});
            this.uSERREGISTRATIONToolStripMenuItem.Name = "uSERREGISTRATIONToolStripMenuItem";
            this.uSERREGISTRATIONToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.uSERREGISTRATIONToolStripMenuItem.Text = "CUSTOMER";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.nEWToolStripMenuItem.Text = "NEW";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.eDITToolStripMenuItem.Text = "SEARCH";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // iNVOICEToolStripMenuItem
            // 
            this.iNVOICEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem3,
            this.eDITToolStripMenuItem3,
            this.exportToExcelToolStripMenuItem,
            this.importToolStripMenuItem});
            this.iNVOICEToolStripMenuItem.Name = "iNVOICEToolStripMenuItem";
            this.iNVOICEToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.iNVOICEToolStripMenuItem.Text = "INVOICE";
            // 
            // nEWToolStripMenuItem3
            // 
            this.nEWToolStripMenuItem3.Name = "nEWToolStripMenuItem3";
            this.nEWToolStripMenuItem3.Size = new System.Drawing.Size(177, 24);
            this.nEWToolStripMenuItem3.Text = "NEW";
            this.nEWToolStripMenuItem3.Click += new System.EventHandler(this.nEWToolStripMenuItem3_Click);
            // 
            // eDITToolStripMenuItem3
            // 
            this.eDITToolStripMenuItem3.Name = "eDITToolStripMenuItem3";
            this.eDITToolStripMenuItem3.Size = new System.Drawing.Size(177, 24);
            this.eDITToolStripMenuItem3.Text = "SEARCH";
            this.eDITToolStripMenuItem3.Click += new System.EventHandler(this.eDITToolStripMenuItem3_Click);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // cONSIGNEToolStripMenuItem
            // 
            this.cONSIGNEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem2,
            this.eDITToolStripMenuItem2});
            this.cONSIGNEToolStripMenuItem.Name = "cONSIGNEToolStripMenuItem";
            this.cONSIGNEToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.cONSIGNEToolStripMenuItem.Text = "CONSIGNE";
            this.cONSIGNEToolStripMenuItem.Visible = false;
            // 
            // nEWToolStripMenuItem2
            // 
            this.nEWToolStripMenuItem2.Name = "nEWToolStripMenuItem2";
            this.nEWToolStripMenuItem2.Size = new System.Drawing.Size(111, 24);
            this.nEWToolStripMenuItem2.Text = "NEW";
            // 
            // eDITToolStripMenuItem2
            // 
            this.eDITToolStripMenuItem2.Name = "eDITToolStripMenuItem2";
            this.eDITToolStripMenuItem2.Size = new System.Drawing.Size(111, 24);
            this.eDITToolStripMenuItem2.Text = "EDIT";
            // 
            // lbl_cust_name
            // 
            this.lbl_cust_name.AutoSize = true;
            this.lbl_cust_name.Location = new System.Drawing.Point(446, 99);
            this.lbl_cust_name.Name = "lbl_cust_name";
            this.lbl_cust_name.Size = new System.Drawing.Size(0, 17);
            this.lbl_cust_name.TabIndex = 111;
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1225, 1075);
            this.Controls.Add(this.lbl_cust_name);
            this.Controls.Add(this.gst_menu);
            this.Controls.Add(this.panel_invoice);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txt_invoice_no);
            this.Controls.Add(this.lbl_invoice_no);
            this.Controls.Add(this.c_id_hidden);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_gstin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_client);
            this.Controls.Add(this.textBox1);
            this.Name = "invoice";
            this.Text = "GENERATE INVOICE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_invoice.ResumeLayout(false);
            this.panel_invoice.PerformLayout();
            this.gst_menu.ResumeLayout(false);
            this.gst_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox combo_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_gstin;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_sgst;
        private System.Windows.Forms.Label lbl_cgst;
        private System.Windows.Forms.Label lbl_igst;
        private System.Windows.Forms.Label lbl_other;
        private System.Windows.Forms.Label lbl_grand;
        private System.Windows.Forms.Label llb_bef_tax;
        private System.Windows.Forms.TextBox txt_before_tax;
        private System.Windows.Forms.TextBox txt_sgst;
        private System.Windows.Forms.TextBox txt_cgst;
        private System.Windows.Forms.TextBox txt_igst;
        private System.Windows.Forms.TextBox txt_other;
        private System.Windows.Forms.TextBox txt_grand;
        private System.Windows.Forms.Label lbl_amt;
        private System.Windows.Forms.Label lbl_amt_word;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label c_id_hidden;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_invoice_no;
        private System.Windows.Forms.TextBox txt_invoice_no;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Panel panel_invoice;
        private System.Windows.Forms.MenuStrip gst_menu;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERREGISTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERREGISTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iNVOICEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cONSIGNEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ComboBox combo_reserve;
        private System.Windows.Forms.Label gst_rev;
        private System.Windows.Forms.Label lbl_cust_name;
        private System.Windows.Forms.Label lbl_inv_hid_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_hsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_tax_val;
        private System.Windows.Forms.DataGridViewComboBoxColumn grid_gst_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_gst_amt;
        private System.Windows.Forms.DataGridViewComboBoxColumn grid_cgst_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_cgst_amt;
        private System.Windows.Forms.DataGridViewComboBoxColumn grid_igst_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_igst_amt;
        private System.Windows.Forms.DataGridViewButtonColumn grid_del_row;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}
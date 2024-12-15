namespace TESTCK_LTTQ
{
    partial class Form2
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
            System.Windows.Forms.Label sTTLabel;
            System.Windows.Forms.Label tENSACHLabel;
            System.Windows.Forms.Label tACGIALabel;
            System.Windows.Forms.Label tHELOAILabel;
            System.Windows.Forms.Label sLTONLabel;
            this.qL_THUVIENDataSet = new TESTCK_LTTQ.QL_THUVIENDataSet();
            this.tHUVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHUVIENTableAdapter = new TESTCK_LTTQ.QL_THUVIENDataSetTableAdapters.THUVIENTableAdapter();
            this.tableAdapterManager = new TESTCK_LTTQ.QL_THUVIENDataSetTableAdapters.TableAdapterManager();
            this.tbTENSACH = new System.Windows.Forms.TextBox();
            this.tbTACGIA = new System.Windows.Forms.TextBox();
            this.tbTHELOAI = new System.Windows.Forms.TextBox();
            this.tbSLTON = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            sTTLabel = new System.Windows.Forms.Label();
            tENSACHLabel = new System.Windows.Forms.Label();
            tACGIALabel = new System.Windows.Forms.Label();
            tHELOAILabel = new System.Windows.Forms.Label();
            sLTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUVIENBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qL_THUVIENDataSet
            // 
            this.qL_THUVIENDataSet.DataSetName = "QL_THUVIENDataSet";
            this.qL_THUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHUVIENBindingSource
            // 
            this.tHUVIENBindingSource.DataMember = "THUVIEN";
            this.tHUVIENBindingSource.DataSource = this.qL_THUVIENDataSet;
            // 
            // tHUVIENTableAdapter
            // 
            this.tHUVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.THUVIENTableAdapter = this.tHUVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = TESTCK_LTTQ.QL_THUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sTTLabel
            // 
            sTTLabel.AutoSize = true;
            sTTLabel.Location = new System.Drawing.Point(122, 76);
            sTTLabel.Name = "sTTLabel";
            sTTLabel.Size = new System.Drawing.Size(0, 16);
            sTTLabel.TabIndex = 1;
            // 
            // tENSACHLabel
            // 
            tENSACHLabel.AutoSize = true;
            tENSACHLabel.Location = new System.Drawing.Point(33, 28);
            tENSACHLabel.Name = "tENSACHLabel";
            tENSACHLabel.Size = new System.Drawing.Size(66, 16);
            tENSACHLabel.TabIndex = 3;
            tENSACHLabel.Text = "Tên sách:";
            tENSACHLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbTENSACH
            // 
            this.tbTENSACH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHUVIENBindingSource, "TENSACH", true));
            this.tbTENSACH.Location = new System.Drawing.Point(105, 25);
            this.tbTENSACH.Name = "tbTENSACH";
            this.tbTENSACH.Size = new System.Drawing.Size(363, 22);
            this.tbTENSACH.TabIndex = 4;
            // 
            // tACGIALabel
            // 
            tACGIALabel.AutoSize = true;
            tACGIALabel.Location = new System.Drawing.Point(43, 62);
            tACGIALabel.Name = "tACGIALabel";
            tACGIALabel.Size = new System.Drawing.Size(56, 16);
            tACGIALabel.TabIndex = 5;
            tACGIALabel.Text = "Tác giả:";
            tACGIALabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTACGIA
            // 
            this.tbTACGIA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHUVIENBindingSource, "TACGIA", true));
            this.tbTACGIA.Location = new System.Drawing.Point(105, 59);
            this.tbTACGIA.Name = "tbTACGIA";
            this.tbTACGIA.Size = new System.Drawing.Size(363, 22);
            this.tbTACGIA.TabIndex = 6;
            // 
            // tHELOAILabel
            // 
            tHELOAILabel.AutoSize = true;
            tHELOAILabel.Location = new System.Drawing.Point(37, 99);
            tHELOAILabel.Name = "tHELOAILabel";
            tHELOAILabel.Size = new System.Drawing.Size(62, 16);
            tHELOAILabel.TabIndex = 7;
            tHELOAILabel.Text = "Thể loại: ";
            tHELOAILabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            tHELOAILabel.Click += new System.EventHandler(this.tHELOAILabel_Click);
            // 
            // tbTHELOAI
            // 
            this.tbTHELOAI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHUVIENBindingSource, "THELOAI", true));
            this.tbTHELOAI.Location = new System.Drawing.Point(105, 99);
            this.tbTHELOAI.Name = "tbTHELOAI";
            this.tbTHELOAI.Size = new System.Drawing.Size(363, 22);
            this.tbTHELOAI.TabIndex = 8;
            // 
            // sLTONLabel
            // 
            sLTONLabel.AutoSize = true;
            sLTONLabel.Location = new System.Drawing.Point(15, 131);
            sLTONLabel.Name = "sLTONLabel";
            sLTONLabel.Size = new System.Drawing.Size(84, 16);
            sLTONLabel.TabIndex = 9;
            sLTONLabel.Text = "Số lượng tồn:";
            sLTONLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbSLTON
            // 
            this.tbSLTON.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHUVIENBindingSource, "SLTON", true));
            this.tbSLTON.Location = new System.Drawing.Point(105, 131);
            this.tbSLTON.Name = "tbSLTON";
            this.tbSLTON.Size = new System.Drawing.Size(363, 22);
            this.tbSLTON.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tENSACHLabel);
            this.groupBox1.Controls.Add(tACGIALabel);
            this.groupBox1.Controls.Add(this.tbSLTON);
            this.groupBox1.Controls.Add(this.tbTHELOAI);
            this.groupBox1.Controls.Add(this.tbTACGIA);
            this.groupBox1.Controls.Add(this.tbTENSACH);
            this.groupBox1.Controls.Add(tHELOAILabel);
            this.groupBox1.Controls.Add(sLTONLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 175);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin thêm mới";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(sTTLabel);
            this.Name = "Form2";
            this.Text = "THÊM MỚI";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUVIENBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_THUVIENDataSet qL_THUVIENDataSet;
        private System.Windows.Forms.BindingSource tHUVIENBindingSource;
        private QL_THUVIENDataSetTableAdapters.THUVIENTableAdapter tHUVIENTableAdapter;
        private QL_THUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbTENSACH;
        private System.Windows.Forms.TextBox tbTACGIA;
        private System.Windows.Forms.TextBox tbTHELOAI;
        private System.Windows.Forms.TextBox tbSLTON;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
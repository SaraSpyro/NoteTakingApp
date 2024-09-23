
namespace NoteTaking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SearchBarTxt = new TextBox();
            SearchBtn = new Button();
            NewNoteGB = new GroupBox();
            button1 = new Button();
            BodyTxt = new TextBox();
            TitleTxt = new TextBox();
            BodyLbl = new Label();
            TitleLbl = new Label();
            Notes = new ListBox();
            OpenBtn = new Button();
            DelBtn = new Button();
            ShowListBtn = new Button();
            NewNoteGB.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBarTxt
            // 
            SearchBarTxt.BackColor = Color.White;
            SearchBarTxt.Location = new Point(900, 12);
            SearchBarTxt.Name = "SearchBarTxt";
            SearchBarTxt.RightToLeft = RightToLeft.Yes;
            SearchBarTxt.Size = new Size(277, 31);
            SearchBarTxt.TabIndex = 0;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(243, 181, 98);
            SearchBtn.BackgroundImageLayout = ImageLayout.None;
            SearchBtn.Font = new Font("IRANSansWeb", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.Location = new Point(800, 12);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.RightToLeft = RightToLeft.Yes;
            SearchBtn.Size = new Size(94, 31);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "پیداش کن!";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // NewNoteGB
            // 
            NewNoteGB.Controls.Add(button1);
            NewNoteGB.Controls.Add(BodyTxt);
            NewNoteGB.Controls.Add(TitleTxt);
            NewNoteGB.Controls.Add(BodyLbl);
            NewNoteGB.Controls.Add(TitleLbl);
            NewNoteGB.Font = new Font("IRANSansWeb", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            NewNoteGB.Location = new Point(12, 12);
            NewNoteGB.Name = "NewNoteGB";
            NewNoteGB.RightToLeft = RightToLeft.Yes;
            NewNoteGB.Size = new Size(762, 716);
            NewNoteGB.TabIndex = 2;
            NewNoteGB.TabStop = false;
            NewNoteGB.Text = "اینجا بنویس!";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(140, 190, 178);
            button1.Font = new Font("IRANSansWeb", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(11, 55);
            button1.Name = "button1";
            button1.Size = new Size(117, 31);
            button1.TabIndex = 10;
            button1.Text = "ثبتش کن!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // BodyTxt
            // 
            BodyTxt.Font = new Font("IRANSans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BodyTxt.Location = new Point(6, 105);
            BodyTxt.Multiline = true;
            BodyTxt.Name = "BodyTxt";
            BodyTxt.Size = new Size(677, 600);
            BodyTxt.TabIndex = 3;
            // 
            // TitleTxt
            // 
            TitleTxt.Font = new Font("IRANSansWeb", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TitleTxt.Location = new Point(406, 55);
            TitleTxt.Name = "TitleTxt";
            TitleTxt.Size = new Size(277, 31);
            TitleTxt.TabIndex = 2;
            // 
            // BodyLbl
            // 
            BodyLbl.AutoSize = true;
            BodyLbl.Location = new Point(701, 105);
            BodyLbl.Name = "BodyLbl";
            BodyLbl.Size = new Size(52, 31);
            BodyLbl.TabIndex = 1;
            BodyLbl.Text = "متن:";
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(689, 55);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(64, 31);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "عنوان:";
            // 
            // Notes
            // 
            Notes.Font = new Font("IRANSansWeb", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            Notes.FormattingEnabled = true;
            Notes.ItemHeight = 31;
            Notes.Location = new Point(800, 124);
            Notes.Name = "Notes";
            Notes.RightToLeft = RightToLeft.Yes;
            Notes.Size = new Size(377, 593);
            Notes.TabIndex = 3;
            // 
            // OpenBtn
            // 
            OpenBtn.BackColor = Color.FromArgb(140, 190, 178);
            OpenBtn.BackgroundImageLayout = ImageLayout.None;
            OpenBtn.Font = new Font("IRANSansWeb", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OpenBtn.Location = new Point(944, 67);
            OpenBtn.Name = "OpenBtn";
            OpenBtn.RightToLeft = RightToLeft.Yes;
            OpenBtn.Size = new Size(94, 31);
            OpenBtn.TabIndex = 4;
            OpenBtn.Text = "بازش کن!";
            OpenBtn.UseVisualStyleBackColor = false;
            OpenBtn.Click += OpenBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.FromArgb(240, 96, 96);
            DelBtn.BackgroundImageLayout = ImageLayout.None;
            DelBtn.Font = new Font("IRANSansWeb", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DelBtn.Location = new Point(800, 67);
            DelBtn.Name = "DelBtn";
            DelBtn.RightToLeft = RightToLeft.Yes;
            DelBtn.Size = new Size(94, 31);
            DelBtn.TabIndex = 5;
            DelBtn.Text = "پاکش کن!";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // ShowListBtn
            // 
            ShowListBtn.BackColor = Color.FromArgb(92, 75, 81);
            ShowListBtn.BackgroundImageLayout = ImageLayout.None;
            ShowListBtn.Font = new Font("IRANSansWeb", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowListBtn.ForeColor = Color.White;
            ShowListBtn.Location = new Point(1083, 69);
            ShowListBtn.Name = "ShowListBtn";
            ShowListBtn.RightToLeft = RightToLeft.Yes;
            ShowListBtn.Size = new Size(94, 31);
            ShowListBtn.TabIndex = 6;
            ShowListBtn.Text = "نشون بده!";
            ShowListBtn.UseVisualStyleBackColor = false;
            ShowListBtn.Click += ShowListBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 235, 191);
            ClientSize = new Size(1189, 751);
            Controls.Add(ShowListBtn);
            Controls.Add(DelBtn);
            Controls.Add(OpenBtn);
            Controls.Add(Notes);
            Controls.Add(NewNoteGB);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBarTxt);
            Font = new Font("IRANSansWeb", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Note";
            Load += Form1_Load;
            NewNoteGB.ResumeLayout(false);
            NewNoteGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox SearchBarTxt;
        private Button SearchBtn;
        private GroupBox NewNoteGB;
        private TextBox TitleTxt;
        private Label BodyLbl;
        private Label TitleLbl;
        private TextBox BodyTxt;
        private Button button1;
        private ListBox Notes;
        private Button OpenBtn;
        private Button DelBtn;
        private Button ShowListBtn;
    }
}

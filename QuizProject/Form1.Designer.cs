namespace TestProject_9v_6
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
            this.components = new System.ComponentModel.Container();
            this.nextQuestionBttn = new System.Windows.Forms.Button();
            this.aAnswerRadioBttn = new System.Windows.Forms.RadioButton();
            this.bAnswerRadioBttn = new System.Windows.Forms.RadioButton();
            this.cAnswerRadioBttn = new System.Windows.Forms.RadioButton();
            this.currQuestionLbl = new System.Windows.Forms.Label();
            this.timeLeftLbl = new System.Windows.Forms.Label();
            this.questionsLeftLbl = new System.Windows.Forms.Label();
            this.chooseAnswerLbl = new System.Windows.Forms.Label();
            this.questionTxtBox = new System.Windows.Forms.RichTextBox();
            this.dAnswerRadioBttn = new System.Windows.Forms.RadioButton();
            this.resultsBttn = new System.Windows.Forms.Button();
            this.pointsLbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.noTimeLbl = new System.Windows.Forms.Label();
            this.endTestBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextQuestionBttn
            // 
            this.nextQuestionBttn.Location = new System.Drawing.Point(463, 296);
            this.nextQuestionBttn.Name = "nextQuestionBttn";
            this.nextQuestionBttn.Size = new System.Drawing.Size(137, 48);
            this.nextQuestionBttn.TabIndex = 0;
            this.nextQuestionBttn.Text = "Следващ въпрос";
            this.nextQuestionBttn.UseVisualStyleBackColor = true;
            this.nextQuestionBttn.Click += new System.EventHandler(this.nextQuestionButt_Click);
            // 
            // aAnswerRadioBttn
            // 
            this.aAnswerRadioBttn.AutoSize = true;
            this.aAnswerRadioBttn.Location = new System.Drawing.Point(151, 245);
            this.aAnswerRadioBttn.Name = "aAnswerRadioBttn";
            this.aAnswerRadioBttn.Size = new System.Drawing.Size(14, 13);
            this.aAnswerRadioBttn.TabIndex = 1;
            this.aAnswerRadioBttn.TabStop = true;
            this.aAnswerRadioBttn.UseVisualStyleBackColor = true;
            // 
            // bAnswerRadioBttn
            // 
            this.bAnswerRadioBttn.AutoSize = true;
            this.bAnswerRadioBttn.Location = new System.Drawing.Point(151, 283);
            this.bAnswerRadioBttn.Name = "bAnswerRadioBttn";
            this.bAnswerRadioBttn.Size = new System.Drawing.Size(14, 13);
            this.bAnswerRadioBttn.TabIndex = 2;
            this.bAnswerRadioBttn.TabStop = true;
            this.bAnswerRadioBttn.UseVisualStyleBackColor = true;
            // 
            // cAnswerRadioBttn
            // 
            this.cAnswerRadioBttn.AutoSize = true;
            this.cAnswerRadioBttn.Location = new System.Drawing.Point(151, 314);
            this.cAnswerRadioBttn.Name = "cAnswerRadioBttn";
            this.cAnswerRadioBttn.Size = new System.Drawing.Size(14, 13);
            this.cAnswerRadioBttn.TabIndex = 3;
            this.cAnswerRadioBttn.TabStop = true;
            this.cAnswerRadioBttn.UseVisualStyleBackColor = true;
            // 
            // currQuestionLbl
            // 
            this.currQuestionLbl.AutoSize = true;
            this.currQuestionLbl.Location = new System.Drawing.Point(49, 78);
            this.currQuestionLbl.Name = "currQuestionLbl";
            this.currQuestionLbl.Size = new System.Drawing.Size(51, 15);
            this.currQuestionLbl.TabIndex = 4;
            this.currQuestionLbl.Text = "Въпрос ";
            // 
            // timeLeftLbl
            // 
            this.timeLeftLbl.AutoSize = true;
            this.timeLeftLbl.Location = new System.Drawing.Point(49, 50);
            this.timeLeftLbl.Name = "timeLeftLbl";
            this.timeLeftLbl.Size = new System.Drawing.Size(106, 15);
            this.timeLeftLbl.TabIndex = 5;
            this.timeLeftLbl.Text = "Оставащо време: ";
            // 
            // questionsLeftLbl
            // 
            this.questionsLeftLbl.AutoSize = true;
            this.questionsLeftLbl.Location = new System.Drawing.Point(429, 50);
            this.questionsLeftLbl.Name = "questionsLeftLbl";
            this.questionsLeftLbl.Size = new System.Drawing.Size(119, 15);
            this.questionsLeftLbl.TabIndex = 6;
            this.questionsLeftLbl.Text = "Оставащи въпроси: ";
            // 
            // chooseAnswerLbl
            // 
            this.chooseAnswerLbl.AutoSize = true;
            this.chooseAnswerLbl.Location = new System.Drawing.Point(37, 243);
            this.chooseAnswerLbl.Name = "chooseAnswerLbl";
            this.chooseAnswerLbl.Size = new System.Drawing.Size(108, 15);
            this.chooseAnswerLbl.TabIndex = 7;
            this.chooseAnswerLbl.Text = "Изберете отговор:";
            // 
            // questionTxtBox
            // 
            this.questionTxtBox.Location = new System.Drawing.Point(49, 96);
            this.questionTxtBox.Name = "questionTxtBox";
            this.questionTxtBox.ReadOnly = true;
            this.questionTxtBox.Size = new System.Drawing.Size(551, 116);
            this.questionTxtBox.TabIndex = 8;
            this.questionTxtBox.Text = "";
            // 
            // dAnswerRadioBttn
            // 
            this.dAnswerRadioBttn.AutoSize = true;
            this.dAnswerRadioBttn.Location = new System.Drawing.Point(151, 349);
            this.dAnswerRadioBttn.Name = "dAnswerRadioBttn";
            this.dAnswerRadioBttn.Size = new System.Drawing.Size(14, 13);
            this.dAnswerRadioBttn.TabIndex = 9;
            this.dAnswerRadioBttn.TabStop = true;
            this.dAnswerRadioBttn.UseVisualStyleBackColor = true;
            // 
            // resultsBttn
            // 
            this.resultsBttn.Location = new System.Drawing.Point(221, 245);
            this.resultsBttn.Name = "resultsBttn";
            this.resultsBttn.Size = new System.Drawing.Size(182, 62);
            this.resultsBttn.TabIndex = 10;
            this.resultsBttn.Text = "Виж резултата си";
            this.resultsBttn.UseVisualStyleBackColor = true;
            this.resultsBttn.Visible = false;
            this.resultsBttn.Click += new System.EventHandler(this.resultsBttn_Click);
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointsLbl.Location = new System.Drawing.Point(221, 136);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(171, 37);
            this.pointsLbl.TabIndex = 11;
            this.pointsLbl.Text = "Брой точки: ";
            this.pointsLbl.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // noTimeLbl
            // 
            this.noTimeLbl.AutoSize = true;
            this.noTimeLbl.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noTimeLbl.Location = new System.Drawing.Point(129, 123);
            this.noTimeLbl.Name = "noTimeLbl";
            this.noTimeLbl.Size = new System.Drawing.Size(398, 54);
            this.noTimeLbl.TabIndex = 12;
            this.noTimeLbl.Text = "Времето ви свърши!";
            this.noTimeLbl.Visible = false;
            // 
            // endTestBttn
            // 
            this.endTestBttn.Location = new System.Drawing.Point(221, 243);
            this.endTestBttn.Name = "endTestBttn";
            this.endTestBttn.Size = new System.Drawing.Size(182, 62);
            this.endTestBttn.TabIndex = 13;
            this.endTestBttn.Text = "Край на теста";
            this.endTestBttn.UseVisualStyleBackColor = true;
            this.endTestBttn.Visible = false;
            this.endTestBttn.Click += new System.EventHandler(this.endTestBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(641, 385);
            this.Controls.Add(this.endTestBttn);
            this.Controls.Add(this.noTimeLbl);
            this.Controls.Add(this.pointsLbl);
            this.Controls.Add(this.resultsBttn);
            this.Controls.Add(this.dAnswerRadioBttn);
            this.Controls.Add(this.questionTxtBox);
            this.Controls.Add(this.chooseAnswerLbl);
            this.Controls.Add(this.questionsLeftLbl);
            this.Controls.Add(this.timeLeftLbl);
            this.Controls.Add(this.currQuestionLbl);
            this.Controls.Add(this.cAnswerRadioBttn);
            this.Controls.Add(this.bAnswerRadioBttn);
            this.Controls.Add(this.aAnswerRadioBttn);
            this.Controls.Add(this.nextQuestionBttn);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Тест за интелигентност";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button nextQuestionBttn;
        private RadioButton aAnswerRadioBttn;
        private RadioButton bAnswerRadioBttn;
        private RadioButton cAnswerRadioBttn;
        private Label currQuestionLbl;
        private Label timeLeftLbl;
        private Label questionsLeftLbl;
        private Label chooseAnswerLbl;
        private RichTextBox questionTxtBox;
        private RadioButton dAnswerRadioBttn;
        private Button resultsBttn;
        private Label pointsLbl;
        private System.Windows.Forms.Timer timer;
        private Label noTimeLbl;
        private Button endTestBttn;
    }
}
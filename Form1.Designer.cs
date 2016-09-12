using PitchPerfect.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace PitchPerfect
{
    partial class PitchPerfect_
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
        int lessonCounter = 0; //counter for lessons
        bool guest = true; //test for whether or not user is logged in
        int userID = 0; //globally recognize who is logged in
        int qCount = 0; // quiz counter;
        
        float correctAnswers = 0;
        List<Question> quizQuestions;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lessonFinal = new System.Windows.Forms.Panel();
            this.lessToMenu = new System.Windows.Forms.PictureBox();
            this.lessToHS = new System.Windows.Forms.PictureBox();
            this.lessToTest = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lessonPanel = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.PictureBox();
            this.playSoundBtn = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.NoteSetupLabel = new System.Windows.Forms.Label();
            this.quizFinal = new System.Windows.Forms.Panel();
            this.quizToMenu = new System.Windows.Forms.PictureBox();
            this.redoQuizBtn = new System.Windows.Forms.PictureBox();
            this.quizHS = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.quiz = new System.Windows.Forms.Panel();
            this.qNum = new System.Windows.Forms.Label();
            this.quizNext = new System.Windows.Forms.PictureBox();
            this.playQuizSound = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.q2 = new System.Windows.Forms.RadioButton();
            this.q3 = new System.Windows.Forms.RadioButton();
            this.q4 = new System.Windows.Forms.RadioButton();
            this.q1 = new System.Windows.Forms.RadioButton();
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.PictureBox();
            this.labelWarning = new System.Windows.Forms.Label();
            this.logInBtn = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonGuest = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logoLabel2 = new System.Windows.Forms.PictureBox();
            this.logOutBtn = new System.Windows.Forms.PictureBox();
            this.toLessonBtn = new System.Windows.Forms.PictureBox();
            this.toQuizBtn = new System.Windows.Forms.PictureBox();
            this.menuHS = new System.Windows.Forms.PictureBox();
            this.lessonFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessToMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessToHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessToTest)).BeginInit();
            this.lessonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playSoundBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.quizFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizToMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redoQuizBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizHS)).BeginInit();
            this.quiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playQuizSound)).BeginInit();
            this.LogInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGuest)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toLessonBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toQuizBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuHS)).BeginInit();
            this.SuspendLayout();
            // 
            // lessonFinal
            // 
            this.lessonFinal.BackgroundImage = global::PitchPerfect.Properties.Resources.mainbackgeround;
            this.lessonFinal.Controls.Add(this.lessToMenu);
            this.lessonFinal.Controls.Add(this.lessToHS);
            this.lessonFinal.Controls.Add(this.lessToTest);
            this.lessonFinal.Controls.Add(this.label1);
            this.lessonFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lessonFinal.Location = new System.Drawing.Point(0, 0);
            this.lessonFinal.Name = "lessonFinal";
            this.lessonFinal.Size = new System.Drawing.Size(397, 318);
            this.lessonFinal.TabIndex = 9;
            this.lessonFinal.Visible = false;
            // 
            // lessToMenu
            // 
            this.lessToMenu.Image = global::PitchPerfect.Properties.Resources.retMenu;
            this.lessToMenu.Location = new System.Drawing.Point(111, 237);
            this.lessToMenu.Name = "lessToMenu";
            this.lessToMenu.Size = new System.Drawing.Size(161, 31);
            this.lessToMenu.TabIndex = 3;
            this.lessToMenu.TabStop = false;
            this.lessToMenu.Click += new System.EventHandler(this.toMenu_Click);
            // 
            // lessToHS
            // 
            this.lessToHS.Image = global::PitchPerfect.Properties.Resources.viewHS;
            this.lessToHS.Location = new System.Drawing.Point(111, 175);
            this.lessToHS.Name = "lessToHS";
            this.lessToHS.Size = new System.Drawing.Size(163, 32);
            this.lessToHS.TabIndex = 2;
            this.lessToHS.TabStop = false;
            this.lessToHS.Click += new System.EventHandler(this.highS_Click);
            // 
            // lessToTest
            // 
            this.lessToTest.Image = global::PitchPerfect.Properties.Resources.Proceed_to_quiz;
            this.lessToTest.Location = new System.Drawing.Point(110, 111);
            this.lessToTest.Name = "lessToTest";
            this.lessToTest.Size = new System.Drawing.Size(162, 31);
            this.lessToTest.TabIndex = 1;
            this.lessToTest.TabStop = false;
            this.lessToTest.Click += new System.EventHandler(this.toQuiz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congrats! You completed the Lesson.\rNow choose from the menu:";
            // 
            // lessonPanel
            // 
            this.lessonPanel.BackgroundImage = global::PitchPerfect.Properties.Resources.mainbackgeround;
            this.lessonPanel.Controls.Add(this.nextBtn);
            this.lessonPanel.Controls.Add(this.playSoundBtn);
            this.lessonPanel.Controls.Add(this.backBtn);
            this.lessonPanel.Controls.Add(this.NoteLabel);
            this.lessonPanel.Controls.Add(this.NoteSetupLabel);
            this.lessonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lessonPanel.Location = new System.Drawing.Point(0, 0);
            this.lessonPanel.Name = "lessonPanel";
            this.lessonPanel.Size = new System.Drawing.Size(397, 318);
            this.lessonPanel.TabIndex = 0;
            // 
            // nextBtn
            // 
            this.nextBtn.Image = global::PitchPerfect.Properties.Resources.Next;
            this.nextBtn.Location = new System.Drawing.Point(276, 274);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(93, 32);
            this.nextBtn.TabIndex = 8;
            this.nextBtn.TabStop = false;
            this.nextBtn.Click += new System.EventHandler(this.next_Click);
            // 
            // playSoundBtn
            // 
            this.playSoundBtn.Image = global::PitchPerfect.Properties.Resources.Playsound;
            this.playSoundBtn.Location = new System.Drawing.Point(135, 148);
            this.playSoundBtn.Name = "playSoundBtn";
            this.playSoundBtn.Size = new System.Drawing.Size(115, 31);
            this.playSoundBtn.TabIndex = 7;
            this.playSoundBtn.TabStop = false;
            this.playSoundBtn.Click += new System.EventHandler(this.playSoundBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Image = global::PitchPerfect.Properties.Resources.Back;
            this.backBtn.Location = new System.Drawing.Point(23, 274);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(93, 32);
            this.backBtn.TabIndex = 6;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.prev_Click);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.NoteLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.Location = new System.Drawing.Point(272, 73);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(0, 21);
            this.NoteLabel.TabIndex = 5;
            // 
            // NoteSetupLabel
            // 
            this.NoteSetupLabel.AutoSize = true;
            this.NoteSetupLabel.BackColor = System.Drawing.Color.Transparent;
            this.NoteSetupLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteSetupLabel.Location = new System.Drawing.Point(19, 73);
            this.NoteSetupLabel.Name = "NoteSetupLabel";
            this.NoteSetupLabel.Size = new System.Drawing.Size(247, 21);
            this.NoteSetupLabel.TabIndex = 4;
            this.NoteSetupLabel.Text = "The following note is a(n): ";
            // 
            // quizFinal
            // 
            this.quizFinal.BackgroundImage = global::PitchPerfect.Properties.Resources.mainbackgeround;
            this.quizFinal.Controls.Add(this.quizToMenu);
            this.quizFinal.Controls.Add(this.redoQuizBtn);
            this.quizFinal.Controls.Add(this.quizHS);
            this.quizFinal.Controls.Add(this.scoreLabel);
            this.quizFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizFinal.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizFinal.Location = new System.Drawing.Point(0, 0);
            this.quizFinal.Name = "quizFinal";
            this.quizFinal.Size = new System.Drawing.Size(397, 318);
            this.quizFinal.TabIndex = 8;
            // 
            // quizToMenu
            // 
            this.quizToMenu.Image = global::PitchPerfect.Properties.Resources.retMenu;
            this.quizToMenu.Location = new System.Drawing.Point(111, 161);
            this.quizToMenu.Name = "quizToMenu";
            this.quizToMenu.Size = new System.Drawing.Size(160, 31);
            this.quizToMenu.TabIndex = 3;
            this.quizToMenu.TabStop = false;
            this.quizToMenu.Click += new System.EventHandler(this.toMenu_Click);
            // 
            // redoQuizBtn
            // 
            this.redoQuizBtn.Image = global::PitchPerfect.Properties.Resources.Retryquiz;
            this.redoQuizBtn.Location = new System.Drawing.Point(111, 226);
            this.redoQuizBtn.Name = "redoQuizBtn";
            this.redoQuizBtn.Size = new System.Drawing.Size(163, 31);
            this.redoQuizBtn.TabIndex = 2;
            this.redoQuizBtn.TabStop = false;
            this.redoQuizBtn.Click += new System.EventHandler(this.toQuiz_Click);
            // 
            // quizHS
            // 
            this.quizHS.Image = global::PitchPerfect.Properties.Resources.viewHS;
            this.quizHS.Location = new System.Drawing.Point(110, 92);
            this.quizHS.Name = "quizHS";
            this.quizHS.Size = new System.Drawing.Size(161, 31);
            this.quizHS.TabIndex = 1;
            this.quizHS.TabStop = false;
            this.quizHS.Click += new System.EventHandler(this.highS_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scoreLabel.Location = new System.Drawing.Point(0, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(397, 73);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quiz
            // 
            this.quiz.BackgroundImage = global::PitchPerfect.Properties.Resources.mainbackgeround;
            this.quiz.Controls.Add(this.qNum);
            this.quiz.Controls.Add(this.quizNext);
            this.quiz.Controls.Add(this.playQuizSound);
            this.quiz.Controls.Add(this.Title);
            this.quiz.Controls.Add(this.q2);
            this.quiz.Controls.Add(this.q3);
            this.quiz.Controls.Add(this.q4);
            this.quiz.Controls.Add(this.q1);
            this.quiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quiz.Location = new System.Drawing.Point(0, 0);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(397, 318);
            this.quiz.TabIndex = 14;
            // 
            // qNum
            // 
            this.qNum.AutoSize = true;
            this.qNum.BackColor = System.Drawing.Color.Transparent;
            this.qNum.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qNum.Location = new System.Drawing.Point(69, 94);
            this.qNum.Name = "qNum";
            this.qNum.Size = new System.Drawing.Size(0, 19);
            this.qNum.TabIndex = 7;
            // 
            // quizNext
            // 
            this.quizNext.Image = global::PitchPerfect.Properties.Resources.Next;
            this.quizNext.Location = new System.Drawing.Point(155, 284);
            this.quizNext.Name = "quizNext";
            this.quizNext.Size = new System.Drawing.Size(86, 31);
            this.quizNext.TabIndex = 6;
            this.quizNext.TabStop = false;
            this.quizNext.Click += new System.EventHandler(this.quizNext_Click);
            // 
            // playQuizSound
            // 
            this.playQuizSound.Image = global::PitchPerfect.Properties.Resources.Playsound;
            this.playQuizSound.Location = new System.Drawing.Point(256, 142);
            this.playQuizSound.Name = "playQuizSound";
            this.playQuizSound.Size = new System.Drawing.Size(116, 34);
            this.playQuizSound.TabIndex = 5;
            this.playQuizSound.TabStop = false;
            this.playQuizSound.Click += new System.EventHandler(this.playQuizSound_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(171, 26);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(54, 23);
            this.Title.TabIndex = 4;
            this.Title.Text = "Quiz";
            // 
            // q2
            // 
            this.q2.AutoSize = true;
            this.q2.BackColor = System.Drawing.Color.Transparent;
            this.q2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2.Location = new System.Drawing.Point(102, 129);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(14, 13);
            this.q2.TabIndex = 3;
            this.q2.TabStop = true;
            this.q2.UseVisualStyleBackColor = false;
            // 
            // q3
            // 
            this.q3.AutoSize = true;
            this.q3.BackColor = System.Drawing.Color.Transparent;
            this.q3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3.Location = new System.Drawing.Point(102, 163);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(14, 13);
            this.q3.TabIndex = 2;
            this.q3.TabStop = true;
            this.q3.UseVisualStyleBackColor = false;
            // 
            // q4
            // 
            this.q4.AutoSize = true;
            this.q4.BackColor = System.Drawing.Color.Transparent;
            this.q4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4.Location = new System.Drawing.Point(102, 200);
            this.q4.Name = "q4";
            this.q4.Size = new System.Drawing.Size(14, 13);
            this.q4.TabIndex = 1;
            this.q4.TabStop = true;
            this.q4.UseVisualStyleBackColor = false;
            // 
            // q1
            // 
            this.q1.AutoSize = true;
            this.q1.BackColor = System.Drawing.Color.Transparent;
            this.q1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1.Location = new System.Drawing.Point(102, 91);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(14, 13);
            this.q1.TabIndex = 0;
            this.q1.TabStop = true;
            this.q1.UseVisualStyleBackColor = false;
            // 
            // LogInPanel
            // 
            this.LogInPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogInPanel.BackgroundImage = global::PitchPerfect.Properties.Resources.mainbackgeround;
            this.LogInPanel.Controls.Add(this.logoLabel);
            this.LogInPanel.Controls.Add(this.labelWarning);
            this.LogInPanel.Controls.Add(this.logInBtn);
            this.LogInPanel.Controls.Add(this.textBoxName);
            this.LogInPanel.Controls.Add(this.buttonGuest);
            this.LogInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogInPanel.Location = new System.Drawing.Point(0, 0);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(397, 318);
            this.LogInPanel.TabIndex = 2;
            // 
            // logoLabel
            // 
            this.logoLabel.Image = global::PitchPerfect.Properties.Resources.Pitchperfect_title;
            this.logoLabel.Location = new System.Drawing.Point(0, -9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(397, 122);
            this.logoLabel.TabIndex = 14;
            this.logoLabel.TabStop = false;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(69, 111);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 13);
            this.labelWarning.TabIndex = 13;
            // 
            // logInBtn
            // 
            this.logInBtn.Image = global::PitchPerfect.Properties.Resources.Login;
            this.logInBtn.Location = new System.Drawing.Point(150, 175);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(86, 34);
            this.logInBtn.TabIndex = 12;
            this.logInBtn.TabStop = false;
            this.logInBtn.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxName.Location = new System.Drawing.Point(133, 135);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 20);
            this.textBoxName.TabIndex = 11;
            this.textBoxName.Text = "Put your name here...";
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            this.textBoxName.MouseEnter += new System.EventHandler(this.textBoxName_MouseEnter);
            // 
            // buttonGuest
            // 
            this.buttonGuest.Image = global::PitchPerfect.Properties.Resources.PlayasGuest;
            this.buttonGuest.Location = new System.Drawing.Point(222, 274);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(163, 32);
            this.buttonGuest.TabIndex = 0;
            this.buttonGuest.TabStop = false;
            this.buttonGuest.Click += new System.EventHandler(this.buttonGuest_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackgroundImage = global::PitchPerfect.Properties.Resources.mainbackgeround;
            this.menuPanel.Controls.Add(this.logoLabel2);
            this.menuPanel.Controls.Add(this.logOutBtn);
            this.menuPanel.Controls.Add(this.toLessonBtn);
            this.menuPanel.Controls.Add(this.toQuizBtn);
            this.menuPanel.Controls.Add(this.menuHS);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(397, 318);
            this.menuPanel.TabIndex = 10;
            // 
            // logoLabel2
            // 
            this.logoLabel2.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel2.Image = global::PitchPerfect.Properties.Resources.Pitchperfect_title;
            this.logoLabel2.Location = new System.Drawing.Point(-3, -22);
            this.logoLabel2.Name = "logoLabel2";
            this.logoLabel2.Size = new System.Drawing.Size(397, 126);
            this.logoLabel2.TabIndex = 5;
            this.logoLabel2.TabStop = false;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Image = global::PitchPerfect.Properties.Resources.logout2;
            this.logOutBtn.Location = new System.Drawing.Point(115, 263);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(159, 31);
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.TabStop = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOut_Click);
            // 
            // toLessonBtn
            // 
            this.toLessonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toLessonBtn.Image = global::PitchPerfect.Properties.Resources.Lesson;
            this.toLessonBtn.Location = new System.Drawing.Point(115, 111);
            this.toLessonBtn.Name = "toLessonBtn";
            this.toLessonBtn.Size = new System.Drawing.Size(159, 32);
            this.toLessonBtn.TabIndex = 3;
            this.toLessonBtn.TabStop = false;
            this.toLessonBtn.Click += new System.EventHandler(this.toLesson_Click);
            // 
            // toQuizBtn
            // 
            this.toQuizBtn.Image = global::PitchPerfect.Properties.Resources.QUiz2;
            this.toQuizBtn.Location = new System.Drawing.Point(115, 163);
            this.toQuizBtn.Name = "toQuizBtn";
            this.toQuizBtn.Size = new System.Drawing.Size(159, 32);
            this.toQuizBtn.TabIndex = 2;
            this.toQuizBtn.TabStop = false;
            this.toQuizBtn.Click += new System.EventHandler(this.toQuiz_Click);
            // 
            // menuHS
            // 
            this.menuHS.Image = global::PitchPerfect.Properties.Resources.viewHS;
            this.menuHS.Location = new System.Drawing.Point(115, 215);
            this.menuHS.Name = "menuHS";
            this.menuHS.Size = new System.Drawing.Size(159, 31);
            this.menuHS.TabIndex = 1;
            this.menuHS.TabStop = false;
            this.menuHS.Click += new System.EventHandler(this.highS_Click);
            // 
            // PitchPerfect_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 318);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.lessonFinal);
            this.Controls.Add(this.lessonPanel);
            this.Controls.Add(this.quizFinal);
            this.Controls.Add(this.quiz);
            this.Controls.Add(this.LogInPanel);
            this.Name = "PitchPerfect_";
            this.Text = "PitchPerfect";
            this.Load += new System.EventHandler(this.PitchPerfect_Load);
            this.lessonFinal.ResumeLayout(false);
            this.lessonFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessToMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessToHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessToTest)).EndInit();
            this.lessonPanel.ResumeLayout(false);
            this.lessonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playSoundBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.quizFinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quizToMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redoQuizBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizHS)).EndInit();
            this.quiz.ResumeLayout(false);
            this.quiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playQuizSound)).EndInit();
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGuest)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toLessonBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toQuizBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lessonPanel;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Label NoteSetupLabel;
        private System.Windows.Forms.PictureBox playSoundBtn;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.PictureBox nextBtn;
        private System.Windows.Forms.Panel lessonFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox lessToMenu;
        private System.Windows.Forms.PictureBox lessToHS;
        private System.Windows.Forms.PictureBox lessToTest;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox menuHS;
        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.PictureBox buttonGuest;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox logInBtn;
        private System.Windows.Forms.PictureBox toLessonBtn;
        private System.Windows.Forms.PictureBox toQuizBtn;
        private System.Windows.Forms.PictureBox logOutBtn;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Panel quiz;
        private System.Windows.Forms.RadioButton q1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RadioButton q2;
        private System.Windows.Forms.RadioButton q3;
        private System.Windows.Forms.RadioButton q4;
        private System.Windows.Forms.Label qNum;
        private System.Windows.Forms.PictureBox quizNext;
        private System.Windows.Forms.PictureBox playQuizSound;
        private System.Windows.Forms.Panel quizFinal;
        private System.Windows.Forms.PictureBox quizToMenu;
        private System.Windows.Forms.PictureBox redoQuizBtn;
        private System.Windows.Forms.PictureBox quizHS;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox logoLabel;
        private System.Windows.Forms.PictureBox logoLabel2;
    }
}


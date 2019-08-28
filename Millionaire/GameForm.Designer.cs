﻿using System;

namespace Millionaire
{
    partial class GameForm
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
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.initialPanel = new System.Windows.Forms.Panel();
            this.choosePackGroupBox = new System.Windows.Forms.GroupBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.answersPanel = new System.Windows.Forms.Panel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerButton1 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.answerButton4 = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.addTimeHint = new System.Windows.Forms.Button();
            this.hint3 = new System.Windows.Forms.Button();
            this.hint2 = new System.Windows.Forms.Button();
            this.hint1 = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.initialPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.answersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(52, 80);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(101, 13);
            this.playerNameLabel.TabIndex = 1;
            this.playerNameLabel.Text = "Введите ваше имя";
            // 
            // playerNameBox
            // 
            this.playerNameBox.Location = new System.Drawing.Point(55, 110);
            this.playerNameBox.MaxLength = 20;
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(154, 20);
            this.playerNameBox.TabIndex = 2;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(356, 396);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(98, 23);
            this.startGameButton.TabIndex = 4;
            this.startGameButton.Text = "Начать игру";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // initialPanel
            // 
            this.initialPanel.Controls.Add(this.choosePackGroupBox);
            this.initialPanel.Controls.Add(this.startGameButton);
            this.initialPanel.Controls.Add(this.playerNameBox);
            this.initialPanel.Controls.Add(this.playerNameLabel);
            this.initialPanel.Location = new System.Drawing.Point(0, 0);
            this.initialPanel.Name = "initialPanel";
            this.initialPanel.Size = new System.Drawing.Size(850, 650);
            this.initialPanel.TabIndex = 5;
            // 
            // choosePackGroupBox
            // 
            this.choosePackGroupBox.Location = new System.Drawing.Point(500, 40);
            this.choosePackGroupBox.Name = "choosePackGroupBox";
            this.choosePackGroupBox.Size = new System.Drawing.Size(250, 350);
            this.choosePackGroupBox.TabIndex = 5;
            this.choosePackGroupBox.TabStop = false;
            this.choosePackGroupBox.Text = "Выберете набор вопросов";
            // 
            // gamePanel
            // 
            this.gamePanel.BackgroundImage = global::Millionaire.Properties.Resources.Game;
            this.gamePanel.Controls.Add(this.answersPanel);
            this.gamePanel.Controls.Add(this.helpButton);
            this.gamePanel.Controls.Add(this.addTimeHint);
            this.gamePanel.Controls.Add(this.hint3);
            this.gamePanel.Controls.Add(this.hint2);
            this.gamePanel.Controls.Add(this.hint1);
            this.gamePanel.Controls.Add(this.timerLabel);
            this.gamePanel.Controls.Add(this.prizeLabel);
            this.gamePanel.Controls.Add(this.counterLabel);
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(850, 650);
            this.gamePanel.TabIndex = 6;
            this.gamePanel.Visible = false;
            // 
            // answersPanel
            // 
            this.answersPanel.BackColor = System.Drawing.Color.White;
            this.answersPanel.Controls.Add(this.questionLabel);
            this.answersPanel.Controls.Add(this.answerButton1);
            this.answersPanel.Controls.Add(this.answerButton2);
            this.answersPanel.Controls.Add(this.answerButton3);
            this.answersPanel.Controls.Add(this.answerButton4);
            this.answersPanel.Location = new System.Drawing.Point(100, 369);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(650, 180);
            this.answersPanel.TabIndex = 6;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.questionLabel.Location = new System.Drawing.Point(25, 25);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(600, 60);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "questionLabel";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerButton1
            // 
            this.answerButton1.BackColor = System.Drawing.Color.LightGray;
            this.answerButton1.Location = new System.Drawing.Point(25, 100);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(250, 25);
            this.answerButton1.TabIndex = 0;
            this.answerButton1.UseVisualStyleBackColor = false;
            this.answerButton1.Click += new System.EventHandler(this.AnswerButtonClick);
            // 
            // answerButton2
            // 
            this.answerButton2.Location = new System.Drawing.Point(375, 100);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(250, 25);
            this.answerButton2.TabIndex = 0;
            this.answerButton2.UseVisualStyleBackColor = true;
            this.answerButton2.Click += new System.EventHandler(this.AnswerButtonClick);
            // 
            // answerButton3
            // 
            this.answerButton3.Location = new System.Drawing.Point(25, 140);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(250, 25);
            this.answerButton3.TabIndex = 0;
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.AnswerButtonClick);
            // 
            // answerButton4
            // 
            this.answerButton4.Location = new System.Drawing.Point(375, 140);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(250, 25);
            this.answerButton4.TabIndex = 0;
            this.answerButton4.UseVisualStyleBackColor = true;
            this.answerButton4.Click += new System.EventHandler(this.AnswerButtonClick);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(100, 615);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(25, 25);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // addTimeHint
            // 
            this.addTimeHint.BackgroundImage = global::Millionaire.Properties.Resources.AddTime;
            this.addTimeHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTimeHint.Location = new System.Drawing.Point(770, 580);
            this.addTimeHint.Name = "hint4";
            this.addTimeHint.Size = new System.Drawing.Size(60, 60);
            this.addTimeHint.TabIndex = 4;
            this.addTimeHint.UseVisualStyleBackColor = true;
            this.addTimeHint.Click += new System.EventHandler(this.AddTimeHint_Click);
            // 
            // hint3
            // 
            this.hint3.BackgroundImage = global::Millionaire.Properties.Resources.Change1;
            this.hint3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hint3.Location = new System.Drawing.Point(690, 580);
            this.hint3.Name = "hint3";
            this.hint3.Size = new System.Drawing.Size(60, 60);
            this.hint3.TabIndex = 4;
            this.hint3.UseVisualStyleBackColor = true;
            // 
            // hint2
            // 
            this.hint2.BackgroundImage = global::Millionaire.Properties.Resources.Mistake;
            this.hint2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hint2.Location = new System.Drawing.Point(610, 580);
            this.hint2.Name = "hint2";
            this.hint2.Size = new System.Drawing.Size(60, 60);
            this.hint2.TabIndex = 4;
            this.hint2.UseVisualStyleBackColor = true;
            this.hint2.Click += new System.EventHandler(this.Hint2_Click);
            // 
            // hint1
            // 
            this.hint1.BackgroundImage = global::Millionaire.Properties.Resources._50;
            this.hint1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hint1.Location = new System.Drawing.Point(530, 580);
            this.hint1.Name = "hint1";
            this.hint1.Size = new System.Drawing.Size(60, 60);
            this.hint1.TabIndex = 4;
            this.hint1.UseVisualStyleBackColor = true;
            this.hint1.Click += new System.EventHandler(this.Hint1_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(20, 627);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 13);
            this.timerLabel.TabIndex = 3;
            // 
            // prizeLabel
            // 
            this.prizeLabel.Location = new System.Drawing.Point(690, 43);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(140, 50);
            this.prizeLabel.TabIndex = 0;
            this.prizeLabel.Text = "label1";
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(20, 40);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(35, 13);
            this.counterLabel.TabIndex = 0;
            this.counterLabel.Text = "label1";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.initialPanel);
            this.Name = "GameForm";
            this.Text = "Who wants to be a Millionaire?";
            this.initialPanel.ResumeLayout(false);
            this.initialPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.answersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Panel initialPanel;
        private System.Windows.Forms.GroupBox choosePackGroupBox;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button addTimeHint;
        private System.Windows.Forms.Button hint3;
        private System.Windows.Forms.Button hint2;
        private System.Windows.Forms.Button hint1;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel answersPanel;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label questionLabel;
    }
}
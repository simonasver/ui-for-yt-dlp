namespace ui_for_yt_dlp.Forms;

partial class MainForm
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        linkInputLabel = new System.Windows.Forms.Label();
        mp3Button = new System.Windows.Forms.Button();
        mp4Button = new System.Windows.Forms.Button();
        outputBox = new System.Windows.Forms.TextBox();
        linkInput = new System.Windows.Forms.TextBox();
        cancelButton = new System.Windows.Forms.Button();
        tabs = new System.Windows.Forms.TabControl();
        mainTab = new System.Windows.Forms.TabPage();
        settingsTab = new System.Windows.Forms.TabPage();
        changeDownloadLocationButton = new System.Windows.Forms.Button();
        downloadLocationPath = new System.Windows.Forms.Label();
        mp4SettingsInput = new System.Windows.Forms.TextBox();
        mp4SettingsLabel = new System.Windows.Forms.Label();
        mp3SettingsInput = new System.Windows.Forms.TextBox();
        mp3SettingsLabel = new System.Windows.Forms.Label();
        downloadLocationLabel = new System.Windows.Forms.Label();
        resetSettingsButton = new System.Windows.Forms.Button();
        tabs.SuspendLayout();
        mainTab.SuspendLayout();
        settingsTab.SuspendLayout();
        SuspendLayout();
        // 
        // linkInputLabel
        // 
        linkInputLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        linkInputLabel.Location = new System.Drawing.Point(6, 3);
        linkInputLabel.Name = "linkInputLabel";
        linkInputLabel.Size = new System.Drawing.Size(741, 32);
        linkInputLabel.TabIndex = 1;
        linkInputLabel.Text = "Įklijuokite nuorodą:";
        // 
        // mp3Button
        // 
        mp3Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        mp3Button.Location = new System.Drawing.Point(6, 92);
        mp3Button.Name = "mp3Button";
        mp3Button.Size = new System.Drawing.Size(356, 74);
        mp3Button.TabIndex = 2;
        mp3Button.Text = ".mp3";
        mp3Button.UseVisualStyleBackColor = true;
        mp3Button.Click += mp3Button_Click;
        // 
        // mp4Button
        // 
        mp4Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        mp4Button.Location = new System.Drawing.Point(391, 92);
        mp4Button.Name = "mp4Button";
        mp4Button.Size = new System.Drawing.Size(356, 74);
        mp4Button.TabIndex = 3;
        mp4Button.Text = ".mp4";
        mp4Button.UseVisualStyleBackColor = true;
        mp4Button.Click += mp4Button_Click;
        // 
        // outputBox
        // 
        outputBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        outputBox.Location = new System.Drawing.Point(6, 182);
        outputBox.Multiline = true;
        outputBox.Name = "outputBox";
        outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        outputBox.Size = new System.Drawing.Size(741, 300);
        outputBox.TabIndex = 4;
        // 
        // linkInput
        // 
        linkInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        linkInput.Location = new System.Drawing.Point(6, 38);
        linkInput.Name = "linkInput";
        linkInput.PlaceholderText = "Youtube nuoroda";
        linkInput.Size = new System.Drawing.Size(741, 35);
        linkInput.TabIndex = 5;
        // 
        // cancelButton
        // 
        cancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cancelButton.Location = new System.Drawing.Point(630, 488);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new System.Drawing.Size(117, 48);
        cancelButton.TabIndex = 6;
        cancelButton.Text = "Atšaukti";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Visible = false;
        cancelButton.Click += cancelButton_Click;
        // 
        // tabs
        // 
        tabs.Controls.Add(mainTab);
        tabs.Controls.Add(settingsTab);
        tabs.Location = new System.Drawing.Point(12, 23);
        tabs.Name = "tabs";
        tabs.SelectedIndex = 0;
        tabs.Size = new System.Drawing.Size(761, 574);
        tabs.TabIndex = 7;
        // 
        // mainTab
        // 
        mainTab.Controls.Add(linkInputLabel);
        mainTab.Controls.Add(cancelButton);
        mainTab.Controls.Add(linkInput);
        mainTab.Controls.Add(outputBox);
        mainTab.Controls.Add(mp3Button);
        mainTab.Controls.Add(mp4Button);
        mainTab.Location = new System.Drawing.Point(4, 24);
        mainTab.Name = "mainTab";
        mainTab.Padding = new System.Windows.Forms.Padding(3);
        mainTab.Size = new System.Drawing.Size(753, 546);
        mainTab.TabIndex = 0;
        mainTab.Text = "Pagrindinis";
        mainTab.UseVisualStyleBackColor = true;
        // 
        // settingsTab
        // 
        settingsTab.Controls.Add(resetSettingsButton);
        settingsTab.Controls.Add(changeDownloadLocationButton);
        settingsTab.Controls.Add(downloadLocationPath);
        settingsTab.Controls.Add(mp4SettingsInput);
        settingsTab.Controls.Add(mp4SettingsLabel);
        settingsTab.Controls.Add(mp3SettingsInput);
        settingsTab.Controls.Add(mp3SettingsLabel);
        settingsTab.Controls.Add(downloadLocationLabel);
        settingsTab.Location = new System.Drawing.Point(4, 24);
        settingsTab.Name = "settingsTab";
        settingsTab.Padding = new System.Windows.Forms.Padding(3);
        settingsTab.Size = new System.Drawing.Size(753, 546);
        settingsTab.TabIndex = 1;
        settingsTab.Text = "Nustatymai";
        settingsTab.UseVisualStyleBackColor = true;
        // 
        // changeDownloadLocationButton
        // 
        changeDownloadLocationButton.Location = new System.Drawing.Point(20, 45);
        changeDownloadLocationButton.Name = "changeDownloadLocationButton";
        changeDownloadLocationButton.Size = new System.Drawing.Size(89, 24);
        changeDownloadLocationButton.TabIndex = 8;
        changeDownloadLocationButton.Text = "Pakeisti";
        changeDownloadLocationButton.UseVisualStyleBackColor = true;
        changeDownloadLocationButton.Click += changeDownloadLocationButton_Click;
        // 
        // downloadLocationPath
        // 
        downloadLocationPath.Location = new System.Drawing.Point(115, 45);
        downloadLocationPath.Name = "downloadLocationPath";
        downloadLocationPath.Size = new System.Drawing.Size(603, 24);
        downloadLocationPath.TabIndex = 7;
        downloadLocationPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // mp4SettingsInput
        // 
        mp4SettingsInput.Location = new System.Drawing.Point(20, 202);
        mp4SettingsInput.Name = "mp4SettingsInput";
        mp4SettingsInput.PlaceholderText = "Įveskite MP4 nustatymus";
        mp4SettingsInput.Size = new System.Drawing.Size(703, 23);
        mp4SettingsInput.TabIndex = 5;
        mp4SettingsInput.TextChanged += mp4SettingsInput_TextChanged;
        // 
        // mp4SettingsLabel
        // 
        mp4SettingsLabel.Location = new System.Drawing.Point(20, 175);
        mp4SettingsLabel.Name = "mp4SettingsLabel";
        mp4SettingsLabel.Size = new System.Drawing.Size(699, 24);
        mp4SettingsLabel.TabIndex = 4;
        mp4SettingsLabel.Text = "MP4 nustatymai (siunčiantis MP4)";
        // 
        // mp3SettingsInput
        // 
        mp3SettingsInput.Location = new System.Drawing.Point(20, 117);
        mp3SettingsInput.Name = "mp3SettingsInput";
        mp3SettingsInput.PlaceholderText = "Įveskite MP3 nustatymus";
        mp3SettingsInput.Size = new System.Drawing.Size(703, 23);
        mp3SettingsInput.TabIndex = 3;
        mp3SettingsInput.TextChanged += mp3SettingsInput_TextChanged;
        // 
        // mp3SettingsLabel
        // 
        mp3SettingsLabel.Location = new System.Drawing.Point(20, 93);
        mp3SettingsLabel.Name = "mp3SettingsLabel";
        mp3SettingsLabel.Size = new System.Drawing.Size(699, 21);
        mp3SettingsLabel.TabIndex = 2;
        mp3SettingsLabel.Text = "MP3 nustatymai (siunčiantis MP3)";
        // 
        // downloadLocationLabel
        // 
        downloadLocationLabel.Location = new System.Drawing.Point(20, 20);
        downloadLocationLabel.Name = "downloadLocationLabel";
        downloadLocationLabel.Size = new System.Drawing.Size(714, 22);
        downloadLocationLabel.TabIndex = 0;
        downloadLocationLabel.Text = "Atsiuntimo vietos nustatymai";
        // 
        // resetSettingsButton
        // 
        resetSettingsButton.BackColor = System.Drawing.Color.LemonChiffon;
        resetSettingsButton.Location = new System.Drawing.Point(514, 260);
        resetSettingsButton.Name = "resetSettingsButton";
        resetSettingsButton.Size = new System.Drawing.Size(203, 46);
        resetSettingsButton.TabIndex = 9;
        resetSettingsButton.Text = "Atstatyti pradinius nustatymus";
        resetSettingsButton.UseVisualStyleBackColor = false;
        resetSettingsButton.Click += resetSettingsButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(780, 606);
        Controls.Add(tabs);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Parsisiuntimas";
        tabs.ResumeLayout(false);
        mainTab.ResumeLayout(false);
        mainTab.PerformLayout();
        settingsTab.ResumeLayout(false);
        settingsTab.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button resetSettingsButton;

    private System.Windows.Forms.Label downloadLocationPath;
    private System.Windows.Forms.Button changeDownloadLocationButton;

    private System.Windows.Forms.Label downloadLocationLabel;
    private System.Windows.Forms.Label mp3SettingsLabel;
    private System.Windows.Forms.TextBox mp3SettingsInput;
    private System.Windows.Forms.Label mp4SettingsLabel;
    private System.Windows.Forms.TextBox mp4SettingsInput;

    private System.Windows.Forms.TabControl tabs;
    private System.Windows.Forms.TabPage mainTab;
    private System.Windows.Forms.TabPage settingsTab;

    private System.Windows.Forms.Button cancelButton;

    private System.Windows.Forms.TextBox linkInput;

    private System.Windows.Forms.TextBox outputBox;

    private System.Windows.Forms.Button mp3Button;
    private System.Windows.Forms.Button mp4Button;

    private System.Windows.Forms.Label linkInputLabel;

    #endregion
}
namespace ui_for_yt_dlp;

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
        SuspendLayout();
        // 
        // linkInputLabel
        // 
        linkInputLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        linkInputLabel.Location = new System.Drawing.Point(12, 23);
        linkInputLabel.Name = "linkInputLabel";
        linkInputLabel.Size = new System.Drawing.Size(761, 38);
        linkInputLabel.TabIndex = 1;
        linkInputLabel.Text = "Įklijuokite nuorodą:";
        // 
        // mp3Button
        // 
        mp3Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        mp3Button.Location = new System.Drawing.Point(12, 122);
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
        mp4Button.Location = new System.Drawing.Point(417, 122);
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
        outputBox.Location = new System.Drawing.Point(12, 220);
        outputBox.Multiline = true;
        outputBox.Name = "outputBox";
        outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        outputBox.Size = new System.Drawing.Size(761, 300);
        outputBox.TabIndex = 4;
        // 
        // linkInput
        // 
        linkInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        linkInput.Location = new System.Drawing.Point(12, 64);
        linkInput.Name = "linkInput";
        linkInput.PlaceholderText = "Youtube nuoroda";
        linkInput.Size = new System.Drawing.Size(761, 35);
        linkInput.TabIndex = 5;
        // 
        // cancelButton
        // 
        cancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cancelButton.Location = new System.Drawing.Point(656, 531);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new System.Drawing.Size(117, 48);
        cancelButton.TabIndex = 6;
        cancelButton.Text = "Atšaukti";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Visible = false;
        cancelButton.Click += cancelButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(785, 591);
        Controls.Add(cancelButton);
        Controls.Add(linkInput);
        Controls.Add(outputBox);
        Controls.Add(mp4Button);
        Controls.Add(mp3Button);
        Controls.Add(linkInputLabel);
        Text = "Parsisiuntimas";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button cancelButton;

    private System.Windows.Forms.TextBox linkInput;

    private System.Windows.Forms.TextBox outputBox;

    private System.Windows.Forms.Button mp3Button;
    private System.Windows.Forms.Button mp4Button;

    private System.Windows.Forms.Label linkInputLabel;

    #endregion
}
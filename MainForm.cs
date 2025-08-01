using System.Diagnostics;

namespace ui_for_yt_dlp;

public partial class MainForm : Form
{
    private Process? _currentProcess;
    
    public MainForm()
    {
        InitializeComponent();
    }

    private void StartProcess(string command)
    {
        Process process = new Process
        {
            StartInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            },
            EnableRaisingEvents = true
        };
        
        process.OutputDataReceived += (s, e) =>
        {
            if (e.Data != null)
            {
                AppendText(e.Data + Environment.NewLine);
            }
        };
        
        process.ErrorDataReceived += (s, e) =>
        {
            if (e.Data != null)
            {
                AppendText(e.Data + Environment.NewLine);
            }
        };

        process.Exited += (s, ev) =>
        {
            _currentProcess = null;
            ChangeActionButtonsEnabled(true);
            ChangeCancelButtonVisible(false);
        };

        process.Start();
        process.BeginOutputReadLine();
        process.BeginErrorReadLine();
        _currentProcess = process;
        
        ChangeActionButtonsEnabled(false);
        ChangeCancelButtonVisible(true);
    }

    private void mp3Button_Click(object sender, EventArgs e)
    {
        var youtubeLink = linkInput.Text;
        if (!string.IsNullOrWhiteSpace(youtubeLink) && _currentProcess == null)
        {
            ChangeActionButtonsEnabled(false);
            StartProcess($"yt-dlp -f bestaudio -x --audio-format mp3 --no-playlist \"{youtubeLink}\"");
            linkInput.Clear();
        }
    }

    private void mp4Button_Click(object sender, EventArgs e)
    {
        var youtubeLink = linkInput.Text;
        if (!string.IsNullOrWhiteSpace(youtubeLink) && _currentProcess == null)
        {
            StartProcess($"yt-dlp -f bestvideo+bestaudio --no-playlist \"{youtubeLink}\"");
            linkInput.Clear();
        }
    }
    
    private void AppendText(string text)
    {
        if (outputBox.InvokeRequired)
        {
            outputBox.Invoke(() => outputBox.AppendText(text));
        }
        else
        {
            outputBox.AppendText(text);
        }
    }

    private void ChangeActionButtonsEnabled(bool enabled)
    {
        if (InvokeRequired)
        {
            Invoke(() => ChangeActionButtonsEnabled(enabled));
        }
        else
        {
            mp3Button.Enabled = enabled;
            mp4Button.Enabled = enabled;
        }
    }

    private void ChangeCancelButtonVisible(bool enabled)
    {
        if (InvokeRequired)
        {
            Invoke(() => ChangeCancelButtonVisible(enabled));
        }
        else
        {
            cancelButton.Visible = enabled;
        }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        KillProcess();
        base.OnFormClosing(e);
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
       KillProcess();
    }

    private void KillProcess()
    {
        if (_currentProcess != null && !_currentProcess.HasExited)
        {
            try
            {
                _currentProcess.Kill(true);
                AppendText("[Procesas atšauktas]\r\n");
            }
            catch (Exception ex)
            {
                AppendText($"[Klaida atšaukiant procesą]: {ex.Message}\r\n");
            }
            finally
            {
                _currentProcess = null;
                ChangeActionButtonsEnabled(true);
            }
        }
    }
}
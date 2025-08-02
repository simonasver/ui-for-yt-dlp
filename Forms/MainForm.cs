using ui_for_yt_dlp.Download;
using ui_for_yt_dlp.Settings;

namespace ui_for_yt_dlp.Forms;

public partial class MainForm : Form
{
    private readonly IAppSettingsService _appSettingsService;
    private readonly IDownloadService _downloadService;

    public MainForm(IAppSettingsService appSettingsService)
    {
        _appSettingsService = appSettingsService;
        _downloadService = new DownloadService(appSettingsService, AppendText, ChangeActionButtonsEnabled, ChangeCancelButtonVisible);

        InitializeComponent();
        InitializeSettings();
    }

    private void mp3Button_Click(object sender, EventArgs e)
    {
        var youtubeLink = linkInput.Text;
        linkInput.Clear();
        _downloadService.DownloadMp3(youtubeLink);
    }

    private void mp4Button_Click(object sender, EventArgs e)
    {
        var youtubeLink = linkInput.Text;
        linkInput.Clear();
        _downloadService.DownloadMp4(youtubeLink);
    }

    private void AppendText(string text)
    {
        if (outputBox.InvokeRequired)
            outputBox.Invoke(() => outputBox.AppendText(text));
        else
            outputBox.AppendText(text);
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
            Invoke(() => ChangeCancelButtonVisible(enabled));
        else
            cancelButton.Visible = enabled;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        _downloadService.KillCurrentProcess();
        base.OnFormClosing(e);
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        _downloadService.KillCurrentProcess();
    }

    private void InitializeSettings()
    {
        var settings = _appSettingsService.GetSettings();

        UpdateSettingsFields(settings.DownloadFileLocation, settings.Mp3Config, settings.Mp4Config);
    }

    private void UpdateSettingsFields(string downloadFileLocation, string mp3Config, string mp4Config)
    {
        downloadLocationPath.Text = downloadFileLocation;
        mp3SettingsInput.Text = mp3Config;
        mp4SettingsInput.Text = mp4Config;
    }

    private void changeDownloadLocationButton_Click(object sender, EventArgs e)
    {
        using var folderDialog = new FolderBrowserDialog();
        folderDialog.Description = "Pasirinkite atsiuntimo vietą";

        if (folderDialog.ShowDialog() == DialogResult.OK)
        {
            string path = folderDialog.SelectedPath;
            _appSettingsService.UpdateDownloadPath(path);
            downloadLocationPath.Text = path;
        }
    }

    private void mp3SettingsInput_TextChanged(object sender, EventArgs e)
    {
        _appSettingsService.UpdateMp3Config(mp3SettingsInput.Text);
    }

    private void mp4SettingsInput_TextChanged(object sender, EventArgs e)
    {
        _appSettingsService.UpdateMp4Config(mp4SettingsInput.Text);
    }

    private void resetSettingsButton_Click(object sender, EventArgs e)
    {
        _appSettingsService.ResetSettings(UpdateSettingsFields);
    }
}
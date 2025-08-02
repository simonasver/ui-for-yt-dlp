using System.Diagnostics;
using ui_for_yt_dlp.Settings;

namespace ui_for_yt_dlp.Download;

public interface IDownloadService
{
    public void DownloadMp3(string youtubeLink);
    public void DownloadMp4(string youtubeLink);
    public void KillCurrentProcess();
}

public class DownloadService(
    IAppSettingsService appSettingsService,
    Action<string> onOutput,
    Action<bool> onActionButtonsEnabled,
    Action<bool> onCancelButtonVisible
) : IDownloadService
{
    private static Process? _currentProcess;
    private static readonly string _downloadedFileName = "%(title)s.%(ext)s";

    public void DownloadMp3(string youtubeLink)
    {
        if (!string.IsNullOrWhiteSpace(youtubeLink) && _currentProcess == null)
        {
            onActionButtonsEnabled(false);
            
            var settings = appSettingsService.GetSettings();
            var mp3Settings = settings.Mp3Config;
            var downloadedFilePath = GetDownloadFilePath(settings.DownloadFileLocation);
            
            StartProcess(
                $"yt-dlp {mp3Settings} -o {downloadedFilePath} \"{youtubeLink}\"");
        }
    }

    public void DownloadMp4(string youtubeLink)
    {
        if (!string.IsNullOrWhiteSpace(youtubeLink) && _currentProcess == null)
        {
            onActionButtonsEnabled(false);
            
            var settings = appSettingsService.GetSettings();
            var mp4Settings = settings.Mp4Config;
            var downloadFilePath = GetDownloadFilePath(settings.DownloadFileLocation);
            
            StartProcess($"yt-dlp {mp4Settings} -o {downloadFilePath} \"{youtubeLink}\"");
        }
    }

    public void KillCurrentProcess()
    {
        if (_currentProcess != null && !_currentProcess.HasExited)
            try
            {
                _currentProcess.Kill(true);
                onOutput("[Procesas atšauktas]\r\n");
            }
            catch (Exception ex)
            {
                onOutput($"[Klaida atšaukiant procesą]: {ex.Message}\r\n");
            }
            finally
            {
                _currentProcess = null;
                onActionButtonsEnabled(true);
            }
    }

    private string GetDownloadFilePath(string downloadLocationPath)
    {
        return $"{downloadLocationPath}\\{_downloadedFileName}";
    }

    private void StartProcess(string command)
    {
        var process = new Process
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
            if (e.Data != null) onOutput(e.Data + Environment.NewLine);
        };

        process.ErrorDataReceived += (s, e) =>
        {
            if (e.Data != null) onOutput(e.Data + Environment.NewLine);
        };

        process.Exited += (s, ev) =>
        {
            _currentProcess = null;
            onActionButtonsEnabled(true);
            onCancelButtonVisible(false);
        };

        onOutput(command);
        process.Start();
        process.BeginOutputReadLine();
        process.BeginErrorReadLine();
        _currentProcess = process;

        onActionButtonsEnabled(false);
        onCancelButtonVisible(true);
    }
}
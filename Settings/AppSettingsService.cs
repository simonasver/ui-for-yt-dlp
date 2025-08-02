using System.Runtime.InteropServices;
using System.Text.Json;

namespace ui_for_yt_dlp.Settings;

public interface IAppSettingsService
{
    public void ResetSettings(Action<string, string, string> onUpdateSettingsFields);
    public AppSettings GetSettings();
    public void UpdateDownloadPath(string path);
    public void UpdateMp3Config(string config);
    public void UpdateMp4Config(string config);
}

public class AppSettingsService : IAppSettingsService
{
    private static AppSettings? _settings;

    private static readonly Guid DownloadsFolderGuid = new("374DE290-123F-4565-9164-39C4925E467B");

    private static readonly JsonSerializerOptions JsonSerializerOptions = new() { WriteIndented = true };

    public void ResetSettings(Action<string, string, string> onUpdateSettingsFields)
    {
        _settings = GetDefaultSettings();
        SaveSettings();
        onUpdateSettingsFields(_settings.DownloadFileLocation, _settings.Mp3Config, _settings.Mp4Config);
    }

    public AppSettings GetSettings()
    {
        return _settings ?? LoadSettings();
    }

    public void UpdateDownloadPath(string path)
    {
        if (_settings == null) return;

        _settings.DownloadFileLocation = path;
        SaveSettings();
    }

    public void UpdateMp3Config(string config)
    {
        if (_settings == null) return;

        _settings.Mp3Config = config;
        SaveSettings();
    }

    public void UpdateMp4Config(string config)
    {
        if (_settings == null) return;

        _settings.Mp4Config = config;
        SaveSettings();
    }

    public AppSettings LoadSettings()
    {
        var path = GetSettingsPath();
        if (!File.Exists(path))
        {
            File.Create(path).Dispose();
            _settings = GetDefaultSettings();
            SaveSettings();

            return _settings;
        }

        var json = File.ReadAllText(path);
        var settings = JsonSerializer.Deserialize<AppSettings>(json) ?? GetDefaultSettings();

        _settings = settings;

        return settings;
    }

    public void SaveSettings()
    {
        var json = JsonSerializer.Serialize(_settings, JsonSerializerOptions);
        File.WriteAllText(GetSettingsPath(), json);
    }

    private string GetSettingsPath()
    {
        var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ui-for-yt-dlp");
        Directory.CreateDirectory(dir);

        return Path.Combine(dir, "settings.json");
    }

    private AppSettings GetDefaultSettings()
    {
        var downloadsPath = GetDownloadsPath();

        return new AppSettings(
            10,
            10,
            downloadsPath,
            "-f bestaudio -x --audio-format mp3 --audio-quality 0 --no-mtime --no-playlist --no-overwrites",
            "-f bestvideo+bestaudio --no-mtime --no-playlist --no-overwrites"
        );
    }

    private string GetDownloadsPath()
    {
        SHGetKnownFolderPath(DownloadsFolderGuid, 0, IntPtr.Zero, out var outPath);
        var path = Marshal.PtrToStringUni(outPath);
        Marshal.FreeCoTaskMem(outPath);
        return path;
    }

    [DllImport("shell32.dll")]
    private static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags,
        IntPtr hToken, out IntPtr ppszPath);
}
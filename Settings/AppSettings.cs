namespace ui_for_yt_dlp.Settings;

public class AppSettings(int windowX, int windowY, string downloadFileLocation, string mp3Config, string mp4Config)
{
    public int WindowX { get; set; } = windowX;
    public int WindowY { get; set; } = windowY;

    public string DownloadFileLocation { get; set; } = downloadFileLocation;
    public string Mp3Config { get; set; } = mp3Config;
    public string Mp4Config { get; set; } = mp4Config;
}
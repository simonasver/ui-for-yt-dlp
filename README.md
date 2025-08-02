# UI for yt-dlp

## About

It's a UI application for [yt-dlp](https://github.com/yt-dlp/yt-dlp) feature-rich command-line audio/video
downloader.<br />
The goal is to provide a simple experience for non-technical users.

## Installation

### Option 1: Pre-compiled installer

- Download installer
  from [here](https://github.com/simonasver/ui-for-yt-dlp/releases/tag/latest)
- Install and start using the program

### Option 2: Compiling from source code

#### Prerequisites

1. Download yt-dlp for Windows from [here](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe).
2. Put downloaded yt-dlp to C:\ytdlp
3. Download yt-dlp's custom ffmpeg build from [here](https://github.com/yt-dlp/FFmpeg-Builds/wiki/Latest)
4. Extract downloaded binaries to C:\ytdlp
5. Add C:\ytdlp to PATH
6. Download .NET SDK

#### Compilation

1. Download source code
2. Compile it
3. Compact compiled code to executable file by using
   `dotnet publish`
4. Run compiled executable which can be found in `./bin/Release/net9.0-windows/win-x64/publish`

## Usage

- Paste youtube link and press a button to download either .mp3 or .mp4 file.
- In settings tab, download directory (by default - Downloads) can be changed
- In settings tab, flags used in MP3 and MP4 button can be changed
- Settings persist in `%appdata%/ui-for-yt-dlp`

## Limitations

- Only working on Windows machines.

## Future TODOs

1. Add internationalization
2. Add design customization settings (mainly text size)
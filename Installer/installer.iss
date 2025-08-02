[Setup]
AppName=UiForYtDlp
AppVersion=1.0
DefaultDirName={commonpf}\UiForYtDlp
DefaultGroupName=UiForYtDlp
OutputBaseFilename=UiForYtDlpInstaller
OutputDir=..
Compression=lzma
SolidCompression=yes
DisableProgramGroupPage=yes
ChangesEnvironment=true
PrivilegesRequired=admin

[Files]
Source: "..\bin\Release\net9.0-windows\win-x64\publish\**"; DestDir: "{app}"; Flags: recursesubdirs

[Run]
Filename: "{app}\ui-for-yt-dlp.exe"; Description: "Launch application"; Flags: skipifsilent nowait postinstall

[Icons]
Name: "{userdesktop}\UiForYtDlp"; Filename: "{app}\ui-for-yt-dlp.exe"
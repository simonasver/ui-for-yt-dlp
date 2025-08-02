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
Source: "..\Publish\ui-for-yt-dlp.exe"; DestDir: "{app}"; Flags: recursesubdirs
Source: "..\Tools\*"; DestDir: "{app}\Tools"; Flags: recursesubdirs

[Icons]
Name: "{userdesktop}\UiForYtDlp"; Filename: "{app}\ui-for-yt-dlp.exe"

[Code]
const RegRoot = HKEY_CURRENT_USER;
const RegSubKey = 'Environment';

procedure EnvAddPath(Path: string);
var
    Paths: string;
begin
    { Retrieve current path (use empty string if entry not exists) }
    if not RegQueryStringValue(RegRoot, RegSubKey, 'Path', Paths)
    then Paths := '';

    { Skip if string already found in path }
    if Pos(';' + Uppercase(Path) + ';', ';' + Uppercase(Paths) + ';') > 0 then exit;

    { App string to the end of the path variable }
    Paths := Paths + ';'+ Path +';'

    { Overwrite (or create if missing) path environment variable }
    if RegWriteStringValue(RegRoot, RegSubKey, 'Path', Paths)
    then Log(Format('The [%s] added to PATH: [%s]', [Path, Paths]))
    else Log(Format('Error while adding the [%s] to PATH: [%s]', [Path, Paths]));
end;

procedure EnvRemovePath(Path: string);
var
    Paths: string;
    P: Integer;
begin
    { Skip if registry entry not exists }
    if not RegQueryStringValue(RegRoot, RegSubKey, 'Path', Paths) then
        exit;

    { Skip if string not found in path }
    P := Pos(';' + Uppercase(Path) + ';', ';' + Uppercase(Paths) + ';');
    if P = 0 then exit;

    { Update path variable }
    Delete(Paths, P - 1, Length(Path) + 1);

    { Overwrite path environment variable }
    if RegWriteStringValue(RegRoot, RegSubKey, 'Path', Paths)
    then Log(Format('The [%s] removed from PATH: [%s]', [Path, Paths]))
    else Log(Format('Error while removing the [%s] from PATH: [%s]', [Path, Paths]));
end;

procedure CurStepChanged(CurStep: TSetupStep);
begin
  if CurStep = ssPostInstall then
  begin
    Log('CurStepChanged triggered: ssPostInstall');
    EnvAddPath(ExpandConstant('{app}\Tools'));
  end;
end;

procedure CurUninstallStepChanged(CurUninstallStep: TUninstallStep);
begin
    if CurUninstallStep = usPostUninstall
    then EnvRemovePath(ExpandConstant('{app}\Tools'));
end;
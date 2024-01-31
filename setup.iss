; 脚本用 Inno Setup 脚本向导生成。
; 查阅文档获取创建 INNO SETUP 脚本文件详细资料!

[Setup]
AppName=CommunicationTest
AppVerName=CommunicationTest 8.2
AppPublisher=yzlm
DefaultDirName={pf}\CommunicationTest
DefaultGroupName=CommunicationTest
DisableProgramGroupPage=yes
Compression=lzma
SolidCompression=yes

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}";

[Files]
Source: "D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net8.0-windows\publish\CommunicationTest.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net8.0-windows\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs
; 注意: 不要在任何共享系统文件中使用“Flags: ignoreversion”

[Icons]
Name: "{group}\CommunicationTest"; Filename: "{app}\CommunicationTest.exe"
Name: "{group}\{cm:UninstallProgram,CommunicationTest}"; Filename: "{uninstallexe}"
Name: "{userdesktop}\CommunicationTest"; Filename: "{app}\CommunicationTest.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\CommunicationTest.exe"; Description: "{cm:LaunchProgram,CommunicationTest}"; Flags: nowait postinstall skipifsilent


; 脚本用 Inno Setup 脚本向导生成。
; 查阅文档获取创建 INNO SETUP 脚本文件详细资料!

[Setup]
AppName=简单通讯测试工具
AppVerName=CommunicationTest 9.12.0
AppPublisher=yzlm
DefaultDirName={pf}\CommunicationTest
DefaultGroupName=CommunicationTest
DisableProgramGroupPage=yes
Compression=lzma
SolidCompression=yes

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}";

[Files]
Source: "D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net9.0-windows\publish\CommunicationTest.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net9.0-windows\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs
; 注意: 不要在任何共享系统文件中使用“Flags: ignoreversion”

[Icons]
Name: "{group}\简单通讯测试工具"; Filename: "{app}\CommunicationTest.exe"
Name: "{group}\{cm:UninstallProgram,简单通讯测试工具}"; Filename: "{uninstallexe}"
Name: "{userdesktop}\简单通讯测试工具"; Filename: "{app}\CommunicationTest.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\CommunicationTest.exe"; Description: "{cm:LaunchProgram,简单通讯测试工具}"; Flags: nowait postinstall skipifsilent


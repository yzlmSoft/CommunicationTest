; 脚本用 Inno Setup 脚本向导生成。
; 查阅文档获取创建 INNO SETUP 脚本文件详细资料!

[Setup]
AppName=CommunicationTest
AppVerName=CommunicationTest 1.0
AppPublisher=CSoft
DefaultDirName={pf}\CSoft
DefaultGroupName=CSoft
AllowNoIcons=yes
Compression=lzma
SolidCompression=yes

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Files]
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\CommunicationTest.exe; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Accessibility.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-console-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-console-l1-2-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-datetime-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-debug-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-errorhandling-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-file-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-file-l1-2-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-file-l2-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-handle-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-heap-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-interlocked-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-libraryloader-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-localization-l1-2-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-memory-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-namedpipe-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-processenvironment-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-processthreads-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-processthreads-l1-1-1.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-profile-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-rtlsupport-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-string-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-synch-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-synch-l1-2-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-sysinfo-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-timezone-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-core-util-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\API-MS-Win-core-xstate-l2-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-conio-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-convert-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-environment-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-filesystem-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-heap-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-locale-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-math-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-multibyte-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-private-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-process-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-runtime-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-stdio-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-string-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-time-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\api-ms-win-crt-utility-l1-1-0.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\clrcompression.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\clretwrc.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\clrjit.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Communication.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\CommunicationTest.deps.json; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\CommunicationTest.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\CommunicationTest.exe; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\CommunicationTest.pdb; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\CommunicationTest.runtimeconfig.json; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\coreclr.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\createdump.exe; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Crow.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\D3DCompiler_47_cor3.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\DataPairs.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\dbgshim.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\DirectWriteForwarder.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\e_sqlite3.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\FastDeepCloner.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\hostfxr.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\hostpolicy.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\LogInterface.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.CSharp.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Data.Sqlite.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.DiaSymReader.Native.x86.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.DotNet.PlatformAbstractions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.EntityFrameworkCore.Abstractions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.EntityFrameworkCore.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.EntityFrameworkCore.Relational.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.EntityFrameworkCore.Sqlite.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Extensions.Caching.Abstractions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Extensions.Caching.Memory.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Extensions.Configuration.Abstractions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Extensions.DependencyInjection.Abstractions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Extensions.DependencyInjection.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Extensions.DependencyModel.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Extensions.Logging.Abstractions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Extensions.Logging.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Extensions.Options.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Extensions.Primitives.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.VisualBasic.Core.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.VisualBasic.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.VisualBasic.Forms.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Win32.Primitives.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Win32.Registry.AccessControl.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Win32.Registry.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Microsoft.Win32.SystemEvents.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\mscordaccore.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\mscordaccore_x86_x86_5.0.321.7212.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\mscordbi.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\mscorrc.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Newtonsoft.Json.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PairsDB.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Parser.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PenImc_cor3.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationCore.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework.Aero.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework.Aero2.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework.AeroLite.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework.Classic.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework.Luna.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework.Royale.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework-SystemCore.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework-SystemData.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework-SystemDrawing.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework-SystemXml.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationFramework-SystemXmlLinq.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationNative_cor3.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\PresentationUI.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\ReachFramework.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\SQLitePCLRaw.batteries_v2.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\SQLitePCLRaw.core.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\SQLitePCLRaw.nativelibrary.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\SQLitePCLRaw.provider.dynamic_cdecl.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.CodeDom.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Collections.Concurrent.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Collections.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Collections.Immutable.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Collections.NonGeneric.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Collections.Specialized.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.ComponentModel.Annotations.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.ComponentModel.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.ComponentModel.EventBasedAsync.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.ComponentModel.Primitives.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.ComponentModel.TypeConverter.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Configuration.ConfigurationManager.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Console.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Data.Common.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Design.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Diagnostics.DiagnosticSource.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Diagnostics.EventLog.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Diagnostics.EventLog.Messages.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Diagnostics.FileVersionInfo.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Diagnostics.PerformanceCounter.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Diagnostics.Process.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Diagnostics.StackTrace.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Diagnostics.TraceSource.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.DirectoryServices.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Drawing.Common.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Drawing.Design.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Drawing.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Drawing.Primitives.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Formats.Asn1.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.IO.Compression.Brotli.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.IO.Compression.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.IO.FileSystem.AccessControl.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.IO.FileSystem.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.IO.FileSystem.DriveInfo.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.IO.IsolatedStorage.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.IO.MemoryMappedFiles.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.IO.Packaging.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.IO.Pipes.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.IO.Ports.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Linq.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Linq.Expressions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Linq.Queryable.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Memory.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.Http.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.NameResolution.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.NetworkInformation.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.Ping.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.Primitives.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.Requests.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.Security.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.ServicePoint.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.Sockets.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.WebClient.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Net.WebHeaderCollection.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.ObjectModel.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Printing.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Private.CoreLib.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Private.DataContractSerialization.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Private.Uri.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Private.Xml.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Private.Xml.Linq.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Reflection.Metadata.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Resources.Extensions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Resources.Writer.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Runtime.CompilerServices.Unsafe.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Runtime.CompilerServices.VisualC.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Runtime.InteropServices.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Runtime.InteropServices.RuntimeInformation.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Runtime.Numerics.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Runtime.Serialization.Formatters.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Runtime.Serialization.Primitives.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.AccessControl.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Claims.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Cryptography.Algorithms.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Cryptography.Cng.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Cryptography.Csp.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Cryptography.Encoding.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Cryptography.Pkcs.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Cryptography.Primitives.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Cryptography.ProtectedData.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Cryptography.X509Certificates.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Cryptography.Xml.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Permissions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Security.Principal.Windows.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Text.Encoding.CodePages.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Text.Encodings.Web.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Text.Json.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Text.RegularExpressions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Threading.AccessControl.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Threading.Channels.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Threading.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Transactions.Local.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Windows.Controls.Ribbon.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Windows.Extensions.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Windows.Forms.Design.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Windows.Forms.Design.Editors.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Windows.Forms.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Windows.Forms.Primitives.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Windows.Input.Manipulations.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Windows.Presentation.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\System.Xaml.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\TopPortLib.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\ucrtbase.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\UIAutomationClient.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\UIAutomationClientSideProviders.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\UIAutomationProvider.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\UIAutomationTypes.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\Utils.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\vcruntime140_cor3.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\WindowsBase.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\WindowsFormsIntegration.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\wpfgfx_cor3.dll; DestDir: {app}; Flags: ignoreversion
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\cs\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\de\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\es\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\fr\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\it\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\ja\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\ko\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\pl\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\pt-BR\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\ru\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\tr\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\zh-Hans\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: D:\GitHub\CommunicationTest\CommunicationTest\bin\Release\net5.0-windows\publish\zh-Hant\*; DestDir: {app}; Flags: ignoreversion recursesubdirs
; 注意: 不要在任何共享系统文件中使用“Flags: ignoreversion”

[Icons]
Name: {group}\CommunicationTest; Filename: {app}\CommunicationTest.exe
Name: {group}\{cm:UninstallProgram,CommunicationTest}; Filename: {uninstallexe}
Name: {userdesktop}\CommunicationTest; Filename: {app}\CommunicationTest.exe; Tasks: desktopicon
Name: {userappdata}\Microsoft\Internet Explorer\Quick Launch\CommunicationTest; Filename: {app}\CommunicationTest.exe; Tasks: quicklaunchicon

[Run]
Filename: {app}\CommunicationTest.exe; Description: {cm:LaunchProgram,CommunicationTest}; Flags: nowait postinstall skipifsilent

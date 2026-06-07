#define MyAppName "Integration Store"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Antonio Toro Sagredo"
#define MyAppExeName "IntegrationStore.exe"
#define SourceDir "C:\Users\atoro\Desktop\IntegrationStore_APP\PresentationLayer\bin\Release"

[Setup]
AppId={{6F8A2E88-5A4D-4A70-8D6D-IntegrationStore}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\Integration Store
DefaultGroupName=Integration Store
DisableProgramGroupPage=yes
OutputDir=C:\Users\atoro\Desktop\IntegrationStore_APP\installer-output
OutputBaseFilename=IntegrationStore_Setup_v1.0.0
Compression=lzma
SolidCompression=yes
WizardStyle=modern
;SetupIconFile={#SourceDir}\IntegrationStore.exe
UninstallDisplayIcon={app}\{#MyAppExeName}
PrivilegesRequired=lowest

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "Crear acceso directo en el escritorio"; GroupDescription: "Accesos directos:"; Flags: unchecked

[Files]
Source: "{#SourceDir}\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{group}\Integration Store"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\Integration Store"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Ejecutar Integration Store"; Flags: nowait postinstall skipifsilent
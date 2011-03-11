ServerName = "."

Set objWMIService  = GetObject("winmgmts:{impersonationLevel=impersonate}!//" & ServerName)
Set colProcessList = objWMIService.ExecQuery ("Select * from Win32_Process Where Name LIKE 'S3GT%'")

For Each Proc in colProcessList
        Proc.Terminate()
NEXT
Set colProcessList = objWMIService.ExecQuery ("Select * from Win32_Process Where Name = 'QuickRegister.exe'")

For Each Proc in colProcessList
        Proc.Terminate()
NEXT
$ErrorActionPreference

Get-WmiObject win32_bios -ComputerName A7K32WV1,NotOnline,Client

Get-WmiObject win32_bios -ComputerName A7K32WV1,NotOnline,Client -EA SilentlyContinue -EV MyError
$MyError

Get-WmiObject win32_bios -ComputerName A7K32WV1,NotOnline,Client -EA Stop

Get-WmiObject win32_bios -ComputerName A7K32WV1,NotOnline,Client -EA Inquire


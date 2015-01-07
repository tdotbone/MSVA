#Choose values to replace with variables


 [String]$ComputerName='A7K32WV1'
 [String]$Drive='c:'


Get-WmiObject -class Win32_logicalDisk -Filter "DeviceID='$Drive'" -ComputerName $ComputerName


param(
    [string]$computername='localhost'
    $bogus
)

Get-WmiObject -Computername $computername -class win32_logicaldisk -Filter "DeviceID='C'"

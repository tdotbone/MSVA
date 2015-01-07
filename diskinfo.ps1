
<#
.Synopsis
This is the short explanation
.Description
This is the long description
.Paramameter ComputerName
This is for remote computers
.Example
DiskInfo -computername remote
This is for remote computer
#>

function Get-diskinfo{
    [CmdletBinding()]
    param(
        [Parameter(Mandatory=$True)] 
        [string[]]$Computername,
        $bogus
)

Get-WmiObject -Computername $computername -class win32_logicaldisk -Filter "DeviceID='C:'"

}
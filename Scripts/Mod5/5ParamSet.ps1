﻿Function Get-CompInfo{
    [CmdletBinding()]
    Param(
        #Want to support multiple computers
        [Parameter(Mandatory=$True,
                    ValueFromPipeline=$true,
                    ValueFromPipelineByPropertyName=$true)]
        #[ValidateSet('DC','Client')]
        [ValidateSet('A7K32WV1','LocalHost')]
        [String[]]$ComputerName,
        



        #Switch to turn on Error logging
        [Switch]$ErrorLog,
        [String]$LogFile = 'c:\errorlog.txt'
    )
    
    Begin{}
    Process{}
    End{}
}
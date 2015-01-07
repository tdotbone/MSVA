<#
 Comment based help
#>
Function Verb-Noun {

    [CmdletBinding()]
    Param(
        [parameter(valuefrompipeline=$true)]
        [Int]$x
    )

    Begin{<#Code#> $total = 0}
    Process{<#Code#> $total += $x}
    End{<#Code#> "Total = $total"}
}


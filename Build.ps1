﻿param (
	[string]$Version = "0.0.0.0",
	[string]$Configuration = "Release"
)

Write-Host $Version
$MyDir = Split-Path $MyInvocation.MyCommand.Definition
$env:EnableNuGetPackageRestore = 'false'

if((Get-Module psake) -eq $null)
{ 
    Import-Module $MyDir\src\Solutions\packages\psake.4.2.0.1\tools\psake.psm1
}

$TmpPath = $MyDir+'\tmp'
[IO.Directory]::CreateDirectory($TmpPath)

$psake.use_exit_on_error = $true
Invoke-psake -buildFile $MyDir'.\Default.ps1' -parameters @{"Version"=$Version;"Configuration"=$Configuration;"NuGetPack"="true"}
if ($psake.build_success -eq $false) { exit 1 } else { exit 0 }

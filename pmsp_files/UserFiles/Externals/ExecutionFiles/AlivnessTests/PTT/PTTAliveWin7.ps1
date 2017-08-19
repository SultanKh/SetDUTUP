
#PTT Aliveness test for win7 only
#Date: 27.04.2015
#Author: Roi Shneor

#get TPM object:
$tpm = Get-WmiObject –namespace "root/cimv2/security/microsofttpm" win32_tpm

#Check it TPM is enabled (exit 1 if not)
$enabled = $tpm.IsEnabled()
if($enabled.IsEnabled -eq $false){
    Write-Host "TPM is not enabled - FAILED" -ForegroundColor Red
    exit 1
}
else{
    Write-Host "TPM is enabled"
}

#Check it TPM is activated (exit 1 if not)
$activated = $tpm.IsActivated()
if($activated.IsActivated -eq $false){
    Write-Host "TPM is not activated - FAILED" -ForegroundColor Red
    exit 1
}
else{
    Write-Host "TPM is activated"
}


#Check it TPM is owned (exit 1 if not)
$owned = $tpm.IsOwned()
if($owned.IsOwned -eq $false){
    Write-Host "TPM is not Owned - FAILED" -ForegroundColor Red
    exit 1
}
else{
    Write-Host "TPM is Owned"
}


Write-Host "PASSED" -ForegroundColor Green
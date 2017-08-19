
#PTT Aliveness test
#Date: 30.10.2014
#Author: Roi Shneor

#get TPM object:
Try
{
    $tpm = Get-WmiObject –namespace "root/cimv2/security/microsofttpm" win32_tpm

#Reset lockout for cases TPM enters lockout because of non-orderly power transitions:
$lockout = $tpm.ResetAuthLockOut()
if($lockout.ReturnValue -ne 0){
    Write-Host "Failed to reset TPM lockout" -ForegroundColor Yellow
}
else{
    Write-Host "TPM lockout was reset"
}

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

#Check it TPM IsAutoProvisioningEnabled (exit 1 if not)
$provisioned = $tpm.IsAutoProvisioningEnabled()
if($provisioned.IsAutoProvisioningEnabled -eq $false){
    Write-Host "TPM AutoProvisioning is not enabled - FAILED" -ForegroundColor Red
    exit 1
}
else{
    Write-Host "TPM AutoProvisioning is enabled"
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

#Check it TPM is ready (exit 1 if not)
$ready = $tpm.IsReadyInformation()
if($ready.IsReady -eq $false){
    Write-Host "TPM is not ready - FAILED" -ForegroundColor Red
    exit 1
}
else{
    Write-Host "TPM is ready"
}

}
Catch
{
    Write-Host "Cant get TPM WMI object - Aliveness test FAILED" -ForegroundColor Red
    exit 1
}

Write-Host "PASSED" -ForegroundColor Green
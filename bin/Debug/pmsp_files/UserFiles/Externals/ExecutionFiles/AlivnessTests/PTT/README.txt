
 * PTT Aliveness test
 * Date: 30.10.2014
 * Author: Roi Shneor
=========================

This tool will check the status of the TPM through Win32_Tpm class in PowerShell.

It will verify that:
1. TPM is enabled.
2. TPM is activated.
3. TPM auto-provisioning status is enabled
4. TPM is Owned.
5. TPM is ready.

If any of the above is false it will fail. otherwise Pass.

To run it on win8 or higher just run "run.bat".
To run it on win7 Edit "run.bat" file: change "PTTAlive.ps1" to "PTTAliveWin7.ps1". and run "run.bat".

Exit code will be 0 on success and 1 on failure.
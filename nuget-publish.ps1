param (
    [Parameter(Mandatory=$true)] # Make the Key parameter mandatory
    [string]$Key # API key parameter
)

function PushNugetPackages($apiKey) {
    $output = "$($rootPath)\nuget"
    if(!(Test-Path $output)) {
        Write-Host "Output folder $($output) does not exist"
        exit    
    }
    Write-Host "Searching for nupkg packages to publish"
    $files = [System.IO.Directory]::GetFiles($output, "*.nupkg")
    Write-Host "Found $($files.Length) nuget files with version $($files)"
    if($files.Length -eq 0) {
        exit
    }
    
    $server = "https://api.nuget.org/v3/index.json" # Update NuGet server URL
    Write-Host "NuGet server: $($server), API key: $($apiKey)"
    foreach($file in $files) {
        Write-Host "Publishing file: $($file)"
        nuget push $file -Source $server -ApiKey $apiKey -SkipDuplicate
    }
}

$rootPath = ($ENV:WORKSPACE)
if($rootPath -eq $null) {
    $rootPath = Split-Path -Parent $MyInvocation.MyCommand.Definition
    Write-Host "$($rootPath)"
}
Write-Host "Current directory: $($rootPath)"
# Uncomment the line below to enable pushing NuGet packages
PushNugetPackages -apiKey $Key # Pass the API key parameter to the function

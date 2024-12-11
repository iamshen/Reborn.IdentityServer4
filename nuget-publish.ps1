param (
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
    # Write-Host "Found $($files.Length) nuget files with version $($files)"
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
if($null -eq $rootPath) {
    $rootPath = Split-Path -Parent $MyInvocation.MyCommand.Definition
    Write-Host "$($rootPath)"
}
Write-Host "Current directory: $($rootPath)"

# Determine the API key to use
if ([string]::IsNullOrEmpty($Key)) {
    $Key = $env:REBORN_IDS4_NUGET_API_KEY
}

# Check if API key is still null or empty
if ([string]::IsNullOrEmpty($Key)) {
    Write-Error "ERROR: Nuget API key not provided!"
    Write-Error "Please provide the Nuget API key as a parameter using 【-Key <YourApiKey>】 "
    Write-Error "OR set the environment variable 【REBORN_IDS4_NUGET_API_KEY】."
    exit
}

PushNugetPackages -apiKey $Key # Pass the resolved API key to the function
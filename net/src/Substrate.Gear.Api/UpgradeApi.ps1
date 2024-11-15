param (
    [string]$gearPath,
    [string]$projectName = 'Substrate.Gear.Api' # Project name should always start from Substrate and never end on Client otherwise generated code doesn't compile
)

$webSocketConfig = if ([string]::IsNullOrEmpty($gearPath)) {
    '"websocket": "wss://rpc.vara.network",'
}
else {
    '"websocket": "ws://127.0.0.1:9944",'
}

$webSocketUrl = if ([string]::IsNullOrEmpty($gearPath)) {
    'wss://rpc.vara.network'
}
else {
    'ws://127.0.0.1:9944'
}

$substrateConfigContent = @"
  {
    "projects": {
      "net_api":         "$projectName",
      "rest_service":    "$projectName.RestService",
      "rest_client":     "$projectName.RestClient",
      "net_integration": "$projectName.NetIntegration"
    },
    "metadata": {
      "websocket": "$webSocketUrl",
    },
    "rest_client_settings": {
      "service_assembly": "$projectName.RestService.dll"
    }
  }
"@;

Write-Output $substrateConfigContent

$gearProcess = if (![string]::IsNullOrEmpty($gearPath)) {
    Start-Process -FilePath $gearPath -ArgumentList "--dev" -PassThru -WindowStyle Hidden
    # Wait a bit till node starts
    Start-Sleep -Seconds 5
}

try {
    Set-Location -Path ..

    Set-Content -Path '.\.substrate\substrate-config.json' -Value $substrateConfigContent

    substrate upgrade

    # Remove unnecessary projects
    if (Test-Path "$projectName.NetIntegration") {
        Remove-Item -Path "$projectName.NetIntegration" -Recurse -Force
    }
    if (Test-Path "$projectName.RestClient") {
        Remove-Item -Path "$projectName.RestClient" -Recurse -Force
    }
    if (Test-Path "$projectName.RestService") {
        Remove-Item -Path "$projectName.RestService" -Recurse -Force
    }

    Set-Location -Path "$projectName"

    # Fix broken code generation
    .\ReplacePattern.ps1 -directory '.' -fileType '*.cs' -searchPattern '\.event\.' -replacePattern '.@event.'
    .\ReplacePattern.ps1 -directory '.' -fileType '*.cs' -searchPattern '\.internal\.' -replacePattern '.@internal.'
}
finally {
    if ($null -ne $gearProcess -and !$gearProcess.HasExited) {
        Stop-Process -Id $gearProcess.Id
    }
}

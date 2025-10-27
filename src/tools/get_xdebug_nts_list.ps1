$url='https://xdebug.org/download/historical'
$url_root='https://xdebug.org/'
Invoke-WebRequest -Uri $url | Select-Object -ExpandProperty Content | Select-String -AllMatches 'href=["'']([^"'']+x86_64\.dll)["'']' | ForEach-Object {
    $_.Matches | ForEach-Object {
		$link=$_.Groups[1].Value
		if ($link.StartsWith('/')) {
            $link -replace '^/', $url_root
        } else {
            $link
        }
	}
} | findstr '\-nts\-' | findstr 'php_xdebug' | findstr /V 'beta' | findstr /V 'alpha' | findstr /V '0rc' | findstr /V '1rc' | findstr /V '0RC' | findstr /V '1RC' | Sort-Object -Descending
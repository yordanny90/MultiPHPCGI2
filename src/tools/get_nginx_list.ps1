$url='https://freenginx.org/download/'
$url_root='https://freenginx.org/'
Invoke-WebRequest -Uri $url | Select-Object -ExpandProperty Content | Select-String -AllMatches 'href=["'']([^"'']+\.zip)["'']' | ForEach-Object {
    $_.Matches | ForEach-Object {
		$link=$_.Groups[1].Value
		if ($link.StartsWith('/')) {
            $link -replace '^/', $url_root
        } else {
            $url + $link
        }
	}
} | findstr 'nginx\-' | findstr /V 'download/freenginx' | Sort-Object -Descending
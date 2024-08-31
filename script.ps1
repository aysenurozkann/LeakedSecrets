<# Toplu Obje Olusturmak Icin Kullanilan Kod Blogu #>
<# @authors : HarmanGurbulak, AysenurOzkan #>

$excelFilePath = "C:\Users\Casper\Desktop\harmansss.xlsx"  
$excel = New-Object -ComObject Excel.Application       
$workbook = $excel.Workbooks.Open($excelFilePath
$worksheet = $workbook.Worksheets.Item(1)                
$outputFilePath = "C:\Users\Casper\Desktop\output.txt"    
$null = New-Item -ItemType File -Path $ 
$addressObjects = @()                                    
for ($row = 2; $row -le $worksheet.UsedRange.Rows.Count; $row++) {   
    $name = $worksheet.Cells.Item($row, 1).Value2
    $ipAddress = $worksheet.Cells.Item($row, 2).
    $subnetMask = $worksheet.Cells.Item($row, 3).Value2
    $output = @"
config firewall address
  edit "$name
    set type ipmask
	set associated-interface "port1"
    set subnet $ipAddress $subnetMask
  next
end
"@
    Add-Content -Path $outputFilePath -Value $output                     
    $addressObjects += "`"$name
}

$addressGroupOutput = @"
config firewall addrgrp
  edit "AddressGroupName"                                                
    set member $($addressObjects -join " ")
	
    set comment "Harman ve Aysenur tarafından hazırlandı"
  next
end
"@
Add-Content -Path $outputFilePath -Value $addressGroupOutput             
$workbook.Close()
$excel.Quit()
[System.Runtime.Interopservices.Marshal]::ReleaseComObject($excel) |     
Out-Null

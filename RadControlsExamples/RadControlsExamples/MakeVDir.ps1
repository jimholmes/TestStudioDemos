#param($newPhysicalFolder, $pathToDBFile)

#D:\TestStudioDemos\RadControlsExamples\RadControlsExamples

import-module webadministration

#function SetNewPhysicalPathforVDir($newPhysicalFolder)
function SetNewPhysicalPathforVDir()
{
	Set-ItemProperty 'IIS:\Sites\Default Web Site\WorkingWithLocators' 
			-Name physicalPath -Value d:\temp
}

function LoadNewDatabase($pathToDBFile)
{
	$server = get-item SQLSERVER:\SQL\BleedingEdge\Default
	$files = new-object System.Collections.Specialized.StringCollection
	$files.Add("D:\TestStudioDemos\RadControlsExamples\DBs\Contacts.mdf")
	$files.Add("D:\TestStudioDemos\RadControlsExamples\DBs\Contacts.ldf")
	$server.AttachDatabase("Contacts", $files, "sa")
	Write-Host "Done"
}

# ==== End Functions ==================================================================

SetNewPhysicalPathforVDir
LoadNewDatabase
Feature: Extract To Path
		In order to avoid waste of time
		As user
		I want to extract zip file to some folder automaticly

@mytag
Scenario: Extract file
	Given Extract file action
	And I have this file path "C:\temp\LocalToExtract\mysetupimage.zip"
	And I have this target directory path "C:\temp\LocalToExtract\Folder"
	When I do action extract	
	Then the zip file should be extracted to destination directory path

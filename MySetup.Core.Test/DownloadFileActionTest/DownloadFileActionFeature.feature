Feature: Download File Action
		In order to avoid waste of time
		as user
		I want to download file automaticly

@mytag
Scenario: Download file
	Given Download file action
	And I have this download url "https://avatars2.githubusercontent.com/u/836496?s=460"
	And I have this destination path "C:\temp\mysetupimage.jpg"
	When I do action
	Then the url should be download to destination path

Feature: Test Stack White + SpecFlow (Paint application)

Scenario: Close 'Paint' application without saving
	Given 'Paint' application is started
	When  I open image in 'Paint' application
	 And  I click button 'Select' and choose 'Select All' option on 'Image' section
	 And  I click button 'Cut' on 'Clipboard' section
	 And  I close 'Paint' application
	Then  Dialog form is displayed

    When  I click 'Don't Save' button on dialog form
	Then  Image file isn't modified after closing application

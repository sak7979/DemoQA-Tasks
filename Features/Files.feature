@smoke
Feature: Input and Output of Files
@Files
Scenario Outline: Uploading and dowloading Files
  Given user navigates to "UploadDownload" page
  When user uploads Files using filepath "<filepath>"
  Then Validate the Upload Files using filename "<uploadfilename>"
  When user downloads file to "<savepath>"
  Then Validate downloaded file in "<savepath>" with filename "<filename>"

Examples:
      | filepath                                                                                      | uploadFilename | savepath                                                                                     | filename        |
      | C:\Users\sakethram.n\OneDrive - TECHNOVERT SOLUTIONS PRIVATE LIMITED\Desktop\Filssss\HIII.txt | HIII.txt       | C:\Users\sakethram.n\OneDrive - TECHNOVERT SOLUTIONS PRIVATE LIMITED\Desktop\Filssss         | sampleFile.jpeg |
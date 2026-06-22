@smoke
@tables
Feature: Webtable operations
@Webtables
Scenario: Add, search, edit and delete a record
	Given user navigates to "WebTables" page
	When user adds a new record 
		| firstName | lastName | userName       | age | salary | department |
		| Lionel    | Messi    | Messi@mail.com | 38  | 150000 | Football   |
		| Ronaldo   | cristiano| CR@mail.com    | 43  | 121313 | Football   |
		| Mbappe    | Kylian   | KM@mail.com    | 28  | 10000  | Football   |
		
	Then user searches for "Lionel"
	When user updates the record
		| UpdatefirstName | UpdatelastName | UpdateuserName             | Updateage | Updatesalary | Updatedepartment |
		| Lamin           | Yamal          | Yamal@mail.com             | 17        | 120000       | Football         | 
	Then user deletes the record "Lamin"
	And the record "Lamin" should not be visible
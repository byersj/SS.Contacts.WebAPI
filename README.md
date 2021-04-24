# SS.Contacts.WebAPI
Coding Exercise for SingleStone
Uses LiteDb
Postman collection included for testing endpoints.

Installation/Running
1. Clone repository
2. Create c:\temp folder - this is where the database will be created
3. Run the project in Visual Studio in debug mode (Press F5)
4. Use Postman collection to hit endpoints

Nothing special kept application within single project to keep development time down. Normally POCOs, Datalayer, interfaces would be in seperate projects and only referenced where needed. Wouldn't normally return POCOs from endpoints, but would map POCO to models. 

Unit tests were not created, code is very simple and mostly self explanatory. Only tricky thing is commented using //JJB for where/how services should be instantiated and injected. 
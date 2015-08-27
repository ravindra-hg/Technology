MVC Action Filter Understanding

Def: Action filter is an attribute that can be applied to controller action or at controller level

Asp.Net MVC supports four types of Action Filter attributes
	1. Authorization filter - IAuthorizationFilter attribute
		This is used for Authentication and Authorization filters and Authorize is an exmple of this filter
	2. Action filters - IActionFilter attribute
		This contains the logic to implement before and after controller action execution. for example: to modify View data
	3. Result filters - IResultFilter attribute
		This contains the logic to implement before and after view result execution ex: you might want to modify the view result before rendering to browser
	4. Exception filters - IExceptionFilter attribute
		This filter can be used for excption filter to handle exception by the controller action or action result
			ex: HandleError attribute

Other Action filter example : OnOutputcache
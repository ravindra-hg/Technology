Exception Handling
1. Handle exception at method level using try catch
2. Handle Exception at controller level by overriding onException
	note: mark filtercontext.ExceptionHandle to redirect to view else exception shown 
3. Global Handle exception handling
	i. Mark class or action method with HandleError attribute
	ii. Mark web.config with <customErrors mode="On">
	iii. Specific error code can be handled and redirect to customized page, especial 404
		<error statusCode="404" redirect="~/Testing/NotFound"/>
	iv. Specific exceptions can be handled by specifying type of exception in the attribute
		[HandleError(ExceptionType=typeof(InvalidOperationException))]
	      
Config = Debug_Prism
Use PRISM navigation

Config = Debug
Use XF navigation

Using XF 3.2 

** Working **

Steps;
Run
Reset Log
Go to Another Page
GoBackAsync
Load Log

Result;
Main disappearing
AnotherPage appearing
AnotherPage disappearing
Main appearing


** Not Working **

Steps;
Run
Reset Log
Go to Another Page
NavigationPage/MainPage
Load Log

Result;
Main disappearing
AnotherPage appearing
Main appearing


If you downgrade XF to 2.5 and use PRISM it works using the root navigation path 'NavigationPage/MainPage'

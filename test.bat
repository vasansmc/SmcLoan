@echo off
Packages\xunit.runner.console.2.0.0\tools\xunit.console ^
	SMCLoanFact\bin\Debug\SMCLoanFact.dll ^
	-parallel all ^
	-html Result.html ^
	-nologo -quiet ^
	-trait "category=para1"
	
@echo on 
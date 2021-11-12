:: Creates a Variable for the Output File
@SET file="pex_test_results.txt"

:: Erases Everything Currently In the Output File
type NUL>%file%

:: ----------------------------------------
:: TITLE
:: ----------------------------------------
echo PEX3 Tests >> %file%
echo Running Correct Test Cases >> %file%
echo. >> %file%

:: ----------------------------------------
:: GOOD EXAMPLES
:: ----------------------------------------
echo Checks datype matching for arithmetic expressions. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_arith-operator.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Checks dataype matching for funciton calls expressions. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_funct-calls.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Checks dataype matching inside function argument spec and function definiton. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_function-arg-declare.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Checks if variables declared in functions can be declared in main. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_redeclare-sep-funct.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Checks datatype matching for assignments. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Checks if blank main function passes. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_template-test.txt >> %file%
echo. >> %file%
echo. >> %file%
echo. >> %file%
echo. >> %file%


:: ----------------------------------------
:: BAD EXAMPLES
:: ----------------------------------------
echo Running Incorrect Test Cases >> %file%
echo. >> %file%
echo Fails when arithmetic expressions appear in logic statements. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_arith-in-logic.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when arithmetic expressions appear in compound logic statements. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_arith-in-logic2.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when datatypes don't match in arithmetic expressions. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_arith-operator.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when assigning an integer another value. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_assign-num-to-var.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when reassigining constants. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_const-reassignment.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when datatype mismatch between function parameter declarations and function definiton. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-arg-declare.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when redeclaring a function parameter in function definition. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-arg-redeclare.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when calling a function with improper number of parameters. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-call-param-count.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when calling a function with improper parameter datatype. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-calls-param-type.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when declaring two identical functions. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-redeclare.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when calling function with logic expression. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_logic-in-call.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when operands in logic expression mismatch datatypes. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_logic-type-mismatch.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when redeclaring a variable.>> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_redeclaration.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when assigning improper datatypes. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when assigning an undeclared variable.>> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_undeclared-var-assign.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when calling a function with a variable name. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_var-funct-call.txt >> %file%
echo. >> %file%
echo. >> %file%
echo Fails when constant assignment does not match declaration. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_const-assignment-type-mismatch.txt >> %file%
echo. >> %file%
echo. >> %file%


pause
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
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_arith-operator.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_funct-calls.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_function-arg-declare.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_redeclare-sep-funct.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
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
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_arith-in-logic.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_arith-in-logic2.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_arith-operator.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_assign-num-to-var.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_const-reassignment.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-arg-declare.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-arg-redeclare.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-call-param-count.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-calls-param-type.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-redeclare.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_funct-unassigned-vars.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_logic-in-call.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_logic-type-mismatch.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_redeclaration.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_undeclared-var-assign.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\FAIL_var-funct-call.txt >> %file%
echo. >> %file%
echo. >> %file%

pause
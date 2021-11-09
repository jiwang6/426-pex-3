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
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%
bin\Debug\ConsoleApplication.exe testcases\pex3\PASS_type-assignment-permutations.txt >> %file%
echo. >> %file%
echo. >> %file%

pause
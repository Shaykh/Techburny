cls
set server=(local)
set database=TechburnyStore
sqlcmd -S %server% -i "00_Database.sql"
sqlcmd -S %server% -d %database% -i "01_Schemas.sql"
sqlcmd -S %server% -d %database% -i "02_Tables.sql"
sqlcmd -S %server% -d %database% -i "03_Constraints.sql"
sqlcmd -S %server% -d %database% -i "04_Functions.sql"
sqlcmd -S %server% -d %database% -i "05_Views.sql"
sqlcmd -S %server% -d %database% -i "06_Rows.sql"
pause

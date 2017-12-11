# MyBillBooks
A book for bills, to prevent pre-cost
## RunTime  
.Net 4.5  
## Compile Environment
***Notice*** Remember to modify your database connection infomation in Data folder  

.Net 4.5  
Visual Studio 2017  
### Relate Package  
NHibernate  
Mysql.Data  
Microsoft.Office.Interop.Excel  
Microsoft.CSharp  
Newtonsoft.json

## Release Note
### 2017/12/8 Release 1.1
1. Change data storage from .cs to Data Folder, you can use it without recompile
2. The startup will be slow, I moved session factory initialize to there
### 2017/4/12 Release 1.0.2
1. Change hbm file compile option.  
2. You can use ime to input text by default now!
### 2017/3/14 Release 1.0.1  
1. Catch more Exception and record it to file.  
2. Pack log util as Log.cs  
### 2017/2/27 Release 1.0  
1. Change the textbox whitch use to select date to DateTimePicker  
2. Catch some Exceptions  
3. Add the Form to see how much you spend  
4. You can export year and month report now  
### 2017/ I foget when I release it. Beta 1  
1. Only one item can import to database without Exception

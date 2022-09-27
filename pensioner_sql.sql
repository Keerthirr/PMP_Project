create database FinalDatabase
use FinalDatabase
create table Pensioner(PensionerID int primary key, AadharID nvarchar (12), Names nvarchar(50), Age int, Gender nvarchar(10), Address nvarchar(60), MobileNo nvarchar(15), BankName nvarchar(50), AccountNumber nvarchar(20), PensionAmount nvarchar(10), Reason nvarchar(50))
select *from Pensioner
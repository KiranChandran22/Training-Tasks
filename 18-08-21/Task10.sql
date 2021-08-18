create table CANDIDATE (
	Ccode Int  primary key,
	Name varchar(20),
	DOJ date
);

insert into CANDIDATE values(1001 ,'S.Raman', '1997-06-27' ) 
insert into CANDIDATE values(1002 ,'M.Sushil ', '1997-11-12' ) 
insert into CANDIDATE values(1003 ,'Mohanyes ', '1997-07-31' ) 

update CANDIDATE set Name='R.Krishnan'
where Ccode=1001

select * from CANDIDATE

drop table CANDIDATE
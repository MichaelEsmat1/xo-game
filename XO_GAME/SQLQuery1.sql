select*from savescore;
delete from  savescore; 
DBCC CHECKIDENT ('savescore', RESEED, 0);
backup database [XO-game]
to disk='E:\XO-game.bak';
CREATE VIEW issuesView AS
SELECT З.Номер,З.Тема,З.Статус,З.ДатаСоздания,З.Текст,п.ФИО  as Составитель, З.Составитель AS Код
FROM Заявки З JOIN Проживающие П ON З.Составитель = П.Код
GO
CREATE VIEW inventView AS
SELECT И.*, К.Блок as Блок, Всего = 
	(SELECT count(*)
	FROM Инвентарь В
	WHERE В.Название = И.Название)
FROM Инвентарь И JOIN Комнаты К ON Комната = К.Номер
GO
CREATE VIEW vahtsView AS
SELECT В.*, Р.ФИО AS Фио
FROM Вахты В JOIN Работники Р ON В.Вахтер = Р.Код
GO

CREATE TYPE dateType FROM DATETIME 
GO
CREATE DEFAULT currentDateDefault AS
GETDATE() 
GO
EXEC sp_bindefault currentDateDefault, dateType 
GO


CREATE TYPE telType FROM VARCHAR(16) 
GO
CREATE RULE telRule AS
(@tel LIKE '+7([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]') OR
(@tel LIKE '8([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]') 
GO
EXEC sp_bindrule telRule, telType 
GO


CREATE TYPE fioType FROM VARCHAR(127) 
GO
CREATE RULE fioRule AS
@fio LIKE '[А-Я]% [А-Я]% [А-Я]%' 
GO
EXEC sp_bindrule fioRule,fioType 
GO


CREATE TYPE moneyType FROM INT 
GO
CREATE RULE notNegativeRule AS
@value >= 0 
GO
EXEC sp_bindRule notNegativeRule, moneyType 
GO


CREATE TYPE blockType FROM VARCHAR(127) 
GO
CREATE RULE blockTypeRule AS
@type = 'Мужской' OR
@type = 'Женский' OR
@type = 'Общий' OR
@type = 'Преподавательский' OR
@type = 'Семейный' OR
@type = 'Служебный' 
GO
EXEC sp_bindRule blockTypeRule, blockType 
GO

CREATE TYPE statusType FROM VARCHAR(127)
GO
CREATE RULE statusRule AS
@status = 'Открыта' OR 
@status = 'Выполняется' OR 
@status = 'Отклонена' OR
@status = 'Выполнена'
GO
EXEC sp_bindRule statusRule, statusType 
GO
CREATE DEFAULT issueStatusDefault AS
'Открыта'
GO
EXEC sp_bindefault issueStatusDefault, statusType 
GO


CREATE TYPE passportType FROM BIGINT
GO
CREATE RULE passportRule AS
 @value >= 1000000000 AND  @value <= 9999999999
GO
EXEC sp_bindRule passportRule, passportType 
GO

SELECT *
FROM issuesView

SELECT *
FROM inventView

SELECT *
FROM vahtsView

 

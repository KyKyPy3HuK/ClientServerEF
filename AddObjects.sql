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


CREATE RULE telRule AS
(@tel LIKE '+7([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]') OR
(@tel LIKE '8([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]') 
GO
EXEC sp_bindrule telRule, 'Проживающие.Телефон'
GO
EXEC sp_bindrule telRule, 'Работники.Телефон'
GO


CREATE RULE fioRule AS
@fio LIKE '[А-Я]% [А-Я]% [А-Я]%' 
GO
EXEC sp_bindrule fioRule, 'Проживающие.ФИО'
GO
EXEC sp_bindrule fioRule, 'Работники.ФИО'
GO


CREATE RULE notNegativeRule AS
@value >= 0 
GO
EXEC sp_bindRule notNegativeRule, 'Должности.Оклад'
GO
EXEC sp_bindRule notNegativeRule, 'ТипыВахт.Ставка'
GO
EXEC sp_bindRule notNegativeRule, 'Вахты.Длительность'
GO
EXEC sp_bindRule notNegativeRule, 'ТипыПроживающих.Тариф'
GO
EXEC sp_bindRule notNegativeRule, 'ТипыКомнат.КойкоМеста'
GO
EXEC sp_bindRule notNegativeRule, 'Инвентарь.Стоимость'
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


CREATE RULE passportRule AS
 @value >= 1000000000 AND  @value <= 9999999999
GO
EXEC sp_bindRule passportRule, 'Работники.Код' 
GO
EXEC sp_bindRule passportRule, 'Проживающие.Код' 
GO

SELECT *
FROM issuesView
GO
SELECT *
FROM inventView
GO
SELECT *
FROM vahtsView
GO
 
CREATE TRIGGER cascadeDeleteBlock ON Комнаты
INSTEAD OF DELETE AS
BEGIN
	DECLARE @room int

	DECLARE roomCur CURSOR FOR
		SELECT deleted.Номер
		FROM deleted

	OPEN roomCur
		FETCH NEXT FROM roomCur INTO @room
		WHILE @@FETCH_STATUS = 0 
		BEGIN

			DECLARE @student int

			DECLARE studentCur CURSOR FOR
				SELECT Проживающие.Код
				FROM Проживающие
				WHERE Проживающие.Комната = @room

			OPEN studentCur
				FETCH NEXT FROM studentCur INTO @student
				WHILE @@FETCH_STATUS = 0
				BEGIN
					DELETE FROM Заявки
					WHERE Заявки.Составитель = @student
					FETCH NEXT FROM studentCur INTO @student
				END
			CLOSE studentCur
			DEALLOCATE studentCur

			DELETE FROM Проживающие
			WHERE Проживающие.Комната = @room

			DELETE FROM Инвентарь
			WHERE Инвентарь.Комната = @room

			DELETE FROM Комнаты
			WHERE Комнаты.Номер = @room

			FETCH NEXT FROM roomCur INTO @room
		END
		CLOSE roomCur
		DEALLOCATE roomCur
END
GO

CREATE TRIGGER insertBlock ON Блоки
INSTEAD OF INSERT AS
	BEGIN
	DECLARE @block int 
	DECLARE @level int
	DECLARE @wing int
	DECLARE @type varchar(127)
	DECLARE blockCur CURSOR FOR
		SELECT inserted.Номер, inserted.Этаж, inserted.Крыло, inserted.Тип
		FROM inserted
	OPEN blockCur
		FETCH NEXT FROM blockCur INTO @block, @level, @wing, @type
		WHILE @@FETCH_STATUS = 0
			BEGIN
			IF NOT EXISTS(SELECT * FROM Блоки WHERE (Блоки.Номер = @block) OR (Блоки.Этаж = @level and Блоки.Крыло = @wing))
				BEGIN
				INSERT INTO Блоки VALUES (@block,@level,@wing,@type)
				END
			FETCH NEXT FROM blockCur INTO @block, @level, @wing, @type
			END
		CLOSE blockCur
		DEALLOCATE blockCur
	END
GO

CREATE TRIGGER updateIssue ON Заявки
INSTEAD OF UPDATE AS
BEGIN
	DECLARE @issue int
	DECLARE @status varchar(127)

	DECLARE issueCur CURSOR FOR
		SELECT inserted.Номер, inserted.Статус
		FROM inserted

	OPEN issueCur
		FETCH NEXT FROM issueCur INTO @issue, @status
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS(SELECT * FROM Заявки WHERE Заявки.Номер = @issue and (Заявки.Статус <> 'Отклонена' OR Заявки.Статус <> 'Выполнена'))
			BEGIN
				UPDATE Заявки
				SET Заявки.Статус = @status
				WHERE Заявки.Номер = @issue
			END
			FETCH NEXT FROM issueCur INTO @issue, @status
		END
		CLOSE issueCur
		DEALLOCATE issueCur
END
GO

CREATE TRIGGER addVaht On Вахты
INSTEAD OF INSERT AS
BEGIN
	DECLARE @vaht int
	DECLARE @type varchar(127)
	DECLARE @date datetime
	DECLARE @duration int
	DECLARE @worker int
	
	DECLARE vahtCur CURSOR FOR
		SELECT inserted.Номер, inserted.Вахтер
		FROM inserted

	OPEN vahtCur
		FETCH NEXT FROM vahtCur INTO @vaht,@type, @date,@duration, @worker
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS(SELECT * FROM Работники WHERE Работники.Код = @worker AND Работники.Должность = 'Вахтер')
			BEGIN
				INSERT INTO Вахты VALUES
				(@type, @date,@duration, @worker)
			END
			FETCH NEXT FROM vahtCur INTO @vaht,@type, @date,@duration, @worker
		END
		CLOSE vahtCur
		DEALLOCATE vahtCur
END
Go

CREATE TRIGGER addDuty ON Дежурство
INSTEAD OF INSERT AS
BEGIN
	DECLARE @worker int
	DECLARE @block int
	DECLARE dutyCur CURSOR FOR
		SELECT inserted.Блок, inserted.Дежурный
		FROM inserted

	OPEN vahtCur
		FETCH NEXT FROM vahtCur INTO @block, @worker
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS(SELECT * FROM Работники WHERE Работники.Код = @worker AND Работники.Должность = 'Уборщик')
			BEGIN
				INSERT INTO Дежурство VALUES
				(@block, @worker)
			END
			FETCH NEXT FROM vahtCur INTO @block, @worker
		END
		CLOSE vahtCur
		DEALLOCATE vahtCur
END
GO

CREATE PROC insertVaht (@type varchar(127), @date datetime, @duration int, @worker int)
AS
IF EXISTS(SELECT * FROM Работники WHERE Работники.Код = @worker AND Работники.Должность = 'Вахтер')
BEGIN
	INSERT INTO Вахты (Тип, ДатаНачала, Длительность, Вахтер) VALUES 
	(@type, @date, @duration,@worker)
	RETURN 0
END
ELSE
BEGIN
RETURN 1
END
GO

CREATE PROC updateVaht (@num int,@type varchar(127), @date datetime, @duration int, @worker int)
AS
IF EXISTS(SELECT * FROM Работники WHERE Работники.Код = @worker and Должность = 'Вахтер')
BEGIN
	UPDATE Вахты
	SET Тип = @type, ДатаНачала = @date, Длительность = @duration, Вахтер = @worker
	WHERE Вахты.Номер = @num
	RETURN 0
END
ELSE
BEGIN
	RETURN 1
END
GO

ALTER PROC insertIssue (@title varchar(127), @text varchar(max), @author int)
AS
IF EXISTS(SELECT * FROM Проживающие WHERE Проживающие.Код = @author)
BEGIN
	INSERT INTO Заявки (Заявки.Тема, Заявки.Текст, Заявки.Составитель) VALUES
	(@title,  @text, @author )
	RETURN 0
END
ELSE
BEGIN
	RETURN 1
END
GO

CREATE PROC updateIssue (@num int, @status statusType)
AS
IF EXISTS(SELECT * FROM Заявки WHERE Заявки.Номер = @num and (Заявки.Статус = 'Открыта' OR Заявки.Статус = 'Выполняется'))
			BEGIN
				UPDATE Заявки
				SET Заявки.Статус = @status
				WHERE Заявки.Номер = @num
				RETURN 0
			END
ELSE
BEGIN 
	RETURN 1
END
Go

CREATE PROC insertInvent (@name varchar(127), @date datetime, @cost int, @room int)
AS
IF EXISTS(SELECT * FROM Комнаты WHERE Комнаты.Номер = @room)
	BEGIN
	INSERT INTO Инвентарь VALUES
	(@name , @date , @cost , @room )
	RETURN 0
	END
ELSE
BEGIN 
	RETURN 1
END
GO

CREATE PROC deleteInvent (@code int)
AS
IF EXISTS(SELECT * FROM Инвентарь WHERE Инвентарь.Код = @code)
BEGIN
	DELETE Инвентарь
	WHERE Инвентарь.Код = @code
	RETURN 0
END
ELSE
BEGIN 
	RETURN 1
END
GO

CREATE PROC updateInvent (@code int, @name varchar(127), @date datetime, @cost int, @room int)
AS
IF EXISTS(SELECT * FROM Инвентарь WHERE Инвентарь.Код = @code)
BEGIN
	UPDATE Инвентарь
	SET Название = @name,ДатаПоставки = @date, Стоимость = @cost, Комната = @room
	WHERE Инвентарь.Код = @code
	RETURN 0
END
ELSE
BEGIN 
	RETURN 1
END
GO

CREATE PROC computeAllCost (@cost int output)
AS
SELECT @cost = sum(Стоимость)
FROM Инвентарь
GO


EXEC updateIssue 3, 'Отклонена'

EXEC insertIssue 'Ремонт',  'Сломалась психика' , 2
GO
SELECT * 
FROM Проживающие

SELECT * 
FROM Заявки

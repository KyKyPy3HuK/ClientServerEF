
--������������� ��� ������ ������ � ����������--
CREATE VIEW issuesView AS
SELECT �.�����,�.����,�.������,�.������������,�.�����,�.���  as �����������, �.����������� AS ���
FROM ������ � JOIN ����������� � ON �.����������� = �.���
GO
--������������� ��� ������ ��������� � ����������--
CREATE VIEW inventView AS
SELECT �.*, �.���� as ����, ����� = 
	(SELECT count(*)
	FROM ��������� �
	WHERE �.�������� = �.��������)
FROM ��������� � JOIN ������� � ON ������� = �.�����
GO
--������������� ��� ������ ���� � ����������--
CREATE VIEW vahtsView AS
SELECT �.*, �.��� AS ���
FROM ����� � JOIN ��������� � ON �.������ = �.���
GO

--������� ��� ������ ��������--
CREATE RULE telRule AS
(@tel LIKE '+7([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]') OR
(@tel LIKE '8([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]') 
GO
EXEC sp_bindrule telRule, '�����������.�������'
GO
EXEC sp_bindrule telRule, '���������.�������'
GO

--������� ��� ���--
CREATE RULE fioRule AS
@fio LIKE '[�-�]% [�-�]% [�-�]%' 
GO
EXEC sp_bindrule fioRule, '�����������.���'
GO
EXEC sp_bindrule fioRule, '���������.���'
GO

--������� ��� �������� ������� ������ ���� ������ ����--
CREATE RULE notNegativeRule AS
@value >= 0 
GO
EXEC sp_bindRule notNegativeRule, '���������.�����'
GO
EXEC sp_bindRule notNegativeRule, '��������.������'
GO
EXEC sp_bindRule notNegativeRule, '�����.������������'
GO
EXEC sp_bindRule notNegativeRule, '���������������.�����'
GO
EXEC sp_bindRule notNegativeRule, '����������.����������'
GO
EXEC sp_bindRule notNegativeRule, '���������.���������'
GO

--���������������� ��� ��� ���� �����--
CREATE TYPE blockType FROM VARCHAR(127) 
GO
CREATE RULE blockTypeRule AS
@type = '�������' OR
@type = '�������' OR
@type = '�����' OR
@type = '�����������������' OR
@type = '��������' OR
@type = '���������' 
GO
EXEC sp_bindRule blockTypeRule, blockType 
GO

--���������������� ��� ��� ������� ������--
CREATE TYPE statusType FROM VARCHAR(127)
GO
CREATE RULE statusRule AS
@status = '�������' OR 
@status = '�����������' OR 
@status = '���������' OR
@status = '���������'
GO
EXEC sp_bindRule statusRule, statusType 
GO
CREATE DEFAULT issueStatusDefault AS
'�������'
GO
EXEC sp_bindefault issueStatusDefault, statusType 
GO

--������� ��� ������ ��������--
CREATE RULE passportRule AS
 @value >= 1000000000 AND  @value <= 9999999999
GO
EXEC sp_bindRule passportRule, '���������.���' 
GO
EXEC sp_bindRule passportRule, '�����������.���' 
GO

 --������� ���������� �������� ����������� � ��������� �������, �� ������ � ���������--
CREATE TRIGGER cascadeDeleteRoom ON �������
INSTEAD OF DELETE AS
BEGIN
	DECLARE @room int

	DECLARE roomCur CURSOR FOR
		SELECT deleted.�����
		FROM deleted

	OPEN roomCur
		FETCH NEXT FROM roomCur INTO @room
		WHILE @@FETCH_STATUS = 0 
		BEGIN

			DECLARE @student int

			DECLARE studentCur CURSOR FOR
				SELECT �����������.���
				FROM �����������
				WHERE �����������.������� = @room

			OPEN studentCur
				FETCH NEXT FROM studentCur INTO @student
				WHILE @@FETCH_STATUS = 0
				BEGIN
					DELETE FROM ������
					WHERE ������.����������� = @student
					FETCH NEXT FROM studentCur INTO @student
				END
			CLOSE studentCur
			DEALLOCATE studentCur

			DELETE FROM �����������
			WHERE �����������.������� = @room

			DELETE FROM ���������
			WHERE ���������.������� = @room

			DELETE FROM �������
			WHERE �������.����� = @room

			FETCH NEXT FROM roomCur INTO @room
		END
		CLOSE roomCur
		DEALLOCATE roomCur
END
GO

--������� ��� �������� �� ������������ �������� ����� � ����� ����������� ������--
CREATE TRIGGER insertBlock ON �����
INSTEAD OF INSERT AS
	BEGIN
	DECLARE @block int 
	DECLARE @level int
	DECLARE @wing int
	DECLARE @type varchar(127)
	DECLARE blockCur CURSOR FOR
		SELECT inserted.�����, inserted.����, inserted.�����, inserted.���
		FROM inserted
	OPEN blockCur
		FETCH NEXT FROM blockCur INTO @block, @level, @wing, @type
		WHILE @@FETCH_STATUS = 0
			BEGIN
			IF NOT EXISTS(SELECT * FROM ����� WHERE (�����.����� = @block) OR (�����.���� = @level and �����.����� = @wing))
				BEGIN
				INSERT INTO ����� VALUES (@block,@level,@wing,@type)
				END
			FETCH NEXT FROM blockCur INTO @block, @level, @wing, @type
			END
		CLOSE blockCur
		DEALLOCATE blockCur
	END
GO

--������� �� ��������� ������� ������--
CREATE TRIGGER updateIssueT ON ������
INSTEAD OF UPDATE AS
BEGIN
	DECLARE @issue int
	DECLARE @status varchar(127)

	DECLARE issueCur CURSOR FOR
		SELECT inserted.�����, inserted.������
		FROM inserted

	OPEN issueCur
		FETCH NEXT FROM issueCur INTO @issue, @status
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS(SELECT * FROM ������ WHERE ������.����� = @issue and (������.������ <> '���������' OR ������.������ <> '���������'))
			BEGIN
				UPDATE ������
				SET ������.������ = @status
				WHERE ������.����� = @issue
			END
			FETCH NEXT FROM issueCur INTO @issue, @status
		END
		CLOSE issueCur
		DEALLOCATE issueCur
END
GO

--������� �� ���������� �����, � ������� ����� �������� ������ �������� � ���������� �������--
CREATE TRIGGER addVaht On �����
INSTEAD OF INSERT AS
BEGIN
	DECLARE @vaht int
	DECLARE @type varchar(127)
	DECLARE @date datetime
	DECLARE @duration int
	DECLARE @worker bigint
	
	DECLARE vahtCur CURSOR FOR
		SELECT *
		FROM inserted

	OPEN vahtCur
		FETCH NEXT FROM vahtCur INTO @vaht,@type, @date,@duration, @worker
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS(SELECT * FROM ��������� WHERE ���������.��� = @worker AND ���������.��������� = '������')
			BEGIN
				INSERT INTO ����� VALUES
				(@type, @date,@duration, @worker)
			END
			FETCH NEXT FROM vahtCur INTO @vaht,@type, @date,@duration, @worker
		END
		CLOSE vahtCur
		DEALLOCATE vahtCur
END
Go

--������� �� ���������� ��������� � ����--
CREATE TRIGGER addDuty ON ���������
INSTEAD OF INSERT AS
BEGIN
	DECLARE @worker bigint
	DECLARE @block int
	DECLARE dutyCur CURSOR FOR
		SELECT inserted.����, inserted.��������
		FROM inserted

	OPEN dutyCur
		FETCH NEXT FROM dutyCur INTO @block, @worker
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS(SELECT * FROM ��������� WHERE ���������.��� = @worker AND ���������.��������� = '�������')
			BEGIN
				INSERT INTO ��������� VALUES
				(@block, @worker)
			END
			FETCH NEXT FROM dutyCur INTO @block, @worker
		END
		CLOSE dutyCur
		DEALLOCATE dutyCur
END
GO

--��������� ���������� ����� �����--
CREATE PROC insertVaht (@type varchar(127), @date datetime, @duration int, @worker bigint)
AS
IF EXISTS(SELECT * FROM ��������� WHERE ���������.��� = @worker AND ���������.��������� = '������')
BEGIN
	INSERT INTO ����� (���, ����������, ������������, ������) VALUES 
	(@type, @date, @duration,@worker)
	RETURN 0
END
ELSE
BEGIN
RETURN 1
END
GO

--��������� ���������� �����--
CREATE PROC updateVaht (@num int,@type varchar(127), @date datetime, @duration int, @worker bigint)
AS
IF EXISTS(SELECT * FROM ��������� WHERE ���������.��� = @worker and ��������� = '������')
BEGIN
	UPDATE �����
	SET ��� = @type, ���������� = @date, ������������ = @duration, ������ = @worker
	WHERE �����.����� = @num
	RETURN 0
END
ELSE
BEGIN
	RETURN 1
END
GO

--��������� ���������� ������--
CREATE PROC insertIssue (@title varchar(127), @text varchar(max), @author bigint)
AS
IF EXISTS(SELECT * FROM ����������� WHERE �����������.��� = @author)
BEGIN
	INSERT INTO ������ (������.����, ������.�����, ������.�����������) VALUES
	(@title,  @text, @author )
	RETURN 0
END
ELSE
BEGIN
	RETURN 1
END
GO

--��������� ���������� ������� ������--
CREATE PROC updateIssue (@num int, @status statusType)
AS
IF EXISTS(SELECT * FROM ������ WHERE ������.����� = @num and (������.������ = '�������' OR ������.������ = '�����������'))
			BEGIN
				UPDATE ������
				SET ������.������ = @status
				WHERE ������.����� = @num
				RETURN 0
			END
ELSE
BEGIN 
	RETURN 1
END
Go

--��������� ���������� ������ ���������--
CREATE PROC insertInvent (@name varchar(127), @date datetime, @cost int, @room int)
AS
IF EXISTS(SELECT * FROM ������� WHERE �������.����� = @room)
	BEGIN
	INSERT INTO ��������� VALUES
	(@name , @date , @cost , @room )
	RETURN 0
	END
ELSE
BEGIN 
	RETURN 1
END
GO

--��������� �������� ���������--
CREATE PROC deleteInvent (@code int)
AS
IF EXISTS(SELECT * FROM ��������� WHERE ���������.��� = @code)
BEGIN
	DELETE ���������
	WHERE ���������.��� = @code
	RETURN 0
END
ELSE
BEGIN 
	RETURN 1
END
GO

--��������� ���������� ���������--
CREATE PROC updateInvent (@code int, @name varchar(127), @date datetime, @cost int, @room int)
AS
IF EXISTS(SELECT * FROM ��������� WHERE ���������.��� = @code)
BEGIN
	UPDATE ���������
	SET �������� = @name,������������ = @date, ��������� = @cost, ������� = @room
	WHERE ���������.��� = @code
	RETURN 0
END
ELSE
BEGIN 
	RETURN 1
END
GO

--��������� �������� �����--
CREATE PROC deleteVaht (@num int)
AS
IF EXISTS(SELECT * FROM ����� WHERE �����.����� = @num)
BEGIN
	DELETE �����
	WHERE �����.����� = @num
	RETURN 0
END
ELSE
BEGIN 
	RETURN 1
END
GO

CREATE PROC computeAllCost (@cost int output)
AS
SELECT @cost = sum(���������)
FROM ���������
GO

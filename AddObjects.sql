CREATE VIEW issuesView AS
SELECT �.�����,�.����,�.������,�.������������,�.�����,�.���  as �����������, �.����������� AS ���
FROM ������ � JOIN ����������� � ON �.����������� = �.���
GO
CREATE VIEW inventView AS
SELECT �.*, �.���� as ����, ����� = 
	(SELECT count(*)
	FROM ��������� �
	WHERE �.�������� = �.��������)
FROM ��������� � JOIN ������� � ON ������� = �.�����
GO
CREATE VIEW vahtsView AS
SELECT �.*, �.��� AS ���
FROM ����� � JOIN ��������� � ON �.������ = �.���
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
@fio LIKE '[�-�]% [�-�]% [�-�]%' 
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
@type = '�������' OR
@type = '�������' OR
@type = '�����' OR
@type = '�����������������' OR
@type = '��������' OR
@type = '���������' 
GO
EXEC sp_bindRule blockTypeRule, blockType 
GO

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

 

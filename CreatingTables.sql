use master 
go
use CourseWorkSQL
go
BEGIN TRANSACTION addTables
	CREATE TABLE ��������������� (
		�������� varchar(127) PRIMARY KEY NOT NULL,
		����� int NOT NULL
	)
	GO
	CREATE TABLE ���������� (
		�������� varchar(127) PRIMARY KEY NOT NULL,
		���������� int NOT NULL
	)
	GO
	CREATE TABLE ��������� (
		�������� varchar(127) PRIMARY KEY NOT NULL,
		����� int NOT NULL
	)
	GO
	CREATE TABLE �������� (
		�������� varchar(127) PRIMARY KEY NOT NULL,
		������ int NOT NULL
	)
	GO
	CREATE TABLE ��������� (
		��� bigint PRIMARY KEY NOT NULL,
		��� varchar(127) NOT NULL,
		������� varchar(127) NOT NULL,
		��������� varchar(127) NOT NULL,
		FOREIGN KEY (���������) REFERENCES ���������
	)
	GO
	CREATE TABLE ����� (
		����� int PRIMARY KEY NOT NULL,
		���� int NOT NULL,
		����� int NOT NULL,
		��� blockType NOT NULL
	)
	GO
	CREATE TABLE ������� (
		����� int PRIMARY KEY NOT NULL,
		��� varchar(127) NOT NULL,
		���� int NOT NULL,
		FOREIGN KEY (���) REFERENCES ����������,
		FOREIGN KEY (����) REFERENCES �����
	)
	GO
	CREATE TABLE ����������� (
		��� bigint PRIMARY KEY NOT NULL,
		��� varchar(127) NOT NULL,
		������� varchar(127) NOT NULL,
		��� varchar(3) NOT NULL,
		������������ date NOT NULL,
		��� varchar(127) NOT NULL,
		������� int NOT NULL,
		FOREIGN KEY (���) REFERENCES ���������������,
		FOREIGN KEY (�������) REFERENCES �������
	)
	GO
	CREATE TABLE ������ (
	����� int PRIMARY KEY NOT NULL IDENTITY(1,1),
	���� varchar(127) NOT NULL,
	������ statusType NOT NULL,
	������������ date NOT NULL default GETDATE(),
	����� varchar(MAX),
	����������� bigint NOT NULL,
	FOREIGN KEY (�����������) REFERENCES �����������
	)
	GO
CREATE TABLE ��������� (
	��� int PRIMARY KEY NOT NULL IDENTITY(1,1),
	�������� varchar(127) NOT NULL,
	������������ date NOT NULL default GETDATE(),
	��������� int NOT NULL,
	������� int NOT NULL,
	FOREIGN KEY (�������) REFERENCES �������,
)
	GO
	CREATE TABLE ����� (
		����� int PRIMARY KEY NOT NULL IDENTITY(1,1),
		��� varchar(127) NOT NULL,
		FOREIGN KEY (���) REFERENCES ��������,
		���������� date NOT NULL default GETDATE(),
		������������ int NOT NULL,
		������ bigint,
		FOREIGN KEY (������) REFERENCES ���������
	)
	GO
	CREATE TABLE ���������(
		���� int PRIMARY KEY NOT NULL,
		�������� bigint NOT NULL,
		FOREIGN KEY(����) REFERENCES �����,
		FOREIGN KEY(��������) REFERENCES ���������
	)
	GO
COMMIT TRANSACTION addTables
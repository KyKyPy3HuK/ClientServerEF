use master
use CourseWorkSQL
CREATE TABLE ��������������� (
	�������� varchar(127) PRIMARY KEY NOT NULL,
	����� int NOT NULL DEFAULT 1000,
	�������� varchar(MAX)
)

CREATE TABLE ���������� (
	�������� varchar(127) PRIMARY KEY NOT NULL,
	�������� varchar(MAX),
	���������� int NOT NULL DEFAULT 0
)

CREATE TABLE ���������� (
	�������� varchar(127) PRIMARY KEY NOT NULL,
	�������� varchar(MAX)
)

CREATE TABLE ��������� (
	�������� varchar(127) PRIMARY KEY NOT NULL,
	�������� varchar(MAX),
	����� int NOT NULL DEFAULT 19000
)

CREATE TABLE �������� (
	�������� varchar(127) PRIMARY KEY NOT NULL,
	�������� varchar(MAX),
	������ int NOT NULL DEFAULT 1,
)

CREATE TABLE ��������� (
	��� int PRIMARY KEY NOT NULL,
	��� varchar(127) NOT NULL,
	������� int NOT NULL UNIQUE,
	������� varchar(127) NOT NULL,
	��������� varchar(127) NOT NULL,
	FOREIGN KEY (���������) REFERENCES ���������
)

CREATE TABLE ����� (
	����� int PRIMARY KEY NOT NULL,
	���� int NOT NULL,
	����� int NOT NULL,
	��� varchar(127) NOT NULL,
	�������� int,
	FOREIGN KEY (���) REFERENCES ����������,
	FOREIGN KEY (��������) REFERENCES ���������
)

CREATE TABLE ������� (
	����� int PRIMARY KEY NOT NULL,
	��� varchar(127) NOT NULL,
	���� int NOT NULL,
	FOREIGN KEY (���) REFERENCES ����������,
	FOREIGN KEY (����) REFERENCES �����
)

CREATE TABLE ����������� (
	��� int PRIMARY KEY NOT NULL,
	��� varchar(127) NOT NULL,
	������� int NOT NULL UNIQUE,
	������� varchar(127) NOT NULL,
	��� varchar(3) NOT NULL,
	������������ date NOT NULL,
	��� varchar(127) NOT NULL,
	������� int NOT NULL,
	FOREIGN KEY (���) REFERENCES ���������������,
	FOREIGN KEY (�������) REFERENCES �������
)



CREATE TABLE ������ (
	����� int PRIMARY KEY NOT NULL,
	���� varchar(127) NOT NULL DEFAULT '��� ����',
	������ varchar(127) NOT NULL DEFAULT '�������',
	������������ date NOT NULL,
	����� varchar(MAX),
	����������� int NOT NULL,
	������������� int,
	FOREIGN KEY (�����������) REFERENCES �����������,
	FOREIGN KEY (�������������) REFERENCES ���������
)

CREATE TABLE ��������� (
	�������� varchar(127) PRIMARY KEY NOT NULL,
	�������� varchar(MAX),
	������������ date NOT NULL,
	��������� int NOT NULL DEFAULT 0,
	������� int NOT NULL,
	FOREIGN KEY (�������) REFERENCES �������,
)

CREATE TABLE ����� (
	��� int PRIMARY KEY NOT NULL,
	��� varchar(127) NOT NULL,
	FOREIGN KEY (���) REFERENCES ��������,
	���������� date NOT NULL,
	������������ int NOT NULL DEFAULT 12,
	������ int,
	FOREIGN KEY (������) REFERENCES ���������
)

use master 
go
use CourseWorkSQL
go
BEGIN TRANSACTION addTables
	CREATE TABLE ТипыПроживающих (
		Название varchar(127) PRIMARY KEY NOT NULL,
		Тариф int NOT NULL
	)
	GO
	CREATE TABLE ТипыКомнат (
		Название varchar(127) PRIMARY KEY NOT NULL,
		КойкоМеста int NOT NULL
	)
	GO
	CREATE TABLE Должности (
		Название varchar(127) PRIMARY KEY NOT NULL,
		Оклад int NOT NULL
	)
	GO
	CREATE TABLE ТипыВахт (
		Название varchar(127) PRIMARY KEY NOT NULL,
		Ставка int NOT NULL
	)
	GO
	CREATE TABLE Работники (
		Код bigint PRIMARY KEY NOT NULL,
		ФИО varchar(127) NOT NULL,
		Телефон varchar(127) NOT NULL,
		Должность varchar(127) NOT NULL,
		FOREIGN KEY (Должность) REFERENCES Должности
	)
	GO
	CREATE TABLE Блоки (
		Номер int PRIMARY KEY NOT NULL,
		Этаж int NOT NULL,
		Крыло int NOT NULL,
		Тип blockType NOT NULL
	)
	GO
	CREATE TABLE Комнаты (
		Номер int PRIMARY KEY NOT NULL,
		Тип varchar(127) NOT NULL,
		Блок int NOT NULL,
		FOREIGN KEY (Тип) REFERENCES ТипыКомнат,
		FOREIGN KEY (Блок) REFERENCES Блоки
	)
	GO
	CREATE TABLE Проживающие (
		Код bigint PRIMARY KEY NOT NULL,
		ФИО varchar(127) NOT NULL,
		Телефон varchar(127) NOT NULL,
		Пол varchar(3) NOT NULL,
		ДатаРождения date NOT NULL,
		Тип varchar(127) NOT NULL,
		Комната int NOT NULL,
		FOREIGN KEY (Тип) REFERENCES ТипыПроживающих,
		FOREIGN KEY (Комната) REFERENCES Комнаты
	)
	GO
	CREATE TABLE Заявки (
	Номер int PRIMARY KEY NOT NULL IDENTITY(1,1),
	Тема varchar(127) NOT NULL,
	Статус statusType NOT NULL,
	ДатаСоздания date NOT NULL default GETDATE(),
	Текст varchar(MAX),
	Составитель bigint NOT NULL,
	FOREIGN KEY (Составитель) REFERENCES Проживающие
	)
	GO
CREATE TABLE Инвентарь (
	Код int PRIMARY KEY NOT NULL IDENTITY(1,1),
	Название varchar(127) NOT NULL,
	ДатаПоставки date NOT NULL default GETDATE(),
	Стоимость int NOT NULL,
	Комната int NOT NULL,
	FOREIGN KEY (Комната) REFERENCES Комнаты,
)
	GO
	CREATE TABLE Вахты (
		Номер int PRIMARY KEY NOT NULL IDENTITY(1,1),
		Тип varchar(127) NOT NULL,
		FOREIGN KEY (Тип) REFERENCES ТипыВахт,
		ДатаНачала date NOT NULL default GETDATE(),
		Длительность int NOT NULL,
		Вахтер bigint,
		FOREIGN KEY (Вахтер) REFERENCES Работники
	)
	GO
	CREATE TABLE Дежурство(
		Блок int PRIMARY KEY NOT NULL,
		Дежурный bigint NOT NULL,
		FOREIGN KEY(Блок) REFERENCES Блоки,
		FOREIGN KEY(Дежурный) REFERENCES Работники
	)
	GO
COMMIT TRANSACTION addTables
use CourseWorkSQL

BEGIN TRAN addRows
INSERT INTO ���������� VALUES
('�����������',2),
('�����������',3),
('���������',0)
Go
INSERT INTO ����� VALUES
(47,4,7,'�������'),
(42,4,2,'�������')
Go
INSERT INTO ������� VALUES
(475, '�����������', 47),
(476, '�����������', 47),
(477, '�����������', 47),
(478, '�����������', 47),
(421, '�����������', 42),
(422, '�����������', 42),
(423, '�����������', 42),
(424, '�����������', 42)
Go
INSERT INTO ��������� VALUES
('���� "�������"', '23.04.2022', 900, 476),
('���� "�������"', '23.04.2022', 900, 476),
('���� "�����������"', '23.04.2022', 2200, 476),
('���� 2200�2000�400', '23.04.2022', 12000, 476),
('���� "�������"', '23.04.2022', 900, 477),
('���� "�������"', '23.04.2022', 900, 477),
('���� "�����������"', '23.04.2022', 2200, 477),
('���� 2200�2000�400', '23.04.2022', 12000, 477),
('����������� "�����"', '01.09.1970', 120, 476)
Go
INSERT INTO ��������������� VALUES
('����� �����',1000),
('����� �������',1000),
('����� ����� ��������',0)
Go
INSERT INTO ����������� VALUES
(2, '����� ���� ��������','8(923)345-54-23','���','25.11.2004','����� �����' ,475)
Go
INSERT INTO ������ VALUES
('������','�������','29.05.2024','��������� ����� ����� � 476 �������',2),
('�����������','�������','22.05.2024','��� ������ ���� ����� ������� � ������� ���� �� 150 ����?',2)
Go
INSERT INTO ��������� VALUES
('������', 19000),
('�������', 17900),
('�������', 32000),
('���������', 26000)
GO
INSERT INTO ��������� VALUES
(1,'�������� ���� ��������','8(955)452-53-22','������'),
(2,'������� ���� �����','8(921)432-77-53','�������'),
(3,'������� ���� ���������','8(677)666-99-69','�������')
GO
INSERT INTO �������� VALUES
('������', 2),
('�������', 1),
('������ � ��������', 3),
('������� � ��������', 2)
Go
INSERT INTO ����� VALUES
('�������','11.05.2024 12:00',12,1),
('�������','12.05.2024 12:00',12,3),
('������','11.05.2024 00:00',12,1)
Go
COMMIT TRAN addRows
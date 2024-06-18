use master
GO
use CW
GO
BEGIN TRAN addRows

INSERT INTO ���������� VALUES
('�������',4),
('����������',1),
('�����������',2),
('�����������',3),
('���������',0)
Go

INSERT INTO ����� VALUES

(12,1,2,'�������'),
(15,1,5,'�������'),
(38,3,8,'�������'),
(46,4,6,'�������'),
(39,3,9,'�������'),
(37,3,7,'���������'),
(41,4,1,'���������'),
(47,4,7,'�������'),
(42,4,2,'�������')
Go

INSERT INTO ������� VALUES
(121, '�����������', 12),
(122, '�����������', 12),
(127, '�����������', 12),
(381, '�����������', 38),
(385, '�����������', 38),
(421, '�����������', 42),
(422, '�����������', 42),
(423, '�����������', 42),
(475, '�����������', 47),
(476, '�����������', 47),
(477, '�����������', 47),
(478, '�����������', 47)
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
('����������� "�����"', '01.09.1970', 120, 476),
('���� "�������"', '23.04.2022', 900, 122),
('���� "�������"', '23.04.2022', 900, 122),
('���� "�����������"', '23.04.2022', 2200, 122),
('���� 2200�2000�400', '23.04.2022', 12000, 122),
('���� "�������"', '23.04.2022', 900, 127),
('���� "�������"', '23.04.2022', 900, 127),
('���� "�����������"', '23.04.2022', 2200, 127),
('���� 2200�2000�400', '23.04.2022', 12000, 127),
('����������� "�����"', '01.09.1970', 120, 127)
Go
INSERT INTO ��������������� VALUES
('����', 800),
('���',3500),
('��� ��������',3500),
('���� ��������', 400),
('��� �����', 2000),
('��� ����� ��������',1000),
('����� �����',1000),
('����� �������',1000),
('����� ����� ��������',0)
Go
INSERT INTO ����������� VALUES
--(2342345676, '����� ���� ��������','8(923)345-14-23','���','25.11.2004','����� �����' ,475),
(1432987567, '�������� ������ ����������','8(961)555-53-53','���','01.01.2003','��� �����' ,477),
(1432376564, '�������� ����� ����������','8(923)362-75-57','���','05.02.2003','��� �����' ,421),
(2342234643, '������ ������� ��������','8(961)124-89-98','���','10.02.2004','����� �����' ,477),
(1432238790, '����� ������ ���������','8(980)876-25-25','���','15.02.2003','����� �����' ,475),
(2342097654, '������� ����� ����������','8(923)323-50-10','���','20.02.2004','����� �����' ,421),
(6744146734, '�������� ������� ���������','8(980)998-05-00','���','25.03.2002','����� �����' ,127),
(6744937856, '������� ����� ���������','8(923)000-50-60','���','30.03.2002','����� �����' ,127),
(2342070775, '������ ������ �������������','8(980)340-88-44','���','5.05.2004','����� �����' ,122),
(6744887065, '���������� ����� �������������','8(923)064-76-34','���','10.05.2002','����' ,422),
(2342057345, '�� �� ���','8(961)356-96-69','���','16.08.2004','����� �����' ,122)
Go
INSERT INTO ������ VALUES
('�����������','�������','01.01.2024','��� ������ ���� ����� ������� � ������� ���� �� 150 ����?',1432238790),
('�����������','�������','22.05.2024','��������� ������ � �����',1432238790),
('�����������','�������','02.01.2024','�������� ������� �����',1432238790),
('������','�������','11.05.2023','������ ��������',6744146734),
('������','�������','22.05.2024','������� ������ � 12 �����',6744146734),
('������','�������','21.05.2024','� 15 ����� ������� �����',6744146734),
('������','�������','12.05.2023','���������� �������� � 127 �������',6744146734),
('������','�������','16.04.2024','������ ������ �������',6744887065),
('������','�������','18.03.2022','����� � 477 �������',1432238790),
('������','�������','22.05.2024','����� ����� �� 476 �������',1432987567),
('������','�������','24.12.2022','����� ����� ������?',2342057345),
('������','�������','22.05.2024','�������� �� ������� � ������',1432238790),
('������','�������','22.08.2024','����� � 12 �����',1432238790),
('������','�������','22.07.2023','����� �� �������',1432238790),
('������','�������','22.11.2024','� ������ � �� ����� � ������?',2342057345)
Go

INSERT INTO ��������� VALUES
('������', 19000),
('�������', 17900),
('�������', 32000),
('���������', 26000)
GO
INSERT INTO ��������� VALUES
(2334555424,'������ ������ ����','8(961)222-11-00','������'),
(1455523423,'�������� ���� ��������','8(955)452-53-22','������'),
(2134134123,'������� ���� �����','8(921)432-77-53','�������'),
(3989456732,'������� ���� ���������','8(920)666-99-69','�������'),
(7788578924,'������� ���� �������','8(955)777-33-77','������'),
(2334976522,'������ ������ ��������','8(900)354-23-89','�������'),
(2134245367,'������ ������� ���������','8(655)877-87-88','�������')
GO
INSERT INTO �������� VALUES
('������', 2),
('�������', 1),
('������ � ��������', 3),
('������� � ��������', 2)
Go
INSERT INTO ����� VALUES
('�������','11.05.2024 12:00',12,2334555424),
('�������','12.05.2024 12:00',12,2334555424),
('������','11.05.2024 00:00',12,1455523423),
('�������','13.05.2024 12:00',12,2334555424),
('������','13.05.2024 00:00',12,1455523423),
('�������','14.05.2024 12:00',12,1455523423),
('������','14.05.2024 00:00',12,7788578924),
('�������','15.05.2024 12:00',12,7788578924),
('������','15.05.2024 00:00',12,1455523423),
('�������','16.05.2024 12:00',12,1455523423),
('������','16.05.2024 00:00',12,7788578924),
('�������','17.05.2024 12:00',12,7788578924),
('������','17.05.2024 00:00',12,1455523423),
('�������','18.05.2024 12:00',12,1455523423),
('������','18.05.2024 00:00',12,7788578924),
('�������','19.05.2024 12:00',12,7788578924),
('������','19.05.2024 00:00',12,1455523423),
('�������','20.05.2024 12:00',12,1455523423),
('������','20.05.2024 00:00',12,2334555424)
Go

INSERT INTO ��������� VALUES
(12,3989456732),
(15,3989456732),
(46,3989456732),
(39,3989456732),
(47,2134245367),
(42,2134245367)

COMMIT TRAN addRows
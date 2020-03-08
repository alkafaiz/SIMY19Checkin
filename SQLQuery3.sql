USE [SImy19]
GO

SELECT [sessionID]
      ,[pesertaID]
      ,[checkin]
      ,[status]
  FROM [dbo].[Checkin]
GO


select * from peserta where not exists (select sessionid from checkin where checkin.pesertaid=peserta.pesertaid and sessionid='regis111') 

insert into checkin (sessionid,pesertaid,status)
values ('regis111','3adbb6c3-e8f0-42f8-b9c4-f64e8eff951d','Expected')

select * from peserta

SELECT peserta.* FROM (select sessionid from checkin where checkin.pesertaid=peserta.pesertaid and sessionid='regis111')
WHERE peserta.nama LIKE '%s%' or peserta.asalnegara like '%ac%'

select checkin.sessionid, session.name,(select count(*) from checkin where status='Expected') as expected,
(select count(*) from checkin where status ='Checked in')as checkedin 
from checkin inner join session on session.sessionid=checkin.sessionid where checkin.sessionid = 'regis111'

select session.sessionid, session.name, 
	(select count(pesertaid) from checkin where checkin.sessionid=session.sessionid and status='Expected') as expected
from session join checkin on session.sessionid=checkin.sessionid group by session.sessionid

select checkin.sessionid, session.name, (select count(checkin.pesertaid) from checkin where status='Expected') as Expected
from checkin join session on checkin.sessionid=session.sessionid group by checkin.sessionid

select checkin.sessionid, 
count(case checkin.status when 'Expected' then 1 else null end) as expected,
session.name
from checkin inner join session on
checkin.sessionid=session.sessionid
group by checkin.sessionid

select session.sessionid, session.name,(select count(*) from checkin where status='Expected') as expected,
(select count(*) from checkin where status ='Checked in')as checkedin 
from checkin join session on session.sessionid=checkin.sessionid 


select * from session
1f68b326-b995-4edc-b3a0-97fdf4180192	CULTURAL NIGHT	DSI	2019-07-12	00:00:00.0000000	00:00:00.0000000	Active
43afb4d9-98f4-4888-9aa7-09ad36bb6f26	SIDANG KOMISI	N24	2019-07-12	00:00:00.0000000	00:00:00.0000000	Active
64356132-6372-444d-bbfc-0437aeb7627d	COACHING	DEWAN SULTAN ISKANDAR	2019-07-11	00:00:00.0000000	00:00:00.0000000	Active
70242f97-e7eb-4fb4-9c0f-8e46334aaa4c	KEDATANGAN	SCHOLARSIN	2019-07-09	00:00:00.0000000	00:00:00.0000000	Active
b2bc9fc3-fcc1-450c-8456-133053064b40	SIDANG INTERNAL	SENAT	2019-11-07	00:00:00.0000000	00:00:00.0000000	Active
c7958635-ea6c-42e0-91ed-8c6e434560a8	OPENING SI	DEWAN SULTAN ISMAIL	2019-07-10	00:00:00.0000000	00:00:00.0000000	Active
fc3241a3-68ef-4491-8788-dc47634b319a	WELCOMING SESSION	DK7	2019-07-09	00:00:00.0000000	00:00:00.0000000	Expired
test001	test	test	2019-12-12	00:00:00.0000000	00:00:00.0000000	Active
select email, nama from peserta where pesertaid='7232ef3c-a21f-49dd-842c-09db24553a19'

select pesertaid from checkin where sessionid='regis111'

select status from checkin where pesertaid='7232ef3c-a21f-49dd-842c-09db24553a19' and sessionid='regis111'

select count(case checkin.status when 'Expected' then 1 else null end), count(case checkin.status when 'Checkedin' then 1 else null end) from checkin where sessionid='regis111'

select checkin.sessionid, checkin.pesertaid,
	peserta.nama, peserta.email, checkin.status
from checkin join peserta 
	on checkin.pesertaid=peserta.pesertaid where peserta.nama like '%ul%' and checkin.sessionid='regis111'

select checkin.sessionid,checkin.pesertaid,peserta.nama, peserta.email, checkin.status from checkin join peserta 
	on checkin.pesertaid=peserta.pesertaid where checkin.sessionid='d8cbd4af-1ad2-40f3-9e33-8807af5d28cc' and (peserta.nama like '%siraju%' 
	or peserta.email like '%uin%' or peserta.university like '%uin%'  )

/* Attendance Data: Opening SI*/
select checkin.pesertaid, peserta.nama, peserta.jenispeserta, peserta.university, checkin.status,checkin.checkin
from checkin inner join peserta on checkin.pesertaid=peserta.pesertaid where sessionid='c7958635-ea6c-42e0-91ed-8c6e434560a8' order by checkin.checkin asc

/* Attendance Data: Welcoming*/
select checkin.checkin, checkin.status, peserta.nama, peserta.jenispeserta, peserta.university 
from checkin inner join peserta on checkin.pesertaid=peserta.pesertaid where sessionid='fc3241a3-68ef-4491-8788-dc47634b319a' order by checkin.checkin asc

/* Attendance Data: SIDANG INTERNAL*/
select checkin.checkin, checkin.status, peserta.nama, peserta.jenispeserta, peserta.university 
from checkin inner join peserta on checkin.pesertaid=peserta.pesertaid where sessionid='b2bc9fc3-fcc1-450c-8456-133053064b40' order by checkin.checkin asc
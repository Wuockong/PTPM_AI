create database LOGIN;
go
use LOGIN;
go

CREATE TABLE Account
(
    Ures VARCHAR(50) PRIMARY KEY,
    Pass VARCHAR(255)
);

INSERT INTO Account VALUES ('admin', '123');

select COUNT(*) from Account where Ures = 'admin' and Pass = '123'
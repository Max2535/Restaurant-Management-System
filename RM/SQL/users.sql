create table users
(
userID int primary key identity,
username varchar(50) not null,
uPass varchar(10) not null,
uName varchar(50) not null,
uPhone varchar(50)
)

INSERT INTO Users (username, uPass, uName, uPhone) VALUES
('johndoe', 'pass1234', 'John Doe', '0812345678'),
('janedoe', 'pass5678', 'Jane Doe', '0823456789'),
('bobjones', 'pass9101', 'Bob Jones', '0834567890'),
('alicebrown', 'pass1213', 'Alice Brown', '0845678901'),
('charliegreen', 'pass1415', 'Charlie Green', '0856789012'),
('emilywhite', 'pass1617', 'Emily White', '0867890123'),
('danielblack', 'pass1819', 'Daniel Black', '0878901234'),
('fionasilver', 'pass2021', 'Fiona Silver', '0889012345'),
('georgegold', 'pass2223', 'George Gold', '0890123456'),
('hannahplatinum', 'pass2425', 'Hannah Platinum', '0801234567');
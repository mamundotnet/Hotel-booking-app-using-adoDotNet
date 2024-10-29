CREATE DATABASE HotelBooking
GO
USE HotelBooking

CREATE TABLE Guests
(
   guestId INT PRIMARY KEY,
   guestName VARCHAR(50) ,
   phone VARCHAR(15) ,
   NID VARCHAR (20),
   birthday DATE ,
)
GO

CREATE TABLE RoomType
(
   typeId INT PRIMARY KEY,
   typeName VARCHAR(20)
)
GO

CREATE TABLE Room
(
   roomNo INT PRIMARY KEY,
   typeId INT REFERENCES RoomType(typeId),
   rent MONEY,
   roomPicture VARBINARY(MAX)
)
GO

CREATE TABLE Booking
(
   bookingId INT PRIMARY KEY,
   guestId INT REFERENCES Guests(guestId),
   roomNo INT REFERENCES Room(roomNo),
   spentDays INT
)
GO


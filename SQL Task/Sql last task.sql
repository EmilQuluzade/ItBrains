--create database Hotel
--use Hotel

---- Create the RoomTypes table
--CREATE TABLE RoomTypes (
--    id INT IDENTITY(1,1) PRIMARY KEY,
--    type_name VARCHAR(255),
--    price DECIMAL(10, 2) -- Added price column
--);

-- Create the Rooms table
-- Create the Customers table
CREATE TABLE Customers (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255)
);

-- Create the RoomTypes table


-- Create the Reservations table
CREATE TABLE Reservations (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255),
    CustomerID INT,
    check_in_date DATE,
    check_out_date DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(id)
);

-- Create the Rooms table
CREATE TABLE Rooms (
    room_id INT IDENTITY(1,1) PRIMARY KEY, -- Added room_id column
    Name VARCHAR(255),
    RoomTypeID INT,
    CustomerID INT NULL,
    ReservationID INT,
    FOREIGN KEY (RoomTypeID) REFERENCES RoomTypes(id),
    FOREIGN KEY (CustomerID) REFERENCES Customers(id),
    FOREIGN KEY (ReservationID) REFERENCES Reservations(id)
);

-- Create the Payments table
CREATE TABLE Payments (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255),
    Reservation INT,
    FOREIGN KEY (Reservation) REFERENCES Reservations(id)
);

ALTER TABLE Payments
ADD amount float;

ALTER TABLE Spendings
ADD amount float;


-- Create the Spendings table
CREATE TABLE Spendings (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255),
    Reservation INT,
    FOREIGN KEY (Reservation) REFERENCES Reservations(id)
);

CREATE VIEW AllCustomerReservations AS
SELECT Customers.Name, Reservations.check_in_date, Reservations.check_out_date
FROM Customers
Inner Join Reservations on Reservations.CustomerID=Customers.id

Create procedure GetRoomDetails @roomID nvarchar(50)
as
select Rooms.room_id , RoomTypes.type_name , RoomTypes.price FROM Rooms
Join RoomTypes on Rooms.RoomTypeID=RoomTypes.ID
where Rooms.Name = @roomID

CREATE FUNCTION CalculateTotalAmount (@customerID nvarchar(50))
RETURNS float
AS
BEGIN
    DECLARE @totalAmount float

  select   @totalAmount=Payments.Amount from Payments inner join Reservations on Reservations.Id=Payments.Reservation where @customerID=Reservations.CustomerId

    RETURN @totalAmount
END

ALTER TABLE Rooms
ADD IsBooked VARCHAR(5);

CREATE TRIGGER UpdateRoomStatusOnReservation
ON Rooms
AFTER INSERT
AS
BEGIN
    UPDATE Rooms
    SET IsBooked = 'true'
    FROM Rooms
    INNER JOIN inserted ON Rooms.room_id = inserted.room_id;
END;



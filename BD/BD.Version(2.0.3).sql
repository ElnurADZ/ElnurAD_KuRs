/*
Created: 03.11.2024
Modified: 17.12.2024
Model: Logical model
Database: MS SQL Server 2019
*/

CREATE DATABASE AUTOMA 
GO
use AUTOMA
go
-- Create tables section -------------------------------------------------

-- Table Department

CREATE TABLE [Department]
(
 [ID_Departament] Int IDENTITY(1, 1) NOT NULL,
 [Name] Char(100) NOT NULL,
 [Adress] Char(100) NOT NULL,
 [Employe_count] Int NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL
)
go

-- Add keys for table Department

ALTER TABLE [Department] ADD CONSTRAINT [Unique_Identifier1] PRIMARY KEY ([ID_Departament])
go

-- Table Clients

CREATE TABLE [Clients]
(
 [ID_Clients] Int IDENTITY(1, 1) NOT NULL,
 [FIO] Char(100) NOT NULL,
 [Phone_number] Char(30) NULL,
 [Email] Char(30) NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [blocked] Bit NULL
)
go

-- Add keys for table Clients

ALTER TABLE [Clients] ADD CONSTRAINT [Unique_Identifier2] PRIMARY KEY ([ID_Clients])
go

-- Table Office

CREATE TABLE [Office]
(
 [ID_Departament] Int NOT NULL,
 [ID_Office] Int IDENTITY(1, 1) NOT NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [Employe_count] Int NULL,
 [Name] Char(100) NOT NULL,
 [Adress] Char(100) NOT NULL,
 [City] Char(100) NOT NULL
)
go

-- Create indexes for table Office

CREATE INDEX [Relationship99] ON [Office] ([ID_Departament])
go

-- Add keys for table Office

ALTER TABLE [Office] ADD CONSTRAINT [Unique_Identifier3] PRIMARY KEY ([ID_Office])
go

-- Table Employee

CREATE TABLE [Employee]
(
 [ID_Office] Int NOT NULL,
 [ID_Emloyee] Int IDENTITY(1, 1) NOT NULL,
 [Post] Char(50) NOT NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [FIO] Char(100) NOT NULL,
 [Phone_number] Char(30) NOT NULL,
 [Parol] nvarchar(20) not null
 )
go

-- Create indexes for table Employee

CREATE INDEX [IX_Relationship33] ON [Employee] ([ID_Office])
go

-- Add keys for table Employee

ALTER TABLE [Employee] ADD CONSTRAINT [Unique_Identifier4] PRIMARY KEY ([ID_Emloyee])
go

-- Table Feedback

CREATE TABLE [Feedback]
(
 [ID_Clients] Int NULL,
 [ID_Feedback] Int IDENTITY(1, 1) NOT NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [Text] Char(1000) NOT NULL,
 [Recommendation] Bit NOT NULL
)
go

-- Create indexes for table Feedback

CREATE INDEX [Relationship98] ON [Feedback] ([ID_Clients])
go

-- Add keys for table Feedback

ALTER TABLE [Feedback] ADD CONSTRAINT [Unique_Identifier5] PRIMARY KEY ([ID_Feedback])
go

-- Table Office_capital

CREATE TABLE [Office_capital]
(
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [Old_Capital] float NOT NULL,
 [New_capital] float NOT NULL,
 [ID_Office_capital] Int IDENTITY(1, 1) NOT NULL,
 [ID_Office] Int NULL
)
go

-- Create indexes for table Office_capital

CREATE INDEX [IX_Relationship47] ON [Office_capital] ([ID_Office])
go

-- Add keys for table Office_capital

ALTER TABLE [Office_capital] ADD CONSTRAINT [Unique_Identifier6] PRIMARY KEY ([ID_Office_capital])
go

-- Table Method_connection

CREATE TABLE [Method_connection]
(
 [ID_Office] Int NOT NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [Phone_number] Char(30) NOT NULL,
 [Email] Char(50) NOT NULL,
 [VK] Char(100) NULL,
 [Instagram] Char(100) NULL,
 [Facebook] Char(100) NULL
)
go

-- Add keys for table Method_connection

ALTER TABLE [Method_connection] ADD CONSTRAINT [Unique_Identifier87] PRIMARY KEY ([ID_Office])
go

-- Table Order_Clients

CREATE TABLE [Order_Clients]
(
 [ID_Clients] Int NOT NULL,
 [ID_Office] Int NOT NULL,
 [ID_Order_Clients] Int IDENTITY(1, 1) NOT NULL,
 [Text] Char(1000) NOT NULL,
 [Term] Date NOT NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [Convenient_price] float NOT NULL,
 [Paid] Bit NULL,
 [Wish] Char(100) NULL
)
go

-- Create indexes for table Order_Clients

CREATE INDEX [IX_Relationship36] ON [Order_Clients] ([ID_Clients])
go

CREATE INDEX [IX_Relationship37] ON [Order_Clients] ([ID_Office])
go

-- Add keys for table Order_Clients

ALTER TABLE [Order_Clients] ADD CONSTRAINT [Unique_Identifier7] PRIMARY KEY ([ID_Order_Clients])
go

-- Table Payments_Clients

CREATE TABLE [Payments_Clients]
(
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [Price] float NOT NULL,
 [Description] Char(1000) NOT NULL,
 [ID_Order_Clients] Int NOT NULL,
 [ID_Clients] Int NOT NULL
)
go

-- Create indexes for table Payments_Clients

CREATE INDEX [IX_Relationship43] ON [Payments_Clients] ([ID_Order_Clients])
go

-- Add keys for table Payments_Clients

ALTER TABLE [Payments_Clients] ADD CONSTRAINT [Unique_Identifier8] PRIMARY KEY ([ID_Order_Clients])
go

-- Table Report_Clients

CREATE TABLE [Report_Clients]
(
 [ID_Order_Clients] Int NOT NULL,
 [ID_Feedback] Int NULL,
 [ID_Report_Client] Int IDENTITY(1, 1) NOT NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [ID_Office_capital] Int NULL,
 [ID_Office] Int NULL
)
go

-- Create indexes for table Report_Clients

CREATE INDEX [IX_Relationship29] ON [Report_Clients] ([ID_Order_Clients])
go

CREATE INDEX [IX_Relationship42] ON [Report_Clients] ([ID_Feedback])
go

CREATE INDEX [IX_Relationship49] ON [Report_Clients] ([ID_Office_capital])
go

CREATE INDEX [IX_Relationship50] ON [Report_Clients] ([ID_Office])
go

-- Add keys for table Report_Clients

ALTER TABLE [Report_Clients] ADD CONSTRAINT [Unique_Identifier9] PRIMARY KEY ([ID_Report_Client])
go

-- Table ADS

CREATE TABLE [ADS]
(
 [ID_ADS] Int IDENTITY(1, 1) NOT NULL,
 [Type_ADS] Char(100) NOT NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL
)
go

-- Add keys for table ADS

ALTER TABLE [ADS] ADD CONSTRAINT [Unique_Identifier50] PRIMARY KEY ([ID_ADS])
go

-- Table Salary

CREATE TABLE [Salary]
(
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [Money] float NOT NULL,
 [Year] Int NOT NULL,
 [Month] Int NOT NULL,
 [ID_Salary] Int IDENTITY(1, 1) NOT NULL,
 [ID_Emloyee] Int NULL
)
go

-- Create indexes for table Salary

CREATE INDEX [IX_Relationship46] ON [Salary] ([ID_Emloyee])
go

-- Add keys for table Salary

ALTER TABLE [Salary] ADD CONSTRAINT [Unique_Identifier60] PRIMARY KEY ([ID_Salary])
go

-- Table Vacations

CREATE TABLE [Vacations]
(
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [Year] Int NOT NULL,
 [Remain] Int NOT NULL,
 [Used] Int NOT NULL,
 [Beginning_Vacations] Date NOT NULL,
 [End_Vacations] Date NOT NULL,
 [ID_Vacations] Int IDENTITY(1, 1) NOT NULL,
 [ID_Emloyee] Int NULL
)
go

-- Create indexes for table Vacations

CREATE INDEX [IX_Relationship45] ON [Vacations] ([ID_Emloyee])
go

-- Add keys for table Vacations

ALTER TABLE [Vacations] ADD CONSTRAINT [Unique_Identifier70] PRIMARY KEY ([ID_Vacations])
go

-- Table Office_ADS

CREATE TABLE [Office_ADS]
(
 [ID_Office] Int NOT NULL,
 [ID_ADS] Int NOT NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [Adress] Char(100) NOT NULL,
 [ADS_Coordinates] Nvarchar(30) NULL,
 [ID_ADS_Office] Int IDENTITY(1, 1) NOT NULL
)
go
-- Add keys for table Office_ADS

ALTER TABLE [Office_ADS] ADD CONSTRAINT [Unique_Identifier76] PRIMARY KEY ([ID_ADS_Office])
go

-- Create indexes for table Office_ADS

CREATE INDEX [IX_Relationship30_Office] ON [Office_ADS] ([ID_Office])
go

CREATE INDEX [IX_Relationship30_ADS] ON [Office_ADS] ([ID_ADS])
go

-- Table Office/Partners

CREATE TABLE [Office/Partners]
(
 [ID_Office] Int NOT NULL,
 [ID_Partners] Int NOT NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL
)
go

-- Add keys for table Office/Partners

ALTER TABLE [Office/Partners] ADD CONSTRAINT [PK_Office/Partners] PRIMARY KEY ([ID_Office],[ID_Partners])
go

-- Table Partners

CREATE TABLE [Partners]
(
 [ID_Partners] Int IDENTITY(1, 1) NOT NULL,
 [Name_Company] Char(100) NOT NULL,
 [Created_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Updated_at] Datetime default CURRENT_TIMESTAMP NOT NULL,
 [Deleted_at] Datetime NULL,
 [Phone_number] Char(30) NULL,
 [Email] Char(50) NULL,
 [Company_activity] Char(1000) NULL
)
go

-- Add keys for table Partners

ALTER TABLE [Partners] ADD CONSTRAINT [PK_Partners] PRIMARY KEY ([ID_Partners])
go

-- Create foreign keys (relationships) section ------------------------------------------------- 


ALTER TABLE [Method_connection] ADD CONSTRAINT [Relationship87] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Office] ADD CONSTRAINT [Relationship99] FOREIGN KEY ([ID_Departament]) REFERENCES [Department] ([ID_Departament]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Feedback] ADD CONSTRAINT [Relationship98] FOREIGN KEY ([ID_Clients]) REFERENCES [Clients] ([ID_Clients]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Office_ADS] ADD CONSTRAINT [Relationship74] FOREIGN KEY ([ID_ADS]) REFERENCES [ADS] ([ID_ADS]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Office_ADS] ADD CONSTRAINT [Relationship76] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Report_Clients] ADD CONSTRAINT [Relationship29] FOREIGN KEY ([ID_Order_Clients]) REFERENCES [Order_Clients] ([ID_Order_Clients]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Employee] ADD CONSTRAINT [Relationship33] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Order_Clients] ADD CONSTRAINT [Relationship36] FOREIGN KEY ([ID_Clients]) REFERENCES [Clients] ([ID_Clients]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Order_Clients] ADD CONSTRAINT [Relationship37] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Office/Partners] ADD CONSTRAINT [Relationship40] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Office/Partners] ADD CONSTRAINT [Relationship41] FOREIGN KEY ([ID_Partners]) REFERENCES [Partners] ([ID_Partners]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Report_Clients] ADD CONSTRAINT [Relationship42] FOREIGN KEY ([ID_Feedback]) REFERENCES [Feedback] ([ID_Feedback]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Payments_Clients] ADD CONSTRAINT [Relationship43] FOREIGN KEY ([ID_Order_Clients]) REFERENCES [Order_Clients] ([ID_Order_Clients]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Vacations] ADD CONSTRAINT [Relationship45] FOREIGN KEY ([ID_Emloyee]) REFERENCES [Employee] ([ID_Emloyee]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Salary] ADD CONSTRAINT [Relationship46] FOREIGN KEY ([ID_Emloyee]) REFERENCES [Employee] ([ID_Emloyee]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Office_capital] ADD CONSTRAINT [Relationship47] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Report_Clients] ADD CONSTRAINT [Relationship49] FOREIGN KEY ([ID_Office_capital]) REFERENCES [Office_capital] ([ID_Office_capital]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Report_Clients] ADD CONSTRAINT [Relationship50] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go







/*
Created: 03.11.2024
Modified: 04.11.2024
Model: Logical model
Database: MS SQL Server 2019
*/



-- Create tables section -------------------------------------------------

-- Table Department

CREATE TABLE [Department]
(
 [ID_Departament] Int NOT NULL,
 [Name] Char(100) NOT NULL,
 [Adress] Char(100) NOT NULL,
 [Employe_count] Int NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL
)
go

-- Add keys for table Department

ALTER TABLE [Department] ADD CONSTRAINT [Unique_Identifier1] PRIMARY KEY ([ID_Departament])
go

-- Table Clients

CREATE TABLE [Clients]
(
 [ID_Clients] Int NOT NULL,
 [FIO] Char(100) NOT NULL,
 [Phone_number] Char(30) NULL,
 [Email] Char(30) NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
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
 [ID_Office] Int NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Employe_count] Int NULL,
 [Name] Char(100) NOT NULL,
 [Adress] Char(100) NOT NULL,
 [City] Char(100) NOT NULL
)
go

-- Create indexes for table Office

CREATE INDEX [IX_имеет] ON [Office] ([ID_Departament])
go

-- Add keys for table Office

ALTER TABLE [Office] ADD CONSTRAINT [Unique_Identifier3] PRIMARY KEY ([ID_Office])
go

-- Table Company

CREATE TABLE [Company]
(
 [ID_Company] Int NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Phone_number] Char(30) NOT NULL,
 [Email] Char(50) NOT NULL,
 [Name] Char(100) NULL,
 [Activity] Char(1000) NOT NULL,
 [Characteristic] Char(1000) NOT NULL
)
go

-- Add keys for table Company

ALTER TABLE [Company] ADD CONSTRAINT [Unique_Identifier4] PRIMARY KEY ([ID_Company])
go

-- Table Employee

CREATE TABLE [Employee]
(
 [ID_Office] Int NOT NULL,
 [ID_Emloyee] Int NOT NULL,
 [Post] Char(50) NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [FIO] Char(100) NOT NULL,
 [Phone_number] Char(30) NOT NULL
)
go

-- Create indexes for table Employee

CREATE INDEX [IX_Relationship33] ON [Employee] ([ID_Office])
go

-- Add keys for table Employee

ALTER TABLE [Employee] ADD CONSTRAINT [Unique_Identifier5] PRIMARY KEY ([ID_Emloyee])
go

-- Table Payments

CREATE TABLE [Payments]
(
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Price] Money NOT NULL,
 [Paid] Bit NOT NULL,
 [Description] Char(1000) NOT NULL,
 [ID_Orders] Int NOT NULL
)
go

-- Add keys for table Payments

ALTER TABLE [Payments] ADD CONSTRAINT [Unique_Identifier6] PRIMARY KEY ([ID_Orders])
go

-- Table Feedback

CREATE TABLE [Feedback]
(
 [ID_Company] Int NULL,
 [ID_Clients] Int NULL,
 [ID_Feedback] Int NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Text] Char(1000) NOT NULL,
 [Recommendation] Bit NOT NULL
)
go

-- Create indexes for table Feedback

CREATE INDEX [IX_Пишет_ОТЗ] ON [Feedback] ([ID_Company])
go

CREATE INDEX [IX_Пишет_От] ON [Feedback] ([ID_Clients])
go

-- Add keys for table Feedback

ALTER TABLE [Feedback] ADD CONSTRAINT [Unique_Identifier7] PRIMARY KEY ([ID_Feedback])
go

-- Table Office_capital

CREATE TABLE [Office_capital]
(
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Old_Capital] Money NOT NULL,
 [New_capital] Money NOT NULL,
 [ID_Office_capital] Int NOT NULL,
 [ID_Office] Int NULL
)
go

-- Create indexes for table Office_capital

CREATE INDEX [IX_Relationship47] ON [Office_capital] ([ID_Office])
go

-- Add keys for table Office_capital

ALTER TABLE [Office_capital] ADD CONSTRAINT [Unique_Identifier8] PRIMARY KEY ([ID_Office_capital])
go

-- Table Reports

CREATE TABLE [Reports]
(
 [ID_Orders] Int NOT NULL,
 [ID_Report] Int NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Descripttion] Char(1000) NOT NULL,
 [ID_Office_capital] Int NULL,
 [ID_Feedback] Int NULL,
 [ID_Office] Int NULL
)
go

-- Create indexes for table Reports

CREATE INDEX [IX_Relationship26] ON [Reports] ([ID_Orders])
go

CREATE INDEX [IX_Relationship28] ON [Reports] ([ID_Office_capital])
go

CREATE INDEX [IX_Relationship48] ON [Reports] ([ID_Feedback])
go

CREATE INDEX [IX_Relationship51] ON [Reports] ([ID_Office])
go

-- Add keys for table Reports

ALTER TABLE [Reports] ADD CONSTRAINT [Unique_Identifier9] PRIMARY KEY ([ID_Report])
go

-- Table Method_connection

CREATE TABLE [Method_connection]
(
 [ID_Office] Int NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Phone_number] Char(30) NOT NULL,
 [Email] Char(50) NOT NULL,
 [VK] Char(100) NULL,
 [Instagram] Char(100) NULL,
 [Facebook] Char(100) NULL
)
go

-- Add keys for table Method_connection

ALTER TABLE [Method_connection] ADD CONSTRAINT [Unique_Identifier10] PRIMARY KEY ([ID_Office])
go

-- Table Orders

CREATE TABLE [Orders]
(
 [ID_Orders] Int NOT NULL,
 [ID_Office] Int NULL,
 [ID_Company] Int NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Term] Date NOT NULL,
 [Text] Char(5000) NOT NULL,
 [Convenient_price] Money NOT NULL,
 [Wish] Char(1000) NULL
)
go

-- Create indexes for table Orders

CREATE INDEX [IX_Relationship34] ON [Orders] ([ID_Office])
go

CREATE INDEX [IX_Relationship35] ON [Orders] ([ID_Company])
go

-- Add keys for table Orders

ALTER TABLE [Orders] ADD CONSTRAINT [Unique_Identifier11] PRIMARY KEY ([ID_Orders])
go

-- Table Order_Clients

CREATE TABLE [Order_Clients]
(
 [ID_Clients] Int NOT NULL,
 [ID_Office] Int NOT NULL,
 [ID_Order_Clients] Int NOT NULL,
 [Text] Char(5000) NOT NULL,
 [Term] Date NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Convenient_price] Money NOT NULL,
 [wish] Char(100) NULL
)
go

-- Create indexes for table Order_Clients

CREATE INDEX [IX_Relationship36] ON [Order_Clients] ([ID_Clients])
go

CREATE INDEX [IX_Relationship37] ON [Order_Clients] ([ID_Office])
go

-- Add keys for table Order_Clients

ALTER TABLE [Order_Clients] ADD CONSTRAINT [Unique_Identifier12] PRIMARY KEY ([ID_Order_Clients])
go

-- Table Payments_Clients

CREATE TABLE [Payments_Clients]
(
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Price] Money NOT NULL,
 [Paid] Bit NOT NULL,
 [Description] Char(1000) NOT NULL,
 [ID_Order_Clients] Int NOT NULL
)
go

-- Add keys for table Payments_Clients

ALTER TABLE [Payments_Clients] ADD CONSTRAINT [Unique_Identifier13] PRIMARY KEY ([ID_Order_Clients])
go

-- Table Report_Clients

CREATE TABLE [Report_Clients]
(
 [ID_Order_Clients] Int NOT NULL,
 [ID_Feedback] Int NULL,
 [ID_Report_Client] Int NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Description] Datetime NOT NULL,
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

ALTER TABLE [Report_Clients] ADD CONSTRAINT [Unique_Identifier14] PRIMARY KEY ([ID_Report_Client])
go

-- Table ADS

CREATE TABLE [ADS]
(
 [ID_ADS] Int NOT NULL,
 [Type_ADS] Char(100) NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL
)
go

-- Add keys for table ADS

ALTER TABLE [ADS] ADD CONSTRAINT [Unique_Identifier15] PRIMARY KEY ([ID_ADS])
go

-- Table Salary

CREATE TABLE [Salary]
(
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Money] Money NOT NULL,
 [Year] Int NOT NULL,
 [ID_Salary] Int NOT NULL,
 [ID_Emloyee] Int NULL
)
go

-- Create indexes for table Salary

CREATE INDEX [IX_Relationship46] ON [Salary] ([ID_Emloyee])
go

-- Add keys for table Salary

ALTER TABLE [Salary] ADD CONSTRAINT [Unique_Identifier16] PRIMARY KEY ([ID_Salary])
go

-- Table Vacations

CREATE TABLE [Vacations]
(
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Year] Int NOT NULL,
 [Remain] Int NOT NULL,
 [Used] Int NOT NULL,
 [Beginning_Vacations] Datetime NOT NULL,
 [End_Vacations] Datetime NOT NULL,
 [ID_Vacations] Int NOT NULL,
 [ID_Emloyee] Int NULL
)
go

-- Create indexes for table Vacations

CREATE INDEX [IX_Relationship45] ON [Vacations] ([ID_Emloyee])
go

-- Add keys for table Vacations

ALTER TABLE [Vacations] ADD CONSTRAINT [Unique_Identifier17] PRIMARY KEY ([ID_Vacations])
go

-- Table Office_ADS

CREATE TABLE [Office_ADS]
(
 [ID_Office] Int NOT NULL,
 [ID_ADS] Int NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [Adress] Char(100) NOT NULL
)
go

-- Table Office/Partners

CREATE TABLE [Office/Partners]
(
 [ID_Office] Int NOT NULL,
 [ID_Partners] Int NOT NULL
)
go

-- Add keys for table Office/Partners

ALTER TABLE [Office/Partners] ADD CONSTRAINT [PK_Office/Partners] PRIMARY KEY ([ID_Office],[ID_Partners])
go

-- Table Partners

CREATE TABLE [Partners]
(
 [ID_Partners] Int NOT NULL,
 [Name_Company] Char(100) NOT NULL,
 [Created_at] Datetime NOT NULL,
 [Updated_at] Datetime NOT NULL,
 [Deleted_at] Datetime NULL,
 [phone_number] Char(30) NULL,
 [Email] Char(50) NULL,
 [Company_activity] Char(1000) NULL
)
go

-- Add keys for table Partners

ALTER TABLE [Partners] ADD CONSTRAINT [PK_Partners] PRIMARY KEY ([ID_Partners])
go

-- Create foreign keys (relationships) section ------------------------------------------------- 


ALTER TABLE [Method_connection] ADD CONSTRAINT [Содержит] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Feedback] ADD CONSTRAINT [Пишет_ОТЗ] FOREIGN KEY ([ID_Company]) REFERENCES [Company] ([ID_Company]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Office] ADD CONSTRAINT [имеет] FOREIGN KEY ([ID_Departament]) REFERENCES [Department] ([ID_Departament]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Feedback] ADD CONSTRAINT [Пишет_От] FOREIGN KEY ([ID_Clients]) REFERENCES [Clients] ([ID_Clients]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Reports] ADD CONSTRAINT [Relationship26] FOREIGN KEY ([ID_Orders]) REFERENCES [Orders] ([ID_Orders]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Reports] ADD CONSTRAINT [Relationship28] FOREIGN KEY ([ID_Office_capital]) REFERENCES [Office_capital] ([ID_Office_capital]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Report_Clients] ADD CONSTRAINT [Relationship29] FOREIGN KEY ([ID_Order_Clients]) REFERENCES [Order_Clients] ([ID_Order_Clients]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Employee] ADD CONSTRAINT [Relationship33] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Orders] ADD CONSTRAINT [Relationship34] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Orders] ADD CONSTRAINT [Relationship35] FOREIGN KEY ([ID_Company]) REFERENCES [Company] ([ID_Company]) ON UPDATE NO ACTION ON DELETE NO ACTION
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



ALTER TABLE [Payments] ADD CONSTRAINT [Relationship44] FOREIGN KEY ([ID_Orders]) REFERENCES [Orders] ([ID_Orders]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Vacations] ADD CONSTRAINT [Relationship45] FOREIGN KEY ([ID_Emloyee]) REFERENCES [Employee] ([ID_Emloyee]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Salary] ADD CONSTRAINT [Relationship46] FOREIGN KEY ([ID_Emloyee]) REFERENCES [Employee] ([ID_Emloyee]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Office_capital] ADD CONSTRAINT [Relationship47] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Reports] ADD CONSTRAINT [Relationship48] FOREIGN KEY ([ID_Feedback]) REFERENCES [Feedback] ([ID_Feedback]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Report_Clients] ADD CONSTRAINT [Relationship49] FOREIGN KEY ([ID_Office_capital]) REFERENCES [Office_capital] ([ID_Office_capital]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Report_Clients] ADD CONSTRAINT [Relationship50] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Reports] ADD CONSTRAINT [Relationship51] FOREIGN KEY ([ID_Office]) REFERENCES [Office] ([ID_Office]) ON UPDATE NO ACTION ON DELETE NO ACTION
go







CREATE TABLE [dbo].[User]
(
    [UserID] BIGINT PRIMARY KEY IDENTITY(1,1),
    [FirstName] NVARCHAR(255) NOT NULL,
    [LastName] NVARCHAR(255) NOT NULL,
    [PrimaryPhone] NVARCHAR(20),
    [Email] NVARCHAR(255) NOT NULL,
    [Country] NVARCHAR(255),
    [Password] NVARCHAR(255) NOT NULL,
    [LastLoggedIn] DATETIME,
    [PasswordAttempts] INT CHECK (PasswordAttempts >= 0 AND PasswordAttempts <= 5), 
    [IsLocked] BIT,
    [LockedTime] DATETIME
);

-- Role Table
CREATE TABLE [dbo].[Role]
(
    [RoleID] INT PRIMARY KEY IDENTITY(1,1),
    [RoleName] NVARCHAR(255) NOT NULL
);

-- UserRole Table
CREATE TABLE [dbo].[UserRole]
(
    [UserRoleID] INT PRIMARY KEY IDENTITY(1,1),
    [UserID] INT FOREIGN KEY REFERENCES [dbo].[User]([UserID]),
    [RoleID] INT FOREIGN KEY REFERENCES [dbo].[Role]([RoleID])
);

-- Case Table
CREATE TABLE [dbo].[Case]
(
    [CaseID] INT PRIMARY KEY IDENTITY(1,1),
    [CaseName] NVARCHAR(255) NOT NULL,
    [Description] NVARCHAR(MAX),
    [AssignedAttorneyID] INT FOREIGN KEY REFERENCES [dbo].[User]([UserID]),
    [Status] NVARCHAR(50) NOT NULL,
    [Progress] INT
);

-- Document Table
CREATE TABLE [dbo].[Document]
(
    [DocumentID] INT PRIMARY KEY IDENTITY(1,1),
    [CaseID] INT FOREIGN KEY REFERENCES [dbo].[Case]([CaseID]),
    [DocumentName] NVARCHAR(255) NOT NULL,
    [FilePath] NVARCHAR(MAX),
    [UploadDate] DATETIME
);

-- Task Table
CREATE TABLE [dbo].[Task]
(
    [TaskID] INT PRIMARY KEY IDENTITY(1,1),
    [CaseID] INT FOREIGN KEY REFERENCES [dbo].[Case]([CaseID]),
    [Description] NVARCHAR(MAX),
    [AssignedTo] INT FOREIGN KEY REFERENCES [dbo].[User]([UserID]),
    [Deadline] DATETIME,
    [Status] NVARCHAR(50) NOT NULL CHECK ([Status] IN ('Not Started', 'In Progress', 'Completed'))
);
-- Permissions Table
CREATE TABLE [dbo].[Permissions]
(
    [PermissionID] INT PRIMARY KEY IDENTITY(1,1),
    [PermissionName] NVARCHAR(255) NOT NULL
);

-- RolePermissions Table
CREATE TABLE [dbo].[RolePermissions]
(
    [RolePermissionID] INT PRIMARY KEY IDENTITY(1,1),
    [RoleID] INT FOREIGN KEY REFERENCES [dbo].[Role]([RoleID]),
    [PermissionID] INT FOREIGN KEY REFERENCES [dbo].[Permissions]([PermissionID])
);

-- Insert data into Role table
INSERT INTO [dbo].[Role] ([RoleName]) VALUES ('Admin');
INSERT INTO [dbo].[Role] ([RoleName]) VALUES ('Attorney');
INSERT INTO [dbo].[Role] ([RoleName]) VALUES ('User');

-- Insert data into Permissions table
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('CreateCase');
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('UpdateCase');
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('AssignCase');
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('TrackCaseStatus');
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('UploadDocument');
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('ViewDocument');
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('DownloadDocument');
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('CreateTask');
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('AssignTask');
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('TrackTaskStatus');
INSERT INTO [dbo].[Permissions] ([PermissionName]) VALUES ('CreateCase');

-- Insert data into User table
INSERT INTO [dbo].[User] ([FirstName], [LastName], [PrimaryPhone], [Email], [Country], [Password], [LastLoggedIn], [PasswordAttempts], [IsLocked], [LockedTime])
VALUES ('John', 'Doe', '123456789', 'john.doe@example.com', 'USA', 'hashedpassword', GETDATE(), 0, 0, NULL);

-- Insert data into UserRole table
INSERT INTO [dbo].[UserRole] ([UserID], [RoleID]) VALUES (1, 1); -- John Doe is an Admin

-- Insert data into Case table
INSERT INTO [dbo].[Case] ([CaseName], [Description], [AssignedAttorneyID], [Status], [Progress])
VALUES ('Case 1', 'This is the description for Case 1. It involves a legal matter that requires careful attention and resolution. The assigned attorney is expected to handle various aspects of the case.', 1, 'Open', 25);


-- Insert data into Document table
INSERT INTO [dbo].[Document] ([CaseID], [DocumentName], [FilePath], [UploadDate])
VALUES (1, 'Document 1', 'C:\Path\To\Document1.pdf', GETDATE());

-- Insert data into Task table
INSERT INTO [dbo].[Task] ([CaseID], [Description], [AssignedTo], [Deadline], [Status])
VALUES (1, 'Task 1', 1, '2023-12-31', 'Not Started');

-- Insert data into RolePermissions table
INSERT INTO [dbo].[RolePermissions] ([RoleID], [PermissionID]) VALUES (1, 1); -- Admin has CreateCase permission
INSERT INTO [dbo].[RolePermissions] ([RoleID], [PermissionID]) VALUES (1, 2); -- Admin has UpdateCase permission
INSERT INTO [dbo].[RolePermissions] ([RoleID], [PermissionID]) VALUES (1, 3); -- Admin has AssignCase permission

-- Insert more data into Case table
INSERT INTO [dbo].[Case] ([CaseName], [Description], [AssignedAttorneyID], [Status], [Progress])
VALUES ('Case 2', 'Case 2 involves a contractual dispute between two parties. The assigned attorney is responsible for reviewing the contracts, gathering evidence, and representing the client in negotiations.', 2, 'In Progress', 50);

INSERT INTO [dbo].[Case] ([CaseName], [Description], [AssignedAttorneyID], [Status], [Progress])
VALUES ('Case 3', Case 3 has been successfully resolved. It was a real estate transaction dispute that required legal intervention. The attorney managed negotiations and legal proceedings, resulting in a favorable outcome for the client.', 3, 'Closed', 100);

-- Insert more data into Task table
INSERT INTO [dbo].[Task] ([CaseID], [Description], [AssignedTo], [Deadline], [Status])
VALUES (2, 'Task 2A', 2, '2023-12-15', 'In Progress');

INSERT INTO [dbo].[Task] ([CaseID], [Description], [AssignedTo], [Deadline], [Status])
VALUES (2, 'Task 2B', 3, '2023-12-20', 'Not Started');

INSERT INTO [dbo].[Task] ([CaseID], [Description], [AssignedTo], [Deadline], [Status])
VALUES (3, 'Task 3A', 1, '2023-12-25', 'Completed');

INSERT INTO [dbo].[Task] ([CaseID], [Description], [AssignedTo], [Deadline], [Status])
VALUES (3, 'Task 3B', 2, '2023-12-30', 'Completed');

INSERT INTO [dbo].[Case] ([CaseName], [Description], [AssignedAttorneyID], [Status], [Progress])
VALUES ('Case 4', 'A family law case involving child custody and support matters. The assigned attorney is working closely with the client to navigate the legal complexities and reach a fair resolution.', 2, 'Open', 30);

INSERT INTO [dbo].[Case] ([CaseName], [Description], [AssignedAttorneyID], [Status], [Progress])
VALUES ('Case 5', 'A criminal defense case where the client is facing charges related to white-collar crime. The defense attorney is building a strong legal strategy to protect the client\'s rights and achieve the best possible outcome.', 3, 'In Progress', 60);

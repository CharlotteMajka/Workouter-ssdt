CREATE TABLE [dbo].[WorkoutTypes]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Name] NVARCHAR(100)
);
INSERT INTO [dbo].[WorkoutTypes] (Name)
VALUES ('Running'), ('Swimming'),('Walking');

CREATE TABLE [dbo].[Jobs] (
    [JobID]          VARCHAR (10)   NOT NULL,
    [JobName]        NVARCHAR (250) NULL,
    [CompanyName]    NVARCHAR (250) NULL,
    [WorkAddress]    NVARCHAR (250) NULL,
    [JobDecription]  TEXT           NULL,
    [WorkDuration]   INT            NULL,
    [Experience]     NVARCHAR (250) NULL,
    [ExpirationDate] DATE           NULL,
    [Benefit]        TEXT           NULL,
    [RequestCdd]     TEXT           NULL,
    [EprID]          VARCHAR (10)   NULL,
    [Salary]         INT           NULL,
    CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED ([JobID] ASC),
    CONSTRAINT [FK_EprID] FOREIGN KEY ([EprID]) REFERENCES [dbo].[Employeers] ([EprID])
);


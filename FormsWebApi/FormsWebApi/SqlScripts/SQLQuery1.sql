CREATE TABLE [dbo].[AuditInfoes] (
    [AuditInfoId] INT            IDENTITY (1, 1) NOT NULL,
    [Time]        DATETIME       NOT NULL,
    [FormId]      INT            NOT NULL,
    [ClientIp]    NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_dbo.AuditInfoes] PRIMARY KEY CLUSTERED ([AuditInfoId] ASC),
    CONSTRAINT [FK_dbo.AuditInfoes_dbo.Forms_FormId] FOREIGN KEY ([FormId]) REFERENCES [dbo].[Forms] ([FormId]) ON DELETE CASCADE
);
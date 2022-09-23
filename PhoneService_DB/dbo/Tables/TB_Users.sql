CREATE TABLE [dbo].[TB_Users] (
    [Email]    VARCHAR (50) NOT NULL,
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NULL,
    [IsAdmin]  BIT          NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC, [Email] ASC)
);


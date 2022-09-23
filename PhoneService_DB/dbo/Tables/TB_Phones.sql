CREATE TABLE [dbo].[TB_Phones] (
    [PhoneID]         INT           IDENTITY (1, 1) NOT NULL,
    [PhoneName]       VARCHAR (20)  NOT NULL,
    [Brand]           VARCHAR (20)  NULL,
    [Price]           INT           NULL,
    [ProductionYear]  INT           NULL,
    [PhoneSpecs]      VARCHAR (100) NULL,
    [PhonesAvailable] INT           NULL,
    CONSTRAINT [PK_TB_Phones] PRIMARY KEY CLUSTERED ([PhoneName] ASC)
);


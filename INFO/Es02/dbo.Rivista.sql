CREATE TABLE [dbo].[Rivista] (
    [id_rivista] INT           IDENTITY (1, 1) NOT NULL,
    [titolo]     NVARCHAR (25) NOT NULL,
    [periodo]    INT           NOT NULL,
    [prezzo]     DECIMAL(4, 2)         NOT NULL DEFAULT 1.50,
    PRIMARY KEY CLUSTERED ([id_rivista] ASC),
    CONSTRAINT [FK_Rivista_Periodo] FOREIGN KEY ([periodo]) REFERENCES [dbo].[Periodi] ([id_periodi]) ON DELETE CASCADE ON UPDATE CASCADE
);


CREATE TABLE [dbo].[TBQuestoes] (
    [Id]         INT NOT NULL IDENTITY,
    [Materia_Id] INT           NOT NULL,
    [Enunciado]  VARCHAR (MAX) NOT NULL,
    [Resposta]    VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_TBQuestoes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBQuestoes_TBMateria] FOREIGN KEY ([Materia_Id]) REFERENCES [dbo].[TBMateria] ([Id])
);


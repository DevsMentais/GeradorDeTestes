CREATE TABLE [dbo].[TBAlternativa] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Letra]      VARCHAR (50)  NOT NULL,
    [Questao_Id] INT           NOT NULL,
    [Resposta]   VARCHAR (300) NOT NULL,
    [Correta]    BIT           NOT NULL,
    CONSTRAINT [PK_TBAlternativa] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBAlternativa_TBQuestoes] FOREIGN KEY ([Questao_Id]) REFERENCES [dbo].[TBQuestoes] ([Id])
);


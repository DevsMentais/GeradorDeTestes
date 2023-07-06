CREATE TABLE [dbo].[TBTESTE_TBQUESTOES] (
    [Questao_id] INT NOT NULL,
    [Teste_id]   INT NOT NULL,
    CONSTRAINT [FK_TBTESTE_TBQUESTOES_TBQuestoes] FOREIGN KEY ([Questao_id]) REFERENCES [dbo].[TBQuestoes] ([Id]),
    CONSTRAINT [FK_TBTESTE_TBQUESTOES_TBTeste] FOREIGN KEY ([Teste_id]) REFERENCES [dbo].[TBTeste] ([Id])
);


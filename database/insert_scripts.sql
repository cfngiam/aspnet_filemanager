USE [AspNetFileManager]
GO

INSERT INTO [dbo].[USER]
           ([Name]
           ,[Email]
           ,[Password]
           ,[IsActive]
           ,[DtUpdate])
     VALUES
           ('Raphael Ivo'
           ,'raphaelivo.net@gmail.com'
           ,'hCGLrfXa5ch3kUE9huO0XcaBzdhCo32hpZFrNXlQNtDmspEF0tAufIbexgNNZSNUaAbBhjMPYqoKV3tTWOPvbw=='
           ,1
           ,getdate())
GO



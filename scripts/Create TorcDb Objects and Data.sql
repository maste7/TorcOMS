USE [TorcDb]
GO

/****** Create Table [dbo].[Products]  ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Create Table [dbo].[Orders]  ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Orders](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[ProductQty] [int] NOT NULL,
	[TotalCost] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO

ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Products]
GO

/**** INSERT PRODUCTS ****/
INSERT INTO [dbo].[Products]([Name], [Price]) VALUES ('Ball', 2.00)
INSERT INTO [dbo].[Products]([Name], [Price]) VALUES ('Hammer', 2.50)
INSERT INTO [dbo].[Products]([Name], [Price]) VALUES ('Drill', 53.20)
INSERT INTO [dbo].[Products]([Name], [Price]) VALUES ('Light', 1.50)
INSERT INTO [dbo].[Products]([Name], [Price]) VALUES ('Hat', 15.00)
GO

INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 1, 4, 8)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 1, 5, 10)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 1, 2, 4)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 1, 7, 14)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 2, 1, 2.5)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 2, 2, 5)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 2, 3, 7.5)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 2, 8, 20)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 3, 1, 53.2)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 3, 14, 744.8)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 3, 22, 1170.4)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 4, 4, 6)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 4, 6, 9)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 4, 17, 25.5)
INSERT INTO [dbo].[Orders]([CustomerId],[ProductId],[ProductQty],[TotalCost]) VALUES(1, 5, 10, 150)
GO
/*
 Navicat Premium Data Transfer

 Source Server         : SQL Local
 Source Server Type    : SQL Server
 Source Server Version : 12002000
 Source Host           : LAPTOP-6F9ISQ9R\SQLEXPRESS:1433
 Source Catalog        : Teste
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 12002000
 File Encoding         : 65001

 Date: 21/03/2023 11:43:03
*/


-- ----------------------------
-- Table structure for Ativos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Ativos]') AND type IN ('U'))
	DROP TABLE [dbo].[Ativos]
GO

CREATE TABLE [dbo].[Ativos] (
  [id] int  NOT NULL,
  [dia] int  NULL,
  [data] datetime  NULL,
  [valor] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [variacaoDia] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [variacaoPrimeiraData] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [nomeAtivo] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Ativos] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Primary Key structure for table Ativos
-- ----------------------------
ALTER TABLE [dbo].[Ativos] ADD CONSTRAINT [PK__Ativos__3213E83F5C19F2F1] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


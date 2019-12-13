CREATE TABLE [dbo].[tb_enterprise_type] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NOT NULL,
    CONSTRAINT [PK_tb_enterprise_type] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[tb_enterprise] (
    [Id]               INT             IDENTITY (1, 1) NOT NULL,
    [Email]            VARCHAR (100)   NULL,
    [Facebook]         VARCHAR (100)   NULL,
    [Twitter]          VARCHAR (100)   NULL,
    [Linkedin]         VARCHAR (100)   NULL,
    [Phone]            VARCHAR (100)   NULL,
    [OwnEnterprise]    BIT             NOT NULL,
    [Name]             VARCHAR (100)   NULL,
    [Photo]            VARCHAR (100)   NULL,
    [Description]      VARCHAR (100)   NULL,
    [City]             VARCHAR (100)   NULL,
    [Country]          VARCHAR (100)   NULL,
    [Value]            INT             NOT NULL,
    [SharePrice]       DECIMAL (18, 2) NOT NULL,
    [EnterpriseTypeId] INT             NOT NULL,
    [OwnShares]        DECIMAL (18, 2) DEFAULT ((0.0)) NOT NULL,
    [Shares]           DECIMAL (18, 2) DEFAULT ((0.0)) NOT NULL,
    CONSTRAINT [PK_tb_enterprise] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tb_enterprise_tb_enterprise_type_EnterpriseTypeId] FOREIGN KEY ([EnterpriseTypeId]) REFERENCES [dbo].[tb_enterprise_type] ([Id]) ON DELETE CASCADE
);

GO
CREATE NONCLUSTERED INDEX [IX_tb_enterprise_EnterpriseTypeId]
    ON [dbo].[tb_enterprise]([EnterpriseTypeId] ASC);


INSERT INTO tb_enterprise_type(Name) VALUES ('Agro');
INSERT INTO tb_enterprise_type(Name) VALUES ('Aviation');
INSERT INTO tb_enterprise_type(Name) VALUES ('Biotech');
INSERT INTO tb_enterprise_type(Name) VALUES ('Eco');
INSERT INTO tb_enterprise_type(Name) VALUES ('Ecommerce');
INSERT INTO tb_enterprise_type(Name) VALUES ('Education');
INSERT INTO tb_enterprise_type(Name) VALUES ('Fashion');
INSERT INTO tb_enterprise_type(Name) VALUES ('Fintech');
INSERT INTO tb_enterprise_type(Name) VALUES ('Food');
INSERT INTO tb_enterprise_type(Name) VALUES ('Games');
INSERT INTO tb_enterprise_type(Name) VALUES ('Health');
INSERT INTO tb_enterprise_type(Name) VALUES ('IOT');
INSERT INTO tb_enterprise_type(Name) VALUES ('Logistics');
INSERT INTO tb_enterprise_type(Name) VALUES ('Media');
INSERT INTO tb_enterprise_type(Name) VALUES ('Mining');
INSERT INTO tb_enterprise_type(Name) VALUES ('Products');
INSERT INTO tb_enterprise_type(Name) VALUES ('Real Estate');
INSERT INTO tb_enterprise_type(Name) VALUES ('Service');
INSERT INTO tb_enterprise_type(Name) VALUES ('Smart City');
INSERT INTO tb_enterprise_type(Name) VALUES ('Social');
INSERT INTO tb_enterprise_type(Name) VALUES ('Software');
INSERT INTO tb_enterprise_type(Name) VALUES ('Technology');
INSERT INTO tb_enterprise_type(Name) VALUES ('Tourism');
INSERT INTO tb_enterprise_type(Name) VALUES ('Transport');

INSERT INTO tb_enterprise (OwnEnterprise, Name, Description, City, Country, Value, SharePrice, EnterpriseTypeId) 
    VALUES ('false', 'AllRide', 'Urbanatika is a socio-environmental company with economic impact, creator of the agro-urban industry', 'Santiago', 'Chile', 0, 5000, 21);

INSERT INTO tb_enterprise (OwnEnterprise, Name, Description, City, Country, Value, SharePrice, EnterpriseTypeId) 
    VALUES ('false', 'Alpaca Samka SpA', 'Alpaca Samka uses alpaca fibres for our “Slow Fashion Project” in association with the Aymaras...', 'Viña del Mar', 'Chile', 0, 5000, 7);
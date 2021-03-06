USE [WebShop]
GO
/****** Object:  Table [dbo].[Kategorije]    Script Date: 15.4.2019. 16:35:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategorije](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[Opis] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KategorijeProizvodi]    Script Date: 15.4.2019. 16:36:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KategorijeProizvodi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProizvodId] [int] NOT NULL,
	[KategorijaId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnici]    Script Date: 15.4.2019. 16:36:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[AdresaDostave] [nvarchar](250) NOT NULL,
	[Kontakt] [varchar](50) NOT NULL,
	[Napomena] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MjereProizvoda]    Script Date: 15.4.2019. 16:36:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MjereProizvoda](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Narudzbe]    Script Date: 15.4.2019. 16:36:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Narudzbe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KorisnikId] [int] NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[DatumKreiranja] [datetime] NOT NULL,
	[DatumVrijemeDostave] [datetime] NOT NULL,
	[JeDostavljeno] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NarudzbeDetalji]    Script Date: 15.4.2019. 16:36:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NarudzbeDetalji](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NarudzbaId] [int] NULL,
	[ProizvodId] [int] NULL,
	[Kolicina] [decimal](18, 2) NOT NULL,
	[JedCijena] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proizvodi]    Script Date: 15.4.2019. 16:36:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvodi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MjeraProizvodaId] [smallint] NOT NULL,
	[VrijemeKreiranja] [datetime] NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
	[Cijena] [decimal](18, 2) NOT NULL,
	[Dostupan] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Korisnici] ON 

INSERT [dbo].[Korisnici] ([Id], [Ime], [Prezime], [Email], [AdresaDostave], [Kontakt], [Napomena]) VALUES (1, N'Marko', N'Mrvic', N'predrag.mrvic@hep.hr', N'jknjoh', N'pkpšpšk', N'pojpoj')
INSERT [dbo].[Korisnici] ([Id], [Ime], [Prezime], [Email], [AdresaDostave], [Kontakt], [Napomena]) VALUES (2, N'Marko', N'Mrvic', N'predrag.mrvic@hep.hr', N'jknjoh', N'pkpšpšk', N'Hakerski napad')
INSERT [dbo].[Korisnici] ([Id], [Ime], [Prezime], [Email], [AdresaDostave], [Kontakt], [Napomena]) VALUES (3, N'Marko', N'Mrvic', N'predrag.mrvic@hep.hr', N'jknjoh', N'pkpšpšk', N'uhuiwd')
SET IDENTITY_INSERT [dbo].[Korisnici] OFF
SET IDENTITY_INSERT [dbo].[MjereProizvoda] ON 

INSERT [dbo].[MjereProizvoda] ([Id], [Naziv]) VALUES (1, N'kg')
INSERT [dbo].[MjereProizvoda] ([Id], [Naziv]) VALUES (2, N'l')
INSERT [dbo].[MjereProizvoda] ([Id], [Naziv]) VALUES (3, N'kom')
INSERT [dbo].[MjereProizvoda] ([Id], [Naziv]) VALUES (4, N'm')
SET IDENTITY_INSERT [dbo].[MjereProizvoda] OFF
SET IDENTITY_INSERT [dbo].[Narudzbe] ON 

INSERT [dbo].[Narudzbe] ([Id], [KorisnikId], [Prezime], [Email], [DatumKreiranja], [DatumVrijemeDostave], [JeDostavljeno]) VALUES (1, 1, N'Mrvic', N'predrag.mrvic@hep.hr', CAST(N'2019-04-15T00:00:00.000' AS DateTime), CAST(N'2019-04-22T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Narudzbe] ([Id], [KorisnikId], [Prezime], [Email], [DatumKreiranja], [DatumVrijemeDostave], [JeDostavljeno]) VALUES (2, 2, N'Mrvic', N'predrag.mrvic@hep.hr', CAST(N'2019-04-15T00:00:00.000' AS DateTime), CAST(N'2019-04-22T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Narudzbe] ([Id], [KorisnikId], [Prezime], [Email], [DatumKreiranja], [DatumVrijemeDostave], [JeDostavljeno]) VALUES (3, 3, N'Mrvic', N'predrag.mrvic@hep.hr', CAST(N'2019-04-15T00:00:00.000' AS DateTime), CAST(N'2019-04-22T00:00:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Narudzbe] OFF
SET IDENTITY_INSERT [dbo].[NarudzbeDetalji] ON 

INSERT [dbo].[NarudzbeDetalji] ([Id], [NarudzbaId], [ProizvodId], [Kolicina], [JedCijena]) VALUES (1, 3, 6, CAST(2.00 AS Decimal(18, 2)), CAST(7.00 AS Decimal(18, 2)))
INSERT [dbo].[NarudzbeDetalji] ([Id], [NarudzbaId], [ProizvodId], [Kolicina], [JedCijena]) VALUES (2, 3, 4, CAST(2.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)))
INSERT [dbo].[NarudzbeDetalji] ([Id], [NarudzbaId], [ProizvodId], [Kolicina], [JedCijena]) VALUES (3, 3, 1, CAST(1.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[NarudzbeDetalji] OFF
SET IDENTITY_INSERT [dbo].[Proizvodi] ON 

INSERT [dbo].[Proizvodi] ([Id], [MjeraProizvodaId], [VrijemeKreiranja], [Naziv], [Cijena], [Dostupan]) VALUES (1, 1, CAST(N'2018-02-01T00:00:00.000' AS DateTime), N'Brasno', CAST(10.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Proizvodi] ([Id], [MjeraProizvodaId], [VrijemeKreiranja], [Naziv], [Cijena], [Dostupan]) VALUES (4, 1, CAST(N'2018-03-03T00:00:00.000' AS DateTime), N'Šecer', CAST(5.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Proizvodi] ([Id], [MjeraProizvodaId], [VrijemeKreiranja], [Naziv], [Cijena], [Dostupan]) VALUES (6, 2, CAST(N'2019-06-05T00:00:00.000' AS DateTime), N'Mlijeko', CAST(7.00 AS Decimal(18, 2)), 0)
SET IDENTITY_INSERT [dbo].[Proizvodi] OFF
ALTER TABLE [dbo].[KategorijeProizvodi]  WITH CHECK ADD FOREIGN KEY([KategorijaId])
REFERENCES [dbo].[Kategorije] ([Id])
GO
ALTER TABLE [dbo].[KategorijeProizvodi]  WITH CHECK ADD FOREIGN KEY([ProizvodId])
REFERENCES [dbo].[Proizvodi] ([Id])
GO
ALTER TABLE [dbo].[Narudzbe]  WITH CHECK ADD FOREIGN KEY([KorisnikId])
REFERENCES [dbo].[Korisnici] ([Id])
GO
ALTER TABLE [dbo].[NarudzbeDetalji]  WITH CHECK ADD FOREIGN KEY([NarudzbaId])
REFERENCES [dbo].[Narudzbe] ([Id])
GO
ALTER TABLE [dbo].[NarudzbeDetalji]  WITH CHECK ADD FOREIGN KEY([ProizvodId])
REFERENCES [dbo].[Proizvodi] ([Id])
GO
ALTER TABLE [dbo].[Proizvodi]  WITH CHECK ADD FOREIGN KEY([MjeraProizvodaId])
REFERENCES [dbo].[MjereProizvoda] ([Id])
GO

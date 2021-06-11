/****** Object:  Table [dbo].[corePermissionRefUser]    Script Date: 04/24/2011 12:20:22 ******/
GO
CREATE TABLE [dbo].[corePermissionRefUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPermission] [int] NULL,
	[idUser] [int] NULL,
 CONSTRAINT [PK_Core_PermissonRefUser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/*SELECT * FROM <foreign_key_table> WHERE <foreign_key_column> 
NOT IN (SELECT <primary_key_column> FROM <primary_key_table>);*/

delete  FROM corePermissionRefUser WHERE corePermissionRefUser.idUser  
NOT IN (SELECT users.id  FROM users);
GO
ALTER TABLE [dbo].[corePermissionRefUser]  WITH CHECK ADD  CONSTRAINT [FK_corePermissionRefUser_users] FOREIGN KEY([idUser])
REFERENCES [dbo].[users] ([id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[corePermissionRefUser] CHECK CONSTRAINT [FK_corePermissionRefUser_users]
GO

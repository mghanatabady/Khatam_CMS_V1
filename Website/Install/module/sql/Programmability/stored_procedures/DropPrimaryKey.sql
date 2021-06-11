CREATE PROCEDURE [dbo].[DropPrimaryKey]
    @tableName Varchar(255)
AS
    /*
       Drop the primary key on @TableName

urlhttp://gen5.info/q/

       Version 1.1
       June 9, 2008
    */

    DECLARE @pkName Varchar(255)

    SET @pkName= (
        SELECT [name] FROM sysobjects
            WHERE [xtype] = 'PK'
            AND [parent_obj] = OBJECT_ID(N'[dbo].['+@tableName+N']')
    )
    DECLARE @dropSql varchar(4000)

    SET @dropSql=
        'ALTER TABLE [dbo].['+@tableName+']
            DROP CONSTRAINT ['+@PkName+']'
    EXEC(@dropSql)
GO
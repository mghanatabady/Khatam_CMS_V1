/****** Object:  StoredProcedure [dbo].[usp_core_getServerControlTitle]    Script Date: 06/12/2011 16:41:57 ****** $write if for alter */ 
CREATE PROCEDURE [dbo].[usp_core_getServerControlTitle]


	@setting_placeholder_title nvarchar(50),
	@setting_section_title nvarchar(50),
	@idLanguage int
	
 AS 

SELECT      Core_ServerControls.title,Core_ServerControlsInstance.id AS idInstance
FROM         Core_ServerControls INNER JOIN
                      Core_ServerControlsInstance ON Core_ServerControls.id = Core_ServerControlsInstance.id_core_serverControl INNER JOIN
                      Core_ServerControlsInstancePlacing ON Core_ServerControlsInstance.id = Core_ServerControlsInstancePlacing.id_core_serverControlInstance INNER JOIN
                      Core_section ON Core_ServerControlsInstancePlacing.id_setting_section = Core_section.id INNER JOIN
                      core_placeholder ON Core_ServerControlsInstancePlacing.id_setting_placeholder = core_placeholder.id
WHERE     (core_placeholder.title = @setting_placeholder_title) AND (Core_section.title = @setting_section_title) AND (Core_ServerControlsInstancePlacing.idLanguage=@idLanguage)

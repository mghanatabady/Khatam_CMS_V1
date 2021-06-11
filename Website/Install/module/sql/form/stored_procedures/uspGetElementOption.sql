CREATE PROCEDURE [dbo].[uspGetElementOption]
@aeo_id [int]
AS
SELECT [aeo_id]
      ,[form_id]
      ,[element_id]
      ,[option_id]
      ,[position]
      ,[option_title]
      ,[option_is_default]
      ,[live]
  FROM [dbo].[fb_element_options]
  where ([aeo_id] = @aeo_id) and (live = 1)








GO

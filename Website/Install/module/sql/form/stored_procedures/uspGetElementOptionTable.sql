CREATE PROCEDURE [dbo].[uspGetElementOptionTable]
@element_id [int]
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
  where (([element_id] = @element_id) and (live = 1)) order by fb_element_options.position








GO

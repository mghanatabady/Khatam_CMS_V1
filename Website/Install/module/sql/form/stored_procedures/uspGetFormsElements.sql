CREATE PROCEDURE [dbo].[uspGetFormsElements]
@form_id [int]
AS
SELECT     element_id, form_id, element_title, element_guidelines, element_size, element_is_required, element_is_unique, element_is_private, element_type, element_position,                        element_default_value, element_constraint, element_total_child FROM         dbo.fb_form_elements WHERE     (form_id = @form_id) order by element_position


GO



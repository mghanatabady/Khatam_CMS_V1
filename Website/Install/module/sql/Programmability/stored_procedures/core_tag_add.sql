CREATE PROCEDURE [dbo].[core_tag_add] @catid int, @tagTitle nvarchar(80)
AS
if @tagTitle <> N'9999999999999999999'
if @tagTitle is not null
begin
DECLARE @r1 int;
if not exists (select * from core_tags where tag_title = @tagTitle)
begin
insert into core_tags (tag_title,[counter]) values (@tagTitle,1)
SET @r1 =  SCOPE_IDENTITY();
insert into core_tag_ref_cat(cat_id,tag_id) values (@catid,@r1) 
end
else
begin 
DECLARE @s1 int;
set @s1 = (select tag_id from core_tags where tag_title=@tagTitle)
if not exists (select * from core_tag_ref_cat where (tag_id=@s1) AND (cat_id=@catid) )
begin
update core_tags set [counter] =  [counter] + 1 where tag_title=@tagTitle
insert into core_tag_ref_cat(cat_id,tag_id) values (@catid,@s1) 
end
end
end


GO

CREATE PROCEDURE [dbo].[core_tags_update] @catid int,
@tag1 nvarchar(80),@tag2 nvarchar(80),@tag3 nvarchar(80),@tag4 nvarchar(80),@tag5 nvarchar(80),
@tag6 nvarchar(80),@tag7 nvarchar(80),@tag8 nvarchar(80),@tag9 nvarchar(80),@tag10 nvarchar(80)
AS
BEGIN TRANSACTION

DECLARE @id_del bigint;

DELETE FROM core_tags
FROM         core_tags INNER JOIN  core_tag_ref_cat ON core_tags.tag_id = core_tag_ref_cat.tag_id
WHERE     (core_tag_ref_cat.cat_id = @catid) AND (core_tags.counter  < 2) AND (core_tags.tag_title <> @tag1) AND (core_tags.tag_title <> @tag2) 
AND (core_tags.tag_title <> @tag3)AND (core_tags.tag_title <> @tag4)AND (core_tags.tag_title <> @tag5)
AND (core_tags.tag_title <> @tag6)AND (core_tags.tag_title <> @tag7)AND (core_tags.tag_title <> @tag8)
AND (core_tags.tag_title <> @tag9)AND (core_tags.tag_title <> @tag10)


UPDATE    core_tags
SET              counter = core_tags.counter - 1
FROM         core_tags INNER JOIN
                      core_tag_ref_cat ON core_tags.tag_id = core_tag_ref_cat.tag_id
WHERE     (core_tag_ref_cat.cat_id = @catid) AND (core_tags.tag_title <> @tag1) AND (core_tags.tag_title <> @tag2) AND (core_tags.tag_title <> @tag3) AND 
                      (core_tags.tag_title <> @tag4) AND (core_tags.tag_title <> @tag5) AND (core_tags.tag_title <> @tag6) AND (core_tags.tag_title <> @tag7) AND 
                      (core_tags.tag_title <> @tag8) AND (core_tags.tag_title <> @tag9) AND (core_tags.tag_title <> @tag10)
                      
DELETE FROM core_tag_ref_cat
FROM         core_tag_ref_cat INNER JOIN
                      core_tags ON core_tag_ref_cat.tag_id = core_tags.tag_id
WHERE     (core_tag_ref_cat.cat_id = @catid) AND (core_tags.tag_title <> @tag1) AND (core_tags.tag_title <> @tag2) AND (core_tags.tag_title <> @tag3) AND 
(core_tags.tag_title <> @tag4) AND (core_tags.tag_title <> @tag5) AND (core_tags.tag_title <> @tag6) AND (core_tags.tag_title <> @tag7) AND 
(core_tags.tag_title <> @tag8) AND (core_tags.tag_title <> @tag9) AND (core_tags.tag_title <> @tag10)
                      
EXEC	 [dbo].[core_tag_add] 		@catid = @catid, 		@tagTitle = @tag1 
EXEC	 [dbo].[core_tag_add] 		@catid = @catid, 		@tagTitle = @tag2 
EXEC	 [dbo].[core_tag_add] 		@catid = @catid, 		@tagTitle = @tag3 
EXEC	 [dbo].[core_tag_add] 		@catid = @catid, 		@tagTitle = @tag4 
EXEC	 [dbo].[core_tag_add] 		@catid = @catid, 		@tagTitle = @tag5 
EXEC	 [dbo].[core_tag_add] 		@catid = @catid, 		@tagTitle = @tag6 
EXEC	 [dbo].[core_tag_add] 		@catid = @catid, 		@tagTitle = @tag7 
EXEC	 [dbo].[core_tag_add] 		@catid = @catid, 		@tagTitle = @tag8 
EXEC	 [dbo].[core_tag_add] 		@catid = @catid, 		@tagTitle = @tag9 
EXEC	 [dbo].[core_tag_add] 		@catid = @catid, 		@tagTitle = @tag10 


/*
DECLARE @r2 int;
if not exists (select * from core_tags where tag_title = @tag2)
begin
insert into core_tags (tag_title,[counter]) values (@tag2,1)
SET @r2 =  SCOPE_IDENTITY();
insert into core_tag_ref_cat(cat_id,tag_id) values (@catid,@r2) 
end
else
begin 
DECLARE @s2 int;
set @s2 = (select tag_id from core_tags where tag_title=@tag2)
if not exists (select * from core_tag_ref_cat where (tag_id=@s2) AND (cat_id=@catid) )
begin
update core_tags set [counter] =  [counter] + 1 where tag_title=@tag2
insert into core_tag_ref_cat(cat_id,tag_id) values (@catid,@s2) 
end
end*/

/*DECLARE @r int;
SET @r =  11;
if @r is not null
print 11
*/
COMMIT TRANSACTION 


GO



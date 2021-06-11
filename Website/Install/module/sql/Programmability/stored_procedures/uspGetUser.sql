/****** Object:  StoredProcedure [dbo].[uspGetUser]    Script Date: 02/08/2013 21:01:07 ******/
CREATE PROCEDURE [dbo].[uspGetUser]
@user_id [int]
AS
SELECT             [id],
            [email],
            [fname],
            [lname],
                     [id_language],
                     [company],
                     [tel],
					[fax],
                     [cellphone],
                     [country],
                     [stats],
                     [city],
                     [address],
                     [zipcode],
                     [active],
                     [suspended]
  FROM [users]
  where (id = @user_id )


GO
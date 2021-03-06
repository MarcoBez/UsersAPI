USE [PIT]
GO
/****** Object:  StoredProcedure [dbo].[sp_add_user]    Script Date: 01/10/2020 8:33:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_add_user](@title int,@name varchar(100),@surname varchar(100),@email varchar(100),@dob varchar(10), @age int,@addr1 varchar(100),@addr2 varchar(100),@town varchar(100), @province int, @pcode varchar(5),@telno varchar(12),@celno varchar(12))
AS
-----------------------------------------------------------------
--Marco Bezuidenhout - 30 Sep 2020 - Initial Create
-----------------------------------------------------------------
BEGIN

	SET NOCOUNT ON;

	BEGIN TRANSACTION

		INSERT INTO user_details(title,name,surname,email,dob,age,addr_1,addr_2,town,province,p_code,tel_no,cel_no)
		VALUES(@title,@name,@surname,@email,@dob,@age,@addr1,@addr2,@town,@province,@pcode,@telno,@celno)


	COMMIT TRANSACTION

END
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_all_users]    Script Date: 01/10/2020 8:33:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_delete_all_users]
AS
-----------------------------------------------------------------
--Marco Bezuidenhout - 30 Sep 2020 - Initial Create
-----------------------------------------------------------------
BEGIN

	SET NOCOUNT ON;

	BEGIN TRANSACTION

		DELETE user_details

	COMMIT TRANSACTION

END
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_user]    Script Date: 01/10/2020 8:33:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_delete_user](@email varchar(100))
AS
-----------------------------------------------------------------
--Marco Bezuidenhout - 30 Sep 2020 - Initial Create
-----------------------------------------------------------------
BEGIN

	SET NOCOUNT ON;

	BEGIN TRANSACTION

		DELETE user_details
		WHERE email = @email

	COMMIT TRANSACTION

END
GO
/****** Object:  StoredProcedure [dbo].[sp_get_all_users]    Script Date: 01/10/2020 8:33:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_get_all_users]
AS
-----------------------------------------------------------------
--Marco Bezuidenhout - 30 Sep 2020 - Initial Create
-----------------------------------------------------------------
BEGIN

	SET NOCOUNT ON;	

--select all users
	SELECT 
		ut.title AS 'title',
		ud.name AS 'name',
		ud.surname AS 'surname',
		ud.email AS 'email',
		ud.dob AS 'dob',
		ud.age AS 'age',
		ud.addr_1 AS 'addr_1',
		ud.addr_2 AS 'addr_2',
		ud.town AS 'town',
		up.province AS 'province',
		ud.p_code AS 'p_code',
		ud.tel_no AS 'tel_no',
		ud.cel_no AS 'cel_no'
	FROM user_details ud
		JOIN user_title ut ON ut.id = ud.title
		JOIN user_province up ON up.id = ud.province
END
GO
/****** Object:  StoredProcedure [dbo].[sp_get_user]    Script Date: 01/10/2020 8:33:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_get_user](@email varchar(100))
AS
-----------------------------------------------------------------
--Marco Bezuidenhout - 30 Sep 2020 - Initial Create
-----------------------------------------------------------------
BEGIN

	SET NOCOUNT ON;

		SELECT 
			ut.title AS 'title',
			ud.name AS 'name',
			ud.surname AS 'surname',
			ud.email AS 'email',
			ud.dob AS 'dob',
			ud.age AS 'age',
			ud.addr_1 AS 'addr_1',
			ud.addr_2 AS 'addr_2',
			ud.town AS 'town',
			up.province AS 'province',
			ud.p_code AS 'p_code',
			ud.tel_no AS 'tel_no',
			ud.cel_no AS 'cel_no'
		FROM user_details ud
			JOIN user_title ut ON ut.id = ud.title
			JOIN user_province up ON up.id = ud.province
		WHERE ud.email = @email

END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_user]    Script Date: 01/10/2020 8:33:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_update_user](@title int,@name varchar(100),@surname varchar(100),@email varchar(100),@dob varchar(10), @age int,@addr1 varchar(100),@addr2 varchar(100),@town varchar(100), @province int, @pcode varchar(5),@telno varchar(12),@celno varchar(12))
AS
-----------------------------------------------------------------
--Marco Bezuidenhout - 30 Sep 2020 - Initial Create
-----------------------------------------------------------------
BEGIN

	SET NOCOUNT ON;

	BEGIN TRANSACTION

		UPDATE user_details
		   SET [age] = @age
			  ,[addr_1] = @addr1
			  ,[addr_2] = @addr2
			  ,[town] = @town
			  ,[province] = @province
			  ,[p_code] = @pcode
			  ,[tel_no] = @telno
			  ,[cel_no] = @celno
		WHERE email = @email

	COMMIT TRANSACTION

END



GO

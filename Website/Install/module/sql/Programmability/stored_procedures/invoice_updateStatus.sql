CREATE PROCEDURE [dbo].[invoice_updateStatus] @invoiceId int
AS
begin

	DECLARE @sbt_paid int
	
	
	select @sbt_paid =resnum from  sbt where ((id_core_invoice=@invoiceId) and ([state]=1) and (RefNum is not null ))

	IF @sbt_paid IS NULL 
	Begin
		DECLARE @sum_Trans int
		select @sum_Trans =sum( amount) from  core_transaction where ((core_transaction.idInvoice=@invoiceId) and ([state]=2))
		
		IF @sum_Trans IS NULL  set @sum_Trans =0

	    DECLARE @price int
		select @price =price from  core_invoice where ((core_invoice.id=@invoiceId) )

			if @sum_Trans >= @price
			Begin
				print 'paid by trans'
				UPDATE    core_invoice SET              payStatus = 2 where (id=@invoiceId)
			END
			ELSE
				BEGIN
				
				if EXISTS(SELECT     id  FROM         core_transaction  WHERE     ([state] =0) AND (idInvoice= @invoiceId))
				begin
				print 'wait'
				UPDATE    core_invoice SET              payStatus = 1 where (id=@invoiceId)
				
				end
				else
				print 'not paid'
				UPDATE    core_invoice SET              payStatus = 0 where (id=@invoiceId)
				
				END

			END
	ELSE
	BEGIN
		print 'paid'
		UPDATE    core_invoice SET              payStatus = 2 where (id=@invoiceId)
	END
end
GO
ALTER PROCEDURE [dbo].[invoice_updateStatus] @invoiceId int
AS
begin

	DECLARE @sbt_paid bigint
	
	
	select @sbt_paid =resnum from  sbt where ((id_core_invoice=@invoiceId) and ([state]=1) and (RefNum is not null ))

	IF @sbt_paid IS NULL 
	Begin
		DECLARE @sum_Trans bigint
		select @sum_Trans =sum( amount) from  core_transaction where ((core_transaction.idInvoice=@invoiceId) and ([state]=2))
		
		IF @sum_Trans IS NULL  set @sum_Trans =0

	    DECLARE @price bigint
		select @price =price from  core_invoice where ((core_invoice.id=@invoiceId) )

			if @sum_Trans >= @price
			Begin
				print 'paid by trans'
				UPDATE    core_invoice SET              payStatus = 2 where (id=@invoiceId)
			END
			ELSE
				BEGIN
				
				if EXISTS(SELECT     id  FROM         core_transaction  WHERE     ([state] =0) AND (idInvoice= @invoiceId))
				begin
				print 'wait'
				UPDATE    core_invoice SET              payStatus = 1 where (id=@invoiceId)
				
				end
				else
				print 'not paid'
				UPDATE    core_invoice SET              payStatus = 0 where (id=@invoiceId)
				
				END

			END
	ELSE
	BEGIN
		print 'paid'
		UPDATE    core_invoice SET              payStatus = 2 where (id=@invoiceId)
	END
end


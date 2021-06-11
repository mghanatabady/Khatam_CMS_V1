CREATE TABLE [dbo].[fb_forms](
	[form_id] [int] IDENTITY(1,1) NOT NULL,
	[form_name] [nvarchar](50) NULL,
	[form_description] [nvarchar](255) NULL,
	[form_email] [nvarchar](255) NULL,
	[form_redirect] [nvarchar](255) NULL,
	[form_success_message] [nvarchar](255) NULL,
	[form_password] [nvarchar](50) NULL,
	[form_unique_ip] [bit] NULL,
	[form_frame_height] [int] NULL,
	[form_has_css] [int] NULL,
	[form_captcha] [int] NULL,
	[form_active] [int] NULL,
	[form_review] [int] NULL,
	[esl_from_name] [nvarchar](255) NULL,
	[esl_from_email_address] [nvarchar](255) NULL,
	[esl_subject] [nvarchar](255) NULL,
	[esl_content] [nvarchar](255) NULL,
	[esl_plain_text] [int] NULL,
	[esr_from_name] [nvarchar](255) NULL,
	[esr_from_email_address] [nvarchar](255) NULL,
	[esr_subject] [nvarchar](255) NULL,
	[esr_content] [nvarchar](255) NULL,
	[esr_plain_text] [int] NULL,
	[test] [int] NULL,
 CONSTRAINT [PK_fb_forms] PRIMARY KEY CLUSTERED 
(
	[form_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


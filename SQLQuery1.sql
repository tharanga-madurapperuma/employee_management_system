CREATE TABLE [dbo].[employees] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [employee_id]    VARCHAR (MAX) NOT NULL,
    [full_name]      VARCHAR (MAX) NULL,
    [gender]         VARCHAR (MAX) NULL,
    [contact_number] VARCHAR (MAX) NULL,
    [position]       VARCHAR (50)  NULL,
    [image]          VARCHAR (MAX) NULL,
    [status]         VARCHAR (MAX) NULL,
    [salary]         INT           NULL,
    [update_date]    DATE          NULL,
    [insert_date]    DATE          NULL,
    [delete_date]    DATE          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
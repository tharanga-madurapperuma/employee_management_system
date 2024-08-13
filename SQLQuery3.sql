CREATE TABLE [dbo].[work_hours] (
    [id]               INT            IDENTITY (1, 1) NOT NULL,
    [employee_id]      VARCHAR (MAX)  NOT NULL,
    [month]            DATE           NOT NULL,
    [total_work_hours] DECIMAL (5, 2) NULL,
    [total_ot]         DECIMAL (5, 2) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
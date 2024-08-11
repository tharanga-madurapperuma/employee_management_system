CREATE TABLE [dbo].[attendance] (
    [attendance_id]   INT           IDENTITY (1, 1) NOT NULL,
    [employee_id]     VARCHAR (MAX) NOT NULL,
    [attendance_date] DATE          NOT NULL,
    [time_in]         TIME (7)      NOT NULL,
    [time_out]        TIME (7)      NOT NULL,
    PRIMARY KEY CLUSTERED ([attendance_id] ASC)
);
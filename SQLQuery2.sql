<<<<<<< HEAD
﻿CREATE TABLE [dbo].[attendance] (
    [attendance_id]   INT           IDENTITY (1, 1) NOT NULL,
    [employee_id]     VARCHAR (MAX) NOT NULL,
    [attendance_date] DATE          NOT NULL,
    [time_in]         TIME (7)      NOT NULL,
    [time_out]        TIME (7)      NOT NULL,
    PRIMARY KEY CLUSTERED ([attendance_id] ASC)
);
=======
﻿CREATE TABLE job_roles
(
	role_id INT PRIMARY KEY IDENTITY(1,1),
	role_des VARCHAR(MAX) NULL,
	basic_salary NUMERIC(10,2),
	EPF NUMERIC(10,2),
	ETF NUMERIC(10,2),
	overtime_per_hour NUMERIC(10,2)
)


SELECT * FROM job_roles

INSERT INTO job_roles (1, 'Intern', 25000, 2000, 750, 142.05)
>>>>>>> e7738b0b522bfa8911c17f6638a93c37176ce6e4

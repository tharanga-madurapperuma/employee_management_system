<<<<<<< HEAD
<<<<<<< HEAD
﻿CREATE TABLE [dbo].[employees] (
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
=======
﻿CREATE TABLE users
(
id int PRIMARY KEY IDENTITY(1,1),
username VARCHAR(MAX) NULL,
password VARCHAR(MAX) NULL,
date_register DATE NULL,
)

SELECT * FROM users

CREATE TABLE employess
(
	id INT PRIMARY KEY IDENTITY(1,1),
	employee_id VARCHAR(MAX) NULL,
	full_name VARCHAR(MAX) NULL,
	gender VARCHAR(MAX) NULL,
	contact_number VARCHAR(MAX) NULL,
	position VARCHAR(MAX) NULL,
	image VARCHAR(MAX) NULL,
	insert_data DATE NULL,
	update_date DATE NULL,
	delete_date DATE NULL,

)

SELECT * FROM employess
>>>>>>> origin/attendance
=======
﻿SELECT * FROM job_roles
>>>>>>> e7738b0b522bfa8911c17f6638a93c37176ce6e4

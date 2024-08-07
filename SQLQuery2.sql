CREATE TABLE job_roles
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
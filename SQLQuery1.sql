CREATE TABLE users
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
--task

SELECT pr.name,c.name 
FROM dbo.product pr 
left join dbo.product_with_category pwc on pwc.product_id = pr.id 
left join dbo.category c on c.id = pwc.category_id 


--sql patch 

CREATE TABLE db_ebdab.dbo.product (
	id int IDENTITY(1,1) NOT NULL,
	name varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK__product__3213E83F63A3A95B PRIMARY KEY (id)
);
INSERT INTO db_ebdab.dbo.product
(id, name)
VALUES(2, N'Product1');
INSERT INTO db_ebdab.dbo.product
(id, name)
VALUES(3, N'Product2');
INSERT INTO db_ebdab.dbo.product
(id, name)
VALUES(4, N'Product3');

CREATE TABLE db_ebdab.dbo.category (
	id int IDENTITY(1,1) NOT NULL,
	name varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK__category__3213E83FF502DBA3 PRIMARY KEY (id)
);

INSERT INTO db_ebdab.dbo.category
(id, name)
VALUES(1, N'Category1');
INSERT INTO db_ebdab.dbo.category
(id, name)
VALUES(2, N'Category2');
INSERT INTO db_ebdab.dbo.category
(id, name)
VALUES(3, N'Category3');


CREATE TABLE db_ebdab.dbo.product_with_category (
	id int IDENTITY(1,1) NOT NULL,
	product_id int NOT NULL,
	category_id int NOT NULL,
	CONSTRAINT PK__product___3213E83FE3510824 PRIMARY KEY (id),
	CONSTRAINT product_with_category_FK_1 FOREIGN KEY (category_id) REFERENCES db_ebdab.dbo.category(id) ON DELETE CASCADE,
	CONSTRAINT product_with_category_FK_2 FOREIGN KEY (product_id) REFERENCES db_ebdab.dbo.product(id) ON DELETE CASCADE
);
INSERT INTO db_ebdab.dbo.product_with_category
(id, product_id, category_id)
VALUES(NULL, 2, 1);
INSERT INTO db_ebdab.dbo.product_with_category
(id, product_id, category_id)
VALUES(NULL, 2, 2);
INSERT INTO db_ebdab.dbo.product_with_category
(id, product_id, category_id)
VALUES(NULL, 3, 2);






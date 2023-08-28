CREATE DATABASE TestTaskDb;
USE TestTaskDb;

CREATE TABLE Category
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(45)
);

CREATE TABLE Product 
(
	Id INT PRIMARY KEY IDENTITY,
	ProductName NVARCHAR(45),
);

CREATE TABLE ProductCategoryPair
(
	Id INT PRIMARY KEY IDENTITY,
	CategortId INT REFERENCES Category (Id) ,
	ProductId INT REFERENCES Product (Id)
);

INSERT Category VALUES 
('Для дома'), ('Для дачи'), ('Электротехника'),('Столовые приборы'), ('Пищевые продукты')
;

INSERT Product VALUES 
('Холодильник'),('Стиральная машина'),('Микроволновка'),('Нож'),('Ложка'),('Вилка'),('Яблоко'),('Котлета'),('Пакет молока'),('Табуретка'),
('Шкаф'),('Автомобиль'),('Дверная ручка'),('Лампочка'),('Лопата'),('Серверная стойка'),('Тетрадь'),('Книга'),('Сельскохозяйственный комбайн'),('Промышленная лампа')
;

INSERT ProductCategoryPair VALUES
(1, 1),(1, 2),(1, 3),(1, 4),(1, 5),(1, 6),(1, 1),(1, 10),(1, 11),(1, 13),(1, 14),(1, 18),
(2, 1),(2, 10),(2, 11),(2, 13),(2, 14),(2, 15),
(3, 1),(3, 2),(3, 3),(3, 14),(3, 16),(3, 17),(3, 20),
(4, 4),(4, 5),(4, 6),
(5, 7),(5, 8),(5, 9)
;

SELECT p.ProductName, c.CategoryName
FROM ProductCategoryPair AS pcr
	FULL JOIN Product AS p
		 ON p.Id = pcr.ProductId
	FULL JOIN Category AS c
		 ON c.Id = pcr.CategortId
;


DROP TABLE ProductCategoryPair;
DROP TABLE Product;
DROP TABLE Category;
# currencyproject
В данном API реализованы два HTTP метода:
1) GET currency/{Id} - возвращает данные о валюте по ее порядковому номеру (1-34)

2) GET currencies - возвращает список данных о валютах в виде страниц, на каждой из которых не более пяти (5) валют.
В конце каждой страницы, возвращаемой данным методом, есть ссылки на предыдущую и следующую страницы.
Запрос конкретной страницы (например, 4) выглядит так: .../currencies?page=4
Данные о валютах хранятся в базе данных SQL SERVER
База данных обновляется каждый раз, когда пользователь делает HTTP запрос
Если в базе данных нет нужных строк, они заносятся в нее
Работа с базой данных реализована с помощью ORM Entity Framework
Запрос для создания нужной таблицы в SQL SERVER:

CREATE TABLE tblCurrency
(
	ID_column INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ID varchar(50),
	NumCode int,
	CharCode varchar(10),
	Nominal int,
	Name varchar(255),
	Value float,
	Previous float
);

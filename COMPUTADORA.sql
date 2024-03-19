CREATE TABLE COMPUTADORA (
	idcomputadora		INT IDENTITY (1,1) NOT NULL,
	nombre				NVARCHAR(50) NOT NULL,
	descripcion			NVARCHAR (100) NOT NULL,
	precio				MONEY NOT NULL,
	fechafabricacion	DATETIME NOT NULL
);
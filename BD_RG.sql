
CREATE DATABASE RG_BOUTIQUE;
GO

USE RG_BOUTIQUE;
GO

CREATE TABLE CATEGORIA 
(
	CAT_ID INT PRIMARY KEY IDENTITY(1,1),
	CAT_DESCRIPCION VARCHAR(100) NOT NULL,
	CAT_ESTADO BIT NOT NULL DEFAULT 1
);

INSERT INTO CATEGORIA (CAT_DESCRIPCION) VALUES
('Gorras'),
('Tenis'),
('Botas'),
('Playera'),
('Camisa'),
('Chanclas');
GO

CREATE TABLE MARCA
(
	MAR_ID INT PRIMARY KEY IDENTITY(1,1),
	MAR_DESCRIPCION VARCHAR(100) NOT NULL,
	MAR_ESTADO BIT NOT NULL DEFAULT 1
);

INSERT INTO MARCA(MAR_DESCRIPCION) VALUES
('Balenciaga'),
('Thirty One'),
('OFF WHITE'),
('Dandy'),
('Barbas'),
('Dior'),
('Amiri'),
('Nike'),
('On Cloud'),
('Louis Vuitton'),
('Timberland'),
('BOSS'),
('KORS'),
('LACOSTE'),
('Calvin Klein'),
('Psycho Bunny');
GO

CREATE TABLE USUARIO
(
	USU_ID INT PRIMARY KEY,
	USU_NOMBRE VARCHAR(100) NOT NULL UNIQUE,
	USU_PASSWORD VARCHAR(100) NOT NULL,
	USU_NIVEL INT NOT NULL CONSTRAINT CHK_USU_NIVEL CHECK (USU_NIVEL IN (1,2)),
	USU_ESTADO BIT NOT NULL DEFAULT 1
);

INSERT INTO USUARIO(USU_ID,USU_NOMBRE,USU_PASSWORD,USU_NIVEL) VALUES
(1, 'Ismael','159753',2),
(777, 'Mapache','Jean151019',1);
GO


CREATE TABLE PRODUCTO
(
    PROD_ID INT PRIMARY KEY IDENTITY(1,1),
    PROD_NOMBRE VARCHAR(100) NOT NULL,
    PROD_CAT_ID INT NOT NULL FOREIGN KEY REFERENCES CATEGORIA(CAT_ID) ON UPDATE CASCADE,
    PROD_MAR_ID INT NOT NULL FOREIGN KEY REFERENCES MARCA(MAR_ID) ON UPDATE CASCADE,
    PROD_ESTADO BIT NOT NULL DEFAULT 1
);


INSERT INTO PRODUCTO(PROD_NOMBRE,PROD_DESCRIPCION,PROD_CAT_ID,PROD_MAR_ID)
VALUES
('Playera Cuello Redondo','Playera básica de algodón',4,9);
GO


CREATE TABLE PRODUCTO_VARIANTE
(
    VAR_ID INT PRIMARY KEY IDENTITY(1,1),
    VAR_CODIGO VARCHAR(100) UNIQUE NOT NULL,
    PROD_ID INT NOT NULL FOREIGN KEY REFERENCES PRODUCTO(PROD_ID) ON UPDATE CASCADE ON DELETE CASCADE,
    COLOR VARCHAR(100),
    TALLA VARCHAR(20),
    PRECIO_COMPRA DECIMAL(10,2) NOT NULL,
    PRECIO_VENTA DECIMAL(10,2) NOT NULL,
    STOCK INT NOT NULL DEFAULT 0,
    VAR_ESTADO BIT NOT NULL DEFAULT 1
);

DELETE FROM PRODUCTO

INSERT INTO PRODUCTO_VARIANTE (VAR_CODIGO, PROD_ID, COLOR, TALLA, PRECIO_COMPRA, PRECIO_VENTA, STOCK)
VALUES
('1001', 1, 'Rojo', 'M', 150.00, 250.00, 10),
('1002', 1, 'Azul', 'L', 150.00, 250.00, 8),
('1003', 1, 'Blanco', 'S', 150.00, 250.00, 12);
GO


CREATE TABLE VENTA
(
    VEN_ID INT PRIMARY KEY IDENTITY(1,1),
    VEN_FECHA DATETIME NOT NULL DEFAULT GETDATE(),
    VEN_SUBTOTAL DECIMAL(10,2) NOT NULL DEFAULT 0,
    VEN_DESCUENTO DECIMAL(10,2) NOT NULL DEFAULT 0,
    VEN_IMPUESTO DECIMAL(10,2) NOT NULL DEFAULT 0,
    VEN_TOTAL AS (VEN_SUBTOTAL - VEN_DESCUENTO + VEN_IMPUESTO) PERSISTED,
    VEN_USU_ID INT NOT NULL FOREIGN KEY REFERENCES USUARIO(USU_ID),
    VEN_ESTADO BIT NOT NULL DEFAULT 1,
	VEN_METODO_PAGO VARCHAR(20) NOT NULL DEFAULT 'EFECTIVO' CONSTRAINT CHK_METODO_PAGO CHECK (VEN_METODO_PAGO IN ('EFECTIVO','TARJETA','TRANSFERENCIA'))
);
GO


CREATE TABLE DETALLE_VENTA
(
    DETV_ID INT IDENTITY(1,1) PRIMARY KEY,
    DETV_VEN_ID INT NOT NULL FOREIGN KEY REFERENCES VENTA(VEN_ID) ON DELETE CASCADE,
    DETV_VAR_ID INT NOT NULL FOREIGN KEY REFERENCES PRODUCTO_VARIANTE(VAR_ID),
    DETV_CANTIDAD INT NOT NULL,
    DETV_PRECIOUNITARIO DECIMAL(10,2) NOT NULL,
    DETV_SUBTOTAL AS (DETV_CANTIDAD * DETV_PRECIOUNITARIO) PERSISTED
);
GO

--===============================================VISTAS===================================================================
ALTER VIEW VW_PRODUCTO_VARIANTE_DETALLE
AS
SELECT 
    pv.VAR_ID,
    pv.VAR_CODIGO AS SKU,
    p.PROD_ID,
    p.PROD_NOMBRE AS NOMBRE_PRODUCTO,
    c.CAT_DESCRIPCION AS CATEGORIA,
    m.MAR_DESCRIPCION AS MARCA,
    pv.COLOR,
    pv.TALLA,
    pv.PRECIO_COMPRA,
    pv.PRECIO_VENTA,
    pv.STOCK,
    pv.VAR_ESTADO
FROM PRODUCTO_VARIANTE pv
INNER JOIN PRODUCTO p ON pv.PROD_ID = p.PROD_ID
INNER JOIN CATEGORIA c ON p.PROD_CAT_ID = c.CAT_ID
INNER JOIN MARCA m ON p.PROD_MAR_ID = m.MAR_ID
WHERE pv.VAR_ESTADO = 1 AND p.PROD_ESTADO = 1;
GO

CREATE VIEW VW_REPORTE_VENTAS
AS
SELECT
    v.VEN_ID AS [Folio],
    v.VEN_FECHA AS [Fecha y Hora],
    u.USU_NOMBRE AS [Vendedor],

    -- Corregido: Unimos el nombre del producto padre con sus variantes
    ISNULL(
        STRING_AGG(CONCAT(c.CAT_DESCRIPCION, ': ',m.MAR_DESCRIPCION, ' - ', p.PROD_NOMBRE),', '), 'Sin productos'
    ) AS [Productos Vendidos],
    v.VEN_METODO_PAGO AS [Metodo de Pago],
    v.VEN_TOTAL AS [Monto Total] -- Corregido: El campo se llama VEN_TOTAL

FROM
    VENTA AS v
LEFT JOIN
    USUARIO AS u ON v.VEN_USU_ID = u.USU_ID
LEFT JOIN
    DETALLE_VENTA AS dv ON v.VEN_ID = dv.DETV_VEN_ID
LEFT JOIN
    PRODUCTO_VARIANTE AS pv ON dv.DETV_VAR_ID = pv.VAR_ID -- Unimos la variante
LEFT JOIN
    PRODUCTO AS p ON pv.PROD_ID = p.PROD_ID -- Y de la variante, unimos al producto
LEFT JOIN
	CATEGORIA AS c ON p.PROD_CAT_ID = c.CAT_ID
LEFT JOIN
	MARCA AS m ON p.PROD_MAR_ID = m.MAR_ID

-- Corregido: Agrupamos por los campos correctos de la tabla VENTA y USUARIO
GROUP BY
    v.VEN_ID,
    v.VEN_FECHA,
    u.USU_NOMBRE,
	v.VEN_METODO_PAGO,
    v.VEN_TOTAL
GO

--============================================PROCEDIMIENTOS======================================================================

ALTER PROCEDURE SP_GUARDAR_PRODUCTO_Y_VARIANTE
(
    -- PRODUCTO
    @PROD_ID INT = 0,
    @PROD_NOMBRE VARCHAR(100),
    @PROD_CAT_ID INT,
    @PROD_MAR_ID INT,

    -- VARIANTE
    @VAR_ID INT = 0,
    @VAR_CODIGO VARCHAR(100),
    @COLOR VARCHAR(100),
    @TALLA VARCHAR(20),
    @PRECIO_COMPRA DECIMAL(10,2),
    @PRECIO_VENTA DECIMAL(10,2),
    @STOCK INT,

    -- SALIDA
    @RESULTADO INT OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. VALIDAR SKU DUPLICADO (Siempre es el primer chequeo de seguridad)
        IF EXISTS(SELECT 1 FROM PRODUCTO_VARIANTE 
                  WHERE VAR_CODIGO = @VAR_CODIGO
                  AND VAR_ID <> @VAR_ID
                  AND VAR_ESTADO = 1)
        BEGIN
            SET @RESULTADO = 2; -- Error: SKU ya existe en otro producto
            ROLLBACK TRANSACTION;
            RETURN;
        END

        --------------------------------------------------------------------
        -- 2. LÓGICA "BUSCAR O CREAR" EL PRODUCTO PADRE CORRECTO
        --------------------------------------------------------------------
        DECLARE @ID_PADRE_CORRECTO INT;

        -- Buscamos si ya existe un padre EXACTAMENTE con ese Nombre, Marca y Categoría
        SELECT @ID_PADRE_CORRECTO = PROD_ID
        FROM PRODUCTO
        WHERE PROD_NOMBRE = @PROD_NOMBRE
          AND PROD_CAT_ID = @PROD_CAT_ID
          AND PROD_MAR_ID = @PROD_MAR_ID
          AND PROD_ESTADO = 1;

        -- Si NO existe esa combinación, la creamos ahora mismo
        IF (@ID_PADRE_CORRECTO IS NULL)
        BEGIN
            INSERT INTO PRODUCTO (PROD_NOMBRE, PROD_CAT_ID, PROD_MAR_ID, PROD_ESTADO)
            VALUES (@PROD_NOMBRE, @PROD_CAT_ID, @PROD_MAR_ID, 1);

            SET @ID_PADRE_CORRECTO = SCOPE_IDENTITY();
        END

        --------------------------------------------------------------------
        -- 3. INSERTAR O ACTUALIZAR LA VARIANTE (Usando el padre correcto)
        --------------------------------------------------------------------
        IF (@VAR_ID = 0)
        BEGIN
            -- NUEVA VARIANTE
            INSERT INTO PRODUCTO_VARIANTE (VAR_CODIGO, PROD_ID, COLOR, TALLA, PRECIO_COMPRA, PRECIO_VENTA, STOCK)
            VALUES (@VAR_CODIGO, @ID_PADRE_CORRECTO, @COLOR, @TALLA, @PRECIO_COMPRA, @PRECIO_VENTA, @STOCK);
        END
        ELSE
        BEGIN
            -- EDITAR VARIANTE EXISTENTE
            -- Al actualizar, forzamos que use @ID_PADRE_CORRECTO. 
            -- Si cambiaste la marca, @ID_PADRE_CORRECTO será diferente al anterior,
            -- moviendo efectivamente esta variante a otro padre (nuevo o existente).
            UPDATE PRODUCTO_VARIANTE
            SET VAR_CODIGO = @VAR_CODIGO,
                PROD_ID = @ID_PADRE_CORRECTO, 
                COLOR = @COLOR,
                TALLA = @TALLA,
                PRECIO_COMPRA = @PRECIO_COMPRA,
                PRECIO_VENTA = @PRECIO_VENTA,
                STOCK = @STOCK
            WHERE VAR_ID = @VAR_ID;
        END

        COMMIT TRANSACTION;
        SET @RESULTADO = 0; -- Éxito total

    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        -- Opcional: puedes usar ERROR_MESSAGE() para ver qué pasó si sigue fallando
        -- SELECT ERROR_MESSAGE(); 
        SET @RESULTADO = 3; -- Error genérico
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE SP_GUARDAR_CATEGORIA
    @CAT_ID INT = 0,
    @CAT_DESCRIPCION VARCHAR(100),
    @CAT_ESTADO BIT = 1,
    @RESULTADO VARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    
    IF (@CAT_ID > 0)
    BEGIN
        IF EXISTS(SELECT 1 FROM CATEGORIA WHERE CAT_DESCRIPCION = @CAT_DESCRIPCION AND CAT_ID <> @CAT_ID)
        BEGIN
            SET @RESULTADO = 'Ya existe otra categoría con esa descripción.'
            RETURN;
        END

        UPDATE CATEGORIA SET
            CAT_DESCRIPCION = @CAT_DESCRIPCION,
            CAT_ESTADO = @CAT_ESTADO
        WHERE
            CAT_ID = @CAT_ID;
        
        SET @RESULTADO = 'Actualizado Correctamente.'
    END

    ELSE
    BEGIN
        IF EXISTS(SELECT 1 FROM CATEGORIA WHERE CAT_DESCRIPCION = @CAT_DESCRIPCION)
        BEGIN
            SET @RESULTADO = 'Esta categoría ya existe, revise su estado.'
            RETURN;
        END
        
        INSERT INTO CATEGORIA(CAT_DESCRIPCION, CAT_ESTADO)
        VALUES (@CAT_DESCRIPCION, @CAT_ESTADO);

        
        SET @RESULTADO = 'Guardado Correctamente.'
    END
END
GO
------------------------------------------------------------------

CREATE PROCEDURE SP_LOGIN
    @USUARIO VARCHAR(100),
    @CLAVE VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        USU_ID,
        USU_NOMBRE,
        USU_NIVEL
    FROM USUARIO
    WHERE 
        USU_NOMBRE = @USUARIO
        AND USU_PASSWORD = @CLAVE
        AND USU_ESTADO = 1;
END;
GO

CREATE OR ALTER PROCEDURE SP_GUARDAR_MARCA
    @MAR_ID INT = 0,
    @MAR_DESCRIPCION VARCHAR(100),
    @MAR_ESTADO BIT = 1,
    @RESULTADO VARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    IF (@MAR_ID > 0)
    BEGIN
        IF EXISTS(SELECT 1 FROM MARCA WHERE MAR_DESCRIPCION = @MAR_DESCRIPCION AND MAR_ID <> @MAR_ID)
        BEGIN
            SET @RESULTADO = 'Ya existe otra marca con esa descripción.'
            RETURN;
        END

        UPDATE MARCA SET
            MAR_DESCRIPCION = @MAR_DESCRIPCION,
            MAR_ESTADO = @MAR_ESTADO
        WHERE
            MAR_ID = @MAR_ID;
        
        SET @RESULTADO = 'Actualizado Correctamente.'
    END

    ELSE
    BEGIN
        IF EXISTS(SELECT 1 FROM MARCA WHERE MAR_DESCRIPCION = @MAR_DESCRIPCION)
        BEGIN
            SET @RESULTADO = 'Esta marca ya existe, revise su estado.'
            RETURN;
        END
        
        INSERT INTO MARCA(MAR_DESCRIPCION, MAR_ESTADO)
        VALUES (@MAR_DESCRIPCION, @MAR_ESTADO);

        
        SET @RESULTADO = 'Guardado Correctamente.'
    END
END
GO
---------------------------------------------------------------
CREATE TYPE DetalleVentaTipo AS TABLE
(
    VAR_ID INT,         
    CANTIDAD INT,       
    PRECIOUNITARIO DECIMAL(10,2) 
);
GO

ALTER PROCEDURE SP_REGISTRAR_VENTA
(
    @USU_ID INT,
    @SUBTOTAL DECIMAL(10,2),
    @DESCUENTO DECIMAL(10,2),
    @IMPUESTO DECIMAL(10,2),
    @METODOPAGO VARCHAR(20),
    @DETALLE_VENTAS DetalleVentaTipo READONLY,
    @VENTA_ID INT OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        BEGIN TRANSACTION;

        INSERT INTO VENTA (VEN_FECHA, VEN_SUBTOTAL, VEN_DESCUENTO, VEN_IMPUESTO, VEN_USU_ID, VEN_METODO_PAGO)
        VALUES (GETDATE(), @SUBTOTAL, @DESCUENTO, @IMPUESTO, @USU_ID, @METODOPAGO);

        SET @VENTA_ID = SCOPE_IDENTITY();

        INSERT INTO DETALLE_VENTA (DETV_VEN_ID, DETV_VAR_ID, DETV_CANTIDAD, DETV_PRECIOUNITARIO)
        SELECT @VENTA_ID, VAR_ID, CANTIDAD, PRECIOUNITARIO
        FROM @DETALLE_VENTAS;

        UPDATE PRODUCTO_VARIANTE
        SET STOCK = STOCK - dv.CANTIDAD
        FROM PRODUCTO_VARIANTE pv
        JOIN @DETALLE_VENTAS dv ON pv.VAR_ID = dv.VAR_ID;

        COMMIT TRANSACTION;

    END TRY
    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW; -- re-lanza error para verlo en C#

    END CATCH
END;
GO



--==================================================================================================================

--==================================================================================================================

--==================================================================================================================

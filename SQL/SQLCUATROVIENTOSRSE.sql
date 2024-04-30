CREATE DATABASE CUATROVIENTOSRSE
USE CUATROVIENTOSRSE
CREATE TABLE ODS(
	NUMERO_ODS SMALLINT PRIMARY KEY,
	NOMBRE NVARCHAR(50),
	DESCRIPCION NVARCHAR(200)
)

CREATE TABLE CONTRATANTE(
	COD_CONTRATANTE SMALLINT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE_CONTRATANTE NVARCHAR(50),
	DESCRIPCION NVARCHAR(500)
)

CREATE TABLE CURSO(
	NOMBRE_CURSO NVARCHAR(50) PRIMARY KEY
)

CREATE TABLE PROFESORES(
	ID_PROFESOR SMALLINT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE_PROFESOR NVARCHAR(50),
	APELLIDO1 NVARCHAR(50),
	APELLIDO2 NVARCHAR(50),
	FECHA_NACIMIENTO DATE
)

CREATE TABLE METAS(
	NUMERO_ODS SMALLINT NOT NULL,	
	CARACTER_META CHAR NOT NULL,
	DESCRIPCION NVARCHAR(500)
)
ALTER TABLE METAS
ADD CONSTRAINT FK_METAS_ODS FOREIGN KEY (NUMERO_ODS) REFERENCES ODS(NUMERO_ODS)
ALTER TABLE METAS
ADD CONSTRAINT PK_METAS PRIMARY KEY (NUMERO_ODS,CARACTER_META)

CREATE TABLE ASIGNATURA(
	NOMBRE_CURSO NVARCHAR(50) NOT NULL,
	COD_ASIGNATURA SMALLINT IDENTITY(1,1) NOT NULL,
	NOMBRE_ASIGNATURA NVARCHAR(50)
)
ALTER TABLE ASIGNATURA
ADD CONSTRAINT FK_ASIGNATURA_CURSO FOREIGN KEY (NOMBRE_CURSO) REFERENCES CURSO(NOMBRE_CURSO)
ALTER TABLE ASIGNATURA
ADD CONSTRAINT PK_ASIGNATURA PRIMARY KEY (NOMBRE_CURSO,COD_ASIGNATURA)

CREATE TABLE INICIATIVAS(
	COD_INICIATIVA SMALLINT IDENTITY(1,1) PRIMARY KEY,
	HORAS SMALLINT,
	TITULO NVARCHAR(50),
	FECHA_INICIO DATE DEFAULT GETDATE(),
	FECHA_FIN DATE
)

CREATE TABLE PROFESORES_INICIATIVA(
	ID_PROFESOR SMALLINT NOT NULL,
	COD_INICIATIVA SMALLINT NOT NULL
)
ALTER TABLE PROFESORES_INICIATIVA
ADD CONSTRAINT FK_PROFESOR FOREIGN KEY (ID_PROFESOR) REFERENCES PROFESORES(ID_PROFESOR)
ALTER TABLE PROFESORES_INICIATIVA
ADD CONSTRAINT FK_PROFESOR_INI FOREIGN KEY (COD_INICIATIVA) REFERENCES INICIATIVAS(COD_INICIATIVA)
ALTER TABLE PROFESORES_INICIATIVA
ADD CONSTRAINT PK_PROFESORES_INICIATIVA PRIMARY KEY (ID_PROFESOR,COD_INICIATIVA)

CREATE TABLE CONTRATANTE_INICIATIVA(
	COD_CONTRATANTE SMALLINT NOT NULL,
	COD_INICIATIVA SMALLINT NOT NULL
)
ALTER TABLE CONTRATANTE_INICIATIVA
ADD CONSTRAINT FK_CONTRATANTE FOREIGN KEY (COD_CONTRATANTE) REFERENCES CONTRATANTE(COD_CONTRATANTE)
ALTER TABLE CONTRATANTE_INICIATIVA
ADD CONSTRAINT FK_CONTRATANTE_INI FOREIGN KEY (COD_INICIATIVA) REFERENCES INICIATIVAS(COD_INICIATIVA)
ALTER TABLE CONTRATANTE_INICIATIVA
ADD CONSTRAINT PK_CONTRATANTE_INICIATIVA PRIMARY KEY (COD_CONTRATANTE,COD_INICIATIVA)

CREATE TABLE METAS_INICIATIVA(
	NUMERO_ODS SMALLINT NOT NULL,
	CARACTER_META CHAR NOT NULL,
	COD_INICIATIVA SMALLINT NOT NULL
)

ALTER TABLE METAS_INICIATIVA
ADD CONSTRAINT FK_METAS FOREIGN KEY (NUMERO_ODS,CARACTER_META) REFERENCES METAS(NUMERO_ODS,CARACTER_META)
ALTER TABLE METAS_INICIATIVA
ADD CONSTRAINT FK_METAS_INI FOREIGN KEY (COD_INICIATIVA) REFERENCES INICIATIVAS(COD_INICIATIVA)
ALTER TABLE METAS_INICIATIVA
ADD CONSTRAINT PK_METAS_INICIATIVA PRIMARY KEY (NUMERO_ODS,CARACTER_META,COD_INICIATIVA)

CREATE TABLE ASIGNATURAS_INICIATIVA(
	NOMBRE_CURSO NVARCHAR(50) NOT NULL,
	COD_ASIGNATURA SMALLINT NOT NULL,
	COD_INICIATIVA SMALLINT NOT NULL
)
ALTER TABLE ASIGNATURAS_INICIATIVA
ADD CONSTRAINT FK_ASIGNATURAS FOREIGN KEY (NOMBRE_CURSO,COD_ASIGNATURA) REFERENCES ASIGNATURA(NOMBRE_CURSO,COD_ASIGNATURA)
ALTER TABLE ASIGNATURAS_INICIATIVA
ADD CONSTRAINT FK_ASIGNATURAS_INI FOREIGN KEY (COD_INICIATIVA) REFERENCES INICIATIVAS(COD_INICIATIVA)
ALTER TABLE ASIGNATURAS_INICIATIVA
ADD CONSTRAINT PK_ASIGNATURAS_INICIATIVA PRIMARY KEY (NOMBRE_CURSO,COD_ASIGNATURA,COD_INICIATIVA)

ALTER TABLE INICIATIVAS 
ADD CONSTRAINT CK_FECHA_FIN CHECK (INICIATIVAS.[FECHA_FIN] > INICIATIVAS.[FECHA_INICIO])
ALTER TABLE INICIATIVAS
ADD CONSTRAINT CK_HORAS CHECK (INICIATIVAS.HORAS > 0)
ALTER TABLE PROFESORES
ADD CONSTRAINT CK_FECHA_NACIMIENTO CHECK (PROFESORES.[FECHA_NACIMIENTO] < GETDATE())

--ODS DATOS
INSERT INTO ODS VALUES (1,'FIN DE LA POBREZA','Erradicar la pobreza extrema para todas las personas en todo el mundo para 2030 es un objetivo fundamental de la Agenda 2030 para el desarrollo sostenible.')
INSERT INTO ODS VALUES (2,'HAMBRE CERO','Acabar con el hambre, lograr la seguridad alimentaria, mejorar la nutrici�n y promover la agricultura sostenible.')
INSERT INTO ODS VALUES (3,'SALUD Y BIENESTAR','Garantizar una vida sana y promover el bienestar para todas las edades, incluyendo el acceso a servicios de salud de calidad.')
INSERT INTO ODS VALUES (4,'EDUCACI�N DE CALIDAD','Asegurar una educaci�n inclusiva, equitativa y de calidad, promoviendo oportunidades de aprendizaje para todos.')
INSERT INTO ODS VALUES (5,'IGUALDAD DE G�NERO',' Lograr la igualdad de g�nero y empoderar a todas las mujeres y ni�as, eliminando la discriminaci�n y la violencia.')
INSERT INTO ODS VALUES (6,'AGUA LIMPIA Y SANEAMIENTO','Garantizar la disponibilidad y gesti�n sostenible del agua y el saneamiento para todos.')
INSERT INTO ODS VALUES (7, 'Energ�a Asequible y No Contaminante', 'Este objetivo se centra en garantizar el acceso a una energ�a asequible, fiable, sostenible y moderna para todos.')
INSERT INTO ODS VALUES (8, 'Trabajo Decente y Crecimiento Econ�mico', 'tiene como objetivo promover un crecimiento econ�mico sostenido, inclusivo y sostenible')
INSERT INTO ODS VALUES (9, 'Industria, Innovaci�n e Infraestructura', 'Este objetivo apunta a construir infraestructuras resilientes, promover la industrializaci�n inclusiva y sostenible, y fomentar la innovaci�n.')
INSERT INTO ODS VALUES (10, 'Reducci�n de las Desigualdades', 'se centra en reducir la desigualdad dentro y entre los pa�ses.')
INSERT INTO ODS VALUES (11, 'Ciudades y Comunidades Sostenibles', 'Este objetivo tiene como objetivo hacer que las ciudades y los asentamientos humanos sean inclusivos, seguros, resilientes y sostenibles.')
INSERT INTO ODS VALUES (12, 'PRODUCCI�N Y CONSUMO RESPONSABLES', 'Garantizar modalidades de consumo y producci�n sostenibles')
INSERT INTO ODS VALUES (13, 'ACCI�N POR EL CLIMA', 'Adoptar medidas urgentes para combatir el cambio clim�tico y sus efectos')
INSERT INTO ODS VALUES (14, 'VIDA SUBMARINA', 'Conservar y utilizar sosteniblemente los oc�anos, los mares y los recursos marinos')
INSERT INTO ODS VALUES (15, 'VIDA DE ECOSISTEMAS TERRESTRES', 'Gestionar sosteniblemente los bosques, luchar contra la desertificaci�n, detener e invertir la degradaci�n de las tierras, detener la p�rdida de biodiversidad')
INSERT INTO ODS VALUES (16, 'PAZ, JUSTICIA E INSTITUCIONES S�LIDAS', 'Promover sociedades justas, pac�ficas e inclusivas')
INSERT INTO ODS VALUES (17, 'ALIANZAS PARA LOGRAR LOS OBJETIVOS', 'Revitalizar la Alianza Mundial para el Desarrollo Sostenible')

--METAS
INSERT INTO METAS VALUES (1, 1, 'Erradicar la pobreza extrema, definida como vivir con menos de 1,90 d�lares al d�a.')
INSERT INTO METAS VALUES (1, 2, 'Reducir a la mitad, al menos, la proporci�n de hombres, mujeres y ni�os de todas las edades que viven en la pobreza en todas sus dimensiones.')
INSERT INTO METAS VALUES (1, 3, 'Implementar medidas sociales y pol�ticas adecuadas para proteger los derechos de los pobres y vulnerables, y aumentar su capacidad para resistir desastres y crisis econ�micas.')

INSERT INTO METAS VALUES (3, 1, 'Reducir la tasa de mortalidad materna global a menos de 70 por cada 100,000 nacidos vivos.')
INSERT INTO METAS VALUES (3, 2, 'Poner fin, para 2030, a las muertes prevenibles de reci�n nacidos y ni�os menores de cinco a�os, con todos los pa�ses apuntando a reducir la mortalidad neonatal a, al menos, 12 por cada 1,000 nacidos vivos y la mortalidad en ni�os menores de cinco a�os a, al menos, 25 por cada 1,000 nacidos vivos.')
INSERT INTO METAS VALUES (3, 8, 'Lograr la cobertura sanitaria universal, incluida la protecci�n contra riesgos financieros, el acceso a servicios de salud esenciales de calidad y el acceso a medicamentos y vacunas seguros, eficaces, asequibles y de calidad para todos.')

INSERT INTO METAS VALUES (4, 1, 'Garantizar que todos los ni�os completen una educaci�n primaria y secundaria gratuita, equitativa y de calidad, que conduzca a resultados de aprendizaje relevantes y efectivos.')
INSERT INTO METAS VALUES (4, 4, 'Aumentar considerablemente el n�mero de j�venes y adultos que tienen las competencias necesarias, incluidas las competencias t�cnicas y profesionales, para acceder al empleo, el trabajo decente y el emprendimiento.')
INSERT INTO METAS VALUES (4, 7, 'Asegurar que todos los estudiantes adquieran los conocimientos y habilidades necesarios para promover el desarrollo sostenible, incluidos, entre otros, mediante la educaci�n para el desarrollo sostenible y la adopci�n de estilos de vida sostenibles.')

INSERT INTO METAS VALUES (5, 1, 'Poner fin a todas las formas de discriminaci�n contra todas las mujeres y ni�as en todo el mundo.')
INSERT INTO METAS VALUES (5, 2, 'Eliminar todas las formas de violencia contra todas las mujeres y ni�as en el �mbito p�blico y privado, incluidas la trata y la explotaci�n sexual y otros tipos de explotaci�n.')
INSERT INTO METAS VALUES (5, 6, 'Asegurar la participaci�n plena y efectiva de las mujeres y la igualdad de oportunidades de liderazgo en todos los niveles de toma de decisiones en la vida pol�tica, econ�mica y p�blica.')--INICIATIVAS

--INICIATIVAS
INSERT INTO INICIATIVAS VALUES (40,'INICIATIVA 1','20/10/2023','9/11/2023')
INSERT INTO INICIATIVAS VALUES (80,'INICIATIVA 2','20/12/2023','9/3/2024')

--CURSO
INSERT INTO CURSO VALUES ('DAM')
INSERT INTO CURSO VALUES ('ASIR')

--ASIGNATURA
INSERT INTO ASIGNATURA VALUES ('DAM','INGL�S')
INSERT INTO ASIGNATURA VALUES ('DAM','PROGRAMACI�N')
INSERT INTO ASIGNATURA VALUES ('DAM','BASES DE DATOS')
INSERT INTO ASIGNATURA VALUES ('DAM','SISTEMAS INFORM�TICOS')

--PROFESORES
INSERT INTO PROFESORES VALUES ('ALBERTO','AGINAGA','APELLIDO2','29/11/1980')
INSERT INTO PROFESORES VALUES ('ABILIO','DIAZ','APELLIDO2','29/1/1970')

--CONTRATANTE
INSERT INTO CONTRATANTE VALUES ('CUATROVIENTOS','4V')
INSERT INTO CONTRATANTE VALUES ('BIURDANA','BHI')

--ASIGNATURAS_INICIATIVA
INSERT INTO ASIGNATURAS_INICIATIVA VALUES ('DAM',1,1)
INSERT INTO ASIGNATURAS_INICIATIVA VALUES ('DAM',3,1)

--METAS_INICIATIVA
INSERT INTO METAS_INICIATIVA VALUES (1,3,1)
INSERT INTO METAS_INICIATIVA VALUES (3,8,1)

--CONTRATANTE_INICIATIVA
INSERT INTO METAS_INICIATIVA VALUES (1,1)

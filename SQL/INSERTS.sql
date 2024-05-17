DBCC CHECKIDENT (INICIATIVAS,RESEED,0)
DBCC CHECKIDENT (ASIGNATURA,RESEED,0)
DBCC CHECKIDENT (PROFESORES,RESEED,0)
DBCC CHECKIDENT (CONTRATANTE,RESEED,0)

DELETE FROM METAS_INICIATIVA
DELETE FROM ASIGNATURAS_INICIATIVA
DELETE FROM CONTRATANTE_INICIATIVA
DELETE FROM PROFESORES_INICIATIVA
DELETE FROM INICIATIVAS
DELETE FROM METAS
DELETE FROM ODS
DELETE FROM ASIGNATURA
DELETE FROM CURSO
DELETE FROM CONTRATANTE
DELETE FROM PROFESORES
go
--ODS DATOS
INSERT INTO ODS VALUES (1,'FIN DE LA POBREZA','Erradicar la pobreza extrema para todas las personas en todo el mundo para 2030 es un objetivo fundamental de la Agenda 2030 para el desarrollo sostenible.','1.jpg')
INSERT INTO ODS VALUES (2,'HAMBRE CERO','Acabar con el hambre, lograr la seguridad alimentaria, mejorar la nutrici�n y promover la agricultura sostenible.', '2.jpg')
INSERT INTO ODS VALUES (3,'SALUD Y BIENESTAR','Garantizar una vida sana y promover el bienestar para todas las edades, incluyendo el acceso a servicios de salud de calidad.', '3.jpg')
INSERT INTO ODS VALUES (4,'EDUCACI�N DE CALIDAD','Asegurar una educaci�n inclusiva, equitativa y de calidad, promoviendo oportunidades de aprendizaje para todos.', '4.jpg')
INSERT INTO ODS VALUES (5,'IGUALDAD DE G�NERO',' Lograr la igualdad de g�nero y empoderar a todas las mujeres y ni�as, eliminando la discriminaci�n y la violencia.', '5.jpg')
INSERT INTO ODS VALUES (6,'AGUA LIMPIA Y SANEAMIENTO','Garantizar la disponibilidad y gesti�n sostenible del agua y el saneamiento para todos.', '6.jpg')
INSERT INTO ODS VALUES (7, 'Energ�a Asequible y No Contaminante', 'Este objetivo se centra en garantizar el acceso a una energ�a asequible, fiable, sostenible y moderna para todos.', '7.jpg')
INSERT INTO ODS VALUES (8, 'Trabajo Decente y Crecimiento Econ�mico', 'tiene como objetivo promover un crecimiento econ�mico sostenido, inclusivo y sostenible', '8.jpg')
INSERT INTO ODS VALUES (9, 'Industria, Innovaci�n e Infraestructura', 'Este objetivo apunta a construir infraestructuras resilientes, promover la industrializaci�n inclusiva y sostenible, y fomentar la innovaci�n.', '9.jpg')
INSERT INTO ODS VALUES (10, 'Reducci�n de las Desigualdades', 'se centra en reducir la desigualdad dentro y entre los pa�ses.', '10.jpg')
INSERT INTO ODS VALUES (11, 'Ciudades y Comunidades Sostenibles', 'Este objetivo tiene como objetivo hacer que las ciudades y los asentamientos humanos sean inclusivos, seguros, resilientes y sostenibles.', '11.jpg')
INSERT INTO ODS VALUES (12, 'PRODUCCI�N Y CONSUMO RESPONSABLES', 'Garantizar modalidades de consumo y producci�n sostenibles', '12.jpg')
INSERT INTO ODS VALUES (13, 'ACCI�N POR EL CLIMA', 'Adoptar medidas urgentes para combatir el cambio clim�tico y sus efectos', '13.jpg')
INSERT INTO ODS VALUES (14, 'VIDA SUBMARINA', 'Conservar y utilizar sosteniblemente los oc�anos, los mares y los recursos marinos', '14.jpg')
INSERT INTO ODS VALUES (15, 'VIDA DE ECOSISTEMAS TERRESTRES', 'Gestionar sosteniblemente los bosques, luchar contra la desertificaci�n, detener e invertir la degradaci�n de las tierras, detener la p�rdida de biodiversidad', '15.jpg')
INSERT INTO ODS VALUES (16, 'PAZ, JUSTICIA E INSTITUCIONES S�LIDAS', 'Promover sociedades justas, pac�ficas e inclusivas', '16.jpg')
INSERT INTO ODS VALUES (17, 'ALIANZAS PARA LOGRAR LOS OBJETIVOS', 'Revitalizar la Alianza Mundial para el Desarrollo Sostenible', '17.jpg')

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

--PROFESORES_INICIATIVA
INSERT INTO PROFESORES_INICIATIVA VALUES (1,1)

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
INSERT INTO CONTRATANTE_INICIATIVA VALUES (1,1)

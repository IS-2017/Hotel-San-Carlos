CREATE DATABASE sancarlos2;
use sancarlos2;

create table usuario(
usuario char(10) NOT NULL PRIMARY KEY,
contraseña char(15) NOT NULL
);


create table bitacora (
id_bit varchar(10) PRIMARY KEY NOT NULL,
hora time,
fecha date,
usuario varchar(100),
descripcion varchar(100),
accion varchar(100),
ip varchar(100)
);

DROP FUNCTION IF EXISTS `generador_correlativo`;
DELIMITER $$
USE `sancarlos2`$$
create FUNCTION `generador_correlativo` () RETURNS nvarchar(10)
BEGIN
    DECLARE ultimo_correlativo nvarchar(10) default (SELECT YEAR(curdate()));
    DECLARE vacio int default 0;
    DEClARE correlativo_cursor CURSOR FOR
    SELECT id_bit FROM bitacora ORDER BY id_bit DESC LIMIT 1;
    DECLARE CONTINUE HANDLER
    FOR NOT FOUND SET vacio = 1;
    OPEN correlativo_cursor;
    FETCH correlativo_cursor INTO ultimo_correlativo;
    CLOSE correlativo_cursor;

    IF vacio = 0 THEN
        SET ultimo_correlativo = ultimo_correlativo + 1;
    ELSEIF vacio = 1 THEN
        SET ultimo_correlativo = concat((SELECT YEAR(curdate())),'0001');
    END IF;
    RETURN(ultimo_correlativo);
END$$
DELIMITER ;

DROP FUNCTION IF EXISTS `ValidarContrasena`;
DELIMITER $$
USE `sancarlos2`$$
create function `ValidarContrasena`(iusuario nvarchar(20), icon nvarchar(20), iip nvarchar(20)) RETURNS int(2)
IF EXISTS (select usuario from usuario where iusuario = usuario) THEN
BEGIN
DECLARE psw char(20);
SELECT contraseña into psw FROM usuario WHERE usuario=iusuario;
	IF icon != psw THEN
	insert into bitacora values(generador_correlativo(),current_time(),curdate(),iusuario,'Fallo loggeo','Login',iip);
	return 0;
	else
	insert into bitacora values(generador_correlativo(),current_time(),curdate(),iusuario,'Loggeo exitoso','Login',iip);
	return 1;
	END IF;
END;
ELSE 
return 0;
insert into bitacora values(generador_correlativo(),current_time(),curdate(),iusuario,'Fallo loggeo','Login',iip);
END IF;

INSERT into usuario values ('johnny','holis');
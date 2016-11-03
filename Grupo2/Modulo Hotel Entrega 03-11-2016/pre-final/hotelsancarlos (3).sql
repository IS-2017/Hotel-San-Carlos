-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-11-2016 a las 15:49:41
-- Versión del servidor: 5.6.17
-- Versión de PHP: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `hotelsancarlos`
--

DELIMITER $$
--
-- Funciones
--
CREATE DEFINER=`root`@`localhost` FUNCTION `generador_correlativo`() RETURNS varchar(10) CHARSET utf8
BEGIN
    DECLARE ultimo_correlativo nvarchar(10) default (SELECT YEAR(curdate()));
    DECLARE vacio int default 0;
    DEClARE correlativo_cursor CURSOR FOR
    SELECT id_encabezado_pedido_pk FROM encabezado_pedido ORDER BY id_encabezado_pedido_pk DESC LIMIT 1;
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

CREATE DEFINER=`root`@`localhost` FUNCTION `registraroperacion`(`iusuario` NVARCHAR(100), `iaccion` NVARCHAR(500), `idescrip` NVARCHAR(500), `itabla` NVARCHAR(50), `iip` NVARCHAR(20)) RETURNS int(2)
BEGIN
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,idescrip,iaccion,itabla,iip);
    return 1;
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `ValidarContrasena`(`iusuario` NVARCHAR(20), `icon` NVARCHAR(20), `iip` NVARCHAR(20)) RETURNS int(2)
IF EXISTS (select usuario from usuario where iusuario = usuario) THEN
BEGIN
DECLARE psw char(20);
SELECT contrasenia into psw FROM usuario WHERE usuario=iusuario;
	IF icon != psw THEN
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,'Fallo loggeo','Login','usuario',iip);
	return 0;
	else
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,'Loggeo exitoso','Login','usuario',iip);
	return 1;
	END IF;
END;
ELSE 
return 0;
insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,'Fallo loggeo','Login','usuario',iip);
END IF$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion`
--

CREATE TABLE IF NOT EXISTS `aplicacion` (
  `id_aplicacion` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_aplicacion` char(40) DEFAULT NULL,
  PRIMARY KEY (`id_aplicacion`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=10205 ;

--
-- Volcado de datos para la tabla `aplicacion`
--

INSERT INTO `aplicacion` (`id_aplicacion`, `nombre_aplicacion`) VALUES
(10204, 'Pollo Campero'),
(100, 'navegador');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignacion_mo`
--

CREATE TABLE IF NOT EXISTS `asignacion_mo` (
  `id_produccion_pk` char(10) NOT NULL,
  `id_empleados_pk` char(10) NOT NULL,
  `cant_horas` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_produccion_pk`,`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bien`
--

CREATE TABLE IF NOT EXISTS `bien` (
  `id_bien_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_categoria_pk` char(18) NOT NULL,
  `precio` decimal(18,0) DEFAULT NULL,
  `costo` decimal(10,0) DEFAULT NULL,
  `descripcion` char(80) DEFAULT NULL,
  `clasificacion` char(20) DEFAULT NULL,
  `apartados` int(11) DEFAULT NULL,
  `tiempo_vida` char(30) DEFAULT NULL,
  `fecha_entrada` date DEFAULT NULL,
  `metodologia` char(40) DEFAULT NULL,
  `id_medida_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bien_habitacion`
--

CREATE TABLE IF NOT EXISTS `bien_habitacion` (
  `id_bien_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `existencia` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_habitacion_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE IF NOT EXISTS `bitacora` (
  `id_bit` int(10) NOT NULL AUTO_INCREMENT,
  `hora` time DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  `accion` varchar(500) DEFAULT NULL,
  `tabla` varchar(50) DEFAULT NULL,
  `ip` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_bit`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=16508 ;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`id_bit`, `hora`, `fecha`, `usuario`, `descripcion`, `accion`, `tabla`, `ip`) VALUES
(16100, '16:25:11', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16101, '16:26:21', '2016-10-20', 'johnny2', 'Insertar', 'Creacion usuario: shakalaka', 'usuario', '192.168.1.8'),
(16102, '16:26:21', '2016-10-20', 'johnny2', 'Operacion exitosa', 'Asignacion del usuario: shakalaka al colaborador: 1-206', 'usuario', '192.168.1.8'),
(16103, '16:26:21', '2016-10-20', 'johnny2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: shakalaka Sobre aplicacion: 10204', 'usuario_privilegios', '192.168.1.8'),
(16104, '16:26:45', '2016-10-20', 'shakalaka', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16105, '17:18:19', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16106, '17:46:43', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16107, '17:49:12', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16108, '17:52:33', '2016-10-20', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16109, '17:52:40', '2016-10-20', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16110, '17:52:50', '2016-10-20', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16111, '17:52:57', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16112, '17:55:01', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16113, '17:55:37', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16114, '17:56:35', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16115, '17:58:54', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16116, '18:01:19', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16117, '18:02:50', '2016-10-20', 'johnny2', 'Insertar', 'Creacion usuario: hola', 'usuario', '192.168.1.8'),
(16118, '18:02:50', '2016-10-20', 'johnny2', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: hola', 'bitacora', '192.168.1.8'),
(16119, '18:02:50', '2016-10-20', 'johnny2', 'Operacion exitosa', 'Asignacion del usuario: hola al colaborador: 1-202', 'usuario', '192.168.1.8'),
(16120, '18:02:50', '2016-10-20', 'johnny2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: False sel: True upd: True del: False a usuario: hola Sobre aplicacion: 10204', 'usuario_privilegios', '192.168.1.8'),
(16121, '18:03:31', '2016-10-20', 'hola', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16122, '18:08:07', '2016-10-20', 'hola', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16123, '23:18:41', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16124, '23:19:16', '2016-10-20', 'johnny2', 'Modificar', 'Actualizacion de contraseña de usuario: johnny2', 'usuario', '192.168.1.8'),
(16125, '23:21:25', '2016-10-20', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16126, '23:21:29', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16127, '23:27:17', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16128, '23:27:33', '2016-10-20', 'johnny2', 'Modificar', 'Actualizacion de contraseña de usuario: johnny2', 'usuario', '192.168.1.8'),
(16129, '23:36:59', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16130, '23:37:22', '2016-10-20', 'johnny2', 'Modificar', 'Actualizacion de contraseña de usuario: johnny2', 'usuario', '192.168.1.8'),
(16131, '23:38:47', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16132, '23:39:00', '2016-10-20', 'johnny2', 'Modificar', 'Actualizacion de contraseña de usuario: johnny2', 'usuario', '192.168.1.8'),
(16133, '23:47:36', '2016-10-20', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16134, '23:47:38', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16135, '23:47:54', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16136, '23:48:10', '2016-10-20', 'johnny2', 'Modificar', 'Actualizacion de contraseña de usuario: johnny2', 'usuario', '192.168.1.8'),
(16137, '23:58:26', '2016-10-20', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16138, '23:58:28', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16139, '23:59:32', '2016-10-20', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16140, '23:59:46', '2016-10-20', 'johnny2', 'Modificar', 'Actualizacion de contraseña de usuario: johnny2', 'usuario', '192.168.1.8'),
(16141, '09:11:44', '2016-10-21', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16142, '09:11:49', '2016-10-21', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16143, '09:11:51', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16144, '09:14:34', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16145, '10:24:26', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16146, '10:26:15', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16147, '10:27:20', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16148, '10:33:41', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16149, '10:36:19', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16150, '10:39:23', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16151, '10:40:10', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16152, '10:41:07', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16153, '10:43:28', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16154, '10:44:56', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16155, '10:49:50', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16156, '10:54:13', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16157, '10:59:50', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16158, '11:29:25', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16159, '11:30:12', '2016-10-21', 'johnny2', 'Modificar', 'Actualizacion de contraseña de usuario: johnny2', 'usuario', '192.168.1.8'),
(16160, '11:36:38', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16161, '11:37:37', '2016-10-21', 'johnny2', 'Eliminar ', 'Se deshabilitò el usuario: shakalaka', 'usuario', '192.168.1.8'),
(16162, '11:42:59', '2016-10-21', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16163, '11:43:04', '2016-10-21', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16164, '11:43:07', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16165, '11:45:17', '2016-10-21', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16166, '11:45:21', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16167, '12:17:49', '2016-10-21', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16168, '12:17:51', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16169, '12:18:47', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16170, '12:19:51', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16171, '12:21:00', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16172, '12:23:36', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16173, '12:24:22', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16174, '12:25:39', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16175, '12:28:55', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16176, '12:31:06', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16177, '12:34:01', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16178, '12:35:51', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16179, '12:39:14', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16180, '12:39:31', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16181, '12:41:14', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16182, '12:42:25', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16183, '12:45:07', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16184, '12:46:18', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16185, '12:50:18', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16186, '17:58:55', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16187, '18:00:30', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16188, '18:02:29', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16189, '18:04:45', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16190, '18:10:55', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16191, '18:17:28', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16192, '18:20:22', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16193, '18:22:56', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16194, '18:28:19', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16195, '18:31:44', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16196, '18:34:15', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16197, '18:36:47', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16198, '18:41:45', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16199, '18:42:43', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16200, '18:45:07', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16201, '18:49:38', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16202, '18:52:20', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16203, '19:16:46', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16204, '19:23:55', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16205, '19:28:08', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16206, '19:31:22', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16207, '19:33:03', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16208, '19:34:02', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16209, '19:37:13', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16210, '19:38:19', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16211, '19:39:57', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16212, '19:44:06', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16213, '19:56:26', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16214, '20:02:11', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16215, '20:05:26', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16216, '20:08:18', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16217, '20:45:15', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16218, '20:52:21', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16219, '20:55:21', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16220, '20:57:44', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16221, '20:59:57', '2016-10-21', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.6'),
(16222, '21:00:01', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16223, '21:06:32', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16224, '21:08:00', '2016-10-21', 'JOHNNY2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16225, '21:08:25', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16226, '21:09:38', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.6'),
(16227, '22:55:39', '2016-10-21', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16228, '22:56:49', '2016-10-21', 'johnny2', 'Insertar', 'Creacion usuario: hoho', 'usuario', '192.168.1.8'),
(16229, '22:56:49', '2016-10-21', 'johnny2', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: hoho', 'bitacora', '192.168.1.8'),
(16230, '22:56:50', '2016-10-21', 'johnny2', 'Operacion exitosa', 'Asignacion del usuario: hoho al colaborador: 1-204', 'usuario', '192.168.1.8'),
(16231, '22:56:50', '2016-10-21', 'johnny2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: hoho Sobre aplicacion: 10204', 'usuario_privilegios', '192.168.1.8'),
(16232, '22:57:13', '2016-10-21', 'hoho', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16233, '23:06:06', '2016-10-21', 'hoho', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16234, '23:08:25', '2016-10-21', 'hoho', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16235, '23:08:28', '2016-10-21', 'hoho', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16236, '23:10:07', '2016-10-21', 'hoho', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16237, '23:15:33', '2016-10-21', 'hoho', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16238, '23:19:39', '2016-10-21', 'hoho', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16239, '23:21:20', '2016-10-21', 'hoho', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16240, '23:23:24', '2016-10-21', 'hoho', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16241, '23:27:54', '2016-10-21', 'hoho', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16242, '23:33:52', '2016-10-21', 'hoho', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16243, '08:40:00', '2016-10-24', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.85.137'),
(16244, '08:40:32', '2016-10-24', 'johnny2', 'Modificar', 'Actualizacion de contraseña de usuario: johnny2', 'usuario', '10.1.85.137'),
(16245, '08:44:52', '2016-10-24', 'johnny2', 'Intento Operacion', 'Error al crear usuario a nivel DBS7423894392794', 'dbo.users', '10.1.85.137'),
(16246, '08:45:14', '2016-10-24', 'johnny2', 'Insertar', 'Creacion usuario: roberto', 'usuario', '10.1.85.137'),
(16247, '08:45:15', '2016-10-24', 'johnny2', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: roberto', 'bitacora', '10.1.85.137'),
(16248, '08:45:46', '2016-10-24', 'johnny2', 'Insertar', 'Creacion usuario: hjadsfhadsfjkasfhjadsflk', 'usuario', '10.1.85.137'),
(16249, '08:45:46', '2016-10-24', 'johnny2', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: hjadsfhadsfjkasfhjadsflk', 'bitacora', '10.1.85.137'),
(16250, '08:45:46', '2016-10-24', 'johnny2', 'Operacion exitosa', 'Asignacion del usuario: hjadsfhadsfjkasfhjadsflk al colaborador: 1-201', 'usuario', '10.1.85.137'),
(16251, '08:45:46', '2016-10-24', 'johnny2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: True upd: True del: False a usuario: hjadsfhadsfjkasfhjadsflk Sobre aplicacion: 10204', 'usuario_privilegios', '10.1.85.137'),
(16252, '13:32:41', '2016-10-24', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '10.1.85.137'),
(16253, '13:32:44', '2016-10-24', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.85.137'),
(16254, '13:40:42', '2016-10-24', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.85.137'),
(16255, '13:51:32', '2016-10-24', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '10.1.85.137'),
(16256, '13:51:36', '2016-10-24', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.85.137'),
(16257, '13:54:39', '2016-10-24', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.85.137'),
(16258, '22:40:50', '2016-10-24', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16259, '23:30:07', '2016-10-24', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16260, '23:34:09', '2016-10-24', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.8'),
(16261, '23:34:12', '2016-10-24', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16262, '23:35:02', '2016-10-24', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16263, '23:36:16', '2016-10-24', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16264, '12:28:14', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16265, '12:29:14', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16266, '12:45:19', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16267, '12:49:04', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16268, '12:57:55', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16269, '12:59:25', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16270, '14:56:16', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16271, '14:59:48', '2016-10-26', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.29'),
(16272, '14:59:51', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16273, '15:01:12', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16274, '15:02:36', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16275, '15:05:26', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16276, '15:08:07', '2016-10-26', 'johnny2', 'Fallo loggeo', 'Login', 'usuario', '192.168.1.29'),
(16277, '15:08:23', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16278, '15:08:34', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16279, '15:08:50', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16280, '15:11:49', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16281, '15:15:53', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16282, '15:19:19', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16283, '15:20:06', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16284, '15:25:32', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16285, '15:26:04', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16286, '15:30:13', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16287, '15:38:20', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16288, '15:39:18', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16289, '15:54:18', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16290, '15:54:54', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16291, '15:56:23', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16292, '15:57:14', '2016-10-26', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.29'),
(16293, '05:07:26', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16294, '05:36:46', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16295, '07:25:58', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16296, '07:29:08', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16297, '07:50:31', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16298, '07:52:07', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16299, '07:54:28', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16300, '07:56:54', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16301, '08:03:33', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16302, '08:04:56', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16303, '08:21:08', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16304, '08:28:49', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16305, '08:30:14', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16306, '08:31:25', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16307, '08:33:52', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16308, '08:56:06', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16309, '08:58:06', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16310, '08:59:02', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16311, '09:01:40', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16312, '09:04:39', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16313, '09:07:18', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16314, '09:10:22', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16315, '09:14:54', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16316, '09:16:47', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16317, '09:17:33', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16318, '09:19:12', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16319, '09:21:23', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16320, '09:22:27', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16321, '09:26:29', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16322, '09:27:19', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16323, '09:29:40', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16324, '09:31:30', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16325, '09:32:03', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16326, '09:32:49', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16327, '09:34:27', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16328, '09:35:42', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16329, '09:36:04', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16330, '09:55:11', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16331, '10:03:35', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16332, '10:04:15', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16333, '10:06:23', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16334, '10:17:46', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16335, '10:20:49', '2016-10-27', 'johnny2', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16336, '12:27:12', '2016-10-27', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16337, '12:29:29', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16338, '12:30:19', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16339, '12:30:37', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16340, '12:30:55', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16341, '12:34:02', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16342, '12:49:53', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16343, '12:58:31', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16344, '12:59:32', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16345, '13:03:14', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16346, '13:07:33', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16347, '13:08:06', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16348, '13:08:53', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16349, '13:09:46', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16350, '13:11:26', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16351, '14:45:11', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16352, '14:46:32', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16353, '14:47:58', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16354, '14:50:29', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16355, '14:51:15', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16356, '14:53:47', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16357, '14:56:07', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16358, '16:20:33', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16359, '16:21:15', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16360, '16:23:39', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16361, '16:26:58', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16362, '16:29:08', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16363, '16:31:13', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16364, '16:32:12', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16365, '16:36:56', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16366, '16:41:44', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16367, '16:43:42', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16368, '16:48:45', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16369, '16:51:56', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16370, '16:54:48', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16371, '16:58:09', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16372, '17:19:24', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16373, '17:20:58', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16374, '17:23:51', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16375, '17:36:32', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16376, '17:37:26', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16377, '17:38:38', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16378, '17:39:57', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16379, '17:45:33', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16380, '17:58:35', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16381, '18:00:44', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16382, '19:29:53', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.9'),
(16383, '20:32:00', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16384, '20:36:14', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16385, '20:42:38', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16386, '20:47:40', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16387, '20:58:08', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16388, '21:44:23', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16389, '21:46:53', '2016-10-27', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
(16390, '07:55:35', '2016-10-28', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.117'),
(16391, '12:51:48', '2016-10-28', 'usuariodbs', 'Fallo loggeo', 'Login', 'usuario', '10.1.86.199'),
(16392, '12:51:58', '2016-10-28', 'usuariodbs', 'Fallo loggeo', 'Login', 'usuario', '10.1.86.199'),
(16393, '12:52:24', '2016-10-28', 'johnny', 'Fallo loggeo', 'Login', 'usuario', '10.1.86.199'),
(16394, '12:52:31', '2016-10-28', 'johnny', 'Fallo loggeo', 'Login', 'usuario', '10.1.86.199'),
(16395, '12:53:15', '2016-10-28', 'hola', 'Fallo loggeo', 'Login', 'usuario', '10.1.86.199'),
(16396, '12:53:17', '2016-10-28', 'hola', 'Fallo loggeo', 'Login', 'usuario', '10.1.86.199'),
(16397, '12:53:20', '2016-10-28', 'hola', 'Fallo loggeo', 'Login', 'usuario', '10.1.86.199'),
(16398, '12:53:26', '2016-10-28', 'hola', 'Fallo loggeo', 'Login', 'usuario', '10.1.86.199'),
(16399, '12:53:27', '2016-10-28', 'hola', 'Fallo loggeo', 'Login', 'usuario', '10.1.86.199'),
(16400, '12:53:51', '2016-10-28', 'sebastianrules', 'Loggeo exitoso', 'Login', 'usuario', '10.1.86.199'),
(16401, '12:54:21', '2016-10-28', 'johnny', 'Fallo loggeo', 'Login', 'usuario', '10.1.86.199'),
(16402, '12:54:45', '2016-10-28', 'sebastianrules', 'Loggeo exitoso', 'Login', 'usuario', '10.1.86.199'),
(16403, '12:55:52', '2016-10-28', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '10.1.86.199'),
(16404, '12:58:47', '2016-10-28', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '10.1.86.199'),
(16405, '13:09:21', '2016-10-28', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '10.1.86.199'),
(16406, '23:49:18', '2016-10-29', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16407, '00:55:00', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16408, '00:55:49', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16409, '01:02:22', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16410, '01:05:11', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16411, '01:06:26', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16412, '01:12:22', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16413, '01:16:37', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16414, '10:03:07', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16415, '10:04:26', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16416, '10:06:06', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16417, '10:08:58', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16418, '10:27:36', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16419, '10:34:58', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16420, '10:39:58', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16421, '10:41:07', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16422, '10:43:46', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16423, '10:51:08', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16424, '10:53:10', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16425, '10:54:51', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16426, '10:55:53', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16427, '10:56:38', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16428, '10:58:28', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16429, '11:03:03', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16430, '11:05:27', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16431, '11:17:39', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16432, '12:14:44', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16433, '12:15:22', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16434, '12:17:17', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16435, '12:17:29', '2016-10-30', 'johnny', 'Insertar', 'Insercion de documento: 769871', 'documento', '192.168.1.10'),
(16436, '12:18:20', '2016-10-30', 'johnny', 'Insertar', 'Insercion de documento: 769871', 'documento', '192.168.1.10'),
(16437, '12:19:41', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16438, '12:20:25', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16439, '12:22:25', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16440, '12:22:48', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16441, '12:23:29', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16442, '12:23:59', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16443, '12:25:24', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16444, '12:26:58', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16445, '12:28:57', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16446, '12:29:19', '2016-10-30', 'johnny', 'Insertar', 'Insercion de documento: 769871', 'documento', '192.168.1.10'),
(16447, '12:30:26', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16448, '12:31:26', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16449, '12:33:14', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16450, '12:33:29', '2016-10-30', 'johnny', 'Insertar', 'Insercion de documento: 769871', 'documento', '192.168.1.10'),
(16451, '12:33:50', '2016-10-30', 'johnny', 'Modificar', 'Modificacion de documento con codigo: 6', 'documento', '192.168.1.10'),
(16452, '12:55:33', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16453, '12:58:52', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16454, '13:07:14', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16455, '13:07:47', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16456, '13:11:06', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16457, '14:25:52', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16458, '14:39:01', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16459, '14:44:03', '2016-10-30', 'johnny', 'Insertar', 'Registro de aplicacion: 100--navegador', 'aplicacion', '192.168.1.10'),
(16460, '14:44:58', '2016-10-30', 'johnny', 'Asignacion/cambio permisos', 'Eliminacion de privilegios para usuario: johnny', 'usuario_privilegios', '192.168.1.10'),
(16461, '14:44:58', '2016-10-30', 'johnny', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: True del: True a usuario: johnny Sobre aplicacion: 100', 'usuario_privilegios', '192.168.1.10'),
(16462, '14:45:20', '2016-10-30', 'johnny', 'Insertar', 'Insercion de documento: 769871', 'documento', '192.168.1.10'),
(16463, '14:46:37', '2016-10-30', 'johnny', 'Asignacion/cambio permisos', 'Eliminacion de privilegios para usuario: johnny', 'usuario_privilegios', '192.168.1.10'),
(16464, '14:46:37', '2016-10-30', 'johnny', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: True del: True a usuario: johnny Sobre aplicacion: 100', 'usuario_privilegios', '192.168.1.10'),
(16465, '14:47:52', '2016-10-30', 'johnny', 'Asignacion/cambio permisos', 'Eliminacion de privilegios para usuario: johnny', 'usuario_privilegios', '192.168.1.10'),
(16466, '14:47:52', '2016-10-30', 'johnny', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: johnny Sobre aplicacion: 100', 'usuario_privilegios', '192.168.1.10'),
(16467, '14:48:58', '2016-10-30', 'johnny', 'Asignacion/cambio permisos', 'Eliminacion de privilegios para usuario: johnny', 'usuario_privilegios', '192.168.1.10'),
(16468, '14:48:58', '2016-10-30', 'johnny', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: False sel: False upd: True del: False a usuario: johnny Sobre aplicacion: 100', 'usuario_privilegios', '192.168.1.10'),
(16469, '14:49:45', '2016-10-30', 'johnny', 'Asignacion/cambio permisos', 'Eliminacion de privilegios para usuario: johnny', 'usuario_privilegios', '192.168.1.10'),
(16470, '14:49:45', '2016-10-30', 'johnny', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: False sel: True upd: True del: False a usuario: johnny Sobre aplicacion: 100', 'usuario_privilegios', '192.168.1.10'),
(16471, '15:52:53', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16472, '15:54:08', '2016-10-30', 'johnny', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16473, '15:54:24', '2016-10-30', 'johnny', 'Modificar', 'Modificacion de documento con codigo: 1', 'documento', '192.168.1.10'),
(16474, '15:54:55', '2016-10-30', 'johnny', 'Modificar', 'Modificacion de documento con codigo: 6', 'documento', '192.168.1.10'),
(16475, '10:07:45', '2016-10-31', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16476, '10:11:55', '2016-10-31', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16477, '10:12:52', '2016-10-31', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16478, '10:14:37', '2016-10-31', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16479, '10:15:18', '2016-10-31', 'usuariodbs', 'Modificar', 'Modificacion de documento con codigo: 4', 'documento', '10.1.82.209'),
(16480, '17:42:06', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16481, '17:45:08', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16482, '17:47:42', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16483, '18:15:15', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16484, '18:17:02', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16485, '18:20:01', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16486, '18:29:29', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16487, '18:33:19', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16488, '18:37:29', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16489, '18:39:20', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16490, '18:43:13', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16491, '18:46:26', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16492, '18:51:56', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16493, '18:55:18', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16494, '19:12:59', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16495, '07:47:42', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16496, '07:49:07', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16497, '07:57:11', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16498, '08:00:55', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16499, '08:01:36', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16500, '08:03:39', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16501, '08:04:40', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16502, '08:05:29', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16503, '08:17:50', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16504, '08:23:54', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16505, '08:26:57', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16506, '08:31:50', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209'),
(16507, '08:35:32', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.82.209');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodega`
--

CREATE TABLE IF NOT EXISTS `bodega` (
  `id_bodega_pk` int(11) NOT NULL AUTO_INCREMENT,
  `ubicacion` char(40) DEFAULT NULL,
  `nombre_bodega` char(40) DEFAULT NULL,
  `tamaño` char(50) DEFAULT NULL,
  PRIMARY KEY (`id_bodega_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `buzon`
--

CREATE TABLE IF NOT EXISTS `buzon` (
  `id_buzon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) NOT NULL,
  `fecha` date DEFAULT NULL,
  `descripcion` varchar(20) NOT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_buzon_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `tipo_categoria` char(25) DEFAULT NULL,
  `id_categoria_pk` int(10) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`tipo_categoria`, `id_categoria_pk`) VALUES
('Plato fuerte', 1),
('Postre', 2),
('Bebida', 3),
('Guarnicion', 4),
('Entrada', 5),
('Ensalada', 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `id_cliente_pk` int(11) NOT NULL AUTO_INCREMENT,
  `correo` char(50) DEFAULT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `nit` varchar(10) NOT NULL,
  `telefono` char(15) DEFAULT NULL,
  `direccion` varchar(30) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `id_tipocredito_pk` int(11) DEFAULT NULL,
  `id_contribuyente_pk` int(11) DEFAULT NULL,
  `id_tprecio_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_cliente_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE IF NOT EXISTS `compra` (
  `id_factura_pk` int(11) NOT NULL,
  `id_orden_compra_pk` int(11) NOT NULL,
  `serie_factura` char(15) DEFAULT NULL,
  `fecha_recibia` date DEFAULT NULL,
  `encargado` char(20) DEFAULT NULL,
  `total` decimal(10,0) DEFAULT NULL,
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `id_forma_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_factura_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `com_venta`
--

CREATE TABLE IF NOT EXISTS `com_venta` (
  `id_com_venta_pk` char(10) NOT NULL,
  `total_venta` char(10) DEFAULT NULL,
  `com_sobre_venta` char(10) DEFAULT NULL,
  `comision` char(10) DEFAULT NULL,
  `id_devengos_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_com_venta_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conciliaciones`
--

CREATE TABLE IF NOT EXISTS `conciliaciones` (
  `id_conciliacion_pk` char(10) NOT NULL,
  `id_documento_pk` char(10) NOT NULL,
  `fecha` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_conciliacion_pk`,`id_documento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `consultaalmacenada`
--

CREATE TABLE IF NOT EXISTS `consultaalmacenada` (
  `id_consulta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `tipo` varchar(10) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`id_consulta_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contribuyente`
--

CREATE TABLE IF NOT EXISTS `contribuyente` (
  `id_contribuyente_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` char(10) DEFAULT NULL,
  `nit` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_contribuyente_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `convertidora`
--

CREATE TABLE IF NOT EXISTS `convertidora` (
  `id` char(10) NOT NULL,
  `valor` float(8,0) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion`
--

CREATE TABLE IF NOT EXISTS `cotizacion` (
  `id_cotizacion_pk` int(11) NOT NULL,
  `nombre_cot` varchar(25) NOT NULL,
  `epllido_cot` varchar(25) NOT NULL,
  `nit_cot` varchar(25) NOT NULL,
  `telefono_cot` varchar(15) NOT NULL,
  `direccion_cot` varchar(50) NOT NULL,
  `id_detallecot_pk` int(11) DEFAULT NULL,
  `id_cliente_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_cotizacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion_bien`
--

CREATE TABLE IF NOT EXISTS `cotizacion_bien` (
  `id_detallecot_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_detallecot_pk`,`id_bien_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion_paquete`
--

CREATE TABLE IF NOT EXISTS `cotizacion_paquete` (
  `id_detallecot_pk` int(11) NOT NULL,
  `id_promocion_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detallecot_pk`,`id_promocion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_bancaria`
--

CREATE TABLE IF NOT EXISTS `cuenta_bancaria` (
  `id_cuenta_bancaria_pk` char(10) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `nombre_banco` char(10) DEFAULT NULL,
  `no_cuenta` char(10) DEFAULT NULL,
  `saldo_libros` char(10) DEFAULT NULL,
  `saldo_bancarios` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_cuenta_bancaria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_corriente_por_pagar`
--

CREATE TABLE IF NOT EXISTS `cuenta_corriente_por_pagar` (
  `id_cuenta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_proveedor_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_cuenta_pk`,`id_proveedor_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `deducciones`
--

CREATE TABLE IF NOT EXISTS `deducciones` (
  `id_presamo_pk` char(10) NOT NULL,
  `nombre` char(10) DEFAULT NULL,
  `detalle` char(10) DEFAULT NULL,
  `cantidad_deduccion` char(10) DEFAULT NULL,
  `cuotas` char(10) DEFAULT NULL,
  `fecha` char(10) DEFAULT NULL,
  `id_planilla_igss_pk` char(10) NOT NULL,
  `id_empleados_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_presamo_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_compra`
--

CREATE TABLE IF NOT EXISTS `detalle_compra` (
  `id_factura_pk` int(11) NOT NULL,
  `id_detalle_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio_compra` decimal(15,0) DEFAULT NULL,
  `subtotal_compra` decimal(15,0) DEFAULT NULL,
  `id_orden_compra_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_factura_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_cotizacion`
--

CREATE TABLE IF NOT EXISTS `detalle_cotizacion` (
  `id_detallecot_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad_detcot` varchar(10) NOT NULL,
  `desc_servicio_detcot` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_detallecot_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_cuenta_por_pagar`
--

CREATE TABLE IF NOT EXISTS `detalle_cuenta_por_pagar` (
  `detalle_cuenta_por_pagar_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `comprobante` int(11) DEFAULT NULL,
  `debe` decimal(15,0) DEFAULT NULL,
  `haber` decimal(15,0) DEFAULT NULL,
  `saldo` decimal(15,0) DEFAULT NULL,
  `id_cuenta_pk` int(11) DEFAULT NULL,
  `id_proveedor_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`detalle_cuenta_por_pagar_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_disp_banc`
--

CREATE TABLE IF NOT EXISTS `detalle_disp_banc` (
  `id_detalle_db_pk` char(10) NOT NULL,
  `id_disponibilidad_bancaria` char(10) NOT NULL,
  `id_documento_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_detalle_db_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_documento`
--

CREATE TABLE IF NOT EXISTS `detalle_documento` (
  `id_detalle_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_bien_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `no_doc` int(11) DEFAULT NULL,
  `serie_doc` int(11) DEFAULT NULL,
  `id_tipo_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_documentos`
--

CREATE TABLE IF NOT EXISTS `detalle_documentos` (
  `id_detalle_cv_pk` char(10) NOT NULL,
  `nombre_cuenta` char(10) DEFAULT NULL,
  `codigo_cuenta` char(10) DEFAULT NULL,
  `debe` char(10) DEFAULT NULL,
  `haber` char(10) DEFAULT NULL,
  `id_documento_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_detalle_cv_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_muestreo`
--

CREATE TABLE IF NOT EXISTS `detalle_muestreo` (
  `id_encabezado` int(11) NOT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `existencia` char(100) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_encabezado`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_nomina`
--

CREATE TABLE IF NOT EXISTS `detalle_nomina` (
  `id_dn` char(10) NOT NULL,
  `id_empleados_pk` char(10) NOT NULL,
  `id_nomina_pk` char(10) NOT NULL,
  `id_presamo_pk` char(10) NOT NULL,
  `id_devengos_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_dn`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido`
--

CREATE TABLE IF NOT EXISTS `detalle_pedido` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `id_bien_pk` int(11) NOT NULL,
  `cod_pedido` int(11) NOT NULL,
  `item_cod_producto` int(11) NOT NULL,
  `precio` decimal(5,2) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `estado_detalle` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_detalle`,`id_bien_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido_1`
--

CREATE TABLE IF NOT EXISTS `detalle_pedido_1` (
  `id_detalle_pedido_pk` char(10) NOT NULL,
  `id_encabezado_pedido_pk` char(10) NOT NULL,
  `cantidad` char(10) DEFAULT NULL,
  `id_menu_pk` char(10) DEFAULT NULL,
  `correlativo` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pedido_pk`,`id_encabezado_pedido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido_compra`
--

CREATE TABLE IF NOT EXISTS `detalle_pedido_compra` (
  `id_detalle_pk` int(11) NOT NULL,
  `id_orden_compra_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_detalle_requisicion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pk`,`id_orden_compra_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido_rest`
--

CREATE TABLE IF NOT EXISTS `detalle_pedido_rest` (
  `cantidad` double DEFAULT '1',
  `id_menu_pk` char(10) DEFAULT NULL,
  `descuento` double DEFAULT '0',
  `orden` int(10) NOT NULL AUTO_INCREMENT,
  `id_encabezado_pedido_pk` char(10) NOT NULL,
  `correlativo` int(10) NOT NULL,
  PRIMARY KEY (`id_encabezado_pedido_pk`,`orden`),
  KEY `Refmenu22` (`id_menu_pk`),
  KEY `holihehe` (`id_menu_pk`,`correlativo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Volcado de datos para la tabla `detalle_pedido_rest`
--

INSERT INTO `detalle_pedido_rest` (`cantidad`, `id_menu_pk`, `descuento`, `orden`, `id_encabezado_pedido_pk`, `correlativo`) VALUES
(1, 'BB', 0, 1, '20160006', 1),
(1, 'BB', 0, 2, '20160006', 1),
(1, 'BB', 0, 3, '20160006', 1),
(1, 'BB', 0, 4, '20160006', 1),
(1, 'BB', 0, 5, '20160006', 1),
(1, 'BB', 0, 6, '20160006', 1),
(1, 'BB', 0, 7, '20160006', 1),
(0, '', 0, 8, '20160006', 0),
(1, 'BB', 0, 1, '20160007', 2),
(1, 'BB', 0, 2, '20160007', 2),
(1, 'BB', 0, 3, '20160007', 2),
(1, 'BB', 0, 4, '20160007', 2),
(1, 'BB', 0, 5, '20160007', 2),
(1, 'BB', 0, 6, '20160007', 2),
(1, 'BB', 0, 7, '20160007', 2),
(1, 'BB', 0, 8, '20160007', 2),
(1, 'BB', 0, 9, '20160007', 2),
(1, 'BB', 0, 10, '20160007', 2),
(1, 'BB', 0, 11, '20160007', 2),
(1, 'BB', 0, 12, '20160007', 2),
(1, 'BB', 0, 13, '20160007', 2),
(1, 'BB', 0, 14, '20160007', 2),
(1, 'BB', 0, 15, '20160007', 2),
(1, 'BB', 0, 1, '20160008', 1),
(1, 'BB', 0, 2, '20160008', 1),
(1, 'BB', 0, 3, '20160008', 1),
(1, 'BB', 0, 4, '20160008', 1),
(1, 'BB', 0, 5, '20160008', 1),
(0, '', 0, 6, '20160008', 0),
(1, 'BB', 0, 1, '20160009', 2),
(1, 'PF', 0, 2, '20160009', 1),
(0, '', 0, 3, '20160009', 0),
(1, 'BB', 0, 1, '20160010', 1),
(1, 'PF', 0, 2, '20160010', 1),
(0, '', 0, 3, '20160010', 0),
(1, 'BB', 0, 1, '20160011', 1),
(1, 'BB', 0, 2, '20160011', 1),
(1, 'PF', 0, 3, '20160011', 1),
(0, '', 0, 4, '20160011', 0),
(1, 'BB', 0, 1, '20160012', 1),
(1, 'BB', 0, 2, '20160012', 1),
(1, 'BB', 0, 3, '20160012', 1),
(1, 'BB', 0, 4, '20160012', 1),
(1, 'BB', 0, 1, '20160013', 1),
(1, 'BB', 0, 2, '20160013', 1),
(1, 'BB', 0, 3, '20160013', 1),
(1, 'BB', 0, 4, '20160013', 1),
(1, 'PF', 0, 5, '20160013', 1),
(1, 'BB', 0, 1, '20160014', 1),
(1, 'BB', 0, 2, '20160014', 1),
(1, 'BB', 0, 3, '20160014', 1),
(1, 'BB', 0, 4, '20160014', 1),
(1, 'PF', 0, 1, '20160015', 1),
(1, 'BB', 0, 1, '20160017', 2),
(1, 'BB', 0, 2, '20160017', 2),
(1, 'BB', 0, 3, '20160017', 2),
(1, 'PF', 0, 4, '20160017', 1),
(1, 'PF', 0, 1, '20160018', 1),
(1, 'BB', 0, 1, '20160021', 1),
(1, 'BB', 0, 2, '20160021', 1),
(1, 'BB', 0, 3, '20160021', 1),
(1, 'BB', 0, 4, '20160021', 2),
(1, 'BB', 0, 1, '20160022', 1),
(1, 'BB', 0, 1, '20160023', 1),
(1, 'BB', 0, 2, '20160023', 1),
(1, 'BB', 0, 3, '20160023', 1),
(1, 'BB', 0, 4, '20160023', 1),
(1, 'BB', 0, 1, '20160024', 1),
(1, 'BB', 0, 2, '20160024', 1),
(50, 'BB', 0, 1, '20160025', 2),
(4567, 'BB', 0, 2, '20160025', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_planilla_igss`
--

CREATE TABLE IF NOT EXISTS `detalle_planilla_igss` (
  `id_detalle_pigss` char(10) NOT NULL,
  `id_planilla_igss_pk` char(10) NOT NULL,
  `id_empleados_pk` char(10) NOT NULL,
  `sueldo_base` char(10) DEFAULT NULL,
  `porcentaje_igss` char(10) DEFAULT NULL,
  `igss_pagar` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pigss`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_produccion`
--

CREATE TABLE IF NOT EXISTS `detalle_produccion` (
  `correlativo` char(10) NOT NULL,
  `id_produccion_pk` char(10) NOT NULL,
  `cantidad_mp` char(10) DEFAULT NULL,
  `id_detalle_pedido_pk` char(10) NOT NULL,
  `id_encabezado_pedido_pk` char(10) NOT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`correlativo`,`id_produccion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_receta_mp`
--

CREATE TABLE IF NOT EXISTS `detalle_receta_mp` (
  `correlativo` char(10) NOT NULL,
  `id_receta_pk` char(10) NOT NULL,
  `cantidad` char(10) DEFAULT NULL,
  `id_proceso_pk` char(10) DEFAULT NULL,
  `id_medida_pk` char(10) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`correlativo`,`id_receta_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_requisicion`
--

CREATE TABLE IF NOT EXISTS `detalle_requisicion` (
  `id_detalle_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_requisicion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `deuda`
--

CREATE TABLE IF NOT EXISTS `deuda` (
  `id_deuda` int(11) NOT NULL AUTO_INCREMENT,
  `monto` char(10) DEFAULT NULL,
  `saldo_total` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_fac_empresa_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_deuda`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devengos`
--

CREATE TABLE IF NOT EXISTS `devengos` (
  `id_devengos_pk` char(10) NOT NULL,
  `nombre` char(10) DEFAULT NULL,
  `detalle` char(10) DEFAULT NULL,
  `cantidad_debengado` char(10) DEFAULT NULL,
  `cuotas` char(10) DEFAULT NULL,
  `fecha` char(10) DEFAULT NULL,
  `id_empleados_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_devengos_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `disponibilidad_bancaria`
--

CREATE TABLE IF NOT EXISTS `disponibilidad_bancaria` (
  `id_disponibilidad_bancaria` char(10) NOT NULL,
  `fecha` char(10) DEFAULT NULL,
  `id_cuenta_bancaria_pk` char(10) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_tipo_documento` char(10) NOT NULL,
  PRIMARY KEY (`id_disponibilidad_bancaria`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `documento`
--

CREATE TABLE IF NOT EXISTS `documento` (
  `id_documento_pk` int(10) NOT NULL AUTO_INCREMENT,
  `conciliado` char(10) DEFAULT NULL,
  `fecha` char(10) DEFAULT NULL,
  `valor_total` char(10) DEFAULT NULL,
  `destinatario` char(10) DEFAULT NULL,
  `no_documento` char(10) DEFAULT NULL,
  `descripcion` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT 'ACTIVO',
  `id_fac_pk` int(11) DEFAULT NULL,
  `id_cuenta_bancaria_pk` char(10) NOT NULL,
  `id_tipo_documento` char(10) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_documento_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Volcado de datos para la tabla `documento`
--

INSERT INTO `documento` (`id_documento_pk`, `conciliado`, `fecha`, `valor_total`, `destinatario`, `no_documento`, `descripcion`, `estado`, `id_fac_pk`, `id_cuenta_bancaria_pk`, `id_tipo_documento`, `id_empresa_pk`, `id_bien_pk`, `id_fac_empresa_pk`, `id_cuenta_pk`, `id_proveedor_pk`) VALUES
(1, 'conciliado', '2016-10-30', '544.00', 'asdasdas', '769871', 'asdoasio', 'ACTIVO', NULL, '1', '546512', 1, 1, 1, 1, 1),
(2, NULL, '2016-10-13', NULL, 'df asda', '769871', 'asdasda', NULL, NULL, '', '', 0, 0, 0, 0, 0),
(3, NULL, '2016-10-21', NULL, 'asdasas', '769871', 'asdas', NULL, NULL, '', '', 0, 0, 0, 0, 0),
(4, NULL, '2016-10-04', NULL, 'ASDASDAS', '769871', 'ASADASA', 'ACTIVO', NULL, '', '', 0, 0, 0, 0, 0),
(5, NULL, '2016-10-30', NULL, 'zcascsa', '769871', 'ascascas', 'ACTIVO', NULL, '', '', 0, 0, 0, 0, 0),
(6, NULL, '2016-10-06', NULL, 'asdas', '769871', 'asdasd', 'ACTIVO', NULL, '', '', 0, 0, 0, 0, 0),
(7, NULL, '2016-10-30', NULL, 'dvsca', '769871', 'asdasda', 'ACTIVO', NULL, '', '', 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE IF NOT EXISTS `empleado` (
  `id_empleados_pk` char(10) NOT NULL,
  `nombre` char(10) DEFAULT NULL,
  `telefono` char(10) DEFAULT NULL,
  `direccion` char(10) DEFAULT NULL,
  `genero` char(10) DEFAULT NULL,
  `fecha_nacimiento` char(10) DEFAULT NULL,
  `fecha_ingreso` char(10) DEFAULT NULL,
  `fecha_egreso` char(10) DEFAULT NULL,
  `dpi` char(10) DEFAULT NULL,
  `no_afiliacion_igss` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `disponibilidad` int(11) DEFAULT '1',
  `jornada` char(15) DEFAULT 'diurna',
  PRIMARY KEY (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`id_empleados_pk`, `nombre`, `telefono`, `direccion`, `genero`, `fecha_nacimiento`, `fecha_ingreso`, `fecha_egreso`, `dpi`, `no_afiliacion_igss`, `id_empresa_pk`, `disponibilidad`, `jornada`) VALUES
('201', 'Papajohns', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, 'diurna'),
('202', 'Chaca', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, 'diurna'),
('203', 'Chacax', NULL, NULL, NULL, '1966', '2016-10-21', NULL, '217006951', NULL, 2, 1, 'diurna'),
('204', 'Sebastian', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, 'diurna'),
('206', 'johnny', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, 'diurna');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE IF NOT EXISTS `empresa` (
  `id_empresa_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `direccion` varchar(30) NOT NULL,
  `region` char(20) NOT NULL,
  `estrellas_hotel` varchar(15) NOT NULL,
  `nit` char(10) DEFAULT NULL,
  `correo` char(35) DEFAULT NULL,
  `telefono` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`id_empresa_pk`, `nombre`, `direccion`, `region`, `estrellas_hotel`, `nit`, `correo`, `telefono`) VALUES
(1, 'CHRIX', 'ciudad', 'norte', '5', NULL, NULL, NULL),
(2, 'CHRIS', 'ciudad', 'norte', '5', NULL, NULL, NULL),
(3, 'MARVS', 'ciudad', 'norte', '5', NULL, NULL, NULL),
(4, 'GABY', 'ciudad', 'norte', '5', NULL, NULL, NULL),
(5, 'GABY', 'ciudad', 'norte', '5', NULL, NULL, NULL),
(6, 'GABY', 'ciudad', 'norte', '5', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_documento`
--

CREATE TABLE IF NOT EXISTS `encabezado_documento` (
  `no_doc` int(11) NOT NULL,
  `serie_doc` int(11) NOT NULL,
  `id_tipo_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `empresa` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`no_doc`,`serie_doc`,`id_tipo_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_muestreo`
--

CREATE TABLE IF NOT EXISTS `encabezado_muestreo` (
  `id_encabezado` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `responsable` char(50) DEFAULT NULL,
  PRIMARY KEY (`id_encabezado`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_pedido`
--

CREATE TABLE IF NOT EXISTS `encabezado_pedido` (
  `id_encabezado_pedido_pk` char(10) NOT NULL,
  `hora_ingreso` char(10) DEFAULT NULL,
  `id_cliente_pk` char(10) DEFAULT NULL,
  `fecha_ingreso` char(10) DEFAULT NULL,
  `fecha_entrega` date DEFAULT NULL,
  `hora_entrega` varchar(10) DEFAULT NULL,
  `id_empleados_pk` char(10) DEFAULT NULL,
  `id_empresa_pk` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT 'pend',
  PRIMARY KEY (`id_encabezado_pedido_pk`),
  KEY `k3` (`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `encabezado_pedido`
--

INSERT INTO `encabezado_pedido` (`id_encabezado_pedido_pk`, `hora_ingreso`, `id_cliente_pk`, `fecha_ingreso`, `fecha_entrega`, `hora_entrega`, `id_empleados_pk`, `id_empresa_pk`, `estado`) VALUES
('20160001', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160002', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160003', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160004', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160005', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160006', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160007', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160008', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160009', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160010', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160011', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160012', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160013', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160014', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160015', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160016', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160017', '', '', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160018', '', '', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160019', '', '', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160020', '', '', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160021', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160022', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160023', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160024', '', '1', '2016-10-27', '2016-10-27', '', '203', '2', 'pend'),
('20160025', '12:30pm', '1', '2016-10-28', '2016-11-02', '12:30pm', '203', '2', 'pend');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `evento`
--

CREATE TABLE IF NOT EXISTS `evento` (
  `id_evento_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `fecha_entrada` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `hora_entrada` time NOT NULL,
  `hora_salida` time NOT NULL,
  `costo` int(11) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_salon_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_evento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE IF NOT EXISTS `factura` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `fecha_vencimiento` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `fecha_emision` date NOT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_impuesto_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_detalle`
--

CREATE TABLE IF NOT EXISTS `factura_detalle` (
  `id_bien_pk` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio` int(11) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_fac_empresa_pk`,`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_pago`
--

CREATE TABLE IF NOT EXISTS `factura_pago` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_forma_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_forma_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio`
--

CREATE TABLE IF NOT EXISTS `folio` (
  `id_cuenta_pagar_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado` varchar(10) NOT NULL,
  `fecha_ingreso` date NOT NULL,
  `fecha_pago` date DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_cuenta_pagar_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_bien`
--

CREATE TABLE IF NOT EXISTS `folio_bien` (
  `id_folio_bien_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_folio_bien_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_factura`
--

CREATE TABLE IF NOT EXISTS `folio_factura` (
  `id_cuenta_pagar_pk` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_cuenta_pagar_pk`,`id_fac_empresa_pk`,`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_habitacion`
--

CREATE TABLE IF NOT EXISTS `folio_habitacion` (
  `id_folio_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_habitacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_promocion`
--

CREATE TABLE IF NOT EXISTS `folio_promocion` (
  `id_folio_promocion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` int(11) NOT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_promocion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_salon`
--

CREATE TABLE IF NOT EXISTS `folio_salon` (
  `id_folio_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_salon_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_salon_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `forma_pago`
--

CREATE TABLE IF NOT EXISTS `forma_pago` (
  `id_forma_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_pago` char(25) DEFAULT NULL,
  `descripcion` char(50) DEFAULT NULL,
  PRIMARY KEY (`id_forma_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gastos_importacion`
--

CREATE TABLE IF NOT EXISTS `gastos_importacion` (
  `id_importacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `transporte` char(25) DEFAULT NULL,
  `direccion_salida` char(25) DEFAULT NULL,
  `hora_fecha_salida` date DEFAULT NULL,
  `direccion_llegada` char(25) DEFAULT NULL,
  `hora_fecha_llegada` date DEFAULT NULL,
  `aduana` decimal(15,0) DEFAULT NULL,
  `otros_impuestos` decimal(15,0) DEFAULT NULL,
  `id_factura_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_importacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `habitacion`
--

CREATE TABLE IF NOT EXISTS `habitacion` (
  `id_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `nivel` int(11) DEFAULT NULL,
  `estrellas_habitacion` varchar(10) NOT NULL,
  `descripcion` varchar(10) DEFAULT NULL,
  `estado` char(10) NOT NULL,
  `id_tipo_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_habitacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `horas_extra`
--

CREATE TABLE IF NOT EXISTS `horas_extra` (
  `id_horas_extra_pk` char(10) NOT NULL,
  `fecha_inicio` char(10) DEFAULT NULL,
  `fecha_fin` char(10) DEFAULT NULL,
  `horas_extra` char(10) DEFAULT NULL,
  `monto_horas_extra` char(10) DEFAULT NULL,
  `sueldo_horas_extra` char(10) DEFAULT NULL,
  `id_devengos_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_horas_extra_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `impuesto`
--

CREATE TABLE IF NOT EXISTS `impuesto` (
  `id_impuesto_pk` int(11) NOT NULL AUTO_INCREMENT,
  `porcentaje` decimal(18,2) DEFAULT NULL,
  `nombre` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_impuesto_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `invitado`
--

CREATE TABLE IF NOT EXISTS `invitado` (
  `id_invitado_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `dpi` varchar(20) DEFAULT NULL,
  `correo` varchar(30) DEFAULT NULL,
  `id_evento_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_invitado_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE IF NOT EXISTS `marca` (
  `id_marca_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_marca` char(50) DEFAULT NULL,
  PRIMARY KEY (`id_marca_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca_producto`
--

CREATE TABLE IF NOT EXISTS `marca_producto` (
  `id_marca_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `fecha` date DEFAULT NULL,
  `precio` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`id_marca_pk`,`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medida`
--

CREATE TABLE IF NOT EXISTS `medida` (
  `id_medida_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_medida` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_medida_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medida_1`
--

CREATE TABLE IF NOT EXISTS `medida_1` (
  `id_medida_pk` char(10) NOT NULL,
  `valor` char(10) DEFAULT NULL,
  `nombre_medida` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_medida_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `menu`
--

CREATE TABLE IF NOT EXISTS `menu` (
  `id_menu_pk` char(10) NOT NULL,
  `correlativo` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` char(50) DEFAULT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `id_receta_pk` char(10) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_menu_pk`,`correlativo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Volcado de datos para la tabla `menu`
--

INSERT INTO `menu` (`id_menu_pk`, `correlativo`, `nombre`, `descripcion`, `id_receta_pk`, `id_precio`) VALUES
('PF', 1, 'Carne asada', NULL, NULL, 4),
('PF', 2, 'Carne adobada', NULL, NULL, 4),
('PF', 3, 'Carnitas', NULL, NULL, 4),
('PF', 4, 'hoho', NULL, NULL, 4),
('BB', 1, 'Cerveza', NULL, NULL, 1),
('BB', 2, 'Cerveza', NULL, NULL, 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimiento_inventario`
--

CREATE TABLE IF NOT EXISTS `movimiento_inventario` (
  `id_movimiento_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_mov` date DEFAULT NULL,
  `id_transaccion_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `no_doc` int(11) DEFAULT NULL,
  `serie_doc` int(11) DEFAULT NULL,
  `id_tipo_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_movimiento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nomina`
--

CREATE TABLE IF NOT EXISTS `nomina` (
  `id_nomina_pk` char(10) NOT NULL,
  `fecha` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_nomina_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `obj_perdido`
--

CREATE TABLE IF NOT EXISTS `obj_perdido` (
  `id_obj_perdido_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` char(30) NOT NULL,
  `descripcion` char(100) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_obj_perdido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `operacion`
--

CREATE TABLE IF NOT EXISTS `operacion` (
  `id_operacion` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` char(10) DEFAULT NULL,
  `descripcion` char(10) DEFAULT NULL,
  `fecha_emision` char(10) DEFAULT NULL,
  `id_deuda` int(11) DEFAULT NULL,
  `id_doc` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_operacion`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden_pedido_compra`
--

CREATE TABLE IF NOT EXISTS `orden_pedido_compra` (
  `id_orden_compra_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `encargado` char(25) DEFAULT NULL,
  `estado_pedido` char(20) DEFAULT NULL,
  `observaciones` char(30) DEFAULT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `id_requisicion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_orden_compra_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paquetes_eventos`
--

CREATE TABLE IF NOT EXISTS `paquetes_eventos` (
  `id_paquetes_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_evento_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_paquetes_salon_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paquetes_reservacion_habitacion`
--

CREATE TABLE IF NOT EXISTS `paquetes_reservacion_habitacion` (
  `id_paquetes_reservacion_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_reserhabit_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_paquetes_reservacion_habitacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paquete_inventario`
--

CREATE TABLE IF NOT EXISTS `paquete_inventario` (
  `id_paquete_inventario` int(11) NOT NULL AUTO_INCREMENT,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_paquete_inventario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_cotizacion`
--

CREATE TABLE IF NOT EXISTS `pedido_cotizacion` (
  `id_cotizacion_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_cotizacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_factura`
--

CREATE TABLE IF NOT EXISTS `pedido_factura` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE IF NOT EXISTS `perfil` (
  `id_perfil` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_perfil` char(40) DEFAULT NULL,
  PRIMARY KEY (`id_perfil`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`id_perfil`, `nombre_perfil`) VALUES
(1, 'colocador'),
(2, 'holis'),
(3, 'holis'),
(4, 'cajero'),
(5, 'cociinero'),
(6, 'holi');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_privilegios`
--

CREATE TABLE IF NOT EXISTS `perfil_privilegios` (
  `id_aplicacion` int(11) NOT NULL,
  `id_perfil` int(11) NOT NULL,
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_aplicacion`,`id_perfil`),
  KEY `Refperfil4` (`id_perfil`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `perfil_privilegios`
--

INSERT INTO `perfil_privilegios` (`id_aplicacion`, `id_perfil`, `ins`, `sel`, `upd`, `del`) VALUES
(100, 1, 1, 1, 1, 1),
(10204, 2, 1, 1, 0, 0),
(10204, 3, 1, 1, 0, 0),
(10204, 4, 1, 0, 0, 0),
(10204, 5, 1, 1, 0, 1),
(10204, 6, 0, 1, 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `planilla_igss`
--

CREATE TABLE IF NOT EXISTS `planilla_igss` (
  `id_planilla_igss_pk` char(10) NOT NULL,
  `sueldo` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_planilla_igss_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `precio`
--

CREATE TABLE IF NOT EXISTS `precio` (
  `id_precio` int(11) NOT NULL AUTO_INCREMENT,
  `precio` double NOT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_tamaniop_pk` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_precio`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `precio`
--

INSERT INTO `precio` (`id_precio`, `precio`, `id_bien_pk`, `id_categoria_pk`, `id_tamaniop_pk`) VALUES
(1, 20, NULL, '1', '1'),
(2, 49, NULL, '2', '2'),
(3, 49, NULL, '2', '2'),
(4, 4, NULL, '3', '3'),
(5, 45, NULL, '4', '5'),
(6, 45, NULL, '3', '5');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `problema`
--

CREATE TABLE IF NOT EXISTS `problema` (
  `id_problema_pk` int(11) NOT NULL AUTO_INCREMENT,
  `asunto` char(20) NOT NULL,
  `descripcion` char(100) NOT NULL,
  `fecha` date NOT NULL,
  `estado` char(20) NOT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_problema_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proceso`
--

CREATE TABLE IF NOT EXISTS `proceso` (
  `id_proceso_pk` char(10) NOT NULL,
  `observacion` char(100) DEFAULT NULL,
  `caracteristica_proceso` char(100) DEFAULT NULL,
  `nombre_proceso` char(20) DEFAULT NULL,
  `tiempo_proceso` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_proceso_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `produccion`
--

CREATE TABLE IF NOT EXISTS `produccion` (
  `id_produccion_pk` char(10) NOT NULL,
  `costo_mano_de_obra` char(10) DEFAULT NULL,
  `costo_materia_prima` char(10) DEFAULT NULL,
  `costo_maquinaria` char(10) DEFAULT NULL,
  `hora_produccion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `fecha_produccion` date DEFAULT NULL,
  `hrs_produccion` char(10) DEFAULT NULL,
  `costo_produccion` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_produccion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_bodega`
--

CREATE TABLE IF NOT EXISTS `producto_bodega` (
  `id_bien_pk` int(11) NOT NULL,
  `id_bodega_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `existencia` int(11) DEFAULT NULL,
  `existencia_congelada` int(11) DEFAULT NULL,
  `existencia_auditada` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_bodega_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `promocion`
--

CREATE TABLE IF NOT EXISTS `promocion` (
  `id_promocion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_paquete` varchar(10) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `costo` decimal(10,2) NOT NULL,
  `detalle` varchar(100) NOT NULL,
  `id_salon_pk` int(11) DEFAULT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_promocion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE IF NOT EXISTS `proveedor` (
  `id_proveedor_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_proveedor` char(25) DEFAULT NULL,
  `direccion` date DEFAULT NULL,
  `telefono` char(15) DEFAULT NULL,
  `correo_electronico` char(50) DEFAULT NULL,
  PRIMARY KEY (`id_proveedor_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `receta`
--

CREATE TABLE IF NOT EXISTS `receta` (
  `id_receta_pk` char(10) NOT NULL,
  `nombre_receta` char(30) DEFAULT NULL,
  `horas_hombre` char(10) DEFAULT NULL,
  `costo_receta` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_receta_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporteador`
--

CREATE TABLE IF NOT EXISTS `reporteador` (
  `id_reporteador` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) DEFAULT NULL,
  `ubicacion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_reporteador`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `requisicion`
--

CREATE TABLE IF NOT EXISTS `requisicion` (
  `id_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `encargado` char(50) DEFAULT NULL,
  `id_detalle_requisicion_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_requisicion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reservacion_habitacion`
--

CREATE TABLE IF NOT EXISTS `reservacion_habitacion` (
  `id_reserhabit_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_entreda` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `hora_entreda` time NOT NULL,
  `hora_salida` time NOT NULL,
  `id_cliente_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_reserhabit_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salon`
--

CREATE TABLE IF NOT EXISTS `salon` (
  `id_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `descripcion` varchar(20) NOT NULL,
  `dimiencion` varchar(20) NOT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_salon_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tamanio_porcion`
--

CREATE TABLE IF NOT EXISTS `tamanio_porcion` (
  `tamanio` varchar(100) NOT NULL,
  `id_tamaniop_pk` int(10) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_tamaniop_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Volcado de datos para la tabla `tamanio_porcion`
--

INSERT INTO `tamanio_porcion` (`tamanio`, `id_tamaniop_pk`) VALUES
('16oz', 1),
('Media porcion', 2),
('Porcion completa', 3),
('10oz', 4),
('24oz', 5),
('8oz', 6),
('200g', 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tiempo_vida`
--

CREATE TABLE IF NOT EXISTS `tiempo_vida` (
  `id_tiempo_vida_pk` char(10) NOT NULL,
  `fecha_prod` char(10) DEFAULT NULL,
  `tiempo_caducidad` char(10) DEFAULT NULL,
  `fecha_vencimiento` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_tiempo_vida_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo`
--

CREATE TABLE IF NOT EXISTS `tipo` (
  `id_tipo_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nivel_tipo` char(100) DEFAULT NULL,
  `capacidad_tipo` int(11) DEFAULT NULL,
  `especificaciones_tipo` varchar(1000) DEFAULT NULL,
  `costo_tipo` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipousuario`
--

CREATE TABLE IF NOT EXISTS `tipousuario` (
  `idUsuario` int(11) NOT NULL,
  `tipo` varchar(100) NOT NULL,
  `descripcion` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipousuario`
--

INSERT INTO `tipousuario` (`idUsuario`, `tipo`, `descripcion`) VALUES
(1, 'admin', 'administrador del sistema'),
(2, 'cliente', 'opciones limitadas'),
(3, 'empleado', 'conRestricciones');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `usuario` char(50) NOT NULL,
  `contrasenia` char(80) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleados_pk` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`usuario`, `contrasenia`, `fecha_creacion`, `estado`, `id_empleados_pk`, `id_empresa_pk`) VALUES
('hjadsfhadsfjkasfhjadsflk', 'MQAyADMA', '2016-10-24', NULL, '201', 1),
('hola', 'MQAyADMA', '2016-10-20', NULL, '202', 1),
('hoho', 'MQAyADMA', '2016-10-21', NULL, '204', 1),
('johnny', 'aABvAGwAYQA=', '2016-10-19', 'activo', '203', 1),
('sebastianrules', 'hola', '2016-10-20', NULL, '204', 1),
('usuariodbs', 'aABvAGwAYQA=', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_privilegios`
--

CREATE TABLE IF NOT EXISTS `usuario_privilegios` (
  `usuario` char(50) NOT NULL,
  `id_aplicacion` int(11) NOT NULL,
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL,
  `id_perfil` int(11) DEFAULT NULL,
  PRIMARY KEY (`usuario`,`id_aplicacion`),
  KEY `Refperfil1` (`id_perfil`),
  KEY `Refaplicacion6` (`id_aplicacion`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuario_privilegios`
--

INSERT INTO `usuario_privilegios` (`usuario`, `id_aplicacion`, `ins`, `sel`, `upd`, `del`, `id_perfil`) VALUES
('hola', 10204, 0, 1, 1, 0, 0),
('hoho', 10204, 1, 0, 0, 0, 0),
('hjadsfhadsfjkasfhjadsflk', 10204, 1, 1, 1, 0, 0),
('sebastianrules', 10204, 1, 1, 1, 1, 0),
('johnny', 100, 0, 1, 1, 0, 0),
('usuariodbs', 100, 0, 1, 1, 1, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

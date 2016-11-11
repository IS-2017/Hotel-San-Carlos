-- phpMyAdmin SQL Dump
-- version 4.1.12
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-11-2016 a las 07:38:24
-- Versión del servidor: 5.5.36
-- Versión de PHP: 5.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `base6`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `cuenta`(fi char(20),ff char(20),id_p char(20),t_anterior char(20))
begin
 declare T int;
 set @T:= t_anterior;
 SELECT fecha,comprobante, debe,haber, IF(debe='0',(@T:=@T-haber),(@T:=@T+debe)) AS saldo FROM detalle_cuenta_por_pagar where fecha between fi and ff and id_proveedor_pk = id_p;
 end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `kardex`( fecha_inicio char(20), fecha_fin char(20) , T_inicial char(20))
begin 
DECLARE T int;
SET @T:= T_inicial;
SELECT id_movimiento_pk, fecha_mov, id_bien_pk , id_categoria_pk , transaccion ,cantidad  ,IF( transaccion  ='Compra' or transaccion = 'Devolucion sobre venta' ,(@T:=@T+cantidad),(@T:=@T-cantidad )) AS Saldo FROM movimiento_inventario where fecha_mov between fecha_inicio and fecha_fin;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Ultimo_saldo_anterior`( fecha_inicio char(20))
begin 
DECLARE T int;
SET @T:= 0;
SELECT IF( transaccion  ='Compra' or transaccion = 'Devolucion sobre venta' ,(@T:=@T+cantidad),(@T:=@T-cantidad )) AS Saldo FROM movimiento_inventario where fecha_mov <fecha_inicio;
end$$

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

CREATE DEFINER=`root`@`localhost` FUNCTION `ObtenerCorrelativoBien`(categoria nvarchar(18)) RETURNS int(11)
IF (select count(*) from bien where id_categoria_pk = categoria) > 0 THEN
BEGIN
DECLARE ult_corr int; 
DECLARE nuevo_corr int; 
select max(id_bien_pk) into ult_corr from bien where id_categoria_pk = categoria;
set nuevo_corr = ult_corr + 1; 
return nuevo_corr;
END;
ELSE 
return 1;
END IF$$

CREATE DEFINER=`root`@`localhost` FUNCTION `registraroperacion`(iusuario nvarchar(100), iaccion nvarchar(500), idescrip nvarchar(500),itabla nvarchar(50), iip nvarchar(20)) RETURNS int(2)
BEGIN
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,idescrip,iaccion,itabla,iip);
    return 1;
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `ValidarContrasena`(iusuario nvarchar(20), icon nvarchar(20), iip nvarchar(20)) RETURNS int(2)
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
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15113 ;

--
-- Volcado de datos para la tabla `aplicacion`
--

INSERT INTO `aplicacion` (`id_aplicacion`, `nombre_aplicacion`) VALUES
(15101, 'folio'),
(15111, 'reservacion hotel'),
(15104, 'habitacion'),
(15112, 'evento'),
(13106, 'Empleados'),
(13109, 'Devengos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignacion_mo`
--

CREATE TABLE IF NOT EXISTS `asignacion_mo` (
  `id_encabezado_pedido_pk` char(10) DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `cant_horas` float(8,0) DEFAULT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  KEY `Ref238401` (`id_empleados_pk`),
  KEY `Ref186306` (`id_encabezado_pedido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bien`
--

CREATE TABLE IF NOT EXISTS `bien` (
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `precio` decimal(18,0) DEFAULT NULL,
  `costo` decimal(10,0) DEFAULT NULL,
  `descripcion` char(80) DEFAULT NULL,
  `id_linea_pk` int(11) DEFAULT NULL,
  `apartados` int(11) DEFAULT NULL,
  `metodologia` char(40) DEFAULT NULL,
  `id_medida_pk` int(11) DEFAULT NULL,
  `porcentaje_comision` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_marca_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_categoria_pk`),
  KEY `Ref189404` (`id_medida_pk`),
  KEY `Ref14425` (`id_marca_pk`),
  KEY `Ref249431` (`id_linea_pk`),
  KEY `Ref98` (`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bien`
--

INSERT INTO `bien` (`id_bien_pk`, `id_categoria_pk`, `precio`, `costo`, `descripcion`, `id_linea_pk`, `apartados`, `metodologia`, `id_medida_pk`, `porcentaje_comision`, `estado`, `id_marca_pk`) VALUES
(1, 'AF', '865', '679', 'Televisor', 9, 0, NULL, 1, '1', 'activo', 7),
(1, 'PT', '184', '23', 'pollo dorado', 7, NULL, NULL, 1, NULL, 'activo', 4),
(3, 'PT', '0', '23', 'Jamon de pavo', 6, 0, NULL, 1, '1', 'activo', 3),
(2, 'P', '0', '23', 'Salsa de tomate', 8, 0, NULL, 1, '1', 'activo', 6),
(1, 'MP', '0', '12', 'Pimienta', 8, 0, NULL, 1, '2', 'activo', 5),
(4, 'MP', '0', '12', 'Chile verde', 8, 0, NULL, 1, '1', 'activo', 6),
(5, 'MP', '26', '23', 'leche deslactosada', 3, 0, NULL, 3, '1', 'activo', 4),
(6, 'MP', '0', '34', 'mantequilla', 3, 0, NULL, 2, '1', 'activo', 3),
(2, 'PT', '75', '58', 'Version2licuado', 7, NULL, NULL, 1, NULL, 'activo', 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bien_habitacion`
--

CREATE TABLE IF NOT EXISTS `bien_habitacion` (
  `id_bien_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `existencia` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_habitacion_pk`,`id_categoria_pk`),
  KEY `Ref112` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Ref2086` (`id_habitacion_pk`),
  KEY `Refbien12` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16637 ;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`id_bit`, `hora`, `fecha`, `usuario`, `descripcion`, `accion`, `tabla`, `ip`) VALUES
(16100, '20:51:26', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16101, '20:51:35', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16102, '20:52:47', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16103, '21:04:26', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16104, '21:05:15', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16105, '21:06:30', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16106, '21:07:21', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16107, '21:07:54', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16108, '21:07:59', '2016-11-07', 'usuariodbs', 'Insertar', 'insercion de nueva reservacion', 'reservacion_habitacion', '192.168.0.20'),
(16109, '21:09:35', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16110, '21:09:50', '2016-11-07', 'usuariodbs', 'Insertar', 'insercion de nueva reservacion', 'reservacion_habitacion', '192.168.0.20'),
(16111, '21:09:53', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16112, '21:11:56', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16113, '21:11:59', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16114, '21:12:47', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16115, '21:13:15', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16116, '21:16:32', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16117, '21:17:29', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16118, '21:17:37', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16119, '21:17:51', '2016-11-07', 'usuariodbs', 'Insertar', 'insercion de nueva reservacion', 'reservacion_habitacion', '192.168.56.1'),
(16120, '21:18:11', '2016-11-07', 'usuariodbs', 'Modificar', 'modifico una reservacion', 'reservacion_habitacion', '192.168.56.1'),
(16121, '21:18:17', '2016-11-07', 'usuariodbs', 'Eliminar ', 'elimino reservacion', 'reservacion_habitacion', '192.168.56.1'),
(16122, '21:19:16', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16123, '21:20:48', '2016-11-07', 'usuariodbs', 'Insertar', 'Registro de aplicacion: 15101--folio', 'aplicacion', '192.168.0.20'),
(16124, '21:22:25', '2016-11-07', 'usuariodbs', 'Modificar', 'modifico una reservacion', 'reservacion_habitacion', '192.168.56.1'),
(16125, '21:28:38', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16126, '21:32:08', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16127, '21:34:42', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16128, '21:34:45', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16129, '21:35:58', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16130, '21:36:37', '2016-11-07', 'usuariodbs', 'Insertar', 'Registro de aplicacion: 15111--reservacion hotel', 'aplicacion', '192.168.56.1'),
(16131, '21:38:04', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16132, '21:39:49', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16133, '21:40:18', '2016-11-07', 'usuariodbs', 'Insertar', 'Creacion usuario: rodrigo', 'usuario', '192.168.56.1'),
(16134, '21:40:18', '2016-11-07', 'usuariodbs', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: rodrigo', 'bitacora', '192.168.56.1'),
(16135, '21:40:18', '2016-11-07', 'usuariodbs', 'Operacion exitosa', 'Asignacion del usuario: rodrigo al colaborador: 1-1', 'usuario', '192.168.56.1'),
(16136, '21:40:18', '2016-11-07', 'usuariodbs', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: rodrigo Sobre aplicacion: 15111', 'usuario_privilegios', '192.168.56.1'),
(16137, '21:40:28', '2016-11-07', 'rodrigo', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16138, '21:42:49', '2016-11-07', 'rodrigo', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16139, '21:43:51', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16140, '21:44:08', '2016-11-07', 'rodrigo', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16141, '21:46:45', '2016-11-07', 'rodrigo', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16142, '21:48:21', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16143, '21:49:32', '2016-11-07', 'usuariodbs', 'Insertar', 'Creacion usuario: flofo', 'usuario', '192.168.56.1'),
(16144, '21:49:32', '2016-11-07', 'usuariodbs', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: flofo', 'bitacora', '192.168.56.1'),
(16145, '21:49:32', '2016-11-07', 'usuariodbs', 'Operacion exitosa', 'Asignacion del usuario: flofo al colaborador: 1-1', 'usuario', '192.168.56.1'),
(16146, '21:49:32', '2016-11-07', 'usuariodbs', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: True upd: False del: False a usuario: flofo Sobre aplicacion: 15111', 'usuario_privilegios', '192.168.56.1'),
(16147, '21:49:44', '2016-11-07', 'flofo', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16148, '21:51:03', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16149, '21:52:18', '2016-11-07', 'usuariodbs', 'Insertar', 'Creacion usuario: walter', 'usuario', '192.168.0.20'),
(16150, '21:52:18', '2016-11-07', 'usuariodbs', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: walter', 'bitacora', '192.168.0.20'),
(16151, '21:52:18', '2016-11-07', 'usuariodbs', 'Operacion exitosa', 'Asignacion del usuario: walter al colaborador: 1-1', 'usuario', '192.168.0.20'),
(16152, '21:52:18', '2016-11-07', 'usuariodbs', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: True del: False a usuario: walter Sobre aplicacion: 15101', 'usuario_privilegios', '192.168.0.20'),
(16153, '21:52:18', '2016-11-07', 'usuariodbs', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: True del: False a usuario: walter Sobre aplicacion: 15111', 'usuario_privilegios', '192.168.0.20'),
(16154, '21:52:32', '2016-11-07', 'walter', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16155, '21:54:24', '2016-11-07', 'walter', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16156, '21:54:28', '2016-11-07', 'walter', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16157, '21:58:31', '2016-11-07', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.20'),
(16158, '07:31:53', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.101'),
(16159, '07:37:03', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.101'),
(16160, '07:37:42', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.101'),
(16161, '07:41:58', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.101'),
(16162, '07:42:53', '2016-11-08', 'usuariodbs', 'Insertar', 'Insercion de nuevo folio', 'Folio', '192.168.0.101'),
(16163, '07:43:10', '2016-11-08', 'usuariodbs', 'Insertar', 'Insertar', 'detalle_folio', '192.168.0.101'),
(16164, '07:43:10', '2016-11-08', 'usuariodbs', 'Insertar', 'Insercion folio_reservacion', 'folio_habitacion', '192.168.0.101'),
(16165, '07:45:16', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.101'),
(16166, '07:59:54', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16167, '08:02:20', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16168, '08:03:29', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16169, '08:07:19', '2016-11-08', 'usuariodbs', 'Insertar', 'insercion de nueva reservacion', 'reservacion_habitacion', '192.168.0.107'),
(16170, '08:09:00', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16171, '08:10:28', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16172, '08:11:16', '2016-11-08', 'usuariodbs', 'Insertar', 'Insercion de nuevo folio', 'Folio', '192.168.0.107'),
(16173, '08:11:28', '2016-11-08', 'usuariodbs', 'Insertar', 'Insertar', 'detalle_folio', '192.168.0.107'),
(16174, '08:11:29', '2016-11-08', 'usuariodbs', 'Insertar', 'Insercion folio_Evento', 'folio_salon', '192.168.0.107'),
(16175, '08:14:23', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16176, '08:16:09', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16177, '08:33:24', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16178, '08:34:27', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16179, '08:40:21', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16180, '08:47:49', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16181, '08:49:33', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16182, '08:50:19', '2016-11-08', 'usuariodbs', 'Modificar', 'modifico una reservacion', 'reservacion_habitacion', '192.168.56.1'),
(16183, '08:51:05', '2016-11-08', 'usuariodbs', 'Insertar', 'insercion de nueva reservacion', 'reservacion_habitacion', '192.168.56.1'),
(16184, '08:51:18', '2016-11-08', 'usuariodbs', 'Eliminar ', 'elimino reservacion', 'reservacion_habitacion', '192.168.56.1'),
(16185, '08:52:03', '2016-11-08', 'usuariodbs', 'Modificar', 'modifico una reservacion', 'reservacion_habitacion', '192.168.56.1'),
(16186, '08:52:23', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16187, '08:53:12', '2016-11-08', 'usuariodbs', 'Modificar', 'modifico una reservacion', 'reservacion_habitacion', '192.168.56.1'),
(16188, '08:55:42', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16189, '08:56:43', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16190, '08:57:37', '2016-11-08', 'usuariodbs', 'Modificar', 'Se inserto el registro', 'habitacion', '169.254.57.105'),
(16191, '09:00:18', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16192, '09:01:20', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16193, '09:07:32', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16194, '09:12:13', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16195, '09:14:45', '2016-11-08', 'walter', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.103'),
(16196, '09:14:54', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.103'),
(16197, '09:17:28', '2016-11-08', 'usuariodbs', 'Insertar', 'Insertar', 'detalle_folio', '192.168.0.103'),
(16198, '09:17:28', '2016-11-08', 'usuariodbs', 'Insertar', 'Insercion folio_reservacion', 'folio_habitacion', '192.168.0.103'),
(16199, '09:18:18', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16200, '09:19:00', '2016-11-08', 'usuariodbs', 'Insertar', 'Insertar', 'detalle_folio', '192.168.0.103'),
(16201, '09:19:01', '2016-11-08', 'usuariodbs', 'Insertar', 'Insercion folio_Evento', 'folio_salon', '192.168.0.103'),
(16202, '09:21:22', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.103'),
(16203, '09:22:45', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16204, '09:23:12', '2016-11-08', 'usuariodbs', 'Modificar', 'Se inserto el registro', 'habitacion', '169.254.57.105'),
(16205, '09:24:24', '2016-11-08', 'usuariodbs', 'Insertar', 'insercion de nueva reservacion', 'reservacion_habitacion', '169.254.57.105'),
(16206, '09:24:26', '2016-11-08', 'usuariodbs', 'Insertar', 'insercion de nueva reservacion', 'reservacion_habitacion', '169.254.57.105'),
(16207, '09:25:57', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16208, '09:28:57', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.103'),
(16209, '09:30:18', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16210, '09:31:56', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16211, '09:31:56', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.103'),
(16212, '09:33:19', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.103'),
(16213, '09:33:27', '2016-11-08', 'usuariodbs', 'Insertar', 'Registro de aplicacion: 15104--habitacion', 'aplicacion', '169.254.57.105'),
(16214, '09:34:13', '2016-11-08', 'usuariodbs', 'Insertar', 'Creacion usuario: ana', 'usuario', '169.254.57.105'),
(16215, '09:34:13', '2016-11-08', 'usuariodbs', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: ana', 'bitacora', '169.254.57.105'),
(16216, '09:34:13', '2016-11-08', 'usuariodbs', 'Operacion exitosa', 'Asignacion del usuario: ana al colaborador: 1-1', 'usuario', '169.254.57.105'),
(16217, '09:34:14', '2016-11-08', 'usuariodbs', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: True upd: False del: True a usuario: ana Sobre aplicacion: 15104', 'usuario_privilegios', '169.254.57.105'),
(16218, '09:34:27', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16219, '09:34:53', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.103'),
(16220, '09:35:40', '2016-11-08', 'ana', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16221, '09:36:30', '2016-11-08', 'ana', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16222, '09:36:32', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.103'),
(16223, '09:36:51', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16224, '09:37:22', '2016-11-08', 'usuariodbs', 'Insertar', 'Insertar', 'detalle_folio', '192.168.0.103'),
(16225, '09:37:22', '2016-11-08', 'usuariodbs', 'Insertar', 'Insercion folio_Articulo', 'folio_bien', '192.168.0.103'),
(16226, '09:37:34', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16227, '09:41:43', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16228, '09:42:27', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16229, '09:43:12', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16230, '09:45:30', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16231, '09:46:31', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16232, '09:47:20', '2016-11-08', 'usuariodbs', 'Insertar', 'Insertar', 'detalle_folio', '169.254.57.105'),
(16233, '09:47:20', '2016-11-08', 'usuariodbs', 'Insertar', 'Insercion folio_Articulo', 'folio_bien', '169.254.57.105'),
(16234, '09:48:03', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16235, '09:48:52', '2016-11-08', 'usuariodbs', 'Insertar', 'Insertar', 'detalle_folio', '169.254.57.105'),
(16236, '09:48:52', '2016-11-08', 'usuariodbs', 'Insertar', 'Insercion folio_Promocion', 'folio_promocion', '169.254.57.105'),
(16237, '09:51:41', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16238, '09:55:41', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16239, '09:56:15', '2016-11-08', 'walter', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16240, '09:57:26', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16241, '09:58:10', '2016-11-08', 'walter', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16242, '09:58:44', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16243, '09:59:37', '2016-11-08', 'usuariodbs', 'Insertar', 'Registro de aplicacion: 15112--evento', 'aplicacion', '192.168.0.107'),
(16244, '10:00:35', '2016-11-08', 'usuariodbs', 'Insertar', 'Creacion usuario: roberto', 'usuario', '192.168.0.107'),
(16245, '10:00:35', '2016-11-08', 'usuariodbs', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: roberto', 'bitacora', '192.168.0.107'),
(16246, '10:00:35', '2016-11-08', 'usuariodbs', 'Operacion exitosa', 'Asignacion del usuario: roberto al colaborador: 1-1', 'usuario', '192.168.0.107'),
(16247, '10:00:36', '2016-11-08', 'usuariodbs', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: roberto Sobre aplicacion: 15111', 'usuario_privilegios', '192.168.0.107'),
(16248, '10:00:36', '2016-11-08', 'usuariodbs', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: roberto Sobre aplicacion: 15104', 'usuario_privilegios', '192.168.0.107'),
(16249, '10:00:36', '2016-11-08', 'usuariodbs', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: roberto Sobre aplicacion: 15112', 'usuario_privilegios', '192.168.0.107'),
(16250, '10:00:54', '2016-11-08', 'roberto', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16251, '10:07:48', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16252, '10:15:04', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16253, '10:17:10', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16254, '10:18:06', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16255, '10:18:16', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16256, '10:19:08', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16257, '10:19:12', '2016-11-08', 'usuariodbs', 'Insertar', 'Se inserto el registro', 'tipo_habitacion', '169.254.57.105'),
(16258, '10:23:42', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16259, '10:23:48', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16260, '10:24:06', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16261, '10:25:20', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16262, '10:25:33', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16263, '10:26:19', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16264, '10:26:44', '2016-11-08', 'usuariodbs', 'Modificar', 'Se inserto el registro', 'habitacion', '169.254.57.105'),
(16265, '10:27:44', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16266, '10:28:32', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16267, '10:29:56', '2016-11-08', 'usuariodbs', 'Insertar', 'insercion de nueva reservacion', 'reservacion_habitacion', '169.254.57.105'),
(16268, '10:33:16', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16269, '10:35:58', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16270, '10:36:37', '2016-11-08', 'usuariodbs', 'Insertar', 'insercion de nueva reservacion', 'reservacion_habitacion', '169.254.57.105'),
(16271, '10:38:18', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16272, '10:39:01', '2016-11-08', 'usuariodbs', 'Insertar', 'insercion de nueva reservacion', 'reservacion_habitacion', '169.254.57.105'),
(16273, '10:39:31', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16274, '10:41:09', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16275, '10:43:48', '2016-11-08', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '169.254.57.105'),
(16276, '10:44:38', '2016-11-08', 'usuariodbs', 'Insertar', 'Insertar', 'detalle_folio', '169.254.57.105'),
(16277, '10:44:38', '2016-11-08', 'usuariodbs', 'Insertar', 'Insercion folio_Articulo', 'folio_bien', '169.254.57.105'),
(16278, '09:53:54', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16279, '09:55:50', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16280, '10:01:31', '2016-11-09', 'usuariodbs', 'Insertar', 'insercion de categoria: Productos basicos', 'categoria', '192.168.0.105'),
(16281, '10:13:40', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16282, '10:16:45', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16283, '10:18:20', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16284, '10:19:21', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16285, '10:20:45', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16286, '10:20:58', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16287, '10:22:00', '2016-11-09', 'usuariodbs', 'Insertar', 'registro de  orden de compra como documento modificador de inventario: 1', 'encabezado_documento', '192.168.0.105'),
(16288, '10:23:51', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16289, '10:24:39', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16290, '10:25:51', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16291, '10:26:00', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16292, '10:27:00', '2016-11-09', 'usuariodbs', 'Insertar', 'registro de  devolucion sobre compra: ', 'devolucion_compra', '192.168.0.105'),
(16293, '10:27:03', '2016-11-09', 'usuariodbs', 'Insertar', 'registro de Devolucion sobre compra como documento modificador de inventario: 1', 'encabezado_documento', '192.168.0.105'),
(16294, '10:27:10', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16295, '10:27:44', '2016-11-09', 'usuariodbs', 'Insertar', 'registro de  devolucion sobre compra: ', 'devolucion_compra', '192.168.0.105'),
(16296, '10:27:46', '2016-11-09', 'usuariodbs', 'Insertar', 'registro de Devolucion sobre compra como documento modificador de inventario: 2', 'encabezado_documento', '192.168.0.105'),
(16297, '10:35:57', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16298, '10:38:10', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16299, '10:42:04', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16300, '10:42:38', '2016-11-09', 'usuariodbs', 'Intento Operacion', 'Error al crear usuario a nivel DBSwalter', 'dbo.users', '192.168.0.105'),
(16301, '10:42:38', '2016-11-09', 'usuariodbs', 'Intento Operacion', 'Error al crear usuariowalter', 'usuario', '192.168.0.105'),
(16302, '10:43:53', '2016-11-09', 'usuariodbs', 'Insertar', 'Creacion usuario: walter2', 'usuario', '192.168.0.105'),
(16303, '10:43:53', '2016-11-09', 'usuariodbs', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: walter2', 'bitacora', '192.168.0.105'),
(16304, '10:43:53', '2016-11-09', 'usuariodbs', 'Operacion exitosa', 'Asignacion del usuario: walter2 al colaborador: 1-1', 'usuario', '192.168.0.105'),
(16305, '10:43:54', '2016-11-09', 'usuariodbs', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: walter2 Sobre aplicacion: 15111', 'usuario_privilegios', '192.168.0.105'),
(16306, '10:44:06', '2016-11-09', 'walter2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16307, '10:45:22', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16308, '10:46:03', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16309, '10:48:41', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16310, '10:53:05', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16311, '10:53:29', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16312, '11:04:05', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16313, '11:05:21', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16314, '11:19:02', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16315, '11:24:18', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16316, '11:27:11', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16317, '11:29:53', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16318, '11:34:33', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16319, '11:35:14', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16320, '11:37:27', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16321, '11:50:47', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16322, '11:52:13', '2016-11-09', 'usuariodbs', 'Insertar', 'registro de  orden de compra como documento modificador de inventario: 2', 'encabezado_documento', '192.168.0.105'),
(16323, '12:16:51', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16324, '12:17:50', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16325, '12:20:39', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16326, '12:21:55', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16327, '12:24:39', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16328, '12:25:42', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.115'),
(16329, '12:27:57', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.115'),
(16330, '12:28:15', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16331, '12:29:21', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.115'),
(16332, '12:30:08', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16333, '12:39:32', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16334, '12:41:00', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16335, '12:45:39', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16336, '12:47:24', '2016-11-09', 'usuariodbs', 'Insertar', 'Se ha hecho el registro de: 2,encontre 500 pimientas jeje lol xDxDXxdxxdxDX,7,1,MP,500', ' Detalle_ Muestreo ', '192.168.0.105'),
(16337, '12:48:12', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16338, '12:50:00', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16339, '12:50:14', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16340, '12:52:23', '2016-11-09', 'usuariodbs', 'Insertar', 'Se ha hecho el registro de: 3,se encontraron 23 sobres de pimienta,7,1,MP,23', ' Detalle_ Muestreo ', '192.168.0.105'),
(16341, '12:54:36', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16342, '12:56:39', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16343, '12:56:50', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16344, '13:00:04', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16345, '13:03:40', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16346, '13:04:16', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16347, '13:04:43', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16348, '13:07:35', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16349, '13:07:37', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16350, '13:08:16', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16351, '13:09:13', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.114'),
(16352, '13:09:25', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16353, '13:09:58', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16354, '13:13:19', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16355, '13:17:43', '2016-11-09', 'usuariodbs', 'Insertar', 'registro de  orden de compra como documento modificador de inventario: 3', 'encabezado_documento', '192.168.0.105'),
(16356, '13:22:26', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16357, '13:24:20', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16358, '13:27:50', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16359, '13:32:14', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16360, '13:35:27', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16361, '13:37:34', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16362, '13:39:51', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16363, '13:40:05', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16364, '13:43:40', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16365, '13:47:35', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16366, '13:48:16', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16367, '13:49:48', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.116'),
(16368, '13:50:24', '2016-11-09', 'usuariodbs', 'Fallo loggeo', 'Login', 'usuario', '192.168.0.105'),
(16369, '13:50:36', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16370, '13:51:56', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16371, '13:54:07', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16372, '13:59:55', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16373, '14:13:14', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16374, '19:49:48', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16375, '19:51:34', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16376, '20:03:08', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16377, '20:03:41', '2016-11-09', 'usuariodbs', 'Insertar', 'Insercion de documento con el numero: 241233', 'documento', '192.168.56.1'),
(16378, '20:05:10', '2016-11-09', 'usuariodbs', 'Modificar', 'Modificacion de documento con el numero: 2131231', 'documento', '192.168.56.1'),
(16379, '20:09:36', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16380, '20:15:33', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16381, '20:19:49', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16382, '20:24:39', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16383, '20:26:23', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16384, '20:27:58', '2016-11-09', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16385, '07:39:41', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16386, '07:42:09', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16387, '07:45:31', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16388, '07:49:42', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16389, '07:52:41', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16390, '07:54:20', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16391, '07:55:27', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de lìnea: Platillo fuerte', 'linea', '192.168.0.107'),
(16392, '07:57:38', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de lìnea: Condimentos', 'linea', '192.168.0.107'),
(16393, '07:58:56', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de Marca: Maller', 'marca', '192.168.0.107'),
(16394, '07:59:57', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de bien Pimienta', 'bien', '192.168.0.107'),
(16395, '08:00:08', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16396, '08:01:42', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16397, '08:02:17', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16398, '08:02:49', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de bien Pimienta', 'bien', '192.168.0.107'),
(16399, '08:04:52', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de Marca: Naturas', 'marca', '192.168.0.107'),
(16400, '08:05:34', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de bien Salsa de tomate', 'bien', '192.168.0.107'),
(16401, '08:06:59', '2016-11-10', 'usuariodbs', 'Insertar', 'registro de  orden de compra como documento modificador de inventario: 4', 'encabezado_documento', '192.168.0.107'),
(16402, '08:08:26', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16403, '08:09:32', '2016-11-10', 'usuariodbs', 'Eliminar ', 'Se ha hecho el registro de: Bodega 1', ' Bodega ', '192.168.0.107'),
(16404, '08:19:10', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16405, '08:22:36', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de bien Jamon de pavo', 'bien', '192.168.0.107'),
(16406, '08:23:06', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16407, '08:23:39', '2016-11-10', 'usuariodbs', 'Insertar', 'registro de  orden de compra como documento modificador de inventario: 5', 'encabezado_documento', '192.168.0.107'),
(16408, '08:23:57', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16409, '08:26:15', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16410, '08:28:46', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16411, '08:31:36', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de lìnea: Electronicos', 'linea', '192.168.0.107'),
(16412, '08:33:06', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de Marca: Samsung', 'marca', '192.168.0.107'),
(16413, '08:44:12', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16414, '09:05:46', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16415, '09:07:15', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16416, '09:08:30', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de bien Televisor', 'bien', '192.168.0.107'),
(16417, '09:11:09', '2016-11-10', 'usuariodbs', 'Insertar', 'registro de  orden de compra como documento modificador de inventario: 6', 'encabezado_documento', '192.168.0.107'),
(16418, '09:19:01', '2016-11-10', 'usuariodbs', 'Insertar', 'registro de  devolucion sobre compra: ', 'devolucion_compra', '192.168.0.107'),
(16419, '09:19:05', '2016-11-10', 'usuariodbs', 'Insertar', 'registro de Devolucion sobre compra como documento modificador de inventario: 3', 'encabezado_documento', '192.168.0.107'),
(16420, '09:31:45', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16421, '09:35:03', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16422, '09:36:24', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16423, '09:39:55', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16424, '09:43:34', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16425, '09:46:02', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16426, '09:52:41', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16427, '09:53:35', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16428, '09:57:11', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16429, '09:58:25', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16430, '09:58:31', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16431, '10:00:48', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16432, '10:01:24', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16433, '10:01:37', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16434, '10:01:45', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16435, '10:06:14', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16436, '10:06:47', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.100'),
(16437, '10:07:36', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16438, '10:08:47', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16439, '10:09:34', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16440, '10:10:56', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16441, '10:12:42', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16442, '10:13:53', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16443, '10:14:49', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16444, '10:15:09', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de bien Chile verde', 'bien', '192.168.0.107'),
(16445, '10:16:05', '2016-11-10', 'usuariodbs', 'Insertar', 'registro de  orden de compra como documento modificador de inventario: 7', 'encabezado_documento', '192.168.0.107'),
(16446, '10:17:11', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16447, '10:17:30', '2016-11-10', 'usuariodbs', 'Insertar', 'registro de  devolucion sobre compra: ', 'devolucion_compra', '192.168.0.107'),
(16448, '10:17:31', '2016-11-10', 'usuariodbs', 'Insertar', 'registro de Devolucion sobre compra como documento modificador de inventario: 5', 'encabezado_documento', '192.168.0.107'),
(16449, '10:21:07', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16450, '10:22:08', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16451, '10:23:04', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16452, '10:23:17', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16453, '10:24:31', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16454, '10:25:32', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16455, '10:26:15', '2016-11-10', 'usuariodbs', 'Insertar', 'Creacion usuario: javier2', 'usuario', '192.168.0.107'),
(16456, '10:26:15', '2016-11-10', 'usuariodbs', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: javier2', 'bitacora', '192.168.0.107'),
(16457, '10:26:16', '2016-11-10', 'usuariodbs', 'Operacion exitosa', 'Asignacion del usuario: javier2 al colaborador: 1-1', 'usuario', '192.168.0.107'),
(16458, '10:26:16', '2016-11-10', 'usuariodbs', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: javier2 Sobre aplicacion: 15104', 'usuario_privilegios', '192.168.0.107'),
(16459, '10:26:38', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16460, '10:27:06', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16461, '10:28:41', '2016-11-10', 'javier2', 'Insertar', 'Se ha hecho el registro de: 5,encontre en bodega 10 televisores,4,1,AF,10', ' Detalle_ Muestreo ', '192.168.0.107'),
(16462, '10:28:46', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16463, '10:29:06', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16464, '10:34:29', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16465, '10:36:10', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16466, '10:38:41', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16467, '10:39:40', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de bien leche deslactosada', 'bien', '192.168.0.107'),
(16468, '10:40:30', '2016-11-10', 'usuariodbs', 'Insertar', 'insercion de bien mantequilla', 'bien', '192.168.0.107'),
(16469, '10:41:18', '2016-11-10', 'usuariodbs', 'Insertar', 'registro de  orden de compra como documento modificador de inventario: 8', 'encabezado_documento', '192.168.0.107'),
(16470, '10:46:13', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16471, '10:47:32', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16472, '10:47:53', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16473, '10:49:11', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16474, '10:53:11', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16475, '10:53:51', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16476, '10:55:05', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16477, '11:01:01', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16478, '11:06:02', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.174.1'),
(16479, '11:06:48', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16480, '11:15:13', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16481, '11:16:54', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16482, '11:20:10', '2016-11-10', 'javier2', 'Fallo loggeo', 'Login', 'usuario', '192.168.91.1'),
(16483, '11:20:12', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.91.1'),
(16484, '11:24:09', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16485, '11:33:17', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16486, '11:36:22', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16487, '11:39:02', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16488, '11:46:59', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16489, '11:49:45', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16490, '11:51:28', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16491, '11:53:18', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16492, '11:54:17', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16493, '11:55:06', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16494, '11:58:40', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16495, '12:00:28', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16496, '12:00:35', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16497, '12:01:53', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16498, '12:02:09', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16499, '12:02:29', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16500, '12:03:26', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16501, '12:03:29', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.107'),
(16502, '12:05:29', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16503, '12:06:23', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16504, '12:07:08', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16505, '12:07:41', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16506, '12:11:43', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16507, '12:12:14', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16508, '12:12:20', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16509, '12:13:37', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16510, '12:13:44', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16511, '12:15:14', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16512, '12:16:07', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16513, '12:18:26', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16514, '12:20:23', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16515, '12:20:50', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16516, '12:22:48', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16517, '12:24:21', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16518, '12:26:12', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16519, '12:28:47', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16520, '12:30:05', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16521, '12:31:50', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16522, '12:35:19', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16523, '12:36:36', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16524, '12:39:13', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16525, '12:41:32', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16526, '12:44:46', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16527, '12:46:19', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16528, '12:47:33', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16529, '12:48:36', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16530, '12:49:12', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.105'),
(16531, '13:05:07', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16532, '13:08:53', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16533, '13:10:28', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16534, '13:11:08', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.102'),
(16535, '13:11:47', '2016-11-10', 'usuariodbs', 'Modificar', 'Modificacion de documento con el numero: 2131231', 'documento', '192.168.0.102'),
(16536, '13:14:55', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16537, '13:16:26', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.102'),
(16538, '13:24:03', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16539, '13:25:27', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16540, '13:26:24', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.102'),
(16541, '13:27:03', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.102'),
(16542, '13:28:42', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.102'),
(16543, '13:32:34', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.102');
INSERT INTO `bitacora` (`id_bit`, `hora`, `fecha`, `usuario`, `descripcion`, `accion`, `tabla`, `ip`) VALUES
(16544, '13:33:20', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16545, '13:34:07', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16546, '13:34:09', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.102'),
(16547, '13:36:49', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.102'),
(16548, '13:37:08', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16549, '13:38:21', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16550, '13:38:22', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16551, '13:39:01', '2016-11-10', 'usuariodbs', 'Insertar', 'Insercion de documento con el numero: 12345', 'documento', '192.168.0.102'),
(16552, '13:40:20', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16553, '13:42:12', '2016-11-10', 'usuariodbs', 'Insertar', 'Insertar de documento con el numero: 5687457', 'documento', '192.168.0.102'),
(16554, '13:42:31', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16555, '13:46:48', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16556, '13:47:01', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16557, '13:48:53', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.102'),
(16558, '13:49:23', '2016-11-10', 'usuariodbs', 'Modificar', 'Modificacion de documento con el numero: 451320654', 'documento', '192.168.0.102'),
(16559, '13:50:40', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16560, '13:51:43', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16561, '13:52:13', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16562, '13:52:56', '2016-11-10', 'usuariodbs', 'Modificar', 'Modificacion de documento con el numero: 654231654', 'documento', '192.168.0.102'),
(16563, '13:53:02', '2016-11-10', 'javier2', 'Insertar', 'Registro de aplicacion: 13106--Empleados', 'aplicacion', '192.168.56.1'),
(16564, '13:53:47', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Eliminacion de privilegios para usuario: javier2', 'usuario_privilegios', '192.168.56.1'),
(16565, '13:53:47', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: javier2 Sobre aplicacion: 15104', 'usuario_privilegios', '192.168.56.1'),
(16566, '13:53:47', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javier2 Sobre aplicacion: 13106', 'usuario_privilegios', '192.168.56.1'),
(16567, '13:54:08', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16568, '13:54:49', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Eliminacion de privilegios para usuario: javier2', 'usuario_privilegios', '192.168.56.1'),
(16569, '13:54:49', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: javier2 Sobre aplicacion: 15104', 'usuario_privilegios', '192.168.56.1'),
(16570, '13:54:49', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: False sel: True upd: True del: False a usuario: javier2 Sobre aplicacion: 13106', 'usuario_privilegios', '192.168.56.1'),
(16571, '13:55:20', '2016-11-10', 'javier2', 'Modificar', 'Modificacion de Empleado con codigo: 2', 'empleado', '192.168.56.1'),
(16572, '13:55:29', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16573, '13:56:45', '2016-11-10', 'usuariodbs', 'Insertar', 'Modificacion de documento con el numero: 56415216', 'documento', '192.168.0.102'),
(16574, '13:58:47', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16575, '13:58:55', '2016-11-10', 'usuariodbs', 'Insertar', 'Insertar de documento con el numero: 654656', 'documento', '192.168.0.102'),
(16576, '14:00:58', '2016-11-10', 'javier2', 'Insertar', 'Creacion usuario: recursos_humanos', 'usuario', '192.168.56.1'),
(16577, '14:00:58', '2016-11-10', 'javier2', 'Operacion exitosa', 'Se otorga permiso sobre bitacora al usuario: recursos_humanos', 'bitacora', '192.168.56.1'),
(16578, '14:00:58', '2016-11-10', 'javier2', 'Operacion exitosa', 'Asignacion del usuario: recursos_humanos al colaborador: 1-2', 'usuario', '192.168.56.1'),
(16579, '14:00:58', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: recursos_humanos Sobre aplicacion: 13106', 'usuario_privilegios', '192.168.56.1'),
(16580, '14:01:15', '2016-11-10', 'recursos_humanos', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16581, '14:02:14', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16582, '14:03:27', '2016-11-10', 'recursos_humanos', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16583, '14:08:06', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16584, '14:10:18', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16585, '14:11:07', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16586, '14:12:51', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16587, '14:14:23', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16588, '14:15:59', '2016-11-10', 'recursos_humanos', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16589, '14:16:23', '2016-11-10', 'recursos_humanos', 'Insertar', 'Registro de aplicacion: 13109--Devengos', 'aplicacion', '192.168.56.1'),
(16590, '14:17:04', '2016-11-10', 'recursos_humanos', 'Asignacion/cambio permisos', 'Eliminacion de privilegios para usuario: recursos_humanos', 'usuario_privilegios', '192.168.56.1'),
(16591, '14:17:05', '2016-11-10', 'recursos_humanos', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: recursos_humanos Sobre aplicacion: 13106', 'usuario_privilegios', '192.168.56.1'),
(16592, '14:17:05', '2016-11-10', 'recursos_humanos', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: recursos_humanos Sobre aplicacion: 13109', 'usuario_privilegios', '192.168.56.1'),
(16593, '14:17:15', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16594, '14:18:00', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16595, '14:18:43', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16596, '14:19:55', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16597, '14:22:14', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Eliminacion de privilegios para usuario: javier2', 'usuario_privilegios', '192.168.56.1'),
(16598, '14:22:14', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: javier2 Sobre aplicacion: 15104', 'usuario_privilegios', '192.168.56.1'),
(16599, '14:23:15', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16600, '14:25:25', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.106'),
(16601, '14:28:17', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16602, '14:31:22', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16603, '14:34:33', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16604, '14:35:46', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16605, '14:37:31', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16606, '14:38:28', '2016-11-10', 'javier2', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16607, '14:39:03', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Eliminacion de privilegios para usuario: javier2', 'usuario_privilegios', '192.168.56.1'),
(16608, '14:39:03', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: javier2 Sobre aplicacion: 15104', 'usuario_privilegios', '192.168.56.1'),
(16609, '14:39:03', '2016-11-10', 'javier2', 'Asignacion/cambio permisos', 'Asignacion de permiso: ins: False sel: False upd: False del: False a usuario: javier2 Sobre aplicacion: 13106', 'usuario_privilegios', '192.168.56.1'),
(16610, '18:28:44', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16611, '19:20:47', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16612, '19:28:24', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16613, '19:35:45', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16614, '19:38:29', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16615, '19:39:57', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16616, '19:44:56', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16617, '19:56:00', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16618, '19:58:14', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16619, '20:06:20', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16620, '20:11:35', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16621, '20:14:23', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16622, '20:34:26', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16623, '20:48:34', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16624, '20:54:40', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16625, '20:57:53', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16626, '20:59:27', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16627, '21:06:10', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16628, '22:36:00', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16629, '22:56:08', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16630, '22:58:17', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16631, '23:00:41', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16632, '23:24:18', '2016-11-10', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16633, '00:19:29', '2016-11-11', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16634, '00:24:39', '2016-11-11', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16635, '00:26:03', '2016-11-11', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7'),
(16636, '00:35:04', '2016-11-11', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.7');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodega`
--

CREATE TABLE IF NOT EXISTS `bodega` (
  `id_bodega_pk` int(11) NOT NULL AUTO_INCREMENT,
  `ubicacion` char(40) DEFAULT NULL,
  `nombre_bodega` char(40) DEFAULT NULL,
  `tama` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bodega_pk`),
  KEY `Ref17432` (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `bodega`
--

INSERT INTO `bodega` (`id_bodega_pk`, `ubicacion`, `nombre_bodega`, `tama`, `estado`, `id_empresa_pk`) VALUES
(1, 'central', 'Bodega central', NULL, 'activo', 1),
(2, 'central', 'Bodega restaurante', NULL, 'activo', 1),
(3, 'central', 'Bodega 1', NULL, 'activo', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `buzon`
--

CREATE TABLE IF NOT EXISTS `buzon` (
  `id_buzon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) NOT NULL,
  `fecha` date DEFAULT NULL,
  `descripcion` varchar(20) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_buzon_pk`),
  KEY `Ref17226` (`id_empresa_pk`),
  KEY `Ref1520` (`id_cliente_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `id_categoria_pk` char(18) NOT NULL,
  `tipo_categoria` char(25) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`id_categoria_pk`, `tipo_categoria`, `estado`) VALUES
('MP', 'Materia Prima', 'activo'),
('PT', 'Producto terminado', 'activo'),
('AF', 'Activo fijo', 'activo'),
('PB', 'Productos basicos', 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `id_cliente_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `correo` varchar(50) DEFAULT NULL,
  `dpi` int(11) DEFAULT NULL,
  `nit` varchar(10) NOT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `id_tipocredito_pk` int(11) DEFAULT NULL,
  `id_contribuyente_pk` int(11) DEFAULT NULL,
  `id_empleado_pk` int(11) DEFAULT NULL,
  `dias_cred` int(11) NOT NULL,
  `id_tprecio_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_cliente_pk`),
  KEY `Ref153238` (`id_tipocredito_pk`),
  KEY `Ref159255` (`id_contribuyente_pk`),
  KEY `Ref238484` (`id_empleado_pk`),
  KEY `Ref152316` (`id_tprecio_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`id_cliente_pk`, `nombre`, `apellido`, `correo`, `dpi`, `nit`, `telefono`, `direccion`, `fecha_nacimiento`, `id_tipocredito_pk`, `id_contribuyente_pk`, `id_empleado_pk`, `dias_cred`, `id_tprecio_pk`, `estado`) VALUES
(2, 'Recinos', 'waaalteeeer', 'Walter', 284773, '87474', '738933', 'direcion 3', '0000-00-00', 2, 1, 1, 0, 2, 'ACTIVO'),
(3, 'Daniel', 'Estrada', 'NUEVO D', 9478471, '99844', '78372', 'nuevo 09', '2016-11-27', 1, 1, 1, 0, 1, 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `cliente_efectivo`
--
CREATE TABLE IF NOT EXISTS `cliente_efectivo` (
`dpi` int(11)
,`id_cuenta_pagar_pk` int(11)
,`costo` decimal(10,2)
,`nombre` char(30)
,`fecha` char(100)
);
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE IF NOT EXISTS `compra` (
  `id_factura_compra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_factura` int(11) NOT NULL,
  `id_pedido_compra_pk` int(11) NOT NULL,
  `serie_factura` char(15) DEFAULT NULL,
  `fecha_recibida` date DEFAULT NULL,
  `encargado` char(20) DEFAULT NULL,
  `total` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `id_forma_pk` int(11) NOT NULL,
  `estado_compra` char(15) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_factura_compra_pk`),
  KEY `Ref129174` (`id_pedido_compra_pk`),
  KEY `Ref123176` (`id_cuenta_pk`,`id_proveedor_pk`),
  KEY `Ref99223` (`id_forma_pk`),
  KEY `Ref17464` (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Volcado de datos para la tabla `compra`
--

INSERT INTO `compra` (`id_factura_compra_pk`, `id_factura`, `id_pedido_compra_pk`, `serie_factura`, `fecha_recibida`, `encargado`, `total`, `estado`, `id_cuenta_pk`, `id_proveedor_pk`, `id_forma_pk`, `estado_compra`, `id_empresa_pk`) VALUES
(2, 0, 1, NULL, '2016-11-09', NULL, NULL, 'activo', 0, 2, 0, 'procesada', 1),
(3, 0, 1, NULL, '2016-11-09', NULL, NULL, 'activo', 0, 2, 0, 'procesada', 1),
(4, 0, 1, NULL, '2016-11-10', NULL, NULL, 'activo', 0, 2, 0, 'procesada', 1),
(5, 0, 1, NULL, '2016-11-10', NULL, NULL, 'activo', 0, 2, 0, 'procesada', 1),
(6, 0, 1, NULL, '2016-11-10', NULL, NULL, 'activo', 0, 2, 0, 'procesada', 1),
(7, 0, 1, NULL, '2016-11-10', NULL, NULL, 'activo', 0, 2, 0, 'procesada', 1),
(8, 0, 1, NULL, '2016-11-10', NULL, NULL, 'activo', 0, 2, 0, 'procesada', 1),
(9, 4450, 1, '411A', '2016-11-11', 'Ludvin', '200', 'ACTIVO', 1, 1, 2, 'PENDIENTE', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `com_venta`
--

CREATE TABLE IF NOT EXISTS `com_venta` (
  `id_com_venta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_empleados_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `total_venta` decimal(10,2) DEFAULT NULL,
  `porsentaje_comision` decimal(10,2) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `total_comision` decimal(10,2) DEFAULT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_com_venta_pk`,`id_empleados_pk`),
  KEY `Ref94452` (`id_fac_empresa_pk`,`id_empresa_pk`),
  KEY `Ref238453` (`id_empleados_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `com_venta`
--

INSERT INTO `com_venta` (`id_com_venta_pk`, `id_empleados_pk`, `estado`, `total_venta`, `porsentaje_comision`, `fecha`, `total_comision`, `id_fac_empresa_pk`, `id_empresa_pk`) VALUES
(1, 1, 'ACTIVO', '75.90', '6.00', '2016-11-09', '4.55', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conciliaciones`
--

CREATE TABLE IF NOT EXISTS `conciliaciones` (
  `id_conciliacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_documento_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_conciliacion_pk`,`id_documento_pk`),
  KEY `Ref234373` (`id_documento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contribuyente`
--

CREATE TABLE IF NOT EXISTS `contribuyente` (
  `id_contribuyente_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `nit` varchar(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_contribuyente_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `contribuyente`
--

INSERT INTO `contribuyente` (`id_contribuyente_pk`, `nombre`, `nit`, `estado`) VALUES
(1, 'olivia', '123456', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `convertidora`
--

CREATE TABLE IF NOT EXISTS `convertidora` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `valor` float(8,0) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion`
--

CREATE TABLE IF NOT EXISTS `cotizacion` (
  `id_cotizacion` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_cte` varchar(50) DEFAULT NULL,
  `apellido_cte` varchar(50) DEFAULT NULL,
  `nit_cte` varchar(50) DEFAULT NULL,
  `telefono_cte` varchar(15) DEFAULT NULL,
  `direccion_cte` varchar(50) DEFAULT NULL,
  `fecha_cot` varchar(50) NOT NULL,
  `estado_cot` varchar(100) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_cliente_pk` int(11) NOT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_cotizacion`),
  KEY `Ref15181` (`id_cliente_pk`),
  KEY `id_empresa_pk` (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `cotizacion`
--

INSERT INTO `cotizacion` (`id_cotizacion`, `nombre_cte`, `apellido_cte`, `nit_cte`, `telefono_cte`, `direccion_cte`, `fecha_cot`, `estado_cot`, `id_empresa_pk`, `id_cliente_pk`, `estado`) VALUES
(1, 'sammy', 'salazar', '4340', NULL, 'ciudad', '9/11/2016', 'inactiva', 0, 0, NULL),
(2, 'erick', 'muñoz', '4534', NULL, 'ciudad', 'jueves, 10 de noviembre de 2016', 'activa', 0, 0, NULL),
(3, 'pedro', 'martinez', '234231', NULL, 'ciudad', 'miércoles, 9 de noviembre de 2016', 'activa', 0, 0, NULL),
(4, 'peter', 'aguirre', '4689346', '53430301', 'ciudad', 'jueves, 10 de noviembre de 2016', 'activa', 0, 0, NULL),
(5, 'juan', 'alberto', '4376449', '22482160', 'ciudad', 'lunes, 7 de noviembre de 2016', 'inactiva', 0, 0, NULL),
(6, 'juan', 'velasquez', '5634986', '22321049', 'izabal', 'viernes, 11 de noviembre de 2016', 'activa', 0, 0, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion_bien`
--

CREATE TABLE IF NOT EXISTS `cotizacion_bien` (
  `id_precio` int(11) NOT NULL,
  `id_detallecot_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_precio`,`id_detallecot_pk`),
  KEY `Ref151407` (`id_precio`),
  KEY `Ref93417` (`id_detallecot_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion_paquete`
--

CREATE TABLE IF NOT EXISTS `cotizacion_paquete` (
  `id_promocion_pk` int(11) NOT NULL,
  `id_detallecot_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_promocion_pk`,`id_detallecot_pk`),
  KEY `Ref93416` (`id_detallecot_pk`),
  KEY `Ref25124` (`id_promocion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_bancaria`
--

CREATE TABLE IF NOT EXISTS `cuenta_bancaria` (
  `id_cuenta_bancaria_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado` char(25) DEFAULT 'ACTIVO',
  `id_empresa_pk` int(11) NOT NULL,
  `nombre_banco` char(50) DEFAULT NULL,
  `no_cuenta` char(50) DEFAULT NULL,
  `saldo_libros` decimal(10,2) DEFAULT NULL,
  `saldo_bancarios` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_cuenta_bancaria_pk`),
  KEY `Ref17381` (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `cuenta_bancaria`
--

INSERT INTO `cuenta_bancaria` (`id_cuenta_bancaria_pk`, `estado`, `id_empresa_pk`, `nombre_banco`, `no_cuenta`, `saldo_libros`, `saldo_bancarios`) VALUES
(1, 'ACTIVO', 1, 'CITIBANK', '255642-4', '2500.00', '5460.00'),
(2, 'ACTIVO', 1, 'BANCO INDUSTRIAL', '5645198-8', '6548.00', '6546.00'),
(3, 'ACTIVO', 1, 'G&T CONTINENTAL', '5649846-9', '56100.00', '65462.20');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_corriente_por_pagar`
--

CREATE TABLE IF NOT EXISTS `cuenta_corriente_por_pagar` (
  `id_cuenta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_proveedor_pk` int(11) NOT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  PRIMARY KEY (`id_cuenta_pk`,`id_proveedor_pk`),
  KEY `Ref124170` (`id_proveedor_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `cuenta_corriente_por_pagar`
--

INSERT INTO `cuenta_corriente_por_pagar` (`id_cuenta_pk`, `id_proveedor_pk`, `estado`) VALUES
(1, 1, 'ACTIVO'),
(2, 2, 'ACTIVO'),
(3, 3, 'ACTIVO'),
(4, 4, 'ACTIVO'),
(5, 5, 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `deducciones`
--

CREATE TABLE IF NOT EXISTS `deducciones` (
  `id_presamo_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` char(100) DEFAULT NULL,
  `detalle` char(250) DEFAULT NULL,
  `cantidad_deduccion` decimal(10,2) DEFAULT NULL,
  `cuotas` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` char(10) DEFAULT 'ACTIVO',
  `id_planilla_igss_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `id_detalle_impuesto_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_presamo_pk`),
  KEY `Ref256449` (`id_detalle_impuesto_pk`),
  KEY `Ref237391` (`id_planilla_igss_pk`),
  KEY `Ref238392` (`id_empleados_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `deducciones`
--

INSERT INTO `deducciones` (`id_presamo_pk`, `nombre`, `detalle`, `cantidad_deduccion`, `cuotas`, `fecha`, `estado`, `id_planilla_igss_pk`, `id_empleados_pk`, `id_detalle_impuesto_pk`) VALUES
(1, 'Prestamo', 'Dinero prestado para pagar bienes', '1000.00', 1, '2016-09-08', 'ACTIVO', 1, 1, 0),
(2, 'DaÃ±o a Equipo', 'Reparacion de equipo', '500.00', 1, '2016-09-25', 'ACTIVO', 1, 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_compra`
--

CREATE TABLE IF NOT EXISTS `detalle_compra` (
  `id_detalle_compra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_factura_compra_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  PRIMARY KEY (`id_detalle_compra_pk`),
  KEY `Ref125442` (`id_factura_compra_pk`),
  KEY `Ref1466` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Refbien466` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Volcado de datos para la tabla `detalle_compra`
--

INSERT INTO `detalle_compra` (`id_detalle_compra_pk`, `cantidad`, `estado`, `id_factura_compra_pk`, `id_bien_pk`, `id_categoria_pk`) VALUES
(2, 7, 'activo', 2, 1, 'MP'),
(3, 23, 'activo', 3, 3, 'MP'),
(4, 1, 'activo', 3, 2, 'MP'),
(5, 10, 'activo', 4, 2, 'MP'),
(6, 10, 'activo', 4, 1, 'MP'),
(7, 5, 'activo', 5, 3, 'MP'),
(8, 5, 'activo', 5, 1, 'MP'),
(9, 8, 'activo', 6, 1, 'AF'),
(10, 10, 'activo', 7, 4, 'MP'),
(11, 1000, 'activo', 8, 6, 'MP'),
(12, 1000, 'activo', 8, 5, 'MP'),
(13, 10, 'ACTIVO', 9, 1, 'MP'),
(14, 10, 'ACTIVO', 9, 2, 'MP');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_com_ventas`
--

CREATE TABLE IF NOT EXISTS `detalle_com_ventas` (
  `id_detalle_com_ventas` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `id_com_venta_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `total_ventas` decimal(10,2) DEFAULT NULL,
  `comision` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_com_ventas`),
  KEY `Ref241494` (`id_com_venta_pk`,`id_empleados_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `detalle_com_ventas`
--

INSERT INTO `detalle_com_ventas` (`id_detalle_com_ventas`, `fecha`, `id_com_venta_pk`, `id_empleados_pk`, `estado`, `total_ventas`, `comision`) VALUES
(1, '2016-11-09', 1, 1, 'ACTIVO', '75.90', '4.55');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_cotizacion`
--

CREATE TABLE IF NOT EXISTS `detalle_cotizacion` (
  `id_detallecot_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad_detallecot` int(11) DEFAULT NULL,
  `desc_servicio_detcot` varchar(150) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_cotizacion_pk` int(11) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_detallecot_pk`),
  KEY `Ref154408` (`id_precio`,`id_detallecot_pk`),
  KEY `Ref100409` (`id_detallecot_pk`,`id_promocion_pk`),
  KEY `Ref92415` (`id_cotizacion_pk`),
  KEY `Ref17461` (`id_empresa_pk`),
  KEY `Refcotizacion_bien408` (`id_detallecot_pk`,`id_precio`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Volcado de datos para la tabla `detalle_cotizacion`
--

INSERT INTO `detalle_cotizacion` (`id_detallecot_pk`, `cantidad_detallecot`, `desc_servicio_detcot`, `id_promocion_pk`, `id_cotizacion_pk`, `id_precio`, `estado`, `id_empresa_pk`) VALUES
(1, 10, NULL, NULL, 1, 1, NULL, NULL),
(2, 15, NULL, NULL, 2, 1, NULL, NULL),
(3, 8, NULL, NULL, 3, 7, NULL, NULL),
(4, 8, NULL, NULL, 4, 7, NULL, NULL),
(5, 4, NULL, NULL, 5, 7, NULL, NULL),
(6, 9, NULL, NULL, 5, 9, NULL, NULL),
(7, 18, NULL, NULL, 6, 9, NULL, NULL),
(8, 34, NULL, NULL, 6, 7, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_cuenta_por_pagar`
--

CREATE TABLE IF NOT EXISTS `detalle_cuenta_por_pagar` (
  `detalle_cuenta_por_pagar_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` char(25) DEFAULT NULL,
  `comprobante` char(10) DEFAULT NULL,
  `debe` decimal(15,0) DEFAULT '0',
  `haber` decimal(15,0) DEFAULT '0',
  `saldo` decimal(15,0) DEFAULT '0',
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_cuenta_pk` int(11) DEFAULT NULL,
  `id_proveedor_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`detalle_cuenta_por_pagar_pk`),
  KEY `Ref123293` (`id_proveedor_pk`,`id_cuenta_pk`),
  KEY `Refcuenta_corriente_por_pagar293` (`id_cuenta_pk`,`id_proveedor_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Volcado de datos para la tabla `detalle_cuenta_por_pagar`
--

INSERT INTO `detalle_cuenta_por_pagar` (`detalle_cuenta_por_pagar_pk`, `fecha`, `comprobante`, `debe`, `haber`, `saldo`, `estado`, `id_cuenta_pk`, `id_proveedor_pk`) VALUES
(1, '10-27-2016', '0', '44', '0', '44', 'ACTIVO', 1, 1),
(11, '10-25-2016', '0', '50', '0', '50', 'ACTIVO', 2, 2),
(3, '10-28-2016', '0', '44', '0', '88', 'ACTIVO', 1, 1),
(12, '10-31-2016', '0', '0', '20', '68', 'ACTIVO', 1, 1),
(13, '11-01-2016', '0', '0', '60', '8', 'ACTIVO', 1, 1),
(14, '10-10-2016', '0', '120', '0', '170', 'ACTIVO', 2, 2),
(15, '10-15-2016', '0', '50', '0', '58', 'ACTIVO', 1, 1),
(16, '2016-11-08 10:59:51', '0', '0', '170', '0', 'ACTIVO', 2, 2),
(17, NULL, NULL, '0', '0', '0', 'ACTIVO', 4, 4),
(18, NULL, NULL, '0', '0', '0', 'ACTIVO', 3, 3),
(19, '2016-11-10 11:37:20', 'ZPUFHP', '0', '80', '0', 'ACTIVO', 1, 1),
(20, NULL, NULL, '0', '0', '0', 'ACTIVO', 5, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_devolucion_compra`
--

CREATE TABLE IF NOT EXISTS `detalle_devolucion_compra` (
  `id_detalle_devolucion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `observaciones` char(100) DEFAULT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `id_devolucion_compra_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_devolucion_pk`),
  KEY `Ref1467` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Ref262481` (`id_devolucion_compra_pk`),
  KEY `Refbien467` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `detalle_devolucion_compra`
--

INSERT INTO `detalle_devolucion_compra` (`id_detalle_devolucion_pk`, `cantidad`, `observaciones`, `estado`, `id_bien_pk`, `id_categoria_pk`, `id_devolucion_compra_pk`) VALUES
(1, 2, 'hola', 'activo', 1, 'MP', 2),
(2, 1, 'ggfjh', 'activo', 1, 'AF', 3),
(3, 3, 'Nuevas', NULL, 1, '', 4),
(4, 5, 'vencidas', 'activo', 4, 'MP', 5),
(5, 2, 'DULCE', NULL, 2, '', 6),
(6, 6, 'LCD', NULL, 1, '', 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_disp_banc`
--

CREATE TABLE IF NOT EXISTS `detalle_disp_banc` (
  `id_detalle_db_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado` char(25) DEFAULT NULL,
  `id_disponibilidad_bancaria` int(11) NOT NULL,
  `id_documento_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_db_pk`),
  KEY `Ref230379` (`id_disponibilidad_bancaria`),
  KEY `Ref234380` (`id_documento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_documento`
--

CREATE TABLE IF NOT EXISTS `detalle_documento` (
  `id_detalle_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_bien_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `no_doc` char(18) DEFAULT NULL,
  `serie_doc` char(18) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `tipo_doc` char(40) DEFAULT NULL,
  `empresa` char(20) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pk`),
  KEY `Ref1185` (`id_bien_pk`,`id_categoria_pk`),
  KEY `Ref130187` (`serie_doc`,`no_doc`,`empresa`,`tipo_doc`),
  KEY `Refencabezado_documento187` (`no_doc`,`serie_doc`,`tipo_doc`,`empresa`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Volcado de datos para la tabla `detalle_documento`
--

INSERT INTO `detalle_documento` (`id_detalle_pk`, `id_bien_pk`, `cantidad`, `id_categoria_pk`, `no_doc`, `serie_doc`, `estado`, `tipo_doc`, `empresa`) VALUES
(5, 1, 7, 'MP', '2', '-', 'activo', 'Orden de compra', '1'),
(6, 3, 23, 'MP', '3', '-', 'activo', 'Orden de compra', '1'),
(7, 2, 1, 'MP', '3', '-', 'activo', 'Orden de compra', '1'),
(8, 2, 10, 'MP', '4', '-', 'activo', 'Orden de compra', '1'),
(9, 1, 10, 'MP', '4', '-', 'activo', 'Orden de compra', '1'),
(10, 1, 3, 'MP', '1', 'A', 'activo', 'Factura', '1'),
(11, 2, 5, 'MP', '1', 'A', 'activo', 'Factura', '1'),
(12, 1, 8, 'MP', '2', 'A', 'activo', 'Factura', '1'),
(13, 3, 5, 'MP', '5', '-', 'activo', 'Orden de compra', '1'),
(14, 1, 5, 'MP', '5', '-', 'activo', 'Orden de compra', '1'),
(15, 1, 8, 'AF', '6', '-', 'activo', 'Orden de compra', '1'),
(16, 1, 1, 'AF', '3', '-', 'activo', 'Devolucion sobre compra', '-'),
(17, 4, 10, 'MP', '7', '-', 'activo', 'Orden de compra', '1'),
(18, 4, 5, 'MP', '5', '-', 'activo', 'Devolucion sobre compra', '-'),
(19, 6, 1000, 'MP', '8', '-', 'activo', 'Orden de compra', '1'),
(20, 5, 1000, 'MP', '8', '-', 'activo', 'Orden de compra', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_documentos`
--

CREATE TABLE IF NOT EXISTS `detalle_documentos` (
  `id_detalle_cv_pk` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` char(100) DEFAULT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `nombre_cuenta` char(100) DEFAULT NULL,
  `debe` decimal(10,2) DEFAULT NULL,
  `haber` decimal(10,2) DEFAULT NULL,
  `fecha` date NOT NULL,
  `id_documento_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_cv_pk`),
  KEY `Ref234374` (`id_documento_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Volcado de datos para la tabla `detalle_documentos`
--

INSERT INTO `detalle_documentos` (`id_detalle_cv_pk`, `detalle`, `estado`, `nombre_cuenta`, `debe`, `haber`, `fecha`, `id_documento_pk`) VALUES
(1, 'escritorios', 'ACTIVO', 'daniel', '2300.00', '0.00', '2016-11-05', 1),
(2, 'sillas', 'ACTIVO', 'daniel', '3100.00', '0.00', '2016-11-02', 2),
(3, 'escritorio', 'ACTIVO', 'otto hernandez', '3000.00', '0.00', '2016-11-07', 4),
(4, 'silla', 'INACTIVO', 'otto hernandez', '2600.00', '0.00', '2016-11-08', 1),
(5, 'fghfghf', 'ACTIVO', 'asdasasd', '2400.00', '0.00', '2016-10-08', 4),
(6, 'escritorio', 'ACTIVO', 'Hotel san carlos', '0.00', '5200.00', '2016-11-09', 4),
(7, 'asdasda', 'ACTIVO', 'Nilson Reguan', '56412.00', '0.00', '2016-11-17', 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_folio`
--

CREATE TABLE IF NOT EXISTS `detalle_folio` (
  `id_detalle_folio_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) DEFAULT NULL,
  `nombre` char(30) DEFAULT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_folio_salon_pk` int(11) DEFAULT NULL,
  `id_folio_habitacion_pk` int(11) DEFAULT NULL,
  `id_folio_bien_pk` int(11) DEFAULT NULL,
  `id_folio_promocion_pk` int(11) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_folio_pk`),
  KEY `Ref163433` (`id_folio_bien_pk`),
  KEY `Ref162434` (`id_folio_salon_pk`),
  KEY `Ref161435` (`id_folio_habitacion_pk`),
  KEY `Ref164436` (`id_folio_promocion_pk`),
  KEY `Ref33437` (`id_cuenta_pagar_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Volcado de datos para la tabla `detalle_folio`
--

INSERT INTO `detalle_folio` (`id_detalle_folio_pk`, `costo`, `nombre`, `fecha`, `id_folio_salon_pk`, `id_folio_habitacion_pk`, `id_folio_bien_pk`, `id_folio_promocion_pk`, `id_cuenta_pagar_pk`) VALUES
(1, '278.00', '1', '08/11/2016 07:43:06 a. m.', NULL, 1, NULL, NULL, 2),
(2, '58500.00', 'boda', '08/11/2016 08:09:32 a.m.', 1, NULL, NULL, NULL, 3),
(3, '278.00', '3', '08/11/2016 09:17:22 a. m.', NULL, 2, NULL, NULL, 1),
(4, '41000.00', 'cumpleaños', '08/11/2016 09:18:45 a. m.', 2, NULL, NULL, NULL, 1),
(5, '200.00', 'PRODUCTO 1', '08/11/2016 09:37:13 a. m.', NULL, NULL, 1, NULL, 1),
(6, '200.00', 'PRODUCTO 1', '8/11/2016 9:47:15 a. m.', NULL, NULL, 2, NULL, 3),
(7, '1000.00', 'Promocion 1', '8/11/2016 9:48:48 a. m.', NULL, NULL, NULL, 2, 1),
(8, '200.00', 'PRODUCTO 1', '8/11/2016 10:44:34 a. m.', NULL, NULL, 3, NULL, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_muestreo`
--

CREATE TABLE IF NOT EXISTS `detalle_muestreo` (
  `id_muestreo_pk` int(11) NOT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `existencia` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `existencia_auditada` char(20) DEFAULT NULL,
  PRIMARY KEY (`id_muestreo_pk`),
  KEY `Ref143215` (`id_muestreo_pk`),
  KEY `Ref10290` (`id_bodega_pk`,`id_categoria_pk`,`id_bien_pk`),
  KEY `Refproducto_bodega290` (`id_bien_pk`,`id_bodega_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_muestreo`
--

INSERT INTO `detalle_muestreo` (`id_muestreo_pk`, `descripcion`, `existencia`, `id_bien_pk`, `id_bodega_pk`, `id_categoria_pk`, `estado`, `existencia_auditada`) VALUES
(2, 'encontre 500 pimientas jeje lol xDxDXxdxxdxDX', 7, 1, 2, 'MP', NULL, '500'),
(3, 'se encontraron 23 sobres de pimienta', 7, 1, 2, 'MP', NULL, '23'),
(5, 'encontre en bodega 10 televisores', 4, 1, 1, 'AF', NULL, '10');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_nomina`
--

CREATE TABLE IF NOT EXISTS `detalle_nomina` (
  `id_dn` int(10) NOT NULL AUTO_INCREMENT,
  `estado` char(25) DEFAULT 'ACTIVO',
  `Sueldo_base` decimal(10,2) DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `id_nomina_pk` int(11) NOT NULL,
  `id_presamo_pk` int(11) NOT NULL,
  `id_devengos_pk` int(11) NOT NULL,
  `total_devengos` decimal(10,2) DEFAULT NULL,
  `total_deduccion` decimal(10,2) DEFAULT NULL,
  `sueldo_liquido` decimal(10,2) DEFAULT NULL,
  `id_percepcion_pk` int(11) NOT NULL,
  `id_detalle_impuesto_pk` int(11) NOT NULL,
  `id_detalle_pres_pk` int(11) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_dn`),
  KEY `Ref242397` (`id_devengos_pk`),
  KEY `Ref255446` (`id_percepcion_pk`),
  KEY `Ref256447` (`id_detalle_impuesto_pk`),
  KEY `Ref271493` (`id_detalle_pres_pk`),
  KEY `Ref238388` (`id_empleados_pk`),
  KEY `Ref240389` (`id_nomina_pk`),
  KEY `Ref239390` (`id_presamo_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=36 ;

--
-- Volcado de datos para la tabla `detalle_nomina`
--

INSERT INTO `detalle_nomina` (`id_dn`, `estado`, `Sueldo_base`, `id_empleados_pk`, `id_nomina_pk`, `id_presamo_pk`, `id_devengos_pk`, `total_devengos`, `total_deduccion`, `sueldo_liquido`, `id_percepcion_pk`, `id_detalle_impuesto_pk`, `id_detalle_pres_pk`, `fecha`) VALUES
(30, 'ACTIVO', '7000.00', 2, 1, 0, 0, '1500.00', '0.00', '6816.59', 0, 0, 0, '2016-09-30'),
(29, 'ACTIVO', '5000.00', 1, 1, 0, 0, '3000.96', '1500.00', '5058.88', 0, 0, 0, '2016-09-30'),
(31, 'ACTIVO', '5000.00', 3, 1, 0, 0, '0.00', '0.00', '4963.00', 0, 0, 0, '2016-09-29'),
(32, 'ACTIVO', '4900.00', 4, 2, 0, 0, '0.00', '0.00', '4873.00', 0, 0, 0, '2016-11-09'),
(33, 'ACTIVO', '5000.00', 1, 3, 0, 0, '2500.00', '0.00', '5042.00', 0, 0, 0, '2016-11-09'),
(34, 'ACTIVO', '5000.00', 1, 3, 0, 0, '2500.00', '0.00', '5042.00', 0, 0, 0, '2016-08-29'),
(35, 'ACTIVO', '5000.00', 2, 3, 0, 0, '0.00', '0.00', '4963.00', 0, 0, 0, '2016-08-29');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido`
--

CREATE TABLE IF NOT EXISTS `detalle_pedido` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `estado_detalle` varchar(25) DEFAULT NULL,
  `precio` decimal(18,2) DEFAULT NULL,
  `subtotal` decimal(18,2) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_pedido_pk` int(11) DEFAULT NULL,
  `id_emp` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` varchar(11) NOT NULL,
  `id_precio_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `Ref151403` (`id_precio`),
  KEY `Ref248429` (`id_pedido_pk`),
  KEY `id_emp` (`id_emp`),
  KEY `id_bien_pk` (`id_bien_pk`),
  KEY `id_categoria_pk` (`id_categoria_pk`),
  KEY `id_precio_pk` (`id_precio_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `detalle_pedido`
--

INSERT INTO `detalle_pedido` (`id_detalle`, `cantidad`, `descripcion`, `estado_detalle`, `precio`, `subtotal`, `id_precio`, `estado`, `id_pedido_pk`, `id_emp`, `id_bien_pk`, `id_categoria_pk`, `id_precio_pk`) VALUES
(1, 50, 'Televisor', 'Activo', '25.30', '1265.00', NULL, '', 1, 0, 1, '0', 1),
(2, 2, 'Jamon de pavo', 'Activo', '60.90', '121.80', 3, 'Activo', 2, 0, 3, '0', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido_1`
--

CREATE TABLE IF NOT EXISTS `detalle_pedido_1` (
  `id_detalle_pedido_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_encabezado_pedido_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_menu_pk` char(18) DEFAULT NULL,
  `correlativo` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pedido_pk`,`id_encabezado_pedido_pk`),
  KEY `Ref194296` (`id_menu_pk`,`correlativo`),
  KEY `Ref190297` (`id_encabezado_pedido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido_compra`
--

CREATE TABLE IF NOT EXISTS `detalle_pedido_compra` (
  `id_detalle_pedido_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `precio_compra` decimal(15,0) DEFAULT NULL,
  `subtotal` decimal(15,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_pedido_compra_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  PRIMARY KEY (`id_detalle_pedido_pk`),
  KEY `Ref129441` (`id_pedido_compra_pk`),
  KEY `Ref1465` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Refbien465` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Volcado de datos para la tabla `detalle_pedido_compra`
--

INSERT INTO `detalle_pedido_compra` (`id_detalle_pedido_pk`, `cantidad`, `precio_compra`, `subtotal`, `estado`, `id_pedido_compra_pk`, `id_bien_pk`, `id_categoria_pk`) VALUES
(1, 10, '10', '100', 'ACTIVO', 1, 1, 'MP'),
(2, 10, '10', '100', 'ACTIVO', 1, 2, 'MP'),
(3, 8, '20', '160', 'ACTIVO', 2, 2, 'MP'),
(4, 7, '10', '170', 'ACTIVO', 3, 1, 'MP'),
(5, 23, '10', '230', 'ACTIVO', 4, 3, 'MP'),
(6, 1, '50', '50', 'ACTIVO', 4, 2, 'MP'),
(7, 10, '10', '100', 'ACTIVO', 5, 2, 'MP'),
(8, 10, '5', '50', 'ACTIVO', 5, 1, 'MP'),
(9, 5, '20', '100', 'ACTIVO', 6, 3, 'MP'),
(10, 5, '25', '125', 'ACTIVO', 6, 1, 'MP'),
(11, 8, '20', '160', 'ACTIVO', 7, 1, 'AF');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido_rest`
--

CREATE TABLE IF NOT EXISTS `detalle_pedido_rest` (
  `cantidad` double DEFAULT NULL,
  `id_menu_pk` char(10) DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `orden` int(10) NOT NULL DEFAULT '0',
  `id_encabezado_pedido_pk` char(10) NOT NULL DEFAULT '',
  `correlativo` int(10) DEFAULT NULL,
  PRIMARY KEY (`id_encabezado_pedido_pk`,`orden`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_pedido_rest`
--

INSERT INTO `detalle_pedido_rest` (`cantidad`, `id_menu_pk`, `descuento`, `orden`, `id_encabezado_pedido_pk`, `correlativo`) VALUES
(1, '7', 0, 0, '20160001', 1),
(45, '7', 0, 0, '20160002', 1),
(2, '7', 0, 0, '20160003', 1),
(3, '7', 0, 0, '20160004', 1),
(3, '7', 5, 0, '20160005', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_planilla_igss`
--

CREATE TABLE IF NOT EXISTS `detalle_planilla_igss` (
  `id_detalle_pigss` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `id_planilla_igss_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `sueldo_base` decimal(10,2) DEFAULT NULL,
  `igss_pagar` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pigss`),
  KEY `Ref237393` (`id_planilla_igss_pk`),
  KEY `Ref238394` (`id_empleados_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=33 ;

--
-- Volcado de datos para la tabla `detalle_planilla_igss`
--

INSERT INTO `detalle_planilla_igss` (`id_detalle_pigss`, `fecha`, `estado`, `id_planilla_igss_pk`, `id_empleados_pk`, `sueldo_base`, `igss_pagar`) VALUES
(1, '2016-11-02', 'ACTIVO', 1, 1, '5000.00', '775.00'),
(2, '2016-11-02', 'ACTIVO', 1, 2, '4900.00', '759.50'),
(3, '2016-11-17', 'ACTIVO', 1, 1, '5000.00', '775.00'),
(4, '2016-11-17', 'ACTIVO', 1, 2, '4900.00', '759.50'),
(27, '2016-09-30', 'ACTIVO', 1, 2, '7000.00', '340.52'),
(26, '2016-09-30', 'ACTIVO', 1, 1, '5000.00', '246.33'),
(28, '2016-09-29', 'ACTIVO', 1, 3, '7000.00', '241.00'),
(29, '2016-11-09', 'ACTIVO', 1, 4, '21312.00', '236.00'),
(30, '2016-11-09', 'ACTIVO', 1, 1, '5000.00', '245.00'),
(31, '2016-08-29', 'ACTIVO', 1, 1, '5000.00', '245.00'),
(32, '2016-08-29', 'ACTIVO', 1, 2, '4900.00', '241.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_prestacion`
--

CREATE TABLE IF NOT EXISTS `detalle_prestacion` (
  `id_detalle_pres_pk` int(11) NOT NULL AUTO_INCREMENT,
  `porcentaje` decimal(10,2) DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `id_devengos_pk` int(11) NOT NULL,
  `id_presamo_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `id_detalle_impuesto_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_pres_pk`),
  KEY `Ref242489` (`id_devengos_pk`),
  KEY `Ref239490` (`id_presamo_pk`),
  KEY `Ref238491` (`id_empleados_pk`),
  KEY `Ref256492` (`id_detalle_impuesto_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_receta_mp`
--

CREATE TABLE IF NOT EXISTS `detalle_receta_mp` (
  `correlativo` int(11) NOT NULL AUTO_INCREMENT,
  `id_receta_pk` int(11) NOT NULL,
  `cantidad` float(8,0) DEFAULT NULL,
  `id_proceso_pk` int(11) DEFAULT NULL,
  `id_medida_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`correlativo`,`id_receta_pk`),
  KEY `Ref192301` (`id_proceso_pk`),
  KEY `Ref189302` (`id_medida_pk`),
  KEY `Ref187304` (`id_receta_pk`),
  KEY `Ref1311` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `detalle_receta_mp`
--

INSERT INTO `detalle_receta_mp` (`correlativo`, `id_receta_pk`, `cantidad`, `id_proceso_pk`, `id_medida_pk`, `id_bien_pk`, `id_categoria_pk`) VALUES
(1, 1, 0, 1, 3, 2, 'mp'),
(2, 2, 3, 2, 2, 3, 'mp'),
(3, 3, 0, 3, 3, 5, 'mp'),
(4, 3, 2, 2, 2, 3, 'mp'),
(5, 3, 2, 1, 2, 4, 'mp');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_requisicion`
--

CREATE TABLE IF NOT EXISTS `detalle_requisicion` (
  `id_detalle_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_requisicion_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_requisicion_pk`),
  KEY `Ref145440` (`id_requisicion_pk`),
  KEY `Ref1220` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Refbien220` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Volcado de datos para la tabla `detalle_requisicion`
--

INSERT INTO `detalle_requisicion` (`id_detalle_requisicion_pk`, `cantidad`, `estado`, `id_bien_pk`, `id_categoria_pk`, `id_requisicion_pk`) VALUES
(1, 10, 'activo', 1, 'MP', 1),
(2, 10, 'activo', 2, 'MP', 1),
(3, 8, 'activo', 2, 'MP', 2),
(4, 7, 'activo', 1, 'MP', 3),
(5, 23, 'activo', 3, 'MP', 4),
(6, 1, 'activo', 2, 'MP', 4),
(7, 10, 'activo', 2, 'MP', 5),
(8, 10, 'activo', 1, 'MP', 5),
(9, 5, 'activo', 3, 'MP', 6),
(10, 5, 'activo', 1, 'MP', 6),
(11, 8, 'activo', 1, 'AF', 7),
(12, 10, 'activo', 4, 'MP', 8),
(13, 1000, 'activo', 6, 'MP', 9),
(14, 1000, 'activo', 5, 'MP', 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `deuda`
--

CREATE TABLE IF NOT EXISTS `deuda` (
  `id_deuda` int(11) NOT NULL AUTO_INCREMENT,
  `monto` decimal(10,2) DEFAULT NULL,
  `saldo_total` decimal(10,2) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_fac_empresa_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_deuda`),
  KEY `Ref15230` (`id_cliente_pk`),
  KEY `Ref94231` (`id_empresa_pk`,`id_fac_empresa_pk`,`serie`),
  KEY `Ref17232` (`id_empresa_pk`),
  KEY `Reffactura231` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `deuda`
--

INSERT INTO `deuda` (`id_deuda`, `monto`, `saldo_total`, `id_cliente_pk`, `id_fac_empresa_pk`, `id_empresa_pk`, `serie`, `estado`) VALUES
(1, '1500.00', '1500.00', 3, 1, 1, '', NULL),
(2, '60.21', '60.21', 3, 8, 1, 'A', NULL),
(3, '437.92', '437.92', 2, 9, 1, 'A', NULL),
(4, '-32929.68', '-32929.68', 2, 10, 1, 'A', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devengos`
--

CREATE TABLE IF NOT EXISTS `devengos` (
  `id_devengos_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado` char(25) DEFAULT 'ACTIVO',
  `nombre` char(100) DEFAULT NULL,
  `detalle` char(250) DEFAULT NULL,
  `cantidad_debengado` decimal(10,2) DEFAULT NULL,
  `cuotas` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `id_planilla_igss_pk` int(11) NOT NULL,
  `id_detalle_impuesto_pk` int(11) NOT NULL,
  `id_detalle_com_ventas` int(11) NOT NULL,
  `id_com_venta_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_devengos_pk`),
  KEY `Ref237448` (`id_planilla_igss_pk`),
  KEY `Ref256450` (`id_detalle_impuesto_pk`),
  KEY `Ref272497` (`id_empleados_pk`,`id_detalle_com_ventas`,`id_com_venta_pk`),
  KEY `Ref238386` (`id_empleados_pk`),
  KEY `Refdetalle_com_ventas497` (`id_detalle_com_ventas`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `devengos`
--

INSERT INTO `devengos` (`id_devengos_pk`, `estado`, `nombre`, `detalle`, `cantidad_debengado`, `cuotas`, `fecha`, `id_empleados_pk`, `id_planilla_igss_pk`, `id_detalle_impuesto_pk`, `id_detalle_com_ventas`, `id_com_venta_pk`) VALUES
(1, 'ACTIVO', 'Nuevo Devengo', 'Horas Extra', '1000.96', 1, '2016-09-23', 1, 0, 0, 0, 0),
(2, 'ACTIVO', 'Bonificacion', 'Bono por asistencia laboral', '2000.00', 1, '2016-09-18', 1, 0, 0, 0, 0),
(3, 'ACTIVO', 'Horas Extra', 'Bonificacion por trabajar horas extra durante el mes de Septiembre', '1500.00', 1, '2016-09-13', 2, 0, 0, 0, 0),
(4, 'ACTIVO', 'bonificacion asistencia', 'asistencia completa durante periodo de trabajo', '2500.00', 2, '2016-08-10', 1, 0, 0, 0, 0),
(5, 'INACTIVO', 'asdf', 'asdf', '1500.00', 1, '2016-11-10', 3, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion_compra`
--

CREATE TABLE IF NOT EXISTS `devolucion_compra` (
  `id_devolucion_compra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `encargado` char(25) DEFAULT NULL,
  `fecha_devolucion` char(25) DEFAULT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_bodega_pk` int(11) NOT NULL,
  `id_factura_compra_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_devolucion_compra_pk`),
  KEY `Ref5469` (`id_bodega_pk`),
  KEY `Ref125473` (`id_factura_compra_pk`),
  KEY `Ref124474` (`id_proveedor_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `devolucion_compra`
--

INSERT INTO `devolucion_compra` (`id_devolucion_compra_pk`, `encargado`, `fecha_devolucion`, `estado`, `id_bodega_pk`, `id_factura_compra_pk`, `id_proveedor_pk`) VALUES
(1, 'Cristian cisneros', '2016-11-09', 'activo', 1, 1, 1),
(2, 'jose', '2016-11-09', 'activo', 1, 1, 1),
(3, 'selvin', '2016-11-10', 'activo', 1, 2, 1),
(4, 'SelvinTiniguar', '11/10/2016 10:11:05 AM', NULL, 1, 2, 2),
(5, 'Javier', '2016-11-10', 'activo', 2, 7, 1),
(6, 'Juan', '11/10/2016 11:34:25 AM', NULL, 0, 4, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion_detventa`
--

CREATE TABLE IF NOT EXISTS `devolucion_detventa` (
  `id_detalle_dec` int(11) NOT NULL AUTO_INCREMENT,
  `id_dev` int(11) NOT NULL,
  `id_bien` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `precio` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL,
  `estado` varchar(20) DEFAULT 'activo',
  PRIMARY KEY (`id_detalle_dec`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion_venta`
--

CREATE TABLE IF NOT EXISTS `devolucion_venta` (
  `id_dev` int(11) NOT NULL AUTO_INCREMENT,
  `id_empresa` int(11) NOT NULL,
  `id_fact_emp` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `fecha` varchar(30) NOT NULL,
  `motivo` varchar(200) NOT NULL,
  `total` decimal(10,0) NOT NULL,
  `estado` varchar(20) NOT NULL DEFAULT 'activo',
  PRIMARY KEY (`id_dev`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `disponibilidad_bancaria`
--

CREATE TABLE IF NOT EXISTS `disponibilidad_bancaria` (
  `id_disponibilidad_bancaria` int(11) NOT NULL AUTO_INCREMENT,
  `estado` char(25) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_cuenta_bancaria_pk` int(11) NOT NULL,
  `id_tipo_documento` int(11) NOT NULL,
  PRIMARY KEY (`id_disponibilidad_bancaria`),
  KEY `Ref232377` (`id_cuenta_bancaria_pk`),
  KEY `Ref229378` (`id_tipo_documento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `documento`
--

CREATE TABLE IF NOT EXISTS `documento` (
  `id_documento_pk` int(11) NOT NULL AUTO_INCREMENT,
  `conciliado` char(50) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `valor_total` decimal(10,2) DEFAULT NULL,
  `destinatario` char(100) DEFAULT NULL,
  `no_documento` char(100) DEFAULT NULL,
  `descripcion` char(250) DEFAULT NULL,
  `estado` char(50) DEFAULT 'ACTIVO',
  `id_cuenta_bancaria_pk` int(11) NOT NULL,
  `id_tipo_documento` int(11) NOT NULL,
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_documento_pk`),
  KEY `Ref232375` (`id_cuenta_bancaria_pk`),
  KEY `Ref229376` (`id_tipo_documento`),
  KEY `Ref123385` (`id_proveedor_pk`,`id_cuenta_pk`),
  KEY `Refcuenta_corriente_por_pagar385` (`id_cuenta_pk`,`id_proveedor_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Volcado de datos para la tabla `documento`
--

INSERT INTO `documento` (`id_documento_pk`, `conciliado`, `fecha`, `valor_total`, `destinatario`, `no_documento`, `descripcion`, `estado`, `id_cuenta_bancaria_pk`, `id_tipo_documento`, `id_cuenta_pk`, `id_proveedor_pk`) VALUES
(1, 'Conciliado', '2016-11-07', '485.00', 'otto hernandez', '2131231', 'para cambios en servidor', 'ACTIVO', 1, 1, 0, 0),
(2, 'Conciliado', '2016-11-17', '5400.00', 'hotel san carlos', '5465138', 'pago de mes', 'ACTIVO', 2, 1, 0, 0),
(3, 'No Conciliado', '2016-11-24', '4100.00', 'hotel san carlos', '453134', 'sadasgeqwd', 'ACTIVO', 3, 2, 0, 0),
(4, 'Conciliado', '2016-11-04', '3200.00', 'wadasdas', '48495618', 'asdasv', 'ACTIVO', 1, 2, 0, 0),
(5, 'Conciliado', '2016-11-29', '56412.00', 'otto hernandez', '8549526', 'sadas', 'ACTIVO', 1, 3, 1, 0),
(6, 'No Conciliado', '2016-11-11', '45.00', 'javier figueroa', '654231654', 'hola', 'ACTIVO', 3, 4, 3, 1),
(7, 'Conciliado', '2016-11-04', '6900.00', 'asdasda', '45654', 'dgdfgdf', 'ACTIVO', 2, 1, 0, 0),
(8, 'Conciliado', '2016-11-18', '6500.44', 'rfsfsdfds', '324234', 'dsfsd', 'ACTIVO', 2, 4, 2, 2),
(9, 'Conciliado', '2016-11-29', '3200.00', 'asdas', '516235', 'sadas', 'ACTIVO', 2, 3, 2, 0),
(10, 'Conciliado', '2016-11-09', '7000.00', 'dan', '241233', 'nuevo servidor', 'ACTIVO', 2, 1, 0, 0),
(11, 'No Conciliado', '2016-11-01', '540000.00', 'hotel san carlos', '12345', 'pago de cliente Javier', 'ACTIVO', 2, 1, 0, 0),
(12, 'No Conciliado', '2016-11-10', '546512.00', 'comedor central de Guatemala', '5687457', 'pago de evento', 'ACTIVO', 2, 2, 0, 0),
(13, 'No Conciliado', '2016-11-16', '455.00', 'javier figueroa', '56415216', 'este documento es de debito', 'ACTIVO', 3, 4, 3, 1),
(14, 'No Conciliado', '2016-11-29', '2000.00', 'javier figueroa', '654656', 'se acredita un pago', 'ACTIVO', 2, 3, 2, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `doc_impuesto`
--

CREATE TABLE IF NOT EXISTS `doc_impuesto` (
  `id_doc_imp` int(11) NOT NULL AUTO_INCREMENT,
  `documento` varchar(25) DEFAULT NULL,
  `id_impuesto_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_doc_imp`),
  KEY `Ref155463` (`id_impuesto_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE IF NOT EXISTS `empleado` (
  `id_empleados_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_sueldo` char(25) DEFAULT NULL,
  `procentaje` decimal(10,2) DEFAULT NULL,
  `nombre` char(100) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `edad` char(10) DEFAULT NULL,
  `dpi` char(13) DEFAULT NULL,
  `nacionalidad` char(25) DEFAULT NULL,
  `estado_civil` char(25) DEFAULT NULL,
  `no_afiliacion_igss` char(50) DEFAULT NULL,
  `fecha_ingreso` date DEFAULT NULL,
  `fecha_egreso` date DEFAULT NULL,
  `direccion` char(10) DEFAULT NULL,
  `cargo` char(250) DEFAULT NULL,
  `telefono` char(15) DEFAULT NULL,
  `genero` char(10) DEFAULT NULL,
  `sueldo` int(11) DEFAULT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `disponibilidad` char(30) DEFAULT NULL,
  `foto_empleado` varchar(200) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_jornada_tra_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_empleados_pk`),
  KEY `Ref17398` (`id_empresa_pk`),
  KEY `Ref270488` (`id_jornada_tra_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`id_empleados_pk`, `tipo_sueldo`, `procentaje`, `nombre`, `fecha_nacimiento`, `edad`, `dpi`, `nacionalidad`, `estado_civil`, `no_afiliacion_igss`, `fecha_ingreso`, `fecha_egreso`, `direccion`, `cargo`, `telefono`, `genero`, `sueldo`, `estado`, `disponibilidad`, `foto_empleado`, `id_empresa_pk`, `id_jornada_tra_pk`) VALUES
(1, 'SUEDLO', '7.00', 'Daniel', '2016-11-07', '28', '8832838', 'GT', 'S', 'AFILIADO', '2016-11-23', '2016-11-24', 'Direcc', 'VENDEDOR', '28283', 'M', 7300, 'ACTIVO', '1', '\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0', 1, 1),
(2, 'Suedlo', NULL, 'Cristian', '2016-11-20', '29', '287282', 'Guatemala', 'Viudo/a', '231232', '2016-11-06', '2016-11-09', '22 zona1', 'Vendedor', '9372', 'Masculino', 8000, 'ACTIVO', '1', 'z.jpg', 1, 1),
(3, 'mensual', NULL, 'Nilson Reguan', '1993-08-30', '23', '123456789', 'Guatemala', 'Soltero/a', '123456789', '2016-11-09', '2016-11-11', 'Mixco Guat', 'Vendedor', '123456789', 'Masculino', 1500, 'ACTIVO', NULL, 'wallpapers-17.jpg', 1, 0),
(4, 'mensual', NULL, 'Nilson Reguan', '1993-08-30', '23', '123456789', 'Guatemala', 'Soltero/a', '123456789', '2016-11-09', '2016-11-11', 'Mixco Guat', 'Vendedor', '123456789', 'Masculino', 1500, 'INACTIVO', NULL, 'wallpapers-17.jpg', 1, 0),
(5, 'mensual', NULL, 'Otto Hernandez', '1988-12-25', '23', '123456', 'Guatemala', 'Soltero/a', '1234', '2016-11-10', '2016-11-10', 'Mixco Guat', 'Recepcion', '1231564', 'Masculino', 1500, 'ACTIVO', NULL, '47702056-wallpapers-hd-games.jpg', 1, 1);

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
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`id_empresa_pk`, `nombre`, `direccion`, `region`, `estrellas_hotel`, `nit`, `correo`, `telefono`, `estado`) VALUES
(1, 'Hotel 1', 'direccion ', 'GT', '3', '382827', 'correo', '38342', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_documento`
--

CREATE TABLE IF NOT EXISTS `encabezado_documento` (
  `no_doc` char(18) NOT NULL,
  `serie_doc` char(18) NOT NULL,
  `tipo_doc` char(40) NOT NULL,
  `empresa` char(20) NOT NULL,
  `fecha` char(20) DEFAULT NULL,
  `estado_doc` char(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `clie_prov` int(11) DEFAULT NULL,
  PRIMARY KEY (`no_doc`,`serie_doc`,`tipo_doc`,`empresa`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `encabezado_documento`
--

INSERT INTO `encabezado_documento` (`no_doc`, `serie_doc`, `tipo_doc`, `empresa`, `fecha`, `estado_doc`, `estado`, `clie_prov`) VALUES
('2', '-', 'Orden de compra', '1', '2016-11-09', 'procesado', 'activo', 2),
('3', '-', 'Orden de compra', '1', '2016-11-09', 'procesado', 'activo', 2),
('4', '-', 'Orden de compra', '1', '2016-11-10', 'procesado', 'activo', 2),
('2', 'A', 'Factura', '1', '2016-11-10', 'procesado', 'activo', NULL),
('1', 'A', 'Factura', '1', '2016-11-10', 'procesado', 'activo', NULL),
('5', '-', 'Orden de compra', '1', '2016-11-10', 'procesado', 'activo', 2),
('6', '-', 'Orden de compra', '1', '2016-11-10', 'procesado', 'activo', 2),
('3', '-', 'Devolucion sobre compra', '-', '2016-11-10', 'procesado', 'activo', 1),
('7', '-', 'Orden de compra', '1', '2016-11-10', 'procesado', 'activo', 2),
('5', '-', 'Devolucion sobre compra', '-', '2016-11-10', 'procesado', 'activo', 1),
('8', '-', 'Orden de compra', '1', '2016-11-10', 'procesado', 'activo', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_muestreo`
--

CREATE TABLE IF NOT EXISTS `encabezado_muestreo` (
  `id_muestreo_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `responsable` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_muestreo_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `encabezado_muestreo`
--

INSERT INTO `encabezado_muestreo` (`id_muestreo_pk`, `fecha`, `responsable`, `estado`) VALUES
(1, '2016-11-09', 'df', 'activo'),
(2, '2016-11-09', 'Javier', 'activo'),
(3, '2016-11-09', 'Javier Javier Figueroa Figueroa', 'activo'),
(4, '2016-11-10', 'Rene diaz', 'activo'),
(5, '2016-11-10', 'Otto hernandez', 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_pedido`
--

CREATE TABLE IF NOT EXISTS `encabezado_pedido` (
  `id_encabezado_pedido_pk` int(11) NOT NULL AUTO_INCREMENT,
  `hora_ingreso` char(10) DEFAULT NULL,
  `id_cliente_pk` char(10) DEFAULT NULL,
  `fecha_ingreso` char(18) DEFAULT NULL,
  `fecha_entrega` char(18) DEFAULT NULL,
  `hora_entrega` timestamp NULL DEFAULT NULL,
  `id_empleados_pk` char(10) DEFAULT NULL,
  `estado` varchar(10) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_encabezado_pedido_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=20160006 ;

--
-- Volcado de datos para la tabla `encabezado_pedido`
--

INSERT INTO `encabezado_pedido` (`id_encabezado_pedido_pk`, `hora_ingreso`, `id_cliente_pk`, `fecha_ingreso`, `fecha_entrega`, `hora_entrega`, `id_empleados_pk`, `estado`, `id_empresa_pk`) VALUES
(20160001, '09:54:31', '3', '2016-11-10', '2016-11-10', '0000-00-00 00:00:00', '1', '', 0),
(20160002, '09:55:08', '', '2016-11-10', '2016-11-10', '0000-00-00 00:00:00', '1', '', 0),
(20160003, '10:02:05', '3', '2016-11-10', '2016-11-10', '0000-00-00 00:00:00', '1', 'activo', 0),
(20160004, '10:16:12', '3', '2016-11-10', '2016-11-10', '0000-00-00 00:00:00', '1', 'pend', 0),
(20160005, '11:01:19', '3', '2016-11-10', '2016-11-10', '0000-00-00 00:00:00', '1', '', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `evento`
--

CREATE TABLE IF NOT EXISTS `evento` (
  `id_evento_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `fecha_entrada` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `hora_entrada` int(11) NOT NULL,
  `hora_salida` int(11) NOT NULL,
  `costo` int(11) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_salon_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_evento_pk`),
  KEY `Ref1552` (`id_cliente_pk`),
  KEY `Ref1953` (`id_salon_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `evento`
--

INSERT INTO `evento` (`id_evento_pk`, `nombre`, `fecha_entrada`, `fecha_salida`, `hora_entrada`, `hora_salida`, `costo`, `estado`, `id_cliente_pk`, `id_salon_pk`) VALUES
(1, 'boda', '2016-11-06', '2016-11-08', 2, 13, 19500, 'reservado', 2, 1),
(2, 'cumpleaños', '2016-11-09', '2016-11-10', 3, 2, 20500, 'reservado', 1, 1),
(4, '15 años', '2016-11-06', '2016-11-08', 2, 13, 14500, 'reservado', 2, 2),
(5, 'boda', '2016-11-09', '2016-11-11', 13, 2, 30500, 'reservado', 2, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE IF NOT EXISTS `factura` (
  `id_fac_empresa_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  `marca_comision` char(10) DEFAULT 'X',
  `fecha_vencimiento` date DEFAULT NULL,
  `estado_factura` varchar(15) DEFAULT NULL,
  `fecha_emision` date NOT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_impuesto_pk` int(11) DEFAULT NULL,
  `id_moneda` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_parametros_pk` int(11) DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  KEY `Ref246405` (`id_moneda`),
  KEY `Ref251462` (`id_parametros_pk`),
  KEY `Ref17241` (`id_empresa_pk`),
  KEY `Ref155246` (`id_impuesto_pk`),
  KEY `Ref238483` (`id_empleados_pk`),
  KEY `Ref15126` (`id_cliente_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`id_fac_empresa_pk`, `id_empresa_pk`, `serie`, `marca_comision`, `fecha_vencimiento`, `estado_factura`, `fecha_emision`, `subtotal`, `total`, `id_cliente_pk`, `id_impuesto_pk`, `id_moneda`, `estado`, `id_parametros_pk`, `id_empleados_pk`) VALUES
(1, 1, '1', 'S', '2016-11-21', 'ACTIVO', '2016-11-01', '4000.00', '4100.00', 1, 1, 1, 'ACTIVO', 1, 1),
(2, 1, '3', 'X', '2016-11-08', 'ACTIVO', '2016-12-19', '3000.00', '3300.00', 1, 1, 1, 'ACTIVO', 1, 1),
(3, 1, '4', 'X', '2016-11-09', 'ACTIVO', '2016-11-25', '5000.00', '5000.00', 1, 1, 1, 'ACTIVO', 1, 2),
(4, 1, '44', 'X', '2016-11-16', 'ACTIVO', '2016-12-12', '6000.00', '6100.00', 1, 1, 1, 'ACTIVO', 1, 2),
(5, 1, '5', 'X', '2016-11-17', 'ACTIVO', '2016-11-09', '8000.00', '8000.00', 1, 1, 1, 'ACTIVO', 1, 2),
(6, 1, '6', 'X', '2016-11-18', 'ACTIVO', '2016-11-09', '15000.00', '15000.00', 1, 1, 1, 'ACTIVO', 1, 2),
(7, 1, 'A', 'X', '0000-00-00', NULL, '0000-00-00', '50.60', '60.21', 3, 0, NULL, 'ACTIVO', NULL, 1),
(8, 1, 'A', 'X', '0000-00-00', NULL, '0000-00-00', '50.60', '60.21', 3, 0, NULL, 'ACTIVO', NULL, 1),
(9, 1, 'A', 'X', '0000-00-00', NULL, '0000-00-00', '368.00', '437.92', 2, 0, NULL, 'ACTIVO', NULL, 1),
(10, 1, 'A', 'X', '0000-00-00', NULL, '0000-00-00', '-27672.00', '-32929.68', 2, -5258, NULL, 'ACTIVO', NULL, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura documento`
--

CREATE TABLE IF NOT EXISTS `factura documento` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_documento_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`id_documento_pk`,`serie`),
  KEY `Ref94383` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  KEY `Ref234384` (`id_documento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_detalle`
--

CREATE TABLE IF NOT EXISTS `factura_detalle` (
  `id_detalle_fact` int(11) NOT NULL AUTO_INCREMENT,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `id_precio` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `precio` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL,
  `estado` char(15) DEFAULT 'activo',
  PRIMARY KEY (`id_detalle_fact`),
  KEY `Ref94247` (`serie`),
  KEY `Reffactura247` (`serie`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=230 ;

--
-- Volcado de datos para la tabla `factura_detalle`
--

INSERT INTO `factura_detalle` (`id_detalle_fact`, `id_fac_empresa_pk`, `id_empresa_pk`, `serie`, `id_precio`, `cantidad`, `descripcion`, `precio`, `subtotal`, `estado`) VALUES
(13, 13, 3, 'A', 53, 1, 'ART1', 15, 15, 'ACTIVO'),
(12, 13, 3, 'A', 43, 1, 'ART1', 15, 15, 'ACTIVO'),
(11, 13, 3, 'A', 54, 1, 'ART1', 15, 15, 'ACTIVO'),
(14, 14, 3, 'A', 54, 1, 'ART1', 15, 15, 'ACTIVO'),
(15, 14, 3, 'A', 43, 1, 'ART1', 15, 15, NULL),
(16, 14, 3, 'A', 53, 1, 'ART1', 15, 15, NULL),
(17, 15, 3, 'C', 54, 1, 'ART1', 15, 15, NULL),
(18, 15, 3, 'C', 43, 1, 'ART1', 15, 15, NULL),
(19, 16, 1, 'A', 54, 1, 'ART1', 15, 15, NULL),
(20, 16, 1, 'A', 43, 1, 'ART1', 15, 15, NULL),
(21, 16, 1, 'A', 53, 1, 'ART1', 15, 15, NULL),
(22, 17, 3, 'A', 38, 1, '1', 200, 200, NULL),
(23, 17, 3, 'A', 52, 1, 'PRO1', 400, 400, NULL),
(24, 17, 3, 'A', 55, 1, 'ART1', 15, 15, NULL),
(25, 17, 3, 'A', 48, 1, 'SAL1', 300, 300, NULL),
(26, 17, 3, 'A', 49, 1, 'SAL1', 300, 300, NULL),
(27, 17, 3, 'A', 44, 1, 'PRO1', 400, 400, NULL),
(28, 17, 3, 'A', 40, 1, 'SAL1', 300, 300, NULL),
(29, 17, 3, 'A', 50, 1, 'art2', 15, 15, NULL),
(30, 17, 3, 'A', 51, 1, '1', 200, 200, NULL),
(31, 17, 3, 'A', 47, 1, '1', 200, 200, NULL),
(32, 17, 3, 'A', 39, 1, '1', 200, 200, NULL),
(33, 18, 3, 'A', 38, 1, '1', 200, 200, NULL),
(34, 18, 3, 'A', 52, 1, 'PRO1', 400, 400, NULL),
(35, 18, 3, 'A', 55, 1, 'ART1', 15, 15, NULL),
(36, 18, 3, 'A', 48, 1, 'SAL1', 300, 300, NULL),
(37, 18, 3, 'A', 49, 1, 'SAL1', 300, 300, NULL),
(38, 18, 3, 'A', 44, 1, 'PRO1', 400, 400, NULL),
(39, 18, 3, 'A', 40, 1, 'SAL1', 300, 300, NULL),
(40, 18, 3, 'A', 50, 1, 'art2', 15, 15, NULL),
(41, 18, 3, 'A', 51, 1, '1', 200, 200, NULL),
(42, 18, 3, 'A', 47, 1, '1', 200, 200, NULL),
(43, 18, 3, 'A', 39, 1, '1', 200, 200, NULL),
(44, 19, 3, 'B', 54, 1, 'ART1', 15, 15, NULL),
(45, 19, 3, 'B', 43, 1, 'ART1', 15, 15, NULL),
(46, 19, 3, 'B', 53, 1, 'ART1', 15, 15, NULL),
(47, 21, 1, 'B', 1, 2, 'ART1', 15, 30, NULL),
(48, 21, 1, 'B', 5, 5, 'Teclado', 10, 50, NULL),
(49, 21, 1, 'B', 9, 1, 'Marcadore', 25, 25, NULL),
(50, 21, 1, 'B', 8, 3, 'Globos', 100, 300, NULL),
(51, 22, 1, 'B', 1, 2, 'ART1', 15, 30, NULL),
(52, 22, 1, 'B', 5, 5, 'Teclado', 10, 50, NULL),
(53, 22, 1, 'B', 9, 1, 'Marcadore', 25, 25, NULL),
(54, 22, 1, 'B', 8, 3, 'Globos', 100, 300, NULL),
(55, 23, 1, 'B', 38, 1, '1', 200, 200, NULL),
(56, 23, 1, 'B', 52, 1, 'PRO1', 400, 400, NULL),
(57, 23, 1, 'B', 55, 1, 'ART1', 15, 15, NULL),
(58, 23, 1, 'B', 48, 1, 'SAL1', 300, 300, NULL),
(59, 23, 1, 'B', 49, 1, 'SAL1', 300, 300, NULL),
(60, 23, 1, 'B', 44, 1, 'PRO1', 400, 400, NULL),
(61, 23, 1, 'B', 40, 1, 'SAL1', 300, 300, NULL),
(62, 23, 1, 'B', 50, 1, 'art2', 15, 15, NULL),
(63, 23, 1, 'B', 51, 1, '1', 200, 200, NULL),
(64, 23, 1, 'B', 47, 1, '1', 200, 200, NULL),
(65, 23, 1, 'B', 39, 1, '1', 200, 200, NULL),
(66, 24, 3, 'C', 54, 1, 'ART1', 15, 15, NULL),
(67, 24, 3, 'C', 43, 1, 'ART1', 15, 15, NULL),
(68, 25, 3, 'A', 54, 1, 'ART1', 15, 15, NULL),
(69, 25, 3, 'A', 43, 1, 'ART1', 15, 15, NULL),
(70, 26, 3, 'B', 54, 1, 'ART1', 15, 15, NULL),
(71, 26, 3, 'B', 43, 1, 'ART1', 15, 15, NULL),
(72, 26, 3, 'B', 53, 1, 'ART1', 15, 15, NULL),
(73, 27, 1, 'C', 1, 2, 'ART1', 15, 30, NULL),
(74, 27, 1, 'C', 5, 5, 'Teclado', 10, 50, NULL),
(75, 27, 1, 'C', 9, 1, 'Marcadore', 25, 25, NULL),
(76, 27, 1, 'C', 8, 3, 'Globos', 100, 300, NULL),
(77, 28, 1, 'A', 38, 1, '1', 200, 200, NULL),
(78, 28, 1, 'A', 52, 1, 'PRO1', 400, 400, NULL),
(79, 28, 1, 'A', 55, 1, 'ART1', 15, 15, NULL),
(80, 28, 1, 'A', 48, 1, 'SAL1', 300, 300, NULL),
(81, 28, 1, 'A', 49, 1, 'SAL1', 300, 300, NULL),
(82, 28, 1, 'A', 44, 1, 'PRO1', 400, 400, NULL),
(83, 28, 1, 'A', 40, 1, 'SAL1', 300, 300, NULL),
(84, 28, 1, 'A', 50, 1, 'art2', 15, 15, NULL),
(85, 28, 1, 'A', 51, 1, '1', 200, 200, NULL),
(86, 28, 1, 'A', 47, 1, '1', 200, 200, NULL),
(87, 28, 1, 'A', 39, 1, '1', 200, 200, NULL),
(88, 29, 1, 'B', 1, 3, 'ART1', 15, 45, NULL),
(89, 29, 1, 'B', 5, 6, 'Teclado', 10, 60, NULL),
(90, 29, 1, 'B', 9, 1, 'Marcadore', 25, 25, NULL),
(91, 29, 1, 'B', 10, 3, 'Lapiz', 40, 120, NULL),
(92, 29, 1, 'B', 4, 10, 'Mouse', 5, 50, NULL),
(93, 30, 3, 'A', 54, 1, 'ART1', 15, 15, NULL),
(94, 30, 3, 'A', 43, 1, 'ART1', 15, 15, NULL),
(95, 30, 3, 'A', 53, 1, 'ART1', 15, 15, NULL),
(96, 31, 1, 'C', 1, 3, 'ART1', 15, 45, NULL),
(97, 31, 1, 'C', 5, 6, 'Teclado', 10, 60, NULL),
(98, 31, 1, 'C', 9, 1, 'Marcadore', 25, 25, NULL),
(99, 31, 1, 'C', 10, 3, 'Lapiz', 40, 120, NULL),
(100, 31, 1, 'C', 4, 10, 'Mouse', 5, 50, NULL),
(101, 32, 1, 'A', 54, 1, 'ART1', 15, 15, NULL),
(102, 32, 1, 'A', 43, 1, 'ART1', 15, 15, NULL),
(103, 32, 1, 'A', 53, 1, 'ART1', 15, 15, NULL),
(104, 33, 2, 'B', 54, 1, 'ART1', 15, 15, NULL),
(105, 33, 2, 'B', 43, 1, 'ART1', 15, 15, NULL),
(106, 33, 2, 'B', 53, 1, 'ART1', 15, 15, NULL),
(107, 34, 2, 'B', 54, 1, 'ART1', 15, 15, NULL),
(108, 34, 2, 'B', 43, 1, 'ART1', 15, 15, NULL),
(109, 34, 2, 'B', 53, 1, 'ART1', 15, 15, NULL),
(110, 35, 1, 'C', 54, 1, 'ART1', 15, 15, NULL),
(111, 35, 1, 'C', 43, 1, 'ART1', 15, 15, NULL),
(112, 35, 1, 'C', 53, 1, 'ART1', 15, 15, NULL),
(113, 36, 1, 'C', 54, 1, 'ART1', 15, 15, NULL),
(114, 36, 1, 'C', 43, 1, 'ART1', 15, 15, NULL),
(115, 36, 1, 'C', 53, 1, 'ART1', 15, 15, NULL),
(116, 37, 1, 'C', 1, 2, 'ART1', 15, 30, NULL),
(117, 37, 1, 'C', 5, 5, 'Teclado', 10, 50, NULL),
(118, 37, 1, 'C', 9, 1, 'Marcadore', 25, 25, NULL),
(119, 37, 1, 'C', 8, 3, 'Globos', 100, 300, NULL),
(120, 38, 3, 'C', 54, 1, 'ART1', 15, 15, NULL),
(121, 38, 3, 'C', 43, 1, 'ART1', 15, 15, NULL),
(122, 38, 3, 'C', 53, 1, 'ART1', 15, 15, NULL),
(123, 39, 3, 'C', 54, 1, 'ART1', 15, 15, NULL),
(124, 39, 3, 'C', 43, 1, 'ART1', 15, 15, NULL),
(125, 39, 3, 'C', 53, 1, 'ART1', 15, 15, NULL),
(126, 40, 2, 'A', 54, 1, 'ART1', 15, 15, NULL),
(127, 40, 2, 'A', 43, 1, 'ART1', 15, 15, NULL),
(128, 40, 2, 'A', 53, 1, 'ART1', 15, 15, NULL),
(129, 41, 2, 'B', 54, 1, 'ART1', 15, 15, NULL),
(130, 41, 2, 'B', 43, 1, 'ART1', 15, 15, NULL),
(131, 41, 2, 'B', 53, 1, 'ART1', 15, 15, NULL),
(132, 42, 2, 'B', 54, 1, 'ART1', 15, 15, NULL),
(133, 42, 2, 'B', 43, 1, 'ART1', 15, 15, NULL),
(134, 42, 2, 'B', 53, 1, 'ART1', 15, 15, NULL),
(135, 43, 1, 'C', 1, 2, 'ART1', 15, 30, NULL),
(136, 43, 1, 'C', 5, 5, 'Teclado', 10, 50, NULL),
(137, 43, 1, 'C', 9, 1, 'Marcadore', 25, 25, NULL),
(138, 43, 1, 'C', 8, 3, 'Globos', 100, 300, NULL),
(139, 44, 1, 'C', 54, 1, 'ART1', 15, 15, NULL),
(140, 44, 1, 'C', 43, 1, 'ART1', 15, 15, NULL),
(141, 44, 1, 'C', 53, 1, 'ART1', 15, 15, NULL),
(142, 45, 3, 'B', 54, 1, 'ART1', 15, 15, NULL),
(143, 45, 3, 'B', 43, 1, 'ART1', 15, 15, NULL),
(144, 45, 3, 'B', 53, 1, 'ART1', 15, 15, NULL),
(145, 46, 1, 'B', 54, 1, 'ART1', 15, 15, NULL),
(146, 46, 1, 'B', 43, 1, 'ART1', 15, 15, NULL),
(147, 46, 1, 'B', 53, 1, 'ART1', 15, 15, NULL),
(148, 47, 3, 'B', 38, 1, '1', 200, 200, NULL),
(149, 47, 3, 'B', 52, 1, 'PRO1', 400, 400, NULL),
(150, 47, 3, 'B', 55, 1, 'ART1', 15, 15, NULL),
(151, 47, 3, 'B', 48, 1, 'SAL1', 300, 300, NULL),
(152, 47, 3, 'B', 49, 1, 'SAL1', 300, 300, NULL),
(153, 47, 3, 'B', 44, 1, 'PRO1', 400, 400, NULL),
(154, 47, 3, 'B', 40, 1, 'SAL1', 300, 300, NULL),
(155, 47, 3, 'B', 50, 1, 'art2', 15, 15, NULL),
(156, 47, 3, 'B', 51, 1, '1', 200, 200, NULL),
(157, 47, 3, 'B', 47, 1, '1', 200, 200, NULL),
(158, 47, 3, 'B', 39, 1, '1', 200, 200, NULL),
(159, 48, 1, 'B', 54, 1, 'ART1', 15, 15, NULL),
(160, 48, 1, 'B', 43, 1, 'ART1', 15, 15, NULL),
(161, 48, 1, 'B', 53, 1, 'ART1', 15, 15, NULL),
(162, 49, 2, 'C', 54, 1, 'ART1', 15, 15, NULL),
(163, 49, 2, 'C', 43, 1, 'ART1', 15, 15, NULL),
(164, 49, 2, 'C', 53, 1, 'ART1', 15, 15, NULL),
(165, 50, 1, 'A', 1, 2, 'ART1', 15, 30, NULL),
(166, 50, 1, 'A', 5, 5, 'Teclado', 10, 50, NULL),
(167, 50, 1, 'A', 9, 1, 'Marcadore', 25, 25, NULL),
(168, 50, 1, 'A', 8, 3, 'Globos', 100, 300, NULL),
(169, 51, 1, 'B', 1, 2, 'ART1', 15, 30, NULL),
(170, 51, 1, 'B', 5, 5, 'Teclado', 10, 50, NULL),
(171, 51, 1, 'B', 9, 1, 'Marcadore', 25, 25, NULL),
(172, 51, 1, 'B', 8, 3, 'Globos', 100, 300, NULL),
(173, 52, 1, 'B', 1, 3, 'ART1', 15, 45, NULL),
(174, 52, 1, 'B', 5, 6, 'Teclado', 10, 60, NULL),
(175, 52, 1, 'B', 9, 1, 'Marcadore', 25, 25, NULL),
(176, 52, 1, 'B', 10, 3, 'Lapiz', 40, 120, NULL),
(177, 52, 1, 'B', 4, 10, 'Mouse', 5, 50, NULL),
(178, 53, 2, 'C', 54, 1, 'ART1', 15, 15, NULL),
(179, 53, 2, 'C', 43, 1, 'ART1', 15, 15, NULL),
(180, 53, 2, 'C', 53, 1, 'ART1', 15, 15, NULL),
(181, 54, 2, 'B', 54, 1, 'ART1', 15, 15, NULL),
(182, 54, 2, 'B', 43, 1, 'ART1', 15, 15, NULL),
(183, 54, 2, 'B', 53, 1, 'ART1', 15, 15, NULL),
(184, 55, 1, 'A', 1, 2, 'ART1', 15, 30, NULL),
(185, 55, 1, 'A', 5, 5, 'Teclado', 10, 50, NULL),
(186, 55, 1, 'A', 9, 1, 'Marcadore', 25, 25, NULL),
(187, 55, 1, 'A', 8, 3, 'Globos', 100, 300, NULL),
(188, 56, 1, 'A', 54, 1, 'ART1', 15, 15, NULL),
(189, 56, 1, 'A', 43, 1, 'ART1', 15, 15, NULL),
(190, 56, 1, 'A', 53, 1, 'ART1', 15, 15, NULL),
(191, 57, 1, 'A', 54, 1, 'ART1', 15, 15, NULL),
(192, 57, 1, 'A', 43, 1, 'ART1', 15, 15, NULL),
(193, 57, 1, 'A', 53, 1, 'ART1', 15, 15, NULL),
(194, 58, 1, 'A', 54, 1, 'ART1', 15, 15, NULL),
(195, 58, 1, 'A', 43, 1, 'ART1', 15, 15, NULL),
(196, 58, 1, 'A', 53, 1, 'ART1', 15, 15, NULL),
(197, 59, 1, 'A', 54, 1, 'ART1', 15, 15, NULL),
(198, 59, 1, 'A', 43, 1, 'ART1', 15, 15, NULL),
(199, 59, 1, 'A', 53, 1, 'ART1', 15, 15, NULL),
(200, 60, 1, 'A', 1, 2, 'ART1', 15, 30, NULL),
(201, 60, 1, 'A', 5, 5, 'Teclado', 10, 50, NULL),
(202, 60, 1, 'A', 9, 1, 'Marcadore', 25, 25, NULL),
(203, 60, 1, 'A', 8, 3, 'Globos', 100, 300, NULL),
(204, 61, 1, 'A', 1, 2, 'ART1', 15, 30, NULL),
(205, 61, 1, 'A', 5, 5, 'Teclado', 10, 50, NULL),
(206, 61, 1, 'A', 9, 1, 'Marcadore', 25, 25, NULL),
(207, 61, 1, 'A', 8, 3, 'Globos', 100, 300, NULL),
(208, 62, 1, 'A', 1, 2, 'ART1', 15, 30, NULL),
(209, 62, 1, 'A', 5, 5, 'Teclado', 10, 50, NULL),
(210, 62, 1, 'A', 9, 1, 'Marcadore', 25, 25, NULL),
(211, 62, 1, 'A', 8, 3, 'Globos', 100, 300, NULL),
(212, 63, 1, 'A', 1, 2, 'ART1', 15, 30, NULL),
(213, 63, 1, 'A', 5, 5, 'Teclado', 10, 50, NULL),
(214, 63, 1, 'A', 9, 1, 'Marcadore', 25, 25, NULL),
(215, 63, 1, 'A', 8, 3, 'Globos', 100, 300, NULL),
(216, 64, 1, 'A', 2, 40, 'art2', 16, 630, NULL),
(217, 64, 1, 'A', 4, 10, 'Mouse', 7, 74, NULL),
(218, 64, 1, 'A', 0, 0, '', 0, 0, NULL),
(219, 65, 1, 'A', 2, 1, 'art2', 16, 16, NULL),
(220, 65, 1, 'A', 0, 0, '', 0, 0, NULL),
(221, 2, 1, 'A', 1, 1, 'Hamburgesa con queso', 25, 25, NULL),
(222, 2, 1, 'A', 0, 0, '', 0, 0, NULL),
(223, 8, 1, 'A', 1, 2, 'pollo dorado', 25, 51, 'activo'),
(224, 8, 1, 'A', 0, 0, '', 0, 0, 'activo'),
(225, 9, 1, 'A', 2, 2, 'Version2licuado', 184, 368, 'activo'),
(226, 9, 1, 'A', 0, 0, '', 0, 0, 'activo'),
(227, 10, 1, 'A', 2, 1, 'boda', -7036, -7036, 'activo'),
(228, 10, 1, 'A', 6, 1, 'PRODUCTO 1', 200, 200, 'activo'),
(229, 10, 1, 'A', 8, 1, 'PRODUCTO 1', 200, 200, 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_pago`
--

CREATE TABLE IF NOT EXISTS `factura_pago` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_forma_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_forma_pk`),
  KEY `Ref94127` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  KEY `Ref99128` (`id_forma_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio`
--

CREATE TABLE IF NOT EXISTS `folio` (
  `id_cuenta_pagar_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado` varchar(10) NOT NULL,
  `fecha_ingreso` date NOT NULL,
  `fecha_pago` char(18) DEFAULT NULL,
  `costo` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_cuenta_pagar_pk`),
  KEY `Ref15167` (`id_cliente_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Volcado de datos para la tabla `folio`
--

INSERT INTO `folio` (`id_cuenta_pagar_pk`, `estado`, `fecha_ingreso`, `fecha_pago`, `costo`, `id_cliente_pk`) VALUES
(1, 'Pendiente', '2016-11-09', NULL, '42478', 1),
(2, 'PAGADO', '2016-11-08', '2016-11-08', '278', 3),
(3, 'Cancelado', '2016-11-08', 'jueves, 10 de novi', '103400', 2),
(4, 'PAGADO', '2016-11-08', '2016-11-08', '0.00', 3),
(5, 'PAGADO', '2016-11-08', '2016-11-08', '0.00', 3),
(6, 'PAGADO', '2016-11-08', '2016-11-08', '0.00', 2),
(7, 'PAGADO', '2016-11-08', '2016-11-08', '0.00', 2),
(8, 'Pendiente', '2016-11-08', NULL, '0.00', 1),
(9, 'PAGADO', '2016-11-08', '2016-11-08', '0.00', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_bien`
--

CREATE TABLE IF NOT EXISTS `folio_bien` (
  `id_folio_bien_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_folio_bien_pk`),
  KEY `Ref33261` (`id_cuenta_pagar_pk`),
  KEY `Ref1262` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Refbien262` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `folio_bien`
--

INSERT INTO `folio_bien` (`id_folio_bien_pk`, `costo`, `fecha`, `id_cuenta_pagar_pk`, `id_bien_pk`, `id_categoria_pk`) VALUES
(1, '200.00', '08/11/2016 09:37:13 a. m.', 1, 1, NULL),
(2, '200.00', '8/11/2016 9:47:15 a. m.', 3, 1, NULL),
(3, '200.00', '8/11/2016 10:44:34 a. m.', 3, 1, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_factura`
--

CREATE TABLE IF NOT EXISTS `folio_factura` (
  `id_cuenta_pagar_pk` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_cuenta_pagar_pk`,`id_fac_empresa_pk`,`id_empresa_pk`),
  KEY `Ref33253` (`id_cuenta_pagar_pk`),
  KEY `Ref94254` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `folio_factura`
--

INSERT INTO `folio_factura` (`id_cuenta_pagar_pk`, `id_fac_empresa_pk`, `id_empresa_pk`, `serie`, `estado`) VALUES
(3, 10, 1, 'A', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_habitacion`
--

CREATE TABLE IF NOT EXISTS `folio_habitacion` (
  `id_folio_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_reserhabit_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_habitacion_pk`),
  KEY `Ref37424` (`id_reserhabit_pk`),
  KEY `Ref33257` (`id_cuenta_pagar_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `folio_habitacion`
--

INSERT INTO `folio_habitacion` (`id_folio_habitacion_pk`, `costo`, `fecha`, `id_cuenta_pagar_pk`, `id_reserhabit_pk`) VALUES
(1, '278.00', '08/11/2016 07:43:06 a. m.', 2, 1),
(2, '278.00', '08/11/2016 09:17:22 a. m.', 1, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_promocion`
--

CREATE TABLE IF NOT EXISTS `folio_promocion` (
  `id_folio_promocion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` int(11) NOT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_promocion_pk`),
  KEY `Ref33263` (`id_cuenta_pagar_pk`),
  KEY `Ref25264` (`id_promocion_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `folio_promocion`
--

INSERT INTO `folio_promocion` (`id_folio_promocion_pk`, `costo`, `fecha`, `id_cuenta_pagar_pk`, `id_promocion_pk`) VALUES
(1, 1000, '8/11/2016 9:47:26 a. m.', 3, 1),
(2, 1000, '8/11/2016 9:48:48 a. m.', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_salon`
--

CREATE TABLE IF NOT EXISTS `folio_salon` (
  `id_folio_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_evento_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_salon_pk`),
  KEY `Ref26443` (`id_evento_pk`),
  KEY `Ref33259` (`id_cuenta_pagar_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `folio_salon`
--

INSERT INTO `folio_salon` (`id_folio_salon_pk`, `costo`, `fecha`, `id_cuenta_pagar_pk`, `id_evento_pk`) VALUES
(1, '58500.00', '08/11/2016 08:09:32 a.m.', 3, 1),
(2, '41000.00', '08/11/2016 09:18:45 a. m.', 1, 2),
(3, '43500.00', '8/11/2016 10:43:17 a. m.', 3, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `forma_pago`
--

CREATE TABLE IF NOT EXISTS `forma_pago` (
  `id_forma_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_pago` varchar(25) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `estado` char(15) DEFAULT 'activo',
  PRIMARY KEY (`id_forma_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `forma_pago`
--

INSERT INTO `forma_pago` (`id_forma_pk`, `tipo_pago`, `descripcion`, `estado`) VALUES
(1, 'efectivo', 'con dinero real', 'ACTIVO'),
(2, 'credito', 'por pagos', 'ACTIVO'),
(3, 'documento', 'promociones', 'ACTIVO'),
(4, 'Cheque', 'cheques a nombre de la empresa', NULL);

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
  `estado` char(15) DEFAULT NULL,
  `id_factura_compra_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_importacion_pk`),
  KEY `Ref125172` (`id_factura_compra_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `gastos_importacion`
--

INSERT INTO `gastos_importacion` (`id_importacion_pk`, `transporte`, `direccion_salida`, `hora_fecha_salida`, `direccion_llegada`, `hora_fecha_llegada`, `aduana`, `otros_impuestos`, `estado`, `id_factura_compra_pk`) VALUES
(1, 'Avion', 'Areapuerto 2', '2016-10-30', 'Areopuerto 1', '2016-11-16', '22', '33', 'ACTIVO', 9);

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
  PRIMARY KEY (`id_habitacion_pk`),
  KEY `Ref3444` (`id_tipo_pk`),
  KEY `Ref17161` (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `habitacion`
--

INSERT INTO `habitacion` (`id_habitacion_pk`, `nombre`, `nivel`, `estrellas_habitacion`, `descripcion`, `estado`, `id_tipo_pk`, `id_empresa_pk`) VALUES
(1, 'T200', 2, '3', 'Datos', 'ACTIVADO', 1, 1),
(2, 'T-300', 1, '4', 'DATOS 2', 'ACTIVADO', 2, 1),
(3, 'habitacion', 5, '5', 'hola', 'ACTIVADO', 2, 1),
(4, 'T-400', 5, '5', 'habitacion', 'ACTIVO', 2, 1),
(5, 'prueba', 5, '5', 'hola', 'ACTIVO', 3, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `impuesto`
--

CREATE TABLE IF NOT EXISTS `impuesto` (
  `id_impuesto_pk` int(11) NOT NULL AUTO_INCREMENT,
  `porcentaje` decimal(18,2) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_impuesto_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `impuesto`
--

INSERT INTO `impuesto` (`id_impuesto_pk`, `porcentaje`, `nombre`, `descripcion`, `estado`) VALUES
(1, '0.12', 'Iva', 'impuesto al valor agregado', 'activo'),
(2, '0.07', 'ISR', 'Impuesto sobre la renta', 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `impuestos_ley`
--

CREATE TABLE IF NOT EXISTS `impuestos_ley` (
  `id_detalle_impuesto_pk` int(11) NOT NULL AUTO_INCREMENT,
  `porcentaje_impuesto` decimal(10,2) DEFAULT NULL,
  `rango_relaciones` varchar(50) DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_impuesto_pk`),
  KEY `Ref238451` (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

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
  PRIMARY KEY (`id_invitado_pk`),
  KEY `Ref2621` (`id_evento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `jornada_trabajo`
--

CREATE TABLE IF NOT EXISTS `jornada_trabajo` (
  `id_jornada_tra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `jornada` char(25) DEFAULT NULL,
  `horas_trabajo` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT 'ACTIVO',
  PRIMARY KEY (`id_jornada_tra_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `jornada_trabajo`
--

INSERT INTO `jornada_trabajo` (`id_jornada_tra_pk`, `jornada`, `horas_trabajo`, `estado`) VALUES
(1, 'Jornada Diurna', 8, 'ACTIVO'),
(2, 'Jornada Nocturna', 6, 'ACTIVO'),
(3, 'Jornada Mixta', 7, 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `linea`
--

CREATE TABLE IF NOT EXISTS `linea` (
  `id_linea_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_linea` char(40) DEFAULT NULL,
  `porcentaje_comision` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_linea_pk`),
  KEY `Ref9430` (`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Volcado de datos para la tabla `linea`
--

INSERT INTO `linea` (`id_linea_pk`, `nombre_linea`, `porcentaje_comision`, `estado`, `id_categoria_pk`) VALUES
(8, 'Condimentos', NULL, 'activo', 'MP'),
(7, 'Platillo fuerte', NULL, 'activo', 'PT'),
(3, 'Lacteos', NULL, 'activo', 'MP'),
(4, 'Verduras', NULL, 'activo', 'MP'),
(5, 'Frutas', NULL, 'activo', 'MP'),
(6, 'Embutidos', NULL, 'activo', 'MP'),
(9, 'Electronicos', NULL, 'activo', 'AF');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE IF NOT EXISTS `marca` (
  `id_marca_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_marca` char(50) DEFAULT NULL,
  `procentaje_comision` decimal(10,2) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_marca_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`id_marca_pk`, `nombre_marca`, `procentaje_comision`, `estado`) VALUES
(1, 'NIKE', '6.00', 'activo'),
(2, 'Adidas', '7.00', 'activo'),
(3, 'Sula', NULL, 'activo'),
(4, 'HSC', NULL, 'activo'),
(5, 'Maller', NULL, 'activo'),
(6, 'Naturas', NULL, 'activo'),
(7, 'Samsung', NULL, 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medida`
--

CREATE TABLE IF NOT EXISTS `medida` (
  `id_medida_pk` int(11) NOT NULL AUTO_INCREMENT,
  `valor` char(10) DEFAULT NULL,
  `nombre_medida` char(30) DEFAULT NULL,
  `abreviatura` char(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_medida_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `medida`
--

INSERT INTO `medida` (`id_medida_pk`, `valor`, `nombre_medida`, `abreviatura`, `estado`) VALUES
(1, NULL, 'Unidades', 'Und.', 'activo'),
(2, NULL, 'gramos', 'gr', 'activo'),
(3, NULL, 'litros', 'lt', 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `menu`
--

CREATE TABLE IF NOT EXISTS `menu` (
  `id_menu_pk` char(50) NOT NULL,
  `correlativo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` char(50) DEFAULT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `id_receta_pk` int(11) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_menu_pk`,`correlativo`),
  KEY `Ref187300` (`id_receta_pk`),
  KEY `Ref151308` (`id_precio`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Volcado de datos para la tabla `menu`
--

INSERT INTO `menu` (`id_menu_pk`, `correlativo`, `nombre`, `descripcion`, `id_receta_pk`, `id_precio`, `id_bien_pk`, `id_categoria_pk`) VALUES
('7', 1, 'pollo dorado', 'pollo dorado', 2, 2, NULL, NULL),
('7', 2, 'Licuado mixto', 'Delicioso mix de frutas y verduras organicas', 3, 3, NULL, NULL),
('7', 3, 'Version2licuado', 'hola', 3, 4, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimiento_inventario`
--

CREATE TABLE IF NOT EXISTS `movimiento_inventario` (
  `id_movimiento_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_mov` date DEFAULT NULL,
  `transaccion` char(40) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `no_doc` char(18) DEFAULT NULL,
  `serie_doc` char(18) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `tipo_doc` char(40) DEFAULT NULL,
  `empresa` char(20) DEFAULT NULL,
  PRIMARY KEY (`id_movimiento_pk`),
  KEY `Ref130183` (`serie_doc`,`no_doc`,`empresa`,`tipo_doc`),
  KEY `Ref5210` (`id_bodega_pk`),
  KEY `Ref1289` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Refencabezado_documento183` (`no_doc`,`serie_doc`,`tipo_doc`,`empresa`),
  KEY `Refbien289` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Volcado de datos para la tabla `movimiento_inventario`
--

INSERT INTO `movimiento_inventario` (`id_movimiento_pk`, `fecha_mov`, `transaccion`, `id_bodega_pk`, `id_bien_pk`, `id_categoria_pk`, `cantidad`, `no_doc`, `serie_doc`, `estado`, `tipo_doc`, `empresa`) VALUES
(14, '2016-11-05', 'Devolucion sobre compra', 1, 1, 'AF', 1, '3', '-', 'activo', 'Devolucion sobre compra', '-'),
(13, '2016-11-05', 'Compra', 1, 1, 'AF', 8, '6', '-', 'activo', 'Orden de compra', '1'),
(12, '2016-11-06', 'Venta', 2, 1, 'MP', 8, '2', 'A', 'activo', 'Factura', '1'),
(11, '2016-11-08', 'Compra', 2, 1, 'MP', 5, '5', '-', 'activo', 'Orden de compra', '1'),
(10, '2016-11-07', 'Compra', 2, 3, 'MP', 5, '5', '-', 'activo', 'Orden de compra', '1'),
(15, '2016-11-10', 'Compra', 2, 4, 'MP', 10, '7', '-', 'activo', 'Orden de compra', '1'),
(16, '2016-11-10', 'Devolucion sobre compra', 2, 4, 'MP', 5, '5', '-', 'activo', 'Devolucion sobre compra', '-'),
(17, '2016-11-10', 'Venta', 2, 1, 'MP', 3, '1', 'A', 'activo', 'Factura', '1'),
(18, '2016-11-10', 'Venta', 2, 2, 'MP', 5, '1', 'A', 'activo', 'Factura', '1'),
(19, '2016-11-10', 'Compra', 2, 6, 'MP', 1000, '8', '-', 'activo', 'Orden de compra', '1'),
(20, '2016-11-10', 'Compra', 2, 5, 'MP', 1000, '8', '-', 'activo', 'Orden de compra', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nomina`
--

CREATE TABLE IF NOT EXISTS `nomina` (
  `id_nomina_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_nomina` varchar(100) DEFAULT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `fecha_inicio_pago` date DEFAULT NULL,
  `fecha_de_corte` date DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_nomina_pk`),
  KEY `Ref17400` (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `nomina`
--

INSERT INTO `nomina` (`id_nomina_pk`, `nombre_nomina`, `estado`, `fecha_inicio_pago`, `fecha_de_corte`, `id_empresa_pk`) VALUES
(1, 'Nomina Septiembre', 'ACTIVO', '2016-09-01', '2016-10-01', 1),
(2, 'HOLA', 'ACTIVO', '2016-11-02', '2016-11-09', 2),
(3, 'Nomina Agosto', 'ACTIVO', '2016-08-01', '2016-08-31', 1),
(4, 'servidor', 'ACTIVO', '2016-11-09', '2016-11-23', 1);

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
  PRIMARY KEY (`id_obj_perdido_pk`),
  KEY `Ref17256` (`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `obtenerdetalle`
--
CREATE TABLE IF NOT EXISTS `obtenerdetalle` (
`nombre_proveedor` char(25)
,`id_proveedor_pk` int(11)
);
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `operacion`
--

CREATE TABLE IF NOT EXISTS `operacion` (
  `id_operacion` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `fecha_emision` date DEFAULT NULL,
  `id_deuda` int(11) DEFAULT NULL,
  `id_doc` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_operacion`),
  KEY `Ref148228` (`id_doc`),
  KEY `Ref150229` (`id_deuda`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `operacion`
--

INSERT INTO `operacion` (`id_operacion`, `cantidad`, `descripcion`, `fecha_emision`, `id_deuda`, `id_doc`, `estado`) VALUES
(1, 500, 'pago de ...', '0000-00-00', 1, 2, NULL),
(2, 500, 'pago 2....', '2016-11-11', 1, 2, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paquetes_eventos`
--

CREATE TABLE IF NOT EXISTS `paquetes_eventos` (
  `id_paquetes_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_evento_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_paquetes_salon_pk`),
  KEY `Ref2616` (`id_evento_pk`),
  KEY `Ref2517` (`id_promocion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paquetes_reservacion_habitacion`
--

CREATE TABLE IF NOT EXISTS `paquetes_reservacion_habitacion` (
  `id_paquetes_reservacion_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_reserhabit_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_paquetes_reservacion_habitacion_pk`),
  KEY `Ref2518` (`id_promocion_pk`),
  KEY `Ref3719` (`id_reserhabit_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paquete_inventario`
--

CREATE TABLE IF NOT EXISTS `paquete_inventario` (
  `id_paquete_inventario` int(11) NOT NULL AUTO_INCREMENT,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_paquete_inventario`),
  KEY `Ref2580` (`id_promocion_pk`),
  KEY `Ref181` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `parametros_fac`
--

CREATE TABLE IF NOT EXISTS `parametros_fac` (
  `id_parametros_pk` int(11) NOT NULL AUTO_INCREMENT,
  `empresa` int(11) DEFAULT NULL,
  `id_impuesto` int(11) NOT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_parametros_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `parametros_fac`
--

INSERT INTO `parametros_fac` (`id_parametros_pk`, `empresa`, `id_impuesto`, `estado`) VALUES
(1, 1, 1, NULL),
(2, 1, 2, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE IF NOT EXISTS `pedido` (
  `id_pedido_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_emp` int(11) NOT NULL,
  `id_vendedor` int(11) NOT NULL,
  `fecha_pedido` date DEFAULT NULL,
  `cliente` char(50) DEFAULT NULL,
  `usu_pedido` char(50) DEFAULT NULL,
  `estado_pedido` char(20) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_pedido_pk`),
  KEY `Ref15426` (`id_cliente_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`id_pedido_pk`, `id_emp`, `id_vendedor`, `fecha_pedido`, `cliente`, `usu_pedido`, `estado_pedido`, `id_cliente_pk`, `estado`) VALUES
(1, 1, 0, '2016-11-10', NULL, NULL, '', 2, 'Activo'),
(2, 1, 0, '2016-11-10', NULL, NULL, 'Activo', 2, 'Activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_compra`
--

CREATE TABLE IF NOT EXISTS `pedido_compra` (
  `id_pedido_compra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `encargado` char(25) DEFAULT NULL,
  `estado_pedido` char(20) DEFAULT NULL,
  `observaciones` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `id_requisicion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_pedido_compra_pk`),
  KEY `Ref124175` (`id_proveedor_pk`),
  KEY `Ref145218` (`id_requisicion_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Volcado de datos para la tabla `pedido_compra`
--

INSERT INTO `pedido_compra` (`id_pedido_compra_pk`, `fecha`, `encargado`, `estado_pedido`, `observaciones`, `estado`, `id_proveedor_pk`, `id_requisicion_pk`) VALUES
(1, '0004-12-16', 'Jose Castro', 'RECIBIDO', 'pedido a proveedor', 'ACTIVO', 1, 1),
(2, '0007-12-16', 'Mario Gonzales', 'ENVIADO', 'pedido a proveedor', 'ACTIVO', 2, 2),
(3, '0008-12-16', 'Juan Perez', 'ENVIADO', 'pedido a proveedor', 'ACTIVO', 3, 3),
(4, '0009-12-16', 'Maria Rames', 'ENVIADO', 'pedido a proveedor', 'ACTIVO', 4, 4),
(5, '2012-12-16', 'Vanessa Meltrozo', 'ENVIADO', 'pedido a proveedor', 'ACTIVO', 4, 5),
(6, '2017-12-16', 'Debora Carillo', 'ENVIADO', 'pedido a proveedor', 'ACTIVO', 2, 6),
(7, '2017-12-16', 'Debora Misti', 'ENVIADO', 'pedido a proveedor', 'ACTIVO', 2, 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_cotizacion`
--

CREATE TABLE IF NOT EXISTS `pedido_cotizacion` (
  `id_cotizacion_pk` int(11) NOT NULL,
  `id_pedido_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_cotizacion_pk`,`id_pedido_pk`),
  KEY `Ref248428` (`id_pedido_pk`),
  KEY `Ref92250` (`id_cotizacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_factura`
--

CREATE TABLE IF NOT EXISTS `pedido_factura` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  `id_pedido_pk` int(11) NOT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`,`id_pedido_pk`),
  KEY `Ref248427` (`id_pedido_pk`),
  KEY `Ref94252` (`id_empresa_pk`,`id_fac_empresa_pk`,`serie`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `percepcion`
--

CREATE TABLE IF NOT EXISTS `percepcion` (
  `id_percepcion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_percepcion` varchar(50) DEFAULT NULL,
  `estado` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id_percepcion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE IF NOT EXISTS `perfil` (
  `id_perfil` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_perfil` char(40) DEFAULT NULL,
  PRIMARY KEY (`id_perfil`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

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
  KEY `Ref266476` (`id_aplicacion`),
  KEY `Ref265477` (`id_perfil`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `planilla_igss`
--

CREATE TABLE IF NOT EXISTS `planilla_igss` (
  `id_planilla_igss_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado` char(10) DEFAULT NULL,
  `porcentaje_igss` decimal(10,2) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_planilla_igss_pk`),
  KEY `Ref17399` (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `planilla_igss`
--

INSERT INTO `planilla_igss` (`id_planilla_igss_pk`, `estado`, `porcentaje_igss`, `fecha`, `id_empresa_pk`) VALUES
(1, 'ACTIVO', '4.83', '2016-11-09', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `precio`
--

CREATE TABLE IF NOT EXISTS `precio` (
  `id_precio` int(11) NOT NULL AUTO_INCREMENT,
  `precio` decimal(10,2) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_tamaniop_pk` char(10) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_tprecio_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_precio`),
  KEY `Ref152459` (`id_tprecio_pk`),
  KEY `Ref1235` (`id_bien_pk`,`id_categoria_pk`),
  KEY `Ref182313` (`id_tamaniop_pk`),
  KEY `id_categoria_pk` (`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=19 ;

--
-- Volcado de datos para la tabla `precio`
--

INSERT INTO `precio` (`id_precio`, `precio`, `id_bien_pk`, `id_categoria_pk`, `id_tamaniop_pk`, `estado`, `id_tprecio_pk`) VALUES
(3, '60.90', 3, NULL, NULL, 'ACTIVO', 1),
(2, '24.15', 2, NULL, NULL, 'ACTIVO', 1),
(1, '24.15', 1, NULL, NULL, 'ACTIVO', 1),
(7, '27.60', 1, NULL, NULL, 'ACTIVO', 3),
(8, '27.60', 2, NULL, NULL, 'ACTIVO', 3),
(9, '69.60', 3, NULL, NULL, 'ACTIVO', 3);

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
  PRIMARY KEY (`id_problema_pk`),
  KEY `Ref17169` (`id_empresa_pk`),
  KEY `Ref15168` (`id_cliente_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proceso`
--

CREATE TABLE IF NOT EXISTS `proceso` (
  `id_proceso_pk` int(11) NOT NULL AUTO_INCREMENT,
  `observacion` char(100) DEFAULT NULL,
  `caracteristica_proceso` char(100) DEFAULT NULL,
  `nombre_proceso` char(20) DEFAULT NULL,
  `tiempo_proceso` char(50) DEFAULT NULL,
  `medida_tiempo` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_proceso_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `proceso`
--

INSERT INTO `proceso` (`id_proceso_pk`, `observacion`, `caracteristica_proceso`, `nombre_proceso`, `tiempo_proceso`, `medida_tiempo`) VALUES
(1, 'no sobre pase la cantidad de fruta', 'Agregar todas las frutas necesarias y cortarlas en tamaños convencionales para que la licuadora pued', 'Licuar', '0.05', 'Minutos'),
(2, 'cocer', 'cocer', 'cocer', '0.566666666666667', 'Minutos'),
(3, 'Cuidado con batir mas de la cuenta', 'Batir todos los ingredientes homogeneamente', 'Batir', '0.05', 'Minutos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `produccion`
--

CREATE TABLE IF NOT EXISTS `produccion` (
  `id_produccion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo_mano_de_obra` char(10) DEFAULT NULL,
  `costo_materia_prima` char(10) DEFAULT NULL,
  `costo_maquinaria` char(10) DEFAULT NULL,
  `hora_produccion` timestamp NULL DEFAULT NULL,
  `fecha_produccion` date DEFAULT NULL,
  `hrs_produccion` char(10) DEFAULT NULL,
  `costo_produccion` char(10) DEFAULT NULL,
  `fecha_caducidad` date DEFAULT NULL,
  `id_encabezado_pedido_pk` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_produccion_pk`),
  KEY `id_encabezado_pedido_pk` (`id_encabezado_pedido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

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
  `fecha_entrada` date DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_bodega_pk`,`id_categoria_pk`),
  KEY `Ref110` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Ref511` (`id_bodega_pk`),
  KEY `Refbien10` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `producto_bodega`
--

INSERT INTO `producto_bodega` (`id_bien_pk`, `id_bodega_pk`, `id_categoria_pk`, `existencia`, `existencia_congelada`, `existencia_auditada`, `fecha_entrada`, `estado`) VALUES
(1, 1, 'AF', -4, 4, 10, NULL, 'activo'),
(1, 1, 'PT', -8, NULL, NULL, NULL, 'activo'),
(1, 0, 'AF', -11, NULL, NULL, NULL, 'activo'),
(3, 2, 'MP', 5, NULL, NULL, NULL, 'activo'),
(3, 0, 'MP', 0, NULL, NULL, NULL, 'activo'),
(1, 2, 'MP', 2004, NULL, NULL, NULL, 'activo'),
(2, 2, 'MP', 2010, NULL, NULL, NULL, 'activo'),
(2, 0, 'MP', 0, NULL, NULL, NULL, 'activo'),
(1, 0, 'MP', -11, NULL, NULL, NULL, 'activo'),
(4, 0, 'MP', 0, NULL, NULL, NULL, 'activo'),
(4, 2, 'MP', 2005, NULL, NULL, NULL, 'activo'),
(5, 0, 'MP', 0, NULL, NULL, NULL, 'activo'),
(6, 0, 'MP', 0, NULL, NULL, NULL, 'activo'),
(6, 2, 'MP', 1000, NULL, NULL, NULL, 'activo'),
(5, 2, 'MP', 1000, NULL, NULL, NULL, 'activo'),
(2, 1, 'PT', 1, NULL, NULL, NULL, 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `promocion`
--

CREATE TABLE IF NOT EXISTS `promocion` (
  `id_promocion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_paquete` varchar(10) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `costo` int(11) NOT NULL,
  `detalle` varchar(100) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_salon_pk` int(11) DEFAULT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_promocion_pk`),
  KEY `Ref1195` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Ref19163` (`id_salon_pk`),
  KEY `Ref20165` (`id_habitacion_pk`),
  KEY `Refbien195` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `promocion`
--

INSERT INTO `promocion` (`id_promocion_pk`, `tipo_paquete`, `nombre`, `costo`, `detalle`, `estado`, `id_salon_pk`, `id_habitacion_pk`, `id_bien_pk`, `id_categoria_pk`) VALUES
(1, 'VIP', 'Promocion 1', 1000, 'Musica en vivo', 'ACTIVO', 1, 1, 1, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE IF NOT EXISTS `proveedor` (
  `id_proveedor_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_proveedor` char(25) DEFAULT NULL,
  `direccion` char(25) DEFAULT NULL,
  `telefono` char(15) DEFAULT NULL,
  `correo_electronico` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  PRIMARY KEY (`id_proveedor_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=116 ;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`id_proveedor_pk`, `nombre_proveedor`, `direccion`, `telefono`, `correo_electronico`, `estado`) VALUES
(1, 'El Mundo Del Producto', '33 Avenida 33 Zona 3', '4232-1114', 'El_M_Pto@hotmail.com', 'ACTIVO'),
(110, 'EL Bododegon', '2 Zona 3', '2233-5566', 'eBodegon@dgmail.com', 'ACTIVO'),
(2, 'Buen Precio', '3-0 Zona 4', '5544-8899', 'b_prcio@gmail.com', 'ACTIVO'),
(3, 'El Don Juan', '22-11 Zona 23', '3344-2211', 'el_d-Juan@gmail.com', 'ACTIVO'),
(4, 'San JuanVernardo', '2da Calle Fondo Zona 1', '4466-9022', 'd_J_vernardo@gmail.com', 'ACTIVO'),
(5, 'El Dorito', '22-1 Calle Zona 2', '4422-1122', 'el_Doto@hotmail.com', 'ACTIVO'),
(111, 'Hotel San Carlos', 'zona9', '34566876', 'raices@gmail.com', 'ACTIVO'),
(112, 'Distribuidora Mi', 'zona6', '32312176', 'distribuidorami@gmail.com', 'ACTIVO'),
(113, 'Importaciones SU', 'zona3', '34324876', 'importacionessu@gmail.com', 'ACTIVO'),
(114, 'Ferri 12', 'zona10', '12769876', 'Ferri12@gmail.com', 'ACTIVO'),
(115, 'El Bodegito', '44 Zona 4-22', '3355-3322', 'co_@gmail.com', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `receta`
--

CREATE TABLE IF NOT EXISTS `receta` (
  `id_receta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_receta` char(30) DEFAULT NULL,
  `horas_hombre` float(8,0) DEFAULT NULL,
  `costo_receta` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_receta_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `receta`
--

INSERT INTO `receta` (`id_receta_pk`, `nombre_receta`, `horas_hombre`, `costo_receta`) VALUES
(1, 'Licuado', 0, '31.00'),
(2, 'Salsa romana', 1, '23.00'),
(3, 'Licuado', 1, '58.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporteador`
--

CREATE TABLE IF NOT EXISTS `reporteador` (
  `id_reporteador` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` char(50) DEFAULT NULL,
  `ubicacion` char(200) DEFAULT NULL,
  PRIMARY KEY (`id_reporteador`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `requisicion`
--

CREATE TABLE IF NOT EXISTS `requisicion` (
  `id_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `encargado` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_bodega_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_requisicion_pk`),
  KEY `Ref5217` (`id_bodega_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Volcado de datos para la tabla `requisicion`
--

INSERT INTO `requisicion` (`id_requisicion_pk`, `fecha`, `encargado`, `estado`, `id_bodega_pk`) VALUES
(1, '2016-11-09', 'Julito Cruz', 'activo', 1),
(2, '2016-11-09', 'Marvin', 'activo', 2),
(3, '2016-11-09', 'Marvin', 'activo', 1),
(4, '2016-11-09', 'Pedro', 'activo', 2),
(5, '2016-11-10', 'Walter', 'activo', 1),
(6, '2016-11-10', 'walter', 'activo', 2),
(7, '2016-11-10', 'gorge', 'activo', 1),
(8, '2016-11-10', 'Jose', 'activo', 2),
(9, '2016-11-10', 'dgfsd', 'activo', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reservacion_habitacion`
--

CREATE TABLE IF NOT EXISTS `reservacion_habitacion` (
  `id_reserhabit_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  `fecha_entreda` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `estado` char(20) DEFAULT NULL,
  `fecha_reservacion` date NOT NULL,
  PRIMARY KEY (`id_reserhabit_pk`),
  KEY `Ref1546` (`id_cliente_pk`),
  KEY `Ref2047` (`id_habitacion_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Volcado de datos para la tabla `reservacion_habitacion`
--

INSERT INTO `reservacion_habitacion` (`id_reserhabit_pk`, `id_cliente_pk`, `id_habitacion_pk`, `fecha_entreda`, `fecha_salida`, `estado`, `fecha_reservacion`) VALUES
(8, 1, 5, '2016-11-08', '2016-11-08', 'OCUPADO', '2016-11-08'),
(7, 2, 5, '2016-11-08', '2016-11-08', 'INACTIVO', '2016-11-08');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `reservacion_tipo`
--
CREATE TABLE IF NOT EXISTS `reservacion_tipo` (
`nivel_tipo` char(100)
,`nombre` varchar(20)
,`fecha_entreda` date
);
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salon`
--

CREATE TABLE IF NOT EXISTS `salon` (
  `id_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `descripcion` varchar(20) NOT NULL,
  `dimiensiones` varchar(20) NOT NULL,
  `costo` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_salon_pk`),
  KEY `Ref17162` (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `salon`
--

INSERT INTO `salon` (`id_salon_pk`, `nombre`, `descripcion`, `dimiensiones`, `costo`, `estado`, `id_empresa_pk`) VALUES
(1, 'Grande', 'Aire libre', '300x500', 3500, 'ACTIVO', 1),
(2, 'Mediano', 'Salon ejecutivo', '500x400', 2000, 'ACTIVO', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tamanio_porcion`
--

CREATE TABLE IF NOT EXISTS `tamanio_porcion` (
  `id_tamaniop_pk` char(10) NOT NULL,
  `tamanio` char(10) DEFAULT NULL,
  `valor` varchar(10) NOT NULL,
  PRIMARY KEY (`id_tamaniop_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tamanio_porcion`
--

INSERT INTO `tamanio_porcion` (`id_tamaniop_pk`, `tamanio`, `valor`) VALUES
('1', '8gr', '8'),
('2', '16gr', '16');

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
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_credito`
--

CREATE TABLE IF NOT EXISTS `tipo_credito` (
  `id_tipocredito_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) DEFAULT NULL,
  `valor` decimal(10,2) NOT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_tipocredito_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `tipo_credito`
--

INSERT INTO `tipo_credito` (`id_tipocredito_pk`, `tipo`, `valor`, `estado`) VALUES
(1, 'A', '2500.00', 'ACTIVO'),
(2, 'B', '2000.00', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_documento`
--

CREATE TABLE IF NOT EXISTS `tipo_documento` (
  `id_tipo_documento` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_documento` char(50) DEFAULT NULL,
  `detalle` char(200) DEFAULT NULL,
  `estado` char(10) DEFAULT 'ACTIVO',
  PRIMARY KEY (`id_tipo_documento`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `tipo_documento`
--

INSERT INTO `tipo_documento` (`id_tipo_documento`, `nombre_documento`, `detalle`, `estado`) VALUES
(1, 'Deposito', 'documento para ingreso de dinero a hotel  san carlos', 'ACTIVO'),
(2, 'Cheque', 'Documento para ingreso y egreso de dinero a hotel san carlos', 'ACTIVO'),
(3, 'Nota de credito', 'Nota para ingresar acreditaciones en hotel san carlos', 'ACTIVO'),
(4, 'Nota de Debito', 'Nota para ingresar todos los debitos en las cuentas de hotel san carlos', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_doc_1`
--

CREATE TABLE IF NOT EXISTS `tipo_doc_1` (
  `id_tipo_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_tipo` varchar(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `tipo_doc_1`
--

INSERT INTO `tipo_doc_1` (`id_tipo_pk`, `nombre_tipo`, `estado`) VALUES
(1, 'Factura', 'ACTIVO'),
(2, 'Recibo', 'ACTIVO'),
(3, 'Nota de credito', 'ACTIVO'),
(4, 'Nota de debito', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_habitacion`
--

CREATE TABLE IF NOT EXISTS `tipo_habitacion` (
  `id_tipo_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nivel_tipo` char(100) DEFAULT NULL,
  `adulto_tipo` int(11) DEFAULT NULL,
  `ninio_tipo` int(11) DEFAULT NULL,
  `especificaciones_tipo` char(100) DEFAULT NULL,
  `costo_tipo` decimal(10,0) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `tipo_habitacion`
--

INSERT INTO `tipo_habitacion` (`id_tipo_pk`, `nivel_tipo`, `adulto_tipo`, `ninio_tipo`, `especificaciones_tipo`, `costo_tipo`, `estado`) VALUES
(1, 'SUITE', 2, 1, 'DOS CAMAS Y UN BAÑO', '139', 'ACTIVO'),
(2, 'PRESIDENCIAL', 2, 1, '4 CAMAS', '800', 'ACTIVO'),
(3, 'junior', 4, 2, '4 adultos dos ninos', '450', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_moneda`
--

CREATE TABLE IF NOT EXISTS `tipo_moneda` (
  `id_moneda` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(25) DEFAULT NULL,
  `tasa_cambio` decimal(10,2) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_moneda`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_precio`
--

CREATE TABLE IF NOT EXISTS `tipo_precio` (
  `id_tprecio_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  PRIMARY KEY (`id_tprecio_pk`),
  KEY `Ref151314` (`id_precio`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `tipo_precio`
--

INSERT INTO `tipo_precio` (`id_tprecio_pk`, `tipo`, `id_precio`, `estado`) VALUES
(1, 'Mayorista', NULL, 'ACTIVO'),
(2, 'Minorista', NULL, 'ACTIVO'),
(3, 'Consumidor', NULL, 'ACTIVO'),
(4, 'Distribuidor', NULL, 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `usuario` char(50) NOT NULL,
  `contrasenia` char(80) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `id_empleados_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`usuario`),
  KEY `Ref238480` (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`usuario`, `contrasenia`, `fecha_creacion`, `estado`, `id_empresa_pk`, `id_empleados_pk`) VALUES
('usuariodbs', 'aABvAGwAYQA=', NULL, NULL, 1, 1),
('rodrigo', 'MQAyADMA', '2016-11-07', 'ACTIVO', 1, 1),
('flofo', 'MQAyADMA', '2016-11-07', NULL, 1, 1),
('walter', 'dwBhAGwAdABlAHIA', '2016-11-07', NULL, 1, 1),
('ana', 'MQAyADMA', '2016-11-08', NULL, 1, 1),
('roberto', 'MQAyADMA', '2016-11-08', NULL, 1, 1),
('walter2', 'dwBhAGwAdABlAHIA', '2016-11-09', NULL, 1, 1),
('javier2', 'aABvAGwAYQA=', '2016-11-10', NULL, 1, 1),
('recursos_humanos', 'cAByAHUAZQBiAGEA', '2016-11-10', NULL, 1, 2);

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
  KEY `Ref265475` (`id_perfil`),
  KEY `Ref264478` (`usuario`),
  KEY `Ref266479` (`id_aplicacion`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario_privilegios`
--

INSERT INTO `usuario_privilegios` (`usuario`, `id_aplicacion`, `ins`, `sel`, `upd`, `del`, `id_perfil`) VALUES
('recursos_humanos', 13109, 1, 1, 1, 1, 0),
('recursos_humanos', 13106, 1, 1, 1, 1, 0),
('javier2', 13106, 0, 0, 0, 0, 0),
('javier2', 15104, 1, 0, 0, 0, 0),
('usuariodbs', 16101, 1, 1, 1, 1, 0),
('usuariodbs', 16201, 1, 1, 1, 1, 0);

-- --------------------------------------------------------

--
-- Estructura para la vista `cliente_efectivo`
--
DROP TABLE IF EXISTS `cliente_efectivo`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `cliente_efectivo` AS select `a`.`dpi` AS `dpi`,`b`.`id_cuenta_pagar_pk` AS `id_cuenta_pagar_pk`,`c`.`costo` AS `costo`,`c`.`nombre` AS `nombre`,`c`.`fecha` AS `fecha` from ((`cliente` `a` join `folio` `b`) join `detalle_folio` `c`) where ((`a`.`id_cliente_pk` = `b`.`id_cliente_pk`) and (`b`.`id_cuenta_pagar_pk` = `c`.`id_cuenta_pagar_pk`));

-- --------------------------------------------------------

--
-- Estructura para la vista `obtenerdetalle`
--
DROP TABLE IF EXISTS `obtenerdetalle`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `obtenerdetalle` AS select `proveedor`.`nombre_proveedor` AS `nombre_proveedor`,`detalle_cuenta_por_pagar`.`id_proveedor_pk` AS `id_proveedor_pk` from (`proveedor` join `detalle_cuenta_por_pagar` on((`proveedor`.`id_proveedor_pk` = `detalle_cuenta_por_pagar`.`id_proveedor_pk`))) group by `proveedor`.`id_proveedor_pk`;

-- --------------------------------------------------------

--
-- Estructura para la vista `reservacion_tipo`
--
DROP TABLE IF EXISTS `reservacion_tipo`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `reservacion_tipo` AS select `c`.`nivel_tipo` AS `nivel_tipo`,`b`.`nombre` AS `nombre`,`a`.`fecha_entreda` AS `fecha_entreda` from ((`reservacion_habitacion` `a` join `habitacion` `b`) join `tipo_habitacion` `c`) where ((`b`.`id_habitacion_pk` = `a`.`id_habitacion_pk`) and (`b`.`id_tipo_pk` = `c`.`id_tipo_pk`) and (`a`.`estado` = 'Reservado'));

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

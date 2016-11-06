-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-11-2016 a las 08:00:17
-- Versión del servidor: 10.1.13-MariaDB
-- Versión de PHP: 7.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `base4`
--

DELIMITER $$
--
-- Funciones
--
CREATE DEFINER=`root`@`localhost` FUNCTION `registraroperacion` (`iusuario` NVARCHAR(100), `iaccion` NVARCHAR(500), `idescrip` NVARCHAR(500), `itabla` NVARCHAR(50), `iip` NVARCHAR(20)) RETURNS INT(2) BEGIN
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,idescrip,iaccion,itabla,iip);
    return 1;
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `ValidarContrasena` (`iusuario` NVARCHAR(20), `icon` NVARCHAR(20), `iip` NVARCHAR(20)) RETURNS INT(2) IF EXISTS (select usuario from usuario where iusuario = usuario) THEN
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

CREATE TABLE `aplicacion` (
  `id_aplicacion` int(11) NOT NULL,
  `nombre_aplicacion` char(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignacion_mo`
--

CREATE TABLE `asignacion_mo` (
  `id_produccion_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `cant_horas` float(8,0) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bien`
--

CREATE TABLE `bien` (
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `precio` decimal(18,0) DEFAULT NULL,
  `costo` decimal(10,0) DEFAULT NULL,
  `descripcion` char(80) DEFAULT NULL,
  `clasificacion` char(20) DEFAULT NULL,
  `apartados` int(11) DEFAULT NULL,
  `metodologia` char(40) DEFAULT NULL,
  `id_medida_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_marca_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bien`
--

INSERT INTO `bien` (`id_bien_pk`, `id_categoria_pk`, `precio`, `costo`, `descripcion`, `clasificacion`, `apartados`, `metodologia`, `id_medida_pk`, `estado`, `id_marca_pk`) VALUES
(1, '1', '15', '15', 'ART1', '1', 1, '1', 1, '1', 1),
(2, '1', '64654', '15', 'art2', 'gfdgf', 112, 'dgfdg', 1, 'gfdg', 1),
(3, '1', '12', '15', 'Jabon', '1', 1, '1', 1, 'activo', 1),
(4, '', '5', '7', 'Mouse', '1', 1, '1', 1, 'activo', 1),
(5, '1', '10', '9', 'Teclado', '1', 1, '1', 1, 'activo', 1),
(6, '1', '100', '80', 'Globos', '1', 1, '1', 1, 'activo', 1),
(7, '1', '10', '9', 'Teclado', '1', 1, '1', 1, 'activo', 1),
(8, '1', '100', '80', 'Globos', '1', 1, '1', 1, 'activo', 1),
(9, '1', '25', '20', 'Marcadore', '1', 1, '1', 1, 'activo', 1),
(10, '1', '40', '35', 'Lapiz', '1', 1, '1', 1, 'activo', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bien_habitacion`
--

CREATE TABLE `bien_habitacion` (
  `id_bien_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `existencia` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `id_bit` int(10) NOT NULL,
  `hora` time DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  `accion` varchar(500) DEFAULT NULL,
  `tabla` varchar(50) DEFAULT NULL,
  `ip` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`id_bit`, `hora`, `fecha`, `usuario`, `descripcion`, `accion`, `tabla`, `ip`) VALUES
(1, '12:47:50', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '127.0.0.1'),
(2, '13:10:58', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.91.185'),
(3, '14:21:34', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.91.185'),
(4, '14:26:35', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.91.185'),
(5, '14:27:26', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.91.185'),
(6, '14:28:08', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.91.185'),
(7, '15:00:08', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '10.1.91.185'),
(8, '21:58:52', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.5'),
(9, '22:38:45', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.5'),
(10, '22:41:56', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.5'),
(11, '22:49:46', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.5'),
(12, '02:13:24', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.4'),
(13, '02:18:57', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.4'),
(14, '02:27:05', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.4'),
(15, '02:45:23', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.4'),
(16, '02:49:12', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.4'),
(17, '02:50:30', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.4'),
(18, '02:53:21', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.4'),
(19, '02:55:20', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.4'),
(20, '03:27:20', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(21, '03:33:49', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(22, '03:38:18', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(23, '03:40:17', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(24, '03:58:15', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(25, '03:59:07', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(26, '04:14:31', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(27, '04:42:46', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(28, '04:50:24', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(29, '04:51:57', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(30, '05:01:57', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.2'),
(31, '11:30:47', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '127.0.0.1'),
(32, '11:39:39', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '127.0.0.1'),
(33, '11:43:07', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '127.0.0.1'),
(34, '19:53:44', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(35, '20:49:28', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(36, '21:05:15', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(37, '21:06:16', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(38, '21:21:30', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(39, '21:22:57', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(40, '21:29:14', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(41, '21:34:38', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(42, '21:44:52', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(43, '21:45:51', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(44, '21:50:41', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(45, '21:56:00', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(46, '22:03:27', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(47, '22:07:32', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(48, '22:11:03', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(49, '22:14:30', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(50, '22:30:43', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(51, '22:32:24', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(52, '22:37:20', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(53, '22:38:30', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(54, '22:39:37', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(55, '22:54:38', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(56, '23:12:29', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(57, '23:14:22', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(58, '23:19:23', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(59, '23:24:13', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(60, '23:26:31', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(61, '23:30:20', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(62, '23:44:12', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(63, '23:47:33', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(64, '23:49:12', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(65, '23:53:20', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(66, '23:55:21', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(67, '23:58:53', '2016-11-04', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(68, '00:00:43', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(69, '00:01:49', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(70, '00:03:34', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(71, '00:06:54', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(72, '00:08:42', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(73, '00:13:52', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(74, '00:26:35', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(75, '00:29:04', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(76, '00:47:26', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(77, '00:52:50', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3'),
(78, '00:57:33', '2016-11-05', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.3');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodega`
--

CREATE TABLE `bodega` (
  `id_bodega_pk` int(11) NOT NULL,
  `ubicacion` char(40) DEFAULT NULL,
  `nombre_bodega` char(40) DEFAULT NULL,
  `tamaño` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `buzon`
--

CREATE TABLE `buzon` (
  `id_buzon_pk` int(11) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `fecha` date DEFAULT NULL,
  `descripcion` varchar(20) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE `categoria` (
  `id_categoria_pk` char(18) NOT NULL,
  `tipo_categoria` char(25) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente_pk` int(11) NOT NULL,
  `correo` varchar(50) DEFAULT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `dpi` int(11) DEFAULT NULL,
  `nit` varchar(10) NOT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `fecha_nacimiento` varchar(200) DEFAULT NULL,
  `id_tipocredito_pk` int(11) DEFAULT NULL,
  `id_contribuyente_pk` int(11) DEFAULT NULL,
  `id_empleado_pk` int(11) NOT NULL,
  `id_tprecio_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`id_cliente_pk`, `correo`, `nombre`, `apellido`, `dpi`, `nit`, `telefono`, `direccion`, `fecha_nacimiento`, `id_tipocredito_pk`, `id_contribuyente_pk`, `id_empleado_pk`, `id_tprecio_pk`, `estado`) VALUES
(1, 'gsdfgsdfg', 'Juan', 'Mendez Lopez', 24234234, '3434544', '3453453', '10 calle zona 1', '2016-10-19', 1, 1, 0, 1, '1'),
(2, 'sgfgf', 'Pedro', 'Galvez', 344534, '567675', '456456', 'Zona 9', '2016-10-18', 1, 1, 0, 1, '1'),
(3, 'pepin12', 'Andres ', 'Morales Polanco', NULL, '2345-677', NULL, '24 calle zona 1', NULL, NULL, NULL, 0, NULL, NULL),
(4, 'olivitin', 'olivia', 'vicente', 123456, '123', '111222', 'z7', 'jueves, 3 de noviembre de 2016', 5, 0, 0, 0, NULL),
(5, 'sisu', 'Sammy', 'Salazar', 32322, '83928', '89493', 'cd', 'sábado, 05 de noviembre de 2016', 5, 1, 2, 0, NULL),
(6, 's', 's', 's', 2, '2', '2', 's', 'sábado, 05 de noviembre de 2016', 5, 1, 2, 0, NULL),
(7, 'correo', 'Sirup', 'jfjf', 4343, '4894', '89402', 'cd', 'sábado, 05 de noviembre de 2016', 1, 1, 0, 2, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE `compra` (
  `id_factura_pk` int(11) NOT NULL,
  `id_orden_compra_pk` int(11) NOT NULL,
  `serie_factura` char(15) DEFAULT NULL,
  `fecha_recibida` date DEFAULT NULL,
  `encargado` char(20) DEFAULT NULL,
  `total` decimal(10,0) DEFAULT NULL,
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `id_forma_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `com_venta`
--

CREATE TABLE `com_venta` (
  `id_com_venta_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `total_venta` decimal(10,2) DEFAULT NULL,
  `porsentaje_comision` decimal(10,2) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `total_comision` date DEFAULT NULL,
  `id_devengos_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conciliaciones`
--

CREATE TABLE `conciliaciones` (
  `id_conciliacion_pk` int(11) NOT NULL,
  `id_documento_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `consultaalmacenada`
--

CREATE TABLE `consultaalmacenada` (
  `id_consulta_pk` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `tipo` varchar(10) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `fecha` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `consultaguardada`
--

CREATE TABLE `consultaguardada` (
  `id_consulta_pk` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `tipo` varchar(10) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `fecha` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contribuyente`
--

CREATE TABLE `contribuyente` (
  `id_contribuyente_pk` int(11) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `nit` varchar(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `contribuyente`
--

INSERT INTO `contribuyente` (`id_contribuyente_pk`, `nombre`, `nit`, `estado`) VALUES
(1, 'akame', '188', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `convertidora`
--

CREATE TABLE `convertidora` (
  `id` int(11) NOT NULL,
  `valor` float(8,0) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion`
--

CREATE TABLE `cotizacion` (
  `id_cotizacion` int(11) NOT NULL,
  `nombre_cte` varchar(50) DEFAULT NULL,
  `apellido_cte` varchar(50) DEFAULT NULL,
  `nit_cte` varchar(50) DEFAULT NULL,
  `telefono_cte` varchar(15) DEFAULT NULL,
  `direccion_cte` varchar(50) DEFAULT NULL,
  `fecha_cot` varchar(50) NOT NULL,
  `estado_cot` varchar(100) NOT NULL,
  `id_cliente_pk` int(11) NOT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion_bien`
--

CREATE TABLE `cotizacion_bien` (
  `id_precio` int(11) NOT NULL,
  `id_detallecot_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion_paquete`
--

CREATE TABLE `cotizacion_paquete` (
  `id_promocion_pk` int(11) NOT NULL,
  `id_detallecot_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_bancaria`
--

CREATE TABLE `cuenta_bancaria` (
  `id_cuenta_bancaria_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `nombre_banco` char(50) DEFAULT NULL,
  `no_cuenta` char(50) DEFAULT NULL,
  `saldo_libros` decimal(10,2) DEFAULT NULL,
  `saldo_bancarios` decimal(10,2) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_corriente_por_pagar`
--

CREATE TABLE `cuenta_corriente_por_pagar` (
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `deducciones`
--

CREATE TABLE `deducciones` (
  `id_presamo_pk` int(11) NOT NULL,
  `nombre` char(100) DEFAULT NULL,
  `detalle` char(250) DEFAULT NULL,
  `cantidad_deduccion` decimal(10,2) DEFAULT NULL,
  `cuotas` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_planilla_igss_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_compra`
--

CREATE TABLE `detalle_compra` (
  `id_factura_pk` int(11) NOT NULL,
  `id_detalle_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio_compra` decimal(15,0) DEFAULT NULL,
  `subtotal_compra` decimal(15,0) DEFAULT NULL,
  `id_orden_compra_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_com_ventas`
--

CREATE TABLE `detalle_com_ventas` (
  `id_detalle_com_ventas` int(11) NOT NULL,
  `id_com_venta_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `total_ventas` decimal(10,2) DEFAULT NULL,
  `comision` decimal(10,2) DEFAULT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_cotizacion`
--

CREATE TABLE `detalle_cotizacion` (
  `id_detallecot_pk` int(11) NOT NULL,
  `cantidad_detallecot` int(11) DEFAULT NULL,
  `desc_servicio_detcot` varchar(150) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_cotizacion_pk` int(11) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_cuenta_por_pagar`
--

CREATE TABLE `detalle_cuenta_por_pagar` (
  `detalle_cuenta_por_pagar_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `comprobante` int(11) DEFAULT NULL,
  `debe` decimal(15,0) DEFAULT NULL,
  `haber` decimal(15,0) DEFAULT NULL,
  `saldo` decimal(15,0) DEFAULT NULL,
  `id_cuenta_pk` int(11) DEFAULT NULL,
  `id_proveedor_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_disp_banc`
--

CREATE TABLE `detalle_disp_banc` (
  `id_detalle_db_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_disponibilidad_bancaria` int(11) NOT NULL,
  `id_documento_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_documento`
--

CREATE TABLE `detalle_documento` (
  `id_detalle_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `no_doc` int(11) DEFAULT NULL,
  `serie_doc` int(11) DEFAULT NULL,
  `id_tipo_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_documentos`
--

CREATE TABLE `detalle_documentos` (
  `id_detalle_cv_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `nombre_cuenta` char(100) DEFAULT NULL,
  `debe` decimal(10,2) DEFAULT NULL,
  `haber` decimal(10,2) DEFAULT NULL,
  `id_documento_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_folio`
--

CREATE TABLE `detalle_folio` (
  `id_detalle_folio_pk` int(11) NOT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `nombre` char(30) DEFAULT NULL,
  `id_folio_salon_pk` int(11) DEFAULT NULL,
  `id_folio_habitacion_pk` int(11) DEFAULT NULL,
  `id_folio_bien_pk` int(11) DEFAULT NULL,
  `id_folio_promocion_pk` int(11) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `fecha` char(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_folio`
--

INSERT INTO `detalle_folio` (`id_detalle_folio_pk`, `costo`, `nombre`, `id_folio_salon_pk`, `id_folio_habitacion_pk`, `id_folio_bien_pk`, `id_folio_promocion_pk`, `id_cuenta_pagar_pk`, `fecha`) VALUES
(38, '200.00', '1', NULL, 19, NULL, NULL, 2, '25/10/2016 06:48:17 p. m.'),
(52, '400.00', 'PRO1', NULL, NULL, NULL, 11, 2, '25/10/2016 07:38:28 p. m.'),
(54, '15.00', 'ART1', NULL, NULL, 20, NULL, 1, '25/10/2016 07:49:59 p. m.'),
(55, '15.00', 'ART1', NULL, NULL, 21, NULL, 2, '25/10/2016 07:50:04 p. m.'),
(48, '300.00', 'SAL1', 10, NULL, NULL, NULL, 2, '25/10/2016 07:04:24 p. m.'),
(49, '300.00', 'SAL1', 11, NULL, NULL, NULL, 2, '25/10/2016 07:05:34 p. m.'),
(43, '15.00', 'ART1', NULL, NULL, 17, NULL, 1, '25/10/2016 06:55:30 p. m.'),
(44, '400.00', 'PRO1', NULL, NULL, NULL, 8, 2, '25/10/2016 06:56:01 p. m.'),
(40, '300.00', 'SAL1', 8, NULL, NULL, NULL, 2, '25/10/2016 06:48:52 p. m.'),
(50, '15.00', 'art2', NULL, NULL, 18, NULL, 2, '25/10/2016 07:27:49 p. m.'),
(51, '200.00', '1', NULL, 22, NULL, NULL, 2, '25/10/2016 07:33:46 p. m.'),
(53, '15.00', 'ART1', NULL, NULL, 19, NULL, 1, '25/10/2016 07:49:55 p. m.'),
(47, '200.00', '1', NULL, 21, NULL, NULL, 2, '25/10/2016 07:03:53 p. m.'),
(39, '200.00', '1', NULL, 20, NULL, NULL, 2, '25/10/2016 06:48:22 p. m.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_muestreo`
--

CREATE TABLE `detalle_muestreo` (
  `id_encabezado` int(11) NOT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `existencia` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_nomina`
--

CREATE TABLE `detalle_nomina` (
  `id_dn` char(10) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `Sueldo_base` decimal(10,2) DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `id_nomina_pk` int(11) NOT NULL,
  `id_presamo_pk` int(11) NOT NULL,
  `id_devengos_pk` int(11) NOT NULL,
  `total_sueldo` decimal(10,2) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido`
--

CREATE TABLE `detalle_pedido` (
  `id_emp` int(11) NOT NULL,
  `id_detalle` int(11) NOT NULL,
  `id_pedido_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `descripcion` varchar(200) NOT NULL,
  `precio` decimal(10,0) NOT NULL,
  `subtotal` decimal(10,0) NOT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `estado_detalle` varchar(25) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_pedido`
--

INSERT INTO `detalle_pedido` (`id_emp`, `id_detalle`, `id_pedido_pk`, `id_bien_pk`, `cantidad`, `descripcion`, `precio`, `subtotal`, `id_categoria_pk`, `id_precio`, `estado`, `estado_detalle`) VALUES
(1, 1, 1, 1, 2, 'ART1', '15', '30', '1', 1, 'activo', 'activo'),
(1, 2, 1, 5, 5, 'Teclado', '10', '50', '1', 1, 'activo', 'activo'),
(1, 3, 1, 9, 1, 'Marcadore', '25', '25', '1', 1, 'activo', 'activo'),
(1, 4, 1, 8, 3, 'Globos', '100', '300', '1', 1, 'activo', 'activo'),
(1, 5, 2, 1, 3, 'ART1', '15', '45', '1', 1, 'activo', 'activo'),
(1, 6, 2, 5, 6, 'Teclado', '10', '60', '1', 1, 'activo', 'activo'),
(1, 7, 2, 9, 1, 'Marcadore', '25', '25', '1', 1, 'activo', 'activo'),
(1, 8, 2, 10, 3, 'Lapiz', '40', '120', '1', 1, '1', 'activo'),
(1, 9, 2, 4, 10, 'Mouse', '5', '50', '1', 1, 'activo', 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido_1`
--

CREATE TABLE `detalle_pedido_1` (
  `id_detalle_pedido_pk` int(11) NOT NULL,
  `id_encabezado_pedido_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_menu_pk` char(18) DEFAULT NULL,
  `correlativo` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido_compra`
--

CREATE TABLE `detalle_pedido_compra` (
  `id_detalle_pk` int(11) NOT NULL,
  `id_orden_compra_pk` int(11) NOT NULL,
  `id_detalle_requisicion_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_planilla_igss`
--

CREATE TABLE `detalle_planilla_igss` (
  `id_detalle_pigss` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_planilla_igss_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `sueldo_base` decimal(10,2) DEFAULT NULL,
  `igss_pagar` decimal(10,2) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_produccion`
--

CREATE TABLE `detalle_produccion` (
  `correlativo` int(11) NOT NULL,
  `id_produccion_pk` char(10) NOT NULL,
  `cantidad_mp` char(10) DEFAULT NULL,
  `id_detalle_pedido_pk` int(11) NOT NULL,
  `id_encabezado_pedido_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_receta_mp`
--

CREATE TABLE `detalle_receta_mp` (
  `correlativo` int(11) NOT NULL,
  `id_receta_pk` int(11) NOT NULL,
  `cantidad` float(8,0) DEFAULT NULL,
  `id_proceso_pk` int(11) DEFAULT NULL,
  `id_medida_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_requisicion`
--

CREATE TABLE `detalle_requisicion` (
  `id_detalle_requisicion_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `deuda`
--

CREATE TABLE `deuda` (
  `id_deuda` int(11) NOT NULL,
  `monto` decimal(10,2) DEFAULT NULL,
  `saldo_total` decimal(10,2) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_fac_empresa_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `id_empleados_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `deuda`
--

INSERT INTO `deuda` (`id_deuda`, `monto`, `saldo_total`, `id_cliente_pk`, `id_fac_empresa_pk`, `id_empresa_pk`, `serie`, `id_empleados_pk`, `estado`) VALUES
(1, '1000.00', '1000.00', 4, 31, 3, '31', NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devengos`
--

CREATE TABLE `devengos` (
  `id_devengos_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `nombre` char(100) DEFAULT NULL,
  `detalle` char(250) DEFAULT NULL,
  `cantidad_debengado` decimal(10,2) DEFAULT NULL,
  `cuotas` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion_detventa`
--

CREATE TABLE `devolucion_detventa` (
  `id_detalle_dec` int(11) NOT NULL,
  `id_dev` int(11) NOT NULL,
  `id_bien` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `precio` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion_venta`
--

CREATE TABLE `devolucion_venta` (
  `id_dev` int(11) NOT NULL,
  `id_empresa` int(11) NOT NULL,
  `id_fact_emp` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `fecha` varchar(30) NOT NULL,
  `motivo` varchar(200) NOT NULL,
  `total` decimal(10,0) NOT NULL,
  `estado` varchar(20) NOT NULL DEFAULT 'activo'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `disponibilidad_bancaria`
--

CREATE TABLE `disponibilidad_bancaria` (
  `id_disponibilidad_bancaria` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_cuenta_bancaria_pk` int(11) NOT NULL,
  `id_tipo_documento` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `documento`
--

CREATE TABLE `documento` (
  `id_documento_pk` int(11) NOT NULL,
  `conciliado` char(50) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `valor_total` decimal(10,2) DEFAULT NULL,
  `destinatario` char(100) DEFAULT NULL,
  `no_documento` char(100) DEFAULT NULL,
  `descripcion` char(250) DEFAULT NULL,
  `estado` char(50) DEFAULT NULL,
  `id_cuenta_bancaria_pk` int(11) NOT NULL,
  `id_tipo_documento` int(11) NOT NULL,
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `id_empleados_pk` int(11) NOT NULL,
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
  `estado` char(25) DEFAULT NULL,
  `foto_empleado` binary(200) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`id_empleados_pk`, `nombre`, `fecha_nacimiento`, `edad`, `dpi`, `nacionalidad`, `estado_civil`, `no_afiliacion_igss`, `fecha_ingreso`, `fecha_egreso`, `direccion`, `cargo`, `telefono`, `genero`, `sueldo`, `estado`, `foto_empleado`, `id_empresa_pk`) VALUES
(1, 'Jose Perez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'vendedor', NULL, NULL, NULL, NULL, NULL, 3),
(2, 'Ana Palacios', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'contadora', NULL, NULL, NULL, NULL, NULL, 3),
(3, 'Carmen Reyes', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'vendedor', NULL, NULL, NULL, NULL, NULL, 1),
(4, 'Maria Flores', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'vendedor', NULL, NULL, NULL, NULL, NULL, 3),
(5, 'Roberto Galvez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'vendedor', NULL, NULL, NULL, NULL, NULL, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE `empresa` (
  `id_empresa_pk` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `direccion` varchar(30) NOT NULL,
  `region` char(20) NOT NULL,
  `estrellas_hotel` varchar(15) NOT NULL,
  `nit` char(10) DEFAULT NULL,
  `correo` char(35) DEFAULT NULL,
  `telefono` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`id_empresa_pk`, `nombre`, `direccion`, `region`, `estrellas_hotel`, `nit`, `correo`, `telefono`, `estado`) VALUES
(1, 'Mariposa S.A', 'zona 1', 'Norte', '2', NULL, NULL, NULL, NULL),
(2, 'Ferreteria El clavit', 'zona 9', 'Central', '3', NULL, NULL, NULL, NULL),
(3, 'Hotel San Carlos', 'zona 10', 'central', '5', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_documento`
--

CREATE TABLE `encabezado_documento` (
  `no_doc` int(11) NOT NULL,
  `serie_doc` int(11) NOT NULL,
  `id_tipo_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `empresa` char(50) DEFAULT NULL,
  `estado_doc` char(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_muestreo`
--

CREATE TABLE `encabezado_muestreo` (
  `id_encabezado` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `responsable` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_pedido`
--

CREATE TABLE `encabezado_pedido` (
  `id_encabezado_pedido_pk` int(11) NOT NULL,
  `hora_ingreso` char(10) DEFAULT NULL,
  `id_cliente_pk` char(10) DEFAULT NULL,
  `fecha_ingreso` char(18) DEFAULT NULL,
  `fecha_entrega` char(18) DEFAULT NULL,
  `hora_entrega` timestamp NULL DEFAULT NULL,
  `id_empleados_pk` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `evento`
--

CREATE TABLE `evento` (
  `id_evento_pk` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `fecha_entrada` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `hora_entrada` time NOT NULL,
  `hora_salida` time NOT NULL,
  `costo` int(11) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_salon_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `fecha_vencimiento` varchar(100) DEFAULT NULL,
  `estado_factura` varchar(15) DEFAULT NULL,
  `fecha_emision` varchar(100) NOT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_impuesto_pk` int(11) DEFAULT NULL,
  `id_moneda` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT 'activo'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`id_fac_empresa_pk`, `id_empresa_pk`, `serie`, `id_empleados_pk`, `fecha_vencimiento`, `estado_factura`, `fecha_emision`, `subtotal`, `total`, `id_cliente_pk`, `id_impuesto_pk`, `id_moneda`, `estado`) VALUES
(10, 3, 'A', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 1, NULL, 'activo'),
(9, 1, 'B', 1, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 1, NULL, 'activo'),
(8, 3, 'A', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 1, NULL, 'activo'),
(7, 3, 'A', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 1, NULL, 'activo'),
(11, 1, 'A', 1, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 2, NULL, 'activo'),
(12, 3, 'A', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 1, NULL, 'activo'),
(13, 3, 'A', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 1, NULL, 'activo'),
(14, 3, 'A', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 1, NULL, 'activo'),
(15, 3, 'C', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 2, NULL, 'activo'),
(16, 1, 'A', 1, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 1, NULL, 'activo'),
(17, 3, 'A', 3, 'jueves, 27 de octubre de 2016', 'Deuda', 'jueves, 27 de octubre de 2016', '2530.00', '2530.00', 2, 1, NULL, 'activo'),
(18, 3, 'A', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '2530.00', '2530.00', 2, 1, NULL, 'activo'),
(19, 3, 'B', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 2, NULL, 'activo'),
(20, 1, 'B', 1, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '405.00', '405.00', 1, 1, NULL, 'activo'),
(21, 1, 'B', 1, 'jueves, 27 de octubre de 2016', 'Deuda', 'jueves, 27 de octubre de 2016', '405.00', '405.00', 1, 1, NULL, 'activo'),
(22, 1, 'B', 1, 'jueves, 27 de octubre de 2016', 'Deuda', 'jueves, 27 de octubre de 2016', '405.00', '405.00', 1, 1, NULL, 'activo'),
(23, 1, 'B', 1, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '2530.00', '2530.00', 2, 2, NULL, 'activo'),
(24, 3, 'C', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 2, NULL, 'activo'),
(25, 3, 'A', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 1, NULL, 'activo'),
(26, 3, 'B', 3, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '45.00', '45.00', 1, 1, NULL, 'activo'),
(27, 1, 'C', 1, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '405.00', '405.00', 1, 1, NULL, 'activo'),
(28, 1, 'A', 1, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '2530.00', '2530.00', 2, 1, NULL, 'activo'),
(29, 1, 'B', 1, 'jueves, 27 de octubre de 2016', 'Cancelado', 'jueves, 27 de octubre de 2016', '300.00', '300.00', 2, 1, NULL, 'activo'),
(30, 3, 'A', 3, 'viernes, 28 de octubre de 2016', 'Cancelado', 'viernes, 28 de octubre de 2016', '45.00', '45.00', 1, 2, NULL, 'activo'),
(31, 1, 'C', 1, 'viernes, 28 de octubre de 2016', 'Cancelado', 'viernes, 28 de octubre de 2016', '300.00', '300.00', 2, 1, NULL, 'activo'),
(32, 1, 'A', 1, 'sábado, 05 de noviembre de 2016', 'Deuda', 'sábado, 05 de noviembre de 2016', '94.86', '94.86', 2, 1, NULL, 'activo'),
(33, 1, 'B', 1, 'sábado, 05 de noviembre de 2016', 'Cancelado', 'sábado, 05 de noviembre de 2016', '32.40', '32.40', 7, 2, NULL, 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura documento`
--

CREATE TABLE `factura documento` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_documento_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_detalle`
--

CREATE TABLE `factura_detalle` (
  `id_detalle_fact` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `id_precio` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `precio` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura_detalle`
--

INSERT INTO `factura_detalle` (`id_detalle_fact`, `id_fac_empresa_pk`, `id_empresa_pk`, `serie`, `id_precio`, `cantidad`, `descripcion`, `precio`, `subtotal`, `estado`) VALUES
(13, 13, 3, 'A', 53, 1, 'ART1', 15, 15, NULL),
(12, 13, 3, 'A', 43, 1, 'ART1', 15, 15, NULL),
(11, 13, 3, 'A', 54, 1, 'ART1', 15, 15, NULL),
(14, 14, 3, 'A', 54, 1, 'ART1', 15, 15, NULL),
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
(101, 32, 1, 'A', 3, 5, 'Jabon', 15, 76, NULL),
(102, 32, 1, 'A', 5, 2, 'Teclado', 9, 18, NULL),
(103, 32, 1, 'A', 0, 0, '', 0, 0, NULL),
(104, 33, 1, 'B', 1, 2, 'ART1', 16, 32, NULL),
(105, 33, 1, 'B', 0, 0, '', 0, 0, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_pago`
--

CREATE TABLE `factura_pago` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_forma_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `id_empleados_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio`
--

CREATE TABLE `folio` (
  `id_cuenta_pagar_pk` int(11) NOT NULL,
  `estado` varchar(10) NOT NULL,
  `fecha_ingreso` date NOT NULL,
  `fecha_pago` varchar(100) DEFAULT NULL,
  `costo` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `folio`
--

INSERT INTO `folio` (`id_cuenta_pagar_pk`, `estado`, `fecha_ingreso`, `fecha_pago`, `costo`, `id_cliente_pk`) VALUES
(1, 'Cancelado', '2016-10-25', 'jueves, 27 de octubre de 2016', '45', 1),
(2, 'Pendiente', '2016-10-25', NULL, '2530', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_bien`
--

CREATE TABLE `folio_bien` (
  `id_folio_bien_pk` int(11) NOT NULL,
  `costo` decimal(10,2) NOT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `fecha` char(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `folio_bien`
--

INSERT INTO `folio_bien` (`id_folio_bien_pk`, `costo`, `id_cuenta_pagar_pk`, `id_bien_pk`, `id_categoria_pk`, `fecha`) VALUES
(21, '15.00', 2, 1, NULL, '25/10/2016 07:50:04 p. m.'),
(20, '15.00', 1, 1, NULL, '25/10/2016 07:49:59 p. m.'),
(19, '15.00', 1, 1, NULL, '25/10/2016 07:49:55 p. m.'),
(17, '15.00', 1, 1, NULL, '25/10/2016 06:55:30 p. m.'),
(18, '15.00', 2, 2, NULL, '25/10/2016 07:27:49 p. m.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_factura`
--

CREATE TABLE `folio_factura` (
  `id_cuenta_pagar_pk` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `estado` char(15) DEFAULT 'activo'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `folio_factura`
--

INSERT INTO `folio_factura` (`id_cuenta_pagar_pk`, `id_fac_empresa_pk`, `id_empresa_pk`, `serie`, `estado`) VALUES
(1, 15, 0, '', 'activo'),
(1, 24, 0, '', 'activo'),
(1, 25, 0, '', 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_habitacion`
--

CREATE TABLE `folio_habitacion` (
  `id_folio_habitacion_pk` int(11) NOT NULL,
  `costo` decimal(10,2) NOT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_reserhabit_pk` int(11) DEFAULT NULL,
  `fecha` char(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `folio_habitacion`
--

INSERT INTO `folio_habitacion` (`id_folio_habitacion_pk`, `costo`, `id_cuenta_pagar_pk`, `id_reserhabit_pk`, `fecha`) VALUES
(22, '200.00', 2, 1, '25/10/2016 07:33:46 p. m.'),
(21, '200.00', 2, 1, '25/10/2016 07:03:53 p. m.'),
(19, '200.00', 2, 1, '25/10/2016 06:48:17 p. m.'),
(20, '200.00', 2, 1, '25/10/2016 06:48:22 p. m.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_promocion`
--

CREATE TABLE `folio_promocion` (
  `id_folio_promocion_pk` int(11) NOT NULL,
  `costo` int(11) NOT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `fecha` char(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `folio_promocion`
--

INSERT INTO `folio_promocion` (`id_folio_promocion_pk`, `costo`, `id_cuenta_pagar_pk`, `id_promocion_pk`, `fecha`) VALUES
(11, 400, 2, 1, '25/10/2016 07:38:28 p. m.'),
(8, 400, 2, 1, '25/10/2016 06:56:01 p. m.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_salon`
--

CREATE TABLE `folio_salon` (
  `id_folio_salon_pk` int(11) NOT NULL,
  `costo` decimal(10,2) NOT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_salon_pk` int(11) DEFAULT NULL,
  `fecha` char(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `folio_salon`
--

INSERT INTO `folio_salon` (`id_folio_salon_pk`, `costo`, `id_cuenta_pagar_pk`, `id_salon_pk`, `fecha`) VALUES
(8, '300.00', 2, 1, '25/10/2016 06:48:52 p. m.'),
(10, '300.00', 2, 1, '25/10/2016 07:04:24 p. m.'),
(11, '300.00', 2, 1, '25/10/2016 07:05:34 p. m.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `forma_pago`
--

CREATE TABLE `forma_pago` (
  `id_forma_pk` int(11) NOT NULL,
  `tipo_pago` varchar(25) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `estado` char(15) DEFAULT 'activo'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `forma_pago`
--

INSERT INTO `forma_pago` (`id_forma_pk`, `tipo_pago`, `descripcion`, `estado`) VALUES
(1, 'Tarjeta de credito', 'Visa', 'activo'),
(2, 'Efectivo', 'Moneda actual', 'activo'),
(3, 'cheque', 'cheque de caja', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gastos_importacion`
--

CREATE TABLE `gastos_importacion` (
  `id_importacion_pk` int(11) NOT NULL,
  `transporte` char(25) DEFAULT NULL,
  `direccion_salida` char(25) DEFAULT NULL,
  `hora_fecha_salida` date DEFAULT NULL,
  `direccion_llegada` char(25) DEFAULT NULL,
  `hora_fecha_llegada` date DEFAULT NULL,
  `aduana` decimal(15,0) DEFAULT NULL,
  `otros_impuestos` decimal(15,0) DEFAULT NULL,
  `id_factura_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `habitacion`
--

CREATE TABLE `habitacion` (
  `id_habitacion_pk` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `nivel` int(11) DEFAULT NULL,
  `estrellas_habitacion` varchar(10) NOT NULL,
  `descripcion` varchar(10) DEFAULT NULL,
  `estado` char(10) NOT NULL,
  `id_tipo_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `habitacion`
--

INSERT INTO `habitacion` (`id_habitacion_pk`, `nombre`, `nivel`, `estrellas_habitacion`, `descripcion`, `estado`, `id_tipo_pk`, `id_empresa_pk`) VALUES
(1, 'HAB1', 1, '1', '1', '1', 1, 1),
(2, 'HAB2', 1, '1', 'jhgjh', 'jhg', 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `impuesto`
--

CREATE TABLE `impuesto` (
  `id_impuesto_pk` int(11) NOT NULL,
  `porcentaje` decimal(18,2) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `descripcion` varchar(200) NOT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `impuesto`
--

INSERT INTO `impuesto` (`id_impuesto_pk`, `porcentaje`, `nombre`, `descripcion`, `estado`) VALUES
(1, '12.00', 'iva', 'impuesto al valor agregado', NULL),
(2, '8.00', 'ist', 'IMPUESTO RENTA', NULL),
(3, '7.00', 'IRS', 'IMP RENTA', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `invitado`
--

CREATE TABLE `invitado` (
  `id_invitado_pk` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `dpi` varchar(20) DEFAULT NULL,
  `correo` varchar(30) DEFAULT NULL,
  `id_evento_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `id_marca_pk` int(11) NOT NULL,
  `nombre_marca` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medida`
--

CREATE TABLE `medida` (
  `id_medida_pk` int(11) NOT NULL,
  `valor` char(10) DEFAULT NULL,
  `nombre_medida` char(30) DEFAULT NULL,
  `abreviatura` char(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `menu`
--

CREATE TABLE `menu` (
  `id_menu_pk` char(18) NOT NULL,
  `correlativo` int(11) NOT NULL,
  `nombre` char(50) DEFAULT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `id_receta_pk` int(11) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimiento_inventario`
--

CREATE TABLE `movimiento_inventario` (
  `id_movimiento_pk` int(11) NOT NULL,
  `fecha_mov` date DEFAULT NULL,
  `clie_prov` int(11) DEFAULT NULL,
  `id_transaccion_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `no_doc` int(11) DEFAULT NULL,
  `serie_doc` int(11) DEFAULT NULL,
  `id_tipo_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nomina`
--

CREATE TABLE `nomina` (
  `id_nomina_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `obj_perdido`
--

CREATE TABLE `obj_perdido` (
  `id_obj_perdido_pk` int(11) NOT NULL,
  `nombre` char(30) NOT NULL,
  `descripcion` char(100) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `operacion`
--

CREATE TABLE `operacion` (
  `id_operacion` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `fecha_emision` date DEFAULT NULL,
  `id_deuda` int(11) DEFAULT NULL,
  `id_doc` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paquetes_eventos`
--

CREATE TABLE `paquetes_eventos` (
  `id_paquetes_salon_pk` int(11) NOT NULL,
  `id_evento_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paquetes_reservacion_habitacion`
--

CREATE TABLE `paquetes_reservacion_habitacion` (
  `id_paquetes_reservacion_habitacion_pk` int(11) NOT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_reserhabit_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paquete_inventario`
--

CREATE TABLE `paquete_inventario` (
  `id_paquete_inventario` int(11) NOT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `parametros_fac`
--

CREATE TABLE `parametros_fac` (
  `id_parametros_pk` int(11) NOT NULL,
  `nombre` varchar(15) DEFAULT NULL,
  `descripcion` varchar(200) NOT NULL,
  `estado` char(15) DEFAULT 'activo'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `parametros_fac`
--

INSERT INTO `parametros_fac` (`id_parametros_pk`, `nombre`, `descripcion`, `estado`) VALUES
(1, 'iva', 'se agrega a los precios', NULL),
(2, 'IRS', 'sobre los precios', 'activo'),
(3, 'precios', 'segun el estado del cliente', 'activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `id_pedido_pk` int(11) NOT NULL,
  `id_emp` int(11) NOT NULL,
  `fecha_pedido` date DEFAULT NULL,
  `estado_pedido` char(20) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_vendedor` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`id_pedido_pk`, `id_emp`, `fecha_pedido`, `estado_pedido`, `id_cliente_pk`, `estado`, `id_vendedor`) VALUES
(1, 1, '2016-10-18', 'act', 1, 'activo', 0),
(2, 1, '2016-10-18', 'act', 2, 'activo', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_compra`
--

CREATE TABLE `pedido_compra` (
  `id_orden_compra_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `encargado` char(25) DEFAULT NULL,
  `estado_pedido` char(20) DEFAULT NULL,
  `observaciones` char(50) DEFAULT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `id_requisicion_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_cotizacion`
--

CREATE TABLE `pedido_cotizacion` (
  `id_cotizacion_pk` int(11) NOT NULL,
  `id_pedido_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_factura`
--

CREATE TABLE `pedido_factura` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  `id_pedido_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE `perfil` (
  `id_perfil` int(11) NOT NULL,
  `nombre_perfil` char(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_privilegios`
--

CREATE TABLE `perfil_privilegios` (
  `id_aplicacion` int(11) NOT NULL,
  `id_perfil` int(11) NOT NULL,
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `planilla_igss`
--

CREATE TABLE `planilla_igss` (
  `id_planilla_igss_pk` int(11) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `porcentaje_igss` decimal(10,2) DEFAULT NULL,
  `sueldo` date DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `precio`
--

CREATE TABLE `precio` (
  `id_precio` int(11) NOT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_tamaniop_pk` char(10) DEFAULT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  `id_evento_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_salon_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_tprecio_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `precio`
--

INSERT INTO `precio` (`id_precio`, `precio`, `id_bien_pk`, `id_categoria_pk`, `id_tamaniop_pk`, `id_habitacion_pk`, `id_evento_pk`, `id_promocion_pk`, `id_salon_pk`, `estado`, `id_tprecio_pk`) VALUES
(80, '35.70', 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
(79, '20.40', 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
(78, '81.60', 8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
(77, '9.18', 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
(76, '81.60', 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
(75, '9.18', 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
(74, '7.14', 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
(73, '15.30', 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
(72, '15.30', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
(71, '15.30', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
(90, '37.80', 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(89, '21.60', 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(88, '86.40', 8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(87, '9.72', 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(86, '86.40', 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(85, '9.72', 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(84, '7.56', 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(83, '16.20', 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(82, '16.20', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(81, '16.20', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(91, '17.25', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3),
(92, '17.25', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3),
(93, '17.25', 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3),
(94, '8.05', 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3),
(95, '10.35', 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3),
(96, '92.00', 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3),
(97, '10.35', 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3),
(98, '92.00', 8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3),
(99, '23.00', 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3),
(100, '40.25', 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3),
(101, '16.50', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4),
(102, '16.50', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4),
(103, '16.50', 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4),
(104, '7.70', 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4),
(105, '9.90', 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4),
(106, '88.00', 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4),
(107, '9.90', 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4),
(108, '88.00', 8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4),
(109, '22.00', 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4),
(110, '38.50', 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `problema`
--

CREATE TABLE `problema` (
  `id_problema_pk` int(11) NOT NULL,
  `asunto` char(20) NOT NULL,
  `descripcion` char(100) NOT NULL,
  `fecha` date NOT NULL,
  `estado` char(20) NOT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proceso`
--

CREATE TABLE `proceso` (
  `id_proceso_pk` int(11) NOT NULL,
  `observacion` char(100) DEFAULT NULL,
  `caracteristica_proceso` char(100) DEFAULT NULL,
  `nombre_proceso` char(20) DEFAULT NULL,
  `tiempo_proceso` char(10) DEFAULT NULL,
  `medida_tiempo` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `produccion`
--

CREATE TABLE `produccion` (
  `id_produccion_pk` int(11) NOT NULL,
  `costo_mano_de_obra` char(10) DEFAULT NULL,
  `costo_materia_prima` char(10) DEFAULT NULL,
  `costo_maquinaria` char(10) DEFAULT NULL,
  `hora_produccion` timestamp NULL DEFAULT NULL,
  `fecha_produccion` date DEFAULT NULL,
  `hrs_produccion` char(10) DEFAULT NULL,
  `costo_produccion` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_bodega`
--

CREATE TABLE `producto_bodega` (
  `id_bien_pk` int(11) NOT NULL,
  `id_bodega_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `existencia` int(11) DEFAULT NULL,
  `existencia_congelada` int(11) DEFAULT NULL,
  `existencia_auditada` int(11) DEFAULT NULL,
  `fecha_entrada` date DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `promocion`
--

CREATE TABLE `promocion` (
  `id_promocion_pk` int(11) NOT NULL,
  `tipo_paquete` varchar(10) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `costo` decimal(10,2) NOT NULL,
  `detalle` varchar(100) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_salon_pk` int(11) DEFAULT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `promocion`
--

INSERT INTO `promocion` (`id_promocion_pk`, `tipo_paquete`, `nombre`, `costo`, `detalle`, `estado`, `id_salon_pk`, `id_habitacion_pk`, `id_bien_pk`, `id_categoria_pk`) VALUES
(1, 'ee', 'PRO1', '400.00', 'gfhjf', 'fd', 1, 1, 1, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `id_proveedor_pk` int(11) NOT NULL,
  `nombre_proveedor` char(25) DEFAULT NULL,
  `direccion` date DEFAULT NULL,
  `telefono` char(15) DEFAULT NULL,
  `correo_electronico` char(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `receta`
--

CREATE TABLE `receta` (
  `id_receta_pk` int(11) NOT NULL,
  `nombre_receta` char(30) DEFAULT NULL,
  `horas_hombre` float(8,0) DEFAULT NULL,
  `costo_receta` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporteador`
--

CREATE TABLE `reporteador` (
  `id_reporteador` int(11) NOT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  `ubicacion` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `requisicion`
--

CREATE TABLE `requisicion` (
  `id_requisicion_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `encargado` char(50) DEFAULT NULL,
  `id_detalle_requisicion_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reservacion_habitacion`
--

CREATE TABLE `reservacion_habitacion` (
  `id_reserhabit_pk` int(11) NOT NULL,
  `fecha_entreda` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `hora_entreda` time NOT NULL,
  `hora_salida` time NOT NULL,
  `id_cliente_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `reservacion_habitacion`
--

INSERT INTO `reservacion_habitacion` (`id_reserhabit_pk`, `fecha_entreda`, `fecha_salida`, `hora_entreda`, `hora_salida`, `id_cliente_pk`, `id_habitacion_pk`) VALUES
(1, '2016-10-04', '2016-10-19', '12:00:00', '12:00:00', 1, 1),
(2, '2016-10-04', '2016-10-12', '13:00:00', '13:00:00', 1, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salon`
--

CREATE TABLE `salon` (
  `id_salon_pk` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `descripcion` varchar(20) NOT NULL,
  `dimiencion` varchar(20) NOT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `salon`
--

INSERT INTO `salon` (`id_salon_pk`, `nombre`, `descripcion`, `dimiencion`, `costo`, `estado`, `id_empresa_pk`) VALUES
(1, 'SAL1', 'sdfsdf', '34', '300.00', '1', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tamanio_porcion`
--

CREATE TABLE `tamanio_porcion` (
  `id_tamaniop_pk` char(10) NOT NULL,
  `tamanio` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tiempo_vida`
--

CREATE TABLE `tiempo_vida` (
  `id_tiempo_vida_pk` char(10) NOT NULL,
  `fecha_prod` char(10) DEFAULT NULL,
  `tiempo_caducidad` char(10) DEFAULT NULL,
  `fecha_vencimiento` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo`
--

CREATE TABLE `tipo` (
  `id_tipo_pk` int(11) NOT NULL,
  `nivel_tipo` char(100) DEFAULT NULL,
  `adulto_tipo` int(11) DEFAULT NULL,
  `ninios_tipo` int(11) DEFAULT NULL,
  `especificaciones_tipo` char(100) DEFAULT NULL,
  `costo_tipo` decimal(10,0) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo`
--

INSERT INTO `tipo` (`id_tipo_pk`, `nivel_tipo`, `adulto_tipo`, `ninios_tipo`, `especificaciones_tipo`, `costo_tipo`, `estado`) VALUES
(1, '1', 1, 1, 'gdgfdgfdgfd', '200', '1'),
(2, '1', 1, 1, 'gdgfdgfdgfd', '250', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_credito`
--

CREATE TABLE `tipo_credito` (
  `id_tipocredito_pk` int(11) NOT NULL,
  `tipo` varchar(20) DEFAULT NULL,
  `valor` decimal(10,2) NOT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_credito`
--

INSERT INTO `tipo_credito` (`id_tipocredito_pk`, `tipo`, `valor`, `estado`) VALUES
(1, 'sdafasdf', '2000.00', 'sdfsd'),
(2, 'tipo2', '1000.00', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_doc`
--

CREATE TABLE `tipo_doc` (
  `id_tipo_pk` int(11) NOT NULL,
  `nombre_tipo` char(55) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_documento`
--

CREATE TABLE `tipo_documento` (
  `id_tipo_documento` int(11) NOT NULL,
  `nombre_documento` char(50) DEFAULT NULL,
  `detalle` char(200) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_doc_1`
--

CREATE TABLE `tipo_doc_1` (
  `id_doc` int(11) NOT NULL,
  `nom_doc` varchar(50) DEFAULT NULL,
  `desc_doc` varchar(100) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_moneda`
--

CREATE TABLE `tipo_moneda` (
  `id_moneda` int(11) NOT NULL,
  `tipo` varchar(25) DEFAULT NULL,
  `tasa_cambio` decimal(10,2) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_precio`
--

CREATE TABLE `tipo_precio` (
  `id_tprecio_pk` int(11) NOT NULL,
  `tipo` varchar(20) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_precio`
--

INSERT INTO `tipo_precio` (`id_tprecio_pk`, `tipo`, `id_precio`, `estado`) VALUES
(1, 'Mayorista', NULL, NULL),
(2, 'Distribuidor', NULL, NULL),
(3, 'Consumidor', NULL, NULL),
(4, 'Minorista', NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transaccion`
--

CREATE TABLE `transaccion` (
  `id_transaccion_pk` int(11) NOT NULL,
  `tipo_transaccion` char(40) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `usuario` char(50) NOT NULL,
  `contrasenia` char(80) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleados_pk` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`usuario`, `contrasenia`, `fecha_creacion`, `estado`, `id_empleados_pk`, `id_empresa_pk`) VALUES
('usuariodbs', 'aABvAGwAYQA=', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_privilegios`
--

CREATE TABLE `usuario_privilegios` (
  `usuario` char(50) NOT NULL,
  `id_aplicacion` int(11) NOT NULL,
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL,
  `id_perfil` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD PRIMARY KEY (`id_aplicacion`);

--
-- Indices de la tabla `asignacion_mo`
--
ALTER TABLE `asignacion_mo`
  ADD PRIMARY KEY (`id_produccion_pk`,`id_empleados_pk`),
  ADD KEY `Ref186306` (`id_produccion_pk`),
  ADD KEY `Ref238401` (`id_empleados_pk`);

--
-- Indices de la tabla `bien`
--
ALTER TABLE `bien`
  ADD PRIMARY KEY (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Ref98` (`id_categoria_pk`),
  ADD KEY `Ref189404` (`id_medida_pk`),
  ADD KEY `Ref14425` (`id_marca_pk`);

--
-- Indices de la tabla `bien_habitacion`
--
ALTER TABLE `bien_habitacion`
  ADD PRIMARY KEY (`id_bien_pk`,`id_habitacion_pk`,`id_categoria_pk`),
  ADD KEY `Ref112` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Ref2086` (`id_habitacion_pk`);

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`id_bit`);

--
-- Indices de la tabla `bodega`
--
ALTER TABLE `bodega`
  ADD PRIMARY KEY (`id_bodega_pk`);

--
-- Indices de la tabla `buzon`
--
ALTER TABLE `buzon`
  ADD PRIMARY KEY (`id_buzon_pk`),
  ADD KEY `Ref1520` (`id_cliente_pk`),
  ADD KEY `Ref17226` (`id_empresa_pk`);

--
-- Indices de la tabla `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id_categoria_pk`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente_pk`),
  ADD KEY `Ref152316` (`id_tprecio_pk`),
  ADD KEY `Ref153238` (`id_tipocredito_pk`),
  ADD KEY `Ref159255` (`id_contribuyente_pk`);

--
-- Indices de la tabla `compra`
--
ALTER TABLE `compra`
  ADD PRIMARY KEY (`id_factura_pk`),
  ADD KEY `Ref129174` (`id_orden_compra_pk`),
  ADD KEY `Ref123176` (`id_proveedor_pk`,`id_cuenta_pk`),
  ADD KEY `Ref99223` (`id_forma_pk`),
  ADD KEY `Refcuenta_corriente_por_pagar176` (`id_cuenta_pk`,`id_proveedor_pk`);

--
-- Indices de la tabla `com_venta`
--
ALTER TABLE `com_venta`
  ADD PRIMARY KEY (`id_com_venta_pk`),
  ADD KEY `Ref242387` (`id_devengos_pk`);

--
-- Indices de la tabla `conciliaciones`
--
ALTER TABLE `conciliaciones`
  ADD PRIMARY KEY (`id_conciliacion_pk`,`id_documento_pk`),
  ADD KEY `Ref234373` (`id_documento_pk`);

--
-- Indices de la tabla `consultaalmacenada`
--
ALTER TABLE `consultaalmacenada`
  ADD PRIMARY KEY (`id_consulta_pk`);

--
-- Indices de la tabla `consultaguardada`
--
ALTER TABLE `consultaguardada`
  ADD PRIMARY KEY (`id_consulta_pk`);

--
-- Indices de la tabla `contribuyente`
--
ALTER TABLE `contribuyente`
  ADD PRIMARY KEY (`id_contribuyente_pk`);

--
-- Indices de la tabla `convertidora`
--
ALTER TABLE `convertidora`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
  ADD PRIMARY KEY (`id_cotizacion`),
  ADD KEY `Ref15181` (`id_cliente_pk`);

--
-- Indices de la tabla `cotizacion_bien`
--
ALTER TABLE `cotizacion_bien`
  ADD PRIMARY KEY (`id_precio`,`id_detallecot_pk`),
  ADD KEY `Ref151407` (`id_precio`),
  ADD KEY `Ref93417` (`id_detallecot_pk`);

--
-- Indices de la tabla `cotizacion_paquete`
--
ALTER TABLE `cotizacion_paquete`
  ADD PRIMARY KEY (`id_promocion_pk`,`id_detallecot_pk`),
  ADD KEY `Ref93416` (`id_detallecot_pk`),
  ADD KEY `Ref25124` (`id_promocion_pk`);

--
-- Indices de la tabla `cuenta_bancaria`
--
ALTER TABLE `cuenta_bancaria`
  ADD PRIMARY KEY (`id_cuenta_bancaria_pk`),
  ADD KEY `Ref17381` (`id_empresa_pk`);

--
-- Indices de la tabla `cuenta_corriente_por_pagar`
--
ALTER TABLE `cuenta_corriente_por_pagar`
  ADD PRIMARY KEY (`id_cuenta_pk`,`id_proveedor_pk`),
  ADD KEY `Ref124170` (`id_proveedor_pk`);

--
-- Indices de la tabla `deducciones`
--
ALTER TABLE `deducciones`
  ADD PRIMARY KEY (`id_presamo_pk`),
  ADD KEY `Ref237391` (`id_planilla_igss_pk`),
  ADD KEY `Ref238392` (`id_empleados_pk`);

--
-- Indices de la tabla `detalle_compra`
--
ALTER TABLE `detalle_compra`
  ADD PRIMARY KEY (`id_factura_pk`),
  ADD KEY `Ref128292` (`id_orden_compra_pk`,`id_detalle_pk`),
  ADD KEY `Ref125171` (`id_factura_pk`),
  ADD KEY `Refdetalle_pedido_compra292` (`id_detalle_pk`,`id_orden_compra_pk`);

--
-- Indices de la tabla `detalle_com_ventas`
--
ALTER TABLE `detalle_com_ventas`
  ADD PRIMARY KEY (`id_detalle_com_ventas`,`id_com_venta_pk`,`id_empleados_pk`),
  ADD KEY `Ref241395` (`id_com_venta_pk`),
  ADD KEY `Ref238396` (`id_empleados_pk`),
  ADD KEY `Ref94414` (`id_empresa_pk`,`id_fac_empresa_pk`,`serie`,`id_empleados_pk`),
  ADD KEY `Reffactura414` (`id_empleados_pk`,`id_fac_empresa_pk`,`id_empresa_pk`,`serie`);

--
-- Indices de la tabla `detalle_cotizacion`
--
ALTER TABLE `detalle_cotizacion`
  ADD PRIMARY KEY (`id_detallecot_pk`),
  ADD KEY `Ref154408` (`id_detallecot_pk`,`id_precio`),
  ADD KEY `Ref100409` (`id_promocion_pk`,`id_detallecot_pk`),
  ADD KEY `Ref92415` (`id_cotizacion_pk`),
  ADD KEY `Refcotizacion_paquete409` (`id_detallecot_pk`,`id_promocion_pk`);

--
-- Indices de la tabla `detalle_cuenta_por_pagar`
--
ALTER TABLE `detalle_cuenta_por_pagar`
  ADD PRIMARY KEY (`detalle_cuenta_por_pagar_pk`),
  ADD KEY `Ref123293` (`id_cuenta_pk`,`id_proveedor_pk`);

--
-- Indices de la tabla `detalle_disp_banc`
--
ALTER TABLE `detalle_disp_banc`
  ADD PRIMARY KEY (`id_detalle_db_pk`),
  ADD KEY `Ref230379` (`id_disponibilidad_bancaria`),
  ADD KEY `Ref234380` (`id_documento_pk`);

--
-- Indices de la tabla `detalle_documento`
--
ALTER TABLE `detalle_documento`
  ADD PRIMARY KEY (`id_detalle_pk`),
  ADD KEY `Ref1185` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Ref130187` (`id_tipo_pk`,`no_doc`,`serie_doc`),
  ADD KEY `Refbien185` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Refencabezado_documento187` (`no_doc`,`serie_doc`,`id_tipo_pk`);

--
-- Indices de la tabla `detalle_documentos`
--
ALTER TABLE `detalle_documentos`
  ADD PRIMARY KEY (`id_detalle_cv_pk`),
  ADD KEY `Ref234374` (`id_documento_pk`);

--
-- Indices de la tabla `detalle_folio`
--
ALTER TABLE `detalle_folio`
  ADD PRIMARY KEY (`id_detalle_folio_pk`),
  ADD KEY `Ref162431` (`id_folio_salon_pk`),
  ADD KEY `Ref161432` (`id_folio_habitacion_pk`),
  ADD KEY `Ref163433` (`id_folio_bien_pk`),
  ADD KEY `Ref164434` (`id_folio_promocion_pk`),
  ADD KEY `Ref33435` (`id_cuenta_pagar_pk`);

--
-- Indices de la tabla `detalle_muestreo`
--
ALTER TABLE `detalle_muestreo`
  ADD PRIMARY KEY (`id_encabezado`),
  ADD KEY `Ref10290` (`id_bodega_pk`,`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Ref143215` (`id_encabezado`),
  ADD KEY `Refproducto_bodega290` (`id_bien_pk`,`id_bodega_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_nomina`
--
ALTER TABLE `detalle_nomina`
  ADD PRIMARY KEY (`id_dn`),
  ADD KEY `Ref238388` (`id_empleados_pk`),
  ADD KEY `Ref240389` (`id_nomina_pk`),
  ADD KEY `Ref239390` (`id_presamo_pk`),
  ADD KEY `Ref242397` (`id_devengos_pk`);

--
-- Indices de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  ADD PRIMARY KEY (`id_detalle`,`id_bien_pk`),
  ADD KEY `Ref151403` (`id_precio`),
  ADD KEY `Ref248429` (`id_pedido_pk`),
  ADD KEY `Ref1244` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Refbien244` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_pedido_1`
--
ALTER TABLE `detalle_pedido_1`
  ADD PRIMARY KEY (`id_detalle_pedido_pk`,`id_encabezado_pedido_pk`),
  ADD KEY `Ref194296` (`id_menu_pk`,`correlativo`),
  ADD KEY `Ref190297` (`id_encabezado_pedido_pk`);

--
-- Indices de la tabla `detalle_pedido_compra`
--
ALTER TABLE `detalle_pedido_compra`
  ADD PRIMARY KEY (`id_detalle_pk`,`id_orden_compra_pk`),
  ADD KEY `Ref146291` (`id_detalle_requisicion_pk`),
  ADD KEY `Ref129173` (`id_orden_compra_pk`);

--
-- Indices de la tabla `detalle_planilla_igss`
--
ALTER TABLE `detalle_planilla_igss`
  ADD PRIMARY KEY (`id_detalle_pigss`),
  ADD KEY `Ref237393` (`id_planilla_igss_pk`),
  ADD KEY `Ref238394` (`id_empleados_pk`);

--
-- Indices de la tabla `detalle_produccion`
--
ALTER TABLE `detalle_produccion`
  ADD PRIMARY KEY (`correlativo`,`id_produccion_pk`),
  ADD KEY `Ref191299` (`id_encabezado_pedido_pk`,`id_detalle_pedido_pk`),
  ADD KEY `Ref1310` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Refdetalle_pedido_1299` (`id_detalle_pedido_pk`,`id_encabezado_pedido_pk`),
  ADD KEY `Refbien310` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_receta_mp`
--
ALTER TABLE `detalle_receta_mp`
  ADD PRIMARY KEY (`correlativo`,`id_receta_pk`),
  ADD KEY `Ref192301` (`id_proceso_pk`),
  ADD KEY `Ref189302` (`id_medida_pk`),
  ADD KEY `Ref187304` (`id_receta_pk`),
  ADD KEY `Ref1311` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_requisicion`
--
ALTER TABLE `detalle_requisicion`
  ADD PRIMARY KEY (`id_detalle_requisicion_pk`),
  ADD KEY `Ref1220` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `deuda`
--
ALTER TABLE `deuda`
  ADD PRIMARY KEY (`id_deuda`),
  ADD KEY `Ref15230` (`id_cliente_pk`),
  ADD KEY `Ref94231` (`id_fac_empresa_pk`,`id_empresa_pk`,`id_empleados_pk`,`serie`),
  ADD KEY `Ref17232` (`id_empresa_pk`),
  ADD KEY `Reffactura231` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`,`id_empleados_pk`);

--
-- Indices de la tabla `devengos`
--
ALTER TABLE `devengos`
  ADD PRIMARY KEY (`id_devengos_pk`),
  ADD KEY `Ref238386` (`id_empleados_pk`);

--
-- Indices de la tabla `devolucion_venta`
--
ALTER TABLE `devolucion_venta`
  ADD PRIMARY KEY (`id_dev`);

--
-- Indices de la tabla `disponibilidad_bancaria`
--
ALTER TABLE `disponibilidad_bancaria`
  ADD PRIMARY KEY (`id_disponibilidad_bancaria`),
  ADD KEY `Ref232377` (`id_cuenta_bancaria_pk`),
  ADD KEY `Ref229378` (`id_tipo_documento`);

--
-- Indices de la tabla `documento`
--
ALTER TABLE `documento`
  ADD PRIMARY KEY (`id_documento_pk`),
  ADD KEY `Ref232375` (`id_cuenta_bancaria_pk`),
  ADD KEY `Ref229376` (`id_tipo_documento`),
  ADD KEY `Ref123385` (`id_proveedor_pk`,`id_cuenta_pk`),
  ADD KEY `Refcuenta_corriente_por_pagar385` (`id_cuenta_pk`,`id_proveedor_pk`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`id_empleados_pk`),
  ADD KEY `Ref17398` (`id_empresa_pk`);

--
-- Indices de la tabla `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`id_empresa_pk`);

--
-- Indices de la tabla `encabezado_documento`
--
ALTER TABLE `encabezado_documento`
  ADD PRIMARY KEY (`no_doc`,`serie_doc`,`id_tipo_pk`),
  ADD KEY `Ref142212` (`id_tipo_pk`);

--
-- Indices de la tabla `encabezado_muestreo`
--
ALTER TABLE `encabezado_muestreo`
  ADD PRIMARY KEY (`id_encabezado`);

--
-- Indices de la tabla `encabezado_pedido`
--
ALTER TABLE `encabezado_pedido`
  ADD PRIMARY KEY (`id_encabezado_pedido_pk`);

--
-- Indices de la tabla `evento`
--
ALTER TABLE `evento`
  ADD PRIMARY KEY (`id_evento_pk`),
  ADD KEY `Ref1552` (`id_cliente_pk`),
  ADD KEY `Ref1953` (`id_salon_pk`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`,`id_empleados_pk`),
  ADD KEY `Ref246405` (`id_moneda`),
  ADD KEY `Ref238412` (`id_empleados_pk`),
  ADD KEY `Ref15126` (`id_cliente_pk`),
  ADD KEY `Ref17241` (`id_empresa_pk`),
  ADD KEY `Ref155246` (`id_impuesto_pk`);

--
-- Indices de la tabla `factura documento`
--
ALTER TABLE `factura documento`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`id_documento_pk`,`serie`,`id_empleados_pk`),
  ADD KEY `Ref94383` (`id_fac_empresa_pk`,`id_empresa_pk`,`id_empleados_pk`,`serie`),
  ADD KEY `Ref234384` (`id_documento_pk`),
  ADD KEY `Reffactura383` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`,`id_empleados_pk`);

--
-- Indices de la tabla `factura_detalle`
--
ALTER TABLE `factura_detalle`
  ADD PRIMARY KEY (`id_detalle_fact`),
  ADD KEY `Ref94247` (`serie`),
  ADD KEY `Reffactura247` (`serie`);

--
-- Indices de la tabla `factura_pago`
--
ALTER TABLE `factura_pago`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_forma_pk`),
  ADD KEY `Ref94127` (`id_empresa_pk`,`id_fac_empresa_pk`,`serie`,`id_empleados_pk`),
  ADD KEY `Ref99128` (`id_forma_pk`),
  ADD KEY `Reffactura127` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`,`id_empleados_pk`);

--
-- Indices de la tabla `folio`
--
ALTER TABLE `folio`
  ADD PRIMARY KEY (`id_cuenta_pagar_pk`),
  ADD KEY `Ref15167` (`id_cliente_pk`);

--
-- Indices de la tabla `folio_bien`
--
ALTER TABLE `folio_bien`
  ADD PRIMARY KEY (`id_folio_bien_pk`),
  ADD KEY `Ref33261` (`id_cuenta_pagar_pk`),
  ADD KEY `Ref1262` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Refbien262` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `folio_factura`
--
ALTER TABLE `folio_factura`
  ADD PRIMARY KEY (`id_cuenta_pagar_pk`,`id_fac_empresa_pk`,`id_empresa_pk`),
  ADD KEY `Ref33253` (`id_cuenta_pagar_pk`),
  ADD KEY `Ref94254` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Reffactura254` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`);

--
-- Indices de la tabla `folio_habitacion`
--
ALTER TABLE `folio_habitacion`
  ADD PRIMARY KEY (`id_folio_habitacion_pk`),
  ADD KEY `Ref37424` (`id_reserhabit_pk`),
  ADD KEY `Ref33257` (`id_cuenta_pagar_pk`);

--
-- Indices de la tabla `folio_promocion`
--
ALTER TABLE `folio_promocion`
  ADD PRIMARY KEY (`id_folio_promocion_pk`),
  ADD KEY `Ref33263` (`id_cuenta_pagar_pk`),
  ADD KEY `Ref25264` (`id_promocion_pk`);

--
-- Indices de la tabla `folio_salon`
--
ALTER TABLE `folio_salon`
  ADD PRIMARY KEY (`id_folio_salon_pk`),
  ADD KEY `Ref33259` (`id_cuenta_pagar_pk`),
  ADD KEY `Ref19260` (`id_salon_pk`);

--
-- Indices de la tabla `forma_pago`
--
ALTER TABLE `forma_pago`
  ADD PRIMARY KEY (`id_forma_pk`);

--
-- Indices de la tabla `gastos_importacion`
--
ALTER TABLE `gastos_importacion`
  ADD PRIMARY KEY (`id_importacion_pk`),
  ADD KEY `Ref125172` (`id_factura_pk`);

--
-- Indices de la tabla `habitacion`
--
ALTER TABLE `habitacion`
  ADD PRIMARY KEY (`id_habitacion_pk`),
  ADD KEY `Ref3444` (`id_tipo_pk`),
  ADD KEY `Ref17161` (`id_empresa_pk`);

--
-- Indices de la tabla `impuesto`
--
ALTER TABLE `impuesto`
  ADD PRIMARY KEY (`id_impuesto_pk`);

--
-- Indices de la tabla `invitado`
--
ALTER TABLE `invitado`
  ADD PRIMARY KEY (`id_invitado_pk`),
  ADD KEY `Ref2621` (`id_evento_pk`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id_marca_pk`);

--
-- Indices de la tabla `medida`
--
ALTER TABLE `medida`
  ADD PRIMARY KEY (`id_medida_pk`);

--
-- Indices de la tabla `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id_menu_pk`,`correlativo`),
  ADD KEY `Ref187300` (`id_receta_pk`),
  ADD KEY `Ref151308` (`id_precio`);

--
-- Indices de la tabla `movimiento_inventario`
--
ALTER TABLE `movimiento_inventario`
  ADD PRIMARY KEY (`id_movimiento_pk`),
  ADD KEY `Ref1289` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Ref130183` (`id_tipo_pk`,`no_doc`,`serie_doc`),
  ADD KEY `Ref132208` (`id_transaccion_pk`),
  ADD KEY `Ref5210` (`id_bodega_pk`),
  ADD KEY `Refencabezado_documento183` (`no_doc`,`serie_doc`,`id_tipo_pk`);

--
-- Indices de la tabla `nomina`
--
ALTER TABLE `nomina`
  ADD PRIMARY KEY (`id_nomina_pk`),
  ADD KEY `Ref17400` (`id_empresa_pk`);

--
-- Indices de la tabla `obj_perdido`
--
ALTER TABLE `obj_perdido`
  ADD PRIMARY KEY (`id_obj_perdido_pk`),
  ADD KEY `Ref17256` (`id_empresa_pk`);

--
-- Indices de la tabla `operacion`
--
ALTER TABLE `operacion`
  ADD PRIMARY KEY (`id_operacion`),
  ADD KEY `Ref148228` (`id_doc`),
  ADD KEY `Ref150229` (`id_deuda`);

--
-- Indices de la tabla `paquetes_eventos`
--
ALTER TABLE `paquetes_eventos`
  ADD PRIMARY KEY (`id_paquetes_salon_pk`),
  ADD KEY `Ref2616` (`id_evento_pk`),
  ADD KEY `Ref2517` (`id_promocion_pk`);

--
-- Indices de la tabla `paquetes_reservacion_habitacion`
--
ALTER TABLE `paquetes_reservacion_habitacion`
  ADD PRIMARY KEY (`id_paquetes_reservacion_habitacion_pk`),
  ADD KEY `Ref2518` (`id_promocion_pk`),
  ADD KEY `Ref3719` (`id_reserhabit_pk`);

--
-- Indices de la tabla `paquete_inventario`
--
ALTER TABLE `paquete_inventario`
  ADD PRIMARY KEY (`id_paquete_inventario`),
  ADD KEY `Ref2580` (`id_promocion_pk`),
  ADD KEY `Ref181` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Refbien81` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `parametros_fac`
--
ALTER TABLE `parametros_fac`
  ADD PRIMARY KEY (`id_parametros_pk`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`id_pedido_pk`),
  ADD KEY `Ref15426` (`id_cliente_pk`);

--
-- Indices de la tabla `pedido_compra`
--
ALTER TABLE `pedido_compra`
  ADD PRIMARY KEY (`id_orden_compra_pk`),
  ADD KEY `Ref124175` (`id_proveedor_pk`),
  ADD KEY `Ref145218` (`id_requisicion_pk`);

--
-- Indices de la tabla `pedido_cotizacion`
--
ALTER TABLE `pedido_cotizacion`
  ADD PRIMARY KEY (`id_cotizacion_pk`,`id_pedido_pk`),
  ADD KEY `Ref248428` (`id_pedido_pk`),
  ADD KEY `Ref92250` (`id_cotizacion_pk`);

--
-- Indices de la tabla `pedido_factura`
--
ALTER TABLE `pedido_factura`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`,`id_pedido_pk`),
  ADD KEY `Ref248427` (`id_pedido_pk`),
  ADD KEY `Ref94252` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`,`id_empleados_pk`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`id_perfil`);

--
-- Indices de la tabla `perfil_privilegios`
--
ALTER TABLE `perfil_privilegios`
  ADD PRIMARY KEY (`id_aplicacion`,`id_perfil`),
  ADD KEY `Refperfil4` (`id_perfil`);

--
-- Indices de la tabla `planilla_igss`
--
ALTER TABLE `planilla_igss`
  ADD PRIMARY KEY (`id_planilla_igss_pk`),
  ADD KEY `Ref17399` (`id_empresa_pk`);

--
-- Indices de la tabla `precio`
--
ALTER TABLE `precio`
  ADD PRIMARY KEY (`id_precio`),
  ADD KEY `Ref182313` (`id_tamaniop_pk`),
  ADD KEY `Ref20420` (`id_habitacion_pk`),
  ADD KEY `Ref26421` (`id_evento_pk`),
  ADD KEY `Ref25422` (`id_promocion_pk`),
  ADD KEY `Ref19423` (`id_salon_pk`),
  ADD KEY `Ref1235` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Refbien235` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `id_tprecio_pk` (`id_tprecio_pk`);

--
-- Indices de la tabla `problema`
--
ALTER TABLE `problema`
  ADD PRIMARY KEY (`id_problema_pk`),
  ADD KEY `Ref15168` (`id_cliente_pk`),
  ADD KEY `Ref17169` (`id_empresa_pk`);

--
-- Indices de la tabla `proceso`
--
ALTER TABLE `proceso`
  ADD PRIMARY KEY (`id_proceso_pk`);

--
-- Indices de la tabla `produccion`
--
ALTER TABLE `produccion`
  ADD PRIMARY KEY (`id_produccion_pk`);

--
-- Indices de la tabla `producto_bodega`
--
ALTER TABLE `producto_bodega`
  ADD PRIMARY KEY (`id_bien_pk`,`id_bodega_pk`,`id_categoria_pk`),
  ADD KEY `Ref110` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Ref511` (`id_bodega_pk`),
  ADD KEY `Refbien10` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `promocion`
--
ALTER TABLE `promocion`
  ADD PRIMARY KEY (`id_promocion_pk`),
  ADD KEY `Ref19163` (`id_salon_pk`),
  ADD KEY `Ref20165` (`id_habitacion_pk`),
  ADD KEY `Ref1195` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`id_proveedor_pk`);

--
-- Indices de la tabla `receta`
--
ALTER TABLE `receta`
  ADD PRIMARY KEY (`id_receta_pk`);

--
-- Indices de la tabla `reporteador`
--
ALTER TABLE `reporteador`
  ADD PRIMARY KEY (`id_reporteador`);

--
-- Indices de la tabla `requisicion`
--
ALTER TABLE `requisicion`
  ADD PRIMARY KEY (`id_requisicion_pk`),
  ADD KEY `Ref146216` (`id_detalle_requisicion_pk`),
  ADD KEY `Ref5217` (`id_bodega_pk`);

--
-- Indices de la tabla `reservacion_habitacion`
--
ALTER TABLE `reservacion_habitacion`
  ADD PRIMARY KEY (`id_reserhabit_pk`),
  ADD KEY `Ref1546` (`id_cliente_pk`),
  ADD KEY `Ref2047` (`id_habitacion_pk`);

--
-- Indices de la tabla `salon`
--
ALTER TABLE `salon`
  ADD PRIMARY KEY (`id_salon_pk`),
  ADD KEY `Ref17162` (`id_empresa_pk`);

--
-- Indices de la tabla `tamanio_porcion`
--
ALTER TABLE `tamanio_porcion`
  ADD PRIMARY KEY (`id_tamaniop_pk`);

--
-- Indices de la tabla `tiempo_vida`
--
ALTER TABLE `tiempo_vida`
  ADD PRIMARY KEY (`id_tiempo_vida_pk`);

--
-- Indices de la tabla `tipo`
--
ALTER TABLE `tipo`
  ADD PRIMARY KEY (`id_tipo_pk`);

--
-- Indices de la tabla `tipo_credito`
--
ALTER TABLE `tipo_credito`
  ADD PRIMARY KEY (`id_tipocredito_pk`);

--
-- Indices de la tabla `tipo_doc`
--
ALTER TABLE `tipo_doc`
  ADD PRIMARY KEY (`id_tipo_pk`);

--
-- Indices de la tabla `tipo_documento`
--
ALTER TABLE `tipo_documento`
  ADD PRIMARY KEY (`id_tipo_documento`);

--
-- Indices de la tabla `tipo_doc_1`
--
ALTER TABLE `tipo_doc_1`
  ADD PRIMARY KEY (`id_doc`);

--
-- Indices de la tabla `tipo_moneda`
--
ALTER TABLE `tipo_moneda`
  ADD PRIMARY KEY (`id_moneda`);

--
-- Indices de la tabla `tipo_precio`
--
ALTER TABLE `tipo_precio`
  ADD PRIMARY KEY (`id_tprecio_pk`),
  ADD KEY `Ref151314` (`id_precio`);

--
-- Indices de la tabla `transaccion`
--
ALTER TABLE `transaccion`
  ADD PRIMARY KEY (`id_transaccion_pk`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`usuario`);

--
-- Indices de la tabla `usuario_privilegios`
--
ALTER TABLE `usuario_privilegios`
  ADD PRIMARY KEY (`usuario`,`id_aplicacion`),
  ADD KEY `Refperfil1` (`id_perfil`),
  ADD KEY `Refaplicacion6` (`id_aplicacion`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  MODIFY `id_aplicacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `bien`
--
ALTER TABLE `bien`
  MODIFY `id_bien_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `id_bit` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=79;
--
-- AUTO_INCREMENT de la tabla `bodega`
--
ALTER TABLE `bodega`
  MODIFY `id_bodega_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `buzon`
--
ALTER TABLE `buzon`
  MODIFY `id_buzon_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `consultaalmacenada`
--
ALTER TABLE `consultaalmacenada`
  MODIFY `id_consulta_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `consultaguardada`
--
ALTER TABLE `consultaguardada`
  MODIFY `id_consulta_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `contribuyente`
--
ALTER TABLE `contribuyente`
  MODIFY `id_contribuyente_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `convertidora`
--
ALTER TABLE `convertidora`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
  MODIFY `id_cotizacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cuenta_corriente_por_pagar`
--
ALTER TABLE `cuenta_corriente_por_pagar`
  MODIFY `id_cuenta_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_cotizacion`
--
ALTER TABLE `detalle_cotizacion`
  MODIFY `id_detallecot_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_cuenta_por_pagar`
--
ALTER TABLE `detalle_cuenta_por_pagar`
  MODIFY `detalle_cuenta_por_pagar_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_documento`
--
ALTER TABLE `detalle_documento`
  MODIFY `id_detalle_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_folio`
--
ALTER TABLE `detalle_folio`
  MODIFY `id_detalle_folio_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;
--
-- AUTO_INCREMENT de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  MODIFY `id_detalle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT de la tabla `detalle_pedido_1`
--
ALTER TABLE `detalle_pedido_1`
  MODIFY `id_detalle_pedido_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_pedido_compra`
--
ALTER TABLE `detalle_pedido_compra`
  MODIFY `id_detalle_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_produccion`
--
ALTER TABLE `detalle_produccion`
  MODIFY `correlativo` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_receta_mp`
--
ALTER TABLE `detalle_receta_mp`
  MODIFY `correlativo` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_requisicion`
--
ALTER TABLE `detalle_requisicion`
  MODIFY `id_detalle_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `deuda`
--
ALTER TABLE `deuda`
  MODIFY `id_deuda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `devolucion_venta`
--
ALTER TABLE `devolucion_venta`
  MODIFY `id_dev` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `id_empleados_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `empresa`
--
ALTER TABLE `empresa`
  MODIFY `id_empresa_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `encabezado_muestreo`
--
ALTER TABLE `encabezado_muestreo`
  MODIFY `id_encabezado` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `encabezado_pedido`
--
ALTER TABLE `encabezado_pedido`
  MODIFY `id_encabezado_pedido_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `evento`
--
ALTER TABLE `evento`
  MODIFY `id_evento_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `id_fac_empresa_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;
--
-- AUTO_INCREMENT de la tabla `factura_detalle`
--
ALTER TABLE `factura_detalle`
  MODIFY `id_detalle_fact` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=106;
--
-- AUTO_INCREMENT de la tabla `folio`
--
ALTER TABLE `folio`
  MODIFY `id_cuenta_pagar_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `folio_bien`
--
ALTER TABLE `folio_bien`
  MODIFY `id_folio_bien_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT de la tabla `folio_habitacion`
--
ALTER TABLE `folio_habitacion`
  MODIFY `id_folio_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
--
-- AUTO_INCREMENT de la tabla `folio_promocion`
--
ALTER TABLE `folio_promocion`
  MODIFY `id_folio_promocion_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT de la tabla `folio_salon`
--
ALTER TABLE `folio_salon`
  MODIFY `id_folio_salon_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT de la tabla `forma_pago`
--
ALTER TABLE `forma_pago`
  MODIFY `id_forma_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `gastos_importacion`
--
ALTER TABLE `gastos_importacion`
  MODIFY `id_importacion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `habitacion`
--
ALTER TABLE `habitacion`
  MODIFY `id_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `impuesto`
--
ALTER TABLE `impuesto`
  MODIFY `id_impuesto_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `invitado`
--
ALTER TABLE `invitado`
  MODIFY `id_invitado_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `id_marca_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `medida`
--
ALTER TABLE `medida`
  MODIFY `id_medida_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `menu`
--
ALTER TABLE `menu`
  MODIFY `correlativo` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `movimiento_inventario`
--
ALTER TABLE `movimiento_inventario`
  MODIFY `id_movimiento_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `obj_perdido`
--
ALTER TABLE `obj_perdido`
  MODIFY `id_obj_perdido_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `operacion`
--
ALTER TABLE `operacion`
  MODIFY `id_operacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `paquetes_eventos`
--
ALTER TABLE `paquetes_eventos`
  MODIFY `id_paquetes_salon_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `paquetes_reservacion_habitacion`
--
ALTER TABLE `paquetes_reservacion_habitacion`
  MODIFY `id_paquetes_reservacion_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `paquete_inventario`
--
ALTER TABLE `paquete_inventario`
  MODIFY `id_paquete_inventario` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `parametros_fac`
--
ALTER TABLE `parametros_fac`
  MODIFY `id_parametros_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `pedido`
--
ALTER TABLE `pedido`
  MODIFY `id_pedido_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `pedido_compra`
--
ALTER TABLE `pedido_compra`
  MODIFY `id_orden_compra_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `precio`
--
ALTER TABLE `precio`
  MODIFY `id_precio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=111;
--
-- AUTO_INCREMENT de la tabla `problema`
--
ALTER TABLE `problema`
  MODIFY `id_problema_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `proceso`
--
ALTER TABLE `proceso`
  MODIFY `id_proceso_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `produccion`
--
ALTER TABLE `produccion`
  MODIFY `id_produccion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `promocion`
--
ALTER TABLE `promocion`
  MODIFY `id_promocion_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `id_proveedor_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `receta`
--
ALTER TABLE `receta`
  MODIFY `id_receta_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `reporteador`
--
ALTER TABLE `reporteador`
  MODIFY `id_reporteador` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `requisicion`
--
ALTER TABLE `requisicion`
  MODIFY `id_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `reservacion_habitacion`
--
ALTER TABLE `reservacion_habitacion`
  MODIFY `id_reserhabit_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `salon`
--
ALTER TABLE `salon`
  MODIFY `id_salon_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `tipo`
--
ALTER TABLE `tipo`
  MODIFY `id_tipo_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `tipo_credito`
--
ALTER TABLE `tipo_credito`
  MODIFY `id_tipocredito_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `tipo_doc`
--
ALTER TABLE `tipo_doc`
  MODIFY `id_tipo_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipo_doc_1`
--
ALTER TABLE `tipo_doc_1`
  MODIFY `id_doc` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipo_moneda`
--
ALTER TABLE `tipo_moneda`
  MODIFY `id_moneda` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipo_precio`
--
ALTER TABLE `tipo_precio`
  MODIFY `id_tprecio_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `transaccion`
--
ALTER TABLE `transaccion`
  MODIFY `id_transaccion_pk` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

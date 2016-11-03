-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-11-2016 a las 22:24:23
-- Versión del servidor: 10.1.16-MariaDB
-- Versión de PHP: 7.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `hotelsancarlos`
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

--
-- Volcado de datos para la tabla `aplicacion`
--

INSERT INTO `aplicacion` (`id_aplicacion`, `nombre_aplicacion`) VALUES
(100, 'navegador'),
(16101, 'documento');

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
  `id_linea_pk` int(11) DEFAULT NULL,
  `apartados` int(11) DEFAULT NULL,
  `metodologia` char(40) DEFAULT NULL,
  `id_medida_pk` int(11) DEFAULT NULL,
  `porcentaje_comision` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_marca_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bien`
--

INSERT INTO `bien` (`id_bien_pk`, `id_categoria_pk`, `precio`, `costo`, `descripcion`, `id_linea_pk`, `apartados`, `metodologia`, `id_medida_pk`, `porcentaje_comision`, `estado`, `id_marca_pk`) VALUES
(1, '1', '400', '200', 'PRODUCTO UNO', 1, 3, 'SABER', 1, '7', 'ACTIVO', 1),
(2, '1', '344', '233', 'PRODUCTO2', 2, 3, 'SABER2', 1, '10', 'ACTIVO', 2),
(3, '1', '800', '700', 'PRODUCTO TRES', 2, 3, 'SABEEEER', 1, '5', 'ACTIVO', 2),
(4, '1', '789', '93', 'PRODUCTO 4', 1, 3, 'SABEROX23', 1, '15', 'ACTIVO', 1);

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
(16100, '13:33:48', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16101, '15:16:54', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16102, '15:17:29', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16103, '15:21:23', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16104, '15:21:36', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16105, '15:25:16', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16106, '15:35:56', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16107, '15:36:30', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16108, '15:39:39', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16109, '15:52:11', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16110, '15:53:13', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16111, '15:57:16', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16112, '16:02:25', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16113, '16:06:26', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16114, '16:16:02', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16115, '16:18:39', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16116, '22:09:06', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16117, '22:11:42', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16118, '22:13:02', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16119, '22:18:55', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16120, '22:24:43', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16121, '22:26:31', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16122, '22:27:40', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16123, '22:42:10', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16124, '22:45:43', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16125, '22:50:00', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16126, '22:53:11', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16127, '22:55:37', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16128, '23:06:02', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16129, '23:09:23', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16130, '23:18:05', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16131, '23:20:50', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16132, '23:22:14', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16133, '23:24:00', '2016-11-01', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16134, '17:51:27', '2016-11-02', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.0.100'),
(16135, '08:20:16', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1'),
(16136, '08:21:08', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.56.1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodega`
--

CREATE TABLE `bodega` (
  `id_bodega_pk` int(11) NOT NULL,
  `ubicacion` char(40) DEFAULT NULL,
  `nombre_bodega` char(40) DEFAULT NULL,
  `tama` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL
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
  `fecha_nacimiento` date DEFAULT NULL,
  `id_tipocredito_pk` int(11) DEFAULT NULL,
  `id_contribuyente_pk` int(11) DEFAULT NULL,
  `id_tprecio_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE `compra` (
  `id_factura_compra_pk` int(11) NOT NULL,
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
  `id_empresa_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `com_venta`
--

CREATE TABLE `com_venta` (
  `id_com_venta_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `total_venta` decimal(10,2) DEFAULT NULL,
  `porsentaje_comision` decimal(10,2) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `total_comision` decimal(10,2) DEFAULT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `com_venta`
--

INSERT INTO `com_venta` (`id_com_venta_pk`, `id_empleados_pk`, `estado`, `total_venta`, `porsentaje_comision`, `fecha`, `total_comision`, `id_fac_empresa_pk`, `id_empresa_pk`) VALUES
(16, 1, 'ACTIVO', '1600.00', '10.00', '2016-11-02', '160.00', 2, 1),
(15, 1, 'ACTIVO', '900.00', '7.00', '2016-11-02', '63.00', 1, 1),
(14, 1, 'ACTIVO', '1600.00', '9.00', '2016-11-02', '144.00', 2, 1),
(13, 1, 'ACTIVO', '900.00', '4.00', '2016-11-02', '36.00', 1, 1);

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
-- Estructura de tabla para la tabla `contribuyente`
--

CREATE TABLE `contribuyente` (
  `id_contribuyente_pk` int(11) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `nit` varchar(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
  `id_cotizacion_pk` int(11) NOT NULL,
  `nombre_cot` varchar(50) DEFAULT NULL,
  `epllido_cot` varchar(50) DEFAULT NULL,
  `nit_cot` varchar(50) DEFAULT NULL,
  `telefono_cot` varchar(15) DEFAULT NULL,
  `direccion_cot` varchar(50) DEFAULT NULL,
  `estado-cot` varchar(100) NOT NULL,
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
  `estado` char(25) DEFAULT 'ACTIVO',
  `id_empresa_pk` int(11) NOT NULL,
  `nombre_banco` char(50) DEFAULT NULL,
  `no_cuenta` char(50) DEFAULT NULL,
  `saldo_libros` decimal(10,2) DEFAULT NULL,
  `saldo_bancarios` decimal(10,2) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cuenta_bancaria`
--

INSERT INTO `cuenta_bancaria` (`id_cuenta_bancaria_pk`, `estado`, `id_empresa_pk`, `nombre_banco`, `no_cuenta`, `saldo_libros`, `saldo_bancarios`) VALUES
(1, 'activo', 1, 'CITIBANK', '45698579-8', '5400.00', '6500.00'),
(2, 'ACTIVO', 1, 'Banco Industrial', '128754432-6', '8000.00', '9600.00'),
(3, 'ACTIVO', 1, 'G&T CONTINENTAL', '21623565-8', '29000.00', '36000.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_corriente_por_pagar`
--

CREATE TABLE `cuenta_corriente_por_pagar` (
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `estado` char(15) DEFAULT NULL
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
  `estado` char(10) DEFAULT 'ACTIVO',
  `id_planilla_igss_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `id_detalle_impuesto_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_compra`
--

CREATE TABLE `detalle_compra` (
  `id_detalle_compra_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_factura_compra_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_com_ventas`
--

CREATE TABLE `detalle_com_ventas` (
  `id_detalle_com_ventas` int(11) NOT NULL,
  `id_com_venta_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `total_ventas` decimal(10,2) DEFAULT NULL,
  `comision` decimal(10,2) DEFAULT NULL,
  `id_devengos_pk` int(11) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_com_ventas`
--

INSERT INTO `detalle_com_ventas` (`id_detalle_com_ventas`, `id_com_venta_pk`, `id_empleados_pk`, `estado`, `total_ventas`, `comision`, `id_devengos_pk`, `fecha`) VALUES
(1, 1, 1, 'ACTIVO', '2500.00', '123.00', 1, '2016-11-02'),
(2, 1, 1, 'ACTIVO', '2500.00', '123.00', 1, '2016-11-02'),
(3, 1, 1, 'ACTIVO', '900.00', '27.00', 1, '2016-11-02'),
(4, 1, 1, 'ACTIVO', '7400.00', '666.00', 1, '2016-11-02'),
(5, 1, 1, 'ACTIVO', '2500.00', '180.00', 1, '2016-11-02'),
(6, 1, 1, 'ACTIVO', '2500.00', '223.00', 1, '2016-11-02');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_cotizacion`
--

CREATE TABLE `detalle_cotizacion` (
  `id_detallecot_pk` int(11) NOT NULL,
  `cantidad_detcot` int(11) DEFAULT NULL,
  `desc_servicio_detcot` varchar(150) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_cotizacion_pk` int(11) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_cuenta_por_pagar`
--

CREATE TABLE `detalle_cuenta_por_pagar` (
  `detalle_cuenta_por_pagar_pk` int(11) NOT NULL,
  `fecha` char(25) DEFAULT NULL,
  `comprobante` int(11) DEFAULT NULL,
  `debe` decimal(15,0) DEFAULT NULL,
  `haber` decimal(15,0) DEFAULT NULL,
  `saldo` decimal(15,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_cuenta_pk` int(11) DEFAULT NULL,
  `id_proveedor_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_dev`
--

CREATE TABLE `detalle_dev` (
  `id_detalle_dev` int(11) NOT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `precio` decimal(18,2) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `subtotal` decimal(18,2) DEFAULT NULL,
  `id_dev` int(11) DEFAULT NULL,
  `id_fac_empresa_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_devolucion_compra`
--

CREATE TABLE `detalle_devolucion_compra` (
  `id_detalle_devolucion_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `observaciones` char(100) DEFAULT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `id_devolucion_compra_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_disp_banc`
--

CREATE TABLE `detalle_disp_banc` (
  `id_detalle_db_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
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
  `no_doc` char(18) DEFAULT NULL,
  `serie_doc` char(18) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `tipo_doc` char(40) DEFAULT NULL,
  `empresa` char(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_documentos`
--

CREATE TABLE `detalle_documentos` (
  `id_detalle_cv_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `nombre_cuenta` char(100) DEFAULT NULL,
  `detalle` varchar(100) NOT NULL,
  `debe` decimal(10,2) DEFAULT NULL,
  `haber` decimal(10,2) DEFAULT NULL,
  `fecha` date NOT NULL,
  `id_documento_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_documentos`
--

INSERT INTO `detalle_documentos` (`id_detalle_cv_pk`, `estado`, `nombre_cuenta`, `detalle`, `debe`, `haber`, `fecha`, `id_documento_pk`) VALUES
(1, 'ACTIVO', 'daniel', 'Escritorios', '2300.00', '0.00', '2016-11-02', 1),
(2, 'ACTIVO', 'daniel', 'Sillas', '3100.00', '0.00', '2016-11-02', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_folio`
--

CREATE TABLE `detalle_folio` (
  `id_detalle_folio_pk` int(11) NOT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `nombre` char(30) DEFAULT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_folio_salon_pk` int(11) DEFAULT NULL,
  `id_folio_habitacion_pk` int(11) DEFAULT NULL,
  `id_folio_bien_pk` int(11) DEFAULT NULL,
  `id_folio_promocion_pk` int(11) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
  `estado` char(15) DEFAULT NULL,
  `existencia_auditada` char(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_nomina`
--

CREATE TABLE `detalle_nomina` (
  `id_dn` int(10) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `Sueldo_base` decimal(10,2) DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `id_nomina_pk` int(11) NOT NULL,
  `id_presamo_pk` int(11) NOT NULL,
  `id_devengos_pk` int(11) NOT NULL,
  `total_sueldo` decimal(10,2) DEFAULT NULL,
  `id_percepcion_pk` int(11) NOT NULL,
  `id_detalle_impuesto_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido`
--

CREATE TABLE `detalle_pedido` (
  `id_detalle` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `estado_detalle` varchar(25) DEFAULT NULL,
  `precio` decimal(18,2) DEFAULT NULL,
  `subtotal` decimal(18,2) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_pedido_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
  `id_detalle_pedido_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio_compra` decimal(15,0) DEFAULT NULL,
  `subtotal` decimal(15,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_pedido_compra_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_planilla_igss`
--

CREATE TABLE `detalle_planilla_igss` (
  `id_detalle_pigss` int(11) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `id_planilla_igss_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `sueldo_base` decimal(10,2) DEFAULT NULL,
  `igss_pagar` decimal(10,2) DEFAULT NULL,
  `fecha` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_planilla_igss`
--

INSERT INTO `detalle_planilla_igss` (`id_detalle_pigss`, `estado`, `id_planilla_igss_pk`, `id_empleados_pk`, `sueldo_base`, `igss_pagar`, `fecha`) VALUES
(1, 'ACTIVO', 1, 1, '5000.00', '775.00', '2016-11-02'),
(2, 'ACTIVO', 1, 2, '4900.00', '759.50', '2016-11-02'),
(3, 'ACTIVO', 1, 1, '5000.00', '775.00', '2016-11-17'),
(4, 'ACTIVO', 1, 2, '4900.00', '759.50', '2016-11-17');

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
  `estado` char(15) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_requisicion_pk` int(11) NOT NULL
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
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devengos`
--

CREATE TABLE `devengos` (
  `id_devengos_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `nombre` char(100) DEFAULT NULL,
  `detalle` char(250) DEFAULT NULL,
  `cantidad_debengado` decimal(10,2) DEFAULT NULL,
  `cuotas` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `id_planilla_igss_pk` int(11) NOT NULL,
  `id_detalle_impuesto_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion`
--

CREATE TABLE `devolucion` (
  `id_dev` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  `fecha_devolucion` date DEFAULT NULL,
  `motivo_devolucion` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion_compra`
--

CREATE TABLE `devolucion_compra` (
  `id_devolucion_compra_pk` int(11) NOT NULL,
  `encargado` char(25) DEFAULT NULL,
  `fecha_devolucion` char(25) DEFAULT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_bodega_pk` int(11) NOT NULL,
  `id_factura_compra_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `disponibilidad_bancaria`
--

CREATE TABLE `disponibilidad_bancaria` (
  `id_disponibilidad_bancaria` int(11) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
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
  `estado` char(50) DEFAULT 'ACTIVO',
  `id_cuenta_bancaria_pk` int(11) NOT NULL,
  `id_tipo_documento` int(11) NOT NULL,
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `documento`
--

INSERT INTO `documento` (`id_documento_pk`, `conciliado`, `fecha`, `valor_total`, `destinatario`, `no_documento`, `descripcion`, `estado`, `id_cuenta_bancaria_pk`, `id_tipo_documento`, `id_cuenta_pk`, `id_proveedor_pk`) VALUES
(1, 'Conciliado', '2016-11-01', '5400.00', 'ASDAS', '123123', 'PAGO DE COMPUTADORAS', 'ACTIVO', 1, 1, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `doc_impuesto`
--

CREATE TABLE `doc_impuesto` (
  `id_doc_imp` int(11) NOT NULL,
  `documento` varchar(25) DEFAULT NULL,
  `id_impuesto_pk` int(11) DEFAULT NULL
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
  `porcentaje` decimal(8,2) NOT NULL,
  `telefono` char(15) DEFAULT NULL,
  `genero` char(10) DEFAULT NULL,
  `sueldo` int(11) DEFAULT NULL,
  `tipo_sueldo` varchar(55) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `foto_empleado` varchar(200) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`id_empleados_pk`, `nombre`, `fecha_nacimiento`, `edad`, `dpi`, `nacionalidad`, `estado_civil`, `no_afiliacion_igss`, `fecha_ingreso`, `fecha_egreso`, `direccion`, `cargo`, `porcentaje`, `telefono`, `genero`, `sueldo`, `tipo_sueldo`, `estado`, `foto_empleado`, `id_empresa_pk`) VALUES
(1, 'Daniel', '2016-11-08', '18', '21312321', 'GT', 'S', 'AFILIADO', '2016-11-07', '2016-11-16', '12VS', 'VENDEDOR', '9.00', '12312', 'M', 5000, '', 'ACTIVO', '\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0', 1),
(2, 'CRISTIAN', '2016-11-08', '20', '323', 'GT', 'S', 'AFILIADO', '2016-11-22', '2016-11-16', 'AF24', 'VENDEDOR', '8.80', '32', 'M', 4900, '', 'ACTIVO', '\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0', 1),
(3, 'ESTRADA', '2016-11-14', '21', '32324', 'GT', 'S', 'NO AFILIADO', '2016-11-15', '2016-11-09', '3DGA', 'GERENTE', '0.00', '34332', 'M', 7000, '', 'ACTIVO', '\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0', 1);

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
(1, 'Hotel1', '12F', 'GT', '3', '212', 'DAFDS', '2312', 'ACTIVO'),
(2, 'Hotel2', 'DFASD', 'GT', '4', '22', 'FASDCBB', '2112', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_documento`
--

CREATE TABLE `encabezado_documento` (
  `no_doc` char(18) NOT NULL,
  `serie_doc` char(18) NOT NULL,
  `tipo_doc` char(40) NOT NULL,
  `empresa` char(20) NOT NULL,
  `fecha` char(20) DEFAULT NULL,
  `estado_doc` char(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `clie_prov` int(11) DEFAULT NULL
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
  `fecha_vencimiento` date DEFAULT NULL,
  `estado_factura` varchar(15) DEFAULT NULL,
  `fecha_emision` date NOT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_impuesto_pk` int(11) DEFAULT NULL,
  `id_moneda` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_parametros_pk` int(11) DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `marca_comision` varchar(10) NOT NULL DEFAULT 'X'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`id_fac_empresa_pk`, `id_empresa_pk`, `serie`, `fecha_vencimiento`, `estado_factura`, `fecha_emision`, `subtotal`, `total`, `id_cliente_pk`, `id_impuesto_pk`, `id_moneda`, `estado`, `id_parametros_pk`, `id_empleados_pk`, `marca_comision`) VALUES
(1, 1, '1', '2016-11-21', 'ACTIVO', '2016-11-01', '4000.00', '4100.00', 1, 1, 1, 'ACTIVO', 1, 1, 'S'),
(2, 1, '3', '2016-11-08', 'ACTIVO', '2016-12-19', '3000.00', '3300.00', 1, 1, 1, 'ACTIVO', 1, 1, 'S'),
(3, 1, '4', '2016-11-09', 'ACTIVO', '2016-11-25', '5000.00', '5000.00', 1, 1, 1, 'ACTIVO', 1, 2, 'X'),
(4, 1, '44', '2016-11-16', 'ACTIVO', '2016-12-12', '6000.00', '6100.00', 1, 1, 1, 'ACTIVO', 1, 2, 'X');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura documento`
--

CREATE TABLE `factura documento` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_documento_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_detalle`
--

CREATE TABLE `factura_detalle` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_precio` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `nombre_desc` varchar(200) DEFAULT NULL,
  `precio` decimal(18,2) DEFAULT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_detalle_folio_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura_detalle`
--

INSERT INTO `factura_detalle` (`id_fac_empresa_pk`, `id_empresa_pk`, `id_precio`, `cantidad`, `nombre_desc`, `precio`, `serie`, `estado`, `id_detalle_folio_pk`) VALUES
(1, 1, 1, 3, 'DESCUENT1', '300.00', '3212', 'ACTIVO', 1),
(2, 1, 2, 4, 'DESCUENT2', '4000.00', '2321F', 'ACTIVO', 2),
(3, 1, 3, 5, 'DESCUENTO3', '400.00', '12', 'ACTIVO', 1),
(4, 1, 4, 2, 'DESCUENTO4', '400.00', 'FAS2', 'ACTIVO', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_pago`
--

CREATE TABLE `factura_pago` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_forma_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `serie` varchar(10) DEFAULT NULL,
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
  `fecha_pago` char(18) DEFAULT NULL,
  `costo` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_bien`
--

CREATE TABLE `folio_bien` (
  `id_folio_bien_pk` int(11) NOT NULL,
  `costo` decimal(10,2) NOT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_factura`
--

CREATE TABLE `folio_factura` (
  `id_cuenta_pagar_pk` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_habitacion`
--

CREATE TABLE `folio_habitacion` (
  `id_folio_habitacion_pk` int(11) NOT NULL,
  `costo` decimal(10,2) NOT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_reserhabit_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_promocion`
--

CREATE TABLE `folio_promocion` (
  `id_folio_promocion_pk` int(11) NOT NULL,
  `costo` int(11) NOT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `folio_salon`
--

CREATE TABLE `folio_salon` (
  `id_folio_salon_pk` int(11) NOT NULL,
  `costo` decimal(10,2) NOT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_evento_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `forma_pago`
--

CREATE TABLE `forma_pago` (
  `id_forma_pk` int(11) NOT NULL,
  `tipo_pago` varchar(25) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
  `estado` char(15) DEFAULT NULL,
  `id_factura_compra_pk` int(11) NOT NULL
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

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `impuesto`
--

CREATE TABLE `impuesto` (
  `id_impuesto_pk` int(11) NOT NULL,
  `porcentaje` decimal(18,2) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `impuestos_ley`
--

CREATE TABLE `impuestos_ley` (
  `id_detalle_impuesto_pk` int(11) NOT NULL,
  `porcentaje_impuesto` decimal(10,2) DEFAULT NULL,
  `rango_relaciones` varchar(50) DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
-- Estructura de tabla para la tabla `linea`
--

CREATE TABLE `linea` (
  `id_linea_pk` int(11) NOT NULL,
  `nombre_categoria` char(40) DEFAULT NULL,
  `porcentaje_comision` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `linea`
--

INSERT INTO `linea` (`id_linea_pk`, `nombre_categoria`, `porcentaje_comision`, `estado`, `id_categoria_pk`) VALUES
(1, 'ELECTRODOMESTICOS', '4', 'ACTIVO', '1'),
(2, 'VIDEOJUEGOS', '9', 'ACTIVO', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `id_marca_pk` int(11) NOT NULL,
  `nombre_marca` char(50) DEFAULT NULL,
  `procentaje_comision` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`id_marca_pk`, `nombre_marca`, `procentaje_comision`, `estado`) VALUES
(1, 'NIKE', '3', 'ACTIVO'),
(2, 'ADIDAS', '6', 'ACTIVO');

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
  `transaccion` char(40) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `no_doc` char(18) DEFAULT NULL,
  `serie_doc` char(18) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `tipo_doc` char(40) DEFAULT NULL,
  `empresa` char(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nomina`
--

CREATE TABLE `nomina` (
  `id_nomina_pk` int(11) NOT NULL,
  `nombre_nomina` varchar(100) DEFAULT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `fecha_inicio_pago` date DEFAULT NULL,
  `fecha_de_corte` date DEFAULT NULL,
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
  `categoria` varchar(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `id_pedido_pk` int(11) NOT NULL,
  `fecha_pedido` date DEFAULT NULL,
  `cliente` char(50) DEFAULT NULL,
  `usu_pedido` char(50) DEFAULT NULL,
  `estado_pedido` char(20) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_compra`
--

CREATE TABLE `pedido_compra` (
  `id_pedido_compra_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `encargado` char(25) DEFAULT NULL,
  `estado_pedido` char(20) DEFAULT NULL,
  `observaciones` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
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
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `percepcion`
--

CREATE TABLE `percepcion` (
  `id_percepcion_pk` int(11) NOT NULL,
  `tipo_percepcion` varchar(50) DEFAULT NULL,
  `estado` varchar(25) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE `perfil` (
  `id_perfil` int(11) NOT NULL,
  `nombre_perfil` char(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`id_perfil`, `nombre_perfil`) VALUES
(1, 'administrador');

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

--
-- Volcado de datos para la tabla `perfil_privilegios`
--

INSERT INTO `perfil_privilegios` (`id_aplicacion`, `id_perfil`, `ins`, `sel`, `upd`, `del`) VALUES
(100, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `planilla_igss`
--

CREATE TABLE `planilla_igss` (
  `id_planilla_igss_pk` int(11) NOT NULL,
  `estado` char(10) DEFAULT 'ACTIVO',
  `porcentaje_igss` decimal(10,2) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `cuota_patronal` decimal(10,2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `planilla_igss`
--

INSERT INTO `planilla_igss` (`id_planilla_igss_pk`, `estado`, `porcentaje_igss`, `fecha`, `id_empresa_pk`, `cuota_patronal`) VALUES
(1, 'ACTIVO', '4.83', '2016-11-15', 1, '10.67');

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
  `estado` char(15) DEFAULT NULL,
  `id_tprecio_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `precio`
--

INSERT INTO `precio` (`id_precio`, `precio`, `id_bien_pk`, `id_categoria_pk`, `id_tamaniop_pk`, `estado`, `id_tprecio_pk`) VALUES
(1, '300.00', 1, '1', '1', 'ACTIVO', 1),
(2, '400.00', 2, '1', '1', 'ACTIVO', 1),
(3, '500.00', 3, '1', '1', 'ACTIVO', 1),
(4, '1000.00', 4, '1', '1', 'ACTIVO', 1);

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

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `id_proveedor_pk` int(11) NOT NULL,
  `nombre_proveedor` char(25) DEFAULT NULL,
  `direccion` char(25) DEFAULT NULL,
  `telefono` char(15) DEFAULT NULL,
  `correo_electronico` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
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
  `nombre` char(50) DEFAULT NULL,
  `ubicacion` char(200) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `requisicion`
--

CREATE TABLE `requisicion` (
  `id_requisicion_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `encargado` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
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
  `fecha_reservacion` date NOT NULL,
  `id_cliente_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
-- Estructura de tabla para la tabla `tipo_credito`
--

CREATE TABLE `tipo_credito` (
  `id_tipocredito_pk` int(11) NOT NULL,
  `tipo` varchar(20) DEFAULT NULL,
  `valor` decimal(10,2) NOT NULL,
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
  `estado` char(10) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_documento`
--

INSERT INTO `tipo_documento` (`id_tipo_documento`, `nombre_documento`, `detalle`, `estado`) VALUES
(1, 'Deposito', 'documento para establecer los ingresos a las cuentas del hotel san carlos', 'ACTIVO'),
(2, 'Cheque', 'Documento para ingresar entradas y salidas de dinero en el hotel san carlos', 'ACTIVO'),
(3, 'Nota de credito', 'Documento para presentar creditos en hotel san carlos', 'ACTIVO'),
(4, 'Nota de debito', 'Dcoumento para presentar debitos en hotel san carlos', 'ACTIVO');

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
-- Estructura de tabla para la tabla `tipo_habitacion`
--

CREATE TABLE `tipo_habitacion` (
  `id_tipo_pk` int(11) NOT NULL,
  `nivel_tipo` char(100) DEFAULT NULL,
  `adulto_tipo` int(11) DEFAULT NULL,
  `ninios_tipo` int(11) DEFAULT NULL,
  `especificaciones_tipo` char(100) DEFAULT NULL,
  `costo_tipo` decimal(10,0) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
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

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `usuario` char(50) NOT NULL,
  `contrasenia` char(80) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `id_empleados_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`usuario`, `contrasenia`, `fecha_creacion`, `estado`, `id_empresa_pk`, `id_empleados_pk`) VALUES
('usuariodbs', 'aABvAGwAYQA=', '2016-11-01', 'activo', 1, 1);

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
-- Volcado de datos para la tabla `usuario_privilegios`
--

INSERT INTO `usuario_privilegios` (`usuario`, `id_aplicacion`, `ins`, `sel`, `upd`, `del`, `id_perfil`) VALUES
('usuariodbs', 100, 1, 1, 1, 1, 0);

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
  ADD KEY `Ref238401` (`id_empleados_pk`),
  ADD KEY `Ref186306` (`id_produccion_pk`);

--
-- Indices de la tabla `bien`
--
ALTER TABLE `bien`
  ADD PRIMARY KEY (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Ref189404` (`id_medida_pk`),
  ADD KEY `Ref98` (`id_categoria_pk`),
  ADD KEY `Ref14425` (`id_marca_pk`),
  ADD KEY `Ref249431` (`id_linea_pk`);

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
  ADD PRIMARY KEY (`id_bodega_pk`),
  ADD KEY `Ref17432` (`id_empresa_pk`);

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
  ADD KEY `Ref153238` (`id_tipocredito_pk`),
  ADD KEY `Ref159255` (`id_contribuyente_pk`),
  ADD KEY `Ref152316` (`id_tprecio_pk`);

--
-- Indices de la tabla `compra`
--
ALTER TABLE `compra`
  ADD PRIMARY KEY (`id_factura_compra_pk`),
  ADD KEY `Ref17464` (`id_empresa_pk`),
  ADD KEY `Ref129174` (`id_pedido_compra_pk`),
  ADD KEY `Ref123176` (`id_cuenta_pk`,`id_proveedor_pk`),
  ADD KEY `Ref99223` (`id_forma_pk`);

--
-- Indices de la tabla `com_venta`
--
ALTER TABLE `com_venta`
  ADD PRIMARY KEY (`id_com_venta_pk`,`id_empleados_pk`),
  ADD KEY `Ref94452` (`id_empresa_pk`,`id_fac_empresa_pk`),
  ADD KEY `Ref238453` (`id_empleados_pk`),
  ADD KEY `Reffactura452` (`id_fac_empresa_pk`,`id_empresa_pk`);

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
  ADD PRIMARY KEY (`id_cotizacion_pk`),
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
  ADD KEY `Ref238392` (`id_empleados_pk`),
  ADD KEY `Ref256449` (`id_detalle_impuesto_pk`);

--
-- Indices de la tabla `detalle_compra`
--
ALTER TABLE `detalle_compra`
  ADD PRIMARY KEY (`id_detalle_compra_pk`),
  ADD KEY `Ref125442` (`id_factura_compra_pk`),
  ADD KEY `Ref1466` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Refbien466` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_com_ventas`
--
ALTER TABLE `detalle_com_ventas`
  ADD PRIMARY KEY (`id_detalle_com_ventas`,`id_com_venta_pk`,`id_empleados_pk`),
  ADD KEY `Ref241395` (`id_empleados_pk`,`id_com_venta_pk`),
  ADD KEY `Ref242445` (`id_devengos_pk`),
  ADD KEY `Refcom_venta395` (`id_com_venta_pk`,`id_empleados_pk`);

--
-- Indices de la tabla `detalle_cotizacion`
--
ALTER TABLE `detalle_cotizacion`
  ADD PRIMARY KEY (`id_detallecot_pk`),
  ADD KEY `Ref154408` (`id_detallecot_pk`,`id_precio`),
  ADD KEY `Ref100409` (`id_promocion_pk`,`id_detallecot_pk`),
  ADD KEY `Ref92415` (`id_cotizacion_pk`),
  ADD KEY `Ref17461` (`id_empresa_pk`),
  ADD KEY `Refcotizacion_paquete409` (`id_detallecot_pk`,`id_promocion_pk`);

--
-- Indices de la tabla `detalle_cuenta_por_pagar`
--
ALTER TABLE `detalle_cuenta_por_pagar`
  ADD PRIMARY KEY (`detalle_cuenta_por_pagar_pk`),
  ADD KEY `Ref123293` (`id_proveedor_pk`,`id_cuenta_pk`),
  ADD KEY `Refcuenta_corriente_por_pagar293` (`id_cuenta_pk`,`id_proveedor_pk`);

--
-- Indices de la tabla `detalle_dev`
--
ALTER TABLE `detalle_dev`
  ADD PRIMARY KEY (`id_detalle_dev`),
  ADD KEY `Ref257456` (`id_empresa_pk`,`id_fac_empresa_pk`,`id_dev`,`serie`),
  ADD KEY `Ref1458` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Refdevolucion456` (`id_dev`,`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Refbien458` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_devolucion_compra`
--
ALTER TABLE `detalle_devolucion_compra`
  ADD PRIMARY KEY (`id_detalle_devolucion_pk`),
  ADD KEY `Ref1467` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Ref262481` (`id_devolucion_compra_pk`),
  ADD KEY `Refbien467` (`id_bien_pk`,`id_categoria_pk`);

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
  ADD KEY `Ref1185` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Ref130187` (`no_doc`,`empresa`,`serie_doc`,`tipo_doc`),
  ADD KEY `Refencabezado_documento187` (`no_doc`,`serie_doc`,`tipo_doc`,`empresa`);

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
  ADD KEY `Ref163433` (`id_folio_bien_pk`),
  ADD KEY `Ref162434` (`id_folio_salon_pk`),
  ADD KEY `Ref161435` (`id_folio_habitacion_pk`),
  ADD KEY `Ref164436` (`id_folio_promocion_pk`),
  ADD KEY `Ref33437` (`id_cuenta_pagar_pk`);

--
-- Indices de la tabla `detalle_muestreo`
--
ALTER TABLE `detalle_muestreo`
  ADD PRIMARY KEY (`id_encabezado`),
  ADD KEY `Ref143215` (`id_encabezado`),
  ADD KEY `Ref10290` (`id_bien_pk`,`id_categoria_pk`,`id_bodega_pk`),
  ADD KEY `Refproducto_bodega290` (`id_bien_pk`,`id_bodega_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_nomina`
--
ALTER TABLE `detalle_nomina`
  ADD PRIMARY KEY (`id_dn`),
  ADD KEY `Ref238388` (`id_empleados_pk`),
  ADD KEY `Ref240389` (`id_nomina_pk`),
  ADD KEY `Ref239390` (`id_presamo_pk`),
  ADD KEY `Ref242397` (`id_devengos_pk`),
  ADD KEY `Ref255446` (`id_percepcion_pk`),
  ADD KEY `Ref256447` (`id_detalle_impuesto_pk`);

--
-- Indices de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  ADD PRIMARY KEY (`id_detalle`),
  ADD KEY `Ref151403` (`id_precio`),
  ADD KEY `Ref248429` (`id_pedido_pk`);

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
  ADD PRIMARY KEY (`id_detalle_pedido_pk`),
  ADD KEY `Ref129441` (`id_pedido_compra_pk`),
  ADD KEY `Ref1465` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Refbien465` (`id_bien_pk`,`id_categoria_pk`);

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
  ADD KEY `Ref145440` (`id_requisicion_pk`),
  ADD KEY `Ref1220` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `deuda`
--
ALTER TABLE `deuda`
  ADD PRIMARY KEY (`id_deuda`),
  ADD KEY `Ref15230` (`id_cliente_pk`),
  ADD KEY `Ref94231` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Ref17232` (`id_empresa_pk`);

--
-- Indices de la tabla `devengos`
--
ALTER TABLE `devengos`
  ADD PRIMARY KEY (`id_devengos_pk`),
  ADD KEY `Ref238386` (`id_empleados_pk`),
  ADD KEY `Ref237448` (`id_planilla_igss_pk`),
  ADD KEY `Ref256450` (`id_detalle_impuesto_pk`);

--
-- Indices de la tabla `devolucion`
--
ALTER TABLE `devolucion`
  ADD PRIMARY KEY (`id_dev`,`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Ref94454` (`id_empresa_pk`,`id_fac_empresa_pk`,`serie`),
  ADD KEY `Ref15455` (`id_cliente_pk`),
  ADD KEY `Reffactura454` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`);

--
-- Indices de la tabla `devolucion_compra`
--
ALTER TABLE `devolucion_compra`
  ADD PRIMARY KEY (`id_devolucion_compra_pk`),
  ADD KEY `Ref5469` (`id_bodega_pk`),
  ADD KEY `Ref125473` (`id_factura_compra_pk`),
  ADD KEY `Ref124474` (`id_proveedor_pk`);

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
-- Indices de la tabla `doc_impuesto`
--
ALTER TABLE `doc_impuesto`
  ADD PRIMARY KEY (`id_doc_imp`),
  ADD KEY `Ref155463` (`id_impuesto_pk`);

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
  ADD PRIMARY KEY (`no_doc`,`serie_doc`,`tipo_doc`,`empresa`);

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
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Ref246405` (`id_moneda`),
  ADD KEY `Ref251462` (`id_parametros_pk`),
  ADD KEY `Ref238483` (`id_empleados_pk`),
  ADD KEY `Ref15126` (`id_cliente_pk`),
  ADD KEY `Ref17241` (`id_empresa_pk`),
  ADD KEY `Ref155246` (`id_impuesto_pk`);

--
-- Indices de la tabla `factura documento`
--
ALTER TABLE `factura documento`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`id_documento_pk`,`serie`),
  ADD KEY `Ref94383` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Ref234384` (`id_documento_pk`);

--
-- Indices de la tabla `factura_detalle`
--
ALTER TABLE `factura_detalle`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`id_precio`),
  ADD KEY `Ref151402` (`id_precio`),
  ADD KEY `Ref250439` (`id_detalle_folio_pk`),
  ADD KEY `Ref94247` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Refempresa248` (`id_empresa_pk`);

--
-- Indices de la tabla `factura_pago`
--
ALTER TABLE `factura_pago`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_forma_pk`),
  ADD KEY `Ref94127` (`id_empresa_pk`,`id_fac_empresa_pk`,`serie`),
  ADD KEY `Ref99128` (`id_forma_pk`),
  ADD KEY `Reffactura127` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`);

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
  ADD KEY `Ref1262` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `folio_factura`
--
ALTER TABLE `folio_factura`
  ADD PRIMARY KEY (`id_cuenta_pagar_pk`,`id_fac_empresa_pk`,`id_empresa_pk`),
  ADD KEY `Ref33253` (`id_cuenta_pagar_pk`),
  ADD KEY `Ref94254` (`id_empresa_pk`,`id_fac_empresa_pk`,`serie`),
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
  ADD KEY `Ref26443` (`id_evento_pk`),
  ADD KEY `Ref33259` (`id_cuenta_pagar_pk`);

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
  ADD KEY `Ref125172` (`id_factura_compra_pk`);

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
-- Indices de la tabla `impuestos_ley`
--
ALTER TABLE `impuestos_ley`
  ADD PRIMARY KEY (`id_detalle_impuesto_pk`),
  ADD KEY `Ref238451` (`id_empleados_pk`);

--
-- Indices de la tabla `invitado`
--
ALTER TABLE `invitado`
  ADD PRIMARY KEY (`id_invitado_pk`),
  ADD KEY `Ref2621` (`id_evento_pk`);

--
-- Indices de la tabla `linea`
--
ALTER TABLE `linea`
  ADD PRIMARY KEY (`id_linea_pk`),
  ADD KEY `Ref9430` (`id_categoria_pk`);

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
  ADD KEY `Ref130183` (`no_doc`,`empresa`,`serie_doc`,`tipo_doc`),
  ADD KEY `Ref5210` (`id_bodega_pk`),
  ADD KEY `Ref1289` (`id_categoria_pk`,`id_bien_pk`),
  ADD KEY `Refencabezado_documento183` (`no_doc`,`serie_doc`,`tipo_doc`,`empresa`),
  ADD KEY `Refbien289` (`id_bien_pk`,`id_categoria_pk`);

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
  ADD KEY `Ref181` (`id_bien_pk`,`id_categoria_pk`);

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
  ADD PRIMARY KEY (`id_pedido_compra_pk`),
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
  ADD KEY `Ref94252` (`id_empresa_pk`,`id_fac_empresa_pk`,`serie`);

--
-- Indices de la tabla `percepcion`
--
ALTER TABLE `percepcion`
  ADD PRIMARY KEY (`id_percepcion_pk`);

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
  ADD KEY `Ref266476` (`id_aplicacion`),
  ADD KEY `Ref265477` (`id_perfil`);

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
  ADD KEY `Ref152459` (`id_tprecio_pk`),
  ADD KEY `Ref1235` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Ref182313` (`id_tamaniop_pk`);

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
-- Indices de la tabla `tipo_credito`
--
ALTER TABLE `tipo_credito`
  ADD PRIMARY KEY (`id_tipocredito_pk`);

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
-- Indices de la tabla `tipo_habitacion`
--
ALTER TABLE `tipo_habitacion`
  ADD PRIMARY KEY (`id_tipo_pk`);

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
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`usuario`),
  ADD KEY `Ref238480` (`id_empleados_pk`);

--
-- Indices de la tabla `usuario_privilegios`
--
ALTER TABLE `usuario_privilegios`
  ADD PRIMARY KEY (`usuario`,`id_aplicacion`),
  ADD KEY `Ref265475` (`id_perfil`),
  ADD KEY `Ref264478` (`usuario`),
  ADD KEY `Ref266479` (`id_aplicacion`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  MODIFY `id_aplicacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16102;
--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `id_bit` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16137;
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
  MODIFY `id_cliente_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `compra`
--
ALTER TABLE `compra`
  MODIFY `id_factura_compra_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `com_venta`
--
ALTER TABLE `com_venta`
  MODIFY `id_com_venta_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT de la tabla `consultaalmacenada`
--
ALTER TABLE `consultaalmacenada`
  MODIFY `id_consulta_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `contribuyente`
--
ALTER TABLE `contribuyente`
  MODIFY `id_contribuyente_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `convertidora`
--
ALTER TABLE `convertidora`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cuenta_bancaria`
--
ALTER TABLE `cuenta_bancaria`
  MODIFY `id_cuenta_bancaria_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `cuenta_corriente_por_pagar`
--
ALTER TABLE `cuenta_corriente_por_pagar`
  MODIFY `id_cuenta_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `deducciones`
--
ALTER TABLE `deducciones`
  MODIFY `id_presamo_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_compra`
--
ALTER TABLE `detalle_compra`
  MODIFY `id_detalle_compra_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_com_ventas`
--
ALTER TABLE `detalle_com_ventas`
  MODIFY `id_detalle_com_ventas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
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
-- AUTO_INCREMENT de la tabla `detalle_dev`
--
ALTER TABLE `detalle_dev`
  MODIFY `id_detalle_dev` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_devolucion_compra`
--
ALTER TABLE `detalle_devolucion_compra`
  MODIFY `id_detalle_devolucion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_disp_banc`
--
ALTER TABLE `detalle_disp_banc`
  MODIFY `id_detalle_db_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_documento`
--
ALTER TABLE `detalle_documento`
  MODIFY `id_detalle_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_documentos`
--
ALTER TABLE `detalle_documentos`
  MODIFY `id_detalle_cv_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `detalle_folio`
--
ALTER TABLE `detalle_folio`
  MODIFY `id_detalle_folio_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_nomina`
--
ALTER TABLE `detalle_nomina`
  MODIFY `id_dn` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  MODIFY `id_detalle` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_pedido_1`
--
ALTER TABLE `detalle_pedido_1`
  MODIFY `id_detalle_pedido_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_pedido_compra`
--
ALTER TABLE `detalle_pedido_compra`
  MODIFY `id_detalle_pedido_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_planilla_igss`
--
ALTER TABLE `detalle_planilla_igss`
  MODIFY `id_detalle_pigss` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
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
  MODIFY `id_deuda` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `devengos`
--
ALTER TABLE `devengos`
  MODIFY `id_devengos_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `devolucion`
--
ALTER TABLE `devolucion`
  MODIFY `id_dev` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `devolucion_compra`
--
ALTER TABLE `devolucion_compra`
  MODIFY `id_devolucion_compra_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `disponibilidad_bancaria`
--
ALTER TABLE `disponibilidad_bancaria`
  MODIFY `id_disponibilidad_bancaria` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `documento`
--
ALTER TABLE `documento`
  MODIFY `id_documento_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `doc_impuesto`
--
ALTER TABLE `doc_impuesto`
  MODIFY `id_doc_imp` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `id_empleados_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `empresa`
--
ALTER TABLE `empresa`
  MODIFY `id_empresa_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
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
-- AUTO_INCREMENT de la tabla `folio`
--
ALTER TABLE `folio`
  MODIFY `id_cuenta_pagar_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `folio_bien`
--
ALTER TABLE `folio_bien`
  MODIFY `id_folio_bien_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `folio_habitacion`
--
ALTER TABLE `folio_habitacion`
  MODIFY `id_folio_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `folio_promocion`
--
ALTER TABLE `folio_promocion`
  MODIFY `id_folio_promocion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `folio_salon`
--
ALTER TABLE `folio_salon`
  MODIFY `id_folio_salon_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `forma_pago`
--
ALTER TABLE `forma_pago`
  MODIFY `id_forma_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `gastos_importacion`
--
ALTER TABLE `gastos_importacion`
  MODIFY `id_importacion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `habitacion`
--
ALTER TABLE `habitacion`
  MODIFY `id_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `impuesto`
--
ALTER TABLE `impuesto`
  MODIFY `id_impuesto_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `invitado`
--
ALTER TABLE `invitado`
  MODIFY `id_invitado_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `linea`
--
ALTER TABLE `linea`
  MODIFY `id_linea_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `id_marca_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
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
-- AUTO_INCREMENT de la tabla `nomina`
--
ALTER TABLE `nomina`
  MODIFY `id_nomina_pk` int(11) NOT NULL AUTO_INCREMENT;
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
  MODIFY `id_parametros_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `pedido`
--
ALTER TABLE `pedido`
  MODIFY `id_pedido_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `pedido_compra`
--
ALTER TABLE `pedido_compra`
  MODIFY `id_pedido_compra_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `planilla_igss`
--
ALTER TABLE `planilla_igss`
  MODIFY `id_planilla_igss_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `precio`
--
ALTER TABLE `precio`
  MODIFY `id_precio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
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
  MODIFY `id_promocion_pk` int(11) NOT NULL AUTO_INCREMENT;
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
  MODIFY `id_reserhabit_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `salon`
--
ALTER TABLE `salon`
  MODIFY `id_salon_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipo_credito`
--
ALTER TABLE `tipo_credito`
  MODIFY `id_tipocredito_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipo_documento`
--
ALTER TABLE `tipo_documento`
  MODIFY `id_tipo_documento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `tipo_doc_1`
--
ALTER TABLE `tipo_doc_1`
  MODIFY `id_doc` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipo_habitacion`
--
ALTER TABLE `tipo_habitacion`
  MODIFY `id_tipo_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipo_moneda`
--
ALTER TABLE `tipo_moneda`
  MODIFY `id_moneda` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipo_precio`
--
ALTER TABLE `tipo_precio`
  MODIFY `id_tprecio_pk` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

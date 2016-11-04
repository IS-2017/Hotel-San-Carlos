-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-11-2016 a las 00:56:02
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
(16100, '17:50:56', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10'),
(16101, '17:55:34', '2016-11-03', 'usuariodbs', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.10');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodega`
--

CREATE TABLE `bodega` (
  `id_bodega_pk` int(11) NOT NULL,
  `ubicacion` char(40) DEFAULT NULL,
  `nombre_bodega` char(40) DEFAULT NULL,
  `tamaño` char(50) DEFAULT NULL,
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
-- Estructura de tabla para la tabla `cargo_empleado`
--

CREATE TABLE `cargo_empleado` (
  `id_cargo_emp_pk` int(10) NOT NULL,
  `estado` char(10) DEFAULT 'ACTIVO',
  `cargo` char(25) DEFAULT NULL,
  `porcentaje_comision` decimal(10,0) DEFAULT NULL
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
  `estado` char(15) DEFAULT NULL,
  `id_empleados_pk` int(11) DEFAULT NULL
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
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `com_venta`
--

INSERT INTO `com_venta` (`id_com_venta_pk`, `id_empleados_pk`, `estado`, `total_venta`, `porsentaje_comision`, `fecha`, `total_comision`, `id_fac_empresa_pk`, `id_empresa_pk`, `serie`) VALUES
(16, 1, 'ACTIVO', '1600.00', '10.00', '2016-11-02', '160.00', 2, 1, ''),
(15, 1, 'ACTIVO', '900.00', '7.00', '2016-11-02', '160.00', 2, 1, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conciliaciones`
--

CREATE TABLE `conciliaciones` (
  `id_conciliacion_pk` int(11) NOT NULL,
  `id_documento_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `estado` char(10) DEFAULT 'ACTIVO'
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
(1, 'ACTIVO', 1, 'CITIBANK', '255642-4', '2500.00', '5460.00'),
(2, 'ACTIVO', 1, 'BANCO INDUSTRIAL', '5645198-8', '6548.00', '6546.00'),
(3, 'ACTIVO', 1, 'G&T CONTINENTAL', '5649846-9', '56100.00', '65462.20');

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
  `detalle` varchar(100) DEFAULT NULL,
  `debe` decimal(10,2) DEFAULT NULL,
  `haber` decimal(10,2) DEFAULT NULL,
  `fecha` date NOT NULL,
  `id_documento_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_documentos`
--

INSERT INTO `detalle_documentos` (`id_detalle_cv_pk`, `estado`, `nombre_cuenta`, `detalle`, `debe`, `haber`, `fecha`, `id_documento_pk`) VALUES
(1, 'ACTIVO', 'daniel', 'escritorios', '2300.00', '0.00', '2016-11-02', 1),
(2, 'ACTIVO', 'daniel', 'sillas', '3100.00', '0.00', '2016-11-02', 1);

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
  `total_devengos` decimal(10,2) DEFAULT NULL,
  `total_deduccion` decimal(10,2) DEFAULT NULL,
  `sueldo_liquido` decimal(10,2) DEFAULT NULL,
  `id_percepcion_pk` int(11) NOT NULL,
  `id_detalle_impuesto_pk` int(11) NOT NULL,
  `id_detalle_pres_pk` int(11) NOT NULL
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
  `igss_pagar` decimal(10,2) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_planilla_igss`
--

INSERT INTO `detalle_planilla_igss` (`id_detalle_pigss`, `estado`, `id_planilla_igss_pk`, `id_empleados_pk`, `sueldo_base`, `igss_pagar`) VALUES
(1, 'ACTIVO', 1, 1, '5000.00', '775.00'),
(2, 'ACTIVO', 1, 1, '5000.00', '775.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_prestacion`
--

CREATE TABLE `detalle_prestacion` (
  `id_detalle_pres_pk` int(11) NOT NULL,
  `porcentaje` decimal(10,2) DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `id_devengos_pk` int(11) NOT NULL,
  `id_presamo_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `id_detalle_impuesto_pk` int(11) NOT NULL
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
  `id_detalle_impuesto_pk` int(11) NOT NULL,
  `id_com_venta_pk` int(11) NOT NULL
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
  `telefono` char(15) DEFAULT NULL,
  `genero` char(10) DEFAULT NULL,
  `sueldo` int(11) DEFAULT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `disponibilidad` char(30) DEFAULT NULL,
  `foto_empleado` varchar(200) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_cargo_emp_pk` char(10) NOT NULL,
  `id_jornada_tra_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`id_empleados_pk`, `nombre`, `fecha_nacimiento`, `edad`, `dpi`, `nacionalidad`, `estado_civil`, `no_afiliacion_igss`, `fecha_ingreso`, `fecha_egreso`, `direccion`, `cargo`, `telefono`, `genero`, `sueldo`, `estado`, `disponibilidad`, `foto_empleado`, `id_empresa_pk`, `id_cargo_emp_pk`, `id_jornada_tra_pk`) VALUES
(1, 'Daniel', '2016-11-08', '18', '215165412', 'GT', 'S', 'AFILIADO', '2016-11-07', '2016-11-16', '12VS', 'VENDEDOR', '12312', 'M', 5000, 'ACTIVO', NULL, NULL, 1, '1', 1);

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
(1, 'hotel1', 'zona1', 'guatemala', '5', '5584-8', 'hotel1@hotel.com', '24556958', 'Activo'),
(2, 'hotel2', 'zona5', 'guatemala', '5', '6546415-8', 'hotel2@hotel2.com', '5658498', NULL);

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
  `hora_entrega` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
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
  `id_empleados_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
-- Estructura de tabla para la tabla `jornada_trabajo`
--

CREATE TABLE `jornada_trabajo` (
  `id_jornada_tra_pk` int(11) NOT NULL,
  `jornada` char(25) DEFAULT NULL,
  `horas_trabajo` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT 'ACTIVO'
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

--
-- Volcado de datos para la tabla `nomina`
--

INSERT INTO `nomina` (`id_nomina_pk`, `nombre_nomina`, `estado`, `fecha_inicio_pago`, `fecha_de_corte`, `id_empresa_pk`) VALUES
(1, 'nomina1', 'ACTIVO', '2016-11-03', '2016-11-11', 1);

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
  `estado` varchar(25) DEFAULT 'ACTIVO'
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
  `estado` varchar(10) DEFAULT 'ACTIVO',
  `porcentaje_igss` decimal(10,2) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `planilla_igss`
--

INSERT INTO `planilla_igss` (`id_planilla_igss_pk`, `estado`, `porcentaje_igss`, `fecha`, `id_empresa_pk`) VALUES
(1, 'ACTIVO', '4.83', '2016-11-15', 1);

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
  `hora_produccion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
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
(1, 'Deposito', 'documento para ingreso de dinero a hotel  san carlos', 'ACTIVO'),
(2, 'Cheque', 'Documento para ingreso y egreso de dinero a hotel san carlos', 'ACTIVO'),
(3, 'Nota de credito', 'Nota para ingresar acreditaciones en hotel san carlos', 'ACTIVO'),
(4, 'Nota de Debito', 'Nota para ingresar todos los debitos en las cuentas de hotel san carlos', 'Activo');

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
  `estado` char(10) DEFAULT 'ACTIVO',
  `id_empresa_pk` int(11) DEFAULT NULL,
  `id_empleados_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`usuario`, `contrasenia`, `fecha_creacion`, `estado`, `id_empresa_pk`, `id_empleados_pk`) VALUES
('usuariodbs', 'aABvAGwAYQA=', '2016-11-01', 'ACTIVO', 1, 1);

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
('usuariodbs', 16101, 1, 1, 1, 1, 0);

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
  ADD KEY `Refempleado401` (`id_empleados_pk`);

--
-- Indices de la tabla `bien`
--
ALTER TABLE `bien`
  ADD PRIMARY KEY (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Refmedida404` (`id_medida_pk`),
  ADD KEY `Refmarca425` (`id_marca_pk`),
  ADD KEY `Reflinea431` (`id_linea_pk`),
  ADD KEY `Refcategoria8` (`id_categoria_pk`);

--
-- Indices de la tabla `bien_habitacion`
--
ALTER TABLE `bien_habitacion`
  ADD PRIMARY KEY (`id_bien_pk`,`id_habitacion_pk`,`id_categoria_pk`),
  ADD KEY `Refbien12` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Refhabitacion86` (`id_habitacion_pk`);

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
  ADD KEY `Refempresa432` (`id_empresa_pk`);

--
-- Indices de la tabla `buzon`
--
ALTER TABLE `buzon`
  ADD PRIMARY KEY (`id_buzon_pk`),
  ADD KEY `Refempresa226` (`id_empresa_pk`),
  ADD KEY `Refcliente20` (`id_cliente_pk`);

--
-- Indices de la tabla `cargo_empleado`
--
ALTER TABLE `cargo_empleado`
  ADD PRIMARY KEY (`id_cargo_emp_pk`);

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
  ADD KEY `Reftipo_credito238` (`id_tipocredito_pk`),
  ADD KEY `Refcontribuyente255` (`id_contribuyente_pk`),
  ADD KEY `Refempleado484` (`id_empleados_pk`),
  ADD KEY `Reftipo_precio316` (`id_tprecio_pk`);

--
-- Indices de la tabla `compra`
--
ALTER TABLE `compra`
  ADD PRIMARY KEY (`id_factura_compra_pk`),
  ADD KEY `Refpedido_compra174` (`id_pedido_compra_pk`),
  ADD KEY `Refcuenta_corriente_por_pagar176` (`id_cuenta_pk`,`id_proveedor_pk`),
  ADD KEY `Refforma_pago223` (`id_forma_pk`),
  ADD KEY `Refempresa464` (`id_empresa_pk`);

--
-- Indices de la tabla `com_venta`
--
ALTER TABLE `com_venta`
  ADD PRIMARY KEY (`id_com_venta_pk`,`id_empleados_pk`),
  ADD KEY `Reffactura452` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Refempleado453` (`id_empleados_pk`);

--
-- Indices de la tabla `conciliaciones`
--
ALTER TABLE `conciliaciones`
  ADD PRIMARY KEY (`id_conciliacion_pk`,`id_documento_pk`),
  ADD KEY `Refdocumento373` (`id_documento_pk`);

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
  ADD KEY `Refcliente181` (`id_cliente_pk`);

--
-- Indices de la tabla `cotizacion_bien`
--
ALTER TABLE `cotizacion_bien`
  ADD PRIMARY KEY (`id_precio`,`id_detallecot_pk`),
  ADD KEY `Refdetalle_cotizacion417` (`id_detallecot_pk`);

--
-- Indices de la tabla `cotizacion_paquete`
--
ALTER TABLE `cotizacion_paquete`
  ADD PRIMARY KEY (`id_promocion_pk`,`id_detallecot_pk`),
  ADD KEY `Refdetalle_cotizacion416` (`id_detallecot_pk`);

--
-- Indices de la tabla `cuenta_bancaria`
--
ALTER TABLE `cuenta_bancaria`
  ADD PRIMARY KEY (`id_cuenta_bancaria_pk`),
  ADD KEY `Refempresa381` (`id_empresa_pk`);

--
-- Indices de la tabla `cuenta_corriente_por_pagar`
--
ALTER TABLE `cuenta_corriente_por_pagar`
  ADD PRIMARY KEY (`id_cuenta_pk`,`id_proveedor_pk`),
  ADD KEY `Refproveedor170` (`id_proveedor_pk`);

--
-- Indices de la tabla `deducciones`
--
ALTER TABLE `deducciones`
  ADD PRIMARY KEY (`id_presamo_pk`),
  ADD KEY `Refimpuestos_ley449` (`id_detalle_impuesto_pk`),
  ADD KEY `Refplanilla_igss391` (`id_planilla_igss_pk`),
  ADD KEY `Refempleado392` (`id_empleados_pk`);

--
-- Indices de la tabla `detalle_compra`
--
ALTER TABLE `detalle_compra`
  ADD PRIMARY KEY (`id_detalle_compra_pk`),
  ADD KEY `Refcompra442` (`id_factura_compra_pk`),
  ADD KEY `Refbien466` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_cotizacion`
--
ALTER TABLE `detalle_cotizacion`
  ADD PRIMARY KEY (`id_detallecot_pk`),
  ADD KEY `Refcotizacion_bien408` (`id_detallecot_pk`,`id_precio`),
  ADD KEY `Refcotizacion_paquete409` (`id_detallecot_pk`,`id_promocion_pk`),
  ADD KEY `Refcotizacion415` (`id_cotizacion_pk`),
  ADD KEY `Refempresa461` (`id_empresa_pk`);

--
-- Indices de la tabla `detalle_cuenta_por_pagar`
--
ALTER TABLE `detalle_cuenta_por_pagar`
  ADD PRIMARY KEY (`detalle_cuenta_por_pagar_pk`),
  ADD KEY `Refcuenta_corriente_por_pagar293` (`id_cuenta_pk`,`id_proveedor_pk`);

--
-- Indices de la tabla `detalle_dev`
--
ALTER TABLE `detalle_dev`
  ADD PRIMARY KEY (`id_detalle_dev`),
  ADD KEY `Refdevolucion456` (`id_dev`,`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Refbien458` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_devolucion_compra`
--
ALTER TABLE `detalle_devolucion_compra`
  ADD PRIMARY KEY (`id_detalle_devolucion_pk`),
  ADD KEY `Refbien467` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Refdevolucion_compra481` (`id_devolucion_compra_pk`);

--
-- Indices de la tabla `detalle_disp_banc`
--
ALTER TABLE `detalle_disp_banc`
  ADD PRIMARY KEY (`id_detalle_db_pk`),
  ADD KEY `Refdisponibilidad_bancaria379` (`id_disponibilidad_bancaria`),
  ADD KEY `Refdocumento380` (`id_documento_pk`);

--
-- Indices de la tabla `detalle_documento`
--
ALTER TABLE `detalle_documento`
  ADD PRIMARY KEY (`id_detalle_pk`),
  ADD KEY `Refbien185` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Refencabezado_documento187` (`no_doc`,`serie_doc`,`tipo_doc`,`empresa`);

--
-- Indices de la tabla `detalle_documentos`
--
ALTER TABLE `detalle_documentos`
  ADD PRIMARY KEY (`id_detalle_cv_pk`),
  ADD KEY `Refdocumento374` (`id_documento_pk`);

--
-- Indices de la tabla `detalle_folio`
--
ALTER TABLE `detalle_folio`
  ADD PRIMARY KEY (`id_detalle_folio_pk`),
  ADD KEY `Reffolio_bien433` (`id_folio_bien_pk`),
  ADD KEY `Reffolio_salon434` (`id_folio_salon_pk`),
  ADD KEY `Reffolio_habitacion435` (`id_folio_habitacion_pk`),
  ADD KEY `Reffolio_promocion436` (`id_folio_promocion_pk`),
  ADD KEY `Reffolio437` (`id_cuenta_pagar_pk`);

--
-- Indices de la tabla `detalle_muestreo`
--
ALTER TABLE `detalle_muestreo`
  ADD PRIMARY KEY (`id_encabezado`),
  ADD KEY `Refproducto_bodega290` (`id_bien_pk`,`id_bodega_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_nomina`
--
ALTER TABLE `detalle_nomina`
  ADD PRIMARY KEY (`id_dn`),
  ADD KEY `Refdevengos397` (`id_devengos_pk`),
  ADD KEY `Refpercepcion446` (`id_percepcion_pk`),
  ADD KEY `Refimpuestos_ley447` (`id_detalle_impuesto_pk`),
  ADD KEY `Refdetalle_prestacion493` (`id_detalle_pres_pk`),
  ADD KEY `Refempleado388` (`id_empleados_pk`),
  ADD KEY `Refnomina389` (`id_nomina_pk`),
  ADD KEY `Refdeducciones390` (`id_presamo_pk`);

--
-- Indices de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  ADD PRIMARY KEY (`id_detalle`),
  ADD KEY `Refprecio403` (`id_precio`),
  ADD KEY `Refpedido429` (`id_pedido_pk`);

--
-- Indices de la tabla `detalle_pedido_1`
--
ALTER TABLE `detalle_pedido_1`
  ADD PRIMARY KEY (`id_detalle_pedido_pk`,`id_encabezado_pedido_pk`),
  ADD KEY `Refmenu296` (`id_menu_pk`,`correlativo`),
  ADD KEY `Refencabezado_pedido297` (`id_encabezado_pedido_pk`);

--
-- Indices de la tabla `detalle_pedido_compra`
--
ALTER TABLE `detalle_pedido_compra`
  ADD PRIMARY KEY (`id_detalle_pedido_pk`),
  ADD KEY `Refpedido_compra441` (`id_pedido_compra_pk`),
  ADD KEY `Refbien465` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_planilla_igss`
--
ALTER TABLE `detalle_planilla_igss`
  ADD PRIMARY KEY (`id_detalle_pigss`),
  ADD KEY `Refplanilla_igss393` (`id_planilla_igss_pk`),
  ADD KEY `Refempleado394` (`id_empleados_pk`);

--
-- Indices de la tabla `detalle_prestacion`
--
ALTER TABLE `detalle_prestacion`
  ADD PRIMARY KEY (`id_detalle_pres_pk`),
  ADD KEY `Refdevengos489` (`id_devengos_pk`),
  ADD KEY `Refdeducciones490` (`id_presamo_pk`),
  ADD KEY `Refempleado491` (`id_empleados_pk`),
  ADD KEY `Refimpuestos_ley492` (`id_detalle_impuesto_pk`);

--
-- Indices de la tabla `detalle_produccion`
--
ALTER TABLE `detalle_produccion`
  ADD PRIMARY KEY (`correlativo`,`id_produccion_pk`),
  ADD KEY `Refdetalle_pedido_1299` (`id_detalle_pedido_pk`,`id_encabezado_pedido_pk`),
  ADD KEY `Refbien310` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_receta_mp`
--
ALTER TABLE `detalle_receta_mp`
  ADD PRIMARY KEY (`correlativo`,`id_receta_pk`),
  ADD KEY `Refproceso301` (`id_proceso_pk`),
  ADD KEY `Refmedida302` (`id_medida_pk`),
  ADD KEY `Refreceta304` (`id_receta_pk`),
  ADD KEY `Refbien311` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `detalle_requisicion`
--
ALTER TABLE `detalle_requisicion`
  ADD PRIMARY KEY (`id_detalle_requisicion_pk`),
  ADD KEY `Refrequisicion440` (`id_requisicion_pk`),
  ADD KEY `Refbien220` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `deuda`
--
ALTER TABLE `deuda`
  ADD PRIMARY KEY (`id_deuda`),
  ADD KEY `Refcliente230` (`id_cliente_pk`),
  ADD KEY `Reffactura231` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Refempresa232` (`id_empresa_pk`);

--
-- Indices de la tabla `devengos`
--
ALTER TABLE `devengos`
  ADD PRIMARY KEY (`id_devengos_pk`),
  ADD KEY `Refplanilla_igss448` (`id_planilla_igss_pk`),
  ADD KEY `Refimpuestos_ley450` (`id_detalle_impuesto_pk`),
  ADD KEY `Refcom_venta485` (`id_empleados_pk`,`id_com_venta_pk`);

--
-- Indices de la tabla `devolucion`
--
ALTER TABLE `devolucion`
  ADD PRIMARY KEY (`id_dev`,`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Reffactura454` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Refcliente455` (`id_cliente_pk`);

--
-- Indices de la tabla `devolucion_compra`
--
ALTER TABLE `devolucion_compra`
  ADD PRIMARY KEY (`id_devolucion_compra_pk`),
  ADD KEY `Refbodega469` (`id_bodega_pk`),
  ADD KEY `Refcompra473` (`id_factura_compra_pk`),
  ADD KEY `Refproveedor474` (`id_proveedor_pk`);

--
-- Indices de la tabla `disponibilidad_bancaria`
--
ALTER TABLE `disponibilidad_bancaria`
  ADD PRIMARY KEY (`id_disponibilidad_bancaria`),
  ADD KEY `Refcuenta_bancaria377` (`id_cuenta_bancaria_pk`),
  ADD KEY `Reftipo_documento378` (`id_tipo_documento`);

--
-- Indices de la tabla `documento`
--
ALTER TABLE `documento`
  ADD PRIMARY KEY (`id_documento_pk`),
  ADD KEY `Refcuenta_bancaria375` (`id_cuenta_bancaria_pk`),
  ADD KEY `Reftipo_documento376` (`id_tipo_documento`),
  ADD KEY `Refcuenta_corriente_por_pagar385` (`id_cuenta_pk`,`id_proveedor_pk`);

--
-- Indices de la tabla `doc_impuesto`
--
ALTER TABLE `doc_impuesto`
  ADD PRIMARY KEY (`id_doc_imp`),
  ADD KEY `Refimpuesto463` (`id_impuesto_pk`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`id_empleados_pk`),
  ADD KEY `Refempresa398` (`id_empresa_pk`),
  ADD KEY `Refcargo_empleado487` (`id_cargo_emp_pk`),
  ADD KEY `Refjornada_trabajo488` (`id_jornada_tra_pk`);

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
  ADD KEY `Refcliente52` (`id_cliente_pk`),
  ADD KEY `Refsalon53` (`id_salon_pk`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Reftipo_moneda405` (`id_moneda`),
  ADD KEY `Refparametros_fac462` (`id_parametros_pk`),
  ADD KEY `Refempresa241` (`id_empresa_pk`),
  ADD KEY `Refimpuesto246` (`id_impuesto_pk`),
  ADD KEY `Refempleado483` (`id_empleados_pk`),
  ADD KEY `Refcliente126` (`id_cliente_pk`);

--
-- Indices de la tabla `factura documento`
--
ALTER TABLE `factura documento`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`id_documento_pk`,`serie`),
  ADD KEY `Reffactura383` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Refdocumento384` (`id_documento_pk`);

--
-- Indices de la tabla `factura_detalle`
--
ALTER TABLE `factura_detalle`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`id_precio`),
  ADD KEY `Refprecio402` (`id_precio`),
  ADD KEY `Refdetalle_folio439` (`id_detalle_folio_pk`),
  ADD KEY `Reffactura247` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Refempresa248` (`id_empresa_pk`);

--
-- Indices de la tabla `factura_pago`
--
ALTER TABLE `factura_pago`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_forma_pk`),
  ADD KEY `Reffactura127` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  ADD KEY `Refforma_pago128` (`id_forma_pk`);

--
-- Indices de la tabla `folio`
--
ALTER TABLE `folio`
  ADD PRIMARY KEY (`id_cuenta_pagar_pk`),
  ADD KEY `Refcliente167` (`id_cliente_pk`);

--
-- Indices de la tabla `folio_bien`
--
ALTER TABLE `folio_bien`
  ADD PRIMARY KEY (`id_folio_bien_pk`),
  ADD KEY `Reffolio261` (`id_cuenta_pagar_pk`),
  ADD KEY `Refbien262` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `folio_factura`
--
ALTER TABLE `folio_factura`
  ADD PRIMARY KEY (`id_cuenta_pagar_pk`,`id_fac_empresa_pk`,`id_empresa_pk`),
  ADD KEY `Reffactura254` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`);

--
-- Indices de la tabla `folio_habitacion`
--
ALTER TABLE `folio_habitacion`
  ADD PRIMARY KEY (`id_folio_habitacion_pk`),
  ADD KEY `Refreservacion_habitacion424` (`id_reserhabit_pk`),
  ADD KEY `Reffolio257` (`id_cuenta_pagar_pk`);

--
-- Indices de la tabla `folio_promocion`
--
ALTER TABLE `folio_promocion`
  ADD PRIMARY KEY (`id_folio_promocion_pk`),
  ADD KEY `Reffolio263` (`id_cuenta_pagar_pk`),
  ADD KEY `Refpromocion264` (`id_promocion_pk`);

--
-- Indices de la tabla `folio_salon`
--
ALTER TABLE `folio_salon`
  ADD PRIMARY KEY (`id_folio_salon_pk`),
  ADD KEY `Refevento443` (`id_evento_pk`),
  ADD KEY `Reffolio259` (`id_cuenta_pagar_pk`);

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
  ADD KEY `Refcompra172` (`id_factura_compra_pk`);

--
-- Indices de la tabla `habitacion`
--
ALTER TABLE `habitacion`
  ADD PRIMARY KEY (`id_habitacion_pk`),
  ADD KEY `Reftipo_habitacion44` (`id_tipo_pk`),
  ADD KEY `Refempresa161` (`id_empresa_pk`);

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
  ADD KEY `Refempleado451` (`id_empleados_pk`);

--
-- Indices de la tabla `invitado`
--
ALTER TABLE `invitado`
  ADD PRIMARY KEY (`id_invitado_pk`),
  ADD KEY `Refevento21` (`id_evento_pk`);

--
-- Indices de la tabla `jornada_trabajo`
--
ALTER TABLE `jornada_trabajo`
  ADD PRIMARY KEY (`id_jornada_tra_pk`);

--
-- Indices de la tabla `linea`
--
ALTER TABLE `linea`
  ADD PRIMARY KEY (`id_linea_pk`),
  ADD KEY `Refcategoria430` (`id_categoria_pk`);

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
  ADD KEY `Refreceta300` (`id_receta_pk`),
  ADD KEY `Refprecio308` (`id_precio`);

--
-- Indices de la tabla `movimiento_inventario`
--
ALTER TABLE `movimiento_inventario`
  ADD PRIMARY KEY (`id_movimiento_pk`),
  ADD KEY `Refencabezado_documento183` (`no_doc`,`serie_doc`,`tipo_doc`,`empresa`),
  ADD KEY `Refbodega210` (`id_bodega_pk`),
  ADD KEY `Refbien289` (`id_bien_pk`,`id_categoria_pk`);

--
-- Indices de la tabla `nomina`
--
ALTER TABLE `nomina`
  ADD PRIMARY KEY (`id_nomina_pk`),
  ADD KEY `Refempresa400` (`id_empresa_pk`);

--
-- Indices de la tabla `obj_perdido`
--
ALTER TABLE `obj_perdido`
  ADD PRIMARY KEY (`id_obj_perdido_pk`),
  ADD KEY `Refempresa256` (`id_empresa_pk`);

--
-- Indices de la tabla `operacion`
--
ALTER TABLE `operacion`
  ADD PRIMARY KEY (`id_operacion`),
  ADD KEY `Reftipo_doc_1228` (`id_doc`),
  ADD KEY `Refdeuda229` (`id_deuda`);

--
-- Indices de la tabla `paquetes_eventos`
--
ALTER TABLE `paquetes_eventos`
  ADD PRIMARY KEY (`id_paquetes_salon_pk`),
  ADD KEY `Refevento16` (`id_evento_pk`),
  ADD KEY `Refpromocion17` (`id_promocion_pk`);

--
-- Indices de la tabla `paquetes_reservacion_habitacion`
--
ALTER TABLE `paquetes_reservacion_habitacion`
  ADD PRIMARY KEY (`id_paquetes_reservacion_habitacion_pk`),
  ADD KEY `Refpromocion18` (`id_promocion_pk`),
  ADD KEY `Refreservacion_habitacion19` (`id_reserhabit_pk`);

--
-- Indices de la tabla `paquete_inventario`
--
ALTER TABLE `paquete_inventario`
  ADD PRIMARY KEY (`id_paquete_inventario`),
  ADD KEY `Refpromocion80` (`id_promocion_pk`),
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
  ADD KEY `Refcliente426` (`id_cliente_pk`);

--
-- Indices de la tabla `pedido_compra`
--
ALTER TABLE `pedido_compra`
  ADD PRIMARY KEY (`id_pedido_compra_pk`),
  ADD KEY `Refproveedor175` (`id_proveedor_pk`),
  ADD KEY `Refrequisicion218` (`id_requisicion_pk`);

--
-- Indices de la tabla `pedido_cotizacion`
--
ALTER TABLE `pedido_cotizacion`
  ADD PRIMARY KEY (`id_cotizacion_pk`,`id_pedido_pk`),
  ADD KEY `Refpedido428` (`id_pedido_pk`);

--
-- Indices de la tabla `pedido_factura`
--
ALTER TABLE `pedido_factura`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`,`id_pedido_pk`),
  ADD KEY `Refpedido427` (`id_pedido_pk`);

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
  ADD KEY `Refperfil477` (`id_perfil`);

--
-- Indices de la tabla `planilla_igss`
--
ALTER TABLE `planilla_igss`
  ADD PRIMARY KEY (`id_planilla_igss_pk`),
  ADD KEY `Refempresa399` (`id_empresa_pk`);

--
-- Indices de la tabla `precio`
--
ALTER TABLE `precio`
  ADD PRIMARY KEY (`id_precio`),
  ADD KEY `Reftipo_precio459` (`id_tprecio_pk`),
  ADD KEY `Refbien235` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Reftamanio_porcion313` (`id_tamaniop_pk`);

--
-- Indices de la tabla `problema`
--
ALTER TABLE `problema`
  ADD PRIMARY KEY (`id_problema_pk`),
  ADD KEY `Refempresa169` (`id_empresa_pk`),
  ADD KEY `Refcliente168` (`id_cliente_pk`);

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
  ADD KEY `Refbien10` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Refbodega11` (`id_bodega_pk`);

--
-- Indices de la tabla `promocion`
--
ALTER TABLE `promocion`
  ADD PRIMARY KEY (`id_promocion_pk`),
  ADD KEY `Refbien195` (`id_bien_pk`,`id_categoria_pk`),
  ADD KEY `Refsalon163` (`id_salon_pk`),
  ADD KEY `Refhabitacion165` (`id_habitacion_pk`);

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
  ADD KEY `Refbodega217` (`id_bodega_pk`);

--
-- Indices de la tabla `reservacion_habitacion`
--
ALTER TABLE `reservacion_habitacion`
  ADD PRIMARY KEY (`id_reserhabit_pk`),
  ADD KEY `Refcliente46` (`id_cliente_pk`),
  ADD KEY `Refhabitacion47` (`id_habitacion_pk`);

--
-- Indices de la tabla `salon`
--
ALTER TABLE `salon`
  ADD PRIMARY KEY (`id_salon_pk`),
  ADD KEY `Refempresa162` (`id_empresa_pk`);

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
  ADD KEY `Refprecio314` (`id_precio`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`usuario`),
  ADD KEY `Refempleado480` (`id_empleados_pk`);

--
-- Indices de la tabla `usuario_privilegios`
--
ALTER TABLE `usuario_privilegios`
  ADD PRIMARY KEY (`usuario`,`id_aplicacion`),
  ADD KEY `Refperfil475` (`id_perfil`),
  ADD KEY `Refaplicacion479` (`id_aplicacion`);

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
  MODIFY `id_bit` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16102;
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
-- AUTO_INCREMENT de la tabla `cargo_empleado`
--
ALTER TABLE `cargo_empleado`
  MODIFY `id_cargo_emp_pk` int(10) NOT NULL AUTO_INCREMENT;
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
-- AUTO_INCREMENT de la tabla `conciliaciones`
--
ALTER TABLE `conciliaciones`
  MODIFY `id_conciliacion_pk` int(11) NOT NULL AUTO_INCREMENT;
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
  MODIFY `id_detalle_pigss` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `detalle_prestacion`
--
ALTER TABLE `detalle_prestacion`
  MODIFY `id_detalle_pres_pk` int(11) NOT NULL AUTO_INCREMENT;
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
  MODIFY `id_documento_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `doc_impuesto`
--
ALTER TABLE `doc_impuesto`
  MODIFY `id_doc_imp` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `id_empleados_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
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
-- AUTO_INCREMENT de la tabla `impuestos_ley`
--
ALTER TABLE `impuestos_ley`
  MODIFY `id_detalle_impuesto_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `invitado`
--
ALTER TABLE `invitado`
  MODIFY `id_invitado_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `jornada_trabajo`
--
ALTER TABLE `jornada_trabajo`
  MODIFY `id_jornada_tra_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `linea`
--
ALTER TABLE `linea`
  MODIFY `id_linea_pk` int(11) NOT NULL AUTO_INCREMENT;
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
-- AUTO_INCREMENT de la tabla `nomina`
--
ALTER TABLE `nomina`
  MODIFY `id_nomina_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
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
-- AUTO_INCREMENT de la tabla `percepcion`
--
ALTER TABLE `percepcion`
  MODIFY `id_percepcion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `planilla_igss`
--
ALTER TABLE `planilla_igss`
  MODIFY `id_planilla_igss_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `precio`
--
ALTER TABLE `precio`
  MODIFY `id_precio` int(11) NOT NULL AUTO_INCREMENT;
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

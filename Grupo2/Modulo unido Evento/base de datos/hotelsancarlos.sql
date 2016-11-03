-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 03, 2016 at 06:15 AM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hotelsancarlos`
--

-- --------------------------------------------------------

--
-- Table structure for table `asignacion_mo`
--

CREATE TABLE IF NOT EXISTS `asignacion_mo` (
  `id_produccion_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `cant_horas` float(8,0) DEFAULT NULL,
  PRIMARY KEY (`id_produccion_pk`,`id_empleados_pk`),
  KEY `Ref186306` (`id_produccion_pk`),
  KEY `Ref238401` (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `bien`
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
  `estado` char(15) DEFAULT NULL,
  `id_marca_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_categoria_pk`),
  KEY `Ref98` (`id_categoria_pk`),
  KEY `Ref189404` (`id_medida_pk`),
  KEY `Ref14425` (`id_marca_pk`),
  KEY `Ref249431` (`id_linea_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `bien_habitacion`
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
-- Table structure for table `bodega`
--

CREATE TABLE IF NOT EXISTS `bodega` (
  `id_bodega_pk` int(11) NOT NULL AUTO_INCREMENT,
  `ubicacion` char(40) DEFAULT NULL,
  `nombre_bodega` char(40) DEFAULT NULL,
  `tamaño` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bodega_pk`),
  KEY `Ref17432` (`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `buzon`
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
-- Table structure for table `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `id_categoria_pk` char(18) NOT NULL,
  `tipo_categoria` char(25) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `id_cliente_pk` int(11) NOT NULL AUTO_INCREMENT,
  `correo` varchar(50) DEFAULT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `dpi` int(20) DEFAULT NULL,
  `nit` varchar(10) NOT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `id_tipocredito_pk` int(11) DEFAULT NULL,
  `id_contribuyente_pk` int(11) DEFAULT NULL,
  `id_tprecio_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_cliente_pk`),
  KEY `Ref153238` (`id_tipocredito_pk`),
  KEY `Ref159255` (`id_contribuyente_pk`),
  KEY `Ref152316` (`id_tprecio_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` (`id_cliente_pk`, `correo`, `nombre`, `apellido`, `dpi`, `nit`, `telefono`, `direccion`, `fecha_nacimiento`, `id_tipocredito_pk`, `id_contribuyente_pk`, `id_tprecio_pk`, `estado`) VALUES
(1, 'robert@gmail.com', 'Roberto', 'Portillo', 42654897, '456789', '49887799', 'zona 18', '2014-07-23', 1, 1, 1, 'Activo'),
(2, 'rodrigo@gmail.com', 'Rodrigo', 'Sifontes', 56788945, '45267889', '2255788542', 'zona 17', '2016-10-02', 2, 2, 2, 'ACTIVO');

-- --------------------------------------------------------

--
-- Table structure for table `compra`
--

CREATE TABLE IF NOT EXISTS `compra` (
  `id_factura_pk` int(11) NOT NULL,
  `id_pedido_compra_pk` int(11) NOT NULL,
  `serie_factura` char(15) DEFAULT NULL,
  `fecha_recibida` date DEFAULT NULL,
  `encargado` char(20) DEFAULT NULL,
  `total` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `id_forma_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_factura_pk`),
  KEY `Ref129174` (`id_pedido_compra_pk`),
  KEY `Ref123176` (`id_proveedor_pk`,`id_cuenta_pk`),
  KEY `Ref99223` (`id_forma_pk`),
  KEY `Refcuenta_corriente_por_pagar176` (`id_cuenta_pk`,`id_proveedor_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `com_venta`
--

CREATE TABLE IF NOT EXISTS `com_venta` (
  `id_com_venta_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `total_venta` decimal(10,2) DEFAULT NULL,
  `porsentaje_comision` decimal(10,2) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `total_comision` date DEFAULT NULL,
  `id_devengos_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_com_venta_pk`),
  KEY `Ref242387` (`id_devengos_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `conciliaciones`
--

CREATE TABLE IF NOT EXISTS `conciliaciones` (
  `id_conciliacion_pk` int(11) NOT NULL,
  `id_documento_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_conciliacion_pk`,`id_documento_pk`),
  KEY `Ref234373` (`id_documento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `consultaalmacenada`
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
-- Table structure for table `contribuyente`
--

CREATE TABLE IF NOT EXISTS `contribuyente` (
  `id_contribuyente_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `nit` varchar(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_contribuyente_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `convertidora`
--

CREATE TABLE IF NOT EXISTS `convertidora` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `valor` float(8,0) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `cotizacion`
--

CREATE TABLE IF NOT EXISTS `cotizacion` (
  `id_cotizacion_pk` int(11) NOT NULL,
  `nombre_cot` varchar(50) DEFAULT NULL,
  `epllido_cot` varchar(50) DEFAULT NULL,
  `nit_cot` varchar(50) DEFAULT NULL,
  `telefono_cot` varchar(15) DEFAULT NULL,
  `direccion_cot` varchar(50) DEFAULT NULL,
  `estado-cot` varchar(100) NOT NULL,
  `id_cliente_pk` int(11) NOT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_cotizacion_pk`),
  KEY `Ref15181` (`id_cliente_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cotizacion_bien`
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
-- Table structure for table `cotizacion_paquete`
--

CREATE TABLE IF NOT EXISTS `cotizacion_paquete` (
  `id_promocion_pk` int(11) NOT NULL,
  `id_detallecot_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_promocion_pk`,`id_detallecot_pk`),
  KEY `Ref25124` (`id_promocion_pk`),
  KEY `Ref93416` (`id_detallecot_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cuenta_bancaria`
--

CREATE TABLE IF NOT EXISTS `cuenta_bancaria` (
  `id_cuenta_bancaria_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `nombre_banco` char(50) DEFAULT NULL,
  `no_cuenta` char(50) DEFAULT NULL,
  `saldo_libros` decimal(10,2) DEFAULT NULL,
  `saldo_bancarios` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_cuenta_bancaria_pk`),
  KEY `Ref17381` (`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cuenta_corriente_por_pagar`
--

CREATE TABLE IF NOT EXISTS `cuenta_corriente_por_pagar` (
  `id_cuenta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_proveedor_pk` int(11) NOT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_cuenta_pk`,`id_proveedor_pk`),
  KEY `Ref124170` (`id_proveedor_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `deducciones`
--

CREATE TABLE IF NOT EXISTS `deducciones` (
  `id_presamo_pk` int(11) NOT NULL,
  `nombre` char(100) DEFAULT NULL,
  `detalle` char(250) DEFAULT NULL,
  `cantidad_deduccion` decimal(10,2) DEFAULT NULL,
  `cuotas` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_planilla_igss_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_presamo_pk`),
  KEY `Ref237391` (`id_planilla_igss_pk`),
  KEY `Ref238392` (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_compra`
--

CREATE TABLE IF NOT EXISTS `detalle_compra` (
  `id_detalle_compra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_detalle_pedido_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio_compra` decimal(15,0) DEFAULT NULL,
  `subtotal_compra` decimal(15,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_factura_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_compra_pk`),
  KEY `Ref128292` (`id_detalle_pedido_pk`),
  KEY `Ref125442` (`id_factura_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_com_ventas`
--

CREATE TABLE IF NOT EXISTS `detalle_com_ventas` (
  `id_detalle_com_ventas` int(11) NOT NULL,
  `id_com_venta_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `total_ventas` decimal(10,2) DEFAULT NULL,
  `comision` decimal(10,2) DEFAULT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  PRIMARY KEY (`id_detalle_com_ventas`,`id_com_venta_pk`,`id_empleados_pk`),
  KEY `Ref241395` (`id_com_venta_pk`),
  KEY `Ref238396` (`id_empleados_pk`),
  KEY `Ref94414` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_cotizacion`
--

CREATE TABLE IF NOT EXISTS `detalle_cotizacion` (
  `id_detallecot_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad_detcot` int(11) DEFAULT NULL,
  `desc_servicio_detcot` varchar(150) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_cotizacion_pk` int(11) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_detallecot_pk`),
  KEY `Ref154408` (`id_detallecot_pk`,`id_precio`),
  KEY `Ref100409` (`id_promocion_pk`,`id_detallecot_pk`),
  KEY `Ref92415` (`id_cotizacion_pk`),
  KEY `Refcotizacion_paquete409` (`id_detallecot_pk`,`id_promocion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_cuenta_por_pagar`
--

CREATE TABLE IF NOT EXISTS `detalle_cuenta_por_pagar` (
  `detalle_cuenta_por_pagar_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` char(25) DEFAULT NULL,
  `comprobante` int(11) DEFAULT NULL,
  `debe` decimal(15,0) DEFAULT NULL,
  `haber` decimal(15,0) DEFAULT NULL,
  `saldo` decimal(15,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_cuenta_pk` int(11) DEFAULT NULL,
  `id_proveedor_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`detalle_cuenta_por_pagar_pk`),
  KEY `Ref123293` (`id_cuenta_pk`,`id_proveedor_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_disp_banc`
--

CREATE TABLE IF NOT EXISTS `detalle_disp_banc` (
  `id_detalle_db_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_disponibilidad_bancaria` int(11) NOT NULL,
  `id_documento_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_db_pk`),
  KEY `Ref230379` (`id_disponibilidad_bancaria`),
  KEY `Ref234380` (`id_documento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_documento`
--

CREATE TABLE IF NOT EXISTS `detalle_documento` (
  `id_detalle_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_bien_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `no_doc` int(11) DEFAULT NULL,
  `serie_doc` int(11) DEFAULT NULL,
  `id_tipo_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pk`),
  KEY `Ref1185` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Ref130187` (`no_doc`,`serie_doc`,`id_tipo_pk`),
  KEY `Refbien185` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_documentos`
--

CREATE TABLE IF NOT EXISTS `detalle_documentos` (
  `id_detalle_cv_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `nombre_cuenta` char(100) DEFAULT NULL,
  `debe` decimal(10,2) DEFAULT NULL,
  `haber` decimal(10,2) DEFAULT NULL,
  `id_documento_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_cv_pk`),
  KEY `Ref234374` (`id_documento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_folio`
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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_muestreo`
--

CREATE TABLE IF NOT EXISTS `detalle_muestreo` (
  `id_encabezado` int(11) NOT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `existencia` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_encabezado`),
  KEY `Ref143215` (`id_encabezado`),
  KEY `Ref10290` (`id_bien_pk`,`id_bodega_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_nomina`
--

CREATE TABLE IF NOT EXISTS `detalle_nomina` (
  `id_dn` char(10) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `Sueldo_base` decimal(10,2) DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `id_nomina_pk` int(11) NOT NULL,
  `id_presamo_pk` int(11) NOT NULL,
  `id_devengos_pk` int(11) NOT NULL,
  `total_sueldo` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_dn`),
  KEY `Ref238388` (`id_empleados_pk`),
  KEY `Ref240389` (`id_nomina_pk`),
  KEY `Ref239390` (`id_presamo_pk`),
  KEY `Ref242397` (`id_devengos_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_pedido`
--

CREATE TABLE IF NOT EXISTS `detalle_pedido` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `id_bien_pk` int(11) NOT NULL,
  `cod_pedido` int(11) DEFAULT NULL,
  `item_cod_producto` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `estado_detalle` varchar(25) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_pedido_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_detalle`,`id_bien_pk`),
  KEY `Ref1244` (`id_bien_pk`,`id_categoria_pk`),
  KEY `Ref151403` (`id_precio`),
  KEY `Ref248429` (`id_pedido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_pedido_1`
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
-- Table structure for table `detalle_pedido_compra`
--

CREATE TABLE IF NOT EXISTS `detalle_pedido_compra` (
  `id_detalle_pedido_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado` char(15) DEFAULT NULL,
  `id_detalle_requisicion_pk` int(11) DEFAULT NULL,
  `id_pedido_compra_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_pedido_pk`),
  KEY `Ref146291` (`id_detalle_requisicion_pk`),
  KEY `Ref129441` (`id_pedido_compra_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_planilla_igss`
--

CREATE TABLE IF NOT EXISTS `detalle_planilla_igss` (
  `id_detalle_pigss` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_planilla_igss_pk` int(11) NOT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  `sueldo_base` decimal(10,2) DEFAULT NULL,
  `igss_pagar` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pigss`),
  KEY `Ref237393` (`id_planilla_igss_pk`),
  KEY `Ref238394` (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_produccion`
--

CREATE TABLE IF NOT EXISTS `detalle_produccion` (
  `correlativo` int(11) NOT NULL AUTO_INCREMENT,
  `id_produccion_pk` char(10) NOT NULL,
  `cantidad_mp` char(10) DEFAULT NULL,
  `id_detalle_pedido_pk` int(11) NOT NULL,
  `id_encabezado_pedido_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`correlativo`,`id_produccion_pk`),
  KEY `Ref191299` (`id_detalle_pedido_pk`,`id_encabezado_pedido_pk`),
  KEY `Ref1310` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_receta_mp`
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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_requisicion`
--

CREATE TABLE IF NOT EXISTS `detalle_requisicion` (
  `id_detalle_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_requisicion_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_requisicion_pk`),
  KEY `Ref1220` (`id_bien_pk`,`id_categoria_pk`),
  KEY `Ref145440` (`id_requisicion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `deuda`
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
  KEY `Ref94231` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  KEY `Ref17232` (`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `devengos`
--

CREATE TABLE IF NOT EXISTS `devengos` (
  `id_devengos_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `nombre` char(100) DEFAULT NULL,
  `detalle` char(250) DEFAULT NULL,
  `cantidad_debengado` decimal(10,2) DEFAULT NULL,
  `cuotas` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_empleados_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_devengos_pk`),
  KEY `Ref238386` (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `disponibilidad_bancaria`
--

CREATE TABLE IF NOT EXISTS `disponibilidad_bancaria` (
  `id_disponibilidad_bancaria` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_cuenta_bancaria_pk` int(11) NOT NULL,
  `id_tipo_documento` int(11) NOT NULL,
  PRIMARY KEY (`id_disponibilidad_bancaria`),
  KEY `Ref232377` (`id_cuenta_bancaria_pk`),
  KEY `Ref229378` (`id_tipo_documento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `documento`
--

CREATE TABLE IF NOT EXISTS `documento` (
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
  `id_proveedor_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_documento_pk`),
  KEY `Ref232375` (`id_cuenta_bancaria_pk`),
  KEY `Ref229376` (`id_tipo_documento`),
  KEY `Ref123385` (`id_cuenta_pk`,`id_proveedor_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `empleado`
--

CREATE TABLE IF NOT EXISTS `empleado` (
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
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_empleados_pk`),
  KEY `Ref17398` (`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `empleado_1`
--

CREATE TABLE IF NOT EXISTS `empleado_1` (
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
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `empresa`
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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `encabezado_documento`
--

CREATE TABLE IF NOT EXISTS `encabezado_documento` (
  `no_doc` int(11) NOT NULL,
  `serie_doc` int(11) NOT NULL,
  `id_tipo_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `empresa` char(50) DEFAULT NULL,
  `estado_doc` char(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`no_doc`,`serie_doc`,`id_tipo_pk`),
  KEY `Ref142212` (`id_tipo_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `encabezado_muestreo`
--

CREATE TABLE IF NOT EXISTS `encabezado_muestreo` (
  `id_encabezado` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `responsable` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_encabezado`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `encabezado_pedido`
--

CREATE TABLE IF NOT EXISTS `encabezado_pedido` (
  `id_encabezado_pedido_pk` int(11) NOT NULL AUTO_INCREMENT,
  `hora_ingreso` char(10) DEFAULT NULL,
  `id_cliente_pk` char(10) DEFAULT NULL,
  `fecha_ingreso` char(18) DEFAULT NULL,
  `fecha_entrega` char(18) DEFAULT NULL,
  `hora_entrega` timestamp NULL DEFAULT NULL,
  `id_empleados_pk` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_encabezado_pedido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `evento`
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
-- Dumping data for table `evento`
--

INSERT INTO `evento` (`id_evento_pk`, `nombre`, `fecha_entrada`, `fecha_salida`, `hora_entrada`, `hora_salida`, `costo`, `estado`, `id_cliente_pk`, `id_salon_pk`) VALUES
(1, 'FJDALKF', '2016-10-25', '2016-11-01', 8, 8, 0, NULL, 1, 0),
(2, 'GFD', '2016-10-06', '2016-11-01', 800, 800, 0, NULL, 1, 0),
(3, 'boda', '2016-11-01', '2016-11-03', 6, 4, 9000, NULL, 2, 2),
(4, 'confirmacion', '2016-11-01', '2016-11-04', 5, 19, 1500, NULL, 2, 2),
(5, 'jdfsl', '2016-11-03', '2016-11-10', 20, 17, 1500, NULL, 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `factura`
--

CREATE TABLE IF NOT EXISTS `factura` (
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
  `id_empleados_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  KEY `Ref15126` (`id_cliente_pk`),
  KEY `Ref17241` (`id_empresa_pk`),
  KEY `Ref155246` (`id_impuesto_pk`),
  KEY `Ref246405` (`id_moneda`),
  KEY `Ref253438` (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `factura documento`
--

CREATE TABLE IF NOT EXISTS `factura documento` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_documento_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`id_documento_pk`,`serie`),
  KEY `Ref94383` (`id_empresa_pk`,`id_fac_empresa_pk`,`serie`),
  KEY `Ref234384` (`id_documento_pk`),
  KEY `Reffactura383` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `factura_detalle`
--

CREATE TABLE IF NOT EXISTS `factura_detalle` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_precio` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `nombre_desc` varchar(200) DEFAULT NULL,
  `precio` decimal(18,2) DEFAULT NULL,
  `serie` varchar(10) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_detalle_folio_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`id_precio`),
  KEY `Ref94247` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  KEY `Ref151402` (`id_precio`),
  KEY `Ref250439` (`id_detalle_folio_pk`),
  KEY `Refempresa248` (`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `factura_pago`
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
-- Table structure for table `folio`
--

CREATE TABLE IF NOT EXISTS `folio` (
  `id_cuenta_pagar_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado` varchar(10) NOT NULL,
  `fecha_ingreso` date NOT NULL,
  `fecha_pago` date DEFAULT NULL,
  `costo` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_cuenta_pagar_pk`),
  KEY `Ref15167` (`id_cliente_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `folio_bien`
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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `folio_factura`
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

-- --------------------------------------------------------

--
-- Table structure for table `folio_habitacion`
--

CREATE TABLE IF NOT EXISTS `folio_habitacion` (
  `id_folio_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_reserhabit_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_habitacion_pk`),
  KEY `Ref33257` (`id_cuenta_pagar_pk`),
  KEY `Ref37424` (`id_reserhabit_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `folio_promocion`
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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `folio_salon`
--

CREATE TABLE IF NOT EXISTS `folio_salon` (
  `id_folio_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `fecha` char(100) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_evento_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_salon_pk`),
  KEY `Ref33259` (`id_cuenta_pagar_pk`),
  KEY `Ref26443` (`id_evento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `forma_pago`
--

CREATE TABLE IF NOT EXISTS `forma_pago` (
  `id_forma_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_pago` varchar(25) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_forma_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `gastos_importacion`
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
  `id_factura_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_importacion_pk`),
  KEY `Ref125172` (`id_factura_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `habitacion`
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
  KEY `Ref17161` (`id_empresa_pk`),
  KEY `Ref3444` (`id_tipo_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `impuesto`
--

CREATE TABLE IF NOT EXISTS `impuesto` (
  `id_impuesto_pk` int(11) NOT NULL AUTO_INCREMENT,
  `porcentaje` decimal(18,2) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_impuesto_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `invitado`
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
-- Table structure for table `linea`
--

CREATE TABLE IF NOT EXISTS `linea` (
  `id_linea_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_categoria` char(40) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_linea_pk`),
  KEY `Ref9430` (`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `marca`
--

CREATE TABLE IF NOT EXISTS `marca` (
  `id_marca_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_marca` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_marca_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `medida`
--

CREATE TABLE IF NOT EXISTS `medida` (
  `id_medida_pk` int(11) NOT NULL AUTO_INCREMENT,
  `valor` char(10) DEFAULT NULL,
  `nombre_medida` char(30) DEFAULT NULL,
  `abreviatura` char(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_medida_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE IF NOT EXISTS `menu` (
  `id_menu_pk` char(18) NOT NULL,
  `correlativo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` char(50) DEFAULT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `id_receta_pk` int(11) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_menu_pk`,`correlativo`),
  KEY `Ref187300` (`id_receta_pk`),
  KEY `Ref151308` (`id_precio`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `movimiento_inventario`
--

CREATE TABLE IF NOT EXISTS `movimiento_inventario` (
  `id_movimiento_pk` int(11) NOT NULL AUTO_INCREMENT,
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
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_movimiento_pk`),
  KEY `Ref130183` (`no_doc`,`serie_doc`,`id_tipo_pk`),
  KEY `Ref132208` (`id_transaccion_pk`),
  KEY `Ref5210` (`id_bodega_pk`),
  KEY `Ref1289` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `nomina`
--

CREATE TABLE IF NOT EXISTS `nomina` (
  `id_nomina_pk` int(11) NOT NULL,
  `estado` char(25) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_nomina_pk`),
  KEY `Ref17400` (`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `obj_perdido`
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
-- Table structure for table `operacion`
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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `paquetes_eventos`
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
-- Table structure for table `paquetes_reservacion_habitacion`
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
-- Table structure for table `paquete_inventario`
--

CREATE TABLE IF NOT EXISTS `paquete_inventario` (
  `id_paquete_inventario` int(11) NOT NULL AUTO_INCREMENT,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_paquete_inventario`),
  KEY `Ref2580` (`id_promocion_pk`),
  KEY `Ref181` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Refbien81` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `parametros_fac`
--

CREATE TABLE IF NOT EXISTS `parametros_fac` (
  `id_parametros_pk` int(11) NOT NULL AUTO_INCREMENT,
  `categoria` varchar(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_parametros_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `pedido`
--

CREATE TABLE IF NOT EXISTS `pedido` (
  `id_pedido_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_pedido` date DEFAULT NULL,
  `cliente` char(50) DEFAULT NULL,
  `usu_pedido` char(50) DEFAULT NULL,
  `estado_pedido` char(20) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_pedido_pk`),
  KEY `Ref15426` (`id_cliente_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `pedido_compra`
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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `pedido_cotizacion`
--

CREATE TABLE IF NOT EXISTS `pedido_cotizacion` (
  `id_cotizacion_pk` int(11) NOT NULL,
  `id_pedido_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_cotizacion_pk`,`id_pedido_pk`),
  KEY `Ref92250` (`id_cotizacion_pk`),
  KEY `Ref248428` (`id_pedido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pedido_factura`
--

CREATE TABLE IF NOT EXISTS `pedido_factura` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `serie` varchar(10) NOT NULL,
  `id_pedido_pk` int(11) NOT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`,`id_pedido_pk`),
  KEY `Ref94252` (`id_fac_empresa_pk`,`id_empresa_pk`,`serie`),
  KEY `Ref248427` (`id_pedido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `planilla_igss`
--

CREATE TABLE IF NOT EXISTS `planilla_igss` (
  `id_planilla_igss_pk` int(11) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `porcentaje_igss` decimal(10,2) DEFAULT NULL,
  `sueldo` date DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_planilla_igss_pk`),
  KEY `Ref17399` (`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `precio`
--

CREATE TABLE IF NOT EXISTS `precio` (
  `id_precio` int(11) NOT NULL AUTO_INCREMENT,
  `precio` decimal(10,2) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_tamaniop_pk` char(10) DEFAULT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  `id_evento_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_salon_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_precio`),
  KEY `Ref1235` (`id_bien_pk`,`id_categoria_pk`),
  KEY `Ref182313` (`id_tamaniop_pk`),
  KEY `Ref20420` (`id_habitacion_pk`),
  KEY `Ref26421` (`id_evento_pk`),
  KEY `Ref25422` (`id_promocion_pk`),
  KEY `Ref19423` (`id_salon_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `problema`
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
  KEY `Ref15168` (`id_cliente_pk`),
  KEY `Ref17169` (`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `proceso`
--

CREATE TABLE IF NOT EXISTS `proceso` (
  `id_proceso_pk` int(11) NOT NULL AUTO_INCREMENT,
  `observacion` char(100) DEFAULT NULL,
  `caracteristica_proceso` char(100) DEFAULT NULL,
  `nombre_proceso` char(20) DEFAULT NULL,
  `tiempo_proceso` char(10) DEFAULT NULL,
  `medida_tiempo` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_proceso_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `produccion`
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
  PRIMARY KEY (`id_produccion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `producto_bodega`
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

-- --------------------------------------------------------

--
-- Table structure for table `promocion`
--

CREATE TABLE IF NOT EXISTS `promocion` (
  `id_promocion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_paquete` varchar(10) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `costo` int(10) NOT NULL,
  `detalle` varchar(100) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_salon_pk` int(11) DEFAULT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_promocion_pk`),
  KEY `Ref19163` (`id_salon_pk`),
  KEY `Ref20165` (`id_habitacion_pk`),
  KEY `Ref1195` (`id_categoria_pk`,`id_bien_pk`),
  KEY `Refbien195` (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `promocion`
--

INSERT INTO `promocion` (`id_promocion_pk`, `tipo_paquete`, `nombre`, `costo`, `detalle`, `estado`, `id_salon_pk`, `id_habitacion_pk`, `id_bien_pk`, `id_categoria_pk`) VALUES
(1, 'Agrandado', 'Agrandado', 5000, 'djaflsdjalkf', 'ACTIVO', 1, 1, 1, '1'),
(2, 'mediano', 'mediano', 1500, 'incluye un servicio de luces y musica en vivo', 'activo', 1, 1, 1, '1');

-- --------------------------------------------------------

--
-- Table structure for table `proveedor`
--

CREATE TABLE IF NOT EXISTS `proveedor` (
  `id_proveedor_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_proveedor` char(25) DEFAULT NULL,
  `direccion` char(25) DEFAULT NULL,
  `telefono` char(15) DEFAULT NULL,
  `correo_electronico` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_proveedor_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `receta`
--

CREATE TABLE IF NOT EXISTS `receta` (
  `id_receta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_receta` char(30) DEFAULT NULL,
  `horas_hombre` float(8,0) DEFAULT NULL,
  `costo_receta` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_receta_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `requisicion`
--

CREATE TABLE IF NOT EXISTS `requisicion` (
  `id_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `encargado` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_requisicion_pk`),
  KEY `Ref5217` (`id_bodega_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `reservacion_habitacion`
--

CREATE TABLE IF NOT EXISTS `reservacion_habitacion` (
  `id_reserhabit_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_entreda` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `fecha_reservacion` date NOT NULL,
  `id_cliente_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_reserhabit_pk`),
  KEY `Ref1546` (`id_cliente_pk`),
  KEY `Ref2047` (`id_habitacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `salon`
--

CREATE TABLE IF NOT EXISTS `salon` (
  `id_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `descripcion` varchar(20) NOT NULL,
  `dimiencion` varchar(20) NOT NULL,
  `costo` int(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_salon_pk`),
  KEY `Ref17162` (`id_empresa_pk`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `salon`
--

INSERT INTO `salon` (`id_salon_pk`, `nombre`, `descripcion`, `dimiencion`, `costo`, `estado`, `id_empresa_pk`) VALUES
(1, 'ejecutivo', 'Salon de Reuniones', '300 x 250', 1500, 'Activo', 1),
(2, 'vista al mar', 'salon al aire libre', '500x800', 5000, 'Activo', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tamanio_porcion`
--

CREATE TABLE IF NOT EXISTS `tamanio_porcion` (
  `id_tamaniop_pk` char(10) NOT NULL,
  `tamanio` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_tamaniop_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tiempo_vida`
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
-- Table structure for table `tipo_credito`
--

CREATE TABLE IF NOT EXISTS `tipo_credito` (
  `id_tipocredito_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) DEFAULT NULL,
  `valor` decimal(10,2) NOT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_tipocredito_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tipo_doc`
--

CREATE TABLE IF NOT EXISTS `tipo_doc` (
  `id_tipo_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_tipo` char(55) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tipo_documento`
--

CREATE TABLE IF NOT EXISTS `tipo_documento` (
  `id_tipo_documento` int(11) NOT NULL,
  `nombre_documento` char(50) DEFAULT NULL,
  `detalle` char(200) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_documento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tipo_doc_1`
--

CREATE TABLE IF NOT EXISTS `tipo_doc_1` (
  `id_doc` int(11) NOT NULL AUTO_INCREMENT,
  `nom_doc` varchar(50) DEFAULT NULL,
  `desc_doc` varchar(100) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tipo_habitacion`
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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tipo_moneda`
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
-- Table structure for table `tipo_precio`
--

CREATE TABLE IF NOT EXISTS `tipo_precio` (
  `id_tprecio_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_tprecio_pk`),
  KEY `Ref151314` (`id_precio`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `transaccion`
--

CREATE TABLE IF NOT EXISTS `transaccion` (
  `id_transaccion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_transaccion` char(40) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_transaccion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

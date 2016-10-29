CREATE DATABASE  IF NOT EXISTS `hotelsancarlos` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `hotelsancarlos`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: hotelsancarlos
-- ------------------------------------------------------
-- Server version	5.5.24-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bien`
--

DROP TABLE IF EXISTS `bien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
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
  `estado` char(15) DEFAULT NULL,
  `id_marca_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bien`
--

LOCK TABLES `bien` WRITE;
/*!40000 ALTER TABLE `bien` DISABLE KEYS */;
INSERT INTO `bien` VALUES (1,'1',10,20,'frijoles',3,1,'peps',1,'ACTIVO',2),(2,'2',20,30,'ARROZ',2,2,'ueps',2,'ACTIVO',1),(3,'3',13,10,'macheteZ',1,3,'ponderado',3,'ACTIVO',2),(4,'4',14,14,'motosierra',4,4,'ueps',4,'ACTIVO',4),(5,'5',15,15,'braga',5,5,'peps',5,'ACTIVO',5);
/*!40000 ALTER TABLE `bien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bodega` (
  `id_bodega_pk` int(11) NOT NULL AUTO_INCREMENT,
  `ubicacion` char(40) DEFAULT NULL,
  `nombre_bodega` char(40) DEFAULT NULL,
  `tamaño` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bodega_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
INSERT INTO `bodega` VALUES (1,'2do_piso','restaurante','2metos','ACTIVO',10),(2,'2do_piso','restaurante','2metos','ACTIVO',10),(3,'3do_piso','sala','4metos','ACTIVO',11),(4,'4do_piso','comedor','1metos','ACTIVO',12);
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `id_categoria_pk` char(18) NOT NULL,
  `tipo_categoria` char(25) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES ('1','comida','ACTIVO'),('2','Limpieza','ACTIVO'),('3','restaurante','ACTIVO');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `compra` (
  `id_factura_pk` int(11) NOT NULL,
  `id_pedido_compra_pk` int(11) NOT NULL,
  `serie_factura` char(15) DEFAULT NULL,
  `fecha_recibida` date DEFAULT NULL,
  `encargado` char(20) DEFAULT NULL,
  `total` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `id_forma_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_factura_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
INSERT INTO `compra` VALUES (1313,2,'B','0002-02-02','CRISTOBAL cervantes',200,'ACTIVO',1,2,1),(1414,2,'A','0001-02-01','esteban cervantes',100,'INACTIVO',1,2,2);
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuenta_corriente_por_pagar`
--

DROP TABLE IF EXISTS `cuenta_corriente_por_pagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuenta_corriente_por_pagar` (
  `id_cuenta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_proveedor_pk` int(11) NOT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  PRIMARY KEY (`id_cuenta_pk`,`id_proveedor_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuenta_corriente_por_pagar`
--

LOCK TABLES `cuenta_corriente_por_pagar` WRITE;
/*!40000 ALTER TABLE `cuenta_corriente_por_pagar` DISABLE KEYS */;
INSERT INTO `cuenta_corriente_por_pagar` VALUES (1,2,'ACTIVO'),(2,3,'ACTIVO');
/*!40000 ALTER TABLE `cuenta_corriente_por_pagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_compra`
--

DROP TABLE IF EXISTS `detalle_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_compra` (
  `id_detalle_compra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_detalle_pedido_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio_compra` decimal(15,0) DEFAULT NULL,
  `subtotal_compra` decimal(15,0) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_factura_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_compra_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_compra`
--

LOCK TABLES `detalle_compra` WRITE;
/*!40000 ALTER TABLE `detalle_compra` DISABLE KEYS */;
INSERT INTO `detalle_compra` VALUES (1,1,20,10,200,'ACTIVO',1313),(2,2,10,5,50,'ACTIVO',1414);
/*!40000 ALTER TABLE `detalle_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_cuenta_por_pagar`
--

DROP TABLE IF EXISTS `detalle_cuenta_por_pagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_cuenta_por_pagar` (
  `detalle_cuenta_por_pagar_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` char(25) DEFAULT NULL,
  `comprobante` int(11) DEFAULT NULL,
  `debe` decimal(15,0) DEFAULT NULL,
  `haber` decimal(15,0) DEFAULT NULL,
  `saldo` decimal(15,0) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_cuenta_pk` int(11) DEFAULT NULL,
  `id_proveedor_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`detalle_cuenta_por_pagar_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_cuenta_por_pagar`
--

LOCK TABLES `detalle_cuenta_por_pagar` WRITE;
/*!40000 ALTER TABLE `detalle_cuenta_por_pagar` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_cuenta_por_pagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_pedido_compra`
--

DROP TABLE IF EXISTS `detalle_pedido_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_pedido_compra` (
  `id_detalle_pedido_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_detalle_requisicion_pk` int(11) DEFAULT NULL,
  `id_pedido_compra_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_pedido_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_pedido_compra`
--

LOCK TABLES `detalle_pedido_compra` WRITE;
/*!40000 ALTER TABLE `detalle_pedido_compra` DISABLE KEYS */;
INSERT INTO `detalle_pedido_compra` VALUES (1,'ACTIVO',1,1),(2,'ACTIVO',2,2),(3,'ACTIVO',1,1),(4,'ACTIVO',1,3);
/*!40000 ALTER TABLE `detalle_pedido_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_requisicion`
--

DROP TABLE IF EXISTS `detalle_requisicion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_requisicion` (
  `id_detalle_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_requisicion_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_requisicion_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_requisicion`
--

LOCK TABLES `detalle_requisicion` WRITE;
/*!40000 ALTER TABLE `detalle_requisicion` DISABLE KEYS */;
INSERT INTO `detalle_requisicion` VALUES (1,5,'ACTIVO',1,'1',2),(2,6,'ACTIVO',2,'2',2),(3,7,'ACTIVO',3,'3',2),(4,8,'ACTIVO',4,'4',2),(5,10,'ACTIVO',5,'5',2);
/*!40000 ALTER TABLE `detalle_requisicion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `forma_pago`
--

DROP TABLE IF EXISTS `forma_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `forma_pago` (
  `id_forma_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_pago` varchar(25) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_forma_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `forma_pago`
--

LOCK TABLES `forma_pago` WRITE;
/*!40000 ALTER TABLE `forma_pago` DISABLE KEYS */;
INSERT INTO `forma_pago` VALUES (1,'efectivo','entrega del efectivo','ACTIVO'),(2,'debito','pago por partes','ACTIVO');
/*!40000 ALTER TABLE `forma_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gastos_importacion`
--

DROP TABLE IF EXISTS `gastos_importacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gastos_importacion` (
  `id_importacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `transporte` char(25) DEFAULT NULL,
  `direccion_salida` char(25) DEFAULT NULL,
  `hora_fecha_salida` date DEFAULT NULL,
  `direccion_llegada` char(25) DEFAULT NULL,
  `hora_fecha_llegada` date DEFAULT NULL,
  `aduana` decimal(15,0) DEFAULT NULL,
  `otros_impuestos` decimal(15,0) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_factura_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_importacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gastos_importacion`
--

LOCK TABLES `gastos_importacion` WRITE;
/*!40000 ALTER TABLE `gastos_importacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `gastos_importacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido_compra`
--

DROP TABLE IF EXISTS `pedido_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido_compra` (
  `id_pedido_compra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `encargado` char(25) DEFAULT NULL,
  `estado_pedido` char(20) DEFAULT NULL,
  `observaciones` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_proveedor_pk` int(11) NOT NULL,
  `id_requisicion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_pedido_compra_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido_compra`
--

LOCK TABLES `pedido_compra` WRITE;
/*!40000 ALTER TABLE `pedido_compra` DISABLE KEYS */;
INSERT INTO `pedido_compra` VALUES (1,'0001-01-01','jose espejel','enviado','xx','ACTIVO',2,2),(2,'0002-02-01','mario morales','enviado','xxx','ACTIVO',3,3),(3,'0003-03-03','kendo kaponi','enviado','xxx','ACTIVO',2,2);
/*!40000 ALTER TABLE `pedido_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `id_proveedor_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_proveedor` char(25) DEFAULT NULL,
  `direccion` char(25) DEFAULT NULL,
  `telefono` char(15) DEFAULT NULL,
  `correo_electronico` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  PRIMARY KEY (`id_proveedor_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'MATERIA','zona2','23456787','materia@gmail.com','ACTIVO'),(2,'comida','zona1','34234567','comida@gmail.com','ACTIVO');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requisicion`
--

DROP TABLE IF EXISTS `requisicion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `requisicion` (
  `id_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `encargado` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_bodega_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_requisicion_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requisicion`
--

LOCK TABLES `requisicion` WRITE;
/*!40000 ALTER TABLE `requisicion` DISABLE KEYS */;
INSERT INTO `requisicion` VALUES (2,'0001-01-01','jose morales','ACTIVO',1),(3,'0002-02-02','CARLOS morales','ACTIVO',2);
/*!40000 ALTER TABLE `requisicion` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-10-28 22:33:02

CREATE DATABASE  IF NOT EXISTS `hotelsancarlos` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `hotelsancarlos`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: hotelsancarlos
-- ------------------------------------------------------
-- Server version	5.7.13-log

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
-- Table structure for table `aplicacion`
--

DROP TABLE IF EXISTS `aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aplicacion` (
  `id_aplicacion` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_aplicacion` char(40) DEFAULT NULL,
  PRIMARY KEY (`id_aplicacion`)
) ENGINE=MyISAM AUTO_INCREMENT=10205 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion`
--

LOCK TABLES `aplicacion` WRITE;
/*!40000 ALTER TABLE `aplicacion` DISABLE KEYS */;
INSERT INTO `aplicacion` VALUES (10204,'Pollo Campero');
/*!40000 ALTER TABLE `aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asignacion_mo`
--

DROP TABLE IF EXISTS `asignacion_mo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asignacion_mo` (
  `id_produccion_pk` char(10) NOT NULL,
  `id_empleados_pk` char(10) NOT NULL,
  `cant_horas` char(10) DEFAULT NULL,
  `fecha_asig` date DEFAULT NULL,
  PRIMARY KEY (`id_produccion_pk`,`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asignacion_mo`
--

LOCK TABLES `asignacion_mo` WRITE;
/*!40000 ALTER TABLE `asignacion_mo` DISABLE KEYS */;
/*!40000 ALTER TABLE `asignacion_mo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asignacion_mp`
--

DROP TABLE IF EXISTS `asignacion_mp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asignacion_mp` (
  `id_encabezado_pedido_pk` char(10) DEFAULT NULL,
  `cant_mp` double DEFAULT NULL,
  `id_menu_pk` char(10) DEFAULT NULL,
  `correlativo` int(10) DEFAULT NULL,
  `id_bien_pk` int(10) DEFAULT NULL,
  `cant_hh` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asignacion_mp`
--

LOCK TABLES `asignacion_mp` WRITE;
/*!40000 ALTER TABLE `asignacion_mp` DISABLE KEYS */;
/*!40000 ALTER TABLE `asignacion_mp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bien`
--

DROP TABLE IF EXISTS `bien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bien` (
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
  PRIMARY KEY (`id_bien_pk`,`id_categoria_pk`),
  KEY `Refcategoria8` (`id_categoria_pk`),
  KEY `Refmedida404` (`id_medida_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bien`
--

LOCK TABLES `bien` WRITE;
/*!40000 ALTER TABLE `bien` DISABLE KEYS */;
INSERT INTO `bien` VALUES (26,'mp',6,50,'kiwi','Fruta',2,'1 semana','2016-10-25','cualquiera',1),(27,'mp',6,50,'fresa','Fruta',2,'1 semana','2016-10-25','cualquiera',1),(28,'mp',6,50,'sandia','Fruta',2,'1 semana','2016-10-25','cualquiera',1),(29,'mp',6,50,'papa','Vegetales',2,'1 semana','2016-10-25','cualquiera',1),(30,'mp',6,50,'tomate','Vegetales',2,'1 semana','2016-10-25','cualquiera',1),(31,'mp',6,50,'zanahoria','Vegetales',2,'1 semana','2016-10-25','cualquiera',1),(32,'mp',6,50,'Crema','Lacteos',2,'1 semana','2016-10-25','cualquiera',1),(33,'mp',6,50,'Queso','Lacteos',2,'1 semana','2016-10-25','cualquiera',1),(34,'mp',6,50,'Leche','Lacteos',2,'1 semana','2016-10-25','cualquiera',1),(35,'pt',6,50,'cama','inmuebles',2,'1 semana','2016-10-25','cualquiera',1),(36,'pt',6,50,'closet','inmuebles',2,'1 semana','2016-10-25','cualquiera',1);
/*!40000 ALTER TABLE `bien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bien_habitacion`
--

DROP TABLE IF EXISTS `bien_habitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bien_habitacion` (
  `id_bien_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `existencia` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_habitacion_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bien_habitacion`
--

LOCK TABLES `bien_habitacion` WRITE;
/*!40000 ALTER TABLE `bien_habitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `bien_habitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bitacora` (
  `id_bit` int(10) NOT NULL AUTO_INCREMENT,
  `hora` time DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  `accion` varchar(500) DEFAULT NULL,
  `tabla` varchar(50) DEFAULT NULL,
  `ip` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_bit`)
) ENGINE=InnoDB AUTO_INCREMENT=16451 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
INSERT INTO `bitacora` VALUES (16100,'16:25:11','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16101,'16:26:21','2016-10-20','johnny2','Insertar','Creacion usuario: shakalaka','usuario','192.168.1.8'),(16102,'16:26:21','2016-10-20','johnny2','Operacion exitosa','Asignacion del usuario: shakalaka al colaborador: 1-206','usuario','192.168.1.8'),(16103,'16:26:21','2016-10-20','johnny2','Asignacion/cambio permisos','Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: shakalaka Sobre aplicacion: 10204','usuario_privilegios','192.168.1.8'),(16104,'16:26:45','2016-10-20','shakalaka','Loggeo exitoso','Login','usuario','192.168.1.8'),(16105,'17:18:19','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16106,'17:46:43','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16107,'17:49:12','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16108,'17:52:33','2016-10-20','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16109,'17:52:40','2016-10-20','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16110,'17:52:50','2016-10-20','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16111,'17:52:57','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16112,'17:55:01','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16113,'17:55:37','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16114,'17:56:35','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16115,'17:58:54','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16116,'18:01:19','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16117,'18:02:50','2016-10-20','johnny2','Insertar','Creacion usuario: hola','usuario','192.168.1.8'),(16118,'18:02:50','2016-10-20','johnny2','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: hola','bitacora','192.168.1.8'),(16119,'18:02:50','2016-10-20','johnny2','Operacion exitosa','Asignacion del usuario: hola al colaborador: 1-202','usuario','192.168.1.8'),(16120,'18:02:50','2016-10-20','johnny2','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: True del: False a usuario: hola Sobre aplicacion: 10204','usuario_privilegios','192.168.1.8'),(16121,'18:03:31','2016-10-20','hola','Loggeo exitoso','Login','usuario','192.168.1.8'),(16122,'18:08:07','2016-10-20','hola','Loggeo exitoso','Login','usuario','192.168.1.8'),(16123,'23:18:41','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16124,'23:19:16','2016-10-20','johnny2','Modificar','Actualizacion de contraseña de usuario: johnny2','usuario','192.168.1.8'),(16125,'23:21:25','2016-10-20','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16126,'23:21:29','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16127,'23:27:17','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16128,'23:27:33','2016-10-20','johnny2','Modificar','Actualizacion de contraseña de usuario: johnny2','usuario','192.168.1.8'),(16129,'23:36:59','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16130,'23:37:22','2016-10-20','johnny2','Modificar','Actualizacion de contraseña de usuario: johnny2','usuario','192.168.1.8'),(16131,'23:38:47','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16132,'23:39:00','2016-10-20','johnny2','Modificar','Actualizacion de contraseña de usuario: johnny2','usuario','192.168.1.8'),(16133,'23:47:36','2016-10-20','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16134,'23:47:38','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16135,'23:47:54','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16136,'23:48:10','2016-10-20','johnny2','Modificar','Actualizacion de contraseña de usuario: johnny2','usuario','192.168.1.8'),(16137,'23:58:26','2016-10-20','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16138,'23:58:28','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16139,'23:59:32','2016-10-20','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16140,'23:59:46','2016-10-20','johnny2','Modificar','Actualizacion de contraseña de usuario: johnny2','usuario','192.168.1.8'),(16141,'09:11:44','2016-10-21','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16142,'09:11:49','2016-10-21','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16143,'09:11:51','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16144,'09:14:34','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16145,'10:24:26','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16146,'10:26:15','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16147,'10:27:20','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16148,'10:33:41','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16149,'10:36:19','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16150,'10:39:23','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16151,'10:40:10','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16152,'10:41:07','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16153,'10:43:28','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16154,'10:44:56','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16155,'10:49:50','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16156,'10:54:13','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16157,'10:59:50','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16158,'11:29:25','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16159,'11:30:12','2016-10-21','johnny2','Modificar','Actualizacion de contraseña de usuario: johnny2','usuario','192.168.1.8'),(16160,'11:36:38','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16161,'11:37:37','2016-10-21','johnny2','Eliminar ','Se deshabilitò el usuario: shakalaka','usuario','192.168.1.8'),(16162,'11:42:59','2016-10-21','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16163,'11:43:04','2016-10-21','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16164,'11:43:07','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16165,'11:45:17','2016-10-21','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16166,'11:45:21','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16167,'12:17:49','2016-10-21','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16168,'12:17:51','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16169,'12:18:47','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16170,'12:19:51','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16171,'12:21:00','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16172,'12:23:36','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16173,'12:24:22','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16174,'12:25:39','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16175,'12:28:55','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16176,'12:31:06','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16177,'12:34:01','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16178,'12:35:51','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16179,'12:39:14','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16180,'12:39:31','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16181,'12:41:14','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16182,'12:42:25','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16183,'12:45:07','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16184,'12:46:18','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16185,'12:50:18','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16186,'17:58:55','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16187,'18:00:30','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16188,'18:02:29','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16189,'18:04:45','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16190,'18:10:55','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16191,'18:17:28','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16192,'18:20:22','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16193,'18:22:56','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16194,'18:28:19','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16195,'18:31:44','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16196,'18:34:15','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16197,'18:36:47','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16198,'18:41:45','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16199,'18:42:43','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16200,'18:45:07','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16201,'18:49:38','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16202,'18:52:20','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16203,'19:16:46','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16204,'19:23:55','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16205,'19:28:08','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16206,'19:31:22','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16207,'19:33:03','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16208,'19:34:02','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16209,'19:37:13','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16210,'19:38:19','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16211,'19:39:57','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16212,'19:44:06','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16213,'19:56:26','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16214,'20:02:11','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16215,'20:05:26','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16216,'20:08:18','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16217,'20:45:15','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16218,'20:52:21','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16219,'20:55:21','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16220,'20:57:44','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16221,'20:59:57','2016-10-21','johnny2','Fallo loggeo','Login','usuario','192.168.1.6'),(16222,'21:00:01','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16223,'21:06:32','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16224,'21:08:00','2016-10-21','JOHNNY2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16225,'21:08:25','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16226,'21:09:38','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.6'),(16227,'22:55:39','2016-10-21','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16228,'22:56:49','2016-10-21','johnny2','Insertar','Creacion usuario: hoho','usuario','192.168.1.8'),(16229,'22:56:49','2016-10-21','johnny2','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: hoho','bitacora','192.168.1.8'),(16230,'22:56:50','2016-10-21','johnny2','Operacion exitosa','Asignacion del usuario: hoho al colaborador: 1-204','usuario','192.168.1.8'),(16231,'22:56:50','2016-10-21','johnny2','Asignacion/cambio permisos','Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: hoho Sobre aplicacion: 10204','usuario_privilegios','192.168.1.8'),(16232,'22:57:13','2016-10-21','hoho','Loggeo exitoso','Login','usuario','192.168.1.8'),(16233,'23:06:06','2016-10-21','hoho','Loggeo exitoso','Login','usuario','192.168.1.8'),(16234,'23:08:25','2016-10-21','hoho','Fallo loggeo','Login','usuario','192.168.1.8'),(16235,'23:08:28','2016-10-21','hoho','Loggeo exitoso','Login','usuario','192.168.1.8'),(16236,'23:10:07','2016-10-21','hoho','Loggeo exitoso','Login','usuario','192.168.1.8'),(16237,'23:15:33','2016-10-21','hoho','Loggeo exitoso','Login','usuario','192.168.1.8'),(16238,'23:19:39','2016-10-21','hoho','Loggeo exitoso','Login','usuario','192.168.1.8'),(16239,'23:21:20','2016-10-21','hoho','Loggeo exitoso','Login','usuario','192.168.1.8'),(16240,'23:23:24','2016-10-21','hoho','Loggeo exitoso','Login','usuario','192.168.1.8'),(16241,'23:27:54','2016-10-21','hoho','Loggeo exitoso','Login','usuario','192.168.1.8'),(16242,'23:33:52','2016-10-21','hoho','Loggeo exitoso','Login','usuario','192.168.1.8'),(16243,'08:40:00','2016-10-24','johnny2','Loggeo exitoso','Login','usuario','10.1.85.137'),(16244,'08:40:32','2016-10-24','johnny2','Modificar','Actualizacion de contraseña de usuario: johnny2','usuario','10.1.85.137'),(16245,'08:44:52','2016-10-24','johnny2','Intento Operacion','Error al crear usuario a nivel DBS7423894392794','dbo.users','10.1.85.137'),(16246,'08:45:14','2016-10-24','johnny2','Insertar','Creacion usuario: roberto','usuario','10.1.85.137'),(16247,'08:45:15','2016-10-24','johnny2','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: roberto','bitacora','10.1.85.137'),(16248,'08:45:46','2016-10-24','johnny2','Insertar','Creacion usuario: hjadsfhadsfjkasfhjadsflk','usuario','10.1.85.137'),(16249,'08:45:46','2016-10-24','johnny2','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: hjadsfhadsfjkasfhjadsflk','bitacora','10.1.85.137'),(16250,'08:45:46','2016-10-24','johnny2','Operacion exitosa','Asignacion del usuario: hjadsfhadsfjkasfhjadsflk al colaborador: 1-201','usuario','10.1.85.137'),(16251,'08:45:46','2016-10-24','johnny2','Asignacion/cambio permisos','Asignacion de permiso: ins: True sel: True upd: True del: False a usuario: hjadsfhadsfjkasfhjadsflk Sobre aplicacion: 10204','usuario_privilegios','10.1.85.137'),(16252,'13:32:41','2016-10-24','johnny2','Fallo loggeo','Login','usuario','10.1.85.137'),(16253,'13:32:44','2016-10-24','johnny2','Loggeo exitoso','Login','usuario','10.1.85.137'),(16254,'13:40:42','2016-10-24','johnny2','Loggeo exitoso','Login','usuario','10.1.85.137'),(16255,'13:51:32','2016-10-24','johnny2','Fallo loggeo','Login','usuario','10.1.85.137'),(16256,'13:51:36','2016-10-24','johnny2','Loggeo exitoso','Login','usuario','10.1.85.137'),(16257,'13:54:39','2016-10-24','johnny2','Loggeo exitoso','Login','usuario','10.1.85.137'),(16258,'22:40:50','2016-10-24','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16259,'23:30:07','2016-10-24','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16260,'23:34:09','2016-10-24','johnny2','Fallo loggeo','Login','usuario','192.168.1.8'),(16261,'23:34:12','2016-10-24','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16262,'23:35:02','2016-10-24','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16263,'23:36:16','2016-10-24','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16264,'12:28:14','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16265,'12:29:14','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16266,'12:45:19','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16267,'12:49:04','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16268,'12:57:55','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16269,'12:59:25','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16270,'14:56:16','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16271,'14:59:48','2016-10-26','johnny2','Fallo loggeo','Login','usuario','192.168.1.29'),(16272,'14:59:51','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16273,'15:01:12','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16274,'15:02:36','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16275,'15:05:26','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16276,'15:08:07','2016-10-26','johnny2','Fallo loggeo','Login','usuario','192.168.1.29'),(16277,'15:08:23','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16278,'15:08:34','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16279,'15:08:50','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16280,'15:11:49','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16281,'15:15:53','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16282,'15:19:19','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16283,'15:20:06','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16284,'15:25:32','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16285,'15:26:04','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16286,'15:30:13','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16287,'15:38:20','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16288,'15:39:18','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16289,'15:54:18','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16290,'15:54:54','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16291,'15:56:23','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16292,'15:57:14','2016-10-26','johnny2','Loggeo exitoso','Login','usuario','192.168.1.29'),(16293,'05:07:26','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16294,'05:36:46','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','192.168.1.8'),(16295,'07:25:58','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16296,'07:29:08','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16297,'07:50:31','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16298,'07:52:07','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16299,'07:54:28','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16300,'07:56:54','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16301,'08:03:33','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16302,'08:04:56','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16303,'08:21:08','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16304,'08:28:49','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16305,'08:30:14','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16306,'08:31:25','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16307,'08:33:52','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16308,'08:56:06','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16309,'08:58:06','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16310,'08:59:02','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16311,'09:01:40','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16312,'09:04:39','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16313,'09:07:18','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16314,'09:10:22','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16315,'09:14:54','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16316,'09:16:47','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16317,'09:17:33','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16318,'09:19:12','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16319,'09:21:23','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16320,'09:22:27','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16321,'09:26:29','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16322,'09:27:19','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16323,'09:29:40','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16324,'09:31:30','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16325,'09:32:03','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16326,'09:32:49','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16327,'09:34:27','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16328,'09:35:42','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16329,'09:36:04','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16330,'09:55:11','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16331,'10:03:35','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16332,'10:04:15','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16333,'10:06:23','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16334,'10:17:46','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16335,'10:20:49','2016-10-27','johnny2','Loggeo exitoso','Login','usuario','10.1.82.117'),(16336,'12:27:12','2016-10-27','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.9'),(16337,'12:29:29','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16338,'12:30:19','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16339,'12:30:37','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16340,'12:30:55','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16341,'12:34:02','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16342,'12:49:53','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16343,'12:58:31','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16344,'12:59:32','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16345,'13:03:14','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16346,'13:07:33','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16347,'13:08:06','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16348,'13:08:53','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16349,'13:09:46','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16350,'13:11:26','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16351,'14:45:11','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16352,'14:46:32','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16353,'14:47:58','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16354,'14:50:29','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16355,'14:51:15','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16356,'14:53:47','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16357,'14:56:07','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16358,'16:20:33','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16359,'16:21:15','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16360,'16:23:39','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16361,'16:26:58','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16362,'16:29:08','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16363,'16:31:13','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16364,'16:32:12','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16365,'16:36:56','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16366,'16:41:44','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16367,'16:43:42','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16368,'16:48:45','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16369,'16:51:56','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16370,'16:54:48','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16371,'16:58:09','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16372,'17:19:24','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16373,'17:20:58','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16374,'17:23:51','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16375,'17:36:32','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16376,'17:37:26','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16377,'17:38:38','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16378,'17:39:57','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16379,'17:45:33','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16380,'17:58:35','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16381,'18:00:44','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16382,'19:29:53','2016-10-27','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16383,'15:32:04','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16384,'15:34:58','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16385,'15:40:18','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16386,'16:54:06','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16387,'17:19:08','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16388,'17:19:58','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16389,'17:22:04','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16390,'17:24:28','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16391,'17:26:19','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16392,'17:26:46','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16393,'18:09:27','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16394,'18:11:09','2016-10-28','johnny','Loggeo exitoso','Login','usuario','192.168.1.25'),(16395,'18:28:52','2016-10-28','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.25'),(16396,'18:30:23','2016-10-28','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.25'),(16397,'18:39:39','2016-10-28','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.25'),(16398,'13:29:24','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16399,'13:31:41','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16400,'13:32:23','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16401,'13:40:44','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16402,'13:44:18','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16403,'13:44:51','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16404,'13:54:35','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16405,'13:55:12','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16406,'14:06:26','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16407,'14:07:48','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16408,'14:09:49','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16409,'14:20:49','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16410,'14:23:37','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16411,'14:24:07','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16412,'14:30:48','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16413,'14:35:52','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16414,'14:37:18','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16415,'14:38:45','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16416,'14:40:52','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16417,'14:42:32','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16418,'14:45:21','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16419,'14:47:47','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16420,'14:48:57','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16421,'14:56:29','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16422,'14:57:27','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16423,'14:58:48','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16424,'15:00:00','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16425,'15:01:50','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16426,'15:03:07','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16427,'15:06:49','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16428,'15:09:35','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16429,'15:25:00','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16430,'15:28:41','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.18'),(16431,'17:02:05','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16432,'17:11:54','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16433,'17:30:42','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16434,'17:41:21','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16435,'18:49:31','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16436,'18:49:59','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16437,'18:50:37','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16438,'18:51:02','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16439,'18:54:56','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16440,'18:56:18','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16441,'19:00:58','2016-11-02','johnny','Loggeo exitoso','Login','usuario','192.168.1.9'),(16442,'08:29:43','2016-11-03','johnny','Loggeo exitoso','Login','usuario','10.1.68.1'),(16443,'08:59:38','2016-11-03','johnny','Loggeo exitoso','Login','usuario','10.1.68.1'),(16444,'09:06:50','2016-11-03','johnny','Loggeo exitoso','Login','usuario','10.1.68.1'),(16445,'09:14:11','2016-11-03','johnny','Loggeo exitoso','Login','usuario','10.1.68.1'),(16446,'09:27:45','2016-11-03','johnny','Loggeo exitoso','Login','usuario','10.1.68.1'),(16447,'09:28:57','2016-11-03','johnny','Loggeo exitoso','Login','usuario','10.1.68.1'),(16448,'09:31:58','2016-11-03','johnny','Loggeo exitoso','Login','usuario','10.1.68.1'),(16449,'09:47:08','2016-11-03','johnny','Loggeo exitoso','Login','usuario','10.1.68.1'),(16450,'09:51:44','2016-11-03','johnny','Loggeo exitoso','Login','usuario','10.1.68.1');
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
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
  PRIMARY KEY (`id_bodega_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `buzon`
--

DROP TABLE IF EXISTS `buzon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `buzon` (
  `id_buzon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) NOT NULL,
  `fecha` date DEFAULT NULL,
  `descripcion` varchar(20) NOT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_buzon_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `buzon`
--

LOCK TABLES `buzon` WRITE;
/*!40000 ALTER TABLE `buzon` DISABLE KEYS */;
/*!40000 ALTER TABLE `buzon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `tipo_categoria` char(25) DEFAULT NULL,
  `id_categoria_pk` char(25) NOT NULL,
  PRIMARY KEY (`id_categoria_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES ('Plato fuerte','1'),('Postre','2'),('Bebida','3'),('Guarnicion','4'),('Entrada','5'),('Ensalada','6');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
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
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,NULL,'Pololo','Polili','74386069',NULL,'ciudad','2016-10-26',NULL,NULL,NULL),(2,NULL,'Pelele','Pululu','386069',NULL,'ciudad','2016-10-26',NULL,NULL,NULL),(3,NULL,'changos','locos','45645490',NULL,'ciudad','2016-10-26',NULL,NULL,NULL);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `com_venta`
--

DROP TABLE IF EXISTS `com_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `com_venta` (
  `id_com_venta_pk` char(10) NOT NULL,
  `total_venta` char(10) DEFAULT NULL,
  `com_sobre_venta` char(10) DEFAULT NULL,
  `comision` char(10) DEFAULT NULL,
  `id_devengos_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_com_venta_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `com_venta`
--

LOCK TABLES `com_venta` WRITE;
/*!40000 ALTER TABLE `com_venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `com_venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `compra` (
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
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conciliaciones`
--

DROP TABLE IF EXISTS `conciliaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conciliaciones` (
  `id_conciliacion_pk` char(10) NOT NULL,
  `id_documento_pk` char(10) NOT NULL,
  `fecha` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_conciliacion_pk`,`id_documento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conciliaciones`
--

LOCK TABLES `conciliaciones` WRITE;
/*!40000 ALTER TABLE `conciliaciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `conciliaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultaalmacenada`
--

DROP TABLE IF EXISTS `consultaalmacenada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `consultaalmacenada` (
  `id_consulta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `tipo` varchar(10) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`id_consulta_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultaalmacenada`
--

LOCK TABLES `consultaalmacenada` WRITE;
/*!40000 ALTER TABLE `consultaalmacenada` DISABLE KEYS */;
/*!40000 ALTER TABLE `consultaalmacenada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contribuyente`
--

DROP TABLE IF EXISTS `contribuyente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contribuyente` (
  `id_contribuyente_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` char(10) DEFAULT NULL,
  `nit` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_contribuyente_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contribuyente`
--

LOCK TABLES `contribuyente` WRITE;
/*!40000 ALTER TABLE `contribuyente` DISABLE KEYS */;
/*!40000 ALTER TABLE `contribuyente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `convertidora`
--

DROP TABLE IF EXISTS `convertidora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `convertidora` (
  `id` char(10) NOT NULL,
  `valor` float(8,0) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `convertidora`
--

LOCK TABLES `convertidora` WRITE;
/*!40000 ALTER TABLE `convertidora` DISABLE KEYS */;
/*!40000 ALTER TABLE `convertidora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cotizacion`
--

DROP TABLE IF EXISTS `cotizacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cotizacion` (
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
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cotizacion`
--

LOCK TABLES `cotizacion` WRITE;
/*!40000 ALTER TABLE `cotizacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `cotizacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cotizacion_bien`
--

DROP TABLE IF EXISTS `cotizacion_bien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cotizacion_bien` (
  `id_detallecot_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_detallecot_pk`,`id_bien_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cotizacion_bien`
--

LOCK TABLES `cotizacion_bien` WRITE;
/*!40000 ALTER TABLE `cotizacion_bien` DISABLE KEYS */;
/*!40000 ALTER TABLE `cotizacion_bien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cotizacion_paquete`
--

DROP TABLE IF EXISTS `cotizacion_paquete`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cotizacion_paquete` (
  `id_detallecot_pk` int(11) NOT NULL,
  `id_promocion_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detallecot_pk`,`id_promocion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cotizacion_paquete`
--

LOCK TABLES `cotizacion_paquete` WRITE;
/*!40000 ALTER TABLE `cotizacion_paquete` DISABLE KEYS */;
/*!40000 ALTER TABLE `cotizacion_paquete` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuenta_bancaria`
--

DROP TABLE IF EXISTS `cuenta_bancaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuenta_bancaria` (
  `id_cuenta_bancaria_pk` char(10) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `nombre_banco` char(10) DEFAULT NULL,
  `no_cuenta` char(10) DEFAULT NULL,
  `saldo_libros` char(10) DEFAULT NULL,
  `saldo_bancarios` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_cuenta_bancaria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuenta_bancaria`
--

LOCK TABLES `cuenta_bancaria` WRITE;
/*!40000 ALTER TABLE `cuenta_bancaria` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuenta_bancaria` ENABLE KEYS */;
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
  PRIMARY KEY (`id_cuenta_pk`,`id_proveedor_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuenta_corriente_por_pagar`
--

LOCK TABLES `cuenta_corriente_por_pagar` WRITE;
/*!40000 ALTER TABLE `cuenta_corriente_por_pagar` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuenta_corriente_por_pagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deducciones`
--

DROP TABLE IF EXISTS `deducciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deducciones` (
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
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deducciones`
--

LOCK TABLES `deducciones` WRITE;
/*!40000 ALTER TABLE `deducciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `deducciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_compra`
--

DROP TABLE IF EXISTS `detalle_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_compra` (
  `id_factura_pk` int(11) NOT NULL,
  `id_detalle_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio_compra` decimal(15,0) DEFAULT NULL,
  `subtotal_compra` decimal(15,0) DEFAULT NULL,
  `id_orden_compra_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_factura_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_compra`
--

LOCK TABLES `detalle_compra` WRITE;
/*!40000 ALTER TABLE `detalle_compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_cotizacion`
--

DROP TABLE IF EXISTS `detalle_cotizacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_cotizacion` (
  `id_detallecot_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad_detcot` varchar(10) NOT NULL,
  `desc_servicio_detcot` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_detallecot_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_cotizacion`
--

LOCK TABLES `detalle_cotizacion` WRITE;
/*!40000 ALTER TABLE `detalle_cotizacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_cotizacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_cuenta_por_pagar`
--

DROP TABLE IF EXISTS `detalle_cuenta_por_pagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_cuenta_por_pagar` (
  `detalle_cuenta_por_pagar_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `comprobante` int(11) DEFAULT NULL,
  `debe` decimal(15,0) DEFAULT NULL,
  `haber` decimal(15,0) DEFAULT NULL,
  `saldo` decimal(15,0) DEFAULT NULL,
  `id_cuenta_pk` int(11) DEFAULT NULL,
  `id_proveedor_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`detalle_cuenta_por_pagar_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_cuenta_por_pagar`
--

LOCK TABLES `detalle_cuenta_por_pagar` WRITE;
/*!40000 ALTER TABLE `detalle_cuenta_por_pagar` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_cuenta_por_pagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_disp_banc`
--

DROP TABLE IF EXISTS `detalle_disp_banc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_disp_banc` (
  `id_detalle_db_pk` char(10) NOT NULL,
  `id_disponibilidad_bancaria` char(10) NOT NULL,
  `id_documento_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_detalle_db_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_disp_banc`
--

LOCK TABLES `detalle_disp_banc` WRITE;
/*!40000 ALTER TABLE `detalle_disp_banc` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_disp_banc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_documento`
--

DROP TABLE IF EXISTS `detalle_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_documento` (
  `id_detalle_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_bien_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `no_doc` int(11) DEFAULT NULL,
  `serie_doc` int(11) DEFAULT NULL,
  `id_tipo_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_documento`
--

LOCK TABLES `detalle_documento` WRITE;
/*!40000 ALTER TABLE `detalle_documento` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_documentos`
--

DROP TABLE IF EXISTS `detalle_documentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_documentos` (
  `id_detalle_cv_pk` char(10) NOT NULL,
  `nombre_cuenta` char(10) DEFAULT NULL,
  `codigo_cuenta` char(10) DEFAULT NULL,
  `debe` char(10) DEFAULT NULL,
  `haber` char(10) DEFAULT NULL,
  `id_documento_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_detalle_cv_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_documentos`
--

LOCK TABLES `detalle_documentos` WRITE;
/*!40000 ALTER TABLE `detalle_documentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_documentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_muestreo`
--

DROP TABLE IF EXISTS `detalle_muestreo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_muestreo` (
  `id_encabezado` int(11) NOT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `existencia` char(100) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_encabezado`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_muestreo`
--

LOCK TABLES `detalle_muestreo` WRITE;
/*!40000 ALTER TABLE `detalle_muestreo` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_muestreo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_nomina`
--

DROP TABLE IF EXISTS `detalle_nomina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_nomina` (
  `id_dn` char(10) NOT NULL,
  `id_empleados_pk` char(10) NOT NULL,
  `id_nomina_pk` char(10) NOT NULL,
  `id_presamo_pk` char(10) NOT NULL,
  `id_devengos_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_dn`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_nomina`
--

LOCK TABLES `detalle_nomina` WRITE;
/*!40000 ALTER TABLE `detalle_nomina` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_nomina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_pedido`
--

DROP TABLE IF EXISTS `detalle_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_pedido` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `id_bien_pk` int(11) NOT NULL,
  `cod_pedido` int(11) NOT NULL,
  `item_cod_producto` int(11) NOT NULL,
  `precio` decimal(5,2) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `estado_detalle` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_detalle`,`id_bien_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_pedido`
--

LOCK TABLES `detalle_pedido` WRITE;
/*!40000 ALTER TABLE `detalle_pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_pedido_1`
--

DROP TABLE IF EXISTS `detalle_pedido_1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_pedido_1` (
  `id_detalle_pedido_pk` char(10) NOT NULL,
  `id_encabezado_pedido_pk` char(10) NOT NULL,
  `cantidad` char(10) DEFAULT NULL,
  `id_menu_pk` char(10) DEFAULT NULL,
  `correlativo` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pedido_pk`,`id_encabezado_pedido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_pedido_1`
--

LOCK TABLES `detalle_pedido_1` WRITE;
/*!40000 ALTER TABLE `detalle_pedido_1` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_pedido_1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_pedido_compra`
--

DROP TABLE IF EXISTS `detalle_pedido_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_pedido_compra` (
  `id_detalle_pk` int(11) NOT NULL,
  `id_orden_compra_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_detalle_requisicion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pk`,`id_orden_compra_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_pedido_compra`
--

LOCK TABLES `detalle_pedido_compra` WRITE;
/*!40000 ALTER TABLE `detalle_pedido_compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_pedido_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_pedido_rest`
--

DROP TABLE IF EXISTS `detalle_pedido_rest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_pedido_rest` (
  `cantidad` double DEFAULT '1',
  `id_menu_pk` char(10) DEFAULT NULL,
  `descuento` double DEFAULT '0',
  `orden` int(10) NOT NULL AUTO_INCREMENT,
  `id_encabezado_pedido_pk` char(10) NOT NULL,
  `correlativo` int(10) NOT NULL,
  PRIMARY KEY (`id_encabezado_pedido_pk`,`orden`),
  KEY `Refmenu22` (`id_menu_pk`),
  KEY `holihehe` (`id_menu_pk`,`correlativo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_pedido_rest`
--

LOCK TABLES `detalle_pedido_rest` WRITE;
/*!40000 ALTER TABLE `detalle_pedido_rest` DISABLE KEYS */;
INSERT INTO `detalle_pedido_rest` VALUES (1,'BB',0,1,'20160006',1),(1,'BB',0,2,'20160006',1),(1,'BB',0,3,'20160006',1),(1,'BB',0,4,'20160006',1),(1,'BB',0,5,'20160006',1),(1,'BB',0,6,'20160006',1),(1,'BB',0,7,'20160006',1),(0,'',0,8,'20160006',0),(1,'BB',0,1,'20160007',2),(1,'BB',0,2,'20160007',2),(1,'BB',0,3,'20160007',2),(1,'BB',0,4,'20160007',2),(1,'BB',0,5,'20160007',2),(1,'BB',0,6,'20160007',2),(1,'BB',0,7,'20160007',2),(1,'BB',0,8,'20160007',2),(1,'BB',0,9,'20160007',2),(1,'BB',0,10,'20160007',2),(1,'BB',0,11,'20160007',2),(1,'BB',0,12,'20160007',2),(1,'BB',0,13,'20160007',2),(1,'BB',0,14,'20160007',2),(1,'BB',0,15,'20160007',2),(1,'BB',0,1,'20160008',1),(1,'BB',0,2,'20160008',1),(1,'BB',0,3,'20160008',1),(1,'BB',0,4,'20160008',1),(1,'BB',0,5,'20160008',1),(0,'',0,6,'20160008',0),(1,'BB',0,1,'20160009',2),(1,'PF',0,2,'20160009',1),(0,'',0,3,'20160009',0),(1,'BB',0,1,'20160010',1),(1,'PF',0,2,'20160010',1),(0,'',0,3,'20160010',0),(1,'BB',0,1,'20160011',1),(1,'BB',0,2,'20160011',1),(1,'PF',0,3,'20160011',1),(0,'',0,4,'20160011',0),(1,'BB',0,1,'20160012',1),(1,'BB',0,2,'20160012',1),(1,'BB',0,3,'20160012',1),(1,'BB',0,4,'20160012',1),(1,'BB',0,1,'20160013',1),(1,'BB',0,3,'20160020',1),(1,'BB',0,3,'20160013',1),(1,'BB',0,4,'20160013',1),(250,'PF',0,2,'20160023',2),(1,'BB',0,1,'20160014',1),(1,'BB',0,2,'20160014',1),(1,'BB',0,3,'20160014',1),(1,'BB',0,4,'20160014',1),(1,'PF',0,1,'20160015',1),(1,'BB',0,1,'20160017',2),(1,'BB',0,2,'20160017',2),(1,'BB',0,3,'20160017',2),(1,'PF',0,4,'20160017',1),(1,'PF',0,1,'20160018',1),(1,'BB',0,1,'20160021',1),(1,'BB',0,2,'20160021',1),(1,'BB',0,3,'20160021',1),(1,'BB',0,4,'20160021',1),(500,'PF',0,1,'20160023',1),(1,'BB',0,4,'20160020',1),(400,'BB',50,1,'20160024',6),(8000,'BB',0,9,'20160022',2),(1,'PF',0,8,'20160022',2),(1,'BB',0,7,'20160022',1),(1,'BB',0,1,'20160020',1),(34,'BB',50,1,'20160025',6),(34,'BB',0,2,'20160025',6);
/*!40000 ALTER TABLE `detalle_pedido_rest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_planilla_igss`
--

DROP TABLE IF EXISTS `detalle_planilla_igss`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_planilla_igss` (
  `id_detalle_pigss` char(10) NOT NULL,
  `id_planilla_igss_pk` char(10) NOT NULL,
  `id_empleados_pk` char(10) NOT NULL,
  `sueldo_base` char(10) DEFAULT NULL,
  `porcentaje_igss` char(10) DEFAULT NULL,
  `igss_pagar` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pigss`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_planilla_igss`
--

LOCK TABLES `detalle_planilla_igss` WRITE;
/*!40000 ALTER TABLE `detalle_planilla_igss` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_planilla_igss` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_produccion`
--

DROP TABLE IF EXISTS `detalle_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_produccion` (
  `correlativo` char(10) NOT NULL,
  `id_produccion_pk` char(10) NOT NULL,
  `cantidad_mp` char(10) DEFAULT NULL,
  `id_detalle_pedido_pk` char(10) NOT NULL,
  `id_encabezado_pedido_pk` char(10) NOT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`correlativo`,`id_produccion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_produccion`
--

LOCK TABLES `detalle_produccion` WRITE;
/*!40000 ALTER TABLE `detalle_produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_receta_mp`
--

DROP TABLE IF EXISTS `detalle_receta_mp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_receta_mp` (
  `correlativo` int(11) NOT NULL AUTO_INCREMENT,
  `id_receta_pk` int(11) NOT NULL,
  `cantidad` char(40) DEFAULT NULL,
  `id_proceso_pk` char(20) DEFAULT NULL,
  `id_medida_pk` char(20) DEFAULT NULL,
  `id_bien_pk` char(20) DEFAULT NULL,
  `id_categoria_pk` char(40) DEFAULT NULL,
  PRIMARY KEY (`correlativo`,`id_receta_pk`),
  KEY `Refbien311` (`id_bien_pk`,`id_categoria_pk`),
  KEY `Refproceso301` (`id_proceso_pk`),
  KEY `Refmedida302` (`id_medida_pk`),
  KEY `Refreceta304` (`id_receta_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=77 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_receta_mp`
--

LOCK TABLES `detalle_receta_mp` WRITE;
/*!40000 ALTER TABLE `detalle_receta_mp` DISABLE KEYS */;
INSERT INTO `detalle_receta_mp` VALUES (29,1,'123','1','1','29','mp'),(30,1,'123','1','1','26','mp'),(31,1,'123','4','2','32','mp'),(43,7,'1','1','1','26','mp'),(33,2,'12','2','1','29','mp'),(34,2,'12','1','1','32','mp'),(35,2,'12','1','1','26','mp'),(42,6,'12','2','1','29','mp'),(37,5,'1','1','1','29','mp'),(38,5,'1','1','1','30','mp'),(39,5,'1','1','2','32','mp'),(41,6,'12','1','1','26','mp'),(44,7,'1','5','1','34','mp'),(45,8,'1','1','1','26','mp'),(46,8,'1','3','1','29','mp'),(47,8,'1','2','2','32','mp'),(48,9,'1','1','1','30','mp'),(49,9,'1','5','1','32','mp'),(50,10,'20','8','1','26','mp'),(51,10,'2','7','1','27','mp'),(52,11,'2','10','1','26','mp'),(53,11,'2','12','2','34','mp'),(54,12,'2','8','1','30','mp'),(55,12,'2','8','1','31','mp'),(56,13,'2','8','1','30','mp'),(57,13,'2','8','1','31','mp'),(58,14,'2','8','1','30','mp'),(59,14,'2','8','1','31','mp'),(60,15,'2','8','1','30','mp'),(61,15,'2','8','1','31','mp'),(62,16,'2','8','1','30','mp'),(63,16,'2','8','1','31','mp'),(64,17,'2','8','1','30','mp'),(65,17,'2','8','1','31','mp'),(66,18,'2','8','1','30','mp'),(67,18,'2','8','1','31','mp'),(68,19,'2','8','1','30','mp'),(69,19,'2','8','1','31','mp'),(70,20,'2','8','1','30','mp'),(71,20,'2','8','1','31','mp'),(72,21,'2','11','1','27','mp'),(73,21,'4','11','1','28','mp'),(74,21,'0.25','12','2','34','mp'),(75,22,'20','8','1','31','mp'),(76,22,'10','8','1','29','mp');
/*!40000 ALTER TABLE `detalle_receta_mp` ENABLE KEYS */;
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
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_requisicion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_requisicion`
--

LOCK TABLES `detalle_requisicion` WRITE;
/*!40000 ALTER TABLE `detalle_requisicion` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_requisicion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deuda`
--

DROP TABLE IF EXISTS `deuda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deuda` (
  `id_deuda` int(11) NOT NULL AUTO_INCREMENT,
  `monto` char(10) DEFAULT NULL,
  `saldo_total` char(10) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_fac_empresa_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_deuda`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deuda`
--

LOCK TABLES `deuda` WRITE;
/*!40000 ALTER TABLE `deuda` DISABLE KEYS */;
/*!40000 ALTER TABLE `deuda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devengos`
--

DROP TABLE IF EXISTS `devengos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devengos` (
  `id_devengos_pk` char(10) NOT NULL,
  `nombre` char(10) DEFAULT NULL,
  `detalle` char(10) DEFAULT NULL,
  `cantidad_debengado` char(10) DEFAULT NULL,
  `cuotas` char(10) DEFAULT NULL,
  `fecha` char(10) DEFAULT NULL,
  `id_empleados_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_devengos_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devengos`
--

LOCK TABLES `devengos` WRITE;
/*!40000 ALTER TABLE `devengos` DISABLE KEYS */;
/*!40000 ALTER TABLE `devengos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `disponibilidad_bancaria`
--

DROP TABLE IF EXISTS `disponibilidad_bancaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `disponibilidad_bancaria` (
  `id_disponibilidad_bancaria` char(10) NOT NULL,
  `fecha` char(10) DEFAULT NULL,
  `id_cuenta_bancaria_pk` char(10) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_tipo_documento` char(10) NOT NULL,
  PRIMARY KEY (`id_disponibilidad_bancaria`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disponibilidad_bancaria`
--

LOCK TABLES `disponibilidad_bancaria` WRITE;
/*!40000 ALTER TABLE `disponibilidad_bancaria` DISABLE KEYS */;
/*!40000 ALTER TABLE `disponibilidad_bancaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `documento`
--

DROP TABLE IF EXISTS `documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `documento` (
  `id_documento_pk` char(10) NOT NULL,
  `conciliado` char(10) DEFAULT NULL,
  `fecha` char(10) DEFAULT NULL,
  `valor_total` char(10) DEFAULT NULL,
  `destinatario` char(10) DEFAULT NULL,
  `no_documento` char(10) DEFAULT NULL,
  `descripcion` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_fac_pk` int(11) DEFAULT NULL,
  `id_cuenta_bancaria_pk` char(10) NOT NULL,
  `id_tipo_documento` char(10) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_cuenta_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_documento_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `documento`
--

LOCK TABLES `documento` WRITE;
/*!40000 ALTER TABLE `documento` DISABLE KEYS */;
/*!40000 ALTER TABLE `documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
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
  PRIMARY KEY (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES ('201','Papajohns',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1),('202','Chaca',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1),('203','Chacax',NULL,NULL,NULL,'1966','2016-10-21',NULL,'217006951',NULL,2,1),('204','Sebastian',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1),('206','johnny',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1);
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empresa` (
  `id_empresa_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `direccion` varchar(30) NOT NULL,
  `region` char(20) NOT NULL,
  `estrellas_hotel` varchar(15) NOT NULL,
  `nit` char(10) DEFAULT NULL,
  `correo` char(35) DEFAULT NULL,
  `telefono` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_empresa_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
INSERT INTO `empresa` VALUES (1,'CHRIX','ciudad','norte','5',NULL,NULL,NULL),(2,'CHRIS','ciudad','norte','5',NULL,NULL,NULL),(3,'MARVS','ciudad','norte','5',NULL,NULL,NULL),(4,'GABY','ciudad','norte','5',NULL,NULL,NULL),(5,'GABY','ciudad','norte','5',NULL,NULL,NULL),(6,'GABY','ciudad','norte','5',NULL,NULL,NULL);
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_documento`
--

DROP TABLE IF EXISTS `encabezado_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `encabezado_documento` (
  `no_doc` int(11) NOT NULL,
  `serie_doc` int(11) NOT NULL,
  `id_tipo_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `empresa` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`no_doc`,`serie_doc`,`id_tipo_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_documento`
--

LOCK TABLES `encabezado_documento` WRITE;
/*!40000 ALTER TABLE `encabezado_documento` DISABLE KEYS */;
/*!40000 ALTER TABLE `encabezado_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_muestreo`
--

DROP TABLE IF EXISTS `encabezado_muestreo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `encabezado_muestreo` (
  `id_encabezado` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `responsable` char(50) DEFAULT NULL,
  PRIMARY KEY (`id_encabezado`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_muestreo`
--

LOCK TABLES `encabezado_muestreo` WRITE;
/*!40000 ALTER TABLE `encabezado_muestreo` DISABLE KEYS */;
/*!40000 ALTER TABLE `encabezado_muestreo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_pedido`
--

DROP TABLE IF EXISTS `encabezado_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `encabezado_pedido` (
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
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_pedido`
--

LOCK TABLES `encabezado_pedido` WRITE;
/*!40000 ALTER TABLE `encabezado_pedido` DISABLE KEYS */;
INSERT INTO `encabezado_pedido` VALUES ('20160001','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160002','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160003','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160004','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160005','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160006','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160007','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160008','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160009','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160010','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160011','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160012','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160013','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160014','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160015','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160016','','1','2016-10-27','2016-10-27','','203','2','pend'),('20160017','','','2016-10-27','2016-10-27','','203','2','pend'),('20160018','','','2016-10-27','2016-10-27','','203','2','pend'),('20160019','','','2016-10-27','2016-10-27','','203','2','pend'),('20160020','','','2016-10-27','2016-10-27','','203','2','pend'),('20160021','','1','2016-10-28','2016-10-28','','203','2','pend'),('20160022','15:35:25','1','2016-10-28','2016-10-28','12:30pm','203','2','pend'),('20160023','18:40:03','1','2016-10-28','2016-10-28','','201','1','pend'),('20160024','17:45:04','1','2016-11-02','2016-11-02','','203','2','pend'),('20160025','09:52:28','1','2016-11-03','2016-11-03','','203','2','pend');
/*!40000 ALTER TABLE `encabezado_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `evento` (
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
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura` (
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
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura_detalle`
--

DROP TABLE IF EXISTS `factura_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura_detalle` (
  `id_bien_pk` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio` int(11) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_fac_empresa_pk`,`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura_detalle`
--

LOCK TABLES `factura_detalle` WRITE;
/*!40000 ALTER TABLE `factura_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura_pago`
--

DROP TABLE IF EXISTS `factura_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura_pago` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_forma_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_forma_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura_pago`
--

LOCK TABLES `factura_pago` WRITE;
/*!40000 ALTER TABLE `factura_pago` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `folio`
--

DROP TABLE IF EXISTS `folio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `folio` (
  `id_cuenta_pagar_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado` varchar(10) NOT NULL,
  `fecha_ingreso` date NOT NULL,
  `fecha_pago` date DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_cuenta_pagar_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `folio`
--

LOCK TABLES `folio` WRITE;
/*!40000 ALTER TABLE `folio` DISABLE KEYS */;
/*!40000 ALTER TABLE `folio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `folio_bien`
--

DROP TABLE IF EXISTS `folio_bien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `folio_bien` (
  `id_folio_bien_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_folio_bien_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `folio_bien`
--

LOCK TABLES `folio_bien` WRITE;
/*!40000 ALTER TABLE `folio_bien` DISABLE KEYS */;
/*!40000 ALTER TABLE `folio_bien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `folio_factura`
--

DROP TABLE IF EXISTS `folio_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `folio_factura` (
  `id_cuenta_pagar_pk` int(11) NOT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_cuenta_pagar_pk`,`id_fac_empresa_pk`,`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `folio_factura`
--

LOCK TABLES `folio_factura` WRITE;
/*!40000 ALTER TABLE `folio_factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `folio_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `folio_habitacion`
--

DROP TABLE IF EXISTS `folio_habitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `folio_habitacion` (
  `id_folio_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_habitacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `folio_habitacion`
--

LOCK TABLES `folio_habitacion` WRITE;
/*!40000 ALTER TABLE `folio_habitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `folio_habitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `folio_promocion`
--

DROP TABLE IF EXISTS `folio_promocion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `folio_promocion` (
  `id_folio_promocion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` int(11) NOT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_promocion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `folio_promocion`
--

LOCK TABLES `folio_promocion` WRITE;
/*!40000 ALTER TABLE `folio_promocion` DISABLE KEYS */;
/*!40000 ALTER TABLE `folio_promocion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `folio_salon`
--

DROP TABLE IF EXISTS `folio_salon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `folio_salon` (
  `id_folio_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `costo` decimal(10,2) NOT NULL,
  `id_cuenta_pagar_pk` int(11) DEFAULT NULL,
  `id_salon_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_folio_salon_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `folio_salon`
--

LOCK TABLES `folio_salon` WRITE;
/*!40000 ALTER TABLE `folio_salon` DISABLE KEYS */;
/*!40000 ALTER TABLE `folio_salon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `forma_pago`
--

DROP TABLE IF EXISTS `forma_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `forma_pago` (
  `id_forma_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_pago` char(25) DEFAULT NULL,
  `descripcion` char(50) DEFAULT NULL,
  PRIMARY KEY (`id_forma_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `forma_pago`
--

LOCK TABLES `forma_pago` WRITE;
/*!40000 ALTER TABLE `forma_pago` DISABLE KEYS */;
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
  `id_factura_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_importacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gastos_importacion`
--

LOCK TABLES `gastos_importacion` WRITE;
/*!40000 ALTER TABLE `gastos_importacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `gastos_importacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `habitacion`
--

DROP TABLE IF EXISTS `habitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `habitacion` (
  `id_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `nivel` int(11) DEFAULT NULL,
  `estrellas_habitacion` varchar(10) NOT NULL,
  `descripcion` varchar(10) DEFAULT NULL,
  `estado` char(10) NOT NULL,
  `id_tipo_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_habitacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `habitacion`
--

LOCK TABLES `habitacion` WRITE;
/*!40000 ALTER TABLE `habitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `habitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horas_extra`
--

DROP TABLE IF EXISTS `horas_extra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horas_extra` (
  `id_horas_extra_pk` char(10) NOT NULL,
  `fecha_inicio` char(10) DEFAULT NULL,
  `fecha_fin` char(10) DEFAULT NULL,
  `horas_extra` char(10) DEFAULT NULL,
  `monto_horas_extra` char(10) DEFAULT NULL,
  `sueldo_horas_extra` char(10) DEFAULT NULL,
  `id_devengos_pk` char(10) NOT NULL,
  PRIMARY KEY (`id_horas_extra_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horas_extra`
--

LOCK TABLES `horas_extra` WRITE;
/*!40000 ALTER TABLE `horas_extra` DISABLE KEYS */;
/*!40000 ALTER TABLE `horas_extra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `impuesto`
--

DROP TABLE IF EXISTS `impuesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `impuesto` (
  `id_impuesto_pk` int(11) NOT NULL AUTO_INCREMENT,
  `porcentaje` decimal(18,2) DEFAULT NULL,
  `nombre` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_impuesto_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `impuesto`
--

LOCK TABLES `impuesto` WRITE;
/*!40000 ALTER TABLE `impuesto` DISABLE KEYS */;
/*!40000 ALTER TABLE `impuesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invitado`
--

DROP TABLE IF EXISTS `invitado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invitado` (
  `id_invitado_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `dpi` varchar(20) DEFAULT NULL,
  `correo` varchar(30) DEFAULT NULL,
  `id_evento_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_invitado_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invitado`
--

LOCK TABLES `invitado` WRITE;
/*!40000 ALTER TABLE `invitado` DISABLE KEYS */;
/*!40000 ALTER TABLE `invitado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marca` (
  `id_marca_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_marca` char(50) DEFAULT NULL,
  PRIMARY KEY (`id_marca_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca_producto`
--

DROP TABLE IF EXISTS `marca_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marca_producto` (
  `id_marca_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `fecha` date DEFAULT NULL,
  `precio` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`id_marca_pk`,`id_bien_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca_producto`
--

LOCK TABLES `marca_producto` WRITE;
/*!40000 ALTER TABLE `marca_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `marca_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medida`
--

DROP TABLE IF EXISTS `medida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medida` (
  `id_medida_pk` int(11) NOT NULL AUTO_INCREMENT,
  `valor` char(10) DEFAULT NULL,
  `nombre_medida` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_medida_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medida`
--

LOCK TABLES `medida` WRITE;
/*!40000 ALTER TABLE `medida` DISABLE KEYS */;
INSERT INTO `medida` VALUES (1,'0.7','gr'),(2,'0.5','lt');
/*!40000 ALTER TABLE `medida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medida_1`
--

DROP TABLE IF EXISTS `medida_1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medida_1` (
  `id_medida_pk` char(10) NOT NULL,
  `valor` char(10) DEFAULT NULL,
  `nombre_medida` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_medida_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medida_1`
--

LOCK TABLES `medida_1` WRITE;
/*!40000 ALTER TABLE `medida_1` DISABLE KEYS */;
/*!40000 ALTER TABLE `medida_1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menu` (
  `id_menu_pk` char(10) NOT NULL,
  `correlativo` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` char(50) DEFAULT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `id_receta_pk` char(10) DEFAULT NULL,
  `id_precio` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_menu_pk`,`correlativo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES ('PF',1,'Carne asada',NULL,NULL,4),('PF',2,'Carne adobada',NULL,NULL,4),('PF',3,'Carnitas',NULL,NULL,4),('PF',4,'hoho',NULL,NULL,4),('BB',1,'Cerveza',NULL,NULL,1),('BB',2,'Cerveza',NULL,NULL,6),('PF',5,'Pierna','','9',5),('PF',6,'Pierna','','11',5),('PF',7,'Pollo con salsa especial','','9',5),('BB',3,'Licuado Verde','','10',5),('PF',8,'Wasabi','','2',11),('BB',4,'Frozzen azul','','10',12),('BB',5,'Nieve','','7',13),('BB',6,'Smoothie Fresa','Licuado con la fruta más fresca y los ingredientes de mejor calidad','10',7),('BB',7,'Licuado mix','Licuado organico de frutas mixtas','10',8);
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_inventario`
--

DROP TABLE IF EXISTS `movimiento_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimiento_inventario` (
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
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_inventario`
--

LOCK TABLES `movimiento_inventario` WRITE;
/*!40000 ALTER TABLE `movimiento_inventario` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nomina`
--

DROP TABLE IF EXISTS `nomina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nomina` (
  `id_nomina_pk` char(10) NOT NULL,
  `fecha` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_nomina_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nomina`
--

LOCK TABLES `nomina` WRITE;
/*!40000 ALTER TABLE `nomina` DISABLE KEYS */;
/*!40000 ALTER TABLE `nomina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `obj_perdido`
--

DROP TABLE IF EXISTS `obj_perdido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `obj_perdido` (
  `id_obj_perdido_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` char(30) NOT NULL,
  `descripcion` char(100) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_obj_perdido_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `obj_perdido`
--

LOCK TABLES `obj_perdido` WRITE;
/*!40000 ALTER TABLE `obj_perdido` DISABLE KEYS */;
/*!40000 ALTER TABLE `obj_perdido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `operacion`
--

DROP TABLE IF EXISTS `operacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `operacion` (
  `id_operacion` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` char(10) DEFAULT NULL,
  `descripcion` char(10) DEFAULT NULL,
  `fecha_emision` char(10) DEFAULT NULL,
  `id_deuda` int(11) DEFAULT NULL,
  `id_doc` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_operacion`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operacion`
--

LOCK TABLES `operacion` WRITE;
/*!40000 ALTER TABLE `operacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `operacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orden_pedido_compra`
--

DROP TABLE IF EXISTS `orden_pedido_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orden_pedido_compra` (
  `id_orden_compra_pk` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `encargado` char(25) DEFAULT NULL,
  `estado_pedido` char(20) DEFAULT NULL,
  `observaciones` char(30) DEFAULT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `id_requisicion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_orden_compra_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orden_pedido_compra`
--

LOCK TABLES `orden_pedido_compra` WRITE;
/*!40000 ALTER TABLE `orden_pedido_compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `orden_pedido_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paquete_inventario`
--

DROP TABLE IF EXISTS `paquete_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paquete_inventario` (
  `id_paquete_inventario` int(11) NOT NULL AUTO_INCREMENT,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_paquete_inventario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paquete_inventario`
--

LOCK TABLES `paquete_inventario` WRITE;
/*!40000 ALTER TABLE `paquete_inventario` DISABLE KEYS */;
/*!40000 ALTER TABLE `paquete_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paquetes_eventos`
--

DROP TABLE IF EXISTS `paquetes_eventos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paquetes_eventos` (
  `id_paquetes_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_evento_pk` int(11) DEFAULT NULL,
  `id_promocion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_paquetes_salon_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paquetes_eventos`
--

LOCK TABLES `paquetes_eventos` WRITE;
/*!40000 ALTER TABLE `paquetes_eventos` DISABLE KEYS */;
/*!40000 ALTER TABLE `paquetes_eventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paquetes_reservacion_habitacion`
--

DROP TABLE IF EXISTS `paquetes_reservacion_habitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paquetes_reservacion_habitacion` (
  `id_paquetes_reservacion_habitacion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_promocion_pk` int(11) DEFAULT NULL,
  `id_reserhabit_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_paquetes_reservacion_habitacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paquetes_reservacion_habitacion`
--

LOCK TABLES `paquetes_reservacion_habitacion` WRITE;
/*!40000 ALTER TABLE `paquetes_reservacion_habitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `paquetes_reservacion_habitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido_cotizacion`
--

DROP TABLE IF EXISTS `pedido_cotizacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido_cotizacion` (
  `id_cotizacion_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_cotizacion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido_cotizacion`
--

LOCK TABLES `pedido_cotizacion` WRITE;
/*!40000 ALTER TABLE `pedido_cotizacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedido_cotizacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido_factura`
--

DROP TABLE IF EXISTS `pedido_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido_factura` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido_factura`
--

LOCK TABLES `pedido_factura` WRITE;
/*!40000 ALTER TABLE `pedido_factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedido_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil`
--

DROP TABLE IF EXISTS `perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `perfil` (
  `id_perfil` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_perfil` char(40) DEFAULT NULL,
  PRIMARY KEY (`id_perfil`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil`
--

LOCK TABLES `perfil` WRITE;
/*!40000 ALTER TABLE `perfil` DISABLE KEYS */;
INSERT INTO `perfil` VALUES (1,'colocador'),(2,'holis'),(3,'holis'),(4,'cajero'),(5,'cociinero'),(6,'holi');
/*!40000 ALTER TABLE `perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_privilegios`
--

DROP TABLE IF EXISTS `perfil_privilegios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `perfil_privilegios` (
  `id_aplicacion` int(11) NOT NULL,
  `id_perfil` int(11) NOT NULL,
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_aplicacion`,`id_perfil`),
  KEY `Refperfil4` (`id_perfil`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_privilegios`
--

LOCK TABLES `perfil_privilegios` WRITE;
/*!40000 ALTER TABLE `perfil_privilegios` DISABLE KEYS */;
INSERT INTO `perfil_privilegios` VALUES (10204,1,1,0,0,0),(10204,2,1,1,0,0),(10204,3,1,1,0,0),(10204,4,1,0,0,0),(10204,5,1,1,0,1),(10204,6,0,1,1,0);
/*!40000 ALTER TABLE `perfil_privilegios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `planilla_igss`
--

DROP TABLE IF EXISTS `planilla_igss`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `planilla_igss` (
  `id_planilla_igss_pk` char(10) NOT NULL,
  `sueldo` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_planilla_igss_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `planilla_igss`
--

LOCK TABLES `planilla_igss` WRITE;
/*!40000 ALTER TABLE `planilla_igss` DISABLE KEYS */;
/*!40000 ALTER TABLE `planilla_igss` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `precio`
--

DROP TABLE IF EXISTS `precio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `precio` (
  `id_precio` int(11) NOT NULL AUTO_INCREMENT,
  `precio` double NOT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_tamaniop_pk` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_precio`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `precio`
--

LOCK TABLES `precio` WRITE;
/*!40000 ALTER TABLE `precio` DISABLE KEYS */;
INSERT INTO `precio` VALUES (1,20,NULL,'1','1'),(2,49,NULL,'2','2'),(3,49,NULL,'2','2'),(4,4,NULL,'3','3'),(5,45,NULL,'4','5'),(6,45,NULL,'3','5'),(7,100,NULL,'pt','12'),(8,100,NULL,'pt','12');
/*!40000 ALTER TABLE `precio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `problema`
--

DROP TABLE IF EXISTS `problema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `problema` (
  `id_problema_pk` int(11) NOT NULL AUTO_INCREMENT,
  `asunto` char(20) NOT NULL,
  `descripcion` char(100) NOT NULL,
  `fecha` date NOT NULL,
  `estado` char(20) NOT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_problema_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `problema`
--

LOCK TABLES `problema` WRITE;
/*!40000 ALTER TABLE `problema` DISABLE KEYS */;
/*!40000 ALTER TABLE `problema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proceso`
--

DROP TABLE IF EXISTS `proceso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proceso` (
  `id_proceso_pk` int(11) NOT NULL AUTO_INCREMENT,
  `observacion` char(100) DEFAULT NULL,
  `caracteristica_proceso` char(100) DEFAULT NULL,
  `nombre_proceso` char(20) DEFAULT NULL,
  `tiempo_proceso` char(10) DEFAULT NULL,
  `medida_tiempo` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_proceso_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proceso`
--

LOCK TABLES `proceso` WRITE;
/*!40000 ALTER TABLE `proceso` DISABLE KEYS */;
INSERT INTO `proceso` VALUES (1,'cocer por 30  minutos','cocer por 30  minutos','Cocido','12','minutos'),(2,'estilar el aceite por 2 minutos','colocarlas en el recipiente y colocar 5ml de aceite','Freir papas','5','minutos'),(3,'dejar en la refri por 6 horas','Colocar ingredientes necesarios','Sazonar Carne','5','Horas'),(4,'la carne debe estar a un altura de 10 centimetros','Colocar Carne en las brasas a fuego lento','Ahumar Carne','34','Minutos'),(5,'se debe realizar cuidadosamente','se debe hornear a fuego lento','Hornear','50','Minutos'),(6,'ninguna','se debe machar','Machacar','2','Minutos'),(7,'dorar','dorar','dorar','7','Minutos'),(8,'Pica pica','Picar bien','Picar','1','Minutos'),(9,'asdfasfadsfasfa','asfafdsfasf','pelar papas','58','Minutos'),(10,'Quitar las semillas antes de licuar','Licua bien durante el proceso','Licuar','1','Horas'),(11,'Quitar las semillas antes de licuar','Licua bien durante el proceso','Licuar','1','Horas'),(12,'Verificar caducidad de leche','Vertir cuidadosamente','Agregar','1','Horas'),(13,'No aplique demasiada fuerza en caso de ser materia prima sensible u oxidable','Mezcle homogeneamente todos los ingredientes','Mezclar','0','Minutos');
/*!40000 ALTER TABLE `proceso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produccion`
--

DROP TABLE IF EXISTS `produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produccion` (
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
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produccion`
--

LOCK TABLES `produccion` WRITE;
/*!40000 ALTER TABLE `produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto_bodega`
--

DROP TABLE IF EXISTS `producto_bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto_bodega` (
  `id_bien_pk` int(11) NOT NULL,
  `id_bodega_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `existencia` int(11) DEFAULT NULL,
  `existencia_congelada` int(11) DEFAULT NULL,
  `existencia_auditada` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_bodega_pk`,`id_categoria_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto_bodega`
--

LOCK TABLES `producto_bodega` WRITE;
/*!40000 ALTER TABLE `producto_bodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto_bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `promocion`
--

DROP TABLE IF EXISTS `promocion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `promocion` (
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
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `promocion`
--

LOCK TABLES `promocion` WRITE;
/*!40000 ALTER TABLE `promocion` DISABLE KEYS */;
/*!40000 ALTER TABLE `promocion` ENABLE KEYS */;
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
  `direccion` date DEFAULT NULL,
  `telefono` char(15) DEFAULT NULL,
  `correo_electronico` char(50) DEFAULT NULL,
  PRIMARY KEY (`id_proveedor_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receta`
--

DROP TABLE IF EXISTS `receta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receta` (
  `id_receta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_receta` char(30) DEFAULT NULL,
  `horas_hombre` float(8,0) DEFAULT NULL,
  `costo_receta` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_receta_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receta`
--

LOCK TABLES `receta` WRITE;
/*!40000 ALTER TABLE `receta` DISABLE KEYS */;
INSERT INTO `receta` VALUES (1,'Salsa Roja',24,'100'),(2,'Salsa verde',24,'100'),(3,'Salsa Amarilla',5,'50'),(4,'Salsa azul',17,'100'),(5,'Salsa ChampiÃ±ones',36,'150'),(6,'Conserva',17,'100'),(7,'Salsa de leche',62,'100'),(8,'asd',22,'150'),(9,'Salsa especial',62,'100'),(10,'licuado',8,'100'),(11,'Salsinha',25,'150'),(12,'Hambuguesiña',2,'100'),(13,'Hambuguesiña',2,'100'),(14,'Hambuguesiña',2,'100'),(15,'Hambuguesiña',2,'100'),(16,'Hambuguesiña',2,'100'),(17,'Hambuguesiña',2,'100'),(18,'Hambuguesiña',2,'100'),(19,'Hambuguesiña',2,'100'),(20,'Hambuguesiña',2,'100'),(21,'Licuado mixto',3,'150'),(22,'Vegetales al dente',2,'100');
/*!40000 ALTER TABLE `receta` ENABLE KEYS */;
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
  `id_detalle_requisicion_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_requisicion_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requisicion`
--

LOCK TABLES `requisicion` WRITE;
/*!40000 ALTER TABLE `requisicion` DISABLE KEYS */;
/*!40000 ALTER TABLE `requisicion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservacion_habitacion`
--

DROP TABLE IF EXISTS `reservacion_habitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reservacion_habitacion` (
  `id_reserhabit_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_entreda` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `hora_entreda` time NOT NULL,
  `hora_salida` time NOT NULL,
  `id_cliente_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_reserhabit_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservacion_habitacion`
--

LOCK TABLES `reservacion_habitacion` WRITE;
/*!40000 ALTER TABLE `reservacion_habitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservacion_habitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salon`
--

DROP TABLE IF EXISTS `salon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salon` (
  `id_salon_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `descripcion` varchar(20) NOT NULL,
  `dimiencion` varchar(20) NOT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_salon_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salon`
--

LOCK TABLES `salon` WRITE;
/*!40000 ALTER TABLE `salon` DISABLE KEYS */;
/*!40000 ALTER TABLE `salon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tamanio_porcion`
--

DROP TABLE IF EXISTS `tamanio_porcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tamanio_porcion` (
  `tamanio` varchar(100) NOT NULL,
  `id_tamaniop_pk` int(10) NOT NULL AUTO_INCREMENT,
  `valor` int(10) DEFAULT NULL,
  PRIMARY KEY (`id_tamaniop_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tamanio_porcion`
--

LOCK TABLES `tamanio_porcion` WRITE;
/*!40000 ALTER TABLE `tamanio_porcion` DISABLE KEYS */;
INSERT INTO `tamanio_porcion` VALUES ('8 grms',12,1),('16 grms',13,2);
/*!40000 ALTER TABLE `tamanio_porcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiempo_vida`
--

DROP TABLE IF EXISTS `tiempo_vida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiempo_vida` (
  `id_tiempo_vida_pk` char(10) NOT NULL,
  `fecha_prod` char(10) DEFAULT NULL,
  `tiempo_caducidad` char(10) DEFAULT NULL,
  `fecha_vencimiento` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_tiempo_vida_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiempo_vida`
--

LOCK TABLES `tiempo_vida` WRITE;
/*!40000 ALTER TABLE `tiempo_vida` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiempo_vida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo`
--

DROP TABLE IF EXISTS `tipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo` (
  `id_tipo_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nivel_tipo` char(100) DEFAULT NULL,
  `capacidad_tipo` int(11) DEFAULT NULL,
  `especificaciones_tipo` varchar(1000) DEFAULT NULL,
  `costo_tipo` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo`
--

LOCK TABLES `tipo` WRITE;
/*!40000 ALTER TABLE `tipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `usuario` char(50) NOT NULL,
  `contrasenia` char(80) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleados_pk` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('hola','MQAyADMA','2016-10-20',NULL,'202',1),('hoho','MQAyADMA','2016-10-21',NULL,'204',1),('johnny','aABvAGwAYQA=','2016-10-19','activo','203',2),('sebastianrules','hola','2016-10-20',NULL,'204',1),('usuariodbs','aABvAGwAYQA=',NULL,NULL,'201',1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_privilegios`
--

DROP TABLE IF EXISTS `usuario_privilegios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_privilegios` (
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
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_privilegios`
--

LOCK TABLES `usuario_privilegios` WRITE;
/*!40000 ALTER TABLE `usuario_privilegios` DISABLE KEYS */;
INSERT INTO `usuario_privilegios` VALUES ('hola',10204,0,1,1,0,0),('hoho',10204,1,0,0,0,0),('hjadsfhadsfjkasfhjadsflk',10204,1,1,1,0,0),('sebastianrules',10204,1,1,1,1,0);
/*!40000 ALTER TABLE `usuario_privilegios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'hotelsancarlos'
--

--
-- Dumping routines for database 'hotelsancarlos'
--
/*!50003 DROP FUNCTION IF EXISTS `generador_correlativo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
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
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `ValidarContrasena` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
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
END IF ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
create user dumpy identified by 'dumpy';   
 
GRANT ALL PRIVILEGES ON hotelsancarlos.* TO 'dumpy'@'localhost' WITH GRANT OPTION;
GRANT ALL PRIVILEGES ON hotelsancarlos.* TO 'dumpy'@'%' WITH GRANT OPTION;


GRANT EXECUTE, PROCESS, SELECT, SHOW DATABASES, SHOW VIEW, ALTER, ALTER ROUTINE,
    CREATE, CREATE ROUTINE, CREATE TEMPORARY TABLES, CREATE VIEW, DELETE, DROP,
    EVENT, INDEX, INSERT, REFERENCES, TRIGGER, UPDATE, CREATE USER, FILE,
    LOCK TABLES, RELOAD, REPLICATION CLIENT, REPLICATION SLAVE, SHUTDOWN,
    SUPER
        ON *.* TO dumpy@'%'
    WITH GRANT OPTION;
GRANT EXECUTE, PROCESS, SELECT, SHOW DATABASES, SHOW VIEW, ALTER, ALTER ROUTINE,
    CREATE, CREATE ROUTINE, CREATE TEMPORARY TABLES, CREATE VIEW, DELETE, DROP,
    EVENT, INDEX, INSERT, REFERENCES, TRIGGER, UPDATE, CREATE USER, FILE,
    LOCK TABLES, RELOAD, REPLICATION CLIENT, REPLICATION SLAVE, SHUTDOWN,
    SUPER
        ON *.* TO dumpy@'localhost'
    WITH GRANT OPTION;
flush privileges;    

  /*USUARIO QUE DEBERA UTILIZARSE PARA ENTRAR AL SISTEMA*/  
  
create user usuariodbs identified by 'aABvAGwAYQA='; /* LA CONTRASEÑA CON LA QUE DEBEN INGRESAR SERA: hola*/
 
/*GRANT ALL PRIVILEGES ON sancarlos2.* TO 'dumpy'@'%' WITH GRANT OPTION;*/


GRANT EXECUTE, PROCESS, SELECT, SHOW DATABASES, SHOW VIEW, ALTER, ALTER ROUTINE,
    CREATE, CREATE ROUTINE, CREATE TEMPORARY TABLES, CREATE VIEW, DELETE, DROP,
    EVENT, INDEX, INSERT, REFERENCES, TRIGGER, UPDATE, CREATE USER, FILE,
    LOCK TABLES, RELOAD, REPLICATION CLIENT, REPLICATION SLAVE, SHUTDOWN,
    SUPER
        ON *.* TO usuariodbs@'%'
    WITH GRANT OPTION;
flush privileges;
GRANT EXECUTE, PROCESS, SELECT, SHOW DATABASES, SHOW VIEW, ALTER, ALTER ROUTINE,
    CREATE, CREATE ROUTINE, CREATE TEMPORARY TABLES, CREATE VIEW, DELETE, DROP,
    EVENT, INDEX, INSERT, REFERENCES, TRIGGER, UPDATE, CREATE USER, FILE,
    LOCK TABLES, RELOAD, REPLICATION CLIENT, REPLICATION SLAVE, SHUTDOWN,
    SUPER
        ON *.* TO usuariodbs@'localhost'
    WITH GRANT OPTION;
    
flush privileges;
-- Dump completed on 2016-11-03 10:01:19

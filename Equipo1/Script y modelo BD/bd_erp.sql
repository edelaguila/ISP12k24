CREATE DATABASE  IF NOT EXISTS `bd_erp` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `bd_erp`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_erp
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_aplicaciones`
--

DROP TABLE IF EXISTS `tbl_aplicaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_aplicaciones` (
  `pk_id_aplicacion` int(11) NOT NULL,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(150) NOT NULL,
  `estado_aplicacion` tinyint(4) DEFAULT 0,
  PRIMARY KEY (`pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_aplicaciones`
--

LOCK TABLES `tbl_aplicaciones` WRITE;
/*!40000 ALTER TABLE `tbl_aplicaciones` DISABLE KEYS */;
INSERT INTO `tbl_aplicaciones` VALUES (1,'Menu','Ingreso Login',1),(999,'Cerrar Sesion','Cerrar Sesion',1),(1000,'MDI SEGURIDAD','PARA SEGURIDAD',1),(1001,'Mant. Usuario','PARA SEGURIDAD',1),(1002,'Mant. Aplicación','PARA SEGURIDAD',1),(1003,'Mant. Modulo','PARA SEGURIDAD',1),(1004,'Mant. Perfil','PARA SEGURIDAD',1),(1101,'Asign. Modulo Aplicacion','PARA SEGURIDAD',1),(1102,'Asign. Aplicacion Perfil','PARA SEGURIDAD',1),(1103,'Asign. Perfil Usuario','PARA SEGURIDAD',1),(1201,'Pcs. Cambio Contraseña','PARA SEGURIDAD',1),(1301,'Pcs. BITACORA','PARA SEGURIDAD',1),(8000,'MDI PROTOTIPO ERP','PARA ERP',1),(8001,'Mant. Proveedor','PARA ERP',1),(8002,'Mant. Transacciones Proveedor','PARA ERP',1),(8003,'Mant. Clientes','PARA ERP',1),(8004,'Mant. Vendedores','PARA ERP',1),(8005,'Mant. Productos','PARA ERP',1),(8006,'Mant. Mov. Inventario','PARA ERP',1),(8007,'Mant. Bancos','PARA ERP',1),(8008,'Mant. Movimiento Bancos','PARA ERP',1),(8009,'Mant. Tipo de Cambio','PARA ERP',1),(8010,'Pro. Ordenes de Compra','PARA ERP',1),(8011,'Pro. Compras','PARA ERP',1),(8012,'Pro. Factura por Pagar','PARA ERP',1),(8013,'Pro. Movimiento Proveedores','PARA ERP',1),(8014,'Pro. Cotizacion de Ventas','PARA ERP',1),(8015,'Pro. Pedidos','PARA ERP',1),(8016,'Pro. Facturas por Cobrar','PARA ERP',1),(8017,'Pro. Traslado de Producto','PARA ERP',1),(8018,'Pro. Auditoría de Inventario','PARA ERP',1),(8019,'Pro. Movimiento Bancario','PARA ERP',1),(8020,'Pro. Autorizacion Ordenes','PARA ERP',1),(8021,'Pro. Disponibilidad Diaria','PARA ERP',1);
/*!40000 ALTER TABLE `tbl_aplicaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asignacionesperfilsusuario`
--

DROP TABLE IF EXISTS `tbl_asignacionesperfilsusuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacionesperfilsusuario` (
  `fk_id_usuario` int(11) NOT NULL,
  `fk_id_perfil` int(11) NOT NULL,
  PRIMARY KEY (`fk_id_usuario`,`fk_id_perfil`),
  KEY `fk_id_perfil` (`fk_id_perfil`),
  CONSTRAINT `tbl_asignacionesperfilsusuario_ibfk_1` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  CONSTRAINT `tbl_asignacionesperfilsusuario_ibfk_2` FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignacionesperfilsusuario`
--

LOCK TABLES `tbl_asignacionesperfilsusuario` WRITE;
/*!40000 ALTER TABLE `tbl_asignacionesperfilsusuario` DISABLE KEYS */;
INSERT INTO `tbl_asignacionesperfilsusuario` VALUES (1,1);
/*!40000 ALTER TABLE `tbl_asignacionesperfilsusuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asignacionmoduloaplicacion`
--

DROP TABLE IF EXISTS `tbl_asignacionmoduloaplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacionmoduloaplicacion` (
  `fk_id_modulos` int(11) NOT NULL,
  `fk_id_aplicacion` int(11) NOT NULL,
  PRIMARY KEY (`fk_id_modulos`,`fk_id_aplicacion`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`),
  CONSTRAINT `tbl_asignacionmoduloaplicacion_ibfk_1` FOREIGN KEY (`fk_id_modulos`) REFERENCES `tbl_modulos` (`pk_id_modulos`),
  CONSTRAINT `tbl_asignacionmoduloaplicacion_ibfk_2` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignacionmoduloaplicacion`
--

LOCK TABLES `tbl_asignacionmoduloaplicacion` WRITE;
/*!40000 ALTER TABLE `tbl_asignacionmoduloaplicacion` DISABLE KEYS */;
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES (1000,1000),(1000,1001),(1000,1002),(1000,1003),(1000,1004),(1000,1102),(1000,1103),(1000,1201),(1000,1301),(8000,8000),(8000,8001),(8000,8002),(8000,8003),(8000,8004),(8000,8005),(8000,8006),(8000,8007),(8000,8008),(8000,8009),(8000,8010),(8000,8011),(8000,8012),(8000,8013),(8000,8014),(8000,8015),(8000,8016),(8000,8017),(8000,8018),(8000,8019),(8000,8020),(8000,8021);
/*!40000 ALTER TABLE `tbl_asignacionmoduloaplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_autorizacionordenescompra`
--

DROP TABLE IF EXISTS `tbl_autorizacionordenescompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_autorizacionordenescompra` (
  `id_numeroDeAutorizacion` int(11) NOT NULL AUTO_INCREMENT,
  `tbl_OrdenesCompra_id_OrdComp` int(11) NOT NULL,
  `estadoOrden` varchar(30) NOT NULL,
  `conceptoDeAutorizacion` varchar(50) NOT NULL,
  `fechaAutorizacion` date NOT NULL,
  `subTotal` double NOT NULL,
  `iva` double NOT NULL,
  `totalOrden` double NOT NULL,
  `cuentaAsociada` int(11) NOT NULL,
  PRIMARY KEY (`id_numeroDeAutorizacion`),
  KEY `tbl_OrdenesCompra_id_OrdComp` (`tbl_OrdenesCompra_id_OrdComp`),
  KEY `cuentaAsociada` (`cuentaAsociada`),
  CONSTRAINT `tbl_autorizacionordenescompra_ibfk_1` FOREIGN KEY (`tbl_OrdenesCompra_id_OrdComp`) REFERENCES `tbl_ordenescompra` (`id_OrdComp`),
  CONSTRAINT `tbl_autorizacionordenescompra_ibfk_2` FOREIGN KEY (`cuentaAsociada`) REFERENCES `tbl_cuentabancaria` (`id_cuentaBancaria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_autorizacionordenescompra`
--

LOCK TABLES `tbl_autorizacionordenescompra` WRITE;
/*!40000 ALTER TABLE `tbl_autorizacionordenescompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_autorizacionordenescompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_banco`
--

DROP TABLE IF EXISTS `tbl_banco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_banco` (
  `id_banco` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_banco` varchar(30) NOT NULL,
  `direccion_banco` varchar(50) DEFAULT NULL,
  `telefono_banco` varchar(20) DEFAULT NULL,
  `estado_banco` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_banco`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_banco`
--

LOCK TABLES `tbl_banco` WRITE;
/*!40000 ALTER TABLE `tbl_banco` DISABLE KEYS */;
INSERT INTO `tbl_banco` VALUES (1,'Banrural','zona1','25874136','Activo ');
/*!40000 ALTER TABLE `tbl_banco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_banco2`
--

DROP TABLE IF EXISTS `tbl_banco2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_banco2` (
  `ban_id_Banco` int(11) NOT NULL AUTO_INCREMENT,
  `fk_ban_Nombre_banco` varchar(100) DEFAULT NULL,
  `ban_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`ban_id_Banco`),
  KEY `fk_ban_Nombre_banco` (`fk_ban_Nombre_banco`),
  CONSTRAINT `tbl_banco2_ibfk_1` FOREIGN KEY (`fk_ban_Nombre_banco`) REFERENCES `tbl_mantenimientos_agregar_bancos` (`manag_nombre_banco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_banco2`
--

LOCK TABLES `tbl_banco2` WRITE;
/*!40000 ALTER TABLE `tbl_banco2` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_banco2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bitacoradeeventos`
--

DROP TABLE IF EXISTS `tbl_bitacoradeeventos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bitacoradeeventos` (
  `pk_id_bitacora` int(11) NOT NULL AUTO_INCREMENT,
  `fk_id_usuario` int(11) NOT NULL,
  `fk_id_aplicacion` int(11) NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time NOT NULL,
  `host_bitacora` varchar(45) NOT NULL,
  `ip_bitacora` varchar(100) NOT NULL,
  `accion_bitacora` varchar(50) NOT NULL,
  PRIMARY KEY (`pk_id_bitacora`),
  KEY `fk_id_usuario` (`fk_id_usuario`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`),
  CONSTRAINT `tbl_bitacoradeeventos_ibfk_1` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  CONSTRAINT `tbl_bitacoradeeventos_ibfk_2` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=349 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacoradeeventos`
--

LOCK TABLES `tbl_bitacoradeeventos` WRITE;
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` DISABLE KEYS */;
INSERT INTO `tbl_bitacoradeeventos` VALUES (1,1,1000,'2024-02-21','19:21:03','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(2,1,1000,'2024-02-21','19:21:53','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(3,1,1,'2024-02-23','08:36:22','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(4,1,1000,'2024-02-23','08:36:23','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(5,1,1,'2024-02-23','08:37:00','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(6,1,1,'2024-02-23','08:37:47','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(7,1,999,'2024-02-23','08:37:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Cerro Sesion'),(8,1,1,'2024-02-23','09:12:16','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(9,1,1000,'2024-02-23','09:12:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(10,1,1000,'2024-02-23','09:14:25','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(11,1,999,'2024-02-23','09:27:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Cerro Sesion'),(12,1,1,'2024-02-23','21:23:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(13,1,1000,'2024-02-23','21:23:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(14,1,1000,'2024-02-23','21:24:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(15,1,1000,'2024-02-23','21:25:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(16,1,1,'2024-02-23','21:26:16','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(17,1,1000,'2024-02-23','21:26:17','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(18,1,1,'2024-02-23','21:28:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(19,1,1000,'2024-02-23','21:28:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(20,1,1000,'2024-02-23','21:29:37','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(21,1,1000,'2024-02-23','21:30:32','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(22,1,999,'2024-02-23','21:54:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Cerro Sesion'),(23,1,1,'2024-04-05','17:15:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(24,1,1000,'2024-04-05','17:15:48','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(25,1,1,'2024-04-05','17:17:20','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(26,1,1000,'2024-04-05','17:17:22','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(27,1,1,'2024-04-10','15:39:05','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(28,1,1000,'2024-04-10','15:39:07','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(29,1,1,'2024-04-10','15:47:22','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(30,1,1000,'2024-04-10','15:47:24','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(31,1,1,'2024-04-10','16:44:17','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(32,1,1000,'2024-04-10','16:44:19','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(33,1,1000,'2024-04-10','16:44:39','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(34,1,1,'2024-04-10','16:50:42','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(35,1,1000,'2024-04-10','16:50:43','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(36,1,1,'2024-04-10','16:54:40','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(37,1,1000,'2024-04-10','16:54:41','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(38,1,1,'2024-04-10','16:59:01','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(39,1,1000,'2024-04-10','16:59:02','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(40,1,1,'2024-04-10','17:00:52','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(41,1,1000,'2024-04-10','17:00:54','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(42,1,1,'2024-04-10','17:03:02','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(43,1,1000,'2024-04-10','17:03:04','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(44,1,1,'2024-04-10','17:06:03','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(45,1,1000,'2024-04-10','17:06:05','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(46,1,1,'2024-04-10','17:09:05','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(47,1,1000,'2024-04-10','17:09:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(48,1,1,'2024-04-10','17:11:17','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(49,1,1000,'2024-04-10','17:11:18','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(50,1,1,'2024-04-10','17:14:14','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(51,1,1000,'2024-04-10','17:14:15','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(52,1,1,'2024-04-10','17:16:13','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(53,1,1000,'2024-04-10','17:16:14','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(54,1,1,'2024-04-10','17:37:53','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(55,1,1000,'2024-04-10','17:37:54','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(56,1,1,'2024-04-10','17:38:56','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(57,1,1000,'2024-04-10','17:38:57','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(58,1,1,'2024-04-10','17:40:45','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(59,1,1000,'2024-04-10','17:40:46','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(60,1,1,'2024-04-10','17:43:36','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(61,1,1000,'2024-04-10','17:43:38','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(62,1,1,'2024-04-10','17:46:17','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(63,1,1000,'2024-04-10','17:46:18','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(64,1,1,'2024-04-10','18:50:08','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(65,1,1000,'2024-04-10','18:50:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(66,1,1,'2024-04-10','18:52:33','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(67,1,1000,'2024-04-10','18:52:34','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(68,1,1,'2024-04-10','18:53:35','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(69,1,1000,'2024-04-10','18:53:36','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(70,1,1,'2024-04-10','18:56:56','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(71,1,1000,'2024-04-10','18:56:57','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(72,1,1,'2024-04-10','18:57:47','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(73,1,1000,'2024-04-10','18:57:49','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(74,1,1,'2024-04-10','18:59:01','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(75,1,1000,'2024-04-10','18:59:02','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(76,1,1,'2024-04-10','18:59:51','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(77,1,1000,'2024-04-10','18:59:52','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(78,1,1,'2024-04-10','19:04:19','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(79,1,1000,'2024-04-10','19:04:20','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(80,1,1,'2024-04-10','19:06:25','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(81,1,1000,'2024-04-10','19:06:27','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(82,1,1,'2024-04-11','15:40:09','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(83,1,1000,'2024-04-11','15:40:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(84,1,1000,'2024-04-11','15:41:03','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(85,1,1000,'2024-04-11','15:41:19','DESKTOP-EIV7ULN','192.168.5.164','Se ha modificado un registro'),(86,1,1,'2024-04-11','15:41:40','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(87,1,1000,'2024-04-11','15:41:42','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Seguridad'),(88,1,1,'2024-04-11','15:47:02','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(89,1,1000,'2024-04-11','15:47:03','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(90,1,1,'2024-04-11','15:48:48','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(91,1,1000,'2024-04-11','15:48:51','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Seguridad'),(92,1,1,'2024-04-11','15:49:13','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(93,1,1000,'2024-04-11','15:49:15','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(94,1,1,'2024-04-11','16:12:58','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(95,1,1,'2024-04-11','16:24:48','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(96,1,8000,'2024-04-11','16:24:50','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(97,1,1000,'2024-04-11','16:24:53','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Seguridad'),(98,1,1,'2024-04-11','17:12:58','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(99,1,8000,'2024-04-11','17:13:00','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(100,1,1,'2024-04-11','17:14:18','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(101,1,8000,'2024-04-11','17:14:20','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(102,1,1,'2024-04-11','17:15:57','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(103,1,8000,'2024-04-11','17:15:58','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(104,1,1,'2024-04-11','17:17:43','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(105,1,8000,'2024-04-11','17:17:44','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(106,1,1,'2024-04-11','17:21:35','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(107,1,8000,'2024-04-11','17:21:36','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(108,1,1,'2024-04-11','17:22:35','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(109,1,8000,'2024-04-11','17:22:37','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(110,1,1,'2024-04-11','17:26:51','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(111,1,8000,'2024-04-11','17:26:53','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(112,1,1,'2024-04-11','17:30:42','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(113,1,8000,'2024-04-11','17:30:43','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(114,1,1,'2024-04-11','17:31:45','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(115,1,8000,'2024-04-11','17:31:47','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(116,1,8002,'2024-04-11','17:32:10','DESKTOP-EIV7ULN','192.168.5.164','Se ha modificado un registro'),(117,1,1,'2024-04-11','17:37:29','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(118,1,8000,'2024-04-11','17:37:30','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(119,1,8002,'2024-04-11','17:37:37','DESKTOP-EIV7ULN','192.168.5.164','Se ha eliminado un registro'),(120,1,8002,'2024-04-11','17:38:00','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(121,1,8002,'2024-04-11','17:38:17','DESKTOP-EIV7ULN','192.168.5.164','Se ha modificado un registro'),(122,1,1,'2024-04-11','17:42:54','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(123,1,8000,'2024-04-11','17:42:55','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(124,1,8002,'2024-04-11','17:43:12','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(125,1,1,'2024-04-11','17:52:19','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(126,1,8000,'2024-04-11','17:52:20','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(127,1,1,'2024-04-11','17:58:55','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(128,1,8000,'2024-04-11','17:58:56','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(129,1,8002,'2024-04-11','17:59:15','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(130,1,8002,'2024-04-11','18:00:57','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(131,1,1,'2024-04-11','18:05:20','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(132,1,8000,'2024-04-11','18:05:22','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(133,1,8002,'2024-04-11','18:05:47','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(134,1,1,'2024-04-11','18:08:25','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(135,1,8000,'2024-04-11','18:08:26','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(136,1,8002,'2024-04-11','18:09:08','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(137,1,1,'2024-04-11','18:14:30','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(138,1,8000,'2024-04-11','18:14:32','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(139,1,8002,'2024-04-11','18:15:10','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(140,1,8002,'2024-04-11','18:15:40','DESKTOP-EIV7ULN','192.168.5.164','Se ha eliminado un registro'),(141,1,8002,'2024-04-11','18:15:44','DESKTOP-EIV7ULN','192.168.5.164','Se ha eliminado un registro'),(142,1,8002,'2024-04-11','18:15:50','DESKTOP-EIV7ULN','192.168.5.164','Se ha eliminado un registro'),(143,1,8002,'2024-04-11','18:15:55','DESKTOP-EIV7ULN','192.168.5.164','Se ha eliminado un registro'),(144,1,1,'2024-04-11','18:16:32','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(145,1,8000,'2024-04-11','18:16:34','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(146,1,1,'2024-04-12','09:18:19','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(147,1,8000,'2024-04-12','09:18:21','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(148,1,1,'2024-04-12','09:26:49','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(149,1,8000,'2024-04-12','09:26:56','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(150,1,1000,'2024-04-12','09:27:06','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Seguridad'),(151,1,1,'2024-04-12','09:27:31','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(152,1,8000,'2024-04-12','09:27:32','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(153,1,1,'2024-04-12','09:49:17','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(154,1,8000,'2024-04-12','09:49:20','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(155,1,8002,'2024-04-12','09:49:47','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(156,1,1000,'2024-04-12','09:54:41','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Seguridad'),(157,1,1,'2024-04-12','09:56:26','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(158,1,1,'2024-04-12','15:21:33','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(159,1,8000,'2024-04-12','15:21:34','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(160,1,1,'2024-04-12','15:26:15','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(161,1,8000,'2024-04-12','15:26:17','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(162,1,8000,'2024-04-12','15:27:11','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(163,1,1,'2024-04-12','15:28:27','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(164,1,8000,'2024-04-12','15:28:28','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(165,1,1,'2024-04-12','15:30:13','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(166,1,8000,'2024-04-12','15:30:15','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(167,1,1,'2024-04-12','15:36:03','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(168,1,8000,'2024-04-12','15:36:05','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(169,1,1,'2024-04-12','15:39:56','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(170,1,8000,'2024-04-12','15:39:57','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(171,1,1,'2024-04-12','15:43:07','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(172,1,8000,'2024-04-12','15:43:09','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(173,1,1,'2024-04-12','15:47:06','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(174,1,8000,'2024-04-12','15:47:08','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(175,1,1,'2024-04-12','15:48:58','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(176,1,8000,'2024-04-12','15:48:59','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(177,1,1,'2024-04-12','15:53:36','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(178,1,8000,'2024-04-12','15:53:37','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(179,1,1,'2024-04-12','15:55:21','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(180,1,8000,'2024-04-12','15:55:23','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(181,1,1,'2024-04-12','16:00:30','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(182,1,8000,'2024-04-12','16:00:31','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(183,1,1,'2024-04-12','16:04:24','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(184,1,8000,'2024-04-12','16:04:26','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(185,1,1,'2024-04-12','16:05:07','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(186,1,8000,'2024-04-12','16:05:08','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(187,1,1,'2024-04-12','17:24:26','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(188,1,8000,'2024-04-12','17:24:28','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(189,1,1,'2024-04-12','17:25:47','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(190,1,8000,'2024-04-12','17:25:49','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(191,1,1,'2024-04-17','17:57:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(192,1,8000,'2024-04-17','17:57:11','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(193,1,8000,'2024-04-17','17:57:14','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(194,1,8000,'2024-04-17','17:57:14','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(195,1,8000,'2024-04-17','17:57:14','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(196,1,8000,'2024-04-17','17:57:14','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(197,1,8000,'2024-04-17','17:57:15','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(198,1,8000,'2024-04-17','17:57:15','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(199,1,8000,'2024-04-17','17:57:27','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(200,1,8000,'2024-04-17','17:57:27','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(201,1,8000,'2024-04-17','17:57:28','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(202,1,8000,'2024-04-17','17:57:28','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(203,1,1,'2024-04-17','18:22:18','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(204,1,8000,'2024-04-17','18:22:20','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(205,1,1,'2024-04-17','18:25:21','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(206,1,8000,'2024-04-17','18:25:23','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(207,1,1,'2024-04-17','18:26:25','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(208,1,8000,'2024-04-17','18:26:26','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(209,1,8002,'2024-04-17','18:26:56','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(210,1,1,'2024-04-25','09:18:49','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(211,1,8000,'2024-04-25','09:18:51','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(212,1,8003,'2024-04-25','09:19:34','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(213,1,8004,'2024-04-25','09:20:35','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(214,1,1,'2024-04-25','09:23:23','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(215,1,8000,'2024-04-25','09:23:24','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(216,1,1,'2024-04-25','09:28:34','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(217,1,8000,'2024-04-25','09:28:36','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(218,1,1,'2024-04-25','09:30:43','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(219,1,8000,'2024-04-25','09:30:45','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(220,1,8007,'2024-04-25','09:31:15','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(221,1,8008,'2024-04-25','09:31:39','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(222,1,1,'2024-04-25','09:31:58','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(223,1,8000,'2024-04-25','09:32:00','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(225,1,1000,'2024-04-25','09:34:04','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Seguridad'),(226,1,1,'2024-04-25','15:10:29','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(227,1,8000,'2024-04-25','15:10:30','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(228,1,1,'2024-04-25','15:21:53','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(229,1,8000,'2024-04-25','15:21:55','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(230,1,1,'2024-04-25','16:15:58','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(231,1,8000,'2024-04-25','16:16:00','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(232,1,8001,'2024-04-25','16:16:27','DESKTOP-EIV7ULN','192.168.5.164','Se ha guardado un registro'),(233,1,1,'2024-04-25','16:19:30','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(234,1,8000,'2024-04-25','16:19:32','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(235,1,1,'2024-04-25','21:13:41','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(236,1,8000,'2024-04-25','21:13:42','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(237,1,1,'2024-04-25','21:20:06','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(238,1,8000,'2024-04-25','21:20:08','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(239,1,1,'2024-04-25','21:20:36','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(240,1,8000,'2024-04-25','21:20:37','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(241,1,1,'2024-04-25','21:24:06','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(242,1,8000,'2024-04-25','21:24:07','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(243,1,1,'2024-04-25','21:36:00','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(244,1,8000,'2024-04-25','21:36:02','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(245,1,1,'2024-04-25','21:37:53','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(246,1,8000,'2024-04-25','21:37:54','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(247,1,1,'2024-04-25','21:39:57','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(248,1,8000,'2024-04-25','21:39:58','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(249,1,1,'2024-04-25','21:42:20','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(250,1,8000,'2024-04-25','21:42:21','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(251,1,1,'2024-04-25','21:44:29','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(252,1,8000,'2024-04-25','21:44:30','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(253,1,1,'2024-04-25','21:45:31','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(254,1,8000,'2024-04-25','21:45:33','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(255,1,1,'2024-04-25','21:46:56','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(256,1,8000,'2024-04-25','21:46:57','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(257,1,1,'2024-04-26','15:35:26','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(258,1,8000,'2024-04-26','15:35:27','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(259,1,1,'2024-04-26','15:40:42','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(260,1,8000,'2024-04-26','15:40:43','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(261,1,1,'2024-04-26','15:55:29','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(262,1,8000,'2024-04-26','15:55:30','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(263,1,1,'2024-04-26','15:59:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(264,1,8000,'2024-04-26','15:59:11','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(265,1,1,'2024-04-26','16:02:31','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(266,1,8000,'2024-04-26','16:02:32','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(267,1,1,'2024-04-26','16:04:44','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(268,1,8000,'2024-04-26','16:04:45','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(269,1,1,'2024-04-26','16:09:33','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(270,1,8000,'2024-04-26','16:09:34','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(271,1,1,'2024-04-26','16:12:08','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(272,1,8000,'2024-04-26','16:12:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(273,1,1,'2024-04-26','16:15:08','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(274,1,8000,'2024-04-26','16:15:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(275,1,1,'2024-04-26','16:16:42','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(276,1,8000,'2024-04-26','16:16:44','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(277,1,1,'2024-04-26','16:19:41','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(278,1,8000,'2024-04-26','16:19:43','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(279,1,1,'2024-04-26','16:20:18','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(280,1,8000,'2024-04-26','16:20:20','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(281,1,1,'2024-04-26','16:20:58','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(282,1,8000,'2024-04-26','16:20:59','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(283,1,1,'2024-04-26','16:21:57','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(284,1,8000,'2024-04-26','16:21:58','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(285,1,1,'2024-04-26','16:24:17','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(286,1,8000,'2024-04-26','16:24:18','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(287,1,1,'2024-04-26','16:24:54','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(288,1,8000,'2024-04-26','16:24:56','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(289,1,1,'2024-04-26','16:26:15','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(290,1,8000,'2024-04-26','16:26:16','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(291,1,1,'2024-04-26','16:34:04','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(292,1,8000,'2024-04-26','16:34:06','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(293,1,1,'2024-04-26','16:37:54','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(294,1,8000,'2024-04-26','16:37:55','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(295,1,1,'2024-04-26','16:40:18','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(296,1,8000,'2024-04-26','16:40:20','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(297,1,1,'2024-04-26','16:41:40','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(298,1,8000,'2024-04-26','16:41:41','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(299,1,1,'2024-04-26','16:46:09','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(300,1,8000,'2024-04-26','16:46:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(301,1,1,'2024-04-26','16:49:39','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(302,1,8000,'2024-04-26','16:49:40','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(303,1,1,'2024-04-26','16:56:04','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(304,1,8000,'2024-04-26','16:56:05','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(305,1,1,'2024-04-26','17:04:09','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(306,1,8000,'2024-04-26','17:04:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(307,1,1,'2024-04-26','17:05:23','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(308,1,8000,'2024-04-26','17:05:24','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(309,1,1,'2024-04-30','17:15:27','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(310,1,8000,'2024-04-30','17:15:29','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(311,1,1,'2024-04-30','17:19:50','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(312,1,8000,'2024-04-30','17:19:52','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(313,1,1,'2024-04-30','17:22:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(314,1,8000,'2024-04-30','17:22:11','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(315,1,1,'2024-04-30','17:25:49','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(316,1,8000,'2024-04-30','17:25:51','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(317,1,1,'2024-04-30','17:27:08','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(318,1,8000,'2024-04-30','17:27:10','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(319,1,1,'2024-04-30','17:32:16','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(320,1,8000,'2024-04-30','17:32:17','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(321,1,1,'2024-04-30','17:33:16','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(322,1,8000,'2024-04-30','17:33:18','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(323,1,1,'2024-04-30','17:35:09','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(324,1,8000,'2024-04-30','17:35:11','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(325,1,1,'2024-04-30','18:10:28','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(326,1,8000,'2024-04-30','18:10:29','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(327,1,1,'2024-04-30','18:33:02','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(328,1,8000,'2024-04-30','18:33:04','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(329,1,1,'2024-04-30','18:33:41','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(330,1,8000,'2024-04-30','18:33:42','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(331,1,1,'2024-04-30','18:35:58','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(332,1,8000,'2024-04-30','18:35:59','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(333,1,8000,'2024-04-30','18:36:02','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(334,1,1,'2024-04-30','18:38:20','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(335,1,8000,'2024-04-30','18:38:22','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(336,1,1,'2024-04-30','21:01:53','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(337,1,8000,'2024-04-30','21:01:56','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(338,1,1,'2024-04-30','21:11:06','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(339,1,8000,'2024-04-30','21:11:08','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(340,1,8000,'2024-04-30','21:11:13','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(341,1,1,'2024-04-30','21:15:31','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(342,1,8000,'2024-04-30','21:15:32','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(343,1,1,'2024-04-30','21:30:42','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(344,1,8000,'2024-04-30','21:30:44','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(345,1,1,'2024-04-30','21:41:07','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(346,1,8000,'2024-04-30','21:41:09','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo'),(347,1,1,'2024-04-30','21:59:21','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Login'),(348,1,8000,'2024-04-30','21:59:22','DESKTOP-EIV7ULN','192.168.5.164','Ingreso Prototipo');
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bodegas`
--

DROP TABLE IF EXISTS `tbl_bodegas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bodegas` (
  `id_bodega` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_bodega` varchar(45) NOT NULL,
  `ubicacion_bodega` varchar(45) NOT NULL,
  `capacidad_bodega` int(11) NOT NULL,
  PRIMARY KEY (`id_bodega`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bodegas`
--

LOCK TABLES `tbl_bodegas` WRITE;
/*!40000 ALTER TABLE `tbl_bodegas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bodegas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_clientes`
--

DROP TABLE IF EXISTS `tbl_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_clientes` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_cl` varchar(50) NOT NULL,
  `apellido_cl` varchar(50) NOT NULL,
  `direccion_cl` varchar(100) NOT NULL,
  `correo_cl` varchar(100) NOT NULL,
  `telefono_cl` varchar(45) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_clientes`
--

LOCK TABLES `tbl_clientes` WRITE;
/*!40000 ALTER TABLE `tbl_clientes` DISABLE KEYS */;
INSERT INTO `tbl_clientes` VALUES (1,'Otto','Aventura','sucasa','Aventuotto@mail.com','1231231'),(2,'Carol','Chuy','zona 2','c@gmail.com','41224026'),(3,'Carol','Chuy','zona 2','c@gmail.com','41224026');
/*!40000 ALTER TABLE `tbl_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_compras`
--

DROP TABLE IF EXISTS `tbl_compras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_compras` (
  `id_EncComp` int(11) NOT NULL,
  `fechaSolicitid_EncComp` date NOT NULL,
  `fechaEntrega_OrdComp` date NOT NULL,
  `deptoSolicitante_EncComp` varchar(45) NOT NULL,
  `entregar_a_EncComp` varchar(45) NOT NULL,
  `subTotal_EncComp` double NOT NULL,
  `iva_EncComp` double NOT NULL,
  `totalOrden_EncComp` double NOT NULL,
  `notas_EncComp` varchar(45) NOT NULL,
  `tbl_proveedor_id_prov` int(11) NOT NULL,
  `recibidoIgualSolicitado_EncComp` int(11) DEFAULT NULL,
  `fechaVencimientoPago_EncComp` date DEFAULT NULL,
  `id_OrdComp` int(11) NOT NULL,
  PRIMARY KEY (`id_EncComp`),
  KEY `fk_tbl_Encabezado_Compras_tbl_proveedor1_idx` (`tbl_proveedor_id_prov`),
  KEY `fk_OrdenCompra` (`id_OrdComp`),
  CONSTRAINT `fk_OrdenCompra` FOREIGN KEY (`id_OrdComp`) REFERENCES `tbl_ordenescompra` (`id_OrdComp`),
  CONSTRAINT `fk_tbl_Encabezado_Compras_tbl_proveedor1` FOREIGN KEY (`tbl_proveedor_id_prov`) REFERENCES `tbl_proveedor` (`id_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_compras`
--

LOCK TABLES `tbl_compras` WRITE;
/*!40000 ALTER TABLE `tbl_compras` DISABLE KEYS */;
INSERT INTO `tbl_compras` VALUES (1,'2024-04-26','2024-04-27','Ventas','Andrea',10000,1000,11000,'Compritas',4,1,'2024-04-30',1);
/*!40000 ALTER TABLE `tbl_compras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_conceptomovimientodebancos`
--

DROP TABLE IF EXISTS `tbl_conceptomovimientodebancos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_conceptomovimientodebancos` (
  `id_conceptoMovimiento` int(11) NOT NULL AUTO_INCREMENT,
  `concepto_movimientoBanco` varchar(30) NOT NULL,
  `efecto_movimientoBanco` varchar(2) NOT NULL,
  `estado_movimientoBanco` varchar(30) NOT NULL,
  PRIMARY KEY (`id_conceptoMovimiento`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_conceptomovimientodebancos`
--

LOCK TABLES `tbl_conceptomovimientodebancos` WRITE;
/*!40000 ALTER TABLE `tbl_conceptomovimientodebancos` DISABLE KEYS */;
INSERT INTO `tbl_conceptomovimientodebancos` VALUES (1,'Nota de credito','+','Activo');
/*!40000 ALTER TABLE `tbl_conceptomovimientodebancos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_conciliacion_bancaria`
--

DROP TABLE IF EXISTS `tbl_conciliacion_bancaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_conciliacion_bancaria` (
  `pk_conb_id_conciliacion` int(11) NOT NULL AUTO_INCREMENT,
  `conb_anio_conciliacion` varchar(100) DEFAULT NULL,
  `conb_mes_conciliacion` varchar(100) DEFAULT NULL,
  `fk_conb_mov_libro` float NOT NULL,
  `fk_conb_estatusConc` int(11) NOT NULL,
  `conb_mov_conciliacion` float DEFAULT NULL,
  `conb_saldo_final` float DEFAULT NULL,
  `conb_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`pk_conb_id_conciliacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_conciliacion_bancaria`
--

LOCK TABLES `tbl_conciliacion_bancaria` WRITE;
/*!40000 ALTER TABLE `tbl_conciliacion_bancaria` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_conciliacion_bancaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cotizaciones`
--

DROP TABLE IF EXISTS `tbl_cotizaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cotizaciones` (
  `No_Cotizacion` int(11) NOT NULL,
  `fecha_coti` date NOT NULL,
  `fechaFinal_coti` date NOT NULL,
  PRIMARY KEY (`No_Cotizacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cotizaciones`
--

LOCK TABLES `tbl_cotizaciones` WRITE;
/*!40000 ALTER TABLE `tbl_cotizaciones` DISABLE KEYS */;
INSERT INTO `tbl_cotizaciones` VALUES (0,'2024-04-12','2024-04-25'),(1,'2024-03-15','2024-04-15');
/*!40000 ALTER TABLE `tbl_cotizaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuentabancaria`
--

DROP TABLE IF EXISTS `tbl_cuentabancaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentabancaria` (
  `id_cuentaBancaria` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_empresa` varchar(30) NOT NULL,
  `id_bancoAsociado` int(11) NOT NULL,
  `tipo_cuenta` varchar(30) NOT NULL,
  `numero_cuenta` varchar(30) NOT NULL,
  `saldoDisponible` double NOT NULL,
  `fecha_apertura` date NOT NULL,
  `estado_cuenta` varchar(20) NOT NULL,
  `tipo_moneda` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_cuentaBancaria`),
  KEY `id_bancoAsociado` (`id_bancoAsociado`),
  CONSTRAINT `tbl_cuentabancaria_ibfk_1` FOREIGN KEY (`id_bancoAsociado`) REFERENCES `tbl_banco` (`id_banco`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuentabancaria`
--

LOCK TABLES `tbl_cuentabancaria` WRITE;
/*!40000 ALTER TABLE `tbl_cuentabancaria` DISABLE KEYS */;
INSERT INTO `tbl_cuentabancaria` VALUES (1,'Carol Chuy',1,'Ahorro','1234567',10000,'2024-04-25','Activo','Quetzal');
/*!40000 ALTER TABLE `tbl_cuentabancaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalle_cotizacion`
--

DROP TABLE IF EXISTS `tbl_detalle_cotizacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalle_cotizacion` (
  `id_detalle_cotizacion` int(11) NOT NULL AUTO_INCREMENT,
  `tbl_clientes_id_cliente` int(11) NOT NULL,
  `cantidad_coti` int(11) NOT NULL,
  `tbl_cotizaciones_No_Cotizacion` int(11) NOT NULL,
  `tbl_producto_cod_producto` int(11) NOT NULL,
  `total_detCoti` double NOT NULL,
  PRIMARY KEY (`id_detalle_cotizacion`),
  KEY `fk_tbl_detalle_cotizacion_tbl_clientes1_idx` (`tbl_clientes_id_cliente`),
  KEY `fk_tbl_detalle_cotizacion_tbl_cotizaciones1_idx` (`tbl_cotizaciones_No_Cotizacion`),
  KEY `fk_tbl_detalle_cotizacion_tbl_producto1_idx` (`tbl_producto_cod_producto`),
  CONSTRAINT `fk_tbl_detalle_cotizacion_tbl_clientes1` FOREIGN KEY (`tbl_clientes_id_cliente`) REFERENCES `tbl_clientes` (`id_cliente`),
  CONSTRAINT `fk_tbl_detalle_cotizacion_tbl_cotizaciones1` FOREIGN KEY (`tbl_cotizaciones_No_Cotizacion`) REFERENCES `tbl_cotizaciones` (`No_Cotizacion`),
  CONSTRAINT `fk_tbl_detalle_cotizacion_tbl_producto1` FOREIGN KEY (`tbl_producto_cod_producto`) REFERENCES `tbl_producto` (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalle_cotizacion`
--

LOCK TABLES `tbl_detalle_cotizacion` WRITE;
/*!40000 ALTER TABLE `tbl_detalle_cotizacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detalle_cotizacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detallecompras`
--

DROP TABLE IF EXISTS `tbl_detallecompras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detallecompras` (
  `id_detalleCompra` int(11) NOT NULL,
  `cantidad_compra_det` int(11) NOT NULL,
  `totalPorProducto_det` double NOT NULL,
  `tbl_Producto_cod_producto` int(11) NOT NULL,
  `tbl_Encabezado_Compras_id_Orden` int(11) NOT NULL,
  PRIMARY KEY (`id_detalleCompra`),
  KEY `fk_tbl_detalleCompras_tbl_Producto1_idx` (`tbl_Producto_cod_producto`),
  KEY `fk_tbl_detalleCompras_tbl_Encabezado_Compras1_idx` (`tbl_Encabezado_Compras_id_Orden`),
  CONSTRAINT `fk_tbl_detalleCompras_tbl_Encabezado_Compras1` FOREIGN KEY (`tbl_Encabezado_Compras_id_Orden`) REFERENCES `tbl_compras` (`id_EncComp`),
  CONSTRAINT `fk_tbl_detalleCompras_tbl_Producto1` FOREIGN KEY (`tbl_Producto_cod_producto`) REFERENCES `tbl_producto` (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detallecompras`
--

LOCK TABLES `tbl_detallecompras` WRITE;
/*!40000 ALTER TABLE `tbl_detallecompras` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detallecompras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detallefacturaxpagar`
--

DROP TABLE IF EXISTS `tbl_detallefacturaxpagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detallefacturaxpagar` (
  `id_detalleFac` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad_detalleFac` int(11) NOT NULL,
  `totalPorProducto_detalleFac` double NOT NULL,
  `tbl_facturaXPagar_NoFactura` int(11) NOT NULL,
  `tbl_Producto_cod_producto` int(11) NOT NULL,
  PRIMARY KEY (`id_detalleFac`),
  KEY `fk_tbl_detalleFacturaXPagar_tbl_facturaXPagar1_idx` (`tbl_facturaXPagar_NoFactura`),
  KEY `fk_tbl_detalleFacturaXPagar_tbl_Producto1_idx` (`tbl_Producto_cod_producto`),
  CONSTRAINT `fk_tbl_detalleFacturaXPagar_tbl_Producto1` FOREIGN KEY (`tbl_Producto_cod_producto`) REFERENCES `tbl_producto` (`cod_producto`),
  CONSTRAINT `fk_tbl_detalleFacturaXPagar_tbl_facturaXPagar1` FOREIGN KEY (`tbl_facturaXPagar_NoFactura`) REFERENCES `tbl_facturaxpagar` (`NoFactura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detallefacturaxpagar`
--

LOCK TABLES `tbl_detallefacturaxpagar` WRITE;
/*!40000 ALTER TABLE `tbl_detallefacturaxpagar` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detallefacturaxpagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detallemovpro`
--

DROP TABLE IF EXISTS `tbl_detallemovpro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detallemovpro` (
  `id_detalleMovP` int(11) NOT NULL AUTO_INCREMENT,
  `noFactura` int(11) NOT NULL,
  `banco_MovP` varchar(45) NOT NULL,
  `tipo_MovP` varchar(45) NOT NULL,
  `numero_MovP` varchar(45) NOT NULL,
  PRIMARY KEY (`id_detalleMovP`),
  KEY `noFactura_idx` (`noFactura`),
  CONSTRAINT `noFactura` FOREIGN KEY (`noFactura`) REFERENCES `tbl_facturaxpagar` (`NoFactura`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detallemovpro`
--

LOCK TABLES `tbl_detallemovpro` WRITE;
/*!40000 ALTER TABLE `tbl_detallemovpro` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detallemovpro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalleordenescompra`
--

DROP TABLE IF EXISTS `tbl_detalleordenescompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalleordenescompra` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `OrdenesCompra_id_OrdComp` int(11) NOT NULL,
  `cantidad_det` int(11) NOT NULL,
  `totalProducto_det` double NOT NULL,
  `tbl_Producto_cod_producto` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `fk_DetalleOrdenesCompra_OrdenesCompra_idx` (`OrdenesCompra_id_OrdComp`),
  KEY `fk_tbl_DetalleOrdenesCompra_tbl_Producto1_idx` (`tbl_Producto_cod_producto`),
  CONSTRAINT `fk_DetalleOrdenesCompra_OrdenesCompra` FOREIGN KEY (`OrdenesCompra_id_OrdComp`) REFERENCES `tbl_ordenescompra` (`id_OrdComp`),
  CONSTRAINT `fk_tbl_DetalleOrdenesCompra_tbl_Producto1` FOREIGN KEY (`tbl_Producto_cod_producto`) REFERENCES `tbl_producto` (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalleordenescompra`
--

LOCK TABLES `tbl_detalleordenescompra` WRITE;
/*!40000 ALTER TABLE `tbl_detalleordenescompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detalleordenescompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalleventas`
--

DROP TABLE IF EXISTS `tbl_detalleventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalleventas` (
  `id_ventas_det` int(11) NOT NULL,
  `fecha_venta_det` date NOT NULL,
  `tbl_Ventas_pedido_id_ventas_ped` int(11) NOT NULL,
  PRIMARY KEY (`id_ventas_det`),
  KEY `fk_tbl_Ventas_detalle_tbl_Ventas_pedido1_idx` (`tbl_Ventas_pedido_id_ventas_ped`),
  CONSTRAINT `fk_tbl_Ventas_detalle_tbl_Ventas_pedido1` FOREIGN KEY (`tbl_Ventas_pedido_id_ventas_ped`) REFERENCES `tbl_ventaspedido` (`id_ventas_ped`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalleventas`
--

LOCK TABLES `tbl_detalleventas` WRITE;
/*!40000 ALTER TABLE `tbl_detalleventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detalleventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_disponibilidaddiaria`
--

DROP TABLE IF EXISTS `tbl_disponibilidaddiaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_disponibilidaddiaria` (
  `id_disponibilidad` int(11) NOT NULL AUTO_INCREMENT,
  `id_cuentaDisponibilidad` int(11) NOT NULL,
  `id_bancoActual` int(11) NOT NULL,
  `saldo_disponible` double NOT NULL,
  `saldo_consumido` double NOT NULL,
  `saldo_actual` double NOT NULL,
  `fecha_DisponibilidadDiaria` date NOT NULL,
  PRIMARY KEY (`id_disponibilidad`),
  KEY `id_cuentaDisponibilidad` (`id_cuentaDisponibilidad`),
  KEY `id_bancoActual` (`id_bancoActual`),
  CONSTRAINT `tbl_disponibilidaddiaria_ibfk_1` FOREIGN KEY (`id_cuentaDisponibilidad`) REFERENCES `tbl_cuentabancaria` (`id_cuentaBancaria`),
  CONSTRAINT `tbl_disponibilidaddiaria_ibfk_2` FOREIGN KEY (`id_bancoActual`) REFERENCES `tbl_banco` (`id_banco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_disponibilidaddiaria`
--

LOCK TABLES `tbl_disponibilidaddiaria` WRITE;
/*!40000 ALTER TABLE `tbl_disponibilidaddiaria` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_disponibilidaddiaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_encabezadomovpro`
--

DROP TABLE IF EXISTS `tbl_encabezadomovpro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_encabezadomovpro` (
  `id_enMovPro` int(11) NOT NULL AUTO_INCREMENT,
  `id_prove` int(11) NOT NULL,
  `fecha_MovPro` datetime NOT NULL,
  `total_MovPro` varchar(45) NOT NULL,
  PRIMARY KEY (`id_enMovPro`),
  KEY `id_prove_idx` (`id_prove`),
  CONSTRAINT `id_prove` FOREIGN KEY (`id_prove`) REFERENCES `tbl_proveedor` (`id_prov`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_encabezadomovpro`
--

LOCK TABLES `tbl_encabezadomovpro` WRITE;
/*!40000 ALTER TABLE `tbl_encabezadomovpro` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_encabezadomovpro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_existencias`
--

DROP TABLE IF EXISTS `tbl_existencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_existencias` (
  `id_existencias` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `tbl_sucursales_id_sucursal` int(11) NOT NULL,
  `tbl_producto_id_producto` int(11) NOT NULL,
  PRIMARY KEY (`id_existencias`),
  KEY `fk_tbl_existencias_tbl_sucursal1_idx` (`tbl_sucursales_id_sucursal`),
  KEY `tbl_producto_id_producto_idx` (`tbl_producto_id_producto`),
  CONSTRAINT `fk_tbl_existencias_tbl_sucursal` FOREIGN KEY (`tbl_sucursales_id_sucursal`) REFERENCES `tbl_sucursales` (`id_sucursal`),
  CONSTRAINT `tbl_producto_id_producto` FOREIGN KEY (`tbl_producto_id_producto`) REFERENCES `tbl_producto` (`cod_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_existencias`
--

LOCK TABLES `tbl_existencias` WRITE;
/*!40000 ALTER TABLE `tbl_existencias` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_existencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_facturaxcobrar`
--

DROP TABLE IF EXISTS `tbl_facturaxcobrar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_facturaxcobrar` (
  `NoFactura` int(11) NOT NULL,
  `total_facxcob` double NOT NULL,
  `tiempoPago_facxcob` varchar(45) NOT NULL,
  `estado_facxcob` varchar(45) NOT NULL,
  `tbl_Ventas_detalle_id_ventas_det` int(11) NOT NULL,
  `tbl_Clientes_id_cliente` int(11) NOT NULL,
  PRIMARY KEY (`NoFactura`),
  KEY `fk_tbl_facturaXcobrar_tbl_Ventas_detalle1_idx` (`tbl_Ventas_detalle_id_ventas_det`),
  KEY `fk_tbl_FacturaXcobrar_tbl_Clientes1_idx` (`tbl_Clientes_id_cliente`),
  CONSTRAINT `fk_tbl_FacturaXcobrar_tbl_Clientes1` FOREIGN KEY (`tbl_Clientes_id_cliente`) REFERENCES `tbl_clientes` (`id_cliente`),
  CONSTRAINT `fk_tbl_facturaXcobrar_tbl_Ventas_detalle1` FOREIGN KEY (`tbl_Ventas_detalle_id_ventas_det`) REFERENCES `tbl_detalleventas` (`id_ventas_det`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_facturaxcobrar`
--

LOCK TABLES `tbl_facturaxcobrar` WRITE;
/*!40000 ALTER TABLE `tbl_facturaxcobrar` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_facturaxcobrar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_facturaxpagar`
--

DROP TABLE IF EXISTS `tbl_facturaxpagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_facturaxpagar` (
  `NoFactura` int(11) NOT NULL,
  `nombreprov_facxpag` varchar(45) NOT NULL,
  `nitprov_facxpag` varchar(20) NOT NULL,
  `fechavenc_facxpag` date NOT NULL,
  `fecha_abono` date NOT NULL,
  `subtotal_facxpag` double NOT NULL,
  `iva_facxpag` double NOT NULL,
  `totalfac_facxpag` double NOT NULL,
  `estado_facxpag` int(11) NOT NULL,
  `tbl_Encabezado_Compras_id_EncComp` int(11) NOT NULL,
  PRIMARY KEY (`NoFactura`),
  KEY `fk_tbl_facturaXPagar_tbl_Encabezado_Compras1_idx` (`tbl_Encabezado_Compras_id_EncComp`),
  CONSTRAINT `fk_tbl_facturaXPagar_tbl_Encabezado_Compras1` FOREIGN KEY (`tbl_Encabezado_Compras_id_EncComp`) REFERENCES `tbl_compras` (`id_EncComp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_facturaxpagar`
--

LOCK TABLES `tbl_facturaxpagar` WRITE;
/*!40000 ALTER TABLE `tbl_facturaxpagar` DISABLE KEYS */;
INSERT INTO `tbl_facturaxpagar` VALUES (1,'Carol','125478963','2024-04-30','2024-04-26',10000,1000,11000,1,1),(2,'Andrea Corado','1789429','2024-05-05','2024-04-24',5000,500,5500,1,1);
/*!40000 ALTER TABLE `tbl_facturaxpagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_lineas`
--

DROP TABLE IF EXISTS `tbl_lineas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_lineas` (
  `id_linea` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_linea` varchar(45) NOT NULL,
  PRIMARY KEY (`id_linea`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_lineas`
--

LOCK TABLES `tbl_lineas` WRITE;
/*!40000 ALTER TABLE `tbl_lineas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_lineas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_mantenimientos_agregar_bancos`
--

DROP TABLE IF EXISTS `tbl_mantenimientos_agregar_bancos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_mantenimientos_agregar_bancos` (
  `pk_manag_id_ban` int(11) NOT NULL AUTO_INCREMENT,
  `manag_id_bancoag` int(11) DEFAULT NULL,
  `manag_nombre_banco` varchar(100) DEFAULT NULL,
  `manag_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`pk_manag_id_ban`),
  UNIQUE KEY `manag_nombre_banco` (`manag_nombre_banco`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_mantenimientos_agregar_bancos`
--

LOCK TABLES `tbl_mantenimientos_agregar_bancos` WRITE;
/*!40000 ALTER TABLE `tbl_mantenimientos_agregar_bancos` DISABLE KEYS */;
INSERT INTO `tbl_mantenimientos_agregar_bancos` VALUES (1,111,'Banco industrial',1),(2,222,'Banrural',1);
/*!40000 ALTER TABLE `tbl_mantenimientos_agregar_bancos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_mantenimientos_agregar_cuenta`
--

DROP TABLE IF EXISTS `tbl_mantenimientos_agregar_cuenta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_mantenimientos_agregar_cuenta` (
  `pk_manac_id_cuenta` int(11) NOT NULL AUTO_INCREMENT,
  `manac_numero_de_cuenta` int(11) DEFAULT NULL,
  `fk_manac_tipo_de_moneda` varchar(100) DEFAULT NULL,
  `manac_tipo_de_cuenta` varchar(100) DEFAULT NULL,
  `fk_manac_selec_banco` varchar(50) DEFAULT NULL,
  `manac_alias` varchar(100) DEFAULT NULL,
  `manac_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`pk_manac_id_cuenta`),
  UNIQUE KEY `manac_numero_de_cuenta` (`manac_numero_de_cuenta`),
  KEY `fk_manac_selec_banco` (`fk_manac_selec_banco`),
  KEY `fk_manac_tipo_de_moneda` (`fk_manac_tipo_de_moneda`),
  CONSTRAINT `tbl_mantenimientos_agregar_cuenta_ibfk_1` FOREIGN KEY (`fk_manac_selec_banco`) REFERENCES `tbl_mantenimientos_agregar_bancos` (`manag_nombre_banco`),
  CONSTRAINT `tbl_mantenimientos_agregar_cuenta_ibfk_2` FOREIGN KEY (`fk_manac_tipo_de_moneda`) REFERENCES `tbl_monedabanco` (`mon_nomMoneda`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_mantenimientos_agregar_cuenta`
--

LOCK TABLES `tbl_mantenimientos_agregar_cuenta` WRITE;
/*!40000 ALTER TABLE `tbl_mantenimientos_agregar_cuenta` DISABLE KEYS */;
INSERT INTO `tbl_mantenimientos_agregar_cuenta` VALUES (1,10001,'Quetzales','Ahorro','Banco industrial','<Diego Marroquin',1),(2,10002,'Dólares','Monetaria','Banrural','Diego Marroquin',1);
/*!40000 ALTER TABLE `tbl_mantenimientos_agregar_cuenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_mantenimientos_tipo_movimiento`
--

DROP TABLE IF EXISTS `tbl_mantenimientos_tipo_movimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_mantenimientos_tipo_movimiento` (
  `pk_movtm_id_transaccion` int(11) NOT NULL AUTO_INCREMENT,
  `movtm_transacciones_existentes` varchar(100) DEFAULT NULL,
  `movtm_status` int(11) DEFAULT NULL,
  `movtm_valor_transaccion` int(11) NOT NULL,
  PRIMARY KEY (`pk_movtm_id_transaccion`),
  UNIQUE KEY `movtm_transacciones_existentes` (`movtm_transacciones_existentes`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_mantenimientos_tipo_movimiento`
--

LOCK TABLES `tbl_mantenimientos_tipo_movimiento` WRITE;
/*!40000 ALTER TABLE `tbl_mantenimientos_tipo_movimiento` DISABLE KEYS */;
INSERT INTO `tbl_mantenimientos_tipo_movimiento` VALUES (1,'Debito',1,0),(2,'Credito',1,1);
/*!40000 ALTER TABLE `tbl_mantenimientos_tipo_movimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_marcas`
--

DROP TABLE IF EXISTS `tbl_marcas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_marcas` (
  `id_marca` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_marca` varchar(45) NOT NULL,
  PRIMARY KEY (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_marcas`
--

LOCK TABLES `tbl_marcas` WRITE;
/*!40000 ALTER TABLE `tbl_marcas` DISABLE KEYS */;
INSERT INTO `tbl_marcas` VALUES (1,'Kerns'),(2,'Lala');
/*!40000 ALTER TABLE `tbl_marcas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_modulos`
--

DROP TABLE IF EXISTS `tbl_modulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_modulos` (
  `pk_id_modulos` int(11) NOT NULL,
  `nombre_modulo` varchar(50) NOT NULL,
  `descripcion_modulo` varchar(150) NOT NULL,
  `estado_modulo` tinyint(4) DEFAULT 0,
  PRIMARY KEY (`pk_id_modulos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_modulos`
--

LOCK TABLES `tbl_modulos` WRITE;
/*!40000 ALTER TABLE `tbl_modulos` DISABLE KEYS */;
INSERT INTO `tbl_modulos` VALUES (1000,'SEGURIDAD','Seguridad',1),(8000,'PROTOTIPO ERP','ERP',1);
/*!40000 ALTER TABLE `tbl_modulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_moneda`
--

DROP TABLE IF EXISTS `tbl_moneda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_moneda` (
  `mon_id_moneda` int(11) NOT NULL AUTO_INCREMENT,
  `fk_mon_nombre_moneda` varchar(50) DEFAULT NULL,
  `mon_Cant_moneda` float DEFAULT NULL,
  `mon_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`mon_id_moneda`),
  KEY `fk_mon_nombre_moneda` (`fk_mon_nombre_moneda`),
  CONSTRAINT `tbl_moneda_ibfk_1` FOREIGN KEY (`fk_mon_nombre_moneda`) REFERENCES `tbl_registro_moneda` (`regmon_Tipo_moneda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_moneda`
--

LOCK TABLES `tbl_moneda` WRITE;
/*!40000 ALTER TABLE `tbl_moneda` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_moneda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_monedabanco`
--

DROP TABLE IF EXISTS `tbl_monedabanco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_monedabanco` (
  `pk_mon_id_moneda` int(11) NOT NULL AUTO_INCREMENT,
  `mon_nomMoneda` varchar(100) DEFAULT NULL,
  `mon_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`pk_mon_id_moneda`),
  UNIQUE KEY `mon_nomMoneda` (`mon_nomMoneda`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_monedabanco`
--

LOCK TABLES `tbl_monedabanco` WRITE;
/*!40000 ALTER TABLE `tbl_monedabanco` DISABLE KEYS */;
INSERT INTO `tbl_monedabanco` VALUES (1,'Quetzales',NULL),(2,'Dólares',NULL);
/*!40000 ALTER TABLE `tbl_monedabanco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_movimiento_inv`
--

DROP TABLE IF EXISTS `tbl_movimiento_inv`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimiento_inv` (
  `id_movimiento_inv` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_movimiento` date NOT NULL,
  `cantidad_movimiento` int(11) NOT NULL,
  `descripcion_movimiento` varchar(45) NOT NULL,
  `tbl_movimientos_id_movimiento` int(11) NOT NULL,
  `tbl_sucursales_id_sucursal` int(11) NOT NULL,
  `tbl_Producto_cod_producto` int(11) NOT NULL,
  PRIMARY KEY (`id_movimiento_inv`),
  KEY `fk_tbl_movimiento_inv_tbl_movimiento1_idx` (`tbl_movimientos_id_movimiento`),
  KEY `fk_tbl_movimiento_inv_tbl_sucursales1_idx` (`tbl_sucursales_id_sucursal`),
  KEY `fk_tbl_movimiento_inv_tbl_Producto1_idx` (`tbl_Producto_cod_producto`),
  CONSTRAINT `fk_tbl_movimiento_inv_tbl_Producto1` FOREIGN KEY (`tbl_Producto_cod_producto`) REFERENCES `tbl_producto` (`cod_producto`),
  CONSTRAINT `fk_tbl_movimiento_inv_tbl_movimiento1` FOREIGN KEY (`tbl_movimientos_id_movimiento`) REFERENCES `tbl_movimientos` (`id_movimiento`),
  CONSTRAINT `fk_tbl_movimiento_inv_tbl_sucursales1` FOREIGN KEY (`tbl_sucursales_id_sucursal`) REFERENCES `tbl_sucursales` (`id_sucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_movimiento_inv`
--

LOCK TABLES `tbl_movimiento_inv` WRITE;
/*!40000 ALTER TABLE `tbl_movimiento_inv` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_movimiento_inv` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_movimientodebancos`
--

DROP TABLE IF EXISTS `tbl_movimientodebancos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimientodebancos` (
  `id_movimientoBanco` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_movimientoBanco` int(11) NOT NULL,
  `fecha_movimientoBanco` date NOT NULL,
  `monto_movimientoBanco` double NOT NULL,
  `cuenta_movimientoBanco` int(11) NOT NULL,
  PRIMARY KEY (`id_movimientoBanco`),
  KEY `tipo_movimientoBanco` (`tipo_movimientoBanco`),
  KEY `cuenta_movimientoBanco` (`cuenta_movimientoBanco`),
  CONSTRAINT `tbl_movimientodebancos_ibfk_1` FOREIGN KEY (`tipo_movimientoBanco`) REFERENCES `tbl_conceptomovimientodebancos` (`id_conceptoMovimiento`),
  CONSTRAINT `tbl_movimientodebancos_ibfk_2` FOREIGN KEY (`cuenta_movimientoBanco`) REFERENCES `tbl_cuentabancaria` (`id_cuentaBancaria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_movimientodebancos`
--

LOCK TABLES `tbl_movimientodebancos` WRITE;
/*!40000 ALTER TABLE `tbl_movimientodebancos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_movimientodebancos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_movimientos`
--

DROP TABLE IF EXISTS `tbl_movimientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimientos` (
  `id_movimiento` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_movimiento` varchar(45) NOT NULL,
  `descripcion_movimiento` varchar(45) NOT NULL,
  PRIMARY KEY (`id_movimiento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_movimientos`
--

LOCK TABLES `tbl_movimientos` WRITE;
/*!40000 ALTER TABLE `tbl_movimientos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_movimientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_movimientosbancarios`
--

DROP TABLE IF EXISTS `tbl_movimientosbancarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimientosbancarios` (
  `pk_movban_id_transaccion` int(11) NOT NULL AUTO_INCREMENT,
  `movban_valor_transaccion` float NOT NULL,
  `movban_descripcion_transaccion` varchar(100) DEFAULT NULL,
  `fk_movban_num_cuenta` int(11) DEFAULT NULL,
  `fk_movban_tipo_transaccion` varchar(50) DEFAULT NULL,
  `fk_movban_valorTrans` int(11) NOT NULL,
  `movban_status` int(11) DEFAULT NULL,
  `movban_fecha_de_ingreso` datetime DEFAULT NULL,
  `manag_status_conciliacion` int(11) NOT NULL,
  PRIMARY KEY (`pk_movban_id_transaccion`),
  KEY `fk_movban_num_cuenta` (`fk_movban_num_cuenta`),
  KEY `fk_movban_tipo_transaccion` (`fk_movban_tipo_transaccion`),
  CONSTRAINT `tbl_movimientosbancarios_ibfk_1` FOREIGN KEY (`fk_movban_num_cuenta`) REFERENCES `tbl_mantenimientos_agregar_cuenta` (`manac_numero_de_cuenta`),
  CONSTRAINT `tbl_movimientosbancarios_ibfk_2` FOREIGN KEY (`fk_movban_tipo_transaccion`) REFERENCES `tbl_mantenimientos_tipo_movimiento` (`movtm_transacciones_existentes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_movimientosbancarios`
--

LOCK TABLES `tbl_movimientosbancarios` WRITE;
/*!40000 ALTER TABLE `tbl_movimientosbancarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_movimientosbancarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ordenescompra`
--

DROP TABLE IF EXISTS `tbl_ordenescompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_ordenescompra` (
  `id_OrdComp` int(11) NOT NULL,
  `fechaSolicitid_OrdComp` date NOT NULL,
  `fechaEntrega_OrdComp` date NOT NULL,
  `deptoSolicitante_OrdComp` varchar(45) NOT NULL,
  `entregar_a_OrdComp` varchar(45) NOT NULL,
  `subTotal_OrdComp` double NOT NULL,
  `iva_OrdComp` double NOT NULL,
  `totalOrden_OrdComp` double NOT NULL,
  `notas_OrdComp` varchar(45) NOT NULL,
  `tbl_proveedor_id_prov` int(11) NOT NULL,
  PRIMARY KEY (`id_OrdComp`),
  KEY `fk_tbl_OrdenesCompra_tbl_proveedor1_idx` (`tbl_proveedor_id_prov`),
  CONSTRAINT `fk_tbl_OrdenesCompra_tbl_proveedor1` FOREIGN KEY (`tbl_proveedor_id_prov`) REFERENCES `tbl_proveedor` (`id_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ordenescompra`
--

LOCK TABLES `tbl_ordenescompra` WRITE;
/*!40000 ALTER TABLE `tbl_ordenescompra` DISABLE KEYS */;
INSERT INTO `tbl_ordenescompra` VALUES (1,'2023-10-26','2023-10-27','Contabilidad','Carol Cecilia',500.2,15.2,515.2,'Esta es la primer orden',2);
/*!40000 ALTER TABLE `tbl_ordenescompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_perfiles`
--

DROP TABLE IF EXISTS `tbl_perfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_perfiles` (
  `pk_id_perfil` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_perfil` varchar(50) NOT NULL,
  `descripcion_perfil` varchar(150) NOT NULL,
  `estado_perfil` tinyint(4) DEFAULT 0,
  PRIMARY KEY (`pk_id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_perfiles`
--

LOCK TABLES `tbl_perfiles` WRITE;
/*!40000 ALTER TABLE `tbl_perfiles` DISABLE KEYS */;
INSERT INTO `tbl_perfiles` VALUES (1,'ADMINISTRADOR','contiene todos los permisos del programa',1),(2,'SEGURIDAD','contiene todos los permisos de seguridad',1);
/*!40000 ALTER TABLE `tbl_perfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_permisosaplicacionesusuario`
--

DROP TABLE IF EXISTS `tbl_permisosaplicacionesusuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permisosaplicacionesusuario` (
  `fk_id_aplicacion` int(11) NOT NULL,
  `fk_id_usuario` int(11) NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT 0,
  `modificar_permiso` tinyint(1) DEFAULT 0,
  `eliminar_permiso` tinyint(1) DEFAULT 0,
  `buscar_permiso` tinyint(1) DEFAULT 0,
  `imprimir_permiso` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`fk_id_aplicacion`,`fk_id_usuario`),
  KEY `fk_id_usuario` (`fk_id_usuario`),
  CONSTRAINT `tbl_permisosaplicacionesusuario_ibfk_1` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  CONSTRAINT `tbl_permisosaplicacionesusuario_ibfk_2` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_permisosaplicacionesusuario`
--

LOCK TABLES `tbl_permisosaplicacionesusuario` WRITE;
/*!40000 ALTER TABLE `tbl_permisosaplicacionesusuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_permisosaplicacionesusuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_permisosaplicacionperfil`
--

DROP TABLE IF EXISTS `tbl_permisosaplicacionperfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permisosaplicacionperfil` (
  `fk_id_perfil` int(11) NOT NULL,
  `fk_id_aplicacion` int(11) NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT 0,
  `modificar_permiso` tinyint(1) DEFAULT 0,
  `eliminar_permiso` tinyint(1) DEFAULT 0,
  `buscar_permiso` tinyint(1) DEFAULT 0,
  `imprimir_permiso` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`fk_id_perfil`,`fk_id_aplicacion`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`),
  CONSTRAINT `tbl_permisosaplicacionperfil_ibfk_1` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  CONSTRAINT `tbl_permisosaplicacionperfil_ibfk_2` FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_permisosaplicacionperfil`
--

LOCK TABLES `tbl_permisosaplicacionperfil` WRITE;
/*!40000 ALTER TABLE `tbl_permisosaplicacionperfil` DISABLE KEYS */;
INSERT INTO `tbl_permisosaplicacionperfil` VALUES (1,1000,1,1,1,1,1),(1,1001,1,1,1,1,1),(1,1002,1,1,1,1,1),(1,1003,1,1,1,1,1),(1,1004,1,1,1,1,1),(1,1101,1,1,1,1,1),(1,1102,1,1,1,1,1),(1,1103,1,1,1,1,1),(1,1201,1,1,1,1,1),(1,1301,1,1,1,1,1),(1,8000,1,1,1,1,1),(1,8001,1,1,1,1,1),(1,8002,1,1,1,1,1),(1,8003,1,1,1,1,1),(1,8004,1,1,1,1,1),(1,8005,1,1,1,1,1),(1,8006,1,1,1,1,1),(1,8007,1,1,1,1,1),(1,8008,1,1,1,1,1),(1,8009,1,1,1,1,1),(1,8010,1,1,1,1,1),(1,8011,1,1,1,1,1),(1,8012,1,1,1,1,1),(1,8013,1,1,1,1,1),(1,8014,1,1,1,1,1),(1,8015,1,1,1,1,1),(1,8016,1,1,1,1,1),(1,8017,1,1,1,1,1),(1,8018,1,1,1,1,1),(1,8019,1,1,1,1,1),(1,8020,1,1,1,1,1),(1,8021,1,1,1,1,1);
/*!40000 ALTER TABLE `tbl_permisosaplicacionperfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_producto`
--

DROP TABLE IF EXISTS `tbl_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_producto` (
  `cod_producto` int(11) NOT NULL,
  `nombre_prod` varchar(45) NOT NULL,
  `descripcion_prod` varchar(45) NOT NULL,
  `precioUnitario_prod` double NOT NULL,
  `tbl_linea_id_linea` int(11) NOT NULL,
  `tbl_marca_id_marca` int(11) NOT NULL,
  PRIMARY KEY (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_producto`
--

LOCK TABLES `tbl_producto` WRITE;
/*!40000 ALTER TABLE `tbl_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_proveedor`
--

DROP TABLE IF EXISTS `tbl_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_proveedor` (
  `id_prov` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_prov` varchar(45) NOT NULL,
  `domicilio_prov` varchar(45) NOT NULL,
  `telefono_prov` varchar(45) NOT NULL,
  `nit_prov` varchar(20) NOT NULL,
  `estado_prov` varchar(45) NOT NULL,
  PRIMARY KEY (`id_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_proveedor`
--

LOCK TABLES `tbl_proveedor` WRITE;
/*!40000 ALTER TABLE `tbl_proveedor` DISABLE KEYS */;
INSERT INTO `tbl_proveedor` VALUES (1,'Andrea Corado','Zona 5','41224025','1789429','0'),(2,'Smith Enterprises','14 calle 12-26 zona 8','56746493','2328562','activo'),(3,'david','zona 1','12457896','11887596','0'),(4,'Carol','zona 6','258741369','125478963','Activo');
/*!40000 ALTER TABLE `tbl_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_registro_moneda`
--

DROP TABLE IF EXISTS `tbl_registro_moneda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_registro_moneda` (
  `regmon_id_Moneda` int(11) NOT NULL AUTO_INCREMENT,
  `regmon_Tipo_moneda` varchar(100) DEFAULT NULL,
  `regmon_Valor_moneda` float DEFAULT NULL,
  `regmon_fecha_de_registro` datetime DEFAULT NULL,
  `regmon_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`regmon_id_Moneda`),
  UNIQUE KEY `regmon_Tipo_moneda` (`regmon_Tipo_moneda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_registro_moneda`
--

LOCK TABLES `tbl_registro_moneda` WRITE;
/*!40000 ALTER TABLE `tbl_registro_moneda` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_registro_moneda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_sucursales`
--

DROP TABLE IF EXISTS `tbl_sucursales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_sucursales` (
  `id_sucursal` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_sucursal` varchar(45) NOT NULL,
  `direccion_sucursal` varchar(45) NOT NULL,
  `telefono_sucursal` int(11) NOT NULL,
  `correo_sucursal` varchar(45) NOT NULL,
  PRIMARY KEY (`id_sucursal`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_sucursales`
--

LOCK TABLES `tbl_sucursales` WRITE;
/*!40000 ALTER TABLE `tbl_sucursales` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_sucursales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipocambio`
--

DROP TABLE IF EXISTS `tbl_tipocambio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipocambio` (
  `id_tipo_cambio` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `moneda_origen` varchar(10) NOT NULL,
  `moneda_destino` varchar(10) NOT NULL,
  `tipo_cambio` double NOT NULL,
  PRIMARY KEY (`id_tipo_cambio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipocambio`
--

LOCK TABLES `tbl_tipocambio` WRITE;
/*!40000 ALTER TABLE `tbl_tipocambio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tipocambio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_transacciones`
--

DROP TABLE IF EXISTS `tbl_transacciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_transacciones` (
  `id_transaccion` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_transaccion` varchar(50) DEFAULT NULL,
  `numero_transaccion` varchar(50) DEFAULT NULL,
  `fecha_transaccion` date DEFAULT NULL,
  `beneficiario_transaccion` varchar(100) DEFAULT NULL,
  `concepto_transaccion` varchar(255) DEFAULT NULL,
  `numero_factura` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_transaccion`),
  KEY `numero_factura` (`numero_factura`),
  CONSTRAINT `tbl_transacciones_ibfk_1` FOREIGN KEY (`numero_factura`) REFERENCES `tbl_facturaxpagar` (`NoFactura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transacciones`
--

LOCK TABLES `tbl_transacciones` WRITE;
/*!40000 ALTER TABLE `tbl_transacciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_transacciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_transprov`
--

DROP TABLE IF EXISTS `tbl_transprov`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_transprov` (
  `id_transprov` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_transprov` varchar(45) NOT NULL,
  `estado_transprov` varchar(50) DEFAULT NULL,
  `tipo_transprov` varchar(20) NOT NULL,
  PRIMARY KEY (`id_transprov`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transprov`
--

LOCK TABLES `tbl_transprov` WRITE;
/*!40000 ALTER TABLE `tbl_transprov` DISABLE KEYS */;
INSERT INTO `tbl_transprov` VALUES (6,'Cancelación de Pagos Pendientes','Activo','Abono'),(7,'Pago a proveedores','Activo','Abono');
/*!40000 ALTER TABLE `tbl_transprov` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usuarios`
--

DROP TABLE IF EXISTS `tbl_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_usuarios` (
  `pk_id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(50) NOT NULL,
  `apellido_usuario` varchar(50) NOT NULL,
  `username_usuario` varchar(20) NOT NULL,
  `password_usuario` varchar(100) NOT NULL,
  `email_usuario` varchar(50) NOT NULL,
  `estado_usuario` tinyint(4) NOT NULL DEFAULT 0,
  `pregunta` varchar(50) NOT NULL,
  `respuesta` varchar(50) NOT NULL,
  PRIMARY KEY (`pk_id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_usuarios`
--

LOCK TABLES `tbl_usuarios` WRITE;
/*!40000 ALTER TABLE `tbl_usuarios` DISABLE KEYS */;
INSERT INTO `tbl_usuarios` VALUES (1,'admin','admin','admin','HO0aGo4nM94=','esduardo@gmail.com',1,'COLOR FAVORITO','X9yc1/l1b2A=');
/*!40000 ALTER TABLE `tbl_usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_vendedor`
--

DROP TABLE IF EXISTS `tbl_vendedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_vendedor` (
  `id_vendedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_vend` varchar(45) NOT NULL,
  `telefono_vend` varchar(45) NOT NULL,
  `estado_vend` varchar(45) NOT NULL,
  `tbl_ventaspedido_id_ventas_ped` int(11) NOT NULL,
  PRIMARY KEY (`id_vendedor`),
  KEY `fk_tbl_vendedor_tbl_ventaspedido1_idx` (`tbl_ventaspedido_id_ventas_ped`),
  CONSTRAINT `fk_tbl_vendedor_tbl_ventaspedido1` FOREIGN KEY (`tbl_ventaspedido_id_ventas_ped`) REFERENCES `tbl_ventaspedido` (`id_ventas_ped`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_vendedor`
--

LOCK TABLES `tbl_vendedor` WRITE;
/*!40000 ALTER TABLE `tbl_vendedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_vendedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ventaspedido`
--

DROP TABLE IF EXISTS `tbl_ventaspedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_ventaspedido` (
  `id_ventas_ped` int(11) NOT NULL,
  `id_vendedor` int(11) NOT NULL,
  `tbl_detalle_cotizacion_id` int(11) NOT NULL,
  PRIMARY KEY (`id_ventas_ped`),
  KEY `fk_id_vendedor_idx` (`id_vendedor`),
  KEY `tbl_detalle_cotizacion_id_idx` (`tbl_detalle_cotizacion_id`),
  CONSTRAINT `fk_id_vendedor` FOREIGN KEY (`id_vendedor`) REFERENCES `tbl_vendedor` (`id_vendedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `tbl_detalle_cotizacion_id` FOREIGN KEY (`tbl_detalle_cotizacion_id`) REFERENCES `tbl_detalle_cotizacion` (`id_detalle_cotizacion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ventaspedido`
--

LOCK TABLES `tbl_ventaspedido` WRITE;
/*!40000 ALTER TABLE `tbl_ventaspedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ventaspedido` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-30 22:25:42

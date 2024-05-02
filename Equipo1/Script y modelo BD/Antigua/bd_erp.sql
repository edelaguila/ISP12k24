CREATE DATABASE  IF NOT EXISTS `bd_erp` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bd_erp`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_erp
-- ------------------------------------------------------
-- Server version	8.1.0

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
  `pk_id_aplicacion` int NOT NULL,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(150) NOT NULL,
  `estado_aplicacion` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_aplicaciones`
--

LOCK TABLES `tbl_aplicaciones` WRITE;
/*!40000 ALTER TABLE `tbl_aplicaciones` DISABLE KEYS */;
INSERT INTO `tbl_aplicaciones` VALUES (1,'Menu','Ingreso Login',1),(999,'Cerrar Sesion','Cerrar Sesion',1),(1000,'MDI SEGURIDAD','PARA SEGURIDAD',1),(1001,'Mant. Usuario','PARA SEGURIDAD',1),(1002,'Mant. Aplicación','PARA SEGURIDAD',1),(1003,'Mant. Modulo','PARA SEGURIDAD',1),(1004,'Mant. Perfil','PARA SEGURIDAD',1),(1101,'Asign. Modulo Aplicacion','PARA SEGURIDAD',1),(1102,'Asign. Aplicacion Perfil','PARA SEGURIDAD',1),(1103,'Asign. Perfil Usuario','PARA SEGURIDAD',1),(1201,'Pcs. Cambio Contraseña','PARA SEGURIDAD',1),(1301,'Pcs. BITACORA','PARA SEGURIDAD',1),(8000,'MDI PROTOTIPO ERP','PARA ERP',1),(8001,'Mant. Proveedor','PARA ERP',1),(8002,'Mant. Transacciones Proveedor','PARA ERP',1),(8003,'Mant. Clientes','PARA ERP',1),(8004,'Mant. Vendedores','PARA ERP',1),(8005,'Mant. Productos','PARA ERP',1),(8006,'Mant. Mov. Inventario','PARA ERP',1),(8007,'Mant. Bancos','PARA ERP',1),(8008,'Mant. Movimiento Bancos','PARA ERP',1),(8009,'Mant. Tipo de Cambio','PARA ERP',1),(8010,'Pro. Ordenes de Compra','PARA ERP',1),(8011,'Pro. Compras','PARA ERP',1),(8012,'Pro. Factura por Pagar','PARA ERP',1),(8013,'Pro. Movimiento Proveedores','PARA ERP',1),(8014,'Pro. Cotizacion de Ventas','PARA ERP',1),(8015,'Pro. Pedidos','PARA ERP',1),(8016,'Pro. Facturas por Cobrar','PARA ERP',1),(8017,'Pro. Traslado de Producto','PARA ERP',1),(8018,'Pro. Auditoría de Inventario','PARA ERP',1),(8019,'Pro. Movimiento Bancario','PARA ERP',1),(8020,'Pro. Autorizacion Ordenes','PARA ERP',1),(8021,'Pro. Disponibilidad Diaria','PARA ERP',1),(8030,'Mant. Cuenta bancaria','PARA ERP',1),(8031,'Pro. Movimiento de bancos','PARA ERP',1);
/*!40000 ALTER TABLE `tbl_aplicaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asignacionesperfilsusuario`
--

DROP TABLE IF EXISTS `tbl_asignacionesperfilsusuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacionesperfilsusuario` (
  `fk_id_usuario` int NOT NULL,
  `fk_id_perfil` int NOT NULL,
  PRIMARY KEY (`fk_id_usuario`,`fk_id_perfil`),
  KEY `fk_id_perfil` (`fk_id_perfil`),
  CONSTRAINT `tbl_asignacionesperfilsusuario_ibfk_1` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  CONSTRAINT `tbl_asignacionesperfilsusuario_ibfk_2` FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
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
  `fk_id_modulos` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  PRIMARY KEY (`fk_id_modulos`,`fk_id_aplicacion`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`),
  CONSTRAINT `tbl_asignacionmoduloaplicacion_ibfk_1` FOREIGN KEY (`fk_id_modulos`) REFERENCES `tbl_modulos` (`pk_id_modulos`),
  CONSTRAINT `tbl_asignacionmoduloaplicacion_ibfk_2` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignacionmoduloaplicacion`
--

LOCK TABLES `tbl_asignacionmoduloaplicacion` WRITE;
/*!40000 ALTER TABLE `tbl_asignacionmoduloaplicacion` DISABLE KEYS */;
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES (1000,1000),(1000,1001),(1000,1002),(1000,1003),(1000,1004),(1000,1102),(1000,1103),(1000,1201),(1000,1301),(8000,8000),(8000,8001),(8000,8002),(8000,8003),(8000,8004),(8000,8005),(8000,8006),(8000,8007),(8000,8008),(8000,8009),(8000,8010),(8000,8011),(8000,8012),(8000,8013),(8000,8014),(8000,8015),(8000,8016),(8000,8017),(8000,8018),(8000,8019),(8000,8020),(8000,8021),(8000,8030),(8000,8031);
/*!40000 ALTER TABLE `tbl_asignacionmoduloaplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_autorizacionordenescompra`
--

DROP TABLE IF EXISTS `tbl_autorizacionordenescompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_autorizacionordenescompra` (
  `id_numeroDeAutorizacion` int NOT NULL AUTO_INCREMENT,
  `tbl_OrdenesCompra_id_OrdComp` int NOT NULL,
  `estadoOrden` varchar(30) NOT NULL,
  `conceptoDeAutorizacion` varchar(50) NOT NULL,
  `fechaAutorizacion` date NOT NULL,
  `subTotal` double NOT NULL,
  `iva` double NOT NULL,
  `totalOrden` double NOT NULL,
  `cuentaAsociada` int NOT NULL,
  PRIMARY KEY (`id_numeroDeAutorizacion`),
  KEY `tbl_OrdenesCompra_id_OrdComp` (`tbl_OrdenesCompra_id_OrdComp`),
  KEY `cuentaAsociada` (`cuentaAsociada`),
  CONSTRAINT `tbl_autorizacionordenescompra_ibfk_1` FOREIGN KEY (`tbl_OrdenesCompra_id_OrdComp`) REFERENCES `tbl_ordenescompra` (`id_OrdComp`),
  CONSTRAINT `tbl_autorizacionordenescompra_ibfk_2` FOREIGN KEY (`cuentaAsociada`) REFERENCES `tbl_cuentabancaria` (`id_cuentaBancaria`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_autorizacionordenescompra`
--

LOCK TABLES `tbl_autorizacionordenescompra` WRITE;
/*!40000 ALTER TABLE `tbl_autorizacionordenescompra` DISABLE KEYS */;
INSERT INTO `tbl_autorizacionordenescompra` VALUES (1,1,'Aprobado','Esta persona debe mucho dinero ','2024-04-26',500.2,15.2,515.2,1),(2,3,'No aprobado','Le vamos a robar dinero xd','2024-04-26',90700,10884,101584,1);
/*!40000 ALTER TABLE `tbl_autorizacionordenescompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_banco`
--

DROP TABLE IF EXISTS `tbl_banco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_banco` (
  `id_banco` int NOT NULL AUTO_INCREMENT,
  `nombre_banco` varchar(30) NOT NULL,
  `direccion_banco` varchar(50) DEFAULT NULL,
  `telefono_banco` varchar(20) DEFAULT NULL,
  `estado_banco` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_banco`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_banco`
--

LOCK TABLES `tbl_banco` WRITE;
/*!40000 ALTER TABLE `tbl_banco` DISABLE KEYS */;
INSERT INTO `tbl_banco` VALUES (3,'Banco Industrial','zona2','142412','Activo '),(4,'BAM','zona3','87656278','Suspendido');
/*!40000 ALTER TABLE `tbl_banco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_banco2`
--

DROP TABLE IF EXISTS `tbl_banco2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_banco2` (
  `ban_id_Banco` int NOT NULL AUTO_INCREMENT,
  `fk_ban_Nombre_banco` varchar(100) DEFAULT NULL,
  `ban_status` int DEFAULT NULL,
  PRIMARY KEY (`ban_id_Banco`),
  KEY `fk_ban_Nombre_banco` (`fk_ban_Nombre_banco`),
  CONSTRAINT `tbl_banco2_ibfk_1` FOREIGN KEY (`fk_ban_Nombre_banco`) REFERENCES `tbl_mantenimientos_agregar_bancos` (`manag_nombre_banco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `pk_id_bitacora` int NOT NULL AUTO_INCREMENT,
  `fk_id_usuario` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=482 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacoradeeventos`
--

LOCK TABLES `tbl_bitacoradeeventos` WRITE;
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` DISABLE KEYS */;
INSERT INTO `tbl_bitacoradeeventos` VALUES (1,1,1000,'2024-02-21','19:21:03','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(2,1,1000,'2024-02-21','19:21:53','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(3,1,1,'2024-02-23','08:36:22','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(4,1,1000,'2024-02-23','08:36:23','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(5,1,1,'2024-02-23','08:37:00','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(6,1,1,'2024-02-23','08:37:47','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(7,1,999,'2024-02-23','08:37:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Cerro Sesion'),(8,1,1,'2024-02-23','09:12:16','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(9,1,1000,'2024-02-23','09:12:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(10,1,1000,'2024-02-23','09:14:25','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(11,1,999,'2024-02-23','09:27:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Cerro Sesion'),(12,1,1,'2024-02-23','21:23:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(13,1,1000,'2024-02-23','21:23:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(14,1,1000,'2024-02-23','21:24:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(15,1,1000,'2024-02-23','21:25:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(16,1,1,'2024-02-23','21:26:16','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(17,1,1000,'2024-02-23','21:26:17','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(18,1,1,'2024-02-23','21:28:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(19,1,1000,'2024-02-23','21:28:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(20,1,1000,'2024-02-23','21:29:37','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(21,1,1000,'2024-02-23','21:30:32','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(22,1,999,'2024-02-23','21:54:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Cerro Sesion'),(23,1,1,'2024-04-10','20:28:49','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(24,1,1000,'2024-04-10','20:28:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(25,1,1000,'2024-04-10','20:29:04','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(26,1,1000,'2024-04-10','20:29:13','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(27,1,1000,'2024-04-10','20:29:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha modificado un registro'),(28,1,1000,'2024-04-10','20:29:35','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(29,1,1,'2024-04-10','20:41:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(30,1,1000,'2024-04-10','20:41:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(31,1,1,'2024-04-10','20:43:01','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(32,1,1000,'2024-04-10','20:43:02','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(33,1,1,'2024-04-10','20:45:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(34,1,1000,'2024-04-10','20:45:19','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(35,1,1,'2024-04-10','20:46:11','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(36,1,1000,'2024-04-10','20:46:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(37,1,1,'2024-04-10','20:47:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(38,1,1000,'2024-04-10','20:47:20','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(39,1,1,'2024-04-10','22:32:10','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(40,1,1000,'2024-04-10','22:32:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(41,1,1,'2024-04-10','22:33:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(42,1,1000,'2024-04-10','22:33:43','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(43,1,1,'2024-04-10','22:40:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(44,1,1000,'2024-04-10','22:40:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(45,1,1,'2024-04-10','22:42:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(46,1,1000,'2024-04-10','22:42:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(47,1,1,'2024-04-10','22:44:08','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(48,1,1000,'2024-04-10','22:44:09','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(49,1,1,'2024-04-10','22:45:49','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(50,1,1000,'2024-04-10','22:45:49','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(51,1,1,'2024-04-10','22:48:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(52,1,1000,'2024-04-10','22:48:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(53,1,1,'2024-04-10','22:49:39','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(54,1,1000,'2024-04-10','22:49:40','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(55,1,1,'2024-04-10','22:50:44','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(56,1,1000,'2024-04-10','22:50:45','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(57,1,1,'2024-04-10','22:52:07','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(58,1,1000,'2024-04-10','22:52:08','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(59,1,1,'2024-04-10','22:58:39','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(60,1,1000,'2024-04-10','22:58:40','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(61,1,1,'2024-04-10','22:59:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(62,1,1000,'2024-04-10','22:59:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(63,1,1000,'2024-04-10','23:01:39','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(64,1,1,'2024-04-10','23:02:35','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(65,1,1000,'2024-04-10','23:02:36','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(66,1,1,'2024-04-10','23:05:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(67,1,1000,'2024-04-10','23:05:35','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(68,1,1,'2024-04-10','23:06:05','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(69,1,1000,'2024-04-10','23:06:06','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(70,1,1,'2024-04-10','23:06:36','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(71,1,1000,'2024-04-10','23:06:38','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(72,1,1,'2024-04-10','23:09:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(73,1,1000,'2024-04-10','23:09:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(74,1,1,'2024-04-10','23:10:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(75,1,1000,'2024-04-10','23:10:55','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(76,1,1,'2024-04-10','23:11:52','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(77,1,1000,'2024-04-10','23:11:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(78,1,1,'2024-04-10','23:13:29','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(79,1,1000,'2024-04-10','23:13:31','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(80,1,1,'2024-04-10','23:16:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(81,1,1000,'2024-04-10','23:16:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(82,1,1,'2024-04-10','23:25:44','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(83,1,1000,'2024-04-10','23:25:45','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(84,1,1,'2024-04-10','23:27:06','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(85,1,1000,'2024-04-10','23:27:07','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(86,1,1,'2024-04-10','23:28:08','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(87,1,1000,'2024-04-10','23:28:09','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(88,1,1,'2024-04-10','23:31:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(89,1,1000,'2024-04-10','23:31:43','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(90,1,1,'2024-04-10','23:31:59','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(91,1,1000,'2024-04-10','23:32:00','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(92,1,1,'2024-04-10','23:34:12','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(93,1,1000,'2024-04-10','23:34:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(94,1,1,'2024-04-10','23:35:43','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(95,1,1000,'2024-04-10','23:35:45','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(96,1,1,'2024-04-10','23:37:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(97,1,1000,'2024-04-10','23:37:52','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(98,1,1,'2024-04-10','23:39:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(99,1,1000,'2024-04-10','23:39:20','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(100,1,1,'2024-04-10','23:52:03','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(101,1,1000,'2024-04-10','23:52:03','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(102,1,1,'2024-04-10','23:53:59','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(103,1,1000,'2024-04-10','23:54:00','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(104,1,1,'2024-04-10','23:54:45','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(105,1,1000,'2024-04-10','23:54:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(106,1,1,'2024-04-10','23:56:32','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(107,1,1000,'2024-04-10','23:56:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(108,1,1,'2024-04-11','09:43:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(109,1,1000,'2024-04-11','09:43:19','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(111,1,1000,'2024-04-11','09:43:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Seguridad'),(112,1,1,'2024-04-11','09:44:35','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(113,1,1000,'2024-04-11','09:44:36','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(114,1,1000,'2024-04-11','09:44:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha modificado un registro'),(115,1,1000,'2024-04-11','09:44:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Seguridad'),(116,1,1,'2024-04-11','09:47:28','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(117,1,1000,'2024-04-11','09:47:29','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(119,1,1000,'2024-04-11','09:47:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Seguridad'),(120,1,1,'2024-04-11','09:50:51','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(121,1,1000,'2024-04-11','09:50:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(122,1,1,'2024-04-11','09:53:38','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(123,1,1000,'2024-04-11','09:53:39','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(124,1,1,'2024-04-11','16:43:02','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(125,1,1,'2024-04-11','16:45:29','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(126,1,8000,'2024-04-11','16:45:31','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(127,1,1,'2024-04-11','16:47:00','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(128,1,8000,'2024-04-11','16:47:01','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(129,1,1,'2024-04-11','16:59:56','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(130,1,8000,'2024-04-11','16:59:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(131,1,1,'2024-04-11','17:01:40','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(132,1,8000,'2024-04-11','17:01:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(133,1,8000,'2024-04-11','17:01:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(134,1,1,'2024-04-11','17:20:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(135,1,8000,'2024-04-11','17:20:20','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(136,1,1,'2024-04-11','17:22:03','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(137,1,8000,'2024-04-11','17:22:04','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(138,1,1,'2024-04-11','17:23:11','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(139,1,8000,'2024-04-11','17:23:12','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(140,1,1,'2024-04-11','17:29:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(141,1,8000,'2024-04-11','17:29:27','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(142,1,1,'2024-04-11','17:30:36','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(143,1,8000,'2024-04-11','17:30:37','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(144,1,1,'2024-04-11','17:32:10','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(145,1,8000,'2024-04-11','17:32:11','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(146,1,1,'2024-04-11','17:33:16','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(147,1,8000,'2024-04-11','17:33:17','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(148,1,1,'2024-04-11','17:35:28','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(149,1,8000,'2024-04-11','17:35:30','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(150,1,1,'2024-04-11','17:41:01','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(151,1,8000,'2024-04-11','17:41:02','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(152,1,1,'2024-04-11','17:42:40','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(153,1,8000,'2024-04-11','17:42:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(154,1,1,'2024-04-11','17:45:23','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(155,1,8000,'2024-04-11','17:45:25','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(156,1,8000,'2024-04-11','17:45:27','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(157,1,1,'2024-04-11','18:31:59','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(158,1,8000,'2024-04-11','18:32:00','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(159,1,1,'2024-04-11','18:40:10','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(160,1,8000,'2024-04-11','18:40:11','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(161,1,1,'2024-04-11','19:02:34','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(162,1,8000,'2024-04-11','19:02:45','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(163,1,1,'2024-04-11','19:39:30','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(164,1,8000,'2024-04-11','19:39:31','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(165,1,1,'2024-04-11','19:40:27','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(166,1,8000,'2024-04-11','19:40:29','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(167,1,1,'2024-04-11','20:00:05','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(168,1,8000,'2024-04-11','20:00:06','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(169,1,1,'2024-04-11','20:01:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(170,1,8000,'2024-04-11','20:01:34','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(171,1,1,'2024-04-11','20:03:13','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(172,1,8000,'2024-04-11','20:03:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(173,1,1,'2024-04-11','20:05:32','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(174,1,8000,'2024-04-11','20:05:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(175,1,1,'2024-04-11','20:19:40','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(176,1,8000,'2024-04-11','20:19:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(177,1,1,'2024-04-11','20:21:00','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(178,1,8000,'2024-04-11','20:21:01','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(179,1,1,'2024-04-11','20:22:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(180,1,8000,'2024-04-11','20:22:15','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(181,1,1,'2024-04-11','20:24:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(182,1,8000,'2024-04-11','20:24:51','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(183,1,1,'2024-04-11','20:29:05','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(184,1,8000,'2024-04-11','20:29:06','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(185,1,1,'2024-04-11','20:31:07','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(186,1,8000,'2024-04-11','20:31:08','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(187,1,1,'2024-04-11','20:34:35','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(188,1,8000,'2024-04-11','20:34:36','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(189,1,1,'2024-04-11','20:36:59','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(190,1,8000,'2024-04-11','20:37:00','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(191,1,1,'2024-04-11','20:39:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(192,1,8000,'2024-04-11','20:39:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(193,1,1,'2024-04-11','20:44:16','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(194,1,8000,'2024-04-11','20:44:17','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(195,1,1,'2024-04-11','20:46:47','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(196,1,8000,'2024-04-11','20:46:48','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(197,1,1,'2024-04-11','20:48:17','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(198,1,8000,'2024-04-11','20:48:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(199,1,1,'2024-04-11','20:49:56','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(200,1,8000,'2024-04-11','20:49:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(201,1,1,'2024-04-11','20:56:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(202,1,8000,'2024-04-11','20:56:19','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(203,1,1,'2024-04-11','21:07:13','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(204,1,8000,'2024-04-11','21:07:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(205,1,8003,'2024-04-11','21:07:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha modificado un registro'),(206,1,1000,'2024-04-11','21:07:51','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Seguridad'),(207,1,1,'2024-04-12','08:59:35','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(208,1,8000,'2024-04-12','08:59:37','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(209,1,1,'2024-04-12','09:09:30','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(210,1,8000,'2024-04-12','09:09:31','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(211,1,1,'2024-04-12','09:11:16','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(212,1,8000,'2024-04-12','09:11:17','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(213,1,1,'2024-04-12','10:06:22','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(214,1,8000,'2024-04-12','10:06:23','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(215,1,8003,'2024-04-12','10:08:45','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(216,1,8003,'2024-04-12','10:09:07','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(217,1,8003,'2024-04-12','10:09:25','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha modificado un registro'),(218,1,8004,'2024-04-12','10:09:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(219,1,1,'2024-04-12','10:17:32','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(220,1,8000,'2024-04-12','10:17:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(221,1,1,'2024-04-12','10:19:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(222,1,8000,'2024-04-12','10:19:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(223,1,1,'2024-04-12','10:21:48','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(224,1,8000,'2024-04-12','10:21:49','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(225,1,1,'2024-04-12','10:23:15','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(226,1,8000,'2024-04-12','10:23:16','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(227,1,1,'2024-04-12','10:24:02','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(228,1,8000,'2024-04-12','10:24:03','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(229,1,1,'2024-04-12','10:25:49','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(230,1,8000,'2024-04-12','10:25:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(231,1,1,'2024-04-12','10:31:38','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(232,1,8000,'2024-04-12','10:31:39','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(233,1,1,'2024-04-12','10:36:08','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(234,1,8000,'2024-04-12','10:36:09','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(235,1,1,'2024-04-12','10:36:47','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(236,1,8000,'2024-04-12','10:36:48','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(237,1,1,'2024-04-12','10:38:52','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(238,1,8000,'2024-04-12','10:38:53','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(239,1,1,'2024-04-12','10:40:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(240,1,8000,'2024-04-12','10:40:22','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(241,1,1,'2024-04-12','10:45:08','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(242,1,8000,'2024-04-12','10:45:09','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(243,1,1,'2024-04-12','10:47:02','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(244,1,8000,'2024-04-12','10:47:03','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(245,1,1,'2024-04-12','10:47:48','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(246,1,8000,'2024-04-12','10:47:49','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(247,1,1,'2024-04-12','10:58:08','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(248,1,8000,'2024-04-12','10:58:09','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(249,1,1,'2024-04-12','11:25:53','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(250,1,8000,'2024-04-12','11:25:55','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(251,1,1,'2024-04-12','11:49:04','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(252,1,8000,'2024-04-12','11:49:05','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(253,1,1,'2024-04-12','11:50:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(254,1,8000,'2024-04-12','11:50:34','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(255,1,1,'2024-04-12','11:52:31','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(256,1,8000,'2024-04-12','11:52:32','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(257,1,8001,'2024-04-12','11:52:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(258,1,8001,'2024-04-12','11:52:51','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha modificado un registro'),(259,1,8001,'2024-04-12','11:52:59','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha modificado un registro'),(260,1,8001,'2024-04-12','11:53:05','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(261,1,8001,'2024-04-12','11:53:15','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(262,1,8001,'2024-04-12','11:53:28','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(263,1,8001,'2024-04-12','11:53:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha eliminado un registro'),(264,1,8001,'2024-04-12','11:53:47','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha eliminado un registro'),(265,1,8001,'2024-04-12','11:53:59','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(266,1,8003,'2024-04-12','11:54:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(267,1,8001,'2024-04-12','11:55:06','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(268,1,1,'2024-04-12','11:56:01','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(269,1,8000,'2024-04-12','11:56:02','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(270,1,8001,'2024-04-12','11:56:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(271,1,8001,'2024-04-12','11:56:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(272,1,8001,'2024-04-12','11:56:34','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(273,1,8001,'2024-04-12','11:56:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(274,1,1,'2024-04-12','13:12:53','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(275,1,8000,'2024-04-12','13:12:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(276,1,1,'2024-04-12','13:13:55','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(277,1,8000,'2024-04-12','13:13:56','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(278,1,8004,'2024-04-12','13:14:36','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha modificado un registro'),(279,1,1,'2024-04-12','13:15:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(280,1,8000,'2024-04-12','13:15:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(281,1,8004,'2024-04-12','13:16:15','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(282,1,8004,'2024-04-12','13:16:30','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(283,1,8004,'2024-04-12','13:16:38','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(284,1,8000,'2024-04-12','13:17:07','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(285,1,8004,'2024-04-12','13:17:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(286,1,1,'2024-04-12','13:18:28','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(287,1,8000,'2024-04-12','13:18:29','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(288,1,8004,'2024-04-12','13:18:48','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(289,1,1,'2024-04-12','13:23:19','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(290,1,8000,'2024-04-12','13:23:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(291,1,8004,'2024-04-12','13:23:40','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(292,1,1,'2024-04-12','13:25:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(293,1,8000,'2024-04-12','13:25:28','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(294,1,8004,'2024-04-12','13:25:51','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(295,1,1,'2024-04-12','13:26:37','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(296,1,8000,'2024-04-12','13:26:38','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(297,1,8004,'2024-04-12','13:26:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(298,1,1,'2024-04-12','13:28:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(299,1,8000,'2024-04-12','13:28:55','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(300,1,8004,'2024-04-12','13:29:07','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(301,1,1,'2024-04-12','13:30:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(302,1,8000,'2024-04-12','13:30:55','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(303,1,8004,'2024-04-12','13:31:05','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(304,1,1,'2024-04-12','13:45:20','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(305,1,8000,'2024-04-12','13:45:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(306,1,1,'2024-04-12','13:52:44','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(307,1,8000,'2024-04-12','13:52:45','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(308,1,1,'2024-04-12','14:13:02','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(309,1,8000,'2024-04-12','14:13:03','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(310,1,1,'2024-04-12','14:13:52','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(311,1,8000,'2024-04-12','14:13:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(312,1,1,'2024-04-12','14:15:23','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(313,1,8000,'2024-04-12','14:15:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(314,1,1,'2024-04-12','14:18:22','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(315,1,8000,'2024-04-12','14:18:23','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(316,1,1,'2024-04-12','14:19:31','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(317,1,8000,'2024-04-12','14:19:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(318,1,1,'2024-04-12','14:27:29','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(319,1,8000,'2024-04-12','14:27:30','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(320,1,1,'2024-04-12','14:28:07','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(321,1,8000,'2024-04-12','14:28:08','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(322,1,1,'2024-04-12','14:28:55','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(323,1,8000,'2024-04-12','14:28:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(324,1,1,'2024-04-12','14:30:05','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(325,1,8000,'2024-04-12','14:30:06','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(326,1,1,'2024-04-12','14:32:29','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(327,1,8000,'2024-04-12','14:32:30','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(328,1,1,'2024-04-12','14:34:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(329,1,8000,'2024-04-12','14:34:25','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(330,1,1,'2024-04-12','14:35:25','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(331,1,8000,'2024-04-12','14:35:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(332,1,1,'2024-04-12','18:11:09','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(333,1,8000,'2024-04-12','18:11:10','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(334,1,1,'2024-04-12','18:17:17','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(335,1,8000,'2024-04-12','18:17:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(336,1,1,'2024-04-12','18:17:51','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(337,1,8000,'2024-04-12','18:17:53','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(338,1,8007,'2024-04-12','18:18:27','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(339,1,8008,'2024-04-12','18:18:52','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(340,1,8030,'2024-04-12','18:19:29','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(341,1,1000,'2024-04-12','18:21:30','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Seguridad'),(342,1,1,'2024-04-12','18:29:28','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(343,1,8000,'2024-04-12','18:29:30','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(345,1,8000,'2024-04-12','18:30:27','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(346,1,1,'2024-04-12','18:30:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(347,1,8000,'2024-04-12','18:30:48','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(348,1,1,'2024-04-12','21:50:27','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(349,1,8000,'2024-04-12','21:50:28','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(350,1,1,'2024-04-12','21:50:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(351,1,8000,'2024-04-12','21:50:51','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(352,1,1,'2024-04-12','21:52:25','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(353,1,8000,'2024-04-12','21:52:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(354,1,1,'2024-04-12','21:53:23','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(355,1,8000,'2024-04-12','21:53:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(356,1,1,'2024-04-12','21:54:09','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(357,1,8000,'2024-04-12','21:54:10','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(358,1,1,'2024-04-12','22:29:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(359,1,8000,'2024-04-12','22:29:25','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(360,1,8001,'2024-04-12','22:29:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(361,1,8002,'2024-04-12','22:30:39','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(362,1,8002,'2024-04-12','22:30:59','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(363,1,8003,'2024-04-12','22:31:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(364,1,8004,'2024-04-12','22:32:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(365,1,8004,'2024-04-12','22:32:37','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha modificado un registro'),(366,1,8007,'2024-04-12','22:33:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(367,1,8008,'2024-04-12','22:33:52','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(368,1,8030,'2024-04-12','22:34:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(369,1,1000,'2024-04-12','22:44:48','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Seguridad'),(370,1,1,'2024-04-12','22:45:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(371,1,1000,'2024-04-12','22:45:56','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Seguridad'),(372,1,1,'2024-04-12','22:51:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(373,1,8000,'2024-04-12','22:51:34','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(374,1,8002,'2024-04-12','22:51:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(375,1,8002,'2024-04-12','22:52:03','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(376,1,8002,'2024-04-12','22:52:34','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(377,1,1,'2024-04-12','22:54:05','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(378,1,8000,'2024-04-12','22:54:06','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(379,1,8002,'2024-04-12','22:54:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(380,1,1,'2024-04-15','20:39:39','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(381,1,8000,'2024-04-15','20:39:40','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(382,1,1,'2024-04-17','14:01:12','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(383,1,8000,'2024-04-17','14:01:13','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo Parcial'),(384,1,1,'2024-04-18','10:28:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(385,1,8000,'2024-04-18','10:28:59','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Cinevision parcial2'),(386,1,1,'2024-04-18','10:32:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(387,1,8000,'2024-04-18','10:32:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Cinevision parcial2'),(388,1,1,'2024-04-18','10:32:53','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(389,1,8000,'2024-04-18','10:32:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Cinevision parcial2'),(390,1,1,'2024-04-26','11:28:10','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(391,1,8000,'2024-04-26','11:28:12','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(392,1,1,'2024-04-26','11:31:31','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(393,1,8000,'2024-04-26','11:31:32','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(394,1,1,'2024-04-26','11:33:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(395,1,8000,'2024-04-26','11:33:49','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(396,1,1,'2024-04-26','11:39:20','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(397,1,8000,'2024-04-26','11:39:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(398,1,1,'2024-04-26','11:41:17','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(399,1,8000,'2024-04-26','11:41:18','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(400,1,1,'2024-04-26','11:42:11','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(401,1,1,'2024-04-26','11:42:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(402,1,8000,'2024-04-26','11:42:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(403,1,1,'2024-04-26','11:54:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(404,1,8000,'2024-04-26','11:54:28','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(405,1,1,'2024-04-26','11:56:05','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(406,1,8000,'2024-04-26','11:56:06','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(407,1,1,'2024-04-26','11:57:08','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(408,1,8000,'2024-04-26','11:57:09','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(409,1,1,'2024-04-26','11:58:40','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(410,1,8000,'2024-04-26','11:58:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(411,1,1,'2024-04-26','12:02:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(412,1,8000,'2024-04-26','12:02:22','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(413,1,1,'2024-04-26','12:11:34','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(414,1,8000,'2024-04-26','12:11:36','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(415,1,1,'2024-04-26','12:14:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(416,1,8000,'2024-04-26','12:14:15','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(417,1,1,'2024-04-26','12:17:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(418,1,8000,'2024-04-26','12:17:28','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(419,1,1,'2024-04-26','12:19:57','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(420,1,8000,'2024-04-26','12:19:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(421,1,1,'2024-04-26','12:21:10','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(422,1,8000,'2024-04-26','12:21:11','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(423,1,1,'2024-04-26','12:22:00','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(424,1,8000,'2024-04-26','12:22:02','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(425,1,1,'2024-04-26','12:25:54','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(426,1,8000,'2024-04-26','12:25:55','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(427,1,1,'2024-04-26','12:27:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(428,1,8000,'2024-04-26','12:27:47','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(429,1,1,'2024-04-26','12:28:43','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(430,1,8000,'2024-04-26','12:28:44','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(431,1,1,'2024-04-26','12:29:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(432,1,8000,'2024-04-26','12:29:59','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(433,1,1,'2024-04-26','12:35:13','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(434,1,8000,'2024-04-26','12:35:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(435,1,1,'2024-04-26','12:48:31','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(436,1,8000,'2024-04-26','12:48:32','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(437,1,1,'2024-04-26','12:52:31','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(438,1,8000,'2024-04-26','12:52:33','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(439,1,1,'2024-04-26','12:58:11','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(440,1,8000,'2024-04-26','12:58:12','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(441,1,1,'2024-04-26','13:00:13','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(442,1,8000,'2024-04-26','13:00:14','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(443,1,1,'2024-04-26','13:52:04','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(444,1,8000,'2024-04-26','13:52:06','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(445,1,1,'2024-04-26','17:11:29','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(446,1,8000,'2024-04-26','17:11:30','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(447,1,8005,'2024-04-26','17:12:49','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(448,1,1,'2024-04-26','17:13:20','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(449,1,8000,'2024-04-26','17:13:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(450,1,1,'2024-04-26','17:17:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(451,1,8000,'2024-04-26','17:17:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(452,1,8005,'2024-04-26','17:18:06','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(453,1,1,'2024-04-26','17:18:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(454,1,8000,'2024-04-26','17:18:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(455,1,1,'2024-04-26','17:24:46','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(456,1,8000,'2024-04-26','17:24:47','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(457,1,8005,'2024-04-26','17:25:22','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(458,1,1,'2024-04-26','17:27:58','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(459,1,8000,'2024-04-26','17:28:00','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(460,1,8005,'2024-04-26','17:28:20','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(461,1,1,'2024-04-26','17:30:40','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(462,1,8000,'2024-04-26','17:30:41','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(463,1,1,'2024-04-26','17:33:21','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(464,1,8000,'2024-04-26','17:33:22','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(465,1,1,'2024-04-26','17:34:52','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(466,1,8000,'2024-04-26','17:34:53','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(467,1,8005,'2024-04-26','17:35:12','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(468,1,1,'2024-04-26','17:36:09','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(469,1,8000,'2024-04-26','17:36:10','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(470,1,8005,'2024-04-26','17:36:30','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha modificado un registro'),(471,1,8005,'2024-04-26','17:36:50','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(472,1,1,'2024-04-26','18:06:04','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(473,1,8000,'2024-04-26','18:06:05','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(474,1,1,'2024-04-26','18:12:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(475,1,8000,'2024-04-26','18:12:26','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(476,1,1,'2024-04-26','18:22:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(477,1,8000,'2024-04-26','18:22:25','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(478,1,8002,'2024-04-26','18:22:48','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro'),(479,1,1,'2024-04-26','18:23:40','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(480,1,8000,'2024-04-26','18:23:42','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Prototipo'),(481,1,8002,'2024-04-26','18:24:07','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Se ha guardado un registro');
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bodegas`
--

DROP TABLE IF EXISTS `tbl_bodegas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bodegas` (
  `id_bodega` int NOT NULL AUTO_INCREMENT,
  `nombre_bodega` varchar(45) NOT NULL,
  `ubicacion_bodega` varchar(45) NOT NULL,
  `capacidad_bodega` int NOT NULL,
  PRIMARY KEY (`id_bodega`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bodegas`
--

LOCK TABLES `tbl_bodegas` WRITE;
/*!40000 ALTER TABLE `tbl_bodegas` DISABLE KEYS */;
INSERT INTO `tbl_bodegas` VALUES (1,'BytechBodega','Mixco',20);
/*!40000 ALTER TABLE `tbl_bodegas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_clientes`
--

DROP TABLE IF EXISTS `tbl_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_clientes` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `nombre_cl` varchar(50) NOT NULL,
  `apellido_cl` varchar(50) NOT NULL,
  `direccion_cl` varchar(100) NOT NULL,
  `correo_cl` varchar(100) NOT NULL,
  `telefono_cl` varchar(45) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=332 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_clientes`
--

LOCK TABLES `tbl_clientes` WRITE;
/*!40000 ALTER TABLE `tbl_clientes` DISABLE KEYS */;
INSERT INTO `tbl_clientes` VALUES (1,'aalonos','alex','a','a','a'),(2,'Lucas','hernandez','zon2','l@mail.com','123412'),(3,'David','Carrillo','Mixco','dav@mail.com','187652'),(4,'sas','das','das','das','sad'),(13,'Jose','Martinez','zona4','josm@mail.com','42142341'),(14,'Lucas','Hernandez','zona4','lc','412421'),(15,'David','a','a','a','a'),(16,'a','d','d','d','d'),(17,'a','a','a','a','a'),(18,'a','a','a','a','a'),(19,'e','e','e','e','e'),(20,'h','h','h','h','h'),(21,'g','g','g','g','g'),(22,'t','t','t','t','t'),(23,'t','t','t','t','t'),(24,'1b','b','b','b','b'),(25,'b','b','b','b','b'),(26,'1','1','1','1','1'),(27,'2','2','2','2','2'),(28,'barrios','balines','b','b','b'),(29,'b','b','b','b','bb'),(30,'n','n','n','n','n'),(31,'4','4','4','4','4'),(32,'1','1','1','1','1'),(33,'1','1','1','1','1'),(34,'1','1','1','1','1'),(35,'David','Carrillo','zona2','carri@mail.com','512521'),(36,'a','a','a','a','a'),(37,'m','am','m','m','m'),(38,'a','a','a','a','a'),(39,'23','23','23','23','23'),(99,'a','a','a','a','a'),(100,'David','Carrillo','mixco','car@mail.','123123'),(101,'Andrea','Cecilia','su casita','coradoa@mail.com','5682135'),(321,'Jose','Martinez','zona4','jos@mail.com','12412'),(322,'Jose','Escobar','zona4','esc@mail.com','421421'),(323,'m','m','dfgd','m','42'),(324,'mdasdasdasd','m','dfgd','m','42'),(325,'b','b','b','b','b'),(326,'asd','asd','asd','asd','asd'),(327,'adasd','asd','asd','asd','asd'),(328,'asd','asdsad','asd','asdas','da'),(329,'bnb','bnb','bnb','bn','bn'),(330,'Jose Maria','ordoñez','zona2','jos@mail.com','1124512'),(331,'Saul','Martinez','zona4','su@mail.com','8628632');
/*!40000 ALTER TABLE `tbl_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_compras`
--

DROP TABLE IF EXISTS `tbl_compras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_compras` (
  `id_EncComp` int NOT NULL AUTO_INCREMENT,
  `fechaSolicitid_EncComp` date NOT NULL,
  `fechaEntrega_OrdComp` date NOT NULL,
  `deptoSolicitante_EncComp` varchar(45) NOT NULL,
  `entregar_a_EncComp` varchar(45) NOT NULL,
  `subTotal_EncComp` double NOT NULL,
  `iva_EncComp` double NOT NULL,
  `totalOrden_EncComp` double NOT NULL,
  `notas_EncComp` varchar(45) NOT NULL,
  `tbl_proveedor_id_prov` int NOT NULL,
  `recibidoIgualSolicitado_EncComp` int NOT NULL,
  `fechaVencimientoPago_EncComp` date NOT NULL,
  `id_OrdComp` int NOT NULL,
  PRIMARY KEY (`id_EncComp`),
  KEY `fk_tbl_Encabezado_Compras_tbl_proveedor1_idx` (`tbl_proveedor_id_prov`),
  KEY `fk_OrdenCompra` (`id_OrdComp`),
  CONSTRAINT `fk_OrdenCompra` FOREIGN KEY (`id_OrdComp`) REFERENCES `tbl_ordenescompra` (`id_OrdComp`),
  CONSTRAINT `fk_tbl_Encabezado_Compras_tbl_proveedor1` FOREIGN KEY (`tbl_proveedor_id_prov`) REFERENCES `tbl_proveedor` (`id_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_compras`
--

LOCK TABLES `tbl_compras` WRITE;
/*!40000 ALTER TABLE `tbl_compras` DISABLE KEYS */;
INSERT INTO `tbl_compras` VALUES (1,'2023-10-26','2023-10-27','Contabilidad','Carol Cecilia',500.2,15.2,515.2,'Mi primera compra yeiiii',1,1,'2024-05-12',1);
/*!40000 ALTER TABLE `tbl_compras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_conceptomovimientodebancos`
--

DROP TABLE IF EXISTS `tbl_conceptomovimientodebancos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_conceptomovimientodebancos` (
  `id_conceptoMovimiento` int NOT NULL AUTO_INCREMENT,
  `concepto_movimientoBanco` varchar(30) NOT NULL,
  `efecto_movimientoBanco` varchar(2) NOT NULL,
  `estado_movimientoBanco` varchar(30) NOT NULL,
  PRIMARY KEY (`id_conceptoMovimiento`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_conceptomovimientodebancos`
--

LOCK TABLES `tbl_conceptomovimientodebancos` WRITE;
/*!40000 ALTER TABLE `tbl_conceptomovimientodebancos` DISABLE KEYS */;
INSERT INTO `tbl_conceptomovimientodebancos` VALUES (1,'Deposito','+','Activo'),(2,'Retiro','-','Activo');
/*!40000 ALTER TABLE `tbl_conceptomovimientodebancos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_conciliacion_bancaria`
--

DROP TABLE IF EXISTS `tbl_conciliacion_bancaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_conciliacion_bancaria` (
  `pk_conb_id_conciliacion` int NOT NULL AUTO_INCREMENT,
  `conb_anio_conciliacion` varchar(100) DEFAULT NULL,
  `conb_mes_conciliacion` varchar(100) DEFAULT NULL,
  `fk_conb_mov_libro` float NOT NULL,
  `fk_conb_estatusConc` int NOT NULL,
  `conb_mov_conciliacion` float DEFAULT NULL,
  `conb_saldo_final` float DEFAULT NULL,
  `conb_status` int DEFAULT NULL,
  PRIMARY KEY (`pk_conb_id_conciliacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `No_Cotizacion` int NOT NULL,
  `fecha_coti` date NOT NULL,
  `fechaFinal_coti` date NOT NULL,
  PRIMARY KEY (`No_Cotizacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cotizaciones`
--

LOCK TABLES `tbl_cotizaciones` WRITE;
/*!40000 ALTER TABLE `tbl_cotizaciones` DISABLE KEYS */;
INSERT INTO `tbl_cotizaciones` VALUES (0,'2024-04-12','2024-04-27'),(1,'2024-04-12','2024-04-27'),(2,'2024-04-12','2024-04-27'),(3,'2024-04-12','2024-04-27'),(4,'2024-04-12','2024-04-27'),(5,'2024-04-26','2024-05-11'),(6,'2024-04-26','2024-05-11'),(7,'2024-04-26','2024-05-11'),(8,'2024-04-26','2024-05-11'),(9,'2024-04-26','2024-05-11'),(10,'2024-04-26','2024-05-11'),(11,'2024-04-26','2024-05-11'),(12,'2024-04-26','2024-05-11');
/*!40000 ALTER TABLE `tbl_cotizaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuentabancaria`
--

DROP TABLE IF EXISTS `tbl_cuentabancaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentabancaria` (
  `id_cuentaBancaria` int NOT NULL AUTO_INCREMENT,
  `nombre_empresa` varchar(30) NOT NULL,
  `id_bancoAsociado` int NOT NULL,
  `tipo_cuenta` varchar(30) NOT NULL,
  `numero_cuenta` varchar(30) NOT NULL,
  `saldoDisponible` double NOT NULL,
  `fecha_apertura` date NOT NULL,
  `estado_cuenta` varchar(20) NOT NULL,
  `tipo_moneda` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_cuentaBancaria`),
  KEY `id_bancoAsociado` (`id_bancoAsociado`),
  CONSTRAINT `tbl_cuentabancaria_ibfk_1` FOREIGN KEY (`id_bancoAsociado`) REFERENCES `tbl_banco` (`id_banco`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuentabancaria`
--

LOCK TABLES `tbl_cuentabancaria` WRITE;
/*!40000 ALTER TABLE `tbl_cuentabancaria` DISABLE KEYS */;
INSERT INTO `tbl_cuentabancaria` VALUES (1,'Carrillo FC',3,'Monetaria','3201',100444,'2024-04-12','Activo','Dollar'),(2,'Bytech SA',4,'Monetaria','8765',4500,'2024-04-12','Activo','Euro');
/*!40000 ALTER TABLE `tbl_cuentabancaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalle_cotizacion`
--

DROP TABLE IF EXISTS `tbl_detalle_cotizacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalle_cotizacion` (
  `id_detalle_cotizacion` int NOT NULL AUTO_INCREMENT,
  `tbl_clientes_id_cliente` int NOT NULL,
  `cantidad_coti` int NOT NULL,
  `tbl_cotizaciones_No_Cotizacion` int NOT NULL,
  `tbl_producto_cod_producto` int NOT NULL,
  `total_detCoti` double NOT NULL,
  PRIMARY KEY (`id_detalle_cotizacion`),
  KEY `fk_tbl_detalle_cotizacion_tbl_clientes1_idx` (`tbl_clientes_id_cliente`),
  KEY `fk_tbl_detalle_cotizacion_tbl_cotizaciones1_idx` (`tbl_cotizaciones_No_Cotizacion`),
  KEY `fk_tbl_detalle_cotizacion_tbl_producto1_idx` (`tbl_producto_cod_producto`),
  CONSTRAINT `fk_tbl_detalle_cotizacion_tbl_clientes1` FOREIGN KEY (`tbl_clientes_id_cliente`) REFERENCES `tbl_clientes` (`id_cliente`),
  CONSTRAINT `fk_tbl_detalle_cotizacion_tbl_cotizaciones1` FOREIGN KEY (`tbl_cotizaciones_No_Cotizacion`) REFERENCES `tbl_cotizaciones` (`No_Cotizacion`),
  CONSTRAINT `fk_tbl_detalle_cotizacion_tbl_producto1` FOREIGN KEY (`tbl_producto_cod_producto`) REFERENCES `tbl_producto` (`cod_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalle_cotizacion`
--

LOCK TABLES `tbl_detalle_cotizacion` WRITE;
/*!40000 ALTER TABLE `tbl_detalle_cotizacion` DISABLE KEYS */;
INSERT INTO `tbl_detalle_cotizacion` VALUES (25,16,1,0,1,9850),(26,16,1,0,2,9850),(27,39,1,1,1,27500),(28,39,10,1,1,27500),(29,3,1,2,1,2500),(30,3,1,2,1,5000),(31,3,1,2,1,5000),(32,101,1,3,1,61300),(33,101,4,3,2,61300),(34,13,12,4,1,44700),(35,13,1,4,2,44700),(36,13,1,4,2,44700),(37,37,1,5,1,5000),(38,37,1,5,1,5000),(39,324,1,5,1,5000),(40,25,1,6,1,9850),(41,25,1,6,2,9850),(42,326,1,7,2,7350),(43,327,1,8,1,2500),(44,326,1,9,1,2500),(45,329,1,10,1,19700),(46,329,1,10,2,19700),(47,329,1,10,2,19700),(48,329,1,10,1,19700),(49,330,1,11,12,17323),(50,330,1,11,1,17323),(51,330,1,11,2,17323),(52,330,1,11,2,17323),(53,331,1,12,2,19700),(54,331,1,12,1,19700),(55,331,1,12,1,19700),(56,331,1,12,2,19700);
/*!40000 ALTER TABLE `tbl_detalle_cotizacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detallecompras`
--

DROP TABLE IF EXISTS `tbl_detallecompras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detallecompras` (
  `id_detalleCompra` int NOT NULL,
  `cantidad_compra_det` int NOT NULL,
  `totalPorProducto_det` double NOT NULL,
  `tbl_Producto_cod_producto` int NOT NULL,
  `tbl_Encabezado_Compras_id_EncComp` int NOT NULL,
  PRIMARY KEY (`id_detalleCompra`),
  KEY `fk_tbl_detalleCompras_tbl_Producto1_idx` (`tbl_Producto_cod_producto`),
  KEY `fk_tbl_detalleCompras_tbl_Encabezado_Compras1_idx` (`tbl_Encabezado_Compras_id_EncComp`),
  CONSTRAINT `fk_tbl_detalleCompras_tbl_Encabezado_Compras1` FOREIGN KEY (`tbl_Encabezado_Compras_id_EncComp`) REFERENCES `tbl_compras` (`id_EncComp`),
  CONSTRAINT `fk_tbl_detalleCompras_tbl_Producto1` FOREIGN KEY (`tbl_Producto_cod_producto`) REFERENCES `tbl_producto` (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detallecompras`
--

LOCK TABLES `tbl_detallecompras` WRITE;
/*!40000 ALTER TABLE `tbl_detallecompras` DISABLE KEYS */;
INSERT INTO `tbl_detallecompras` VALUES (1,2,3,1,1);
/*!40000 ALTER TABLE `tbl_detallecompras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detallefacturaxpagar`
--

DROP TABLE IF EXISTS `tbl_detallefacturaxpagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detallefacturaxpagar` (
  `id_detalleFac` int NOT NULL AUTO_INCREMENT,
  `cantidad_detalleFac` int NOT NULL,
  `totalPorProducto_detalleFac` double NOT NULL,
  `tbl_facturaXPagar_NoFactura` int NOT NULL,
  `tbl_Producto_cod_producto` int NOT NULL,
  PRIMARY KEY (`id_detalleFac`),
  KEY `fk_tbl_detalleFacturaXPagar_tbl_facturaXPagar1_idx` (`tbl_facturaXPagar_NoFactura`),
  KEY `fk_tbl_detalleFacturaXPagar_tbl_Producto1_idx` (`tbl_Producto_cod_producto`),
  CONSTRAINT `fk_tbl_detalleFacturaXPagar_tbl_facturaXPagar1` FOREIGN KEY (`tbl_facturaXPagar_NoFactura`) REFERENCES `tbl_facturaxpagar` (`NoFactura`),
  CONSTRAINT `fk_tbl_detalleFacturaXPagar_tbl_Producto1` FOREIGN KEY (`tbl_Producto_cod_producto`) REFERENCES `tbl_producto` (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detallefacturaxpagar`
--

LOCK TABLES `tbl_detallefacturaxpagar` WRITE;
/*!40000 ALTER TABLE `tbl_detallefacturaxpagar` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detallefacturaxpagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalleordenescompra`
--

DROP TABLE IF EXISTS `tbl_detalleordenescompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalleordenescompra` (
  `id_detalle` int NOT NULL AUTO_INCREMENT,
  `OrdenesCompra_id_OrdComp` int NOT NULL,
  `cantidad_det` int NOT NULL,
  `totalProducto_det` double NOT NULL,
  `tbl_Producto_cod_producto` int NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `fk_DetalleOrdenesCompra_OrdenesCompra_idx` (`OrdenesCompra_id_OrdComp`),
  KEY `fk_tbl_DetalleOrdenesCompra_tbl_Producto1_idx` (`tbl_Producto_cod_producto`),
  CONSTRAINT `fk_DetalleOrdenesCompra_OrdenesCompra` FOREIGN KEY (`OrdenesCompra_id_OrdComp`) REFERENCES `tbl_ordenescompra` (`id_OrdComp`),
  CONSTRAINT `fk_tbl_DetalleOrdenesCompra_tbl_Producto1` FOREIGN KEY (`tbl_Producto_cod_producto`) REFERENCES `tbl_producto` (`cod_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalleordenescompra`
--

LOCK TABLES `tbl_detalleordenescompra` WRITE;
/*!40000 ALTER TABLE `tbl_detalleordenescompra` DISABLE KEYS */;
INSERT INTO `tbl_detalleordenescompra` VALUES (1,2,1,123,12),(2,2,2,5000,1),(3,3,12,88200,2),(4,3,1,2500,1);
/*!40000 ALTER TABLE `tbl_detalleordenescompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalleventas`
--

DROP TABLE IF EXISTS `tbl_detalleventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalleventas` (
  `id_ventas_det` int NOT NULL,
  `fecha_venta_det` date NOT NULL,
  `tbl_Ventas_pedido_id_ventas_ped` int NOT NULL,
  PRIMARY KEY (`id_ventas_det`),
  KEY `fk_tbl_Ventas_detalle_tbl_Ventas_pedido1_idx` (`tbl_Ventas_pedido_id_ventas_ped`),
  CONSTRAINT `fk_tbl_Ventas_detalle_tbl_Ventas_pedido1` FOREIGN KEY (`tbl_Ventas_pedido_id_ventas_ped`) REFERENCES `tbl_ventaspedido` (`id_ventas_ped`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `id_disponibilidad` int NOT NULL AUTO_INCREMENT,
  `id_cuentaDisponibilidad` int NOT NULL,
  `id_bancoActual` int NOT NULL,
  `saldo_disponible` double NOT NULL,
  `saldo_consumido` double NOT NULL,
  `saldo_actual` double NOT NULL,
  `fecha_DisponibilidadDiaria` date NOT NULL,
  PRIMARY KEY (`id_disponibilidad`),
  KEY `id_cuentaDisponibilidad` (`id_cuentaDisponibilidad`),
  KEY `id_bancoActual` (`id_bancoActual`),
  CONSTRAINT `tbl_disponibilidaddiaria_ibfk_1` FOREIGN KEY (`id_cuentaDisponibilidad`) REFERENCES `tbl_cuentabancaria` (`id_cuentaBancaria`),
  CONSTRAINT `tbl_disponibilidaddiaria_ibfk_2` FOREIGN KEY (`id_bancoActual`) REFERENCES `tbl_banco` (`id_banco`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_disponibilidaddiaria`
--

LOCK TABLES `tbl_disponibilidaddiaria` WRITE;
/*!40000 ALTER TABLE `tbl_disponibilidaddiaria` DISABLE KEYS */;
INSERT INTO `tbl_disponibilidaddiaria` VALUES (1,1,3,99999,500,100499,'2024-04-26'),(2,1,3,99389,1055,100444,'2024-04-26');
/*!40000 ALTER TABLE `tbl_disponibilidaddiaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_existencias`
--

DROP TABLE IF EXISTS `tbl_existencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_existencias` (
  `id_existencias` int NOT NULL AUTO_INCREMENT,
  `tbl_sucursales_id_sucursal` int NOT NULL,
  `tbl_producto_id_producto` int NOT NULL,
  `cantidad` int NOT NULL,
  PRIMARY KEY (`id_existencias`),
  KEY `fk_tbl_existencias_tbl_sucursal1_idx` (`tbl_sucursales_id_sucursal`),
  KEY `fk_tbl_producto_idx` (`tbl_producto_id_producto`),
  CONSTRAINT `fk_tbl_existencias_tbl_sucursal` FOREIGN KEY (`tbl_sucursales_id_sucursal`) REFERENCES `tbl_sucursales` (`id_sucursal`),
  CONSTRAINT `fk_tbl_producto` FOREIGN KEY (`tbl_producto_id_producto`) REFERENCES `tbl_producto` (`cod_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_existencias`
--

LOCK TABLES `tbl_existencias` WRITE;
/*!40000 ALTER TABLE `tbl_existencias` DISABLE KEYS */;
INSERT INTO `tbl_existencias` VALUES (1,1,1,10);
/*!40000 ALTER TABLE `tbl_existencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_facturaxcobrar`
--

DROP TABLE IF EXISTS `tbl_facturaxcobrar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_facturaxcobrar` (
  `NoFactura` int NOT NULL,
  `total_facxcob` double NOT NULL,
  `tiempoPago_facxcob` varchar(45) NOT NULL,
  `estado_facxcob` varchar(45) NOT NULL,
  `tbl_Ventas_detalle_id_ventas_det` int NOT NULL,
  `tbl_Clientes_id_cliente` int NOT NULL,
  PRIMARY KEY (`NoFactura`),
  KEY `fk_tbl_facturaXcobrar_tbl_Ventas_detalle1_idx` (`tbl_Ventas_detalle_id_ventas_det`),
  KEY `fk_tbl_FacturaXcobrar_tbl_Clientes1_idx` (`tbl_Clientes_id_cliente`),
  CONSTRAINT `fk_tbl_FacturaXcobrar_tbl_Clientes1` FOREIGN KEY (`tbl_Clientes_id_cliente`) REFERENCES `tbl_clientes` (`id_cliente`),
  CONSTRAINT `fk_tbl_facturaXcobrar_tbl_Ventas_detalle1` FOREIGN KEY (`tbl_Ventas_detalle_id_ventas_det`) REFERENCES `tbl_detalleventas` (`id_ventas_det`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `NoFactura` int NOT NULL,
  `nombreprov_facxpag` varchar(45) NOT NULL,
  `nitprov_facxpag` varchar(20) NOT NULL,
  `fechavenc_facxpag` date NOT NULL,
  `fecha_abono` date NOT NULL,
  `subtotal_facxpag` double NOT NULL,
  `iva_facxpag` double NOT NULL,
  `totalfac_facxpag` double NOT NULL,
  `estado_facxpag` int NOT NULL,
  `tbl_Encabezado_Compras_id_EncComp` int NOT NULL,
  PRIMARY KEY (`NoFactura`),
  KEY `fk_tbl_facturaXPagar_tbl_Encabezado_Compras1_idx` (`tbl_Encabezado_Compras_id_EncComp`),
  CONSTRAINT `fk_tbl_facturaXPagar_tbl_Encabezado_Compras1` FOREIGN KEY (`tbl_Encabezado_Compras_id_EncComp`) REFERENCES `tbl_compras` (`id_EncComp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_facturaxpagar`
--

LOCK TABLES `tbl_facturaxpagar` WRITE;
/*!40000 ALTER TABLE `tbl_facturaxpagar` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_facturaxpagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_lineas`
--

DROP TABLE IF EXISTS `tbl_lineas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_lineas` (
  `id_linea` int NOT NULL AUTO_INCREMENT,
  `nombre_linea` varchar(45) NOT NULL,
  PRIMARY KEY (`id_linea`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_lineas`
--

LOCK TABLES `tbl_lineas` WRITE;
/*!40000 ALTER TABLE `tbl_lineas` DISABLE KEYS */;
INSERT INTO `tbl_lineas` VALUES (1,'Tecnología');
/*!40000 ALTER TABLE `tbl_lineas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_mantenimientos_agregar_bancos`
--

DROP TABLE IF EXISTS `tbl_mantenimientos_agregar_bancos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_mantenimientos_agregar_bancos` (
  `pk_manag_id_ban` int NOT NULL AUTO_INCREMENT,
  `manag_id_bancoag` int DEFAULT NULL,
  `manag_nombre_banco` varchar(100) DEFAULT NULL,
  `manag_status` int DEFAULT NULL,
  PRIMARY KEY (`pk_manag_id_ban`),
  UNIQUE KEY `manag_nombre_banco` (`manag_nombre_banco`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `pk_manac_id_cuenta` int NOT NULL AUTO_INCREMENT,
  `manac_numero_de_cuenta` int DEFAULT NULL,
  `fk_manac_tipo_de_moneda` varchar(100) DEFAULT NULL,
  `manac_tipo_de_cuenta` varchar(100) DEFAULT NULL,
  `fk_manac_selec_banco` varchar(50) DEFAULT NULL,
  `manac_alias` varchar(100) DEFAULT NULL,
  `manac_status` int DEFAULT NULL,
  PRIMARY KEY (`pk_manac_id_cuenta`),
  UNIQUE KEY `manac_numero_de_cuenta` (`manac_numero_de_cuenta`),
  KEY `fk_manac_selec_banco` (`fk_manac_selec_banco`),
  KEY `fk_manac_tipo_de_moneda` (`fk_manac_tipo_de_moneda`),
  CONSTRAINT `tbl_mantenimientos_agregar_cuenta_ibfk_1` FOREIGN KEY (`fk_manac_selec_banco`) REFERENCES `tbl_mantenimientos_agregar_bancos` (`manag_nombre_banco`),
  CONSTRAINT `tbl_mantenimientos_agregar_cuenta_ibfk_2` FOREIGN KEY (`fk_manac_tipo_de_moneda`) REFERENCES `tbl_monedabanco` (`mon_nomMoneda`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_mantenimientos_agregar_cuenta`
--

LOCK TABLES `tbl_mantenimientos_agregar_cuenta` WRITE;
/*!40000 ALTER TABLE `tbl_mantenimientos_agregar_cuenta` DISABLE KEYS */;
INSERT INTO `tbl_mantenimientos_agregar_cuenta` VALUES (1,12312321,NULL,'Debito','Banco industrial','Extra',NULL);
/*!40000 ALTER TABLE `tbl_mantenimientos_agregar_cuenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_mantenimientos_tipo_movimiento`
--

DROP TABLE IF EXISTS `tbl_mantenimientos_tipo_movimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_mantenimientos_tipo_movimiento` (
  `pk_movtm_id_transaccion` int NOT NULL AUTO_INCREMENT,
  `movtm_transacciones_existentes` varchar(100) DEFAULT NULL,
  `movtm_status` int DEFAULT NULL,
  `movtm_valor_transaccion` int NOT NULL,
  PRIMARY KEY (`pk_movtm_id_transaccion`),
  UNIQUE KEY `movtm_transacciones_existentes` (`movtm_transacciones_existentes`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `id_marca` int NOT NULL AUTO_INCREMENT,
  `nombre_marca` varchar(45) NOT NULL,
  PRIMARY KEY (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_marcas`
--

LOCK TABLES `tbl_marcas` WRITE;
/*!40000 ALTER TABLE `tbl_marcas` DISABLE KEYS */;
INSERT INTO `tbl_marcas` VALUES (1,'DELL'),(2,'HP'),(3,'Lenovo'),(4,'DELL'),(5,'Microsoft');
/*!40000 ALTER TABLE `tbl_marcas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_modulos`
--

DROP TABLE IF EXISTS `tbl_modulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_modulos` (
  `pk_id_modulos` int NOT NULL,
  `nombre_modulo` varchar(50) NOT NULL,
  `descripcion_modulo` varchar(150) NOT NULL,
  `estado_modulo` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_modulos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `mon_id_moneda` int NOT NULL AUTO_INCREMENT,
  `fk_mon_nombre_moneda` varchar(50) DEFAULT NULL,
  `mon_Cant_moneda` float DEFAULT NULL,
  `mon_status` int DEFAULT NULL,
  PRIMARY KEY (`mon_id_moneda`),
  KEY `fk_mon_nombre_moneda` (`fk_mon_nombre_moneda`),
  CONSTRAINT `tbl_moneda_ibfk_1` FOREIGN KEY (`fk_mon_nombre_moneda`) REFERENCES `tbl_registro_moneda` (`regmon_Tipo_moneda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `pk_mon_id_moneda` int NOT NULL AUTO_INCREMENT,
  `mon_nomMoneda` varchar(100) DEFAULT NULL,
  `mon_status` int DEFAULT NULL,
  PRIMARY KEY (`pk_mon_id_moneda`),
  UNIQUE KEY `mon_nomMoneda` (`mon_nomMoneda`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `id_movimiento_inv` int NOT NULL AUTO_INCREMENT,
  `fecha_movimiento` date NOT NULL,
  `cantidad_movimiento` int NOT NULL,
  `descripcion_movimiento` varchar(45) NOT NULL,
  `tbl_movimientos_id_movimiento` int NOT NULL,
  `tbl_sucursales_id_sucursal` int NOT NULL,
  `tbl_Producto_cod_producto` int NOT NULL,
  PRIMARY KEY (`id_movimiento_inv`),
  KEY `fk_tbl_movimiento_inv_tbl_movimiento1_idx` (`tbl_movimientos_id_movimiento`),
  KEY `fk_tbl_movimiento_inv_tbl_sucursales1_idx` (`tbl_sucursales_id_sucursal`),
  KEY `fk_tbl_movimiento_inv_tbl_Producto1_idx` (`tbl_Producto_cod_producto`),
  CONSTRAINT `fk_tbl_movimiento_inv_tbl_movimiento1` FOREIGN KEY (`tbl_movimientos_id_movimiento`) REFERENCES `tbl_movimientos` (`id_movimiento`),
  CONSTRAINT `fk_tbl_movimiento_inv_tbl_Producto1` FOREIGN KEY (`tbl_Producto_cod_producto`) REFERENCES `tbl_producto` (`cod_producto`),
  CONSTRAINT `fk_tbl_movimiento_inv_tbl_sucursales1` FOREIGN KEY (`tbl_sucursales_id_sucursal`) REFERENCES `tbl_sucursales` (`id_sucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `id_movimientoBanco` int NOT NULL AUTO_INCREMENT,
  `tipo_movimientoBanco` int NOT NULL,
  `fecha_movimientoBanco` date NOT NULL,
  `monto_movimientoBanco` double NOT NULL,
  `cuenta_movimientoBanco` int NOT NULL,
  PRIMARY KEY (`id_movimientoBanco`),
  KEY `tipo_movimientoBanco` (`tipo_movimientoBanco`),
  KEY `cuenta_movimientoBanco` (`cuenta_movimientoBanco`),
  CONSTRAINT `tbl_movimientodebancos_ibfk_1` FOREIGN KEY (`tipo_movimientoBanco`) REFERENCES `tbl_conceptomovimientodebancos` (`id_conceptoMovimiento`),
  CONSTRAINT `tbl_movimientodebancos_ibfk_2` FOREIGN KEY (`cuenta_movimientoBanco`) REFERENCES `tbl_cuentabancaria` (`id_cuentaBancaria`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_movimientodebancos`
--

LOCK TABLES `tbl_movimientodebancos` WRITE;
/*!40000 ALTER TABLE `tbl_movimientodebancos` DISABLE KEYS */;
INSERT INTO `tbl_movimientodebancos` VALUES (1,1,'2024-04-11',500,1),(2,2,'2024-04-11',500,2),(3,1,'2024-04-26',500,1),(4,2,'2024-04-26',555,1);
/*!40000 ALTER TABLE `tbl_movimientodebancos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_movimientos`
--

DROP TABLE IF EXISTS `tbl_movimientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimientos` (
  `id_movimiento` int NOT NULL AUTO_INCREMENT,
  `nombre_movimiento` varchar(45) NOT NULL,
  `descripcion_movimiento` varchar(45) NOT NULL,
  PRIMARY KEY (`id_movimiento`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_movimientos`
--

LOCK TABLES `tbl_movimientos` WRITE;
/*!40000 ALTER TABLE `tbl_movimientos` DISABLE KEYS */;
INSERT INTO `tbl_movimientos` VALUES (1,'Entrada','Entrada de producto'),(2,'Salida','Salida de producto'),(3,'Traslado','Traslado de producto entre sucursales');
/*!40000 ALTER TABLE `tbl_movimientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_movimientosbancarios`
--

DROP TABLE IF EXISTS `tbl_movimientosbancarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimientosbancarios` (
  `pk_movban_id_transaccion` int NOT NULL AUTO_INCREMENT,
  `movban_valor_transaccion` float NOT NULL,
  `movban_descripcion_transaccion` varchar(100) DEFAULT NULL,
  `fk_movban_num_cuenta` int DEFAULT NULL,
  `fk_movban_tipo_transaccion` varchar(50) DEFAULT NULL,
  `fk_movban_valorTrans` int NOT NULL,
  `movban_status` int DEFAULT NULL,
  `movban_fecha_de_ingreso` datetime DEFAULT NULL,
  `manag_status_conciliacion` int NOT NULL,
  PRIMARY KEY (`pk_movban_id_transaccion`),
  KEY `fk_movban_num_cuenta` (`fk_movban_num_cuenta`),
  KEY `fk_movban_tipo_transaccion` (`fk_movban_tipo_transaccion`),
  CONSTRAINT `tbl_movimientosbancarios_ibfk_1` FOREIGN KEY (`fk_movban_num_cuenta`) REFERENCES `tbl_mantenimientos_agregar_cuenta` (`manac_numero_de_cuenta`),
  CONSTRAINT `tbl_movimientosbancarios_ibfk_2` FOREIGN KEY (`fk_movban_tipo_transaccion`) REFERENCES `tbl_mantenimientos_tipo_movimiento` (`movtm_transacciones_existentes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `id_OrdComp` int NOT NULL AUTO_INCREMENT,
  `fechaSolicitid_OrdComp` date NOT NULL,
  `fechaEntrega_OrdComp` date NOT NULL,
  `deptoSolicitante_OrdComp` varchar(45) NOT NULL,
  `entregar_a_OrdComp` varchar(45) NOT NULL,
  `subTotal_OrdComp` double NOT NULL,
  `iva_OrdComp` double NOT NULL,
  `totalOrden_OrdComp` double NOT NULL,
  `notas_OrdComp` varchar(45) NOT NULL,
  `tbl_proveedor_id_prov` int NOT NULL,
  PRIMARY KEY (`id_OrdComp`),
  KEY `fk_tbl_OrdenesCompra_tbl_proveedor1_idx` (`tbl_proveedor_id_prov`),
  CONSTRAINT `fk_tbl_OrdenesCompra_tbl_proveedor1` FOREIGN KEY (`tbl_proveedor_id_prov`) REFERENCES `tbl_proveedor` (`id_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ordenescompra`
--

LOCK TABLES `tbl_ordenescompra` WRITE;
/*!40000 ALTER TABLE `tbl_ordenescompra` DISABLE KEYS */;
INSERT INTO `tbl_ordenescompra` VALUES (1,'2023-10-26','2023-10-27','Contabilidad','Carol Cecilia',500.2,15.2,515.2,'Esta es la primer orden',1),(2,'2024-04-26','2024-04-28','Ventas','mi',5123,614.76,5737.76,'Orden1',9),(3,'2024-04-26','2024-05-22','Compras','David Carrillo',90700,10884,101584,'Muy caro',9);
/*!40000 ALTER TABLE `tbl_ordenescompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_perfiles`
--

DROP TABLE IF EXISTS `tbl_perfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_perfiles` (
  `pk_id_perfil` int NOT NULL AUTO_INCREMENT,
  `nombre_perfil` varchar(50) NOT NULL,
  `descripcion_perfil` varchar(150) NOT NULL,
  `estado_perfil` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `fk_id_aplicacion` int NOT NULL,
  `fk_id_usuario` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`fk_id_aplicacion`,`fk_id_usuario`),
  KEY `fk_id_usuario` (`fk_id_usuario`),
  CONSTRAINT `tbl_permisosaplicacionesusuario_ibfk_1` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  CONSTRAINT `tbl_permisosaplicacionesusuario_ibfk_2` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
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
  `fk_id_perfil` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`fk_id_perfil`,`fk_id_aplicacion`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`),
  CONSTRAINT `tbl_permisosaplicacionperfil_ibfk_1` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  CONSTRAINT `tbl_permisosaplicacionperfil_ibfk_2` FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_permisosaplicacionperfil`
--

LOCK TABLES `tbl_permisosaplicacionperfil` WRITE;
/*!40000 ALTER TABLE `tbl_permisosaplicacionperfil` DISABLE KEYS */;
INSERT INTO `tbl_permisosaplicacionperfil` VALUES (1,1000,1,1,1,1,1),(1,1001,1,1,1,1,1),(1,1002,1,1,1,1,1),(1,1003,1,1,1,1,1),(1,1004,1,1,1,1,1),(1,1101,1,1,1,1,1),(1,1102,1,1,1,1,1),(1,1103,1,1,1,1,1),(1,1201,1,1,1,1,1),(1,1301,1,1,1,1,1),(1,8000,1,1,1,1,1),(1,8001,1,1,1,1,1),(1,8002,1,1,1,1,1),(1,8003,1,1,1,1,1),(1,8004,1,1,1,1,1),(1,8005,1,1,1,1,1),(1,8006,1,1,1,1,1),(1,8007,1,1,1,1,1),(1,8008,1,1,1,1,1),(1,8009,1,1,1,1,1),(1,8010,1,1,1,1,1),(1,8011,1,1,1,1,1),(1,8012,1,1,1,1,1),(1,8013,1,1,1,1,1),(1,8014,1,1,1,1,1),(1,8015,1,1,1,1,1),(1,8016,1,1,1,1,1),(1,8017,1,1,1,1,1),(1,8018,1,1,1,1,1),(1,8019,1,1,1,1,1),(1,8020,1,1,1,1,1),(1,8021,1,1,1,1,1),(1,8030,1,1,1,1,1),(1,8031,1,1,1,1,1);
/*!40000 ALTER TABLE `tbl_permisosaplicacionperfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_producto`
--

DROP TABLE IF EXISTS `tbl_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_producto` (
  `cod_producto` int NOT NULL,
  `fecha_registro` date DEFAULT NULL,
  `nombre_prod` varchar(45) NOT NULL,
  `descripcion_prod` varchar(45) NOT NULL,
  `precioUnitario_prod` double NOT NULL,
  `tbl_marca_id_marca` int NOT NULL,
  `tbl_linea_id_linea` int NOT NULL,
  PRIMARY KEY (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_producto`
--

LOCK TABLES `tbl_producto` WRITE;
/*!40000 ALTER TABLE `tbl_producto` DISABLE KEYS */;
INSERT INTO `tbl_producto` VALUES (1,'2024-02-12','PC','tecnologia',2500,1,1),(2,'2024-02-12','RTX3090','Tarjeta Grafica',7350,3,1),(12,'2024-04-26','asda','adas',123,3,1);
/*!40000 ALTER TABLE `tbl_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_proveedor`
--

DROP TABLE IF EXISTS `tbl_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_proveedor` (
  `id_prov` int NOT NULL AUTO_INCREMENT,
  `nombre_prov` varchar(45) NOT NULL,
  `domicilio_prov` varchar(45) NOT NULL,
  `telefono_prov` varchar(45) NOT NULL,
  `nit_prov` varchar(20) NOT NULL,
  `estado_prov` varchar(45) NOT NULL,
  PRIMARY KEY (`id_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_proveedor`
--

LOCK TABLES `tbl_proveedor` WRITE;
/*!40000 ALTER TABLE `tbl_proveedor` DISABLE KEYS */;
INSERT INTO `tbl_proveedor` VALUES (1,'2otto','zona2','14124','12412','activo'),(2,'a','a','a','12','Inactivo'),(3,'1','1','1','1','Inactivo'),(6,'1a','as','s','12','Inactivo'),(7,'adsa','adasd','12312','123123','Inactivo'),(8,'asdas','ada','adsa','31231','Activo'),(9,'Jose','zona2','1241421','12412','Inactivo');
/*!40000 ALTER TABLE `tbl_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_registro_moneda`
--

DROP TABLE IF EXISTS `tbl_registro_moneda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_registro_moneda` (
  `regmon_id_Moneda` int NOT NULL AUTO_INCREMENT,
  `regmon_Tipo_moneda` varchar(100) DEFAULT NULL,
  `regmon_Valor_moneda` float DEFAULT NULL,
  `regmon_fecha_de_registro` datetime DEFAULT NULL,
  `regmon_status` int DEFAULT NULL,
  PRIMARY KEY (`regmon_id_Moneda`),
  UNIQUE KEY `regmon_Tipo_moneda` (`regmon_Tipo_moneda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `id_sucursal` int NOT NULL AUTO_INCREMENT,
  `nombre_sucursal` varchar(45) NOT NULL,
  `direccion_sucursal` varchar(45) NOT NULL,
  `telefono_sucursal` int NOT NULL,
  `correo_sucursal` varchar(45) NOT NULL,
  PRIMARY KEY (`id_sucursal`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_sucursales`
--

LOCK TABLES `tbl_sucursales` WRITE;
/*!40000 ALTER TABLE `tbl_sucursales` DISABLE KEYS */;
INSERT INTO `tbl_sucursales` VALUES (1,'sucursalSur','Monterico',12349829,'MSur@mail.com'),(2,'Sucursal Norte','Petén',98765432,'petensucu@gmail.com');
/*!40000 ALTER TABLE `tbl_sucursales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipocambio`
--

DROP TABLE IF EXISTS `tbl_tipocambio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipocambio` (
  `id_tipo_cambio` int NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `moneda_origen` varchar(10) NOT NULL,
  `moneda_destino` varchar(10) NOT NULL,
  `tipo_cambio` double NOT NULL,
  PRIMARY KEY (`id_tipo_cambio`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
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
  `id_transaccion` int NOT NULL AUTO_INCREMENT,
  `tipo_transaccion` varchar(50) DEFAULT NULL,
  `numero_transaccion` varchar(50) DEFAULT NULL,
  `fecha_transaccion` date DEFAULT NULL,
  `beneficiario_transaccion` varchar(100) DEFAULT NULL,
  `concepto_transaccion` varchar(255) DEFAULT NULL,
  `numero_factura` int DEFAULT NULL,
  PRIMARY KEY (`id_transaccion`),
  KEY `numero_factura` (`numero_factura`),
  CONSTRAINT `tbl_transacciones_ibfk_1` FOREIGN KEY (`numero_factura`) REFERENCES `tbl_facturaxpagar` (`NoFactura`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
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
  `id_transprov` int NOT NULL AUTO_INCREMENT,
  `nombre_transprov` varchar(45) NOT NULL,
  `estado_transprov` varchar(45) NOT NULL,
  `tipo_transprov` varchar(20) NOT NULL,
  `tbl_proveedor_id_prov` int NOT NULL,
  PRIMARY KEY (`id_transprov`),
  KEY `fk_tbl_transprov_tbl_proveedor1_idx` (`tbl_proveedor_id_prov`),
  CONSTRAINT `fk_tbl_transprov_tbl_proveedor1` FOREIGN KEY (`tbl_proveedor_id_prov`) REFERENCES `tbl_proveedor` (`id_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transprov`
--

LOCK TABLES `tbl_transprov` WRITE;
/*!40000 ALTER TABLE `tbl_transprov` DISABLE KEYS */;
INSERT INTO `tbl_transprov` VALUES (2,'sd','Inactivo','Abono',2),(3,'Lucas','Activo','Cargo',3),(4,'Pago a Proveedores','Inactivo','Abono',2);
/*!40000 ALTER TABLE `tbl_transprov` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usuarios`
--

DROP TABLE IF EXISTS `tbl_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_usuarios` (
  `pk_id_usuario` int NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(50) NOT NULL,
  `apellido_usuario` varchar(50) NOT NULL,
  `username_usuario` varchar(20) NOT NULL,
  `password_usuario` varchar(100) NOT NULL,
  `email_usuario` varchar(50) NOT NULL,
  `estado_usuario` tinyint NOT NULL DEFAULT '0',
  `pregunta` varchar(50) NOT NULL,
  `respuesta` varchar(50) NOT NULL,
  PRIMARY KEY (`pk_id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `id_vendedor` int NOT NULL AUTO_INCREMENT,
  `nombre_vend` varchar(45) NOT NULL,
  `apellido_vend` varchar(45) NOT NULL,
  `telefono_vend` varchar(45) NOT NULL,
  `estado_vend` varchar(45) NOT NULL,
  PRIMARY KEY (`id_vendedor`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_vendedor`
--

LOCK TABLES `tbl_vendedor` WRITE;
/*!40000 ALTER TABLE `tbl_vendedor` DISABLE KEYS */;
INSERT INTO `tbl_vendedor` VALUES (5,'Lucas','hernandez','12124','Activo'),(6,'david','carrix','1231','Activo'),(7,'a','a','a','Activo'),(8,'d','d','d','Activo'),(9,'v','v','v','Activo'),(10,'Otto','AventuraLopez','421231','Inactivo');
/*!40000 ALTER TABLE `tbl_vendedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ventaspedido`
--

DROP TABLE IF EXISTS `tbl_ventaspedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_ventaspedido` (
  `id_ventas_ped` int NOT NULL,
  `id_vendedor` int NOT NULL,
  `tbl_detalle_cotizacion_id` int NOT NULL,
  PRIMARY KEY (`id_ventas_ped`),
  KEY `fk_id_vendedor` (`id_vendedor`),
  KEY `tbl_detalle_cotizacion_id_idx` (`tbl_detalle_cotizacion_id`),
  CONSTRAINT `fk_id_vendedor` FOREIGN KEY (`id_vendedor`) REFERENCES `tbl_vendedor` (`id_vendedor`),
  CONSTRAINT `tbl_detalle_cotizacion_id` FOREIGN KEY (`tbl_detalle_cotizacion_id`) REFERENCES `tbl_detalle_cotizacion` (`id_detalle_cotizacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ventaspedido`
--

LOCK TABLES `tbl_ventaspedido` WRITE;
/*!40000 ALTER TABLE `tbl_ventaspedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ventaspedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vista_clientes`
--

DROP TABLE IF EXISTS `vista_clientes`;
/*!50001 DROP VIEW IF EXISTS `vista_clientes`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_clientes` AS SELECT 
 1 AS `ID_Cliente`,
 1 AS `Nombre`,
 1 AS `Apellido`,
 1 AS `Direccion`,
 1 AS `Correo`,
 1 AS `Telefono`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vista_clientes`
--

/*!50001 DROP VIEW IF EXISTS `vista_clientes`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_clientes` AS select `tbl_clientes`.`id_cliente` AS `ID_Cliente`,`tbl_clientes`.`nombre_cl` AS `Nombre`,`tbl_clientes`.`apellido_cl` AS `Apellido`,`tbl_clientes`.`direccion_cl` AS `Direccion`,`tbl_clientes`.`correo_cl` AS `Correo`,`tbl_clientes`.`telefono_cl` AS `Telefono` from `tbl_clientes` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-26 18:37:14

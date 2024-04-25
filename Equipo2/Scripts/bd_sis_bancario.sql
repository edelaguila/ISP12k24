-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_hoteleria_pruebas
-- ------------------------------------------------------
-- Server version	8.0.35

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
INSERT INTO `tbl_aplicaciones` VALUES (1,'Menu','Ingreso Login',1),(999,'Cerrar Sesion','Cerrar Sesion',1),(1000,'MDI SEGURIDAD','PARA SEGURIDAD',1),(1001,'Mant. Usuario','PARA SEGURIDAD',1),(1002,'Mant. Aplicación','PARA SEGURIDAD',1),(1003,'Mant. Modulo','PARA SEGURIDAD',1),(1004,'Mant. Perfil','PARA SEGURIDAD',1),(1101,'Asign. Modulo Aplicacion','PARA SEGURIDAD',1),(1102,'Asign. Aplicacion Perfil','PARA SEGURIDAD',1),(1103,'Asign. Perfil Usuario','PARA SEGURIDAD',1),(1201,'Pcs. Cambio Contraseña','PARA SEGURIDAD',1),(1301,'Pcs. BITACORA','PARA SEGURIDAD',1),(7000,'MDI BANCOS','PARA BANCOS',1),(7001,'Movimientos Bancarios','PARA BANCOS',1),(7002,'Conciliacion Bancaria','PARA BANCOS',1),(7003,'Tipo de cambio','PARA BANCOS',1),(7004,'Disponibilidad diaria','PARA BANCOS',1),(7005,'Autorizacion de ordenes de compras','PARA BANCOS',1),(7006,'Mant. Ag.Bancos','PARA BANCOS',1),(7007,'Mant. Ag.Cuentas','PARA BANCOS',1),(7008,'Mant. Ag.Movimiento','PARA BANCOS',1),(7009,'Mant. Ordenes de compra','PARA BANCOS',1),(8000,'MDI Prototipo','Proto',1),(8001,'Crear Cita','Crear',1),(8002,'Visualizar Cita','Vizualizar',1),(8003,'Reprogramar Cita','Reprogramar',1),(8004,'Cancelar Cita','Cancelar',1),(8005,'Comprobación de Doc','Docs',1);
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
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES (1000,1000),(1000,1001),(1000,1002),(1000,1003),(1000,1004),(1000,1102),(1000,1103),(1000,1201),(1000,1301),(7000,7000),(7000,7001),(7000,7002),(7000,7003),(7000,7004),(7000,7005),(7000,7006),(7000,7007),(7000,7008),(7000,7009),(8000,8000),(8000,8001),(8000,8002),(8000,8003),(8000,8004),(8000,8005);
/*!40000 ALTER TABLE `tbl_asignacionmoduloaplicacion` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=541 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacoradeeventos`
--

LOCK TABLES `tbl_bitacoradeeventos` WRITE;
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` DISABLE KEYS */;
INSERT INTO `tbl_bitacoradeeventos` VALUES (1,1,1,'2023-10-27','14:05:00','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(2,1,999,'2023-10-27','14:05:02','OLSTER','fe80::a328:23e5:7f78:af4f%14','Cerro Sesion'),(3,1,1000,'2023-10-27','14:08:27','OLSTER','fe80::a328:23e5:7f78:af4f%14','Se ha guardado un registro'),(4,1,1,'2023-10-27','15:25:57','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(5,1,999,'2023-10-27','15:25:58','OLSTER','fe80::a328:23e5:7f78:af4f%14','Cerro Sesion'),(6,1,1000,'2023-10-27','15:28:22','OLSTER','192.168.56.1','Se ha guardado un registro'),(7,1,1000,'2023-10-27','15:28:38','OLSTER','192.168.56.1','Se ha modificado un registro'),(8,1,1,'2023-10-30','23:50:17','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(9,1,999,'2023-10-30','23:50:18','OLSTER','fe80::a328:23e5:7f78:af4f%14','Cerro Sesion'),(10,1,1000,'2023-10-30','23:51:18','OLSTER','fe80::a328:23e5:7f78:af4f%14','Se ha guardado un registro'),(11,1,1000,'2023-10-30','23:53:48','OLSTER','fe80::a328:23e5:7f78:af4f%14','Se ha guardado un registro'),(12,1,1,'2023-11-03','12:39:11','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(13,1,999,'2023-11-03','12:39:25','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Cerro Sesion'),(14,1,1,'2023-11-03','12:41:51','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(15,1,1,'2023-11-03','15:13:01','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(16,1,1,'2023-11-03','15:24:41','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(17,1,7000,'2023-11-03','15:24:43','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(18,1,1,'2023-11-03','15:26:56','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(19,1,1,'2023-11-03','15:28:30','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(20,1,7000,'2023-11-03','15:28:31','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(21,1,1,'2023-11-03','22:35:50','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(22,1,7000,'2023-11-03','22:35:54','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(23,1,1,'2023-11-04','20:34:39','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(24,1,7000,'2023-11-04','20:34:41','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(25,1,1,'2023-11-04','20:40:02','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(26,1,7000,'2023-11-04','20:40:04','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(27,1,1,'2023-11-04','20:42:54','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(28,1,7000,'2023-11-04','20:42:56','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(29,1,1,'2023-11-04','20:47:17','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(30,1,7000,'2023-11-04','20:47:19','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(31,1,1,'2023-11-04','20:55:04','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(32,1,7000,'2023-11-04','20:55:05','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(33,1,1,'2023-11-04','21:02:58','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(34,1,7000,'2023-11-04','21:02:59','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(35,1,1,'2023-11-04','21:09:27','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(36,1,999,'2023-11-04','21:09:27','OLSTER','fe80::a328:23e5:7f78:af4f%14','Cerro Sesion'),(37,1,1,'2023-11-04','21:09:37','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(38,1,7000,'2023-11-04','21:09:39','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(39,1,1,'2023-11-04','21:20:36','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(40,1,7000,'2023-11-04','21:20:38','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(41,1,1,'2023-11-04','21:27:42','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(42,1,7000,'2023-11-04','21:27:44','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(43,1,1,'2023-11-04','21:32:11','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(44,1,7000,'2023-11-04','21:32:13','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(45,1,1,'2023-11-04','21:35:25','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(46,1,7000,'2023-11-04','21:35:27','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(47,1,1,'2023-11-04','21:40:05','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(48,1,7000,'2023-11-04','21:40:07','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(49,1,1,'2023-11-04','21:45:12','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(50,1,7000,'2023-11-04','21:45:14','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(51,1,1,'2023-11-04','21:53:17','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(52,1,7000,'2023-11-04','21:53:18','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(53,1,1,'2023-11-04','21:54:32','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(54,1,7000,'2023-11-04','21:54:33','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(55,1,1,'2023-11-04','21:56:58','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(56,1,7000,'2023-11-04','21:57:01','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(57,1,1004,'2023-11-04','21:58:02','OLSTER','fe80::a328:23e5:7f78:af4f%14','Guardar'),(58,1,1004,'2023-11-04','21:58:27','OLSTER','fe80::a328:23e5:7f78:af4f%14','Modificar'),(59,1,999,'2023-11-04','22:02:11','OLSTER','fe80::a328:23e5:7f78:af4f%14','Cerro Sesion'),(60,1,1,'2023-11-05','20:32:24','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(61,1,7000,'2023-11-05','20:32:27','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(62,1,1,'2023-11-05','21:12:57','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(63,1,7000,'2023-11-05','21:12:58','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(64,1,1,'2023-11-05','21:14:00','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(65,1,7000,'2023-11-05','21:14:01','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(66,1,1,'2023-11-05','21:18:38','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(67,1,7000,'2023-11-05','21:18:39','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(68,1,999,'2023-11-05','21:18:52','OLSTER','fe80::a328:23e5:7f78:af4f%14','Cerro Sesion'),(69,1,1,'2023-11-05','21:20:09','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(70,1,7000,'2023-11-05','21:20:10','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(71,1,999,'2023-11-05','21:20:24','OLSTER','fe80::a328:23e5:7f78:af4f%14','Cerro Sesion'),(72,1,1,'2023-11-05','21:21:11','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(73,1,7000,'2023-11-05','21:21:12','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(74,1,1,'2023-11-05','21:22:57','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(75,1,7000,'2023-11-05','21:22:58','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Ventas'),(76,1,1,'2023-11-06','22:51:39','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(77,1,7000,'2023-11-06','22:51:40','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(78,1,1004,'2023-11-06','22:52:15','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Guardar'),(79,1,1,'2023-11-06','23:35:34','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(80,1,7000,'2023-11-06','23:35:35','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(81,1,1,'2023-11-06','23:36:37','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(82,1,7000,'2023-11-06','23:36:38','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(83,1,1,'2023-11-06','23:37:40','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(84,1,7000,'2023-11-06','23:37:42','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(85,1,1,'2023-11-06','23:39:08','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(86,1,7000,'2023-11-06','23:39:11','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(87,1,1,'2023-11-06','23:41:18','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(88,1,7000,'2023-11-06','23:41:19','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(89,1,1,'2023-11-06','23:44:41','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(90,1,7000,'2023-11-06','23:44:42','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(91,1,1,'2023-11-06','23:46:38','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(92,1,7000,'2023-11-06','23:46:39','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(93,1,1,'2023-11-06','23:50:39','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(94,1,7000,'2023-11-06','23:50:40','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(95,1,1,'2023-11-06','23:53:18','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(96,1,7000,'2023-11-06','23:53:19','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(97,1,1003,'2023-11-06','23:53:35','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Guardar'),(98,1,999,'2023-11-06','23:55:40','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Cerro Sesion'),(99,1,1,'2023-11-07','00:43:59','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(100,1,7000,'2023-11-07','00:44:01','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(101,1,1,'2023-11-07','00:45:52','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(102,1,7000,'2023-11-07','00:45:53','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(103,1,1,'2023-11-07','00:47:02','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(104,1,7000,'2023-11-07','00:47:02','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(105,1,1,'2023-11-07','00:48:55','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(106,1,7000,'2023-11-07','00:48:56','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(107,1,1,'2023-11-07','00:49:41','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(108,1,7000,'2023-11-07','00:49:42','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(109,1,1,'2023-11-07','00:50:51','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(110,1,7000,'2023-11-07','00:50:53','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(111,1,1003,'2023-11-07','00:51:08','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Guardar'),(112,1,1004,'2023-11-07','00:51:32','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Guardar'),(113,1,999,'2023-11-07','00:51:53','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Cerro Sesion'),(114,1,1,'2023-11-07','00:58:01','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(115,1,7000,'2023-11-07','00:58:12','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(116,1,1,'2023-11-07','00:58:57','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(117,1,7000,'2023-11-07','00:58:59','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(118,1,1,'2023-11-07','01:11:09','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(119,1,7000,'2023-11-07','01:11:10','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(120,1,1,'2023-11-07','01:12:26','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(121,1,7000,'2023-11-07','01:12:28','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(122,1,1,'2023-11-07','01:15:01','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(123,1,7000,'2023-11-07','01:15:02','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(124,1,1,'2023-11-07','01:17:34','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(125,1,7000,'2023-11-07','01:17:35','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(126,1,1,'2023-11-07','01:20:58','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(127,1,7000,'2023-11-07','01:20:59','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(128,1,1,'2023-11-07','01:24:26','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(129,1,7000,'2023-11-07','01:24:27','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(130,1,1,'2023-11-07','01:26:47','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(131,1,7000,'2023-11-07','01:26:48','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(132,1,1,'2023-11-07','01:28:43','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(133,1,7000,'2023-11-07','01:28:44','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(134,1,1,'2023-11-07','01:31:22','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(135,1,7000,'2023-11-07','01:31:23','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(136,1,1004,'2023-11-07','01:31:53','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Guardar'),(137,1,1,'2023-11-07','07:32:31','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(138,1,7000,'2023-11-07','07:32:33','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(139,1,1,'2023-11-07','07:33:51','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(140,1,7000,'2023-11-07','07:33:52','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(141,1,1,'2023-11-07','07:54:33','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(142,1,7000,'2023-11-07','07:54:43','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(143,1,1,'2023-11-07','08:01:26','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(144,1,7000,'2023-11-07','08:01:27','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(145,1,1003,'2023-11-07','08:03:08','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Guardar'),(146,1,1,'2023-11-07','08:05:31','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Login'),(147,1,7000,'2023-11-07','08:05:32','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Ingreso Ventas'),(148,1,1004,'2023-11-07','08:06:19','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Guardar'),(149,1,1003,'2023-11-07','08:08:28','OLSTER','fe80::8a8a:66cd:92ea:16ea%18','Guardar'),(150,1,1,'2023-11-07','20:59:16','OLSTER','fe80::a328:23e5:7f78:af4f%14','Ingreso Login'),(151,1,1,'2023-11-08','21:25:58','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(152,1,7000,'2023-11-08','21:26:00','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(153,1,1,'2023-11-08','21:42:26','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(154,1,7000,'2023-11-08','21:42:57','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(155,1,999,'2023-11-08','21:54:36','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(156,1,1,'2023-11-08','22:03:12','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(157,1,7000,'2023-11-08','22:03:13','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(158,1,999,'2023-11-08','22:03:34','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(159,1,1,'2023-11-08','22:05:55','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(160,1,7000,'2023-11-08','22:05:56','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(161,1,1,'2023-11-08','22:08:15','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(162,1,7000,'2023-11-08','22:08:16','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(163,1,1,'2023-11-08','22:39:40','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(164,1,7000,'2023-11-08','22:39:42','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(165,1,999,'2023-11-08','22:40:41','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(166,1,1,'2023-11-08','22:46:10','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(167,1,7000,'2023-11-08','22:46:11','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(168,1,1,'2023-11-08','22:49:26','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(169,1,7000,'2023-11-08','22:50:39','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(170,1,999,'2023-11-08','22:51:26','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(171,1,1,'2023-11-08','22:57:08','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(172,1,7000,'2023-11-08','22:57:13','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(173,1,1,'2023-11-08','22:58:36','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(174,1,7000,'2023-11-08','22:58:37','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(175,1,1,'2023-11-08','23:00:13','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(176,1,7000,'2023-11-08','23:00:14','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(177,1,1,'2023-11-08','23:01:58','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(178,1,7000,'2023-11-08','23:01:59','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(179,1,1,'2023-11-08','23:03:56','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(180,1,7000,'2023-11-08','23:03:58','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(181,1,999,'2023-11-08','23:04:52','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(182,1,1,'2023-11-08','23:08:27','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(183,1,7000,'2023-11-08','23:08:28','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(184,1,1,'2023-11-08','23:11:56','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(185,1,7000,'2023-11-08','23:11:57','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(186,1,1,'2023-11-08','23:14:18','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(187,1,7000,'2023-11-08','23:14:19','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(188,1,999,'2023-11-08','23:15:15','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(189,1,1,'2023-11-08','23:17:22','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(190,1,7000,'2023-11-08','23:17:23','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(191,1,1,'2023-11-08','23:19:44','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(192,1,7000,'2023-11-08','23:19:45','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(193,1,1004,'2023-11-08','23:20:33','OLSTER','fe80::a328:23e5:7f78:af4f%13','Guardar'),(194,1,1,'2023-11-09','00:14:54','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(195,1,7000,'2023-11-09','00:14:55','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(196,1,1,'2023-11-09','00:16:01','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(197,1,7000,'2023-11-09','00:16:02','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(198,1,1,'2023-11-09','00:23:21','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(199,1,7000,'2023-11-09','00:23:22','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(200,1,1,'2023-11-09','00:25:16','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(201,1,7000,'2023-11-09','00:25:18','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(202,1,1004,'2023-11-09','00:25:44','OLSTER','fe80::a328:23e5:7f78:af4f%13','Guardar'),(203,1,999,'2023-11-09','00:25:49','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(204,1,1,'2023-11-09','00:37:04','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(205,1,7000,'2023-11-09','00:37:05','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(206,1,1,'2023-11-09','00:42:10','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(207,1,7000,'2023-11-09','00:42:11','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(208,1,1,'2023-11-09','00:58:33','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(209,1,7000,'2023-11-09','00:58:41','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(210,1,1,'2023-11-09','01:03:01','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(211,1,7000,'2023-11-09','01:03:02','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(212,1,1,'2023-11-09','01:06:08','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(213,1,7000,'2023-11-09','01:06:09','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(214,1,1,'2023-11-09','01:07:37','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(215,1,7000,'2023-11-09','01:07:39','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(216,1,1,'2023-11-09','01:15:08','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(217,1,7000,'2023-11-09','01:15:08','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(218,1,1,'2023-11-09','01:17:54','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(219,1,7000,'2023-11-09','01:17:55','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(220,1,1,'2023-11-09','01:19:00','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(221,1,7000,'2023-11-09','01:19:01','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(222,1,1,'2023-11-09','01:22:04','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(223,1,7000,'2023-11-09','01:22:05','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(224,1,1,'2023-11-09','01:26:38','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(225,1,7000,'2023-11-09','01:26:39','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(226,1,1,'2023-11-09','01:30:14','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(227,1,7000,'2023-11-09','01:30:15','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(228,1,1,'2023-11-09','01:36:11','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(229,1,7000,'2023-11-09','01:36:12','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(230,1,1,'2023-11-09','01:40:04','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(231,1,7000,'2023-11-09','01:40:05','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(232,1,1,'2023-11-09','01:42:21','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(233,1,7000,'2023-11-09','01:42:22','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(234,1,1,'2023-11-09','01:43:48','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(235,1,7000,'2023-11-09','01:43:49','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Ventas'),(236,1,1,'2024-02-06','09:48:58','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(237,1,7000,'2024-02-06','09:49:00','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(238,1,1,'2024-02-06','12:35:21','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(239,1,7000,'2024-02-06','12:35:22','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(240,1,1000,'2024-02-06','12:35:50','OLSTER','fe80::a328:23e5:7f78:af4f%13','Se ha eliminado un registro'),(241,1,1000,'2024-02-06','12:36:09','OLSTER','fe80::a328:23e5:7f78:af4f%13','Se ha guardado un registro'),(242,1,1000,'2024-02-06','12:36:27','OLSTER','fe80::a328:23e5:7f78:af4f%13','Se ha guardado un registro'),(243,1,1,'2024-02-06','12:57:50','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(244,1,7000,'2024-02-06','12:57:51','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(245,1,1,'2024-02-06','13:01:19','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(246,1,7000,'2024-02-06','13:01:20','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(247,1,1,'2024-02-06','13:05:24','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(248,1,7000,'2024-02-06','13:05:25','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(249,1,1,'2024-02-06','13:06:46','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(250,1,7000,'2024-02-06','13:06:49','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(251,1,1,'2024-02-06','13:08:32','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(252,1,7000,'2024-02-06','13:08:33','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(253,1,1,'2024-02-06','13:10:32','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(254,1,7000,'2024-02-06','13:10:33','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(255,1,1,'2024-02-06','13:12:06','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(256,1,7000,'2024-02-06','13:12:07','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(257,1,1,'2024-02-06','13:12:44','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(258,1,7000,'2024-02-06','13:12:45','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(259,1,1,'2024-02-06','13:14:15','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(260,1,7000,'2024-02-06','13:14:16','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(261,1,1,'2024-02-06','13:15:36','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(262,1,7000,'2024-02-06','13:15:36','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(263,1,1,'2024-02-06','13:21:55','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(264,1,7000,'2024-02-06','13:21:56','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(265,1,1,'2024-02-06','13:23:09','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(266,1,7000,'2024-02-06','13:23:10','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(267,1,1,'2024-02-06','13:24:03','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(268,1,7000,'2024-02-06','13:24:04','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(269,1,999,'2024-02-06','13:24:10','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(270,1,1,'2024-02-06','13:25:52','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(271,1,7000,'2024-02-06','13:25:53','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(272,1,1,'2024-02-06','13:26:26','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(273,1,7000,'2024-02-06','13:26:27','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(274,1,1000,'2024-02-06','13:27:07','OLSTER','fe80::a328:23e5:7f78:af4f%13','Se ha eliminado un registro'),(275,1,1,'2024-02-06','13:30:03','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(276,1,7000,'2024-02-06','13:30:04','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(277,1,1,'2024-02-06','13:31:50','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(278,1,7000,'2024-02-06','13:31:51','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(279,1,1,'2024-02-06','13:32:41','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(280,1,7000,'2024-02-06','13:32:42','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(281,1,1,'2024-02-06','13:34:53','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(282,1,7000,'2024-02-06','13:34:54','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(283,1,1,'2024-02-06','13:35:42','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(284,1,7000,'2024-02-06','13:35:43','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(285,1,1,'2024-02-06','13:37:14','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(286,1,7000,'2024-02-06','13:37:15','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(287,1,1,'2024-02-06','13:37:51','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(288,1,7000,'2024-02-06','13:37:52','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(289,1,1,'2024-02-06','13:39:18','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(290,1,7000,'2024-02-06','13:39:19','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(291,1,1,'2024-02-06','13:43:55','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(292,1,7000,'2024-02-06','13:43:56','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(293,1,1,'2024-02-06','13:44:42','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(294,1,7000,'2024-02-06','13:44:44','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(295,1,1,'2024-02-07','08:30:19','OLSTER','192.168.56.1','Ingreso Login'),(296,1,7000,'2024-02-07','08:30:26','OLSTER','192.168.56.1','Ingreso Hoteleria'),(297,1,1,'2024-02-07','08:34:10','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(298,1,7000,'2024-02-07','08:34:11','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(299,1,1,'2024-02-07','08:36:10','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(300,1,7000,'2024-02-07','08:36:12','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(301,1,999,'2024-02-07','08:36:42','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(302,1,1,'2024-02-07','08:38:34','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(303,1,7000,'2024-02-07','08:38:36','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(304,1,1,'2024-02-07','08:42:59','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(305,1,7000,'2024-02-07','08:43:00','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(306,1,999,'2024-02-07','08:43:08','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(307,1,1,'2024-02-07','08:43:57','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(308,1,7000,'2024-02-07','08:43:58','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(309,1,1,'2024-02-07','08:51:20','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(310,1,7000,'2024-02-07','08:51:21','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Hoteleria'),(311,1,999,'2024-02-07','08:51:28','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerro Sesion'),(312,1,1,'2024-02-09','10:12:04','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(313,1,7000,'2024-02-09','10:12:06','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Hoteleria'),(314,1,1000,'2024-02-09','10:12:29','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Se ha modificado un registro'),(315,1,1,'2024-02-09','10:15:04','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(316,1,7000,'2024-02-09','10:15:06','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Hoteleria'),(317,1,1,'2024-02-09','10:15:45','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(318,1,7000,'2024-02-09','10:15:46','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Hoteleria'),(319,1,1,'2024-02-09','10:17:31','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(320,1,7000,'2024-02-09','10:17:33','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Hoteleria'),(321,1,1,'2024-02-09','10:41:46','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(322,1,7000,'2024-02-09','10:41:47','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Hoteleria'),(323,1,999,'2024-02-09','10:41:59','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Cerro Sesion'),(324,1,1,'2024-02-21','04:04:05','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(325,1,1,'2024-02-21','04:06:23','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(326,1,1,'2024-02-21','04:11:10','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(327,1,1,'2024-02-21','04:11:58','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(328,1,1,'2024-02-21','04:14:27','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(329,1,1,'2024-02-21','04:17:40','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(330,1,1,'2024-02-21','04:23:01','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(331,1,1,'2024-02-21','04:27:57','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(332,1,1,'2024-02-21','04:32:44','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(333,1,1,'2024-02-21','04:34:51','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(334,1,1,'2024-02-21','04:36:53','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(335,1,1,'2024-02-21','04:39:18','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(336,1,1,'2024-02-21','04:42:13','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(337,1,1,'2024-02-21','04:43:50','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(338,1,1,'2024-02-21','04:46:32','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(339,1,1,'2024-02-21','04:47:34','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(340,1,1,'2024-02-21','04:48:50','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(341,1,1000,'2024-02-21','04:49:08','OLSTER','fe80::a328:23e5:7f78:af4f%13','Se ha guardado un registro'),(342,1,1,'2024-02-21','04:52:33','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(343,1,1000,'2024-02-21','04:52:47','OLSTER','fe80::a328:23e5:7f78:af4f%13','Se ha guardado un registro'),(344,1,1,'2024-02-21','04:54:25','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(345,1,1000,'2024-02-21','04:54:42','OLSTER','fe80::a328:23e5:7f78:af4f%13','Se ha guardado un registro'),(346,1,1,'2024-02-21','05:15:40','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(347,1,1,'2024-02-21','05:35:50','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(348,1,1,'2024-02-21','05:36:20','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(349,1,1,'2024-02-21','05:38:12','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(350,1,1,'2024-02-21','05:41:11','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(351,1,1,'2024-02-21','05:43:03','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(352,1,1,'2024-02-21','05:45:20','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(353,1,1,'2024-02-21','05:46:14','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(354,1,1,'2024-02-21','05:48:26','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(355,1,1,'2024-02-21','05:49:02','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(356,1,1,'2024-02-21','05:51:16','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(357,1,1,'2024-02-21','05:53:32','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(358,1,1,'2024-02-21','05:56:34','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(359,1,1,'2024-02-21','06:01:09','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(360,1,1,'2024-02-21','06:02:19','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(361,1,1,'2024-02-21','06:03:40','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(362,1,1,'2024-02-21','06:04:43','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(363,1,1,'2024-02-21','06:06:36','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(364,1,1,'2024-02-21','06:09:28','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(365,1,1,'2024-02-21','06:13:47','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(366,1,1,'2024-02-21','06:15:22','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(367,1,1,'2024-02-21','06:16:16','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(368,1,1,'2024-02-21','15:43:04','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(369,1,1,'2024-02-21','15:45:19','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(370,1,1,'2024-02-21','15:45:56','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(371,1,1,'2024-02-21','15:47:07','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(372,1,1,'2024-02-21','15:48:44','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(373,1,1,'2024-02-21','15:49:46','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(374,1,1,'2024-02-21','15:50:53','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(375,1,1,'2024-02-21','15:54:30','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(376,1,1,'2024-02-21','15:55:19','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(377,1,1,'2024-02-21','15:59:11','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(378,1,1,'2024-02-21','16:00:12','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(379,1,1,'2024-02-21','16:13:43','OLSTER','192.168.56.1','Ingreso Login'),(380,1,1,'2024-02-21','16:19:03','OLSTER','192.168.56.1','Ingreso Login'),(381,1,1,'2024-02-21','16:26:56','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(382,1,1,'2024-02-21','18:53:40','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(383,1,1,'2024-02-21','18:55:04','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(384,1,1,'2024-02-21','19:30:18','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(385,1,1,'2024-02-21','19:58:00','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(386,1,1,'2024-02-21','20:12:30','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(387,1,1,'2024-02-21','20:15:22','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(388,1,1,'2024-02-21','20:44:58','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(389,1,1,'2024-02-21','20:48:59','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(390,1,1,'2024-02-21','20:52:06','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(391,1,1,'2024-02-21','20:53:19','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(392,1,1,'2024-02-21','20:59:53','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(393,1,1,'2024-02-21','21:01:22','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(394,1,1,'2024-02-21','21:02:43','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(395,1,1,'2024-02-21','21:23:05','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(396,1,1,'2024-02-21','21:26:59','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(397,1,1,'2024-02-21','21:31:55','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(398,1,1,'2024-02-21','21:36:07','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(399,1,1,'2024-02-21','21:38:20','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(400,1,1,'2024-02-21','21:39:24','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(401,1,1,'2024-02-21','21:49:49','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(402,1,1,'2024-02-21','21:53:29','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(403,1,1,'2024-02-21','22:00:02','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(404,1,1,'2024-02-21','22:01:31','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(405,1,1,'2024-02-21','22:21:33','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(406,1,1,'2024-02-21','22:24:03','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(407,1,1,'2024-02-21','22:25:51','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(408,1,1,'2024-02-21','22:29:31','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(409,1,1,'2024-02-21','22:34:19','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(410,1,1,'2024-02-21','22:40:28','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(411,1,1,'2024-02-21','22:43:01','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(412,1,1,'2024-02-21','22:59:04','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(413,1,1,'2024-02-21','23:35:21','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(414,1,1,'2024-02-21','23:38:25','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(415,1,1,'2024-02-21','23:40:45','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(416,1,1,'2024-02-21','23:43:34','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(417,1,1000,'2024-02-21','23:43:36','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Seguridad'),(418,1,1,'2024-02-21','23:43:47','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(419,1,1,'2024-02-21','23:49:19','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(420,1,1,'2024-02-21','23:52:43','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(421,1,1,'2024-02-21','23:56:54','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(422,1,1,'2024-02-22','00:09:02','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(423,1,1,'2024-02-22','00:14:12','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(424,1,1,'2024-02-22','00:31:19','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(425,1,1,'2024-02-22','00:33:28','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(426,1,1,'2024-02-22','00:40:41','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(427,1,1,'2024-02-22','00:41:19','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(428,1,1000,'2024-02-22','00:41:27','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Seguridad'),(429,1,1,'2024-02-22','00:42:26','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(430,1,1,'2024-02-22','01:33:43','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(431,1,1,'2024-02-22','17:17:00','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(432,1,1,'2024-02-22','17:31:43','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(433,1,1,'2024-02-22','17:56:33','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(434,1,1,'2024-02-22','18:01:14','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(435,1,1,'2024-02-22','19:00:24','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(436,1,1,'2024-02-22','19:01:32','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(437,1,1,'2024-02-22','19:06:25','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(438,1,1,'2024-02-22','19:08:45','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(439,1,1,'2024-02-22','19:09:57','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(440,1,1,'2024-02-22','19:12:39','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(441,1,1,'2024-02-22','19:13:56','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(442,1,1,'2024-02-22','19:18:56','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(443,1,1,'2024-02-22','19:31:40','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(444,1,1,'2024-02-22','19:33:51','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(445,1,1,'2024-02-22','19:34:49','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(446,1,1,'2024-02-22','19:35:45','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(447,1,1,'2024-02-22','20:46:35','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(448,1,1,'2024-02-22','20:48:22','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(449,1,1,'2024-02-22','20:52:26','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(450,1,1,'2024-02-22','20:54:27','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(451,1,1,'2024-02-22','21:04:58','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(452,1,1,'2024-02-22','21:13:32','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(453,1,1,'2024-02-22','21:23:55','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(454,1,1,'2024-02-23','09:55:26','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(455,1,1,'2024-02-23','10:04:43','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(456,1,1,'2024-02-23','10:05:07','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(457,1,1,'2024-02-23','10:05:28','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(458,1,1,'2024-02-23','11:03:52','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(459,1,1,'2024-02-23','11:06:26','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(460,1,1000,'2024-02-23','11:06:52','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Se ha eliminado un registro'),(461,1,1,'2024-02-23','11:10:17','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(462,1,1,'2024-02-23','11:13:26','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(463,1,1,'2024-02-23','11:16:50','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(464,1,1,'2024-02-23','17:08:45','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(465,1,1,'2024-02-23','17:12:36','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(466,1,1,'2024-02-23','17:15:15','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(467,1,1,'2024-02-23','17:15:54','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(468,1,1,'2024-02-23','17:16:52','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(469,1,1000,'2024-02-23','17:17:25','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Se ha modificado un registro'),(470,1,1,'2024-02-23','17:25:50','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(471,1,1,'2024-02-23','17:27:25','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(472,1,1,'2024-02-23','17:29:15','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(473,1,1,'2024-02-23','17:32:04','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Ingreso Login'),(474,1,1000,'2024-02-23','17:36:14','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Se ha eliminado un registro'),(475,1,1000,'2024-02-23','17:36:30','DESKTOP-HCCDANL','2803:d100:e5a0:1e5a::5','Se ha eliminado un registro'),(476,1,1,'2024-04-05','14:41:05','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(477,1,1,'2024-04-05','14:42:23','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(478,1,1,'2024-04-05','14:58:59','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(479,1,1000,'2024-04-05','14:59:26','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha modificado un registro'),(480,1,1,'2024-04-05','15:01:58','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(481,1,1,'2024-04-05','15:03:31','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(482,1,1000,'2024-04-05','15:03:51','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha modificado un registro'),(483,1,1,'2024-04-05','15:05:19','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(484,1,1,'2024-04-05','17:02:28','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(485,1,1,'2024-04-05','17:58:12','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(486,1,1,'2024-04-05','18:01:01','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(487,1,1000,'2024-04-05','18:01:57','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(488,1,1,'2024-04-05','18:05:11','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(489,1,1000,'2024-04-05','18:05:35','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(490,1,1000,'2024-04-05','18:08:27','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(491,1,1,'2024-04-05','18:10:51','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(492,1,1000,'2024-04-05','18:11:32','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(493,1,1,'2024-04-05','18:21:13','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(494,1,1000,'2024-04-05','18:22:02','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(495,1,1000,'2024-04-05','18:24:17','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(496,1,1000,'2024-04-05','18:25:11','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(497,1,1,'2024-04-05','18:31:51','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(498,1,1000,'2024-04-05','18:32:59','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(499,1,1000,'2024-04-05','18:33:22','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha modificado un registro'),(500,1,1000,'2024-04-05','18:33:27','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha eliminado un registro'),(501,1,1,'2024-04-05','18:34:35','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(502,1,1,'2024-04-05','18:36:17','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(503,1,1000,'2024-04-05','18:37:01','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(504,1,1,'2024-04-05','18:38:20','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Ingreso Login'),(505,1,1000,'2024-04-05','18:39:05','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(506,1,1000,'2024-04-05','18:39:36','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha modificado un registro'),(507,1,1000,'2024-04-05','18:39:50','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha eliminado un registro'),(508,1,1000,'2024-04-05','18:40:28','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(509,1,1000,'2024-04-05','18:40:52','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha modificado un registro'),(510,1,1000,'2024-04-05','18:41:04','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha eliminado un registro'),(511,1,1000,'2024-04-05','18:42:06','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha guardado un registro'),(512,1,1000,'2024-04-05','18:42:35','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha modificado un registro'),(513,1,1000,'2024-04-05','18:42:48','DESKTOP-HCCDANL','2803:d100:e5a0:24c:c914:e035:9458:9d07','Se ha eliminado un registro'),(514,1,1,'2024-04-10','21:45:32','DESKTOP-HCCDANL','2803:d100:e5a0:d10:5d6e:9ffd:5496:aea5','Ingreso Login'),(515,1,1,'2024-04-12','10:08:47','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(516,1,1,'2024-04-12','10:13:23','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(517,1,1000,'2024-04-12','10:15:35','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Se ha guardado un registro'),(518,1,1000,'2024-04-12','10:15:59','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Se ha modificado un registro'),(519,1,1000,'2024-04-12','10:16:12','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Se ha eliminado un registro'),(520,1,1,'2024-04-12','11:52:19','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(521,1,1,'2024-04-12','11:53:53','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(522,1,1000,'2024-04-12','11:54:13','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Seguridad'),(523,1,1,'2024-04-12','11:57:25','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(524,1,8000,'2024-04-12','11:57:26','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Prototipo'),(525,1,1,'2024-04-12','11:59:14','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(526,1,8000,'2024-04-12','11:59:29','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Prototipo'),(527,1,1,'2024-04-13','17:54:16','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(528,1,8000,'2024-04-13','17:54:18','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Prototipo'),(529,1,1,'2024-04-13','18:04:51','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(530,1,8000,'2024-04-13','18:04:53','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Prototipo'),(531,1,1,'2024-04-13','18:06:37','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(532,1,8000,'2024-04-13','18:06:39','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Prototipo'),(533,1,1000,'2024-04-13','18:08:57','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Seguridad'),(534,1,1,'2024-04-13','18:10:08','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(535,1,8000,'2024-04-13','18:10:09','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Prototipo'),(536,1,1,'2024-04-13','18:51:21','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(537,1,1,'2024-04-13','19:37:52','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Login'),(538,1,8000,'2024-04-13','19:38:26','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Se ha guardado un registro'),(539,1,1000,'2024-04-13','19:38:34','DESKTOP-HCCDANL','2803:d100:e5a0:d10::2','Ingreso Seguridad'),(540,1,1,'2024-04-23','18:09:52','DESKTOP-HCCDANL','2803:d100:e5a0:d10::7','Ingreso Login');
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cheque`
--

DROP TABLE IF EXISTS `tbl_cheque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cheque` (
  `chq_id` int NOT NULL AUTO_INCREMENT,
  `chq_numero` varchar(20) NOT NULL,
  `chq_cuenta` int NOT NULL,
  `chq_monto` double NOT NULL,
  `chq_endoso` varchar(100) DEFAULT NULL,
  `chq_fecha` date NOT NULL,
  `chq_saldo_cuenta` double NOT NULL,
  PRIMARY KEY (`chq_id`),
  KEY `chq_cuenta` (`chq_cuenta`),
  CONSTRAINT `tbl_cheque_ibfk_1` FOREIGN KEY (`chq_cuenta`) REFERENCES `tbl_cuenta` (`cue_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cheque`
--

LOCK TABLES `tbl_cheque` WRITE;
/*!40000 ALTER TABLE `tbl_cheque` DISABLE KEYS */;
INSERT INTO `tbl_cheque` VALUES (2,'123456',1,1000,'María','2024-04-23',5000),(3,'654321',2,1500,'Juan','2024-04-24',8000);
/*!40000 ALTER TABLE `tbl_cheque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cliente`
--

DROP TABLE IF EXISTS `tbl_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cliente` (
  `cli_id` int NOT NULL AUTO_INCREMENT,
  `cli_nombre` varchar(50) NOT NULL,
  `cli_direccion` varchar(70) NOT NULL,
  `cli_correo` varchar(50) NOT NULL,
  `cli_telefono` varchar(10) NOT NULL,
  `cli_dpi` varchar(20) NOT NULL,
  `cli_edad` int NOT NULL,
  PRIMARY KEY (`cli_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cliente`
--

LOCK TABLES `tbl_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_cliente` DISABLE KEYS */;
INSERT INTO `tbl_cliente` VALUES (1,'Juan Perez','Calle 123, Ciudad','juan@example.com','1234567890','1234567890123',35),(2,'María López','Avenida XYZ, Pueblo','maria@example.com','0987654321','9876543210987',28);
/*!40000 ALTER TABLE `tbl_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuenta`
--

DROP TABLE IF EXISTS `tbl_cuenta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuenta` (
  `cue_id` int NOT NULL AUTO_INCREMENT,
  `cue_cliente` int NOT NULL,
  `cue_tipo` int NOT NULL,
  `cue_saldo` int NOT NULL,
  `cue_moneda` int NOT NULL,
  PRIMARY KEY (`cue_id`),
  KEY `cue_cliente` (`cue_cliente`),
  KEY `cue_tipo` (`cue_tipo`),
  KEY `cue_moneda` (`cue_moneda`),
  CONSTRAINT `tbl_cuenta_ibfk_1` FOREIGN KEY (`cue_cliente`) REFERENCES `tbl_cliente` (`cli_id`),
  CONSTRAINT `tbl_cuenta_ibfk_2` FOREIGN KEY (`cue_tipo`) REFERENCES `tbl_tipo_cuenta` (`tcu_id`),
  CONSTRAINT `tbl_cuenta_ibfk_3` FOREIGN KEY (`cue_moneda`) REFERENCES `tbl_moneda` (`mon_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuenta`
--

LOCK TABLES `tbl_cuenta` WRITE;
/*!40000 ALTER TABLE `tbl_cuenta` DISABLE KEYS */;
INSERT INTO `tbl_cuenta` VALUES (1,1,1,5000,1),(2,2,2,8000,2);
/*!40000 ALTER TABLE `tbl_cuenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_estados`
--

DROP TABLE IF EXISTS `tbl_estados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_estados` (
  `pk_id_estado` int NOT NULL AUTO_INCREMENT,
  `est_info_estado` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `est_num_estado` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_estado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_estados`
--

LOCK TABLES `tbl_estados` WRITE;
/*!40000 ALTER TABLE `tbl_estados` DISABLE KEYS */;
INSERT INTO `tbl_estados` VALUES (1,'Activo',1),(2,'Eliminado',2),(3,'Modificado',3);
/*!40000 ALTER TABLE `tbl_estados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_historial_transacciones`
--

DROP TABLE IF EXISTS `tbl_historial_transacciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_historial_transacciones` (
  `htr_id` int NOT NULL AUTO_INCREMENT,
  `htr_cuenta` int NOT NULL,
  `htr_tipo` int NOT NULL,
  `htr_monto` double NOT NULL,
  `htr_fecha` date NOT NULL,
  PRIMARY KEY (`htr_id`),
  KEY `htr_tipo` (`htr_tipo`),
  KEY `htr_cuenta` (`htr_cuenta`),
  CONSTRAINT `tbl_historial_transacciones_ibfk_1` FOREIGN KEY (`htr_tipo`) REFERENCES `tbl_tipo_transaccion` (`ttr_id`),
  CONSTRAINT `tbl_historial_transacciones_ibfk_2` FOREIGN KEY (`htr_cuenta`) REFERENCES `tbl_cuenta` (`cue_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_historial_transacciones`
--

LOCK TABLES `tbl_historial_transacciones` WRITE;
/*!40000 ALTER TABLE `tbl_historial_transacciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_historial_transacciones` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=444445 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_mantenimientos_tipo_movimiento`
--

LOCK TABLES `tbl_mantenimientos_tipo_movimiento` WRITE;
/*!40000 ALTER TABLE `tbl_mantenimientos_tipo_movimiento` DISABLE KEYS */;
INSERT INTO `tbl_mantenimientos_tipo_movimiento` VALUES (444333,'DEBITO',1,0);
/*!40000 ALTER TABLE `tbl_mantenimientos_tipo_movimiento` ENABLE KEYS */;
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
INSERT INTO `tbl_modulos` VALUES (1000,'SEGURIDAD','Seguridad',1),(7000,'Hoteleria','Hoteleria',1),(8000,'Prototipo','Prototipo',1);
/*!40000 ALTER TABLE `tbl_modulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_moneda`
--

DROP TABLE IF EXISTS `tbl_moneda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_moneda` (
  `mon_id` int NOT NULL AUTO_INCREMENT,
  `mon_nombre` varchar(40) NOT NULL,
  PRIMARY KEY (`mon_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_moneda`
--

LOCK TABLES `tbl_moneda` WRITE;
/*!40000 ALTER TABLE `tbl_moneda` DISABLE KEYS */;
INSERT INTO `tbl_moneda` VALUES (1,'Dólar estadounidense'),(2,'Euro');
/*!40000 ALTER TABLE `tbl_moneda` ENABLE KEYS */;
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
  `fk_num_cuentaDebito` int DEFAULT NULL,
  `fk_num_cuentaCredito` int DEFAULT NULL,
  `movban_status` int DEFAULT NULL,
  `movban_fecha_de_ingreso` datetime DEFAULT NULL,
  PRIMARY KEY (`pk_movban_id_transaccion`),
  KEY `fk_num_cuentaDebito` (`fk_num_cuentaDebito`),
  KEY `fk_num_cuentaCredito` (`fk_num_cuentaCredito`),
  CONSTRAINT `tbl_movimientosbancarios_ibfk_1` FOREIGN KEY (`fk_num_cuentaDebito`) REFERENCES `tbl_cuenta` (`cue_id`),
  CONSTRAINT `tbl_movimientosbancarios_ibfk_2` FOREIGN KEY (`fk_num_cuentaCredito`) REFERENCES `tbl_cuenta` (`cue_id`)
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
-- Table structure for table `tbl_pago_servicio`
--

DROP TABLE IF EXISTS `tbl_pago_servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_pago_servicio` (
  `psrv_id` int NOT NULL AUTO_INCREMENT,
  `psrv_servicio` int NOT NULL,
  `psrv_concepto` varchar(200) NOT NULL,
  `psrv_monto` double NOT NULL,
  `psrv_fecha` date NOT NULL,
  PRIMARY KEY (`psrv_id`),
  KEY `psrv_servicio` (`psrv_servicio`),
  CONSTRAINT `tbl_pago_servicio_ibfk_1` FOREIGN KEY (`psrv_servicio`) REFERENCES `tbl_servicio` (`srv_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_pago_servicio`
--

LOCK TABLES `tbl_pago_servicio` WRITE;
/*!40000 ALTER TABLE `tbl_pago_servicio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_pago_servicio` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
INSERT INTO `tbl_permisosaplicacionperfil` VALUES (1,1000,1,1,1,1,1),(1,1001,1,1,1,1,1),(1,1002,1,1,1,1,1),(1,1003,1,1,1,1,1),(1,1004,1,1,1,1,1),(1,1101,1,1,1,1,1),(1,1102,1,1,1,1,1),(1,1103,1,1,1,1,1),(1,1201,1,1,1,1,1),(1,1301,1,1,1,1,1),(1,8000,1,1,1,1,1),(1,8001,1,1,1,1,1),(1,8002,1,1,1,1,1),(1,8003,1,1,1,1,1),(1,8004,1,1,1,1,1),(1,8005,1,1,1,1,1);
/*!40000 ALTER TABLE `tbl_permisosaplicacionperfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_pruebapasaporte`
--

DROP TABLE IF EXISTS `tbl_pruebapasaporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_pruebapasaporte` (
  `Pk_id_persona` int NOT NULL AUTO_INCREMENT,
  `nombre_persona` varchar(100) NOT NULL,
  `dpi_persona` varchar(50) NOT NULL,
  PRIMARY KEY (`Pk_id_persona`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_pruebapasaporte`
--

LOCK TABLES `tbl_pruebapasaporte` WRITE;
/*!40000 ALTER TABLE `tbl_pruebapasaporte` DISABLE KEYS */;
INSERT INTO `tbl_pruebapasaporte` VALUES (1,'Juan','1234567891011'),(2,'Jose Daniel','4321321525'),(3,'Daniel','32143242'),(4,'Oliver','13432152313'),(5,'Oliver','3242134214'),(6,'Danny','8883334'),(7,'Luis','12333321'),(8,'',''),(9,'Mario','4555435'),(10,'Danny','12333213');
/*!40000 ALTER TABLE `tbl_pruebapasaporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_reportes`
--

DROP TABLE IF EXISTS `tbl_reportes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_reportes` (
  `pk_id_reporte` int NOT NULL AUTO_INCREMENT,
  `rep_correlativo` int DEFAULT NULL,
  `rep_nombre` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `fk_estado` int DEFAULT NULL,
  `rep_fecha` datetime DEFAULT NULL,
  `rep_archivo` varchar(120) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `rep_fechaMod` datetime DEFAULT NULL,
  PRIMARY KEY (`pk_id_reporte`),
  UNIQUE KEY `rep_correlativo` (`rep_correlativo`),
  KEY `fk_estado` (`fk_estado`),
  CONSTRAINT `tbl_reportes_ibfk_1` FOREIGN KEY (`fk_estado`) REFERENCES `tbl_estados` (`pk_id_estado`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_reportes`
--

LOCK TABLES `tbl_reportes` WRITE;
/*!40000 ALTER TABLE `tbl_reportes` DISABLE KEYS */;
INSERT INTO `tbl_reportes` VALUES (10,10002,'planilssla.txt',1,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tbl_reportes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_servicio`
--

DROP TABLE IF EXISTS `tbl_servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_servicio` (
  `srv_id` int NOT NULL AUTO_INCREMENT,
  `srv_cuenta` int NOT NULL,
  `srv_beneficiario` varchar(50) NOT NULL,
  PRIMARY KEY (`srv_id`),
  KEY `srv_cuenta` (`srv_cuenta`),
  CONSTRAINT `tbl_servicio_ibfk_1` FOREIGN KEY (`srv_cuenta`) REFERENCES `tbl_cuenta` (`cue_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_servicio`
--

LOCK TABLES `tbl_servicio` WRITE;
/*!40000 ALTER TABLE `tbl_servicio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_servicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tarjeta`
--

DROP TABLE IF EXISTS `tbl_tarjeta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tarjeta` (
  `tar_id` int NOT NULL AUTO_INCREMENT,
  `tar_codigo` varchar(20) NOT NULL,
  `tar_cliente` int NOT NULL,
  `tar_tipo` int NOT NULL,
  `tar_cvv` int NOT NULL,
  `tar_fecha_vencimiento` date NOT NULL,
  `tar_cuenta` int NOT NULL,
  PRIMARY KEY (`tar_id`),
  KEY `tar_cliente` (`tar_cliente`),
  KEY `tar_tipo` (`tar_tipo`),
  KEY `tar_cuenta` (`tar_cuenta`),
  CONSTRAINT `tbl_tarjeta_ibfk_1` FOREIGN KEY (`tar_cliente`) REFERENCES `tbl_cliente` (`cli_id`),
  CONSTRAINT `tbl_tarjeta_ibfk_2` FOREIGN KEY (`tar_tipo`) REFERENCES `tbl_tipo_tarjeta` (`ttar_id`),
  CONSTRAINT `tbl_tarjeta_ibfk_3` FOREIGN KEY (`tar_cuenta`) REFERENCES `tbl_cuenta` (`cue_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tarjeta`
--

LOCK TABLES `tbl_tarjeta` WRITE;
/*!40000 ALTER TABLE `tbl_tarjeta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tarjeta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipo_cuenta`
--

DROP TABLE IF EXISTS `tbl_tipo_cuenta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipo_cuenta` (
  `tcu_id` int NOT NULL AUTO_INCREMENT,
  `tcu_nombre` varchar(30) NOT NULL,
  PRIMARY KEY (`tcu_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipo_cuenta`
--

LOCK TABLES `tbl_tipo_cuenta` WRITE;
/*!40000 ALTER TABLE `tbl_tipo_cuenta` DISABLE KEYS */;
INSERT INTO `tbl_tipo_cuenta` VALUES (1,'Cuenta Corriente'),(2,'Cuenta de Ahorro');
/*!40000 ALTER TABLE `tbl_tipo_cuenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipo_tarjeta`
--

DROP TABLE IF EXISTS `tbl_tipo_tarjeta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipo_tarjeta` (
  `ttar_id` int NOT NULL AUTO_INCREMENT,
  `ttar_nombre` varchar(20) NOT NULL,
  PRIMARY KEY (`ttar_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipo_tarjeta`
--

LOCK TABLES `tbl_tipo_tarjeta` WRITE;
/*!40000 ALTER TABLE `tbl_tipo_tarjeta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tipo_tarjeta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipo_transaccion`
--

DROP TABLE IF EXISTS `tbl_tipo_transaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipo_transaccion` (
  `ttr_id` int NOT NULL AUTO_INCREMENT,
  `ttr_nombre` varchar(50) NOT NULL,
  `ttr_operacion` int NOT NULL,
  PRIMARY KEY (`ttr_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipo_transaccion`
--

LOCK TABLES `tbl_tipo_transaccion` WRITE;
/*!40000 ALTER TABLE `tbl_tipo_transaccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tipo_transaccion` ENABLE KEYS */;
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
-- Temporary view structure for view `vista_aplicacion_perfil`
--

DROP TABLE IF EXISTS `vista_aplicacion_perfil`;
/*!50001 DROP VIEW IF EXISTS `vista_aplicacion_perfil`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_aplicacion_perfil` AS SELECT 
 1 AS `ID`,
 1 AS `Perfil`,
 1 AS `Aplicacion`,
 1 AS `Insertar`,
 1 AS `Modificar`,
 1 AS `Eliminar`,
 1 AS `Buscar`,
 1 AS `Reporte`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vista_aplicacionusuario`
--

DROP TABLE IF EXISTS `vista_aplicacionusuario`;
/*!50001 DROP VIEW IF EXISTS `vista_aplicacionusuario`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_aplicacionusuario` AS SELECT 
 1 AS `Aplicacion`,
 1 AS `ID`,
 1 AS `Usuario`,
 1 AS `Insertar`,
 1 AS `Editar`,
 1 AS `Eliminar`,
 1 AS `Buscar`,
 1 AS `Reporte`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vista_modulo_aplicacion`
--

DROP TABLE IF EXISTS `vista_modulo_aplicacion`;
/*!50001 DROP VIEW IF EXISTS `vista_modulo_aplicacion`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_modulo_aplicacion` AS SELECT 
 1 AS `ID`,
 1 AS `Modulo`,
 1 AS `Aplicacion`,
 1 AS `Nombre`,
 1 AS `Descripcion`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vista_perfil_usuario`
--

DROP TABLE IF EXISTS `vista_perfil_usuario`;
/*!50001 DROP VIEW IF EXISTS `vista_perfil_usuario`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_perfil_usuario` AS SELECT 
 1 AS `ID`,
 1 AS `Usuario`,
 1 AS `nickName`,
 1 AS `perfil`,
 1 AS `Nombre`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vista_aplicacion_perfil`
--

/*!50001 DROP VIEW IF EXISTS `vista_aplicacion_perfil`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_aplicacion_perfil` AS select `b`.`fk_id_perfil` AS `ID`,`a`.`nombre_perfil` AS `Perfil`,`b`.`fk_id_aplicacion` AS `Aplicacion`,`b`.`guardar_permiso` AS `Insertar`,`b`.`modificar_permiso` AS `Modificar`,`b`.`eliminar_permiso` AS `Eliminar`,`b`.`buscar_permiso` AS `Buscar`,`b`.`imprimir_permiso` AS `Reporte` from (`tbl_permisosaplicacionperfil` `b` join `tbl_perfiles` `a` on((`a`.`pk_id_perfil` = `b`.`fk_id_perfil`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_aplicacionusuario`
--

/*!50001 DROP VIEW IF EXISTS `vista_aplicacionusuario`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_aplicacionusuario` AS select `b`.`fk_id_aplicacion` AS `Aplicacion`,`b`.`fk_id_usuario` AS `ID`,`a`.`nombre_usuario` AS `Usuario`,`b`.`guardar_permiso` AS `Insertar`,`b`.`modificar_permiso` AS `Editar`,`b`.`eliminar_permiso` AS `Eliminar`,`b`.`buscar_permiso` AS `Buscar`,`b`.`imprimir_permiso` AS `Reporte` from (`tbl_permisosaplicacionesusuario` `b` join `tbl_usuarios` `a` on((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_modulo_aplicacion`
--

/*!50001 DROP VIEW IF EXISTS `vista_modulo_aplicacion`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_modulo_aplicacion` AS select `b`.`fk_id_modulos` AS `ID`,`a`.`nombre_modulo` AS `Modulo`,`b`.`fk_id_aplicacion` AS `Aplicacion`,`c`.`nombre_aplicacion` AS `Nombre`,`c`.`descripcion_aplicacion` AS `Descripcion` from ((`tbl_asignacionmoduloaplicacion` `b` join `tbl_modulos` `a` on((`a`.`pk_id_modulos` = `b`.`fk_id_modulos`))) join `tbl_aplicaciones` `c` on((`c`.`pk_id_aplicacion` = `b`.`fk_id_aplicacion`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_perfil_usuario`
--

/*!50001 DROP VIEW IF EXISTS `vista_perfil_usuario`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_perfil_usuario` AS select `b`.`fk_id_usuario` AS `ID`,`a`.`nombre_usuario` AS `Usuario`,`a`.`username_usuario` AS `nickName`,`b`.`fk_id_perfil` AS `perfil`,`c`.`nombre_perfil` AS `Nombre` from ((`tbl_asignacionesperfilsusuario` `b` join `tbl_usuarios` `a` on((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`))) join `tbl_perfiles` `c` on((`c`.`pk_id_perfil` = `b`.`fk_id_perfil`))) */;
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

-- Dump completed on 2024-04-25  8:52:30

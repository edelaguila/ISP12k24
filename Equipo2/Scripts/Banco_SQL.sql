CREATE DATABASE  IF NOT EXISTS `bd_banco` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bd_banco`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_banco
-- ------------------------------------------------------
-- Server version	8.3.0

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
INSERT INTO `tbl_aplicaciones` VALUES (1,'Menu','Ingreso Login',1),(999,'Cerrar Sesion','Cerrar Sesion',1),(1000,'MDI SEGURIDAD','PARA SEGURIDAD',1),(1001,'Mant. Usuario','PARA SEGURIDAD',1),(1002,'Mant. Aplicación','PARA SEGURIDAD',1),(1003,'Mant. Modulo','PARA SEGURIDAD',1),(1004,'Mant. Perfil','PARA SEGURIDAD',1),(1101,'Asign. Modulo Aplicacion','PARA SEGURIDAD',1),(1102,'Asign. Aplicacion Perfil','PARA SEGURIDAD',1),(1103,'Asign. Perfil Usuario','PARA SEGURIDAD',1),(1201,'Pcs. Cambio Contraseña','PARA SEGURIDAD',1),(1301,'Pcs. BITACORA','PARA SEGURIDAD',1),(8000,'MDI Prototipo','Proto',1),(8001,'Crear Cita','Crear',1),(8002,'Visualizar Cita','Vizualizar',1),(8003,'Reprogramar Cita','Reprogramar',1),(8004,'Cancelar Cita','Cancelar',1),(8005,'Comprobación de Doc','Docs',1);
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
INSERT INTO `tbl_asignacionesperfilsusuario` VALUES (1,1),(2,1);
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
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES (1000,1000),(1000,1001),(1000,1002),(1000,1003),(1000,1004),(1000,1102),(1000,1103),(1000,1201),(1000,1301),(8000,8000),(8000,8001),(8000,8002),(8000,8003),(8000,8004),(8000,8005);
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
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacoradeeventos`
--

LOCK TABLES `tbl_bitacoradeeventos` WRITE;
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` DISABLE KEYS */;
INSERT INTO `tbl_bitacoradeeventos` VALUES (1,1,1,'2024-04-26','15:29:08','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(2,1,8000,'2024-04-26','15:30:03','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(3,1,1,'2024-04-26','15:31:32','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(4,1,8000,'2024-04-26','15:31:34','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(5,1,1,'2024-04-26','15:56:33','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(6,1,1,'2024-04-26','16:39:44','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(7,1,8000,'2024-04-26','16:39:46','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(8,1,1,'2024-04-26','16:41:29','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(9,1,8000,'2024-04-26','16:41:41','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(10,1,1,'2024-04-26','16:42:34','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(11,1,8000,'2024-04-26','16:42:37','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(12,1,1,'2024-04-26','16:44:04','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(13,1,8000,'2024-04-26','16:44:06','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(14,1,1,'2024-04-26','16:45:18','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(15,1,8000,'2024-04-26','16:45:20','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(16,1,1,'2024-04-28','17:15:41','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(17,1,8000,'2024-04-28','17:15:43','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(18,1,1,'2024-04-28','19:01:21','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(19,1,1000,'2024-04-28','19:01:23','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Seguridad'),(20,1,1001,'2024-04-28','19:02:11','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Guardar'),(21,2,1,'2024-04-28','19:02:32','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(22,2,999,'2024-04-28','19:02:34','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Cerró Sesión'),(23,2,1,'2024-04-28','19:02:40','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(24,2,1,'2024-04-28','19:04:42','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(25,2,8000,'2024-04-28','19:04:43','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(26,1,1,'2024-04-28','19:28:45','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(27,1,8000,'2024-04-28','19:28:50','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(28,1,999,'2024-04-28','19:29:01','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Cerró Sesión'),(29,1,1,'2024-04-28','19:41:27','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(30,1,8000,'2024-04-28','19:41:28','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(31,1,1,'2024-04-28','19:44:33','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(32,1,8000,'2024-04-28','19:44:34','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(33,1,1,'2024-04-28','20:11:24','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(34,1,8000,'2024-04-28','20:11:25','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(35,1,1,'2024-04-28','20:12:48','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(36,1,8000,'2024-04-28','20:12:48','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(37,1,999,'2024-04-28','20:12:59','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Cerró Sesión'),(38,1,1,'2024-04-28','20:13:45','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(39,1,8000,'2024-04-28','20:13:46','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(40,1,999,'2024-04-28','20:13:51','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Cerró Sesión'),(41,1,1,'2024-04-28','20:14:53','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(42,1,8000,'2024-04-28','20:14:55','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(43,1,999,'2024-04-28','20:15:25','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Cerró Sesión'),(44,1,1,'2024-04-28','21:21:00','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(45,1,8000,'2024-04-28','21:21:01','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(46,1,1,'2024-04-28','21:22:23','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(47,1,8000,'2024-04-28','21:22:24','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(48,1,1,'2024-04-28','21:23:40','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(49,1,8000,'2024-04-28','21:23:42','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(50,1,1,'2024-04-28','21:26:24','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(51,1,8000,'2024-04-28','21:26:25','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(52,1,1,'2024-04-28','21:29:09','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(53,1,8000,'2024-04-28','21:29:10','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(54,1,1,'2024-04-28','21:31:59','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso Login'),(55,1,8000,'2024-04-28','21:32:00','OLSTER','fe80::8a8a:66cd:92ea:16ea%17','Ingreso a bancos'),(56,1,1,'2024-04-30','08:57:01','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(57,1,8000,'2024-04-30','08:57:02','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(58,1,1,'2024-04-30','08:58:09','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(59,1,8000,'2024-04-30','08:58:11','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(60,1,1,'2024-05-03','13:04:48','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(61,1,8000,'2024-05-03','13:04:50','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso a bancos'),(62,1,999,'2024-05-03','13:04:58','OLSTER','fe80::a328:23e5:7f78:af4f%13','Cerró Sesión'),(63,1,1,'2024-05-03','13:10:49','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Login'),(64,1,1000,'2024-05-03','13:10:52','OLSTER','fe80::a328:23e5:7f78:af4f%13','Ingreso Seguridad');
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` ENABLE KEYS */;
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
  `cli_nit` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`cli_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cliente`
--

LOCK TABLES `tbl_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_cliente` DISABLE KEYS */;
INSERT INTO `tbl_cliente` VALUES (1,'Oliver','11 Av','olstertecn597@gmail.com','59621085','1351413484',21,'59621085'),(2,'Jose','10ma Av','otzunund@miumg.edu.gt','78945633','55548483114584',28,'59621095');
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
  `cue_numero` varchar(45) NOT NULL,
  `cue_usuario` int DEFAULT NULL,
  PRIMARY KEY (`cue_id`),
  KEY `cue_cliente` (`cue_cliente`),
  KEY `cue_tipo` (`cue_tipo`),
  KEY `cue_moneda` (`cue_moneda`),
  KEY `tbl_cuenta_ibfk_4_idx` (`cue_usuario`),
  CONSTRAINT `tbl_cuenta_ibfk_1` FOREIGN KEY (`cue_cliente`) REFERENCES `tbl_cliente` (`cli_id`),
  CONSTRAINT `tbl_cuenta_ibfk_2` FOREIGN KEY (`cue_tipo`) REFERENCES `tbl_tipo_cuenta` (`tcu_id`),
  CONSTRAINT `tbl_cuenta_ibfk_3` FOREIGN KEY (`cue_moneda`) REFERENCES `tbl_moneda` (`mon_id`),
  CONSTRAINT `tbl_cuenta_ibfk_4` FOREIGN KEY (`cue_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuenta`
--

LOCK TABLES `tbl_cuenta` WRITE;
/*!40000 ALTER TABLE `tbl_cuenta` DISABLE KEYS */;
INSERT INTO `tbl_cuenta` VALUES (1,1,1,3600,1,'37575878',1),(2,2,1,1500,1,'59621085',1);
/*!40000 ALTER TABLE `tbl_cuenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuentaamiga`
--

DROP TABLE IF EXISTS `tbl_cuentaamiga`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentaamiga` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_cuenta_principal` int NOT NULL,
  `id_cuenta_amiga` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_cuenta_principal` (`id_cuenta_principal`),
  KEY `id_cuenta_amiga` (`id_cuenta_amiga`),
  CONSTRAINT `tbl_cuentaamiga_ibfk_1` FOREIGN KEY (`id_cuenta_principal`) REFERENCES `tbl_cuenta` (`cue_id`),
  CONSTRAINT `tbl_cuentaamiga_ibfk_2` FOREIGN KEY (`id_cuenta_amiga`) REFERENCES `tbl_cuenta` (`cue_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuentaamiga`
--

LOCK TABLES `tbl_cuentaamiga` WRITE;
/*!40000 ALTER TABLE `tbl_cuentaamiga` DISABLE KEYS */;
INSERT INTO `tbl_cuentaamiga` VALUES (10,1,2);
/*!40000 ALTER TABLE `tbl_cuentaamiga` ENABLE KEYS */;
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
-- Table structure for table `tbl_factura`
--

DROP TABLE IF EXISTS `tbl_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_factura` (
  `fac_id` int NOT NULL AUTO_INCREMENT,
  `fac_fecha` date NOT NULL,
  `cli_nit` int NOT NULL,
  `fac_monto` double NOT NULL,
  `fac_estado` int NOT NULL,
  `fac_servicio` varchar(50) NOT NULL,
  PRIMARY KEY (`fac_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_factura`
--

LOCK TABLES `tbl_factura` WRITE;
/*!40000 ALTER TABLE `tbl_factura` DISABLE KEYS */;
INSERT INTO `tbl_factura` VALUES (1,'2024-05-08',59621085,200,1,'Luz'),(2,'2024-05-08',59621085,100,0,'Agua'),(3,'2024-05-08',59621085,100,0,'Agua');
/*!40000 ALTER TABLE `tbl_factura` ENABLE KEYS */;
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
INSERT INTO `tbl_modulos` VALUES (1000,'SEGURIDAD','Seguridad',1),(8000,'Prototipo','Prototipo',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_moneda`
--

LOCK TABLES `tbl_moneda` WRITE;
/*!40000 ALTER TABLE `tbl_moneda` DISABLE KEYS */;
INSERT INTO `tbl_moneda` VALUES (1,'Dolar'),(2,'Euro'),(3,'Quetzal');
/*!40000 ALTER TABLE `tbl_moneda` ENABLE KEYS */;
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
INSERT INTO `tbl_tipo_cuenta` VALUES (1,'Ahorro'),(2,'Monetario');
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_usuarios`
--

LOCK TABLES `tbl_usuarios` WRITE;
/*!40000 ALTER TABLE `tbl_usuarios` DISABLE KEYS */;
INSERT INTO `tbl_usuarios` VALUES (1,'admin','admin','admin','HO0aGo4nM94=','esduardo@gmail.com',1,'COLOR FAVORITO','X9yc1/l1b2A='),(2,'Oliver','Jose','Oliver','jIM8RY7n0OdezrmUaQf3HA==','olstertecn597@gmail.com',1,'PRIMER MASCOTA','jIM8RY7n0OdezrmUaQf3HA==');
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

-- Dump completed on 2024-05-09 20:05:15

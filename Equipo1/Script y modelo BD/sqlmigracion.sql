CREATE DATABASE  IF NOT EXISTS `bd_migracion` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bd_migracion`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_migracion
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
INSERT INTO `tbl_aplicaciones` VALUES (1,'Menu','Ingreso Login',1),(999,'Cerrar Sesion','Cerrar Sesion',1),(1000,'MDI SEGURIDAD','PARA SEGURIDAD',1),(1001,'Mant. Usuario','PARA SEGURIDAD',1),(1002,'Mant. Aplicación','PARA SEGURIDAD',1),(1003,'Mant. Modulo','PARA SEGURIDAD',1),(1004,'Mant. Perfil','PARA SEGURIDAD',1),(1101,'Asign. Modulo Aplicacion','PARA SEGURIDAD',1),(1102,'Asign. Aplicacion Perfil','PARA SEGURIDAD',1),(1103,'Asign. Perfil Usuario','PARA SEGURIDAD',1),(1201,'Pcs. Cambio Contraseña','PARA SEGURIDAD',1),(1301,'Pcs. BITACORA','PARA SEGURIDAD',1),(2000,'MDI migracion','PARA migracion',1),(2001,'administracion','PARA migraion',1),(2002,'agendar cita','para migracion',1),(2003,'reagendar cita','PARA migracion',1),(2004,'generacion de boleta','PARA BANCOS',1),(2005,'confirmacion de boleta','PARA BANCOS',1),(2006,'Mant. Bancos','PARA BANCOS',1),(2007,'Mant. RENAP','PARA RENAP',1);
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
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES (1000,1000),(1000,1001),(1000,1002),(1000,1003),(1000,1004),(1000,1102),(1000,1103),(1000,1201),(1000,1301),(2000,2000),(2000,2001),(2000,2002),(2000,2003),(2000,2004),(2000,2005),(2000,2006);
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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacoradeeventos`
--

LOCK TABLES `tbl_bitacoradeeventos` WRITE;
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` DISABLE KEYS */;
INSERT INTO `tbl_bitacoradeeventos` VALUES (8,1,1,'2024-02-21','10:15:25','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Login'),(9,1,1000,'2024-02-21','10:15:27','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Seguridad'),(10,1,1000,'2024-02-21','10:15:39','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Ingreso Seguridad'),(11,1,1001,'2024-02-21','10:16:24','LAPTOP-R6RT5UAG','fe80::b0e1:4dc3:fcc8:4576%10','Guardar');
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_boleta`
--

DROP TABLE IF EXISTS `tbl_boleta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_boleta` (
  `Pk_id_boleta` int NOT NULL AUTO_INCREMENT,
  `boleta_concepto` varchar(60) NOT NULL,
  `boleta_tipoPago` varchar(60) NOT NULL,
  `id_tipopasaporte` int NOT NULL,
  `boleta_añosDuracion` int NOT NULL,
  `boleta_numeroDoc` int NOT NULL,
  `tbl_cgc_Pk_no_cgc` int NOT NULL,
  `tbl_renap_Pk_num_dpi` bigint NOT NULL,
  PRIMARY KEY (`Pk_id_boleta`),
  KEY `id_tipopasaporte` (`id_tipopasaporte`),
  KEY `fk_tbl_boleta_tbl_cgc` (`tbl_cgc_Pk_no_cgc`),
  KEY `fk_tbl_boleta_tbl_renap1_idx` (`tbl_renap_Pk_num_dpi`),
  CONSTRAINT `fk_tbl_boleta_tbl_cgc` FOREIGN KEY (`tbl_cgc_Pk_no_cgc`) REFERENCES `tbl_cgc` (`Pk_no_cgc`),
  CONSTRAINT `fk_tbl_boleta_tbl_renap1` FOREIGN KEY (`tbl_renap_Pk_num_dpi`) REFERENCES `tbl_renap` (`Pk_num_dpi`),
  CONSTRAINT `tbl_boleta_ibfk_2` FOREIGN KEY (`id_tipopasaporte`) REFERENCES `tbl_preciopasaporte` (`Pk_id_prepasaporte`)
) ENGINE=InnoDB AUTO_INCREMENT=87680397 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_boleta`
--

LOCK TABLES `tbl_boleta` WRITE;
/*!40000 ALTER TABLE `tbl_boleta` DISABLE KEYS */;
INSERT INTO `tbl_boleta` VALUES (3,'xd','xd',1,2,88906852,8890684,2024),(25372181,'concepto','efectivo',1,10,25372181,2537217,32456856),(87680396,'sadsda','ads',1,2,87680396,8768038,32456856);
/*!40000 ALTER TABLE `tbl_boleta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cgc`
--

DROP TABLE IF EXISTS `tbl_cgc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cgc` (
  `Pk_no_cgc` int NOT NULL,
  PRIMARY KEY (`Pk_no_cgc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cgc`
--

LOCK TABLES `tbl_cgc` WRITE;
/*!40000 ALTER TABLE `tbl_cgc` DISABLE KEYS */;
INSERT INTO `tbl_cgc` VALUES (2537217),(8768038),(8890684);
/*!40000 ALTER TABLE `tbl_cgc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cita`
--

DROP TABLE IF EXISTS `tbl_cita`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cita` (
  `Pk_id_cita` int NOT NULL,
  `cit_fecha` varchar(255) NOT NULL,
  `cit_pais` varchar(45) NOT NULL,
  `cit_hora` varchar(45) NOT NULL,
  `cit_dept` varchar(45) NOT NULL,
  `cit_municipio` varchar(45) NOT NULL,
  `tbl_boleta_Pk_id_boleta` int NOT NULL,
  `tbl_cgc_Pk_no_cgc` int NOT NULL,
  `tbl_renap_Pk_num_dpi` bigint NOT NULL,
  PRIMARY KEY (`Pk_id_cita`),
  KEY `fk_tbl_cita_tbl_boleta1_idx` (`tbl_boleta_Pk_id_boleta`),
  KEY `fk_tbl_cita_tbl_cgc1_idx` (`tbl_cgc_Pk_no_cgc`),
  KEY `fk_tbl_cita_tbl_renap1_idx` (`tbl_renap_Pk_num_dpi`),
  CONSTRAINT `fk_tbl_cita_tbl_boleta1` FOREIGN KEY (`tbl_boleta_Pk_id_boleta`) REFERENCES `tbl_boleta` (`Pk_id_boleta`),
  CONSTRAINT `fk_tbl_cita_tbl_cgc1` FOREIGN KEY (`tbl_cgc_Pk_no_cgc`) REFERENCES `tbl_cgc` (`Pk_no_cgc`),
  CONSTRAINT `fk_tbl_cita_tbl_renap1` FOREIGN KEY (`tbl_renap_Pk_num_dpi`) REFERENCES `tbl_renap` (`Pk_num_dpi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cita`
--

LOCK TABLES `tbl_cita` WRITE;
/*!40000 ALTER TABLE `tbl_cita` DISABLE KEYS */;
INSERT INTO `tbl_cita` VALUES (1,'2024-02-16','gt','9:00 hrs.','gt','sdas',3,8890684,2024);
/*!40000 ALTER TABLE `tbl_cita` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_datospersonales`
--

DROP TABLE IF EXISTS `tbl_datospersonales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_datospersonales` (
  `Pk_id` int NOT NULL AUTO_INCREMENT,
  `dp_nombre` varchar(255) NOT NULL,
  `dp_primerapellido` varchar(32) NOT NULL,
  `dp_segundoapellido` varchar(45) NOT NULL,
  `dp_fechanac` date NOT NULL,
  `dp_dirResidencia` varchar(45) NOT NULL,
  `dp_celular` varchar(45) NOT NULL,
  `dp_telefono` varchar(45) NOT NULL,
  `dp_correo` varchar(45) NOT NULL,
  `dp_correoconfir` varchar(45) NOT NULL,
  `dp_alturacm` varchar(45) NOT NULL,
  `dp_tez` varchar(45) NOT NULL,
  `dp_ojos` varchar(45) NOT NULL,
  `dp_ocupacion` varchar(45) NOT NULL,
  `dp_casadoapellido` varchar(25) NOT NULL,
  `tbl_renap_Pk_num_dpi` bigint NOT NULL,
  PRIMARY KEY (`Pk_id`),
  KEY `fk_tbl_datospersonales_tbl_renap1_idx` (`tbl_renap_Pk_num_dpi`),
  CONSTRAINT `fk_tbl_datospersonales_tbl_renap1` FOREIGN KEY (`tbl_renap_Pk_num_dpi`) REFERENCES `tbl_renap` (`Pk_num_dpi`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_datospersonales`
--

LOCK TABLES `tbl_datospersonales` WRITE;
/*!40000 ALTER TABLE `tbl_datospersonales` DISABLE KEYS */;
INSERT INTO `tbl_datospersonales` VALUES (4,'hola','hola','hola','2024-02-20','asd','asd','asd','asd','sd','sdasd','Media','Azul','Empleado/a','hola',2024),(5,'Luca ','Hernandez','Ramirez','1995-06-08','7av 15 calle casa 12','1231234','1125151','luc@mail.com','luc@mail.com','178','Clara','Marrón','Estudiante','nada',32456856);
/*!40000 ALTER TABLE `tbl_datospersonales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_login`
--

DROP TABLE IF EXISTS `tbl_login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_login` (
  `Pk_num_admin` int NOT NULL AUTO_INCREMENT,
  `nombre_admin` varchar(255) NOT NULL,
  `usuario_admin` varchar(10) NOT NULL,
  `pass_admin` varchar(255) NOT NULL,
  PRIMARY KEY (`Pk_num_admin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_login`
--

LOCK TABLES `tbl_login` WRITE;
/*!40000 ALTER TABLE `tbl_login` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_login` ENABLE KEYS */;
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
INSERT INTO `tbl_modulos` VALUES (1000,'SEGURIDAD','Seguridad',1),(2000,'migracion','migracion',1);
/*!40000 ALTER TABLE `tbl_modulos` ENABLE KEYS */;
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
INSERT INTO `tbl_perfiles` VALUES (1,'ADMINISTRADOR','contiene todos los permisos del programa',1),(2,'SEGURIDAD','contiene todos los permisos de seguridad',1),(3,'MIGRACION','contiene todos los permisos de seguridad',1);
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
INSERT INTO `tbl_permisosaplicacionperfil` VALUES (1,1000,1,1,1,1,1),(1,1001,1,1,1,1,1),(1,1002,1,1,1,1,1),(1,1003,1,1,1,1,1),(1,1004,1,1,1,1,1),(1,1101,1,1,1,1,1),(1,1102,1,1,1,1,1),(1,1103,1,1,1,1,1),(1,1201,1,1,1,1,1),(1,1301,1,1,1,1,1),(1,2000,1,1,1,1,1),(1,2001,1,1,1,1,1),(1,2002,1,1,1,1,1),(1,2003,1,1,1,1,1),(1,2004,1,1,1,1,1),(1,2005,1,1,1,1,1),(1,2006,1,1,1,1,1);
/*!40000 ALTER TABLE `tbl_permisosaplicacionperfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_preciopasaporte`
--

DROP TABLE IF EXISTS `tbl_preciopasaporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_preciopasaporte` (
  `Pk_id_prepasaporte` int NOT NULL AUTO_INCREMENT,
  `prepasaporte_nombre` varchar(60) NOT NULL,
  `prepasaporte_dolar` double NOT NULL,
  `prepasaporte_tasa` double NOT NULL,
  `prepasaporte_quetzales` double NOT NULL,
  PRIMARY KEY (`Pk_id_prepasaporte`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_preciopasaporte`
--

LOCK TABLES `tbl_preciopasaporte` WRITE;
/*!40000 ALTER TABLE `tbl_preciopasaporte` DISABLE KEYS */;
INSERT INTO `tbl_preciopasaporte` VALUES (1,'ordinario',5,0.78,40);
/*!40000 ALTER TABLE `tbl_preciopasaporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_renap`
--

DROP TABLE IF EXISTS `tbl_renap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_renap` (
  `Pk_num_dpi` bigint NOT NULL AUTO_INCREMENT,
  `ren_dpi` varchar(45) NOT NULL DEFAULT 'DPI',
  `ren_nacionalidad` varchar(45) NOT NULL,
  `ren_genero` varchar(45) NOT NULL,
  `ren_estadoCivil` varchar(45) NOT NULL,
  `ren_nombres` varchar(45) NOT NULL,
  `ren_primerapellido` varchar(45) NOT NULL,
  `ren_segundoapellido` varchar(45) NOT NULL,
  `ren_casadoapellido` varchar(45) NOT NULL,
  `ren_fechanacimiento` date NOT NULL,
  PRIMARY KEY (`Pk_num_dpi`)
) ENGINE=InnoDB AUTO_INCREMENT=32456857 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_renap`
--

LOCK TABLES `tbl_renap` WRITE;
/*!40000 ALTER TABLE `tbl_renap` DISABLE KEYS */;
INSERT INTO `tbl_renap` VALUES (2024,'2024','gt','Masculino','Casado','hola','hola','hola','hola','2024-02-20'),(32456856,'32456856','Guatemala','Masculino','Soltero','Luca ','Hernandez','Ramirez','nada','1995-06-08');
/*!40000 ALTER TABLE `tbl_renap` ENABLE KEYS */;
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
INSERT INTO `tbl_usuarios` VALUES (1,'admin','admin','admin','HO0aGo4nM94=','esduardo@gmail.com',1,'COLOR FAVORITO','X9yc1/l1b2A='),(2,'migracion','migracion','migracion','NPw6Rzocbs5uZgw3Wi2+zQ==','migracion@mai.com',1,'COLOR FAVORITO','NPw6Rzocbs5uZgw3Wi2+zQ==');
/*!40000 ALTER TABLE `tbl_usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-02-21 10:18:13

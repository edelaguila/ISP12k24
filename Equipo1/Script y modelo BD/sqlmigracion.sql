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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_boleta`
--

LOCK TABLES `tbl_boleta` WRITE;
/*!40000 ALTER TABLE `tbl_boleta` DISABLE KEYS */;
INSERT INTO `tbl_boleta` VALUES (3,'xd','xd',1,2,88906852,8890684,2024);
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
INSERT INTO `tbl_cgc` VALUES (8890684);
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
  `cit_hora` varchar(45) NOT NULL,
  `cit_dept` varchar(45) NOT NULL,
  `cit_ciudad` varchar(45) NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_datospersonales`
--

LOCK TABLES `tbl_datospersonales` WRITE;
/*!40000 ALTER TABLE `tbl_datospersonales` DISABLE KEYS */;
INSERT INTO `tbl_datospersonales` VALUES (4,'hola','hola','hola','2024-02-20','asd','asd','asd','asd','sd','sdasd','Media','Azul','Empleado/a','hola',2024);
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
) ENGINE=InnoDB AUTO_INCREMENT=2025 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_renap`
--

LOCK TABLES `tbl_renap` WRITE;
/*!40000 ALTER TABLE `tbl_renap` DISABLE KEYS */;
INSERT INTO `tbl_renap` VALUES (2024,'2024','gt','Masculino','Casado','hola','hola','hola','hola','2024-02-20');
/*!40000 ALTER TABLE `tbl_renap` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-02-20 13:42:49

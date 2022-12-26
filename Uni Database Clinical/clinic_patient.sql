-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: clinic
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient` (
  `patientFirstName` varchar(255) DEFAULT NULL,
  `patientMiddleName` varchar(255) DEFAULT NULL,
  `patientLastName` varchar(255) DEFAULT NULL,
  `patientDateOfBirth` date DEFAULT NULL,
  `patientNationalID` varchar(255) NOT NULL,
  `patientPhoneNum` varchar(255) DEFAULT NULL,
  `patientAddress` varchar(255) DEFAULT NULL,
  `patientMaritalStatus` varchar(255) DEFAULT NULL,
  `patientID` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`patientNationalID`),
  UNIQUE KEY `patientID_UNIQUE` (`patientID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES ('Mai','Samy','Noaman','1972-12-05','30172050512613','01269176071','1 Al Marghni_Almazah_Heliopolis_Caio','divorced',3),('Magda','Mamdouh','Ragy','1980-07-09','30180090907633','01181674934','88 Al Marghni_Almazah_Heliopolis_Caio','married',4),('Rana','Salah','Mohsen','1999-06-01','30190601010997','01201664338','122 Al Marghni_Almazah_Heliopolis_Caio','single',5),('Sally','Kamal','Fayek','1996-05-07','30195070709678','01201771880','11 Al Marghni_Almazah_Heliopolis_Caio','married',1),('Sara','Magdy','Samy','1992-01-22','30195222202673','01097280691','43 Al Marghni_Almazah_Heliopolis_Caio','single',2);
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-26  9:55:14

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
-- Table structure for table `patient_history`
--

DROP TABLE IF EXISTS `patient_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient_history` (
  `PatientID` int NOT NULL,
  `PatientNationalID` varchar(250) NOT NULL,
  `Visit_Reason` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Husband_Name` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Husband_Age` int DEFAULT NULL,
  `FirstPeriod_Age` int DEFAULT NULL,
  `Period_Regular` tinyint DEFAULT NULL,
  `Period_IRegular` tinyint DEFAULT NULL,
  `Period_Duration` int DEFAULT NULL,
  `PeriodtoPeriod_bleeding` tinyint DEFAULT NULL,
  `Bleeding_AfterSex` tinyint DEFAULT NULL,
  `Period_Duration_4d` tinyint DEFAULT NULL,
  `Period_Duration_7d` tinyint DEFAULT NULL,
  `Period_Duration_MoreThan7d` tinyint DEFAULT NULL,
  `Last_PeriodDate` date DEFAULT NULL,
  `Period_Pain_Yes` tinyint DEFAULT NULL,
  `Period_Pain_No` tinyint DEFAULT NULL,
  `Period_Pain_Sometimes` tinyint DEFAULT NULL,
  `Pain_Before_Period` tinyint DEFAULT NULL,
  `Pain_During_Period` tinyint DEFAULT NULL,
  `Pain_BeforeandDuring_Period` tinyint DEFAULT NULL,
  `Had_Pregnant` tinyint DEFAULT NULL,
  `Had_Abortion` tinyint DEFAULT NULL,
  `PregnancyorAbortion_Year` int DEFAULT NULL,
  `Pregnancyorbortion_Place` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Pregnancy_Duration` int DEFAULT NULL,
  `HoursOfLabor` int DEFAULT NULL,
  `TypeofDelivery` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Baby_Gender` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Baby_BirthWeight` float DEFAULT NULL,
  `Baby_PresentHealth` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `SexualActivity_Iquiries` tinyint DEFAULT NULL,
  `Had_Gyn_Surgries` tinyint DEFAULT NULL,
  `Infertility_Surgery` tinyint DEFAULT NULL,
  `Ovarian_Surgery` tinyint DEFAULT NULL,
  `Cesarean_Surgery` tinyint DEFAULT NULL,
  `Tubal_Ligation_Surgery` tinyint DEFAULT NULL,
  `Hysterectomy_Surgery` tinyint DEFAULT NULL,
  `Laparoscopy_Surgery` tinyint DEFAULT NULL,
  `Infertility_Surgery_Year` int DEFAULT NULL,
  `Ovarian_Surgery_Year` int DEFAULT NULL,
  `Cesarean_Surgery_Year` int DEFAULT NULL,
  `Tubal_Ligation_Surgery_Year` int DEFAULT NULL,
  `Hysterectomy_Surgery_Year` int DEFAULT NULL,
  `Laparoscopy_Surgery_Year` int DEFAULT NULL,
  `Other_Gyn_Surgeries` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Other_Gyn_Surgeries_Year` int DEFAULT NULL,
  `Another_Surgeries` tinyint DEFAULT NULL,
  `Surgery_Type` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Surgery_Year` int DEFAULT NULL,
  `Date_last_PapSmear` date DEFAULT NULL,
  `Have_Arthritis` tinyint DEFAULT NULL,
  `Have_HighBloodPresaure` tinyint DEFAULT NULL,
  `Have_HeartDiseases` tinyint DEFAULT NULL,
  `Have_KidneyDiseases` tinyint DEFAULT NULL,
  `Have_Emphysema` tinyint DEFAULT NULL,
  `Have_EatingDisorder` tinyint DEFAULT NULL,
  `Have_BloodTransfustions` tinyint DEFAULT NULL,
  `Have_ThyroidDiseases` tinyint DEFAULT NULL,
  `Have_Epileps` tinyint DEFAULT NULL,
  `Have_AnotherDiseases` varchar(250) DEFAULT NULL,
  `Medicine_Taken` varchar(500) DEFAULT NULL,
  `Medicine_Doses` varchar(250) DEFAULT NULL,
  `Medicine_Pill_PerDay` int DEFAULT NULL,
  `Have_Drug_Allergies` tinyint DEFAULT NULL,
  `Drug_Allergies_Names` varchar(250) DEFAULT NULL,
  `FamiliyMember_Diabetes` tinyint DEFAULT NULL,
  `FamiliyMember_OvarianCnacer` tinyint DEFAULT NULL,
  `FamiliyMember_BreastCancer` tinyint DEFAULT NULL,
  `FamiliyMember_ColonCancer` tinyint DEFAULT NULL,
  `Another_FamiliyMember_Diseases` varchar(250) DEFAULT NULL,
  `No_FamiliyMember_Diseases` tinyint DEFAULT NULL,
  `Names_FamiliyMember_Diseases` varchar(250) DEFAULT NULL,
  `Weight_Loss_Recently` tinyint DEFAULT NULL,
  `Weight_Gain_Recently` tinyint DEFAULT NULL,
  `Hair_Growth_Recently` tinyint DEFAULT NULL,
  `Hair_Loss_Recently` tinyint DEFAULT NULL,
  `ChangeInEnergy_Recently` tinyint DEFAULT NULL,
  `BreastDischarge_Recently` tinyint DEFAULT NULL,
  `AnotherSymptoms_Recently` varchar(250) DEFAULT NULL,
  `NoSymptoms_Recently` tinyint DEFAULT NULL,
  PRIMARY KEY (`PatientID`),
  UNIQUE KEY `PatientNationalID_UNIQUE` (`PatientNationalID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient_history`
--

LOCK TABLES `patient_history` WRITE;
/*!40000 ALTER TABLE `patient_history` DISABLE KEYS */;
INSERT INTO `patient_history` VALUES (1,'30172050512613','Blood in urine','Karim Tarek Magdy',42,12,1,0,5,0,0,0,1,0,'2022-11-09',1,0,0,0,1,0,1,0,2018,'Al-Salam Hosbital',8,5,'Normal','Boy',4.5,'Normal',0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',0,0,'',0,'2020-05-01',0,1,0,0,0,0,1,0,0,'','Concor','5 mg',1,0,'',1,0,1,0,'',1,'Thanaa(Mom)',0,1,0,1,1,0,'',0);
/*!40000 ALTER TABLE `patient_history` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-26  9:55:12

-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: pp
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `aiddistribution`
--

DROP TABLE IF EXISTS `aiddistribution`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aiddistribution` (
  `AidID` int NOT NULL AUTO_INCREMENT,
  `CampaignCycleID` int DEFAULT NULL,
  `AidType` enum('Medical','Financial','Food','Education') DEFAULT NULL,
  `AmountDonated` decimal(10,2) DEFAULT NULL,
  `DistributionDate` date DEFAULT NULL,
  PRIMARY KEY (`AidID`),
  KEY `CampaignCycleID` (`CampaignCycleID`),
  CONSTRAINT `aiddistribution_ibfk_1` FOREIGN KEY (`CampaignCycleID`) REFERENCES `campaigncycle` (`CampaignCycleID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aiddistribution`
--

LOCK TABLES `aiddistribution` WRITE;
/*!40000 ALTER TABLE `aiddistribution` DISABLE KEYS */;
INSERT INTO `aiddistribution` VALUES (1,1,'Financial',23.00,'2025-05-12'),(2,1,'Food',1200.00,'2025-01-15'),(3,2,'Medical',2500.00,'2025-02-20'),(4,3,'Financial',1800.50,'2025-03-10'),(5,4,'Education',2200.00,'2025-03-25'),(6,5,'Food',950.75,'2025-04-05'),(7,6,'Medical',3000.00,'2025-04-18'),(8,7,'Financial',1600.00,'2025-05-01'),(9,8,'Education',2000.00,'2025-05-12'),(10,9,'Food',1350.00,'2025-06-03'),(11,10,'Medical',2700.00,'2025-06-15'),(12,1,'Education',1900.00,'2025-06-25'),(13,2,'Financial',2100.00,'2025-07-05'),(14,3,'Food',1000.00,'2025-07-18'),(15,4,'Medical',2850.00,'2025-08-01'),(16,5,'Education',1750.00,'2025-08-10');
/*!40000 ALTER TABLE `aiddistribution` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `beneficiaries`
--

DROP TABLE IF EXISTS `beneficiaries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `beneficiaries` (
  `BeneficiaryID` int NOT NULL AUTO_INCREMENT,
  `FullName` varchar(100) DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `Gender` enum('Male','Female') DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `Address` text,
  PRIMARY KEY (`BeneficiaryID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `beneficiaries`
--

LOCK TABLES `beneficiaries` WRITE;
/*!40000 ALTER TABLE `beneficiaries` DISABLE KEYS */;
INSERT INTO `beneficiaries` VALUES (2,'halim','2009-04-17','Female','03679767838','dfhjsf'),(3,'Samuel Thompson','1980-05-15','Male','111-222-3333','123 Elm Street, Springfield'),(4,'Laura Martinez','1992-08-21','Female','222-333-4444','456 Oak Avenue, Riverdale'),(5,'Michael Johnson','1975-11-03','Male','333-444-5555','789 Pine Road, Greenville'),(6,'Emily Davis','1988-02-14','Female','444-555-6666','321 Maple Lane, Fairview'),(7,'Robert Lee','1990-06-30','Male','555-666-7777','654 Cedar Blvd, Lakewood'),(8,'Sophia Turner','1995-09-12','Female','666-777-8888','987 Birch Street, Hilltop'),(9,'James Walker','1982-03-27','Male','777-888-9999','741 Spruce Court, Brookfield'),(10,'Olivia Hall','1998-01-08','Female','888-999-0000','852 Willow Way, Roseville'),(11,'David Allen','1979-07-19','Male','999-000-1111','963 Chestnut Dr, Lakeside'),(12,'Emma Scott','1993-12-22','Female','000-111-2222','159 Walnut St, Meadowview'),(13,'Benjamin Hill','1986-04-10','Male','101-202-3030','753 Aspen Ave, Ridgewood'),(14,'Grace Lewis','1991-10-05','Female','202-303-4040','357 Poplar Pl, Westfield'),(15,'Daniel Young','1984-09-18','Male','303-404-5050','951 Redwood Ln, Pinecrest'),(16,'Chloe Green','1996-03-04','Female','404-505-6060','258 Beech St, Elmwood'),(17,'William King','1987-08-25','Male','505-606-7070','147 Magnolia Blvd, Northgate');
/*!40000 ALTER TABLE `beneficiaries` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campaign`
--

DROP TABLE IF EXISTS `campaign`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `campaign` (
  `CampaignID` int NOT NULL AUTO_INCREMENT,
  `CampaignName` varchar(100) DEFAULT NULL,
  `Description` text,
  PRIMARY KEY (`CampaignID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campaign`
--

LOCK TABLES `campaign` WRITE;
/*!40000 ALTER TABLE `campaign` DISABLE KEYS */;
INSERT INTO `campaign` VALUES (1,'Rash','dgjfghjr'),(2,'Winter Relief','Warm clothes and blankets'),(3,'Education Drive','School supplies and tutoring'),(4,'Medical Aid','Free clinics and medicines'),(5,'Ramadan Ration','Food for needy families'),(6,'Widow Support','Financial help for widows'),(7,'Orphan Education','Tuition for orphans'),(8,'Blood Donation','Blood drives for hospitals'),(9,'Disaster Response','Relief in emergencies'),(10,'Back to School','Backpacks and uniforms'),(11,'Clean Water','Water filter distribution');
/*!40000 ALTER TABLE `campaign` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campaigncycle`
--

DROP TABLE IF EXISTS `campaigncycle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `campaigncycle` (
  `CampaignCycleID` int NOT NULL AUTO_INCREMENT,
  `CampaignMonth` enum('January','February','March','April','May','June','July','August','September','October','November','December') DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `EditionID` int DEFAULT NULL,
  `CampaignID` int DEFAULT NULL,
  `IsActive` enum('Active','Expired') DEFAULT NULL,
  PRIMARY KEY (`CampaignCycleID`),
  KEY `EditionID` (`EditionID`),
  KEY `CampaignID` (`CampaignID`),
  CONSTRAINT `campaigncycle_ibfk_1` FOREIGN KEY (`EditionID`) REFERENCES `edition` (`EditionID`),
  CONSTRAINT `campaigncycle_ibfk_2` FOREIGN KEY (`CampaignID`) REFERENCES `campaign` (`CampaignID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campaigncycle`
--

LOCK TABLES `campaigncycle` WRITE;
/*!40000 ALTER TABLE `campaigncycle` DISABLE KEYS */;
INSERT INTO `campaigncycle` VALUES (1,'May','2025-05-12','2025-05-12',1,1,'Active'),(2,'January','2024-01-01','2024-01-31',5,1,'Expired'),(3,'February','2024-02-01','2024-02-28',5,2,'Expired'),(4,'March','2024-03-01','2024-03-31',5,3,'Active'),(5,'April','2024-04-01','2024-04-30',5,4,'Active'),(6,'May','2024-05-01','2024-05-31',5,5,'Active'),(7,'June','2024-06-01','2024-06-30',5,6,'Active'),(8,'July','2024-07-01','2024-07-31',5,7,'Active'),(9,'August','2024-08-01','2024-08-31',5,8,'Active'),(10,'September','2024-09-01','2024-09-30',5,9,'Active'),(11,'October','2024-10-01','2024-10-31',5,10,'Active');
/*!40000 ALTER TABLE `campaigncycle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donation`
--

DROP TABLE IF EXISTS `donation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donation` (
  `DonationID` int NOT NULL AUTO_INCREMENT,
  `DonorID` int DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT NULL,
  `Donation_Date` date DEFAULT NULL,
  `CampaignCycleID` int DEFAULT NULL,
  PRIMARY KEY (`DonationID`),
  KEY `DonorID` (`DonorID`),
  KEY `CampaignCycleID` (`CampaignCycleID`),
  CONSTRAINT `donation_ibfk_1` FOREIGN KEY (`DonorID`) REFERENCES `donor` (`DonorID`),
  CONSTRAINT `donation_ibfk_2` FOREIGN KEY (`CampaignCycleID`) REFERENCES `campaigncycle` (`CampaignCycleID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donation`
--

LOCK TABLES `donation` WRITE;
/*!40000 ALTER TABLE `donation` DISABLE KEYS */;
INSERT INTO `donation` VALUES (1,1,37.00,'2025-05-12',1),(2,1,100.00,'2025-01-10',1),(3,2,250.50,'2025-02-15',2),(4,3,300.00,'2025-03-05',3),(5,4,150.75,'2025-01-20',1),(6,5,500.00,'2025-04-12',4),(7,6,75.00,'2025-02-28',2),(8,7,200.00,'2025-03-18',5),(9,8,325.25,'2025-05-01',6),(10,9,400.00,'2025-03-25',3),(11,10,125.00,'2025-04-10',4),(12,11,600.00,'2025-05-15',7),(13,12,80.00,'2025-01-30',8),(14,13,275.00,'2025-03-22',9),(15,14,350.50,'2025-02-14',10),(16,15,420.00,'2025-04-05',11);
/*!40000 ALTER TABLE `donation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donationbeneficiary`
--

DROP TABLE IF EXISTS `donationbeneficiary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donationbeneficiary` (
  `DonationBeneficiaryID` int NOT NULL AUTO_INCREMENT,
  `BeneficiaryID` int DEFAULT NULL,
  `DonationDate` date DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT NULL,
  `BeneficiaryType` enum('Orphan','Widow','Disabled','Needy') DEFAULT NULL,
  `CampaignCycleID` int DEFAULT NULL,
  PRIMARY KEY (`DonationBeneficiaryID`),
  KEY `CampaignCycleID` (`CampaignCycleID`),
  KEY `BeneficiaryID` (`BeneficiaryID`),
  CONSTRAINT `donationbeneficiary_ibfk_1` FOREIGN KEY (`CampaignCycleID`) REFERENCES `campaigncycle` (`CampaignCycleID`),
  CONSTRAINT `donationbeneficiary_ibfk_2` FOREIGN KEY (`BeneficiaryID`) REFERENCES `beneficiaries` (`BeneficiaryID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donationbeneficiary`
--

LOCK TABLES `donationbeneficiary` WRITE;
/*!40000 ALTER TABLE `donationbeneficiary` DISABLE KEYS */;
INSERT INTO `donationbeneficiary` VALUES (16,2,'2025-01-20',200.00,'Widow',2),(17,3,'2025-02-10',175.50,'Disabled',3),(18,4,'2025-02-25',220.00,'Needy',4),(19,5,'2025-03-05',190.75,'Orphan',5),(20,6,'2025-03-18',210.00,'Widow',6),(21,7,'2025-04-01',250.00,'Disabled',7),(22,8,'2025-04-15',160.00,'Needy',8),(23,9,'2025-04-25',180.00,'Orphan',9),(24,10,'2025-05-05',230.00,'Widow',10),(25,11,'2025-05-20',195.00,'Disabled',11),(26,12,'2025-06-01',210.00,'Needy',1),(27,13,'2025-06-10',175.00,'Orphan',2),(28,14,'2025-06-18',205.00,'Widow',3),(29,15,'2025-07-01',225.00,'Disabled',4);
/*!40000 ALTER TABLE `donationbeneficiary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donor`
--

DROP TABLE IF EXISTS `donor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donor` (
  `DonorID` int NOT NULL AUTO_INCREMENT,
  `DonorName` varchar(100) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `City` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`DonorID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donor`
--

LOCK TABLES `donor` WRITE;
/*!40000 ALTER TABLE `donor` DISABLE KEYS */;
INSERT INTO `donor` VALUES (1,'Fatima',NULL,NULL,NULL),(2,'Ahmed Raza','ahmed.raza@example.com','03001234567','Lahore'),(3,'Fatima Noor','fatima.noor@example.com','03111234567','Karachi'),(4,'Bilal Hassan','bilal.hassan@example.com','03221234567','Islamabad'),(5,'Ayesha Siddiqui','ayesha.sid@example.com','03331234567','Peshawar'),(6,'Zain Ali','zain.ali@example.com','03441234567','Quetta'),(7,'Rabia Khan','rabia.khan@example.com','03551234567','Multan'),(8,'Usman Tariq','usman.tariq@example.com','03661234567','Sialkot'),(9,'Sana Javed','sana.javed@example.com','03771234567','Hyderabad'),(10,'Imran Sheikh','imran.sheikh@example.com','03881234567','Faisalabad'),(11,'Mehwish Gul','mehwish.gul@example.com','03991234567','Rawalpindi'),(12,'Ali Hamza','ali.hamza@example.com','03011234568','Gujranwala'),(13,'Nadia Mir','nadia.mir@example.com','03121234568','Bahawalpur'),(14,'Kashif Mehmood','kashif.mehmood@example.com','03231234568','Sargodha'),(15,'Hina Shah','hina.shah@example.com','03341234568','Abbottabad'),(16,'Shahbaz Ali','shahbaz.ali@example.com','03451234568','Sukkur'),(17,'Areesha Shareef',NULL,NULL,NULL);
/*!40000 ALTER TABLE `donor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `edition`
--

DROP TABLE IF EXISTS `edition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `edition` (
  `EditionID` int NOT NULL AUTO_INCREMENT,
  `Year` year DEFAULT NULL,
  `Description` text,
  PRIMARY KEY (`EditionID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edition`
--

LOCK TABLES `edition` WRITE;
/*!40000 ALTER TABLE `edition` DISABLE KEYS */;
INSERT INTO `edition` VALUES (1,2024,NULL),(2,2020,'Pilot Edition'),(3,2021,'Expansion to new cities'),(4,2022,'Added medical support'),(5,2023,'Education focus'),(6,2024,'Nationwide reach'),(7,2025,'Digital platform launch');
/*!40000 ALTER TABLE `edition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `event`
--

DROP TABLE IF EXISTS `event`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `event` (
  `EventID` int NOT NULL AUTO_INCREMENT,
  `EventName` varchar(100) DEFAULT NULL,
  `EventDate` date DEFAULT NULL,
  `EditionID` int DEFAULT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `CategoryID` int DEFAULT NULL,
  PRIMARY KEY (`EventID`),
  KEY `CategoryID` (`CategoryID`),
  KEY `EditionID` (`EditionID`),
  CONSTRAINT `event_ibfk_1` FOREIGN KEY (`CategoryID`) REFERENCES `eventcategory` (`CategoryID`),
  CONSTRAINT `event_ibfk_2` FOREIGN KEY (`EditionID`) REFERENCES `edition` (`EditionID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event`
--

LOCK TABLES `event` WRITE;
/*!40000 ALTER TABLE `event` DISABLE KEYS */;
INSERT INTO `event` VALUES (1,'Event','2024-03-04',1,'jj',1),(3,'Annual Charity Gala','2025-06-15',1,'Grand Hall, City Center',1),(4,'Spring Fundraiser','2025-04-22',2,'Central Park',2),(5,'Health Awareness Walk','2025-07-10',1,'Riverfront Park',3),(6,'Tech for Good Conference','2025-08-01',3,'Convention Center',4),(7,'Holiday Toy Drive','2025-12-10',4,'Mall of the City',2),(8,'Community Cooking Class','2025-05-05',2,'Community Center',5),(9,'Art for Charity Auction','2025-11-13',3,'City Art Museum',1),(10,'Charity Bike Ride','2025-06-28',4,'Downtown Park',3);
/*!40000 ALTER TABLE `event` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eventcategory`
--

DROP TABLE IF EXISTS `eventcategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `eventcategory` (
  `CategoryID` int NOT NULL AUTO_INCREMENT,
  `CategoryName` varchar(50) DEFAULT NULL,
  `Description` text,
  PRIMARY KEY (`CategoryID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eventcategory`
--

LOCK TABLES `eventcategory` WRITE;
/*!40000 ALTER TABLE `eventcategory` DISABLE KEYS */;
INSERT INTO `eventcategory` VALUES (1,'category',''),(2,'Health Camp','Free medical checkups and health awareness activities'),(3,'Education Seminar','Workshops and lectures focused on educational topics'),(4,'Fundraiser','Events organized to raise funds for various campaigns'),(5,'Volunteer Training','Training sessions for new and existing volunteers'),(6,'Food Drive','Collecting and distributing food to the needy'),(7,'Awareness Walk','Public walks to raise awareness about social issues'),(8,'Community Meetup','Events for interacting with local community members'),(9,'Clothing Drive','Collecting clothes for distribution to the underprivileged'),(10,'Blood Donation','Organizing and managing blood donation camps'),(11,'Career Guidance','Helping youths with career and academic planning'),(12,'Cultural Program','Events to promote local culture and talents'),(13,'Cleanliness Drive','Community clean-up initiatives and awareness'),(14,'Youth Summit','Engagement sessions for young leaders and change-makers'),(15,'Mental Health Workshop','Raising awareness about mental health and coping skills'),(16,'Disaster Relief Briefing','Preparedness training and information sessions');
/*!40000 ALTER TABLE `eventcategory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expense`
--

DROP TABLE IF EXISTS `expense`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `expense` (
  `ExpenseID` int NOT NULL AUTO_INCREMENT,
  `ExpenseCategory` enum('Transport','Food','Venue','Equipment','Utilities') DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT NULL,
  `PaidTo` varchar(100) DEFAULT NULL,
  `PaymentDate` date DEFAULT NULL,
  `Description` text,
  `EventID` int DEFAULT NULL,
  PRIMARY KEY (`ExpenseID`),
  KEY `EventID` (`EventID`),
  CONSTRAINT `expense_ibfk_1` FOREIGN KEY (`EventID`) REFERENCES `event` (`EventID`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expense`
--

LOCK TABLES `expense` WRITE;
/*!40000 ALTER TABLE `expense` DISABLE KEYS */;
INSERT INTO `expense` VALUES (1,'Venue',347.00,'renter','2025-05-12','jheh',1),(40,'Transport',150.00,'City Cabs Ltd.','2025-04-01','Shuttle service for volunteers',1),(41,'Venue',1200.00,'Community Hall','2025-04-03','Event venue booking',3),(42,'Equipment',450.75,'Tech Supplies Co.','2025-04-04','Sound system and projector rental',4),(43,'Utilities',90.00,'Local Utilities Board','2025-04-05','Electricity charges for event',5),(44,'Transport',220.00,'Rapid Transit Services','2025-04-06','Volunteer pickup service',6),(45,'Food',180.25,'Bistro Meals','2025-04-07','Dinner for guest speakers',7),(46,'Venue',950.00,'Town Conference Center','2025-04-08','Hall rental for workshop',8),(47,'Equipment',310.60,'Event Rentals Inc.','2025-04-09','Lighting and stage setup',9),(48,'Utilities',75.80,'EnergyPlus','2025-04-10','Water and power for the day',10);
/*!40000 ALTER TABLE `expense` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `feedback`
--

DROP TABLE IF EXISTS `feedback`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `feedback` (
  `FeedbackID` int NOT NULL AUTO_INCREMENT,
  `SubmittedByRole` enum('Lead','Volunteer') NOT NULL,
  `CampaignCycleID` int DEFAULT NULL,
  `UserID` int NOT NULL,
  `FeedbackText` text NOT NULL,
  `Rating` int DEFAULT NULL,
  `SubmissionDate` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`FeedbackID`),
  KEY `CampaignCycleID` (`CampaignCycleID`),
  KEY `UserID` (`UserID`),
  CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`CampaignCycleID`) REFERENCES `campaigncycle` (`CampaignCycleID`),
  CONSTRAINT `feedback_ibfk_2` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  CONSTRAINT `feedback_chk_1` CHECK ((`Rating` between 1 and 5))
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `feedback`
--

LOCK TABLES `feedback` WRITE;
/*!40000 ALTER TABLE `feedback` DISABLE KEYS */;
INSERT INTO `feedback` VALUES (3,'Lead',1,1,'Great organization and well-managed resources.',5,'2025-05-13 10:37:14'),(4,'Volunteer',1,2,'It was a good experience working with the team.',4,'2025-05-13 10:37:14'),(5,'Volunteer',2,3,'Faced some logistical issues but managed well.',3,'2025-05-13 10:37:14'),(6,'Lead',2,4,'Everything went according to plan.',5,'2025-05-13 10:37:14'),(7,'Volunteer',3,5,'Need better coordination among volunteers.',3,'2025-05-13 10:37:14'),(8,'Volunteer',3,6,'Enjoyed helping out and learned a lot.',4,'2025-05-13 10:37:14'),(9,'Lead',4,7,'Need more time for preparation next time.',3,'2025-05-13 10:37:14'),(10,'Volunteer',4,8,'Loved the energy and dedication of everyone.',5,'2025-05-13 10:37:14'),(11,'Volunteer',5,9,'Good communication and timely support.',4,'2025-05-13 10:37:14'),(12,'Lead',5,10,'Could improve task assignment clarity.',3,'2025-05-13 10:37:14');
/*!40000 ALTER TABLE `feedback` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Role` enum('Head','Lead','Member') DEFAULT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'yusra2','0333-4436367','1234yusra','yusra@gmail.com','Head'),(2,'laiba3','0334-3435454','laibatariq8','laiba@gmail.com','Member'),(3,'admin','03001234567','pass1','admin@example.com','Head'),(4,'lead1','03111234567','pass2','lead1@example.com','Lead'),(5,'vol1','03221234567','pass3','vol1@example.com','Member'),(6,'vol2','03331234567','pass4','vol2@example.com','Member'),(7,'vol3','03441234567','pass5','vol3@example.com','Member'),(8,'vol4','03551234567','pass6','vol4@example.com','Member'),(9,'vol5','03661234567','pass7','vol5@example.com','Member'),(10,'lead2','03771234567','pass8','lead2@example.com','Lead'),(11,'vol6','03881234567','pass9','vol6@example.com','Member'),(12,'vol7','03991234567','pass10','vol7@example.com','Member'),(15,'alice_johnson','345-678-9012','hashed_pw_3','alice@example.com','Member'),(16,'bob_williams','456-789-0123','hashed_pw_4','bob@example.com','Member'),(17,'charlie_brown','567-890-1234','hashed_pw_5','charlie@example.com','Lead'),(19,'eve_miller','789-012-3456','hashed_pw_7','diana@eample.com','Member'),(20,'frank_thomas','890-123-4567','hashed_pw_8','frank@example.com','Member'),(21,'grace_lee','901-234-5678','hashed_pw_9','grace@example.com','Lead'),(26,'yusra','0323-0473892','12h83833','syusra77@gmail.com','Head');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `view_beneficiaryaid`
--

DROP TABLE IF EXISTS `view_beneficiaryaid`;
/*!50001 DROP VIEW IF EXISTS `view_beneficiaryaid`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_beneficiaryaid` AS SELECT 
 1 AS `FullName`,
 1 AS `Amount`,
 1 AS `BeneficiaryType`,
 1 AS `CampaignMonth`,
 1 AS `DonationDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_campaigncyclevolunteers`
--

DROP TABLE IF EXISTS `view_campaigncyclevolunteers`;
/*!50001 DROP VIEW IF EXISTS `view_campaigncyclevolunteers`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_campaigncyclevolunteers` AS SELECT 
 1 AS `CampaignName`,
 1 AS `CampaignMonth`,
 1 AS `FullName`,
 1 AS `JoinDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_eventdetails`
--

DROP TABLE IF EXISTS `view_eventdetails`;
/*!50001 DROP VIEW IF EXISTS `view_eventdetails`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_eventdetails` AS SELECT 
 1 AS `EventName`,
 1 AS `EventDate`,
 1 AS `Location`,
 1 AS `CategoryName`,
 1 AS `Year`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `volunteer`
--

DROP TABLE IF EXISTS `volunteer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `volunteer` (
  `VolunteerID` int NOT NULL AUTO_INCREMENT,
  `FullName` varchar(100) DEFAULT NULL,
  `JoinDate` date DEFAULT NULL,
  `UserID` int DEFAULT NULL,
  `RequestStatus` enum('Pending','Accepted','Rejected') DEFAULT 'Pending',
  PRIMARY KEY (`VolunteerID`),
  UNIQUE KEY `UserID` (`UserID`),
  CONSTRAINT `volunteer_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=135 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `volunteer`
--

LOCK TABLES `volunteer` WRITE;
/*!40000 ALTER TABLE `volunteer` DISABLE KEYS */;
INSERT INTO `volunteer` VALUES (130,'John Carter','2025-05-01',1,'Accepted'),(131,'Samantha Reyes','2025-05-02',2,'Pending'),(132,'Michael Liu','2025-05-03',3,'Pending'),(133,'Priya Desai','2025-05-04',4,'Pending'),(134,'Leo Martinez','2025-05-05',5,'Rejected');
/*!40000 ALTER TABLE `volunteer` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `SetDefaultStatusBeforeInsert` BEFORE INSERT ON `volunteer` FOR EACH ROW BEGIN
    SET NEW.RequestStatus = 'Pending';
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `volunteercampaigncycle`
--

DROP TABLE IF EXISTS `volunteercampaigncycle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `volunteercampaigncycle` (
  `VolunteerID` int NOT NULL,
  `CampaignCycleID` int NOT NULL,
  PRIMARY KEY (`VolunteerID`,`CampaignCycleID`),
  KEY `CampaignCycleID` (`CampaignCycleID`),
  CONSTRAINT `volunteercampaigncycle_ibfk_1` FOREIGN KEY (`VolunteerID`) REFERENCES `volunteer` (`VolunteerID`),
  CONSTRAINT `volunteercampaigncycle_ibfk_2` FOREIGN KEY (`CampaignCycleID`) REFERENCES `campaigncycle` (`CampaignCycleID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `volunteercampaigncycle`
--

LOCK TABLES `volunteercampaigncycle` WRITE;
/*!40000 ALTER TABLE `volunteercampaigncycle` DISABLE KEYS */;
INSERT INTO `volunteercampaigncycle` VALUES (130,1),(131,1),(133,2),(134,2),(132,3),(134,3),(133,5);
/*!40000 ALTER TABLE `volunteercampaigncycle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `volunteertask`
--

DROP TABLE IF EXISTS `volunteertask`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `volunteertask` (
  `TaskID` int NOT NULL AUTO_INCREMENT,
  `VolunteerID` int DEFAULT NULL,
  `AssignedBy` int DEFAULT NULL,
  `TaskTitle` varchar(100) DEFAULT NULL,
  `TaskDescription` text,
  `Status` enum('Pending','In-Progress','Completed') DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `Deadline` date DEFAULT NULL,
  PRIMARY KEY (`TaskID`),
  KEY `VolunteerID` (`VolunteerID`),
  KEY `AssignedBy` (`AssignedBy`),
  CONSTRAINT `volunteertask_ibfk_1` FOREIGN KEY (`VolunteerID`) REFERENCES `volunteer` (`VolunteerID`),
  CONSTRAINT `volunteertask_ibfk_2` FOREIGN KEY (`AssignedBy`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `volunteertask`
--

LOCK TABLES `volunteertask` WRITE;
/*!40000 ALTER TABLE `volunteertask` DISABLE KEYS */;
INSERT INTO `volunteertask` VALUES (7,130,2,'Set Up Chairs','Arrange chairs at the event venue before the guests arrive.','Pending','2025-05-06','2025-05-07'),(8,131,1,'Manage Registration','Assist guests with event registration at the entrance.','In-Progress','2025-05-06','2025-05-08'),(9,133,4,'Distribute Flyers','Hand out flyers in the neighborhood for awareness.','Completed','2025-05-04','2025-05-06'),(10,134,5,'Coordinate Refreshments','Ensure food and drinks are available and properly arranged.','Pending','2025-05-07','2025-05-09'),(11,132,3,'Clean Up','Help clean up the venue after the event.','In-Progress','2025-05-08','2025-05-10');
/*!40000 ALTER TABLE `volunteertask` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_insert_volunteertask` BEFORE INSERT ON `volunteertask` FOR EACH ROW BEGIN
    SET NEW.Status = 'Pending';
    SET NEW.StartDate = CURDATE();
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Dumping events for database 'pp'
--

--
-- Dumping routines for database 'pp'
--
/*!50003 DROP PROCEDURE IF EXISTS `GetVolunteerTasksByName` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetVolunteerTasksByName`(IN volunteerName VARCHAR(100))
BEGIN SELECT v.FullName AS Volunteer, vt.TaskTitle, vt.TaskDescription, vt.Status, vt.StartDate, vt.Deadline, u.Username AS AssignedBy FROM VolunteerTask vt JOIN Volunteer v ON vt.VolunteerID = v.VolunteerID JOIN Users u ON vt.AssignedBy = u.UserID WHERE v.FullName = volunteerName; END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `view_beneficiaryaid`
--

/*!50001 DROP VIEW IF EXISTS `view_beneficiaryaid`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_beneficiaryaid` AS select `b`.`FullName` AS `FullName`,`db`.`Amount` AS `Amount`,`db`.`BeneficiaryType` AS `BeneficiaryType`,`cc`.`CampaignMonth` AS `CampaignMonth`,`db`.`DonationDate` AS `DonationDate` from ((`donationbeneficiary` `db` join `beneficiaries` `b` on((`db`.`BeneficiaryID` = `b`.`BeneficiaryID`))) join `campaigncycle` `cc` on((`db`.`CampaignCycleID` = `cc`.`CampaignCycleID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_campaigncyclevolunteers`
--

/*!50001 DROP VIEW IF EXISTS `view_campaigncyclevolunteers`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_campaigncyclevolunteers` AS select `c`.`CampaignName` AS `CampaignName`,`cc`.`CampaignMonth` AS `CampaignMonth`,`v`.`FullName` AS `FullName`,`v`.`JoinDate` AS `JoinDate` from (((`volunteercampaigncycle` `vcc` join `volunteer` `v` on((`vcc`.`VolunteerID` = `v`.`VolunteerID`))) join `campaigncycle` `cc` on((`vcc`.`CampaignCycleID` = `cc`.`CampaignCycleID`))) join `campaign` `c` on((`cc`.`CampaignID` = `c`.`CampaignID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_eventdetails`
--

/*!50001 DROP VIEW IF EXISTS `view_eventdetails`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_eventdetails` AS select `event`.`EventName` AS `EventName`,`event`.`EventDate` AS `EventDate`,`event`.`Location` AS `Location`,`eventcategory`.`CategoryName` AS `CategoryName`,`edition`.`Year` AS `Year` from ((`event` join `eventcategory` on((`event`.`CategoryID` = `eventcategory`.`CategoryID`))) join `edition` on((`event`.`EditionID` = `edition`.`EditionID`))) */;
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

-- Dump completed on 2025-09-01  5:56:02

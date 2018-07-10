CREATE DATABASE  IF NOT EXISTS `manila_atlantic_booking_system` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `manila_atlantic_booking_system`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: manila_atlantic_booking_system
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.10-MariaDB

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
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admin` (
  `admin_no` int(6) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `username` varchar(30) NOT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`admin_no`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES (000001,'admin','admin');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aircraft`
--

DROP TABLE IF EXISTS `aircraft`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aircraft` (
  `aircraft_cd` char(5) NOT NULL,
  `aircraft_type` varchar(20) NOT NULL,
  `capacity` int(3) NOT NULL,
  `status` char(1) NOT NULL,
  PRIMARY KEY (`aircraft_cd`),
  UNIQUE KEY `aircraft_cd_UNIQUE` (`aircraft_cd`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aircraft`
--

LOCK TABLES `aircraft` WRITE;
/*!40000 ALTER TABLE `aircraft` DISABLE KEYS */;
INSERT INTO `aircraft` VALUES ('CJ004','toyota air',250,'R'),('CJ005','toyota air',250,'A'),('CJ006','toyota air',250,'A'),('ER889','iAirplane',250,'A'),('ER890','iAirplane',250,'R'),('JA033','myplane',150,'A'),('JA034','myplane',150,'R'),('JB901','windowsky',200,'A'),('JB902','windowsky',200,'A'),('KC001','samsung jet',300,'A');
/*!40000 ALTER TABLE `aircraft` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer` (
  `cust_no` int(5) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `username` varchar(30) DEFAULT NULL,
  `password` varchar(20) DEFAULT NULL,
  `title` varchar(4) NOT NULL,
  `gvn_name` varchar(20) NOT NULL,
  `fam_name` varchar(20) NOT NULL,
  `mob_no` int(11) NOT NULL,
  `alt_mob` int(11) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`cust_no`),
  UNIQUE KEY `cust_no_UNIQUE` (`cust_no`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (00001,'joche','12joch','Ms.','Joanne','Chong',2147483647,2147483647,NULL),(00002,NULL,NULL,'Mr.','Kyle','Chua',2147483647,2147483647,'kyle@yahoo.com'),(00003,NULL,NULL,'Mr.','Janz','Villamayor',2147483647,2147483647,'jan@gmail.com'),(00004,'justg23','gj999','Mr.','Glen ','Justice',2147483647,2147483647,NULL),(00005,'lhite','wowow','Ms.','Lydia ','White',2147483647,2147483647,'lhite@mail.com'),(00006,'stacy1','nhguav','Mrs.','Stacy ','Vaughn',2147483647,2147483647,'stacy@ymail.com'),(00007,'nknk','050716','Ms.','Norma ','Kramer',2147483647,2147483647,NULL),(00008,NULL,NULL,'Ms.','Kathy ','Erickson',2147483647,2147483647,'k.erickson@gmail.com'),(00009,'mcsergio','squirtle','Mr.','Sergio ','McKnight',2147483647,2147483647,'serge@mail.com'),(00010,NULL,NULL,'Mrs.','Lynn ','Byers',2147483647,2147483647,'lynnb@yahoo.com');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flight`
--

DROP TABLE IF EXISTS `flight`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flight` (
  `flight_no` int(6) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `etd` int(4) unsigned zerofill NOT NULL,
  `eta` int(4) unsigned zerofill NOT NULL,
  `orgn` char(3) NOT NULL,
  `destination` char(3) NOT NULL,
  `date_added` date NOT NULL,
  PRIMARY KEY (`flight_no`),
  UNIQUE KEY `flight_no_UNIQUE` (`flight_no`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flight`
--

LOCK TABLES `flight` WRITE;
/*!40000 ALTER TABLE `flight` DISABLE KEYS */;
INSERT INTO `flight` VALUES (000001,0100,0230,'SYD','JAP','2015-12-31'),(000002,1000,1200,'MNL','JAP','2015-08-11'),(000003,1415,1610,'MIA','MNL','2016-01-10'),(000004,2210,0120,'KOR','MIA','2016-01-24'),(000005,0100,0230,'GUM','MIA','2016-01-24'),(000006,0300,0430,'HKG','JAP','2015-02-20'),(000007,0400,0500,'PEK','JAP','2015-02-24'),(000008,0500,0600,'SIN','MNL','2015-05-27'),(000009,1000,1130,'PER','MNL','2015-11-12'),(000010,1100,1200,'JAP','KOR','2015-11-04');
/*!40000 ALTER TABLE `flight` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flightinstance`
--

DROP TABLE IF EXISTS `flightinstance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flightinstance` (
  `instance_no` int(6) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `dep_date` date NOT NULL,
  `status` char(1) NOT NULL,
  `price` float NOT NULL,
  `date_add` date NOT NULL,
  `aircraft_cd` char(5) NOT NULL,
  `available` int(3) NOT NULL,
  `flgt_no` int(6) unsigned zerofill NOT NULL,
  PRIMARY KEY (`instance_no`),
  UNIQUE KEY `instance_no_UNIQUE` (`instance_no`)
) ENGINE=InnoDB AUTO_INCREMENT=92753 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flightinstance`
--

LOCK TABLES `flightinstance` WRITE;
/*!40000 ALTER TABLE `flightinstance` DISABLE KEYS */;
INSERT INTO `flightinstance` VALUES (011752,'2016-10-03','A',5666.6,'2016-02-16','ER889',12,000006),(035823,'2016-03-14','F',3613.49,'2016-01-24','KC001',29,000004),(039633,'2016-03-21','A',1261.99,'0000-00-00','KC001',109,000005),(042572,'2016-04-01','O',2736.5,'2015-08-11','CJ005',0,000002),(045824,'2016-03-14','C',3613.49,'2016-01-24','CJ006',2,000010),(071852,'2016-11-12','A',2446,'2016-02-16','JA034',57,000008),(082492,'2016-08-03','C',5126.99,'2016-01-10','JB901',250,000003),(082762,'2016-03-01','A',9000.5,'2016-02-16','JB902',25,000009),(091751,'2016-09-01','C',2555,'2015-12-31','ER889',250,000001),(092752,'2016-10-03','A',4400.35,'2016-02-16','ER890',123,000007);
/*!40000 ALTER TABLE `flightinstance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lineitems`
--

DROP TABLE IF EXISTS `lineitems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lineitems` (
  `quantity` int(2) NOT NULL,
  `instance_no` int(5) unsigned zerofill NOT NULL,
  `subtotal` float unsigned NOT NULL,
  `trans_no` int(8) unsigned zerofill NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lineitems`
--

LOCK TABLES `lineitems` WRITE;
/*!40000 ALTER TABLE `lineitems` DISABLE KEYS */;
INSERT INTO `lineitems` VALUES (4,39633,5047.96,12345678),(2,42572,5473,19191919),(2,82492,10254,19191919),(4,42572,10946,12345678),(1,72472,11473,11113333),(4,35823,14450,12345678),(5,45492,15000,23235353),(4,82455,15473,19191919),(3,91751,19800,06665652),(5,56497,31353,34442342);
/*!40000 ALTER TABLE `lineitems` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `location`
--

DROP TABLE IF EXISTS `location`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `location` (
  `loc_cd` char(3) NOT NULL,
  `name` varchar(20) NOT NULL,
  `airport` varchar(30) NOT NULL,
  PRIMARY KEY (`loc_cd`),
  UNIQUE KEY `loc_cd_UNIQUE` (`loc_cd`),
  UNIQUE KEY `name_UNIQUE` (`name`),
  UNIQUE KEY `airport_UNIQUE` (`airport`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `location`
--

LOCK TABLES `location` WRITE;
/*!40000 ALTER TABLE `location` DISABLE KEYS */;
INSERT INTO `location` VALUES ('GUM','Guam','A. B. Won Pat International Ai'),('HKG','Hong Kong','Hong Kong International Airpor'),('JAP','Japan','Japan Airport'),('KOR','Korea','Seoul Terminal'),('MIA','Miami','Florida Station'),('MNL','Manila','NAIA'),('PEK','Beijing','Beijing Capital Ineternational'),('PER','Perth','Perth Airport'),('SIN','Singapore','Singapore Changi Airport'),('SYD','Sydney','Sydney Port');
/*!40000 ALTER TABLE `location` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transaction` (
  `trans_no` int(8) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `cust_no` int(5) unsigned zerofill NOT NULL,
  `date` date NOT NULL,
  `total` float NOT NULL,
  PRIMARY KEY (`trans_no`),
  UNIQUE KEY `trans_no_UNIQUE` (`trans_no`)
) ENGINE=InnoDB AUTO_INCREMENT=33961031 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction`
--

LOCK TABLES `transaction` WRITE;
/*!40000 ALTER TABLE `transaction` DISABLE KEYS */;
INSERT INTO `transaction` VALUES (00000151,00001,'2016-02-14',19800),(06665652,00002,'2016-02-15',5005.5),(12345678,00001,'2016-02-14',30443.9),(12756959,00006,'2016-04-11',34555.7),(13766039,00009,'2016-07-17',6788.5),(19191919,00001,'2016-02-14',15727),(22655949,00003,'2016-01-28',97860.3),(22857969,00009,'2016-07-11',7755),(23005040,00007,'2016-01-12',23345.5),(23665040,00005,'2016-07-28',34422),(33031431,00004,'2016-03-08',5552),(33961030,00008,'2016-04-03',6664.25);
/*!40000 ALTER TABLE `transaction` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-04-07 19:36:45

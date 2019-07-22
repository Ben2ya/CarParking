-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2017-03-28 12:59:52
-- --------------------------------------
-- Server version 10.1.10-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of carparkingservices
-- 

DROP TABLE IF EXISTS `carparkingservices`;
CREATE TABLE IF NOT EXISTS `carparkingservices` (
  `Carplate` text NOT NULL,
  `CarModel` text NOT NULL,
  `Color` text NOT NULL,
  `DateTime` text NOT NULL,
  `Service` text NOT NULL,
  `Charges` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table carparkingservices
-- 

/*!40000 ALTER TABLE `carparkingservices` DISABLE KEYS */;
INSERT INTO `carparkingservices`(`Carplate`,`CarModel`,`Color`,`DateTime`,`Service`,`Charges`) VALUES
('KBX','PREMIO','Brown','23/03/2017','Parking2','200'),
('KBX','PREMIO','Brown','23/03/2017','Parking2','200'),
('KBC','TOYOTA SUPER DELUXE','Black','23/03/2017','Parking2','200'),
('KBC','TOYOTA SUPER DELUXE','Black','23/03/2017','Parking2','200'),
('KBC','TOYOTA SUPER DELUXE','Black','23/03/2017','Car Repair','3000'),
('KBC','TOYOTA SUPER DELUXE','Black','23/03/2017','Pressure Filling','250');
/*!40000 ALTER TABLE `carparkingservices` ENABLE KEYS */;

-- 
-- Definition of details
-- 

DROP TABLE IF EXISTS `details`;
CREATE TABLE IF NOT EXISTS `details` (
  `Carplate` text NOT NULL,
  `Carmodel` text NOT NULL,
  `Color` text NOT NULL,
  `OwnerName` text NOT NULL,
  `Telephone` text NOT NULL,
  `DatTime` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table details
-- 

/*!40000 ALTER TABLE `details` DISABLE KEYS */;
INSERT INTO `details`(`Carplate`,`Carmodel`,`Color`,`OwnerName`,`Telephone`,`DatTime`) VALUES
('KAA 212K','CORROLA','WHITE','FELIX','100','Monday, March 20, 2017'),
('KBX','PREMIO','Brown','Samuel Maina','07390139131','Tuesday, March 21, 2017'),
('KBC','TOYOTA SUPER DELUXE','Black','Samson Weng','07390139131342','Tuesday, March 21, 2017');
/*!40000 ALTER TABLE `details` ENABLE KEYS */;

-- 
-- Definition of login
-- 

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `Username` text,
  `Password` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table login
-- 

/*!40000 ALTER TABLE `login` DISABLE KEYS */;

/*!40000 ALTER TABLE `login` ENABLE KEYS */;

-- 
-- Definition of parkingslots
-- 

DROP TABLE IF EXISTS `parkingslots`;
CREATE TABLE IF NOT EXISTS `parkingslots` (
  `ParkingSlot` text NOT NULL,
  `Amount` text NOT NULL,
  `Status` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table parkingslots
-- 

/*!40000 ALTER TABLE `parkingslots` DISABLE KEYS */;
INSERT INTO `parkingslots`(`ParkingSlot`,`Amount`,`Status`) VALUES
('Parking1','200','Available'),
('Parking2','200','Available'),
('Parking3','200','Available'),
('Parking4','200','Available'),
('Parking5','200','Available');
/*!40000 ALTER TABLE `parkingslots` ENABLE KEYS */;

-- 
-- Definition of services
-- 

DROP TABLE IF EXISTS `services`;
CREATE TABLE IF NOT EXISTS `services` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  `Amount` text NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table services
-- 

/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services`(`ID`,`Name`,`Amount`) VALUES
(1,'Car Wash','150'),
(2,'Maintainance','500'),
(3,'Change Oil','100'),
(4,'Pressure Filling','250'),
(5,'Car Repair','3000'),
(6,'Car Alignment','31000');
/*!40000 ALTER TABLE `services` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2017-03-28 12:59:53
-- Total time: 0:0:0:0:792 (d:h:m:s:ms)

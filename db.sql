-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.21-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping structure for table bilsemteknik.users
CREATE TABLE IF NOT EXISTS `users` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `UserFirstName` varchar(50) NOT NULL,
  `UserLastName` varchar(50) NOT NULL,
  `UserPhone` varchar(15) NOT NULL,
  `UserEmail` varchar(100) NOT NULL,
  `UserType` tinyint(4) NOT NULL,
  PRIMARY KEY (`UserId`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bilsemteknik.users: ~0 rows (approximately)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`UserId`, `UserFirstName`, `UserLastName`, `UserPhone`, `UserEmail`, `UserType`) VALUES
	(1, 'Bahadır', 'AKKÖY', '5423245841', 'bahadir.akkoy@gmail.com', 0);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Feb 06, 2024 at 10:44 PM
-- Server version: 8.0.29
-- PHP Version: 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `todoplanner`
--

-- --------------------------------------------------------

--
-- Table structure for table `obveze`
--

DROP TABLE IF EXISTS `obveze`;
CREATE TABLE IF NOT EXISTS `obveze` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `id_user` int NOT NULL,
  `Obveza` varchar(1000) CHARACTER SET utf32 COLLATE utf32_croatian_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_obveza_id_users` (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `obveze`
--

INSERT INTO `obveze` (`Id`, `id_user`, `Obveza`) VALUES
(4, 1, 'lalalala'),
(5, 1, 'lalalala'),
(6, 1, 'david'),
(7, 1, 'david'),
(8, 1, 'david'),
(9, 1, 'david'),
(10, 1, 'david'),
(11, 1, 'david'),
(12, 1, 'david');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `firstname` varchar(30) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `password`) VALUES
(1, 'Dino', 'Lukić', 'dino', 'dino'),
(2, 'David ', 'Soldatić', 'david', 'david'),
(4, 'Marko', 'Marić', 'Perić', 'marko'),
(6, 'Marko', 'Perković', 'markoperkovic', 'thompson'),
(7, 'david', 'davidovic', 'dad@123', '123');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `obveze`
--
ALTER TABLE `obveze`
  ADD CONSTRAINT `fk_obveza_id_users` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

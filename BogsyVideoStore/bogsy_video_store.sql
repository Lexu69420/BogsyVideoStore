-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 19, 2025 at 09:56 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bogsy_video_store`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer_tbl`
--

CREATE TABLE `customer_tbl` (
  `CustomerID` int(50) NOT NULL,
  `CustomerName` text NOT NULL,
  `Age` int(50) NOT NULL,
  `Gender` text NOT NULL,
  `ContactNumber` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer_tbl`
--

INSERT INTO `customer_tbl` (`CustomerID`, `CustomerName`, `Age`, `Gender`, `ContactNumber`, `Address`) VALUES
(1, 'LeBron James', 40, 'Male', '09184956237', 'Los Angeles, USA'),
(2, 'Lionel Messi', 37, 'Male', '09922512345', 'Sao Paulo, Argentina');

-- --------------------------------------------------------

--
-- Table structure for table `rental_tbl`
--

CREATE TABLE `rental_tbl` (
  `RentalID` int(50) NOT NULL,
  `CustomerID` int(50) NOT NULL,
  `VideoID` int(50) NOT NULL,
  `RentalDate` varchar(50) NOT NULL,
  `ReturnDate` varchar(50) NOT NULL,
  `Status` text NOT NULL,
  `TotalAmount` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rental_tbl`
--

INSERT INTO `rental_tbl` (`RentalID`, `CustomerID`, `VideoID`, `RentalDate`, `ReturnDate`, `Status`, `TotalAmount`) VALUES
(1, 1, 1, '2025-02-19', '2025-02-22', 'Rented', '150'),
(2, 2, 4, '2025-02-19 16:03:07.107995', '2025-02-22 16:03:07.105000', 'Rented', '150'),
(4, 1, 3, '2025-02-19 16:33:54.675556', '2025-02-21 16:33:54.672000', 'Returned', '25'),
(6, 1, 3, '2025-02-19 16:33:54.675556', '2025-02-23 16:33:54.672000', 'Returned', '75');

-- --------------------------------------------------------

--
-- Table structure for table `video_tbl`
--

CREATE TABLE `video_tbl` (
  `VideoID` int(50) NOT NULL,
  `Title` text NOT NULL,
  `Genre` text NOT NULL,
  `Category` text NOT NULL,
  `Price` varchar(50) NOT NULL,
  `Stocks` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `video_tbl`
--

INSERT INTO `video_tbl` (`VideoID`, `Title`, `Genre`, `Category`, `Price`, `Stocks`) VALUES
(1, 'Avengers', 'Action', 'DVD', '50', 4),
(3, 'Xmen', 'Action', 'VCD', '25', 7),
(4, 'Jujutsu Kaisen', 'Anime', 'DVD', '50', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer_tbl`
--
ALTER TABLE `customer_tbl`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `rental_tbl`
--
ALTER TABLE `rental_tbl`
  ADD PRIMARY KEY (`RentalID`),
  ADD KEY `CustomerID` (`CustomerID`),
  ADD KEY `VideoID` (`VideoID`);

--
-- Indexes for table `video_tbl`
--
ALTER TABLE `video_tbl`
  ADD PRIMARY KEY (`VideoID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer_tbl`
--
ALTER TABLE `customer_tbl`
  MODIFY `CustomerID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `rental_tbl`
--
ALTER TABLE `rental_tbl`
  MODIFY `RentalID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `video_tbl`
--
ALTER TABLE `video_tbl`
  MODIFY `VideoID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `rental_tbl`
--
ALTER TABLE `rental_tbl`
  ADD CONSTRAINT `CustomerID` FOREIGN KEY (`CustomerID`) REFERENCES `customer_tbl` (`CustomerID`),
  ADD CONSTRAINT `VideoID` FOREIGN KEY (`VideoID`) REFERENCES `video_tbl` (`VideoID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

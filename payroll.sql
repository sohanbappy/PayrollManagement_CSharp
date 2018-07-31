-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 11, 2017 at 07:14 PM
-- Server version: 10.1.28-MariaDB
-- PHP Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payroll`
--
CREATE DATABASE IF NOT EXISTS `payroll` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `payroll`;

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `Sl` int(11) NOT NULL,
  `em_id` varchar(11) NOT NULL,
  `dept` varchar(100) NOT NULL,
  `intime` time NOT NULL,
  `outtime` time DEFAULT NULL,
  `working_hr` time DEFAULT NULL,
  `day` date NOT NULL,
  `deduction` double NOT NULL,
  `overtime` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`Sl`, `em_id`, `dept`, `intime`, `outtime`, `working_hr`, `day`, `deduction`, `overtime`) VALUES
(1, '101', 'A', '01:44:12', '01:44:24', '00:00:12', '2017-12-02', 0, 1785.71428571429),
(5, '101', 'A', '15:33:34', '15:33:44', '00:00:10', '2017-12-01', 0, 892.857142857143);

-- --------------------------------------------------------

--
-- Table structure for table `employee_info`
--

CREATE TABLE `employee_info` (
  `em_id` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` int(11) NOT NULL,
  `designation` varchar(50) NOT NULL,
  `dept` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `date_of_birth` varchar(100) NOT NULL,
  `date_of_join` varchar(100) NOT NULL,
  `bl_group` varchar(10) NOT NULL,
  `basic` double NOT NULL,
  `address` varchar(500) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_info`
--

INSERT INTO `employee_info` (`em_id`, `name`, `phone`, `designation`, `dept`, `gender`, `date_of_birth`, `date_of_join`, `bl_group`, `basic`, `address`, `password`) VALUES
('101', 'bappy', 1766334885, 'ceo', 'A', 'Male', '12/1/1995', '12/1/2017', 'B+', 50000, 'Uttata-10', 'bappy');

-- --------------------------------------------------------

--
-- Table structure for table `leave_info`
--

CREATE TABLE `leave_info` (
  `Sl` int(50) NOT NULL,
  `em_ID` varchar(50) NOT NULL,
  `leave_type` varchar(50) NOT NULL,
  `from_date` varchar(50) NOT NULL,
  `to_date` varchar(50) NOT NULL,
  `days` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `leave_info`
--

INSERT INTO `leave_info` (`Sl`, `em_ID`, `leave_type`, `from_date`, `to_date`, `days`, `status`) VALUES
(1, '101', 'Casual', '0000-00-00', '0000-00-00', '6', 'Pending'),
(2, 'sumi', 'Casual', '0000-00-00', '0000-00-00', '7', 'Pending'),
(3, 'sumi', 'Sickness', '11/28/2017', '11/30/2017', '3', 'Pending'),
(4, '101', 'Sickness', '11/29/2017', '11/30/2017', '2', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `em_id` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`em_id`, `password`, `type`) VALUES
('101', 'bappy', 'employee'),
('root', '123', 'admin'),
('sumi', '456', 'employee');

-- --------------------------------------------------------

--
-- Table structure for table `resign`
--

CREATE TABLE `resign` (
  `sl` int(100) NOT NULL,
  `em_id` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `date_of_resign` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `salary`
--

CREATE TABLE `salary` (
  `Sl` int(11) NOT NULL,
  `em_ID` varchar(11) NOT NULL,
  `basic_pay` double NOT NULL,
  `allowence` double NOT NULL,
  `deduction` double NOT NULL,
  `overtime` double NOT NULL,
  `total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `salary`
--

INSERT INTO `salary` (`Sl`, `em_ID`, `basic_pay`, `allowence`, `deduction`, `overtime`, `total`) VALUES
(4, '101', 50000, 500, 0, 2678.57142857143, 53178.5714285714);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`Sl`);

--
-- Indexes for table `employee_info`
--
ALTER TABLE `employee_info`
  ADD PRIMARY KEY (`em_id`);

--
-- Indexes for table `leave_info`
--
ALTER TABLE `leave_info`
  ADD PRIMARY KEY (`Sl`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`em_id`);

--
-- Indexes for table `resign`
--
ALTER TABLE `resign`
  ADD PRIMARY KEY (`sl`);

--
-- Indexes for table `salary`
--
ALTER TABLE `salary`
  ADD PRIMARY KEY (`Sl`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `Sl` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `leave_info`
--
ALTER TABLE `leave_info`
  MODIFY `Sl` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `resign`
--
ALTER TABLE `resign`
  MODIFY `sl` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `salary`
--
ALTER TABLE `salary`
  MODIFY `Sl` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

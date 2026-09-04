-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 22, 2026 at 05:19 PM
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
-- Database: `dbzhotel`
--

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

CREATE TABLE `booking` (
  `Id` int(11) NOT NULL,
  `Kode_booking` varchar(50) NOT NULL,
  `Tamu_id` int(11) DEFAULT NULL,
  `Kamar_id` int(11) DEFAULT NULL,
  `User_id` int(11) DEFAULT NULL,
  `Tgl_checkin` datetime NOT NULL,
  `Tgl_checkout` datetime NOT NULL,
  `Total_biaya` decimal(12,2) DEFAULT NULL,
  `Status_transaksi` enum('checkin','checkout','batal') DEFAULT 'checkin'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `booking`
--

INSERT INTO `booking` (`Id`, `Kode_booking`, `Tamu_id`, `Kamar_id`, `User_id`, `Tgl_checkin`, `Tgl_checkout`, `Total_biaya`, `Status_transaksi`) VALUES
(3, 'BK20260822213644', 3, 1, 1, '2026-08-29 12:02:49', '2026-08-22 12:03:02', 1000000.00, 'checkin'),
(4, 'T02', 2, 3, 1, '2026-08-24 12:02:49', '2026-08-22 12:03:02', 15000000.00, 'checkout');

-- --------------------------------------------------------

--
-- Table structure for table `kamar`
--

CREATE TABLE `kamar` (
  `Id` int(11) NOT NULL,
  `Nomor_kamar` varchar(50) NOT NULL,
  `Tipe_kamar` int(11) DEFAULT NULL,
  `Status` enum('tersedia','terisi','maintenance') DEFAULT 'tersedia',
  `Foto` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kamar`
--

INSERT INTO `kamar` (`Id`, `Nomor_kamar`, `Tipe_kamar`, `Status`, `Foto`) VALUES
(1, 'K01', 1, 'terisi', NULL),
(2, 'K02', 2, 'terisi', NULL),
(3, 'K03', 3, 'terisi', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `pembayaran`
--

CREATE TABLE `pembayaran` (
  `Id` int(11) NOT NULL,
  `Booking_id` int(11) DEFAULT NULL,
  `Tanggal_bayar` datetime DEFAULT NULL,
  `Jumlah_bayar` decimal(12,2) DEFAULT NULL,
  `Metode` enum('cash','transfer','qris') DEFAULT NULL,
  `Status` enum('DP','Lunas') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `Id_role` int(11) NOT NULL,
  `Nama_role` varchar(50) NOT NULL,
  `Keterangan` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`Id_role`, `Nama_role`, `Keterangan`) VALUES
(1, 'admin', 'Mengelola seluruh sistem'),
(2, 'resepsionis', 'Menangani booking dan check-in/checkout tamu'),
(3, 'OB', 'Membersihkan area hotel');

-- --------------------------------------------------------

--
-- Table structure for table `tamu`
--

CREATE TABLE `tamu` (
  `Id` int(11) NOT NULL,
  `Nama_tamu` varchar(50) NOT NULL,
  `No_telepon` varchar(15) DEFAULT NULL,
  `Alamat` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tamu`
--

INSERT INTO `tamu` (`Id`, `Nama_tamu`, `No_telepon`, `Alamat`) VALUES
(1, 'Ahmad Fauzi', '08637527', 'Bandung'),
(2, 'ZIdan', '0874763789', 'cimahi'),
(3, 'Zayyan Mubarok', '0863457362', 'Batujajar');

-- --------------------------------------------------------

--
-- Table structure for table `tipe_kamar`
--

CREATE TABLE `tipe_kamar` (
  `Id` int(11) NOT NULL,
  `Nama_tipe` varchar(50) NOT NULL,
  `Harga_permalam` decimal(12,2) NOT NULL,
  `Kapasitas` int(11) DEFAULT NULL,
  `Deskripsi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tipe_kamar`
--

INSERT INTO `tipe_kamar` (`Id`, `Nama_tipe`, `Harga_permalam`, `Kapasitas`, `Deskripsi`) VALUES
(1, 'standar', 500000.00, 3, 'AC, TV 42 inch, KING BED, FREE WIFI'),
(2, 'Deluxe', 800000.00, 6, 'Lengkap'),
(3, 'Suite', 5000000.00, 8, 'Spek Dewa');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(225) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Id_role` int(11) DEFAULT NULL,
  `Status` enum('Aktif','NonAktif') DEFAULT 'Aktif'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `Username`, `Password`, `Nama`, `Id_role`, `Status`) VALUES
(1, 'admin', '123', 'Zayyan', 1, 'Aktif'),
(3, 'Resep', '1234', 'Fauzan', 2, 'Aktif');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `booking`
--
ALTER TABLE `booking`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Kode_booking` (`Kode_booking`),
  ADD KEY `Tamu_id` (`Tamu_id`),
  ADD KEY `Kamar_id` (`Kamar_id`),
  ADD KEY `User_id` (`User_id`);

--
-- Indexes for table `kamar`
--
ALTER TABLE `kamar`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Tipe_kamar` (`Tipe_kamar`);

--
-- Indexes for table `pembayaran`
--
ALTER TABLE `pembayaran`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Booking_id` (`Booking_id`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`Id_role`);

--
-- Indexes for table `tamu`
--
ALTER TABLE `tamu`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tipe_kamar`
--
ALTER TABLE `tipe_kamar`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Username` (`Username`),
  ADD KEY `Id_role` (`Id_role`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `booking`
--
ALTER TABLE `booking`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `kamar`
--
ALTER TABLE `kamar`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `pembayaran`
--
ALTER TABLE `pembayaran`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `Id_role` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tamu`
--
ALTER TABLE `tamu`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tipe_kamar`
--
ALTER TABLE `tipe_kamar`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `booking`
--
ALTER TABLE `booking`
  ADD CONSTRAINT `booking_ibfk_1` FOREIGN KEY (`Tamu_id`) REFERENCES `tamu` (`Id`),
  ADD CONSTRAINT `booking_ibfk_2` FOREIGN KEY (`Kamar_id`) REFERENCES `kamar` (`Id`),
  ADD CONSTRAINT `booking_ibfk_3` FOREIGN KEY (`User_id`) REFERENCES `users` (`Id`);

--
-- Constraints for table `kamar`
--
ALTER TABLE `kamar`
  ADD CONSTRAINT `kamar_ibfk_1` FOREIGN KEY (`Tipe_kamar`) REFERENCES `tipe_kamar` (`Id`);

--
-- Constraints for table `pembayaran`
--
ALTER TABLE `pembayaran`
  ADD CONSTRAINT `pembayaran_ibfk_1` FOREIGN KEY (`Booking_id`) REFERENCES `booking` (`Id`);

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`Id_role`) REFERENCES `role` (`Id_role`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

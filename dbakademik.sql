-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 24, 2024 at 01:48 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbakademik`
--

-- --------------------------------------------------------

--
-- Table structure for table `dosen`
--

CREATE TABLE `dosen` (
  `nip` varchar(25) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `alamat` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `dosen`
--

INSERT INTO `dosen` (`nip`, `nama`, `alamat`) VALUES
('0090999', 'Ahmad Basuki', 'Jl.Gempol sari no. 10 Bandung'),
('1111', 'Lia Rosalina', 'Jl. Cendana 4 No. 6 Sumedang'),
('1234567', 'Irpan Budiana', 'Gg Manggis 43 Cimahi'),
('77777', 'Dadan Sunandar', 'Perumahan Bumi Permai, Jalan Bengawan Solo 17, RT 09 RW 03, Kelurahan Kaliurang, Kecamatan Kebahagiaan, Kota Malang, Jawa Timur, 224352');

-- --------------------------------------------------------

--
-- Table structure for table `jadwal`
--

CREATE TABLE `jadwal` (
  `kodejadwal` varchar(10) NOT NULL,
  `matakuliah` varchar(100) NOT NULL,
  `dosen` varchar(50) NOT NULL,
  `ruangan` varchar(30) NOT NULL,
  `waktu` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `jadwal`
--

INSERT INTO `jadwal` (`kodejadwal`, `matakuliah`, `dosen`, `ruangan`, `waktu`) VALUES
('J001', 'MK001', '1111', 'RL02', '18:00-20:00'),
('J002', 'MK002', '1234567', 'R02', '09:00-10:00');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`) VALUES
('admin', 'admin'),
('irpan', 'irpan');

-- --------------------------------------------------------

--
-- Table structure for table `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `nim` varchar(30) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jeniskelamin` varchar(20) NOT NULL,
  `alamat` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mahasiswa`
--

INSERT INTO `mahasiswa` (`nim`, `nama`, `jeniskelamin`, `alamat`) VALUES
('224260007', 'Fani Oktaviani', 'P', 'Jl. Manggis 190 Jakarta'),
('224260046', 'Reja Dzulfikri', 'L', 'Jl. Dr. Rahardjo No. 175, Jakarta'),
('224260053', 'Rahmi Hosiah', 'P', 'Jl. Cianjur 552 Bandung'),
('224260065', 'Via Nurpadilah', 'P', 'Jl. Kemunging 89 Yogyakarta'),
('224260084', 'Risma Nurbaety', 'P', 'Jl. Jakarta 43 Bandung'),
('567888', 'Dedi Suhendi', 'L', 'Jalan Mangga Besar III No. 17, RT 06 RW 07, Kelurahan Bedali, Kecamatan Lawang, Kab. Malang, Jawa Timur, 60256');

-- --------------------------------------------------------

--
-- Table structure for table `matakuliah`
--

CREATE TABLE `matakuliah` (
  `kodemk` varchar(30) NOT NULL,
  `namamk` varchar(100) NOT NULL,
  `sks` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `matakuliah`
--

INSERT INTO `matakuliah` (`kodemk`, `namamk`, `sks`) VALUES
('MK001', 'Algoritma Pemrograman', 3),
('MK002', 'Pemrograman Visual', 4);

-- --------------------------------------------------------

--
-- Table structure for table `ruangan`
--

CREATE TABLE `ruangan` (
  `koderuangan` varchar(40) NOT NULL,
  `namaruangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `ruangan`
--

INSERT INTO `ruangan` (`koderuangan`, `namaruangan`) VALUES
('R01', 'Ruang 01'),
('R02', 'Ruang 02A'),
('R03', 'Ruang 03'),
('R04', 'Ruang 04'),
('R05', 'Ruang 05'),
('R07', 'Ruang 07-C'),
('RL01', 'Ruang Lab 01'),
('RL02', 'Ruang Lab 02'),
('RL03', 'Ruang Lab 03');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dosen`
--
ALTER TABLE `dosen`
  ADD PRIMARY KEY (`nip`);

--
-- Indexes for table `jadwal`
--
ALTER TABLE `jadwal`
  ADD PRIMARY KEY (`kodejadwal`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`nim`);

--
-- Indexes for table `matakuliah`
--
ALTER TABLE `matakuliah`
  ADD PRIMARY KEY (`kodemk`);

--
-- Indexes for table `ruangan`
--
ALTER TABLE `ruangan`
  ADD PRIMARY KEY (`koderuangan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

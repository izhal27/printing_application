-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 21, 2022 at 07:38 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET FOREIGN_KEY_CHECKS=0;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `printing_app`
--
CREATE DATABASE IF NOT EXISTS `printing_app` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `printing_app`;

-- --------------------------------------------------------

--
-- Table structure for table `form_action`
--

DROP TABLE IF EXISTS `form_action`;
CREATE TABLE IF NOT EXISTS `form_action` (
  `form_name` varchar(100) NOT NULL,
  `form_text` varchar(100) DEFAULT NULL,
  `act_1` varchar(50) DEFAULT NULL,
  `act_2` varchar(50) DEFAULT NULL,
  `act_3` varchar(50) DEFAULT NULL,
  `act_4` varchar(50) DEFAULT NULL,
  `act_5` varchar(50) DEFAULT NULL,
  `act_6` varchar(50) DEFAULT NULL,
  `act_7` varchar(50) DEFAULT NULL,
  `act_8` varchar(50) DEFAULT NULL,
  `act_9` varchar(50) DEFAULT NULL,
  `act_10` varchar(50) DEFAULT NULL,
  `act_11` varchar(50) DEFAULT NULL,
  `act_12` varchar(50) DEFAULT NULL,
  `act_13` varchar(50) DEFAULT NULL,
  `act_14` varchar(50) DEFAULT NULL,
  `act_15` varchar(50) DEFAULT NULL,
  UNIQUE KEY `form_name_UNIQUE` (`form_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `form_action`
--

INSERT INTO `form_action` (`form_name`, `form_text`, `act_1`, `act_2`, `act_3`, `act_4`, `act_5`, `act_6`, `act_7`, `act_8`, `act_9`, `act_10`, `act_11`, `act_12`, `act_13`, `act_14`, `act_15`) VALUES
('JenisOrderanView', 'Jenis Orderan', 'Tambah', 'Ubah', 'Hapus', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('LaporanOrderanView', 'Laporan Orderan', 'Hapus', 'Cetak', 'Detail', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('LaporanPengeluaranView', 'Laporan Pengeluaran', 'Hapus', 'Cetak', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('PelangganView', 'Pelanggan', 'Tambah', 'Ubah', 'Hapus', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('PengeluaranView', 'Pengeluaran', 'Tambah', 'Ubah', 'Hapus', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('PenjualanView', 'Orderan Barang', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('RoleView', 'Role', 'Update', 'Tambah', 'Ubah', 'Hapus', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('UserView', 'User', 'Tambah', 'Ubah', 'Hapus', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `jenis_orderan`
--

DROP TABLE IF EXISTS `jenis_orderan`;
CREATE TABLE IF NOT EXISTS `jenis_orderan` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `kode` varchar(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `harga_satuan` decimal(19,0) NOT NULL DEFAULT 0,
  `keterangan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `unique_kode_jenis_orderan` (`kode`) USING BTREE,
  UNIQUE KEY `unique_nama_jenis_orderan` (`nama`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `orderan`
--

DROP TABLE IF EXISTS `orderan`;
CREATE TABLE IF NOT EXISTS `orderan` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `pelanggan_id` int(10) UNSIGNED NOT NULL,
  `no_nota` varchar(255) NOT NULL,
  `tanggal` datetime NOT NULL,
  `keterangan` varchar(100) DEFAULT NULL,
  `total_diskon` decimal(19,0) NOT NULL DEFAULT 0,
  `total` decimal(19,0) NOT NULL DEFAULT 0,
  `bayar` decimal(19,0) NOT NULL DEFAULT 0,
  `kembali` decimal(19,0) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`),
  KEY `fk_pelanggan_pelanggan_id` (`pelanggan_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `orderan_detail`
--

DROP TABLE IF EXISTS `orderan_detail`;
CREATE TABLE IF NOT EXISTS `orderan_detail` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `orderan_id` int(10) UNSIGNED NOT NULL,
  `kode_jenis_orderan` varchar(100) NOT NULL,
  `nama_jenis_orderan` varchar(100) NOT NULL,
  `harga_satuan` decimal(19,0) NOT NULL,
  `jumlah` decimal(19,0) NOT NULL,
  `diskon` decimal(19,0) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_order_order_id` (`orderan_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

DROP TABLE IF EXISTS `pelanggan`;
CREATE TABLE IF NOT EXISTS `pelanggan` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nama` varchar(100) NOT NULL,
  `alamat` varchar(255) DEFAULT NULL,
  `contact` varchar(100) DEFAULT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `unique_nama_pelanggan` (`nama`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`id`, `nama`, `alamat`, `contact`, `keterangan`) VALUES
(1, 'UMUM', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `pengaturan`
--

DROP TABLE IF EXISTS `pengaturan`;
CREATE TABLE IF NOT EXISTS `pengaturan` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nama` varchar(100) NOT NULL DEFAULT 'Nama Toko',
  `alamat_1` varchar(100) DEFAULT NULL,
  `alamat_2` varchar(100) DEFAULT NULL,
  `contact` varchar(100) DEFAULT NULL,
  `printer_tipe` tinyint(1) UNSIGNED NOT NULL DEFAULT 1,
  `path_logo` varchar(255) DEFAULT NULL,
  `path_background` varchar(255) DEFAULT NULL,
  `catatan_kaki` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pengaturan`
--

INSERT INTO `pengaturan` (`id`, `nama`, `alamat_1`, `alamat_2`, `contact`, `printer_tipe`, `path_logo`, `path_background`, `catatan_kaki`) VALUES
(1, 'Nama Toko', 'Alamat 1', 'Alamat 2', '08123456789', 1, NULL, NULL, '*** Terima Kasih Atas Kepercayaan Anda ***');

-- --------------------------------------------------------

--
-- Table structure for table `pengeluaran`
--

DROP TABLE IF EXISTS `pengeluaran`;
CREATE TABLE IF NOT EXISTS `pengeluaran` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `tanggal` datetime NOT NULL,
  `nama` varchar(100) NOT NULL,
  `total` decimal(19,0) NOT NULL DEFAULT 0,
  `keterangan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
CREATE TABLE IF NOT EXISTS `role` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `kode` varchar(255) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `kode` (`kode`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`id`, `kode`, `nama`, `keterangan`) VALUES
(1, 'adm', 'Administrator', NULL),
(2, 'opr', 'Operator', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `role_detail`
--

DROP TABLE IF EXISTS `role_detail`;
CREATE TABLE IF NOT EXISTS `role_detail` (
  `role_kode` varchar(255) NOT NULL,
  `menu_name` varchar(255) NOT NULL,
  `menu_parent` varchar(255) DEFAULT NULL,
  `form_action` varchar(255) DEFAULT NULL,
  `tag` varchar(255) NOT NULL,
  KEY `fk_role_detail_role_kode` (`role_kode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `role_detail`
--

INSERT INTO `role_detail` (`role_kode`, `menu_name`, `menu_parent`, `form_action`, `tag`) VALUES
('adm', 'Tambah', 'Master', 'UserView', 'action'),
('adm', 'Ubah', 'Master', 'UserView', 'action'),
('adm', 'Hapus', 'Master', 'UserView', 'action'),
('adm', 'Tambah', 'Master', 'JenisOrderanView', 'action'),
('adm', 'Ubah', 'Master', 'JenisOrderanView', 'action'),
('adm', 'Hapus', 'Master', 'JenisOrderanView', 'action'),
('adm', 'Update', 'Master', 'RoleView', 'action'),
('adm', 'Tambah', 'Master', 'RoleView', 'action'),
('adm', 'Ubah', 'Master', 'RoleView', 'action'),
('adm', 'Hapus', 'Master', 'RoleView', 'action'),
('adm', 'Hapus', 'Laporan', 'LaporanPengeluaranView', 'action'),
('adm', 'Cetak', 'Laporan', 'LaporanPengeluaranView', 'action'),
('adm', 'Tambah', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Ubah', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Hapus', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Tambah', 'Master', 'PelangganView', 'action'),
('adm', 'Ubah', 'Master', 'PelangganView', 'action'),
('adm', 'Hapus', 'Master', 'PelangganView', 'action'),
('adm', 'Hapus', 'Laporan', 'LaporanOrderanView', 'action'),
('adm', 'Cetak', 'Laporan', 'LaporanOrderanView', 'action'),
('adm', 'Detail', 'Laporan', 'LaporanOrderanView', 'action'),
('adm', 'Master', 'Master', NULL, 'menu'),
('adm', 'JenisOrderanView', 'Master', NULL, 'menuForm'),
('adm', 'PelangganView', 'Master', NULL, 'menuForm'),
('adm', 'UserView', 'Master', NULL, 'menuForm'),
('adm', 'RoleView', 'Master', NULL, 'menuForm'),
('adm', 'Transaksi', 'Transaksi', NULL, 'menu'),
('adm', 'OrderanView', 'Transaksi', NULL, 'menuForm'),
('adm', 'PengeluaranView', 'Transaksi', NULL, 'menuForm'),
('adm', 'Laporan', 'Laporan', NULL, 'menu'),
('adm', 'LaporanOrderanView', 'Laporan', NULL, 'menuForm'),
('adm', 'LaporanPengeluaranView', 'Laporan', NULL, 'menuForm'),
('adm', 'LaporanLabaRugiView', 'Laporan', NULL, 'menuForm'),
('adm', 'Database', 'Database', NULL, 'menu'),
('adm', 'Alat', 'Alat', NULL, 'menu'),
('adm', 'PengaturanView', 'Alat', NULL, 'menuForm'),
('opr', 'Master', 'Master', NULL, 'menu'),
('opr', 'JenisOrderanView', 'Master', NULL, 'menuForm'),
('opr', 'Tambah', 'Master', 'JenisOrderanView', 'action'),
('opr', 'PelangganView', 'Master', NULL, 'menuForm'),
('opr', 'Tambah', 'Master', 'PelangganView', 'action'),
('opr', 'Transaksi', 'Transaksi', NULL, 'menu'),
('opr', 'OrderanView', 'Transaksi', NULL, 'menuForm'),
('opr', 'PengeluaranView', 'Transaksi', NULL, 'menuForm'),
('opr', 'Tambah', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Tambah', 'Master', 'UserView', 'action'),
('adm', 'Ubah', 'Master', 'UserView', 'action'),
('adm', 'Hapus', 'Master', 'UserView', 'action'),
('adm', 'Tambah', 'Master', 'JenisOrderanView', 'action'),
('adm', 'Ubah', 'Master', 'JenisOrderanView', 'action'),
('adm', 'Hapus', 'Master', 'JenisOrderanView', 'action'),
('adm', 'Update', 'Master', 'RoleView', 'action'),
('adm', 'Tambah', 'Master', 'RoleView', 'action'),
('adm', 'Ubah', 'Master', 'RoleView', 'action'),
('adm', 'Hapus', 'Master', 'RoleView', 'action'),
('adm', 'Hapus', 'Laporan', 'LaporanPengeluaranView', 'action'),
('adm', 'Cetak', 'Laporan', 'LaporanPengeluaranView', 'action'),
('adm', 'Tambah', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Ubah', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Hapus', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Tambah', 'Master', 'PelangganView', 'action'),
('adm', 'Ubah', 'Master', 'PelangganView', 'action'),
('adm', 'Hapus', 'Master', 'PelangganView', 'action'),
('adm', 'Hapus', 'Laporan', 'LaporanOrderanView', 'action'),
('adm', 'Cetak', 'Laporan', 'LaporanOrderanView', 'action'),
('adm', 'Detail', 'Laporan', 'LaporanOrderanView', 'action'),
('adm', 'Master', 'Master', NULL, 'menu'),
('adm', 'JenisOrderanView', 'Master', NULL, 'menuForm'),
('adm', 'PelangganView', 'Master', NULL, 'menuForm'),
('adm', 'UserView', 'Master', NULL, 'menuForm'),
('adm', 'RoleView', 'Master', NULL, 'menuForm'),
('adm', 'Transaksi', 'Transaksi', NULL, 'menu'),
('adm', 'OrderanView', 'Transaksi', NULL, 'menuForm'),
('adm', 'PengeluaranView', 'Transaksi', NULL, 'menuForm'),
('adm', 'Laporan', 'Laporan', NULL, 'menu'),
('adm', 'LaporanOrderanView', 'Laporan', NULL, 'menuForm'),
('adm', 'LaporanPengeluaranView', 'Laporan', NULL, 'menuForm'),
('adm', 'LaporanLabaRugiView', 'Laporan', NULL, 'menuForm'),
('adm', 'Database', 'Database', NULL, 'menu'),
('adm', 'Alat', 'Alat', NULL, 'menu'),
('adm', 'PengaturanView', 'Alat', NULL, 'menuForm'),
('opr', 'Master', 'Master', NULL, 'menu'),
('opr', 'JenisOrderanView', 'Master', NULL, 'menuForm'),
('opr', 'Tambah', 'Master', 'JenisOrderanView', 'action'),
('opr', 'PelangganView', 'Master', NULL, 'menuForm'),
('opr', 'Tambah', 'Master', 'PelangganView', 'action'),
('opr', 'Transaksi', 'Transaksi', NULL, 'menu'),
('opr', 'OrderanView', 'Transaksi', NULL, 'menuForm'),
('opr', 'PengeluaranView', 'Transaksi', NULL, 'menuForm'),
('opr', 'Tambah', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Tambah', 'Master', 'UserView', 'action'),
('adm', 'Ubah', 'Master', 'UserView', 'action'),
('adm', 'Hapus', 'Master', 'UserView', 'action'),
('adm', 'Tambah', 'Master', 'JenisOrderanView', 'action'),
('adm', 'Ubah', 'Master', 'JenisOrderanView', 'action'),
('adm', 'Hapus', 'Master', 'JenisOrderanView', 'action'),
('adm', 'Update', 'Master', 'RoleView', 'action'),
('adm', 'Tambah', 'Master', 'RoleView', 'action'),
('adm', 'Ubah', 'Master', 'RoleView', 'action'),
('adm', 'Hapus', 'Master', 'RoleView', 'action'),
('adm', 'Hapus', 'Laporan', 'LaporanPengeluaranView', 'action'),
('adm', 'Cetak', 'Laporan', 'LaporanPengeluaranView', 'action'),
('adm', 'Tambah', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Ubah', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Hapus', 'Transaksi', 'PengeluaranView', 'action'),
('adm', 'Tambah', 'Master', 'PelangganView', 'action'),
('adm', 'Ubah', 'Master', 'PelangganView', 'action'),
('adm', 'Hapus', 'Master', 'PelangganView', 'action'),
('adm', 'Hapus', 'Laporan', 'LaporanOrderanView', 'action'),
('adm', 'Cetak', 'Laporan', 'LaporanOrderanView', 'action'),
('adm', 'Detail', 'Laporan', 'LaporanOrderanView', 'action'),
('adm', 'Master', 'Master', NULL, 'menu'),
('adm', 'JenisOrderanView', 'Master', NULL, 'menuForm'),
('adm', 'PelangganView', 'Master', NULL, 'menuForm'),
('adm', 'UserView', 'Master', NULL, 'menuForm'),
('adm', 'RoleView', 'Master', NULL, 'menuForm'),
('adm', 'Transaksi', 'Transaksi', NULL, 'menu'),
('adm', 'OrderanView', 'Transaksi', NULL, 'menuForm'),
('adm', 'PengeluaranView', 'Transaksi', NULL, 'menuForm'),
('adm', 'Laporan', 'Laporan', NULL, 'menu'),
('adm', 'LaporanOrderanView', 'Laporan', NULL, 'menuForm'),
('adm', 'LaporanPengeluaranView', 'Laporan', NULL, 'menuForm'),
('adm', 'LaporanLabaRugiView', 'Laporan', NULL, 'menuForm'),
('adm', 'Database', 'Database', NULL, 'menu'),
('adm', 'Alat', 'Alat', NULL, 'menu'),
('adm', 'PengaturanView', 'Alat', NULL, 'menuForm'),
('opr', 'Master', 'Master', NULL, 'menu'),
('opr', 'JenisOrderanView', 'Master', NULL, 'menuForm'),
('opr', 'Tambah', 'Master', 'JenisOrderanView', 'action'),
('opr', 'PelangganView', 'Master', NULL, 'menuForm'),
('opr', 'Tambah', 'Master', 'PelangganView', 'action'),
('opr', 'Transaksi', 'Transaksi', NULL, 'menu'),
('opr', 'OrderanView', 'Transaksi', NULL, 'menuForm'),
('opr', 'PengeluaranView', 'Transaksi', NULL, 'menuForm'),
('opr', 'Tambah', 'Transaksi', 'PengeluaranView', 'action');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `login_id` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role_kode` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `login_id_UNIQUE` (`login_id`),
  KEY `fk_user_role_kode` (`role_kode`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `login_id`, `password`, `role_kode`) VALUES
(1, 'admin', '1000:+rQ2d9EsKMK5of62nL0ct10skO2kg//+:d7K5beDiXstpiezFXK+OoOcNYZMl1Q8e', 'adm'),
(2, 'operator', '1000:tGP5sfmvnv8svI/EIglBnMIIdkhOvGvG:OIgwv0cGK7XEDiQpSV3RT+e9BBigKxHT', 'opr');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `orderan`
--
ALTER TABLE `orderan`
  ADD CONSTRAINT `fk_pelanggan_pelanggan_id` FOREIGN KEY (`pelanggan_id`) REFERENCES `pelanggan` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `orderan_detail`
--
ALTER TABLE `orderan_detail`
  ADD CONSTRAINT `fk_orderan_orderan_id` FOREIGN KEY (`orderan_id`) REFERENCES `orderan` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `fk_user_role_kode` FOREIGN KEY (`role_kode`) REFERENCES `role` (`kode`) ON DELETE NO ACTION ON UPDATE CASCADE;
SET FOREIGN_KEY_CHECKS=1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

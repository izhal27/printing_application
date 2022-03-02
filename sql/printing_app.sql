SET FOREIGN_KEY_CHECKS=0;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;


CREATE TABLE `form_action` (
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
  `act_15` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `jenis_orderan` (
  `id` int(10) UNSIGNED NOT NULL,
  `kode` varchar(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `harga_satuan` decimal(19,0) NOT NULL DEFAULT 0,
  `keterangan` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `order` (
  `id` int(10) UNSIGNED NOT NULL,
  `pelanggan_id` int(10) UNSIGNED NOT NULL,
  `keterangan` varchar(100) DEFAULT NULL,
  `tanggal` date NOT NULL,
  `total_diskon` decimal(19,0) NOT NULL DEFAULT 0,
  `total` decimal(19,0) NOT NULL DEFAULT 0,
  `bayar` decimal(19,0) NOT NULL DEFAULT 0,
  `kembali` decimal(19,0) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `order_detail` (
  `id` int(10) UNSIGNED NOT NULL,
  `order_id` int(10) UNSIGNED NOT NULL,
  `kode_jenis_orderan` varchar(100) NOT NULL,
  `nama_jenis_orderan` varchar(100) NOT NULL,
  `harga_satuan` decimal(19,0) NOT NULL,
  `jumlah` decimal(19,0) NOT NULL,
  `diskon` decimal(19,0) NOT NULL,
  `sub_total` decimal(19,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `pelanggan` (
  `id` int(10) UNSIGNED NOT NULL,
  `nama` varchar(100) NOT NULL,
  `alamat` varchar(255) DEFAULT NULL,
  `contact` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `pelanggan` (`id`, `nama`, `alamat`, `contact`) VALUES
(1, 'UMUM', NULL, NULL);

CREATE TABLE `pengeluaran` (
  `id` int(10) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `total` decimal(19,0) NOT NULL DEFAULT 0,
  `keterangan` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `role` (
  `id` int(10) UNSIGNED NOT NULL,
  `kode` varchar(255) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `keterangan` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `role` (`id`, `kode`, `nama`, `keterangan`) VALUES
(1, 'adm', 'Administrator', NULL),
(2, 'opr', 'Operator', NULL);

CREATE TABLE `role_detail` (
  `role_kode` varchar(255) NOT NULL,
  `menu_name` varchar(255) NOT NULL,
  `menu_parent` varchar(255) DEFAULT NULL,
  `form_action` varchar(255) DEFAULT NULL,
  `tag` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `user` (
  `id` int(10) UNSIGNED NOT NULL,
  `login_id` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role_kode` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `user` (`id`, `login_id`, `password`, `role_kode`) VALUES
(1, 'admin', '1000:+rQ2d9EsKMK5of62nL0ct10skO2kg//+:d7K5beDiXstpiezFXK+OoOcNYZMl1Q8e', 'adm');


ALTER TABLE `form_action`
  ADD UNIQUE KEY `form_name_UNIQUE` (`form_name`);

ALTER TABLE `jenis_orderan`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `unique_kode_jenis_orderan` (`kode`) USING BTREE,
  ADD UNIQUE KEY `unique_nama_jenis_orderan` (`nama`) USING BTREE;

ALTER TABLE `order`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_pelanggan_pelanggan_id` (`pelanggan_id`);

ALTER TABLE `order_detail`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_order_order_id` (`order_id`);

ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `unique_nama_pelanggan` (`nama`);

ALTER TABLE `pengeluaran`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `role`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `kode` (`kode`);

ALTER TABLE `role_detail`
  ADD KEY `fk_role_detail_role_kode` (`role_kode`);

ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `login_id_UNIQUE` (`login_id`),
  ADD KEY `fk_user_role_kode` (`role_kode`);


ALTER TABLE `jenis_orderan`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

ALTER TABLE `order`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

ALTER TABLE `order_detail`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

ALTER TABLE `pelanggan`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

ALTER TABLE `pengeluaran`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;

ALTER TABLE `role`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

ALTER TABLE `user`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;


ALTER TABLE `order`
  ADD CONSTRAINT `fk_pelanggan_pelanggan_id` FOREIGN KEY (`pelanggan_id`) REFERENCES `pelanggan` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `order_detail`
  ADD CONSTRAINT `fk_order_order_id` FOREIGN KEY (`order_id`) REFERENCES `order` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `user`
  ADD CONSTRAINT `fk_user_role_kode` FOREIGN KEY (`role_kode`) REFERENCES `role` (`kode`) ON DELETE NO ACTION ON UPDATE CASCADE;
SET FOREIGN_KEY_CHECKS=1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

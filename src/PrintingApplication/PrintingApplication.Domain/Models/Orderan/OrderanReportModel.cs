﻿using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Domain.Models.OrderanDetail;
using PrintingApplication.Domain.Models.Pelanggan;
using System;
using System.Collections.Generic;

namespace PrintingApplication.Domain.Models.Orderan
{
    public class OrderanReportModel : IOrderanReportModel
    {
        public uint id { get; set; }

        public uint orderan_id { get; set; }

        public DateTime tanggal { get; set; }

        public string no_nota { get; set; }

        public IOrderanModel Orderan { get; set; }

        public uint pelanggan_id { get; set; }

        private string _pelanggan_nama;

        public string pelanggan_nama
        {
            get { return _pelanggan_nama; }
            set { _pelanggan_nama = string.IsNullOrWhiteSpace(value) ? string.Empty : value; }
        }

        public string keterangan { get; set; }

        public decimal total_diskon { get; set; }

        public decimal total { get; set; }

        public decimal bayar { get; set; }

        public decimal kembali { get; set; }

        public string kode_jenis_orderan { get; set; }

        public string nama_jenis_orderan { get; set; }

        public decimal lebar { get; set; }

        public decimal tinggi { get; set; }

        public decimal total_dimensi { get; set; }

        public decimal harga_satuan { get; set; }

        public decimal harga { get { return unit_satuan == Unit.METER ? total_dimensi * harga_satuan : harga_satuan; } }

        public Unit unit_satuan { get; set; }

        public decimal jumlah { get; set; }

        public decimal design { get; set; }

        public decimal diskon { get; set; }

        public decimal sub_total
        {
            get {
                if (unit_satuan == Unit.METER && lebar > 0 && tinggi > 0)
                {
                    total_dimensi = lebar * tinggi;
                }
                else if (total_dimensi <= 0)
                {
                    total_dimensi = 1;
                }

                decimal totalHargaSatuan = harga_satuan;
                if (unit_satuan == Unit.METER && total_dimensi > 0)
                {
                    totalHargaSatuan = total_dimensi * harga_satuan;
                }
                else
                {
                    totalHargaSatuan = total_dimensi * harga_satuan;
                }

                return jumlah > 0 && harga_satuan > 0 ? ((jumlah * totalHargaSatuan) + design) : 0;
            }
        }

        public IEnumerable<IOrderanDetailModel> OrderanDetails { get; set; }

        public IPelangganModel Pelanggan { get; }
    }
}

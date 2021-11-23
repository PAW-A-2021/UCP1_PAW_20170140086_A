using System;
using System.Collections.Generic;

namespace DataVaksin.Models
{
    public partial class DataAnggota
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public string Umur { get; set; }
        public string Pekerjaan { get; set; }
        public string TempatTanggalLahir { get; set; }
        public string JenisKelamin { get; set; }
        public string JenisVaksin { get; set; }
        public string Alamat { get; set; }
        public byte[] Foto { get; set; }
    }
}

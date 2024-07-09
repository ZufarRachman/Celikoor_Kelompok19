using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Celikoor_LIB
{
    public class Invoice
    {
        string id;
        DateTime tanggal;
        double grandTotal;
        double diskonNominal;
        double total;
        Konsumen konsumen;
        Pegawai kasir;
        SesiFilm sesiFilm;
        string status;
        List<Ticket> listTiket;

        #region Properties
        public string Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public double GrandTotal { get => grandTotal; set => grandTotal = value; }
        public double DiskonNominal { get => diskonNominal; set => diskonNominal = value; }
        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public string Status { get => status; set => status = value; }
        public List<Ticket> ListTiket { get => listTiket; set => listTiket = value; }
        public double Total { get => total; set => total = value; }
        public SesiFilm SesiFilm { get => sesiFilm; set => sesiFilm = value; }
        #endregion

        #region Constructors
        public Invoice(string id, DateTime tanggal, double grandTotal, double diskonNominal, Konsumen konsumen, Pegawai kasir, string status)
        {
            Id = id;
            Tanggal = tanggal;
            GrandTotal = grandTotal;
            DiskonNominal = diskonNominal;
            Konsumen = konsumen;
            Kasir = kasir;
            Status = status;
            ListTiket = new List<Ticket>();
        }

        public Invoice(string id, DateTime tanggal, double grandTotal, double total, double diskonNominal, Konsumen konsumen, string status, SesiFilm sesiFilm)
        {
            Id = id;
            Tanggal = tanggal;
            GrandTotal = grandTotal;
            Total = total;
            DiskonNominal = diskonNominal;
            Konsumen = konsumen;
            Status = status;
            ListTiket = new List<Ticket>();
            SesiFilm = sesiFilm;
        }

        public Invoice(string id, DateTime tanggal)
        {
            Id = id;
            Tanggal = tanggal;
        }
        #endregion

        #region Methods
        public static List<Invoice> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select i.*, k.nama, p.nama from invoices i left join pegawais p on p.id=i.kasir_id left join konsumens k on k.id=i.konsumens_id order by i.id asc";

            if (kriteria != "")
            {
                sql = "select i.*, k.nama, p.nama from invoices i left join pegawais p on p.id=i.kasir_id left join konsumens k on k.id=i.konsumens_id where " + kriteria + " like '%" + nilaiKriteria + "%' order by i.id asc";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Invoice> listInvoice = new List<Invoice>();
            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetValue(5).ToString(), hasil.GetValue(8).ToString());
                Konsumen k = new Konsumen(hasil.GetValue(4).ToString(), hasil.GetValue(7).ToString());

                Invoice i = new Invoice(hasil.GetValue(0).ToString(), DateTime.Parse(hasil.GetValue(1).ToString()), double.Parse(hasil.GetValue(2).ToString()), double.Parse(hasil.GetValue(3).ToString()), k, p, hasil.GetValue(6).ToString());
                listInvoice.Add(i);
            }
            return listInvoice;
        }
        public static void TambahData(Invoice i)
        {
            using (TransactionScope transcope = new TransactionScope())
            {
                try
                {
                    Koneksi koneksi = new Koneksi();
                    string sql = "insert into invoices(id, tanggal, grand_total, diskon_nominal, konsumens_id, status) values (" + i.Id + ",'" + i.Tanggal.ToString("yyyy-MM-dd") + "'," + i.GrandTotal + ",'" + i.DiskonNominal.ToString().Replace(",", ".") + "'," + i.Konsumen.Id + ",'" + i.Status + "')";
                    Koneksi.JalankanPerintahNonQuery(sql, koneksi);

                    //foreach(Ticket t in i.ListTiket)
                    //{
                    //    string sql2 = "insert into tikets(invoices_id, nomor_kursi, status_hadir, harga, jadwal_films_id, studios_id, films_id) values(" + t.InvoiceId.Id + ",'" + t.NomorKursi + "'," + t.StatusHadir + "," + t.Harga + "," + t.JadwalFilmId.Id + "," + t.StudioId.Id + "," + t.FilmId.Id + ")";

                    //    Koneksi.JalankanPerintahNonQuery(sql2, koneksi);
                    //}
                    transcope.Complete();
                }
                catch (Exception ex)
                {
                    transcope.Dispose();
                    throw new Exception(ex.Message);
                }
            }
        }

        public static void Pemesanan(Invoice i, string tiket)
        {
            using (TransactionScope transcope = new TransactionScope())
            {
                try
                {
                    Koneksi koneksi = new Koneksi();
                    string sql = "insert into invoices(id, tanggal, grand_total, diskon_nominal, konsumens_id, status) values (" + i.Id + ",'" + i.Tanggal.ToString("yyyy-MM-dd") + "'," + i.GrandTotal + ",'" + i.DiskonNominal.ToString().Replace(",", ".") + "'," + i.Konsumen.Id + ",'" + i.Status + "')";
                    Koneksi.JalankanPerintahNonQuery(sql, koneksi);
                    Console.WriteLine(tiket);
                    tiket = tiket.Replace(" ", "");
                    List<string> tickets = tiket.Split(',').ToList();
                    Console.WriteLine(tickets);
                    foreach (string part in tickets)
                    {
                        Console.WriteLine(part);
                        string sql2 = "insert into tikets(invoices_id, nomor_kursi, status_hadir, harga, jadwal_film_id, studios_id, films_id) values(" + i.Id + ",'" + part + "'," + "FALSE" + "," + i.Total / tickets.Count + "," + i.SesiFilm.JadwalFilmID.Id + "," + i.SesiFilm.StudioID.Id + "," + i.SesiFilm.FilmID.Id + ")";
                        Console.WriteLine(sql2);

                        Koneksi.JalankanPerintahNonQuery(sql2, koneksi);

                    }
                    
                    string sql3 = "UPDATE konsumens SET saldo = saldo - " + i.GrandTotal + " WHERE id = " + i.Konsumen.Id;
                    Console.WriteLine(sql3);

                    Koneksi.JalankanPerintahNonQuery(sql3, koneksi);
                    transcope.Complete();

                }
                catch (Exception ex)
                {
                    transcope.Dispose();
                    throw new Exception(ex.Message);
                }
            }
        }

        public void TambahDataTiket(Invoice invoice, string nomorKursi, string statusHadir, double harga, JadwalFilm jf, Studio s, Film f)
        {
            Ticket t = new Ticket(invoice, nomorKursi, statusHadir, harga, jf, s, f);
            ListTiket.Add(t);
        }

        public static void UbahData(Invoice i)
        {
            string sql = "update invoices set tanggal='" + i.Tanggal.ToString("yyyy-MM-dd") + "', grand_total=" + i.GrandTotal + ", diskon_nominal='" + i.DiskonNominal.ToString().Replace(",", ".") + "', konsumens_id=" + i.Konsumen.Id + ", kasir_id=" + i.Kasir.Id + ", status='" + i.Status + "' where id=" + i.Id;

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static Boolean HapusData(Invoice i)
        {
            string sql = "delete from invoices where id=" + i.Id;
            int jumlahDataBerubah = Koneksi.JalankanPerintahNonQuery(sql);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string GenerateID()
        {
            string sql = "select max(id) from invoices";

            string hasilID;
            int IDTerbaru;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() == "")
                {
                    IDTerbaru = 1;
                }
                else
                {
                    IDTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                }
                hasilID = IDTerbaru.ToString();
            }
            else
            {
                hasilID = "1";
            }
            return hasilID;
        }

        public static Invoice AmbilDataByID(string id)
        {
            string sql = "select i.*, k.nama, p.nama from invoices i left join pegawais p on p.id=i.kasir_id left join konsumens k on k.id=i.konsumens_id where i.id=" + id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetValue(5).ToString(), hasil.GetValue(8).ToString());
                Konsumen k = new Konsumen(hasil.GetValue(4).ToString(), hasil.GetValue(7).ToString());

                Invoice i = new Invoice(hasil.GetValue(0).ToString(), DateTime.Parse(hasil.GetValue(1).ToString()), double.Parse(hasil.GetValue(2).ToString()), double.Parse(hasil.GetValue(3).ToString()), k, p, hasil.GetValue(6).ToString());
                return i;
            }
            else
            {
                return null;
            }
        }

      
        #endregion
    }
}

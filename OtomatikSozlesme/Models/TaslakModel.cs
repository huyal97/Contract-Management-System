using System.ComponentModel.DataAnnotations;

namespace OtomatikSozlesme.Models
{
    public class TaslakModel
    {
        public int ID { get; set; }
        [Display(Name = "Şirket Adı")]
        public string SIRKETADI { get; set; }
        [Display(Name = "Şartname Adı")]
        public string SARTNAMEADI { get; set; }
        [Display(Name = "1. İŞİN ADI VE TANIMI")]
        public string IS_TANIM_1 { get; set; }
        [Display(Name = "2. VARSA ALT YÜKLENİCİ ÇALIŞTIRMAYA İLİŞKİN ESASLAR")]
        public string ALT_YUKLENICI_2 { get; set; }
        [Display(Name = "3. GARANTİ SÜRESİ")]
        public string GARANTI_SURESI_3 { get; set; }
        [Display(Name = "4. EĞİTİME AİT ŞARTLAR")]
        public string EGITIM_SARTLARI_4 { get; set; }
        [Display(Name = "5. İŞİN KAPSAMI ve İFASI İLE İLGİLİ ŞARTLAR")]
        public string ISIN_KAPSAMI_5 { get; set; }
        [Display(Name = "6. SÖZLEŞME BEDELİNE DÂHİL UNSURLAR")]
        public string SOZLESME_BEDELINE_UNSURLARI_6 { get; set; }
        [Display(Name = "7. İŞİN YERİ VE SÜRESİ")]
        public string ISIN_YERI_SURESI_7 { get; set; }
        [Display(Name = "8. İŞİN TESLİM VE KABUL ŞARTLARI")]
        public string ISIN_TESLIM_KABUL_SARTLARI_8 { get; set; }
        [Display(Name = "9. YÜKLENİCİ PERSONELİNDE ARANAN NİTELİKLER")]
        public string YUKLENICI_PERSONEL_ARANAN_NITELIKLER_9 { get; set; }
        [Display(Name = "10. İŞİN İFASINDA KULLANILACAK PERSONEL, ARAÇ GEREÇ VE MALZEME")]
        public string ISIN_IFASINDA_PERSONEL_10 { get; set; }
        [Display(Name = "11. FİYAT FARKI")]
        public string FIYAT_FARKI_11 { get; set; }
        [Display(Name = "12. İŞE BAŞLAMA")]
        public string ISE_BASLAMA_12 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TestBll
    {
        public int Topla(int sayi1, int sayi2) => sayi1 + sayi2;
        public int Topla(int[] sayiListesi) => sayiListesi.Sum();
    }
}

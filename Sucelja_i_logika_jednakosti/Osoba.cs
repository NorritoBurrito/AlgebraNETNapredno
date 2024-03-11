using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_i_logika_jednakosti
{
    public class Osoba:IComparable<Osoba>
    {
        private string _ime;
        private string _prezime;
        private int _dob;
        public string Ime { get { return _ime; } set { _ime = value; } }
        public string Prezime { get { return _prezime; } set { _prezime = value; } }
        public int Dob { get { return _dob; } set { _dob = value; } }

        public Osoba(string ime, string prezime, int dob)
        {
            _ime = ime;
            _prezime = prezime;
            _dob = dob;
        }

        public int CompareTo(Osoba druga_osoba)
        {
            int usporedba=Prezime.CompareTo(druga_osoba.Prezime);
            if(usporedba!=0) return usporedba;
            usporedba=Ime.CompareTo(druga_osoba.Ime);
            if(usporedba!=0)return usporedba;
            return Dob.CompareTo(druga_osoba.Dob);
        }
    }
}

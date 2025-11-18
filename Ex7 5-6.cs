using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            // TEHTÄVÄ 5: Lasketaan luvun neliö niin kauan kuin syötetty luku on positiivinen

            int luku; // Luodaan muuttuja luvulle

            do
            {
                luku = int.Parse(Console.ReadLine()); // Luetaan käyttäjältä luku

                if (luku >= 0) // Tarkistetaan että luku on positiivinen
                {
                    int nelio = luku * luku; // Lasketaan luvun neliö
                    Console.WriteLine(nelio); // Tulostetaan neliö
                }
            }
            while (luku >= 0); // Toistetaan niin kauan kuin luku on positiivinen
            /*
            do...while-silmukka toimii näin:
            Ensin tehdään se, mitä silmukan sisällä lukee, ja vasta sen jälkeen kysytään: "Jatketaanko vielä?"
            Jos vastaus on kyllä (ehto on totta), tehdään sama uudestaan. Jos vastaus on ei (ehto ei ole totta), lopetetaan.
            Tässä ohjelmassa halutaan, että käyttäjä saa aina syöttää ainakin yhden luvun ennen kuin tarkistetaan, onko se positiivinen.
            Siksi käytetään do...while-silmukkaa, koska se aina suorittaa vähintään kerran ennen tarkistusta.
            
            Kuvittele, että äiti sanoo:
            "Maista ainakin yhden palan vihanneksia, ja jos se maistuu hyvältä, saat ottaa lisää."
            Sinun täytyy maistaa ensin (do), ja vasta sen jälkeen äiti kysyy (while):
            "Haluatko lisää?"
            Jos haluat, otat lisää. Jos et halua, lopetat.
            
            while on kuin opettaja sanoo: "Jos olet tehnyt läksyt, saat pelata." Jos et ole tehnyt läksyjä, et pelaa ollenkaan.
            do...while on kuin opettaja sanoo: "Pelaa kerran, mutta jos läksyt on tehty, saat pelata lisää." Eli pelaat ainakin kerran.
            */


            // TEHTÄVÄ 6: Etsitään pienin ja suurin positiivinen luku käyttäjän syötteistä

            int pienin = int.MaxValue; // Alustetaan pienin mahdollisimman suureksi
            int suurin = int.MinValue; // Alustetaan suurin mahdollisimman pieneksi
            /*
            Aloitamme pienimmän luvun niin isosta arvosta kuin tietokone osaa käsitellä, jotta ensimmäinen oikea luku on varmasti pienempi ja voi korvata sen, 
            ja suurimman luvun niin pienestä arvosta kuin tietokone osaa käsitellä, jotta ensimmäinen oikea luku on varmasti suurempi ja voi korvata sen.
            Vertaus:
            Se on kuin sanoisit: "Pienin kivi on nyt vuoren kokoinen ja suurin kivi on nyt hiekanjyvän kokoinen, jotta kun löydän ensimmäisen oikean kiven, voin vaihtaa nämä arvot heti."
            */
            do
            {
                luku = int.Parse(Console.ReadLine()); // Luetaan uusi luku

                if (luku >= 0) // Jos luku on positiivinen
                {
                    if (luku < pienin) // Jos luku on pienempi kuin nykyinen pienin
                    {
                        pienin = luku; // Päivitetään pienin
                    }
                    if (luku > suurin) // Jos luku on suurempi kuin nykyinen suurin
                    {
                        suurin = luku; // Päivitetään suurin
                    }
                }
            }
            while (luku >= 0); // Toistetaan kunnes saadaan negatiivinen luku

            Console.WriteLine(pienin); // Tulostetaan pienin syötetty positiivinen luku
            Console.WriteLine(suurin); // Tulostetaan suurin syötetty positiivinen luku
        }
    }
}

using system;

namespace Programs

    public static class Solution
    {
    KOEAIHEET
    
    TYYPPIMUUNNOS
    Muuttaa arvon tietotyypistä toiseen, esim. kokonaisluvusta desimaaliksi.
    Esimerkki:
    
    int luku = 10;
    double desimaali = (double)luku; // tyyppimuunnos int → double

    WHILE
    Toistaa koodilohkoa niin kauan kuin ehto on tosi.
    Esimerkki:
    int i = 0;
    while (i < 5)
    {
        Console.WriteLine(i);
        i++;
    }
    Muista aina alltosulut silmukassa, muutoin se jumittuu!!!!

    SWITCH
    Valitsee suoritettavan koodilohkon muuttujan arvon perusteella.
    Esimerkki:
    
    int valinta = 2;
    switch (valinta)
    {
        case 1: Console.WriteLine("Yksi"); break;
        case 2: Console.WriteLine("Kaksi"); break;
        default: Console.WriteLine("Tuntematon"); break;
    }

    FOR
    Toistaa koodilohkoa tietyn määrän kertoja.
    Esimerkki:
    
    for (int i = 0; i < 5; i++)
    {
    Console.WriteLine(i);
    }

    DO..WHILE
    Suorittaa koodilohkon vähintään kerran ja jatkaa, jos ehto on tosi.
    Esimerkki:
    
    int i = 0;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i < 5);

    PARSE
    Muuntaa merkkijonon tiettyyn tietotyyppiin.
    Esimerkki:
    try
    {
        int x = int.Parse("abc"); // virheellinen muunnos
    }
    catch (FormatException)
    {
        Console.WriteLine("Virhe: väärä muoto");
    }

    IF...IF ELSE
    Ehtolause, joka suorittaa eri koodilohkoja riippuen ehdon totuudesta.
    Esimerkki:
    
    int luku = 10;
    if (luku > 0)
        Console.WriteLine("Positiivinen");
    else
        Console.WriteLine("Negatiivinen tai nolla");

    EI POIKKEUKSIA OSIOT ELI TEHTÄVÄ 12
    
    MUISTISÄÄNTÖJÄ

    1. i++; i = i + 1;

    Molemmat tarkoittavat samaa: lisätään muuttujaan i yksi.
    Käytetään usein silmukoissa, kun halutaan kasvattaa laskuria yhdellä.


    2. i--;

    Vähentää muuttujaa i yhdellä (käänteinen suunta).
    Hyödyllinen, kun lasketaan alaspäin (esim. 10 → 1).


    3. i++; j += i;

    i++ kasvattaa i yhdellä.
    j += i lisää i arvon j:hin (sama kuin j = j + i).
    Eli ensin kasvatetaan i, sitten lisätään se j:hin.


    4. k *= i * j; k++;

    k *= i * j tarkoittaa: kerrotaan k arvolla (i * j).
    k++ lisää k:hen yhden.
    Eli ensin suuri kertolasku, sitten kasvatetaan yhdellä.


    5. j--; i += j + k;

    j-- vähentää j yhdellä.
    i += j + k lisää j + k arvon i:hin (sama kuin i = i + (j + k)).
    Eli ensin pienennetään j, sitten lisätään j + k i:hin.


    6. ++j; k -= j;

    ++j kasvattaa j yhdellä (pre-increment).
    k -= j vähentää j arvon k:sta (sama kuin k = k - j).
    Eli ensin kasvatetaan j, sitten vähennetään se k:sta.
    
    
    }

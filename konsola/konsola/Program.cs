

string[] male = [ "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "w", "x", "y", "z" ];
string[] duze = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "W", "X", "Y", "Z" ];
string[] diakrytyczne =[ "ą", "ę", "ł", "ń", "ó", "ś", "ź", "ż", "Ą", "Ę", "Ł", "Ń", "Ó", "Ś", "Ź", "Ż" ];
int[] cyfry = [0,1,2,3,4,5,6,7,8,9];
string[] specjalne = [ "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+"];



/*
# nazwa funkcji: losuj
# opis funkcji: Funkcja generuje losowe hasło składające się z 3 małych liter, 3 dużych liter, 2 znaków specjalnych, 2 cyfr i 2 znaków diakrytycznych
# parametry: brak
# zwraca typ i opis: brak
# autor: 00000000000
*/


void losuj()
{
    List<string> haslo = new List<string>();
    Random random = new Random();

    for (int i = 0; i < 3; i++)
    {
        
        int randomIndex = random.Next(male.Length);
        haslo.Add(male[randomIndex]);
    }

    for (int i = 0; i < 3; i++)
    {
        int randomIndex = random.Next(duze.Length);
        haslo.Add(duze[randomIndex]);
    }

    for (int i = 0; i < 2; i++)
    {
        int randomIndex = random.Next(diakrytyczne.Length);
        haslo.Add(diakrytyczne[randomIndex]);
    }

    for (int i = 0; i < 2; i++)
    {
        int randomIndex = random.Next(cyfry.Length);
        haslo.Add(cyfry[randomIndex].ToString());
    }

    for (int i = 0; i < 2; i++)
    {
        int randomIndex = random.Next(specjalne.Length);
        haslo.Add(specjalne[randomIndex]);
    }



        for(int i = haslo.Count - 1; i > 0; i--)
    {
        int j = random.Next(i - 1);

        string temp = haslo[j];
        haslo[j] = haslo[i];
        haslo[i] = temp;
    }


    Console.WriteLine(string.Join("", haslo));
    
}
losuj(); 
losuj();
losuj();
losuj();
losuj();


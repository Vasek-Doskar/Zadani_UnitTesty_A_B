using System;
using System.Collections.Generic;
using System.Text;

namespace Zadani_UnitTesty_A_B
{
    /// <summary>
    /// Třída poskytující pomocné metody pro zpracování, úpravu a validaci textových řetězců.
    /// </summary>
    public class ZpracovavacTextu
    {
        /// <summary>
        /// Spojí jméno a příjmení do jednoho řetězce odděleného mezerou.
        /// </summary>
        /// <param name="jmeno">Křestní jméno.</param>
        /// <param name="prijmeni">Příjmení.</param>
        /// <returns>Celé jméno ve formátu "Jméno Příjmení".</returns>
        public string VytvorCeleJmeno(string jmeno, string prijmeni) => $"{jmeno} {prijmeni}";

        /// <summary>
        /// Spočítá počet znaků v textu po odstranění všech mezer.
        /// </summary>
        /// <param name="text">Vstupní text.</param>
        /// <returns>Počet znaků bez mezer. Vrátí 0, pokud je text <c>null</c>.</returns>
        public int SpocitejZnakyBezMezer(string text)
        {
            if (text == null) return 0;
            return text.Replace(" ", "").Length;
        }

        /// <summary>
        /// Zjistí, zda je zadaný text palindrom (čte se stejně zepředu i zezadu, bez ohledu na velikost písmen a mezery).
        /// </summary>
        /// <param name="text">Testovaný text.</param>
        /// <returns><c>true</c>, pokud je text palindrom; jinak <c>false</c>.</returns>
        public bool JePalindrom(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            string ocisteny = text.ToLower().Replace(" ", "");
            string obraceny = new string(ocisteny.ToCharArray().Reverse().ToArray());
            return ocisteny == obraceny;
        }

        /// <summary>
        /// Odstraní úvodní a koncové mezery a převede text na velká písmena.
        /// </summary>
        /// <param name="text">Vstupní text.</param>
        /// <returns>Oříznutý text s velkými písmeny nebo <c>null</c>, pokud byl vstup <c>null</c>.</returns>
        public string OrizniAUpravNaVelka(string text) => text?.Trim().ToUpper();

        /// <summary>
        /// Nahradí všechny výskyty zakázaného slova hvězdičkami ("***").
        /// </summary>
        /// <param name="text">Původní text.</param>
        /// <param name="zakazaneSlovo">Slovo, které má být cenzurováno.</param>
        /// <returns>Cenzurovaný text.</returns>
        public string CenzurujSlovo(string text, string zakazaneSlovo)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(zakazaneSlovo)) return text;
            return text.Replace(zakazaneSlovo, "***");
        }

        /// <summary>
        /// Rozdělí text na samostatná slova podle mezer, čárek a teček. Ignoruje prázdné položky.
        /// </summary>
        /// <param name="text">Vstupní text k rozdělení.</param>
        /// <returns>Pole nalezených slov.</returns>
        public string[] RozdelNaSlova(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return new string[0];
            return text.Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Zkrátí text na zadanou maximální délku a přidá trojtečku ("..."), pokud byl text zkrácen.
        /// </summary>
        /// <param name="text">Vstupní text.</param>
        /// <param name="maxDelka">Maximální povolená délka původního textu.</param>
        /// <returns>Zkrácený text s trojtečkou nebo původní text.</returns>
        public string ZkratText(string text, int maxDelka)
        {
            if (text == null) return string.Empty;
            if (text.Length <= maxDelka) return text;
            return text.Substring(0, maxDelka) + "...";
        }

        /// <summary>
        /// Ověří, zda řetězec obsahuje alespoň jednu číslici (0–9).
        /// </summary>
        /// <param name="text">Testovaný text.</param>
        /// <returns><c>true</c>, pokud text obsahuje číslici; jinak <c>false</c>.</returns>
        public bool ObsahujeCislici(string text)
        {
            if (text == null) return false;
            return text.Any(char.IsDigit);
        }

        /// <summary>
        /// Kontroluje, zda zadáné heslo dosahuje minimální požadované délky.
        /// </summary>
        /// <param name="heslo">Testované heslo.</param>
        /// <param name="minDelka">Minimální délka hesla.</param>
        /// <returns><c>true</c>, pokud heslo vyhovuje délce; jinak <c>false</c>.</returns>
        public bool JeDostatecneDluhy(string heslo, int minDelka)
        {
            if (heslo == null) return false;
            return heslo.Length >= minDelka;
        }

        /// <summary>
        /// Validuje text a vyhodí výjimku, pokud je text <c>null</c>, prázdný nebo obsahuje pouze bílé znaky.
        /// </summary>
        /// <param name="text">Kontrolovaný text.</param>
        /// <exception cref="ArgumentNullException">Vyhozeno, pokud je text neplatný.</exception>
        public void VyzadujNeprazdnyText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException(nameof(text), "Text nesmí být prázdný.");
        }
    }
}
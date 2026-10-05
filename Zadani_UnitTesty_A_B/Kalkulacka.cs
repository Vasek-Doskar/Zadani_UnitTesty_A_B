using System;
using System.Collections.Generic;
using System.Text;

namespace Zadani_UnitTesty_A_B
{
    /// <summary>
    /// Třída reprezentující kalkulačku se základními matematickými operacemi a pamětí.
    /// </summary>
    public class Kalkulacka
    {
        private double pamet = 0;

        /// <summary>
        /// Sečte dvě celá čísla.
        /// </summary>
        /// <param name="a">První sčítanec.</param>
        /// <param name="b">Druhý sčítanec.</param>
        /// <returns>Součet hodnot <paramref name="a"/> a <paramref name="b"/>.</returns>
        public int Sticti(int a, int b) => a + b;

        /// <summary>
        /// Vypočítá podíl dvou desatinných čísel.
        /// </summary>
        /// <param name="citatel">Číslo, které dělíme.</param>
        /// <param name="jmenovatel">Číslo, kterým dělíme.</param>
        /// <returns>Výsledek dělení.</returns>
        /// <exception cref="ArgumentException">Vyhozeno, pokud je <paramref name="jmenovatel"/> roven nule.</exception>
        public double Podil(double citatel, double jmenovatel)
        {
            if (jmenovatel == 0)
                throw new ArgumentException("Jmenovatel nesmí být nula.");
            return citatel / jmenovatel;
        }

        /// <summary>
        /// Zjistí, zda je zadané celé číslo sudé.
        /// </summary>
        /// <param name="cislo">Testované číslo.</param>
        /// <returns><c>true</c>, pokud je číslo sudé; jinak <c>false</c>.</returns>
        public bool JeSude(int cislo) => cislo % 2 == 0;

        /// <summary>
        /// Uloží zadanou hodnotu do vnitřní paměti kalkulačky.
        /// </summary>
        /// <param name="hodnota">Hodnota k uložení.</param>
        public void UlozDoPameti(double hodnota)
        {
            pamet = hodnota;
        }

        /// <summary>
        /// Vrátí aktuální hodnotu uloženou v paměti kalkulačky.
        /// </summary>
        /// <returns>Hodnota z paměti.</returns>
        public double NactiZPameti() { 
            return pamet; }

        /// <summary>
        /// Vynuluje hodnotu uloženou v paměti kalkulačky.
        /// </summary>
        public void VynulujPamet()
        {
            pamet = 0;
        }

        /// <summary>
        /// Vypočítá absolutní hodnotu zadaného celého čísla.
        /// </summary>
        /// <param name="cislo">Vstupní číslo.</param>
        /// <returns>Absolutní hodnota čísla.</returns>
        public int AbsolutniHodnota(int cislo) => Math.Abs(cislo);

        /// <summary>
        /// Ověří, zda se číslo nachází v uzavřeném intervalu [min, max].
        /// </summary>
        /// <param name="cislo">Testované číslo.</param>
        /// <param name="min">Minimální povolená hodnota (včetně).</param>
        /// <param name="max">Maximální povolená hodnota (včetně).</param>
        /// <returns><c>true</c>, pokud číslo leží v rozsahu; jinak <c>false</c>.</returns>
        public bool JeVRozsahu(int cislo, int min, int max)
        {
            return cislo >= min && cislo <= max;
        }

        /// <summary>
        /// Spočíta průměrnou hodnotu z pole celých čísel.
        /// </summary>
        /// <param name="cisla">Pole čísel pro výpočet průměru.</param>
        /// <returns>Aritmetický průměr zadaných čísel.</returns>
        /// <exception cref="ArgumentException">Vyhozeno, pokud je pole <c>null</c> nebo prázdné.</exception>
        public double SpocitejPrumer(int[] cisla)
        {
            if (cisla == null || cisla.Length == 0)
                throw new ArgumentException("Pole nesmí být prázdné.");
            return cisla.Average();
        }

        /// <summary>
        /// Zaokrouhlí desetinné číslo na požadovaný počet desetinných míst.
        /// </summary>
        /// <param name="cislo">Číslo k zaokrouhlení.</param>
        /// <param name="pocetMisty">Počet desetinných míst.</param>
        /// <returns>Zaokrouhlené číslo.</returns>
        public double Zaokrouhli(double cislo, int pocetMisty)
        {
            return Math.Round(cislo, pocetMisty);
        }
    }
}

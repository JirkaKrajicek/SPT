using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{    
        static class PrevodyCisel //vytvoreni staticke tridy (pro podobnou funkci jako napriklad staticka trida a metoda Math.Pow() )
        {

        public static string Binary(uint VstupBin) // vytvoreni staticke metody pro prevod cisla do dvojkove soustavy
            {
                uint vstupBin = Convert.ToUInt32(VstupBin); 
                uint zbytekBin = 0; //pomocna promena potrebna k provedeni vypoctu

                List<uint> bin = new List<uint>(); //zvolen list jakozto pole s dynamickou velikosti
                while (vstupBin > 0) //cyklus while, zde zacina prevod z desitkove soustavy do dvojkove. Pouzivame metodu deleni a cteni zbytku
                {
                    zbytekBin = vstupBin % 2;  //zjisteni zbytku po deleni vstupni hodnoty dvema
                    bin.Add(zbytekBin); //ulozeni zbytku do listu
                    vstupBin /= 2; //vydeleni vstupni hodnoty dvema a zacykleni, dokud vysledek se nerovna 0
                }
                uint[] pole_List_Bin = bin.ToArray(); //prepsani dat z listu do pole. Nove pole ma velikost presne takovou, jak potrebujeme
                uint[] pole_Bin_mirror = new uint[pole_List_Bin.Length]; //vytvoreni druheho pole, stejne velike, jak predchozi pole s daty z listu
                for (int i = 0, j = pole_List_Bin.Length - 1; i < pole_List_Bin.Length; i++, j--) //cyklus for pro naplneni pole daty v tomto pripade v opacnem poradi
                {
                    pole_Bin_mirror[j] = pole_List_Bin[i]; //pri urceni cisla v nove soustave je potreba cist zbytky po deleni v opacnem poradi
                }
                string output = string.Join("", pole_Bin_mirror); //pole se spravnym poradim spojime bez mezer, aby se jevilo jako ucelene cislo
                return output; //spojenipro prehlednost nas vystup je ve forme string tak, abychom meli zjednodusenou praci pri vypisovani ve winformech

            }
            public static string Hex(uint VstupHex) //obdobny postup jako u prevodu do binarni soustavy, ted pouze do sestkove
            {
                uint vstupHex = Convert.ToUInt32(VstupHex); ;
                uint zbytekHex = 0;

                List<uint> hex = new List<uint>();
                while (vstupHex > 0)
                    {
                        zbytekHex = vstupHex % 6;
                        hex.Add(zbytekHex);
                        vstupHex /= 6;
                    }
                uint[] pole_List_Hex = hex.ToArray();
                uint[] pole_Hex_mirror = new uint[pole_List_Hex.Length];
                for (int i = 0, j = pole_List_Hex.Length - 1; i < pole_List_Hex.Length; i++, j--)
                    {
                        pole_Hex_mirror[j] = pole_List_Hex[i];
                    }
                string outputHex = string.Join("", pole_Hex_mirror);
                return outputHex;
                
            }
            public static string Okta(uint VstupOkta) //obdobny postup jako u prevodu do binarni soustavy, ted pouze do osmickove
            {
                uint vstupOkta = Convert.ToUInt32(VstupOkta);
                uint zbytekOkta = 0;

                List<uint> osm = new List<uint>();
                while (vstupOkta > 0)
                    {
                        zbytekOkta = vstupOkta % 8;
                        osm.Add(zbytekOkta);
                        vstupOkta /= 8;
                    }
                uint[] pole_List_Osm = osm.ToArray();
                uint[] pole_Osm_mirror = new uint[pole_List_Osm.Length];
                for (int i = 0, j = pole_List_Osm.Length - 1; i < pole_List_Osm.Length; i++, j--)
                    {
                        pole_Osm_mirror[j] = pole_List_Osm[i];
                    }
                string outputHex = string.Join("", pole_Osm_mirror);
                return outputHex;

            }
            public static string HexDec(uint VstupHexDec) //prevod z desitkove soustavy do hexadecimalni - tedy do sestnactkove
            {
                uint vstupHexDec = Convert.ToUInt32(VstupHexDec);
                uint zbytekHexDec = 0; //pomocna promenna pro vypocet

                List<char> hexdec = new List<char>(); //pole s dynamickou veliksoti, forma charakteru, nebot sestnactkova soustava pracuje s cisly i pismeny
                while (vstupHexDec > 0) //cyklus while opakujici se dokud vstupni hodnota po deleni 16 neni rovna 0
                    {
                        zbytekHexDec = vstupHexDec % 16; //zjisteni hodnoty zbytku po deleni 16

                        if (zbytekHexDec == 0) zbytekHexDec = (char)'0'; //list, do ktereho ukladame, je ve forme char a tedy data do nej ukladana musi mit stejny datovy tip
                        if (zbytekHexDec == 1) zbytekHexDec = (char)'1'; //a tedy prevadime cislo 0-9 do formy znaku 0-9
                        if (zbytekHexDec == 2) zbytekHexDec = (char)'2'; //ad 0
                        if (zbytekHexDec == 3) zbytekHexDec = (char)'3'; //ad 0
                        if (zbytekHexDec == 4) zbytekHexDec = (char)'4'; //ad 0
                        if (zbytekHexDec == 5) zbytekHexDec = (char)'5'; //ad 0
                        if (zbytekHexDec == 6) zbytekHexDec = (char)'6'; //ad 0
                        if (zbytekHexDec == 7) zbytekHexDec = (char)'7'; //ad 0
                        if (zbytekHexDec == 8) zbytekHexDec = (char)'8'; //ad 0
                        if (zbytekHexDec == 9) zbytekHexDec = (char)'9'; //ad 0
                        if (zbytekHexDec == 10) zbytekHexDec = (char)'A'; //v hexadecimalni soustave zapisujeme cisla 10-15 pomoci pismen A-F
                        if (zbytekHexDec == 11) zbytekHexDec = (char)'B'; //proto ciselny zbytek prevadime do jejich ekvivalentni podoby
                        if (zbytekHexDec == 12) zbytekHexDec = (char)'C'; //ad 10                        
                        if (zbytekHexDec == 13) zbytekHexDec = (char)'D'; //ad 10 
                        if (zbytekHexDec == 14) zbytekHexDec = (char)'E'; //ad 10 
                        if (zbytekHexDec == 15) zbytekHexDec = (char)'F'; //ad 10 

                        hexdec.Add((char)zbytekHexDec); //pridani zbytku po deleni 16 ve sve ekvivalentni podobe do listu
                        vstupHexDec /= 16; //vydeleni vstupni hodnoty 16 a zacykleni, dokud po deleni vysledek neni 0
                    }
                char[] pole_List_HexDec = hexdec.ToArray(); //vytvoreni noveho pole, ktere naplnime daty z listu
                char[] pole_HexDec_mirror = new char[pole_List_HexDec.Length]; //vytvoreni druheho pole se stejnou velikosti jako pole zaplnene daty z listu
                for (int i = 0, j = pole_List_HexDec.Length - 1; i < pole_List_HexDec.Length; i++, j--) //cyklus for pro naplneni druheho pole daty z prvniho pole v opacnem poradi
                    {
                        pole_HexDec_mirror[j] = pole_List_HexDec[i];
                    }

                string outputHex = string.Join("", pole_HexDec_mirror); //spojeni dat z druheho pole jako jeden celek
                return outputHex; //kdyz tuto metodu zavolame, vystup je v podobe stringu
        }
    }
    }

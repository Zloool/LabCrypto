using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ZhuLab1
{
    
    public static class Caesar
    {
        static String alfabet = "абвгдеєжзиіїйклмнопрстуфхцчшщьюя ";
        public static string Encrypt(String message, int key)
        {
            String After = "";
            message = message.ToLower();
            for (int i = 0; i < message.Length; i++)
            {
                if (alfabet.IndexOf(message[i]) < 0)
                    After += message[i];
                Int32 newPos = (alfabet.IndexOf(message[i]) + key) % alfabet.Length;
                
                After = After + alfabet[newPos];
            }
            return After;
        }

        public static string Decrypt(string message, int key)
        {
            key = alfabet.Length - key;
            return Encrypt(message, key);
        }
    }

    public static class Vizhiner
    {
        static String alfabet = "абвгдеєжзиіїйклмнопрстуфхцчшщьюя ы";
        public static string Encrypt(String message, String key)
        {
            String After = "";
            message = message.ToLower();
            key = key.ToLower();
            int j = -1;
            for (int i = 0; i < message.Length; i++)
            {
                j = ((j+1) % key.Length);
                if (alfabet.IndexOf(message[i]) < 0)
                {
                    After += message[i];
                    continue;
                }
                Int32 newPos = (alfabet.IndexOf(message[i]) + alfabet.IndexOf(key[j])) % alfabet.Length;
                After = After + alfabet[newPos];
            }
            return After;
        }

        public static string Decrypt(String message, String key)
        {
            String After = "";
            message = message.ToLower();
            key = key.ToLower();
            for (int i = 0, j = -1; i < message.Length; i++)
            {
                j = ((j + 1) % key.Length);
                if (alfabet.IndexOf(message[i]) < 0)
                {
                    After += message[i];
                    continue;
                }
                Int32 newPos = (alfabet.IndexOf(message[i]) - alfabet.IndexOf(key[j]) + alfabet.Length) % alfabet.Length;
                After = After + alfabet[newPos];
            }
            return After;
        }
    }

    public static class Analyzer
    {
        static String alfabet = "абвгдеєжзиіїйклмнопрстуфхцчшщьюя";
        public static String StatAnalyze(String message)
        {
            Int32[] mas = new Int32[32];
            Double[] jmov = new Double[32];
            int max = 0, maxind = 0, jmaxind = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = 0;
            }
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] != ' ' && alfabet.IndexOf(message[i]) > -1)
                    mas[alfabet.IndexOf(message[i])]++;
            }
            for (int i = 0; i < 32; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    maxind = i;
                }
                jmov[i] = (double)mas[i] / (double)message.Length;
                if (jmov[i] > 0.075 && jmov[i] < 0.085)
                {
                    jmaxind = i;
                }
            }
            String result = "";
            for (int i = 0; i < alfabet.Length; i++)
            {
                result = result + alfabet[i] + ":" + mas[i];
                int magick = Convert.ToInt32((double)mas[i] / max * 100);
                for (int j = 0; j < magick; j++)
                {
                    result = result + "*";
                }
                result = result + "\r\n";
            }
            int secret = (maxind + 1 % alfabet.Length);
            return result + "Зсув: " + secret + "\r\n";
        }
    }
    
    public static class RSA
    {
        static String alfabet = "абвгдеєжзиіїйклмнопрстуфхцчшщьюя ";
        public static string Encrypt(String message, Int32 p, Int32 q)
        {
            String After = "";
            message = message.ToLower();
            BigInteger n = p * q;
            BigInteger Eiler = (p-1) * (q-1);
            Int32 exp = 7;
            //Int32 d = (Int32)((exp ^ (-1))%Eiler);
            Int32 d = 3;
            foreach (var item in message)
            {
                BigInteger crypted = (alfabet.IndexOf(item));
                if (crypted > -1)
                {
                    crypted = (BigInteger.Pow(crypted, exp)) % n;
                }
                After = After + crypted + " ";
            }
            return After + "::" + d + "::" + n;
        }

        public static string Decrypt(string message, Int32 d, Int32 n)
        {
            String After = "";
            MatchCollection encrypted = Form1.MyParse(message);
            BigInteger rez = 0;
            foreach(Match match in encrypted)
            {
                rez = Int32.Parse(match.Value);
                rez = (Int32)(BigInteger.Pow(rez, d)) % n;
                After = After + alfabet[(Int32)rez];
            }
            return After;
        }
    }

    public partial class Form1 : System.Windows.Forms.Form
    {
        public static MatchCollection MyParse(String str)
        {
            const string myReg = @"[0-9]+\s";
            MatchCollection myMatch = Regex.Matches(str, myReg);
            return myMatch;
        }

        public Form1()
        {
            
              InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbAfter.Text = Caesar.Encrypt(tbBefore.Text, Convert.ToInt32(tbZsuv.Text));
            //tbAfter.Text = Vizhiner.Encrypt(tbBefore.Text, "БЕГ");
            //tbAfter.Text = RSA.Encrypt(tbBefore.Text, 7, 11);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            tbBefore.Text = Caesar.Decrypt(tbAfter.Text, Convert.ToInt32(tbZsuv.Text));
            //tbBefore.Text = Vizhiner.Decrypt(tbAfter.Text, "БЕГ");
            //tbBefore.Text = RSA.Decrypt(tbAfter.Text,3,33);
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            tbAnalyze.Text = Analyzer.StatAnalyze(tbAfter.Text);
        } 
    }
}

/*1009	1013	1019	1021	1031	1033	1039	1049	1051	1061	1063	1069
1087	1091	1093	1097	1103	1109	1117	1123	1129	1151	1153	1163	1171	1181	1187	1193	1201	1213	1217	1223
1229	1231	1237	1249	1259	1277	1279	1283	1289	1291	1297	1301	1303	1307	1319	1321	1327	1361	1367	1373
1381	1399	1409	1423	1427	1429	1433	1439	1447	1451	1453	1459	1471	1481	1483	1487	1489	1493	1499	1511
1523	1531	1543	1549	1553	1559	1567	1571	1579	1583	1597	1601	1607	1609	1613	1619	1621	1627	1637	1657
1663	1667	1669	1693	1697	1699	1709	1721	1723	1733	1741	1747	1753	1759	1777	1783	1787	1789	1801	1811
1823	1831	1847	1861	1867	1871	1873	1877	1879	1889	1901	1907	1913	1931	1933	1949	1951	1973	1979	1987
1993	1997	1999	2003	2011	2017	2027	2029	2039	2053	2063	2069	2081	2083	2087	2089	2099	2111	2113	2129
2131	2137	2141	2143	2153	2161	2179	2203	2207	2213	2221	2237	2239	2243	2251	2267	2269	2273	2281	2287
2293	2297	2309	2311	2333	2339	2341	2347	2351	2357	2371	2377	2381	2383	2389	2393	2399	2411	2417	2423
2437	2441	2447	2459	2467	2473	2477	2503	2521	2531	2539	2543	2549	2551	2557	2579	2591	2593	2609	2617
2621	2633	2647	2657	2659	2663	2671	2677	2683	2687	2689	2693	2699	2707	2711	2713	2719	2729	2731	2741
2749	2753	2767	2777	2789	2791	2797	2801	2803	2819	2833	2837	2843	2851	2857	2861	2879	2887	2897	2903
2909	2917	2927	2939	2953	2957	2963	2969	2971	2999	3001	3011	3019	3023	3037	3041	3049	3061	3067	3079
3083	3089	3109	3119	3121	3137	3163	3167	3169	3181	3187	3191	3203	3209	3217	3221	3229	3251	3253	3257
3259	3271	3299	3301	3307	3313	3319	3323	3329	3331	3343	3347	3359	3361	3371	3373	3389	3391	3407	3413
3433	3449	3457	3461	3463	3467	3469	3491	3499	3511	3517	3527	3529	3533	3539	3541	3547	3557	3559	3571
*/

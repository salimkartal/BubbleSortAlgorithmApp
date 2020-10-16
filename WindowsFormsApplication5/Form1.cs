using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int[] Kabarcik_Siralama_Algoritmasi(int[] islenecekDizi)
        {
            
            int gecici = 0;
            for (int i = 0; i < islenecekDizi.Count(); i++)
            {
                
                for (int j = 0; j < islenecekDizi.Count() - (i + 1); j++)
                {
                    if (islenecekDizi[j] > islenecekDizi[(j + 1)])
                    {
                        gecici = islenecekDizi[j];
                        islenecekDizi[j] = islenecekDizi[j + 1];
                        islenecekDizi[j + 1] = gecici;
                    }

                    //diziyi yazdırma
                    foreach (int eleman in islenecekDizi)
                        Console.Write(eleman + " ");

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            return islenecekDizi;
        }

        int tik=0;
        private void button1_Click(object sender, EventArgs e)
        {
            tik++;
            int[] dizi = new int[6];
            int a = Convert.ToInt32(textBox1.Text);
            dizi[0] = a;
            int b = Convert.ToInt32(textBox2.Text);
            dizi[1] = b;
            int c = Convert.ToInt32(textBox3.Text);
            dizi[2] = c;
            int d = Convert.ToInt32(textBox4.Text);
            dizi[3] = d;
            int f = Convert.ToInt32(textBox5.Text);
            dizi[4] = f;
            int g = Convert.ToInt32(textBox6.Text);
            dizi[5] = g;


            dizi = Kabarcik_Siralama_Algoritmasi(dizi);

            SAYILAR.Items.Clear();
            for (int i = 0; i < dizi.Length-4 ; i++)
            {
                if (tik == 1)
                {
                    SAYILAR.Items.Add(dizi[i]);
                    label1.Text="Sayi en baştan yanındaki ile karşılaştırılıp ilerliyor";
                }

            }
            for (int i = 0; i < dizi.Length-2 ; i++)
            {
                if (tik == 2)
                {
                    SAYILAR.Items.Add(dizi[i]);
                    label1.Text = "Sonra dizinin sonuna kadar böyle devam edip \ntekrardan en baştan karşılaştırma yapıyor";
                }

            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (tik == 3)
                {
                    SAYILAR.Items.Add(dizi[i]);
                    label1.Text = "Sonuçta 3 aşamada bu sıralama işlemi tamamlanmış oluyor:\nZaman Karmaşıklığı: n^2 +7 \nBüyük O Notasyonu: best-case: O(n) worst-case: O(n^2)";
                }

            }
        }
    } 
}
    


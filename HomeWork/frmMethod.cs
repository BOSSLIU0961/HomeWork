using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class frmMethod : Form
    {
        public frmMethod()
        {
            InitializeComponent();
        }

        private void btnOddNumber_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(txtOddNumber.Text);
                if( i % 2 == 0 )
                {
                    labResult.Text = $"數入的數 {i} 為 偶數";
                }
                else 
                {
                    labResult.Text = $"數入的數 {i} 為 奇數";
                }
            }
            catch
            {
                MessageBox.Show($"請輸入數值");
            }
        }
        
        private void btnArrayOdd_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    a += 1;
                }
                else
                {
                    b += 1; 
                }
            }
            labResult.Text = $"int陣列arr0711[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]\r\n奇數為{ b }\r\n偶數為{ a }"; 
        }

        private void btnBigSmall_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            labResult.Text = $"int陣列arr0711[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]\r\n最大值為{arr.Max()}\r\n最小值為{arr.Min()}";
        }

        private void btnTheLongestName_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4] {"愛","愛新","愛新覺","愛新覺羅"};
            labResult.Text = $"陣列arr0711 : 愛,愛新,愛新覺,覺新覺羅\r\n最大值為{arr.Max()}\r\n最小值為{arr.Min()}";
        }

        private void btnNameWithLove_Click(object sender, EventArgs e)
        {
            string[] arr = new string[6] { "鰲拜","愛", "愛新", "愛新覺", "愛新覺羅","韋小寶" };
            int a = 0;
            int b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains("愛"))
                {
                    a += 1;
                }
                if(arr[i].Contains("寶"))
                {
                    b += 1;
                }
            }
            labResult.Text = $"陣列arr0711 : 鰲拜,愛, 愛新, 愛新覺, 愛新覺羅,韋小寶\r\n有「愛」跟「寶」的名字一共有{ a + b }個";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果 : ";
        }

        private void btnArrayBoarderOne_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < 10; i++) 
            {
                for(int j = 0; j < 10; j++)
                {
                    if(i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        result += " 1 ";
                    }
                    else
                    {
                        result += " 0 ";
                    }
                }
                result += "\r\n";
            }
            labResult.Text = result;
        }

        private void btnArrayBoarderZero_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        result += " 0 ";
                    }
                    else
                    {
                        result += " 1 ";
                    }
                }
                result += "\r\n";
            }
            labResult.Text = result;
        }

        private void btnOneZeroCross_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //result += (i + j + 1) % 2;
                    if ((i + j) % 2 == 0)
                    {
                        result += " 1 ";
                    }
                    else
                    {
                        result += " 0 ";
                    }
                }
                result += "\r\n";
            }
            labResult.Text = result;
        }

        void swap(ref int a,ref int b)
        {
            int i = a;
            a = b;
            b = i;
        }
        private void btnSwap_Click(object sender, EventArgs e)
        {
            int a = 0 , b = 1;
            labResult.Text = $"換位前 a = {a},b = {b}";
            swap(ref a,ref b);
            labResult.Text += $"\r\n換位前 a = {a},b = {b}";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int result = 0;
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            labResult.Text = $"int陣列arr0711[1,2,3,4,5]\r\n加總為 {result}";
            //等於下方
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //labResult.Text = $"int陣列arr0711[1,2,3,4,5]\r\n加總為 {arr.Sum()}";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int[] arr = new int[5] { 1, 2, 5, 4, 3 };
            //int result = 0;
            //int[] arr = new int[5] { 1, 2, 5, 4, 3 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //if (result<arr[i]) result = arr[i];
            //}
            labResult.Text = $"int陣列arr0711[1,2,3,4,5]\r\n最大值為 {arr.Max()}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int[] arr = new int[5] { 1, 2, 5, 4, 3 };
            labResult.Text = $"int陣列arr0711[1,2,3,4,5]\r\n最小值為 {arr.Min()}";
        }
    }
}

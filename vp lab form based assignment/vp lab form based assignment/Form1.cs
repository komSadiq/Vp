using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vp_lab_assiment_form_base
{
    public partial class Form1 : Form
    {
        public static string alphabetLowCase = "abcdefghijklmnopqrstuvwxyz";
        public static string alphabetUpCase = "ABCDEFGHIJKLMNOPQRSTUVWXYS";


        public Form1()
        {
            InitializeComponent();

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder(); //used for maitaining string 
                if (txtBoxInput.Text != "")
                {
                    string input = txtBoxInput.Text.ToString();
                    int key = int.Parse(txtBoxKey.Text.ToString());
                    char[] arry = input.ToCharArray();
                    int result;
                    for (int i = 0; i < arry.Length; i++)
                    {
                        if (Char.IsLower(arry[i]))
                        {
                            if (key >= 0 && key < 26)
                            {
                                result = alphabetLowCase.IndexOf(arry[i]) + key;
                                if (result >= 26)
                                {
                                    result = result % 26;
                                }
                                sb.Append(alphabetLowCase[result]);
                            }
                            else
                            {
                                key = key % 26;
                                result = alphabetLowCase.IndexOf(arry[i]) + key;
                                sb.Append(arry[result]);
                            }

                        }
                        else if (Char.IsUpper(arry[i]))
                        {
                            if (key >= 0 && key < 26)
                            {
                                result = alphabetUpCase.IndexOf(arry[i]) - key;
                                if (result >= 26)
                                {
                                    result = result % 26;
                                }
                                sb.Append(alphabetUpCase[result]);
                            }
                            else
                            {
                                key = key % 26;
                                result = alphabetUpCase.IndexOf(arry[i]) - key;
                                sb.Append(arry[result]);
                                sb.Append("");
                            }
                        }
                        else
                        {
                            sb.Append(arry[i]);
                        }
                    }
                }

                txtBoxResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (txtBoxResult.Text != "")
                {
                    string input = txtBoxResult.Text.ToString();
                    int key = int.Parse(txtBoxKey.Text.ToString());
                    char[] arry = input.ToCharArray();
                    int result;
                    for (int i = 0; i < arry.Length; i++)
                    {
                        if (Char.IsLower(arry[i]))
                        {
                            if (key >= 0 && key < 26)
                            {
                                result = alphabetLowCase.IndexOf(arry[i]) - key;
                                if (result >= 26)
                                {
                                    result = result % 26;
                                }
                                if(result<0)
                                {
                                    result = result + 26;
                                }
                                sb.Append(alphabetLowCase[result]);
                            }
                            else
                            {
                                key = key % 26;
                                result = alphabetLowCase.IndexOf(arry[i]) - key;
                                sb.Append(arry[result]);
                            }

                        }
                        else if (Char.IsUpper(arry[i]))
                        {
                            if (key >= 0 && key < 26)
                            {
                                result = alphabetUpCase.IndexOf(arry[i]) - key;
                                if (result >= 26)
                                {
                                    result = result % 26;
                                }
                                sb.Append(alphabetUpCase[result]);
                            }
                            else
                            {
                                key = key % 26;
                                result = alphabetUpCase.IndexOf(arry[i]) - key;
                                sb.Append(arry[result+key]);
                                sb.Append("");
                            }
                        }
                        else
                        {
                            sb.Append(arry[i]);

                        }
                    }
                }
                txtBoxResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}







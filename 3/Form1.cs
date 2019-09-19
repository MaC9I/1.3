using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        int X;
        int Y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            X = Convert.ToInt16(rnd.Next(500));
            Y = Convert.ToInt16(rnd.Next(400));
        }
        string attemps = " попытка № 0";
        private void Form1_Click(object sender, EventArgs e)
        {
            string text = Text                                                                                                                         ;
            text = Text.Remove(Text.IndexOf("»")+1)                                                                                ;
            int attempsint = Convert.ToInt32(attemps.Remove(0, attemps.LastIndexOf(" ")))                                                         ;
            attemps=attemps.Remove(attemps.LastIndexOf(" ")+1)                                                              ;
            attempsint++                                                                                                                   ;
            attemps = attemps + attempsint                                                             ;
            text = text + attemps                                                                         ;
            Text = text                                                                                                                                 ;
            int CorentPosX =X - PointToClient(Cursor.Position).X                                                                                     ;
            int CorentPosY =Y - PointToClient(Cursor.Position).Y                                                                                   ;
            int rad = CorentPosX * CorentPosX + CorentPosY * CorentPosY                                                                                ;
            int ball = (rad / 900)                                                                                                         ;
            if (ball<10)                                                                                                                       {
                BackColor = Color.FromArgb(ball * 25, ball * 25, ball * 25)                                                                               ;}
            else                                                                                                                             {
                BackColor = Color.FromArgb(255, 255, 255)                                                                                                        ;}
            ball =10 - ball                                                                                                                   ;
            Random rnd = new Random()                                                                                       ;
            if (rad <=900)                                                                                                                        {
                MessageBox.Show("Количество выбитых вами очков: " + 10 + "\n Вы попали в центр мишени!"+"\nПотраченое количество попыток: "+ attempsint)             ;
                X = Convert.ToInt16(rnd.Next(500))                                                                                                                       ;
                Y = Convert.ToInt16(rnd.Next(400))                                                                                                                       ;
                BackColor = Color.FromArgb(255, 255, 255)                                                                                                         ;
                Text = "«Лаб. раб. №1_3. Юсуф Максим» "                                                                                                                      ;
                attemps = " попытка № 0"                                                                                                                    ;
                                                                                                                                                         }
            else                                                                                                                                     {
                if (rad <= 9000)                                                                                                                           {
                    this.Text = Text+' '+ ball+" очков"                                                                                                   ; ;
                                                                                                                                                                     }}
        }
    }
}

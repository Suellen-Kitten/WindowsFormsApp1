using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //para o código funcionar é só tirar os "//" ou "/*" e "*/" respectivos

            // concatenação

            //MessageBox.Show("Hello Word");

            /*string mensagem = "Minha Mensagem";
            MessageBox.Show(mensagem); */

            /*String mensagem = "Olá ";
            String nome = "Victor";
            MessageBox.Show(mensagem + nome);*/

            /*int idade = 25;
            string mensagem = "sua idade é: " + idade;
            MessageBox.Show(mensagem);*/

            /*double saldo = 100.0;
            string mensagem = "seu saldo é: " + saldo;
            MessageBox.Show(mensagem);*/

            //ATIVIDADE 1

            /*int idadeJoao = 10;
            int iadeMaria = 25;
            int idadeSuh = 18;
            int idadeSoma = idadeJoao + iadeMaria + idadeSuh;
            int idadeMediaAredondada = (idadeSoma /= 3);
            string mensagem = "Seu resultado é: " + idadeMediaAredondada;
            MessageBox.Show(mensagem);*/

            //ATIVIDADE 2

            /*int pi = 3.14;
            string mensagem = "sua mensagem é: " + pi;*/
            // não tem como fazer um MessageBox.Show(mensagem);
            // não é possivel converter implicitante tipo "double" em "int".

            //ATIVIDADE 3

            /*double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQeubrado = " + piQuebrado);*/

            //ATIVIDADE 4

            /*int a = 1;
            int b = 8;
            int c = -9;

            double delta = (b * b) - (4 * a * c);
            //usar um double raiz ajuda na hora de por a raiz funcionando
            double raiz = Math.Sqrt(delta);
            //usar o var? mas na atividade pede double, então fica double
            //mas poderia ser  
            //double valor = ((-(b)) + Math.Sqrt(delta)) / (2 * a)
            double a1 = ((-(b)) + raiz) / (2 * a);
            double a2 = ((-(b)) - raiz) / (2 * a);

            string A1 = "seu valor de X': " + a1;
            string A2 = "seu valor X'': " + a2;

            MessageBox.Show(A1);
            MessageBox.Show(A2);*/

            MessageBox.Show("Prezer sou o BOTÃO 1");
        }

        //Lembre-se de que se foi apagar o botão 2 tens q apagar preiro onde ele foi criado no Form1.cs[Design]

        private void button2_Click(object sender, EventArgs e)
        {
            //#botão extra, você pode por cada valor em um botao A1 no 1 e A2 no 2 ou da forma que quiser sem tirar a funcionalidade,
            //ou deixar o mesmo botão com 2 respota, esse resultará em 2 alertas um seguido do outro.
            MessageBox.Show("Prazer sou o BOTÃO 2");
        }
    }
}

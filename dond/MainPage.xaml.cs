using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace dond
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public class Box
    {
        public int Number { get; set; }
        public double Cash { get; set; }
        public int Cashid { get; set; }

        public Box(int number, double cash, int cashid)
        {

            Number = number;
            Cash = cash;
            Cashid = cashid;
        }

    }

    public sealed partial class MainPage : Page
    {
        //public Box box0 = new Box(0, 0, 0);

        Box[] caseArray = new Box[26];
        public int round = 0;
        public int chosencase { get; set; }
        double totalCash = 3418416.01;
        public int totalCases = 25;
        public int allcase = 326;
        public int chosenid { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void playbtn_Click(object sender, RoutedEventArgs e)
        {
            cover.Visibility = Visibility.Collapsed;
            playbtn.Visibility = Visibility.Collapsed;
            logo.Visibility = Visibility.Collapsed;
            shuffle();
        }

        public void shuffle()
        {
            Random rnd = new Random();
            double[] array = new double[26];
            int[] array2 = new int[26];
            int a = 0;
            var cash = new List<double>()
        {
            0.01,
            1,
            5,
            10,
            25,
            50,
            75,
            100,
            200,
            300,
            400,
            500,
            750,
            1000,
            5000,
            10000,
            25000,
            50000,
            75000,
            100000,
            200000,
            300000,
            400000,
            500000,
            750000,
            1000000,
        };
            List<int> cashids = new List<int>();
            for (int i = 0; i <= 25; i++)
            {
                cashids.Add(i);
            }


            for (int i = 25; i >= 0; i--)
            {
                int b = rnd.Next(0, i + 1);
                array2[a] = cashids[b];
                array[a] = cash[array2[a]];
                caseArray[a] = new Box(a + 1, array[a], array2[a] + 1);
                cashids.RemoveAt(b);
                a++;

            }




        }

        public void Strike(int a)
        {
            if (caseArray[a - 1].Cashid == 1)
                strikeid0.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 2)
                strikeid1.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 3)
                strikeid2.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 4)
                strikeid3.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 5)
                strikeid4.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 6)
                strikeid5.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 7)
                strikeid6.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 8)
                strikeid7.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 9)
                strikeid8.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 10)
                strikeid9.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 11)
                strikeid10.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 12)
                strikeid11.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 13)
                strikeid12.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 14)
                strikeid13.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 15)
                strikeid14.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 16)
                strikeid15.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 17)
                strikeid16.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 18)
                strikeid17.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 19)
                strikeid18.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 20)
                strikeid19.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 21)
                strikeid20.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 22)
                strikeid21.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 23)
                strikeid22.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 24)
                strikeid23.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 25)
                strikeid24.Visibility = Visibility.Visible;
            if (caseArray[a - 1].Cashid == 26)
                strikeid25.Visibility = Visibility.Visible;

        }

        public void boxSelected(int a)
        {
            cover2.Visibility = Visibility.Visible;
            opencase.Visibility = Visibility.Visible;
            next.Visibility = Visibility.Visible;
            chosenshow.Visibility = Visibility.Visible;
            chosenshow.Text = "$" + Convert.ToString(caseArray[a - 1].Cash);
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            cover2.Visibility = Visibility.Collapsed;
            opencase.Visibility = Visibility.Collapsed;
            next.Visibility = Visibility.Collapsed;
            chosenshow.Visibility = Visibility.Collapsed;
            chosenshow.Text = "";
            if (round == 8 || round == 14 || round == 18 || round == 21 || round == 23 || round == 24)
            {
                bank();
            }
            if (round == 25)
                final();

        }

        public void phase1(int a)
        {
            message.Text = "Choose 7 cases to open";
            chosencase = a - 1;
            chosen.Content = Convert.ToString(caseArray[chosencase].Number);
            chosenid = a;
            allcase -= (a - 1);
            round++;
        }

        public void phase2(int a)
        {
            if (round == 1)
                message.Text = "Choose 6 more cases to open";
            if (round == 2 || round == 8)
                message.Text = "Choose 5 more cases to open";
            if (round == 3 || round == 9)
                message.Text = "Choose 4 more cases to open";
            if (round == 4 || round == 10 || round == 14)
                message.Text = "Choose 3 more cases to open";
            if (round == 5 || round == 11 || round == 15 || round == 18)
                message.Text = "Choose 2 more cases to open";
            if (round == 6 || round == 12 || round == 16 || round == 19 || round == 21)
                message.Text = "Choose 1 more case to open";
            if (round == 7)
                message.Text = "Choose 6 cases to open";
            if (round == 13)
                message.Text = "Choose 4 cases to open";
            if (round == 17)
                message.Text = "Choose 3 cases to open";
            if (round == 20)
                message.Text = "Choose 2 cases to open";
            if (round == 22 || round == 23)
                message.Text = "Choose 1 case to open";
            totalCash -= caseArray[a - 1].Cash;
            totalCases--;
            allcase -= (a - 1);
            Strike(a);
            boxSelected(a);
            round++;


        }

        public void bank()
        {
            cover2.Visibility = Visibility.Visible;
            deal.Visibility = Visibility.Visible;
            nodeal.Visibility = Visibility.Visible;
            banker.Visibility = Visibility.Visible;
            offer.Visibility = Visibility.Visible;
            bankerimg.Visibility = Visibility.Visible;
            offer.Text = "Their offer is: $" + Convert.ToString(Math.Round(totalCash / totalCases, 2));
        }

        public void final()
        {
            cover2.Visibility = Visibility.Visible;
            banker.Visibility = Visibility.Visible;
            banker.Text = "Switch or Keep?";
            offer.Visibility = Visibility.Visible;
            offer.Text = "Click on the luckier case!";
            finalcase1.Visibility = Visibility.Visible;
            finalcase2.Visibility = Visibility.Visible;
            finalcasen1.Visibility = Visibility.Visible;
            finalcasen1.Content = Convert.ToString(caseArray[chosencase].Number);
            finalcasen2.Visibility = Visibility.Visible;
            finalcasen2.Content = Convert.ToString(allcase);


        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(1);
            else if (round >= 1 && round <= 24)
                phase2(1);

            one.Visibility = Visibility.Collapsed;
            c1.Visibility = Visibility.Collapsed;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(2);
            else if (round >= 1 && round <= 24)
                phase2(2);
            else
            {
                final();
            }

            two.Visibility = Visibility.Collapsed;
            c2.Visibility = Visibility.Collapsed;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(3);
            else if (round >= 1 && round <= 24)
                phase2(3);
            else
            {
                final();
            }

            three.Visibility = Visibility.Collapsed;
            c3.Visibility = Visibility.Collapsed;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(4);
            else if (round >= 1 && round <= 24)
                phase2(4);
            else
            {
                final();
            }

            four.Visibility = Visibility.Collapsed;
            c4.Visibility = Visibility.Collapsed;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(5);
            else if (round >= 1 && round <= 24)
                phase2(5);
            else
            {
                final();
            }

            five.Visibility = Visibility.Collapsed;
            c5.Visibility = Visibility.Collapsed;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(6);
            else if (round >= 1 && round <= 24)
                phase2(6);
            else
            {
                final();
            }

            six.Visibility = Visibility.Collapsed;
            c6.Visibility = Visibility.Collapsed;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(7);
            else if (round >= 1 && round <= 24)
                phase2(7);
            else
            {
                final();
            }

            seven.Visibility = Visibility.Collapsed;
            c7.Visibility = Visibility.Collapsed;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(8);
            else if (round >= 1 && round <= 24)
                phase2(8);
            else
            {
                final();
            }

            eight.Visibility = Visibility.Collapsed;
            c8.Visibility = Visibility.Collapsed;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(9);
            else if (round >= 1 && round <= 24)
                phase2(9);
            else
            {
                final();
            }

            nine.Visibility = Visibility.Collapsed;
            c9.Visibility = Visibility.Collapsed;
        }

        private void ten_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(10);
            else if (round >= 1 && round <= 24)
                phase2(10);
            else
            {
                final();
            }

            ten.Visibility = Visibility.Collapsed;
            c10.Visibility = Visibility.Collapsed;
        }

        private void eleven_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(11);
            else if (round >= 1 && round <= 24)
                phase2(11);
            else
            {
                final();
            }

            eleven.Visibility = Visibility.Collapsed;
            c11.Visibility = Visibility.Collapsed;
        }

        private void twelve_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(12);
            else if (round >= 1 && round <= 24)
                phase2(12);
            else
            {
                final();
            }

            twelve.Visibility = Visibility.Collapsed;
            c12.Visibility = Visibility.Collapsed;
        }

        private void thirteen_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(13);
            else if (round >= 1 && round <= 24)
                phase2(13);
            else
            {
                final();
            }

            thirteen.Visibility = Visibility.Collapsed;
            c13.Visibility = Visibility.Collapsed;
        }

        private void fourteen_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(14);
            else if (round >= 1 && round <= 24)
                phase2(14);
            else
            {
                final();
            }

            fourteen.Visibility = Visibility.Collapsed;
            c14.Visibility = Visibility.Collapsed;
        }

        private void fifteen_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(15);
            else if (round >= 1 && round <= 24)
                phase2(15);
            else
            {
                final();
            }

            fifteen.Visibility = Visibility.Collapsed;
            c15.Visibility = Visibility.Collapsed;
        }

        private void sixteen_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(16);
            else if (round >= 1 && round <= 24)
                phase2(16);
            else
            {
                final();
            }

            sixteen.Visibility = Visibility.Collapsed;
            c16.Visibility = Visibility.Collapsed;
        }

        private void seventeen_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(17);
            else if (round >= 1 && round <= 24)
                phase2(17);
            else
            {
                final();
            }

            seventeen.Visibility = Visibility.Collapsed;
            c17.Visibility = Visibility.Collapsed;
        }

        private void eighteen_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(18);
            else if (round >= 1 && round <= 24)
                phase2(18);
            else
            {
                final();
            }

            eighteen.Visibility = Visibility.Collapsed;
            c18.Visibility = Visibility.Collapsed;
        }

        private void nineteen_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(19);
            else if (round >= 1 && round <= 24)
                phase2(19);
            else
            {
                final();
            }

            nineteen.Visibility = Visibility.Collapsed;
            c19.Visibility = Visibility.Collapsed;
        }

        private void twenty_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(20);
            else if (round >= 1 && round <= 24)
                phase2(20);
            else
            {
                final();
            }

            twenty.Visibility = Visibility.Collapsed;
            c20.Visibility = Visibility.Collapsed;
        }

        private void twentyone_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(21);
            else if (round >= 1 && round <= 24)
                phase2(21);
            else
            {
                final();
            }

            twentyone.Visibility = Visibility.Collapsed;
            c21.Visibility = Visibility.Collapsed;
        }

        private void twentytwo_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(22);
            else if (round >= 1 && round <= 24)
                phase2(22);
            else
            {
                final();
            }

            twentytwo.Visibility = Visibility.Collapsed;
            c22.Visibility = Visibility.Collapsed;
        }

        private void twentythree_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(23);
            else if (round >= 1 && round <= 24)
                phase2(23);
            else
            {
                final();
            }

            twentythree.Visibility = Visibility.Collapsed;
            c23.Visibility = Visibility.Collapsed;
        }

        private void twentyfour_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(24);
            else if (round >= 1 && round <= 24)
                phase2(24);
            else
            {
                final();
            }

            twentyfour.Visibility = Visibility.Collapsed;
            c24.Visibility = Visibility.Collapsed;
        }

        private void twentyfive_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(25);
            else if (round >= 1 && round <= 24)
                phase2(25);
            else
            {
                final();
            }

            twentyfive.Visibility = Visibility.Collapsed;
            c25.Visibility = Visibility.Collapsed;
        }

        private void twentysix_Click(object sender, RoutedEventArgs e)
        {
            if (round == 0)
                phase1(26);
            else if (round >= 1 && round <= 24)
                phase2(26);
            else
            {
                final();
            }

            twentysix.Visibility = Visibility.Collapsed;
            c26.Visibility = Visibility.Collapsed;
        }

        private void nodeal_Click(object sender, RoutedEventArgs e)
        {
            cover2.Visibility = Visibility.Collapsed;
            offer.Visibility = Visibility.Collapsed;
            offer.Text = "";
            banker.Visibility = Visibility.Collapsed;
            deal.Visibility = Visibility.Collapsed;
            nodeal.Visibility = Visibility.Collapsed;
            bankerimg.Visibility = Visibility.Collapsed;
            if (round == 25)
                final();
        }

        private void deal_Click(object sender, RoutedEventArgs e)
        {
            banker.Text = String.Format("You've won ${0}!", Convert.ToString(Math.Round(totalCash / totalCases, 2)));
            offer.Text = "Click your case to see what was inside";
            finish.Visibility = Visibility.Visible;
            deal.Visibility = Visibility.Collapsed;
            nodeal.Visibility = Visibility.Collapsed;
            reveal.Visibility = Visibility.Visible;
            revealcase.Visibility = Visibility.Visible;
            bankerimg.Visibility = Visibility.Collapsed;
            reveal.Content = caseArray[chosencase].Number;

        }

        private void finish_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void reveal_Click(object sender, RoutedEventArgs e)
        {
            revealopen.Visibility = Visibility.Visible;
            revealcash.Visibility = Visibility.Visible;
            revealcash.Text = "$" + Convert.ToString(caseArray[chosencase].Cash);
            reveal.Visibility = Visibility.Collapsed;
            revealcase.Visibility = Visibility.Collapsed;
        }

        private void finalcasen1_Click(object sender, RoutedEventArgs e)
        {
            finalcash1.Visibility = Visibility.Visible;
            finalcash1.Text = "$" + Convert.ToString(caseArray[chosencase].Cash);
            finalreveal1.Visibility = Visibility.Visible;
            finalcash2.Visibility = Visibility.Visible;
            finalcase1.Visibility = Visibility.Collapsed;
            finalcasen1.Visibility = Visibility.Collapsed;
            finish.Visibility = Visibility.Visible;
            banker.Text = String.Format("You've won ${0}!", Convert.ToString(caseArray[chosencase].Cash));
            offer.Text = "";
        }

        private void finalcasen2_Click(object sender, RoutedEventArgs e)
        {
            finalcash2.Visibility = Visibility.Visible;
            finalcash2.Text = "$" + Convert.ToString(caseArray[allcase - 1].Cash);
            finalreveal2.Visibility = Visibility.Visible;
            finalcash1.Visibility = Visibility.Visible;
            finalcase2.Visibility = Visibility.Collapsed;
            finalcasen2.Visibility = Visibility.Collapsed;
            finish.Visibility = Visibility.Visible;
            banker.Text = String.Format("You've won ${0}!", Convert.ToString(caseArray[allcase - 1].Cash));
            offer.Text = "";
        }
    }
}

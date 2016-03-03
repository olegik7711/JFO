using JFO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;
namespace JFO.Views
{
    /// <summary>
    /// Логика взаимодействия для Calculator.xaml
    /// </summary>
    public partial class Calculator : Page
    {
      decimal Plotnost20;
         decimal Plotnost15;
        decimal Prelomlenie;
        decimal PoverkhNatiajenie;
        decimal MolnObem;

         decimal PlotnostAPI;
         decimal NizTeploteSgor;
        decimal MoolekMassa;
         decimal LCH;
         decimal Vodorod;
         decimal Uglerod;
        decimal Vnp;
         decimal FactorNasa;

        ToCalculate calc;
        public Calculator()
        {
            InitializeComponent();
           
            calc = new ToCalculate();
        }
        //расчет 
        private void CulculateBtn_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (Plotnost20Text.Text == "")
                { Plotnost20 = 0; }
                else
                { Plotnost20 = Convert.ToDecimal(Plotnost20Text.Text); }
                if (Plotnost15Text.Text == "")
                { Plotnost15 = 0; }
                else
                { Plotnost15 = Convert.ToDecimal(Plotnost15Text.Text); }
                if (PokazatelPrelomleniaText.Text == "")
                { Prelomlenie = 0; }
                else
                { Prelomlenie = Convert.ToDecimal(PokazatelPrelomleniaText.Text); }
                if (PoverhnNatiajText.Text == "")
                { PoverkhNatiajenie = 0; }
                else
                { PoverkhNatiajenie = Convert.ToDecimal(PoverhnNatiajText.Text); }
                if (MolniyObiemText.Text == "")
                { MolnObem = 0; }
                else
                { MolnObem = Convert.ToDecimal(MolniyObiemText.Text); }
                if (PlotnostAPIText.Text == "")
                { PlotnostAPI = 0; }
                else
                { PlotnostAPI = Convert.ToDecimal(PlotnostAPIText.Text); }
                if (NizTeplotSgorText.Text == "")
                { NizTeploteSgor = 0; }
                else
                { NizTeploteSgor = Convert.ToDecimal(NizTeplotSgorText.Text); }
                if (MoularnajaMassaText.Text == "")
                { MoolekMassa = 0; }
                else
                { MoolekMassa = Convert.ToDecimal(MoularnajaMassaText.Text); }
                if (LCHText.Text == "")
                { LCH = 0; }
                else
                { LCH = Convert.ToDecimal(LCHText.Text); }
                if (VodorodText.Text == "")
                { Vodorod = 0; }
                else
                { Vodorod = Convert.ToDecimal(VodorodText.Text); }
                if (UglerodText.Text == "")
                { Uglerod = 0; }
                else
                { Uglerod = Convert.ToDecimal(UglerodText.Text); }
                if (VNPText.Text == "")
                { Vnp = 0; }
                else
                { Vnp = Convert.ToDecimal(VNPText.Text); }
                if (FactorNasaText.Text == "")
                { FactorNasa = 0; }
                else
                { FactorNasa = Convert.ToDecimal(FactorNasaText.Text); }



                if (Plotnost20 == 0 & Plotnost15 != 0)
                {
                    calc.CulculatePoPl15(Plotnost15);
                    Plotnost20 = calc.Plotnost20;
                }
                if (Plotnost20 == 0 & Vnp != 0)
                {
                    calc.CalculatePoVNP(Vnp);
                    Plotnost20 = calc.Plotnost20;
                }
                if
                    (Plotnost20 == 0 & Prelomlenie != 0)
                {
                    calc.Pl20PoPrelomleniu(Prelomlenie);
                    Plotnost20 = calc.Plotnost20;
                }
                if (Plotnost20 == 0 & PoverkhNatiajenie != 0)
                {
                    calc.Pl20poPovrchNat(PoverkhNatiajenie);
                    Plotnost20 = calc.Plotnost20;
                }


                if (Plotnost20 == 0 & Plotnost15 == 0)
                {
                    if (PlotnostAPI != 0)
                    {
                        calc.Pl15PoPlApi(PlotnostAPI);
                        Plotnost15 = calc.Plotnost15;
                        calc.CulculatePoPl15(Plotnost15);
                        Plotnost20 = calc.Plotnost20;
                    }
                    if (Plotnost15 == 0 & NizTeploteSgor != 0)
                    {
                        calc.Pl15PoNizTplSgor(NizTeploteSgor);
                        Plotnost15 = calc.Plotnost15;
                        calc.CulculatePoPl15(Plotnost15);
                        Plotnost20 = calc.Plotnost20;
                    }
                    if (Plotnost15 == 0 & MoolekMassa != 0)
                    {
                        calc.Pl15PoMolekMass(MoolekMassa);
                        Plotnost15 = calc.Plotnost15;
                        calc.CulculatePoPl15(Plotnost15);
                        Plotnost20 = calc.Plotnost20;
                    }

                }


                if (Plotnost20 == 0 & Vnp == 0)
                {
                    if (LCH != 0)
                    {
                        calc.CalculatePoLCH(LCH);
                        Vnp = calc.Vnp;
                        calc.CalculatePoVNP(Vnp);
                        Plotnost20 = calc.Plotnost20;
                    }
                    else if (Vnp == 0 & LCH == 0 & Vodorod != 0)
                    {
                        calc.calculatePoVodorod(Vodorod);
                        LCH = calc.LCH;
                        calc.CalculatePoLCH(LCH);
                        Vnp = calc.Vnp;
                        calc.CalculatePoVNP(Vnp);
                        Plotnost20 = calc.Plotnost20;
                    }
                    else if (Vnp == 0 & LCH == 0 & Vodorod == 0 & Uglerod != 0)
                    {
                        calc.calculatePoUglerod(Uglerod);
                        Vodorod = calc.Vodorod;
                        calc.calculatePoVodorod(Vodorod);
                        LCH = calc.LCH;
                        calc.CalculatePoLCH(LCH);
                        Vnp = calc.Vnp;
                        calc.CalculatePoVNP(Vnp);
                        Plotnost20 = calc.Plotnost20;
                    }
                    else if (Vnp == 0 & LCH == 0 & Vodorod == 0 & Uglerod == 0 & FactorNasa != 0)
                    {
                        calc.calculatePoFactoruNasa(FactorNasa);
                        Uglerod = calc.Uglerod;
                        calc.calculatePoUglerod(Uglerod);
                        Vodorod = calc.Vodorod;
                        calc.calculatePoVodorod(Vodorod);
                        LCH = calc.LCH;
                        calc.CalculatePoLCH(LCH);
                        Vnp = calc.Vnp;
                        calc.CalculatePoVNP(Vnp);
                        Plotnost20 = calc.Plotnost20;
                    }

                }
                #region расчет физ.химии от плотности при 20
                if (Plotnost20 != 0)
                {
                    calc.CulculatePoPl20(Plotnost20);
                    if (Plotnost15 == 0)
                    {
                        Plotnost15 = calc.Plotnost15;
                        calc.CulculatePoPl15(Plotnost15);
                    }
                    else
                    {
                        calc.CulculatePoPl15(Plotnost15);
                    }
                    if (PlotnostAPI == 0)
                    {
                        PlotnostAPI = calc.PlotnostAPI;
                    }
                    if (NizTeploteSgor == 0)
                    {
                        NizTeploteSgor = calc.NizTeploteSgor;
                    }
                    if (MoolekMassa == 0)
                    {
                        MoolekMassa = calc.MoolekMassa;
                    }
                    if (MolnObem == 0)
                    {
                        MolnObem = calc.MolnObem;
                    }
                    if (Prelomlenie == 0)
                    {
                        Prelomlenie = calc.Prelomlenie;
                    }
                    if (PoverkhNatiajenie == 0)
                    {
                        PoverkhNatiajenie = calc.PoverkhNatiajenie;
                    }
                    if (Vnp == 0)
                    { Vnp = calc.Vnp;
                        calc.CalculatePoVNP(Vnp);
                    }
                    else
                    {
                        calc.CalculatePoVNP(Vnp);
                    }
                    if (LCH == 0)
                    {
                        LCH = calc.LCH;
                        calc.CalculatePoLCH(LCH);
                    }
                    else
                    { calc.CalculatePoLCH(LCH); }
                    if (Vodorod == 0)
                    {
                        Vodorod = calc.Vodorod;
                        calc.calculatePoVodorod(Vodorod);
                    }
                    else
                    { calc.calculatePoVodorod(Vodorod); }
                    if (Uglerod == 0)
                    {
                        Uglerod = calc.Uglerod;
                        calc.calculatePoUglerod(Uglerod);
                    }
                    else
                    { calc.calculatePoUglerod(Uglerod); }
                    if (FactorNasa == 0)
                    {
                        FactorNasa = calc.FactorNasa;
                    }

                }
                #endregion
                //если плотрость введена в килограммах переводим ее в граммы
                if (Plotnost20 > 0.999M) { Plotnost20 = Plotnost20 / 1000; }
                if (Plotnost15 > 0.999M) { Plotnost15 = Plotnost15 / 1000; }

                //выводим результаты вычислений
                Plotnost20 = Math.Round(Plotnost20, 4);
                Plotnost20Text.Text = Plotnost20.ToString();
                Plotnost15 = Math.Round(Plotnost15, 4);
                Plotnost15Text.Text = Plotnost15.ToString();
                Vnp = Math.Round(Vnp, 1);
                VNPText.Text = Vnp.ToString();
                Prelomlenie = Math.Round(Prelomlenie, 4);
                PokazatelPrelomleniaText.Text = Prelomlenie.ToString();
                PoverhnNatiajText.Text = PoverkhNatiajenie.ToString();
                MolnObem = Math.Round(MolnObem, 2);
                MolniyObiemText.Text = MolnObem.ToString();
                Vodorod = Math.Round(Vodorod, 3);
                VodorodText.Text = Vodorod.ToString();
                Uglerod = Math.Round(Uglerod, 4);
                UglerodText.Text = Uglerod.ToString();
                LCH = Math.Round(LCH);
                LCHText.Text = LCH.ToString();
                FactorNasa = Math.Round(FactorNasa, 1);
                FactorNasaText.Text = FactorNasa.ToString();
                PlotnostAPI = Math.Round(PlotnostAPI);
                PlotnostAPIText.Text = PlotnostAPI.ToString();
                NizTeploteSgor = Math.Round(NizTeploteSgor);
                NizTeplotSgorText.Text = NizTeploteSgor.ToString();
                MoolekMassa = Math.Round(MoolekMassa, 2);
                MoularnajaMassaText.Text = MoolekMassa.ToString();
           

            #region//график плотности от температуры

            for (double x = -40D; x <= 70D; x++)
            {
                double XotPlotnost = (double)Plotnost20;
                double grafik;
                double grafikX;
                double grafikY;
                grafik = 1000D * XotPlotnost - 0.58 / XotPlotnost * (x - 20D) - (x - 1200D * (XotPlotnost - 0.68)) / 1000D * (x - 20D);
                grafikX = 490D-(4D * grafik - 2870D);
                grafikY = -4D * x + 330D;
                Ellipse el = new Ellipse();
                el.Width = 5;
                el.Height = 5;
                el.StrokeThickness = 1;
                el.Stroke = Brushes.Red;
                el.Fill = Brushes.Red;
                Canvas.SetLeft(el, grafikX);
                Canvas.SetBottom(el, grafikY);
                GraficPlotnostyCanvas.Children.Add(el);
            }
            }
            catch
            {
                System.Windows.MessageBox.Show("Недостаточно данных для расчета!\n Проверьте, введно ли хотя бы одно значение!");
            }
            #endregion

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            #region//обнуленние текстбоксов
            Plotnost20Text.Text = "0";
            Plotnost15Text.Text = "0";
            VNPText.Text = "0";
            PokazatelPrelomleniaText.Text = "0";
            PoverhnNatiajText.Text = "0";
            MolniyObiemText.Text = "0";
            VodorodText.Text = "0";
            UglerodText.Text = "0";
            LCHText.Text = "0";
            FactorNasaText.Text = "0";

            PlotnostAPIText.Text = "0";
            NizTeplotSgorText.Text = "0";
            MoularnajaMassaText.Text = "0";
            #endregion

            #region//координатная плоскость
            Line OY = new Line();
            OY.X1 = 50;
            OY.Y1 = 10;
            OY.X2 = 50;
            OY.Y2 = 500;
            OY.Stroke = Brushes.Black;
            OY.StrokeThickness = 1;
            Line OX = new Line();
            OX.X1 = 50;
            OX.Y1 = 330;
            OX.X2 = 550;
            OX.Y2 = 330;
            OX.Stroke = Brushes.Black;
            OX.StrokeThickness = 1;

            PointCollection forTri1 = new PointCollection();
            forTri1.Add(new Point(550, 325));
            forTri1.Add(new Point(550, 335));
            forTri1.Add(new Point(560, 330));
            Polygon tri1 = new Polygon();
            tri1.Points = forTri1;
            tri1.Fill = Brushes.Black;

            PointCollection forTri2 = new PointCollection();
            forTri2.Add(new Point(45, 10));
            forTri2.Add(new Point(55, 10));
            forTri2.Add(new Point(50, 0));
            Polygon tri2 = new Polygon();
            tri2.Points = forTri2;
            tri2.Fill = Brushes.Black;

            GraficPlotnostyCanvas.Children.Add(tri2);
            GraficPlotnostyCanvas.Children.Add(tri1);
            GraficPlotnostyCanvas.Children.Add(OY);
            GraficPlotnostyCanvas.Children.Add(OX);
            for(double y=490; y>=50; y=y-40)
            {
                Line middleLine = new Line();
                middleLine.X1 = 40;
                middleLine.Y1 = y;
                middleLine.X2 = 50;
                middleLine.Y2 = y;
                 middleLine.Stroke = Brushes.Black;
            middleLine.StrokeThickness = 1;
                GraficPlotnostyCanvas.Children.Add(middleLine);
                       }
            for (double y = 470; y >= 70; y = y - 40)
            {
                Line smolLine = new Line();
                smolLine.X1 = 50;
                smolLine.Y1 = y;
                smolLine.X2 = 45;
                smolLine.Y2 = y;
                smolLine.Stroke = Brushes.Black;
                smolLine.StrokeThickness = 1;
                GraficPlotnostyCanvas.Children.Add(smolLine);
            }

            for (double x= 90; x<= 560; x = x + 40)
            {
                Line middleLine = new Line();
                middleLine.X1 = x;
                middleLine.Y1 =330;
                middleLine.X2 = x;
                middleLine.Y2 = 340;
                middleLine.Stroke = Brushes.Black;
                middleLine.StrokeThickness = 1;
                GraficPlotnostyCanvas.Children.Add(middleLine);
            }
            for (double x = 70; x <= 540; x= x + 40)
            {
                Line smolLine = new Line();
                smolLine.X1 = x;
                smolLine.Y1 = 330;
                smolLine.X2 = x;
                smolLine.Y2 = 335;
                smolLine.Stroke = Brushes.Black;
                smolLine.StrokeThickness = 1;
                GraficPlotnostyCanvas.Children.Add(smolLine);
               
               
            }
            #endregion
        }
        //отслеживание координат движения мыши на графике
        private void GraficPlotnostyCanvas_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        { double plotnost = e.GetPosition(GraficPlotnostyCanvas).X;
            double temperatura = e.GetPosition(GraficPlotnostyCanvas).Y;
            DinamicTemperTxt.Text = Math.Round((-40D-(temperatura-490D)/4D),1).ToString() ;
            DinamicPlotnostTxt.Text = Math.Round((730D+(plotnost-50)/4D),1).ToString() ;


        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            #region//очистка координатной плоскости
            PointCollection forPl = new PointCollection();
            forPl.Add(new Point(0, 0));
            forPl.Add(new Point(0, 550));
            forPl.Add(new Point(600, 550));
            forPl.Add(new Point(600, 0));
            Polygon pl = new Polygon();
            pl.Points = forPl;
            pl.Fill = Brushes.White;
            GraficPlotnostyCanvas.Children.Add(pl);
           
           
            Line OY = new Line();
            OY.X1 = 50;
            OY.Y1 = 10;
            OY.X2 = 50;
            OY.Y2 = 500;
            OY.Stroke = Brushes.Black;
            OY.StrokeThickness = 1;
            Line OX = new Line();
            OX.X1 = 50;
            OX.Y1 = 330;
            OX.X2 = 550;
            OX.Y2 = 330;
            OX.Stroke = Brushes.Black;
            OX.StrokeThickness = 1;

            PointCollection forTri1 = new PointCollection();
            forTri1.Add(new Point(550, 325));
            forTri1.Add(new Point(550, 335));
            forTri1.Add(new Point(560, 330));
            Polygon tri1 = new Polygon();
            tri1.Points = forTri1;
            tri1.Fill = Brushes.Black;

            PointCollection forTri2 = new PointCollection();
            forTri2.Add(new Point(45, 10));
            forTri2.Add(new Point(55, 10));
            forTri2.Add(new Point(50, 0));
            Polygon tri2 = new Polygon();
            tri2.Points = forTri2;
            tri2.Fill = Brushes.Black;

            GraficPlotnostyCanvas.Children.Add(tri2);
            GraficPlotnostyCanvas.Children.Add(tri1);
            GraficPlotnostyCanvas.Children.Add(OY);
            GraficPlotnostyCanvas.Children.Add(OX);
            for (double y = 490; y >= 50; y = y - 40)
            {
                Line middleLine = new Line();
                middleLine.X1 = 40;
                middleLine.Y1 = y;
                middleLine.X2 = 50;
                middleLine.Y2 = y;
                middleLine.Stroke = Brushes.Black;
                middleLine.StrokeThickness = 1;
                GraficPlotnostyCanvas.Children.Add(middleLine);
            }
            for (double y = 470; y >= 70; y = y - 40)
            {
                Line smolLine = new Line();
                smolLine.X1 = 50;
                smolLine.Y1 = y;
                smolLine.X2 = 45;
                smolLine.Y2 = y;
                smolLine.Stroke = Brushes.Black;
                smolLine.StrokeThickness = 1;
                GraficPlotnostyCanvas.Children.Add(smolLine);
            }

            for (double x = 90; x <= 560; x = x + 40)
            {
                Line middleLine = new Line();
                middleLine.X1 = x;
                middleLine.Y1 = 330;
                middleLine.X2 = x;
                middleLine.Y2 = 340;
                middleLine.Stroke = Brushes.Black;
                middleLine.StrokeThickness = 1;
                GraficPlotnostyCanvas.Children.Add(middleLine);
            }
            for (double x = 70; x <= 540; x = x + 40)
            {
                Line smolLine = new Line();
                smolLine.X1 = x;
                smolLine.Y1 = 330;
                smolLine.X2 = x;
                smolLine.Y2 = 335;
                smolLine.Stroke = Brushes.Black;
                smolLine.StrokeThickness = 1;
                GraficPlotnostyCanvas.Children.Add(smolLine);
            }

            System.Windows.Controls.Label x1 = new System.Windows.Controls.Label();
            x1.Content = "740";
            Canvas.SetLeft(x1, 73);
            Canvas.SetBottom(x1, 190);

            System.Windows.Controls.Label x2 = new System.Windows.Controls.Label();
            x2.Content = "750";
            Canvas.SetLeft(x2, 113);
            Canvas.SetBottom(x2, 190);

            System.Windows.Controls.Label x3 = new System.Windows.Controls.Label();
            x3.Content = "760";
            Canvas.SetLeft(x3, 153);
            Canvas.SetBottom(x3, 190);

            System.Windows.Controls.Label x4 = new System.Windows.Controls.Label();
            x4.Content = "770";
            Canvas.SetLeft(x4, 193);
            Canvas.SetBottom(x4, 190);

            System.Windows.Controls.Label x5 = new System.Windows.Controls.Label();
            x5.Content = "780";
            Canvas.SetLeft(x5, 233);
            Canvas.SetBottom(x5, 190);

            System.Windows.Controls.Label x6 = new System.Windows.Controls.Label();
            x6.Content = "790";
            Canvas.SetLeft(x6, 273);
            Canvas.SetBottom(x6, 190);

            System.Windows.Controls.Label x7 = new System.Windows.Controls.Label();
            x7.Content = "800";
            Canvas.SetLeft(x7, 313);
            Canvas.SetBottom(x7, 190);

            System.Windows.Controls.Label x8 = new System.Windows.Controls.Label();
            x8.Content = "810";
            Canvas.SetLeft(x8, 353);
            Canvas.SetBottom(x8, 190);

            System.Windows.Controls.Label x9 = new System.Windows.Controls.Label();
            x9.Content = "820";
            Canvas.SetLeft(x9, 393);
            Canvas.SetBottom(x9, 190);

            System.Windows.Controls.Label x10 = new System.Windows.Controls.Label();
            x10.Content = "830";
            Canvas.SetLeft(x10, 433);
            Canvas.SetBottom(x10, 190);

            System.Windows.Controls.Label x11 = new System.Windows.Controls.Label();
            x11.Content = "840";
            Canvas.SetLeft(x11, 473);
            Canvas.SetBottom(x11, 190);

            System.Windows.Controls.Label x12 = new System.Windows.Controls.Label();
            x12.Content = "850";
            Canvas.SetLeft(x12, 513);
            Canvas.SetBottom(x12, 190);

            System.Windows.Controls.Label x13 = new System.Windows.Controls.Label();
            Canvas.SetLeft(x13, 538);
            Canvas.SetBottom(x13, 190);
            x13.Content = "ρ кг/м^3";
            x13.FontWeight = FontWeights.Bold;

            System.Windows.Controls.Label y1 = new System.Windows.Controls.Label();
            y1.Content = "-40";
            Canvas.SetLeft(y1, 15);
            Canvas.SetBottom(y1, 48);

            System.Windows.Controls.Label y2 = new System.Windows.Controls.Label();
            y2.Content = "-30";
            Canvas.SetLeft(y2, 15);
            Canvas.SetBottom(y2, 88);

            System.Windows.Controls.Label y3 = new System.Windows.Controls.Label();
            y3.Content = "-20";
            Canvas.SetLeft(y3, 15);
            Canvas.SetBottom(y3, 128);

            System.Windows.Controls.Label y4 = new System.Windows.Controls.Label();
            y4.Content = "-10";
            Canvas.SetLeft(y4, 15);
            Canvas.SetBottom(y4, 168);

            System.Windows.Controls.Label y5 = new System.Windows.Controls.Label();
            y5.Content = "0";
            Canvas.SetLeft(y5, 25);
            Canvas.SetBottom(y5, 208);

            System.Windows.Controls.Label y6 = new System.Windows.Controls.Label();
            y6.Content = "10";
            Canvas.SetLeft(y6, 20);
            Canvas.SetBottom(y6, 248);

            System.Windows.Controls.Label y7 = new System.Windows.Controls.Label();
            y7.Content = "20";
            Canvas.SetLeft(y7, 20);
            Canvas.SetBottom(y7, 288);

            System.Windows.Controls.Label y8 = new System.Windows.Controls.Label();
            y8.Content = "30";
            Canvas.SetLeft(y8, 20);
            Canvas.SetBottom(y8, 328);

            System.Windows.Controls.Label y9 = new System.Windows.Controls.Label();
            y9.Content = "40";
            Canvas.SetLeft(y9, 20);
            Canvas.SetBottom(y9, 368);

            System.Windows.Controls.Label y10 = new System.Windows.Controls.Label();
            y10.Content = "50";
            Canvas.SetLeft(y10, 20);
            Canvas.SetBottom(y10, 408);

            System.Windows.Controls.Label y11 = new System.Windows.Controls.Label();
            y11.Content = "60";
            Canvas.SetLeft(y11, 20);
            Canvas.SetBottom(y11, 448);

            System.Windows.Controls.Label y12 = new System.Windows.Controls.Label();
            y12.Content = "70";
            Canvas.SetLeft(y12, 20);
            Canvas.SetBottom(y12, 488);

            System.Windows.Controls.Label y13 = new System.Windows.Controls.Label();
            Canvas.SetLeft(y13, 20);
            Canvas.SetBottom(y13, 528);
            y13.Content = "t°С";
            y13.FontWeight = FontWeights.Bold;

            DinamicPlotnostTxt = new System.Windows.Controls.TextBox();
            Canvas.SetBottom(DinamicPlotnostTxt, 10);
            Canvas.SetLeft(DinamicPlotnostTxt, 365);

            DinamicPlotnostLbl = new System.Windows.Controls.Label();
            Canvas.SetLeft(DinamicPlotnostLbl, 300);
            Canvas.SetBottom(DinamicPlotnostLbl, 10);
            DinamicPlotnostLbl.Content = "Плотность:";

            DinamicTemperTxt = new System.Windows.Controls.TextBox();
            Canvas.SetLeft(DinamicTemperTxt, 190);
            Canvas.SetBottom(DinamicTemperTxt, 10);

            DinamicTemperLbl = new System.Windows.Controls.Label();
            Canvas.SetLeft(DinamicTemperLbl, 110);
            Canvas.SetBottom(DinamicTemperLbl, 10);
            DinamicTemperLbl.Content = "Температура:";

            GraficPlotnostyCanvas.Children.Add(x1);
            GraficPlotnostyCanvas.Children.Add(x2);
            GraficPlotnostyCanvas.Children.Add(x3);
            GraficPlotnostyCanvas.Children.Add(x4);
            GraficPlotnostyCanvas.Children.Add(x5);
            GraficPlotnostyCanvas.Children.Add(x6);
            GraficPlotnostyCanvas.Children.Add(x7);
            GraficPlotnostyCanvas.Children.Add(x8);
            GraficPlotnostyCanvas.Children.Add(x9);
            GraficPlotnostyCanvas.Children.Add(x10);
            GraficPlotnostyCanvas.Children.Add(x11);
            GraficPlotnostyCanvas.Children.Add(x12);
            GraficPlotnostyCanvas.Children.Add(x13);

            GraficPlotnostyCanvas.Children.Add(y1);
            GraficPlotnostyCanvas.Children.Add(y2);
            GraficPlotnostyCanvas.Children.Add(y3);
            GraficPlotnostyCanvas.Children.Add(y4);
            GraficPlotnostyCanvas.Children.Add(y5);
            GraficPlotnostyCanvas.Children.Add(y6);
            GraficPlotnostyCanvas.Children.Add(y7);
            GraficPlotnostyCanvas.Children.Add(y8);
            GraficPlotnostyCanvas.Children.Add(y9);
            GraficPlotnostyCanvas.Children.Add(y10);
            GraficPlotnostyCanvas.Children.Add(y11);
            GraficPlotnostyCanvas.Children.Add(y12);
            GraficPlotnostyCanvas.Children.Add(y13);

            GraficPlotnostyCanvas.Children.Add(DinamicPlotnostTxt);
            GraficPlotnostyCanvas.Children.Add(DinamicPlotnostLbl);
            GraficPlotnostyCanvas.Children.Add(DinamicTemperLbl);
            GraficPlotnostyCanvas.Children.Add(DinamicTemperTxt);

            #endregion

            #region//обнуленние текстбоксов
            Plotnost20Text.Text = "0";
            Plotnost15Text.Text = "0";
            VNPText.Text = "0";
            PokazatelPrelomleniaText.Text = "0";
            PoverhnNatiajText.Text = "0";
            MolniyObiemText.Text = "0";
            VodorodText.Text = "0";
            UglerodText.Text = "0";
            LCHText.Text = "0";
            FactorNasaText.Text = "0";

            PlotnostAPIText.Text = "0";
            NizTeplotSgorText.Text = "0";
            MoularnajaMassaText.Text = "0";
            #endregion

        }

       #region//разрешение ввода только цифр в текстбоксы
        private void Plotnost20Text_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
            
          if(e.Text==",")
            {
                if(Plotnost20Text.Text.IndexOf(',')!=-1)
                {
                    e.Handled = true;
                }
                return;
            }
            
        }

        private void Plotnost15Text_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (Plotnost15Text.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void PlotnostAPIText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (PlotnostAPIText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void VNPText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (VNPText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void LCHText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (LCHText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void NizTeplotSgorText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (NizTeplotSgorText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void PoverhnNatiajText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (PoverhnNatiajText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void PokazatelPrelomleniaText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (PokazatelPrelomleniaText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void MoularnajaMassaText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (MoularnajaMassaText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void MolniyObiemText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (MolniyObiemText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void VodorodText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (VodorodText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void UglerodText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (UglerodText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void FactorNasaText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;

            if (e.Text == ",")
            {
                if (FactorNasaText.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }
        #endregion

        //схранение результатов в текстовый файл
       private void SaveInFileBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text files|*.txt";
            if(sf.ShowDialog()==DialogResult.OK & sf.FileName.Length>0)
            {
                using (StreamWriter sw = new StreamWriter(sf.FileName, true))
                {
                    sw.WriteLine("Результаты расчетов");
                    sw.WriteLine("");
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(Plotnost20Label.Content.ToString() + "                    |   " + Plotnost20Text.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(Plotnost15Label.Content.ToString() + "                   |   " + Plotnost15Text.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(VNPLabel.Content.ToString() + "                |   " + VNPText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(LCHLabel.Content.ToString() + "                       |   " + LCHText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(NizTeplotSgorLabel.Content.ToString() + "               |   " + NizTeplotSgorText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(PoverhnNatiajLabel.Content.ToString() + "                  |   " + PoverhnNatiajText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(PokazatelPrelomleniaLabel.Content.ToString() + "                        |   " + PokazatelPrelomleniaText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(MolarnajaMassaLabel.Content.ToString() + "                        |   " + MoularnajaMassaText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(MolniyObiemLabel.Content.ToString() + "                         |   " + MolniyObiemText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(VodorodLabel.Content.ToString() + "                    |   " + VodorodText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(UglerodLabel.Content.ToString() + "                    |   " + UglerodText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(FactorNasaLabel.Content.ToString() + "                  |   " + FactorNasaText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.Close();
                }
            }

        }
    }


}

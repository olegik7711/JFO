using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFO.Classes
{
    class ToCalculate
    {
    public  decimal Plotnost20;
     public decimal Plotnost15;
       public decimal Prelomlenie;
      public decimal PoverkhNatiajenie;
        public decimal MolnObem;

        public decimal PlotnostAPI;
        public decimal NizTeploteSgor;
        public decimal MoolekMassa;
        public decimal LCH;
        public decimal Vodorod;
        public decimal Uglerod;
      public decimal Vnp;
        public decimal FactorNasa;

        //если плотность при 20 введена, находим значения связанных с ней свойств
        public void CulculatePoPl20(decimal plotnost20)
        {
            if (plotnost20 > 0.999M) { plotnost20 = plotnost20 / 1000; }
            this.Plotnost20 = plotnost20;
            
                 Plotnost15 = Plotnost20 + (0.0035M / Plotnost20);
             
                Prelomlenie = ((Plotnost20 * Plotnost20) + 3.468M) / 2.841M;
                PoverkhNatiajenie = 0.00001M * (5M * Plotnost20 - 1.5M);
               
                Vnp = 21.5M + (-165M * (Plotnost20 - 0.81M) + 1260M * ((Plotnost20 - 0.81M) * (Plotnost20 - 0.81M)));
                                                    
                  }

        //если плотность при 15 введена, находим значения связанных с ней свойств
        public void CulculatePoPl15(decimal plotnost15)
        {
            if (plotnost15 > 0.999M) { plotnost15 = plotnost15 / 1000; }
            this.Plotnost15 = plotnost15;
          
            double PL20 = ((double)Plotnost15 + Math.Sqrt((double)Plotnost15 * (double)Plotnost15 - 4D * 0.0035)) / 2D;
            Plotnost20 = (decimal)PL20;
            PlotnostAPI = (141.5M / Plotnost15) - 131.5M;
                NizTeploteSgor = 46426.7M + 3168.5M * Plotnost15 - 8792.7M * (Plotnost15 * Plotnost15);
                MoolekMassa = (44.29M * Plotnost15) / (1.03M - Plotnost15);
           double MO =(double) MoolekMassa /(double)Plotnost20 ;
            MolnObem = (decimal)MO;
           
        }
        
        //находим плотность при 20 по поверхностному натяжению
        public void Pl20poPovrchNat(decimal poverchNatiajenie)
        {
            this.PoverkhNatiajenie = poverchNatiajenie;
            Plotnost20 = (PoverkhNatiajenie / 0.00001M + 1.5M) / 5M;
        }

        //находим плотность при 20 по преломлению
        public void Pl20PoPrelomleniu(decimal prelomlenie)
        {
            this.Prelomlenie = prelomlenie;
            
            double a = (double)Prelomlenie;
          double b = Math.Sqrt((a*2.841)-3.468);
            Plotnost20 = (decimal)b;
        }

        //находим значения свойств связанных с ВНП
        public void CalculatePoVNP(decimal vnp)
        {
            this.Vnp = vnp;
            double PL20;
            PL20 = (2206.2 - Math.Sqrt(4867318.44 - 5040D * (981.846 - (double)Vnp))) / 2520D;
            Plotnost20 = (decimal)PL20;
            LCH = (Vnp - 1.03M) / 0.423M;
        }

        //находим значения свойств связанных с ЛЧ
        public void CalculatePoLCH(decimal lch)
        {
            this.LCH = lch;
            Vnp = LCH * 0.423M + 1.03M;
            Vodorod = (LCH + 174.5M) / 16.5M;
        }

        //находим значения свойств связанных с содержанием водорода
        public void calculatePoVodorod(decimal vodorod)
        {
            this.Vodorod = vodorod;
            LCH = Vodorod * 16.5M - 174.5M;
            Uglerod = 100M - Vodorod;
        }

        //находим значения свойств связанных с углерода
        public void calculatePoUglerod(decimal uglerod)
        {
            this.Uglerod = uglerod;
            Vodorod = 100 - Uglerod;
            FactorNasa = (210M + 600M) * 0.6M * ((100M-Uglerod) / Uglerod - 0.207M) / ((100M-Uglerod) / Uglerod - 0.259M);
        }

        //находим значения свойств связанных с фактором НАСА
        public void calculatePoFactoruNasa(decimal factorNasa)
        {
            this.FactorNasa = factorNasa;
            Uglerod = (48600M - 100M * FactorNasa) / (586.602M - 1.259M * FactorNasa);
        }

        //находим плотность при 15 по плотности API
        public void Pl15PoPlApi(decimal plotnostApi)
        {
            this.PlotnostAPI = plotnostApi;
            Plotnost15 = 141.5M / (PlotnostAPI + 131.5M);
        }

        //находим плотность при 15 по низшей теплоте сгорания 
        public void Pl15PoNizTplSgor(decimal niztplsgor)
        {
            this.NizTeploteSgor = niztplsgor;
            double pl15 = (-3168.5 - Math.Sqrt(10039392.25 + 35170.8 * (46426.7 - (double)NizTeploteSgor))) / (-17585.4);
            Plotnost15 = Convert.ToDecimal(pl15);
        }

        //находим плотность при 15 по молекулярной массе
        public void Pl15PoMolekMass(decimal molekmass)
        {
            this.MoolekMassa = molekmass;
            Plotnost15 = 1.03M * MoolekMassa / (44.29M + MoolekMassa);
        }

        //public void Pl15PoMolnObiem(decimal molObiem)
        //{
        //    this.MolnObem = molObiem;
        //    Plotnost15 = 
        //}
    }
}

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
using System.Windows.Shapes;

namespace JFO.Views
{
    /// <summary>
    /// Логика взаимодействия для AboutFuelProperty.xaml
    /// </summary>
    public partial class AboutFuelProperty : Window
    {
        public AboutFuelProperty()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Oglavlenie.FontSize = 20;
            Oglavlenie.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = "      Чтобы получить необходимую вам информацию, выберите пункт в блоке \"Содержание\".\n" +
                         "      Информация появится ниже.";
            Img1.Source = null;
            Img2.Source = null;
            Img3.Source = null;
        }

        private void Plotnost_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Plotnost.Content.ToString();
           
            First.Text = "      Плотность — скалярная физическая величина, определяемая"+
                "как отношение массы тела к занимаемому этим телом объёму.\n"+
"Для обозначения плотности обычно используется греческая буква ρ (ро) (происхождение "+
    "обозначения подлежит уточнению),\nиногда используются также латинские буквы D и d"+
    " (от Шаблон: Lang = la — «плотность»).";
            Img1.Source = new BitmapImage(new Uri("/Images/plotnost3.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/plotnost2.jpg", UriKind.Relative));
            Img3.Source = new BitmapImage(new Uri("/Images/plotnost1.jpg", UriKind.Relative));
        }

        private void Viascost_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Viascost.Content.ToString();
            First.Text = "      Вязкость (внутреннее трение) — одно из явлений переноса, свойство"+
                " текучих тел (жидкостей и газов) оказывать сопротивление перемещению одной\n "+
                "их части относительно другой. В результате работа, затрачиваемая на это перемещение,"+
                " рассеивается в виде тепла.\n\n"+
                         "      Механизм внутреннего трения в жидкостях и газах заключается в том,"+
                " что хаотически движущиеся молекулы переносят импульс из одного слоя в другой,\n"+
                           "что приводит к выравниванию скоростей — это описывается введением силы трения."+
                           " Вязкость твёрдых тел обладает рядом специфических особенностей\n и рассматривается "+
                           "обычно отдельно.\n\n"+
                "      Различают динамическую вязкость(единица измерения в Международной системе единиц(СИ) — Па·с," +
                " в системе СГС — пуаз; 1 Па·с = 10 пуаз)\nи кинематическую вязкость(единица измерения в СИ — м²/с, " +
                "в СГС — стокс, внесистемная единица — градус Энглера). Кинематическая вязкость\n может быть получена" +
                " как отношение динамической вязкости к плотности вещества и своим происхождением обязана" +
                " классическим методам\n измерения вязкости, таким как измерение времени вытекания заданного" +
                " объёма через калиброванное отверстие под действием силы тяжести. \nПрибор для измерения" +
                " вязкости называется вискозиметром.";
            Img1.Source = new BitmapImage(new Uri("/Images/Viascost1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/viascost2.jpg", UriKind.Relative));
            Img3.Source = new BitmapImage(new Uri("/Images/viscost3.jpg", UriKind.Relative));

        }

        private void FracSost_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = FracSost.Content.ToString();
            First.Text = "      Фракционированием называется разделение сложной смеси компонентов на смеси" +
                " более простого состава или, в пределе,\n" +
                " на индивидуальные составляющие.\n\n" +
                         "      В технических условиях на авиационные и автомобильные бензины, авиационные," +
                " тракторные и осветительные керосины, дизельные топлива,\n" +
                " а также растворители одним из важнейших показателей является фракционный состав." +
                " Обыкновенно для этих нефтепродуктов при проведении\n" +
                " разгонки в стандартных условиях нормируются: температура начала кипения, температуры," +
                " при которых отгоняется 10, 50, 90 и 97,5 % (об.)\n" +
                " от загрузки, а также остаток (в %) и иногда температура конца кипения.\n\n" +
                "      Фракционный состав моторных топлив имеет очень важное эксплуатационное значение," +
                " так как характеризует их испаряемость в двигателях\n" +
                " и давление паров при различных температурах и давлениях. Топливо для двигателей с" +
                " зажиганием от искры должно иметь такую испаряемость,\n" +
                " которая обеспечила бы легкий запуск двигателя при низких температурах, быстрый" +
                " прогрев двигателя, его хорошую приемистость к переменам\n" +
                " режима и равномерное распределение топлива по цилиндрам. Топливо для воздушно – реактивных" +
                " двигателей должно быть утяжеленного фракционного\n" +
                " состава(порядка 150–280 °С) для обеспечения надежной работы системы подачи топлива" +
                " на больших высотах без образования паровых пробок.\n" +
                " Вместе с тем топливо должно отличаться хорошей испаряемостью в камере сгорания и" +
                " полнотой сгорания.";
            Img1.Source = new BitmapImage(new Uri("/Images/frsos1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/frsos2.jpg", UriKind.Relative));
            Img3.Source = new BitmapImage(new Uri("/Images/frsos3.jpg", UriKind.Relative));
        }

        private void NizTepSgor_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = NizTepSgor.Content.ToString();
            First.Text = "     Теплота́ сгора́ния — это количество выделившейся теплоты при полном сгорании" +
                        " массовой (для твердых и жидких веществ) или объёмной (для газообразных)\n единицы вещества." +
                        "Измеряется в джоулях или калориях. Теплота сгорания, отнесённая к единице массы" +
                        " или объёма топлива, называется\n удельной теплотой сгорания (дж или кал на 1 кг, м³ или моль). " +
                        "Для её измерения пользуются методами калориметрии. Теплота сгорания определяется\n" +
                        " химическим составом горючего вещества. Содержащиеся в горючем веществе химические элементы" +
                        " обозначаются принятыми символами С, Н, О, N, S,\n а зола и вода — символами А и W соответственно.\n\n" +
                        "     Низшая теплота сгорания соответствует тому количеству теплоты, которое выделяется при" +
                        " полном сгорании, без учёта теплоты конденсации водяного пара.\n Теплоту конденсации водяных паров" +
                        " также называют скрытой теплотой парообразования(конденсации).\n\n" +
                        "     Низшая и высшая теплота сгорания связаны соотношением: Q_B = Q_H + k(W + 9H)," +
                        " где k — коэффициент, равный 25 кДж / кг(6 ккал / кг); W — количество\n воды в горючем" +
                        " веществе, % (по массе); Н — количество водорода в горючем веществе, % (по массе).";
            Img1.Source = new BitmapImage(new Uri("/Images/NizTeplSgor1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/NizTeplSgor2.jpg", UriKind.Relative));
            Img3.Source = new BitmapImage(new Uri("/Images/NizTeplSgor3.jpg", UriKind.Relative));

        }
        private void Kislotn_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Kislotn.Content.ToString();
            First.Text = "      Кислотность топлива выражают в миллиграммах щелочи КОН, израсходованной"+
                "на нейтрализацию кислых соединений, содержащихся в 100 мл топлива.\n\n"+
                "      По кислотности топлива судят о наличии в нем соединений кислотного характера." +
                " К таким соединениям относятся нафтеновые кислоты,\n" +
                " фенолы, асфальтогеновые кислоты и пр.Нафтеновые кислоты, особенно низкомолекулярные," +
                " способны вызвать коррозию резервуаров, топливных баков\n" +
                " и деталей топливоподаю-щей системы двигателя. Наиболее сильно действуют нафтеновые " +
                "кислоты на свинец, медь, олово, сталь и чугун.На алюминий\n" +
                " нафтеновые кислоты не действуют.\n\n" +
                "      При взаимодействии нафтеновых кислот с металлами образуются мыла; обычно мыла не" +
                " растворимы в топливе и находятся в нем во взвешенном \n" +
                " состоянии, но могут и выпасть в виде осадка.";
            Img1.Source = new BitmapImage(new Uri("/Images/kislotnost1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/kislotnost2.jpg", UriKind.Relative));
            Img3.Source = null;
        }
        #region поведение картинок
        private void Img1_MouseEnter(object sender, MouseEventArgs e)
        {
            Img1.Width = 500;
            Img1.Height = 500;
        }

        private void Img1_MouseLeave(object sender, MouseEventArgs e)
        {
            Img1.Width = 300;
            Img1.Height = 300;
        }

        private void Img2_MouseEnter(object sender, MouseEventArgs e)
        {
            Img2.Width = 500;
            Img2.Height = 500;
        }

        private void Img2_MouseLeave(object sender, MouseEventArgs e)
        {
            Img2.Width = 300;
            Img2.Height = 300;
        }

        private void Img3_MouseEnter(object sender, MouseEventArgs e)
        {
            Img3.Width = 500;
            Img3.Height = 500;
        }

        private void Img3_MouseLeave(object sender, MouseEventArgs e)
        {
            Img3.Width = 300;
            Img3.Height = 300;
        }
        #endregion

        private void VNP_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = VNP.Content.ToString();
            First.Text = "      Способность реактивных топлив к нагарообразованию оценивается специальным" +
                " показателем - высотой некоптящего пламени,\n" + " измеряемой в миллиметрах.\n\n"+
            "      Работами лабораторий фирмы Пратт-Уитней было установлено, что, чем ниже" +
            " высота некоптящего пламени топлива, тем выше\n" +
            " интенсивность излучения пламени. Также установлено, что чем больше высота" +
            " некоптящего пламени, тем меньше дыма и углеродистых\n" +
            " отложений (нагара)образуется при сгорании топлива в газотурбинном двигателе.\n\n" +
            "      Керосин с высоким содержанием ароматических соединений характеризуется" +
            " малой высотой некоптящего пламени. Гидроочистка\n" +
            " позволяет улучшить керосин с низкой высотой некоптящего пламени.Во время этого" +
            " процесса бензольные кольца в молекулах ароматических\n" +
            " углеводородов насыщаются водородом и таким образом превращаются в нафтены," +
            " которые уже не так коптят при горении.\n\n" +
            "      Высота некоптящего пламени не должна быть меньше 20 - 25 мм.";
            Img1.Source = new BitmapImage(new Uri("/Images/vnp1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/vnp2.jpg", UriKind.Relative));
            Img3.Source = null; 

        }

        private void Iod_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Iod.Content.ToString();
            First.Text = "      Йодное число характеризует наличие непредельных углеводородов в топливе." +
                " Эти углеводороды наиболее склонны к окислению,\n" +
                " что может служить косвенной характеристикой реактивного топлива к" +
                " образованию отложений окислительного характера.\n\n" +
                "      Определяют йодное число по ГОСТ 2070 - 82. Содержание непредельных" +
                " углеводородов рассчитывают по величине йодного числа\n" +
                " и по средней молекулярной массе испытуемого топлива, которая для топлив" +
                " Т-2, ТС-1 и Т-1 принимается равной 175.\n\n\n\n\n\n\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/iod1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/iod2.jpg", UriKind.Relative));
            Img3.Source = null;
        }

        private void Vspishka_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Vspishka.Content.ToString();
            First.Text = "      Температура вспышки — наименьшая температура летучего конденсированного"+
                " вещества, при которой пары над поверхностью\n"+
                " вещества способны вспыхивать в воздухе под воздействием источника зажигания,"+
                " однако устойчивое горение после удаления\n"+
                " источника зажигания не возникает. Вспышка — быстрое сгорание смеси паров"+
                " летучего вещества с воздухом, сопровождающееся\n"+
                " кратковременным видимым свечением.Температуру вспышки следует отличать как"+
                " от температуры воспламенения, при которой\n"+
                " горючее вещество способно самостоятельно гореть после прекращения действия"+
                " источника зажигания, так и от температуры\n"+
                " самовоспламенения, при которой для инициирования горения или взрыва не требуется"+
                " внешний источник зажигания.";
            Img1.Source = new BitmapImage(new Uri("/Images/vspishk1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/vspishk2.jpg", UriKind.Relative));
            Img3.Source = null;
        }

        private void Kristall_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Kristall.Content.ToString();
            First.Text =
                "       Температурой начала кристаллизации топлив называют максимальную температуру, при" +
                " которой в топливе невооруженным глазом обнаруживаются кристаллы.\n\n" +
                "       Кристаллы забивают топливный фильтр двигателя перед насосом и резко снижают" +
                " его пропускную способность, что приводит к отказу двигателя.\n\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/kristall1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/Kristall2.jpg", UriKind.Relative));
            Img3.Source = null;
        }

        private void TSRT_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = TSRT.Content.ToString();
            Oglavlenie.Width = 400;
            First.Text =
                "      Основной проблемой, возникающей в результате нагрева топлива в полете," +
                " связанного как со сверхзвуковыми скоростями полета,\n" +
                " так и с воздействием высоких температур на топливо со стороны горячих" +
                " элементов силовой установки(например, находящегося\n" +
                " втопливном коллекторе после выключения двигателя), является осадкообразование," +
                " наиболее интенсивное в пределах температуры\n" +
                " 130—200°С(рис. 6.4).Стойкость топлива к осадкообразованию при высоких" +
                " температурах называется термической стабильностью.\n" +
                " Термостабильность ухудшается при увеличении содержания непредельных углеводородов" +
                " и гетероорганических примесей: твердые,\n" +
                " нерастворимые в топливе осадки являются конечными продуктами их окисления," +
                " полимеризации и химической конденсации. При использовании\n" +
                " недостаточно термостабильных топлив(например, сортов Т-1 и ТС-1) на горячих" +
                " поверхностях(особенно бронзовых), соприкасающихся с жидким\n" +
                " топливом, образуются твердые нагароподобные отложения, а в массе топлива — взвесь" +
                " мельчайших твердых частиц, которые забивают\n" +
                "фильтры, попадают в каналы и зазоры топливной аппаратуры. В дренажных отверстиях" +
                " осадки иногда откладываются в виде рыхлой массы.";
            Img1.Source = new BitmapImage(new Uri("/Images/tsrt1.jpg", UriKind.Relative));
            Img2.Source = null;
            Img3.Source = null;
        }

        private void Aromat_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Width = 400;
            Oglavlenie.Text = Aromat.Content.ToString();
            First.Text =
                "      Содержание ароматических углевлдородов в реактивном топливе ограничивается 20%" +
                "для дозвуковой авиации и 8% объема для специальных\n" +
                "топлив. При повышении содержания ароматических углеводородов в реактивном топливе" +
                "падает его теплотворная способность, ухудшается сгорание\n" +
                " и увеличивается нагарообразование в двигателе летательного аппарата\n\n\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/arom3.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/arom1.jpg", UriKind.Relative));
            Img3.Source = new BitmapImage(new Uri("/Images/arom2.jpg", UriKind.Relative));
        }

        private void FactSmoly_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = FactSmoly.Content.ToString();
            First.Text =
                "      Фактическими смолами в реактивных топливах называют сумму, сложных продуктов" +
                " их окисления, полимеризации и конденсации, образовавшихся\n" +
                " в процессе производства и хранения, а также в процессе определения в специальном" +
                " приборе в условиях испытания.\n\n" +
                "      Жидкофазное окисление реактивных топлив в основном определяется температурой" +
                " окисления и содержанием в них гетероорганических\n" +
                " и непредельных углеводородов. Продукты окисления реактивных топлив (или смолы)" +
                " являются причиной образования высокотемпературных\n" +
                " осадков, под которыми понимают осадки, появляющиеся в топливах при нагреве до температур" +
                " выше 373К.\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/factsmol1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/factsmol2.jpg", UriKind.Relative));
            Img3.Source = null;
        }

        private void Sera_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Sera.Content.ToString();
            First.Text =
                "      Содержание серы (или сернистых соединений) в то­варных нефтепродуктах приходится" +
                " строго регламентировать, а следовательно, для\n" +
                " получения прямогонных топлив необходимо подбирать нефти с ограниченным содержанием" +
                " серы или подвер­гать высокосернистые нефтепродукты\n" +
                " более глубокой переработке (каталитический крекинг, гидрирование, гидроочистка и другие" +
                " методы, в процессе которых сернистые соединения разрушаются).\n\n" +
                "      Для товарных реактивных топлив допускается содержание общей серы (в зависимости от" +
                " нефтяного сырья) 0.1—0.25вес. % (ГОСТ 10227)\n" +
                "      Элементарная сера может образовываться в качестве вторичных продуктов раз­рушения" +
                " более сложных сернистых соединений. Сера и\n" +
                " сероводород яв­ляются наиболее коррозионноактивными соединениями. Медь и ее сплавы в" +
                " присутствии сероводорода и элементарной серы\n" +
                " раз­рушаются с большой скоростью. Ни сероводород, ни элементар­ная сера не должны присутствовать" +
                " в товарных топливах.\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/sera1.jpg", UriKind.Relative));
            Img2.Source = null;
            Img3.Source = null;
        }

        private void Merkaptan_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Merkaptan.Content.ToString();
            First.Text =
                "      К коррозиониоактивным и малостабильным соединениям от­носятся меркаптаны. Эти соединения" +
                " кислого характера, имею­щие в своем составе\n" +
                " сульфгидрильную группу БН. Их содержа­ние в топливах строго ограничивается стандартами." +
                " В реактивных топливах, полученных из сернистых\n" +
                " нефтей, содержание меркаптановой серы должно быть не выше 0,003%. Среди меркаптанов," +
                " обнаруживаемых в среднедистиллятных нефтяных топливах,\n" +
                " сульфгидрильная группа может находиться в алкановой цепи, у цикланового кольца (тиолы," +
                " аналоги алкоголен) и у бензольного или нафталинового колец\n" +
                "(тиофенолы, аналоги фенолов).\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/merkaptan2.png", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/merkaptan1.jpg", UriKind.Relative));
            Img3.Source = null;
        }

        private void Serovodorod_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Serovodorod.Content.ToString();
            First.Text =
                "      Cероводород и элементарная сера могут образовываться в качестве вторичных продуктов"+
                " раз­рушения более сложных сернистых соединений\n"+
                " топлив. Они яв­ляются наиболее коррозионноактивными соединениями. Медь и ее сплавы в присутствии"+
                " сероводорода и элементарной серы раз­рушаются\n"+
                " с большой скоростью. Ни сероводород, ни элементар­ная сера не должны присутствовать в товарных"+
                " топливах.\n\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/serovodorod1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/serovodorod2.jpg", UriKind.Relative));
            Img3.Source = null;
        }

        private void Plastinka_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Plastinka.Content.ToString();
            First.Text =
                "      Сущность метода заключается в выдерживании медной пластинки в испытуемом топливе при повышенной" +
                " температуре и фиксировании изменения ее внешнего\n" +
                " вида, характеризующего коррозионное воздействие топлива.\n\n\n\n\n\n\n\n\n\n\n\n\n";
                Img1.Source = new BitmapImage(new Uri("/Images/plastina1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/plastina2.jpg", UriKind.Relative));
            Img3.Source = null;
        }

        private void Zolnost_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Zolnost.Content.ToString();
            First.Text =
                "       Зольность — массовая доля золы, содержание в процентах негорючего (на безводную массу) остатка," +
                " который создаётся из минеральных примесей\n" +
                " топлива при его полном сгорании. Для практических целей значение зольности, определённое по" +
                " аналитической пробе, обычно пересчитывается\n" + " на сухую массу  или рабочее  состояние топлива.\n\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/zolnost1.jpg", UriKind.Relative));
            Img2.Source = null;
            Img3.Source = null;
        }

        private void Naftaliny_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Naftaliny.Content.ToString();
            First.Text =
                "      Повышенное содержание нафталиновых углеводородов резко повышает образование нагара" +
                " в двигателе, а также способствует повышенной\n" +
                " излучательной способности топлива, что приводит к локальным перегревам двигателя летательного" +
                " аппарата и может привести к прогару стенок \n" +
                " камеры сгорания. Образующиеся при неполном сгорании нафталиновых углеводородов твердые частицы" +
                " приводят к повышенной эрозии отдельных частей двигателя.\n\n\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/naftalin1.jpg", UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri("/Images/naftalin2.jpg", UriKind.Relative));
            Img3.Source = null;
        }

        private void LCH_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = LCH.Content.ToString();
            First.Text =
                "      Люминометрическое число - показатель теплового излучения пламени при сгорании реактивного" +
                " топлива. Люминометрическое число различных\n" +
                " типов реактивных топлив изменяется в пределах от 46 до 70 и характеризует качество сгорания" +
                " топлива: чем люминометрическое число больше,\n" +
                " тем меньше интенсивность излучения пламени, температура стенок камеры сгорания газотурбинного" +
                " двигателя и вероятность их коробления и прогара.\n\n\n\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/lch1.jpg", UriKind.Relative));
            Img2.Source = null;
            Img3.Source = null;
        }

        private void DTS_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = DTS.Content.ToString();
            First.Text =
                "      Термоокислительная стабильность реактивных топлив определяется их стойкостью к окислению" +
                " в заданном эксплуатационном диапазоне\n" +
                " температур. В первых предусматривается нагрев топлива в бомбах в контакте с надтопливным" +
                " воздухом, во вторых - при движении топлива\n" +
                " через нагреваемые трубку и контрольный фильтр.\n\n"+
            "      Термоокислительная стабильность реактивного топлива должна быть высокой.Топливо в" +
            " топливоподающей системе (особенно в сверхзвуковом\n" +
            " реактивном самолете) может нагреться до 150 - 250 С. Под действием таких температур некоторые" +
            " составляющие топлива(непредельные углеводороды,\n" +
            " меркаптаны, смолы) изменяются с образованием не растворимых в топливе осадков, загрязняющих" +
            " поверхности охлаждения, забивающих фильтры и форсунки;\n" +
            " в результате нарушается нормальная работа двигателя. Улучшение термоокислительной стабильности" +
            " топлив достигается либо очисткой их, либо применением\n присадок.";
            Img1.Source = new BitmapImage(new Uri("/Images/jftot.jpg", UriKind.Relative));
            Img2.Source = null;
            Img3.Source = null;
        }

        private void Electro_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = Electro.Content.ToString();
            First.Text =
                "      Электрические свойства топлива определяют пожаробезопасность процесса заправки им"+
                " топливозаправщиков и летательных аппаратов и\n"+
                " работу топливоизмерительной аппаратуры. Случаи взрывов и пожаров, возникающих при эксплуатации"+
                " авиационной техники из-за разрядов\n"+
                " статического электричества, зарегистрированы как в России, так и  за рубежом.\n\n"+
                "      В связи с тем, что реактивные топлива состоят, в основном, из соединений, которые"+
                " неполярны или слабополярны, топлива являются\n"+
                " практически диэлектриками, т.е.плохо проводят электрический ток. Это качество топлива определяет"+
                " способность к накоплению зарядов в его\n"+
                " объеме при перекачке. Заряды возникают при наличии в топливе незначительных количеств полярных"+
                " соединений и воды. Осушенные и очищенные от\n"+
                " полярных соединений углеводороды и топлива практически не электризуются. Однако топлива такой"+
                " степени очистки на практике в обращение не\n"+
                " поступают, и все товарные топлива представляют потенциальную опасность искрообразования от" +
                "статического электричества.\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/electro1.jpg", UriKind.Relative));
            Img2.Source = null;
            Img3.Source = null;
        }

        private void DavlenParov_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = DavlenParov.Content.ToString();
            First.Text =
                "      Давление насыщенных паров реактивных топлив - величина переменная и зависит от его" +
                " фракционного состава и температуры. Как правило,\n" +
                " чем легче фракционный состав топлива, тем выше давление его паров. Давление насыщенных" +
                " паров реактивного топлива обусловливает потери\n" +
                " топлива и избыточное давление в баках, необходимое для обеспечения бескавитационной работы" +
                " топливных насосов.Оно определяется в приборе\n" +
                " типа бомбы Рейда при температуре 38 С для топлива Т-2 и при 150 С для топлив, не содержащих" +
                " бензиновой фракции.\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/davlen1.jpg", UriKind.Relative));
            Img2.Source = null;
            Img3.Source = null;
        }

        private void NR21f2_Checked(object sender, RoutedEventArgs e)
        {
            First.FontSize = 14;
            First.FontWeight = FontWeights.Bold;
            Oglavlenie.Text = NR21f2.Content.ToString();
            First.Text =
                "      Противоизносные свойства реактивных топлив зависят от вязкости топлив, содержания в них" +
                " меркаптанов и обуславливаются наличием\n" +
                " поверхностно-активных веществ, способных адсорбироваться на поверхности пар трения," +
                " предотвращая их износ.\n\n" +
                "      Ресурс работы топливных насосов авиационных двигателей во многом определяют противоизносные" +
                " свойства реактивных топлив.Особенно\n" +
                " чувствительны к этому показателю насосы-регуляторы плунжерного типа, работающие при повышенных" +
                " давлениях топлива. Насосы такого типа\n" +
                " широко применяют в двигателях сверхзвуковых самолетов.\n\n"+
            "      Противоизносные свойства реактивных топлив улучшаются при введении присадок, обладающих" +
            " поверхностно - активными свойствами.\n\n\n\n\n";
            Img1.Source = new BitmapImage(new Uri("/Images/isnos1.jpg", UriKind.Relative));
            Img2.Source = null;
            Img3.Source = null;
        }
    }
}

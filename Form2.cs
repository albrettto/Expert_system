using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Expert_system
{
    public partial class Test_Form : Form
    {
        int counter = 0;//Индекс вопроса
        string answer_check;//Ответ на него

        //Список вопросов
        string q1 = @"Какая группа музыкальных инструментов вас интересует?";
        string q2 = @"Колебания вдуваемой струи: 
        1.возникает в результате рассечения её об острый край стенки ствола или острый клинчатый вырез специального рассекающего отверстия, расположенного на стволе; 
        2.достигается при помощи эластичного вибрирующего прерывателя - язычка;
        3.вызывается вибрацией соответствующим образом напряженных губ исполнителя, прижатых к мундштуку или непосредственно к верхнему концу ствола." ;
        string q3 = @"При игре на этом инструменте струя воздуха рассекается прямо об острый край стенки ствола или же в данном инструменте присутствуют специальные боковые отверстия, об острый клинчатый вырез которого рассекается направляемая на него струя воздуха?";
        string q4 = @"Ствол инструмента открыт с обоих концов?";
        string q5 = @"Есть наконечник?";
        string q6 = @"Струя воздуха прерывается одинарной эластичной пластиной или проходит в щель между двумя?";
        string q7 = @"Струя воздуха сразу поступает в инструмент или попадает в промежуточный объем, из которого поступает в звкуообразующую часть инструмента?";
        string q8 = @"Изменяется ли высота основного тона?";
        string q9 = @"Инструмент довольно больших размеров с цилиндрообразным стволом или широкомензурный инструмент со сравнительно коротким стволом и коническим каналом.";
        string q10 = @"Инструмент с цилиндрообразным стволом и раструбом-конусом или граница между стволом и раструбом трудно определима, канал конический, ствол-раструб короткий.";
        string q11 = @"Изменяется ли высота основного тона струн при игре?";
        string q12 = @"Какой корпус?";
        string q13 = @"Звукоизвлечение с помощью смычка или фрикционного колеса?";
        string q14 = @"Звук: 
        1.извлекается защипыванием струны или бряцанием;
        2.возникает от трения смычка или деревянного колеса;
        3.извлекается ударом по струне палочкой, молоточком.";
        string q15 = @"Звукоизвлечение происходит путем удара по мембране или вызывается трением пальцев по ней?";
        string q16 = @"Звук определенной высоты?";
        string q17 = @"Инструмент или его звучащая деталь приводится в состояние вибрации путем защипывания или рывком?";
        string q18 = @"Звук возникает от трения твердых тел  или в результате взаимного трения упругого тела и массы окружающего воздуха при быстром движении тела?";
        string q19 = @"Инструмент звучит при ударе по нему другим предметом или путем взаимного удара его составных частей?";
        string q20 = @"Основным звукообразующим элементов является одинарный свободный язычок или две эластичные пластины?";
        string q21 = @"Струя воздуха приводит в состояние вибрации язычок, свободно колеблющийся в проеме металлической рамы?";

        //Список ответов
        string a1 = "Духовые";
        string a2 = "Струннные";
        string a3 = "Мембранные";
        string a4 = "Самозвучащие";
        string a5 = "Свистковые";
        string a6 = "Язычковые";
        string a7 = "Мундштучные";
        string a8 = "Краесекущие";
        string a9 = "Клинчатовырезные";
        string a10 = "Да (Открытые)";
        string a11 = "Нет (Полузакрытые)";
        string a12 = "Да (Продольные)";
        string a13 = "Нет (Поперечные)";
        string a14 = "С одинарным";
        string a15 = "С двойным";
        string a16 = "Без воздушного резервуара";
        string a17 = "С воздушным резервуаром";
        string a18 = "Да (Натуральные)";
        string a19 = "Нет (Ладковые)";
        string a20 = "Цилиндрический";
        string a21 = "Конический";
        string a22 = "Щипковые";
        string a23 = "Фрикционные";
        string a24 = "Ударные";
        string a25 = "Да (Арфообразные)";
        string a26 = "Нет (Танбуровидные)";
        string a27 = "Ящик";
        string a28 = "Рама";
        string a29 = "Смычковое";
        string a30 = "Колёсные";
        string a31 = "Да (Настраивающиеся)";
        string a32 = "Нет (Ненастраивающиеся)";
        string a33 = "Да (щипковые)";
        string a34 = "Нет";
        string a35 = "Да (фрикционные)";
        string a36 = "Да (ударные)";
        string a37 = "Нет (воздушные)";
        string a38 = "Да (с проскакивающим язычком)";
        string a39 = "Нет (со свободным язычком)";
        string a40 = "Губовиднощелевые";

        //Изображения музыкальных инструментов
        Image arfa = Expert_system.Properties.Resources.арфа;
        Image bal = Expert_system.Properties.Resources.балалайка;
        Image bar = Expert_system.Properties.Resources.барабан1;
        Image ber = Expert_system.Properties.Resources.береста;
        Image brel = Expert_system.Properties.Resources.брелка;
        Image bub = Expert_system.Properties.Resources.бубен1;
        Image varg = Expert_system.Properties.Resources.варган;
        Image vol = Expert_system.Properties.Resources.волынка;
        Image gub_gar = Expert_system.Properties.Resources.губная_гармошка;
        Image gus = Expert_system.Properties.Resources.гусли;
        Image dud = Expert_system.Properties.Resources.дудка;
        Image zhal = Expert_system.Properties.Resources.жалейка;
        Image lira = Expert_system.Properties.Resources.лира;
        Image lil_tr = Expert_system.Properties.Resources.малая_труба;
        Image lil_fl = Expert_system.Properties.Resources.малая_флейта;
        Image lil_rog = Expert_system.Properties.Resources.малый_рог;
        Image okar = Expert_system.Properties.Resources.окарина;
        Image pogr = Expert_system.Properties.Resources.погремушка;
        Image rog = Expert_system.Properties.Resources.рог;
        Image svist = Expert_system.Properties.Resources.свистулька;
        Image scrip = Expert_system.Properties.Resources.скрипка;
        Image stir_deck = Expert_system.Properties.Resources.стиральная_доска;
        Image trub = Expert_system.Properties.Resources.труба;
        Image tulum = Expert_system.Properties.Resources.тулумбас;
        Image fleit_pan = Expert_system.Properties.Resources.флейта_пана;
        Image cimb = Expert_system.Properties.Resources.цимбала;

        //Звуки музыкальных инструментов
        SoundPlayer sp = new SoundPlayer();
        string arfa_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\арфа.wav";
        string bal_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\балалайка.wav";
        string bar_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\барабан.wav";
        string ber_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\береста.wav";
        string brel_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\брёлка.wav";
        string bub_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\бубен.wav";
        string varg_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\варган.wav";
        string vol_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\волынка.wav";
        string gub_gar_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\губная-гармоника.wav";
        string gus_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\гусли.wav";
        string dud_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\дудка.wav";
        string zhal_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\жалейка.wav";
        string lira_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\лира.wav";
        string lil_tr_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\малая труба.wav";
        string lil_fl_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\малая флейта.wav";
        string lil_rog_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\малый рог.wav";
        string okar_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\окарина.wav";
        string pogr_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\погремушка.wav";
        string rog_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\рог.wav";
        string svist_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\свистулька.wav";
        string scrip_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\скрипка.wav";
        string stir_deck_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\стиральная доска.wav";
        string trub_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\труба.wav";
        string tulum_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\тулумбас.wav";
        string fleit_pan_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\флейта пана.wav";
        string cimb_sound = @"C:\Users\User\OneDrive - ФГБОУ ВО УГАТУ\Рабочий стол\УНИВЕР\3 КУРС\5 СЕМЕСТР\Инженерия знаний\Лабораторная работа №3-4\melodies\цимбалы.wav";


        public Test_Form()
        {
            InitializeComponent();
            Illustr_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Text_txt.Text = q1;
            Var1_btn.Text = a1;
            Var2_btn.Text = a2;
            Var3_btn.Text = a3;
            Var4_btn.Text = a4;
            play_btn.Visible = false;
            stop_btn.Visible = false;
        }
        private void Again_btn_repeat_Click(object sender, EventArgs e)
        { //Кнопка "Начать заново"
            stop_btn_Click(sender, e);
            counter = 0;
            this.Hide();
            Main_Form main_form = new Main_Form();
            main_form.Show();
        }
        private void Var1_btn_Click(object sender, EventArgs e)
        {   //Кнопка первого варианта ответа
            answer_check = Var1_btn.Text;
            counter++;
            next_question(counter, answer_check);
        }
        private void Var2_btn_Click(object sender, EventArgs e)
        {   //Кнопка второго варианта ответа
            answer_check = Var2_btn.Text;
            counter++;
            next_question(counter, answer_check);
        }
        private void Var3_btn_Click(object sender, EventArgs e)
        {   //Кнопка третьего варианта ответа
            answer_check = Var3_btn.Text;
            counter++;
            next_question(counter, answer_check);
        }
        private void Var4_btn_Click(object sender, EventArgs e)
        {   //Кнопка четвертого варианта ответа
            answer_check = Var4_btn.Text;
            counter++;
            next_question(counter, answer_check);
        }
        public void next_question(int index, string answer)
        {
            Var1_btn.Visible = true;
            Var2_btn.Visible = true;
            Var3_btn.Visible = true;
            Var4_btn.Visible = true;
            play_btn.Visible = false;
            stop_btn.Visible = false;
            switch (index)
            {
                case 1:
                    if(answer == a1)
                    {
                        Text_txt.Text = q2;
                        Var1_btn.Text = a5;
                        Var2_btn.Text = a6;
                        Var3_btn.Text = a7;
                        Var4_btn.Visible = false;
                    }
                    else if(answer == a2)
                    {
                        Text_txt.Text = q14;
                        Var1_btn.Text = a22;
                        Var2_btn.Text = a23;
                        Var3_btn.Text = a24;
                        Var4_btn.Visible = false;
                    }
                    else if (answer == a3)
                    {
                        Text_txt.Text = q15;
                        Var1_btn.Text = a24;
                        Var4_btn.Text = a23;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a4)
                    {
                        Text_txt.Text = q17;
                        Var1_btn.Text = a33;
                        Var4_btn.Text = a34;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    break;
                case 2:
                    if(answer == a5)
                    {
                        Text_txt.Text = q3;
                        Var1_btn.Text = a8;
                        Var4_btn.Text = a9;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a6)
                    {
                        Text_txt.Text = q6;
                        Var1_btn.Text = a14;
                        Var4_btn.Text = a15;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a7)
                    {
                        Text_txt.Text = q8;
                        Var1_btn.Text = a18;
                        Var4_btn.Text = a19;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a22)
                    {
                        Text_txt.Text = q11;
                        Var1_btn.Text = a25;
                        Var4_btn.Text = a26;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a23 && Text_txt.Text == q14)
                    {
                        Text_txt.Text = q13;
                        Var1_btn.Text = a29;
                        Var4_btn.Text = a30;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a24 && Text_txt.Text == q14)
                    {
                        Text_txt.Text = "Это инструмент Цимбалы";
                        Illustr_pb.Image = cimb;
                        sp.SoundLocation = cimb_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a24 && Text_txt.Text == q15)
                    {
                        Text_txt.Text = q16;
                        Var1_btn.Text = a31;
                        Var4_btn.Text = a32;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a23 && Text_txt.Text == q15)
                    {
                        Text_txt.Text = "Это инструмент Бубен";
                        Illustr_pb.Image = bub;
                        sp.SoundLocation = bub_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a33)
                    {
                        Text_txt.Text = "Это инструмент Варган";
                        Illustr_pb.Image = varg;
                        sp.SoundLocation = varg_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a34)
                    {
                        Text_txt.Text = q18;
                        Var1_btn.Text = a35;
                        Var4_btn.Text = a34;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    break;
                case 3:
                    if (answer == a8)
                    {
                        Text_txt.Text = q4;
                        Var1_btn.Text = a10;
                        Var4_btn.Text = a11;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a9)
                    {
                        Text_txt.Text = q5;
                        Var1_btn.Text = a12;
                        Var4_btn.Text = a13;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a14)
                    {
                        Text_txt.Text = q7;
                        Var1_btn.Text = a16;
                        Var4_btn.Text = a17;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a15)
                    {
                        Text_txt.Text = "Это инструмент Брёлка";
                        Illustr_pb.Image = brel;
                        sp.SoundLocation = brel_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a18)
                    {
                        Text_txt.Text = q9;
                        Var1_btn.Text = a20;
                        Var4_btn.Text = a21;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a19)
                    {
                        Text_txt.Text = q10;
                        Var1_btn.Text = a20;
                        Var4_btn.Text = a21;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a25)
                    {
                        Text_txt.Text = q12;
                        Var1_btn.Text = a27;
                        Var4_btn.Text = a28;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a26)
                    {
                        Text_txt.Text = "Это инструмент Балалайка";
                        Illustr_pb.Image = bal;
                        sp.SoundLocation = bal_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a29)
                    {
                        Text_txt.Text = "Это инструмент Скрипка";
                        Illustr_pb.Image = scrip;
                        sp.SoundLocation = scrip_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a30)
                    {
                        Text_txt.Text = "Это инструмент Лира";
                        Illustr_pb.Image = lira;
                        sp.SoundLocation = lira_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a31)
                    {
                        Text_txt.Text = "Это инструмент Тулумбас";
                        Illustr_pb.Image = tulum;
                        sp.SoundLocation = tulum_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a32)
                    {
                        Text_txt.Text = "Это инструмент Барабан";
                        Illustr_pb.Image = bar;
                        sp.SoundLocation = bar_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a35)
                    {
                        Text_txt.Text = "Это инструмент Стиральная Доска";
                        Illustr_pb.Image = stir_deck;
                        sp.SoundLocation = stir_deck_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a34)
                    {
                        Text_txt.Text = q19;
                        Var1_btn.Text = a36;
                        Var4_btn.Text = a37;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    break;
                case 4:
                    if (answer == a10)
                    {
                        Text_txt.Text = "Это инструмент Дудка";
                        Illustr_pb.Image = dud;
                        sp.SoundLocation = dud_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a11)
                    {
                        Text_txt.Text = "Это инструмент Флейта Пана";
                        Illustr_pb.Image = fleit_pan;
                        sp.SoundLocation = fleit_pan_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a12)
                    {
                        Text_txt.Text = "Это инструмент Окарина";
                        Illustr_pb.Image = okar;
                        sp.SoundLocation = okar_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a13)
                    {
                        Text_txt.Text = "Это инструмент Малая Флейта";
                        Illustr_pb.Image = lil_fl;
                        sp.SoundLocation = lil_fl_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a16)
                    {
                        Text_txt.Text = "Это инструмент Жалейка";
                        Illustr_pb.Image = zhal;
                        sp.SoundLocation = zhal_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a17)
                    {
                        Text_txt.Text = "Это инструмент Волынка";
                        Illustr_pb.Image = vol;
                        sp.SoundLocation = vol_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a20 && Text_txt.Text == q9)
                    {
                        Text_txt.Text = "Это инструмент Труба";
                        Illustr_pb.Image = trub;
                        sp.SoundLocation = trub_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a21 && Text_txt.Text == q9)
                    {
                        Text_txt.Text = "Это инструмент Рог";
                        Illustr_pb.Image = rog;
                        sp.SoundLocation = rog_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a20 && Text_txt.Text == q10)
                    {
                        Text_txt.Text = "Это инструмент Малая труба";
                        Illustr_pb.Image = lil_tr;
                        sp.SoundLocation = lil_tr_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a21 && Text_txt.Text == q10)
                    {
                        Text_txt.Text = "Это инструмент Малый рог";
                        Illustr_pb.Image = lil_rog;
                        sp.SoundLocation = lil_rog_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a27)
                    {
                        Text_txt.Text = "Это инструмент Гусли";
                        Illustr_pb.Image = gus;
                        sp.SoundLocation = gus_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a28)
                    {
                        Text_txt.Text = "Это инструмент Арфа";
                        Illustr_pb.Image = arfa;
                        sp.SoundLocation = arfa_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a36)
                    {
                        Text_txt.Text = "Это инструмент Погремушка";
                        Illustr_pb.Image = pogr;
                        sp.SoundLocation = pogr_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a37)
                    {
                        Text_txt.Text = q20;
                        Var1_btn.Text = a6;
                        Var4_btn.Text = a40;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    break;
                case 5:
                    if (answer == a6)
                    {
                        Text_txt.Text = q21;
                        Var1_btn.Text = a38;
                        Var4_btn.Text = a39;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else if (answer == a40)
                    {
                        Text_txt.Text = "Это инструмент Свистулька";
                        Illustr_pb.Image = svist;
                        sp.SoundLocation = svist_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    break;
                case 6:
                    if (answer == a38)
                    {
                        Text_txt.Text = "Это инструмент Губная гармоника";
                        Illustr_pb.Image = gub_gar;
                        sp.SoundLocation = gub_gar_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    else
                    {
                        Text_txt.Text = "Это инструмент Береста";
                        Illustr_pb.Image = ber;
                        sp.SoundLocation = ber_sound;
                        play_btn.Visible = true;
                        stop_btn.Visible = true;
                        Var1_btn.Visible = false;
                        Var4_btn.Visible = false;
                        Var2_btn.Visible = false;
                        Var3_btn.Visible = false;
                    }
                    break;
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            sp.Play();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }
    }
}
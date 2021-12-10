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
        int counter = 0; //Индекс вопроса
        string answer_check; //Ответ на него

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
        private void play_btn_Click(object sender, EventArgs e)
        {   //Кнопка начала воспроизведения
            sp.Play();
        }
        private void stop_btn_Click(object sender, EventArgs e)
        {   //Кнопка остановки воспроизведения
            sp.Stop();
        }
        public void nq1(string question, string answer1, string answer2)
        {
            Text_txt.Text = question;
            Var1_btn.Text = answer1;
            Var4_btn.Text = answer2;
            Var2_btn.Visible = false;
            Var3_btn.Visible = false;
        }
        public void nq2(string mus_instr, Image img, string sound)
        {
            Text_txt.Text = "Это инструмент " + mus_instr;
            Illustr_pb.Image = img;
            sp.SoundLocation = sound;
            play_btn.Visible = true;
            stop_btn.Visible = true;
            Var1_btn.Visible = false;
            Var4_btn.Visible = false;
            Var2_btn.Visible = false;
            Var3_btn.Visible = false;
        }
        public void nq3(string question, string answer1, string answer2, string answer3)
        {
            Text_txt.Text = question;
            Var1_btn.Text = answer1;
            Var2_btn.Text = answer2;
            Var3_btn.Text = answer3;
            Var4_btn.Visible = false;
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
                    if (answer == a1)
                        nq3(q2, a5, a6, a7);
                    else if (answer == a2)
                        nq3(q14, a22, a23, a24);
                    else if (answer == a3)
                        nq1(q15, a24, a23);
                    else if (answer == a4)
                        nq1(q17, a33, a34);
                    break;
                case 2:
                    if (answer == a5)
                        nq1(q3, a8, a9);
                    else if (answer == a6)
                        nq1(q6, a14, a15);
                    else if (answer == a7)
                        nq1(q8, a18, a19);
                    else if (answer == a22)
                        nq1(q11, a25, a26);
                    else if (answer == a23 && Text_txt.Text == q14)
                        nq1(q13, a29, a30);
                    else if (answer == a24 && Text_txt.Text == q14)
                        nq2("Цимбалы", cimb, cimb_sound);
                    else if (answer == a24 && Text_txt.Text == q15)
                        nq1(q16, a31, a32);
                    else if (answer == a23 && Text_txt.Text == q15)
                        nq2("Бубен", bub, bub_sound);
                    else if (answer == a33)
                        nq2("Варган", varg, varg_sound);
                    else if (answer == a34)
                        nq1(q18, a35, a34);
                    break;
                case 3:
                    if (answer == a8)
                        nq1(q4, a10, a11);
                    else if (answer == a9)
                        nq1(q5, a12, a13);
                    else if (answer == a14)
                        nq1(q7, a16, a17);
                    else if (answer == a15)
                        nq2("Брёлка", brel, brel_sound);
                    else if (answer == a18)
                        nq1(q9, a20, a21);
                    else if (answer == a19)
                        nq1(q10, a20, a21);
                    else if (answer == a25)
                        nq1(q12, a27, a28);
                    else if (answer == a26)
                        nq2("Балалайка", bal, bal_sound);
                    else if (answer == a29)
                        nq2("Скрипка", scrip, scrip_sound);
                    else if (answer == a30)
                        nq2("Лира", lira, lira_sound);
                    else if (answer == a31)
                        nq2("Тулумбас", tulum, tulum_sound);
                    else if (answer == a32)
                        nq2("Барабан", bar, bar_sound);
                    else if (answer == a35)
                        nq2("Стиральная Доска", stir_deck, stir_deck_sound);
                    else if (answer == a34)
                        nq1(q19, a36, a37);
                    break;
                case 4:
                    if (answer == a10)
                        nq2("Дудка", dud, dud_sound);
                    else if (answer == a11)
                        nq2("Флейта Пана", fleit_pan, fleit_pan_sound);
                    else if (answer == a12)
                        nq2("Окарина", okar, okar_sound);
                    else if (answer == a13)
                        nq2("Малая Флейта", lil_fl, lil_fl_sound);
                    else if (answer == a16)
                        nq2("Жалейка", zhal, zhal_sound);
                    else if (answer == a17)
                        nq2("Волынка", vol, vol_sound);
                    else if (answer == a20 && Text_txt.Text == q9)
                        nq2("Труба", trub, trub_sound);
                    else if (answer == a21 && Text_txt.Text == q9)
                        nq2("Рог", rog, rog_sound);
                    else if (answer == a20 && Text_txt.Text == q10)
                        nq2("Малая труба", lil_tr, lil_tr_sound);
                    else if (answer == a21 && Text_txt.Text == q10)
                        nq2("Малый рог", lil_rog, lil_rog_sound);
                    else if (answer == a27)
                        nq2("Гусли", gus, gus_sound);

                    else if (answer == a28)
                        nq2("Арфа", arfa, arfa_sound);
                    else if (answer == a36)
                        nq2("Погремушка", pogr, pogr_sound);
                    else if (answer == a37)
                        nq1(q20, a6, a40);
                    break;
                case 5:
                    if (answer == a6)
                        nq1(q21, a38, a39);
                    else if (answer == a40)
                        nq2("Свистулька", svist, svist_sound);
                    break;
                case 6:
                    if (answer == a38)
                        nq2("Губная гармоника", gub_gar, gub_gar_sound);
                    else
                        nq2("Береста", ber, ber_sound);
                    break;
            }
        }
    }
}
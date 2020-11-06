using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class InputModel
    {
        #region Переменные для исходных данных 
        //Температура поступающего газа
        public double t0nach { get; set; }
        //Температура газа в конце периода 1
        public double t0I { get; set; }
        //Температура газа в конце периода 2
        public double t0II { get; set; }
        //Температура газов под сводной камеры
        public double t1nach { get; set; }
        //t1I
        public double t1I { get; set; }
        //Технологическая температура сушки
        public double t1II { get; set; }
        //Температура отходящего газа
        public double t2nach { get; set; }
        //t2I
        public double t2I { get; set; }
        //Температура сущильного агента, покидающего робочое пространство печи 
        public double t2II { get; set; }
        // Время работы сушильной печи 1
        public double tou1 { get; set; }
        // Время работы сушильной печи 2
        public double tou2 { get; set; }
        //Начальная влажность
        public double W1v { get; set; }
        //Конечная влажность
        public double W2v { get; set; }
        //Средняя по массе начальная температура материала
        public double tm1 { get; set; }
        //Средняя по массе конечная температура материала
        public double tm2 { get; set; }
        //Энтальпия воденого пара при 100 C
        public double in100 { get; set; }
        //Начальная энтальпия воды
        public double i1vl { get; set; }
        //i2
        public double i2 { get; set; }
        //Энтальрия воздуха
        public double i2v { get; set; }
        //хв
        public double xv { get; set; }
        //Valfa1
        public double Valfa1 { get; set; }
        //Масса приспособления
        public double Gnp { get; set; }
        //Температура массы приспособления в начеле
        public double tnp1 { get; set; }
        //Температура массы приспособления в конце
        public double tnp2 { get; set; }
        //Удельная теплоемкость материла приспособлений в интервале tпр2-tпр1
        public double cnp { get; set; }
        //Температура воздуха
        public double tv { get; set; }
        //Среднее температура 1
        public double tct1sh { get; set; }
        //Среднее температура 2
        public double tct2sh { get; set; }
        //Наружная поверность сушильной камеры
        public double F2 { get; set; }
        //Внутренная поверность сушильной камеры
        public double F1 { get; set; }
        //Период охлаждения
        public double ton1 { get; set; }
        //Толщина стенки в 2 кирпича (2х0,230)
        public double S { get; set; }
        //Сниженная  температура наружной поверхности стенок 
        public double tcnuz { get; set; }
        //Тольщина свода 1
        public double Svd1 { get; set; }
        //Тольщина свода 2
        public double Svd2 { get; set; }
        //Поверхность свода
        public double Fcv { get; set; }
        //Температура на гринице слоев
        public double tcl { get; set; }
        //Температура внутренной стенки 
        public double tcv1 { get; set; }
        //Температура внешной стенки
        public double tcv2 { get; set; }
        //Коэффицент теплопроводности первого материала
        public double l1 { get; set; }
        //Коэффицент теплопроводности второго материала
        public double l2 { get; set; }
        //Коэффицент теплопроводности третьего материала
        public double l3 { get; set; }
        //Поверхность двери сушильной камеры
        public double Fdv { get; set; }
        //Тольщина двери сушильной камеры
        public double Sdv { get; set; }
        //Коэффицент теплопроводности четвертого материала
        public double l4 { get; set; }
        //Средняя теплоемкость
        public double c { get; set; }
        //Потери теплоты последствием химического недожога
        public double q3 { get; set; }

        // Теплота сгорания топлива
        public double Qnr { get; set; }
        //Сечение топки

        public double ctop { get; set; }
        //Длина
        public double L { get; set; }
        #endregion
        #region Переменные для формул 

        // Химическая теплота топлива 
        public double Qx { get; set; }
        //Средное значения температуры за третий период сушки
        public double t2 { get; set; }
        //Средное значения температуры за второй период сушки
        public double t1 { get; set; }
        //Средное значения температуры за первый период сушки
        public double t0 { get; set; }
        //Влажность материала в начеле сушки
        public double W1c { get; set; }
        //Влажность материала в конце сушки
        public double W2c { get; set; }
        //Температура массы сущимого материала в конце
        public double tmm2 { get; set; }
        // Расчет статьи
        public double Q1 { get; set; }
        //Разбавление первычных продуктов сгорания воздухом в количестве xв
        public double q2 { get; set; }
        //Потери теплоты с уходящими газами
        public double Q2 { get; set; }
        //Химический недожог
        public double Q3 { get; set; }
        //Потери теплоты на нагреве приспомобленний и теплопроводностью через стенки
        public double Q5np { get; set; }
        //Средное значение температуры t0- и t1-
        public double tct1 { get; set; }
        //Средное значение температуры t1- и t2-
        public double tct2 { get; set; }
        //Плотность телового потока
        public double q5t { get; set; }
        //Толщину стенок камеры
        public double Scm { get; set; }
        //Средняя поверхность стеной
        public double F22 { get; set; }
        //Потери теплоты теплопроводностью через стенку сушильной печи
        public double Q5tct { get; set; }
        //Потери теплоты через свод 
        public double Q5tcv { get; set; }
        //Потери теплоты через двери сушильной камеры
        public double Q5tdv { get; set; }
        //Общие потери теплоты теплопроводностью
        public double Q5trp { get; set; }
        //Покрытие потерь топлоты теплопроводностью 
        public double Q5rp { get; set; }
        //Потери теплоты топкой 
        public double Q5top { get; set; }
        //Аккумуляция теплоты стенками рабочего пространва
        public double tctnach { get; set; }
        //Средние изменинея температур внутренней поверхности стенок
        public double crtct1 { get; set; }
        //Температура за время τ2
        public double ttst2 { get; set; }
        //Температура нагрева стенки 
        public double tctnag { get; set; }
        //Температура стенки охложденная
        public double tctoxl { get; set; }
        //Время τ'
        public double tt1 { get; set; }
        //Время τ''
        public double tt2 { get; set; }
        //Сумма внутренней поверхности стенки
        public double Fcm { get; set; }
        //Аккумуляция теплоты стенки печи при циклических калибаний температуры
        public double Qv { get; set; }
        //Расход топлива
        public double B { get; set; }
        //Коэффициент полезного дейстаия 
        public double n { get; set; }
        //Расход теплоты на 1 кг исправленной влаги
        public double qisp { get; set; }
        //Тепловое напряжение сводного объема топки
        public double qob { get; set; }
        //Объем одной  топки
        public double Vtop { get; set; }
        //Масса исправленной из изделий влаги
        public double Gvl { get; set; }
        //Топливо расходуется в секунду
        public double tsk { get; set; }
        //Всего типливо
        public double topl { get; set; }
        //Коэффицент полезного действия
        public double kpd { get; set; }
        #endregion
        public void Calc()
        {

            Qx = Math.Round(Qnr * (tou1 + tou2), 2);
            t2 = Math.Round((t2nach + (t2I - t2nach) * (1 / (0.7 + 1))) * (tou1 / (tou1 + tou2)) + 0.5 * (t2I + t2II) * (tou1 / (tou1 + tou2)), 1);
            t1 = Math.Round((t1nach + (t1I - t1nach) * (1 / (0.7 + 1))) * (tou1 / (tou1 + tou2)) + 0.5 * (t1I + t1II) * (tou1 / (tou1 + tou2)), 0);
            t0 = Math.Round((t0nach + (t0I - t0nach) * (1 / (0.7 + 1))) * (tou1 / (tou1 + tou2)) + 0.5 * (t0I + t0II) * (tou1 / (tou1 + tou2)), 0);
            W1c = Math.Round(W1v / (1 - 0.01 * W1v), 1);
            W2c = Math.Round(W2v / (1 - 0.01 * W2v), 1);
            tmm2 = Math.Round(0.5 * (t1II + t2II) - 100, 1);
            Q1 = Math.Round(((0.84 + (0.01 * (W2c * 4.19))) * (tm1 - tm2) + 0.01 * (W1c - W2c) * (in100 - i1vl + 2.09 * t2 - 100)) * 10000, 1);
            q2 = Math.Round((i2 + xv * (i2v - 25)) * Valfa1, 1);
            Q2 = Math.Round(q2 * (tou1 + tou2), 0);
            Q3 = Math.Round(0.02 * Qnr * (tou1 + tou2), 0);
            Q5np = Math.Round(cnp * (tnp2 - tnp1) * Gnp, 0);
            tct1 = Math.Round((tou1 / (tou1 + tou2)) * (t0 + t1), 0);
            tct2 = Math.Round((tou1 / (tou1 + tou2)) * (t2 + t1), 0);
            q5t = Math.Round((W1v + 0.06 * tct2) * (tct2 - tv), 2);
            Scm = Math.Round((0.509 * (tct1sh - tct2sh)) / (0.8 * 700), 3);
            F22 = Math.Round((tou1 / (tou1 + tou2)) * (F2 + F1), 1);
            Q5tct = Math.Round((0.0001 * (0.509 / S) * (tct1sh - tcnuz) * F22 * (tou1 + tou2)), 1);
            Q5tcv = Math.Round(0.001 * (((tcv1 - tcv2) * Fcv * (tou1 + tou2)) / ((Svd1 / l1) + (Svd2 / l2))), 1);
            Q5tdv = Math.Round(0.001 * (((tcv1 - tcv2) * Fdv * (tou1 + tou2)) / (Sdv / l3)), 1);
            Q5trp = Math.Round(Q5tdv + Q5tcv + Q5tct, 1);
            Q5rp = Math.Round(0.41 + Q5trp, 1);
            Q5top = Math.Round((1 - 0.8) * (tou1 + tou2) * Qnr, 1);
            tctnach = Math.Round(0.5 * (0.5 * (tv + t0nach) + t1nach), 1);
            crtct1 = Math.Round(0.7 * ((0.5 * (t1I + t0I)) - tctnach), 1);
            ttst2 = Math.Round(0.5 * (t0II + (0.5 * (t1II + t0II))) - tctnach, 1);
            tctnag = Math.Round(((tou1 * crtct1 + tou2 * ttst2) / (tou1 + tou2)),1);
            tctoxl = Math.Round(0.8*((0.5*(t1II+t0II))-tctnach),1);
            tt1 = Math.Round((tou1 + tou2)*(Math.Pow((tctnag / ttst2),2)), 1);
            tt2 = Math.Round(ton1*(Math.Pow((tctoxl / ttst2), 2)), 1);
            Fcm = Math.Round(F1+Fcv+Fdv,2);
            Qv = Math.Round(1.7725*Math.Sqrt(l4*c*1300)*Math.Sqrt(tt1*tt2)*((ttst2*Fcm)/((Math.Sqrt(tt1)+Math.Sqrt(tt2))*1000)), 1);
            B = Math.Round((Q1+ Q5rp+2.19)/((Qnr-q2-0.5-0.2)*Qnr)*Math.Pow(10,4), 1);
            n = Math.Round(Q1/(B*Qnr),2);
            qisp = Math.Round(B*Qnr/Gvl,2);
            qob = Math.Round(((0.01809*Qnr)/(2*Vtop))*1000, 2);
            Vtop = Math.Round(L * ctop,2);
            Gvl = Math.Round(100*(W1c-W2c),2);
            tsk = Math.Round(B/3600,6);
            topl = Math.Round(tsk * (tou1 + tou2), 4);
            kpd = Math.Round((Q1/(Qnr* topl))*100,2);

        }
        public static double[] ArrayX;
        public static double[] ArrayY;
        public void Graph()
        {
            int razm = Convert.ToInt32(Math.Round(topl + 0.5)) + 2;
            ArrayX = new double[razm];
            ArrayY = new double[razm];

            for (int i = 0; i < razm - 1; i++)
            {
                if (topl < i)
                {
                    ArrayX[i] = topl;
                    ArrayY[i] = Math.Round(kpd * topl, 2);
                    ArrayX[i + 1] = i;
                    ArrayY[i + 1] = Math.Round(kpd * i, 2);
                }
                else
                {
                    ArrayX[i] = i;
                    ArrayY[i] = Math.Round(kpd * i, 2);
                }
            }
        }
        public void Calculate()
        {
            Calc();
            Graph();
        }
        public ResultModel Rachet()
        {
            return new ResultModel
            {
                Qx = (double)Qx,
                t2 = (double)t2,
                t1 = (double)t1,
                t0 = (double)t0,
                W1c = (double)W1c,
                W2c = (double)W2c,
                tmm2 = (double)tmm2,
                Q1 = (double)Q1,
                q2 = (double)q2,
                Q2 = (double)Q2,
                Q3 = (double)Q3,
                Q5np = (double)Q5np,
                tct1 = (double)tct1,
                tct2 = (double)tct1,
                q5t = (double)q5t,
                Scm = (double)Scm,
                F22 = (double)F22,
                Q5tct = (double)Q5tct,
                Q5tcv = (double)Q5tcv,
                Q5tdv = (double)Q5tdv,
                Q5trp = (double)Q5trp,
                Q5rp = (double)Q5rp,
                Q5top = (double)Q5top,
                tctnach = (double)tctnach,
                crtct1 = (double)crtct1,
                ttst2 = (double)ttst2,
                tctnag = (double)tctnag,
                tctoxl = (double)tctoxl,
                tt1 = (double)tt1,
                tt2 = (double)tt2,
                Fcm = (double)Fcm,
                Qv = (double)Qv,
                B = (double)B,
                n = (double)n,
                qisp = (double)qisp,
                qob = (double)qob,
                Vtop = (double)Vtop,
                Gvl = (double)Gvl,
                tsk = (double)tsk,
                topl = (double)topl,
                kpd = (double)kpd,
               
            };
        }
    }

}

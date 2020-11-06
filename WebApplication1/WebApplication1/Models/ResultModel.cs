using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ResultModel
    {
       
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
    }
}

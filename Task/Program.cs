using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Упр 1");
            //List<string> file_lines = File.ReadAllLines("D:\\Distrib\\Adel\\Прога\\Lesson_2.12\\Task\\Students.txt").ToList();
            //List<Student> students = new List<Student>();
            //foreach (var file_line in file_lines)
            //{
                //var split_line = file_line.Split(new[] {","}, StringSplitOptions.None);
                //string name = split_line[0];
                //int group = Convert.ToInt32(split_line[1]);
                //students.Add(new Student(name, group));
            //}
            //List<Student> group321 = new List<Student>();
            //List<Student> group322 = new List<Student>();

            //foreach (Student student in students)
            //{
                //switch(student.Group)
                //{
                    //case 321:
                        //group321.Add(student);
                        //break;
                    //case 322:
                        //group322.Add(student);
                        //break;
                    //default:
                        //Console.WriteLine("Чужак");
                        //break;
                //}
            //}

            //List<List<Student>> PM = new List<List<Student>>() {group321, group322};
            //Event event1 = new Event("Театральная постановка", new DateTime(2023, 11, 11), 321, 1);
            //event1.Select(PM);
            //event1.Print();
            //Event event2 = new Event("Кино", new DateTime(2023, 11, 11), 322, 2);
            //event2.Select(PM);
            //event2.Print();
            //Event event3 = new Event("МИМИ", new DateTime(2023, 11, 11), 321, 1);
            //event3.Select(PM);
            //event3.Print();
            //Event event4 = new Event("ДП", new DateTime(2023, 11, 11), 322, 1);
            //event4.Select(PM);
            //event4.Print();
            //Event event5 = new Event("Студбатл", new DateTime(2023, 11, 11), 322, 2);
            //event5.Select(PM);
            //event5.Print();
            //Console.WriteLine();


            Console.WriteLine("Упр 2");
            Person person1 = new Person("Адель", "Футбол");
            Person person2 = new Person("Динар", "Компьютерные игры");
            Person person3 = new Person("Максим", "Автомобили");

            // Возможные события
            string[] events = { "Финал ЛЧ", "Выход GTA6", "Премьера нового автомобиля" };

            // Предложение выбрать событие
            Console.WriteLine("Выберите одно из следующих событий:");
            for (int i = 0; i < events.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + events[i]);
            }

            // Получение выбранного события от пользователя
            Console.WriteLine("Введите номер события:");
            int x = Convert.ToInt32(Console.ReadLine());

            switch(x)
            {
                case 1:
                    Console.WriteLine(person1.Name + " интересуется событием!");
                    break;
                case 2:
                    Console.WriteLine(person2.Name + " интересуется событием!");
                    break;
                case 3:
                    Console.WriteLine(person3.Name + " интересуется событием!");
                    break;
                default:
                    Console.WriteLine("Никто не интересуется этим событием");
                    break;
            }
            Console.ReadKey();
         
        }
    }
}

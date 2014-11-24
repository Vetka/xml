using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Reflection;

namespace ConsoleApplication1
{
    
    public class Student
    {
        [XmlAttribute("Name")]
        public string snp;
        [XmlElement("Course")]
        public int course;
        [XmlElement("Specialty")]
        public string specialty;
    }    

    class Program
    {
       static void Main(string[] args)
        {
            Student one = new Student();
            one.snp = "Петров Игорь Степанович";
            one.course = 3;
            one.specialty = "Машинист погрузочной машины";
            Student two = new Student();
            two.snp = "Маркина Светлана Анатольевна";
            two.course = 1;
            two.specialty = "Социальный работник";
            Student three = new Student();
            three.snp = "Журавлев Николай Константинович";
            three.course = 4;
            three.specialty = "Плавка металла";
            Student four = new Student();
            four.snp = "Сидоренко Павел Григорьевич";
            four.course = 3;
            four.specialty = "Повар - кондитер";
            Student five = new Student();
            five.snp = "Тимошин Евгений Викторович";
            five.course = 3;
            five.specialty = "Машинист погрузочной машины";
            Student six = new Student();
            six.snp = "Шишкина Наталья Леонидовна";
            six.course = 5;
            six.specialty  = "Конструирование и моделирование одежды";
            Student seven = new Student();
            seven.snp = "Зубков Степан Александрович";
            seven.course = 5;
            seven.specialty = "Обработка металлов давлением";
            Student eight = new Student();
            eight.snp = "Травкина Елена Дмитриевна";
            eight.course = 4;
            eight.specialty = "Конструирование и моделирование одежды";
            Student nine = new Student();
            nine.snp = "Ситникова Татьяна Николаевна";
            nine.course = 1;
            nine.specialty = "Повар - кондитер";
            Student ten = new Student();
            ten.snp = "Лапшин Игорь Иванович";
            ten.course = 1;
            ten.specialty = "Обработка металлов давлением";
            Student[] stud = new Student[] { one, two , three, four, five, six, seven, eight, nine, ten };
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine("Студент: " + stud[i].snp +  " Курс: " + stud[i].course + " Специализация: " + stud[i].specialty);
            }
            XmlSerializer ser = new XmlSerializer(typeof(Student[]));
            TextWriter writer = new StreamWriter("SaveFile.xml");
            ser.Serialize(writer,stud);
            writer.Close();
            Console.ReadKey();

            
        }
    }
}

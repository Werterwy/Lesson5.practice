using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.practice
{

/*    3.	Реализовать несколько методов или классов с методами и вызвать один метод из другого.
        В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.*/
    class ExceptionDemo
    {
        public void MethodWithException()
        {
            // Генерируем исключение
            throw new ApplicationException("Это пользовательское исключение");
        }
    }

    class AnotherClass
    {
        public void CallerMethod()
        {
            try
            {
                ExceptionDemo demo = new ExceptionDemo();
                demo.MethodWithException();
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Исключение перехвачено в CallerMethod: " + ex.Message);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            AnotherClass anotherClass = new AnotherClass();

            try
            {
                anotherClass.CallerMethod();
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Исключение перехвачено в Main: " + ex.Message);
            }
        }
    }
}

using System;


namespace name_year
{
    class Program
    {
        static void Main(string[] args)
        {
            char a1;
            var datetime = DateTime.Now;
            bool cycle;
            cycle = false;
            Int32 n=0,m=0,y=0,i,j,k,dibil=0;

            String numb="", month="", year="", complexdate,datenow,complexdate1,numb1,month1,year1,datenow1,name="";
            Console.WriteLine("");
            Console.WriteLine("________    _____      __    __    _____    ______   ______");
            Console.WriteLine("||    ||    ||  \\\\     ||\\   ||    ||  \\\\   ||         ||");
            Console.WriteLine("||    ||    ||__//     || \\  ||    ||__//   ||____     ||");
            Console.WriteLine("||    ||    ||         ||  \\ ||    ||  \\\\   ||         ||");
            Console.WriteLine("||    ||    ||         ||   \\||    ||__//   ||____     ||");
            Console.WriteLine();
            Console.WriteLine("Введите свой никнейм");
            Console.WriteLine();
             name =Convert.ToString( Console.ReadLine());
            if (name == ""||name==" ")
            {
                name = "Аноним";
            }
                
            Console.WriteLine();
            Console.WriteLine("Введите свою дату рождения");
            Console.WriteLine();
            Console.WriteLine("Как вам будет это удобно сделать?");
            if (cycle == false)
            {
                for (; ; )
                {   if (dibil == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Давай лучше по инструкции");
                        a1 = '1';
                    }
                    else
                    {
                        Console.WriteLine("Нажмите 1 если отдельно по инструкции(для глупеньких)");
                        Console.WriteLine("Нажмите 2 если вы уже смешарик , и знаете что - кого");

                        a1 = Convert.ToChar(Console.ReadLine());
                    }
                    
                    if (a1 == '1')
                    {
                        Console.WriteLine("Число");
                        numb = Console.ReadLine().Trim();
                        cycle = true;
                        if (numb[0] == 0)
                        {
                            numb = numb.Substring(1, numb.Length);
                        }
                        bool success = Int32.TryParse(numb, out n);
                        if (success == true)
                            n = Convert.ToInt32(numb);
                        else
                        {
                            Console.WriteLine("Введите коректно дату");
                            cycle = false;
                            
                        }
                            if (cycle == true)
                        {
                            Console.WriteLine("Месяц");
                            month = Console.ReadLine().Trim();
                            if (month[0] == 0)
                            {
                                month = month.Substring(1, month.Length);
                            }
                             success = Int32.TryParse(month, out m);
                            if (success == true)
                                m = Convert.ToInt32(month);
                            else
                            {
                                Console.WriteLine("Введите коректно дату");
                                cycle = false;

                            }
                        }
                            if (cycle==true)
                        {
                            Console.WriteLine("Год");
                            year = Console.ReadLine().Trim();
                            success = Int32.TryParse(year, out y);
                            if (success == true)
                                y = Convert.ToInt32(year);
                            else
                            {
                                Console.WriteLine("Введите коректно дату");
                                cycle = false;

                            }
                        }
                        if (cycle == true)
                        { 
                        if (y < 0)
                        {
                            Console.WriteLine("Это не сайты для взрослых чтобы ты тут свой возраст завышал");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            cycle = false;
                        }
                       else if (y > 2020)
                        {
                            Console.WriteLine("Вы еще не родились");
                            break;
                        }
                       else if (m > 12 || m < 1)
                        {
                            cycle = false;
                            Console.WriteLine("Неправельно введен месяц");
                            Console.WriteLine("Попробуй еще раз");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        
                       else if (n > 31 || n < 1)
                        {
                            cycle = false;
                            Console.WriteLine("Неправельно введен день");
                            Console.WriteLine("Попробуй еще раз");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        if ((m == 4 || m == 9 || m == 6 || m == 11) && n == 31)
                        {
                            cycle = false;
                            Console.WriteLine("В этом месяце только 30 дней");
                            Console.WriteLine("Попробуй еще раз");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        if (m == 2 && (n == 30 || n == 31))
                        {
                            cycle = false;
                            Console.WriteLine("В этом месяце максимум 29 дней");
                            Console.WriteLine("Попробуй еще раз");
                            Console.WriteLine("");
                            Console.WriteLine("");

                        }
                        
                        if (m == 2 && n == 29 && y % 4 != 0)
                        {
                            cycle = false;
                            Console.WriteLine("29 дней только в весакосный год");
                            Console.WriteLine("Попробуй еще раз");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }


                        }

                    }
                 else if (a1 == '2')
                   {
                        k = 0;
                        j = 1;
                        i = 0;
                        Console.WriteLine("Введите в соотвествии с примером День.Месяц.Год");
                        complexdate = Console.ReadLine().Trim()+'.';
                        cycle = true;
                        complexdate1 = complexdate;
                        
                        

                        while (complexdate[k] != '.')
                        {
                            i++;
                            k++;
                            complexdate1 = complexdate1.Substring(1, complexdate1.Length - 1);
                        }
                          complexdate1 = complexdate1.Substring(1);
                        
                        numb = complexdate.Substring(0, i);
                        j = i + j;
                        i = 0;
                        k=k+1;
                         while (complexdate[k] != '.')
                         {
                             i++; k++; 
                            complexdate1 = complexdate1.Substring(1, complexdate1.Length-1);
                         }
                       
                        complexdate1 = complexdate1.Substring(1);
                         month = complexdate.Substring(j, i);
                         j = j + i+1;
                         i = 0;
                        
                        k++;
                        
                         while (complexdate[k] != '.')
                         {
                             i++;k++; 
                            complexdate1 = complexdate1.Substring(1);
                         }
                        
                        complexdate1 = complexdate1.Substring(1);
                        
                        year = complexdate.Substring(j, i);
                        
                        if (numb[0] == 0)
                             n = Convert.ToInt32(numb.Substring(1, 1));
                         else
                             n = Convert.ToInt32(numb);
                        
                        if (month[0] == 0)
                             m = Convert.ToInt32(month.Substring(1, 1));
                         else
                             m = Convert.ToInt32(month);
                        y = Convert.ToInt32(year);
                        if(y<0)
                        {
                            Console.WriteLine("Это не сайты для взрослых чтобы ты тут свой возраст завышал");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            dibil++;
                            cycle = false;
                        }
                       else if (y > 2020)
                        {
                            Console.WriteLine(name," ,вы еще не родились");
                            break;
                        }
                        else if (m > 12 || m < 1)
                        {
                            cycle = false;
                            Console.WriteLine("Неправельно введен месяц");
                            Console.WriteLine("Попробуй еще раз");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            dibil++;
                        }

                        else if (n > 31 || n < 1)
                        {
                            cycle = false;
                            Console.WriteLine("Неправельно введен день");
                            Console.WriteLine("Попробуй еще раз");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            dibil++;
                        }
                        if ((m == 4 || m == 9 || m == 6 || m == 11) && n == 31)
                        {
                            cycle = false;
                            Console.WriteLine("В этом месяце только 30 дней");
                            Console.WriteLine("Попробуй еще раз");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            dibil++;
                        }
                        if (m == 2 && (n == 30 || n == 31))
                        {
                            cycle = false;
                            Console.WriteLine("В этом месяце максимум 29 дней");
                            Console.WriteLine("Попробуй еще раз");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            dibil++;

                        }

                        if (m == 2 && n == 29 && y % 4 != 0)
                        {
                            cycle = false;
                            Console.WriteLine("29 дней только в весакосный год");
                            Console.WriteLine("Попробуй еще раз");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            dibil++;
                        }
                        

                    }
                    else
                    {

                        Console.WriteLine("Патау что-ли нужно нажать 1 или 2 , начните заново");
                        Console.WriteLine("");
                        Console.WriteLine("");

                    }
                    if (cycle == true)
                    {   
                        datenow = Convert.ToString(datetime);
                        datenow1 = datenow;
                        i = 0; j = 1; k = 0;
                        
                        while (datenow[k] != '.')
                        {
                            
                            i++;
                            k++;
                            datenow1 = datenow1.Substring(1);
                        }
                        
                        datenow1 = datenow1.Substring(1);

                        numb1 = datenow.Substring(0, i);
                        
                        j = i + j;
                        i = 0;
                        k = k + 1;
                        while (datenow[k] != '.')
                        {
                            i++; k++;
                            datenow1 = datenow1.Substring(1, datenow1.Length - 1);
                        }

                        datenow1 = datenow1.Substring(1);
                        month1 = datenow.Substring(j, i);
                        j = j + i + 1;
                        i = 0;

                        k++;

                        while (datenow[k] != ' ')
                        {
                            i++; k++;
                            datenow1 = datenow1.Substring(1);
                        }

                        datenow1 = datenow1.Substring(1);
                        
                        year1 = datenow.Substring(j, i);
                        if ((Convert.ToInt32(year1) == y && Convert.ToInt32(month1) < m) || (Convert.ToInt32(year1) == y && Convert.ToInt32(month1) == m && Convert.ToInt32(numb1) < n))
                            Console.WriteLine(name," Вы еще не роделись");
                      else  if (m<Convert.ToInt32(month1)||(m==Convert.ToInt32(month1)&&n<Convert.ToInt32(numb1)))
                        {
                            Console.WriteLine(name);
                            Console.WriteLine("Вам ");
                            Console.Write(Convert.ToInt32(year1) - y);
                            Console.Write(" лет");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine( name);
                            Console.WriteLine("Вам ");
                            Console.Write(Convert.ToInt32(year1) - y-1);
                            Console.Write(" лет");
                            Console.WriteLine();
                        }
                        if (m == 3 && n >= 21 || m == 4 && n <= 20)
                            Console.WriteLine("Вы Овен");
                        if (m == 4 && n >= 21 || m == 5 && n <= 21)
                            Console.WriteLine("Вы Телец");
                        if (m == 5 && n >= 22 || m == 6 && n <= 21)
                            Console.WriteLine("Вы Близнецы");
                        if (m == 6 && n >= 22 || m == 7 && n <= 22)
                            Console.WriteLine("Вы Рак");
                        if (m ==7  && n >= 23 || m == 8 && n <= 23)
                            Console.WriteLine("Вы Лев");
                        if (m == 8 && n >= 24 || m == 9 && n <= 22)
                            Console.WriteLine("Вы Дева");
                        if (m == 9 && n >= 23 || m == 10 && n <= 22)
                            Console.WriteLine("Вы Весы");
                        if (m == 10 && n >= 23 || m == 11 && n <= 22)
                            Console.WriteLine("Вы Скорпион");
                        if (m == 11 && n >= 22 || m == 12 && n <= 21)
                            Console.WriteLine("Вы Стрелец");
                        if (m == 12 && n >= 22 || m == 1 && n <= 20)
                            Console.WriteLine("Вы Козерог");
                        if (m == 1 && n >= 21 || m == 2 && n <= 19)
                            Console.WriteLine("Вы Водолей");
                        if (m == 2 && n >= 20 || m == 3 && n <= 20)
                            Console.WriteLine("Вы Рыбы");
                        break;

                    }


                }
            }
             
        }
    }
}

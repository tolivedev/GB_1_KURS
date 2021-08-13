using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Linq;

namespace Lessons._06_Lesson
{
    class task01
    {
        public task01()
        {
            prc = new List<Process>(Process.GetProcesses());
            //Console.WriteLine(@"
            //                    Отобразить список процессов - 1
            //                    Найти процесс - 2
            //                    Завершить процесс - 3");
            ControlProccesses();
        }

        List<Process> prc;

        public void ControlProccesses()
        {
            bool flag=false;
            do
            {
                Console.WriteLine(@"
                                Выберите действие

                                Отобразить список процессов - 1
                                Найти процесс - 2
                                Завершить процесс - 3
                                Завершить диспетчер - 4"+ "\n");
                int switch_on = Convert.ToInt32(Console.ReadLine());
                switch (switch_on)
                {
                    case 1:
                        {
                            Console.WriteLine("Отобразить весь лист процессов");
                            ShowListProcess(prc);

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nВведите название или Id\n");
                            if (prc != null)
                            {
                                ShowListProcess(FilterOfProcNameOrID(prc));
                            }
                            else
                            {
                                ShowListProcess(FilterOfProcNameOrID(new List<Process>(Process.GetProcesses())));
                            }
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("\nВведите название или Id\n");
                            if (prc != null)
                            {
                                TaskKill(FilterOfProcNameOrID(prc));
                            }
                            else
                            {
                                TaskKill(FilterOfProcNameOrID(new List<Process>(Process.GetProcesses())));

                            }
                            flag = true;

                            break;
                        }
                    case 4:
                        {
                            flag = true;

                            break;
                        }
                    default: { Console.WriteLine("Выберите действие от 1 до 4: "); break; }
                }
                //ShowListProcess(prc);

                //FilterOfProcNameOrID(prc);

            } while (flag != true);



        }

        public List<Process> FilterOfProcNameOrID(List<Process> lsP)
        {
            List<Process> prc = new List<Process>();
            string nameOrId = Console.ReadLine();

            if (int.TryParse(nameOrId, out int id))
            {
                prc.Add(Process.GetProcessById(id));

            }
            else
            {
                prc.AddRange(Process.GetProcessesByName(nameOrId));
            }
            return prc;
        }

        public void TaskKill(List<Process> enumProc)
        {

            foreach (var item in enumProc)
            {
                item.Kill();
            }
        }

        public static void ShowListProcess(List<Process> prcs)
        {

            Console.WriteLine(new string('=', 100) + "\nID\tProcessName\n");

            var query = from Process p in prcs
                        orderby p.ProcessName
                        select p;
            foreach (Process item in query)
            {
                Console.WriteLine($"{item.Id.ToString()}\t{item.ProcessName}");
            }
            Console.WriteLine("Всего процессов: " + prcs.Count);
            //Thread.Sleep(2000);
        }
    }
}
